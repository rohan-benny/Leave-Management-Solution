Public Class AdminForm
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim response As Integer = MessageBox.Show("     Do you Want To Logout?", "LOGGING OUT", MessageBoxButtons.YesNo)
        If response = vbYes Then
            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub ShowForm(form As Form)
        BunifuGradientPanel2.Controls.Clear()
        form.TopLevel = False
        BunifuGradientPanel2.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub ManageUser_Click(sender As Object, e As EventArgs) Handles ManageUser.Click
        ShowForm(ManageUserForm)
    End Sub

    Private Sub Manage_Click(sender As Object, e As EventArgs) Handles Manage.Click
        ShowForm(ManageLeaveForm)
    End Sub

    Private Sub DashBoard_Click(sender As Object, e As EventArgs) Handles DashBoard.Click
        ShowForm(AdminDashForm)
    End Sub

    Private Sub settings_Click(sender As Object, e As EventArgs) Handles settings.Click
        ShowForm(SettingsForm)
        SettingsForm.ContactAdminBtn.Hide()
        SettingsForm.editpro.Enabled = False
    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DashBoard_Click(sender, e)
        DashBoard.PerformClick()
    End Sub

    Private Sub calendar_Click(sender As Object, e As EventArgs) Handles Holidays.Click
        ShowForm(HolidaysForm)
    End Sub

    Private Sub help_Click(sender As Object, e As EventArgs) Handles help.Click
        ShowForm(HelpForm)
    End Sub

    Private Sub ReportAdmin_Click(sender As Object, e As EventArgs) Handles ReportAdmin.Click
        ShowForm(ReportForm)
    End Sub
End Class