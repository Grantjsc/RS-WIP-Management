Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(110, 0, 0, 0)

        Dim secondaryMonitor = Screen.AllScreens.FirstOrDefault(Function(x) Not x.Primary)

        If secondaryMonitor IsNot Nothing Then
            Me.StartPosition = FormStartPosition.Manual
            Me.Location = secondaryMonitor.Bounds.Location
            'Me.WindowState = FormWindowState.Maximized
            Bounds = Screen.PrimaryScreen.WorkingArea
            Me.Show()
        Else
            'WindowState = FormWindowState.Maximized
            Bounds = Screen.PrimaryScreen.WorkingArea
        End If

        'PunchPress_clicked()
        Load_SelectProcess()
    End Sub

    Private Sub PunchPressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PunchPressToolStripMenuItem.Click
        PunchPress_clicked()
    End Sub

    Private Sub VibratorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VibratorToolStripMenuItem.Click
        Vibrator_clicked()
    End Sub

    Private Sub LoadAndWashToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadAndWashToolStripMenuItem.Click
        LoadWash_clicked()
    End Sub

    Private Sub AnnealingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnnealingToolStripMenuItem.Click
        Annealing_clicked()
    End Sub

    Private Sub WashToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WashToolStripMenuItem.Click
        Wash_clicked()
    End Sub

    Private Sub SputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SputToolStripMenuItem.Click
        Sput_clicked()
    End Sub

    Private Sub SAMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAMToolStripMenuItem.Click
        SAM_clicked()
    End Sub

    Private Sub txtProduct_KeyUp(sender As Object, e As KeyEventArgs) Handles txtProduct.KeyUp
        If e.KeyCode = Keys.Enter Then
            Get_Products()
        End If
    End Sub

    Private Sub txtLot_KeyUp(sender As Object, e As KeyEventArgs) Handles txtLot.KeyUp
        If e.KeyCode = Keys.Enter Then
            Search_LotNumber()
        End If
    End Sub

    Private Sub txtQty_KeyUp(sender As Object, e As KeyEventArgs) Handles txtQty.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtQty.ReadOnly = True
            btnSubmit.Focus()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrEmpty(txtProduct.Text) Then
            MsgBox("Please enter the product name!", MsgBoxStyle.Critical)
            txtProduct.Focus()

        ElseIf String.IsNullOrEmpty(txtLot.Text) Then
            MsgBox("Please enter the lot number!", MsgBoxStyle.Critical)
            txtLot.Focus()

        ElseIf String.IsNullOrEmpty(txtQty.Text) Then
            MsgBox("Please enter the quantity!", MsgBoxStyle.Critical)
            txtQty.Focus()
        Else
            Select_Process_ForSaving()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearData()
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) <> 46 Then
                If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        ViewAll_clicked()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        PassSettings_Form.ShowDialog()
    End Sub

    Private Sub UpdateWIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateWIPToolStripMenuItem.Click
        'UpdateWIP_clicked()
        PassUpdateWIP_Form.ShowDialog()
    End Sub

    Private Sub ViewWIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewWIPToolStripMenuItem.Click
        'WIP_Form.ShowDialog()
        WIP_clicked()
        'PassWIP_Form.ShowDialog()
    End Sub
End Class
