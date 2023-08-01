Imports System.Data.OleDb
Public Class AdminDashForm
    Private conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ConnectString)

    Private Sub user_MouseLeave(sender As Object, e As EventArgs) Handles user.MouseLeave, BunifuPictureBox1.MouseLeave, BunifuGradientPanel2.MouseLeave
        user.Text = "User"
    End Sub

    Private Sub pending_MouseLeave(sender As Object, e As EventArgs) Handles pending.MouseLeave, BunifuPictureBox2.MouseLeave, BunifuGradientPanel3.MouseLeave
        pending.Text = "Pending Leave"
    End Sub

    Private Sub approved_MouseLeave(sender As Object, e As EventArgs) Handles BunifuPictureBox3.MouseLeave, BunifuGradientPanel4.MouseLeave, approved.MouseLeave
        approved.Text = "Approved Leave"
    End Sub

    Private Sub rejected_MouseLeave(sender As Object, e As EventArgs) Handles rejected.MouseLeave, BunifuPictureBox4.MouseLeave, BunifuGradientPanel5.MouseLeave
        rejected.Text = "Rejected Leave"
    End Sub

    Private Sub user_MouseEnter(sender As Object, e As EventArgs) Handles user.MouseEnter, BunifuPictureBox1.MouseEnter, BunifuGradientPanel2.MouseEnter
        Try
            Dim query As String = "SELECT COUNT(*) FROM User_Details "
            conn.Open()
            Using command As New OleDbCommand(query, conn)
                Dim us_er As Object = command.ExecuteScalar()
                If us_er IsNot Nothing Then
                    user.Text = us_er.ToString()
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub pending_MouseEnter(sender As Object, e As EventArgs) Handles pending.MouseEnter, BunifuPictureBox2.MouseEnter, BunifuGradientPanel3.MouseEnter
        Try
            Dim query As String = "SELECT COUNT(*) FROM leave_Info WHERE leave_status=@pending"
            conn.Open()
            Using command As New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("@pending", "Pending")
                Dim pend As Object = command.ExecuteScalar()
                If pend IsNot Nothing Then
                    pending.Text = pend.ToString()
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub approved_MouseEnter(sender As Object, e As EventArgs) Handles BunifuPictureBox3.MouseEnter, BunifuGradientPanel4.MouseEnter, approved.MouseEnter
        Try
            Dim query As String = "SELECT COUNT(*) FROM leave_Info WHERE leave_status=@approved"
            conn.Open()
            Using command As New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("@approved", "Approved")
                Dim approve As Object = command.ExecuteScalar()
                If approve IsNot Nothing Then
                    approved.Text = approve.ToString()
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub rejected_MouseEnter(sender As Object, e As EventArgs) Handles rejected.MouseEnter, BunifuPictureBox4.MouseEnter, BunifuGradientPanel5.MouseEnter
        Try
            Dim query As String = "SELECT COUNT(*) FROM leave_Info where leave_status=@rejected"
            conn.Open()
            Using command As New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("@rejected", "Rejected")
                Dim reject As Object = command.ExecuteScalar()
                If reject IsNot Nothing Then
                    rejected.Text = reject.ToString()
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class