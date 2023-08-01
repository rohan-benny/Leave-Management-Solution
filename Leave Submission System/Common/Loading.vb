Public Class Loading
    Private Sub Load_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub BunifuProgressBar1_ProgressChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuProgressBar.ProgressChangedEventArgs) Handles BunifuProgressBar1.ProgressChanged
        If BunifuProgressBar1.Value = 100 Then
            Login.Show()
            Timer1.Stop()
            Me.Hide()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If BunifuProgressBar1.Value < 100 Then
            BunifuProgressBar1.Value = BunifuProgressBar1.Value + 1
        End If
    End Sub
End Class