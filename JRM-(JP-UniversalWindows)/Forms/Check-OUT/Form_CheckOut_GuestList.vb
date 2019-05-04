Imports MySql.Data.MySqlClient

Public Class Form_CheckOut_GuestList
    Dim pt As Double
    Dim dcount As Double
    Dim advpay As Double


    Private Sub Form_CheckOut_GuestList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetAll()
        DisplayList1(ListView2, "")
    End Sub

    Private Sub ResetAll()
        Button_OpenTransact.Enabled = False
        closeDB()
        connection.Close()
    End Sub

    Public Sub DisplayList1(lv As ListView, searchme As String)
        mysql = "SELECT * FROM tblguests , table_transactions, tblGuestDetails WHERE 
        CONCAT(tblguests.Name,tblguests.contactno,tblguestdetails.Fname,tblguestdetails.Mname,tblguestdetails.Lname) like '%" & searchme & "%' AND
        tblguests.Remarks = table_transactions.`Status` AND tblguests.GuestID = table_transactions.G_id AND tblguests.GuestID = tblguestdetails.GuestID ORDER BY TransDate asc"
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
        DisplayList1(ListView1, TextBox1.Text)
    End Sub

    Private Sub DisplayList2(lv As ListView, searchme As String)
        ListView1.Items.Clear()
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
        '================= Persons
        mysql = "SELECT * FROM table_transactions , table_transactiondetails WHERE 
        table_transactions.T_id = table_transactiondetails.T_id AND table_transactions.`Status` = 'Checkin' AND
        table_transactionDetails.T_id = '" & searchme & "'"
        closeDB()
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader
        Dim value As Integer
        lv.Items.Clear()
        Do Until dr.Read = False
            value = Val(dr("T_ID"))
            newline = lv.Items.Add(dr("T_id"))
            newline.SubItems.Add(dr("Item_name"))
            newline.SubItems.Add(Double.Parse(dr("Item_Price")).ToString("n2"))
            newline.SubItems.Add(dr("Quantity"))
            newline.SubItems.Add(Double.Parse(dr("SubTotal")).ToString("n2"))
            newline.SubItems.Add(dr("Item_ID"))
            dcount = dr("discount")
            advpay = dr("Advance")
            Label7.Text = "TransID - " & value.ToString("0000")
            lblDiscount.Text = Double.Parse(dcount).ToString("n2")
            lbladvancePay.Text = Double.Parse(advpay).ToString("n2")
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
        Loop
        closeDB()

        Dim i As Integer
        pt = 0
        For i = 0 To ListView1.Items.Count - 1
            pt = pt + ListView1.Items(i).SubItems(4).Text
        Next i

        lblTotalCharge.Text = FormatNumber(pt)
        lblOverallCharge.Text = FormatNumber((lblTotalCharge.Text - lblDiscount.Text) - lbladvancePay.Text)
        Button_OpenTransact.Enabled = True
    End Sub

    Private Sub ListView2_Click(sender As Object, e As EventArgs) Handles ListView2.Click
        Label3.Text = ListView2.SelectedItems(0).SubItems(4).Text
        gid = ListView2.SelectedItems(0).SubItems(0).Text
        getTid = ListView2.SelectedItems(0).SubItems(4).Text
        DisplayList2(ListView1, getTid)
    End Sub

    Private Sub Button_OpenTransact_Click(sender As Object, e As EventArgs) Handles Button_OpenTransact.Click
        Form_Checkout.Text = "Transactions of Guest [" & Label1.Text & "]"
        Form_Checkout.ShowDialog()
    End Sub

    Private Sub Form_CheckOut_GuestList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_Main.CO = 0
    End Sub
End Class