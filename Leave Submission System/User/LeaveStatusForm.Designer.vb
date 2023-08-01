<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LeaveStatusForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LeaveStatusForm))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties9 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties10 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties11 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties12 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.LeaveList = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.cancelbtn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuPanel2 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.ToDate = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.FromDate = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.NoofDays = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.Leavetypebox = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.ReasonBox = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.BunifuLabel14 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel13 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel12 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel11 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel10 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel9 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuGradientPanel1 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.Leavestatus = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.LeaveList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuPanel2.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LeaveList
        '
        Me.LeaveList.AllowCustomTheming = False
        Me.LeaveList.AllowUserToAddRows = False
        Me.LeaveList.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.LeaveList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.LeaveList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LeaveList.BackgroundColor = System.Drawing.Color.White
        Me.LeaveList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LeaveList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.LeaveList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LeaveList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.LeaveList.ColumnHeadersHeight = 40
        Me.LeaveList.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LeaveList.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LeaveList.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.LeaveList.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LeaveList.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.LeaveList.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.LeaveList.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LeaveList.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.LeaveList.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.LeaveList.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.LeaveList.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.LeaveList.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.LeaveList.CurrentTheme.Name = Nothing
        Me.LeaveList.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.LeaveList.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LeaveList.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.LeaveList.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LeaveList.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LeaveList.DefaultCellStyle = DataGridViewCellStyle3
        Me.LeaveList.EnableHeadersVisualStyles = False
        Me.LeaveList.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LeaveList.HeaderBackColor = System.Drawing.Color.DodgerBlue
#Disable Warning BC40000 ' 'Public Overloads Property HeaderBgColor As Color' is obsolete: 'This property has been deprecated. Use HeaderBackColor instead.'.
        Me.LeaveList.HeaderBgColor = System.Drawing.Color.Empty
#Enable Warning BC40000 ' 'Public Overloads Property HeaderBgColor As Color' is obsolete: 'This property has been deprecated. Use HeaderBackColor instead.'.
        Me.LeaveList.HeaderForeColor = System.Drawing.Color.White
        Me.LeaveList.Location = New System.Drawing.Point(8, 8)
        Me.LeaveList.Name = "LeaveList"
        Me.LeaveList.ReadOnly = True
        Me.LeaveList.RowHeadersVisible = False
        Me.LeaveList.RowTemplate.Height = 40
        Me.LeaveList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LeaveList.Size = New System.Drawing.Size(1115, 255)
        Me.LeaveList.TabIndex = 5
        Me.LeaveList.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'cancelbtn
        '
        Me.cancelbtn.AllowAnimations = True
        Me.cancelbtn.AllowMouseEffects = True
        Me.cancelbtn.AllowToggling = False
        Me.cancelbtn.AnimationSpeed = 200
        Me.cancelbtn.AutoGenerateColors = False
        Me.cancelbtn.AutoRoundBorders = False
        Me.cancelbtn.AutoSizeLeftIcon = True
        Me.cancelbtn.AutoSizeRightIcon = True
        Me.cancelbtn.BackColor = System.Drawing.Color.Transparent
        Me.cancelbtn.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cancelbtn.BackgroundImage = CType(resources.GetObject("cancelbtn.BackgroundImage"), System.Drawing.Image)
        Me.cancelbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.cancelbtn.ButtonText = "Cancel Leave"
        Me.cancelbtn.ButtonTextMarginLeft = 0
        Me.cancelbtn.ColorContrastOnClick = 45
        Me.cancelbtn.ColorContrastOnHover = 45
        Me.cancelbtn.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.cancelbtn.CustomizableEdges = BorderEdges1
        Me.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cancelbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.cancelbtn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cancelbtn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.cancelbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.cancelbtn.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelbtn.ForeColor = System.Drawing.Color.White
        Me.cancelbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancelbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.cancelbtn.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.cancelbtn.IconMarginLeft = 11
        Me.cancelbtn.IconPadding = 10
        Me.cancelbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cancelbtn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.cancelbtn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.cancelbtn.IconSize = 25
        Me.cancelbtn.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cancelbtn.IdleBorderRadius = 35
        Me.cancelbtn.IdleBorderThickness = 1
        Me.cancelbtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cancelbtn.IdleIconLeftImage = Nothing
        Me.cancelbtn.IdleIconRightImage = Nothing
        Me.cancelbtn.IndicateFocus = False
        Me.cancelbtn.Location = New System.Drawing.Point(738, 686)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.cancelbtn.OnDisabledState.BorderRadius = 35
        Me.cancelbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.cancelbtn.OnDisabledState.BorderThickness = 1
        Me.cancelbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cancelbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.cancelbtn.OnDisabledState.IconLeftImage = Nothing
        Me.cancelbtn.OnDisabledState.IconRightImage = Nothing
        Me.cancelbtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.cancelbtn.onHoverState.BorderRadius = 35
        Me.cancelbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.cancelbtn.onHoverState.BorderThickness = 1
        Me.cancelbtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.cancelbtn.onHoverState.ForeColor = System.Drawing.Color.White
        Me.cancelbtn.onHoverState.IconLeftImage = Nothing
        Me.cancelbtn.onHoverState.IconRightImage = Nothing
        Me.cancelbtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cancelbtn.OnIdleState.BorderRadius = 35
        Me.cancelbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.cancelbtn.OnIdleState.BorderThickness = 1
        Me.cancelbtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cancelbtn.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.cancelbtn.OnIdleState.IconLeftImage = Nothing
        Me.cancelbtn.OnIdleState.IconRightImage = Nothing
        Me.cancelbtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.cancelbtn.OnPressedState.BorderRadius = 35
        Me.cancelbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.cancelbtn.OnPressedState.BorderThickness = 1
        Me.cancelbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.cancelbtn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.cancelbtn.OnPressedState.IconLeftImage = Nothing
        Me.cancelbtn.OnPressedState.IconRightImage = Nothing
        Me.cancelbtn.Size = New System.Drawing.Size(209, 51)
        Me.cancelbtn.TabIndex = 2
        Me.cancelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cancelbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.cancelbtn.TextMarginLeft = 0
        Me.cancelbtn.TextPadding = New System.Windows.Forms.Padding(0)
        Me.cancelbtn.UseDefaultRadiusAndThickness = True
        '
        'BunifuPanel2
        '
        Me.BunifuPanel2.BackgroundColor = System.Drawing.Color.White
        Me.BunifuPanel2.BackgroundImage = CType(resources.GetObject("BunifuPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuPanel2.BorderRadius = 17
        Me.BunifuPanel2.BorderThickness = 3
        Me.BunifuPanel2.Controls.Add(Me.ToDate)
        Me.BunifuPanel2.Controls.Add(Me.FromDate)
        Me.BunifuPanel2.Controls.Add(Me.NoofDays)
        Me.BunifuPanel2.Controls.Add(Me.Leavetypebox)
        Me.BunifuPanel2.Controls.Add(Me.ReasonBox)
        Me.BunifuPanel2.Controls.Add(Me.BunifuLabel14)
        Me.BunifuPanel2.Controls.Add(Me.BunifuLabel13)
        Me.BunifuPanel2.Controls.Add(Me.BunifuLabel12)
        Me.BunifuPanel2.Controls.Add(Me.BunifuLabel11)
        Me.BunifuPanel2.Controls.Add(Me.BunifuLabel10)
        Me.BunifuPanel2.Controls.Add(Me.BunifuLabel9)
        Me.BunifuPanel2.Location = New System.Drawing.Point(40, 269)
        Me.BunifuPanel2.Name = "BunifuPanel2"
        Me.BunifuPanel2.ShowBorders = True
        Me.BunifuPanel2.Size = New System.Drawing.Size(487, 519)
        Me.BunifuPanel2.TabIndex = 0
        '
        'ToDate
        '
        Me.ToDate.BackColor = System.Drawing.Color.Transparent
        Me.ToDate.BorderRadius = 9
        Me.ToDate.Color = System.Drawing.Color.Silver
        Me.ToDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.ToDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Right
        Me.ToDate.DisabledColor = System.Drawing.Color.Gray
        Me.ToDate.DisplayWeekNumbers = False
        Me.ToDate.DPHeight = 0
        Me.ToDate.FillDatePicker = False
        Me.ToDate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDate.ForeColor = System.Drawing.Color.Black
        Me.ToDate.Icon = CType(resources.GetObject("ToDate.Icon"), System.Drawing.Image)
        Me.ToDate.IconColor = System.Drawing.Color.DimGray
        Me.ToDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Left
        Me.ToDate.LeftTextMargin = 5
        Me.ToDate.Location = New System.Drawing.Point(202, 191)
        Me.ToDate.MinimumSize = New System.Drawing.Size(4, 32)
        Me.ToDate.Name = "ToDate"
        Me.ToDate.Size = New System.Drawing.Size(247, 32)
        Me.ToDate.TabIndex = 15
        Me.ToDate.Value = New Date(2023, 2, 5, 12, 3, 0, 0)
        '
        'FromDate
        '
        Me.FromDate.BackColor = System.Drawing.Color.Transparent
        Me.FromDate.BorderRadius = 9
        Me.FromDate.Color = System.Drawing.Color.Silver
        Me.FromDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.FromDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Right
        Me.FromDate.DisabledColor = System.Drawing.Color.Gray
        Me.FromDate.DisplayWeekNumbers = False
        Me.FromDate.DPHeight = 0
        Me.FromDate.FillDatePicker = False
        Me.FromDate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromDate.ForeColor = System.Drawing.Color.Black
        Me.FromDate.Icon = CType(resources.GetObject("FromDate.Icon"), System.Drawing.Image)
        Me.FromDate.IconColor = System.Drawing.Color.DimGray
        Me.FromDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Left
        Me.FromDate.LeftTextMargin = 5
        Me.FromDate.Location = New System.Drawing.Point(202, 134)
        Me.FromDate.MinimumSize = New System.Drawing.Size(4, 32)
        Me.FromDate.Name = "FromDate"
        Me.FromDate.Size = New System.Drawing.Size(247, 32)
        Me.FromDate.TabIndex = 14
        Me.FromDate.Value = New Date(2023, 2, 18, 13, 20, 0, 0)
        '
        'NoofDays
        '
        Me.NoofDays.AcceptsReturn = False
        Me.NoofDays.AcceptsTab = False
        Me.NoofDays.AnimationSpeed = 200
        Me.NoofDays.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.NoofDays.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.NoofDays.BackColor = System.Drawing.Color.Transparent
        Me.NoofDays.BackgroundImage = CType(resources.GetObject("NoofDays.BackgroundImage"), System.Drawing.Image)
        Me.NoofDays.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.NoofDays.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.NoofDays.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.NoofDays.BorderColorIdle = System.Drawing.Color.LightGray
        Me.NoofDays.BorderRadius = 9
        Me.NoofDays.BorderThickness = 0
        Me.NoofDays.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.NoofDays.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NoofDays.DefaultFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoofDays.DefaultText = ""
        Me.NoofDays.FillColor = System.Drawing.Color.White
        Me.NoofDays.HideSelection = True
        Me.NoofDays.IconLeft = Nothing
        Me.NoofDays.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.NoofDays.IconPadding = 10
        Me.NoofDays.IconRight = Nothing
        Me.NoofDays.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.NoofDays.Lines = New String(-1) {}
        Me.NoofDays.Location = New System.Drawing.Point(202, 241)
        Me.NoofDays.MaxLength = 32767
        Me.NoofDays.MinimumSize = New System.Drawing.Size(1, 1)
        Me.NoofDays.Modified = False
        Me.NoofDays.Multiline = False
        Me.NoofDays.Name = "NoofDays"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.NoofDays.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.NoofDays.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.NoofDays.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.LightGray
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.NoofDays.OnIdleState = StateProperties4
        Me.NoofDays.Padding = New System.Windows.Forms.Padding(3)
        Me.NoofDays.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NoofDays.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.NoofDays.PlaceholderText = "Enter text"
        Me.NoofDays.ReadOnly = False
        Me.NoofDays.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.NoofDays.SelectedText = ""
        Me.NoofDays.SelectionLength = 0
        Me.NoofDays.SelectionStart = 0
        Me.NoofDays.ShortcutsEnabled = True
        Me.NoofDays.Size = New System.Drawing.Size(247, 34)
        Me.NoofDays.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.NoofDays.TabIndex = 13
        Me.NoofDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NoofDays.TextMarginBottom = 0
        Me.NoofDays.TextMarginLeft = 3
        Me.NoofDays.TextMarginTop = 0
        Me.NoofDays.TextPlaceholder = "Enter text"
        Me.NoofDays.UseSystemPasswordChar = False
        Me.NoofDays.WordWrap = True
        '
        'Leavetypebox
        '
        Me.Leavetypebox.BackColor = System.Drawing.Color.Transparent
        Me.Leavetypebox.BackgroundColor = System.Drawing.Color.White
        Me.Leavetypebox.BorderColor = System.Drawing.Color.Silver
        Me.Leavetypebox.BorderRadius = 9
        Me.Leavetypebox.Color = System.Drawing.Color.Silver
        Me.Leavetypebox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.Leavetypebox.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Leavetypebox.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Leavetypebox.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Leavetypebox.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Leavetypebox.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.Leavetypebox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Leavetypebox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.Leavetypebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Leavetypebox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.Leavetypebox.FillDropDown = True
        Me.Leavetypebox.FillIndicator = False
        Me.Leavetypebox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Leavetypebox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Leavetypebox.ForeColor = System.Drawing.Color.Black
        Me.Leavetypebox.FormattingEnabled = True
        Me.Leavetypebox.Icon = Nothing
        Me.Leavetypebox.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.Leavetypebox.IndicatorColor = System.Drawing.Color.Gray
        Me.Leavetypebox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.Leavetypebox.ItemBackColor = System.Drawing.Color.White
        Me.Leavetypebox.ItemBorderColor = System.Drawing.Color.White
        Me.Leavetypebox.ItemForeColor = System.Drawing.Color.Black
        Me.Leavetypebox.ItemHeight = 26
        Me.Leavetypebox.ItemHighLightColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Leavetypebox.ItemHighLightForeColor = System.Drawing.Color.White
        Me.Leavetypebox.ItemTopMargin = 3
        Me.Leavetypebox.Location = New System.Drawing.Point(202, 81)
        Me.Leavetypebox.Name = "Leavetypebox"
        Me.Leavetypebox.Size = New System.Drawing.Size(247, 32)
        Me.Leavetypebox.TabIndex = 12
        Me.Leavetypebox.Text = "None"
        Me.Leavetypebox.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.Leavetypebox.TextLeftMargin = 5
        '
        'ReasonBox
        '
        Me.ReasonBox.AcceptsReturn = False
        Me.ReasonBox.AcceptsTab = False
        Me.ReasonBox.AnimationSpeed = 200
        Me.ReasonBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.ReasonBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.ReasonBox.BackColor = System.Drawing.Color.Transparent
        Me.ReasonBox.BackgroundImage = CType(resources.GetObject("ReasonBox.BackgroundImage"), System.Drawing.Image)
        Me.ReasonBox.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ReasonBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ReasonBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ReasonBox.BorderColorIdle = System.Drawing.Color.LightGray
        Me.ReasonBox.BorderRadius = 17
        Me.ReasonBox.BorderThickness = 0
        Me.ReasonBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ReasonBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ReasonBox.DefaultFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReasonBox.DefaultText = ""
        Me.ReasonBox.FillColor = System.Drawing.Color.White
        Me.ReasonBox.HideSelection = True
        Me.ReasonBox.IconLeft = Nothing
        Me.ReasonBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.ReasonBox.IconPadding = 10
        Me.ReasonBox.IconRight = Nothing
        Me.ReasonBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.ReasonBox.Lines = New String(-1) {}
        Me.ReasonBox.Location = New System.Drawing.Point(36, 347)
        Me.ReasonBox.MaxLength = 32767
        Me.ReasonBox.MinimumSize = New System.Drawing.Size(2, 2)
        Me.ReasonBox.Modified = False
        Me.ReasonBox.Multiline = True
        Me.ReasonBox.Name = "ReasonBox"
        StateProperties5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.ReasonBox.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.ReasonBox.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.ReasonBox.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.LightGray
        StateProperties8.FillColor = System.Drawing.Color.White
        StateProperties8.ForeColor = System.Drawing.Color.Empty
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.ReasonBox.OnIdleState = StateProperties8
        Me.ReasonBox.Padding = New System.Windows.Forms.Padding(3)
        Me.ReasonBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ReasonBox.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.ReasonBox.PlaceholderText = "Remarks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ReasonBox.ReadOnly = False
        Me.ReasonBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ReasonBox.SelectedText = ""
        Me.ReasonBox.SelectionLength = 0
        Me.ReasonBox.SelectionStart = 0
        Me.ReasonBox.ShortcutsEnabled = True
        Me.ReasonBox.Size = New System.Drawing.Size(413, 121)
        Me.ReasonBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.ReasonBox.TabIndex = 2
        Me.ReasonBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ReasonBox.TextMarginBottom = 0
        Me.ReasonBox.TextMarginLeft = 3
        Me.ReasonBox.TextMarginTop = 0
        Me.ReasonBox.TextPlaceholder = "Remarks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ReasonBox.UseSystemPasswordChar = False
        Me.ReasonBox.WordWrap = True
        '
        'BunifuLabel14
        '
        Me.BunifuLabel14.AllowParentOverrides = False
        Me.BunifuLabel14.AutoEllipsis = False
        Me.BunifuLabel14.AutoSize = False
        Me.BunifuLabel14.CursorType = Nothing
        Me.BunifuLabel14.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel14.Location = New System.Drawing.Point(36, 301)
        Me.BunifuLabel14.Name = "BunifuLabel14"
        Me.BunifuLabel14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel14.Size = New System.Drawing.Size(130, 23)
        Me.BunifuLabel14.TabIndex = 12
        Me.BunifuLabel14.Text = "Reason"
        Me.BunifuLabel14.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel14.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel13
        '
        Me.BunifuLabel13.AllowParentOverrides = False
        Me.BunifuLabel13.AutoEllipsis = False
        Me.BunifuLabel13.AutoSize = False
        Me.BunifuLabel13.CursorType = Nothing
        Me.BunifuLabel13.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel13.Location = New System.Drawing.Point(36, 248)
        Me.BunifuLabel13.Name = "BunifuLabel13"
        Me.BunifuLabel13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel13.Size = New System.Drawing.Size(130, 23)
        Me.BunifuLabel13.TabIndex = 11
        Me.BunifuLabel13.Text = "No of Days"
        Me.BunifuLabel13.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel13.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel12
        '
        Me.BunifuLabel12.AllowParentOverrides = False
        Me.BunifuLabel12.AutoEllipsis = False
        Me.BunifuLabel12.AutoSize = False
        Me.BunifuLabel12.CursorType = Nothing
        Me.BunifuLabel12.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel12.Location = New System.Drawing.Point(36, 81)
        Me.BunifuLabel12.Name = "BunifuLabel12"
        Me.BunifuLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel12.Size = New System.Drawing.Size(130, 23)
        Me.BunifuLabel12.TabIndex = 10
        Me.BunifuLabel12.Text = "Leave Type"
        Me.BunifuLabel12.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel12.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel11
        '
        Me.BunifuLabel11.AllowParentOverrides = False
        Me.BunifuLabel11.AutoEllipsis = False
        Me.BunifuLabel11.AutoSize = False
        Me.BunifuLabel11.CursorType = Nothing
        Me.BunifuLabel11.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel11.Location = New System.Drawing.Point(36, 136)
        Me.BunifuLabel11.Name = "BunifuLabel11"
        Me.BunifuLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel11.Size = New System.Drawing.Size(130, 23)
        Me.BunifuLabel11.TabIndex = 9
        Me.BunifuLabel11.Text = "From"
        Me.BunifuLabel11.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel11.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel10
        '
        Me.BunifuLabel10.AllowParentOverrides = False
        Me.BunifuLabel10.AutoEllipsis = False
        Me.BunifuLabel10.AutoSize = False
        Me.BunifuLabel10.CursorType = Nothing
        Me.BunifuLabel10.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel10.Location = New System.Drawing.Point(36, 193)
        Me.BunifuLabel10.Name = "BunifuLabel10"
        Me.BunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel10.Size = New System.Drawing.Size(130, 23)
        Me.BunifuLabel10.TabIndex = 8
        Me.BunifuLabel10.Text = "To"
        Me.BunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel9
        '
        Me.BunifuLabel9.AllowParentOverrides = False
        Me.BunifuLabel9.AutoEllipsis = False
        Me.BunifuLabel9.AutoSize = False
        Me.BunifuLabel9.CursorType = Nothing
        Me.BunifuLabel9.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel9.Location = New System.Drawing.Point(131, 20)
        Me.BunifuLabel9.Name = "BunifuLabel9"
        Me.BunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel9.Size = New System.Drawing.Size(259, 31)
        Me.BunifuLabel9.TabIndex = 7
        Me.BunifuLabel9.Text = "Leave Information"
        Me.BunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderRadius = 17
        Me.BunifuGradientPanel1.Controls.Add(Me.Leavestatus)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuLabel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.LeaveList)
        Me.BunifuGradientPanel1.Controls.Add(Me.cancelbtn)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuPanel2)
        Me.BunifuGradientPanel1.Font = New System.Drawing.Font("Britannic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkGray
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Silver
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(1135, 800)
        Me.BunifuGradientPanel1.TabIndex = 2
        '
        'Leavestatus
        '
        Me.Leavestatus.AcceptsReturn = False
        Me.Leavestatus.AcceptsTab = False
        Me.Leavestatus.AnimationSpeed = 200
        Me.Leavestatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Leavestatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Leavestatus.BackColor = System.Drawing.Color.Transparent
        Me.Leavestatus.BackgroundImage = CType(resources.GetObject("Leavestatus.BackgroundImage"), System.Drawing.Image)
        Me.Leavestatus.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Leavestatus.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Leavestatus.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Leavestatus.BorderColorIdle = System.Drawing.Color.Black
        Me.Leavestatus.BorderRadius = 17
        Me.Leavestatus.BorderThickness = 0
        Me.Leavestatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Leavestatus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Leavestatus.DefaultFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Leavestatus.DefaultText = ""
        Me.Leavestatus.FillColor = System.Drawing.Color.White
        Me.Leavestatus.HideSelection = True
        Me.Leavestatus.IconLeft = Nothing
        Me.Leavestatus.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.Leavestatus.IconPadding = 10
        Me.Leavestatus.IconRight = Nothing
        Me.Leavestatus.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.Leavestatus.Lines = New String(-1) {}
        Me.Leavestatus.Location = New System.Drawing.Point(718, 442)
        Me.Leavestatus.MaxLength = 32767
        Me.Leavestatus.MinimumSize = New System.Drawing.Size(1, 1)
        Me.Leavestatus.Modified = False
        Me.Leavestatus.Multiline = False
        Me.Leavestatus.Name = "Leavestatus"
        StateProperties9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        StateProperties9.FillColor = System.Drawing.Color.Empty
        StateProperties9.ForeColor = System.Drawing.Color.Empty
        StateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Leavestatus.OnActiveState = StateProperties9
        StateProperties10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties10.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.Leavestatus.OnDisabledState = StateProperties10
        StateProperties11.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(167, Byte), Integer))
        StateProperties11.FillColor = System.Drawing.Color.Empty
        StateProperties11.ForeColor = System.Drawing.Color.Empty
        StateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Leavestatus.OnHoverState = StateProperties11
        StateProperties12.BorderColor = System.Drawing.Color.Black
        StateProperties12.FillColor = System.Drawing.Color.White
        StateProperties12.ForeColor = System.Drawing.Color.Empty
        StateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Leavestatus.OnIdleState = StateProperties12
        Me.Leavestatus.Padding = New System.Windows.Forms.Padding(3)
        Me.Leavestatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Leavestatus.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.Leavestatus.PlaceholderText = "Leave Status"
        Me.Leavestatus.ReadOnly = False
        Me.Leavestatus.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Leavestatus.SelectedText = ""
        Me.Leavestatus.SelectionLength = 0
        Me.Leavestatus.SelectionStart = 0
        Me.Leavestatus.ShortcutsEnabled = True
        Me.Leavestatus.Size = New System.Drawing.Size(284, 50)
        Me.Leavestatus.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.Leavestatus.TabIndex = 14
        Me.Leavestatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Leavestatus.TextMarginBottom = 0
        Me.Leavestatus.TextMarginLeft = 3
        Me.Leavestatus.TextMarginTop = 0
        Me.Leavestatus.TextPlaceholder = "Leave Status"
        Me.Leavestatus.UseSystemPasswordChar = False
        Me.Leavestatus.WordWrap = True
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.AutoSize = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Britannic Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.Location = New System.Drawing.Point(665, 373)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(250, 55)
        Me.BunifuLabel1.TabIndex = 11
        Me.BunifuLabel1.Text = "Leave Status"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 17
        Me.BunifuElipse1.TargetControl = Me
        '
        'LeaveStatusForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1135, 800)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LeaveStatusForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LeaveStatusForm"
        CType(Me.LeaveList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LeaveList As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents cancelbtn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuPanel2 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents ToDate As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents FromDate As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents NoofDays As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents Leavetypebox As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents ReasonBox As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuLabel14 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel13 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel12 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel11 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel10 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel9 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents Leavestatus As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
