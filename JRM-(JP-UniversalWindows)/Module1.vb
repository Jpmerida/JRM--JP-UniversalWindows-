Imports MySql.Data.MySqlClient


Module Module1
    '-------Main Thread-------'
    Public connectionString As String
    Public mysql As String
    Public connection As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public conn As MySqlConnection = New MySqlConnection
    '-------Main Thread-------'

    Public UID As Integer


    Public Sub conndb()
        conn.ConnectionString = ("Server = localhost; uid = root; pwd = admin; database = jrm")
        conn.Open()
    End Sub


    Public Sub viewLocation(listview As ListView, Search4It As String)
        Dim newline As ListViewItem

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
End Module
