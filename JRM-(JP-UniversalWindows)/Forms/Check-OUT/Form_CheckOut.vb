Imports MySql.Data.MySqlClient
Public Class Form_Checkout
    Dim pt As Double
    Dim dcount As Double
    Dim advpay As Double
    Dim Over_All_Charge As Double = 0.00


    Public Venues(5) As Integer
    Public StopV As Integer = 0
    Public AlreadyPaid As Double
    Public SupposedToPay As Double
    Private Sub Form_Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Items.Clear()
        displayGuest()
        DisplayList2(ListView1, getTid)
        DisplayTotal()
        checkifpaid()
        '-=-=-=-=-=-'
    End Sub

    Private Sub DisplayTotal()
        Dim i As Integer
        pt = 0
        For i = 0 To ListView1.Items.Count - 1
            pt = pt + ListView1.Items(i).SubItems(4).Text
        Next i

        lblTotalCharge.Text = FormatNumber(pt)
        Over_All_Charge = FormatNumber((lblTotalCharge.Text - lblDiscount.Text) - lbladvancePay.Text)
        lblOverallCharge.Text = FormatNumber(Over_All_Charge)
    End Sub
    Private Sub displayGuest()
        '================= Guest Details
        mysql = "SELECT * FROM tblguestdetails WHERE tblguestdetails.GuestID ='" & gid & "'"
        closeDB()
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader
        Do Until dr.Read = False
            Label2.Text = dr("Fname") + " " + dr("Mname") + " " + dr("Lname")
        Loop
        closeDB()
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

            Venues(StopV) = Integer.Parse(dr("Item_ID"))
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


    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        If txtAmount.Text = "" Then
            lblChange.Text = "00.00"
            Exit Sub
        End If

        lblChange.Text = FormatNumber(CInt(txtAmount.Text) - CInt(Over_All_Charge))

        If CInt(lblChange.Text) >= 0 Then
            lblChange.ForeColor = Color.Green
        Else
            lblChange.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnSettlePayment_Click(sender As Object, e As EventArgs) Handles btnSettlePayment.Click
        If lblOverallCharge.Text = "0.00" Or lblOverallCharge.Text = "00.00" Then
            MsgBox("No service charges to be paid", vbCritical, "No charges")
            Exit Sub
        End If
        If Panel1.Enabled = False Then
            Panel1.Enabled = True
            btnSettlePayment.Text = "Cancel"
        Else
            Panel1.Enabled = False
            txtAmount.Text = ""
            lblChange.ForeColor = Color.Black
            btnSettlePayment.Text = "Settle Payment"
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
            .Parameters.AddWithValue("@e", lblChange.Text)
            .Parameters.AddWithValue("@f", Over_All_Charge)
            .Parameters.AddWithValue("@g", Date.Now)
            .ExecuteNonQuery()
        End With
        closeDB()

        MsgBox("All charges are paid. Thank you", vbInformation, Label7.Text + " [Paid]")
        txtAmount.Text = ""
        lblOverallCharge.Text = "00.00"
        Over_All_Charge = 00.00
        lblChange.Text = "00.00"
        btnSettlePayment.Text = "Settle Payment"
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
            Button_CheckOUT.Enabled = True
        Else
            Button_CheckOUT.Enabled = False
        End If
    End Sub

    Private Sub Button_CheckOUT_Click(sender As Object, e As EventArgs) Handles Button_CheckOUT.Click
        closeDB()
        If AlreadyPaid >= SupposedToPay Then
            Dim x As Integer = 0
            For x = 0 To StopV
                If Venues(x) = Nothing Then
                Else


                    ''connection.Open()
                    ''Dim update_Venue As New MySqlCommand("UPDATE tblVenue SET Status = 'Available' WHERE VenueID = " & Venues(x) & "", connection)
                    ''update_Venue.ExecuteNonQuery()
                    ''connection.Dispose()
                    ''connection.Close()
                End If
            Next
            connection.Open()
            Dim update_Transactions As New MySqlCommand("UPDATE table_Transactions SET Status = 'Checkout' WHERE T_ID = " & getTid & "", connection)
            update_Transactions.ExecuteNonQuery()
            connection.Dispose()
            connection.Close()
            closeDB()
            MsgBox("Successfuly Checked-OUT", vbInformation, "Updated")

            Form_CheckOut_GuestList.DisplayList1(Form_CheckOut_GuestList.ListView2, "")
            Me.Close()
        Else
        End If
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        '======================== image
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Label12.Text = ListView1.SelectedItems(0).SubItems(6).Text
        If ListView1.SelectedItems(0).SubItems(6).Text = "P000" Then
            PictureBox1.ImageLocation = "C:\Users\JpZ\source\repos\JRM-(JP-UniversalWindows)\JRM-(JP-UniversalWindows)\bin\Debug\JRM_images\Untitled2.jpg"
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            'PictureBox1.ImageLocation = Application.StartupPath & "\JRM_images\Untitled2.jpg"
        ElseIf ListView1.SelectedItems(0).SubItems(6).Text = "I000" Then
            mysql = "SELECT tblvenue.Image_Location, table_transactiondetailsvenue.Item_ID FROM
            table_transactiondetailsvenue , tblvenue WHERE table_transactiondetailsvenue.Item_ID = " & ListView1.SelectedItems(0).SubItems(5).Text & ""
            closeDB()
            conndb()
            cmd = New MySqlCommand(mysql, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do Until dr.Read = False
                PictureBox1.ImageLocation = dr("Image_Location")
            Loop
            closeDB()
        ElseIf ListView1.SelectedItems(0).SubItems(6).Text = "V000" Then
            mysql = "SELECT Item_ID, Item_Image FROM Table_Items WHERE Item_ID = " & ListView1.SelectedItems(0).SubItems(5).Text & ""
            closeDB()
            conndb()
            cmd = New MySqlCommand(mysql, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do Until dr.Read = False
                PictureBox1.ImageLocation = dr("Item_Image")
            Loop
            closeDB()
        End If

    End Sub
End Class