<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblfooter1 = New System.Windows.Forms.Label()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PunchPressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VibratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadAndWashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnealingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.WIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.lblProcessName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLot = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTransac = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.txtProduct = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblfooter2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Main = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.UpdateWIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewWIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblfooter1
        '
        Me.lblfooter1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblfooter1.AutoSize = True
        Me.lblfooter1.BackColor = System.Drawing.Color.Transparent
        Me.lblfooter1.Font = New System.Drawing.Font("Nirmala UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfooter1.ForeColor = System.Drawing.Color.White
        Me.lblfooter1.Location = New System.Drawing.Point(11, 666)
        Me.lblfooter1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfooter1.Name = "lblfooter1"
        Me.lblfooter1.Size = New System.Drawing.Size(133, 12)
        Me.lblfooter1.TabIndex = 122
        Me.lblfooter1.Text = "LITTELFUSE PHILIPPINES INC." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PunchPressToolStripMenuItem, Me.VibratorToolStripMenuItem, Me.LoadAndWashToolStripMenuItem, Me.AnnealingToolStripMenuItem, Me.WashToolStripMenuItem, Me.SputToolStripMenuItem, Me.SAMToolStripMenuItem})
        Me.SettingToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(55, 21)
        Me.SettingToolStripMenuItem.Text = "Menu"
        '
        'PunchPressToolStripMenuItem
        '
        Me.PunchPressToolStripMenuItem.Name = "PunchPressToolStripMenuItem"
        Me.PunchPressToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.PunchPressToolStripMenuItem.Text = "Punch Press"
        '
        'VibratorToolStripMenuItem
        '
        Me.VibratorToolStripMenuItem.Name = "VibratorToolStripMenuItem"
        Me.VibratorToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.VibratorToolStripMenuItem.Text = "Vibrator"
        '
        'LoadAndWashToolStripMenuItem
        '
        Me.LoadAndWashToolStripMenuItem.Name = "LoadAndWashToolStripMenuItem"
        Me.LoadAndWashToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.LoadAndWashToolStripMenuItem.Text = "Load and Wash"
        '
        'AnnealingToolStripMenuItem
        '
        Me.AnnealingToolStripMenuItem.Name = "AnnealingToolStripMenuItem"
        Me.AnnealingToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AnnealingToolStripMenuItem.Text = "Annealing"
        '
        'WashToolStripMenuItem
        '
        Me.WashToolStripMenuItem.Name = "WashToolStripMenuItem"
        Me.WashToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.WashToolStripMenuItem.Text = "Wash"
        '
        'SputToolStripMenuItem
        '
        Me.SputToolStripMenuItem.Name = "SputToolStripMenuItem"
        Me.SputToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.SputToolStripMenuItem.Text = "Sput"
        '
        'SAMToolStripMenuItem
        '
        Me.SAMToolStripMenuItem.Name = "SAMToolStripMenuItem"
        Me.SAMToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.SAMToolStripMenuItem.Text = "SAM"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem, Me.WIPToolStripMenuItem, Me.MenuToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(980, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'WIPToolStripMenuItem
        '
        Me.WIPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewWIPToolStripMenuItem, Me.UpdateWIPToolStripMenuItem})
        Me.WIPToolStripMenuItem.Name = "WIPToolStripMenuItem"
        Me.WIPToolStripMenuItem.Size = New System.Drawing.Size(45, 21)
        Me.WIPToolStripMenuItem.Text = "WIP"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(80, 21)
        Me.MenuToolStripMenuItem.Text = "View Data"
        Me.MenuToolStripMenuItem.Visible = False
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(69, 21)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 124
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(174, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 45)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(120, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 45)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Transaction"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(133, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 45)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Lot number"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubmit.BorderRadius = 15
        Me.btnSubmit.BorderThickness = 3
        Me.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSubmit.FillColor = System.Drawing.Color.White
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSubmit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubmit.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSubmit.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnSubmit.Location = New System.Drawing.Point(279, 394)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.ShadowDecoration.BorderRadius = 15
        Me.btnSubmit.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubmit.ShadowDecoration.Enabled = True
        Me.btnSubmit.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(7)
        Me.btnSubmit.Size = New System.Drawing.Size(134, 56)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        '
        'lblProcessName
        '
        Me.lblProcessName.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessName.Font = New System.Drawing.Font("Impact", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessName.ForeColor = System.Drawing.Color.White
        Me.lblProcessName.Location = New System.Drawing.Point(309, 25)
        Me.lblProcessName.Name = "lblProcessName"
        Me.lblProcessName.Size = New System.Drawing.Size(492, 56)
        Me.lblProcessName.TabIndex = 127
        Me.lblProcessName.Text = "Process"
        Me.lblProcessName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(91, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 45)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Product name"
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.Transparent
        Me.txtQty.BorderColor = System.Drawing.Color.Black
        Me.txtQty.BorderRadius = 10
        Me.txtQty.BorderThickness = 2
        Me.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQty.DefaultText = ""
        Me.txtQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQty.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.ForeColor = System.Drawing.Color.DimGray
        Me.txtQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQty.Location = New System.Drawing.Point(368, 277)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQty.PlaceholderText = ""
        Me.txtQty.SelectedText = ""
        Me.txtQty.Size = New System.Drawing.Size(431, 73)
        Me.txtQty.TabIndex = 3
        '
        'txtLot
        '
        Me.txtLot.BackColor = System.Drawing.Color.Transparent
        Me.txtLot.BorderColor = System.Drawing.Color.Black
        Me.txtLot.BorderRadius = 10
        Me.txtLot.BorderThickness = 2
        Me.txtLot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLot.DefaultText = ""
        Me.txtLot.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLot.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLot.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLot.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLot.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLot.ForeColor = System.Drawing.Color.DimGray
        Me.txtLot.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLot.Location = New System.Drawing.Point(368, 119)
        Me.txtLot.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLot.PlaceholderText = ""
        Me.txtLot.SelectedText = ""
        Me.txtLot.Size = New System.Drawing.Size(431, 73)
        Me.txtLot.TabIndex = 1
        '
        'txtTransac
        '
        Me.txtTransac.BackColor = System.Drawing.Color.Transparent
        Me.txtTransac.BorderColor = System.Drawing.Color.Black
        Me.txtTransac.BorderRadius = 10
        Me.txtTransac.BorderThickness = 2
        Me.txtTransac.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTransac.DefaultText = ""
        Me.txtTransac.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTransac.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTransac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTransac.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTransac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTransac.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransac.ForeColor = System.Drawing.Color.DimGray
        Me.txtTransac.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTransac.Location = New System.Drawing.Point(368, 198)
        Me.txtTransac.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtTransac.Name = "txtTransac"
        Me.txtTransac.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTransac.PlaceholderText = ""
        Me.txtTransac.ReadOnly = True
        Me.txtTransac.SelectedText = ""
        Me.txtTransac.Size = New System.Drawing.Size(431, 73)
        Me.txtTransac.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnSubmit)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtProduct)
        Me.Panel2.Controls.Add(Me.txtQty)
        Me.Panel2.Controls.Add(Me.txtLot)
        Me.Panel2.Controls.Add(Me.txtTransac)
        Me.Panel2.Location = New System.Drawing.Point(0, 109)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(897, 499)
        Me.Panel2.TabIndex = 124
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BorderColor = System.Drawing.Color.Red
        Me.btnClear.BorderRadius = 15
        Me.btnClear.BorderThickness = 3
        Me.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClear.FillColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnClear.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClear.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnClear.Location = New System.Drawing.Point(493, 394)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.BorderRadius = 15
        Me.btnClear.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear.ShadowDecoration.Enabled = True
        Me.btnClear.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(7)
        Me.btnClear.Size = New System.Drawing.Size(134, 56)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        '
        'txtProduct
        '
        Me.txtProduct.BackColor = System.Drawing.Color.Transparent
        Me.txtProduct.BorderColor = System.Drawing.Color.Black
        Me.txtProduct.BorderRadius = 10
        Me.txtProduct.BorderThickness = 2
        Me.txtProduct.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProduct.DefaultText = ""
        Me.txtProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduct.ForeColor = System.Drawing.Color.DimGray
        Me.txtProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProduct.Location = New System.Drawing.Point(368, 40)
        Me.txtProduct.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProduct.PlaceholderText = ""
        Me.txtProduct.SelectedText = ""
        Me.txtProduct.Size = New System.Drawing.Size(431, 73)
        Me.txtProduct.TabIndex = 0
        '
        'lblfooter2
        '
        Me.lblfooter2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblfooter2.AutoSize = True
        Me.lblfooter2.BackColor = System.Drawing.Color.Transparent
        Me.lblfooter2.Font = New System.Drawing.Font("Nirmala UI", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfooter2.ForeColor = System.Drawing.Color.White
        Me.lblfooter2.Location = New System.Drawing.Point(9, 677)
        Me.lblfooter2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfooter2.Name = "lblfooter2"
        Me.lblfooter2.Size = New System.Drawing.Size(108, 12)
        Me.lblfooter2.TabIndex = 123
        Me.lblfooter2.Text = "© LF Philipines - TSG 2025"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblProcessName)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(40, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(897, 608)
        Me.Panel1.TabIndex = 0
        '
        'Main
        '
        Me.Main.AutoScroll = True
        Me.Main.BackColor = System.Drawing.Color.Transparent
        Me.Main.Controls.Add(Me.lblfooter2)
        Me.Main.Controls.Add(Me.Panel1)
        Me.Main.Controls.Add(Me.MenuStrip1)
        Me.Main.Controls.Add(Me.lblfooter1)
        Me.Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Main.FillColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Main.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Main.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Main.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Main.Location = New System.Drawing.Point(0, 0)
        Me.Main.Name = "Main"
        Me.Main.Size = New System.Drawing.Size(980, 701)
        Me.Main.TabIndex = 1
        '
        'UpdateWIPToolStripMenuItem
        '
        Me.UpdateWIPToolStripMenuItem.Name = "UpdateWIPToolStripMenuItem"
        Me.UpdateWIPToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UpdateWIPToolStripMenuItem.Text = "Update Target"
        '
        'ViewWIPToolStripMenuItem
        '
        Me.ViewWIPToolStripMenuItem.Name = "ViewWIPToolStripMenuItem"
        Me.ViewWIPToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewWIPToolStripMenuItem.Text = "View WIP"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 701)
        Me.Controls.Add(Me.Main)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RS WIP Management"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Main.ResumeLayout(False)
        Me.Main.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblfooter1 As Label
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblProcessName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLot As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTransac As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtProduct As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblfooter2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Main As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents LoadAndWashToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnnealingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WashToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WIPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PunchPressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VibratorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateWIPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewWIPToolStripMenuItem As ToolStripMenuItem
End Class
