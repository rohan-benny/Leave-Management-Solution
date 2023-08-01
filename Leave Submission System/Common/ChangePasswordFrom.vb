Imports System.Data.OleDb
Public Class ChangePasswordFrom
    Private conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ConnectString)

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            If Login.user_name.Text = Me.user_name.Text Then
                Dim username As String = user_name.Text
                Dim newPassword As String = newpass.Text
                Dim confirmNewPassword As String = confirm.Text
                Dim old As String = current.Text

                If newPassword <> confirmNewPassword Then
                    MsgBox("New password and confirm password do not match.")
                    Return
                End If

                conn.Open()

                Dim cmdAdmin As New OleDbCommand("SELECT * FROM Admin_Login WHERE username=@username AND password=@password;", conn)
                cmdAdmin.Parameters.AddWithValue("@username", username)
                cmdAdmin.Parameters.AddWithValue("@password", old)
                Dim readerAdmin As OleDbDataReader = cmdAdmin.ExecuteReader()

                If readerAdmin.Read() Then
                    Dim cmdUpdateAdmin As New OleDbCommand("UPDATE Admin_Login SET [password]=@newPassword WHERE username=@username;", conn)
                    cmdUpdateAdmin.Parameters.AddWithValue("@newPassword", newPassword)
                    cmdUpdateAdmin.Parameters.AddWithValue("@username", username)
                    cmdUpdateAdmin.ExecuteNonQuery()

                    MsgBox("Password changed successfully")
                Else
                    Dim cmdUser As New OleDbCommand("SELECT * FROM User_Login WHERE username=@username AND password=@password;", conn)
                    cmdUser.Parameters.AddWithValue("@username", username)
                    cmdUser.Parameters.AddWithValue("@password", old)
                    Dim readerUser As OleDbDataReader = cmdUser.ExecuteReader()

                    If readerUser.Read() Then
                        Dim cmdUpdateUser As New OleDbCommand("UPDATE User_Login SET [password]=@newPassword WHERE username=@username;", conn)
                        cmdUpdateUser.Parameters.AddWithValue("@newPassword", newPassword)
                        cmdUpdateUser.Parameters.AddWithValue("@username", username)
                        cmdUpdateUser.ExecuteNonQuery()

                        MsgBox("Password changed successfully")
                    Else
                        MsgBox("Invalid username or password.")
                    End If
                End If
            Else
                MessageBox.Show("Unauthorized Person")
            End If
            conn.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles showpassword.CheckedChanged
        If showpassword.Checked = True Then
            newpass.UseSystemPasswordChar = False
            current.UseSystemPasswordChar = False
            confirm.UseSystemPasswordChar = False
        Else
            newpass.UseSystemPasswordChar = True
            current.UseSystemPasswordChar = True
            confirm.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ChangePasswordFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newpass.UseSystemPasswordChar = True
        current.UseSystemPasswordChar = True
        confirm.UseSystemPasswordChar = True
    End Sub
End Class