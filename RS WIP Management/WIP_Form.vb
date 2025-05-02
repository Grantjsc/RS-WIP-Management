Imports System.Web.UI.WebControls

Public Class WIP_Form
    Private Sub WIP_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler DataGridView1.DataBindingComplete, AddressOf ApplyCellStyles
        'Get_WIP_Start()
        'Get_WIP_End()

        SAM_sub_Gap()
        Load_Avail_WIP()
        'Load_Target_WIP()

        'dtpStartDate.Value = Date.Now
        'dtpEndDate.Value = Date.Now

        'Load_WIP_BaseStartEnd()
        'No_SUM = True

        '=========< 
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If No_SUM = True Then
            'If e.RowIndex >= 0 Then
            Populate_WIP_noSUM()
            ' End If
        Else
            Populate_WIP()
        End If
    End Sub

    Private Sub DataGridView1_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs) Handles DataGridView1.CellStateChanged
        If No_SUM = True Then
            'If e.RowIndex >= 0 Then
            Populate_WIP_noSUM()
            ' End If
        Else
            Populate_WIP()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    'Private Sub txtTarget_TextChanged(sender As Object, e As EventArgs) Handles txtTarget.TextChanged
    '    If Not String.IsNullOrEmpty(txtTarget.Text) Then
    '        txtGAP.Text = SAM_tOUT - CInt(txtTarget.Text)
    '    Else
    '        txtGAP.Clear()
    '    End If
    'End Sub

    Private Sub txtTarget_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTarget.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) <> 46 Then
                If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        If dtpEndDate.Value < dtpStartDate.Value Then
            MsgBox("End date must not be earlier than start date!", MessageBoxIcon.Error)
        Else
            No_SUM = True
            Load_WIP_BaseStartEnd()
            txtTarget.Clear()
        End If
    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        No_SUM = False
        Load_Avail_WIP()
        txtTarget.Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'PassWIP_Form.ShowDialog()
        Update_Target()
        Load_Avail_WIP()

        'If txtTarget.Text = "" Then
        '    MsgBox("Please enter quantity!", MsgBoxStyle.Critical)
        '    txtTarget.Focus()
        'Else
        '    Update_Target()
        '    If No_SUM = True Then
        '        Load_WIP_BaseStartEnd()
        '    Else
        '        Load_Avail_WIP()
        '    End If
        'End If
    End Sub

    Private Sub ApplyCellStyles(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        ' Apply conditional formatting at the cell level
        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                Dim cellValue As Decimal
                ' Check if the cell value is numeric and negative
                If Decimal.TryParse(cell.Value?.ToString(), cellValue) AndAlso cellValue < 0 Then
                    cell.Style.BackColor = Color.Red
                    cell.Style.ForeColor = Color.White
                Else
                    ' Reset to default style for non-negative or non-numeric values
                    cell.Style.BackColor = Color.Empty
                    cell.Style.ForeColor = Color.Empty
                End If
            Next
        Next
    End Sub

    Private Sub btnTrial_Click(sender As Object, e As EventArgs) Handles btnTrial.Click
        'UpdateOrInsertGroupedQtyToProcess()

        'ProcessWIPMData()

        'Subtract_VibOut()
        'Subtract_LWOut()
        'Subtract_AnnealingOut()
        'Subtract_SputOut()

        'Load_Avail_WIP()
    End Sub
End Class