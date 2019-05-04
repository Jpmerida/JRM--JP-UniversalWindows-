Imports MySql.Data.MySqlClient

Public Class Form_Checkin
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
            'DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
            'DataGridView1.Columns(1).Width = 150
            DataGridView1.Columns(2).Width = 40
            DataGridView1.Columns(3).Width = 30

            DataGridView1.Columns(2).DefaultCellStyle.Format = "n2"
            DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridView1.Columns(3).DefaultCellStyle.Format = "n2"
            DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridView1.Columns(4).DefaultCellStyle.Format = "n2"
            DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridView1.Columns(4).Width = 45
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(5).Width = 0
            continueonce = 1
        End If
    End Sub

    Public Sub clearAll()
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form_Checkin_Guest.ShowDialog()
        'CG = 1
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        Dim item As String
        item = "Quantity of [Persons]"

        Dim price As Double
        price = Double.Parse(ComboBox1.Text).ToString("n2")

        Dim selected As Double
        selected = Double.Parse(InputBox("Enter How Many Persons", "Enter Data", 1, -1, -1))

        Dim total As Double
        total = Double.Parse(selected * price)
        SubTot += total

        table2.Rows.Add(9001, item, price, selected, total, "P000")

        DataGridView1.DataSource = table2

        Dim i As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            PartialTotal = Val(DataGridView1.Rows(i).Cells(4).Value)
        Next i
        GrandTotal = GrandTotal + PartialTotal
        lblGrandTotal.Text = FormatNumber(GrandTotal)
        ''TextBox1.Text = tempSub.ToString("n2")
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        'table2.Rows.Clear()
        'table2.Columns.Clear()
        SubTot = 0
        'CI = 0
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim fdata As New Form_Checkin_Venue()
        'fdata.MdiParent = Me.MdiParent
        'fdata.Show()
        If StopV = 5 Then
            Exit Sub
        End If
        Form_Checkin_Venue.ShowDialog()
    End Sub

    Private Sub Down_Click(sender As Object, e As EventArgs) Handles Down.Click
        If DataGridView1.Rows.Count >= 1 Then
            Dim i As Integer = DataGridView1.CurrentRow.Index + 1
            If (i >= -1 And i < DataGridView1.Rows.Count) Then
                DataGridView1.CurrentCell = DataGridView1.Rows(i).Cells(2)
            End If
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
                PartialTotal = PartialTotal + DataGridView1.Rows(i).Cells(4).Value
            Next i
            GrandTotal = GrandTotal + PartialTotal
            lblGrandTotal.Text = FormatNumber(GrandTotal)
        End If
    End Sub
    Private Sub Button_CheckIN_Click(sender As Object, e As EventArgs) Handles Button_CheckIN.Click
        'Dim advance As Integer = Val(txtAdvance.Text)
        'Dim reserve As String = "0"
        'Dim remarks As String = "Checkin"
        'Dim stat As String = "Active"



        ''-=-=-=-
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
                insert_command1.Parameters.Add("@d", MySqlDbType.VarChar).Value = "Checkin"
                insert_command1.Parameters.Add("@e", MySqlDbType.Date).Value = time.ToString(format)
                insert_command1.Parameters.Add("@f", MySqlDbType.Date).Value = time.AddDays(1D).ToString(format)
                insert_command1.Parameters.Add("@g", MySqlDbType.Double).Value = txtDiscount.Text
                insert_command1.Parameters.Add("@h", MySqlDbType.Double).Value = txtAdvance.Text
                insert_command1.Parameters.Add("@i", MySqlDbType.Double).Value = txtTotal.Text

                If execCommand(insert_command1) Then

                    Dim update_guest As New MySqlCommand("UPDATE tblGuests SET Remarks = 'Checkin' WHERE GuestID = " & CheckGuestID & "", connection)
                    update_guest.ExecuteNonQuery()

                    ''Venues
                    Dim x As Integer = 0
                    For x = 0 To Venues(x)
                        If Venues(x) = Nothing Then
                        Else
                            Dim update_Venue As New MySqlCommand("UPDATE tblVenue SET Status = 'Occupied' WHERE VenueID = " & Venues(x) & "", connection)
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

                            mysql = "UPDATE table_items SET item_Qty = " & newQTY - Val(ItemsMuch(y)) & "" &
                                " WHERE Item_Id = " & Items(y)
                            closeDB()
                            conndb()
                            cmd = New MySqlCommand(mysql, conn)
                            cmd.ExecuteNonQuery()
                            closeDB()
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

                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button_Add_Item_Click(sender As Object, e As EventArgs) Handles Button_Add_Item.Click
        If StopI = 15 Then
            Exit Sub
        End If
        Form_Checkin_Item.ShowDialog()
    End Sub
    Private Sub Form_Checkin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        clearAll()
    End Sub

    'Payments
    Private Sub TxtAdvance_TextChanged(sender As Object, e As EventArgs) Handles txtAdvance.TextChanged
        If Val(lblGrandTotal.Text) < Val(txtAdvance.Text) Or Val(lblGrandTotal.Text) = Val(txtAdvance.Text) Then
            txtTotal.Text = "0.00"
        Else
            txtTotal.Text = (Val(lblGrandTotal.Text) - Val(txtAdvance.Text).ToString("00.00") - Val(txtDiscount.Text)).ToString("00.00")
        End If
    End Sub
    Private Sub TxtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        If Val(lblGrandTotal.Text) < Val(txtAdvance.Text) Or Val(lblGrandTotal.Text) = Val(txtAdvance.Text) Then
            txtTotal.Text = "0.00"
        Else
            txtTotal.Text = (Val(lblGrandTotal.Text) - Val(txtAdvance.Text).ToString("00.00") - Val(txtDiscount.Text)).ToString("00.00")
        End If
        'txtTotal.Text = (Val(lblGrandTotal.Text) - (Val(lblGrandTotal.Text) - Val(txtDiscount.Text))).ToString("00.00")
    End Sub

    'payments

    Private Sub TxtDiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscount.KeyPress
        OnlyNumbers(e)
    End Sub
    Private Sub TxtAdvance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdvance.KeyPress
        OnlyNumbers(e)
    End Sub
End Class