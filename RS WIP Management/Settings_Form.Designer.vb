<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings_Form))
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.GroupBoxTitle = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.CheckSAM = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.CheckSput = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.CheckWash = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.CheckAnn = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.CheckLW = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.CheckVib = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.CheckPP = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.GroupBoxTitle.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnClose.Location = New System.Drawing.Point(380, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedColor = System.Drawing.Color.Transparent
        Me.btnClose.PressedDepth = 0
        Me.btnClose.Size = New System.Drawing.Size(29, 29)
        Me.btnClose.TabIndex = 68
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2CustomGradientPanel1.BorderThickness = 5
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.GroupBoxTitle)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnClose)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(418, 511)
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
        Me.GroupBoxTitle.Controls.Add(Me.btnSave)
        Me.GroupBoxTitle.Controls.Add(Me.CheckSAM)
        Me.GroupBoxTitle.Controls.Add(Me.CheckSput)
        Me.GroupBoxTitle.Controls.Add(Me.CheckWash)
        Me.GroupBoxTitle.Controls.Add(Me.CheckAnn)
        Me.GroupBoxTitle.Controls.Add(Me.CheckLW)
        Me.GroupBoxTitle.Controls.Add(Me.CheckVib)
        Me.GroupBoxTitle.Controls.Add(Me.CheckPP)
        Me.GroupBoxTitle.CustomBorderColor = System.Drawing.Color.Transparent
        Me.GroupBoxTitle.FillColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBoxTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GroupBoxTitle.Location = New System.Drawing.Point(29, 30)
        Me.GroupBoxTitle.Name = "GroupBoxTitle"
        Me.GroupBoxTitle.Size = New System.Drawing.Size(359, 450)
        Me.GroupBoxTitle.TabIndex = 2
        Me.GroupBoxTitle.Text = "Process"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.BorderRadius = 15
        Me.btnSave.BorderThickness = 3
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.White
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSave.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnSave.Location = New System.Drawing.Point(129, 381)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.BorderRadius = 15
        Me.btnSave.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.ShadowDecoration.Enabled = True
        Me.btnSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(7)
        Me.btnSave.Size = New System.Drawing.Size(100, 44)
        Me.btnSave.TabIndex = 76
        Me.btnSave.Text = "Save"
        '
        'CheckSAM
        '
        Me.CheckSAM.AutoSize = True
        Me.CheckSAM.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckSAM.CheckedState.BorderRadius = 0
        Me.CheckSAM.CheckedState.BorderThickness = 0
        Me.CheckSAM.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckSAM.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckSAM.Location = New System.Drawing.Point(94, 327)
        Me.CheckSAM.Name = "CheckSAM"
        Me.CheckSAM.Size = New System.Drawing.Size(86, 36)
        Me.CheckSAM.TabIndex = 75
        Me.CheckSAM.Text = "SAM"
        Me.CheckSAM.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CheckSAM.UncheckedState.BorderRadius = 0
        Me.CheckSAM.UncheckedState.BorderThickness = 0
        Me.CheckSAM.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'CheckSput
        '
        Me.CheckSput.AutoSize = True
        Me.CheckSput.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckSput.CheckedState.BorderRadius = 0
        Me.CheckSput.CheckedState.BorderThickness = 0
        Me.CheckSput.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckSput.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckSput.Location = New System.Drawing.Point(94, 282)
        Me.CheckSput.Name = "CheckSput"
        Me.CheckSput.Size = New System.Drawing.Size(85, 36)
        Me.CheckSput.TabIndex = 74
        Me.CheckSput.Text = "Sput"
        Me.CheckSput.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CheckSput.UncheckedState.BorderRadius = 0
        Me.CheckSput.UncheckedState.BorderThickness = 0
        Me.CheckSput.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'CheckWash
        '
        Me.CheckWash.AutoSize = True
        Me.CheckWash.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckWash.CheckedState.BorderRadius = 0
        Me.CheckWash.CheckedState.BorderThickness = 0
        Me.CheckWash.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckWash.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckWash.Location = New System.Drawing.Point(94, 237)
        Me.CheckWash.Name = "CheckWash"
        Me.CheckWash.Size = New System.Drawing.Size(94, 36)
        Me.CheckWash.TabIndex = 73
        Me.CheckWash.Text = "Wash"
        Me.CheckWash.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CheckWash.UncheckedState.BorderRadius = 0
        Me.CheckWash.UncheckedState.BorderThickness = 0
        Me.CheckWash.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'CheckAnn
        '
        Me.CheckAnn.AutoSize = True
        Me.CheckAnn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckAnn.CheckedState.BorderRadius = 0
        Me.CheckAnn.CheckedState.BorderThickness = 0
        Me.CheckAnn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckAnn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckAnn.Location = New System.Drawing.Point(94, 192)
        Me.CheckAnn.Name = "CheckAnn"
        Me.CheckAnn.Size = New System.Drawing.Size(150, 36)
        Me.CheckAnn.TabIndex = 72
        Me.CheckAnn.Text = "Annealing"
        Me.CheckAnn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CheckAnn.UncheckedState.BorderRadius = 0
        Me.CheckAnn.UncheckedState.BorderThickness = 0
        Me.CheckAnn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'CheckLW
        '
        Me.CheckLW.AutoSize = True
        Me.CheckLW.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckLW.CheckedState.BorderRadius = 0
        Me.CheckLW.CheckedState.BorderThickness = 0
        Me.CheckLW.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckLW.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckLW.Location = New System.Drawing.Point(94, 147)
        Me.CheckLW.Name = "CheckLW"
        Me.CheckLW.Size = New System.Drawing.Size(206, 36)
        Me.CheckLW.TabIndex = 71
        Me.CheckLW.Text = "Load and Wash"
        Me.CheckLW.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CheckLW.UncheckedState.BorderRadius = 0
        Me.CheckLW.UncheckedState.BorderThickness = 0
        Me.CheckLW.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'CheckVib
        '
        Me.CheckVib.AutoSize = True
        Me.CheckVib.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckVib.CheckedState.BorderRadius = 0
        Me.CheckVib.CheckedState.BorderThickness = 0
        Me.CheckVib.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckVib.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckVib.Location = New System.Drawing.Point(94, 102)
        Me.CheckVib.Name = "CheckVib"
        Me.CheckVib.Size = New System.Drawing.Size(128, 36)
        Me.CheckVib.TabIndex = 70
        Me.CheckVib.Text = "Vibrator"
        Me.CheckVib.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CheckVib.UncheckedState.BorderRadius = 0
        Me.CheckVib.UncheckedState.BorderThickness = 0
        Me.CheckVib.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'CheckPP
        '
        Me.CheckPP.AutoSize = True
        Me.CheckPP.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckPP.CheckedState.BorderRadius = 0
        Me.CheckPP.CheckedState.BorderThickness = 0
        Me.CheckPP.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckPP.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckPP.Location = New System.Drawing.Point(94, 57)
        Me.CheckPP.Name = "CheckPP"
        Me.CheckPP.Size = New System.Drawing.Size(171, 36)
        Me.CheckPP.TabIndex = 69
        Me.CheckPP.Text = "Punch Press"
        Me.CheckPP.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CheckPP.UncheckedState.BorderRadius = 0
        Me.CheckPP.UncheckedState.BorderThickness = 0
        Me.CheckPP.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Settings_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 511)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings_Form"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.GroupBoxTitle.ResumeLayout(False)
        Me.GroupBoxTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents GroupBoxTitle As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents CheckPP As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents CheckLW As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents CheckVib As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents CheckSAM As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents CheckSput As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents CheckWash As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents CheckAnn As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
End Class
