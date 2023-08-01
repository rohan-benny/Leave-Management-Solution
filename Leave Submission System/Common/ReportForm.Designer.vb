<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportForm))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.printbtn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.dept = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.usertype = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.leavetype = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.leavestat = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.reportleave = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.reportleave, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BunifuGradientPanel1.BorderRadius = 1
        Me.BunifuGradientPanel1.Controls.Add(Me.printbtn)
        Me.BunifuGradientPanel1.Controls.Add(Me.dept)
        Me.BunifuGradientPanel1.Controls.Add(Me.usertype)
        Me.BunifuGradientPanel1.Controls.Add(Me.leavetype)
        Me.BunifuGradientPanel1.Controls.Add(Me.leavestat)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuLabel5)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuLabel4)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuLabel3)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuLabel2)
        Me.BunifuGradientPanel1.Controls.Add(Me.reportleave)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuLabel1)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkGray
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Silver
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(1135, 800)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'printbtn
        '
        Me.printbtn.AllowAnimations = True
        Me.printbtn.AllowMouseEffects = True
        Me.printbtn.AllowToggling = False
        Me.printbtn.AnimationSpeed = 200
        Me.printbtn.AutoGenerateColors = False
        Me.printbtn.AutoRoundBorders = False
        Me.printbtn.AutoSizeLeftIcon = True
        Me.printbtn.AutoSizeRightIcon = True
        Me.printbtn.BackColor = System.Drawing.Color.Transparent
        Me.printbtn.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.printbtn.BackgroundImage = CType(resources.GetObject("printbtn.BackgroundImage"), System.Drawing.Image)
        Me.printbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.printbtn.ButtonText = "Print Report"
        Me.printbtn.ButtonTextMarginLeft = 0
        Me.printbtn.ColorContrastOnClick = 45
        Me.printbtn.ColorContrastOnHover = 45
        Me.printbtn.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.printbtn.CustomizableEdges = BorderEdges1
        Me.printbtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.printbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.printbtn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.printbtn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.printbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.printbtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printbtn.ForeColor = System.Drawing.Color.White
        Me.printbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.printbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.printbtn.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.printbtn.IconMarginLeft = 11
        Me.printbtn.IconPadding = 10
        Me.printbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.printbtn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.printbtn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.printbtn.IconSize = 25
        Me.printbtn.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.printbtn.IdleBorderRadius = 17
        Me.printbtn.IdleBorderThickness = 1
        Me.printbtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.printbtn.IdleIconLeftImage = Nothing
        Me.printbtn.IdleIconRightImage = Nothing
        Me.printbtn.IndicateFocus = False
        Me.printbtn.Location = New System.Drawing.Point(487, 728)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.printbtn.OnDisabledState.BorderRadius = 17
        Me.printbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.printbtn.OnDisabledState.BorderThickness = 1
        Me.printbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.printbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.printbtn.OnDisabledState.IconLeftImage = Nothing
        Me.printbtn.OnDisabledState.IconRightImage = Nothing
        Me.printbtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.printbtn.onHoverState.BorderRadius = 17
        Me.printbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.printbtn.onHoverState.BorderThickness = 1
        Me.printbtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.printbtn.onHoverState.ForeColor = System.Drawing.Color.White
        Me.printbtn.onHoverState.IconLeftImage = Nothing
        Me.printbtn.onHoverState.IconRightImage = Nothing
        Me.printbtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.printbtn.OnIdleState.BorderRadius = 17
        Me.printbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.printbtn.OnIdleState.BorderThickness = 1
        Me.printbtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.printbtn.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.printbtn.OnIdleState.IconLeftImage = Nothing
        Me.printbtn.OnIdleState.IconRightImage = Nothing
        Me.printbtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.printbtn.OnPressedState.BorderRadius = 17
        Me.printbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.printbtn.OnPressedState.BorderThickness = 1
        Me.printbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.printbtn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.printbtn.OnPressedState.IconLeftImage = Nothing
        Me.printbtn.OnPressedState.IconRightImage = Nothing
        Me.printbtn.Size = New System.Drawing.Size(191, 50)
        Me.printbtn.TabIndex = 9
        Me.printbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.printbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.printbtn.TextMarginLeft = 0
        Me.printbtn.TextPadding = New System.Windows.Forms.Padding(0)
        Me.printbtn.UseDefaultRadiusAndThickness = True
        '
        'dept
        '
        Me.dept.BackColor = System.Drawing.Color.Transparent
        Me.dept.BackgroundColor = System.Drawing.Color.White
        Me.dept.BorderColor = System.Drawing.Color.Silver
        Me.dept.BorderRadius = 1
        Me.dept.Color = System.Drawing.Color.Silver
        Me.dept.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.dept.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dept.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.dept.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dept.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dept.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.dept.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.dept.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dept.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.dept.FillDropDown = True
        Me.dept.FillIndicator = False
        Me.dept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dept.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dept.ForeColor = System.Drawing.Color.Black
        Me.dept.FormattingEnabled = True
        Me.dept.Icon = Nothing
        Me.dept.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.dept.IndicatorColor = System.Drawing.Color.Gray
        Me.dept.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.dept.ItemBackColor = System.Drawing.Color.White
        Me.dept.ItemBorderColor = System.Drawing.Color.White
        Me.dept.ItemForeColor = System.Drawing.Color.Black
        Me.dept.ItemHeight = 26
        Me.dept.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.dept.ItemHighLightForeColor = System.Drawing.Color.White
        Me.dept.ItemTopMargin = 3
        Me.dept.Location = New System.Drawing.Point(727, 146)
        Me.dept.Name = "dept"
        Me.dept.Size = New System.Drawing.Size(225, 32)
        Me.dept.TabIndex = 8
        Me.dept.Text = Nothing
        Me.dept.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.dept.TextLeftMargin = 5
        '
        'usertype
        '
        Me.usertype.BackColor = System.Drawing.Color.Transparent
        Me.usertype.BackgroundColor = System.Drawing.Color.White
        Me.usertype.BorderColor = System.Drawing.Color.Silver
        Me.usertype.BorderRadius = 1
        Me.usertype.Color = System.Drawing.Color.Silver
        Me.usertype.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.usertype.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.usertype.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.usertype.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.usertype.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.usertype.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.usertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.usertype.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.usertype.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.usertype.FillDropDown = True
        Me.usertype.FillIndicator = False
        Me.usertype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usertype.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usertype.ForeColor = System.Drawing.Color.Black
        Me.usertype.FormattingEnabled = True
        Me.usertype.Icon = Nothing
        Me.usertype.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.usertype.IndicatorColor = System.Drawing.Color.Gray
        Me.usertype.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.usertype.ItemBackColor = System.Drawing.Color.White
        Me.usertype.ItemBorderColor = System.Drawing.Color.White
        Me.usertype.ItemForeColor = System.Drawing.Color.Black
        Me.usertype.ItemHeight = 26
        Me.usertype.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.usertype.ItemHighLightForeColor = System.Drawing.Color.White
        Me.usertype.ItemTopMargin = 3
        Me.usertype.Location = New System.Drawing.Point(315, 146)
        Me.usertype.Name = "usertype"
        Me.usertype.Size = New System.Drawing.Size(225, 32)
        Me.usertype.TabIndex = 7
        Me.usertype.Text = Nothing
        Me.usertype.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.usertype.TextLeftMargin = 5
        '
        'leavetype
        '
        Me.leavetype.BackColor = System.Drawing.Color.Transparent
        Me.leavetype.BackgroundColor = System.Drawing.Color.White
        Me.leavetype.BorderColor = System.Drawing.Color.Silver
        Me.leavetype.BorderRadius = 1
        Me.leavetype.Color = System.Drawing.Color.Silver
        Me.leavetype.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.leavetype.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.leavetype.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.leavetype.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.leavetype.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.leavetype.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.leavetype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.leavetype.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.leavetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.leavetype.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.leavetype.FillDropDown = True
        Me.leavetype.FillIndicator = False
        Me.leavetype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.leavetype.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.leavetype.ForeColor = System.Drawing.Color.Black
        Me.leavetype.FormattingEnabled = True
        Me.leavetype.Icon = Nothing
        Me.leavetype.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.leavetype.IndicatorColor = System.Drawing.Color.Gray
        Me.leavetype.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.leavetype.ItemBackColor = System.Drawing.Color.White
        Me.leavetype.ItemBorderColor = System.Drawing.Color.White
        Me.leavetype.ItemForeColor = System.Drawing.Color.Black
        Me.leavetype.ItemHeight = 26
        Me.leavetype.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.leavetype.ItemHighLightForeColor = System.Drawing.Color.White
        Me.leavetype.ItemTopMargin = 3
        Me.leavetype.Location = New System.Drawing.Point(727, 78)
        Me.leavetype.Name = "leavetype"
        Me.leavetype.Size = New System.Drawing.Size(225, 32)
        Me.leavetype.TabIndex = 6
        Me.leavetype.Text = Nothing
        Me.leavetype.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.leavetype.TextLeftMargin = 5
        '
        'leavestat
        '
        Me.leavestat.BackColor = System.Drawing.Color.Transparent
        Me.leavestat.BackgroundColor = System.Drawing.Color.White
        Me.leavestat.BorderColor = System.Drawing.Color.Silver
        Me.leavestat.BorderRadius = 1
        Me.leavestat.Color = System.Drawing.Color.Silver
        Me.leavestat.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.leavestat.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.leavestat.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.leavestat.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.leavestat.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.leavestat.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.leavestat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.leavestat.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.leavestat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.leavestat.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.leavestat.FillDropDown = True
        Me.leavestat.FillIndicator = False
        Me.leavestat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.leavestat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.leavestat.ForeColor = System.Drawing.Color.Black
        Me.leavestat.FormattingEnabled = True
        Me.leavestat.Icon = Nothing
        Me.leavestat.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.leavestat.IndicatorColor = System.Drawing.Color.Gray
        Me.leavestat.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.leavestat.ItemBackColor = System.Drawing.Color.White
        Me.leavestat.ItemBorderColor = System.Drawing.Color.White
        Me.leavestat.ItemForeColor = System.Drawing.Color.Black
        Me.leavestat.ItemHeight = 26
        Me.leavestat.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.leavestat.ItemHighLightForeColor = System.Drawing.Color.White
        Me.leavestat.ItemTopMargin = 3
        Me.leavestat.Location = New System.Drawing.Point(315, 80)
        Me.leavestat.Name = "leavestat"
        Me.leavestat.Size = New System.Drawing.Size(225, 32)
        Me.leavestat.TabIndex = 5
        Me.leavestat.Text = Nothing
        Me.leavestat.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.leavestat.TextLeftMargin = 5
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AllowParentOverrides = False
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.CursorType = Nothing
        Me.BunifuLabel5.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel5.Location = New System.Drawing.Point(574, 148)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(140, 30)
        Me.BunifuLabel5.TabIndex = 4
        Me.BunifuLabel5.Text = "Department"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AllowParentOverrides = False
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.AutoSize = False
        Me.BunifuLabel4.CursorType = Nothing
        Me.BunifuLabel4.Font = New System.Drawing.Font("Britannic Bold", 20.25!)
        Me.BunifuLabel4.Location = New System.Drawing.Point(574, 80)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(135, 37)
        Me.BunifuLabel4.TabIndex = 3
        Me.BunifuLabel4.Text = "Leave Type"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.Location = New System.Drawing.Point(151, 148)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(116, 30)
        Me.BunifuLabel3.TabIndex = 3
        Me.BunifuLabel3.Text = "User Type"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.Location = New System.Drawing.Point(151, 80)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(149, 30)
        Me.BunifuLabel2.TabIndex = 2
        Me.BunifuLabel2.Text = "Leave Status"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'reportleave
        '
        Me.reportleave.AllowCustomTheming = False
        Me.reportleave.AllowUserToAddRows = False
        Me.reportleave.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.reportleave.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.reportleave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.reportleave.BackgroundColor = System.Drawing.Color.White
        Me.reportleave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.reportleave.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.reportleave.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.reportleave.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.reportleave.ColumnHeadersHeight = 40
        Me.reportleave.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.reportleave.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.reportleave.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.reportleave.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.reportleave.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.reportleave.CurrentTheme.BackColor = System.Drawing.Color.Navy
        Me.reportleave.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.reportleave.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy
        Me.reportleave.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.reportleave.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.reportleave.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.reportleave.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.reportleave.CurrentTheme.Name = Nothing
        Me.reportleave.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.reportleave.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.reportleave.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.reportleave.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.reportleave.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.reportleave.DefaultCellStyle = DataGridViewCellStyle3
        Me.reportleave.EnableHeadersVisualStyles = False
        Me.reportleave.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.reportleave.HeaderBackColor = System.Drawing.Color.Navy
        Me.reportleave.HeaderBgColor = System.Drawing.Color.Empty
        Me.reportleave.HeaderForeColor = System.Drawing.Color.White
        Me.reportleave.Location = New System.Drawing.Point(53, 202)
        Me.reportleave.Name = "reportleave"
        Me.reportleave.ReadOnly = True
        Me.reportleave.RowHeadersVisible = False
        Me.reportleave.RowTemplate.Height = 40
        Me.reportleave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.reportleave.Size = New System.Drawing.Size(1008, 494)
        Me.reportleave.TabIndex = 1
        Me.reportleave.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuLabel1.Location = New System.Drawing.Point(13, 22)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(103, 45)
        Me.BunifuLabel1.TabIndex = 0
        Me.BunifuLabel1.Text = "Report"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ReportForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1135, 800)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReportForm"
        Me.Text = "ReportForm"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.reportleave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel1 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel4 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents reportleave As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents dept As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents usertype As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents leavetype As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents leavestat As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents printbtn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
