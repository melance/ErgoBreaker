<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutErgoBreaker
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

    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutErgoBreaker))
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.lnkSorceforge = New System.Windows.Forms.LinkLabel()
        Me.tblText = New System.Windows.Forms.TableLayoutPanel()
        Me.lnkFrench = New System.Windows.Forms.LinkLabel()
        Me.lblAuthor = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblText.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProductName
        '
        resources.ApplyResources(Me.lblProductName, "lblProductName")
        Me.lblProductName.Name = "lblProductName"
        '
        'lblVersion
        '
        resources.ApplyResources(Me.lblVersion, "lblVersion")
        Me.lblVersion.Name = "lblVersion"
        '
        'lblCopyright
        '
        resources.ApplyResources(Me.lblCopyright, "lblCopyright")
        Me.lblCopyright.Name = "lblCopyright"
        '
        'LogoPictureBox
        '
        resources.ApplyResources(Me.LogoPictureBox, "LogoPictureBox")
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.TabStop = False
        '
        'lnkSorceforge
        '
        resources.ApplyResources(Me.lnkSorceforge, "lnkSorceforge")
        Me.lnkSorceforge.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkSorceforge.Name = "lnkSorceforge"
        Me.lnkSorceforge.TabStop = True
        Me.lnkSorceforge.UseCompatibleTextRendering = True
        '
        'tblText
        '
        resources.ApplyResources(Me.tblText, "tblText")
        Me.tblText.Controls.Add(Me.lblAuthor, 0, 3)
        Me.tblText.Controls.Add(Me.lnkFrench, 0, 5)
        Me.tblText.Controls.Add(Me.lblProductName, 0, 0)
        Me.tblText.Controls.Add(Me.lnkSorceforge, 0, 4)
        Me.tblText.Controls.Add(Me.lblVersion, 0, 1)
        Me.tblText.Controls.Add(Me.lblCopyright, 0, 2)
        Me.tblText.Name = "tblText"
        '
        'lnkFrench
        '
        resources.ApplyResources(Me.lnkFrench, "lnkFrench")
        Me.lnkFrench.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkFrench.Name = "lnkFrench"
        Me.lnkFrench.TabStop = True
        Me.lnkFrench.UseCompatibleTextRendering = True
        '
        'lblAuthor
        '
        resources.ApplyResources(Me.lblAuthor, "lblAuthor")
        Me.lblAuthor.Name = "lblAuthor"
        '
        'AboutErgoBreaker
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.tblText)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutErgoBreaker"
        Me.ShowInTaskbar = False
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblText.ResumeLayout(False)
        Me.tblText.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lnkSorceforge As System.Windows.Forms.LinkLabel
    Friend WithEvents tblText As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lnkFrench As System.Windows.Forms.LinkLabel
    Friend WithEvents lblAuthor As System.Windows.Forms.Label

End Class
