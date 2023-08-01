Imports System.Data.OleDb
Public Class UserHomeForm
    Private conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ConnectString)
    Dim loggedInUser As String

    Private Sub UserHomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Note.Location = New Point(1039, Note.Location.Y)
    End Sub

    Private Sub bal_MouseLeave(sender As Object, e As EventArgs) Handles BunifuPictureBox1.MouseLeave, BunifuGradientPanel2.MouseLeave, bal.MouseLeave
        bal.Text = "Balance Leave"
    End Sub

    Private Sub Pending_MouseLeave(sender As Object, e As EventArgs) Handles Pending.MouseLeave, BunifuPictureBox2.MouseLeave, BunifuGradientPanel3.MouseLeave
        Pending.Text = "Pending Leave"
    End Sub

    Private Sub Approved_MouseLeave(sender As Object, e As EventArgs) Handles BunifuPictureBox3.MouseLeave, BunifuGradientPanel4.MouseLeave, Approved.MouseLeave
        Approved.Text = "Approved Leave"
    End Sub

    Private Sub Rejected_MouseLeave(sender As Object, e As EventArgs) Handles Rejected.MouseLeave, BunifuPictureBox4.MouseLeave, BunifuGradientPanel5.MouseLeave
        Rejected.Text = "Rejected Leave"
    End Sub

    Private Sub bal_MouseEnter(sender As Object, e As EventArgs) Handles BunifuPictureBox1.MouseEnter, BunifuGradientPanel2.MouseEnter, bal.MouseEnter
        Try
            loggedInUser = ApplyLeaveForm.user_name.Text
            Dim query As String = "SELECT balleave FROM User_Details WHERE username = @username"
            conn.Open()
            Using command As New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("@username", loggedInUser)
                Dim balanceLeave As Object = command.ExecuteScalar()
                If balanceLeave IsNot Nothing Then
                    bal.Text = balanceLeave.ToString()
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Pending_MouseEnter(sender As Object, e As EventArgs) Handles Pending.MouseEnter, BunifuPictureBox2.MouseEnter, BunifuGradientPanel3.MouseEnter
        Try
            loggedInUser = ApplyLeaveForm.user_name.Text
            Dim query As String = "SELECT COUNT(*) FROM leave_Info where username=@username and leave_status='Pending'"
            conn.Open()
            Using command As New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("@username", loggedInUser)
                Dim pend As Object = command.ExecuteScalar()
                If pend IsNot Nothing Then
                    Pending.Text = pend.ToString()
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Approved_MouseEnter(sender As Object, e As EventArgs) Handles BunifuPictureBox3.MouseEnter, BunifuGradientPanel4.MouseEnter, Approved.MouseEnter
        Try
            loggedInUser = ApplyLeaveForm.user_name.Text
            Dim query As String = "SELECT COUNT(*) FROM leave_Info where username=@username and leave_status='Approved'"
            conn.Open()
            Using command As New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("@username", loggedInUser)
                Dim approve As Object = command.ExecuteScalar()
                If approve IsNot Nothing Then
                    Approved.Text = approve.ToString()
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Rejected_MouseEnter(sender As Object, e As EventArgs) Handles Rejected.MouseEnter, BunifuPictureBox4.MouseEnter, BunifuGradientPanel5.MouseEnter
        Try
            loggedInUser = ApplyLeaveForm.user_name.Text
            Dim query As String = "SELECT COUNT(*) FROM leave_Info where username=@username and leave_status='Rejected'"
            conn.Open()
            Using command As New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("@username", loggedInUser)
                Dim reject As Object = command.ExecuteScalar()
                If reject IsNot Nothing Then
                    Rejected.Text = reject.ToString()
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Note.Location.X > -653 Then
            Note.Location = New Point(Note.Location.X - 6, Note.Location.Y)
        Else
            Note.Location = New Point(1039, Note.Location.Y)
        End If
    End Sub
End Class