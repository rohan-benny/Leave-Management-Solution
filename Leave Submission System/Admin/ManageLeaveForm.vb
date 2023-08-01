Imports System.Data.OleDb
Imports System.Net.Mail

Public Class ManageLeaveForm
    Private conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ConnectString)

    Private Sub ManageLeaveForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuPanel1.Enabled = False
        BunifuPanel2.Enabled = False

        Try
            Dim sql As String = "SELECT Leave_Info.leave_ID, Leave_Info.username, User_Details.firstname, User_Details.lastname, Leave_Info.leave_type, Leave_Info.from_date, Leave_Info.no_of_days, Leave_Info.leave_status FROM Leave_Info ,User_Details where Leave_Info.username=User_Details.username AND leave_status='Pending';"
            Using command As New OleDbCommand(sql, conn)
                Dim adapter As New OleDbDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                Leave_Manage.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        Leave_Manage.Columns("leave_ID").HeaderText = "Leave ID"
        Leave_Manage.Columns("username").HeaderText = "UserName"
        Leave_Manage.Columns("firstname").HeaderText = "First Name"
        Leave_Manage.Columns("lastname").HeaderText = "last Name"
        Leave_Manage.Columns("leave_type").HeaderText = "Leave Type"
        Leave_Manage.Columns("from_date").HeaderText = "Starting Date"
        Leave_Manage.Columns("no_of_days").HeaderText = "No of Days"
        Leave_Manage.Columns("leave_status").HeaderText = "Leave Status"

        user_name.Text = ""
        first_name.Text = ""
        last_name.Text = ""
        email.Text = ""
        phone.Text = ""
        dept.Text = ""
        crs.Text = ""
        sem.Text = ""

        Leaveid.Text = ""
        Leavetypebox.Text = ""
        FromDate.Value = DateTime.Today.AddDays(3)
        ToDate.Value = DateTime.Today.AddDays(3)
        NoofDays.Text = ""
        ReasonBox.Text = ""
    End Sub

    Private Sub Leave_Manage_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Leave_Manage.CellClick
        Try
            Dim username As String = Leave_Manage.Rows(e.RowIndex).Cells("username").Value.ToString()
            Dim leave_ID As String = Leave_Manage.Rows(e.RowIndex).Cells("leave_ID").Value.ToString()

            Dim sql As String = "SELECT * FROM Leave_Info,User_Details WHERE Leave_Info.username=@username AND Leave_Info.username=User_Details.username AND Leave_Info.leave_ID=@leave_ID;"
            Using command As New OleDbCommand(sql, conn)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@leave_ID", leave_ID)
                conn.Open()
                Using reader As OleDbDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        user_name.Text = reader("User_Details.username").ToString()
                        first_name.Text = reader("firstname").ToString()
                        last_name.Text = reader("lastname").ToString()
                        email.Text = reader("email").ToString()
                        phone.Text = reader("phoneno").ToString()
                        dept.Text = reader("department").ToString()
                        crs.Text = reader("course").ToString()
                        sem.Text = reader("semester").ToString()

                        Leaveid.Text = reader("leave_ID").ToString()
                        Leavetypebox.Text = reader("leave_type").ToString()
                        FromDate.Value = DateTime.Parse(reader("from_date").ToString())
                        ToDate.Value = DateTime.Parse(reader("to_date").ToString())
                        NoofDays.Text = reader("no_of_days").ToString()
                        ReasonBox.Text = reader("reason").ToString()

                        If user_name.Text.StartsWith("FAC") Then
                            crs.Hide()
                            sem.Hide()
                            BunifuLabel16.Hide()
                            BunifuLabel1.Hide()
                        Else
                            crs.Show()
                            sem.Show()
                            BunifuLabel16.Show()
                            BunifuLabel1.Show()
                        End If
                    End If
                End Using
                conn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Sub Submitbtn_Click(sender As Object, e As EventArgs) Handles Submitbtn.Click
        Try
            Dim sql As String = "UPDATE Leave_Info SET leave_status='Approved' WHERE username=@username AND leave_ID=@leave_ID;"
            Using command As New OleDbCommand(sql, conn)
                command.Parameters.AddWithValue("@username", user_name.Text)
                command.Parameters.AddWithValue("@leave_ID", Leaveid.Text)
                conn.Open()
                command.ExecuteNonQuery()
                conn.Close()
            End Using

            Dim applicationNumber As String = Leaveid.Text
            Dim sql1 As String = "SELECT firstname, lastname, leave_type, from_date, to_date FROM Leave_Info, User_Details WHERE leave_ID=@applicationNumber and Leave_Info.username=User_Details.username;"
            Using command As New OleDbCommand(sql1, conn)
                command.Parameters.AddWithValue("@applicationNumber", applicationNumber)
                conn.Open()
                Using reader As OleDbDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim firstname As String = reader("firstname").ToString()
                        Dim lastname As String = reader("lastname").ToString()
                        Dim leavetype As String = reader("leave_type").ToString()
                        Dim startDate As DateTime = DateTime.Parse(reader("from_date").ToString())
                        Dim endDate As DateTime = DateTime.Parse(reader("to_date").ToString())

                        Try
                            Dim message As New MailMessage()
                            message.From = New MailAddress("lmsleavemanager@gmail.com")
                            message.To.Add(email.Text)
                            message.Subject = "LEAVE APPROVAL"
                            message.Body = String.Format("Dear " & firstname & " " & lastname & "," & vbCrLf & vbCrLf &
                        "With reference to your application number: " & applicationNumber & ", we have received your request for " & leavetype & " from " & startDate.ToString("dd/MM/yyyy") & " to " & endDate.ToString("dd/MM/yyyy") & "." & vbCrLf & vbCrLf &
                            "We would like to inform you that your leave request has been Accepted." & vbCrLf & vbCrLf &
                            "Warm regards," & vbCrLf &
                            "Leave administrator")

                            Dim client As New SmtpClient()
                            client.Host = "smtp.gmail.com"
                            client.Port = 587
                            client.UseDefaultCredentials = False
                            client.Credentials = New System.Net.NetworkCredential("lmsleavemanager@gmail.com", "cebjpkqjrvsglvsk")
                            client.EnableSsl = True

                            client.Send(message)

                            MessageBox.Show("Approved The Leave")
                        Catch ex As Exception
                            MessageBox.Show("Error: " & ex.Message)
                        Finally
                        End Try
                    Else
                        MessageBox.Show("Invalid application number.")
                    End If
                End Using
                conn.Close()
            End Using

            If Leavetypebox.Text <> "On-Duty Leave" Then
                Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Kristu Jayanti College\SE Project\Leave Submission System\Leave Submission System.mdb"
                Dim cmd As New OleDbCommand("UPDATE User_Details SET balleave = balleave - ? WHERE username = ?", conn)
                cmd.Parameters.AddWithValue("@leaveDays", CInt(NoofDays.Text))
                cmd.Parameters.AddWithValue("@username", user_name.Text)
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conn.Close()
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        ManageLeaveForm_Load(sender, e)
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        Dim username As String = user_name.Text

        Dim sql As String = "UPDATE Leave_Info SET leave_status='Rejected' WHERE username=@username AND leave_ID=@leave_ID;"
        Using command As New OleDbCommand(sql, conn)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@leave_ID", Leaveid.Text)

            conn.Open()
            command.ExecuteNonQuery()
        End Using
        conn.Close()

        Dim applicationNumber As String = Leaveid.Text
        Dim sql1 As String = "SELECT firstname, lastname, leave_type, from_date, to_date FROM Leave_Info, User_Details WHERE leave_ID=@applicationNumber and Leave_Info.username=User_Details.username;"
        Using command As New OleDbCommand(sql1, conn)
            command.Parameters.AddWithValue("@applicationNumber", applicationNumber)
            conn.Open()
            Using reader As OleDbDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Dim firstname As String = reader("firstname").ToString()
                    Dim lastname As String = reader("lastname").ToString()
                    Dim leavetype As String = reader("leave_type").ToString()
                    Dim startDate As DateTime = DateTime.Parse(reader("from_date").ToString())
                    Dim endDate As DateTime = DateTime.Parse(reader("to_date").ToString())

                    Try
                        Dim message As New MailMessage()
                        message.From = New MailAddress("lmsleavemanager@gmail.com")
                        message.To.Add(email.Text)
                        message.Subject = "LEAVE APPROVAL"
                        message.Body = String.Format("Dear " & firstname & " " & lastname & "," & vbCrLf & vbCrLf &
                    "With reference to your application number: " & applicationNumber & ", we have received your request for " & leavetype & " from " & startDate.ToString("dd/MM/yyyy") & " to " & endDate.ToString("dd/MM/yyyy") & "." & vbCrLf & vbCrLf &
                        "We would like to inform you that your leave request has been Rejected." & vbCrLf & vbCrLf &
                        "Warm regards," & vbCrLf &
                        "Leave administrator")

                        Dim client As New SmtpClient()
                        client.Host = "smtp.gmail.com"
                        client.Port = 587
                        client.UseDefaultCredentials = False
                        client.Credentials = New System.Net.NetworkCredential("lmsleavemanager@gmail.com", "cebjpkqjrvsglvsk")
                        client.EnableSsl = True

                        client.Send(message)
                        MessageBox.Show("Rejected The Leave")
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    Finally
                    End Try

                Else
                    MessageBox.Show("Invalid application number.")
                End If
            End Using
            conn.Close()
        End Using
        ManageLeaveForm_Load(sender, e)
    End Sub
End Class