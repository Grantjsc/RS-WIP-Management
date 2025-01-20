Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Threading
Imports System.Web
Imports System.Xml

Module Query_Module

    'Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\RS WIP Management.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfrswip
    'Data Source=BTMESSQLDEV03;Initial Catalog=LFPH_RS;Persist Security Info=True;User ID=mesph;Password=PHFuse;TrustServerCertificate=True


    '****************************< FOR GENERAL USE >****************************
    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\RS WIP Management.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfrswip"
    Public Dbconnection As New OleDbConnection(connString)

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
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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
            Using command As New OleDbCommand(mycommand, Dbconnection)
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
            Using command As New OleDbCommand(mycommand, Dbconnection)
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

    Public PP_In_Qty As Integer
    Public New_PP_In_Qty As Integer

    Sub Get_PunchPress_In()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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

            Using command As New OleDbCommand(query, Dbconnection)
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

        Try

            'Dim Prod As String = Form1.txtProduct.Text
            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text

            New_PP_In_Qty = PP_In_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET PP_In = @in, PP_Out = @Out
                                WHERE Lot_Number = @LotNum"

            Using command As New OleDbCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@in", New_PP_In_Qty)
                command.Parameters.AddWithValue("@Out", Quantity)
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
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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

    Public PP_Out_Qty As Integer
    Public New_PP_Out_Qty As Integer

    Sub Get_PunchPress_Out()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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

            Using command As New OleDbCommand(query, Dbconnection)
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

    Public Vib_In_Qty As Integer
    Public New_Vib_In_Qty As Integer

    Sub Get_Vib_In()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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
            Using command As New OleDbCommand(mycommand, Dbconnection)
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

        Try

            'Dim Prod As String = Form1.txtProduct.Text
            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text

            New_Vib_In_Qty = Vib_In_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET Vib_In = @Nin, Vib_Out = @Out
                                WHERE Lot_Number = @LotNum"

            Using command As New OleDbCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Nin", New_Vib_In_Qty)
                command.Parameters.AddWithValue("@Out", Quantity)
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

            Using command As New OleDbCommand(query, Dbconnection)

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
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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

    Public Vib_Out_Qty As Integer
    Public New_Vib_Out_Qty As Integer

    Sub Get_Vib_Out()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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

            Using command As New OleDbCommand(query, Dbconnection)
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

    Public LW_In_Qty As Integer
    Public New_LW_In_Qty As Integer

    Sub Get_LW_In()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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
            Using command As New OleDbCommand(mycommand, Dbconnection)
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

        Try

            'Dim Prod As String = Form1.txtProduct.Text
            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text

            New_LW_In_Qty = LW_In_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET LW_In = @Nin, LW_Out = @Out
                                WHERE Lot_Number = @LotNum"

            Using command As New OleDbCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Nin", New_Vib_In_Qty)
                command.Parameters.AddWithValue("@Out", Quantity)
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

            Using command As New OleDbCommand(query, Dbconnection)

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
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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

    Public LW_Out_Qty As Integer
    Public New_LW_Out_Qty As Integer

    Sub Get_LW_Out()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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

            Using command As New OleDbCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@LWout", New_Vib_Out_Qty)
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

    Public Ann_In_Qty As Integer
    Public New_Ann_In_Qty As Integer

    Sub Get_Annealing_In()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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
            Using command As New OleDbCommand(mycommand, Dbconnection)
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

        Try

            'Dim Prod As String = Form1.txtProduct.Text
            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text

            New_Ann_In_Qty = Ann_In_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET Annealing_In = @AnnIn, Annealing_Out = @Out
                                WHERE Lot_Number = @LotNum"

            Using command As New OleDbCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@AnnIn", New_Ann_In_Qty)
                command.Parameters.AddWithValue("@Out", Quantity)
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

            Using command As New OleDbCommand(query, Dbconnection)

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
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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

    Public Ann_Out_Qty As Integer
    Public New_Ann_Out_Qty As Integer

    Sub Get_Annealing_Out()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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

            Using command As New OleDbCommand(query, Dbconnection)
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

    Public Wash_In_Qty As Integer
    Public New_Wash_In_Qty As Integer

    Sub Get_Wash_In()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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
            Using command As New OleDbCommand(mycommand, Dbconnection)
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

        Try

            'Dim Prod As String = Form1.txtProduct.Text
            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text

            New_Wash_In_Qty = Wash_In_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET Wash_In = @Win, Wash_Out = @Out
                                WHERE Lot_Number = @LotNum"

            Using command As New OleDbCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Win", New_Wash_In_Qty)
                command.Parameters.AddWithValue("@Out", Quantity)
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

            Using command As New OleDbCommand(query, Dbconnection)

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
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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

    Public Wash_Out_Qty As Integer
    Public New_Wash_Out_Qty As Integer

    Sub Get_Wash_Out()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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

            Using command As New OleDbCommand(query, Dbconnection)
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

    Public Sput_In_Qty As Integer
    Public New_Sput_In_Qty As Integer

    Sub Get_Sput_In()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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
            Using command As New OleDbCommand(mycommand, Dbconnection)
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

        Try

            'Dim Prod As String = Form1.txtProduct.Text
            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text

            New_Sput_In_Qty = Sput_In_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET Sput_In = @Sin, Sput_Out = @Out
                                WHERE Lot_Number = @LotNum"

            Using command As New OleDbCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Sin", New_Sput_In_Qty)
                command.Parameters.AddWithValue("@Out", Quantity)
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

            Using command As New OleDbCommand(query, Dbconnection)

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
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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

    Public Sput_Out_Qty As Integer
    Public New_Sput_Out_Qty As Integer

    Sub Get_Sput_Out()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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

            Using command As New OleDbCommand(query, Dbconnection)
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

    Public SAM_In_Qty As Integer
    Public New_SAM_In_Qty As Integer

    Sub Get_SAM_In()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
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
            Using command As New OleDbCommand(mycommand, Dbconnection)
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

    Sub Add_SAM_Out_to_Processtb()

        Try

            'Dim Prod As String = Form1.txtProduct.Text
            Dim Lot As String = Form1.txtLot.Text
            Dim Quantity As String = Form1.txtQty.Text

            New_SAM_In_Qty = SAM_In_Qty - CInt(Quantity)

            Dim query As String = "UPDATE WIPM_Process_tb 
                                SET SAM_In = @Sin, SAM_Out = @Out
                                WHERE Lot_Number = @LotNum"

            Using command As New OleDbCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Sin", New_SAM_In_Qty)
                command.Parameters.AddWithValue("@Out", Quantity)
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

            Using command As New OleDbCommand(query, Dbconnection)

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

    Sub Load_Avail_WIP()
        Dim command As New OleDbCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            Try

                command.Connection = Dbconnection
                command.CommandText = "SELECT Product, SUM(PP_Out) AS PP_OUT, SUM(Vib_Out) AS VIB_OUT, " &
                                      "SUM(LW_Out) AS LW_OUT, SUM(Annealing_Out) AS ANN_OUT, " &
                                      "SUM(Wash_Out) AS W_OUT, SUM(Sput_Out) AS SPUT_OUT, SUM(SAM_OUT) AS SAM_OUT " &
                                      "FROM WIPM_Process_tb GROUP BY Product"


                Using rdr As OleDbDataReader = command.ExecuteReader()
                    table.Load(rdr)
                End Using

                ' Bind the DataTable to the DataGridView
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

    Public SAM_tOUT As Integer

    Sub Populate_WIP()
        Try
            Dim mydata As String
            Dim command As New OleDbCommand
            Dim data As New DataTable
            Dim adap As New OleDbDataAdapter
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
            Dim command As New OleDbCommand
            Dim data As New DataTable
            Dim adap As New OleDbDataAdapter
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
        Dim command As New OleDbCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            Try
                command.Connection = Dbconnection
                command.CommandText = "Select Product, SUM(PP_Out) As PP_OUT, SUM(Vib_Out) As VIB_OUT, " &
                                      "SUM(LW_Out) As LW_OUT, SUM(Annealing_Out) As ANN_OUT, " &
                                      "SUM(Wash_Out) As W_OUT, SUM(Sput_Out) As SPUT_OUT, SUM(SAM_OUT) As SAM_OUT " &
                                      "FROM WIPM_Process_tb " &
                                      "WHERE DateTime BETWEEN @StartDate AND @EndDate GROUP BY Product"

                Dim startDate As DateTime = WIP_Form.dtpStartDate.Value.Date
                Dim endDate As DateTime = WIP_Form.dtpEndDate.Value.Date.AddDays(1)
                command.Parameters.AddWithValue("@StartDate", startDate)
                command.Parameters.AddWithValue("@EndDate", endDate)

                Using rdr As OleDbDataReader = command.ExecuteReader()
                    table.Load(rdr)
                End Using

                WIP_Form.DataGridView1.DataSource = table

                ' Format DataGridView headers and styles
                For Each column As DataGridViewColumn In WIP_Form.DataGridView1.Columns
                    column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                    column.HeaderCell.Style.ForeColor = Color.White
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 10)
                Next

                WIP_Form.DataGridView1.Columns("Product").HeaderText = "Product Name"
                WIP_Form.DataGridView1.Columns("PP_OUT").HeaderText = "Punch Press Out"
                WIP_Form.DataGridView1.Columns("VIB_OUT").HeaderText = "Vibrator Out"
                WIP_Form.DataGridView1.Columns("LW_OUT").HeaderText = "Load and Wash Out"
                WIP_Form.DataGridView1.Columns("ANN_OUT").HeaderText = "Annealing Out"
                WIP_Form.DataGridView1.Columns("W_OUT").HeaderText = "Wash Out"
                WIP_Form.DataGridView1.Columns("SPUT_OUT").HeaderText = "Sput Out"
                WIP_Form.DataGridView1.Columns("SAM_OUT").HeaderText = "SAM Out"

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

    '**************************** < FOR ViewData_Form > ****************************
    Sub Load_ViewAll()
        Dim command As New OleDbCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            command.Connection = Dbconnection
            command.CommandText = "SELECT Product,SAM_Out, DateTime
                                    FROM WIPM_Process_tb ORDER BY DateTime"

            Dim rdr As OleDbDataReader = command.ExecuteReader

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
        Dim command As New OleDbCommand("", Dbconnection)
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

            Dim rdr As OleDbDataReader = command.ExecuteReader

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

End Module