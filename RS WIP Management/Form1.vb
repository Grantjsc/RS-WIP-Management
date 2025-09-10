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

        dtpStartDate.Value = Date.Now
        dtpEndDate.Value = Date.Now

        Get_Product_Suggestion()

        Load_SelectProcess()

        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
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
    Private Sub txtProduct_Enter(sender As Object, e As EventArgs) Handles txtProduct.Enter
        Get_Product_Suggestion()
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

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) <> 46 Then
                If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txtQty_KeyUp(sender As Object, e As KeyEventArgs) Handles txtQty.KeyUp
        If e.KeyCode = Keys.Enter Then

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

                Select Case Process_Indicator
                    Case 1 ' Vibrator 

                        Insert_to_databse("Vibrator_Qty")

                    Case 2 ' Anneal

                        Insert_to_databse("Anneal_Qty")

                    Case 3 ' Sput

                        Insert_to_databse("Sput_Qty")

                End Select

            End If

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

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        ViewAll_clicked()
    End Sub

    'Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
    '    PassSettings_Form.ShowDialog()
    'End Sub

    Private Sub UpdateWIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateWIPToolStripMenuItem.Click
        'UpdateWIP_clicked()
        'PassUpdateWIP_Form.ShowDialog()
    End Sub

    Private Sub ViewWIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewWIPToolStripMenuItem.Click
        'WIP_Form.ShowDialog()
        WIP_clicked()
        'PassWIP_Form.ShowDialog()
    End Sub

    Public VibTarget As Boolean = False

    Private Sub VibratorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VibratorToolStripMenuItem1.Click
        VibTarget = True
        PassUpdateWIP_Form.ShowDialog()
    End Sub

    Private Sub SputToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SputToolStripMenuItem1.Click
        VibTarget = False
        PassUpdateWIP_Form.ShowDialog()
    End Sub

    Private Sub SAMToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SAMToolStripMenuItem1.Click
        VibTarget = False
        PassUpdateWIP_Form.ShowDialog()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadingProcess_ID = 4

        Select Case Process_Indicator
            Case 1 ' Vibrator 

                Load_Data("Vibrator_Qty")

            Case 2 ' Anneal

                Load_Data("Anneal_Qty")

            Case 3 ' Sput

                Load_Data("Sput_Qty")

        End Select
    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'If String.IsNullOrEmpty(txtSearch.Text) And Search_Go = True Then
        Select Case Process_Indicator
                Case 1 ' Vibrator 

                    SearchLot("Vibrator_Qty")

                Case 2 ' Anneal

                    SearchLot("Anneal_Qty")

                Case 3 ' Sput

                    SearchLot("Sput_Qty")

            End Select
        'End If
    End Sub

    Public Search_Go As Boolean = False
    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        Search_Go = True
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        Search_Go = False
    End Sub

    Public Setting_ID As Integer

    Private Sub EnableDisableProcessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableDisableProcessToolStripMenuItem.Click
        Setting_ID = 1
        PassSettings_Form.ShowDialog()
    End Sub

    Private Sub ProduToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduToolStripMenuItem.Click
        Setting_ID = 2
        PassSettings_Form.ShowDialog()
    End Sub
End Class
