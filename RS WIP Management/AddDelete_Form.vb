Public Class AddDelete_Form
    Private Sub AddDelete_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Load_ProductName()
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex >= 0 AndAlso DataGridView1.Columns(e.ColumnIndex).Name = "DeleteButton" Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Delete_ID = row.Cells("ID").Value
            Console.WriteLine("ID for Delete: " & Delete_ID)

            Dim result As DialogResult
            result = MessageBox.Show("Do you want to delete this product name?", "Delete Product Name",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                'MsgBox("Delte")

                Delete_ProductName()

            End If

        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(txtProduct.Text) Then
            MsgBox("Please enter the product name!", MsgBoxStyle.Critical)
        Else
            Insert_ProductName()
        End If
    End Sub
End Class