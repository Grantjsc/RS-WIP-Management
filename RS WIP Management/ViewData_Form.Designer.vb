<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewData_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewData_Form))
        Me.btnViewAll = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLoad = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.GroupBoxTitle = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.GroupBoxTitle.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnViewAll.Location = New System.Drawing.Point(724, 467)
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
        Me.DataGridView1.Size = New System.Drawing.Size(785, 374)
        Me.DataGridView1.TabIndex = 0
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
        Me.Guna2CustomGradientPanel1.TabIndex = 2
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
        Me.GroupBoxTitle.Controls.Add(Me.btnExport)
        Me.GroupBoxTitle.Controls.Add(Me.btnViewAll)
        Me.GroupBoxTitle.Controls.Add(Me.btnLoad)
        Me.GroupBoxTitle.Controls.Add(Me.Label4)
        Me.GroupBoxTitle.Controls.Add(Me.Label5)
        Me.GroupBoxTitle.Controls.Add(Me.dtpEndDate)
        Me.GroupBoxTitle.Controls.Add(Me.dtpStartDate)
        Me.GroupBoxTitle.Controls.Add(Me.btnClose)
        Me.GroupBoxTitle.Controls.Add(Me.DataGridView1)
        Me.GroupBoxTitle.CustomBorderColor = System.Drawing.Color.Transparent
        Me.GroupBoxTitle.FillColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBoxTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GroupBoxTitle.Location = New System.Drawing.Point(29, 30)
        Me.GroupBoxTitle.Name = "GroupBoxTitle"
        Me.GroupBoxTitle.Size = New System.Drawing.Size(841, 589)
        Me.GroupBoxTitle.TabIndex = 2
        Me.GroupBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnExport
        '
        Me.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExport.BackColor = System.Drawing.Color.Transparent
        Me.btnExport.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnExport.BorderRadius = 15
        Me.btnExport.BorderThickness = 3
        Me.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExport.FillColor = System.Drawing.Color.White
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.Black
        Me.btnExport.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnExport.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnExport.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnExport.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnExport.Location = New System.Drawing.Point(353, 507)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.ShadowDecoration.BorderRadius = 15
        Me.btnExport.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnExport.ShadowDecoration.Enabled = True
        Me.btnExport.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(7)
        Me.btnExport.Size = New System.Drawing.Size(133, 52)
        Me.btnExport.TabIndex = 147
        Me.btnExport.Text = "Export"
        Me.btnExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'ViewData_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 650)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ViewData_Form"
        Me.Text = "ViewData_Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.GroupBoxTitle.ResumeLayout(False)
        Me.GroupBoxTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnViewAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLoad As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpEndDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents GroupBoxTitle As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
End Class
