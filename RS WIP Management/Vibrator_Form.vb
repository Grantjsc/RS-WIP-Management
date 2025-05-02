Public Class Vibrator_Form
    Private Sub Vibrator_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_DEBUR()
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        'Insert_DEBUR()
        'Insert_DEBUR_Yesterday()

        Save_DEBUR_Changes()
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
            Load_DEBUR_byLot()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Load_DEBUR_TextSearch()
    End Sub

End Class