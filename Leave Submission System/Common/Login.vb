Imports System.Data.OleDb
Public Class Login
    Private conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ConnectString)

    Private Function CheckUserLogin(username As String, password As String) As DataRow
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM User_Login WHERE username=@username AND password=@password", conn)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            Dim storedUsername As String = row("username").ToString()
            Dim storedPassword As String = row("password").ToString()

            If String.Equals(storedUsername, username, StringComparison.Ordinal) AndAlso
           String.Equals(storedPassword, password, StringComparison.Ordinal) Then
                conn.Close()
                Return row
            End If
        End If

        conn.Close()
        Return Nothing
    End Function

    Private Function CheckAdminLogin(username As String, password As String) As Boolean
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM Admin_Login WHERE username=@username AND password=@password", conn)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                Dim storedUsername As String = reader("username").ToString()
                Dim storedPassword As String = reader("password").ToString()

                If String.Equals(storedUsername, username, StringComparison.Ordinal) AndAlso
               String.Equals(storedPassword, password, StringComparison.Ordinal) Then
                    reader.Close()
                    conn.Close()
                    Return True
                End If
            End While
        End If

        reader.Close()
        conn.Close()
        Return False
    End Function

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Try
            Dim username As String = user_name.Text
            Dim password As String = pass_word.Text
            Dim userInfo As DataRow = CheckUserLogin(username, password)

            If userInfo IsNot Nothing Then
                Dim userInfoForm As New UserForm(userInfo("username").ToString())
                userInfoForm.Show()
                Me.Hide()
            ElseIf CheckAdminLogin(username, password) Then
                Dim adminForm As New AdminForm()
                adminForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Unauthorised Access", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        ToolTip1.Active = True
        If ShowPassword.Checked = True Then
            pass_word.UseSystemPasswordChar = False
            ToolTip1.SetToolTip(ShowPassword, "Hide Password")
        Else
            pass_word.UseSystemPasswordChar = True
            ToolTip1.SetToolTip(ShowPassword, "Show Password")
        End If
    End Sub
    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles pass_word.TextChanged
        If ShowPassword.Checked = True Then
            pass_word.UseSystemPasswordChar = False
        Else
            pass_word.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        user_name.Text = ""
        pass_word.Text = ""
    End Sub

    Private Sub user_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles user_name.KeyPress
        If user_name.Text.Length >= 15 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub pass_word_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pass_word.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        End If

        If pass_word.Text.Length >= 15 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        Application.Exit()
    End Sub

    Private Sub user_name_TextChanged(sender As Object, e As EventArgs) Handles user_name.TextChanged
        pass_word.Text = ""
    End Sub
End Class