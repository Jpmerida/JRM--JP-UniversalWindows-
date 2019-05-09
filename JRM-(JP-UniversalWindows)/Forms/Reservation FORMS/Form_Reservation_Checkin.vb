Imports MySql.Data.MySqlClient

Public Class Form_Reservation_Checkin
    Public tempSub As Double = 0
    Public SubTot As Double = 0.00
    Public GrandTotal As Double = 0
    Public PartialTotal As Double = 0

    Public Venues(5) As Integer
    Public StopV = 0
    Public Items(5) As Integer
    Public ItemsMuch(5) As Integer
    Public StopI = 0

    Dim dcount As Double
    Dim advpay As Double

    Private Sub Form_Reservation_Checkin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetall()
        DisplayR(DataGridView3, ReservedID)
    End Sub
    Private Sub resetall()
        tempSub = 0
        SubTot = 0.00
        GrandTotal = 0
        PartialTotal = 0

        DataGridView1.Rows.Clear()
        table2.Rows.Clear()
        Array.Clear(Venues, 0, Venues.Length)
        StopV = 0
        Array.Clear(Items, 0, Items.Length)
        Array.Clear(ItemsMuch, 0, ItemsMuch.Length)
        StopI = 0

        dcount = 0
        advpay = 0
    End Sub
    Public Sub DisplayR(datagrid As DataGridView, valueToSearch As Integer)
        DataGridView1.Rows.Clear()
        table2.Rows.Clear()
        Array.Clear(Venues, 0, Venues.Length)
        StopV = 0
        Array.Clear(Items, 0, Items.Length)
        Array.Clear(ItemsMuch, 0, ItemsMuch.Length)
        StopI = 0

        Dim table As New DataTable()


        mysql = "SELECT * FROM table_Transactions WHERE T_ID ='" & valueToSearch & "'"
        closeDB()
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader
        Do Until dr.Read = False
            dcount = dr("discount")
            advpay = dr("Advance")
            Dim time As DateTime = dr("transdate")
            lbltime.Text = time.AddHours(12).ToString("t")
            txtDiscount.Text = Double.Parse(dcount).ToString("n2")
            lbladvancePay.Text = Double.Parse(advpay).ToString("n2")
        Loop
        closeDB()
        ''====    

        ''====    ====    ====    ====    GuestDetails    ====    ====    ====    ====    
        Dim searchQuery5 As String = "SELECT tblguests.`Name`, tblguestdetails.Fname, tblguestdetails.Mname, tblguestdetails.Lname FROM table_transactions ,
        tblguests, tblguestdetails WHERE table_transactions.G_id = tblguests.GuestID AND tblguests.GuestID = tblguestdetails.GuestID AND
        table_transactions.T_id = '" & valueToSearch & "'"
        Dim command5 As New MySqlCommand(searchQuery5, connection)
        connection.Dispose()
        connection.Close()
        connection.Open()
        dr = command5.ExecuteReader
        Do Until dr.Read = False
            'lblName.Text = dr("Name")
            lblName.Text = dr("Name")
            lblguestname.Text = dr("Fname") + " " + dr("Mname") + " " + dr("Lname")

        Loop
        connection.Dispose()
        connection.Close()
        ''====    ====    ====    ====    Persons    ====    ====    ====    ====    
        Dim searchQuery As String = "SELECT * FROM table_transactions , table_transactiondetails WHERE 
        table_transactions.T_id = table_transactiondetails.T_id AND table_transactions.`Status` = 'Reserved' AND
        table_transactionDetails.T_id = '" & valueToSearch & "'"
        Dim command As New MySqlCommand(searchQuery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        adapter.Fill(table)
        connection.Dispose()
        connection.Close()
        connection.Open()
        dr = command.ExecuteReader
        Do Until dr.Read = False
            DataGridView1.Rows.Add(dr("Item_ID"), dr("Item_Name"), Double.Parse(dr("Item_Price")).ToString("n2"), dr("Quantity"), Double.Parse(dr("Subtotal")).ToString("n2"), dr("Type"))

        Loop
        connection.Dispose()
        connection.Close()
        ''====    ====    ====    ====    Venue    ====    ====    ====    ====    
        Dim searchQuery2 As String = "SELECT * FROM table_transactions , table_transactiondetailsvenue WHERE
        table_transactions.T_id = table_transactiondetailsvenue.T_id AND table_transactions.`Status` = 'Reserved' AND
        table_transactiondetailsvenue.T_id = '" & valueToSearch & "'"
        Dim command2 As New MySqlCommand(searchQuery2, connection)
        Dim adapter2 As New MySqlDataAdapter(command2)
        adapter2.Fill(table)
        connection.Dispose()
        connection.Close()
        connection.Open()
        dr = command2.ExecuteReader
        Do Until dr.Read = False
            DataGridView1.Rows.Add(dr("Item_ID"), dr("Item_Name"), Double.Parse(dr("Item_Price")).ToString("n2"), dr("Quantity"), Double.Parse(dr("Subtotal")).ToString("n2"), dr("Type"))
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
        connection.Dispose()
        connection.Close()
        connection.Open()
        dr = command3.ExecuteReader
        Do Until dr.Read = False
            DataGridView1.Rows.Add(dr("Item_ID"), dr("Item_Name"), Double.Parse(dr("Item_Price")).ToString("n2"), dr("Quantity"), Double.Parse(dr("Subtotal")).ToString("n2"), dr("Type"))

        Loop
        connection.Dispose()
        connection.Close()

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

        datagrid.Columns(13).DefaultCellStyle.Format = "n2"
        datagrid.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        datagrid.Columns(14).DefaultCellStyle.Format = "n2"
        datagrid.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        datagrid.Columns(15).DefaultCellStyle.Format = "n2"
        datagrid.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        '' =======================================================================
        Dim i As Integer
        Dim pt = 0
        For i = 0 To datagrid.Rows.Count - 1
            pt = pt + datagrid.Rows(i).Cells(15).Value
        Next i

        lbltotalcharge.Text = FormatNumber(pt)

        Dim Over_all_Charge As Double
        Over_all_Charge = FormatNumber((lbltotalcharge.Text - txtDiscount.Text) - lbladvancePay.Text)
        lblOverallCharge.Text = Double.Parse(Over_all_Charge).ToString("n2")
        '' =======================================================================
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.Rows.Add(9001, "Quantity of [Persons]", 25.0, 2, 50.0, "P000")
    End Sub

    Private Sub Button_Remove_Click(sender As Object, e As EventArgs) Handles Button_Remove.Click
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
            'lblGrandTotal.Text = FormatNumber(GrandTotal)
        End If
    End Sub

    Private Sub Up_Click(sender As Object, e As EventArgs) Handles Up.Click
        If (DataGridView1.Rows.Count >= 1) Then
            Dim i As Integer = DataGridView1.CurrentRow.Index - 1
            If (i >= 0 And i < DataGridView1.Rows.Count) Then
                DataGridView1.CurrentCell = DataGridView1.Rows(i).Cells(2)
            End If
        End If
    End Sub

    Private Sub Down_Click(sender As Object, e As EventArgs) Handles Down.Click
        If DataGridView1.Rows.Count >= 1 Then
            Dim i As Integer = DataGridView1.CurrentRow.Index + 1
            If (i >= -1 And i < DataGridView1.Rows.Count) Then
                DataGridView1.CurrentCell = DataGridView1.Rows(i).Cells(2)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim time As DateTime = Now
        Dim format As String = "yyyy-MM-dd"
        test5 = DateTime.Now.ToString(format)
        Form_Checkin_Venue.ShowDialog()
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        GrandTotal = 0
        PartialTotal = 0
        Dim i As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            PartialTotal = PartialTotal + Double.Parse(DataGridView1.Rows(i).Cells(4).Value)
        Next i
        GrandTotal = GrandTotal + PartialTotal
        'lblGrandTotal.Text = FormatNumber(GrandTotal)
        lbltotalcharge.Text = FormatNumber(GrandTotal)

        Dim Grand As Double = 0
        Dim Advan As Double = 0
        Dim Disco As Double = 0

        Grand = Double.Parse(GrandTotal)
        Advan = Double.Parse(lbladvancePay.Text)
        Disco = Double.Parse(txtDiscount.Text)

        lblOverallCharge.Text = ((Grand - Advan) - Disco).ToString("00.00")
        If Grand <= Advan Then
            lblOverallCharge.Text = "0.00"
        End If


        TxtAdvance_TextChanged(sender, e)
    End Sub

    Private Sub DataGridView1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        GrandTotal = 0
        PartialTotal = 0
        Dim i As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            PartialTotal = PartialTotal + Double.Parse(DataGridView1.Rows(i).Cells(4).Value)
        Next i
        GrandTotal = GrandTotal + PartialTotal
        'lblGrandTotal.Text = FormatNumber(GrandTotal)
        lbltotalcharge.Text = FormatNumber(GrandTotal)
        Dim Grand As Double = 0
        Dim Advan As Double = 0
        Dim Disco As Double = 0

        Grand = Double.Parse(GrandTotal)
        Advan = Double.Parse(lbladvancePay.Text)
        Disco = Double.Parse(txtDiscount.Text)

        lblOverallCharge.Text = ((Grand - Advan) - Disco).ToString("00.00")
        If Grand <= Advan Then
            lblOverallCharge.Text = "0.00"
        End If


        TxtAdvance_TextChanged(sender, e)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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

        DataGridView1.Rows.Add(9001, item, price, selected, total, "P000")
    End Sub

    Private Sub TxtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        If txtAdvance.Text = "" Or txtDiscount.Text = "" Then
            Exit Sub
        End If
        Dim Grand As Double
        Dim Advan As Double
        Dim Disco As Double
        Try
            'Grand = Double.Parse(lblGrandTotal.Text)
            'lblDiscount.Text = Double.Parse(txtDiscount.Text).ToString("00.00")
            Grand = Double.Parse(lbltotalcharge.Text)
            Advan = Double.Parse(txtAdvance.Text)
            Disco = Double.Parse(txtDiscount.Text)
        Catch ex As Exception

        End Try

        txtTotal.Text = ((Grand - Advan) - Disco).ToString("00.00")
        If Grand <= Advan Then
            txtTotal.Text = "0.00"
        End If
    End Sub

    Private Sub TxtAdvance_TextChanged(sender As Object, e As EventArgs) Handles txtAdvance.TextChanged
        If txtAdvance.Text = "" Or txtDiscount.Text = "" Then
            Exit Sub
        End If
        Dim Grand As Double
        Dim Advan As Double
        Dim Disco As Double
        Dim FirstAdv As Double
        Dim OVERALL As Double
        Try
            'Grand = Double.Parse(lblGrandTotal.Text)
            'lbladvancePay.Text = Double.Parse(lbltotalcharge.Text).ToString("00.00")
            FirstAdv = Double.Parse(lbladvancePay.Text)
            Grand = Double.Parse(lbltotalcharge.Text)
            Advan = Double.Parse(txtAdvance.Text)
            Disco = Double.Parse(txtDiscount.Text)
            OVERALL = Double.Parse(lblOverallCharge.Text)
        Catch ex As Exception

        End Try

        txtTotal.Text = (((Grand - Disco) - FirstAdv) - Advan).ToString("00.00")
        If OVERALL <= Advan Then
            txtTotal.Text = "0.00"
        End If

        'Dim Over_all_Charge As Double
        'Over_all_Charge = FormatNumber((lbltotalcharge.Text - lblDiscount.Text) - lbladvancePay.Text)
        'lblOverallCharge.Text = Double.Parse(Over_all_Charge).ToString("n2")
    End Sub

    Private Sub Button_Add_Item_Click(sender As Object, e As EventArgs) Handles Button_Add_Item.Click
        If StopI = 15 Then
            Exit Sub
        End If
        Form_Checkin_Item.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ReservedID = Nothing Or txtAdvance.Text = "" Or txtTotal.Text = Nothing Then
            Exit Sub
        ElseIf MsgBox("GrandTotal : " & txtTotal.Text & " is the total transaction to the selected guest?", vbQuestion + vbYesNo, "Charge Transaction") = vbYes Then

            '= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  Update Old Transaction
            connection.Open()
            Dim update_guest As New MySqlCommand("UPDATE tblGuests SET Remarks = 'Available' WHERE GuestID = " & getID2 & "", connection)
            update_guest.ExecuteNonQuery()
            connection.Dispose()
            connection.Close()

            connection.Open()
            Dim update_transactions As New MySqlCommand("UPDATE table_transactions SET Status = 'Checkout' WHERE T_ID = " & getTID2 & "", connection)
            update_transactions.ExecuteNonQuery()
            connection.Dispose()
            connection.Close()

            Dim k As Integer = 0
            Dim nono As Integer = 0
            For k = 0 To DataGridView3.Rows.Count - 1
                If DataGridView3.Rows(k).Cells("Type").Value = "V000" Then
                    nono = Integer.Parse(DataGridView3.Rows(k).Cells("Item_ID").Value)
                    mysql = "UPDATE tblVenue SET Status = 'Available'" &
                         " WHERE VenueID = @ID"
                    conndb()
                    cmd = New MySqlCommand(mysql, conn)
                    With cmd
                        '.Parameters.AddWithValue("@status", "Available")
                        .Parameters.AddWithValue("@ID", nono)
                        .ExecuteNonQuery()
                    End With
                    closeDB()
                End If
            Next k
            '= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 

            '= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  New Data
            Dim insert_command1 As New MySqlCommand("INSERT INTO `Table_Transactions`(`U_id`, `G_id`, `TransDate`, `Status`, `checkin`, `checkout`, `discount`, `advance`, `total`) VALUES (@a,@b,@c,@d,@e,@f,@g,@h,@i)", connection)
            insert_command1.Parameters.Add("@a", MySqlDbType.Int64).Value = UID
            insert_command1.Parameters.Add("@b", MySqlDbType.Int64).Value = getID2
            insert_command1.Parameters.Add("@c", MySqlDbType.DateTime).Value = DateTime.Now
            insert_command1.Parameters.Add("@d", MySqlDbType.VarChar).Value = "Checkin"
            insert_command1.Parameters.Add("@e", MySqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd")
            insert_command1.Parameters.Add("@f", MySqlDbType.Date).Value = DateTime.Now.AddDays(1D).ToString("yyyy-MM-dd")
            insert_command1.Parameters.Add("@g", MySqlDbType.Double).Value = txtDiscount.Text
            insert_command1.Parameters.Add("@h", MySqlDbType.Double).Value = txtAdvance.Text
            insert_command1.Parameters.Add("@i", MySqlDbType.Double).Value = txtTotal.Text
            'insert_command1.Parameters.Add("@j", MySqlDbType.Double).Value = Now.ToLongTimeString()
            If execCommand(insert_command1) Then

                Dim update_guest2 As New MySqlCommand("UPDATE tblGuests SET Remarks = 'Checkin' WHERE GuestID = " & getID2 & "", connection)
                update_guest2.ExecuteNonQuery()

                Dim newtransactionID As Integer
                Dim command As New MySqlCommand("SELECT MAX(`T_id`) FROM `Table_Transactions`", connection)
                newtransactionID = command.ExecuteScalar().ToString()
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
                            .Parameters.AddWithValue("@aa", newtransactionID)
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
                        Dim update_Venue As New MySqlCommand("UPDATE tblVenue SET Status = 'Occupied' WHERE VenueID = " & DataGridView1.Rows(i).Cells(0).Value & "", connection)
                        update_Venue.ExecuteNonQuery()

                        mysql = "INSERT INTO `Table_TransactionDetailsVENUE`(`T_id`, `Item_Name`, `Item_Price`, `Quantity`, `SubTotal`, `Item_ID`, `Type`) " &
                                            "VALUES (@aa,@bb,@cc,@dd,@ee,@ff,@gg)"
                        closeDB()
                        conndb()
                        cmd = New MySqlCommand(mysql, conn)
                        With cmd
                            .Parameters.AddWithValue("@aa", newtransactionID)
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
                            .Parameters.AddWithValue("@aa", newtransactionID)
                            .Parameters.AddWithValue("@bb", Me.DataGridView1.Rows(i).Cells(1).Value)
                            .Parameters.AddWithValue("@cc", Me.DataGridView1.Rows(i).Cells(2).Value)
                            .Parameters.AddWithValue("@dd", Me.DataGridView1.Rows(i).Cells(3).Value)
                            .Parameters.AddWithValue("@ee", Me.DataGridView1.Rows(i).Cells(4).Value)
                            .Parameters.AddWithValue("@ff", Me.DataGridView1.Rows(i).Cells(0).Value)
                            .Parameters.AddWithValue("@gg", Me.DataGridView1.Rows(i).Cells(5).Value)
                            .ExecuteNonQuery()
                        End With
                        closeDB()

                        Dim newQTY As Integer
                        mysql = "SELECT Item_Qty FROM table_items WHERE Item_ID = " & DataGridView1.Rows(i).Cells(0).Value
                        closeDB()
                        conndb()
                        cmd = New MySqlCommand(mysql, conn)
                        dr = cmd.ExecuteReader
                        Do Until dr.Read = False
                            newQTY = dr("item_Qty")
                        Loop
                        closeDB()

                        If (newQTY <= Val(DataGridView1.Rows(i).Cells(3).Value)) Then
                            mysql = "UPDATE table_items SET item_Qty = " & newQTY & ", Item_Status = '4'" &
                            " WHERE Item_Id = " & DataGridView1.Rows(i).Cells(0).Value
                            closeDB()
                            conndb()
                            cmd = New MySqlCommand(mysql, conn)
                            cmd.ExecuteNonQuery()
                            closeDB()
                        Else
                            mysql = "UPDATE table_items SET item_Qty = " & newQTY - Val(DataGridView1.Rows(i).Cells(3).Value) & "" &
                            " WHERE Item_Id = " & DataGridView1.Rows(i).Cells(0).Value
                            closeDB()
                            conndb()
                            cmd = New MySqlCommand(mysql, conn)
                            cmd.ExecuteNonQuery()
                            closeDB()
                        End If
                    End If

                Next i
            Else
                MessageBox.Show("Data NOT Inserted")
                Exit Sub
            End If
            MsgBox("Transaction has been charged to the selected guest", vbInformation, "Charged to guest")
            Form_Reservation.displayReserved(Form_Reservation.DataGridView2, "")
            Form_Reservation.DisplayR(DataGridView3, Nothing)
            resetall()
            Me.Close()
            '= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        Else

        End If
    End Sub
End Class