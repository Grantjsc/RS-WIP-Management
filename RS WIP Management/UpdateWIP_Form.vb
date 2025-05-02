Public Class UpdateWIP_Form
    Private Sub UpdateWIP_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        UpdateWIP_Load()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        UpdateWIP_Populate()
    End Sub

    Private Sub DataGridView1_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs) Handles DataGridView1.CellStateChanged
        UpdateWIP_Populate()
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'UpdateAll()

        If txtTarget.Text = "" Then
            MsgBox("Please enter the new target quantity!", MsgBoxStyle.Critical)
        Else
            'PassWIP_Form.ShowDialog()
            UpdateWIP_Update_Target()
            UpdateWIP_Load()
        End If
    End Sub
End Class