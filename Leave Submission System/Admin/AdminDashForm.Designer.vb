<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashForm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.BunifuGradientPanel5 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.BunifuPictureBox4 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.rejected = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel4 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.BunifuPictureBox3 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.approved = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel3 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.BunifuPictureBox2 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.pending = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel2 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.user = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.BunifuGradientPanel5.SuspendLayout()
        CType(Me.BunifuPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel4.SuspendLayout()
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel3.SuspendLayout()
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 17
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderRadius = 17
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuGradientPanel5)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuGradientPanel4)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuGradientPanel3)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuGradientPanel2)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkGray
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkGray
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(1135, 800)
        Me.BunifuGradientPanel1.TabIndex = 1
        '
        'BunifuGradientPanel5
        '
        Me.BunifuGradientPanel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel5.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel5.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel5.BorderRadius = 30
        Me.BunifuGradientPanel5.Controls.Add(Me.BunifuPictureBox4)
        Me.BunifuGradientPanel5.Controls.Add(Me.rejected)
        Me.BunifuGradientPanel5.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuGradientPanel5.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BunifuGradientPanel5.Location = New System.Drawing.Point(709, 427)
        Me.BunifuGradientPanel5.Name = "BunifuGradientPanel5"
        Me.BunifuGradientPanel5.Quality = 10
        Me.BunifuGradientPanel5.Size = New System.Drawing.Size(259, 250)
        Me.BunifuGradientPanel5.TabIndex = 9
        '
        'BunifuPictureBox4
        '
        Me.BunifuPictureBox4.AllowFocused = False
        Me.BunifuPictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox4.AutoSizeHeight = True
        Me.BunifuPictureBox4.BorderRadius = 0
        Me.BunifuPictureBox4.Image = CType(resources.GetObject("BunifuPictureBox4.Image"), System.Drawing.Image)
        Me.BunifuPictureBox4.IsCircle = True
        Me.BunifuPictureBox4.Location = New System.Drawing.Point(54, 30)
        Me.BunifuPictureBox4.Name = "BunifuPictureBox4"
        Me.BunifuPictureBox4.Size = New System.Drawing.Size(144, 144)
        Me.BunifuPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox4.TabIndex = 7
        Me.BunifuPictureBox4.TabStop = False
        Me.BunifuPictureBox4.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'rejected
        '
        Me.rejected.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rejected.ForeColor = System.Drawing.Color.White
        Me.rejected.Location = New System.Drawing.Point(0, 200)
        Me.rejected.Name = "rejected"
        Me.rejected.Size = New System.Drawing.Size(259, 28)
        Me.rejected.TabIndex = 1
        Me.rejected.Text = "Rejected Leave"
        Me.rejected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuGradientPanel4
        '
        Me.BunifuGradientPanel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel4.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel4.BorderRadius = 30
        Me.BunifuGradientPanel4.Controls.Add(Me.BunifuPictureBox3)
        Me.BunifuGradientPanel4.Controls.Add(Me.approved)
        Me.BunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuGradientPanel4.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BunifuGradientPanel4.Location = New System.Drawing.Point(140, 427)
        Me.BunifuGradientPanel4.Name = "BunifuGradientPanel4"
        Me.BunifuGradientPanel4.Quality = 10
        Me.BunifuGradientPanel4.Size = New System.Drawing.Size(259, 250)
        Me.BunifuGradientPanel4.TabIndex = 8
        '
        'BunifuPictureBox3
        '
        Me.BunifuPictureBox3.AllowFocused = False
        Me.BunifuPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox3.AutoSizeHeight = True
        Me.BunifuPictureBox3.BorderRadius = 0
        Me.BunifuPictureBox3.Image = CType(resources.GetObject("BunifuPictureBox3.Image"), System.Drawing.Image)
        Me.BunifuPictureBox3.IsCircle = True
        Me.BunifuPictureBox3.Location = New System.Drawing.Point(59, 30)
        Me.BunifuPictureBox3.Name = "BunifuPictureBox3"
        Me.BunifuPictureBox3.Size = New System.Drawing.Size(144, 144)
        Me.BunifuPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox3.TabIndex = 7
        Me.BunifuPictureBox3.TabStop = False
        Me.BunifuPictureBox3.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'approved
        '
        Me.approved.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.approved.ForeColor = System.Drawing.Color.White
        Me.approved.Location = New System.Drawing.Point(0, 200)
        Me.approved.Name = "approved"
        Me.approved.Size = New System.Drawing.Size(259, 28)
        Me.approved.TabIndex = 1
        Me.approved.Text = "Approved Leave"
        Me.approved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel3.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel3.BorderRadius = 30
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuPictureBox2)
        Me.BunifuGradientPanel3.Controls.Add(Me.pending)
        Me.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(709, 72)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Quality = 10
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(259, 250)
        Me.BunifuGradientPanel3.TabIndex = 7
        '
        'BunifuPictureBox2
        '
        Me.BunifuPictureBox2.AllowFocused = False
        Me.BunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox2.AutoSizeHeight = True
        Me.BunifuPictureBox2.BorderRadius = 0
        Me.BunifuPictureBox2.Image = CType(resources.GetObject("BunifuPictureBox2.Image"), System.Drawing.Image)
        Me.BunifuPictureBox2.IsCircle = True
        Me.BunifuPictureBox2.Location = New System.Drawing.Point(54, 24)
        Me.BunifuPictureBox2.Name = "BunifuPictureBox2"
        Me.BunifuPictureBox2.Size = New System.Drawing.Size(144, 144)
        Me.BunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox2.TabIndex = 7
        Me.BunifuPictureBox2.TabStop = False
        Me.BunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'pending
        '
        Me.pending.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pending.ForeColor = System.Drawing.Color.White
        Me.pending.Location = New System.Drawing.Point(0, 202)
        Me.pending.Name = "pending"
        Me.pending.Size = New System.Drawing.Size(259, 28)
        Me.pending.TabIndex = 1
        Me.pending.Text = "Pending Leave"
        Me.pending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.BorderRadius = 30
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuPictureBox1)
        Me.BunifuGradientPanel2.Controls.Add(Me.user)
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(140, 72)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(259, 250)
        Me.BunifuGradientPanel2.TabIndex = 6
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.AutoSizeHeight = True
        Me.BunifuPictureBox1.BorderRadius = 0
        Me.BunifuPictureBox1.Image = CType(resources.GetObject("BunifuPictureBox1.Image"), System.Drawing.Image)
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(59, 24)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(144, 144)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 7
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'user
        '
        Me.user.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.White
        Me.user.Location = New System.Drawing.Point(0, 202)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(259, 28)
        Me.user.TabIndex = 1
        Me.user.Text = "Users"
        Me.user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdminDashForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1135, 800)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminDashForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminDashForm"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel5.ResumeLayout(False)
        CType(Me.BunifuPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel4.ResumeLayout(False)
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel3.ResumeLayout(False)
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel1 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel2 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents user As Label
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuGradientPanel5 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents BunifuPictureBox4 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents rejected As Label
    Friend WithEvents BunifuGradientPanel4 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents BunifuPictureBox3 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents approved As Label
    Friend WithEvents BunifuGradientPanel3 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents BunifuPictureBox2 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents pending As Label
End Class
