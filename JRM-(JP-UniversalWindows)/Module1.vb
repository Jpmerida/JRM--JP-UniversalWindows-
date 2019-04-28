Imports MySql.Data.MySqlClient


Module Module1

    '-------Main Thread-------'
    Public connectionString As String
    Public mysql As String
    ''Public connection As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public conn As MySqlConnection = New MySqlConnection
    Public newline As ListViewItem 'dim
    '-------Main Thread-------'
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~' UserID
    Public USERID_table As New DataTable()
    Public UID As Integer
    Public UIDType As String = "NONE"
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~' For Updating User & Guest/ Location/Spot/Venue
    Public UIDupdate As Integer = 0
    Public GIDupdate As Integer = 0
    Public UsableID As Integer

    Public VUIupdate As Integer
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~' Use for inputing CheckIn

    Public ItsOKAY As Integer = 0
    Public CheckGuestID As Integer
    Public CheckServiceID As Integer = 0
    Public tempSub As Double = 0
    Public SubTot As Double = 0.00
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~' For Opening New Forms (LIMITING only 1 window to open)
    Public Procced As Integer = 0 'for LOGIN FORM
    Public NewAcc As Integer = 0 'for CREATING NEW FORM
    Public UM As Integer = 0 'for USER MANAGEMENT FORM
    Public GM As Integer = 0 'for GUEST MANAGEMENT FORM
    Public SM As Integer = 0 'for SERVICES MANAGEMENT FORM
    Public SC As Integer = 0 'for SERVICE CATEGORIES FORM
    Public SC2 As Integer = 0 'for NEW SERVICE CATEGORIES FORM
    Public CG As Integer = 0 'for CHECKIN GUEST FORM
    Public NF As Integer = 0 'for ADDING SERVICES MANAGEMENT FORM
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~' 

    Public first1 = New first()
    Public GuestWindow = New GuestsManagement()
    Public CLogin = New LoginForm()
    Public MMenu = New MainMenu()
    Public ServicesFORM = New VenueManagementForm()
    Public CategoryForm = New ServiceCategories()
    Public NewCategoryFORM = New CreateNewCategoryType()
    Public ADDServicesForm = New FORM_AddNewServices()
    Public UserWindow = New UserManagement()
    'checkin'
    Public CInForm = New CheckinForm()
    Public CheckInG As New CheckinGuest()
    Public table2 As New DataTable("Table")

    Public connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")

    Public Sub openLogin(NoNumber As Integer)
        If Procced = 0 Then
            CLogin = New LoginForm()
            CLogin.MdiParent = first
            CLogin.Text = "Form - " + first.MdiChildren.Length.ToString()
            CLogin.LayoutMdi(MdiLayout.TileHorizontal)
            CLogin.dock = DockStyle.Left
            CLogin.Show()
            Procced = 1
        End If
    End Sub

    Public Sub openGWindow(NoNumber As Integer)
        If GM = 0 Then
            'GuestsManagement.ShowDialog()
            GuestWindow = New GuestsManagement()
            GuestWindow.MdiParent = first
            GuestWindow.Text = "Guest Management Form - " + first.MdiChildren.Length.ToString()
            GuestWindow.show
            GM = 1
        End If
    End Sub

    Public Function execCommand(ByVal cmd As MySqlCommand) As Boolean
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Try
            If cmd.ExecuteNonQuery() = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
        If connection.State = ConnectionState.Open Then
            connection.Dispose()
            connection.Close()
        End If
    End Function

    Public Sub conndb()
        Try
            conn.ConnectionString = ("Server = localhost; uid = root; pwd = admin; database = jrm")
            conn.Open()
        Catch ex As Exception
            Return
        End Try
    End Sub

    '--------------------Displaying Users in User Management Form--------------------'

    Public Sub viewusers(listview As ListView, username As String)
        If username = "" Then
            mysql = "select * from tblusers WHERE UserType = 'Manager' OR  Usertype = 'Staff' OR UserType = 'Supervisor'"
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
        Else
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
        End If
    End Sub
    '-----------------


    Public Sub populateDatagridview(datagrid As DataGridView, valueToSearch As String)
        Dim searchQuery As String = "SELECT * From tblVenue WHERE CONCAT(Name, Price) like '%" & valueToSearch & "%' order by CategoryID asc"
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

    '--------------------Displaying The Services (named Location*)-------------------'
    Public Sub viewVenue(listview As ListView, username As String)
        If username = "" Then
            mysql = "select * from tblVenue"
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
            'ElseIf Search4It = "Available" Then


        Else
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
        End If
    End Sub

    '-------------------------Displaying the Guests/Costumers-----------------------'
    Public Sub viewguests(listview As ListView, username As String)
        'Dim newline As ListViewItem

        If username = "" Then
            mysql = "select * from tblguests"
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
        Else
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
        End If
    End Sub
    '-----------------------Displaying the Service Categories (Category Types/LocationType)--------------------'
    Public Sub viewCategories(listview As ListView, Search4It As String)


        If Search4It = "" Then
            mysql = "select * from tbllocationtype"
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
        Else
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
        End If
    End Sub


End Module


