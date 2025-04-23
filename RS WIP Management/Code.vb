Imports System.Configuration

Module Function_Module


    Public PunchPress_Process As Boolean
    Public Vibrator_Process As Boolean
    Public LoadWash_Process As Boolean
    Public Annealing_Process As Boolean
    Public Wash_Process As Boolean
    Public Sput_Process As Boolean
    Public SAM_Process As Boolean

    Public IN_Product As Boolean

    Sub PunchPress_clicked()

        Form1.PunchPressToolStripMenuItem.ForeColor = Color.White
        Form1.PunchPressToolStripMenuItem.BackColor = Color.Orange

        Form1.VibratorToolStripMenuItem.ForeColor = Color.Black
        Form1.VibratorToolStripMenuItem.BackColor = Color.Transparent

        Form1.LoadAndWashToolStripMenuItem.ForeColor = Color.Black
        Form1.LoadAndWashToolStripMenuItem.BackColor = Color.Transparent

        Form1.AnnealingToolStripMenuItem.ForeColor = Color.Black
        Form1.AnnealingToolStripMenuItem.BackColor = Color.Transparent

        Form1.WashToolStripMenuItem.ForeColor = Color.Black
        Form1.WashToolStripMenuItem.BackColor = Color.Transparent

        Form1.SputToolStripMenuItem.ForeColor = Color.Black
        Form1.SputToolStripMenuItem.BackColor = Color.Transparent

        Form1.SAMToolStripMenuItem.ForeColor = Color.Black
        Form1.SAMToolStripMenuItem.BackColor = Color.Transparent

        Form1.lblProcessName.Text = "Punch Press"

        PunchPress_Process = True
        Vibrator_Process = False
        LoadWash_Process = False
        Annealing_Process = False
        Wash_Process = False
        Sput_Process = False
        SAM_Process = False

    End Sub

    Sub Vibrator_clicked()
        Form1.PunchPressToolStripMenuItem.ForeColor = Color.Black
        Form1.PunchPressToolStripMenuItem.BackColor = Color.Transparent

        Form1.VibratorToolStripMenuItem.ForeColor = Color.White
        Form1.VibratorToolStripMenuItem.BackColor = Color.Orange

        Form1.LoadAndWashToolStripMenuItem.ForeColor = Color.Black
        Form1.LoadAndWashToolStripMenuItem.BackColor = Color.Transparent

        Form1.AnnealingToolStripMenuItem.ForeColor = Color.Black
        Form1.AnnealingToolStripMenuItem.BackColor = Color.Transparent

        Form1.WashToolStripMenuItem.ForeColor = Color.Black
        Form1.WashToolStripMenuItem.BackColor = Color.Transparent

        Form1.SputToolStripMenuItem.ForeColor = Color.Black
        Form1.SputToolStripMenuItem.BackColor = Color.Transparent

        Form1.SAMToolStripMenuItem.ForeColor = Color.Black
        Form1.SAMToolStripMenuItem.BackColor = Color.Transparent

        Form1.lblProcessName.Text = "Vibrator"

        PunchPress_Process = False
        Vibrator_Process = True
        LoadWash_Process = False
        Annealing_Process = False
        Wash_Process = False
        Sput_Process = False
        SAM_Process = False

    End Sub

    Sub LoadWash_clicked()
        Form1.PunchPressToolStripMenuItem.ForeColor = Color.Black
        Form1.PunchPressToolStripMenuItem.BackColor = Color.Transparent

        Form1.VibratorToolStripMenuItem.ForeColor = Color.Black
        Form1.VibratorToolStripMenuItem.BackColor = Color.Transparent

        Form1.LoadAndWashToolStripMenuItem.ForeColor = Color.White
        Form1.LoadAndWashToolStripMenuItem.BackColor = Color.Orange

        Form1.AnnealingToolStripMenuItem.ForeColor = Color.Black
        Form1.AnnealingToolStripMenuItem.BackColor = Color.Transparent

        Form1.WashToolStripMenuItem.ForeColor = Color.Black
        Form1.WashToolStripMenuItem.BackColor = Color.Transparent

        Form1.SputToolStripMenuItem.ForeColor = Color.Black
        Form1.SputToolStripMenuItem.BackColor = Color.Transparent

        Form1.SAMToolStripMenuItem.ForeColor = Color.Black
        Form1.SAMToolStripMenuItem.BackColor = Color.Transparent

        Form1.lblProcessName.Text = "Load and Wash"

        PunchPress_Process = False
        Vibrator_Process = False
        LoadWash_Process = True
        Annealing_Process = False
        Wash_Process = False
        Sput_Process = False
        SAM_Process = False

    End Sub

    Sub Annealing_clicked()
        Form1.PunchPressToolStripMenuItem.ForeColor = Color.Black
        Form1.PunchPressToolStripMenuItem.BackColor = Color.Transparent

        Form1.VibratorToolStripMenuItem.ForeColor = Color.Black
        Form1.VibratorToolStripMenuItem.BackColor = Color.Transparent

        Form1.LoadAndWashToolStripMenuItem.ForeColor = Color.Black
        Form1.LoadAndWashToolStripMenuItem.BackColor = Color.Transparent

        Form1.AnnealingToolStripMenuItem.ForeColor = Color.White
        Form1.AnnealingToolStripMenuItem.BackColor = Color.Orange

        Form1.WashToolStripMenuItem.ForeColor = Color.Black
        Form1.WashToolStripMenuItem.BackColor = Color.Transparent

        Form1.SputToolStripMenuItem.ForeColor = Color.Black
        Form1.SputToolStripMenuItem.BackColor = Color.Transparent

        Form1.SAMToolStripMenuItem.ForeColor = Color.Black
        Form1.SAMToolStripMenuItem.BackColor = Color.Transparent


        Form1.lblProcessName.Text = "Annealing"

        PunchPress_Process = False
        Vibrator_Process = False
        LoadWash_Process = False
        Annealing_Process = True
        Wash_Process = False
        Sput_Process = False
        SAM_Process = False

    End Sub

    Sub Wash_clicked()
        Form1.PunchPressToolStripMenuItem.ForeColor = Color.Black
        Form1.PunchPressToolStripMenuItem.BackColor = Color.Transparent

        Form1.VibratorToolStripMenuItem.ForeColor = Color.Black
        Form1.VibratorToolStripMenuItem.BackColor = Color.Transparent

        Form1.LoadAndWashToolStripMenuItem.ForeColor = Color.Black
        Form1.LoadAndWashToolStripMenuItem.BackColor = Color.Transparent

        Form1.AnnealingToolStripMenuItem.ForeColor = Color.Black
        Form1.AnnealingToolStripMenuItem.BackColor = Color.Transparent

        Form1.WashToolStripMenuItem.ForeColor = Color.White
        Form1.WashToolStripMenuItem.BackColor = Color.Orange

        Form1.SputToolStripMenuItem.ForeColor = Color.Black
        Form1.SputToolStripMenuItem.BackColor = Color.Transparent

        Form1.SAMToolStripMenuItem.ForeColor = Color.Black
        Form1.SAMToolStripMenuItem.BackColor = Color.Transparent


        Form1.lblProcessName.Text = "Wash"

        PunchPress_Process = False
        Vibrator_Process = False
        LoadWash_Process = False
        Annealing_Process = False
        Wash_Process = True
        Sput_Process = False
        SAM_Process = False

    End Sub

    Sub Sput_clicked()
        Form1.PunchPressToolStripMenuItem.ForeColor = Color.Black
        Form1.PunchPressToolStripMenuItem.BackColor = Color.Transparent

        Form1.VibratorToolStripMenuItem.ForeColor = Color.Black
        Form1.VibratorToolStripMenuItem.BackColor = Color.Transparent

        Form1.LoadAndWashToolStripMenuItem.ForeColor = Color.Black
        Form1.LoadAndWashToolStripMenuItem.BackColor = Color.Transparent

        Form1.AnnealingToolStripMenuItem.ForeColor = Color.Black
        Form1.AnnealingToolStripMenuItem.BackColor = Color.Transparent

        Form1.WashToolStripMenuItem.ForeColor = Color.Black
        Form1.WashToolStripMenuItem.BackColor = Color.Transparent

        Form1.SputToolStripMenuItem.ForeColor = Color.White
        Form1.SputToolStripMenuItem.BackColor = Color.Orange

        Form1.SAMToolStripMenuItem.ForeColor = Color.Black
        Form1.SAMToolStripMenuItem.BackColor = Color.Transparent


        Form1.lblProcessName.Text = "Sput"

        PunchPress_Process = False
        Vibrator_Process = False
        LoadWash_Process = False
        Annealing_Process = False
        Wash_Process = False
        Sput_Process = True
        SAM_Process = False

    End Sub

    Sub SAM_clicked()
        Form1.PunchPressToolStripMenuItem.ForeColor = Color.Black
        Form1.PunchPressToolStripMenuItem.BackColor = Color.Transparent

        Form1.VibratorToolStripMenuItem.ForeColor = Color.Black
        Form1.VibratorToolStripMenuItem.BackColor = Color.Transparent

        Form1.LoadAndWashToolStripMenuItem.ForeColor = Color.Black
        Form1.LoadAndWashToolStripMenuItem.BackColor = Color.Transparent

        Form1.AnnealingToolStripMenuItem.ForeColor = Color.Black
        Form1.AnnealingToolStripMenuItem.BackColor = Color.Transparent

        Form1.WashToolStripMenuItem.ForeColor = Color.Black
        Form1.WashToolStripMenuItem.BackColor = Color.Transparent

        Form1.SputToolStripMenuItem.ForeColor = Color.Black
        Form1.SputToolStripMenuItem.BackColor = Color.Transparent

        Form1.SAMToolStripMenuItem.ForeColor = Color.White
        Form1.SAMToolStripMenuItem.BackColor = Color.Orange


        Form1.lblProcessName.Text = "SAM"

        PunchPress_Process = False
        Vibrator_Process = False
        LoadWash_Process = False
        Annealing_Process = False
        Wash_Process = False
        Sput_Process = False
        SAM_Process = True

    End Sub

    Sub WIP_clicked()
        With WIP_Form
            .TopLevel = False
            Form1.Main.Controls.Add(WIP_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With

    End Sub

    Sub UpdateWIP_clicked()
        With UpdateWIP_Form
            .TopLevel = False
            Form1.Main.Controls.Add(UpdateWIP_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With

    End Sub

    Sub ViewAll_clicked()
        With ViewData_Form
            .TopLevel = False
            Form1.Main.Controls.Add(ViewData_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub ClearData()
        Form1.txtProduct.Clear()
        Form1.txtProduct.ReadOnly = False

        Form1.txtLot.Clear()
        Form1.txtLot.ReadOnly = False

        Form1.txtQty.Clear()
        Form1.txtQty.ReadOnly = False

        Form1.txtTransac.Clear()

        Form1.txtProduct.Focus()
    End Sub

    Sub Select_Process_ForSaving()
        If PunchPress_Process = True Then

            If IN_Product = True Then
                Add_PunchPress_In()
                Add_PunchPress_In_to_Processtb()
                MsgBox("Transaction done!")
                ClearData()
            Else

                Get_PunchPress_In()

                If PP_In_Qty = 0 Then
                    MsgBox("Punch Press In quantity: 0" & vbCrLf &
                           "This process is done! You may proceed to the vibrator process", MsgBoxStyle.Information)
                    ClearData()
                    Vibrator_clicked()
                Else

                    If PP_In_Qty < CInt(Form1.txtQty.Text) Then
                        MsgBox("Out quantity is greater than the In quantity!" & vbCrLf &
                               "Please enter proper amount." & vbCrLf &
                               "Punch Press In qty: " & PP_In_Qty, MsgBoxStyle.Information)


                        Form1.txtQty.ReadOnly = False
                        Form1.txtQty.Clear()
                        Form1.txtQty.Focus()
                    Else

                        Add_PunchPress_Out()
                        Add_PunchPress_Out_to_Processtb()
                        MsgBox("Transaction done!")
                        ClearData()
                    End If

                End If

            End If

        ElseIf Vibrator_Process = True Then

            If IN_Product = True Then
                Get_PunchPress_Out()

                If PP_Out_Qty < CInt(Form1.txtQty.Text) Then
                    MsgBox("In quantity is greater than the Out quantity!" & vbCrLf &
                           "Please enter proper amount." & vbCrLf &
                           "Punch Press Out qty: " & PP_Out_Qty, MsgBoxStyle.Information)

                    Form1.txtQty.ReadOnly = False
                    Form1.txtQty.Clear()
                    Form1.txtQty.Focus()
                Else
                    Add_Vibrator_In()
                    Add_Vibrator_In_to_Processtb()
                    MsgBox("Transaction done!")
                    ClearData()
                End If
            Else

                Get_Vib_In()

                If Vib_In_Qty = 0 Then
                    MsgBox("Vibrator In quantity: 0" & vbCrLf &
                           "This process is done! You may proceed to the load and wash process", MsgBoxStyle.Information)
                    ClearData()
                    LoadWash_clicked()
                Else
                    If Vib_In_Qty < CInt(Form1.txtQty.Text) Then
                        MsgBox("Out quantity is greater than the In quantity!" & vbCrLf &
                               "Please enter proper amount." & vbCrLf &
                               "Vibrator In qty: " & Vib_In_Qty, MsgBoxStyle.Information)

                        Form1.txtQty.ReadOnly = False
                        Form1.txtQty.Clear()
                        Form1.txtQty.Focus()
                    Else

                        Add_Vibrator_Out()
                        Add_Vibrator_Out_to_Processtb()
                        MsgBox("Transaction done!")
                        ClearData()
                    End If
                End If
            End If

        ElseIf LoadWash_Process = True Then

            If IN_Product = True Then
                Get_Vib_Out()

                If Vib_Out_Qty < CInt(Form1.txtQty.Text) Then
                    MsgBox("In quantity is greater than the Out quantity!" & vbCrLf &
                           "Please enter proper amount." & vbCrLf &
                           "Vibrator Out qty: " & Vib_Out_Qty, MsgBoxStyle.Information)

                    Form1.txtQty.ReadOnly = False
                    Form1.txtQty.Clear()
                    Form1.txtQty.Focus()
                Else
                    Add_LW_In()
                    Add_LW_In_to_Processtb()
                    MsgBox("Transaction done!")
                    ClearData()
                End If
            Else

                Get_LW_In()

                If LW_In_Qty = 0 Then
                    MsgBox("Load and wash In quantity: 0" & vbCrLf &
                           "This process is done! You may proceed to the annealing process", MsgBoxStyle.Information)
                    ClearData()
                    Annealing_clicked()
                Else

                    If LW_In_Qty < CInt(Form1.txtQty.Text) Then
                        MsgBox("Out quantity is greater than the In quantity!" & vbCrLf &
                               "Please enter proper amount." & vbCrLf &
                               "Load and Wash In qty: " & LW_In_Qty, MsgBoxStyle.Information)

                        Form1.txtQty.ReadOnly = False
                        Form1.txtQty.Clear()
                        Form1.txtQty.Focus()
                    Else

                        Add_LW_Out()
                        Add_LW_Out_to_Processtb()
                        MsgBox("Transaction done!")
                        ClearData()
                    End If
                End If
            End If

        ElseIf Annealing_Process = True Then

            If IN_Product = True Then
                Get_LW_Out()

                If LW_Out_Qty < CInt(Form1.txtQty.Text) Then
                    MsgBox("In quantity is greater than the Out quantity!" & vbCrLf &
                           "Please enter proper amount." & vbCrLf &
                           "Load and Wash Out qty: " & LW_Out_Qty, MsgBoxStyle.Information)

                    Form1.txtQty.ReadOnly = False
                    Form1.txtQty.Clear()
                    Form1.txtQty.Focus()
                Else
                    Add_Annealing_In()
                    Add_Annealing_In_to_Processtb()
                    MsgBox("Transaction done!")
                    ClearData()
                End If
            Else

                Get_Annealing_In()

                If Ann_In_Qty = 0 Then
                    MsgBox("Annealing In quantity: 0" & vbCrLf &
                           "This process is done! You may proceed to the wash process", MsgBoxStyle.Information)
                    ClearData()
                    Wash_clicked()
                Else

                    If Ann_In_Qty < CInt(Form1.txtQty.Text) Then
                        MsgBox("Out quantity is greater than the In quantity!" & vbCrLf &
                               "Please enter proper amount." & vbCrLf &
                               "Annealing In qty: " & Ann_In_Qty, MsgBoxStyle.Information)

                        Form1.txtQty.ReadOnly = False
                        Form1.txtQty.Clear()
                        Form1.txtQty.Focus()
                    Else

                        Add_Annealing_Out()
                        Add_Annealing_Out_to_Processtb()
                        MsgBox("Transaction done!")
                        ClearData()
                    End If
                End If
            End If

        ElseIf Wash_Process = True Then

            If IN_Product = True Then
                Get_Annealing_Out()

                If Ann_Out_Qty < CInt(Form1.txtQty.Text) Then
                    MsgBox("In quantity is greater than the Out quantity!" & vbCrLf &
                           "Please enter proper amount." & vbCrLf &
                           "Annealing Out qty: " & Ann_Out_Qty, MsgBoxStyle.Information)

                    Form1.txtQty.ReadOnly = False
                    Form1.txtQty.Clear()
                    Form1.txtQty.Focus()
                Else
                    Add_Wash_In()
                    Add_Wash_In_to_Processtb()
                    MsgBox("Transaction done!")
                    ClearData()
                End If
            Else

                Get_Wash_In()

                If Wash_In_Qty = 0 Then
                    MsgBox("Wash In quantity: 0" & vbCrLf &
                           "This process is done! You may proceed to the sput process", MsgBoxStyle.Information)
                    ClearData()
                    Sput_clicked()
                Else

                    If Wash_In_Qty < CInt(Form1.txtQty.Text) Then
                        MsgBox("Out quantity is greater than the In quantity!" & vbCrLf &
                               "Please enter proper amount." & vbCrLf &
                               "Wash In qty: " & Wash_In_Qty, MsgBoxStyle.Information)

                        Form1.txtQty.ReadOnly = False
                        Form1.txtQty.Clear()
                        Form1.txtQty.Focus()
                    Else

                        Add_Wash_Out()
                        Add_Wash_Out_to_Processtb()
                        MsgBox("Transaction done!")
                        ClearData()
                    End If
                End If
            End If

        ElseIf Sput_Process = True Then

            If IN_Product = True Then
                Get_Wash_Out()

                If Wash_Out_Qty < CInt(Form1.txtQty.Text) Then
                    MsgBox("In quantity is greater than the Out quantity!" & vbCrLf &
                           "Please enter proper amount." & vbCrLf &
                           "Wash Out qty: " & Wash_Out_Qty, MsgBoxStyle.Information)

                    Form1.txtQty.ReadOnly = False
                    Form1.txtQty.Clear()
                    Form1.txtQty.Focus()
                Else
                    Add_Sput_In()
                    Add_Sput_In_to_Processtb()
                    MsgBox("Transaction done!")
                    ClearData()
                End If
            Else

                Get_Sput_In()

                If Sput_In_Qty = 0 Then
                    MsgBox("Sput In quantity: 0" & vbCrLf &
                           "This process is done! You may proceed to the SAM process", MsgBoxStyle.Information)
                    ClearData()
                    SAM_clicked()
                Else

                    If Sput_In_Qty < CInt(Form1.txtQty.Text) Then
                        MsgBox("Out quantity is greater than the In quantity!" & vbCrLf &
                               "Please enter proper amount." & vbCrLf &
                               "Sput In qty: " & Sput_In_Qty, MsgBoxStyle.Information)

                        Form1.txtQty.ReadOnly = False
                        Form1.txtQty.Clear()
                        Form1.txtQty.Focus()
                    Else

                        Add_Sput_Out()
                        Add_Sput_Out_to_Processtb()
                        MsgBox("Transaction done!")
                        ClearData()
                    End If
                End If
            End If

        ElseIf SAM_Process = True Then

            If IN_Product = True Then
                Get_Sput_Out()

                If Sput_Out_Qty < CInt(Form1.txtQty.Text) Then
                    MsgBox("In quantity is greater than the Out quantity!" & vbCrLf &
                           "Please enter proper amount." & vbCrLf &
                           "Sput Out qty: " & Sput_Out_Qty, MsgBoxStyle.Information)

                    Form1.txtQty.ReadOnly = False
                    Form1.txtQty.Clear()
                    Form1.txtQty.Focus()
                Else
                    Add_SAM_In()
                    Add_SAM_In_to_Processtb()
                    MsgBox("Transaction done!")
                    ClearData()
                End If
            Else

                Get_SAM_In()

                If SAM_In_Qty = 0 Then
                    MsgBox("SAM In quantity: 0" & vbCrLf &
                           "The process is done for this lot number!", MsgBoxStyle.Information)
                    ClearData()
                    SAM_clicked()
                Else

                    If SAM_In_Qty < CInt(Form1.txtQty.Text) Then
                        MsgBox("Out quantity is greater than the In quantity!" & vbCrLf &
                               "Please enter proper amount." & vbCrLf &
                               "SAM In qty: " & SAM_In_Qty, MsgBoxStyle.Information)

                        Form1.txtQty.ReadOnly = False
                        Form1.txtQty.Clear()
                        Form1.txtQty.Focus()
                    Else

                        Add_SAM_Out()
                        Add_SAM_Out_to_Processtb()
                        MsgBox("Transaction done!")
                        ClearData()
                    End If
                End If
            End If

        End If
    End Sub

    Sub Search_LotNumber()
        If PunchPress_Process = True Then
            Check_PunchPress_LotNum()

        ElseIf Vibrator_Process = True Then
            Check_Vibrator_LotNum()

        ElseIf LoadWash_Process = True Then
            Check_LW_LotNum()

        ElseIf Annealing_Process = True Then
            Check_Annealing_LotNum()

        ElseIf Wash_Process = True Then
            Check_Wash_LotNum()

        ElseIf Sput_Process = True Then
            Check_Sput_LotNum()

        ElseIf SAM_Process = True Then
            Check_SAM_LotNum()

        End If
    End Sub

    '******************< to Load Process >*****************

    Sub Load_SelectProcess()
        Get_PP_Status()
        Get_VIB_Status()
        Get_LW_Status()
        Get_ANN_Status()
        Get_WASH_Status()
        Get_SPUT_Status()
        Get_SAM_Status()

        Dim menuItemMappings As New Dictionary(Of ToolStripMenuItem, String) From {
        {Form1.PunchPressToolStripMenuItem, PP_State},
        {Form1.VibratorToolStripMenuItem, VIB_State},
        {Form1.LoadAndWashToolStripMenuItem, LW_State},
        {Form1.AnnealingToolStripMenuItem, ANN_State},
        {Form1.WashToolStripMenuItem, WASH_State},
        {Form1.SputToolStripMenuItem, SPUT_State},
        {Form1.SAMToolStripMenuItem, SAM_State}
    }

        For Each mapping In menuItemMappings
            mapping.Key.Enabled = (mapping.Value = "True")
        Next

        Load_CheckProcess()
    End Sub

    Sub Load_CheckProcess()
        If PP_State = "True" Then
            PunchPress_clicked()
        ElseIf VIB_State = "True" Then
            Vibrator_clicked()
        ElseIf LW_State = "True" Then
            LoadWash_clicked()
        ElseIf ANN_State = "True" Then
            Annealing_clicked()
        ElseIf WASH_State = "True" Then
            Wash_clicked()
        ElseIf SPUT_State = "True" Then
            Sput_clicked()
        ElseIf SAM_State = "True" Then
            SAM_clicked()
        End If
    End Sub
End Module
Module AppConfig_Module
    Public config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    Public PP_State As String
    Public VIB_State As String
    Public LW_State As String
    Public ANN_State As String
    Public WASH_State As String
    Public SPUT_State As String
    Public SAM_State As String

    Public New_PP_State As String
    Public New_VIB_State As String
    Public New_LW_State As String
    Public New_ANN_State As String
    Public New_WASH_State As String
    Public New_SPUT_State As String
    Public New_SAM_State As String

    Public WIP_SDate As String
    Public WIP_EDate As String

    Public New_WIP_SDate As String
    Public New_WIP_EDate As String

    '*****************< Get Button State >*******************
    Sub Get_PP_Status()
        Dim btnstate As String = System.Configuration.ConfigurationManager.AppSettings("PP_STAT")
        Console.WriteLine(btnstate)

        PP_State = btnstate
    End Sub
    Sub Get_VIB_Status()
        Dim btnstate As String = System.Configuration.ConfigurationManager.AppSettings("VIB_STAT")
        Console.WriteLine(btnstate)

        VIB_State = btnstate
    End Sub
    Sub Get_LW_Status()
        Dim btnstate As String = System.Configuration.ConfigurationManager.AppSettings("LW_STAT")
        Console.WriteLine(btnstate)

        LW_State = btnstate
    End Sub
    Sub Get_ANN_Status()
        Dim btnstate As String = System.Configuration.ConfigurationManager.AppSettings("ANN_STAT")
        Console.WriteLine(btnstate)

        ANN_State = btnstate
    End Sub
    Sub Get_WASH_Status()
        Dim btnstate As String = System.Configuration.ConfigurationManager.AppSettings("WASH_STAT")
        Console.WriteLine(btnstate)

        WASH_State = btnstate
    End Sub
    Sub Get_SPUT_Status()
        Dim btnstate As String = System.Configuration.ConfigurationManager.AppSettings("SPUT_STAT")
        Console.WriteLine(btnstate)

        SPUT_State = btnstate
    End Sub
    Sub Get_SAM_Status()
        Dim btnstate As String = System.Configuration.ConfigurationManager.AppSettings("SAM_STAT")
        Console.WriteLine(btnstate)

        SAM_State = btnstate
    End Sub

    '*****************< Update Button State >*******************

    Sub Update_PP_Status()
        config.AppSettings.Settings("PP_STAT").Value = New_PP_State ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub
    Sub Update_VIB_Status()
        config.AppSettings.Settings("VIB_STAT").Value = New_VIB_State ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub
    Sub Update_LW_Status()
        config.AppSettings.Settings("LW_STAT").Value = New_LW_State ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub
    Sub Update_ANN_Status()
        config.AppSettings.Settings("ANN_STAT").Value = New_ANN_State ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub
    Sub Update_WASH_Status()
        config.AppSettings.Settings("WASH_STAT").Value = New_WASH_State ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub
    Sub Update_SPUT_Status()
        config.AppSettings.Settings("SPUT_STAT").Value = New_SPUT_State ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub
    Sub Update_SAM_Status()
        config.AppSettings.Settings("SAM_STAT").Value = New_SAM_State ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    '*****************< Get WIP Start and End Loading data >*******************
    Sub Get_WIP_Start()
        Dim btnstate As String = System.Configuration.ConfigurationManager.AppSettings("WIP_Start")
        Console.WriteLine(btnstate)

        WIP_SDate = btnstate
    End Sub
    Sub Get_WIP_End()
        Dim btnstate As String = System.Configuration.ConfigurationManager.AppSettings("WIP_End")
        Console.WriteLine(btnstate)

        WIP_EDate = btnstate
    End Sub

    '*****************< Updated WIP Start and End Loading data >*******************

    Sub Update_WIP_Start()
        config.AppSettings.Settings("WIP_Start").Value = New_WIP_SDate ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub
    Sub Update_WIP_End()
        config.AppSettings.Settings("WIP_End").Value = New_WIP_EDate ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

End Module