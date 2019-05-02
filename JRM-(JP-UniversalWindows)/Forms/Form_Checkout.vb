Imports MySql.Data.MySqlClient
Public Class Form_Checkout
    Private Sub Form_Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conndb()
        Dim searchQuery As String = "SELECT * FROM table_Transactions, table_transactiondetails, tblGuests, tblVenue WHERE tblGuests.GuestID = table transactions.G_ID AND table_Transactions.T_ID = table_transactiondetails.T_ID and  = tbleGuests.GuestID AND table_Transactions. order by CategoryID asc"
        Dim command As New MySqlCommand(searchQuery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)


        closeDB()
        '-=-=-=-=-=-'
    End Sub
End Class