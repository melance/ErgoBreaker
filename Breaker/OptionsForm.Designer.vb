<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsForm))
        Me.lblWorkTime = New System.Windows.Forms.Label()
        Me.lblBreakTime = New System.Windows.Forms.Label()
        Me.nudBreakTime = New System.Windows.Forms.NumericUpDown()
        Me.nudWorkTime = New System.Windows.Forms.NumericUpDown()
        Me.nudWarningTime = New System.Windows.Forms.NumericUpDown()
        Me.chkWarningTime = New System.Windows.Forms.CheckBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.icoNotify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.mnuNotifyIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTakeABreak = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeperator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrBreak = New System.Windows.Forms.Timer(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkShowOptionsOnLaunch = New System.Windows.Forms.CheckBox()
        Me.lblPreviewLabel = New System.Windows.Forms.Label()
        Me.picBackColor = New System.Windows.Forms.PictureBox()
        Me.picForeColor = New System.Windows.Forms.PictureBox()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.nudBreakDelay = New System.Windows.Forms.NumericUpDown()
        Me.lblBreakDelay = New System.Windows.Forms.Label()
        Me.chkBeepOnBreakEnd = New System.Windows.Forms.CheckBox()
        Me.nudOpacity = New System.Windows.Forms.NumericUpDown()
        Me.lblOpacity = New System.Windows.Forms.Label()
        Me.lblPreview = New DOALibrary.DOATransparentLabel()
        Me.lblBackgroundColor = New System.Windows.Forms.Label()
        Me.lblForegroundColor = New System.Windows.Forms.Label()
        Me.lblFontLabel = New System.Windows.Forms.Label()
        Me.lnkFont = New System.Windows.Forms.LinkLabel()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblOnSessionLock = New System.Windows.Forms.Label()
        Me.chkRunAtStartup = New System.Windows.Forms.CheckBox()
        Me.radOnLockDoNothing = New System.Windows.Forms.RadioButton()
        Me.radOnLockPause = New System.Windows.Forms.RadioButton()
        Me.radOnLockReset = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.nudBreakTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWorkTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWarningTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuNotifyIcon.SuspendLayout()
        CType(Me.picBackColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picForeColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBreakDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWorkTime
        '
        resources.ApplyResources(Me.lblWorkTime, "lblWorkTime")
        Me.lblWorkTime.Name = "lblWorkTime"
        '
        'lblBreakTime
        '
        resources.ApplyResources(Me.lblBreakTime, "lblBreakTime")
        Me.lblBreakTime.Name = "lblBreakTime"
        '
        'nudBreakTime
        '
        resources.ApplyResources(Me.nudBreakTime, "nudBreakTime")
        Me.nudBreakTime.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudBreakTime.Name = "nudBreakTime"
        Me.nudBreakTime.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'nudWorkTime
        '
        resources.ApplyResources(Me.nudWorkTime, "nudWorkTime")
        Me.nudWorkTime.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudWorkTime.Name = "nudWorkTime"
        Me.nudWorkTime.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'nudWarningTime
        '
        resources.ApplyResources(Me.nudWarningTime, "nudWarningTime")
        Me.nudWarningTime.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudWarningTime.Name = "nudWarningTime"
        Me.nudWarningTime.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'chkWarningTime
        '
        resources.ApplyResources(Me.chkWarningTime, "chkWarningTime")
        Me.chkWarningTime.Checked = True
        Me.chkWarningTime.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWarningTime.Name = "chkWarningTime"
        Me.chkWarningTime.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        resources.ApplyResources(Me.lblMessage, "lblMessage")
        Me.lblMessage.Name = "lblMessage"
        '
        'txtMessage
        '
        resources.ApplyResources(Me.txtMessage, "txtMessage")
        Me.txtMessage.Name = "txtMessage"
        '
        'icoNotify
        '
        Me.icoNotify.ContextMenuStrip = Me.mnuNotifyIcon
        resources.ApplyResources(Me.icoNotify, "icoNotify")
        '
        'mnuNotifyIcon
        '
        Me.mnuNotifyIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptions, Me.mnuTakeABreak, Me.mnuSeperator1, Me.mnuAbout, Me.mnuExit})
        Me.mnuNotifyIcon.Name = "mnuNotifyIcon"
        resources.ApplyResources(Me.mnuNotifyIcon, "mnuNotifyIcon")
        '
        'mnuOptions
        '
        Me.mnuOptions.Name = "mnuOptions"
        resources.ApplyResources(Me.mnuOptions, "mnuOptions")
        '
        'mnuTakeABreak
        '
        Me.mnuTakeABreak.Name = "mnuTakeABreak"
        resources.ApplyResources(Me.mnuTakeABreak, "mnuTakeABreak")
        '
        'mnuSeperator1
        '
        Me.mnuSeperator1.Name = "mnuSeperator1"
        resources.ApplyResources(Me.mnuSeperator1, "mnuSeperator1")
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        resources.ApplyResources(Me.mnuAbout, "mnuAbout")
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        resources.ApplyResources(Me.mnuExit, "mnuExit")
        '
        'tmrBreak
        '
        Me.tmrBreak.Interval = 1000
        '
        'btnSave
        '
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.Name = "btnSave"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkShowOptionsOnLaunch
        '
        resources.ApplyResources(Me.chkShowOptionsOnLaunch, "chkShowOptionsOnLaunch")
        Me.chkShowOptionsOnLaunch.Checked = True
        Me.chkShowOptionsOnLaunch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowOptionsOnLaunch.Name = "chkShowOptionsOnLaunch"
        Me.chkShowOptionsOnLaunch.UseVisualStyleBackColor = True
        '
        'lblPreviewLabel
        '
        resources.ApplyResources(Me.lblPreviewLabel, "lblPreviewLabel")
        Me.lblPreviewLabel.BackColor = System.Drawing.Color.Black
        Me.lblPreviewLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPreviewLabel.Name = "lblPreviewLabel"
        '
        'picBackColor
        '
        Me.picBackColor.BackColor = System.Drawing.Color.Black
        Me.picBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.picBackColor, "picBackColor")
        Me.picBackColor.Name = "picBackColor"
        Me.picBackColor.TabStop = False
        '
        'picForeColor
        '
        Me.picForeColor.BackColor = System.Drawing.Color.White
        Me.picForeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.picForeColor, "picForeColor")
        Me.picForeColor.Name = "picForeColor"
        Me.picForeColor.TabStop = False
        '
        'dlgColor
        '
        Me.dlgColor.AnyColor = True
        '
        'nudBreakDelay
        '
        resources.ApplyResources(Me.nudBreakDelay, "nudBreakDelay")
        Me.nudBreakDelay.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudBreakDelay.Name = "nudBreakDelay"
        Me.nudBreakDelay.Value = New Decimal(New Integer() {120, 0, 0, 0})
        '
        'lblBreakDelay
        '
        resources.ApplyResources(Me.lblBreakDelay, "lblBreakDelay")
        Me.lblBreakDelay.Name = "lblBreakDelay"
        '
        'chkBeepOnBreakEnd
        '
        resources.ApplyResources(Me.chkBeepOnBreakEnd, "chkBeepOnBreakEnd")
        Me.chkBeepOnBreakEnd.Name = "chkBeepOnBreakEnd"
        Me.chkBeepOnBreakEnd.UseVisualStyleBackColor = True
        '
        'nudOpacity
        '
        Me.nudOpacity.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        resources.ApplyResources(Me.nudOpacity, "nudOpacity")
        Me.nudOpacity.Name = "nudOpacity"
        Me.nudOpacity.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lblOpacity
        '
        resources.ApplyResources(Me.lblOpacity, "lblOpacity")
        Me.lblOpacity.Name = "lblOpacity"
        '
        'lblPreview
        '
        resources.ApplyResources(Me.lblPreview, "lblPreview")
        Me.lblPreview.BorderColor = System.Drawing.Color.Black
        Me.lblPreview.Caption = "Take a Break"
        Me.lblPreview.DimmedColor = System.Drawing.Color.LightGray
        Me.lblPreview.ForeColor = System.Drawing.Color.White
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Opacity = 100
        Me.lblPreview.Radius = 0
        Me.lblPreview.ShapeBorderStyle = DOALibrary.DOATransparentLabel.ShapeBorderStyles.ShapeBSFixedSingle
        '
        'lblBackgroundColor
        '
        resources.ApplyResources(Me.lblBackgroundColor, "lblBackgroundColor")
        Me.lblBackgroundColor.Name = "lblBackgroundColor"
        '
        'lblForegroundColor
        '
        resources.ApplyResources(Me.lblForegroundColor, "lblForegroundColor")
        Me.lblForegroundColor.Name = "lblForegroundColor"
        '
        'lblFontLabel
        '
        resources.ApplyResources(Me.lblFontLabel, "lblFontLabel")
        Me.lblFontLabel.Name = "lblFontLabel"
        '
        'lnkFont
        '
        resources.ApplyResources(Me.lnkFont, "lnkFont")
        Me.TableLayoutPanel1.SetColumnSpan(Me.lnkFont, 2)
        Me.lnkFont.Name = "lnkFont"
        Me.lnkFont.TabStop = True
        '
        'dlgFont
        '
        Me.dlgFont.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dlgFont.ScriptsOnly = True
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.Name = "btnExit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        resources.ApplyResources(Me.btnAbout, "btnAbout")
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.lblOnSessionLock, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.chkRunAtStartup, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkShowOptionsOnLaunch, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWorkTime, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nudWorkTime, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblBreakTime, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lnkFont, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.chkBeepOnBreakEnd, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFontLabel, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.nudBreakTime, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.picForeColor, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblBackgroundColor, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblBreakDelay, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.nudOpacity, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOpacity, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMessage, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.nudBreakDelay, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.chkWarningTime, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.nudWarningTime, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMessage, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.picBackColor, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblForegroundColor, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.radOnLockDoNothing, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.radOnLockPause, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.radOnLockReset, 2, 9)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'lblOnSessionLock
        '
        resources.ApplyResources(Me.lblOnSessionLock, "lblOnSessionLock")
        Me.lblOnSessionLock.Name = "lblOnSessionLock"
        '
        'chkRunAtStartup
        '
        resources.ApplyResources(Me.chkRunAtStartup, "chkRunAtStartup")
        Me.chkRunAtStartup.Name = "chkRunAtStartup"
        Me.chkRunAtStartup.UseVisualStyleBackColor = True
        '
        'radOnLockDoNothing
        '
        resources.ApplyResources(Me.radOnLockDoNothing, "radOnLockDoNothing")
        Me.radOnLockDoNothing.Checked = True
        Me.radOnLockDoNothing.Name = "radOnLockDoNothing"
        Me.radOnLockDoNothing.TabStop = True
        Me.radOnLockDoNothing.UseVisualStyleBackColor = True
        '
        'radOnLockPause
        '
        resources.ApplyResources(Me.radOnLockPause, "radOnLockPause")
        Me.radOnLockPause.Name = "radOnLockPause"
        Me.ToolTip1.SetToolTip(Me.radOnLockPause, resources.GetString("radOnLockPause.ToolTip"))
        Me.radOnLockPause.UseVisualStyleBackColor = True
        '
        'radOnLockReset
        '
        resources.ApplyResources(Me.radOnLockReset, "radOnLockReset")
        Me.radOnLockReset.Name = "radOnLockReset"
        Me.ToolTip1.SetToolTip(Me.radOnLockReset, resources.GetString("radOnLockReset.ToolTip"))
        Me.radOnLockReset.UseVisualStyleBackColor = True
        '
        'OptionsForm
        '
        Me.AcceptButton = Me.btnSave
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.lblPreviewLabel)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsForm"
        CType(Me.nudBreakTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWorkTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWarningTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuNotifyIcon.ResumeLayout(False)
        CType(Me.picBackColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picForeColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBreakDelay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblWorkTime As System.Windows.Forms.Label
    Friend WithEvents lblBreakTime As System.Windows.Forms.Label
    Friend WithEvents nudBreakTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudWorkTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudWarningTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkWarningTime As System.Windows.Forms.CheckBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents icoNotify As System.Windows.Forms.NotifyIcon
    Friend WithEvents tmrBreak As System.Windows.Forms.Timer
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chkShowOptionsOnLaunch As System.Windows.Forms.CheckBox
    Friend WithEvents mnuNotifyIcon As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPreviewLabel As System.Windows.Forms.Label
    Friend WithEvents picBackColor As System.Windows.Forms.PictureBox
    Friend WithEvents picForeColor As System.Windows.Forms.PictureBox
    Friend WithEvents dlgColor As System.Windows.Forms.ColorDialog
    Friend WithEvents mnuTakeABreak As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nudBreakDelay As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblBreakDelay As System.Windows.Forms.Label
    Friend WithEvents chkBeepOnBreakEnd As System.Windows.Forms.CheckBox
    Friend WithEvents nudOpacity As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblOpacity As System.Windows.Forms.Label
    Friend WithEvents lblPreview As DOALibrary.DOATransparentLabel
    Friend WithEvents lblBackgroundColor As System.Windows.Forms.Label
    Friend WithEvents lblForegroundColor As System.Windows.Forms.Label
    Friend WithEvents lblFontLabel As System.Windows.Forms.Label
    Friend WithEvents lnkFont As System.Windows.Forms.LinkLabel
    Friend WithEvents dlgFont As System.Windows.Forms.FontDialog
    Friend WithEvents mnuSeperator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkRunAtStartup As System.Windows.Forms.CheckBox
    Friend WithEvents lblOnSessionLock As System.Windows.Forms.Label
    Friend WithEvents radOnLockDoNothing As System.Windows.Forms.RadioButton
    Friend WithEvents radOnLockPause As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents radOnLockReset As System.Windows.Forms.RadioButton

End Class
