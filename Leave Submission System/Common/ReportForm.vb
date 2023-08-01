Imports System.Data.OleDb

Public Class ReportForm
    Dim conn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ConnectString
    Private currentUser As String = Login.user_name.Text

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If leavestat IsNot Nothing Then
            leavestat.Items.Add("All")
            leavestat.Items.Add("Pending")
            leavestat.Items.Add("Approved")
            leavestat.Items.Add("Rejected")
            leavestat.SelectedItem = "All"
        End If

        If leavetype IsNot Nothing Then
            leavetype.Items.Add("All")
            leavetype.Items.Add("Personal Leave")
            leavetype.Items.Add("Medical Leave")
            leavetype.Items.Add("Bereavement Leave")
            leavetype.Items.Add("On-Duty Leave")
            leavetype.SelectedItem = "All"
        End If

        If usertype IsNot Nothing Then
            usertype.Items.Clear()
            usertype.Items.Add("All")
            usertype.Items.Add("Faculty")
            usertype.Items.Add("Student")
            usertype.SelectedItem = "All"
        End If

        If dept IsNot Nothing Then
            dept.Items.Add("All")
            dept.Items.Add("Computer Science")
            dept.Items.Add("Commerce")
            dept.Items.Add("Management")
            dept.SelectedItem = "All"
        End If

        Try
            If IsAdmin(currentUser) Then
                Dim sql As String = "SELECT username FROM User_Details"

                Using connection As New OleDbConnection(conn)
                    Using command As New OleDbCommand(sql, connection)
                        connection.Open()
                        Dim reader = command.ExecuteReader()
                        While reader.Read()
                            usertype.Items.Clear()
                            usertype.Items.Add("All")
                            usertype.Items.Add("Faculty")
                            usertype.Items.Add("Student")
                            usertype.SelectedItem = "All"
                        End While
                    End Using
                End Using
            Else
                usertype.Items.Add(currentUser)
                usertype.SelectedItem = currentUser
                usertype.Hide()
                dept.Hide()
                BunifuLabel5.Hide()
                BunifuLabel3.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        leavestat.SelectedIndex = 0
        leavetype.SelectedIndex = 0
        usertype.SelectedIndex = 0
        dept.SelectedIndex = 0

        LoadReport()
    End Sub

    Private Sub LoadReport()
        Try
            If leavestat Is Nothing OrElse leavetype Is Nothing OrElse usertype Is Nothing OrElse dept Is Nothing Then
                Return
            End If

            Dim sql As String = "SELECT Leave_Info.leave_ID, Leave_Info.username, User_Details.firstname, User_Details.lastname, Leave_Info.leave_type, Leave_Info.from_date, Leave_Info.no_of_days, Leave_Info.leave_status FROM Leave_Info ,User_Details where Leave_Info.username=User_Details.username"

            If leavestat.SelectedItem IsNot Nothing AndAlso leavestat.SelectedItem.ToString() <> "All" Then
                sql += " AND leave_status='" & leavestat.SelectedItem.ToString() & "'"
            End If

            If leavetype.SelectedItem IsNot Nothing AndAlso leavetype.SelectedItem.ToString() <> "All" Then
                sql += " AND leave_type='" & leavetype.SelectedItem.ToString() & "'"
            End If

            If usertype.SelectedItem IsNot Nothing AndAlso usertype.SelectedItem.ToString() <> "All" Then
                If usertype.SelectedItem = "Faculty" Then
                    sql += " AND Leave_Info.username LIKE 'Fac%'"
                ElseIf usertype.SelectedItem = "Student" Then
                    sql += " AND Leave_Info.username LIKE 'STU%'"
                Else
                    sql += " AND Leave_Info.username='" & usertype.SelectedItem.ToString() & "'"
                End If
            End If

            If dept.SelectedItem IsNot Nothing AndAlso dept.SelectedItem.ToString() <> "All" Then
                sql += " AND department='" & dept.SelectedItem.ToString() & "'"
            End If

            If Not IsAdmin(currentUser) Then
                sql += " AND Leave_Info.username='" & currentUser & "'"
            End If

            Using connection As New OleDbConnection(conn)
                Using command As New OleDbCommand(sql, connection)
                    Dim adapter As New OleDbDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    reportleave.DataSource = table
                End Using
            End Using

            reportleave.Columns("leave_ID").HeaderText = "Leave ID"
            reportleave.Columns("username").HeaderText = "User ID"
            reportleave.Columns("firstname").HeaderText = "First Name"
            reportleave.Columns("lastname").HeaderText = "Last Name"
            reportleave.Columns("leave_type").HeaderText = "Type of Leave"
            reportleave.Columns("from_date").HeaderText = "Starting Date"
            reportleave.Columns("no_of_days").HeaderText = "No Of Days"
            reportleave.Columns("leave_status").HeaderText = "Leave Status"
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub FilterChanged(sender As Object, e As EventArgs) Handles leavestat.SelectedIndexChanged, leavetype.SelectedIndexChanged, usertype.SelectedIndexChanged, dept.SelectedIndexChanged
        LoadReport()
    End Sub

    Private Function IsAdmin(username As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM Admin_login WHERE username=@username"
        Using connection As New OleDbConnection(conn)
            Using command As New OleDbCommand(sql, connection)
                command.Parameters.AddWithValue("@username", username)
                connection.Open()
                Dim count As Integer = CInt(command.ExecuteScalar())
                If count > 0 Then
                    Return True
                End If
            End Using
        End Using
        Return False
    End Function

    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private dgv As New DataGridView()
    Private mRow As Integer = 0
    Private newPage As Boolean = True

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim format As New StringFormat
        format.Alignment = StringAlignment.Center
        e.Graphics.DrawString("Leave Submission Details", New Font("Arial Black", 20, FontStyle.Bold), Brushes.Black, New Point(600, 40), format)

        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter

        Dim y As Integer = 100
        Dim x As Integer = 50
        Dim h As Integer = 0
        Dim rc As Rectangle
        Dim row As DataGridViewRow

        Dim fmt1 As New StringFormat()
        fmt1.Alignment = StringAlignment.Center
        fmt1.LineAlignment = StringAlignment.Center
        fmt1.Trimming = StringTrimming.EllipsisCharacter
        Dim headerFont As New Font("Segoe UI", 10, FontStyle.Bold)
        Dim Font As New Font("Segoe UI", 10, FontStyle.Regular)

        If newPage Then
            If mRow < reportleave.Rows.Count Then
                row = reportleave.Rows(mRow)
                x = 50
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Visible Then
                        rc = New Rectangle(x, y, 133.8, cell.Size.Height)
                        e.Graphics.FillRectangle(Brushes.LightGray, rc)
                        e.Graphics.DrawRectangle(Pens.Black, rc)
                        e.Graphics.DrawString(reportleave.Columns(cell.ColumnIndex).HeaderText, headerFont, Brushes.Black, rc, fmt1)
                        x += rc.Width
                        h = Math.Max(h, rc.Height)
                    End If
                Next
                y += h
            End If
        End If

        newPage = False
        Dim displayNow As Integer
        For displayNow = mRow To reportleave.RowCount - 1
            row = reportleave.Rows(displayNow)
            x = 50
            h = 0
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, 133.8, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc)
                    fmt.Alignment = StringAlignment.Near
                    rc.Offset(10, 0)
                    e.Graphics.DrawString(cell.FormattedValue.ToString(), Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h
            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                mRow = displayNow + 1
                newPage = True
                Exit Sub
            End If
        Next
        mRow = 0
        newPage = True
        e.HasMorePages = False
    End Sub
End Class