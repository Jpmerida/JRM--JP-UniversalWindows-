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
        Dim searchQuery As String = "SELECT VenueID, CategoryID, Name, Status, Price, Image FROM tblvenue WHERE CONCAT(Name, Price) like '%" & valueToSearch & "%' order by CategoryID asc"
        Dim command As New MySqlCommand(searchQuery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        datagrid.AllowUserToAddRows = False
        datagrid.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn
        datagrid.DataSource = table
        imgc = datagrid.Columns(5)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
        datagrid.Columns(0).Visible = False
        datagrid.Columns(1).Visible = False
        datagrid.Columns(2).DefaultCellStyle.Format = "n2"
        datagrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        datagrid.Columns(3).DefaultCellStyle.Format = "n2"
        datagrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        datagrid.Columns(4).DefaultCellStyle.Format = "n2"
        datagrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

End Module


