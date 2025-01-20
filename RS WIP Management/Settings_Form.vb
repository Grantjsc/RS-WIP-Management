Public Class Settings_Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CheckPP.Checked = True Then
            New_PP_State = "True"
            Update_PP_Status()
        Else
            New_PP_State = "False"
            Update_PP_Status()
        End If

        If CheckVib.Checked = True Then
            New_VIB_State = "True"
            Update_VIB_Status()
        Else
            New_Vib_State = "False"
            Update_VIB_Status()
        End If

        If CheckLW.Checked = True Then
            New_LW_State = "True"
            Update_LW_Status()
        Else
            New_LW_State = "False"
            Update_LW_Status()
        End If

        If CheckAnn.Checked = True Then
            New_ANN_State = "True"
            Update_ANN_Status()
        Else
            New_ANN_State = "False"
            Update_ANN_Status()
        End If

        If CheckWash.Checked = True Then
            New_WASH_State = "True"
            Update_WASH_Status()
        Else
            New_WASH_State = "False"
            Update_WASH_Status()
        End If

        If CheckSput.Checked = True Then
            New_SPUT_State = "True"
            Update_SPUT_Status()
        Else
            New_SPUT_State = "False"
            Update_SPUT_Status()
        End If

        If CheckSAM.Checked = True Then
            New_SAM_State = "True"
            Update_SAM_Status()
        Else
            New_SAM_State = "False"
            Update_SAM_Status()
        End If

        Me.Close()
        Load_SelectProcess
    End Sub
End Class