Imports MySql.Data.MySqlClient


Module Module1
    '-------Main Thread-------'
    Public connectionString As String
    Public mysql As String
    Public connection As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public conn As MySqlConnection = New MySqlConnection
    Dim newline As ListViewItem
    '-------Main Thread-------'
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~' UserID
    Public UID As Integer
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~' For Updating User & Guest
    Public UIDupdate As Integer
    Public GIDupdate As Integer
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~' 



    Public Sub conndb()
        conn.ConnectionString = ("Server = localhost; uid = root; pwd = admin; database = jrm")
        conn.Open()
    End Sub

    '--------------------Displaying Users in User Management Form--------------------'

    Public Sub viewusers(listview As ListView, username As String)
        If username = "" Then
            mysql = "select * from tblusers"
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
            mysql = "select * from tblusers where fname like '" & username & "%' order by fname asc"
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


    '--------------------Displaying The Services (named Location*)-------------------'
    Public Sub viewLocation(listview As ListView, Search4It As String)


        If Search4It = "" Then
            mysql = "select * from tbllocation"
            conndb()
            cmd = New MySqlCommand(mysql, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            listview.Items.Clear()

            Do While dr.Read = True

                newline = listview.Items.Add(dr("LocationID"))
                newline.SubItems.Add(dr("CategoryID"))
                newline.SubItems.Add(dr("LocationName"))
                newline.SubItems.Add(dr("LocationPrice"))
                newline.SubItems.Add(dr("LocationStatus"))

            Loop

            cmd.Dispose()
            conn.Close()
        Else
            mysql = "select * from tbllocation where LocationName like '" & Search4It & "%' order by LocationName asc"
            conndb()
            cmd = New MySqlCommand(mysql, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            listview.Items.Clear()

            Do While dr.Read = True
                newline = listview.Items.Add(dr("LocationID"))
                newline.SubItems.Add(dr("CategoryID"))
                newline.SubItems.Add(dr("LocationName"))
                newline.SubItems.Add(dr("LocationPrice"))
                newline.SubItems.Add(dr("LocationStatus"))
            Loop
            cmd.Dispose()
            conn.Close()
        End If
    End Sub

    '-------------------------Displaying the Guests/Costumers-----------------------'
    Public Sub viewguests(listview As ListView, name As String)
        Dim newline As ListViewItem

        If name = "" Then
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
            mysql = "select * from tblguests where name like '" & name & "%' order by name asc"
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
                newline.SubItems.Add(dr("guestcreated"))
            Loop

            cmd.Dispose()
            conn.Close()
        End If
    End Sub

End Module
