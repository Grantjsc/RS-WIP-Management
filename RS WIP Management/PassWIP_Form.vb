Public Class PassWIP_Form
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        If txtPass.Text = "rswipmaster" Then
            'WIP_clicked()

            If WIP_Form.txtTarget.Text = "" Then
                MsgBox("Please enter quantity!", MsgBoxStyle.Critical)
                WIP_Form.txtTarget.Focus()
            Else
                'Update_Target()
                'If No_SUM = True Then
                '    Load_WIP_BaseStartEnd()
                'Else
                Load_Avail_WIP()
                'End If
            End If
            WIP_Form.txtTarget.Clear()

            Me.Close()
        Else
            MsgBox("Wrong password!", MsgBoxStyle.Critical)
            txtPass.Text = ""
        End If
    End Sub

    Private Sub txtPass_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPass.KeyUp
        If e.KeyCode = Keys.Enter Then
            If txtPass.Text = "rswipmaster" Then
                'WIP_clicked()
                If WIP_Form.txtTarget.Text = "" Then
                    MsgBox("Please enter quantity!", MsgBoxStyle.Critical)
                    WIP_Form.txtTarget.Focus()
                Else
                    'Update_Target()
                    'If No_SUM = True Then
                    '    Load_WIP_BaseStartEnd()
                    'Else
                    Load_Avail_WIP()
                    'End If
                End If
                WIP_Form.txtTarget.Clear()

                Me.Close()
            Else
                MsgBox("Wrong password!", MsgBoxStyle.Critical)
                txtPass.Text = ""
            End If
        End If
    End Sub

    Private Sub PassWIP_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Load_SelectProcess()
    End Sub
End Class