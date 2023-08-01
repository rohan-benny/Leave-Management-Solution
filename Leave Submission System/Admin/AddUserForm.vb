Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Public Class Adduserform
    Private conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ConnectString)

    Private Sub Adduserform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserType.Items.Add("Student")
        UserType.Items.Add("Faculty")

        dept.Items.Add("Computer Science")
        dept.Items.Add("Commerce")
        dept.Items.Add("Management")

        BunifuPanel1.Enabled = False
    End Sub

    Private Sub UserType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserType.SelectedIndexChanged
        BunifuPanel1.Enabled = True
        Dim prefix As String
        If UserType.SelectedIndex = 0 Then
            prefix = "STU"
            crs.Show()
            sem.Show()
            BunifuLabel12.Show()
            BunifuLabel6.Show()
        ElseIf UserType.SelectedIndex = 1 Then
            prefix = "FAC"
            crs.Hide()
            sem.Hide()
            BunifuLabel12.Hide()
            BunifuLabel6.Hide()
        Else
            prefix = ""
        End If
        Dim username As String = GenerateUsername(prefix)
        user_name.Text = username
    End Sub

    Private Function GenerateUsername(prefix As String) As String
        Dim username As String = ""
        Dim exists As Boolean = True
        Dim count As Integer = 1

        conn.Open()
        Dim cmd As New OleDbCommand("SELECT TOP 1 Username FROM User_Details WHERE Username LIKE @Prefix ORDER BY Username DESC", conn)
        cmd.Parameters.AddWithValue("@Prefix", prefix & "_%")
        Dim lastUsername As Object = cmd.ExecuteScalar()
        conn.Close()

        If lastUsername IsNot Nothing AndAlso lastUsername.ToString().StartsWith(prefix & "_") Then
            Dim lastNumber As Integer = Integer.Parse(lastUsername.ToString().Substring(prefix.Length + 1))
            count = lastNumber + 1
        End If

        Do While exists
            username = prefix & "_" & count.ToString("0000")
            exists = CheckUsernameExists(username)
            count += 1
        Loop
        Return username
    End Function

    Private Function CheckUsernameExists(username As String) As Boolean
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM User_Details WHERE Username=@Username", conn)
        cmd.Parameters.AddWithValue("@Username", username)
        Dim count As Integer = cmd.ExecuteScalar()
        conn.Close()
        Return count > 0
    End Function

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        If UserType.SelectedItem = "Faculty" Then
            crs.Items.Add("None")
            sem.Items.Add("None")

            crs.SelectedItem = "None"
            sem.SelectedItem = "None"
        End If
        Dim username As String = user_name.Text
        Dim password As String = "1234"
        Dim firstName As String = first_name.Text
        Dim lastName As String = last_name.Text
        Dim mail As String = email.Text
        Dim phone As String = phoneno.Text
        Dim department As String = dept.SelectedItem
        Dim course As String = crs.SelectedItem
        Dim semester As String = sem.SelectedItem
        Dim balleave As String = "25"
        Dim photo As String = ""
        Try
            conn.Open()
            Dim cmd1 As New OleDbCommand("INSERT INTO User_Login VALUES (?, ?);", conn)
            cmd1.Parameters.AddWithValue("@username", username)
            cmd1.Parameters.AddWithValue("@password", password)
            cmd1.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Try
            If Not String.IsNullOrEmpty(first_name.Text) AndAlso Not String.IsNullOrEmpty(phoneno.Text) AndAlso Not String.IsNullOrEmpty(dept.SelectedItem) Then
                conn.Open()
                Dim cmd As New OleDbCommand("INSERT INTO User_Details VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?);", conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@firstname", firstName)
                cmd.Parameters.AddWithValue("@lastname", lastName)
                cmd.Parameters.AddWithValue("@email", mail)
                cmd.Parameters.AddWithValue("@phoneno", phone)
                cmd.Parameters.AddWithValue("@department", department)
                cmd.Parameters.AddWithValue("@course", course)
                cmd.Parameters.AddWithValue("@semester", semester)
                cmd.Parameters.AddWithValue("@balleave", balleave)
                cmd.Parameters.AddWithValue("@propic", photo)
                cmd.ExecuteNonQuery()
                conn.Close()

                Dim message As New MailMessage()
                message.From = New MailAddress("lmsleavemanager@gmail.com")
                message.To.Add(email.Text)
                message.Subject = "LOGIN CREDENTIAL"
                message.Body = String.Format("Dear " & first_name.Text & " " & last_name.Text & "," & vbCrLf & vbCrLf &
              "You have been added to Leave Management Solution application where you can submit your leave application." & vbCrLf &
                    "Your Login Credential To access your account:" & vbCrLf & vbCrLf &
                    "      Username: " & user_name.Text & vbCrLf &
                    "      Password: 1234" & vbCrLf & vbCrLf &
                    "After login into you account, change your password. Follow these steps" & vbCrLf &
                    "Settings -> Change Password" & vbCrLf & vbCrLf & vbCrLf &
                    "If you have any query, please feel free to contact" & vbCrLf & vbCrLf &
                    "Warm regards," & vbCrLf &
                    "Leave administrator")

                Dim client As New SmtpClient()
                client.Host = "smtp.gmail.com"
                client.Port = 587
                client.UseDefaultCredentials = False
                client.Credentials = New System.Net.NetworkCredential("lmsleavemanager@gmail.com", "cebjpkqjrvsglvsk")
                client.EnableSsl = True

                client.Send(message)

                MessageBox.Show("Added successfully!")
                Clearbtn.PerformClick()

            Else
                MessageBox.Show("Please fill all the required fields.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub dept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dept.SelectedIndexChanged
        If dept.SelectedItem = "Computer Science" Then
            crs.Text = "select course"
            crs.Items.Clear()
            crs.Items.Add("BCA")
            crs.Items.Add("Bsc CSMS")
            crs.Items.Add("Bsc CSME")
            crs.Items.Add("Bsc LS")
        ElseIf dept.SelectedItem = "Commerce" Then
            crs.Text = "select course"
            crs.Items.Clear()
            crs.Items.Add("B.com")
            crs.Items.Add("B.com Honors")
            crs.Items.Add("B.com Tourism")
            crs.Items.Add("B.com ACCA")
        ElseIf dept.SelectedItem = "Management" Then
            crs.Text = "select course"
            crs.Items.Clear()
            crs.Items.Add("BBA")
            crs.Items.Add("BBA BA")
        End If

        sem.Items.Clear()
        sem.Items.Add("I sem")
        sem.Items.Add("II sem")
        sem.Items.Add("III sem")
        sem.Items.Add("IV sem")
        sem.Items.Add("V sem")
        sem.Items.Add("VI sem")
    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        BunifuPanel1.Enabled = False
        UserType.Text = "Select User"
        user_name.Text = ""
        first_name.Text = ""
        last_name.Text = ""
        email.Text = ""
        phoneno.Text = ""
        dept.Text = "Select Department"
        crs.Text = "Select Course"
        crs.Items.Clear()
        sem.Text = "Select Semester"
    End Sub

    Private Sub phoneno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phoneno.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Only Number Are Allowed.", "ALERT")
        End If
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        If phoneno.Text.Length = 10 And e.KeyChar <> ChrW(Keys.Back) Then
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

    Private Sub phoneno_Validating(sender As Object, e As EventArgs) Handles phoneno.Validating
        If phoneno.Text.Count < 10 Then
            MessageBox.Show("Enter a Valid Phone Number")
        End If
    End Sub
End Class