Friend Class BreakForm

    Private _breakEnd As Date

    Public Property UserClosed As Boolean = False

    Public Sub New(ByVal breakEnd As Date)
        InitializeComponent()
        _breakEnd = breakEnd
        tmrBreak.Start()
        lblMessage.BackColor = My.Settings.BackColor
        lblMessage.ForeColor = My.Settings.ForeColor
        lblMessage.Font = My.Settings.Font
        Opacity = My.Settings.Opacity / 100
    End Sub

    Private Sub tmrBreak_Tick(sender As Object, e As System.EventArgs) Handles tmrBreak.Tick
        SetText()
    End Sub

    Private Sub SetText()
        lblMessage.Text = My.Settings.Message & vbCrLf &
                          CStr(DateDiff(DateInterval.Second, Date.Now, _breakEnd) + 1)
    End Sub

    Private Sub BreakForm_PreviewKeyDown(sender As Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles Me.PreviewKeyDown
        If e.KeyCode = Keys.Escape Then
            UserClosed = True
            Close()
        End If
    End Sub

    Private Sub lblMessage_Click(sender As Object, e As EventArgs) Handles lblMessage.Click

    End Sub
End Class