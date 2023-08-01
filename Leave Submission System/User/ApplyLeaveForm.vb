Imports System.Data.OleDb
Public Class ApplyLeaveForm
    Private conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ConnectString)

    Private Sub ApplyLeaveForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuPanel1.Enabled = False

        FromDate.Enabled = False
        ToDate.Enabled = False
        NoofDays.Enabled = False
        ReasonBox.Enabled = False
        LeaveID.Enabled = False

        Leavetypebox.Items.Clear()
        Leavetypebox.Items.Add("Personal Leave")
        Leavetypebox.Items.Add("Medical Leave")
        Leavetypebox.Items.Add("Bereavement Leave")
        Leavetypebox.Items.Add("On-Duty Leave")

        FromDate.Value = DateTime.Today
        ToDate.Value = DateTime.Today
        FromDate.MinDate = DateTime.Today.AddDays(-10)
        ToDate.MinDate = DateTime.Today.AddDays(-10)

        Try
            Dim leave_ID As String = ""
            Dim rand As New Random()
            Dim unique As Boolean = False

            Do Until unique
                leave_ID = rand.Next(10000, 99999).ToString()

                Dim sqlLeave As String = "SELECT COUNT(*) FROM Leave_Info WHERE leave_ID = ?"
                Using commandLeave As New OleDbCommand(sqlLeave, conn)
                    commandLeave.Parameters.AddWithValue("leave_ID", leave_ID)
                    conn.Open()
                    Dim count As Integer = CInt(commandLeave.ExecuteScalar())
                    If count = 0 Then
                        unique = True
                    End If
                    conn.Close()
                End Using
            Loop
            LeaveID.Text = leave_ID
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        If user_name.Text.StartsWith("FAC") Then
            crs.Hide()
            sem.Hide()
            BunifuLabel16.Hide()
            BunifuLabel17.Hide()
        Else
            crs.Show()
            sem.Show()
            BunifuLabel16.Show()
            BunifuLabel17.Show()
        End If
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        Leavetypebox.Text = "None"
        FromDate.Value = DateTime.Today
        ToDate.Value = DateTime.Today
        ReasonBox.Text = ""

        FromDate.Enabled = False
        ToDate.Enabled = False
        NoofDays.Enabled = False
        ReasonBox.Enabled = False
    End Sub

    Private Sub ToDate_ValueChanged(sender As Object, e As EventArgs) Handles ToDate.ValueChanged

        Dim startDate As Date = FromDate.Value
        Dim endDate As Date = ToDate.Value
        Dim totalDays As Integer = (endDate - startDate).Days + 1

        Dim holidays As New List(Of Date)
        Try
            conn.Open()
            Dim command As New OleDbCommand("SELECT [Date] FROM [Holidays]", conn)
            Dim reader As OleDbDataReader = command.ExecuteReader()
            While reader.Read()
                holidays.Add(reader.GetDateTime(0))
            End While

            For Each holiday As Date In holidays
                If holiday >= startDate AndAlso holiday <= endDate Then
                    totalDays -= 1
                End If
            Next
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        NoofDays.Text = totalDays
    End Sub

    Private Sub FromDate_ValueChanged(sender As Object, e As EventArgs) Handles FromDate.ValueChanged
        Dim startDate As Date = FromDate.Value
        Dim endDate As Date = ToDate.Value
        Dim days As Integer = (endDate - startDate).Days + 1
        Me.NoofDays.Text = days.ToString

        ToDate.Value = FromDate.Value
    End Sub

    Private Sub Leavetypebox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Leavetypebox.SelectedIndexChanged
        FromDate.Enabled = True
        ToDate.Enabled = True
        ReasonBox.Enabled = True
    End Sub

    Private Sub Submitbtn_Click(sender As Object, e As EventArgs) Handles Submitbtn.Click
        Dim query As String = "SELECT balleave FROM User_Details WHERE username = @username"
        Dim myValue As Integer

        Dim cmd As New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@username", user_name.Text)
        Try
            conn.Open()
            myValue = CInt(cmd.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Dim days As Integer = CInt(NoofDays.Text)

        If Leavetypebox.SelectedIndex = -1 AndAlso ReasonBox.Text = "" Then
            MessageBox.Show("Please Enter the neccessary deatils")
        ElseIf myValue < days Then
            MessageBox.Show("You Don't Have Enough Leave to Apply For the Leave" & Environment.NewLine & "Please Contact Leave Administrator", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
        Else
            Try
                Dim no_of_days As Integer = CInt(NoofDays.Text)
                Dim sqlInsert As String = "INSERT INTO Leave_Info (username, leave_ID, leave_type, from_date, to_date, no_of_days, reason, leave_status) VALUES (?, ?, ?, ?, ?, ?, ?, ?);"
                Using commandInsert As New OleDbCommand(sqlInsert, conn)
                    commandInsert.Parameters.AddWithValue("username", user_name.Text)
                    commandInsert.Parameters.AddWithValue("leave_ID", LeaveID.Text)
                    commandInsert.Parameters.AddWithValue("@leave_type", Leavetypebox.SelectedItem)
                    commandInsert.Parameters.AddWithValue("@from_date", FromDate.Value.ToString("yyyy-MM-dd"))
                    commandInsert.Parameters.AddWithValue("@to_date", ToDate.Value.ToString("yyyy-MM-dd"))
                    commandInsert.Parameters.AddWithValue("@no_of_days", no_of_days)
                    commandInsert.Parameters.AddWithValue("@reason", ReasonBox.Text)
                    commandInsert.Parameters.AddWithValue("@leave_status", "Pending")
                    conn.Open()
                    commandInsert.ExecuteNonQuery()
                    conn.Close()
                End Using

                MessageBox.Show("Successfully submitted leave application." & Environment.NewLine & "Your leave ID is " & LeaveID.Text)

                ClearBtn.PerformClick()
                ApplyLeaveForm_Load(sender, e)
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try

        End If
    End Sub
End Class