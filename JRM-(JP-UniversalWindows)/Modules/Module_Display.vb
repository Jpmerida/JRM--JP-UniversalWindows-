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
        mysql = "SELECT * FROM tblguests WHERE Remarks = 'Available' AND Concat(name, email, contactno, address) LIKE '%" & username & "%' order by name asc"
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


    Public Sub populateDatagridview10(lv As ListView, Search4Me As String)
        'valuetosearch = "m"


        lv.Items.Clear()
        Dim Venues(20) As Integer
        Array.Clear(Venues, 0, Venues.Length)
        Dim newdate As DateTime = test5
        Dim time As DateTime = DateTime.Now
        Dim format As String = "yyyy-MM-dd"
        Dim VArray As New List(Of Integer)
        'Dim Array() As Integer
        'ReDim Preserve VArray()

        If test5 = Now.ToString(format) Then
            Dim searchQuery As String = "SELECT *
        FROM
        tblvenue 
        WHERE
        CONCAT(tblvenue.`Name`, tblvenue.Price) LIKE '%" & Search4Me & "%' AND
        tblvenue.`Status` = 'Available'       
        ORDER BY VenueID ASC"
            Dim command As New MySqlCommand(searchQuery, connection)
            Dim adapter As New MySqlDataAdapter(command)
            connection.Dispose()
            connection.Close()
            connection.Open()
            dr = command.ExecuteReader(CommandBehavior.CloseConnection)
            Do While dr.Read = True
                newline = lv.Items.Add(dr("VenueID"))
                newline.SubItems.Add(dr("CategoryID"))
                newline.SubItems.Add(dr("Name"))
                newline.SubItems.Add(dr("Status"))
                newline.SubItems.Add(dr("Price"))
                'newline.SubItems.Add(dr("Image"))
                newline.SubItems.Add(dr("Image_Location"))
            Loop

            connection.Dispose()
            connection.Close()
            connection.Open()
        Else
            Dim searchQuery As String = "SELECT *
        FROM
        tblvenue ,
        table_transactions ,
        table_transactiondetailsvenue
        WHERE
        CONCAT(tblvenue.`Name`, tblvenue.Price) LIKE '%" & Search4Me & "%' AND
        tblvenue.VenueID = table_transactiondetailsvenue.Item_ID AND
        table_transactiondetailsvenue.T_id = table_transactions.T_id AND
        (table_transactions.`Status` = 'Checkin' OR
        table_transactions.`Status` = 'Reserved' ) AND
        table_transactions.CheckIn = '" & test5 & "'        
        ORDER BY VenueID ASC"

            Dim command As New MySqlCommand(searchQuery, connection)
            Dim adapter As New MySqlDataAdapter(command)


            connection.Dispose()
            connection.Close()
            connection.Open()
            dr = command.ExecuteReader(CommandBehavior.CloseConnection)
            Dim x As Integer = 0
            Do While dr.Read = True

                Venues(x) = dr("VenueID")
                VArray.Add(dr("VenueID"))
                x += 1
            Loop

            connection.Dispose()
            connection.Close()
            connection.Open()


            If VArray.Count = Nothing Then
                mysql = "SELECT * FROM tblvenue"
                cmd = New MySqlCommand(mysql, conn)
                connection.Dispose()
                connection.Close()
                conn.Open()
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                Do While dr.Read = True
                    newline = lv.Items.Add(dr("VenueID"))
                    newline.SubItems.Add(dr("CategoryID"))
                    newline.SubItems.Add(dr("Name"))
                    newline.SubItems.Add(dr("Status"))
                    newline.SubItems.Add(dr("Price"))
                    'newline.SubItems.Add(dr("Image"))
                    newline.SubItems.Add(dr("Image_Location"))
                Loop
                dr.Dispose()
                dr.Close()
                cmd.Dispose()
                conn.Dispose()
                conn.Close()

                'ReDim Preserve VArray()
                VArray.Clear()
                Exit Sub
            End If



            Dim mysql1 As String
            Dim cmd1 As MySqlCommand
            Dim dr1 As MySqlDataReader

            mysql1 = "SELECT * FROM tblvenue ORDER BY VenueID ASC"
            cmd1 = New MySqlCommand(mysql1, conn)

            conndb()
            dr1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection)
            'cmd1.ExecuteNonQuery()
            Dim First1 As Integer
            Dim i As Integer = 0
            Do While dr1.Read = True
                First1 = dr1("VenueID")

                If (Venues(i) = First1) Then
                Else
                    newline = lv.Items.Add(dr1("VenueID"))
                    newline.SubItems.Add(dr1("CategoryID"))
                    newline.SubItems.Add(dr1("Name"))
                    newline.SubItems.Add(dr1("Status"))
                    newline.SubItems.Add(dr1("Price"))
                    'newline.SubItems.Add(dr1("Image"))
                    newline.SubItems.Add(dr1("Image_Location"))
                End If
            Loop

            closeDB()
            Array.Clear(Venues, 0, Venues.Length)
            VArray.Clear()
        End If






    End Sub



End Module


