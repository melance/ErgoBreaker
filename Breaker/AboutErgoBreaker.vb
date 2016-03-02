﻿Public NotInheritable Class AboutErgoBreaker

    Private Sub AboutErgoBreaker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        Me.lblProductName.Text = My.Application.Info.ProductName
        Me.lblVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.lblCopyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub lnkGitHub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSorceforge.LinkClicked
        Process.Start("https://github.com/melance/ErgoBreaker")
    End Sub

    Private Sub lnkCompany_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://github.com/melance")
    End Sub

    Private Sub lnkFrench_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkFrench.LinkClicked
        Process.Start("https://crowdin.com/profile/Pietrovski")
    End Sub
End Class
