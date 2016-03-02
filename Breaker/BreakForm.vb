Friend Class BreakForm

    Private _breakEnd As DateTime

    Public Sub New(ByVal breakEnd As DateTime)
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
                          CStr(DateDiff(DateInterval.Second, DateTime.Now, _breakEnd) + 1)
    End Sub

    Private Sub BreakForm_PreviewKeyDown(sender As Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles Me.PreviewKeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class