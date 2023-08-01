Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class ModifyUserForm
    Private conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ConnectString)

    Private Sub ModifyUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuPanel1.Hide()
        ModifyBtn.Hide()

        dept.Items.Add("Computer Science")
        dept.Items.Add("Commerce")
        dept.Items.Add("Management")
    End Sub

    Private Sub user_name_KeyDown(sender As Object, e As KeyEventArgs) Handles user_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            If user_name.Text.StartsWith("FAC") Then
                crs.Hide()
                sem.Hide()
                BunifuLabel12.Hide()
                BunifuLabel6.Hide()
            Else
                dept_SelectedIndexChanged(sender, e)

                crs.Show()
                sem.Show()
                BunifuLabel12.Show()
                BunifuLabel6.Show()
            End If

            BunifuPanel1.Show()
            ModifyBtn.Show()

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
                        dept.SelectedItem = reader("department").ToString()
                        crs.SelectedItem = reader("course").ToString()
                        sem.SelectedItem = reader("semester").ToString()
                    End If
                    reader.Close()
                    conn.Close()
                Else
                    BunifuPanel1.Hide()
                    ModifyBtn.Hide()
                    MessageBox.Show("User not found")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub user_name_TextChanged(sender As Object, e As EventArgs) Handles user_name.TextChanged
        BunifuPanel1.Hide()
        ModifyBtn.Hide()
    End Sub

    Private Sub dept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dept.SelectedIndexChanged
        If dept.SelectedItem = "Computer Science" Then
            crs.Text = "select course"
            crs.Items.Clear()
            crs.Items.Add("BCA")
            crs.Items.Add("CSMS")
        ElseIf dept.SelectedItem = "Commerce" Then
            crs.Text = "select course"
            crs.Items.Clear()
            crs.Items.Add("B.com")
            crs.Items.Add("CA")
        ElseIf dept.SelectedItem = "Management" Then
            crs.Text = "select course"
            crs.Items.Clear()
            crs.Items.Add("BBA")
        End If

        sem.Items.Add("I sem")
        sem.Items.Add("II sem")
        sem.Items.Add("III sem")
        sem.Items.Add("IV sem")
        sem.Items.Add("V sem")
        sem.Items.Add("VI sem")
    End Sub

    Private Sub ModifyBtn_Click(sender As Object, e As EventArgs) Handles ModifyBtn.Click
        If user_name.Text.StartsWith("FAC") Then
            crs.Items.Add("None")
            sem.Items.Add("None")

            crs.SelectedItem = "None"
            sem.SelectedItem = "None"
        End If

        Try
            If Not String.IsNullOrEmpty(first_name.Text) AndAlso Not String.IsNullOrEmpty(last_name.Text) AndAlso Not String.IsNullOrEmpty(phoneno.Text) AndAlso Not String.IsNullOrEmpty(dept.SelectedItem) Then
                Dim cmd As New OleDbCommand()

                cmd.CommandText = "UPDATE User_Details SET firstname = @firstname, lastname = @lastname, email = @email, phoneno = @phoneno, department = @dept, course = @course, semester=@semester WHERE username = @username"
                cmd.Parameters.AddWithValue("@firstname", first_name.Text.Trim())
                cmd.Parameters.AddWithValue("@lastname", last_name.Text.Trim())
                cmd.Parameters.AddWithValue("@email", email.Text.Trim())
                cmd.Parameters.AddWithValue("@phoneno", phoneno.Text.Trim())
                cmd.Parameters.AddWithValue("@dept", dept.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@course", crs.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@semester", sem.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@username", user_name.Text.Trim())
                cmd.Connection = conn

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Information updated successfully!")
                    BunifuPanel1.Hide()
                    ModifyBtn.Hide()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            Else
                MessageBox.Show("Please fill all the required fields.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub phoneno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phoneno.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Only Number Are Allowed.", "ALERT")
        End If

        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        If phoneno.Text.Length >= 10 And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub email_Leave(sender As Object, e As EventArgs) Handles email.Leave
        If email.Text = "" Then
        Else
            Dim emailRegex As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
            If Not emailRegex.IsMatch(email.Text) Then
                MessageBox.Show("Invalid email address. Please enter a valid email address.", "ALERT")
                email.Clear()
            End If
        End If
    End Sub
End Class