Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Friend Class OptionsForm

    Public Enum OnLock
        DoNothing = 0
        ResetTimer = 1
        PauseTimer = 2
    End Enum

    <DllImport("user32", CharSet:=CharSet.Auto)>
    Private Shared Function GetActiveWindow() As Integer
    End Function

    <DllImport("user32", CharSet:=CharSet.Auto)>
    Private Shared Function SetActiveWindow(ByVal hwnd As Integer) As Integer
    End Function

    Private Const RUN_AT_STARTUP_KEY As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"

    Private _workStarted As DateTime
    Private _nextBreak As DateTime
    Private _nextWarning As DateTime
    Private _secondsLeft As Int64 = 0
    Private _onBreak As Boolean = False
    Private _skippedBreaks As Int32 = 0
    Private _childForms As Generic.List(Of BreakForm)
    Private WithEvents _warningForm As WarningForm

    Public Sub New(ByVal culture As String)
        If Not String.IsNullOrWhiteSpace(culture) Then
            Try
                Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo(culture)
            Catch ex As Exception
            End Try
        End If
        InitializeComponent()
        LoadOptions()
        EndBreak()
        tmrBreak.Start()
        AddHandler Microsoft.Win32.SystemEvents.SessionSwitch, AddressOf SessionSwitch
    End Sub

    Private Sub SessionSwitch(ByVal sender As Object, ByVal e As Microsoft.Win32.SessionSwitchEventArgs)
        If e.Reason = SessionSwitchReason.SessionLock Then
            Select Case My.Settings.OnLock
                Case OnLock.PauseTimer
                    tmrBreak.Enabled = False
                    _secondsLeft = DateDiff(DateInterval.Second, _nextBreak, Now())
                Case OnLock.ResetTimer
                    tmrBreak.Enabled = False
            End Select
        ElseIf e.Reason = SessionSwitchReason.SessionUnlock Then
            Select Case My.Settings.OnLock
                Case OnLock.PauseTimer
                    tmrBreak.Enabled = True
                    _workStarted = DateTime.Now
                    _nextBreak = DateAdd(DateInterval.Minute, _secondsLeft, _workStarted)
                    _nextWarning = DateAdd(DateInterval.Second, -1 * My.Settings.WarningTime, _nextBreak)
                Case OnLock.ResetTimer
                    tmrBreak.Enabled = True
                    EndBreak()
            End Select
        End If
    End Sub

    Private Sub icoNotify_BalloonTipClosed(sender As Object, e As System.EventArgs) Handles icoNotify.BalloonTipClosed
        EndBreak()
    End Sub

    Private Sub icoNotify_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles icoNotify.MouseDoubleClick
        ShowForm()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        SaveOptions()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        HideForm()
    End Sub

    Private Sub OptionsForm_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub BreakForm_FormClosed(sender As Object, e As System.EventArgs)
        EndBreak()
    End Sub

    Private Sub LoadOptions()
        Dim font As New FontConverter
        chkRunAtStartup.Checked = My.Settings.RunAtStartup
        chkShowOptionsOnLaunch.Checked = My.Settings.ShowOptionsOnLaunch
        nudBreakTime.Value = My.Settings.BreakTime
        nudBreakDelay.Value = My.Settings.BreakDelay
        nudWorkTime.Value = My.Settings.WorkTime
        chkWarningTime.Checked = My.Settings.WarningTimerEnabled
        nudWarningTime.Value = My.Settings.WarningTime
        txtMessage.Text = My.Settings.Message
        picForeColor.BackColor = My.Settings.ForeColor
        picBackColor.BackColor = My.Settings.BackColor
        lblPreview.BackColor = picBackColor.BackColor
        lblPreview.ForeColor = picForeColor.BackColor
        chkBeepOnBreakEnd.Checked = My.Settings.BeepAtBreakEnd
        lnkFont.Text = font.ConvertToString(My.Settings.Font)
        nudOpacity.Value = My.Settings.Opacity
        radOnLockDoNothing.Checked = (My.Settings.OnLock = OnLock.DoNothing)
        radOnLockPause.Checked = (My.Settings.OnLock = OnLock.PauseTimer)
        radOnLockReset.Checked = (My.Settings.OnLock = OnLock.ResetTimer)
    End Sub

    Private Sub SaveOptions()
        Dim font As New FontConverter
        tmrBreak.Stop()
        My.Settings.RunAtStartup = chkRunAtStartup.Checked
        My.Settings.ShowOptionsOnLaunch = chkShowOptionsOnLaunch.Checked
        My.Settings.BreakTime = CInt(nudBreakTime.Value)
        My.Settings.BreakDelay = CInt(nudBreakDelay.Value)
        My.Settings.WorkTime = CInt(nudWorkTime.Value)
        My.Settings.WarningTimerEnabled = chkWarningTime.Checked
        My.Settings.WarningTime = CInt(nudWarningTime.Value)
        My.Settings.Message = txtMessage.Text
        My.Settings.BackColor = picBackColor.BackColor
        My.Settings.ForeColor = picForeColor.BackColor
        My.Settings.BeepAtBreakEnd = chkBeepOnBreakEnd.Checked
        My.Settings.Opacity = CInt(nudOpacity.Value)
        My.Settings.Font = CType(font.ConvertFromString(lnkFont.Text), Drawing.Font)
        If radOnLockDoNothing.Checked Then
            My.Settings.OnLock = OnLock.DoNothing
        ElseIf radOnLockPause.Checked Then
            My.Settings.OnLock = OnLock.PauseTimer
        Else
            My.Settings.OnLock = OnLock.ResetTimer
        End If
        My.Settings.Save()
        SetRunAtStartup()
        EndBreak()
        tmrBreak.Start()
    End Sub

    Private Sub SetRunAtStartup()
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(RUN_AT_STARTUP_KEY, True)

        If My.Settings.RunAtStartup Then
            key.SetValue(Application.ProductName, """" & Application.ExecutablePath & """")
        Else
            key.DeleteValue(Application.ProductName, False)
        End If

        key.Close()
    End Sub

    Private Sub ShowWarning()
        If _warningForm Is Nothing Then
            _warningForm = New WarningForm
            _warningForm.StartPosition = FormStartPosition.Manual
            _warningForm.Location = New Point(Screen.PrimaryScreen.WorkingArea.Right - _warningForm.Width - 20, Screen.PrimaryScreen.WorkingArea.Bottom - _warningForm.Height - 20)
            _warningForm.Seconds = CInt(DateDiff(DateInterval.Second, DateTime.Now, _nextBreak))
            _warningForm.SkippedBreaks = _skippedBreaks
            _warningForm.TopMost = True
            _warningForm.Show()
        End If
        If _warningForm.Visible Then _warningForm.Seconds = CInt(DateDiff(DateInterval.Second, DateTime.Now, _nextBreak))
    End Sub

    Private Sub StartBreak()
        If _warningForm IsNot Nothing Then
            _warningForm.Dispose()
            _warningForm = Nothing
        End If
        _skippedBreaks = 0
        _onBreak = True
        _workStarted = DateAdd(DateInterval.Second, My.Settings.BreakTime, DateTime.Now)
        _childForms = New Generic.List(Of BreakForm)
        For Each monitor As Screen In System.Windows.Forms.Screen.AllScreens
            Dim child As New BreakForm(_workStarted)
            AddHandler child.FormClosed, AddressOf BreakForm_FormClosed
            child.StartPosition = FormStartPosition.Manual
            child.Location = monitor.Bounds.Location + New Size(100, 100)
            child.WindowState = FormWindowState.Maximized
            child.TopMost = True
            _childForms.Add(child)
            child.Show()
        Next
    End Sub

    Private Sub DelayBreak()
        If _warningForm IsNot Nothing Then
            _warningForm.Dispose()
            _warningForm = Nothing
        End If
        _nextWarning = DateAdd(DateInterval.Second, My.Settings.BreakDelay, _nextWarning)
        _nextBreak = DateAdd(DateInterval.Second, My.Settings.BreakDelay, _nextBreak)
        SetNotifyText()
    End Sub

    Private Sub EndBreak()
        If _childForms IsNot Nothing Then
            For Each child As BreakForm In _childForms
                child.Dispose()
            Next
            _childForms.Clear()
            _childForms = Nothing
        End If
        If _warningForm IsNot Nothing Then
            _warningForm.Dispose()
            _warningForm = Nothing
        End If
        _onBreak = False
        _workStarted = DateTime.Now
        _nextBreak = DateAdd(DateInterval.Minute, My.Settings.WorkTime, _workStarted)
        _nextWarning = DateAdd(DateInterval.Second, -1 * My.Settings.WarningTime, _nextBreak)
        If My.Settings.BeepAtBreakEnd Then Beep()
        SetNotifyText()
    End Sub

    Private Sub SetNotifyText()
        icoNotify.Text = String.Format("Next break scheduled for {0:hh:mm:ss tt}", _nextBreak)
    End Sub

    Private Sub HideForm()
        Me.Hide()
        Me.ShowInTaskbar = False
    End Sub

    Private Sub ShowForm()
        LoadOptions()
        Me.Show()
        Me.ShowInTaskbar = True
    End Sub

    Private Sub tmrBreak_Tick(sender As Object, e As System.EventArgs) Handles tmrBreak.Tick
        If _onBreak Then
            If DateTime.Now >= _workStarted Then
                EndBreak()
            End If
        Else
            If DateTime.Now >= _nextBreak Then
                StartBreak()
            ElseIf DateTime.Now >= _nextWarning AndAlso My.Settings.WarningTimerEnabled Then
                ShowWarning()
            End If
        End If
    End Sub

    Private Sub mnuOptions_Click(sender As System.Object, e As System.EventArgs) Handles mnuOptions.Click
        ShowForm()
    End Sub

    Private Sub mnuExit_Click(sender As System.Object, e As System.EventArgs) Handles mnuExit.Click
        ExitApplication()
    End Sub

    Private Sub OptionsForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        HideForm()
    End Sub

    Private Sub picBackColor_Click(sender As System.Object, e As System.EventArgs) Handles picBackColor.Click
        dlgColor.Color = picBackColor.BackColor
        If dlgColor.ShowDialog = Windows.Forms.DialogResult.OK Then
            picBackColor.BackColor = dlgColor.Color
            UpdatePreview()
        End If
    End Sub

    Private Sub picForeColor_Click(sender As System.Object, e As System.EventArgs) Handles picForeColor.Click
        dlgColor.Color = picForeColor.BackColor
        If dlgColor.ShowDialog = Windows.Forms.DialogResult.OK Then
            picForeColor.BackColor = dlgColor.Color
            UpdatePreview()
        End If
    End Sub

    Private Sub mnuTakeABreak_Click(sender As System.Object, e As System.EventArgs) Handles mnuTakeABreak.Click
        StartBreak()
    End Sub

    Private Sub _warningForm_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles _warningForm.FormClosed
        Select Case _warningForm.DialogResult
            Case Windows.Forms.DialogResult.OK
                StartBreak()
            Case Windows.Forms.DialogResult.Cancel
                _skippedBreaks += 1
                EndBreak()
            Case Windows.Forms.DialogResult.Retry
                DelayBreak()
            Case Else
        End Select
    End Sub

    Private Sub OptionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdatePreview()
        Refresh()
    End Sub

    Private Sub UpdatePreview()
        Dim font As New FontConverter
        Dim opacity As Int32 = (255 * CInt(nudOpacity.Value)) \ 100
        lblPreview.ForeColor = Color.FromArgb(opacity, picForeColor.BackColor)
        lblPreview.BackColor = picBackColor.BackColor
        lblPreview.DimmedColor = lblPreview.ForeColor
        lblPreview.Opacity = opacity
        lblPreview.Caption = txtMessage.Text
        Try
            lblPreview.Font = CType(font.ConvertFromString(lnkFont.Text), Font)
        Catch
        End Try
    End Sub

    Private Sub nudOpacity_ValueChanged(sender As Object, e As EventArgs) Handles nudOpacity.ValueChanged
        UpdatePreview()
    End Sub

    Private Sub txtMessage_TextChanged(sender As Object, e As EventArgs) Handles txtMessage.TextChanged
        UpdatePreview()
    End Sub

    Private Sub lnkFont_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkFont.LinkClicked
        Dim font As New FontConverter
        dlgFont.Font = CType(font.ConvertFromString(lnkFont.Text), Font)
        If dlgFont.ShowDialog = Windows.Forms.DialogResult.OK Then
            lnkFont.Text = font.ConvertToString(dlgFont.Font)
            UpdatePreview()
        End If
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        ShowAbout()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitApplication()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        ShowAbout()
    End Sub

    Private Sub ExitApplication()
        icoNotify.Visible = False
        Application.Exit()
    End Sub

    Private Sub ShowAbout()
        Dim about As New AboutErgoBreaker
        about.ShowDialog(Me)
    End Sub

    Private Sub OptionsForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub
End Class
