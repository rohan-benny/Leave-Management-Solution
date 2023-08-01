Imports System.Data.OleDb
Imports System.IO
Public Class EditProfileform
    Private conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ConnectString)
    Private loggedInUser As String

    Private Sub EditProfileform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuPanel1.Enabled = False

        loggedInUser = ApplyLeaveForm.user_name.Text
        user_name.Text = loggedInUser

        Try
            Dim cmd As New OleDbCommand()
            Dim adapter As New OleDbDataAdapter()
            Dim dataTable As New DataTable()

            cmd.CommandText = "SELECT * FROM User_Details WHERE Username = @Username"
            cmd.Parameters.AddWithValue("@Username", loggedInUser)


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
                    first_name.Text = reader("firstname").ToString()
                    last_name.Text = reader("lastname").ToString()
                    email.Text = reader("email").ToString()
                    phone.Text = reader("phoneno").ToString()
                    dept.Text = reader("department").ToString()
                    crs.Text = reader("course").ToString()
                    sem.Text = reader("semester").ToString()

                    If Not reader.IsDBNull(reader.GetOrdinal("propic")) Then
                        Dim imageData As Byte() = DirectCast(reader("propic"), Byte())
                        If imageData.Length > 0 Then
                            Dim ms As New MemoryStream(imageData)
                            Try
                                Dim image As Image = Image.FromStream(ms)
                                pro_pic.Image = image
                            Catch ex As ArgumentException
                                MessageBox.Show("Invalid image format. Showing default image instead.")
                                pro_pic.Image = My.Resources._34AD2
                            End Try
                        Else
                            pro_pic.Image = My.Resources._34AD2
                        End If
                    Else
                        pro_pic.Image = My.Resources._34AD2
                    End If
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

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub pro_pic_Click(sender As Object, e As EventArgs) Handles pro_pic.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.bmp;*.jpg;*.jpeg;*.png"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            pro_pic.Image = Image.FromFile(openFileDialog1.FileName)
        End If
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Try
            Dim cmd As New OleDbCommand()
            Dim ms As New MemoryStream()

            pro_pic.Image.Save(ms, pro_pic.Image.RawFormat)
            Dim arrImage() As Byte = ms.GetBuffer()
            ms.Close()

            cmd.CommandText = "UPDATE User_Details SET propic = @propic WHERE username = @username"
            cmd.Parameters.AddWithValue("@propic", arrImage)
            cmd.Parameters.AddWithValue("@username", user_name.Text)
            cmd.Connection = conn

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            MsgBox("Profile Updated Successfully" & Environment.NewLine & "It will reflect in your profile on Next Login")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class