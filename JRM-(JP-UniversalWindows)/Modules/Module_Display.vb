Imports MySql.Data.MySqlClient


Module Module_Display
    '--------------------Displaying Users in User Management Form--------------------'

    Public Sub viewusers(listview As ListView, username As String)
            mysql = "select * from tblusers WHERE (UserType = 'Manager' OR  Usertype = 'Staff' OR UserType = 'Supervisor') And CONCAT(Fname, Lname) like '%" & username & "%' order by fname asc"
            conndb()
            cmd = New MySqlCommand(mysql, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            listview.Items.Clear()

            Do While dr.Read = True
                newline = listview.Items.Add(dr("userid"))
                newline.SubItems.Add(dr("fname"))
                newline.SubItems.Add(dr("mname"))
                newline.SubItems.Add(dr("lname"))
                newline.SubItems.Add(dr("gender"))
                newline.SubItems.Add(dr("email"))
                newline.SubItems.Add(dr("contactno"))
                newline.SubItems.Add(dr("address"))
                newline.SubItems.Add(dr("birthdate"))
                newline.SubItems.Add(dr("usercreated"))
                newline.SubItems.Add(dr("usertype"))
                newline.SubItems.Add(dr("username"))
                newline.SubItems.Add(dr("password"))
            Loop

            cmd.Dispose()
            conn.Close()
    End Sub
    '-----------------

    '--------------------Displaying The Services (named Location*)-------------------'
    Public Sub viewVenue(listview As ListView, username As String)
        mysql = "select * from tblVenue where CONCAT(Name,Price) like '%" & username & "%' order by Name asc"
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        listview.Items.Clear()

        Do While dr.Read = True
            newline = listview.Items.Add(dr("VenueID"))
            newline.SubItems.Add(dr("CategoryID"))
            newline.SubItems.Add(dr("Name"))
            newline.SubItems.Add(dr("Price"))
            newline.SubItems.Add(dr("Status"))
        Loop
        cmd.Dispose()
        conn.Close()
    End Sub

    '-------------------------Displaying the Guests/Costumers-----------------------'
    Public Sub viewguests(listview As ListView, username As String)
        mysql = "SELECT * FROM tblguests WHERE Concat(name, email, contactno, address) LIKE '%" & username & "%' order by name asc"
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        listview.Items.Clear()

        Do While dr.Read = True
            newline = listview.Items.Add(dr("guestid"))
            newline.SubItems.Add(dr("name"))
            newline.SubItems.Add(dr("email"))
            newline.SubItems.Add(dr("contactno"))
            newline.SubItems.Add(dr("address"))
            newline.SubItems.Add(dr("Guestcreated"))
        Loop

        cmd.Dispose()
        conn.Close()
    End Sub
    '-----------------------Displaying the Service Categories (Category Types/LocationType)--------------------'
    Public Sub viewCategories(listview As ListView, Search4It As String)
        mysql = "select * from tbllocationtype WHERE CONCAT(CatType, CatDescription) like '%" & Search4It & "%' order by CatType asc"
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        listview.Items.Clear()

        Do While dr.Read = True
            newline = listview.Items.Add(dr("CategoryID"))
            newline.SubItems.Add(dr("CatType"))
            newline.SubItems.Add(dr("CatDescription"))
            newline.SubItems.Add(dr("CatNum"))
            newline.SubItems.Add(dr("CatSize"))
        Loop
        cmd.Dispose()
        conn.Close()
    End Sub


    '==================================================Datagrid'
    Public Sub populateDatagridview(datagrid As DataGridView, valueToSearch As String)
        Dim searchQuery As String = "SELECT VenueID, CategoryID, Name, Status, Price, Image, Image_Location FROM tblvenue WHERE CONCAT(Name, Price) like '%" & valueToSearch & "%' order by CategoryID asc"
        Dim command As New MySqlCommand(searchQuery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        datagrid.AllowUserToAddRows = False
        datagrid.DataSource = table
        'datagrid.RowTemplate.Height = 100
        'Dim imgc As New DataGridViewImageColumn
        'imgc = datagrid.Columns(5)
        'imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
        datagrid.Columns(0).Visible = False
        datagrid.Columns(1).Visible = False
        datagrid.Columns(2).DefaultCellStyle.Format = "n2"
        datagrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        datagrid.Columns(3).DefaultCellStyle.Format = "n2"
        datagrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        datagrid.Columns(4).DefaultCellStyle.Format = "n2"
        datagrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        datagrid.Columns(5).Visible = False
        datagrid.Columns(6).Visible = False
    End Sub

    Public Sub populateDatagridview2(datagrid As DataGridView, valueToSearch As String)
        Dim searchQuery As String = "SELECT * FROM tblvenue WHERE (Status = 'Available') AND CONCAT(Name, Price) like '%" & valueToSearch & "%' order by CategoryID asc"


        Dim command As New MySqlCommand(searchQuery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        datagrid.AllowUserToAddRows = False
        datagrid.DataSource = table
        'datagrid.RowTemplate.Height = 100
        'Dim imgc As New DataGridViewImageColumn
        'imgc = datagrid.Columns(5)
        'imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
        datagrid.Columns(0).Visible = False
        datagrid.Columns(1).Visible = False
        datagrid.Columns(2).DefaultCellStyle.Format = "n2"
        datagrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        datagrid.Columns(3).DefaultCellStyle.Format = "n2"
        datagrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        datagrid.Columns(4).DefaultCellStyle.Format = "n2"
        datagrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        datagrid.Columns(5).Visible = False
        datagrid.Columns(6).Visible = False
    End Sub


    Public Sub displayReserved(datagrid As DataGridView, valueToSearch As String)
        If valueToSearch = "" Then
            Dim searchQuery As String = "SELECT * FROM table_transactions , tblguests WHERE table_transactions.`Status` = 'Reserved' AND tblguests.Remarks = 'Reserved' AND table_transactions.G_id = tblguests.GuestID"
            Dim command As New MySqlCommand(searchQuery, connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            datagrid.AllowUserToAddRows = False
            datagrid.DataSource = table
        Else
            Dim searchQuery As String = "SELECT * FROM table_transactions , tblguests WHERE table_transactions.`Status` = 'Reserved' AND
            tblguests.Remarks = 'Reserved' AND table_transactions.G_id = tblguests.GuestID AND
            CONCAT(tblguests.`Name`) LIKE '%" & valueToSearch & "%'"

            Dim command As New MySqlCommand(searchQuery, connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            datagrid.AllowUserToAddRows = False
            datagrid.DataSource = table
        End If

        datagrid.MultiSelect = False
        datagrid.AllowUserToResizeColumns = False

        datagrid.DefaultCellStyle.SelectionForeColor = Color.Black
        datagrid.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 9.75, FontStyle.Bold)
        datagrid.DefaultCellStyle.Font = New Font("Segoe UI Semibold", 9.75)

        datagrid.AutoResizeColumns()
        datagrid.Columns(0).HeaderText = "ID"
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
        datagrid.Columns(11).Visible = True
        datagrid.Columns(12).Visible = False
        datagrid.Columns(13).Visible = True
        datagrid.Columns(14).Visible = False
        datagrid.Columns(15).Visible = False
        datagrid.Columns(16).Visible = False
        datagrid.Columns(17).Visible = True
    End Sub


End Module


