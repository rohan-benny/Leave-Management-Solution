Imports System.Data.OleDb
Public Class DeleteUserForm
    Private conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ConnectString)

    Private Sub DeleteUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuPanel1.Enabled = False
        BunifuPanel1.Hide()
        Deletebtn.Hide()
    End Sub

    Private Sub user_name_TextChanged(sender As Object, e As EventArgs) Handles user_name.TextChanged
        BunifuPanel1.Hide()
        Deletebtn.Hide()
    End Sub

    Private Sub user_name_KeyDown(sender As Object, e As KeyEventArgs) Handles user_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            If user_name.Text.StartsWith("FAC") Then
                crs.Hide()
                sem.Hide()
                BunifuLabel12.Hide()
                BunifuLabel6.Hide()
            Else
                crs.Show()
                sem.Show()
                BunifuLabel12.Show()
                BunifuLabel6.Show()
            End If

            Deletebtn.Show()
            BunifuPanel1.Show()
            Dim cmd As New OleDbCommand()
            Dim adapter As New OleDbDataAdapter()
            Dim dataTable As New DataTable()

            Try
                cmd.CommandText = "SELECT * FROM User_Details WHERE Username = @Username"
                cmd.Parameters.AddWithValue("@Username", user_name.Text.Trim())
                cmd.Connection = conn
                adapter.SelectCommand = cmd
                conn.Open()
                adapter.Fill(dataTable)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try

            Try
                If dataTable.Rows.Count > 0 Then
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        BunifuPanel1.Show()
                        first_name.Text = reader("firstname").ToString()
                        last_name.Text = reader("lastname").ToString()
                        email.Text = reader("email").ToString()
                        phoneno.Text = reader("phoneno").ToString()
                        dept.Text = reader("department").ToString()
                        crs.Text = reader("course").ToString()
                        sem.Text = reader("semester").ToString()
                    End If
                    reader.Close()
                    conn.Close()
                Else
                    BunifuPanel1.Hide()
                    Deletebtn.Hide()
                    MessageBox.Show("User not found")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        Try
            Dim username As String = user_name.Text
            Dim query As String = "DELETE FROM User_Details WHERE username=@username"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@Username", username)
            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("User information deleted.")

                Dim query1 As String = "DELETE FROM User_Login WHERE username=@username"
                Dim cmd1 As New OleDbCommand(query1, conn)
                cmd1.Parameters.AddWithValue("@Username", username)
                cmd1.ExecuteNonQuery()
            End If
            conn.Close()
        Catch ex As Exception
        MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        user_name.Text = ""
        Deletebtn.Hide()
    End Sub
End Class