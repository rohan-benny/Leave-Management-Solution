Imports System.Data.OleDb
Public Class LeaveStatusForm
    Private conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ConnectString)
    Private loggedInUser As String

    Private Sub LeaveStatusForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuPanel2.Enabled = False

        loggedInUser = ApplyLeaveForm.user_name.Text
        Try
            Dim sql As String = "SELECT Leave_Info.leave_ID, Leave_Info.leave_type, Leave_Info.from_date, Leave_Info.no_of_days FROM Leave_Info, User_Details WHERE Leave_Info.username=@username AND Leave_Info.username=User_Details.username ORDER BY Leave_Info.from_date DESC;"
            Using command As New OleDbCommand(sql, conn)
                command.Parameters.AddWithValue("@username", loggedInUser)
                Dim adapter As New OleDbDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                LeaveList.DataSource = table
            End Using

            LeaveList.Columns("leave_ID").HeaderText = "Leave ID"
            LeaveList.Columns("leave_type").HeaderText = "Leave Type"
            LeaveList.Columns("from_date").HeaderText = "Starting Date"
            LeaveList.Columns("no_of_days").HeaderText = "No of Days"
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub LeaveList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LeaveList.CellClick
        Try
            Dim leaveID As String = LeaveList.Rows(e.RowIndex).Cells("leave_ID").Value.ToString()

            Dim sql As String = "SELECT * FROM Leave_Info,User_Details WHERE Leave_Info.leave_ID=@leaveID AND Leave_Info.username=User_Details.username;"
            Using command As New OleDbCommand(sql, conn)
                command.Parameters.AddWithValue("@leaveID", leaveID)
                conn.Open()
                Dim reader As OleDbDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Leavetypebox.Text = reader("leave_type").ToString()
                    FromDate.Value = DateTime.Parse(reader("from_date").ToString())
                    ToDate.Value = DateTime.Parse(reader("to_date").ToString())
                    NoofDays.Text = reader("no_of_days").ToString()
                    ReasonBox.Text = reader("reason").ToString()
                    Leavestatus.Text = reader("leave_status").ToString()
                End If
                reader.Close()
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Do you want to cancel this leave request?", "Cancel", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim row As DataGridViewRow = LeaveList.CurrentRow
                Dim leaveID As Integer = row.Cells("leave_ID").Value
                Dim leaveStatus1 As String = Leavestatus.Text

                If leaveStatus1 = "Pending" OrElse leaveStatus1 = "Approved" Then
                    Dim query As String = "DELETE FROM Leave_Info WHERE leave_ID=@leaveid"
                    conn.Open()
                    Using cmd As New OleDbCommand(query, conn)
                        cmd.Parameters.AddWithValue("@leaveid", leaveID)
                        cmd.ExecuteNonQuery()
                    End Using
                    conn.Close()
                    MessageBox.Show("Leave request has been cancelled.", "Cancelled")
                    LoadData()
                Else
                    MessageBox.Show("Leave request cannot be cancelled as its status is not pending.", "Error")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        LeaveStatusForm_Load(sender, e)
    End Sub

    Private Sub LoadData()
        Try
            Dim sql As String = "SELECT Leave_Info.leave_ID, Leave_Info.leave_type, Leave_Info.from_date, Leave_Info.no_of_days, Leave_Info.status FROM Leave_Info INNER JOIN User_Details ON Leave_Info.username=User_Details.username"
            Using command As New OleDbCommand(sql, conn)
                command.Parameters.AddWithValue("?", loggedInUser)
                Dim adapter As New OleDbDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                LeaveList.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class