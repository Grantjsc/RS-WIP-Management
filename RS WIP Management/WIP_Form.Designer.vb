<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WIP_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WIP_Form))
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.GroupBoxTitle = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnCopy = New Guna.UI2.WinForms.Guna2Button()
        Me.btnViewAll = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLoad = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.lblProdName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGAP = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTarget = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.GroupBoxTitle.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.GroupBoxTitle)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(900, 650)
        Me.Guna2CustomGradientPanel1.TabIndex = 1
        '
        'GroupBoxTitle
        '
        Me.GroupBoxTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxTitle.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxTitle.BorderColor = System.Drawing.Color.Black
        Me.GroupBoxTitle.BorderRadius = 10
        Me.GroupBoxTitle.BorderThickness = 5
        Me.GroupBoxTitle.Controls.Add(Me.btnCopy)
        Me.GroupBoxTitle.Controls.Add(Me.btnViewAll)
        Me.GroupBoxTitle.Controls.Add(Me.btnLoad)
        Me.GroupBoxTitle.Controls.Add(Me.Label4)
        Me.GroupBoxTitle.Controls.Add(Me.Label5)
        Me.GroupBoxTitle.Controls.Add(Me.dtpEndDate)
        Me.GroupBoxTitle.Controls.Add(Me.dtpStartDate)
        Me.GroupBoxTitle.Controls.Add(Me.btnClose)
        Me.GroupBoxTitle.Controls.Add(Me.lblProdName)
        Me.GroupBoxTitle.Controls.Add(Me.Label3)
        Me.GroupBoxTitle.Controls.Add(Me.Label1)
        Me.GroupBoxTitle.Controls.Add(Me.txtGAP)
        Me.GroupBoxTitle.Controls.Add(Me.txtTarget)
        Me.GroupBoxTitle.Controls.Add(Me.Label2)
        Me.GroupBoxTitle.Controls.Add(Me.lblTitle)
        Me.GroupBoxTitle.Controls.Add(Me.DataGridView1)
        Me.GroupBoxTitle.CustomBorderColor = System.Drawing.Color.Transparent
        Me.GroupBoxTitle.FillColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBoxTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GroupBoxTitle.Location = New System.Drawing.Point(29, 30)
        Me.GroupBoxTitle.Name = "GroupBoxTitle"
        Me.GroupBoxTitle.Size = New System.Drawing.Size(841, 589)
        Me.GroupBoxTitle.TabIndex = 2
        Me.GroupBoxTitle.Text = "AVAILABLE WIP IN LINE"
        Me.GroupBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCopy.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCopy.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCopy.ForeColor = System.Drawing.Color.White
        Me.btnCopy.Location = New System.Drawing.Point(27, 365)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(88, 32)
        Me.btnCopy.TabIndex = 147
        Me.btnCopy.Text = "Copy data"
        Me.btnCopy.Visible = False
        '
        'btnViewAll
        '
        Me.btnViewAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnViewAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnViewAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnViewAll.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewAll.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnViewAll.ForeColor = System.Drawing.Color.White
        Me.btnViewAll.Location = New System.Drawing.Point(724, 365)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(88, 32)
        Me.btnViewAll.TabIndex = 146
        Me.btnViewAll.Text = "View All"
        '
        'btnLoad
        '
        Me.btnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoad.BackColor = System.Drawing.Color.Transparent
        Me.btnLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLoad.FillColor = System.Drawing.Color.Transparent
        Me.btnLoad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLoad.ForeColor = System.Drawing.Color.White
        Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
        Me.btnLoad.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnLoad.Location = New System.Drawing.Point(781, 49)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.PressedColor = System.Drawing.Color.LightGray
        Me.btnLoad.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnLoad.Size = New System.Drawing.Size(31, 30)
        Me.btnLoad.TabIndex = 145
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(546, 54)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 19)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "End Date:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(284, 52)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 19)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "Start Date:"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpEndDate.BackColor = System.Drawing.Color.Transparent
        Me.dtpEndDate.BorderRadius = 10
        Me.dtpEndDate.Checked = True
        Me.dtpEndDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.dtpEndDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dtpEndDate.ForeColor = System.Drawing.Color.White
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(622, 45)
        Me.dtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(153, 36)
        Me.dtpEndDate.TabIndex = 142
        Me.dtpEndDate.Value = New Date(2024, 10, 30, 0, 0, 0, 0)
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpStartDate.BackColor = System.Drawing.Color.Transparent
        Me.dtpStartDate.BorderRadius = 10
        Me.dtpStartDate.Checked = True
        Me.dtpStartDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.dtpStartDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dtpStartDate.ForeColor = System.Drawing.Color.White
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(369, 43)
        Me.dtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(153, 36)
        Me.dtpStartDate.TabIndex = 141
        Me.dtpStartDate.Value = New Date(2024, 10, 30, 0, 0, 0, 0)
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.FocusedColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnClose.Location = New System.Drawing.Point(16, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedColor = System.Drawing.Color.Transparent
        Me.btnClose.PressedDepth = 0
        Me.btnClose.Size = New System.Drawing.Size(29, 29)
        Me.btnClose.TabIndex = 68
        '
        'lblProdName
        '
        Me.lblProdName.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblProdName.BackColor = System.Drawing.Color.Transparent
        Me.lblProdName.Font = New System.Drawing.Font("Impact", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblProdName.Location = New System.Drawing.Point(181, 400)
        Me.lblProdName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProdName.Name = "lblProdName"
        Me.lblProdName.Size = New System.Drawing.Size(623, 36)
        Me.lblProdName.TabIndex = 16
        Me.lblProdName.Text = "name"
        Me.lblProdName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(27, 404)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 29)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Product name:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(569, 447)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 43)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "GAP"
        '
        'txtGAP
        '
        Me.txtGAP.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtGAP.BackColor = System.Drawing.Color.Transparent
        Me.txtGAP.BorderRadius = 20
        Me.txtGAP.BorderThickness = 3
        Me.txtGAP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGAP.DefaultText = ""
        Me.txtGAP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGAP.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGAP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGAP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGAP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGAP.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGAP.ForeColor = System.Drawing.Color.DimGray
        Me.txtGAP.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGAP.Location = New System.Drawing.Point(479, 501)
        Me.txtGAP.Margin = New System.Windows.Forms.Padding(6)
        Me.txtGAP.Name = "txtGAP"
        Me.txtGAP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGAP.PlaceholderText = ""
        Me.txtGAP.ReadOnly = True
        Me.txtGAP.SelectedText = ""
        Me.txtGAP.ShadowDecoration.BorderRadius = 20
        Me.txtGAP.ShadowDecoration.Depth = 15
        Me.txtGAP.ShadowDecoration.Enabled = True
        Me.txtGAP.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.txtGAP.Size = New System.Drawing.Size(250, 51)
        Me.txtGAP.TabIndex = 13
        Me.txtGAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTarget
        '
        Me.txtTarget.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtTarget.BackColor = System.Drawing.Color.Transparent
        Me.txtTarget.BorderRadius = 20
        Me.txtTarget.BorderThickness = 3
        Me.txtTarget.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTarget.DefaultText = ""
        Me.txtTarget.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTarget.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTarget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTarget.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTarget.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTarget.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarget.ForeColor = System.Drawing.Color.DimGray
        Me.txtTarget.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTarget.Location = New System.Drawing.Point(128, 501)
        Me.txtTarget.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTarget.PlaceholderText = ""
        Me.txtTarget.SelectedText = ""
        Me.txtTarget.ShadowDecoration.BorderRadius = 20
        Me.txtTarget.ShadowDecoration.Depth = 15
        Me.txtTarget.ShadowDecoration.Enabled = True
        Me.txtTarget.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.txtTarget.Size = New System.Drawing.Size(250, 51)
        Me.txtTarget.TabIndex = 1
        Me.txtTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(174, 480)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Please enter the target WIP"
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(182, 447)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(143, 36)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Target WIP"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(785, 272)
        Me.DataGridView1.TabIndex = 0
        '
        'WIP_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 650)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WIP_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "WIP_Form"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.GroupBoxTitle.ResumeLayout(False)
        Me.GroupBoxTitle.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBoxTitle As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtTarget As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtGAP As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblProdName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLoad As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpEndDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnViewAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCopy As Guna.UI2.WinForms.Guna2Button
End Class
