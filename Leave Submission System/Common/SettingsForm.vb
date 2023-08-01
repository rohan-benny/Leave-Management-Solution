Public Class SettingsForm
    Private Sub Changepassword_Click(sender As Object, e As EventArgs) Handles Changepassword.Click
        ChangePasswordFrom.Show()
    End Sub

    Private Sub ContactAdminBtn_Click(sender As Object, e As EventArgs) Handles ContactAdminBtn.Click
        Dim email As String = "mailto:lmsleavemanager@gmail.com"
        Process.Start(email)
    End Sub

    Private Sub editpro_Click(sender As Object, e As EventArgs) Handles editpro.Click
        EditProfileform.Show()
    End Sub
End Class