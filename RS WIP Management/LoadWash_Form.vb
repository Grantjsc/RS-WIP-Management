Public Class LoadWash_Form
    Private Sub LoadWash_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_RAMCO()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Insert_RAMCO()
        'Insert_RAMCO_Yesterday()

        Save_RAMCO_Changes()
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "Search lot number" Then

            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If txtSearch.Text = "" Then

            txtSearch.Text = "Search lot number"
            txtSearch.ForeColor = Color.FromArgb(125, 137, 149)
        End If
    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyCode = Keys.Enter Then
            Load_RAMCO_byLot()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Load_RAMCO_TextSearch()
    End Sub
End Class