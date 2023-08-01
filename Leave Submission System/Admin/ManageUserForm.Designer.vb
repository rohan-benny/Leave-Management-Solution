<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageUserForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageUserForm))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.Modifybtn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Searchbtn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuPanel1 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.Deletebtn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Addbtn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuGradientPanel1.SuspendLayout()
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
        Me.BunifuGradientPanel1.Controls.Add(Me.Modifybtn)
        Me.BunifuGradientPanel1.Controls.Add(Me.Searchbtn)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuPanel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Deletebtn)
        Me.BunifuGradientPanel1.Controls.Add(Me.Addbtn)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkGray
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Gray
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(2, 2)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(1135, 800)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'Modifybtn
        '
        Me.Modifybtn.AllowAnimations = True
        Me.Modifybtn.AllowMouseEffects = True
        Me.Modifybtn.AllowToggling = False
        Me.Modifybtn.AnimationSpeed = 200
        Me.Modifybtn.AutoGenerateColors = False
        Me.Modifybtn.AutoRoundBorders = False
        Me.Modifybtn.AutoSizeLeftIcon = True
        Me.Modifybtn.AutoSizeRightIcon = True
        Me.Modifybtn.BackColor = System.Drawing.Color.Transparent
        Me.Modifybtn.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Modifybtn.BackgroundImage = CType(resources.GetObject("Modifybtn.BackgroundImage"), System.Drawing.Image)
        Me.Modifybtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Modifybtn.ButtonText = "Modify"
        Me.Modifybtn.ButtonTextMarginLeft = 0
        Me.Modifybtn.ColorContrastOnClick = 45
        Me.Modifybtn.ColorContrastOnHover = 45
        Me.Modifybtn.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.Modifybtn.CustomizableEdges = BorderEdges1
        Me.Modifybtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Modifybtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Modifybtn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Modifybtn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Modifybtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.Modifybtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modifybtn.ForeColor = System.Drawing.Color.White
        Me.Modifybtn.IconLeftAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Modifybtn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Modifybtn.IconLeftPadding = New System.Windows.Forms.Padding(10)
        Me.Modifybtn.IconMarginLeft = 11
        Me.Modifybtn.IconPadding = 30
        Me.Modifybtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Modifybtn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Modifybtn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.Modifybtn.IconSize = 20
        Me.Modifybtn.IdleBorderColor = System.Drawing.Color.Transparent
        Me.Modifybtn.IdleBorderRadius = 20
        Me.Modifybtn.IdleBorderThickness = 1
        Me.Modifybtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Modifybtn.IdleIconLeftImage = CType(resources.GetObject("Modifybtn.IdleIconLeftImage"), System.Drawing.Image)
        Me.Modifybtn.IdleIconRightImage = Nothing
        Me.Modifybtn.IndicateFocus = False
        Me.Modifybtn.Location = New System.Drawing.Point(125, 396)
        Me.Modifybtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Modifybtn.Name = "Modifybtn"
        Me.Modifybtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Modifybtn.OnDisabledState.BorderRadius = 20
        Me.Modifybtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Modifybtn.OnDisabledState.BorderThickness = 1
        Me.Modifybtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Modifybtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Modifybtn.OnDisabledState.IconLeftImage = Nothing
        Me.Modifybtn.OnDisabledState.IconRightImage = Nothing
        Me.Modifybtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Modifybtn.onHoverState.BorderRadius = 20
        Me.Modifybtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Modifybtn.onHoverState.BorderThickness = 1
        Me.Modifybtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Modifybtn.onHoverState.ForeColor = System.Drawing.Color.White
        Me.Modifybtn.onHoverState.IconLeftImage = Nothing
        Me.Modifybtn.onHoverState.IconRightImage = Nothing
        Me.Modifybtn.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.Modifybtn.OnIdleState.BorderRadius = 20
        Me.Modifybtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Modifybtn.OnIdleState.BorderThickness = 1
        Me.Modifybtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Modifybtn.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.Modifybtn.OnIdleState.IconLeftImage = CType(resources.GetObject("Modifybtn.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.Modifybtn.OnIdleState.IconRightImage = Nothing
        Me.Modifybtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Modifybtn.OnPressedState.BorderRadius = 20
        Me.Modifybtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Modifybtn.OnPressedState.BorderThickness = 1
        Me.Modifybtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Modifybtn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.Modifybtn.OnPressedState.IconLeftImage = Nothing
        Me.Modifybtn.OnPressedState.IconRightImage = Nothing
        Me.Modifybtn.Size = New System.Drawing.Size(91, 98)
        Me.Modifybtn.TabIndex = 6
        Me.Modifybtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Modifybtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Modifybtn.TextMarginLeft = 0
        Me.Modifybtn.TextPadding = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Modifybtn.UseDefaultRadiusAndThickness = True
        '
        'Searchbtn
        '
        Me.Searchbtn.AllowAnimations = True
        Me.Searchbtn.AllowMouseEffects = True
        Me.Searchbtn.AllowToggling = False
        Me.Searchbtn.AnimationSpeed = 200
        Me.Searchbtn.AutoGenerateColors = False
        Me.Searchbtn.AutoRoundBorders = False
        Me.Searchbtn.AutoSizeLeftIcon = True
        Me.Searchbtn.AutoSizeRightIcon = True
        Me.Searchbtn.BackColor = System.Drawing.Color.Transparent
        Me.Searchbtn.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Searchbtn.BackgroundImage = CType(resources.GetObject("Searchbtn.BackgroundImage"), System.Drawing.Image)
        Me.Searchbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Searchbtn.ButtonText = "Search"
        Me.Searchbtn.ButtonTextMarginLeft = 0
        Me.Searchbtn.ColorContrastOnClick = 45
        Me.Searchbtn.ColorContrastOnHover = 45
        Me.Searchbtn.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.Searchbtn.CustomizableEdges = BorderEdges2
        Me.Searchbtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Searchbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Searchbtn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Searchbtn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Searchbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.Searchbtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Searchbtn.ForeColor = System.Drawing.Color.White
        Me.Searchbtn.IconLeftAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Searchbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Searchbtn.IconLeftPadding = New System.Windows.Forms.Padding(10)
        Me.Searchbtn.IconMarginLeft = 11
        Me.Searchbtn.IconPadding = 25
        Me.Searchbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Searchbtn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Searchbtn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.Searchbtn.IconSize = 15
        Me.Searchbtn.IdleBorderColor = System.Drawing.Color.Transparent
        Me.Searchbtn.IdleBorderRadius = 20
        Me.Searchbtn.IdleBorderThickness = 1
        Me.Searchbtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Searchbtn.IdleIconLeftImage = CType(resources.GetObject("Searchbtn.IdleIconLeftImage"), System.Drawing.Image)
        Me.Searchbtn.IdleIconRightImage = Nothing
        Me.Searchbtn.IndicateFocus = False
        Me.Searchbtn.Location = New System.Drawing.Point(125, 265)
        Me.Searchbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Searchbtn.OnDisabledState.BorderRadius = 20
        Me.Searchbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Searchbtn.OnDisabledState.BorderThickness = 1
        Me.Searchbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Searchbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Searchbtn.OnDisabledState.IconLeftImage = Nothing
        Me.Searchbtn.OnDisabledState.IconRightImage = Nothing
        Me.Searchbtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Searchbtn.onHoverState.BorderRadius = 20
        Me.Searchbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Searchbtn.onHoverState.BorderThickness = 1
        Me.Searchbtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Searchbtn.onHoverState.ForeColor = System.Drawing.Color.White
        Me.Searchbtn.onHoverState.IconLeftImage = Nothing
        Me.Searchbtn.onHoverState.IconRightImage = Nothing
        Me.Searchbtn.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.Searchbtn.OnIdleState.BorderRadius = 20
        Me.Searchbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Searchbtn.OnIdleState.BorderThickness = 1
        Me.Searchbtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Searchbtn.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.Searchbtn.OnIdleState.IconLeftImage = CType(resources.GetObject("Searchbtn.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.Searchbtn.OnIdleState.IconRightImage = Nothing
        Me.Searchbtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Searchbtn.OnPressedState.BorderRadius = 20
        Me.Searchbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Searchbtn.OnPressedState.BorderThickness = 1
        Me.Searchbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Searchbtn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.Searchbtn.OnPressedState.IconLeftImage = Nothing
        Me.Searchbtn.OnPressedState.IconRightImage = Nothing
        Me.Searchbtn.Size = New System.Drawing.Size(91, 98)
        Me.Searchbtn.TabIndex = 8
        Me.Searchbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Searchbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Searchbtn.TextMarginLeft = 0
        Me.Searchbtn.TextPadding = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Searchbtn.UseDefaultRadiusAndThickness = True
        '
        'BunifuPanel1
        '
        Me.BunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent
        Me.BunifuPanel1.BackgroundImage = CType(resources.GetObject("BunifuPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel1.BorderRadius = 20
        Me.BunifuPanel1.BorderThickness = 1
        Me.BunifuPanel1.Location = New System.Drawing.Point(299, 31)
        Me.BunifuPanel1.Name = "BunifuPanel1"
        Me.BunifuPanel1.ShowBorders = True
        Me.BunifuPanel1.Size = New System.Drawing.Size(655, 730)
        Me.BunifuPanel1.TabIndex = 4
        '
        'Deletebtn
        '
        Me.Deletebtn.AllowAnimations = True
        Me.Deletebtn.AllowMouseEffects = True
        Me.Deletebtn.AllowToggling = False
        Me.Deletebtn.AnimationSpeed = 200
        Me.Deletebtn.AutoGenerateColors = False
        Me.Deletebtn.AutoRoundBorders = False
        Me.Deletebtn.AutoSizeLeftIcon = True
        Me.Deletebtn.AutoSizeRightIcon = True
        Me.Deletebtn.BackColor = System.Drawing.Color.Transparent
        Me.Deletebtn.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Deletebtn.BackgroundImage = CType(resources.GetObject("Deletebtn.BackgroundImage"), System.Drawing.Image)
        Me.Deletebtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Deletebtn.ButtonText = "Delete"
        Me.Deletebtn.ButtonTextMarginLeft = 0
        Me.Deletebtn.ColorContrastOnClick = 45
        Me.Deletebtn.ColorContrastOnHover = 45
        Me.Deletebtn.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.Deletebtn.CustomizableEdges = BorderEdges3
        Me.Deletebtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Deletebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Deletebtn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Deletebtn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Deletebtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.Deletebtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deletebtn.ForeColor = System.Drawing.Color.White
        Me.Deletebtn.IconLeftAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Deletebtn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Deletebtn.IconLeftPadding = New System.Windows.Forms.Padding(10)
        Me.Deletebtn.IconMarginLeft = 11
        Me.Deletebtn.IconPadding = 25
        Me.Deletebtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Deletebtn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Deletebtn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.Deletebtn.IconSize = 15
        Me.Deletebtn.IdleBorderColor = System.Drawing.Color.Transparent
        Me.Deletebtn.IdleBorderRadius = 20
        Me.Deletebtn.IdleBorderThickness = 1
        Me.Deletebtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Deletebtn.IdleIconLeftImage = CType(resources.GetObject("Deletebtn.IdleIconLeftImage"), System.Drawing.Image)
        Me.Deletebtn.IdleIconRightImage = Nothing
        Me.Deletebtn.IndicateFocus = False
        Me.Deletebtn.Location = New System.Drawing.Point(125, 533)
        Me.Deletebtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Deletebtn.OnDisabledState.BorderRadius = 20
        Me.Deletebtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Deletebtn.OnDisabledState.BorderThickness = 1
        Me.Deletebtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Deletebtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Deletebtn.OnDisabledState.IconLeftImage = Nothing
        Me.Deletebtn.OnDisabledState.IconRightImage = Nothing
        Me.Deletebtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Deletebtn.onHoverState.BorderRadius = 20
        Me.Deletebtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Deletebtn.onHoverState.BorderThickness = 1
        Me.Deletebtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Deletebtn.onHoverState.ForeColor = System.Drawing.Color.White
        Me.Deletebtn.onHoverState.IconLeftImage = Nothing
        Me.Deletebtn.onHoverState.IconRightImage = Nothing
        Me.Deletebtn.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.Deletebtn.OnIdleState.BorderRadius = 20
        Me.Deletebtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Deletebtn.OnIdleState.BorderThickness = 1
        Me.Deletebtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Deletebtn.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.Deletebtn.OnIdleState.IconLeftImage = CType(resources.GetObject("Deletebtn.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.Deletebtn.OnIdleState.IconRightImage = Nothing
        Me.Deletebtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Deletebtn.OnPressedState.BorderRadius = 20
        Me.Deletebtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Deletebtn.OnPressedState.BorderThickness = 1
        Me.Deletebtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Deletebtn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.Deletebtn.OnPressedState.IconLeftImage = Nothing
        Me.Deletebtn.OnPressedState.IconRightImage = Nothing
        Me.Deletebtn.Size = New System.Drawing.Size(91, 98)
        Me.Deletebtn.TabIndex = 7
        Me.Deletebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Deletebtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Deletebtn.TextMarginLeft = 0
        Me.Deletebtn.TextPadding = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Deletebtn.UseDefaultRadiusAndThickness = True
        '
        'Addbtn
        '
        Me.Addbtn.AllowAnimations = True
        Me.Addbtn.AllowMouseEffects = True
        Me.Addbtn.AllowToggling = False
        Me.Addbtn.AnimationSpeed = 200
        Me.Addbtn.AutoGenerateColors = False
        Me.Addbtn.AutoRoundBorders = False
        Me.Addbtn.AutoSizeLeftIcon = True
        Me.Addbtn.AutoSizeRightIcon = True
        Me.Addbtn.BackColor = System.Drawing.Color.Transparent
        Me.Addbtn.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Addbtn.BackgroundImage = CType(resources.GetObject("Addbtn.BackgroundImage"), System.Drawing.Image)
        Me.Addbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Addbtn.ButtonText = "Add"
        Me.Addbtn.ButtonTextMarginLeft = 0
        Me.Addbtn.ColorContrastOnClick = 45
        Me.Addbtn.ColorContrastOnHover = 45
        Me.Addbtn.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.Addbtn.CustomizableEdges = BorderEdges4
        Me.Addbtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Addbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Addbtn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Addbtn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Addbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.Addbtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addbtn.ForeColor = System.Drawing.Color.White
        Me.Addbtn.IconLeftAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Addbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Addbtn.IconLeftPadding = New System.Windows.Forms.Padding(10)
        Me.Addbtn.IconMarginLeft = 11
        Me.Addbtn.IconPadding = 25
        Me.Addbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Addbtn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Addbtn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.Addbtn.IconSize = 15
        Me.Addbtn.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Addbtn.IdleBorderRadius = 20
        Me.Addbtn.IdleBorderThickness = 1
        Me.Addbtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Addbtn.IdleIconLeftImage = CType(resources.GetObject("Addbtn.IdleIconLeftImage"), System.Drawing.Image)
        Me.Addbtn.IdleIconRightImage = Nothing
        Me.Addbtn.IndicateFocus = False
        Me.Addbtn.Location = New System.Drawing.Point(125, 142)
        Me.Addbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Addbtn.OnDisabledState.BorderRadius = 20
        Me.Addbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Addbtn.OnDisabledState.BorderThickness = 1
        Me.Addbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Addbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Addbtn.OnDisabledState.IconLeftImage = Nothing
        Me.Addbtn.OnDisabledState.IconRightImage = Nothing
        Me.Addbtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Addbtn.onHoverState.BorderRadius = 20
        Me.Addbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Addbtn.onHoverState.BorderThickness = 1
        Me.Addbtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Addbtn.onHoverState.ForeColor = System.Drawing.Color.White
        Me.Addbtn.onHoverState.IconLeftImage = Nothing
        Me.Addbtn.onHoverState.IconRightImage = Nothing
        Me.Addbtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Addbtn.OnIdleState.BorderRadius = 20
        Me.Addbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Addbtn.OnIdleState.BorderThickness = 1
        Me.Addbtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Addbtn.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.Addbtn.OnIdleState.IconLeftImage = CType(resources.GetObject("Addbtn.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.Addbtn.OnIdleState.IconRightImage = Nothing
        Me.Addbtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Addbtn.OnPressedState.BorderRadius = 20
        Me.Addbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Addbtn.OnPressedState.BorderThickness = 1
        Me.Addbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Addbtn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.Addbtn.OnPressedState.IconLeftImage = Nothing
        Me.Addbtn.OnPressedState.IconRightImage = Nothing
        Me.Addbtn.Size = New System.Drawing.Size(91, 98)
        Me.Addbtn.TabIndex = 5
        Me.Addbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Addbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Addbtn.TextMarginLeft = 0
        Me.Addbtn.TextPadding = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Addbtn.UseDefaultRadiusAndThickness = True
        '
        'ManageUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 800)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageUserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageUserForm"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel1 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents BunifuPanel1 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents Addbtn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Searchbtn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Deletebtn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Modifybtn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class
