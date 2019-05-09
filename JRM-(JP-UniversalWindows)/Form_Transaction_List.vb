Imports MySql.Data.MySqlClient

Public Class Form_Transaction_List
    Private Sub Form_Transaction_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker4.Value = Now.AddDays(7D)
        displayReserved(DataGridView1, "")
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
        datagrid.Columns(0).Visible = False
        'datagrid.Columns(0).HeaderText = "Transaction ID"
        datagrid.Columns(1).Visible = False
        datagrid.Columns(2).Visible = False
        datagrid.Columns(3).Visible = False
        datagrid.Columns(4).Visible = False 'Status
        datagrid.Columns(5).Visible = True 'Assigned Date
        datagrid.Columns(5).HeaderText = "Date"
        datagrid.Columns(5).Width = 80
        datagrid.Columns(6).Visible = False 'Checkout
        datagrid.Columns(7).Visible = False 'discount
        datagrid.Columns(8).Visible = False 'advance
        datagrid.Columns(9).Visible = True 'total (subtotal - Discount) - Cash Advanced
        datagrid.Columns(10).Visible = False 'Guest ID
        datagrid.Columns(11).Visible = True 'Name
        datagrid.Columns(11).Width = 150
        datagrid.Columns(12).Visible = False 'Email
        datagrid.Columns(13).Visible = False 'Contact #
        datagrid.Columns(14).Visible = False 'Addres
        datagrid.Columns(15).Visible = False 'Guest Created
        datagrid.Columns(16).Visible = False 'Status1
        datagrid.Columns(17).Visible = False 'Remarks
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
        RecentTID = DataGridView1.CurrentRow.Cells(0).Value
        gid = DataGridView1.CurrentRow.Cells(2).Value
        Form_Report.ShowDialog()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        displayReserved(DataGridView1, TextBox1.Text)
    End Sub
End Class