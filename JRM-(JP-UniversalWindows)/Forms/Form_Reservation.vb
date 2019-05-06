Imports MySql.Data.MySqlClient

Public Class Form_Reservation
    Public tempSub As Double = 0
    Public SubTot As Double = 0.00
    Public GrandTotal As Double = 0
    Public PartialTotal As Double = 0

    Public Venues(5) As Integer
    Public StopV = 0
    Public Items(5) As Integer
    Public ItemsMuch(5) As Integer
    Public StopI = 0


    Dim NewTransactionID As Integer
    Dim selectedRowIndex As Integer

    Dim time As DateTime = DateTime.Now
    Dim format As String = "yyyy-MM-dd"
    Dim dateoutnew = Now.AddDays(1D)


    Public checkinform
    Private Sub CheckinForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        transID()
        clearAll()
        resettable()

        displayReserved(DataGridView2, "")
        DisplayR(DataGridView3, Nothing)

        Me.WindowState = FormWindowState.Normal
    End Sub
    Public Sub resettable()
        table2.Rows.Clear()
        If continueonce = 0 Then
            table2.Columns.Add("ID", Type.GetType("System.String"))
            table2.Columns.Add("ITEM", Type.GetType("System.String"))
            table2.Columns.Add("Price", Type.GetType("System.Double"))
            table2.Columns.Add("Qty", Type.GetType("System.Double"))
            table2.Columns.Add("SubTotal", Type.GetType("System.Double"))
            table2.Columns.Add("TYPE", Type.GetType("System.String"))
            DataGridView1.DataSource = table2
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AllowUserToAddRows = False

            DataGridView1.Columns(0).Visible = False
            ''DataGridView1.Columns(2).Width = 40
            ''DataGridView1.Columns(3).Width = 30

            DataGridView1.Columns(2).DefaultCellStyle.Format = "n2"
            DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridView1.Columns(3).DefaultCellStyle.Format = "n2"
            DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridView1.Columns(4).DefaultCellStyle.Format = "n2"
            DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            ''DataGridView1.Columns(4).Width = 45
            DataGridView1.Columns(5).Visible = False
            ''DataGridView1.Columns(5).Width = 0
            continueonce = 1
        End If
    End Sub

    Public Sub clearAll()
        Array.Clear(Venues, 0, Venues.Length)
        StopV = 0
        Array.Clear(Items, 0, Items.Length)
        Array.Clear(ItemsMuch, 0, ItemsMuch.Length)
        StopI = 0

        ''table2 = New DataTable("Table2")
        txtGuest.Text = "___________________________________"
        ComboBox1.Text = "25.00"
        txtTotal.Text = 0
        txtAdvance.Clear()
        lblGrandTotal.Text = 00.00
        tempSub = 0
        SubTot = 0.0
        GrandTotal = 0
        PartialTotal = 0
        CheckGuestID = Nothing

        time = DateTime.Now
        dateoutnew = Now.AddDays(1D)
        DateTimePicker1.Text = time.ToString(format)


        ''Page2
        lblName.Text = ""
        lblTransID.Text = ""
        ReservedID = Nothing
    End Sub

    Public Sub transID()
        closeDB()
        conndb()
        Dim dt As New DataTable("table_transactions")
        rs = New MySqlDataAdapter("SELECT * FROM table_transactions ORDER BY T_ID DESC", conn)
        rs.Fill(dt)

        If dt.Rows.Count = 0 Then
            txtTransID.Text = "TransID - 0001"
        Else
            Dim value As Integer = Val(dt.Rows(0).Item("T_ID"))
            value = value + 1
            txtTransID.Text = "TransID - " & value.ToString("0000")
            trans_ID = value
        End If
        rs.Dispose()
        closeDB()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Pick_Guest.Click
        Form_Checkin_Guest.ShowDialog()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button_Add_Persons.Click

        Dim item As String
        item = "Quantity of [Persons]"

        Dim price As Double
        price = Double.Parse(ComboBox1.Text).ToString("n2")

        Dim selected As Double
        Try
            selected = Double.Parse(InputBox("Enter How Many Persons", "Enter Data", 1, -1, -1))
        Catch ex As Exception
            selected = 1
        End Try

        Dim total As Double
        total = Double.Parse(selected * price)
        SubTot += total

        table2.Rows.Add(9001, item, price, selected, total, "P000")

        DataGridView1.DataSource = table2

        Dim i As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            PartialTotal = Double.Parse(DataGridView1.Rows(i).Cells(4).Value)
        Next i

        'GrandTotal = GrandTotal + PartialTotal
        GrandTotal += PartialTotal
        lblGrandTotal.Text = Double.Parse(FormatNumber(GrandTotal)).ToString("n2")
        ''TextBox1.Text = tempSub.ToString("n2")
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        'table2.Rows.Clear()
        'table2.Columns.Clear()
        SubTot = 0
        'CI = 0
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_Pick_Locations.Click
        'Dim fdata As New Form_Checkin_Venue()
        'fdata.MdiParent = Me.MdiParent
        'fdata.Show()
        If StopV = 5 Then
            Exit Sub
        End If
        Form_Checkin_Venue.ShowDialog()
    End Sub

    Private Sub Down_Click(sender As Object, e As EventArgs)
        If DataGridView1.Rows.Count >= 1 Then
            Dim i As Integer = DataGridView1.CurrentRow.Index + 1
            If (i >= -1 And i < DataGridView1.Rows.Count) Then
                DataGridView1.CurrentCell = DataGridView1.Rows(i).Cells(2)
            End If
        End If
    End Sub

    Private Sub Up_Click(sender As Object, e As EventArgs)
        If (DataGridView1.Rows.Count >= 1) Then
            Dim i As Integer = DataGridView1.CurrentRow.Index - 1
            If (i >= 0 And i < DataGridView1.Rows.Count) Then
                DataGridView1.CurrentCell = DataGridView1.Rows(i).Cells(2)
            End If
        End If
    End Sub

    Private Sub Button_Remove_Click(sender As Object, e As EventArgs)
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("Please select an item to remove", vbCritical, "No item selected")
            Exit Sub
        End If
        If MsgBox("Are you sure you want to remove this item off the list?", vbQuestion + vbYesNo, "Remove Item") = vbYes Then

            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            GrandTotal = 0
            PartialTotal = 0
            Dim i As Integer
            For i = 0 To DataGridView1.Rows.Count - 1
                PartialTotal = PartialTotal + Double.Parse(DataGridView1.Rows(i).Cells(4).Value)
            Next i
            GrandTotal = GrandTotal + PartialTotal
            lblGrandTotal.Text = FormatNumber(GrandTotal)
        End If
    End Sub
    Private Sub Button_CheckIN_Click(sender As Object, e As EventArgs) Handles Button_RESERVE.Click

        If CheckGuestID = Nothing Then
            MsgBox("Please Select A Guest", vbInformation, "Note [Error: No Guest Selected]")
        ElseIf txtAdvance.Text = Nothing Then
            MsgBox("Please Fill The Advance Payement Textbox", vbInformation, "Note [Error: No Payment]")
        Else
            If MsgBox(" GrandTotal : " & lblGrandTotal.Text & " is the total transaction to the selected guest?", vbQuestion + vbYesNo, "Charge Transaction") = vbYes Then
                ''
                Dim insert_command1 As New MySqlCommand("INSERT INTO `Table_Transactions`(`U_id`, `G_id`, `TransDate`, `Status`, `checkin`, `checkout`, `discount`, `advance`, `total`) VALUES (@a,@b,@c,@d,@e,@f,@g,@h,@i)", connection)
                insert_command1.Parameters.Add("@a", MySqlDbType.Int64).Value = UID
                insert_command1.Parameters.Add("@b", MySqlDbType.Int64).Value = CheckGuestID
                insert_command1.Parameters.Add("@c", MySqlDbType.DateTime).Value = DateTime.Now
                insert_command1.Parameters.Add("@d", MySqlDbType.VarChar).Value = "Reserved"
                insert_command1.Parameters.Add("@e", MySqlDbType.Date).Value = time.ToString(format)
                insert_command1.Parameters.Add("@f", MySqlDbType.Date).Value = time.AddDays(1D).ToString(format)
                insert_command1.Parameters.Add("@g", MySqlDbType.Double).Value = txtDiscount.Text
                insert_command1.Parameters.Add("@h", MySqlDbType.Double).Value = txtAdvance.Text
                insert_command1.Parameters.Add("@i", MySqlDbType.Double).Value = txtTotal.Text

                If execCommand(insert_command1) Then

                    Dim update_guest As New MySqlCommand("UPDATE tblGuests SET Remarks = 'Reserved' WHERE GuestID = " & CheckGuestID & "", connection)
                    update_guest.ExecuteNonQuery()

                    ''Venues
                    Dim x As Integer = 0
                    For x = 0 To Venues(x)
                        If Venues(x) = Nothing Then
                        Else
                            Dim update_Venue As New MySqlCommand("UPDATE tblVenue SET Status = 'Reserved' WHERE VenueID = " & Venues(x) & "", connection)
                            update_Venue.ExecuteNonQuery()
                        End If
                    Next x

                    ''Items
                    Dim y As Integer = 0
                    For y = 0 To Items(5 - y)
                        If Items(y) = Nothing Then
                        Else
                            Dim newQTY As Integer
                            mysql = "SELECT Item_Qty FROM table_items WHERE Item_ID = " & Items(y)
                            closeDB()
                            conndb()
                            cmd = New MySqlCommand(mysql, conn)
                            dr = cmd.ExecuteReader
                            Do Until dr.Read = False
                                newQTY = dr("item_Qty")
                            Loop
                            closeDB()

                            If (newQTY <= Val(ItemsMuch(y))) Then
                                mysql = "UPDATE table_items SET item_Qty = " & newQTY & ", Item_Status = '4'" &
                                " WHERE Item_Id = " & Items(y)
                                closeDB()
                                conndb()
                                cmd = New MySqlCommand(mysql, conn)
                                cmd.ExecuteNonQuery()
                                closeDB()
                            Else
                                mysql = "UPDATE table_items SET item_Qty = " & newQTY - Val(ItemsMuch(y)) & "" &
                                " WHERE Item_Id = " & Items(y)
                                closeDB()
                                conndb()
                                cmd = New MySqlCommand(mysql, conn)
                                cmd.ExecuteNonQuery()
                                closeDB()
                            End If
                        End If
                    Next y


                    ''Table Transactions Details
                    Dim command As New MySqlCommand("SELECT MAX(`T_id`) FROM `Table_Transactions`", connection)
                    NewTransactionID = command.ExecuteScalar().ToString()
                    closeDB()
                    Dim i As Integer
                    For i = 0 To Me.DataGridView1.Rows.Count - 1
                        If (Me.DataGridView1.Rows(i).Cells(5).Value = "P000") Then
                            mysql = "INSERT INTO `Table_TransactionDetails`(`T_id`, `Item_Name`, `Item_Price`, `Quantity`, `SubTotal`, `Item_ID`, `Type`) " &
                                                "VALUES (@aa,@bb,@cc,@dd,@ee,@ff,@gg)"
                            closeDB()
                            conndb()
                            cmd = New MySqlCommand(mysql, conn)
                            With cmd
                                .Parameters.AddWithValue("@aa", NewTransactionID)
                                .Parameters.AddWithValue("@bb", Me.DataGridView1.Rows(i).Cells(1).Value)
                                .Parameters.AddWithValue("@cc", Me.DataGridView1.Rows(i).Cells(2).Value)
                                .Parameters.AddWithValue("@dd", Me.DataGridView1.Rows(i).Cells(3).Value)
                                .Parameters.AddWithValue("@ee", Me.DataGridView1.Rows(i).Cells(4).Value)
                                .Parameters.AddWithValue("@ff", Me.DataGridView1.Rows(i).Cells(0).Value)
                                .Parameters.AddWithValue("@gg", Me.DataGridView1.Rows(i).Cells(5).Value)
                                .ExecuteNonQuery()
                            End With
                            closeDB()
                        ElseIf (Me.DataGridView1.Rows(i).Cells(5).Value = "V000") Then
                            mysql = "INSERT INTO `Table_TransactionDetailsVENUE`(`T_id`, `Item_Name`, `Item_Price`, `Quantity`, `SubTotal`, `Item_ID`, `Type`) " &
                                                "VALUES (@aa,@bb,@cc,@dd,@ee,@ff,@gg)"
                            closeDB()
                            conndb()
                            cmd = New MySqlCommand(mysql, conn)
                            With cmd
                                .Parameters.AddWithValue("@aa", NewTransactionID)
                                .Parameters.AddWithValue("@bb", Me.DataGridView1.Rows(i).Cells(1).Value)
                                .Parameters.AddWithValue("@cc", Me.DataGridView1.Rows(i).Cells(2).Value)
                                .Parameters.AddWithValue("@dd", Me.DataGridView1.Rows(i).Cells(3).Value)
                                .Parameters.AddWithValue("@ee", Me.DataGridView1.Rows(i).Cells(4).Value)
                                .Parameters.AddWithValue("@ff", Me.DataGridView1.Rows(i).Cells(0).Value)
                                .Parameters.AddWithValue("@gg", Me.DataGridView1.Rows(i).Cells(5).Value)
                                .ExecuteNonQuery()
                            End With
                            closeDB()

                        ElseIf (Me.DataGridView1.Rows(i).Cells(5).Value = "I000") Then
                            mysql = "INSERT INTO `Table_TransactionDetailsITEM`(`T_id`, `Item_Name`, `Item_Price`, `Quantity`, `SubTotal`, `Item_ID`, `Type`) " &
                                                "VALUES (@aa,@bb,@cc,@dd,@ee,@ff,@gg)"
                            closeDB()
                            conndb()
                            cmd = New MySqlCommand(mysql, conn)
                            With cmd
                                .Parameters.AddWithValue("@aa", NewTransactionID)
                                .Parameters.AddWithValue("@bb", Me.DataGridView1.Rows(i).Cells(1).Value)
                                .Parameters.AddWithValue("@cc", Me.DataGridView1.Rows(i).Cells(2).Value)
                                .Parameters.AddWithValue("@dd", Me.DataGridView1.Rows(i).Cells(3).Value)
                                .Parameters.AddWithValue("@ee", Me.DataGridView1.Rows(i).Cells(4).Value)
                                .Parameters.AddWithValue("@ff", Me.DataGridView1.Rows(i).Cells(0).Value)
                                .Parameters.AddWithValue("@gg", Me.DataGridView1.Rows(i).Cells(5).Value)
                                .ExecuteNonQuery()
                            End With
                            closeDB()

                        End If

                    Next i
                Else
                    MessageBox.Show("Data NOT Inserted")
                    Exit Sub
                End If
                ''

                MsgBox("Transaction has been charged to the selected guest", vbInformation, "Charged to guest")
                displayReserved(DataGridView2, "")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button_Add_Item_Click(sender As Object, e As EventArgs) Handles Button_Pick_Item.Click
        If StopI = 15 Then
            Exit Sub
        End If
        Form_Checkin_Item.ShowDialog()
    End Sub
    Private Sub Form_Checkin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        clearAll()
        ReservedID = 0
        SubTot = 0
    End Sub

    'Payments
    Private Sub TxtAdvance_TextChanged(sender As Object, e As EventArgs) Handles txtAdvance.TextChanged
        If txtAdvance.Text = "" Or txtDiscount.Text = "" Then
            Exit Sub
        End If
        Dim Grand As Double
        Dim Advan As Double
        Dim Disco As Double
        Try
            Grand = Double.Parse(lblGrandTotal.Text)
            Advan = Double.Parse(txtAdvance.Text)
            Disco = Double.Parse(txtDiscount.Text)
        Catch ex As Exception

        End Try

        txtTotal.Text = ((Grand - Advan) - Disco).ToString("00.00")
        If Grand <= Advan Then
            txtTotal.Text = "0.00"
        End If
    End Sub
    Private Sub TxtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged

        If txtAdvance.Text = "" Or txtDiscount.Text = "" Then
            Exit Sub
        End If
        Dim Grand As Double
        Dim Advan As Double
        Dim Disco As Double
        Try
            Grand = Double.Parse(lblGrandTotal.Text)
            Advan = Double.Parse(txtAdvance.Text)
            Disco = Double.Parse(txtDiscount.Text)
        Catch ex As Exception

        End Try

        'Label6.Text = (Grand - Disco) - Advan
        txtTotal.Text = ((Grand - Advan) - Disco).ToString("00.00")
        If Grand <= Advan Then
            txtTotal.Text = "0.00"
        End If
    End Sub

    'payments

    Private Sub TxtDiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscount.KeyPress, ComboBox1.KeyPress, txtAdvance.KeyPress
        OnlyNumbers(e)
    End Sub

    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click
        Try
            ReservedID = DataGridView2.CurrentRow.Cells(0).Value
            lblTransID.Text = "TransID - " & ReservedID.ToString("0000")
            lblName.Text = DataGridView2.CurrentRow.Cells(11).Value
            DisplayR(DataGridView3, ReservedID)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        displayReserved(DataGridView2, TextBox1.Text)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If ReservedID = Nothing Then
            Exit Sub
        Else
            connection.Open()
            Dim update_guest As New MySqlCommand("UPDATE tblGuests SET Remarks = 'Checkin' WHERE GuestID = " & DataGridView2.CurrentRow.Cells("G_ID").Value & "", connection)
            update_guest.ExecuteNonQuery()
            connection.Dispose()
            connection.Close()

            connection.Open()
            Dim update_transactions As New MySqlCommand("UPDATE table_transactions SET Status = 'Checkin' WHERE T_ID = " & DataGridView2.CurrentRow.Cells(0).Value & "", connection)
            update_transactions.ExecuteNonQuery()
            connection.Dispose()
            connection.Close()

            Dim k As Integer = 0
            Dim nono As Integer = 0
            For k = 0 To DataGridView3.Rows.Count - 1
                If DataGridView3.Rows(k).Cells("Type").Value = "V000" Then
                    nono = Integer.Parse(DataGridView3.Rows(k).Cells("Item_ID").Value)
                    mysql = "UPDATE tblVenue SET Status = @status" &
                     " WHERE VenueID = @ID"
                    conndb()
                    cmd = New MySqlCommand(mysql, conn)
                    With cmd
                        .Parameters.AddWithValue("@status", "Occupied")
                        .Parameters.AddWithValue("@ID", nono)
                        .ExecuteNonQuery()
                    End With
                    closeDB()
                End If
            Next k

            clearAll()
            displayReserved(DataGridView2, "")
            DisplayR(DataGridView3, Nothing)
            MsgBox("Transaction has been charged to the selected guest", vbInformation, "Guest Successfully Checked-IN")
        End If
    End Sub
    Public Sub DisplayR(datagrid As DataGridView, valueToSearch As Integer)
        table2.Rows.Clear()
        Array.Clear(Venues, 0, Venues.Length)
        StopV = 0
        Array.Clear(Items, 0, Items.Length)
        Array.Clear(ItemsMuch, 0, ItemsMuch.Length)
        StopI = 0

        Dim table As New DataTable()
        ''====    ====    ====    ====    Persons    ====    ====    ====    ====    
        Dim searchQuery As String = "SELECT * FROM table_transactions , table_transactiondetails WHERE 
        table_transactions.T_id = table_transactiondetails.T_id AND table_transactions.`Status` = 'Reserved' AND
        table_transactionDetails.T_id = '" & valueToSearch & "'"
        Dim command As New MySqlCommand(searchQuery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        adapter.Fill(table)
        ''====    ====    ====    ====    Venue    ====    ====    ====    ====    
        Dim searchQuery2 As String = "SELECT * FROM table_transactions , table_transactiondetailsvenue WHERE
        table_transactions.T_id = table_transactiondetailsvenue.T_id AND table_transactions.`Status` = 'Reserved' AND
        table_transactiondetailsvenue.T_id = '" & valueToSearch & "'"
        Dim command2 As New MySqlCommand(searchQuery2, connection)
        Dim adapter2 As New MySqlDataAdapter(command2)
        adapter2.Fill(table)

        connection.Open()
        dr = command2.ExecuteReader
        Do Until dr.Read = False
            Venues(StopV) = dr("Item_ID")
            StopV = StopV + 1
        Loop
        connection.Dispose()
        connection.Close()
        ''====    ====    ====    ====    Items    ====    ====    ====    ====   
        Dim searchQuery3 As String = "SELECT * FROM table_transactions , table_transactiondetailsitem WHERE
        table_transactions.T_id = table_transactiondetailsitem.T_id AND table_transactions.`Status` = 'Reserved' AND
        table_transactiondetailsitem.T_id = '" & valueToSearch & "'"

        Dim command3 As New MySqlCommand(searchQuery3, connection)
        Dim adapter3 As New MySqlDataAdapter(command3)
        adapter3.Fill(table)

        '' =======================================================================
        datagrid.AllowUserToAddRows = False
        datagrid.DataSource = table

        datagrid.MultiSelect = False
        datagrid.AllowUserToResizeColumns = False

        datagrid.DefaultCellStyle.SelectionForeColor = Color.Black
        datagrid.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 9.75, FontStyle.Bold)
        datagrid.DefaultCellStyle.Font = New Font("Segoe UI Semibold", 9.75)

        datagrid.AutoResizeColumns()

        datagrid.Columns("TDV_id").Visible = False
        datagrid.Columns("TDI_id").Visible = False
        datagrid.Columns(0).Visible = False
        datagrid.Columns(1).Visible = False
        datagrid.Columns(2).Visible = False
        datagrid.Columns(3).Visible = False
        datagrid.Columns(4).Visible = False
        datagrid.Columns(5).Visible = False
        datagrid.Columns(6).Visible = False
        datagrid.Columns(7).Visible = False
        datagrid.Columns(8).Visible = False
        datagrid.Columns(9).Visible = False
        datagrid.Columns(10).Visible = False
        datagrid.Columns(11).Visible = False
        datagrid.Columns(12).Visible = True
        datagrid.Columns(12).HeaderText = "Selected Items"
        datagrid.Columns(13).Visible = True
        datagrid.Columns(13).HeaderText = "Price"
        datagrid.Columns(14).Visible = True
        datagrid.Columns(14).HeaderText = "Qty"
        datagrid.Columns(15).Visible = True
        datagrid.Columns(15).HeaderText = "sub-Total"
        datagrid.Columns(16).Visible = False
        datagrid.Columns(17).Visible = False
    End Sub

    Private Sub Button_Cancel_Reservation_Click(sender As Object, e As EventArgs) Handles Button_Cancel_Reservation.Click
        If ReservedID = Nothing Then
            Exit Sub
        ElseIf MsgBox("Are you sure you want to cancel this Reservation?", vbQuestion + vbYesNo, "Cancel Reservation") = vbYes Then
            connection.Open()
            Dim update_guest As New MySqlCommand("UPDATE tblGuests SET Remarks = 'Available' WHERE GuestID = " & DataGridView2.CurrentRow.Cells("G_ID").Value & "", connection)
            update_guest.ExecuteNonQuery()
            connection.Dispose()
            connection.Close()

            connection.Open()
            Dim update_transactions As New MySqlCommand("UPDATE table_transactions SET Status = 'Canceled' WHERE T_ID = " & DataGridView2.CurrentRow.Cells(0).Value & "", connection)
            update_transactions.ExecuteNonQuery()
            connection.Dispose()
            connection.Close()

            Dim k As Integer = 0
            Dim nono As Integer = 0
            For k = 0 To DataGridView3.Rows.Count - 1
                If DataGridView3.Rows(k).Cells("Type").Value = "V000" Then
                    nono = Integer.Parse(DataGridView3.Rows(k).Cells("Item_ID").Value)
                    mysql = "UPDATE tblVenue SET Status = @status" &
                         " WHERE VenueID = @ID"
                    conndb()
                    cmd = New MySqlCommand(mysql, conn)
                    With cmd
                        .Parameters.AddWithValue("@status", "Available")
                        .Parameters.AddWithValue("@ID", nono)
                        .ExecuteNonQuery()
                    End With
                    closeDB()
                End If
            Next k

            clearAll()
            displayReserved(DataGridView2, "")
            MsgBox("Reservation has been Canceled", vbInformation, "Reservation Canceled")
            DisplayR(DataGridView3, Nothing)
        Else
            clearAll()
            displayReserved(DataGridView2, "")
            DisplayR(DataGridView3, Nothing)
        End If
    End Sub
End Class