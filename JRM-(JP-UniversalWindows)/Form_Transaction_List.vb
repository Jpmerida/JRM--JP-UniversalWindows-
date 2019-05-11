Imports MySql.Data.MySqlClient

Public Class Form_Transaction_List
    Private Sub Form_Transaction_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker4.Value = Now.AddDays(7D)
        displayReserved(DataGridView1, "")
        Displaybydate(ListView1)
    End Sub

    Public Sub Displaybydate(listview As ListView)
        Reportd1 = Format(Date.Now, "yyyy-MM-01")
        Reportd2 = Format(Date.Now.AddMonths(1), "yyyy-MM-01")

        mysql = "SELECT *, COUNT(*) as PAPER, SUM(Gain) AS ROCK
FROM table_transactions
WHERE 
    (table_transactions.`Status` = 'Checkout') AND
    (table_transactions.CheckIn BETWEEN '" & Reportd1 & "' AND '" & Reportd2 & "')
GROUP BY checkin	
ORDER BY table_transactions.TransDate ASC"

        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        listview.Items.Clear()

        Do While dr.Read = True
            newline = listview.Items.Add(dr("T_id"))
            newline.SubItems.Add(dr("U_id"))
            newline.SubItems.Add(dr("G_id"))
            Dim Tran As String = Format(dr("transdate"), "yyyy-MM-dd")
            newline.SubItems.Add(Tran)
            'newline.SubItems.Add(dr("TransDate"))
            newline.SubItems.Add(dr("Status"))
            'newline.SubItems.Add(dr("PAPER"))
            newline.SubItems.Add(dr("PAPER"))
            'newline.SubItems.Add(dr("CheckIn"))
            'newline.SubItems.Add(dr("COUNT(Checkin)"))
            'Dim a As Double = dr("Checkout")
            'Dim b As Double = dr("Discount")
            'Dim c As Double = dr("advance")
            newline.SubItems.Add(dr("Checkout"))
            newline.SubItems.Add(dr("Discount"))
            newline.SubItems.Add(dr("Advance"))
            newline.SubItems.Add(dr("gain"))
            Dim d As Double
            d = dr("Rock")
            newline.SubItems.Add(d.ToString("n2"))
            '
            'newline.SubItems.Add(dr("Gain"))

        Loop

        cmd.Dispose()
        conn.Close()

    End Sub

    Public Sub displayReserved(datagrid As DataGridView, valueToSearch As String)
        connection.Dispose()
        connection.Close()
        connection.Open()

        If valueToSearch = "" Then
            Dim command As New MySqlCommand("SELECT *
            FROM table_transactions , tblguests
            WHERE (table_transactions.G_id = tblguests.GuestID) AND
            (table_transactions.`Status` = 'Canceled' OR
            table_transactions.`Status` = 'Checkout') AND
            (table_transactions.CheckIn BETWEEN @d1 AND @d2)
            ORDER BY table_transactions.TransDate DESC", connection)

            command.Parameters.Add("@d1", MySqlDbType.Date).Value = DateTimePicker3.Value
            command.Parameters.Add("@d2", MySqlDbType.Date).Value = DateTimePicker4.Value

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            datagrid.AllowUserToAddRows = False
            datagrid.DataSource = table
        Else
            Dim command As New MySqlCommand("SELECT *
            FROM table_transactions , tblguests
            WHERE (table_transactions.G_id = tblguests.GuestID) AND
            (table_transactions.`Status` = 'Canceled' OR
            table_transactions.`Status` = 'Checkout') AND
            (table_transactions.CheckIn BETWEEN @d1 AND @d2) AND
            CONCAT(table_transactions.`T_id`, tblguests.`Name`, tblguests.`ContactNo`) LIKE '%" & valueToSearch & "%' ORDER BY table_transactions.TransDate DESC", connection)

            command.Parameters.Add("@d1", MySqlDbType.Date).Value = DateTimePicker3.Value
            command.Parameters.Add("@d2", MySqlDbType.Date).Value = DateTimePicker4.Value

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            datagrid.AllowUserToAddRows = False
            datagrid.DataSource = table
        End If

        'datagrid.MultiSelect = False
        'datagrid.AllowUserToResizeColumns = False

        datagrid.DefaultCellStyle.SelectionForeColor = Color.Black
        datagrid.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 9.75, FontStyle.Bold)
        datagrid.DefaultCellStyle.Font = New Font("Segoe UI Semibold", 9.75)

        datagrid.AutoResizeColumns()
        datagrid.Columns(0).Visible = False 'Transaction ID"
        'datagrid.Columns(0).HeaderText = "Transaction ID"
        datagrid.Columns(1).Visible = False 'u_ID
        datagrid.Columns(2).Visible = False 'G_id
        datagrid.Columns(3).Visible = False 'TransDate
        datagrid.Columns(4).Visible = False 'Status
        datagrid.Columns(5).Visible = True 'Assigned Date 'Checkin
        datagrid.Columns(5).HeaderText = "Date"
        datagrid.Columns(5).Width = 80
        datagrid.Columns(6).Visible = False 'Checkout
        datagrid.Columns(7).Visible = False 'discount
        datagrid.Columns(8).Visible = False 'advance
        datagrid.Columns(9).Visible = True 'total (subtotal - Discount) - Cash Advanced
        datagrid.Columns(5).Width = 80
        datagrid.Columns(10).Visible = False 'Gain
        datagrid.Columns(11).Visible = False 'Guest ID
        datagrid.Columns(12).Visible = True 'Name
        'datagrid.Columns(12).Width = 200
        datagrid.Columns(13).Visible = False 'Email
        datagrid.Columns(14).Visible = False 'Contact #
        datagrid.Columns(15).Visible = False 'Addres
        datagrid.Columns(16).Visible = False 'Guest Created
        datagrid.Columns(17).Visible = False 'Status1
        datagrid.Columns(18).Visible = False 'Remarks
        connection.Dispose()
        connection.Close()
    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker4.ValueChanged
        displayReserved(DataGridView1, "")
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        displayReserved(DataGridView1, "")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            RecentTID = DataGridView1.CurrentRow.Cells(0).Value
            gid = DataGridView1.CurrentRow.Cells(2).Value
            Form_Report.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        displayReserved(DataGridView1, TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim xform As New Form_Search_Date_Transactions()
        'xform.MdiParent = Me.MdiParent
        'xform.ShowDialog()
        Form_Search_Date_Transactions.ShowDialog()
    End Sub

    Private Sub Form_Transaction_List_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form_Main.TI = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connection.Dispose()
        connection.Close()
        connection.Open()
        Dim delete_Print_Transactions As New MySqlCommand("DELETE FROM table_print_transactions_Monthly", connection)
        delete_Print_Transactions.ExecuteNonQuery()
        connection.Dispose()
        connection.Close()

        Dim OLD1 As String = DateTime.Now.ToString("MMMM")
        Dim OLD2 As String = DateTimePicker4.Value.ToString("MMM dd, yyyy")

        'Dim read1 As String = Format(Date.Now, "yyyy-01-01")
        'Dim read2 As String = Format(Date.Now, "yyyy-02-01")
        'Dim read3 As String = Format(Date.Now, "yyyy-03-01")
        'Dim read4 As String = Format(Date.Now, "yyyy-04-01")
        'Dim read5 As String = Format(Date.Now, "yyyy-05-01")
        'Dim read6 As String = Format(Date.Now, "yyyy-06-01")
        'Dim read7 As String = Format(Date.Now, "yyyy-07-01")
        'Dim read8 As String = Format(Date.Now, "yyyy-08-01")
        'Dim read9 As String = Format(Date.Now, "yyyy-09-01")
        'Dim read10 As String = Format(Date.Now, "yyyy-10-01")
        'Dim read11 As String = Format(Date.Now, "yyyy-11-01")
        'Dim read12 As String = Format(Date.Now, "yyyy-12-01")

        'If read1 = Reportd1 Then
        '    OLD1 = DateTime.Now.ToString("MMMM")
        'ElseIf read2 = Reportd1 Then
        '    OLD1 = DateTime.Now.ToString("MMMM")
        'ElseIf read3 = Reportd1 Then
        '    OLD1 = DateTime.Now.ToString("MMMM")
        'ElseIf read4 = Reportd1 Then
        '    OLD1 = DateTime.Now.ToString("MMMM")
        'ElseIf read5 = Reportd1 Then
        '    OLD1 = DateTime.Now.ToString("MMMM")
        'ElseIf read6 = Reportd1 Then
        '    OLD1 = DateTime.Now.ToString("MMMM")
        'ElseIf read7 = Reportd1 Then
        '    OLD1 = DateTime.Now.ToString("MMMM")
        'ElseIf read8 = Reportd1 Then
        '    OLD1 = DateTime.Now.ToString("MMMM")
        'ElseIf read9 = Reportd1 Then
        '    OLD1 = DateTime.Now.ToString("MMMM")
        'ElseIf read10 = Reportd1 Then
        '    OLD1 = DateTime.Now.ToString("MMMM")
        'ElseIf read11 = Reportd1 Then
        '    OLD1 = DateTime.Now.ToString("MMMM")
        'ElseIf read12 = Reportd1 Then
        '    OLD1 = DateTime.Now.ToString("MMMM")
        'End If


        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1

            Dim insert_command1 As New MySqlCommand("INSERT INTO `table_print_transactions_Monthly`(`Date`,`Transactions`,`Sales`,`DateFirst`,`DateSecond`) VALUES(@a,@b,@c,@d,@e)", connection)
            insert_command1.Parameters.Add("@a", MySqlDbType.VarChar).Value = ListView1.Items(i).SubItems(3).Text
            insert_command1.Parameters.Add("@b", MySqlDbType.Int16).Value = Val(ListView1.Items(i).SubItems(5).Text)
            insert_command1.Parameters.Add("@c", MySqlDbType.Double).Value = ListView1.Items(i).SubItems(10).Text
            insert_command1.Parameters.Add("@d", MySqlDbType.VarChar).Value = OLD1
            insert_command1.Parameters.Add("@e", MySqlDbType.VarChar).Value = OLD2
            execCommand(insert_command1)

        Next i

        Dim xform As New Form_Monthly_Report()
        xform.Show()
    End Sub
End Class