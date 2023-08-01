Public Class ManageUserForm
    Private Sub ShowForm(form As Form)
        BunifuPanel1.Controls.Clear()
        form.TopLevel = False
        BunifuPanel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub ManageUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Addbtn_Click_1(sender, e)
    End Sub

    Private Sub Addbtn_Click_1(sender As Object, e As EventArgs) Handles Addbtn.Click
        ShowForm(Adduserform)
    End Sub

    Private Sub Modifybtn_Click_1(sender As Object, e As EventArgs) Handles Modifybtn.Click
        ShowForm(ModifyUserForm)

        ModifyUserForm.BunifuPanel1.Hide()
        ModifyUserForm.user_name.Text = ""
    End Sub

    Private Sub Deletebtn_Click_1(sender As Object, e As EventArgs) Handles Deletebtn.Click
        ShowForm(DeleteUserForm)

        DeleteUserForm.BunifuPanel1.Hide()
        DeleteUserForm.user_name.Text = ""
    End Sub

    Private Sub Searchbtn_Click_1(sender As Object, e As EventArgs) Handles Searchbtn.Click
        ShowForm(SearchUserForm)

        SearchUserForm.BunifuPanel1.Hide()
        SearchUserForm.user_name.Text = ""
    End Sub
End Class