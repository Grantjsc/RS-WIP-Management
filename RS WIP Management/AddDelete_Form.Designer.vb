<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDelete_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddDelete_Form))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Main = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.lblfooter2 = New System.Windows.Forms.Label()
        Me.lblfooter1 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtProduct = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Main.SuspendLayout()
        Me.Guna2GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Main
        '
        Me.Main.AutoScroll = True
        Me.Main.BackColor = System.Drawing.Color.Transparent
        Me.Main.Controls.Add(Me.lblfooter2)
        Me.Main.Controls.Add(Me.lblfooter1)
        Me.Main.Controls.Add(Me.Guna2GroupBox3)
        Me.Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Main.FillColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Main.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Main.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Main.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Main.Location = New System.Drawing.Point(0, 0)
        Me.Main.Name = "Main"
        Me.Main.Size = New System.Drawing.Size(980, 701)
        Me.Main.TabIndex = 2
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
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox3.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox3.BorderRadius = 5
        Me.Guna2GroupBox3.BorderThickness = 5
        Me.Guna2GroupBox3.Controls.Add(Me.btnClose)
        Me.Guna2GroupBox3.Controls.Add(Me.btnAdd)
        Me.Guna2GroupBox3.Controls.Add(Me.Label2)
        Me.Guna2GroupBox3.Controls.Add(Me.DataGridView1)
        Me.Guna2GroupBox3.Controls.Add(Me.txtProduct)
        Me.Guna2GroupBox3.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(38, 57)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(901, 569)
        Me.Guna2GroupBox3.TabIndex = 224
        Me.Guna2GroupBox3.Text = "Add or delete product name"
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
        Me.btnClose.Location = New System.Drawing.Point(851, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedColor = System.Drawing.Color.Transparent
        Me.btnClose.PressedDepth = 0
        Me.btnClose.Size = New System.Drawing.Size(29, 29)
        Me.btnClose.TabIndex = 227
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.BorderRadius = 15
        Me.btnAdd.BorderThickness = 3
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.White
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdd.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnAdd.Location = New System.Drawing.Point(397, 86)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.BorderRadius = 15
        Me.btnAdd.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.ShadowDecoration.Enabled = True
        Me.btnAdd.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(7)
        Me.btnAdd.Size = New System.Drawing.Size(104, 41)
        Me.btnAdd.TabIndex = 226
        Me.btnAdd.Text = "Add"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(29, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 29)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Product name"
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 161)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(825, 373)
        Me.DataGridView1.TabIndex = 225
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
        Me.txtProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtProduct.ForeColor = System.Drawing.Color.DimGray
        Me.txtProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProduct.Location = New System.Drawing.Point(29, 80)
        Me.txtProduct.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtProduct.Multiline = True
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProduct.PlaceholderText = "Type here the new product name"
        Me.txtProduct.SelectedText = ""
        Me.txtProduct.Size = New System.Drawing.Size(346, 52)
        Me.txtProduct.TabIndex = 0
        '
        'AddDelete_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 701)
        Me.Controls.Add(Me.Main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddDelete_Form"
        Me.Text = "AddDelete_Form"
        Me.Main.ResumeLayout(False)
        Me.Main.PerformLayout()
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Main As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lblfooter2 As Label
    Friend WithEvents lblfooter1 As Label
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtProduct As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
End Class
