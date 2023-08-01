<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges7 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges8 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuPanel1 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.BunifuGradientPanel1 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.ManageUser = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.settings = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.ReportAdmin = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.DashBoard = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Logout = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Holidays = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.help = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Manage = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuGradientPanel2 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.BunifuPanel1.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 17
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuPanel1
        '
        Me.BunifuPanel1.BackgroundColor = System.Drawing.Color.OldLace
        Me.BunifuPanel1.BackgroundImage = CType(resources.GetObject("BunifuPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel1.BorderRadius = 17
        Me.BunifuPanel1.BorderThickness = 1
        Me.BunifuPanel1.Controls.Add(Me.BunifuGradientPanel1)
        Me.BunifuPanel1.Controls.Add(Me.BunifuGradientPanel2)
        Me.BunifuPanel1.Location = New System.Drawing.Point(4, 7)
        Me.BunifuPanel1.Name = "BunifuPanel1"
        Me.BunifuPanel1.ShowBorders = True
        Me.BunifuPanel1.Size = New System.Drawing.Size(1440, 810)
        Me.BunifuPanel1.TabIndex = 0
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderRadius = 17
        Me.BunifuGradientPanel1.Controls.Add(Me.ManageUser)
        Me.BunifuGradientPanel1.Controls.Add(Me.settings)
        Me.BunifuGradientPanel1.Controls.Add(Me.ReportAdmin)
        Me.BunifuGradientPanel1.Controls.Add(Me.DashBoard)
        Me.BunifuGradientPanel1.Controls.Add(Me.Logout)
        Me.BunifuGradientPanel1.Controls.Add(Me.Holidays)
        Me.BunifuGradientPanel1.Controls.Add(Me.help)
        Me.BunifuGradientPanel1.Controls.Add(Me.Manage)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuTileButton1)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(297, 810)
        Me.BunifuGradientPanel1.TabIndex = 31
        '
        'ManageUser
        '
        Me.ManageUser.AllowAnimations = True
        Me.ManageUser.AllowMouseEffects = True
        Me.ManageUser.AllowToggling = False
        Me.ManageUser.AnimationSpeed = 200
        Me.ManageUser.AutoGenerateColors = False
        Me.ManageUser.AutoRoundBorders = False
        Me.ManageUser.AutoSizeLeftIcon = True
        Me.ManageUser.AutoSizeRightIcon = True
        Me.ManageUser.BackColor = System.Drawing.Color.Transparent
        Me.ManageUser.BackColor1 = System.Drawing.Color.Transparent
        Me.ManageUser.BackgroundImage = CType(resources.GetObject("ManageUser.BackgroundImage"), System.Drawing.Image)
        Me.ManageUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ManageUser.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ManageUser.ButtonText = "Manage User"
        Me.ManageUser.ButtonTextMarginLeft = 0
        Me.ManageUser.ColorContrastOnClick = 45
        Me.ManageUser.ColorContrastOnHover = 45
        Me.ManageUser.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.ManageUser.CustomizableEdges = BorderEdges1
        Me.ManageUser.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ManageUser.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ManageUser.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ManageUser.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.ManageUser.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.ManageUser.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!)
        Me.ManageUser.ForeColor = System.Drawing.Color.White
        Me.ManageUser.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManageUser.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.ManageUser.IconLeftPadding = New System.Windows.Forms.Padding(16, 3, 3, 3)
        Me.ManageUser.IconMarginLeft = 11
        Me.ManageUser.IconPadding = 15
        Me.ManageUser.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ManageUser.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.ManageUser.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.ManageUser.IconSize = 30
        Me.ManageUser.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ManageUser.IdleBorderRadius = 45
        Me.ManageUser.IdleBorderThickness = 3
        Me.ManageUser.IdleFillColor = System.Drawing.Color.Transparent
        Me.ManageUser.IdleIconLeftImage = CType(resources.GetObject("ManageUser.IdleIconLeftImage"), System.Drawing.Image)
        Me.ManageUser.IdleIconRightImage = Nothing
        Me.ManageUser.IndicateFocus = False
        Me.ManageUser.Location = New System.Drawing.Point(21, 300)
        Me.ManageUser.Name = "ManageUser"
        Me.ManageUser.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ManageUser.OnDisabledState.BorderRadius = 45
        Me.ManageUser.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ManageUser.OnDisabledState.BorderThickness = 3
        Me.ManageUser.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ManageUser.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.ManageUser.OnDisabledState.IconLeftImage = Nothing
        Me.ManageUser.OnDisabledState.IconRightImage = Nothing
        Me.ManageUser.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ManageUser.onHoverState.BorderRadius = 45
        Me.ManageUser.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ManageUser.onHoverState.BorderThickness = 3
        Me.ManageUser.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ManageUser.onHoverState.ForeColor = System.Drawing.Color.White
        Me.ManageUser.onHoverState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage"), System.Drawing.Image)
        Me.ManageUser.onHoverState.IconRightImage = Nothing
        Me.ManageUser.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ManageUser.OnIdleState.BorderRadius = 45
        Me.ManageUser.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ManageUser.OnIdleState.BorderThickness = 3
        Me.ManageUser.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.ManageUser.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.ManageUser.OnIdleState.IconLeftImage = CType(resources.GetObject("ManageUser.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.ManageUser.OnIdleState.IconRightImage = Nothing
        Me.ManageUser.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ManageUser.OnPressedState.BorderRadius = 45
        Me.ManageUser.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ManageUser.OnPressedState.BorderThickness = 3
        Me.ManageUser.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ManageUser.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.ManageUser.OnPressedState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage1"), System.Drawing.Image)
        Me.ManageUser.OnPressedState.IconRightImage = Nothing
        Me.ManageUser.Size = New System.Drawing.Size(244, 60)
        Me.ManageUser.TabIndex = 26
        Me.ManageUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ManageUser.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.ManageUser.TextMarginLeft = 0
        Me.ManageUser.TextPadding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.ManageUser.UseDefaultRadiusAndThickness = True
        '
        'settings
        '
        Me.settings.AllowAnimations = True
        Me.settings.AllowMouseEffects = True
        Me.settings.AllowToggling = False
        Me.settings.AnimationSpeed = 200
        Me.settings.AutoGenerateColors = False
        Me.settings.AutoRoundBorders = False
        Me.settings.AutoSizeLeftIcon = True
        Me.settings.AutoSizeRightIcon = True
        Me.settings.BackColor = System.Drawing.Color.Transparent
        Me.settings.BackColor1 = System.Drawing.Color.Transparent
        Me.settings.BackgroundImage = CType(resources.GetObject("settings.BackgroundImage"), System.Drawing.Image)
        Me.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.settings.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.settings.ButtonText = "Settings"
        Me.settings.ButtonTextMarginLeft = 0
        Me.settings.ColorContrastOnClick = 45
        Me.settings.ColorContrastOnHover = 45
        Me.settings.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.settings.CustomizableEdges = BorderEdges2
        Me.settings.DialogResult = System.Windows.Forms.DialogResult.None
        Me.settings.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.settings.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.settings.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.settings.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle
        Me.settings.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!)
        Me.settings.ForeColor = System.Drawing.Color.White
        Me.settings.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.settings.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.settings.IconLeftPadding = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.settings.IconMarginLeft = 11
        Me.settings.IconPadding = 10
        Me.settings.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.settings.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.settings.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.settings.IconSize = 30
        Me.settings.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.settings.IdleBorderRadius = 45
        Me.settings.IdleBorderThickness = 3
        Me.settings.IdleFillColor = System.Drawing.Color.Transparent
        Me.settings.IdleIconLeftImage = CType(resources.GetObject("settings.IdleIconLeftImage"), System.Drawing.Image)
        Me.settings.IdleIconRightImage = Nothing
        Me.settings.IndicateFocus = False
        Me.settings.Location = New System.Drawing.Point(21, 497)
        Me.settings.Name = "settings"
        Me.settings.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.settings.OnDisabledState.BorderRadius = 45
        Me.settings.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.settings.OnDisabledState.BorderThickness = 3
        Me.settings.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.settings.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.settings.OnDisabledState.IconLeftImage = Nothing
        Me.settings.OnDisabledState.IconRightImage = Nothing
        Me.settings.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.settings.onHoverState.BorderRadius = 45
        Me.settings.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.settings.onHoverState.BorderThickness = 3
        Me.settings.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.settings.onHoverState.ForeColor = System.Drawing.Color.White
        Me.settings.onHoverState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage2"), System.Drawing.Image)
        Me.settings.onHoverState.IconRightImage = Nothing
        Me.settings.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.settings.OnIdleState.BorderRadius = 45
        Me.settings.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.settings.OnIdleState.BorderThickness = 3
        Me.settings.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.settings.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.settings.OnIdleState.IconLeftImage = CType(resources.GetObject("settings.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.settings.OnIdleState.IconRightImage = Nothing
        Me.settings.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.settings.OnPressedState.BorderRadius = 45
        Me.settings.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.settings.OnPressedState.BorderThickness = 3
        Me.settings.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.settings.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.settings.OnPressedState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage3"), System.Drawing.Image)
        Me.settings.OnPressedState.IconRightImage = Nothing
        Me.settings.Size = New System.Drawing.Size(244, 60)
        Me.settings.TabIndex = 23
        Me.settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.settings.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.settings.TextMarginLeft = 0
        Me.settings.TextPadding = New System.Windows.Forms.Padding(0)
        Me.settings.UseDefaultRadiusAndThickness = True
        '
        'ReportAdmin
        '
        Me.ReportAdmin.AllowAnimations = True
        Me.ReportAdmin.AllowMouseEffects = True
        Me.ReportAdmin.AllowToggling = False
        Me.ReportAdmin.AnimationSpeed = 200
        Me.ReportAdmin.AutoGenerateColors = False
        Me.ReportAdmin.AutoRoundBorders = False
        Me.ReportAdmin.AutoSizeLeftIcon = True
        Me.ReportAdmin.AutoSizeRightIcon = True
        Me.ReportAdmin.BackColor = System.Drawing.Color.Transparent
        Me.ReportAdmin.BackColor1 = System.Drawing.Color.Transparent
        Me.ReportAdmin.BackgroundImage = CType(resources.GetObject("ReportAdmin.BackgroundImage"), System.Drawing.Image)
        Me.ReportAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ReportAdmin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ReportAdmin.ButtonText = "Report"
        Me.ReportAdmin.ButtonTextMarginLeft = 0
        Me.ReportAdmin.ColorContrastOnClick = 45
        Me.ReportAdmin.ColorContrastOnHover = 45
        Me.ReportAdmin.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.ReportAdmin.CustomizableEdges = BorderEdges3
        Me.ReportAdmin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ReportAdmin.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ReportAdmin.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ReportAdmin.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.ReportAdmin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.ReportAdmin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!)
        Me.ReportAdmin.ForeColor = System.Drawing.Color.White
        Me.ReportAdmin.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReportAdmin.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.ReportAdmin.IconLeftPadding = New System.Windows.Forms.Padding(18, 3, 3, 3)
        Me.ReportAdmin.IconMarginLeft = 11
        Me.ReportAdmin.IconPadding = 14
        Me.ReportAdmin.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReportAdmin.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.ReportAdmin.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.ReportAdmin.IconSize = 20
        Me.ReportAdmin.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ReportAdmin.IdleBorderRadius = 45
        Me.ReportAdmin.IdleBorderThickness = 3
        Me.ReportAdmin.IdleFillColor = System.Drawing.Color.Transparent
        Me.ReportAdmin.IdleIconLeftImage = CType(resources.GetObject("ReportAdmin.IdleIconLeftImage"), System.Drawing.Image)
        Me.ReportAdmin.IdleIconRightImage = Nothing
        Me.ReportAdmin.IndicateFocus = False
        Me.ReportAdmin.Location = New System.Drawing.Point(21, 432)
        Me.ReportAdmin.Name = "ReportAdmin"
        Me.ReportAdmin.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ReportAdmin.OnDisabledState.BorderRadius = 45
        Me.ReportAdmin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ReportAdmin.OnDisabledState.BorderThickness = 3
        Me.ReportAdmin.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ReportAdmin.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.ReportAdmin.OnDisabledState.IconLeftImage = Nothing
        Me.ReportAdmin.OnDisabledState.IconRightImage = Nothing
        Me.ReportAdmin.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ReportAdmin.onHoverState.BorderRadius = 45
        Me.ReportAdmin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ReportAdmin.onHoverState.BorderThickness = 3
        Me.ReportAdmin.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ReportAdmin.onHoverState.ForeColor = System.Drawing.Color.White
        Me.ReportAdmin.onHoverState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage4"), System.Drawing.Image)
        Me.ReportAdmin.onHoverState.IconRightImage = Nothing
        Me.ReportAdmin.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ReportAdmin.OnIdleState.BorderRadius = 45
        Me.ReportAdmin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ReportAdmin.OnIdleState.BorderThickness = 3
        Me.ReportAdmin.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.ReportAdmin.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.ReportAdmin.OnIdleState.IconLeftImage = CType(resources.GetObject("ReportAdmin.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.ReportAdmin.OnIdleState.IconRightImage = Nothing
        Me.ReportAdmin.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ReportAdmin.OnPressedState.BorderRadius = 45
        Me.ReportAdmin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ReportAdmin.OnPressedState.BorderThickness = 3
        Me.ReportAdmin.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ReportAdmin.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.ReportAdmin.OnPressedState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage5"), System.Drawing.Image)
        Me.ReportAdmin.OnPressedState.IconRightImage = Nothing
        Me.ReportAdmin.Size = New System.Drawing.Size(244, 59)
        Me.ReportAdmin.TabIndex = 28
        Me.ReportAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ReportAdmin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.ReportAdmin.TextMarginLeft = 0
        Me.ReportAdmin.TextPadding = New System.Windows.Forms.Padding(0)
        Me.ReportAdmin.UseDefaultRadiusAndThickness = True
        '
        'DashBoard
        '
        Me.DashBoard.AllowAnimations = True
        Me.DashBoard.AllowMouseEffects = True
        Me.DashBoard.AllowToggling = False
        Me.DashBoard.AnimationSpeed = 200
        Me.DashBoard.AutoGenerateColors = False
        Me.DashBoard.AutoRoundBorders = False
        Me.DashBoard.AutoSizeLeftIcon = True
        Me.DashBoard.AutoSizeRightIcon = True
        Me.DashBoard.BackColor = System.Drawing.Color.Transparent
        Me.DashBoard.BackColor1 = System.Drawing.Color.Transparent
        Me.DashBoard.BackgroundImage = CType(resources.GetObject("DashBoard.BackgroundImage"), System.Drawing.Image)
        Me.DashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DashBoard.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DashBoard.ButtonText = "DashBoard"
        Me.DashBoard.ButtonTextMarginLeft = 0
        Me.DashBoard.ColorContrastOnClick = 45
        Me.DashBoard.ColorContrastOnHover = 45
        Me.DashBoard.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.DashBoard.CustomizableEdges = BorderEdges4
        Me.DashBoard.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DashBoard.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DashBoard.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.DashBoard.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.DashBoard.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.DashBoard.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!)
        Me.DashBoard.ForeColor = System.Drawing.Color.White
        Me.DashBoard.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashBoard.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.DashBoard.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.DashBoard.IconMarginLeft = 11
        Me.DashBoard.IconPadding = 10
        Me.DashBoard.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DashBoard.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.DashBoard.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.DashBoard.IconSize = 30
        Me.DashBoard.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DashBoard.IdleBorderRadius = 45
        Me.DashBoard.IdleBorderThickness = 3
        Me.DashBoard.IdleFillColor = System.Drawing.Color.Transparent
        Me.DashBoard.IdleIconLeftImage = CType(resources.GetObject("DashBoard.IdleIconLeftImage"), System.Drawing.Image)
        Me.DashBoard.IdleIconRightImage = Nothing
        Me.DashBoard.IndicateFocus = False
        Me.DashBoard.Location = New System.Drawing.Point(21, 168)
        Me.DashBoard.Name = "DashBoard"
        Me.DashBoard.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DashBoard.OnDisabledState.BorderRadius = 45
        Me.DashBoard.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DashBoard.OnDisabledState.BorderThickness = 3
        Me.DashBoard.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.DashBoard.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.DashBoard.OnDisabledState.IconLeftImage = Nothing
        Me.DashBoard.OnDisabledState.IconRightImage = Nothing
        Me.DashBoard.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DashBoard.onHoverState.BorderRadius = 45
        Me.DashBoard.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DashBoard.onHoverState.BorderThickness = 3
        Me.DashBoard.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DashBoard.onHoverState.ForeColor = System.Drawing.Color.White
        Me.DashBoard.onHoverState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage6"), System.Drawing.Image)
        Me.DashBoard.onHoverState.IconRightImage = Nothing
        Me.DashBoard.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DashBoard.OnIdleState.BorderRadius = 45
        Me.DashBoard.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DashBoard.OnIdleState.BorderThickness = 3
        Me.DashBoard.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.DashBoard.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.DashBoard.OnIdleState.IconLeftImage = CType(resources.GetObject("DashBoard.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.DashBoard.OnIdleState.IconRightImage = Nothing
        Me.DashBoard.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DashBoard.OnPressedState.BorderRadius = 45
        Me.DashBoard.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DashBoard.OnPressedState.BorderThickness = 3
        Me.DashBoard.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DashBoard.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.DashBoard.OnPressedState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage7"), System.Drawing.Image)
        Me.DashBoard.OnPressedState.IconRightImage = Nothing
        Me.DashBoard.Size = New System.Drawing.Size(244, 60)
        Me.DashBoard.TabIndex = 24
        Me.DashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DashBoard.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DashBoard.TextMarginLeft = 0
        Me.DashBoard.TextPadding = New System.Windows.Forms.Padding(0)
        Me.DashBoard.UseDefaultRadiusAndThickness = True
        '
        'Logout
        '
        Me.Logout.AllowAnimations = True
        Me.Logout.AllowMouseEffects = True
        Me.Logout.AllowToggling = False
        Me.Logout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Logout.AnimationSpeed = 200
        Me.Logout.AutoGenerateColors = False
        Me.Logout.AutoRoundBorders = False
        Me.Logout.AutoSizeLeftIcon = True
        Me.Logout.AutoSizeRightIcon = True
        Me.Logout.BackColor = System.Drawing.Color.Transparent
        Me.Logout.BackColor1 = System.Drawing.Color.Transparent
        Me.Logout.BackgroundImage = CType(resources.GetObject("Logout.BackgroundImage"), System.Drawing.Image)
        Me.Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Logout.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Logout.ButtonText = "Logout"
        Me.Logout.ButtonTextMarginLeft = 0
        Me.Logout.ColorContrastOnClick = 45
        Me.Logout.ColorContrastOnHover = 45
        Me.Logout.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges5.BottomLeft = True
        BorderEdges5.BottomRight = True
        BorderEdges5.TopLeft = True
        BorderEdges5.TopRight = True
        Me.Logout.CustomizableEdges = BorderEdges5
        Me.Logout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Logout.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Logout.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Logout.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Logout.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.Logout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!)
        Me.Logout.ForeColor = System.Drawing.Color.White
        Me.Logout.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logout.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Logout.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.Logout.IconMarginLeft = 11
        Me.Logout.IconPadding = 10
        Me.Logout.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Logout.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Logout.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.Logout.IconSize = 25
        Me.Logout.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Logout.IdleBorderRadius = 45
        Me.Logout.IdleBorderThickness = 3
        Me.Logout.IdleFillColor = System.Drawing.Color.Transparent
        Me.Logout.IdleIconLeftImage = CType(resources.GetObject("Logout.IdleIconLeftImage"), System.Drawing.Image)
        Me.Logout.IdleIconRightImage = Nothing
        Me.Logout.IndicateFocus = False
        Me.Logout.Location = New System.Drawing.Point(21, 744)
        Me.Logout.Name = "Logout"
        Me.Logout.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Logout.OnDisabledState.BorderRadius = 45
        Me.Logout.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Logout.OnDisabledState.BorderThickness = 3
        Me.Logout.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Logout.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Logout.OnDisabledState.IconLeftImage = Nothing
        Me.Logout.OnDisabledState.IconRightImage = Nothing
        Me.Logout.onHoverState.BorderColor = System.Drawing.Color.Maroon
        Me.Logout.onHoverState.BorderRadius = 45
        Me.Logout.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Logout.onHoverState.BorderThickness = 3
        Me.Logout.onHoverState.FillColor = System.Drawing.Color.Maroon
        Me.Logout.onHoverState.ForeColor = System.Drawing.Color.White
        Me.Logout.onHoverState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage8"), System.Drawing.Image)
        Me.Logout.onHoverState.IconRightImage = Nothing
        Me.Logout.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Logout.OnIdleState.BorderRadius = 45
        Me.Logout.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Logout.OnIdleState.BorderThickness = 3
        Me.Logout.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.Logout.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.Logout.OnIdleState.IconLeftImage = CType(resources.GetObject("Logout.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.Logout.OnIdleState.IconRightImage = Nothing
        Me.Logout.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Logout.OnPressedState.BorderRadius = 45
        Me.Logout.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Logout.OnPressedState.BorderThickness = 3
        Me.Logout.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Logout.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.Logout.OnPressedState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage9"), System.Drawing.Image)
        Me.Logout.OnPressedState.IconRightImage = Nothing
        Me.Logout.Size = New System.Drawing.Size(244, 59)
        Me.Logout.TabIndex = 23
        Me.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Logout.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Logout.TextMarginLeft = 0
        Me.Logout.TextPadding = New System.Windows.Forms.Padding(0)
        Me.Logout.UseDefaultRadiusAndThickness = True
        '
        'Holidays
        '
        Me.Holidays.AllowAnimations = True
        Me.Holidays.AllowMouseEffects = True
        Me.Holidays.AllowToggling = False
        Me.Holidays.AnimationSpeed = 200
        Me.Holidays.AutoGenerateColors = False
        Me.Holidays.AutoRoundBorders = False
        Me.Holidays.AutoSizeLeftIcon = True
        Me.Holidays.AutoSizeRightIcon = True
        Me.Holidays.BackColor = System.Drawing.Color.Transparent
        Me.Holidays.BackColor1 = System.Drawing.Color.Transparent
        Me.Holidays.BackgroundImage = CType(resources.GetObject("Holidays.BackgroundImage"), System.Drawing.Image)
        Me.Holidays.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Holidays.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Holidays.ButtonText = "Holidays"
        Me.Holidays.ButtonTextMarginLeft = 0
        Me.Holidays.ColorContrastOnClick = 45
        Me.Holidays.ColorContrastOnHover = 45
        Me.Holidays.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges6.BottomLeft = True
        BorderEdges6.BottomRight = True
        BorderEdges6.TopLeft = True
        BorderEdges6.TopRight = True
        Me.Holidays.CustomizableEdges = BorderEdges6
        Me.Holidays.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Holidays.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Holidays.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Holidays.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Holidays.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.Holidays.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!)
        Me.Holidays.ForeColor = System.Drawing.Color.White
        Me.Holidays.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Holidays.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Holidays.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.Holidays.IconMarginLeft = 11
        Me.Holidays.IconPadding = 10
        Me.Holidays.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Holidays.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Holidays.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.Holidays.IconSize = 14
        Me.Holidays.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Holidays.IdleBorderRadius = 45
        Me.Holidays.IdleBorderThickness = 3
        Me.Holidays.IdleFillColor = System.Drawing.Color.Transparent
        Me.Holidays.IdleIconLeftImage = CType(resources.GetObject("Holidays.IdleIconLeftImage"), System.Drawing.Image)
        Me.Holidays.IdleIconRightImage = Nothing
        Me.Holidays.IndicateFocus = False
        Me.Holidays.Location = New System.Drawing.Point(21, 366)
        Me.Holidays.Name = "Holidays"
        Me.Holidays.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Holidays.OnDisabledState.BorderRadius = 45
        Me.Holidays.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Holidays.OnDisabledState.BorderThickness = 3
        Me.Holidays.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Holidays.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Holidays.OnDisabledState.IconLeftImage = Nothing
        Me.Holidays.OnDisabledState.IconRightImage = Nothing
        Me.Holidays.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Holidays.onHoverState.BorderRadius = 45
        Me.Holidays.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Holidays.onHoverState.BorderThickness = 3
        Me.Holidays.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Holidays.onHoverState.ForeColor = System.Drawing.Color.White
        Me.Holidays.onHoverState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage10"), System.Drawing.Image)
        Me.Holidays.onHoverState.IconRightImage = Nothing
        Me.Holidays.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Holidays.OnIdleState.BorderRadius = 45
        Me.Holidays.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Holidays.OnIdleState.BorderThickness = 3
        Me.Holidays.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.Holidays.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.Holidays.OnIdleState.IconLeftImage = CType(resources.GetObject("Holidays.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.Holidays.OnIdleState.IconRightImage = Nothing
        Me.Holidays.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Holidays.OnPressedState.BorderRadius = 45
        Me.Holidays.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Holidays.OnPressedState.BorderThickness = 3
        Me.Holidays.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Holidays.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.Holidays.OnPressedState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage11"), System.Drawing.Image)
        Me.Holidays.OnPressedState.IconRightImage = Nothing
        Me.Holidays.Size = New System.Drawing.Size(244, 60)
        Me.Holidays.TabIndex = 24
        Me.Holidays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Holidays.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Holidays.TextMarginLeft = 0
        Me.Holidays.TextPadding = New System.Windows.Forms.Padding(0)
        Me.Holidays.UseDefaultRadiusAndThickness = True
        '
        'help
        '
        Me.help.AllowAnimations = True
        Me.help.AllowMouseEffects = True
        Me.help.AllowToggling = False
        Me.help.AnimationSpeed = 200
        Me.help.AutoGenerateColors = False
        Me.help.AutoRoundBorders = False
        Me.help.AutoSizeLeftIcon = True
        Me.help.AutoSizeRightIcon = True
        Me.help.BackColor = System.Drawing.Color.Transparent
        Me.help.BackColor1 = System.Drawing.Color.Transparent
        Me.help.BackgroundImage = CType(resources.GetObject("help.BackgroundImage"), System.Drawing.Image)
        Me.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.help.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.help.ButtonText = "Help"
        Me.help.ButtonTextMarginLeft = 0
        Me.help.ColorContrastOnClick = 45
        Me.help.ColorContrastOnHover = 45
        Me.help.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges7.BottomLeft = True
        BorderEdges7.BottomRight = True
        BorderEdges7.TopLeft = True
        BorderEdges7.TopRight = True
        Me.help.CustomizableEdges = BorderEdges7
        Me.help.DialogResult = System.Windows.Forms.DialogResult.None
        Me.help.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.help.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.help.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.help.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.help.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!)
        Me.help.ForeColor = System.Drawing.Color.White
        Me.help.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.help.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.help.IconLeftPadding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.help.IconMarginLeft = 11
        Me.help.IconPadding = 15
        Me.help.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.help.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.help.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.help.IconSize = 25
        Me.help.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.help.IdleBorderRadius = 45
        Me.help.IdleBorderThickness = 3
        Me.help.IdleFillColor = System.Drawing.Color.Transparent
        Me.help.IdleIconLeftImage = CType(resources.GetObject("help.IdleIconLeftImage"), System.Drawing.Image)
        Me.help.IdleIconRightImage = Nothing
        Me.help.IndicateFocus = False
        Me.help.Location = New System.Drawing.Point(21, 563)
        Me.help.Name = "help"
        Me.help.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.help.OnDisabledState.BorderRadius = 45
        Me.help.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.help.OnDisabledState.BorderThickness = 3
        Me.help.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.help.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.help.OnDisabledState.IconLeftImage = Nothing
        Me.help.OnDisabledState.IconRightImage = Nothing
        Me.help.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.help.onHoverState.BorderRadius = 45
        Me.help.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.help.onHoverState.BorderThickness = 3
        Me.help.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.help.onHoverState.ForeColor = System.Drawing.Color.White
        Me.help.onHoverState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage12"), System.Drawing.Image)
        Me.help.onHoverState.IconRightImage = Nothing
        Me.help.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.help.OnIdleState.BorderRadius = 45
        Me.help.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.help.OnIdleState.BorderThickness = 3
        Me.help.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.help.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.help.OnIdleState.IconLeftImage = CType(resources.GetObject("help.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.help.OnIdleState.IconRightImage = Nothing
        Me.help.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.help.OnPressedState.BorderRadius = 45
        Me.help.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.help.OnPressedState.BorderThickness = 3
        Me.help.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.help.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.help.OnPressedState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage13"), System.Drawing.Image)
        Me.help.OnPressedState.IconRightImage = Nothing
        Me.help.Size = New System.Drawing.Size(244, 59)
        Me.help.TabIndex = 27
        Me.help.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.help.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.help.TextMarginLeft = 0
        Me.help.TextPadding = New System.Windows.Forms.Padding(0)
        Me.help.UseDefaultRadiusAndThickness = True
        '
        'Manage
        '
        Me.Manage.AllowAnimations = True
        Me.Manage.AllowMouseEffects = True
        Me.Manage.AllowToggling = False
        Me.Manage.AnimationSpeed = 200
        Me.Manage.AutoGenerateColors = False
        Me.Manage.AutoRoundBorders = False
        Me.Manage.AutoSizeLeftIcon = True
        Me.Manage.AutoSizeRightIcon = True
        Me.Manage.BackColor = System.Drawing.Color.Transparent
        Me.Manage.BackColor1 = System.Drawing.Color.Transparent
        Me.Manage.BackgroundImage = CType(resources.GetObject("Manage.BackgroundImage"), System.Drawing.Image)
        Me.Manage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Manage.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Manage.ButtonText = "Manage Leave"
        Me.Manage.ButtonTextMarginLeft = 0
        Me.Manage.ColorContrastOnClick = 45
        Me.Manage.ColorContrastOnHover = 45
        Me.Manage.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges8.BottomLeft = True
        BorderEdges8.BottomRight = True
        BorderEdges8.TopLeft = True
        BorderEdges8.TopRight = True
        Me.Manage.CustomizableEdges = BorderEdges8
        Me.Manage.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Manage.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Manage.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Manage.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Manage.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.Manage.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!)
        Me.Manage.ForeColor = System.Drawing.Color.White
        Me.Manage.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Manage.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Manage.IconLeftPadding = New System.Windows.Forms.Padding(18, 3, 3, 3)
        Me.Manage.IconMarginLeft = 11
        Me.Manage.IconPadding = 17
        Me.Manage.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Manage.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Manage.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.Manage.IconSize = 325
        Me.Manage.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Manage.IdleBorderRadius = 45
        Me.Manage.IdleBorderThickness = 3
        Me.Manage.IdleFillColor = System.Drawing.Color.Transparent
        Me.Manage.IdleIconLeftImage = CType(resources.GetObject("Manage.IdleIconLeftImage"), System.Drawing.Image)
        Me.Manage.IdleIconRightImage = Nothing
        Me.Manage.IndicateFocus = False
        Me.Manage.Location = New System.Drawing.Point(21, 234)
        Me.Manage.Name = "Manage"
        Me.Manage.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Manage.OnDisabledState.BorderRadius = 45
        Me.Manage.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Manage.OnDisabledState.BorderThickness = 3
        Me.Manage.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Manage.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Manage.OnDisabledState.IconLeftImage = Nothing
        Me.Manage.OnDisabledState.IconRightImage = Nothing
        Me.Manage.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Manage.onHoverState.BorderRadius = 45
        Me.Manage.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Manage.onHoverState.BorderThickness = 3
        Me.Manage.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Manage.onHoverState.ForeColor = System.Drawing.Color.White
        Me.Manage.onHoverState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage14"), System.Drawing.Image)
        Me.Manage.onHoverState.IconRightImage = Nothing
        Me.Manage.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Manage.OnIdleState.BorderRadius = 45
        Me.Manage.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Manage.OnIdleState.BorderThickness = 3
        Me.Manage.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.Manage.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.Manage.OnIdleState.IconLeftImage = CType(resources.GetObject("Manage.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.Manage.OnIdleState.IconRightImage = Nothing
        Me.Manage.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Manage.OnPressedState.BorderRadius = 45
        Me.Manage.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Manage.OnPressedState.BorderThickness = 3
        Me.Manage.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Manage.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.Manage.OnPressedState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage15"), System.Drawing.Image)
        Me.Manage.OnPressedState.IconRightImage = Nothing
        Me.Manage.Size = New System.Drawing.Size(244, 60)
        Me.Manage.TabIndex = 25
        Me.Manage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Manage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Manage.TextMarginLeft = 0
        Me.Manage.TextPadding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.Manage.UseDefaultRadiusAndThickness = True
        '
        'BunifuTileButton1
        '
        Me.BunifuTileButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTileButton1.color = System.Drawing.Color.Transparent
        Me.BunifuTileButton1.colorActive = System.Drawing.Color.Transparent
        Me.BunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.BunifuTileButton1.ForeColor = System.Drawing.SystemColors.Window
        Me.BunifuTileButton1.Image = CType(resources.GetObject("BunifuTileButton1.Image"), System.Drawing.Image)
        Me.BunifuTileButton1.ImagePosition = 16
        Me.BunifuTileButton1.ImageZoom = 40
        Me.BunifuTileButton1.LabelPosition = 48
        Me.BunifuTileButton1.LabelText = "Administrator"
        Me.BunifuTileButton1.Location = New System.Drawing.Point(51, 12)
        Me.BunifuTileButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(184, 147)
        Me.BunifuTileButton1.TabIndex = 22
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.BorderRadius = 17
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.DarkGray
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Silver
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(300, 5)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(1135, 800)
        Me.BunifuGradientPanel2.TabIndex = 30
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1450, 825)
        Me.Controls.Add(Me.BunifuPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminForm"
        Me.BunifuPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuPanel1 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents DashBoard As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Logout As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents help As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Manage As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Holidays As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents settings As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuGradientPanel2 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents ReportAdmin As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents ManageUser As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class
