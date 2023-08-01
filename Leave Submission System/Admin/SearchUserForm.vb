Imports System.Data.OleDb
Public Class SearchUserForm
    Private conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ConnectString)

    Private Sub SearchUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuPanel1.Hide()
        BunifuPanel1.Enabled = False
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
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

        Try
            Dim cmd As New OleDbCommand()
            Dim adapter As New OleDbDataAdapter()
            Dim dataTable As New DataTable()

            cmd.CommandText = "SELECT * FROM User_Details WHERE Username = @Username"
            cmd.Parameters.AddWithValue("@Username", user_name.Text.Trim())
            cmd.Connection = conn
            adapter.SelectCommand = cmd

            Try
                conn.Open()
                adapter.Fill(dataTable)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try

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
                MessageBox.Show("User not found")

            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub user_name_TextChanged(sender As Object, e As EventArgs) Handles user_name.TextChanged
        BunifuPanel1.Hide()
    End Sub
End Class