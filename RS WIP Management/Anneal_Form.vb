Public Class Anneal_Form
    Private Sub Anneal_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_ANNEAL()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Insert_ANNEAL()
        'Insert_ANNEAL_Yesterday()

        Save_ANNEAL_Changes()
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
            Load_ANNEAL_byLot()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Load_ANNEAL_TextSearch()
    End Sub
End Class