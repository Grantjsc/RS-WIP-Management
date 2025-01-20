Public Class WIP_Form
    Private Sub WIP_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Get_WIP_Start()
        Get_WIP_End()

        Load_Avail_WIP()

        dtpStartDate.Value = Date.Now
        dtpEndDate.Value = Date.Now
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

    Private Sub txtTarget_TextChanged(sender As Object, e As EventArgs) Handles txtTarget.TextChanged
        If Not String.IsNullOrEmpty(txtTarget.Text) Then
            txtGAP.Text = SAM_tOUT - CInt(txtTarget.Text)
        Else
            txtGAP.Clear()
        End If
    End Sub

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
            txtGAP.Clear()
            txtTarget.Clear()
        End If
    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        No_SUM = False
        Load_Avail_WIP()
        txtGAP.Clear()
        txtTarget.Clear()
    End Sub

    Private Sub CopyDataGridViewToClipboard(ByRef dgv As DataGridView)
        Dim s As String = ""
        Dim oCurrentCol As DataGridViewColumn    'Get header
        oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible)
        Do
            s &= oCurrentCol.HeaderText & Chr(Keys.Tab)
            oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol,
               DataGridViewElementStates.Visible, DataGridViewElementStates.None)
        Loop Until oCurrentCol Is Nothing
        s = s.Substring(0, s.Length - 1)
        s &= Environment.NewLine    'Get rows
        For Each row As DataGridViewRow In dgv.Rows
            oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible)
            Do
                If row.Cells(oCurrentCol.Index).Value IsNot Nothing Then
                    s &= row.Cells(oCurrentCol.Index).Value.ToString
                End If
                s &= Chr(Keys.Tab)
                oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol,
                      DataGridViewElementStates.Visible, DataGridViewElementStates.None)
            Loop Until oCurrentCol Is Nothing
            s = s.Substring(0, s.Length - 1)
            s &= Environment.NewLine
        Next    'Put to clipboard
        Dim o As New DataObject
        o.SetText(s)
        Clipboard.SetDataObject(o, True)
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        CopyDataGridViewToClipboard(DataGridView1)
    End Sub
End Class