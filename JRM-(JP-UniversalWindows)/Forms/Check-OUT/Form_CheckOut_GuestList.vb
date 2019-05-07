Imports MySql.Data.MySqlClient

Public Class Form_CheckOut_GuestList
    Dim pt As Double
    Dim dcount As Double
    Dim advpay As Double

    Public Over_all_Charge As Double
    Public myChange As Double
    Public test2 As Double

    Public Venues(5) As Integer
    Public StopV As Integer = 0
    Public AlreadyPaid As Double
    Public SupposedToPay As Double

    Private Sub Form_CheckOut_GuestList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ResetAll()
        DisplayList1(ListView2, "")
    End Sub

    Private Sub ResetAll()
        Array.Clear(Venues, 0, Venues.Length)
        StopV = 0

        Over_all_Charge = 0
        myChange = 0
        Panel3.Visible = False
        Button_OpenTransact.Enabled = False
        Button_CheckOUT.Enabled = False
        AlreadyPaid = 0
        SupposedToPay = 0
        StopV = 0
        Venues = {0, 0, 0, 0, 0, 0}
        ListView1.Items.Clear()
        ListView2.Items.Clear()
        closeDB()
        connection.Close()
    End Sub

    Public Sub DisplayList1(lv As ListView, searchme As String)
        mysql = "SELECT * FROM tblguests , table_transactions, tblGuestDetails WHERE 
        CONCAT(tblguests.Name,tblguests.contactno,tblguestdetails.Fname,tblguestdetails.Mname,tblguestdetails.Lname) like '%" & searchme & "%' AND
        tblguests.Remarks = table_transactions.`Status` AND tblguests.GuestID = table_transactions.G_id AND table_transactions.`Status` = 'Checkin' AND tblguests.GuestID = tblguestdetails.GuestID ORDER BY TransDate asc"
        closeDB()
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader
        Dim value As Integer
        lv.Items.Clear()
        Do Until dr.Read = False
            value = Val(dr("T_ID"))
            newline = lv.Items.Add(dr("GuestID"))
            newline.SubItems.Add("TransID - " & value.ToString("0000"))
            newline.SubItems.Add(dr("Name"))
            newline.SubItems.Add(dr("CheckIn"))
            newline.SubItems.Add(dr("T_ID")) 'Transaction ID
            newline.SubItems.Add(dr("Fname") + " " + dr("Mname") + " " + dr("Lname"))

        Loop
        closeDB()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DisplayList1(ListView2, TextBox1.Text)
    End Sub

    Private Sub DisplayList2(lv As ListView, searchme As String)
        ListView1.Items.Clear()
        Array.Clear(Venues, 0, Venues.Length)
        StopV = 0
        '================= Guest Details
        mysql = "SELECT * FROM tblguestdetails WHERE tblguestdetails.GuestID ='" & gid & "'"
        closeDB()
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader
        Do Until dr.Read = False
            Label1.Text = dr("Fname") + " " + dr("Mname") + " " + dr("Lname")
        Loop
        closeDB()
        '================= Transaction Details
        mysql = "SELECT * FROM table_Transactions WHERE T_ID ='" & getTid & "'"
        closeDB()
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        Dim value As Integer
        dr = cmd.ExecuteReader
        Do Until dr.Read = False
            value = Val(dr("T_ID"))
            dcount = dr("discount")
            advpay = dr("Advance")
            test2 = dr("Total")
            Label7.Text = "TransID - " & value.ToString("0000")
            lblDiscount.Text = Double.Parse(dcount).ToString("n2")
            lbladvancePay.Text = Double.Parse(advpay).ToString("n2")
        Loop
        closeDB()
        '================= Persons
        mysql = "SELECT * FROM table_transactions , table_transactiondetails WHERE 
        table_transactions.T_id = table_transactiondetails.T_id AND table_transactions.`Status` = 'Checkin' AND
        table_transactionDetails.T_id = '" & searchme & "'"
        closeDB()
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader

        lv.Items.Clear()
        Do Until dr.Read = False

            newline = lv.Items.Add(dr("T_id"))
            newline.SubItems.Add(dr("Item_name"))
            newline.SubItems.Add(Double.Parse(dr("Item_Price")).ToString("n2"))
            newline.SubItems.Add(dr("Quantity"))
            newline.SubItems.Add(Double.Parse(dr("SubTotal")).ToString("n2"))
            newline.SubItems.Add(dr("Item_ID"))
            newline.SubItems.Add(dr("Type"))

        Loop
        closeDB()
        '================= Cottage/Location
        mysql = "SELECT * FROM table_transactions , table_transactiondetailsvenue WHERE
        table_transactions.T_id = table_transactiondetailsvenue.T_id AND table_transactions.`Status` = 'Checkin' AND
        table_transactiondetailsvenue.T_id = '" & searchme & "'"
        closeDB()
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader
        Do Until dr.Read = False
            newline = lv.Items.Add(dr("T_id"))
            newline.SubItems.Add(dr("Item_name"))
            newline.SubItems.Add(Double.Parse(dr("Item_Price")).ToString("n2"))
            newline.SubItems.Add(dr("Quantity"))
            newline.SubItems.Add(Double.Parse(dr("SubTotal")).ToString("n2"))
            newline.SubItems.Add(dr("Item_ID"))
            newline.SubItems.Add(dr("Type"))

            Venues(StopV) = dr("Item_ID")
            StopV = StopV + 1
        Loop
        closeDB()
        '================= Items
        mysql = "SELECT * FROM table_transactions , table_transactiondetailsitem WHERE
        table_transactions.T_id = table_transactiondetailsitem.T_id AND table_transactions.`Status` = 'Checkin' AND
        table_transactiondetailsitem.T_id = '" & searchme & "'"
        closeDB()
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader
        Do Until dr.Read = False
            newline = lv.Items.Add(dr("T_id"))
            newline.SubItems.Add(dr("Item_name"))
            newline.SubItems.Add(Double.Parse(dr("Item_Price")).ToString("n2"))
            newline.SubItems.Add(dr("Quantity"))
            newline.SubItems.Add(Double.Parse(dr("SubTotal")).ToString("n2"))
            newline.SubItems.Add(dr("Item_ID"))
            newline.SubItems.Add(dr("Type"))

        Loop
        closeDB()

        Dim i As Integer
        pt = 0
        For i = 0 To ListView1.Items.Count - 1
            pt = pt + ListView1.Items(i).SubItems(4).Text
        Next i

        lbltotalcharge.Text = FormatNumber(pt)

        Over_all_Charge = FormatNumber((lbltotalcharge.Text - lblDiscount.Text) - lbladvancePay.Text)
        lblOverallCharge.Text = Double.Parse(Over_all_Charge).ToString("n2")

        ''lblOverallCharge.Text = Double.Parse(test2).ToString("n2")
        Button_OpenTransact.Enabled = True

        checkifpaid()
    End Sub

    Private Sub ListView2_Click(sender As Object, e As EventArgs) Handles ListView2.Click
        gid = ListView2.SelectedItems(0).SubItems(0).Text 'guest ID
        getTid = ListView2.SelectedItems(0).SubItems(4).Text 'Transact ID
        DisplayList2(ListView1, getTid)
    End Sub

    Private Sub Button_OpenTransact_Click(sender As Object, e As EventArgs) Handles Button_OpenTransact.Click
        Form_Checkout.Text = "Transactions of Guest [" & Label1.Text & "]"
        Form_Checkout.ShowDialog()
    End Sub

    Private Sub Form_CheckOut_GuestList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_Main.CO = 0
    End Sub

    Private Sub TxtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged

        If txtAmount.Text = "" Then
            lblChange.Text = "00.00"
            Exit Sub
        End If
        Dim amount = Double.Parse(txtAmount.Text)
        Dim overall = Double.Parse(lbltotalcharge.Text)
        myChange = Double.Parse(CInt(txtAmount.Text) - CInt(lblOverallCharge.Text)).ToString("n2")
        lblChange.Text = Double.Parse(myChange).ToString("n2")
        'lblChange.Text = FormatNumber(CInt(txtAmount.Text) - CInt(lblOverallCharge.Text))

        If CInt(lblChange.Text) >= 0 Then
            lblChange.ForeColor = Color.Green
        Else
            lblChange.ForeColor = Color.Red
        End If
    End Sub

    Private Sub BtnConfirmPayment_Click(sender As Object, e As EventArgs) Handles btnConfirmPayment.Click
        If lblChange.ForeColor = Color.Red Or lblChange.ForeColor = Color.Black Or Panel1.Enabled = False Then
            MsgBox("The amount given is not enough to pay the Transaction. Please try again", vbCritical, "Insufficient Amount")
            Exit Sub
        End If

        mysql = "INSERT INTO `tblPayment`(`GuestID`, `T_id`, `ReservationID`, `AmountPaid`, `Change`, `TotalChange`, `DatePayed`)" &
            " VALUES (@a,@b,@c,@d,@e,@f,@g)"
        closeDB()
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        With cmd
            .Parameters.AddWithValue("@a", gid)
            .Parameters.AddWithValue("@b", getTid)
            .Parameters.AddWithValue("@c", 1)
            .Parameters.AddWithValue("@d", txtAmount.Text)
            .Parameters.AddWithValue("@e", myChange)
            .Parameters.AddWithValue("@f", Over_all_Charge)
            .Parameters.AddWithValue("@g", Date.Now)
            .ExecuteNonQuery()
        End With
        closeDB()

        MsgBox("All charges are paid. Thank you", vbInformation, Label7.Text + " [Paid]")
        txtAmount.Text = ""
        lblOverallCharge.Text = "0.00"
        'Over_All_Charge = 00.00
        lblChange.Text = "0.00"
        'btnSettlePayment.Text = "Settle Payment"
        Panel1.Enabled = False
        checkifpaid()
        closeDB()
    End Sub
    Private Sub checkifpaid()

        mysql = "SELECT total FROM table_transactions WHERE T_ID = " & getTid
        closeDB()
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader
        Do Until dr.Read = False
            SupposedToPay = dr("total")
        Loop
        closeDB()


        mysql = "SELECT AmountPaid FROM tblpayment WHERE T_ID = " & getTid
        closeDB()
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader
        Do Until dr.Read = False
            AlreadyPaid = dr("AmountPaid")
        Loop
        closeDB()

        If AlreadyPaid >= SupposedToPay Then
            Panel1.Enabled = False
            Panel3.Visible = True
            Button_CheckOUT.Enabled = True
            txtAmount.Text = ""
            lblOverallCharge.Text = "00.00"
            AlreadyPaid = 0.00
            SupposedToPay = 0.00
            StopV = 0
            Venues = {0, 0, 0, 0, 0, 0}
        Else
            Panel1.Enabled = True
            Panel3.Visible = False
            Button_CheckOUT.Enabled = False
        End If
    End Sub

    Private Sub Button_CheckOUT_Click(sender As Object, e As EventArgs) Handles Button_CheckOUT.Click

        closeDB()
        If AlreadyPaid >= SupposedToPay Then
            Dim k As Integer = 0
            Dim nono As Integer = 0
            For k = 0 To ListView1.Items.Count - 1
                If ListView1.Items(k).SubItems(6).Text = "V000" Then
                    nono = Integer.Parse(ListView1.Items(k).SubItems(5).Text)
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

            connection.Open()
            Dim update_guest As New MySqlCommand("UPDATE tblGuests SET Remarks = 'Available', Status = 'Active' WHERE GuestID = " & gid & "", connection)
            update_guest.ExecuteNonQuery()
            connection.Dispose()
            connection.Close()

            connection.Open()
            Dim update_Transactions As New MySqlCommand("UPDATE table_Transactions SET Status = 'Checkout' WHERE T_ID = " & getTid & "", connection)
            update_Transactions.ExecuteNonQuery()
            connection.Dispose()
            connection.Close()
            closeDB()
            MsgBox("Successfuly Checked-OUT", vbInformation, "Updated")


            ResetAll()
            DisplayList1(ListView2, "")
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub TxtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        OnlyNumbers(e)
    End Sub

    Private Sub Form_CheckOut_GuestList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form_Main.CO = 0
    End Sub
End Class