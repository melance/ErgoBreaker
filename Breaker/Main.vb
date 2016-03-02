Module Main
    Public Sub Main()
        Dim args() As String = System.Environment.GetCommandLineArgs()
        Dim mainForm As OptionsForm
        Dim culture As String

        If args.Length = 2 Then
            culture = args(1)
        Else
            culture = String.Empty
        End If
        mainForm = New OptionsForm(culture)

        mainForm.Visible = My.Settings.ShowOptionsOnLaunch
        Application.EnableVisualStyles()
        Application.Run()
    End Sub
End Module
