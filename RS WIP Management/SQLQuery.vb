Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Threading
Imports System.Web
Imports System.Xml

Module Query_Module

    'Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\RS WIP Management.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfrswip
    'Data Source=BTMESSQLDEV03;Initial Catalog=LFPH_RS;Persist Security Info=True;User ID=mesph;Password=PHFuse;TrustServerCertificate=True


    '****************************< FOR MES connection >****************************
    Public MES_connString As String = "Data Source=BTMESSQLPRD04;Initial Catalog=MESCoreReport_EBU_PH;Persist Security Info=True;User ID=MESCoreReadOnly;Password=Mes@user;TrustServerCertificate=True"
    Public MES_Dbconnection As New SqlConnection(MES_connString)

    Sub MES_ConOpen()
        If MES_Dbconnection.State = ConnectionState.Closed Then
            MES_Dbconnection.Open()
        End If
    End Sub
    Sub MES_ConClose()
        If MES_Dbconnection.State = ConnectionState.Open Then
            MES_Dbconnection.Close()
        End If
    End Sub

    '****************************< FOR QA connection >****************************
    Public QA_connString As String = "Data Source=BTMESSQLQA03;Initial Catalog=LFRSBackend;Persist Security Info=True;User ID=mesph;Password=PHFuse;TrustServerCertificate=True"
    Public QA_Dbconnection As New SqlConnection(QA_connString)

    Sub QA_ConOpen()
        If QA_Dbconnection.State = ConnectionState.Closed Then
            QA_Dbconnection.Open()
        End If
    End Sub
    Sub QA_ConClose()
        If QA_Dbconnection.State = ConnectionState.Open Then
            QA_Dbconnection.Close()
        End If
    End Sub

    '****************************< FOR GENERAL USE >****************************

    'Data Source=BTMESSQLPRD01;Initial Catalog=RS;Persist Security Info=True;User ID=rs;Password=dZE34EGv;TrustServerCertificate=True
    'Data Source=BTMESSQLDEV03;Initial Catalog=LFPH_RS;Persist Security Info=True;User ID=mesph;Password=PHFuse;TrustServerCertificate=True

    Public connString As String = "Data Source=BTMESSQLPRD01;Initial Catalog=RS;Persist Security Info=True;User ID=rs;Password=dZE34EGv;TrustServerCertificate=True"
    Public Dbconnection As New SqlConnection(connString)

    Sub ConOpen()
        If Dbconnection.State = ConnectionState.Closed Then
            Dbconnection.Open()
        End If
    End Sub
    Sub ConClose()
        If Dbconnection.State = ConnectionState.Open Then
            Dbconnection.Close()
        End If
    End Sub

    Sub Get_Products()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Products_tb WHERE Products = '" + Form1.txtProduct.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            'Clear_Datas()

            If Data.Rows.Count > 0 Then

                Form1.txtProduct.ReadOnly = True
                Form1.txtLot.Focus()

            Else
                MsgBox("Product does not exist in the database.", MessageBoxIcon.Error)
                Form1.txtProduct.Clear()
                Form1.txtProduct.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    '**************************** < FOR PUNCH PRESS > ****************************
    Sub Add_PunchPress_In_to_Processtb()
        Dim mycommand As String

        Dim Prod As String = Form1.txtProduct.Text
        Dim Lot As String = Form1.txtLot.Text
        Dim Quantity As String = Form1.txtQty.Text
        Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mm tt")

        Try
            ConOpen()
            mycommand = "INSERT INTO [WIPM_Process_tb] ([Product],[Lot_Number], [PP_In], [DateTime]) 
                                VALUES (@proname, @lotnum, @qnty, @dt)"
            Using command As New SqlCommand(mycommand, Dbconnection)
                command.Parameters.AddWithValue("@proname", Prod)
                command.Parameters.AddWithValue("@lotnum", Lot)
                command.Parameters.AddWithValue("@qnty", Quantity)
                command.Parameters.AddWithValue("@dt", dateNtime)
                command.ExecuteNonQuery()
            End Using
            ConClose()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub Add_PunchPress_In()
        Dim mycommand As String

        Dim Prod As String = Form1.txtProduct.Text
        Dim Lot As String = Form1.txtLot.Text
        Dim Quantity As String = Form1.txtQty.Text
        Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mm tt")

        Try
            ConOpen()
            mycommand = "INSERT INTO [WIPM_PunchPress_tb] ([Product],[Lot_Number], [Qty_In], [DateTime_In]) 
                                VALUES (@proname, @lotnum, @qnty, @dnt)"
            Using command As New SqlCommand(mycommand, Dbconnection)
                command.Parameters.AddWithValue("@proname", Prod)
                command.Parameters.AddWithValue("@lotnum", Lot)
                command.Parameters.AddWithValue("@qnty", Quantity)
                command.Parameters.AddWithValue("@dnt", dateNtime)
                command.ExecuteNonQuery()
            End Using
            ConClose()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Public PP_In_Qty As String
    Public New_PP_In_Qty As Integer

    Sub Get_PunchPress_In()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Process_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                PP_In_Qty = Data.Rows(0).Item("PP_In").ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Add_PunchPress_Out()
        Try

            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text
            Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mm tt")

            Dim query As String = "UPDATE WIPM_PunchPress_tb 
                                SET  Qty_Out = @out,  DateTime_Out = @dnt
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@out", Quantity)
                command.Parameters.AddWithValue("@dnt", dateNtime)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Add_PunchPress_Out_to_Processtb()

        Get_PunchPress_Out()

        Try

            'Dim Prod As String = Form1.txtProduct.Text
            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text
            Dim New_Out As Integer = PP_Out_Qty + CInt(Quantity)

            New_PP_In_Qty = PP_In_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET PP_In = @in, PP_Out = @Out
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@in", New_PP_In_Qty)
                command.Parameters.AddWithValue("@Out", New_Out)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Check_PunchPress_LotNum()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_PunchPress_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            'Clear_Datas()

            If Data.Rows.Count > 0 Then

                Form1.txtLot.ReadOnly = True
                Form1.txtTransac.Text = "OUT"
                Form1.txtQty.Focus()

                IN_Product = False

            Else
                'MsgBox("Lot number does not exist in the database.", MessageBoxIcon.Error)

                Form1.txtLot.ReadOnly = True
                Form1.txtTransac.Text = "IN"
                Form1.txtQty.Focus()

                IN_Product = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    '**************************** < FOR VIBRATOR > ****************************
    Sub Check_Vibrator_LotNum()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Vibrator_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            'Clear_Datas()

            If Data.Rows.Count > 0 Then

                Form1.txtLot.ReadOnly = True
                Form1.txtTransac.Text = "OUT"
                Form1.txtQty.Focus()

                IN_Product = False

            Else
                'MsgBox("Lot number does not exist in the database.", MessageBoxIcon.Error)

                Form1.txtLot.ReadOnly = True
                Form1.txtTransac.Text = "IN"
                Form1.txtQty.Focus()

                IN_Product = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Public PP_Out_Qty As String
    Public New_PP_Out_Qty As Integer

    Sub Get_PunchPress_Out()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Process_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                PP_Out_Qty = Data.Rows(0).Item("PP_Out").ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Add_Vibrator_In_to_Processtb()

        Try

            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text

            New_PP_Out_Qty = PP_Out_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET PP_Out = @Pout, Vib_In = @in
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Pout", New_PP_Out_Qty)
                command.Parameters.AddWithValue("@in", Quantity)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Public Vib_In_Qty As String
    Public New_Vib_In_Qty As Integer

    Sub Get_Vib_In()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Process_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                Vib_In_Qty = Data.Rows(0).Item("Vib_In").ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Add_Vibrator_In()
        Dim mycommand As String

        Dim Prod As String = Form1.txtProduct.Text
        Dim Lot As String = Form1.txtLot.Text
        Dim Quantity As String = Form1.txtQty.Text
        Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mm tt")

        Try
            ConOpen()
            mycommand = "INSERT INTO [WIPM_Vibrator_tb] ([Product],[Lot_Number], [Qty_In], [DateTime_In]) 
                                VALUES (@proname, @lotnum, @qnty, @dnt)"
            Using command As New SqlCommand(mycommand, Dbconnection)
                command.Parameters.AddWithValue("@proname", Prod)
                command.Parameters.AddWithValue("@lotnum", Lot)
                command.Parameters.AddWithValue("@qnty", Quantity)
                command.Parameters.AddWithValue("@dnt", dateNtime)
                command.ExecuteNonQuery()
            End Using
            ConClose()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Add_Vibrator_Out_to_Processtb()

        Get_Vib_Out()

        Try

            'Dim Prod As String = Form1.txtProduct.Text
            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text
            Dim New_Out As Integer = Vib_Out_Qty + CInt(Quantity)

            New_Vib_In_Qty = Vib_In_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET Vib_In = @Nin, Vib_Out = @Out
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Nin", New_Vib_In_Qty)
                command.Parameters.AddWithValue("@Out", New_Out)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Add_Vibrator_Out()
        Try

            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text
            Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mm tt")

            Dim query As String = "UPDATE WIPM_Vibrator_tb 
                                SET Qty_Out = @out,  DateTime_Out = @dnt
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)

                command.Parameters.AddWithValue("@out", Quantity)
                command.Parameters.AddWithValue("@dnt", dateNtime)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    '**************************** < FOR LOAD AND WASH > ****************************
    Sub Check_LW_LotNum()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_LoadWash_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            'Clear_Datas()

            If Data.Rows.Count > 0 Then

                Form1.txtLot.ReadOnly = True
                Form1.txtTransac.Text = "OUT"
                Form1.txtQty.Focus()

                IN_Product = False

            Else
                'MsgBox("Lot number does not exist in the database.", MessageBoxIcon.Error)

                Form1.txtLot.ReadOnly = True
                Form1.txtTransac.Text = "IN"
                Form1.txtQty.Focus()

                IN_Product = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Public Vib_Out_Qty As String
    Public New_Vib_Out_Qty As Integer

    Sub Get_Vib_Out()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Process_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                Vib_Out_Qty = Data.Rows(0).Item("Vib_Out").ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Add_LW_In_to_Processtb()

        Try

            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text

            New_Vib_Out_Qty = Vib_Out_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET Vib_Out = @Vout, LW_In = @in
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Vout", New_Vib_Out_Qty)
                command.Parameters.AddWithValue("@in", Quantity)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Public LW_In_Qty As String
    Public New_LW_In_Qty As Integer

    Sub Get_LW_In()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Process_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                LW_In_Qty = Data.Rows(0).Item("LW_In").ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Add_LW_In()
        Dim mycommand As String

        Dim Prod As String = Form1.txtProduct.Text
        Dim Lot As String = Form1.txtLot.Text
        Dim Quantity As String = Form1.txtQty.Text
        Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mm tt")

        Try
            ConOpen()
            mycommand = "INSERT INTO [WIPM_LoadWash_tb] ([Product],[Lot_Number], [Qty_In], [DateTime_In]) 
                                VALUES (@proname, @lotnum, @qnty, @dnt)"
            Using command As New SqlCommand(mycommand, Dbconnection)
                command.Parameters.AddWithValue("@proname", Prod)
                command.Parameters.AddWithValue("@lotnum", Lot)
                command.Parameters.AddWithValue("@qnty", Quantity)
                command.Parameters.AddWithValue("@dnt", dateNtime)
                command.ExecuteNonQuery()
            End Using
            ConClose()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Add_LW_Out_to_Processtb()

        Get_LW_Out()

        Try

            'Dim Prod As String = Form1.txtProduct.Text
            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text
            Dim New_Out As Integer = LW_Out_Qty + CInt(Quantity)

            New_LW_In_Qty = LW_In_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET LW_In = @Nin, LW_Out = @Out
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Nin", New_LW_In_Qty)
                command.Parameters.AddWithValue("@Out", New_Out)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Add_LW_Out()
        Try

            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text
            Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mm tt")

            Dim query As String = "UPDATE WIPM_LoadWash_tb 
                                SET Qty_Out = @out,  DateTime_Out = @dnt
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)

                command.Parameters.AddWithValue("@out", Quantity)
                command.Parameters.AddWithValue("@dnt", dateNtime)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    '**************************** < FOR ANNEALING > ****************************

    Sub Check_Annealing_LotNum()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Annealing_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            'Clear_Datas()

            If Data.Rows.Count > 0 Then

                Form1.txtLot.ReadOnly = True
                Form1.txtTransac.Text = "OUT"
                Form1.txtQty.Focus()

                IN_Product = False

            Else
                'MsgBox("Lot number does not exist in the database.", MessageBoxIcon.Error)

                Form1.txtLot.ReadOnly = True
                Form1.txtTransac.Text = "IN"
                Form1.txtQty.Focus()

                IN_Product = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Public LW_Out_Qty As String
    Public New_LW_Out_Qty As Integer

    Sub Get_LW_Out()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Process_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                LW_Out_Qty = Data.Rows(0).Item("LW_Out").ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Add_Annealing_In_to_Processtb()

        Try

            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text

            New_LW_Out_Qty = LW_Out_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET LW_Out = @LWout, Annealing_In = @in
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@LWout", New_LW_Out_Qty)
                command.Parameters.AddWithValue("@in", Quantity)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Public Ann_In_Qty As String
    Public New_Ann_In_Qty As Integer

    Sub Get_Annealing_In()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Process_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                Ann_In_Qty = Data.Rows(0).Item("Annealing_In").ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Add_Annealing_In()
        Dim mycommand As String

        Dim Prod As String = Form1.txtProduct.Text
        Dim Lot As String = Form1.txtLot.Text
        Dim Quantity As String = Form1.txtQty.Text
        Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mm tt")

        Try
            ConOpen()
            mycommand = "INSERT INTO [WIPM_Annealing_tb] ([Product],[Lot_Number], [Qty_In], [DateTime_In]) 
                                VALUES (@proname, @lotnum, @qnty, @dnt)"
            Using command As New SqlCommand(mycommand, Dbconnection)
                command.Parameters.AddWithValue("@proname", Prod)
                command.Parameters.AddWithValue("@lotnum", Lot)
                command.Parameters.AddWithValue("@qnty", Quantity)
                command.Parameters.AddWithValue("@dnt", dateNtime)
                command.ExecuteNonQuery()
            End Using
            ConClose()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Add_Annealing_Out_to_Processtb()

        Get_Annealing_Out()

        Try

            'Dim Prod As String = Form1.txtProduct.Text
            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text
            Dim New_Out As Integer = Ann_Out_Qty + CInt(Quantity)

            New_Ann_In_Qty = Ann_In_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET Annealing_In = @AnnIn, Annealing_Out = @Out
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@AnnIn", New_Ann_In_Qty)
                command.Parameters.AddWithValue("@Out", New_Out)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Add_Annealing_Out()
        Try

            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text
            Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mm tt")

            Dim query As String = "UPDATE WIPM_Annealing_tb 
                                SET Qty_Out = @out,  DateTime_Out = @dnt
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)

                command.Parameters.AddWithValue("@out", Quantity)
                command.Parameters.AddWithValue("@dnt", dateNtime)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    '**************************** < FOR WASH > ****************************

    Sub Check_Wash_LotNum()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Wash_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            'Clear_Datas()

            If Data.Rows.Count > 0 Then

                Form1.txtLot.ReadOnly = True
                Form1.txtTransac.Text = "OUT"
                Form1.txtQty.Focus()

                IN_Product = False

            Else
                'MsgBox("Lot number does not exist in the database.", MessageBoxIcon.Error)

                Form1.txtLot.ReadOnly = True
                Form1.txtTransac.Text = "IN"
                Form1.txtQty.Focus()

                IN_Product = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Public Ann_Out_Qty As String
    Public New_Ann_Out_Qty As Integer

    Sub Get_Annealing_Out()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Process_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                Ann_Out_Qty = Data.Rows(0).Item("Annealing_Out").ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Add_Wash_In_to_Processtb()

        Try

            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text

            New_Ann_Out_Qty = Ann_Out_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET Annealing_Out = @AnnOut, Wash_In = @in
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@AnnOut", New_Ann_Out_Qty)
                command.Parameters.AddWithValue("@in", Quantity)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Public Wash_In_Qty As String
    Public New_Wash_In_Qty As Integer

    Sub Get_Wash_In()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Process_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                Wash_In_Qty = Data.Rows(0).Item("Wash_In").ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Add_Wash_In()
        Dim mycommand As String

        Dim Prod As String = Form1.txtProduct.Text
        Dim Lot As String = Form1.txtLot.Text
        Dim Quantity As String = Form1.txtQty.Text
        Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mm tt")

        Try
            ConOpen()
            mycommand = "INSERT INTO [WIPM_Wash_tb] ([Product],[Lot_Number], [Qty_In], [DateTime_In]) 
                                VALUES (@proname, @lotnum, @qnty, @dnt)"
            Using command As New SqlCommand(mycommand, Dbconnection)
                command.Parameters.AddWithValue("@proname", Prod)
                command.Parameters.AddWithValue("@lotnum", Lot)
                command.Parameters.AddWithValue("@qnty", Quantity)
                command.Parameters.AddWithValue("@dnt", dateNtime)
                command.ExecuteNonQuery()
            End Using
            ConClose()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Add_Wash_Out_to_Processtb()

        Get_Wash_Out()

        Try

            'Dim Prod As String = Form1.txtProduct.Text
            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text
            Dim New_Out As Integer = Wash_Out_Qty + CInt(Quantity)

            New_Wash_In_Qty = Wash_In_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET Wash_In = @Win, Wash_Out = @Out
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Win", New_Wash_In_Qty)
                command.Parameters.AddWithValue("@Out", New_Out)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Add_Wash_Out()
        Try

            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text
            Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mm tt")

            Dim query As String = "UPDATE WIPM_Wash_tb 
                                SET Qty_Out = @out,  DateTime_Out = @dnt
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)

                command.Parameters.AddWithValue("@out", Quantity)
                command.Parameters.AddWithValue("@dnt", dateNtime)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    '**************************** < FOR SPUT > ****************************
    Sub Check_Sput_LotNum()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Sput_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            'Clear_Datas()

            If Data.Rows.Count > 0 Then

                Form1.txtLot.ReadOnly = True
                Form1.txtTransac.Text = "OUT"
                Form1.txtQty.Focus()

                IN_Product = False

            Else
                'MsgBox("Lot number does not exist in the database.", MessageBoxIcon.Error)

                Form1.txtLot.ReadOnly = True
                Form1.txtTransac.Text = "IN"
                Form1.txtQty.Focus()

                IN_Product = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Public Wash_Out_Qty As String
    Public New_Wash_Out_Qty As Integer

    Sub Get_Wash_Out()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Process_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                Wash_Out_Qty = Data.Rows(0).Item("Wash_Out").ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Add_Sput_In_to_Processtb()

        Try

            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text

            New_Wash_Out_Qty = Wash_Out_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET Wash_Out = @Wout, Sput_In = @in
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Wout", New_Wash_Out_Qty)
                command.Parameters.AddWithValue("@in", Quantity)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Public Sput_In_Qty As String
    Public New_Sput_In_Qty As Integer

    Sub Get_Sput_In()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Process_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                Sput_In_Qty = Data.Rows(0).Item("Sput_In").ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Add_Sput_In()
        Dim mycommand As String

        Dim Prod As String = Form1.txtProduct.Text
        Dim Lot As String = Form1.txtLot.Text
        Dim Quantity As String = Form1.txtQty.Text
        Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mm tt")

        Try
            ConOpen()
            mycommand = "INSERT INTO [WIPM_Sput_tb] ([Product],[Lot_Number], [Qty_In], [DateTime_In]) 
                                VALUES (@proname, @lotnum, @qnty, @dnt)"
            Using command As New SqlCommand(mycommand, Dbconnection)
                command.Parameters.AddWithValue("@proname", Prod)
                command.Parameters.AddWithValue("@lotnum", Lot)
                command.Parameters.AddWithValue("@qnty", Quantity)
                command.Parameters.AddWithValue("@dnt", dateNtime)
                command.ExecuteNonQuery()
            End Using
            ConClose()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Add_Sput_Out_to_Processtb()

        Get_Sput_Out()

        Try

            'Dim Prod As String = Form1.txtProduct.Text
            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text
            Dim New_Out As Integer = Sput_Out_Qty + CInt(Quantity)

            New_Sput_In_Qty = Sput_In_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET Sput_In = @Sin, Sput_Out = @Out
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Sin", New_Sput_In_Qty)
                command.Parameters.AddWithValue("@Out", New_Out)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Add_Sput_Out()
        Try

            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text
            Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mm tt")

            Dim query As String = "UPDATE WIPM_Sput_tb 
                                SET Qty_Out = @out,  DateTime_Out = @dnt
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)

                command.Parameters.AddWithValue("@out", Quantity)
                command.Parameters.AddWithValue("@dnt", dateNtime)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    '**************************** < FOR SAM > ****************************
    Sub Check_SAM_LotNum()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_SAM_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            'Clear_Datas()

            If Data.Rows.Count > 0 Then

                Form1.txtLot.ReadOnly = True
                Form1.txtTransac.Text = "OUT"
                Form1.txtQty.Focus()

                IN_Product = False

            Else
                'MsgBox("Lot number does not exist in the database.", MessageBoxIcon.Error)

                Form1.txtLot.ReadOnly = True
                Form1.txtTransac.Text = "IN"
                Form1.txtQty.Focus()

                IN_Product = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Public Sput_Out_Qty As String
    Public New_Sput_Out_Qty As Integer

    Sub Get_Sput_Out()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Process_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                Sput_Out_Qty = Data.Rows(0).Item("Sput_Out").ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Add_SAM_In_to_Processtb()

        Try

            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text

            New_Sput_Out_Qty = Sput_Out_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET Sput_Out = @Sout, SAM_In = @in
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Sout", New_Sput_Out_Qty)
                command.Parameters.AddWithValue("@in", Quantity)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Public SAM_In_Qty As String
    Public New_SAM_In_Qty As Integer

    Sub Get_SAM_In()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Process_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                SAM_In_Qty = Data.Rows(0).Item("SAM_In").ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Add_SAM_In()
        Dim mycommand As String

        Dim Prod As String = Form1.txtProduct.Text
        Dim Lot As String = Form1.txtLot.Text
        Dim Quantity As String = Form1.txtQty.Text
        Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mm tt")

        Try
            ConOpen()
            mycommand = "INSERT INTO [WIPM_SAM_tb] ([Product],[Lot_Number], [Qty_In], [DateTime_In]) 
                                VALUES (@proname, @lotnum, @qnty, @dnt)"
            Using command As New SqlCommand(mycommand, Dbconnection)
                command.Parameters.AddWithValue("@proname", Prod)
                command.Parameters.AddWithValue("@lotnum", Lot)
                command.Parameters.AddWithValue("@qnty", Quantity)
                command.Parameters.AddWithValue("@dnt", dateNtime)
                command.ExecuteNonQuery()
            End Using
            ConClose()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Public SAM_Out_Qty As Integer
    Sub Get_SAM_Out()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            ConOpen()

            MyData = "SELECT * FROM WIPM_Process_tb WHERE Lot_Number = '" + Form1.txtLot.Text + "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                SAM_Out_Qty = Data.Rows(0).Item("SAM_Out").ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Add_SAM_Out_to_Processtb()
        Get_SAM_Out()

        Try

            'Dim Prod As String = Form1.txtProduct.Text
            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text

            New_SAM_In_Qty = SAM_In_Qty - CInt(Quantity)

            Dim New_Out As Integer = CInt(Quantity) + SAM_Out_Qty

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET SAM_In = @Sin, SAM_Out = @Out
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Sin", New_SAM_In_Qty)
                command.Parameters.AddWithValue("@Out", New_Out)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Add_SAM_Out()
        Try

            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text
            Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mm tt")

            Dim query As String = "UPDATE WIPM_SAM_tb 
                                SET Qty_Out = @out,  DateTime_Out = @dnt
                                WHERE Lot_Number = @LotNum"

            Using command As New SqlCommand(query, Dbconnection)

                command.Parameters.AddWithValue("@out", Quantity)
                command.Parameters.AddWithValue("@dnt", dateNtime)
                command.Parameters.AddWithValue("@LotNum", Lot)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    '**************************** < FOR WIP_Form > ****************************

    'Sub Load_Avail_WIP()
    '    Dim command As New SqlCommand("", Dbconnection)
    '    Dim table As New DataTable

    '    ConOpen()

    '    If Dbconnection.State = ConnectionState.Open Then
    '        Try
    '            command.Connection = Dbconnection
    '            command.CommandText = "SELECT Product, SUM(PP_Out) AS PP_OUT, SUM(Vib_Out) AS VIB_OUT, " &
    '                          "SUM(LW_Out) AS LW_OUT, SUM(Annealing_Out) AS ANN_OUT, " &
    '                          "SUM(Wash_Out) AS W_OUT, SUM(Sput_Out) AS SPUT_OUT, SUM(SAM_OUT) AS SAM_OUT, MAX(Target_WIP) AS Target_WIP, MAX(GAP) AS GAP " &
    '                          "FROM WIPM_Process_tb GROUP BY Product"

    '            Using rdr As SqlDataReader = command.ExecuteReader()
    '                table.Load(rdr)
    '            End Using

    '            ' After binding the DataTable to the DataGridView
    '            WIP_Form.DataGridView1.DataSource = table

    '            ' Format DataGridView columns
    '            For Each column As DataGridViewColumn In WIP_Form.DataGridView1.Columns
    '                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
    '                column.HeaderCell.Style.ForeColor = Color.White
    '                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 10)
    '            Next

    '            ' Rename column headers for clarity
    '            WIP_Form.DataGridView1.Columns("Product").HeaderText = "Product Name"
    '            WIP_Form.DataGridView1.Columns("PP_OUT").HeaderText = "Punch Press Out"
    '            WIP_Form.DataGridView1.Columns("VIB_OUT").HeaderText = "Vibrator Out"
    '            WIP_Form.DataGridView1.Columns("LW_OUT").HeaderText = "Load and Wash Out"
    '            WIP_Form.DataGridView1.Columns("ANN_OUT").HeaderText = "Annealing Out"
    '            WIP_Form.DataGridView1.Columns("W_OUT").HeaderText = "Wash Out"
    '            WIP_Form.DataGridView1.Columns("SPUT_OUT").HeaderText = "Sput Out"
    '            WIP_Form.DataGridView1.Columns("SAM_OUT").HeaderText = "SAM Out"
    '            WIP_Form.DataGridView1.Columns("Target_WIP").HeaderText = "Target"

    '            ' Clear row styles to prevent conflicts
    '            For Each row As DataGridViewRow In WIP_Form.DataGridView1.Rows
    '                row.DefaultCellStyle.BackColor = Color.Empty
    '                row.DefaultCellStyle.ForeColor = Color.Empty
    '            Next

    '            ' Apply conditional formatting at the cell level
    '            For Each row As DataGridViewRow In WIP_Form.DataGridView1.Rows
    '                For Each cell As DataGridViewCell In row.Cells
    '                    Dim cellValue As Decimal
    '                    ' Check if the cell value is numeric and negative
    '                    If Decimal.TryParse(cell.Value?.ToString(), cellValue) AndAlso cellValue < 0 Then
    '                        cell.Style.BackColor = Color.Red
    '                        cell.Style.ForeColor = Color.White
    '                    Else
    '                        ' Reset to default style for non-negative or non-numeric values
    '                        cell.Style.BackColor = Color.Empty
    '                        cell.Style.ForeColor = Color.Empty
    '                    End If
    '                Next
    '            Next

    '            ' Style the DataGridView
    '            WIP_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
    '            WIP_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
    '            WIP_Form.DataGridView1.EnableHeadersVisualStyles = False
    '            WIP_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

    '        Catch ex As Exception
    '            ' Handle any exceptions
    '            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Finally
    '            ' Always close the connection
    '            ConClose()
    '        End Try
    '    Else
    '        MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If

    'End Sub


    Sub Load_Avail_WIP()
        Dim command As New SqlCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            Try
                command.Connection = Dbconnection
                command.CommandText = "SELECT Product, SUM(Vib_Out) AS VIB_OUT, " &
                              "SUM(LW_Out) AS LW_OUT, SUM(Annealing_Out) AS ANN_OUT, " &
                              "SUM(Sput_Out) AS SPUT_OUT, MAX(Target_WIP) AS Target_WIP, MAX(GAP) AS GAP " &
                              "FROM WIPM_Process_tb WHERE NMR = 0 GROUP BY Product"

                Using rdr As SqlDataReader = command.ExecuteReader()
                    table.Load(rdr)
                End Using

                ' After binding the DataTable to the DataGridView
                WIP_Form.DataGridView1.DataSource = table

                ' Format DataGridView columns
                For Each column As DataGridViewColumn In WIP_Form.DataGridView1.Columns
                    column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                    column.HeaderCell.Style.ForeColor = Color.White
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 10)
                Next

                ' Rename column headers for clarity
                WIP_Form.DataGridView1.Columns("Product").HeaderText = "Product Name"
                WIP_Form.DataGridView1.Columns("VIB_OUT").HeaderText = "Vibrator"
                WIP_Form.DataGridView1.Columns("LW_OUT").HeaderText = "Load and Wash"
                WIP_Form.DataGridView1.Columns("ANN_OUT").HeaderText = "Annealing"
                WIP_Form.DataGridView1.Columns("SPUT_OUT").HeaderText = "Sput"
                WIP_Form.DataGridView1.Columns("Target_WIP").HeaderText = "Target"

                ' Clear row styles to prevent conflicts
                For Each row As DataGridViewRow In WIP_Form.DataGridView1.Rows
                    row.DefaultCellStyle.BackColor = Color.Empty
                    row.DefaultCellStyle.ForeColor = Color.Empty
                Next

                ' Apply conditional formatting at the cell level
                For Each row As DataGridViewRow In WIP_Form.DataGridView1.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        Dim cellValue As Decimal
                        ' Check if the cell value is numeric and negative
                        If Decimal.TryParse(cell.Value?.ToString(), cellValue) AndAlso cellValue < 0 Then
                            cell.Style.BackColor = Color.Red
                            cell.Style.ForeColor = Color.White
                        Else
                            ' Reset to default style for non-negative or non-numeric values
                            cell.Style.BackColor = Color.Empty
                            cell.Style.ForeColor = Color.Empty
                        End If
                    Next
                Next

                ' Style the DataGridView
                WIP_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                WIP_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
                WIP_Form.DataGridView1.EnableHeadersVisualStyles = False
                WIP_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

            Catch ex As Exception
                ' Handle any exceptions
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Always close the connection
                ConClose()
            End Try
        Else
            MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    'Sub Load_Avail_WIP()
    '    Dim command As New SqlCommand("", Dbconnection)
    '    Dim table As New DataTable

    '    ConOpen()

    '    If Dbconnection.State = ConnectionState.Open Then
    '        Try
    '            ' Determine the date range for reset logic
    '            Dim startDate As DateTime
    '            Dim endDate As DateTime
    '            Dim now As DateTime = DateTime.Now
    '            Dim conditionAfter6AM As Boolean = now.TimeOfDay >= TimeSpan.FromHours(6)

    '            If conditionAfter6AM Then
    '                ' After 6:00 AM: current day's 6:00 AM to next day's 6:00 AM
    '                startDate = now.Date.AddHours(6)
    '                endDate = now.Date.AddDays(1).AddHours(6)
    '            Else
    '                ' Before or at 6:00 AM: previous day's 6:00 AM to today's 6:00 AM
    '                startDate = now.Date.AddDays(-1).AddHours(6)
    '                endDate = now.Date.AddHours(6)
    '            End If

    '            ' Check if Target_WIP reset is required
    '            Dim resetCheckCmd As New SqlCommand("SELECT COUNT(*) FROM Reset_Log WHERE Reset_Date = @ResetDate", Dbconnection)
    '            resetCheckCmd.Parameters.AddWithValue("@ResetDate", startDate.Date)
    '            Dim resetPerformed As Integer = CInt(resetCheckCmd.ExecuteScalar())

    '            If resetPerformed = 0 Then
    '                ' Step 1: Reset SAM_Out and Target_WIP for all rows
    '                Dim resetCmd As New SqlCommand("UPDATE WIPM_Process_tb SET [Sput_Out] = 0, [Target_WIP] = 0", Dbconnection)
    '                resetCmd.ExecuteNonQuery()

    '                ' Step 2: Distribute GAP values
    '                Dim selectProductsCmd As New SqlCommand("SELECT DISTINCT [Product] FROM WIPM_Process_tb WHERE [GAP] <> 0", Dbconnection)
    '                Using productReader As SqlDataReader = selectProductsCmd.ExecuteReader()
    '                    While productReader.Read()
    '                        Dim productName As String = productReader("Product").ToString()

    '                        ' Get the first row for the current product with non-zero GAP
    '                        Dim selectGapCmd As New SqlCommand("SELECT TOP 1 [ID], [GAP] FROM WIPM_Process_tb WHERE [Product] = @Product AND [GAP] <> 0", Dbconnection)
    '                        selectGapCmd.Parameters.AddWithValue("@Product", productName)

    '                        Using gapReader As SqlDataReader = selectGapCmd.ExecuteReader()
    '                            If gapReader.Read() Then
    '                                Dim selectedID As Integer = CInt(gapReader("ID"))
    '                                Dim gapValue As Integer = CInt(gapReader("GAP"))

    '                                ' Update SAM_Out for the selected row
    '                                Dim updateSamOutCmd As New SqlCommand("UPDATE WIPM_Process_tb SET [Sput_Out] = @Gap WHERE [ID] = @ID", Dbconnection)
    '                                updateSamOutCmd.Parameters.AddWithValue("@Gap", gapValue)
    '                                updateSamOutCmd.Parameters.AddWithValue("@ID", selectedID)

    '                                updateSamOutCmd.ExecuteNonQuery()
    '                            End If
    '                        End Using
    '                    End While
    '                End Using

    '                ' Notify success
    '                'MessageBox.Show("SAM_Out and Target_WIP have been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


    '                ' Log the reset in the Reset_Log table
    '                Dim logResetCmd As New SqlCommand("INSERT INTO Reset_Log (Reset_Date) VALUES (@ResetDate)", Dbconnection)
    '                logResetCmd.Parameters.AddWithValue("@ResetDate", startDate.Date)
    '                logResetCmd.ExecuteNonQuery()
    '            End If

    '            ' Load all data from the database (no date filter here)
    '            command.Connection = Dbconnection
    '            command.CommandText = "SELECT Product, SUM(PP_Out) AS PP_OUT, SUM(Vib_Out) AS VIB_OUT, " &
    '                              "SUM(LW_Out) AS LW_OUT, SUM(Annealing_Out) AS ANN_OUT, " &
    '                              "SUM(Sput_Out) AS SPUT_OUT, " &
    '                              "MAX(Target_WIP) AS Target_WIP, MAX(GAP) AS GAP " &
    '                              "FROM WIPM_Process_tb " &
    '                              "GROUP BY Product"

    '            ' Execute the query and load the results into the DataTable
    '            Using rdr As SqlDataReader = command.ExecuteReader()
    '                table.Load(rdr)
    '            End Using

    '            ' Bind the DataTable to the DataGridView
    '            WIP_Form.DataGridView1.DataSource = table

    '            ' Format DataGridView columns
    '            For Each column As DataGridViewColumn In WIP_Form.DataGridView1.Columns
    '                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
    '                column.HeaderCell.Style.ForeColor = Color.White
    '                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 10)
    '            Next

    '            ' Rename column headers for clarity
    '            WIP_Form.DataGridView1.Columns("Product").HeaderText = "Product Name"
    '            WIP_Form.DataGridView1.Columns("PP_OUT").HeaderText = "Punch Press Out"
    '            WIP_Form.DataGridView1.Columns("VIB_OUT").HeaderText = "Vibrator Out"
    '            WIP_Form.DataGridView1.Columns("LW_OUT").HeaderText = "Load and Wash Out"
    '            WIP_Form.DataGridView1.Columns("ANN_OUT").HeaderText = "Annealing Out"
    '            WIP_Form.DataGridView1.Columns("SPUT_OUT").HeaderText = "Sput Out"
    '            WIP_Form.DataGridView1.Columns("Target_WIP").HeaderText = "Target"

    '            ' Apply conditional formatting at the cell level
    '            For Each row As DataGridViewRow In WIP_Form.DataGridView1.Rows
    '                For Each cell As DataGridViewCell In row.Cells
    '                    Dim cellValue As Decimal
    '                    ' Check if the cell value is numeric and negative
    '                    If Decimal.TryParse(cell.Value?.ToString(), cellValue) AndAlso cellValue < 0 Then
    '                        cell.Style.BackColor = Color.Red
    '                        cell.Style.ForeColor = Color.White
    '                    Else
    '                        ' Reset to default style for non-negative or non-numeric values
    '                        cell.Style.BackColor = Color.Empty
    '                        cell.Style.ForeColor = Color.Empty
    '                    End If
    '                Next
    '            Next

    '            ' Style the DataGridView
    '            WIP_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
    '            WIP_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
    '            WIP_Form.DataGridView1.EnableHeadersVisualStyles = False
    '            WIP_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

    '        Catch ex As Exception
    '            ' Handle any exceptions
    '            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Finally
    '            ' Always close the connection
    '            ConClose()
    '        End Try
    '    Else
    '        MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub

    Sub SAM_sub_Gap()
        Dim command As New SqlCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            Try
                ' Step 1: Load the original data with SUM(Sput_Out) and MAX(GAP) grouped by product
                command.Connection = Dbconnection
                command.CommandText = "SELECT Product, SUM(Sput_Out) AS Total_Sput_Out, MAX(Target_WIP) AS Target " &
                                  "FROM WIPM_Process_tb " &
                                  "GROUP BY Product"

                ' Execute the query and load the results into the DataTable
                Using rdr As SqlDataReader = command.ExecuteReader()
                    table.Load(rdr)
                End Using

                ' Step 2: Update GAP for each row using the original SUM(Sput_Out) and MAX(GAP)
                For Each row As DataRow In table.Rows
                    Dim product As String = row("Product").ToString()
                    Dim totalSamOut As Integer = CInt(row("Total_Sput_Out"))
                    Dim maxGap As Integer = CInt(row("Target"))

                    ' Calculate the new GAP as SUM(Sput_Out) - MAX(GAP)
                    Dim newGap As Integer = totalSamOut - maxGap

                    ' Step 3: Update only the rows for the current product
                    ' Note: Reset GAP to the newly calculated value
                    Dim updateCmd As New SqlCommand("UPDATE WIPM_Process_tb " &
                                                  "SET GAP = @NewGap " &
                                                  "WHERE Product = @prod", Dbconnection)
                    updateCmd.Parameters.AddWithValue("@NewGap", newGap)
                    updateCmd.Parameters.AddWithValue("@prod", product)

                    updateCmd.ExecuteNonQuery()
                Next

                ' Notify success (optional)
                ' MessageBox.Show("GAP values have been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                ' Handle any exceptions
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Always close the connection
                ConClose()
            End Try
        Else
            MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public SAM_tOUT As Integer

    Sub Populate_WIP()
        Try
            Dim mydata As String
            Dim command As New SqlCommand
            Dim data As New DataTable
            Dim adap As New SqlDataAdapter
            Dim val As String

            ConOpen()

            val = WIP_Form.DataGridView1.SelectedCells.Item(0).Value.ToString()

            mydata = "SELECT Product, SUM(SAM_Out) AS SAM_OUT
                      From WIPM_Process_tb
                      WHERE Product = '" & val & "' GROUP BY Product"

            '"SELECT * From WIPM_Process_tb WHERE Product = '" & val & "'"

            '"SELECT Product, SUM(SAM_Out) AS SAM_OUT
            'From WIPM_Process_tb
            'Where Product = '" & val & "' GROUP BY Product"

            command.Connection = Dbconnection
            command.CommandText = mydata
            adap.SelectCommand = command

            adap.Fill(data)

            If data.Rows.Count > 0 Then

                WIP_Form.lblProdName.Text = data.Rows(0).Item("Product").ToString
                SAM_tOUT = CInt(data.Rows(0).Item("SAM_OUT").ToString)

                Console.WriteLine(SAM_tOUT)

            End If
        Catch ex As Exception

        Finally
            ConClose()
        End Try
    End Sub

    Public No_SUM As Boolean
    Sub Populate_WIP_noSUM()
        Try
            Dim mydata As String
            Dim command As New SqlCommand
            Dim data As New DataTable
            Dim adap As New SqlDataAdapter
            Dim val As String

            ConOpen()

            val = WIP_Form.DataGridView1.SelectedCells.Item(0).Value.ToString()

            mydata = "SELECT Product, SUM(SAM_Out) AS SAM_OUT
                      From WIPM_Process_tb
                      WHERE DateTime BETWEEN @StartDate AND @EndDate 
                      And Product = '" & val & "' GROUP BY Product"


            Dim startDate As DateTime = WIP_Form.dtpStartDate.Value.Date
            Dim endDate As DateTime = WIP_Form.dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1) ' Include the entire end date

            command.Parameters.AddWithValue("@StartDate", startDate)
            command.Parameters.AddWithValue("@EndDate", endDate)

            command.Connection = Dbconnection
            command.CommandText = mydata
            adap.SelectCommand = command

            adap.Fill(data)

            If data.Rows.Count > 0 Then

                WIP_Form.lblProdName.Text = data.Rows(0).Item("Product").ToString
                SAM_tOUT = CInt(data.Rows(0).Item("SAM_OUT").ToString)

                Console.WriteLine(SAM_tOUT)

            End If
        Catch ex As Exception

        Finally
            ConClose()
        End Try
    End Sub


    Sub Load_WIP_BaseStartEnd()
        Dim command As New SqlCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            Try
                command.Connection = Dbconnection
                command.CommandText = "Select Product, SUM(PP_Out) As PP_OUT, SUM(Vib_Out) As VIB_OUT, " &
                                      "SUM(LW_Out) As LW_OUT, SUM(Annealing_Out) As ANN_OUT, " &
                                      "SUM(Wash_Out) As W_OUT, SUM(Sput_Out) As SPUT_OUT, SUM(SAM_OUT) As SAM_OUT, MAX(Target_WIP) AS Target_WIP, MAX(GAP) AS GAP " &
                                      "FROM WIPM_Process_tb " &
                                      "WHERE DateTime BETWEEN @StartDate AND @EndDate GROUP BY Product"

                Dim startDate As DateTime = WIP_Form.dtpStartDate.Value.Date
                Dim endDate As DateTime = WIP_Form.dtpEndDate.Value.Date.AddDays(1)
                command.Parameters.AddWithValue("@StartDate", startDate)
                command.Parameters.AddWithValue("@EndDate", endDate)

                Using rdr As SqlDataReader = command.ExecuteReader()
                    table.Load(rdr)
                End Using

                ' After binding the DataTable to the DataGridView
                WIP_Form.DataGridView1.DataSource = table

                ' Format DataGridView columns
                For Each column As DataGridViewColumn In WIP_Form.DataGridView1.Columns
                    column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                    column.HeaderCell.Style.ForeColor = Color.White
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 10)
                Next

                ' Rename column headers for clarity
                WIP_Form.DataGridView1.Columns("Product").HeaderText = "Product Name"
                WIP_Form.DataGridView1.Columns("PP_OUT").HeaderText = "Punch Press Out"
                WIP_Form.DataGridView1.Columns("VIB_OUT").HeaderText = "Vibrator Out"
                WIP_Form.DataGridView1.Columns("LW_OUT").HeaderText = "Load and Wash Out"
                WIP_Form.DataGridView1.Columns("ANN_OUT").HeaderText = "Annealing Out"
                WIP_Form.DataGridView1.Columns("W_OUT").HeaderText = "Wash Out"
                WIP_Form.DataGridView1.Columns("SPUT_OUT").HeaderText = "Sput Out"
                WIP_Form.DataGridView1.Columns("SAM_OUT").HeaderText = "SAM Out"
                WIP_Form.DataGridView1.Columns("Target_WIP").HeaderText = "Target"

                ' Apply conditional formatting for negative GAP values
                For Each row As DataGridViewRow In WIP_Form.DataGridView1.Rows
                    Dim gapValue As Decimal
                    If Decimal.TryParse(row.Cells("GAP").Value?.ToString(), gapValue) AndAlso gapValue < 0 Then
                        row.DefaultCellStyle.BackColor = Color.Red
                        row.DefaultCellStyle.ForeColor = Color.White
                    End If
                Next

                ' Style the DataGridView
                WIP_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                WIP_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
                WIP_Form.DataGridView1.EnableHeadersVisualStyles = False
                WIP_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ConClose()
            End Try
        Else
            MessageBox.Show("Failed to open database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Sub Update_Target()

        Try

            Dim Prod As String = WIP_Form.lblProdName.Text
            Dim Target As String = CInt(WIP_Form.txtTarget.Text)

            Dim T_GAP As Integer = SAM_tOUT - Target


            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET Target_WIP = @product, GAP = @gap 
                                WHERE Product = @Prod"

            Using command As New SqlCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Trgt", Target)
                command.Parameters.AddWithValue("@gap", T_GAP)
                command.Parameters.AddWithValue("@product", Prod)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    '**************************** < FOR ViewData_Form > ****************************
    Sub Load_ViewAll()
        Dim command As New SqlCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            command.Connection = Dbconnection
            command.CommandText = "SELECT Product,SAM_Out, DateTime
                                    FROM WIPM_Process_tb ORDER BY DateTime"

            Dim rdr As SqlDataReader = command.ExecuteReader

            table.Load(rdr)

            ViewData_Form.DataGridView1.DataSource = table

            ' Bold the header cells
            For Each column As DataGridViewColumn In ViewData_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 10)
            Next

            ViewData_Form.DataGridView1.Columns("Product").HeaderText = "Product Name"
            ViewData_Form.DataGridView1.Columns("SAM_Out").HeaderText = "SAM Out"
            ViewData_Form.DataGridView1.Columns("DateTime").HeaderText = "Date and Time"

            'WIP_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(116, 185, 255)
            ViewData_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
            ViewData_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

            ViewData_Form.DataGridView1.EnableHeadersVisualStyles = False
            ViewData_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

        End If

        ConClose()
    End Sub

    Sub Load_ViewAll_BaseStartEnd()
        Dim command As New SqlCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            command.Connection = Dbconnection
            command.CommandText = "SELECT Product, SAM_Out, DateTime
                               FROM WIPM_Process_tb
                               WHERE DateTime BETWEEN @StartDate AND @EndDate ORDER BY DateTime"


            Dim startDate As DateTime = ViewData_Form.dtpStartDate.Value.Date
            Dim endDate As DateTime = ViewData_Form.dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1) ' Include the entire end date

            command.Parameters.AddWithValue("@StartDate", startDate)
            command.Parameters.AddWithValue("@EndDate", endDate)

            Dim rdr As SqlDataReader = command.ExecuteReader

            table.Load(rdr)

            ViewData_Form.DataGridView1.DataSource = table

            ' Format DataGridView headers and styles
            For Each column As DataGridViewColumn In ViewData_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 10)
            Next

            ViewData_Form.DataGridView1.Columns("Product").HeaderText = "Product Name"
            ViewData_Form.DataGridView1.Columns("SAM_Out").HeaderText = "SAM Out"

            'WIP_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(116, 185, 255)
            ViewData_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
            ViewData_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

            ViewData_Form.DataGridView1.EnableHeadersVisualStyles = False
            ViewData_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)
        End If

        ConClose()
    End Sub


    '**************************** < FOR UpdateWIP_Form > ****************************

    Sub UpdateWIP_Load()
        Dim command As New SqlCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            Try
                command.Connection = Dbconnection
                command.CommandText = "SELECT Product, MAX(Target_WIP) AS Target_WIP " &
                              "FROM WIPM_Process_tb GROUP BY Product"

                Using rdr As SqlDataReader = command.ExecuteReader()
                    table.Load(rdr)
                End Using

                ' After binding the DataTable to the DataGridView
                UpdateWIP_Form.DataGridView1.DataSource = table

                ' Format DataGridView columns
                For Each column As DataGridViewColumn In UpdateWIP_Form.DataGridView1.Columns
                    column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                    column.HeaderCell.Style.ForeColor = Color.White
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 10)
                Next

                ' Rename column headers for clarity
                'UpdateWIP_Form.DataGridView1.Columns("Product").ReadOnly = True
                UpdateWIP_Form.DataGridView1.Columns("Product").HeaderText = "Product Name"

                'UpdateWIP_Form.DataGridView1.Columns("Target_WIP").ReadOnly = False
                UpdateWIP_Form.DataGridView1.Columns("Target_WIP").HeaderText = "Target"

                ' Clear row styles to prevent conflicts
                For Each row As DataGridViewRow In UpdateWIP_Form.DataGridView1.Rows
                    row.DefaultCellStyle.BackColor = Color.Empty
                    row.DefaultCellStyle.ForeColor = Color.Empty
                Next

                ' Apply conditional formatting at the cell level
                For Each row As DataGridViewRow In UpdateWIP_Form.DataGridView1.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        Dim cellValue As Decimal
                        ' Check if the cell value is numeric and negative
                        If Decimal.TryParse(cell.Value?.ToString(), cellValue) AndAlso cellValue < 0 Then
                            cell.Style.BackColor = Color.Red
                            cell.Style.ForeColor = Color.White
                        Else
                            ' Reset to default style for non-negative or non-numeric values
                            cell.Style.BackColor = Color.Empty
                            cell.Style.ForeColor = Color.Empty
                        End If
                    Next
                Next

                ' Style the DataGridView
                UpdateWIP_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                UpdateWIP_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                UpdateWIP_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
                UpdateWIP_Form.DataGridView1.EnableHeadersVisualStyles = False
                UpdateWIP_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

            Catch ex As Exception
                ' Handle any exceptions
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Always close the connection
                ConClose()
            End Try
        Else
            MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Sub UpdateWIP_Populate()
        Try
            Dim mydata As String
            Dim command As New SqlCommand
            Dim data As New DataTable
            Dim adap As New SqlDataAdapter
            Dim val As String

            ConOpen()

            val = UpdateWIP_Form.DataGridView1.SelectedCells.Item(0).Value.ToString()

            mydata = "SELECT Product, SUM(SAM_Out) AS SAM_OUT
                      From WIPM_Process_tb
                      WHERE Product = '" & val & "' GROUP BY Product"

            command.Connection = Dbconnection
            command.CommandText = mydata
            adap.SelectCommand = command

            adap.Fill(data)

            If data.Rows.Count > 0 Then

                UpdateWIP_Form.lblProdName.Text = data.Rows(0).Item("Product").ToString
                SAM_tOUT = CInt(data.Rows(0).Item("SAM_OUT").ToString)

                Console.WriteLine(SAM_tOUT)

            End If
        Catch ex As Exception

        Finally
            ConClose()
        End Try
    End Sub

    Sub UpdateWIP_Update_Target()

        Try

            Dim Prod As String = UpdateWIP_Form.lblProdName.Text
            Dim Target As String = CInt(UpdateWIP_Form.txtTarget.Text)

            Dim T_GAP As Integer = SAM_tOUT - Target


            Dim query As String = "UPDATE WIPM_Process_tb 
                               SET Target_WIP = @Trgt, GAP = @gap 
                               WHERE Product = @product"

            Using command As New SqlCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Trgt", Target)
                command.Parameters.AddWithValue("@gap", T_GAP)
                command.Parameters.AddWithValue("@product", Prod)

                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

            MsgBox("Target WIP for " & UpdateWIP_Form.lblProdName.Text & " is updated!")
            UpdateWIP_Form.txtTarget.Clear()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    'Sub UpdateAll()

    '    ConOpen()

    '    For Each row As DataGridViewRow In UpdateWIP_Form.DataGridView1.Rows
    '        ' Ensure the row is not a new row
    '        If Not row.IsNewRow Then
    '            ' Extract the values from the DataGridView
    '            Dim product As String = row.Cells("Product").Value.ToString()
    '            Dim targetWIP As String = row.Cells("Target_WIP").Value.ToString()

    '            ' Define the UPDATE query
    '            Dim query As String = "UPDATE WIPM_Process_tb SET Target_WIP = @TargetWIP WHERE Product = @Product"

    '            ' Create an SqlCommand and add parameters
    '            Using command As New SqlCommand(query, Dbconnection)
    '                command.Parameters.AddWithValue("@TargetWIP", targetWIP)
    '                command.Parameters.AddWithValue("@Product", product)

    '                ' Execute the command
    '                Try
    '                    command.ExecuteNonQuery()
    '                Catch ex As Exception
    '                    MessageBox.Show($"Error updating Product '{product}': {ex.Message}")
    '                End Try
    '            End Using
    '        End If
    '    Next
    '    ConClose()
    '    MessageBox.Show("Target WIP is now updated.")
    'End Sub

    Sub UpdateAll()
        If UpdateWIP_Form.DataGridView1.DataSource Is Nothing Then
            MessageBox.Show("No data available to update.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            Try
                For Each row As DataGridViewRow In UpdateWIP_Form.DataGridView1.Rows
                    If Not row.IsNewRow Then
                        Dim id As Integer
                        Dim targetWIPValue As Decimal

                        ' Get ID and Target_WIP safely
                        If Integer.TryParse(row.Cells("ID").Value?.ToString(), id) AndAlso
                       Decimal.TryParse(row.Cells("Target_WIP").Value?.ToString(), targetWIPValue) Then

                            Using cmd As New SqlCommand("UPDATE WIPM_Process_tb SET Target_WIP = @TargetWIP WHERE ID = @ID", Dbconnection)
                                cmd.Parameters.AddWithValue("@TargetWIP", targetWIPValue)
                                cmd.Parameters.AddWithValue("@ID", id)
                                cmd.ExecuteNonQuery()
                            End Using
                        End If
                    End If
                Next

                MessageBox.Show("All records successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error updating records: " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ConClose()
            End Try
        Else
            MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    '============================= < FOR WIP AUTO FETCH DATA > ============================

    Sub Insert_PUNCHPRESS()
        Try
            MES_ConOpen()
            QA_ConOpen()
            ConOpen()

            Dim today As String = DateTime.Now.ToString("yyyy-MM-dd")

            ' STEP 1: Load existing WIPM records for today
            Dim existingQuery As String = "
            SELECT ProductionLotNumber, TrackOutTime 
            FROM WIPM_Data_tb 
            WHERE CONVERT(date, TrackOutTime) = @TodayDate"
            Dim existingCmd As New SqlCommand(existingQuery, Dbconnection)
            existingCmd.Parameters.AddWithValue("@TodayDate", today)

            Dim existingSet As New HashSet(Of String)
            Using reader = existingCmd.ExecuteReader()
                While reader.Read()
                    Dim key = reader("ProductionLotNumber").ToString() & "|" & Convert.ToDateTime(reader("TrackOutTime")).ToString("s")
                    existingSet.Add(key)
                End While
            End Using

            ' STEP 2: Load all deburr data for today
            Dim deburrQuery As String = "
            SELECT ProductionLotNumber, EQPDescription, TrackOutTime 
            FROM [stMES_cut&form] 
            WHERE CONVERT(date, TrackOutTime) = @TodayDate"
            Dim deburrCmd As New SqlCommand(deburrQuery, MES_Dbconnection)
            deburrCmd.Parameters.AddWithValue("@TodayDate", today)

            Dim deburrList As New List(Of Dictionary(Of String, Object))
            Using reader = deburrCmd.ExecuteReader()
                While reader.Read()
                    Dim row As New Dictionary(Of String, Object)
                    row("ProductionLotNumber") = reader("ProductionLotNumber")
                    row("EQPDescription") = reader("EQPDescription")
                    row("TrackOutTime") = Convert.ToDateTime(reader("TrackOutTime"))
                    deburrList.Add(row)
                End While
            End Using

            ' STEP 3: Prepare one command for inserting
            Dim insertQuery As String = "
            INSERT INTO WIPM_Data_tb 
            (NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode) 
            VALUES (@NMR, @ProductionLotNumber, @EQPDescription, @TrackOutTime, @ReedType, @Qty, @Description, @LotCode)"
            Dim insertCmd As New SqlCommand(insertQuery, Dbconnection)

            For Each row In deburrList
                Dim lotNum As String = row("ProductionLotNumber").ToString()
                Dim trackOut As DateTime = CType(row("TrackOutTime"), DateTime)
                Dim key = lotNum & "|" & trackOut.ToString("s")

                If existingSet.Contains(key) Then Continue For

                ' STEP 4: Load SLR data for the LotNum
                Dim slrQuery As String = "SELECT TOP 1 * FROM Component_SLR WHERE LotN = @LotN"
                Dim slrCmd As New SqlCommand(slrQuery, QA_Dbconnection)
                slrCmd.Parameters.AddWithValue("@LotN", lotNum)

                Using slrReader = slrCmd.ExecuteReader()
                    If slrReader.Read() Then
                        insertCmd.Parameters.Clear()
                        insertCmd.Parameters.AddWithValue("@NMR", 0)
                        insertCmd.Parameters.AddWithValue("@ProductionLotNumber", lotNum)
                        insertCmd.Parameters.AddWithValue("@EQPDescription", row("EQPDescription").ToString())
                        insertCmd.Parameters.AddWithValue("@TrackOutTime", trackOut)
                        insertCmd.Parameters.AddWithValue("@ReedType", slrReader("ReedType"))
                        insertCmd.Parameters.AddWithValue("@Qty", slrReader("Qty"))
                        insertCmd.Parameters.AddWithValue("@Description", slrReader("Description"))
                        insertCmd.Parameters.AddWithValue("@LotCode", slrReader("LotCode"))
                        insertCmd.ExecuteNonQuery()
                    End If
                End Using
            Next

            MsgBox("Optimized insert complete (duplicates skipped).")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            ConClose()
            MES_ConClose()
            QA_ConClose()
        End Try
    End Sub

    Sub Insert_PUNCHPRESS_Yesterday()
        Try
            MES_ConOpen()
            QA_ConOpen()
            ConOpen()

            ' Get yesterday's date
            Dim yesterday As String = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd")

            ' STEP 1: Load existing WIPM records for yesterday
            Dim existingQuery As String = "
            SELECT ProductionLotNumber, TrackOutTime 
            FROM WIPM_Data_tb 
            WHERE CONVERT(date, TrackOutTime) = @DateParam"
            Dim existingCmd As New SqlCommand(existingQuery, Dbconnection)
            existingCmd.Parameters.AddWithValue("@DateParam", yesterday)

            Dim existingSet As New HashSet(Of String)
            Using reader = existingCmd.ExecuteReader()
                While reader.Read()
                    Dim key = reader("ProductionLotNumber").ToString() & "|" & Convert.ToDateTime(reader("TrackOutTime")).ToString("s")
                    existingSet.Add(key)
                End While
            End Using

            ' STEP 2: Load all deburr data for yesterday
            Dim deburrQuery As String = "
            SELECT ProductionLotNumber, EQPDescription, TrackOutTime 
            FROM [stMES_cut&form] 
            WHERE CONVERT(date, TrackOutTime) = @DateParam"
            Dim deburrCmd As New SqlCommand(deburrQuery, MES_Dbconnection)
            deburrCmd.Parameters.AddWithValue("@DateParam", yesterday)

            Dim deburrList As New List(Of Dictionary(Of String, Object))
            Using reader = deburrCmd.ExecuteReader()
                While reader.Read()
                    Dim row As New Dictionary(Of String, Object)
                    row("ProductionLotNumber") = reader("ProductionLotNumber")
                    row("EQPDescription") = reader("EQPDescription")
                    row("TrackOutTime") = Convert.ToDateTime(reader("TrackOutTime"))
                    deburrList.Add(row)
                End While
            End Using

            ' STEP 3: Prepare one command for inserting
            Dim insertQuery As String = "
            INSERT INTO WIPM_Data_tb 
            (NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode) 
            VALUES (@NMR, @ProductionLotNumber, @EQPDescription, @TrackOutTime, @ReedType, @Qty, @Description, @LotCode)"
            Dim insertCmd As New SqlCommand(insertQuery, Dbconnection)

            For Each row In deburrList
                Dim lotNum As String = row("ProductionLotNumber").ToString()
                Dim trackOut As DateTime = CType(row("TrackOutTime"), DateTime)
                Dim key = lotNum & "|" & trackOut.ToString("s")

                If existingSet.Contains(key) Then Continue For

                ' STEP 4: Load SLR data for the LotNum
                Dim slrQuery As String = "SELECT TOP 1 * FROM Component_SLR WHERE LotN = @LotN"
                Dim slrCmd As New SqlCommand(slrQuery, QA_Dbconnection)
                slrCmd.Parameters.AddWithValue("@LotN", lotNum)

                Using slrReader = slrCmd.ExecuteReader()
                    If slrReader.Read() Then
                        insertCmd.Parameters.Clear()
                        insertCmd.Parameters.AddWithValue("@NMR", 0)
                        insertCmd.Parameters.AddWithValue("@ProductionLotNumber", lotNum)
                        insertCmd.Parameters.AddWithValue("@EQPDescription", row("EQPDescription").ToString())
                        insertCmd.Parameters.AddWithValue("@TrackOutTime", trackOut)
                        insertCmd.Parameters.AddWithValue("@ReedType", slrReader("ReedType"))
                        insertCmd.Parameters.AddWithValue("@Qty", slrReader("Qty"))
                        insertCmd.Parameters.AddWithValue("@Description", slrReader("Description"))
                        insertCmd.Parameters.AddWithValue("@LotCode", slrReader("LotCode"))
                        insertCmd.ExecuteNonQuery()
                    End If
                End Using
            Next

            MsgBox("Optimized insert complete (duplicates skipped).")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            ConClose()
            MES_ConClose()
            QA_ConClose()
        End Try
    End Sub

    Sub Insert_DEBUR()
        Try
            MES_ConOpen()
            QA_ConOpen()
            ConOpen()

            Dim today As String = DateTime.Now.ToString("yyyy-MM-dd")

            ' STEP 1: Load existing WIPM records for today
            Dim existingQuery As String = "
            SELECT ProductionLotNumber, TrackOutTime 
            FROM WIPM_Data_tb 
            WHERE CONVERT(date, TrackOutTime) = @TodayDate"
            Dim existingCmd As New SqlCommand(existingQuery, Dbconnection)
            existingCmd.Parameters.AddWithValue("@TodayDate", today)

            Dim existingSet As New HashSet(Of String)
            Using reader = existingCmd.ExecuteReader()
                While reader.Read()
                    Dim key = reader("ProductionLotNumber").ToString() & "|" & Convert.ToDateTime(reader("TrackOutTime")).ToString("s")
                    existingSet.Add(key)
                End While
            End Using

            ' STEP 2: Load all deburr data for today
            Dim deburrQuery As String = "
            SELECT ProductionLotNumber, EQPDescription, TrackOutTime 
            FROM stMES_deburr 
            WHERE CONVERT(date, TrackOutTime) = @TodayDate"
            Dim deburrCmd As New SqlCommand(deburrQuery, MES_Dbconnection)
            deburrCmd.Parameters.AddWithValue("@TodayDate", today)

            Dim deburrList As New List(Of Dictionary(Of String, Object))
            Using reader = deburrCmd.ExecuteReader()
                While reader.Read()
                    Dim row As New Dictionary(Of String, Object)
                    row("ProductionLotNumber") = reader("ProductionLotNumber")
                    row("EQPDescription") = reader("EQPDescription")
                    row("TrackOutTime") = Convert.ToDateTime(reader("TrackOutTime"))
                    deburrList.Add(row)
                End While
            End Using

            ' STEP 3: Prepare one command for inserting
            Dim insertQuery As String = "
            INSERT INTO WIPM_Data_tb 
            (NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode) 
            VALUES (@NMR, @ProductionLotNumber, @EQPDescription, @TrackOutTime, @ReedType, @Qty, @Description, @LotCode)"
            Dim insertCmd As New SqlCommand(insertQuery, Dbconnection)

            For Each row In deburrList
                Dim lotNum As String = row("ProductionLotNumber").ToString()
                Dim trackOut As DateTime = CType(row("TrackOutTime"), DateTime)
                Dim key = lotNum & "|" & trackOut.ToString("s")

                If existingSet.Contains(key) Then Continue For

                ' STEP 4: Load SLR data for the LotNum
                Dim slrQuery As String = "SELECT TOP 1 * FROM Component_SLR WHERE LotN = @LotN"
                Dim slrCmd As New SqlCommand(slrQuery, QA_Dbconnection)
                slrCmd.Parameters.AddWithValue("@LotN", lotNum)

                Using slrReader = slrCmd.ExecuteReader()
                    If slrReader.Read() Then
                        insertCmd.Parameters.Clear()
                        insertCmd.Parameters.AddWithValue("@NMR", 0)
                        insertCmd.Parameters.AddWithValue("@ProductionLotNumber", lotNum)
                        insertCmd.Parameters.AddWithValue("@EQPDescription", row("EQPDescription").ToString())
                        insertCmd.Parameters.AddWithValue("@TrackOutTime", trackOut)
                        insertCmd.Parameters.AddWithValue("@ReedType", slrReader("ReedType"))
                        insertCmd.Parameters.AddWithValue("@Qty", slrReader("Qty"))
                        insertCmd.Parameters.AddWithValue("@Description", slrReader("Description"))
                        insertCmd.Parameters.AddWithValue("@LotCode", slrReader("LotCode"))
                        insertCmd.ExecuteNonQuery()
                    End If
                End Using
            Next

            MsgBox("Optimized insert complete (duplicates skipped).")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            ConClose()
            MES_ConClose()
            QA_ConClose()
        End Try
    End Sub

    Sub Insert_DEBUR_Yesterday()
        Try
            MES_ConOpen()
            QA_ConOpen()
            ConOpen()

            ' Get yesterday's date
            Dim yesterday As String = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd")

            ' STEP 1: Load existing WIPM records for yesterday
            Dim existingQuery As String = "
            SELECT ProductionLotNumber, TrackOutTime 
            FROM WIPM_Data_tb 
            WHERE CONVERT(date, TrackOutTime) = @DateParam"
            Dim existingCmd As New SqlCommand(existingQuery, Dbconnection)
            existingCmd.Parameters.AddWithValue("@DateParam", yesterday)

            Dim existingSet As New HashSet(Of String)
            Using reader = existingCmd.ExecuteReader()
                While reader.Read()
                    Dim key = reader("ProductionLotNumber").ToString() & "|" & Convert.ToDateTime(reader("TrackOutTime")).ToString("s")
                    existingSet.Add(key)
                End While
            End Using

            ' STEP 2: Load all deburr data for yesterday
            Dim deburrQuery As String = "
            SELECT ProductionLotNumber, EQPDescription, TrackOutTime 
            FROM stMES_deburr 
            WHERE CONVERT(date, TrackOutTime) = @DateParam"
            Dim deburrCmd As New SqlCommand(deburrQuery, MES_Dbconnection)
            deburrCmd.Parameters.AddWithValue("@DateParam", yesterday)

            Dim deburrList As New List(Of Dictionary(Of String, Object))
            Using reader = deburrCmd.ExecuteReader()
                While reader.Read()
                    Dim row As New Dictionary(Of String, Object)
                    row("ProductionLotNumber") = reader("ProductionLotNumber")
                    row("EQPDescription") = reader("EQPDescription")
                    row("TrackOutTime") = Convert.ToDateTime(reader("TrackOutTime"))
                    deburrList.Add(row)
                End While
            End Using

            ' STEP 3: Prepare one command for inserting
            Dim insertQuery As String = "
            INSERT INTO WIPM_Data_tb 
            (NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode) 
            VALUES (@NMR, @ProductionLotNumber, @EQPDescription, @TrackOutTime, @ReedType, @Qty, @Description, @LotCode)"
            Dim insertCmd As New SqlCommand(insertQuery, Dbconnection)

            For Each row In deburrList
                Dim lotNum As String = row("ProductionLotNumber").ToString()
                Dim trackOut As DateTime = CType(row("TrackOutTime"), DateTime)
                Dim key = lotNum & "|" & trackOut.ToString("s")

                If existingSet.Contains(key) Then Continue For

                ' STEP 4: Load SLR data for the LotNum
                Dim slrQuery As String = "SELECT TOP 1 * FROM Component_SLR WHERE LotN = @LotN"
                Dim slrCmd As New SqlCommand(slrQuery, QA_Dbconnection)
                slrCmd.Parameters.AddWithValue("@LotN", lotNum)

                Using slrReader = slrCmd.ExecuteReader()
                    If slrReader.Read() Then
                        insertCmd.Parameters.Clear()
                        insertCmd.Parameters.AddWithValue("@NMR", 0)
                        insertCmd.Parameters.AddWithValue("@ProductionLotNumber", lotNum)
                        insertCmd.Parameters.AddWithValue("@EQPDescription", row("EQPDescription").ToString())
                        insertCmd.Parameters.AddWithValue("@TrackOutTime", trackOut)
                        insertCmd.Parameters.AddWithValue("@ReedType", slrReader("ReedType"))
                        insertCmd.Parameters.AddWithValue("@Qty", slrReader("Qty"))
                        insertCmd.Parameters.AddWithValue("@Description", slrReader("Description"))
                        insertCmd.Parameters.AddWithValue("@LotCode", slrReader("LotCode"))
                        insertCmd.ExecuteNonQuery()
                    End If
                End Using
            Next

            MsgBox("Optimized insert complete (duplicates skipped).")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            ConClose()
            MES_ConClose()
            QA_ConClose()
        End Try
    End Sub

    Sub Insert_RAMCO()
        Try
            MES_ConOpen()
            QA_ConOpen()
            ConOpen()

            Dim today As String = DateTime.Now.ToString("yyyy-MM-dd")

            ' STEP 1: Load existing WIPM records for today
            Dim existingQuery As String = "
        SELECT ProductionLotNumber, TrackOutTime 
        FROM WIPM_Data_tb 
        WHERE CONVERT(date, TrackOutTime) = @TodayDate"
            Dim existingCmd As New SqlCommand(existingQuery, Dbconnection)
            existingCmd.Parameters.AddWithValue("@TodayDate", today)

            Dim existingSet As New HashSet(Of String)
            Using reader = existingCmd.ExecuteReader()
                While reader.Read()
                    Dim key = reader("ProductionLotNumber").ToString() & "|" & Convert.ToDateTime(reader("TrackOutTime")).ToString("s")
                    existingSet.Add(key)
                End While
            End Using

            ' STEP 2: Load all RAMCO data for today
            Dim RAMCOQuery As String = "
        SELECT ProductionLotNumber, EQPDescription, TrackOutTime 
        FROM stMES_wash 
        WHERE CONVERT(date, TrackOutTime) = @TodayDate"
            Dim RAMCOCmd As New SqlCommand(RAMCOQuery, MES_Dbconnection)
            RAMCOCmd.Parameters.AddWithValue("@TodayDate", today)

            Dim RAMCOList As New List(Of Dictionary(Of String, Object))
            Using reader = RAMCOCmd.ExecuteReader()
                While reader.Read()
                    Dim row As New Dictionary(Of String, Object)
                    row("ProductionLotNumber") = reader("ProductionLotNumber")
                    row("EQPDescription") = reader("EQPDescription")
                    row("TrackOutTime") = Convert.ToDateTime(reader("TrackOutTime"))
                    RAMCOList.Add(row)
                End While
            End Using

            ' STEP 3: Prepare one command for inserting
            Dim insertQuery As String = "
        INSERT INTO WIPM_Data_tb 
        (NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode) 
        VALUES (@NMR, @ProductionLotNumber, @EQPDescription, @TrackOutTime, @ReedType, @Qty, @Description, @LotCode)"
            Dim insertCmd As New SqlCommand(insertQuery, Dbconnection)

            For Each row In RAMCOList
                Dim lotNum As String = row("ProductionLotNumber").ToString()
                Dim trackOut As DateTime = CType(row("TrackOutTime"), DateTime)
                Dim key = lotNum & "|" & trackOut.ToString("s")

                If existingSet.Contains(key) Then Continue For

                ' STEP 4: Load SLR data for the LotNum
                Dim slrQuery As String = "SELECT TOP 1 * FROM Component_SLR WHERE LotN = @LotN"
                Dim slrCmd As New SqlCommand(slrQuery, QA_Dbconnection)
                slrCmd.Parameters.AddWithValue("@LotN", lotNum)

                Using slrReader = slrCmd.ExecuteReader()
                    If slrReader.Read() Then
                        insertCmd.Parameters.Clear()
                        insertCmd.Parameters.AddWithValue("@NMR", 0)
                        insertCmd.Parameters.AddWithValue("@ProductionLotNumber", lotNum)
                        insertCmd.Parameters.AddWithValue("@EQPDescription", row("EQPDescription").ToString())
                        insertCmd.Parameters.AddWithValue("@TrackOutTime", trackOut)
                        insertCmd.Parameters.AddWithValue("@ReedType", slrReader("ReedType"))
                        insertCmd.Parameters.AddWithValue("@Qty", slrReader("Qty"))
                        insertCmd.Parameters.AddWithValue("@Description", slrReader("Description"))
                        insertCmd.Parameters.AddWithValue("@LotCode", slrReader("LotCode"))
                        insertCmd.ExecuteNonQuery()
                    End If
                End Using
            Next

            MsgBox("Optimized insert complete (duplicates skipped).")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            ConClose()
            MES_ConClose()
            QA_ConClose()
        End Try
    End Sub

    Sub Insert_RAMCO_Yesterday()
        Try
            MES_ConOpen()
            QA_ConOpen()
            ConOpen()

            ' Get yesterday's date
            Dim yesterday As String = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd")

            ' STEP 1: Load existing WIPM records for yesterday
            Dim existingQuery As String = "
        SELECT ProductionLotNumber, TrackOutTime 
        FROM WIPM_Data_tb 
        WHERE CONVERT(date, TrackOutTime) = @DateParam"
            Dim existingCmd As New SqlCommand(existingQuery, Dbconnection)
            existingCmd.Parameters.AddWithValue("@DateParam", yesterday)

            Dim existingSet As New HashSet(Of String)
            Using reader = existingCmd.ExecuteReader()
                While reader.Read()
                    Dim key = reader("ProductionLotNumber").ToString() & "|" & Convert.ToDateTime(reader("TrackOutTime")).ToString("s")
                    existingSet.Add(key)
                End While
            End Using

            ' STEP 2: Load all RAMCO data for yesterday
            Dim RAMCOQuery As String = "
        SELECT ProductionLotNumber, EQPDescription, TrackOutTime 
        FROM stMES_wash 
        WHERE CONVERT(date, TrackOutTime) = @DateParam"
            Dim RAMCOCmd As New SqlCommand(RAMCOQuery, MES_Dbconnection)
            RAMCOCmd.Parameters.AddWithValue("@DateParam", yesterday)

            Dim RAMCOList As New List(Of Dictionary(Of String, Object))
            Using reader = RAMCOCmd.ExecuteReader()
                While reader.Read()
                    Dim row As New Dictionary(Of String, Object)
                    row("ProductionLotNumber") = reader("ProductionLotNumber")
                    row("EQPDescription") = reader("EQPDescription")
                    row("TrackOutTime") = Convert.ToDateTime(reader("TrackOutTime"))
                    RAMCOList.Add(row)
                End While
            End Using

            ' STEP 3: Prepare one command for inserting
            Dim insertQuery As String = "
        INSERT INTO WIPM_Data_tb 
        (NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode) 
        VALUES (@NMR, @ProductionLotNumber, @EQPDescription, @TrackOutTime, @ReedType, @Qty, @Description, @LotCode)"
            Dim insertCmd As New SqlCommand(insertQuery, Dbconnection)

            For Each row In RAMCOList
                Dim lotNum As String = row("ProductionLotNumber").ToString()
                Dim trackOut As DateTime = CType(row("TrackOutTime"), DateTime)
                Dim key = lotNum & "|" & trackOut.ToString("s")

                If existingSet.Contains(key) Then Continue For

                ' STEP 4: Load SLR data for the LotNum
                Dim slrQuery As String = "SELECT TOP 1 * FROM Component_SLR WHERE LotN = @LotN"
                Dim slrCmd As New SqlCommand(slrQuery, QA_Dbconnection)
                slrCmd.Parameters.AddWithValue("@LotN", lotNum)

                Using slrReader = slrCmd.ExecuteReader()
                    If slrReader.Read() Then
                        insertCmd.Parameters.Clear()
                        insertCmd.Parameters.AddWithValue("@NMR", 0)
                        insertCmd.Parameters.AddWithValue("@ProductionLotNumber", lotNum)
                        insertCmd.Parameters.AddWithValue("@EQPDescription", row("EQPDescription").ToString())
                        insertCmd.Parameters.AddWithValue("@TrackOutTime", trackOut)
                        insertCmd.Parameters.AddWithValue("@ReedType", slrReader("ReedType"))
                        insertCmd.Parameters.AddWithValue("@Qty", slrReader("Qty"))
                        insertCmd.Parameters.AddWithValue("@Description", slrReader("Description"))
                        insertCmd.Parameters.AddWithValue("@LotCode", slrReader("LotCode"))
                        insertCmd.ExecuteNonQuery()
                    End If
                End Using
            Next

            MsgBox("Optimized insert complete (duplicates skipped).")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            ConClose()
            MES_ConClose()
            QA_ConClose()
        End Try
    End Sub

    Sub Insert_ANNEAL()
        Try
            MES_ConOpen()
            QA_ConOpen()
            ConOpen()

            Dim today As String = DateTime.Now.ToString("yyyy-MM-dd")

            ' STEP 1: Load existing WIPM records for today
            Dim existingQuery As String = "
        SELECT ProductionLotNumber, TrackOutTime 
        FROM WIPM_Data_tb 
        WHERE CONVERT(date, TrackOutTime) = @TodayDate"
            Dim existingCmd As New SqlCommand(existingQuery, Dbconnection)
            existingCmd.Parameters.AddWithValue("@TodayDate", today)

            Dim existingSet As New HashSet(Of String)
            Using reader = existingCmd.ExecuteReader()
                While reader.Read()
                    Dim key = reader("ProductionLotNumber").ToString() & "|" & Convert.ToDateTime(reader("TrackOutTime")).ToString("s")
                    existingSet.Add(key)
                End While
            End Using

            ' STEP 2: Load all ANNEAL data for today
            Dim ANNEALQuery As String = "
        SELECT ProductionLotNumber, EQPDescription, TrackOutTime 
        FROM stMES_anneal 
        WHERE CONVERT(date, TrackOutTime) = @TodayDate"
            Dim ANNEALCmd As New SqlCommand(ANNEALQuery, MES_Dbconnection)
            ANNEALCmd.Parameters.AddWithValue("@TodayDate", today)

            Dim ANNEALList As New List(Of Dictionary(Of String, Object))
            Using reader = ANNEALCmd.ExecuteReader()
                While reader.Read()
                    Dim row As New Dictionary(Of String, Object)
                    row("ProductionLotNumber") = reader("ProductionLotNumber")
                    row("EQPDescription") = reader("EQPDescription")
                    row("TrackOutTime") = Convert.ToDateTime(reader("TrackOutTime"))
                    ANNEALList.Add(row)
                End While
            End Using

            ' STEP 3: Prepare one command for inserting
            Dim insertQuery As String = "
        INSERT INTO WIPM_Data_tb 
        (NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode) 
        VALUES (@NMR, @ProductionLotNumber, @EQPDescription, @TrackOutTime, @ReedType, @Qty, @Description, @LotCode)"
            Dim insertCmd As New SqlCommand(insertQuery, Dbconnection)

            For Each row In ANNEALList
                Dim lotNum As String = row("ProductionLotNumber").ToString()
                Dim trackOut As DateTime = CType(row("TrackOutTime"), DateTime)
                Dim key = lotNum & "|" & trackOut.ToString("s")

                If existingSet.Contains(key) Then Continue For

                ' STEP 4: Load SLR data for the LotNum
                Dim slrQuery As String = "SELECT TOP 1 * FROM Component_SLR WHERE LotN = @LotN"
                Dim slrCmd As New SqlCommand(slrQuery, QA_Dbconnection)
                slrCmd.Parameters.AddWithValue("@LotN", lotNum)

                Using slrReader = slrCmd.ExecuteReader()
                    If slrReader.Read() Then
                        insertCmd.Parameters.Clear()
                        insertCmd.Parameters.AddWithValue("@NMR", 0)
                        insertCmd.Parameters.AddWithValue("@ProductionLotNumber", lotNum)
                        insertCmd.Parameters.AddWithValue("@EQPDescription", row("EQPDescription").ToString())
                        insertCmd.Parameters.AddWithValue("@TrackOutTime", trackOut)
                        insertCmd.Parameters.AddWithValue("@ReedType", slrReader("ReedType"))
                        insertCmd.Parameters.AddWithValue("@Qty", slrReader("Qty"))
                        insertCmd.Parameters.AddWithValue("@Description", slrReader("Description"))
                        insertCmd.Parameters.AddWithValue("@LotCode", slrReader("LotCode"))
                        insertCmd.ExecuteNonQuery()
                    End If
                End Using
            Next

            MsgBox("Optimized insert complete (duplicates skipped).")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            ConClose()
            MES_ConClose()
            QA_ConClose()
        End Try
    End Sub

    Sub Insert_ANNEAL_Yesterday()
        Try
            MES_ConOpen()
            QA_ConOpen()
            ConOpen()

            ' Get yesterday's date
            Dim yesterday As String = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd")

            ' STEP 1: Load existing WIPM records for yesterday
            Dim existingQuery As String = "
        SELECT ProductionLotNumber, TrackOutTime 
        FROM WIPM_Data_tb 
        WHERE CONVERT(date, TrackOutTime) = @DateParam"
            Dim existingCmd As New SqlCommand(existingQuery, Dbconnection)
            existingCmd.Parameters.AddWithValue("@DateParam", yesterday)

            Dim existingSet As New HashSet(Of String)
            Using reader = existingCmd.ExecuteReader()
                While reader.Read()
                    Dim key = reader("ProductionLotNumber").ToString() & "|" & Convert.ToDateTime(reader("TrackOutTime")).ToString("s")
                    existingSet.Add(key)
                End While
            End Using

            ' STEP 2: Load all ANNEAL data for yesterday
            Dim ANNEALQuery As String = "
        SELECT ProductionLotNumber, EQPDescription, TrackOutTime 
        FROM stMES_anneal 
        WHERE CONVERT(date, TrackOutTime) = @DateParam"
            Dim ANNEALCmd As New SqlCommand(ANNEALQuery, MES_Dbconnection)
            ANNEALCmd.Parameters.AddWithValue("@DateParam", yesterday)

            Dim ANNEALList As New List(Of Dictionary(Of String, Object))
            Using reader = ANNEALCmd.ExecuteReader()
                While reader.Read()
                    Dim row As New Dictionary(Of String, Object)
                    row("ProductionLotNumber") = reader("ProductionLotNumber")
                    row("EQPDescription") = reader("EQPDescription")
                    row("TrackOutTime") = Convert.ToDateTime(reader("TrackOutTime"))
                    ANNEALList.Add(row)
                End While
            End Using

            ' STEP 3: Prepare one command for inserting
            Dim insertQuery As String = "
        INSERT INTO WIPM_Data_tb 
        (NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode) 
        VALUES (@NMR, @ProductionLotNumber, @EQPDescription, @TrackOutTime, @ReedType, @Qty, @Description, @LotCode)"
            Dim insertCmd As New SqlCommand(insertQuery, Dbconnection)

            For Each row In ANNEALList
                Dim lotNum As String = row("ProductionLotNumber").ToString()
                Dim trackOut As DateTime = CType(row("TrackOutTime"), DateTime)
                Dim key = lotNum & "|" & trackOut.ToString("s")

                If existingSet.Contains(key) Then Continue For

                ' STEP 4: Load SLR data for the LotNum
                Dim slrQuery As String = "SELECT TOP 1 * FROM Component_SLR WHERE LotN = @LotN"
                Dim slrCmd As New SqlCommand(slrQuery, QA_Dbconnection)
                slrCmd.Parameters.AddWithValue("@LotN", lotNum)

                Using slrReader = slrCmd.ExecuteReader()
                    If slrReader.Read() Then
                        insertCmd.Parameters.Clear()
                        insertCmd.Parameters.AddWithValue("@NMR", 0)
                        insertCmd.Parameters.AddWithValue("@ProductionLotNumber", lotNum)
                        insertCmd.Parameters.AddWithValue("@EQPDescription", row("EQPDescription").ToString())
                        insertCmd.Parameters.AddWithValue("@TrackOutTime", trackOut)
                        insertCmd.Parameters.AddWithValue("@ReedType", slrReader("ReedType"))
                        insertCmd.Parameters.AddWithValue("@Qty", slrReader("Qty"))
                        insertCmd.Parameters.AddWithValue("@Description", slrReader("Description"))
                        insertCmd.Parameters.AddWithValue("@LotCode", slrReader("LotCode"))
                        insertCmd.ExecuteNonQuery()
                    End If
                End Using
            Next

            MsgBox("Optimized insert complete (duplicates skipped).")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            ConClose()
            MES_ConClose()
            QA_ConClose()
        End Try
    End Sub

    Sub Insert_SPUT()
        Try
            MES_ConOpen()
            QA_ConOpen()
            ConOpen()

            Dim today As String = DateTime.Now.ToString("yyyy-MM-dd")

            ' STEP 1: Load existing WIPM records for today
            Dim existingQuery As String = "
        SELECT ProductionLotNumber, TrackOutTime 
        FROM WIPM_Data_tb 
        WHERE CONVERT(date, TrackOutTime) = @TodayDate"
            Dim existingCmd As New SqlCommand(existingQuery, Dbconnection)
            existingCmd.Parameters.AddWithValue("@TodayDate", today)

            Dim existingSet As New HashSet(Of String)
            Using reader = existingCmd.ExecuteReader()
                While reader.Read()
                    Dim key = reader("ProductionLotNumber").ToString() & "|" & Convert.ToDateTime(reader("TrackOutTime")).ToString("s")
                    existingSet.Add(key)
                End While
            End Using

            ' STEP 2: Load all SPUT data for today
            Dim SPUTQuery As String = "
        SELECT ProductionLotNumber, EQPDescription, TrackOutTime 
        FROM stMES_sput 
        WHERE CONVERT(date, TrackOutTime) = @TodayDate"
            Dim SPUTCmd As New SqlCommand(SPUTQuery, MES_Dbconnection)
            SPUTCmd.Parameters.AddWithValue("@TodayDate", today)

            Dim SPUTList As New List(Of Dictionary(Of String, Object))
            Using reader = SPUTCmd.ExecuteReader()
                While reader.Read()
                    Dim row As New Dictionary(Of String, Object)
                    row("ProductionLotNumber") = reader("ProductionLotNumber")
                    row("EQPDescription") = reader("EQPDescription")
                    row("TrackOutTime") = Convert.ToDateTime(reader("TrackOutTime"))
                    SPUTList.Add(row)
                End While
            End Using

            ' STEP 3: Prepare one command for inserting
            Dim insertQuery As String = "
        INSERT INTO WIPM_Data_tb 
        (NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode) 
        VALUES (@NMR, @ProductionLotNumber, @EQPDescription, @TrackOutTime, @ReedType, @Qty, @Description, @LotCode)"
            Dim insertCmd As New SqlCommand(insertQuery, Dbconnection)

            For Each row In SPUTList
                Dim lotNum As String = row("ProductionLotNumber").ToString()
                Dim trackOut As DateTime = CType(row("TrackOutTime"), DateTime)
                Dim key = lotNum & "|" & trackOut.ToString("s")

                If existingSet.Contains(key) Then Continue For

                ' STEP 4: Load SLR data for the LotNum
                Dim slrQuery As String = "SELECT TOP 1 * FROM Component_SLR WHERE LotN = @LotN"
                Dim slrCmd As New SqlCommand(slrQuery, QA_Dbconnection)
                slrCmd.Parameters.AddWithValue("@LotN", lotNum)

                Using slrReader = slrCmd.ExecuteReader()
                    If slrReader.Read() Then
                        insertCmd.Parameters.Clear()
                        insertCmd.Parameters.AddWithValue("@NMR", 0)
                        insertCmd.Parameters.AddWithValue("@ProductionLotNumber", lotNum)
                        insertCmd.Parameters.AddWithValue("@EQPDescription", row("EQPDescription").ToString())
                        insertCmd.Parameters.AddWithValue("@TrackOutTime", trackOut)
                        insertCmd.Parameters.AddWithValue("@ReedType", slrReader("ReedType"))
                        insertCmd.Parameters.AddWithValue("@Qty", slrReader("Qty"))
                        insertCmd.Parameters.AddWithValue("@Description", slrReader("Description"))
                        insertCmd.Parameters.AddWithValue("@LotCode", slrReader("LotCode"))
                        insertCmd.ExecuteNonQuery()
                    End If
                End Using
            Next

            MsgBox("Optimized insert complete (duplicates skipped).")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            ConClose()
            MES_ConClose()
            QA_ConClose()
        End Try
    End Sub

    Sub Insert_SPUT_Yesterday()
        Try
            MES_ConOpen()
            QA_ConOpen()
            ConOpen()

            ' Get yesterday's date
            Dim yesterday As String = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd")

            ' STEP 1: Load existing WIPM records for yesterday
            Dim existingQuery As String = "
        SELECT ProductionLotNumber, TrackOutTime 
        FROM WIPM_Data_tb 
        WHERE CONVERT(date, TrackOutTime) = @DateParam"
            Dim existingCmd As New SqlCommand(existingQuery, Dbconnection)
            existingCmd.Parameters.AddWithValue("@DateParam", yesterday)

            Dim existingSet As New HashSet(Of String)
            Using reader = existingCmd.ExecuteReader()
                While reader.Read()
                    Dim key = reader("ProductionLotNumber").ToString() & "|" & Convert.ToDateTime(reader("TrackOutTime")).ToString("s")
                    existingSet.Add(key)
                End While
            End Using

            ' STEP 2: Load all SPUT data for yesterday
            Dim SPUTQuery As String = "
        SELECT ProductionLotNumber, EQPDescription, TrackOutTime 
        FROM stMES_sput 
        WHERE CONVERT(date, TrackOutTime) = @DateParam"
            Dim SPUTCmd As New SqlCommand(SPUTQuery, MES_Dbconnection)
            SPUTCmd.Parameters.AddWithValue("@DateParam", yesterday)

            Dim SPUTList As New List(Of Dictionary(Of String, Object))
            Using reader = SPUTCmd.ExecuteReader()
                While reader.Read()
                    Dim row As New Dictionary(Of String, Object)
                    row("ProductionLotNumber") = reader("ProductionLotNumber")
                    row("EQPDescription") = reader("EQPDescription")
                    row("TrackOutTime") = Convert.ToDateTime(reader("TrackOutTime"))
                    SPUTList.Add(row)
                End While
            End Using

            ' STEP 3: Prepare one command for inserting
            Dim insertQuery As String = "
        INSERT INTO WIPM_Data_tb 
        (NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode) 
        VALUES (@NMR, @ProductionLotNumber, @EQPDescription, @TrackOutTime, @ReedType, @Qty, @Description, @LotCode)"
            Dim insertCmd As New SqlCommand(insertQuery, Dbconnection)

            For Each row In SPUTList
                Dim lotNum As String = row("ProductionLotNumber").ToString()
                Dim trackOut As DateTime = CType(row("TrackOutTime"), DateTime)
                Dim key = lotNum & "|" & trackOut.ToString("s")

                If existingSet.Contains(key) Then Continue For

                ' STEP 4: Load SLR data for the LotNum
                Dim slrQuery As String = "SELECT TOP 1 * FROM Component_SLR WHERE LotN = @LotN"
                Dim slrCmd As New SqlCommand(slrQuery, QA_Dbconnection)
                slrCmd.Parameters.AddWithValue("@LotN", lotNum)

                Using slrReader = slrCmd.ExecuteReader()
                    If slrReader.Read() Then
                        insertCmd.Parameters.Clear()
                        insertCmd.Parameters.AddWithValue("@NMR", 0)
                        insertCmd.Parameters.AddWithValue("@ProductionLotNumber", lotNum)
                        insertCmd.Parameters.AddWithValue("@EQPDescription", row("EQPDescription").ToString())
                        insertCmd.Parameters.AddWithValue("@TrackOutTime", trackOut)
                        insertCmd.Parameters.AddWithValue("@ReedType", slrReader("ReedType"))
                        insertCmd.Parameters.AddWithValue("@Qty", slrReader("Qty"))
                        insertCmd.Parameters.AddWithValue("@Description", slrReader("Description"))
                        insertCmd.Parameters.AddWithValue("@LotCode", slrReader("LotCode"))
                        insertCmd.ExecuteNonQuery()
                    End If
                End Using
            Next

            MsgBox("Optimized insert complete (duplicates skipped).")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            ConClose()
            MES_ConClose()
            QA_ConClose()
        End Try
    End Sub

    '============================= < FOR PunchPress_Form > ============================

    Sub Load_PUNCHPRESS()
        Dim command As New SqlCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            command.Connection = Dbconnection
            'command.CommandText = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
            '                     FROM WIPM_Data_tb WHERE EQPDescription Like '%PUNCHPRESS%' Order by TrackOutTime ASC"

            command.CommandText = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                                 FROM WIPM_Data_tb AS main WHERE EQPDescription Like '%PUNCHPRESS%' AND NOT EXISTS (
                                SELECT 1
                                FROM WIPM_Data_tb AS sub
                                WHERE sub.ProductionLotNumber = main.ProductionLotNumber 
                                AND sub.EQPDescription like '%DEBUR%') Order by TrackOutTime ASC"


            Dim rdr As SqlDataReader = command.ExecuteReader

            table.Load(rdr)

            PunchPress_Form.DataGridView1.DataSource = table

            ' Bold the header cells
            For Each column As DataGridViewColumn In PunchPress_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 9, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
            Next

            With PunchPress_Form
                '.DataGridView1.Columns("NMR").ReadOnly = False
                .DataGridView1.Columns("NMR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                .DataGridView1.Columns("ProductionLotNumber").ReadOnly = True
                .DataGridView1.Columns("ProductionLotNumber").HeaderText = "Production Lot Number"

                .DataGridView1.Columns("EQPDescription").ReadOnly = True
                .DataGridView1.Columns("EQPDescription").HeaderText = "EQP Description"

                .DataGridView1.Columns("TrackOutTime").ReadOnly = True
                .DataGridView1.Columns("TrackOutTime").HeaderText = "TrackOut Time"

                .DataGridView1.Columns("ReedType").ReadOnly = True
                .DataGridView1.Columns("ReedType").HeaderText = "Reed Type"

                .DataGridView1.Columns("Qty").ReadOnly = True

                .DataGridView1.Columns("Description").ReadOnly = True

                .DataGridView1.Columns("LotCode").ReadOnly = True

                '.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(116, 185, 255)
                .DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                .DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                .DataGridView1.EnableHeadersVisualStyles = False
                .DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

            End With

        End If

        ConClose()
    End Sub

    Sub Load_PUNCHPRESS_byLot()
        Dim command As New SqlCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            command.Connection = Dbconnection

            ' Updated SQL with UPPER() to ensure case-insensitive comparison
            command.CommandText = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode
                                    FROM WIPM_Data_tb AS main
                                    WHERE EQPDescription LIKE '%PUNCHPRESS%'
                                      AND UPPER(ProductionLotNumber) = UPPER(@Search)
                                      AND NOT EXISTS (
                                        SELECT 1
                                        FROM WIPM_Data_tb AS sub
                                        WHERE sub.ProductionLotNumber = main.ProductionLotNumber
                                          AND sub.EQPDescription LIKE '%DEBUR%')
                                    ORDER BY TrackOutTime ASC"

            ' Trimmed input to avoid leading/trailing whitespace issues
            command.Parameters.AddWithValue("@Search", PunchPress_Form.txtSearch.Text.Trim())

            Dim rdr As SqlDataReader = command.ExecuteReader()
            table.Load(rdr)

            PunchPress_Form.DataGridView1.DataSource = table

            ' Style the grid
            For Each column As DataGridViewColumn In PunchPress_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 9, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
            Next

            With PunchPress_Form
                .DataGridView1.Columns("NMR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .DataGridView1.Columns("ProductionLotNumber").ReadOnly = True
                .DataGridView1.Columns("ProductionLotNumber").HeaderText = "Production Lot Number"
                .DataGridView1.Columns("EQPDescription").ReadOnly = True
                .DataGridView1.Columns("EQPDescription").HeaderText = "EQP Description"
                .DataGridView1.Columns("TrackOutTime").ReadOnly = True
                .DataGridView1.Columns("TrackOutTime").HeaderText = "TrackOut Time"
                .DataGridView1.Columns("ReedType").ReadOnly = True
                .DataGridView1.Columns("ReedType").HeaderText = "Reed Type"
                .DataGridView1.Columns("Qty").ReadOnly = True
                .DataGridView1.Columns("Description").ReadOnly = True
                .DataGridView1.Columns("LotCode").ReadOnly = True

                .DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                .DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
                .DataGridView1.EnableHeadersVisualStyles = False
                .DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)
            End With
        End If

        ConClose()
    End Sub

    Sub Load_PUNCHPRESS_TextSearch()
        Try
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            Dim query As String

            If PunchPress_Form.txtSearch.Text = "" Or PunchPress_Form.txtSearch.Text = "Search lot number" Then
                query = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                                 FROM WIPM_Data_tb AS main WHERE EQPDescription Like '%PUNCHPRESS%' AND NOT EXISTS (
                                SELECT 1
                                FROM WIPM_Data_tb AS sub
                                WHERE sub.ProductionLotNumber = main.ProductionLotNumber 
                                AND sub.EQPDescription like '%DEBUR%') Order by TrackOutTime ASC"
            Else
                query = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode
                                 FROM WIPM_Data_tb AS main
                                 WHERE EQPDescription LIKE '%PUNCHPRESS%' 
                                 AND UPPER(ProductionLotNumber) LIKE UPPER(@Search) 
                                 AND NOT EXISTS (
                                 SELECT 1 
                                 FROM WIPM_Data_tb AS sub 
                                 WHERE sub.ProductionLotNumber = main.ProductionLotNumber 
                                 AND sub.EQPDescription LIKE '%DEBUR%')
                                 ORDER BY TrackOutTime ASC"
            End If

            adap = New SqlDataAdapter(query, Dbconnection)

            If PunchPress_Form.txtSearch.Text <> "" Then
                adap.SelectCommand.Parameters.AddWithValue("@Search", "%" & PunchPress_Form.txtSearch.Text & "%")
            End If

            ConOpen()
            adap.Fill(Data)
            ConClose()

            PunchPress_Form.DataGridView1.DataSource = Data

            ' Bold the header cells
            For Each column As DataGridViewColumn In PunchPress_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 9, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
            Next

            With PunchPress_Form
                '.DataGridView1.Columns("NMR").ReadOnly = False
                .DataGridView1.Columns("NMR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                .DataGridView1.Columns("ProductionLotNumber").ReadOnly = True
                .DataGridView1.Columns("ProductionLotNumber").HeaderText = "Production Lot Number"

                .DataGridView1.Columns("EQPDescription").ReadOnly = True
                .DataGridView1.Columns("EQPDescription").HeaderText = "EQP Description"

                .DataGridView1.Columns("TrackOutTime").ReadOnly = True
                .DataGridView1.Columns("TrackOutTime").HeaderText = "TrackOut Time"

                .DataGridView1.Columns("ReedType").ReadOnly = True
                .DataGridView1.Columns("ReedType").HeaderText = "Reed Type"

                .DataGridView1.Columns("Qty").ReadOnly = True

                .DataGridView1.Columns("Description").ReadOnly = True

                .DataGridView1.Columns("LotCode").ReadOnly = True

                '.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(116, 185, 255)
                .DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                .DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                .DataGridView1.EnableHeadersVisualStyles = False
                .DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

            End With

        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Save_PUNCHPRESS_Changes()
        ConOpen()

        For Each row As DataGridViewRow In PunchPress_Form.DataGridView1.Rows
            ' Skip the new row at the bottom
            If row.IsNewRow Then Continue For

            ' Get checkbox value
            Dim isChecked As Boolean = False
            If Not IsDBNull(row.Cells("NMR").Value) Then
                isChecked = Convert.ToBoolean(row.Cells("NMR").Value)
            End If

            ' Get values from the row
            Dim lotNumber As String = row.Cells("ProductionLotNumber").Value.ToString()
            Dim trackOutTime As String = row.Cells("TrackOutTime").Value.ToString()
            Dim eqpDescription As String = row.Cells("EQPDescription").Value.ToString()

            ' Build SQL update with additional conditions
            Dim updateCmd As New SqlCommand("UPDATE WIPM_Data_tb SET NMR = @NMR WHERE ProductionLotNumber = @LotNumber AND TrackOutTime = @TrackOutTime AND EQPDescription = @EQPDescription", Dbconnection)
            updateCmd.Parameters.AddWithValue("@NMR", If(isChecked, 1, 0))
            updateCmd.Parameters.AddWithValue("@LotNumber", lotNumber)
            updateCmd.Parameters.AddWithValue("@TrackOutTime", trackOutTime)
            updateCmd.Parameters.AddWithValue("@EQPDescription", eqpDescription)

            ' Execute the update
            updateCmd.ExecuteNonQuery()

            ' Also update WIPM_Process_tb based on LotNumber
            Dim updateProcessCmd As New SqlCommand("
            UPDATE WIPM_Process_tb 
            SET NMR = @NMR 
            WHERE Lot_Number = @LotNumber", Dbconnection)
            updateProcessCmd.Parameters.AddWithValue("@NMR", If(isChecked, 1, 0))
            updateProcessCmd.Parameters.AddWithValue("@LotNumber", lotNumber)
            updateProcessCmd.ExecuteNonQuery()
        Next

        ConClose()

        MessageBox.Show("Changes saved successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)


        If PunchPress_Form.txtSearch.Text = "" Or PunchPress_Form.txtSearch.Text = "Search lot number" Then
            ' Reload the data after saving changes
            Load_PUNCHPRESS()
        Else
            Load_PUNCHPRESS_TextSearch()
        End If

    End Sub


    '============================= < FOR Vibrator_Form > ============================
    Sub Load_DEBUR()
        Dim command As New SqlCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            command.Connection = Dbconnection
            'command.CommandText = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
            '                        FROM WIPM_Data_tb WHERE EQPDescription Like '%DEBUR%' Order by TrackOutTime ASC"

            command.CommandText = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                                 FROM WIPM_Data_tb AS main WHERE EQPDescription Like '%DEBUR%' AND NOT EXISTS (
                                SELECT 1
                                FROM WIPM_Data_tb AS sub
                                WHERE sub.ProductionLotNumber = main.ProductionLotNumber 
                                AND sub.EQPDescription like '%RAMCO%') Order by TrackOutTime ASC"

            Dim rdr As SqlDataReader = command.ExecuteReader

            table.Load(rdr)

            Vibrator_Form.DataGridView1.DataSource = table

            ' Bold the header cells
            For Each column As DataGridViewColumn In Vibrator_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 9, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
            Next

            With Vibrator_Form
                '.DataGridView1.Columns("NMR").ReadOnly = False
                .DataGridView1.Columns("NMR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                .DataGridView1.Columns("ProductionLotNumber").ReadOnly = True
                .DataGridView1.Columns("ProductionLotNumber").HeaderText = "Production Lot Number"

                .DataGridView1.Columns("EQPDescription").ReadOnly = True
                .DataGridView1.Columns("EQPDescription").HeaderText = "EQP Description"

                .DataGridView1.Columns("TrackOutTime").ReadOnly = True
                .DataGridView1.Columns("TrackOutTime").HeaderText = "TrackOut Time"

                .DataGridView1.Columns("ReedType").ReadOnly = True
                .DataGridView1.Columns("ReedType").HeaderText = "Reed Type"

                .DataGridView1.Columns("Qty").ReadOnly = True

                .DataGridView1.Columns("Description").ReadOnly = True

                .DataGridView1.Columns("LotCode").ReadOnly = True

                '.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(116, 185, 255)
                .DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                .DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                .DataGridView1.EnableHeadersVisualStyles = False
                .DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

            End With

        End If

        ConClose()
    End Sub

    Sub Load_DEBUR_byLot()
        Dim command As New SqlCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            command.Connection = Dbconnection
            'command.CommandText = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
            '           FROM WIPM_Data_tb 
            '           WHERE EQPDescription LIKE '%DEBUR%' AND ProductionLotNumber = @Search Order by TrackOutTime ASC"

            command.CommandText = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode
                                    FROM WIPM_Data_tb AS main
                                    WHERE EQPDescription LIKE '%DEBUR%'
                                      AND UPPER(ProductionLotNumber) = UPPER(@Search)
                                      AND NOT EXISTS (
                                        SELECT 1
                                        FROM WIPM_Data_tb AS sub
                                        WHERE sub.ProductionLotNumber = main.ProductionLotNumber
                                          AND sub.EQPDescription LIKE '%RAMCO%')
                                    ORDER BY TrackOutTime ASC"

            command.Parameters.AddWithValue("@Search", Vibrator_Form.txtSearch.Text.Trim())

            Dim rdr As SqlDataReader = command.ExecuteReader

            table.Load(rdr)

            Vibrator_Form.DataGridView1.DataSource = table

            ' Bold the header cells
            For Each column As DataGridViewColumn In Vibrator_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 9, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
            Next

            With Vibrator_Form
                '.DataGridView1.Columns("NMR").ReadOnly = False
                .DataGridView1.Columns("NMR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                .DataGridView1.Columns("ProductionLotNumber").ReadOnly = True
                .DataGridView1.Columns("ProductionLotNumber").HeaderText = "Production Lot Number"

                .DataGridView1.Columns("EQPDescription").ReadOnly = True
                .DataGridView1.Columns("EQPDescription").HeaderText = "EQP Description"

                .DataGridView1.Columns("TrackOutTime").ReadOnly = True
                .DataGridView1.Columns("TrackOutTime").HeaderText = "TrackOut Time"

                .DataGridView1.Columns("ReedType").ReadOnly = True
                .DataGridView1.Columns("ReedType").HeaderText = "Reed Type"

                .DataGridView1.Columns("Qty").ReadOnly = True

                .DataGridView1.Columns("Description").ReadOnly = True

                .DataGridView1.Columns("LotCode").ReadOnly = True

                '.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(116, 185, 255)
                .DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                .DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                .DataGridView1.EnableHeadersVisualStyles = False
                .DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

            End With

        End If

        ConClose()
    End Sub

    Sub Load_DEBUR_TextSearch()
        Try
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            Dim query As String

            If Vibrator_Form.txtSearch.Text = "" Or Vibrator_Form.txtSearch.Text = "Search lot number" Then
                'query = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                '                 FROM WIPM_Data_tb WHERE EQPDescription Like '%DEBUR%' Order by TrackOutTime ASC"

                query = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                                 FROM WIPM_Data_tb AS main WHERE EQPDescription Like '%DEBUR%' AND NOT EXISTS (
                                SELECT 1
                                FROM WIPM_Data_tb AS sub
                                WHERE sub.ProductionLotNumber = main.ProductionLotNumber 
                                AND sub.EQPDescription like '%RAMCO%') Order by TrackOutTime ASC"
            Else
                'query = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                '       FROM WIPM_Data_tb 
                '       WHERE EQPDescription LIKE '%DEBUR%' AND ProductionLotNumber LIKE @Search Order by TrackOutTime ASC"

                query = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode
                                 FROM WIPM_Data_tb AS main
                                 WHERE EQPDescription LIKE '%DEBUR%' 
                                 AND UPPER(ProductionLotNumber) LIKE UPPER(@Search) 
                                 AND NOT EXISTS (
                                 SELECT 1 
                                 FROM WIPM_Data_tb AS sub 
                                 WHERE sub.ProductionLotNumber = main.ProductionLotNumber 
                                 AND sub.EQPDescription LIKE '%RAMCO%')
                                 ORDER BY TrackOutTime ASC"

            End If

            adap = New SqlDataAdapter(query, Dbconnection)

            If Vibrator_Form.txtSearch.Text <> "" Then
                adap.SelectCommand.Parameters.AddWithValue("@Search", "%" & Vibrator_Form.txtSearch.Text & "%")
            End If

            ConOpen()
            adap.Fill(Data)
            ConClose()

            Vibrator_Form.DataGridView1.DataSource = Data

            ' Bold the header cells
            For Each column As DataGridViewColumn In Vibrator_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 9, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
            Next

            With Vibrator_Form
                '.DataGridView1.Columns("NMR").ReadOnly = False
                .DataGridView1.Columns("NMR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                .DataGridView1.Columns("ProductionLotNumber").ReadOnly = True
                .DataGridView1.Columns("ProductionLotNumber").HeaderText = "Production Lot Number"

                .DataGridView1.Columns("EQPDescription").ReadOnly = True
                .DataGridView1.Columns("EQPDescription").HeaderText = "EQP Description"

                .DataGridView1.Columns("TrackOutTime").ReadOnly = True
                .DataGridView1.Columns("TrackOutTime").HeaderText = "TrackOut Time"

                .DataGridView1.Columns("ReedType").ReadOnly = True
                .DataGridView1.Columns("ReedType").HeaderText = "Reed Type"

                .DataGridView1.Columns("Qty").ReadOnly = True

                .DataGridView1.Columns("Description").ReadOnly = True

                .DataGridView1.Columns("LotCode").ReadOnly = True

                '.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(116, 185, 255)
                .DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                .DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                .DataGridView1.EnableHeadersVisualStyles = False
                .DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

            End With

        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Save_DEBUR_Changes()
        ConOpen()

        For Each row As DataGridViewRow In Vibrator_Form.DataGridView1.Rows
            ' Skip the new row at the bottom
            If row.IsNewRow Then Continue For

            ' Get checkbox value
            Dim isChecked As Boolean = False
            If Not IsDBNull(row.Cells("NMR").Value) Then
                isChecked = Convert.ToBoolean(row.Cells("NMR").Value)
            End If

            ' Get values from the row
            Dim lotNumber As String = row.Cells("ProductionLotNumber").Value.ToString()
            Dim trackOutTime As String = row.Cells("TrackOutTime").Value.ToString()
            Dim eqpDescription As String = row.Cells("EQPDescription").Value.ToString()

            ' Build SQL update with additional conditions
            Dim updateCmd As New SqlCommand("UPDATE WIPM_Data_tb SET NMR = @NMR WHERE ProductionLotNumber = @LotNumber AND TrackOutTime = @TrackOutTime AND EQPDescription = @EQPDescription", Dbconnection)
            updateCmd.Parameters.AddWithValue("@NMR", If(isChecked, 1, 0))
            updateCmd.Parameters.AddWithValue("@LotNumber", lotNumber)
            updateCmd.Parameters.AddWithValue("@TrackOutTime", trackOutTime)
            updateCmd.Parameters.AddWithValue("@EQPDescription", eqpDescription)

            ' Execute the update
            updateCmd.ExecuteNonQuery()

            ' Also update WIPM_Process_tb based on LotNumber
            Dim updateProcessCmd As New SqlCommand("
            UPDATE WIPM_Process_tb 
            SET NMR = @NMR 
            WHERE Lot_Number = @LotNumber", Dbconnection)
            updateProcessCmd.Parameters.AddWithValue("@NMR", If(isChecked, 1, 0))
            updateProcessCmd.Parameters.AddWithValue("@LotNumber", lotNumber)
            updateProcessCmd.ExecuteNonQuery()
        Next

        ConClose()

        MessageBox.Show("Changes saved successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If Vibrator_Form.txtSearch.Text = "" Or Vibrator_Form.txtSearch.Text = "Search lot number" Then
            ' Reload the data after saving changes
            Load_DEBUR()
        Else
            Load_DEBUR_TextSearch()
        End If

    End Sub


    '============================= < FOR LoadWash_Form > ============================
    Sub Load_RAMCO()
        Dim command As New SqlCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            command.Connection = Dbconnection
            'command.CommandText = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
            '                        FROM WIPM_Data_tb WHERE EQPDescription Like '%RAMCO%' Order by TrackOutTime ASC"

            command.CommandText = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                                 FROM WIPM_Data_tb AS main WHERE EQPDescription Like '%RAMCO%' AND NOT EXISTS (
                                SELECT 1
                                FROM WIPM_Data_tb AS sub
                                WHERE sub.ProductionLotNumber = main.ProductionLotNumber 
                                AND sub.EQPDescription like '%ANNEAL%') Order by TrackOutTime ASC"

            Dim rdr As SqlDataReader = command.ExecuteReader

            table.Load(rdr)

            LoadWash_Form.DataGridView1.DataSource = table

            ' Bold the header cells
            For Each column As DataGridViewColumn In LoadWash_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 9, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
            Next

            With LoadWash_Form
                '.DataGridView1.Columns("NMR").ReadOnly = False
                .DataGridView1.Columns("NMR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                .DataGridView1.Columns("ProductionLotNumber").ReadOnly = True
                .DataGridView1.Columns("ProductionLotNumber").HeaderText = "Production Lot Number"

                .DataGridView1.Columns("EQPDescription").ReadOnly = True
                .DataGridView1.Columns("EQPDescription").HeaderText = "EQP Description"

                .DataGridView1.Columns("TrackOutTime").ReadOnly = True
                .DataGridView1.Columns("TrackOutTime").HeaderText = "TrackOut Time"

                .DataGridView1.Columns("ReedType").ReadOnly = True
                .DataGridView1.Columns("ReedType").HeaderText = "Reed Type"

                .DataGridView1.Columns("Qty").ReadOnly = True

                .DataGridView1.Columns("Description").ReadOnly = True

                .DataGridView1.Columns("LotCode").ReadOnly = True

                '.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(116, 185, 255)
                .DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                .DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                .DataGridView1.EnableHeadersVisualStyles = False
                .DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)


            End With

        End If

        ConClose()
    End Sub

    Sub Load_RAMCO_byLot()
        Dim command As New SqlCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            command.Connection = Dbconnection
            'command.CommandText = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
            '           FROM WIPM_Data_tb 
            '           WHERE EQPDescription LIKE '%RAMCO%' AND ProductionLotNumber = @Search Order by TrackOutTime ASC"

            command.CommandText = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode
                                    FROM WIPM_Data_tb AS main
                                    WHERE EQPDescription LIKE '%RAMCO%'
                                      AND UPPER(ProductionLotNumber) = UPPER(@Search)
                                      AND NOT EXISTS (
                                        SELECT 1
                                        FROM WIPM_Data_tb AS sub
                                        WHERE sub.ProductionLotNumber = main.ProductionLotNumber
                                          AND sub.EQPDescription LIKE '%ANNEAL%')
                                    ORDER BY TrackOutTime ASC"

            command.Parameters.AddWithValue("@Search", LoadWash_Form.txtSearch.Text.Trim())

            Dim rdr As SqlDataReader = command.ExecuteReader

            table.Load(rdr)

            LoadWash_Form.DataGridView1.DataSource = table

            ' Bold the header cells
            For Each column As DataGridViewColumn In LoadWash_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 9, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
            Next

            With LoadWash_Form
                '.DataGridView1.Columns("NMR").ReadOnly = False
                .DataGridView1.Columns("NMR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                .DataGridView1.Columns("ProductionLotNumber").ReadOnly = True
                .DataGridView1.Columns("ProductionLotNumber").HeaderText = "Production Lot Number"

                .DataGridView1.Columns("EQPDescription").ReadOnly = True
                .DataGridView1.Columns("EQPDescription").HeaderText = "EQP Description"

                .DataGridView1.Columns("TrackOutTime").ReadOnly = True
                .DataGridView1.Columns("TrackOutTime").HeaderText = "TrackOut Time"

                .DataGridView1.Columns("ReedType").ReadOnly = True
                .DataGridView1.Columns("ReedType").HeaderText = "Reed Type"

                .DataGridView1.Columns("Qty").ReadOnly = True

                .DataGridView1.Columns("Description").ReadOnly = True

                .DataGridView1.Columns("LotCode").ReadOnly = True

                '.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(116, 185, 255)
                .DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                .DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                .DataGridView1.EnableHeadersVisualStyles = False
                .DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

            End With

        End If

        ConClose()
    End Sub

    Sub Load_RAMCO_TextSearch()
        Try
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            Dim query As String

            If LoadWash_Form.txtSearch.Text = "" Or LoadWash_Form.txtSearch.Text = "Search lot number" Then
                '    query = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                '                     FROM WIPM_Data_tb WHERE EQPDescription Like '%RAMCO%' Order by TrackOutTime ASC"
                'Else
                '    query = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                '           FROM WIPM_Data_tb 
                '           WHERE EQPDescription LIKE '%RAMCO%' AND ProductionLotNumber LIKE @Search Order by TrackOutTime ASC"

                query = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                                 FROM WIPM_Data_tb AS main WHERE EQPDescription Like '%RAMCO%' AND NOT EXISTS (
                                SELECT 1
                                FROM WIPM_Data_tb AS sub
                                WHERE sub.ProductionLotNumber = main.ProductionLotNumber 
                                AND sub.EQPDescription like '%ANNEAL%') Order by TrackOutTime ASC"
            Else

                query = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode
                                 FROM WIPM_Data_tb AS main
                                 WHERE EQPDescription LIKE '%RAMCO%' 
                                 AND UPPER(ProductionLotNumber) LIKE UPPER(@Search) 
                                 AND NOT EXISTS (
                                 SELECT 1 
                                 FROM WIPM_Data_tb AS sub 
                                 WHERE sub.ProductionLotNumber = main.ProductionLotNumber 
                                 AND sub.EQPDescription LIKE '%ANNEAL%')
                                 ORDER BY TrackOutTime ASC"
            End If

            adap = New SqlDataAdapter(query, Dbconnection)

            If LoadWash_Form.txtSearch.Text <> "" Then
                adap.SelectCommand.Parameters.AddWithValue("@Search", "%" & LoadWash_Form.txtSearch.Text & "%")
            End If

            ConOpen()
            adap.Fill(Data)
            ConClose()

            LoadWash_Form.DataGridView1.DataSource = Data

            ' Bold the header cells
            For Each column As DataGridViewColumn In LoadWash_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 9, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
            Next

            With LoadWash_Form
                '.DataGridView1.Columns("NMR").ReadOnly = False
                .DataGridView1.Columns("NMR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                .DataGridView1.Columns("ProductionLotNumber").ReadOnly = True
                .DataGridView1.Columns("ProductionLotNumber").HeaderText = "Production Lot Number"

                .DataGridView1.Columns("EQPDescription").ReadOnly = True
                .DataGridView1.Columns("EQPDescription").HeaderText = "EQP Description"

                .DataGridView1.Columns("TrackOutTime").ReadOnly = True
                .DataGridView1.Columns("TrackOutTime").HeaderText = "TrackOut Time"

                .DataGridView1.Columns("ReedType").ReadOnly = True
                .DataGridView1.Columns("ReedType").HeaderText = "Reed Type"

                .DataGridView1.Columns("Qty").ReadOnly = True

                .DataGridView1.Columns("Description").ReadOnly = True

                .DataGridView1.Columns("LotCode").ReadOnly = True

                '.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(116, 185, 255)
                .DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                .DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                .DataGridView1.EnableHeadersVisualStyles = False
                .DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

            End With

        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Save_RAMCO_Changes()
        ConOpen()

        For Each row As DataGridViewRow In LoadWash_Form.DataGridView1.Rows
            ' Skip the new row at the bottom
            If row.IsNewRow Then Continue For

            ' Get checkbox value
            Dim isChecked As Boolean = False
            If Not IsDBNull(row.Cells("NMR").Value) Then
                isChecked = Convert.ToBoolean(row.Cells("NMR").Value)
            End If

            ' Get values from the row
            Dim lotNumber As String = row.Cells("ProductionLotNumber").Value.ToString()
            Dim trackOutTime As String = row.Cells("TrackOutTime").Value.ToString()
            Dim eqpDescription As String = row.Cells("EQPDescription").Value.ToString()

            ' Build SQL update with additional conditions
            Dim updateCmd As New SqlCommand("UPDATE WIPM_Data_tb SET NMR = @NMR WHERE ProductionLotNumber = @LotNumber AND TrackOutTime = @TrackOutTime AND EQPDescription = @EQPDescription", Dbconnection)
            updateCmd.Parameters.AddWithValue("@NMR", If(isChecked, 1, 0))
            updateCmd.Parameters.AddWithValue("@LotNumber", lotNumber)
            updateCmd.Parameters.AddWithValue("@TrackOutTime", trackOutTime)
            updateCmd.Parameters.AddWithValue("@EQPDescription", eqpDescription)

            ' Execute the update
            updateCmd.ExecuteNonQuery()

            ' Also update WIPM_Process_tb based on LotNumber
            Dim updateProcessCmd As New SqlCommand("
            UPDATE WIPM_Process_tb 
            SET NMR = @NMR 
            WHERE Lot_Number = @LotNumber", Dbconnection)
            updateProcessCmd.Parameters.AddWithValue("@NMR", If(isChecked, 1, 0))
            updateProcessCmd.Parameters.AddWithValue("@LotNumber", lotNumber)
            updateProcessCmd.ExecuteNonQuery()
        Next

        ConClose()

        MessageBox.Show("Changes saved successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If LoadWash_Form.txtSearch.Text = "" Or LoadWash_Form.txtSearch.Text = "Search lot number" Then
            ' Reload the data after saving changes
            Load_RAMCO()
        Else
            Load_RAMCO_TextSearch()
        End If

    End Sub


    '============================= < FOR Anneal_Form > ============================
    Sub Load_ANNEAL()
        Dim command As New SqlCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            command.Connection = Dbconnection
            'command.CommandText = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
            '                        FROM WIPM_Data_tb WHERE EQPDescription Like '%ANNEAL%' Order by TrackOutTime ASC"

            command.CommandText = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                                 FROM WIPM_Data_tb AS main WHERE EQPDescription Like '%ANNEAL%' AND NOT EXISTS (
                                SELECT 1
                                FROM WIPM_Data_tb AS sub
                                WHERE sub.ProductionLotNumber = main.ProductionLotNumber 
                                AND sub.EQPDescription like '%SPUT%') Order by TrackOutTime ASC"

            Dim rdr As SqlDataReader = command.ExecuteReader

            table.Load(rdr)

            Anneal_Form.DataGridView1.DataSource = table

            ' Bold the header cells
            For Each column As DataGridViewColumn In Anneal_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 9, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
            Next

            With Anneal_Form
                '.DataGridView1.Columns("NMR").ReadOnly = False
                .DataGridView1.Columns("NMR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                .DataGridView1.Columns("ProductionLotNumber").ReadOnly = True
                .DataGridView1.Columns("ProductionLotNumber").HeaderText = "Production Lot Number"

                .DataGridView1.Columns("EQPDescription").ReadOnly = True
                .DataGridView1.Columns("EQPDescription").HeaderText = "EQP Description"

                .DataGridView1.Columns("TrackOutTime").ReadOnly = True
                .DataGridView1.Columns("TrackOutTime").HeaderText = "TrackOut Time"

                .DataGridView1.Columns("ReedType").ReadOnly = True
                .DataGridView1.Columns("ReedType").HeaderText = "Reed Type"

                .DataGridView1.Columns("Qty").ReadOnly = True

                .DataGridView1.Columns("Description").ReadOnly = True

                .DataGridView1.Columns("LotCode").ReadOnly = True

                '.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(116, 185, 255)
                .DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                .DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                .DataGridView1.EnableHeadersVisualStyles = False
                .DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

            End With

        End If

        ConClose()
    End Sub

    Sub Load_ANNEAL_byLot()
        Dim command As New SqlCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            command.Connection = Dbconnection
            'command.CommandText = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
            '           FROM WIPM_Data_tb 
            '           WHERE EQPDescription LIKE '%ANNEAL%' AND ProductionLotNumber = @Search Order by TrackOutTime ASC"

            command.CommandText = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode
                                    FROM WIPM_Data_tb AS main
                                    WHERE EQPDescription LIKE '%ANNEAL%'
                                      AND UPPER(ProductionLotNumber) = UPPER(@Search)
                                      AND NOT EXISTS (
                                        SELECT 1
                                        FROM WIPM_Data_tb AS sub
                                        WHERE sub.ProductionLotNumber = main.ProductionLotNumber
                                          AND sub.EQPDescription LIKE '%SPUT%')
                                    ORDER BY TrackOutTime ASC"

            command.Parameters.AddWithValue("@Search", Anneal_Form.txtSearch.Text.Trim())

            Dim rdr As SqlDataReader = command.ExecuteReader

            table.Load(rdr)

            Anneal_Form.DataGridView1.DataSource = table

            ' Bold the header cells
            For Each column As DataGridViewColumn In Anneal_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 9, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
            Next

            With Anneal_Form
                '.DataGridView1.Columns("NMR").ReadOnly = False
                .DataGridView1.Columns("NMR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                .DataGridView1.Columns("ProductionLotNumber").ReadOnly = True
                .DataGridView1.Columns("ProductionLotNumber").HeaderText = "Production Lot Number"

                .DataGridView1.Columns("EQPDescription").ReadOnly = True
                .DataGridView1.Columns("EQPDescription").HeaderText = "EQP Description"

                .DataGridView1.Columns("TrackOutTime").ReadOnly = True
                .DataGridView1.Columns("TrackOutTime").HeaderText = "TrackOut Time"

                .DataGridView1.Columns("ReedType").ReadOnly = True
                .DataGridView1.Columns("ReedType").HeaderText = "Reed Type"

                .DataGridView1.Columns("Qty").ReadOnly = True

                .DataGridView1.Columns("Description").ReadOnly = True

                .DataGridView1.Columns("LotCode").ReadOnly = True

                '.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(116, 185, 255)
                .DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                .DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                .DataGridView1.EnableHeadersVisualStyles = False
                .DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

            End With

        End If

        ConClose()
    End Sub

    Sub Load_ANNEAL_TextSearch()
        Try
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            Dim query As String

            If Anneal_Form.txtSearch.Text = "" Or Anneal_Form.txtSearch.Text = "Search lot number" Then
                '    query = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                '                     FROM WIPM_Data_tb WHERE EQPDescription Like '%ANNEAL%' Order by TrackOutTime ASC"
                'Else
                '    query = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                '           FROM WIPM_Data_tb 
                '           WHERE EQPDescription LIKE '%ANNEAL%' AND ProductionLotNumber LIKE @Search Order by TrackOutTime ASC"

                query = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                                 FROM WIPM_Data_tb AS main WHERE EQPDescription Like '%ANNEAL%' AND NOT EXISTS (
                                SELECT 1
                                FROM WIPM_Data_tb AS sub
                                WHERE sub.ProductionLotNumber = main.ProductionLotNumber 
                                AND sub.EQPDescription like '%SPUT%') Order by TrackOutTime ASC"
            Else

                query = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode
                                 FROM WIPM_Data_tb AS main
                                 WHERE EQPDescription LIKE '%ANNEAL%' 
                                 AND UPPER(ProductionLotNumber) LIKE UPPER(@Search) 
                                 AND NOT EXISTS (
                                 SELECT 1 
                                 FROM WIPM_Data_tb AS sub 
                                 WHERE sub.ProductionLotNumber = main.ProductionLotNumber 
                                 AND sub.EQPDescription LIKE '%SPUT%')
                                 ORDER BY TrackOutTime ASC"

            End If

            adap = New SqlDataAdapter(query, Dbconnection)

            If Anneal_Form.txtSearch.Text <> "" Then
                adap.SelectCommand.Parameters.AddWithValue("@Search", "%" & Anneal_Form.txtSearch.Text & "%")
            End If

            ConOpen()
            adap.Fill(Data)
            ConClose()

            Anneal_Form.DataGridView1.DataSource = Data

            ' Bold the header cells
            For Each column As DataGridViewColumn In Anneal_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 9, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
            Next

            With Anneal_Form
                '.DataGridView1.Columns("NMR").ReadOnly = False
                .DataGridView1.Columns("NMR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                .DataGridView1.Columns("ProductionLotNumber").ReadOnly = True
                .DataGridView1.Columns("ProductionLotNumber").HeaderText = "Production Lot Number"

                .DataGridView1.Columns("EQPDescription").ReadOnly = True
                .DataGridView1.Columns("EQPDescription").HeaderText = "EQP Description"

                .DataGridView1.Columns("TrackOutTime").ReadOnly = True
                .DataGridView1.Columns("TrackOutTime").HeaderText = "TrackOut Time"

                .DataGridView1.Columns("ReedType").ReadOnly = True
                .DataGridView1.Columns("ReedType").HeaderText = "Reed Type"

                .DataGridView1.Columns("Qty").ReadOnly = True

                .DataGridView1.Columns("Description").ReadOnly = True

                .DataGridView1.Columns("LotCode").ReadOnly = True

                '.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(116, 185, 255)
                .DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                .DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                .DataGridView1.EnableHeadersVisualStyles = False
                .DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

            End With

        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Save_ANNEAL_Changes()
        ConOpen()

        For Each row As DataGridViewRow In Anneal_Form.DataGridView1.Rows
            ' Skip the new row at the bottom
            If row.IsNewRow Then Continue For

            ' Get checkbox value
            Dim isChecked As Boolean = False
            If Not IsDBNull(row.Cells("NMR").Value) Then
                isChecked = Convert.ToBoolean(row.Cells("NMR").Value)
            End If

            ' Get values from the row
            Dim lotNumber As String = row.Cells("ProductionLotNumber").Value.ToString()
            Dim trackOutTime As String = row.Cells("TrackOutTime").Value.ToString()
            Dim eqpDescription As String = row.Cells("EQPDescription").Value.ToString()

            ' Build SQL update with additional conditions
            Dim updateCmd As New SqlCommand("UPDATE WIPM_Data_tb SET NMR = @NMR WHERE ProductionLotNumber = @LotNumber AND TrackOutTime = @TrackOutTime AND EQPDescription = @EQPDescription", Dbconnection)
            updateCmd.Parameters.AddWithValue("@NMR", If(isChecked, 1, 0))
            updateCmd.Parameters.AddWithValue("@LotNumber", lotNumber)
            updateCmd.Parameters.AddWithValue("@TrackOutTime", trackOutTime)
            updateCmd.Parameters.AddWithValue("@EQPDescription", eqpDescription)

            ' Execute the update
            updateCmd.ExecuteNonQuery()

            ' Also update WIPM_Process_tb based on LotNumber
            Dim updateProcessCmd As New SqlCommand("
            UPDATE WIPM_Process_tb 
            SET NMR = @NMR 
            WHERE Lot_Number = @LotNumber", Dbconnection)
            updateProcessCmd.Parameters.AddWithValue("@NMR", If(isChecked, 1, 0))
            updateProcessCmd.Parameters.AddWithValue("@LotNumber", lotNumber)
            updateProcessCmd.ExecuteNonQuery()
        Next

        ConClose()

        MessageBox.Show("Changes saved successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If Anneal_Form.txtSearch.Text = "" Or Anneal_Form.txtSearch.Text = "Search lot number" Then
            ' Reload the data after saving changes
            Load_ANNEAL()
        Else
            Load_ANNEAL_TextSearch()
        End If

    End Sub


    '============================= < FOR Sput_Form > ============================
    Sub Load_SPUT()
        Dim command As New SqlCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            command.Connection = Dbconnection
            command.CommandText = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                                    FROM WIPM_Data_tb WHERE EQPDescription Like '%SPUT%' Order by TrackOutTime ASC"

            Dim rdr As SqlDataReader = command.ExecuteReader

            table.Load(rdr)

            Sput_Form.DataGridView1.DataSource = table

            ' Bold the header cells
            For Each column As DataGridViewColumn In Sput_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 9, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
            Next

            With Sput_Form
                '.DataGridView1.Columns("NMR").ReadOnly = False
                .DataGridView1.Columns("NMR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                .DataGridView1.Columns("ProductionLotNumber").ReadOnly = True
                .DataGridView1.Columns("ProductionLotNumber").HeaderText = "Production Lot Number"

                .DataGridView1.Columns("EQPDescription").ReadOnly = True
                .DataGridView1.Columns("EQPDescription").HeaderText = "EQP Description"

                .DataGridView1.Columns("TrackOutTime").ReadOnly = True
                .DataGridView1.Columns("TrackOutTime").HeaderText = "TrackOut Time"

                .DataGridView1.Columns("ReedType").ReadOnly = True
                .DataGridView1.Columns("ReedType").HeaderText = "Reed Type"

                .DataGridView1.Columns("Qty").ReadOnly = True

                .DataGridView1.Columns("Description").ReadOnly = True

                .DataGridView1.Columns("LotCode").ReadOnly = True

                '.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(116, 185, 255)
                .DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                .DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                .DataGridView1.EnableHeadersVisualStyles = False
                .DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

            End With

        End If

        ConClose()
    End Sub

    Sub Load_SPUT_byLot()
        Dim command As New SqlCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            command.Connection = Dbconnection
            command.CommandText = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                       FROM WIPM_Data_tb 
                       WHERE EQPDescription LIKE '%SPUT%' AND ProductionLotNumber = @Search Order by TrackOutTime ASC"

            command.Parameters.AddWithValue("@Search", Sput_Form.txtSearch.Text)

            Dim rdr As SqlDataReader = command.ExecuteReader

            table.Load(rdr)

            Sput_Form.DataGridView1.DataSource = table

            ' Bold the header cells
            For Each column As DataGridViewColumn In Sput_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 9, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
            Next

            With Sput_Form
                '.DataGridView1.Columns("NMR").ReadOnly = False
                .DataGridView1.Columns("NMR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                .DataGridView1.Columns("ProductionLotNumber").ReadOnly = True
                .DataGridView1.Columns("ProductionLotNumber").HeaderText = "Production Lot Number"

                .DataGridView1.Columns("EQPDescription").ReadOnly = True
                .DataGridView1.Columns("EQPDescription").HeaderText = "EQP Description"

                .DataGridView1.Columns("TrackOutTime").ReadOnly = True
                .DataGridView1.Columns("TrackOutTime").HeaderText = "TrackOut Time"

                .DataGridView1.Columns("ReedType").ReadOnly = True
                .DataGridView1.Columns("ReedType").HeaderText = "Reed Type"

                .DataGridView1.Columns("Qty").ReadOnly = True

                .DataGridView1.Columns("Description").ReadOnly = True

                .DataGridView1.Columns("LotCode").ReadOnly = True

                '.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(116, 185, 255)
                .DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                .DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                .DataGridView1.EnableHeadersVisualStyles = False
                .DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

            End With

        End If

        ConClose()
    End Sub

    Sub Load_SPUT_TextSearch()
        Try
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            Dim query As String

            If Sput_Form.txtSearch.Text = "" Or Sput_Form.txtSearch.Text = "Search lot number" Then
                query = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                                 FROM WIPM_Data_tb WHERE EQPDescription Like '%SPUT%' Order by TrackOutTime ASC"
            Else
                query = "SELECT NMR, ProductionLotNumber, EQPDescription, TrackOutTime, ReedType, Qty, Description, LotCode 
                       FROM WIPM_Data_tb 
                       WHERE EQPDescription LIKE '%SPUT%' AND ProductionLotNumber LIKE @Search Order by TrackOutTime ASC"

            End If

            adap = New SqlDataAdapter(query, Dbconnection)

            If Sput_Form.txtSearch.Text <> "" Then
                adap.SelectCommand.Parameters.AddWithValue("@Search", "%" & Sput_Form.txtSearch.Text & "%")
            End If

            ConOpen()
            adap.Fill(Data)
            ConClose()

            Sput_Form.DataGridView1.DataSource = Data

            ' Bold the header cells
            For Each column As DataGridViewColumn In Sput_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 9, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
            Next

            With Sput_Form
                '.DataGridView1.Columns("NMR").ReadOnly = False
                .DataGridView1.Columns("NMR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                .DataGridView1.Columns("ProductionLotNumber").ReadOnly = True
                .DataGridView1.Columns("ProductionLotNumber").HeaderText = "Production Lot Number"

                .DataGridView1.Columns("EQPDescription").ReadOnly = True
                .DataGridView1.Columns("EQPDescription").HeaderText = "EQP Description"

                .DataGridView1.Columns("TrackOutTime").ReadOnly = True
                .DataGridView1.Columns("TrackOutTime").HeaderText = "TrackOut Time"

                .DataGridView1.Columns("ReedType").ReadOnly = True
                .DataGridView1.Columns("ReedType").HeaderText = "Reed Type"

                .DataGridView1.Columns("Qty").ReadOnly = True

                .DataGridView1.Columns("Description").ReadOnly = True

                .DataGridView1.Columns("LotCode").ReadOnly = True

                '.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(116, 185, 255)
                .DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227)
                .DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                .DataGridView1.EnableHeadersVisualStyles = False
                .DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 104, 169)

            End With

        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Save_SPUT_Changes()
        ConOpen()

        For Each row As DataGridViewRow In Sput_Form.DataGridView1.Rows
            ' Skip the new row at the bottom
            If row.IsNewRow Then Continue For

            ' Get checkbox value
            Dim isChecked As Boolean = False
            If Not IsDBNull(row.Cells("NMR").Value) Then
                isChecked = Convert.ToBoolean(row.Cells("NMR").Value)
            End If

            ' Get values from the row
            Dim lotNumber As String = row.Cells("ProductionLotNumber").Value.ToString()
            Dim trackOutTime As String = row.Cells("TrackOutTime").Value.ToString()
            Dim eqpDescription As String = row.Cells("EQPDescription").Value.ToString()

            ' Build SQL update with additional conditions
            Dim updateCmd As New SqlCommand("UPDATE WIPM_Data_tb SET NMR = @NMR WHERE ProductionLotNumber = @LotNumber AND TrackOutTime = @TrackOutTime AND EQPDescription = @EQPDescription", Dbconnection)
            updateCmd.Parameters.AddWithValue("@NMR", If(isChecked, 1, 0))
            updateCmd.Parameters.AddWithValue("@LotNumber", lotNumber)
            updateCmd.Parameters.AddWithValue("@TrackOutTime", trackOutTime)
            updateCmd.Parameters.AddWithValue("@EQPDescription", eqpDescription)

            ' Execute the update
            updateCmd.ExecuteNonQuery()

            ' Also update WIPM_Process_tb based on LotNumber
            Dim updateProcessCmd As New SqlCommand("
            UPDATE WIPM_Process_tb 
            SET NMR = @NMR 
            WHERE Lot_Number = @LotNumber", Dbconnection)
            updateProcessCmd.Parameters.AddWithValue("@NMR", If(isChecked, 1, 0))
            updateProcessCmd.Parameters.AddWithValue("@LotNumber", lotNumber)
            updateProcessCmd.ExecuteNonQuery()
        Next

        ConClose()

        MessageBox.Show("Changes saved successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If Sput_Form.txtSearch.Text = "" Or Sput_Form.txtSearch.Text = "Search lot number" Then
            ' Reload the data after saving changes
            Load_SPUT()
        Else
            Load_SPUT_TextSearch()
        End If

    End Sub

    '============================= < FOR INSERT LOT NUMBER > ============================

    Sub ProcessWIPMData()
        Try
            ConOpen()

            ' STEP 1: Load all existing Lot_Numbers
            Dim existingLots As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
            Using lotCmd As New SqlCommand("SELECT Lot_Number FROM WIPM_Process_tb", Dbconnection)
                Using lotReader = lotCmd.ExecuteReader()
                    While lotReader.Read()
                        existingLots.Add(lotReader("Lot_Number").ToString())
                    End While
                End Using
            End Using

            ' STEP 2: Read data from WIPM_Data_tb
            Dim dataList As New List(Of Dictionary(Of String, Object))
            Using selectCmd As New SqlCommand("SELECT ProductionLotNumber, EQPDescription, ReedType, Qty FROM WIPM_Data_tb", Dbconnection)
                Using reader = selectCmd.ExecuteReader()
                    While reader.Read()
                        Dim row As New Dictionary(Of String, Object) From {
                        {"LotNumber", reader("ProductionLotNumber").ToString()},
                        {"EQPDescription", reader("EQPDescription").ToString().ToUpper()},
                        {"ReedType", reader("ReedType").ToString()},
                        {"Qty", Convert.ToInt32(reader("Qty"))}
                    }
                        dataList.Add(row)
                    End While
                End Using
            End Using

            ' STEP 3: Use Transaction
            Dim trans As SqlTransaction = Dbconnection.BeginTransaction()

            For Each row In dataList
                Dim lotNumber As String = row("LotNumber")
                Dim eqpDesc As String = row("EQPDescription")
                Dim reedType As String = row("ReedType")
                Dim qty As Integer = row("Qty")

                ' Determine output column
                Dim columnToUpdate As String = ""
                If eqpDesc.Contains("PUNCHPRESS") Then columnToUpdate = "PP_Out"
                If eqpDesc.Contains("DEBUR") Then columnToUpdate = "Vib_Out"
                If eqpDesc.Contains("RAMCO") Then columnToUpdate = "LW_Out"
                If eqpDesc.Contains("ANNEAL") Then columnToUpdate = "Annealing_Out"
                If eqpDesc.Contains("SPUT") Then columnToUpdate = "Sput_Out"

                If Not existingLots.Contains(lotNumber) Then
                    ' INSERT: Set only one column with qty, others 0
                    Dim insertQuery As String = $"
                INSERT INTO WIPM_Process_tb (
                    Product, Lot_Number,
                    PP_In, PP_Out,
                    Vib_In, Vib_Out,
                    LW_In, LW_Out,
                    Annealing_In, Annealing_Out,
                    Wash_In, Wash_Out,
                    Sput_In, Sput_Out,
                    SAM_In, SAM_Out,
                    Target_WIP, GAP, DateTime, NMR
                ) VALUES (
                    @Product, @LotNumber,
                    0, @PP_Out,
                    0, @Vib_Out,
                    0, @LW_Out,
                    0, @Annealing_Out,
                    0, 0,
                    0, @Sput_Out,
                    0, 0,
                    0, 0, GETDATE(), 0
                )"
                    Using insertCmd As New SqlCommand(insertQuery, Dbconnection, trans)
                        insertCmd.Parameters.AddWithValue("@Product", reedType)
                        insertCmd.Parameters.AddWithValue("@LotNumber", lotNumber)
                        insertCmd.Parameters.AddWithValue("@PP_Out", If(columnToUpdate = "PP_Out", qty, 0))
                        insertCmd.Parameters.AddWithValue("@Vib_Out", If(columnToUpdate = "Vib_Out", qty, 0))
                        insertCmd.Parameters.AddWithValue("@LW_Out", If(columnToUpdate = "LW_Out", qty, 0))
                        insertCmd.Parameters.AddWithValue("@Annealing_Out", If(columnToUpdate = "Annealing_Out", qty, 0))
                        insertCmd.Parameters.AddWithValue("@Sput_Out", If(columnToUpdate = "Sput_Out", qty, 0))
                        insertCmd.ExecuteNonQuery()
                    End Using
                    existingLots.Add(lotNumber)
                ElseIf columnToUpdate <> "" Then
                    ' UPDATE: Only update if NMR is not 1
                    Dim updateQuery As String = $"
                UPDATE WIPM_Process_tb 
                SET {columnToUpdate} = @Qty 
                WHERE Lot_Number = @LotNumber AND ISNULL(NMR, 0) <> 1"
                    Using updateCmd As New SqlCommand(updateQuery, Dbconnection, trans)
                        updateCmd.Parameters.AddWithValue("@Qty", qty)
                        updateCmd.Parameters.AddWithValue("@LotNumber", lotNumber)
                        updateCmd.ExecuteNonQuery()
                    End Using
                End If
            Next

            trans.Commit()
            MessageBox.Show("WIPM_Process_tb updated successfully (excluding NMR=1 rows).")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Subtract_VibOut()
        Try
            ConOpen()

            ' Efficient batch update: only where PP_Out > 0 and NMR = 0
            Dim updateQuery As String = "
            UPDATE WIPM_Process_tb
            SET PP_Out = CASE 
                            WHEN PP_Out - Vib_Out < 0 THEN 0 
                            ELSE PP_Out - Vib_Out 
                         END
            WHERE PP_Out > 0 AND NMR = 0
        "

            Using updateCmd As New SqlCommand(updateQuery, Dbconnection)
                Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()
                MessageBox.Show("PP_Out updated for " & rowsAffected & " records where NMR = 0 and PP_Out > 0.")
            End Using

        Catch ex As Exception
            MessageBox.Show("Error in Subtracting Debur out: " & ex.Message)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Subtract_LWOut()
        Try
            ConOpen()

            ' Efficient batch update: only where Vib_Out > 0 and NMR = 0
            Dim updateQuery As String = "
            UPDATE WIPM_Process_tb
            SET Vib_Out = CASE 
                            WHEN Vib_Out - LW_Out < 0 THEN 0 
                            ELSE Vib_Out - LW_Out 
                         END
            WHERE Vib_Out > 0 AND NMR = 0
        "

            Using updateCmd As New SqlCommand(updateQuery, Dbconnection)
                Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()
                MessageBox.Show("Vib_Out updated for " & rowsAffected & " records where NMR = 0 and Vib_Out > 0.")
            End Using

        Catch ex As Exception
            MessageBox.Show("Error in Subtracting Load and Wash Out: " & ex.Message)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Subtract_AnnealingOut()
        Try
            ConOpen()

            ' Efficient batch update: only where LW_Out > 0 and NMR = 0
            Dim updateQuery As String = "
            UPDATE WIPM_Process_tb
            SET LW_Out = CASE 
                            WHEN LW_Out - Annealing_Out < 0 THEN 0 
                            ELSE LW_Out - Annealing_Out 
                         END
            WHERE LW_Out > 0 AND NMR = 0
        "

            Using updateCmd As New SqlCommand(updateQuery, Dbconnection)
                Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()
                MessageBox.Show("LW_Out updated for " & rowsAffected & " records where NMR = 0 and LW_Out > 0.")
            End Using

        Catch ex As Exception
            MessageBox.Show("Error in Subtracting Annealing out: " & ex.Message)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Subtract_SputOut()
        Try
            ConOpen()

            ' Efficient batch update: only where Annealing_Out > 0 and NMR = 0
            Dim updateQuery As String = "
            UPDATE WIPM_Process_tb
            SET Annealing_Out = CASE 
                            WHEN Annealing_Out - Sput_Out < 0 THEN 0 
                            ELSE Annealing_Out - Sput_Out 
                         END
            WHERE Annealing_Out > 0 AND NMR = 0
        "

            Using updateCmd As New SqlCommand(updateQuery, Dbconnection)
                Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()
                MessageBox.Show("Annealing_Out updated for " & rowsAffected & " records where NMR = 0 and Annealing_Out > 0.")
            End Using

        Catch ex As Exception
            MessageBox.Show("Error in Subtracting Annealing out: " & ex.Message)
        Finally
            ConClose()
        End Try
    End Sub

End Module