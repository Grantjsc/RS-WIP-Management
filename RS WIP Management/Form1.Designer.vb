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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.ViewWIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateWIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VibratorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SputToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAMToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableDisableProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.btnLoad = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.txtProduct = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblfooter2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Main = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.dtpEndDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox3.SuspendLayout()
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
        Me.PunchPressToolStripMenuItem.Visible = False
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
        Me.LoadAndWashToolStripMenuItem.Visible = False
        '
        'AnnealingToolStripMenuItem
        '
        Me.AnnealingToolStripMenuItem.Name = "AnnealingToolStripMenuItem"
        Me.AnnealingToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AnnealingToolStripMenuItem.Text = "Anneal"
        '
        'WashToolStripMenuItem
        '
        Me.WashToolStripMenuItem.Name = "WashToolStripMenuItem"
        Me.WashToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.WashToolStripMenuItem.Text = "Wash"
        Me.WashToolStripMenuItem.Visible = False
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
        Me.SAMToolStripMenuItem.Visible = False
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
        'ViewWIPToolStripMenuItem
        '
        Me.ViewWIPToolStripMenuItem.Name = "ViewWIPToolStripMenuItem"
        Me.ViewWIPToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ViewWIPToolStripMenuItem.Text = "View WIP"
        '
        'UpdateWIPToolStripMenuItem
        '
        Me.UpdateWIPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VibratorToolStripMenuItem1, Me.SputToolStripMenuItem1, Me.SAMToolStripMenuItem1})
        Me.UpdateWIPToolStripMenuItem.Name = "UpdateWIPToolStripMenuItem"
        Me.UpdateWIPToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.UpdateWIPToolStripMenuItem.Text = "Update Target"
        '
        'VibratorToolStripMenuItem1
        '
        Me.VibratorToolStripMenuItem1.Name = "VibratorToolStripMenuItem1"
        Me.VibratorToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.VibratorToolStripMenuItem1.Text = "Vibrator"
        Me.VibratorToolStripMenuItem1.Visible = False
        '
        'SputToolStripMenuItem1
        '
        Me.SputToolStripMenuItem1.Name = "SputToolStripMenuItem1"
        Me.SputToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.SputToolStripMenuItem1.Text = "Sput"
        Me.SputToolStripMenuItem1.Visible = False
        '
        'SAMToolStripMenuItem1
        '
        Me.SAMToolStripMenuItem1.Name = "SAMToolStripMenuItem1"
        Me.SAMToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.SAMToolStripMenuItem1.Text = "SAM"
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
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableDisableProcessToolStripMenuItem, Me.ProduToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(69, 21)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'EnableDisableProcessToolStripMenuItem
        '
        Me.EnableDisableProcessToolStripMenuItem.Name = "EnableDisableProcessToolStripMenuItem"
        Me.EnableDisableProcessToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.EnableDisableProcessToolStripMenuItem.Text = "Enable/Disable Process"
        '
        'ProduToolStripMenuItem
        '
        Me.ProduToolStripMenuItem.Name = "ProduToolStripMenuItem"
        Me.ProduToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.ProduToolStripMenuItem.Text = "Add/Delete Product Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 124
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Impact", 18.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(38, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 29)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(823, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 45)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Transaction"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Impact", 18.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(38, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 29)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Lot number"
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.btnSubmit.Location = New System.Drawing.Point(-42, 466)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.ShadowDecoration.BorderRadius = 15
        Me.btnSubmit.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubmit.ShadowDecoration.Enabled = True
        Me.btnSubmit.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(7)
        Me.btnSubmit.Size = New System.Drawing.Size(104, 41)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.Visible = False
        '
        'lblProcessName
        '
        Me.lblProcessName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblProcessName.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessName.Font = New System.Drawing.Font("Impact", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessName.ForeColor = System.Drawing.Color.White
        Me.lblProcessName.Location = New System.Drawing.Point(245, 28)
        Me.lblProcessName.Name = "lblProcessName"
        Me.lblProcessName.Size = New System.Drawing.Size(406, 56)
        Me.lblProcessName.TabIndex = 127
        Me.lblProcessName.Text = "Process"
        Me.lblProcessName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(38, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 29)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Product name"
        '
        'txtQty
        '
        Me.txtQty.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.txtQty.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtQty.ForeColor = System.Drawing.Color.DimGray
        Me.txtQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQty.Location = New System.Drawing.Point(38, 295)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQty.PlaceholderText = ""
        Me.txtQty.SelectedText = ""
        Me.txtQty.Size = New System.Drawing.Size(296, 52)
        Me.txtQty.TabIndex = 3
        '
        'txtLot
        '
        Me.txtLot.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.txtLot.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtLot.ForeColor = System.Drawing.Color.DimGray
        Me.txtLot.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLot.Location = New System.Drawing.Point(38, 188)
        Me.txtLot.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLot.PlaceholderText = ""
        Me.txtLot.SelectedText = ""
        Me.txtLot.Size = New System.Drawing.Size(296, 52)
        Me.txtLot.TabIndex = 1
        '
        'txtTransac
        '
        Me.txtTransac.Anchor = System.Windows.Forms.AnchorStyles.Top
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
        Me.txtTransac.Location = New System.Drawing.Point(831, 65)
        Me.txtTransac.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtTransac.Name = "txtTransac"
        Me.txtTransac.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTransac.PlaceholderText = ""
        Me.txtTransac.ReadOnly = True
        Me.txtTransac.SelectedText = ""
        Me.txtTransac.Size = New System.Drawing.Size(431, 73)
        Me.txtTransac.TabIndex = 2
        Me.txtTransac.Visible = False
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MainPanel.Controls.Add(Me.btnLoad)
        Me.MainPanel.Controls.Add(Me.txtSearch)
        Me.MainPanel.Controls.Add(Me.DataGridView1)
        Me.MainPanel.Controls.Add(Me.Guna2GroupBox3)
        Me.MainPanel.Controls.Add(Me.btnSubmit)
        Me.MainPanel.Location = New System.Drawing.Point(0, 109)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(897, 499)
        Me.MainPanel.TabIndex = 124
        '
        'btnLoad
        '
        Me.btnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoad.BackColor = System.Drawing.Color.Transparent
        Me.btnLoad.BorderRadius = 5
        Me.btnLoad.BorderThickness = 2
        Me.btnLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLoad.FillColor = System.Drawing.SystemColors.Control
        Me.btnLoad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.Black
        Me.btnLoad.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLoad.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnLoad.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
        Me.btnLoad.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLoad.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnLoad.Location = New System.Drawing.Point(749, 39)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(120, 33)
        Me.btnLoad.TabIndex = 227
        Me.btnLoad.Text = "Load All"
        Me.btnLoad.TextOffset = New System.Drawing.Point(15, 0)
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.Transparent
        Me.txtSearch.BorderColor = System.Drawing.Color.Black
        Me.txtSearch.BorderRadius = 15
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.LightGray
        Me.txtSearch.IconLeft = CType(resources.GetObject("txtSearch.IconLeft"), System.Drawing.Image)
        Me.txtSearch.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtSearch.Location = New System.Drawing.Point(418, 38)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search lot number"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(323, 28)
        Me.txtSearch.TabIndex = 226
        Me.txtSearch.TextOffset = New System.Drawing.Point(10, 0)
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
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(418, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(451, 382)
        Me.DataGridView1.TabIndex = 225
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox3.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox3.BorderRadius = 5
        Me.Guna2GroupBox3.BorderThickness = 5
        Me.Guna2GroupBox3.Controls.Add(Me.Label2)
        Me.Guna2GroupBox3.Controls.Add(Me.btnClear)
        Me.Guna2GroupBox3.Controls.Add(Me.txtLot)
        Me.Guna2GroupBox3.Controls.Add(Me.Label5)
        Me.Guna2GroupBox3.Controls.Add(Me.txtQty)
        Me.Guna2GroupBox3.Controls.Add(Me.Label3)
        Me.Guna2GroupBox3.Controls.Add(Me.txtProduct)
        Me.Guna2GroupBox3.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(28, 39)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(368, 421)
        Me.Guna2GroupBox3.TabIndex = 224
        Me.Guna2GroupBox3.Text = "Details"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.btnClear.Location = New System.Drawing.Point(130, 358)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.BorderRadius = 15
        Me.btnClear.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear.ShadowDecoration.Enabled = True
        Me.btnClear.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(7)
        Me.btnClear.Size = New System.Drawing.Size(104, 41)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        '
        'txtProduct
        '
        Me.txtProduct.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.txtProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduct.ForeColor = System.Drawing.Color.DimGray
        Me.txtProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProduct.Location = New System.Drawing.Point(38, 89)
        Me.txtProduct.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProduct.PlaceholderText = ""
        Me.txtProduct.SelectedText = ""
        Me.txtProduct.Size = New System.Drawing.Size(296, 52)
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
        Me.lblfooter2.Size = New System.Drawing.Size(163, 12)
        Me.lblfooter2.TabIndex = 123
        Me.lblfooter2.Text = "© LF Philipines - TSG 2025 (G.Catapang)"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.MainPanel)
        Me.Panel1.Controls.Add(Me.lblProcessName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.txtTransac)
        Me.Panel1.Location = New System.Drawing.Point(40, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(897, 608)
        Me.Panel1.TabIndex = 0
        '
        'Main
        '
        Me.Main.AutoScroll = True
        Me.Main.BackColor = System.Drawing.Color.Transparent
        Me.Main.Controls.Add(Me.dtpEndDate)
        Me.Main.Controls.Add(Me.lblfooter2)
        Me.Main.Controls.Add(Me.Label8)
        Me.Main.Controls.Add(Me.Panel1)
        Me.Main.Controls.Add(Me.dtpStartDate)
        Me.Main.Controls.Add(Me.Label7)
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
        'dtpEndDate
        '
        Me.dtpEndDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpEndDate.BackColor = System.Drawing.Color.Transparent
        Me.dtpEndDate.BorderRadius = 10
        Me.dtpEndDate.Checked = True
        Me.dtpEndDate.FillColor = System.Drawing.Color.Black
        Me.dtpEndDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dtpEndDate.ForeColor = System.Drawing.Color.White
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(657, 3)
        Me.dtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(166, 36)
        Me.dtpEndDate.TabIndex = 210
        Me.dtpEndDate.Value = New Date(2024, 10, 30, 0, 0, 0, 0)
        Me.dtpEndDate.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(576, 12)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 211
        Me.Label8.Text = "End Date:"
        Me.Label8.Visible = False
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpStartDate.BackColor = System.Drawing.Color.Transparent
        Me.dtpStartDate.BorderRadius = 10
        Me.dtpStartDate.Checked = True
        Me.dtpStartDate.FillColor = System.Drawing.Color.Black
        Me.dtpStartDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dtpStartDate.ForeColor = System.Drawing.Color.White
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(378, 3)
        Me.dtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(166, 36)
        Me.dtpStartDate.TabIndex = 208
        Me.dtpStartDate.Value = New Date(2024, 10, 30, 0, 0, 0, 0)
        Me.dtpStartDate.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(288, 12)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 20)
        Me.Label7.TabIndex = 209
        Me.Label7.Text = "Start Date:"
        Me.Label7.Visible = False
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
        Me.MainPanel.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents MainPanel As Panel
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
    Friend WithEvents VibratorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SputToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpEndDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents btnLoad As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SAMToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EnableDisableProcessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduToolStripMenuItem As ToolStripMenuItem
End Class
