Imports System.Data.OleDb
Imports System.IO
Public Class UserForm
    Private conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ConnectString)
    Private loggedInUser As String

    Public Sub New(username As String)
        Try
            InitializeComponent()
            Dim cmd As New OleDbCommand("SELECT * FROM User_Details WHERE username = @username", conn)
            cmd.Parameters.AddWithValue("@username", username)
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                ApplyLeaveForm.user_name.Text = reader("username")
                ApplyLeaveForm.first_name.Text = reader("firstname")
                ApplyLeaveForm.last_name.Text = reader("lastname")
                ApplyLeaveForm.email.Text = reader("email")
                ApplyLeaveForm.phone.Text = reader("phoneno")
                ApplyLeaveForm.dept.Text = reader("department")
                ApplyLeaveForm.crs.Text = reader("course")
                ApplyLeaveForm.sem.Text = reader("semester")
            End If

            If Not reader.IsDBNull(reader.GetOrdinal("propic")) Then
                Dim imageData As Byte() = DirectCast(reader("propic"), Byte())
                If imageData.Length > 0 Then
                    Dim ms As New MemoryStream(imageData)
                    Try
                        Dim image As Image = Image.FromStream(ms)
                        profilepic.Image = image
                    Catch ex As ArgumentException
                        MessageBox.Show("Invalid image format. Showing default image instead.")
                        profilepic.Image = My.Resources._34AD2
                    End Try
                Else
                    profilepic.Image = My.Resources._34AD2
                End If
            Else
                profilepic.Image = My.Resources._34AD2
            End If

            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowForm(form As Form)
        BunifuGradientPanel2.Controls.Clear()
        form.TopLevel = False
        BunifuGradientPanel2.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        User.LabelText = ApplyLeaveForm.first_name.Text + " " + ApplyLeaveForm.last_name.Text

        HomeButton_Click(sender, e)
        HomeButton.PerformClick()
    End Sub

    Private Sub exiticon_Click(sender As Object, e As EventArgs) Handles exiticon.Click
        Dim response As Integer
        response = MessageBox.Show("            Do You Want To Logout?", "LOGGING OUT", MessageBoxButtons.YesNo)
        If response = vbYes Then
            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub ApplyLeave_Click(sender As Object, e As EventArgs) Handles ApplyLeave.Click
        ShowForm(ApplyLeaveForm)
    End Sub

    Private Sub LeaveStatus_Click(sender As Object, e As EventArgs) Handles LeaveStatus.Click
        ShowForm(LeaveStatusForm)

        loggedInUser = ApplyLeaveForm.user_name.Text
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        ShowForm(UserHomeForm)
    End Sub

    Private Sub settings_Click(sender As Object, e As EventArgs) Handles settings.Click
        ShowForm(SettingsForm)

        SettingsForm.ContactAdminBtn.Show()
        SettingsForm.editpro.Enabled = True
    End Sub

    Private Sub calendar_Click(sender As Object, e As EventArgs) Handles Holidays.Click
        ShowForm(HolidaysForm)
    End Sub

    Private Sub help_Click(sender As Object, e As EventArgs) Handles help.Click
        ShowForm(HelpForm)
    End Sub

    Private Sub ReportUser_Click(sender As Object, e As EventArgs) Handles ReportUser.Click
        ShowForm(ReportForm)
    End Sub
End Class