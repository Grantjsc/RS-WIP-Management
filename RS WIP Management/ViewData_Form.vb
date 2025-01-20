Imports System.IO

Public Class ViewData_Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ViewData_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Load_ViewAll()

        dtpStartDate.Value = Date.Now
        dtpEndDate.Value = Date.Now
    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Load_ViewAll()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Load_ViewAll_BaseStartEnd()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExportToCSV()
    End Sub
    Private Sub ExportToCSV()
        Dim sfd As New SaveFileDialog()
        'sfd.FileName = "ExportData"
        sfd.Filter = "CSV File | *.csv"

        If sfd.ShowDialog() = DialogResult.OK Then
            Using sw As StreamWriter = File.CreateText(sfd.FileName)
                Dim ColumnNames As List(Of String) = DataGridView1.Columns.
                    Cast(Of DataGridViewColumn).ToList().
                    Select(Function(c) c.Name).ToList()

                sw.WriteLine(String.Join(",", ColumnNames))

                For Each row As DataGridViewRow In DataGridView1.Rows
                    Dim rowData As New List(Of String)

                    For Each column As DataGridViewColumn In DataGridView1.Columns
                        rowData.Add(Convert.ToString(row.Cells(column.Name).Value))
                    Next

                    sw.WriteLine(String.Join(",", rowData))
                Next

                'Process.Start(sfd.FileName)
                MsgBox("Export successful!")

            End Using
        End If

    End Sub
End Class