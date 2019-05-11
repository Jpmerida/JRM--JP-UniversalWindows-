Imports MySql.Data.MySqlClient

Public Class Form_Display_Transactions_Date
    Private Sub Form_Display_Transactions_Date_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Displaybydate(ListView1)
        computetotal()
    End Sub

    Public Sub computetotal()
        Dim i As Integer
        Dim pt As Integer
        pt = 0
        For i = 0 To ListView1.Items.Count - 1
            pt = pt + ListView1.Items(i).SubItems(2).Text
        Next i
        Label1.Text = pt.ToString("n2")
    End Sub

    Public Sub Displaybydate(listview As ListView)
        mysql = "SELECT
        tblguests.`Name`,
        tblguests.Address,
        SUM(table_transactions.Gain) as NEWGAIN
        FROM
        table_transactions
        INNER JOIN tblguests ON tblguests.GuestID = table_transactions.G_id
        WHERE
        table_transactions.CheckIn = '" & Form_Search_Date_Transactions.daytosee & "'
        GROUP BY G_id"

        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        listview.Items.Clear()

        Do While dr.Read = True
            newline = listview.Items.Add(dr("Name"))
            newline.SubItems.Add(dr("Address"))
            Dim d As Double
            d = dr("NEWGAIN")
            newline.SubItems.Add(d.ToString("n2"))
            '
            'newline.SubItems.Add(dr("Gain"))

        Loop

        cmd.Dispose()
        conn.Close()
        computetotal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class