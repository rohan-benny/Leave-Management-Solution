<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.ContactAdminBtn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Changepassword = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.editpro = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
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
        Me.BunifuGradientPanel1.BorderRadius = 1
        Me.BunifuGradientPanel1.Controls.Add(Me.editpro)
        Me.BunifuGradientPanel1.Controls.Add(Me.ContactAdminBtn)
        Me.BunifuGradientPanel1.Controls.Add(Me.Changepassword)
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
        'ContactAdminBtn
        '
        Me.ContactAdminBtn.AllowAnimations = True
        Me.ContactAdminBtn.AllowMouseEffects = True
        Me.ContactAdminBtn.AllowToggling = False
        Me.ContactAdminBtn.AnimationSpeed = 200
        Me.ContactAdminBtn.AutoGenerateColors = False
        Me.ContactAdminBtn.AutoRoundBorders = False
        Me.ContactAdminBtn.AutoSizeLeftIcon = True
        Me.ContactAdminBtn.AutoSizeRightIcon = True
        Me.ContactAdminBtn.BackColor = System.Drawing.Color.Transparent
        Me.ContactAdminBtn.BackColor1 = System.Drawing.Color.Transparent
        Me.ContactAdminBtn.BackgroundImage = CType(resources.GetObject("ContactAdminBtn.BackgroundImage"), System.Drawing.Image)
        Me.ContactAdminBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ContactAdminBtn.ButtonText = "Contact Admin"
        Me.ContactAdminBtn.ButtonTextMarginLeft = 0
        Me.ContactAdminBtn.ColorContrastOnClick = 45
        Me.ContactAdminBtn.ColorContrastOnHover = 45
        Me.ContactAdminBtn.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.ContactAdminBtn.CustomizableEdges = BorderEdges2
        Me.ContactAdminBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ContactAdminBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ContactAdminBtn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ContactAdminBtn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.ContactAdminBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle
        Me.ContactAdminBtn.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactAdminBtn.ForeColor = System.Drawing.Color.Black
        Me.ContactAdminBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ContactAdminBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.ContactAdminBtn.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.ContactAdminBtn.IconMarginLeft = 11
        Me.ContactAdminBtn.IconPadding = 10
        Me.ContactAdminBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ContactAdminBtn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.ContactAdminBtn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.ContactAdminBtn.IconSize = 25
        Me.ContactAdminBtn.IdleBorderColor = System.Drawing.Color.Transparent
        Me.ContactAdminBtn.IdleBorderRadius = 1
        Me.ContactAdminBtn.IdleBorderThickness = 1
        Me.ContactAdminBtn.IdleFillColor = System.Drawing.Color.Transparent
        Me.ContactAdminBtn.IdleIconLeftImage = Nothing
        Me.ContactAdminBtn.IdleIconRightImage = Nothing
        Me.ContactAdminBtn.IndicateFocus = False
        Me.ContactAdminBtn.Location = New System.Drawing.Point(123, 285)
        Me.ContactAdminBtn.Name = "ContactAdminBtn"
        Me.ContactAdminBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ContactAdminBtn.OnDisabledState.BorderRadius = 1
        Me.ContactAdminBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ContactAdminBtn.OnDisabledState.BorderThickness = 1
        Me.ContactAdminBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ContactAdminBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.ContactAdminBtn.OnDisabledState.IconLeftImage = Nothing
        Me.ContactAdminBtn.OnDisabledState.IconRightImage = Nothing
        Me.ContactAdminBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ContactAdminBtn.onHoverState.BorderRadius = 1
        Me.ContactAdminBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ContactAdminBtn.onHoverState.BorderThickness = 1
        Me.ContactAdminBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ContactAdminBtn.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.ContactAdminBtn.onHoverState.IconLeftImage = Nothing
        Me.ContactAdminBtn.onHoverState.IconRightImage = Nothing
        Me.ContactAdminBtn.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.ContactAdminBtn.OnIdleState.BorderRadius = 1
        Me.ContactAdminBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ContactAdminBtn.OnIdleState.BorderThickness = 1
        Me.ContactAdminBtn.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.ContactAdminBtn.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.ContactAdminBtn.OnIdleState.IconLeftImage = Nothing
        Me.ContactAdminBtn.OnIdleState.IconRightImage = Nothing
        Me.ContactAdminBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ContactAdminBtn.OnPressedState.BorderRadius = 1
        Me.ContactAdminBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ContactAdminBtn.OnPressedState.BorderThickness = 1
        Me.ContactAdminBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ContactAdminBtn.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.ContactAdminBtn.OnPressedState.IconLeftImage = Nothing
        Me.ContactAdminBtn.OnPressedState.IconRightImage = Nothing
        Me.ContactAdminBtn.Size = New System.Drawing.Size(150, 39)
        Me.ContactAdminBtn.TabIndex = 9
        Me.ContactAdminBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ContactAdminBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.ContactAdminBtn.TextMarginLeft = 0
        Me.ContactAdminBtn.TextPadding = New System.Windows.Forms.Padding(0)
        Me.ContactAdminBtn.UseDefaultRadiusAndThickness = True
        '
        'Changepassword
        '
        Me.Changepassword.AllowAnimations = True
        Me.Changepassword.AllowMouseEffects = True
        Me.Changepassword.AllowToggling = False
        Me.Changepassword.AnimationSpeed = 200
        Me.Changepassword.AutoGenerateColors = False
        Me.Changepassword.AutoRoundBorders = False
        Me.Changepassword.AutoSizeLeftIcon = True
        Me.Changepassword.AutoSizeRightIcon = True
        Me.Changepassword.BackColor = System.Drawing.Color.Transparent
        Me.Changepassword.BackColor1 = System.Drawing.Color.Transparent
        Me.Changepassword.BackgroundImage = CType(resources.GetObject("Changepassword.BackgroundImage"), System.Drawing.Image)
        Me.Changepassword.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Changepassword.ButtonText = "Change Password"
        Me.Changepassword.ButtonTextMarginLeft = 0
        Me.Changepassword.ColorContrastOnClick = 45
        Me.Changepassword.ColorContrastOnHover = 45
        Me.Changepassword.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.Changepassword.CustomizableEdges = BorderEdges3
        Me.Changepassword.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Changepassword.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Changepassword.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Changepassword.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Changepassword.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle
        Me.Changepassword.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Changepassword.ForeColor = System.Drawing.Color.Black
        Me.Changepassword.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Changepassword.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Changepassword.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.Changepassword.IconMarginLeft = 11
        Me.Changepassword.IconPadding = 10
        Me.Changepassword.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Changepassword.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Changepassword.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.Changepassword.IconSize = 25
        Me.Changepassword.IdleBorderColor = System.Drawing.Color.Transparent
        Me.Changepassword.IdleBorderRadius = 1
        Me.Changepassword.IdleBorderThickness = 1
        Me.Changepassword.IdleFillColor = System.Drawing.Color.Transparent
        Me.Changepassword.IdleIconLeftImage = Nothing
        Me.Changepassword.IdleIconRightImage = Nothing
        Me.Changepassword.IndicateFocus = False
        Me.Changepassword.Location = New System.Drawing.Point(123, 221)
        Me.Changepassword.Name = "Changepassword"
        Me.Changepassword.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Changepassword.OnDisabledState.BorderRadius = 1
        Me.Changepassword.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Changepassword.OnDisabledState.BorderThickness = 1
        Me.Changepassword.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Changepassword.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Changepassword.OnDisabledState.IconLeftImage = Nothing
        Me.Changepassword.OnDisabledState.IconRightImage = Nothing
        Me.Changepassword.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Changepassword.onHoverState.BorderRadius = 1
        Me.Changepassword.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Changepassword.onHoverState.BorderThickness = 1
        Me.Changepassword.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Changepassword.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.Changepassword.onHoverState.IconLeftImage = Nothing
        Me.Changepassword.onHoverState.IconRightImage = Nothing
        Me.Changepassword.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.Changepassword.OnIdleState.BorderRadius = 1
        Me.Changepassword.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Changepassword.OnIdleState.BorderThickness = 1
        Me.Changepassword.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.Changepassword.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.Changepassword.OnIdleState.IconLeftImage = Nothing
        Me.Changepassword.OnIdleState.IconRightImage = Nothing
        Me.Changepassword.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Changepassword.OnPressedState.BorderRadius = 1
        Me.Changepassword.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Changepassword.OnPressedState.BorderThickness = 1
        Me.Changepassword.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Changepassword.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.Changepassword.OnPressedState.IconLeftImage = Nothing
        Me.Changepassword.OnPressedState.IconRightImage = Nothing
        Me.Changepassword.Size = New System.Drawing.Size(160, 39)
        Me.Changepassword.TabIndex = 7
        Me.Changepassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Changepassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Changepassword.TextMarginLeft = 0
        Me.Changepassword.TextPadding = New System.Windows.Forms.Padding(0)
        Me.Changepassword.UseDefaultRadiusAndThickness = True
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.AutoSize = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Britannic Bold", 26.25!)
        Me.BunifuLabel1.Location = New System.Drawing.Point(50, 65)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(137, 43)
        Me.BunifuLabel1.TabIndex = 6
        Me.BunifuLabel1.Text = "Settings"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'editpro
        '
        Me.editpro.AllowAnimations = True
        Me.editpro.AllowMouseEffects = True
        Me.editpro.AllowToggling = False
        Me.editpro.AnimationSpeed = 200
        Me.editpro.AutoGenerateColors = False
        Me.editpro.AutoRoundBorders = False
        Me.editpro.AutoSizeLeftIcon = True
        Me.editpro.AutoSizeRightIcon = True
        Me.editpro.BackColor = System.Drawing.Color.Transparent
        Me.editpro.BackColor1 = System.Drawing.Color.Transparent
        Me.editpro.BackgroundImage = CType(resources.GetObject("editpro.BackgroundImage"), System.Drawing.Image)
        Me.editpro.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.editpro.ButtonText = "Edit Profile"
        Me.editpro.ButtonTextMarginLeft = 0
        Me.editpro.ColorContrastOnClick = 45
        Me.editpro.ColorContrastOnHover = 45
        Me.editpro.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.editpro.CustomizableEdges = BorderEdges1
        Me.editpro.DialogResult = System.Windows.Forms.DialogResult.None
        Me.editpro.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.editpro.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.editpro.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.editpro.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle
        Me.editpro.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editpro.ForeColor = System.Drawing.Color.Black
        Me.editpro.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.editpro.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.editpro.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.editpro.IconMarginLeft = 11
        Me.editpro.IconPadding = 10
        Me.editpro.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.editpro.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.editpro.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.editpro.IconSize = 25
        Me.editpro.IdleBorderColor = System.Drawing.Color.Transparent
        Me.editpro.IdleBorderRadius = 1
        Me.editpro.IdleBorderThickness = 1
        Me.editpro.IdleFillColor = System.Drawing.Color.Transparent
        Me.editpro.IdleIconLeftImage = Nothing
        Me.editpro.IdleIconRightImage = Nothing
        Me.editpro.IndicateFocus = False
        Me.editpro.Location = New System.Drawing.Point(123, 161)
        Me.editpro.Name = "editpro"
        Me.editpro.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.editpro.OnDisabledState.BorderRadius = 1
        Me.editpro.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.editpro.OnDisabledState.BorderThickness = 1
        Me.editpro.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.editpro.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.editpro.OnDisabledState.IconLeftImage = Nothing
        Me.editpro.OnDisabledState.IconRightImage = Nothing
        Me.editpro.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.editpro.onHoverState.BorderRadius = 1
        Me.editpro.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.editpro.onHoverState.BorderThickness = 1
        Me.editpro.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.editpro.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.editpro.onHoverState.IconLeftImage = Nothing
        Me.editpro.onHoverState.IconRightImage = Nothing
        Me.editpro.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.editpro.OnIdleState.BorderRadius = 1
        Me.editpro.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.editpro.OnIdleState.BorderThickness = 1
        Me.editpro.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.editpro.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.editpro.OnIdleState.IconLeftImage = Nothing
        Me.editpro.OnIdleState.IconRightImage = Nothing
        Me.editpro.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.editpro.OnPressedState.BorderRadius = 1
        Me.editpro.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.editpro.OnPressedState.BorderThickness = 1
        Me.editpro.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.editpro.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.editpro.OnPressedState.IconLeftImage = Nothing
        Me.editpro.OnPressedState.IconRightImage = Nothing
        Me.editpro.Size = New System.Drawing.Size(160, 39)
        Me.editpro.TabIndex = 10
        Me.editpro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.editpro.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.editpro.TextMarginLeft = 0
        Me.editpro.TextPadding = New System.Windows.Forms.Padding(0)
        Me.editpro.UseDefaultRadiusAndThickness = True
        '
        'SettingsForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1135, 800)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SettingsForm"
        Me.Text = "SettingsForm"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel1 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents ContactAdminBtn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Changepassword As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents editpro As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class
