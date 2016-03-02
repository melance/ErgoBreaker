<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WarningForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WarningForm))
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnCancelBreak = New System.Windows.Forms.Button()
        Me.btnHideWarning = New System.Windows.Forms.Button()
        Me.btnStartBreak = New System.Windows.Forms.Button()
        Me.btnDelayBreak = New System.Windows.Forms.Button()
        Me.lblCancelledBreaks = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        resources.ApplyResources(Me.lblMessage, "lblMessage")
        Me.lblMessage.Name = "lblMessage"
        '
        'btnCancelBreak
        '
        resources.ApplyResources(Me.btnCancelBreak, "btnCancelBreak")
        Me.btnCancelBreak.Name = "btnCancelBreak"
        Me.btnCancelBreak.UseVisualStyleBackColor = True
        '
        'btnHideWarning
        '
        resources.ApplyResources(Me.btnHideWarning, "btnHideWarning")
        Me.btnHideWarning.Name = "btnHideWarning"
        Me.btnHideWarning.UseVisualStyleBackColor = True
        '
        'btnStartBreak
        '
        resources.ApplyResources(Me.btnStartBreak, "btnStartBreak")
        Me.btnStartBreak.Name = "btnStartBreak"
        Me.btnStartBreak.UseVisualStyleBackColor = True
        '
        'btnDelayBreak
        '
        resources.ApplyResources(Me.btnDelayBreak, "btnDelayBreak")
        Me.btnDelayBreak.Name = "btnDelayBreak"
        Me.btnDelayBreak.UseVisualStyleBackColor = True
        '
        'lblCancelledBreaks
        '
        resources.ApplyResources(Me.lblCancelledBreaks, "lblCancelledBreaks")
        Me.lblCancelledBreaks.Name = "lblCancelledBreaks"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblCancelledBreaks)
        Me.Panel1.Controls.Add(Me.lblMessage)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'WarningForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDelayBreak)
        Me.Controls.Add(Me.btnStartBreak)
        Me.Controls.Add(Me.btnHideWarning)
        Me.Controls.Add(Me.btnCancelBreak)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WarningForm"
        Me.ShowInTaskbar = False
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnCancelBreak As System.Windows.Forms.Button
    Friend WithEvents btnHideWarning As System.Windows.Forms.Button
    Friend WithEvents btnStartBreak As System.Windows.Forms.Button
    Friend WithEvents btnDelayBreak As System.Windows.Forms.Button
    Friend WithEvents lblCancelledBreaks As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
