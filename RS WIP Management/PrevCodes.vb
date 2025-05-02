''=======================< Loading Available WIP (WIP_Form) >===========================

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
'                Dim resetCmd As New SqlCommand("UPDATE WIPM_Process_tb SET [SAM_Out] = 0, [Target_WIP] = 0", Dbconnection)
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
'                                Dim updateSamOutCmd As New SqlCommand("UPDATE WIPM_Process_tb SET [SAM_Out] = @Gap WHERE [ID] = @ID", Dbconnection)
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
'                                  "SUM(LW_Out) AS LW_OUT, SUM(Annealing_Out) AS ANN_OUT, " &
'                                  "SUM(Wash_Out) AS W_OUT, SUM(Sput_Out) AS SPUT_OUT, " &
'                                  "SUM(SAM_OUT) AS SAM_OUT, MAX(Target_WIP) AS Target_WIP, MAX(GAP) AS GAP " &
'                                  "FROM WIPM_Process_tb " &
'                                  "GROUP BY Product"

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
'            WIP_Form.DataGridView1.Columns("W_OUT").HeaderText = "Wash Out"
'            WIP_Form.DataGridView1.Columns("SPUT_OUT").HeaderText = "Sput Out"
'            WIP_Form.DataGridView1.Columns("SAM_OUT").HeaderText = "SAM Out"
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

'Sub SAM_sub_Gap()
'    Dim command As New SqlCommand("", Dbconnection)
'    Dim table As New DataTable

'    ConOpen()

'    If Dbconnection.State = ConnectionState.Open Then
'        Try
'            ' Step 1: Load the original data with SUM(SAM_OUT) and MAX(GAP) grouped by product
'            command.Connection = Dbconnection
'            command.CommandText = "SELECT Product, SUM(SAM_OUT) AS Total_SAM_OUT, MAX(Target_WIP) AS Target " &
'                                  "FROM WIPM_Process_tb " &
'                                  "GROUP BY Product"

'            ' Execute the query and load the results into the DataTable
'            Using rdr As SqlDataReader = command.ExecuteReader()
'                table.Load(rdr)
'            End Using

'            ' Step 2: Update GAP for each row using the original SUM(SAM_OUT) and MAX(GAP)
'            For Each row As DataRow In table.Rows
'                Dim product As String = row("Product").ToString()
'                Dim totalSamOut As Integer = CInt(row("Total_SAM_OUT"))
'                Dim maxGap As Integer = CInt(row("Target"))

'                ' Calculate the new GAP as SUM(SAM_OUT) - MAX(GAP)
'                Dim newGap As Integer = totalSamOut - maxGap

'                ' Step 3: Update only the rows for the current product
'                ' Note: Reset GAP to the newly calculated value
'                Dim updateCmd As New SqlCommand("UPDATE WIPM_Process_tb " &
'                                                  "SET GAP = @NewGap " &
'                                                  "WHERE Product = @prod", Dbconnection)
'                updateCmd.Parameters.AddWithValue("@NewGap", newGap)
'                updateCmd.Parameters.AddWithValue("@prod", product)

'                updateCmd.ExecuteNonQuery()
'            Next

'            ' Notify success (optional)
'            ' MessageBox.Show("GAP values have been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

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