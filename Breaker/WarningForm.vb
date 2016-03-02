Friend Class WarningForm

    Protected Overrides ReadOnly Property ShowWithoutActivation As Boolean
        Get
            Return True
        End Get
    End Property

    Public Property Seconds() As Int32
        Get
            Return _seconds
        End Get
        Set(value As Int32)
            If value <> _seconds Then
                _seconds = value
                lblMessage.Text = String.Format("You have a break scheduled in {0} seconds.", _seconds + 1)
                Me.Refresh()
            End If
        End Set
    End Property

    Public Property SkippedBreaks As Int32

    Private _seconds As Int32

    Private Sub btnHideWarning_Click(sender As System.Object, e As System.EventArgs) Handles btnHideWarning.Click
        Me.Hide()
    End Sub

    Private Sub btnCancelBreak_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelBreak.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        If Me.InvokeRequired Then
            Dim a As New Action(AddressOf Me.Close)
            Me.Invoke(a)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnStartBreak_Click(sender As System.Object, e As System.EventArgs) Handles btnStartBreak.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        If Me.InvokeRequired Then
            Dim a As New Action(AddressOf Me.Close)
            Me.Invoke(a)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub WarningForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.DialogResult = Windows.Forms.DialogResult.None
        If SkippedBreaks = 0 Then
            lblCancelledBreaks.Visible = False
        Else
            lblCancelledBreaks.Visible = True
            If SkippedBreaks = 1 Then
                lblCancelledBreaks.Text = "You cancelled your previous break."
            Else
                lblCancelledBreaks.Text = String.Format("You cancelled your previous {0} breaks.", SkippedBreaks)
            End If
        End If
    End Sub

    Private Sub btnDelayBreak_Click(sender As System.Object, e As System.EventArgs) Handles btnDelayBreak.Click
        Me.DialogResult = Windows.Forms.DialogResult.Retry
        If Me.InvokeRequired Then
            Dim a As New Action(AddressOf Me.Close)
            Me.Invoke(a)
        Else
            Me.Close()
        End If
    End Sub
End Class
