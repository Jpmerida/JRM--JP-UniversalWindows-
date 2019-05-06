Imports MySql.Data.MySqlClient

Public Class Form_Reservation_Checkin

    Public Venues(5) As Integer
    Public StopV = 0
    Public Items(5) As Integer
    Public ItemsMuch(5) As Integer
    Public StopI = 0

    Private Sub Form_Reservation_Checkin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayR(DataGridView3, ReservedID)
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

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()
    End Sub
End Class