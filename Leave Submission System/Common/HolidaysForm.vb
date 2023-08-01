Imports System.Data.OleDb
Public Class HolidaysForm
    Private conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ConnectString)

    Private Sub HolidaysForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String = "SELECT * FROM Holidays ORDER BY Date;"
            Using command As New OleDbCommand(sql, conn)
                Dim adapter As New OleDbDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                holidays.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class