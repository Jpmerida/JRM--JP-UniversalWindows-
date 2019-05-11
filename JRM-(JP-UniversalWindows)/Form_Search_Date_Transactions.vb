Imports MySql.Data.MySqlClient
Public Class Form_Search_Date_Transactions

    Public daytosee As String

    Private Sub Form_Search_Date_Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker4.Value = Now.AddDays(7D)
        Displaybydate(ListView1)
    End Sub
    Public Sub computetotal()
        Dim i As Integer
        Dim pt As Integer
        pt = 0
        For i = 0 To ListView1.Items.Count - 1
            pt = pt + ListView1.Items(i).SubItems(10).Text
        Next i
        Label1.Text = pt.ToString("n2")
    End Sub

    Public Sub Displaybydate(listview As ListView)
        Reportd1 = Format(DateTimePicker3.Value, "yyyy-MM-dd")
        Reportd2 = Format(DateTimePicker4.Value, "yyyy-MM-dd")

        mysql = "SELECT *, COUNT(*) as PAPER, SUM(Gain) AS ROCK
FROM table_transactions
WHERE 
    (table_transactions.`Status` = 'Checkout') AND
    (table_transactions.CheckIn BETWEEN '" & Reportd1 & "' AND '" & Reportd2 & "')
GROUP BY checkin	
ORDER BY table_transactions.TransDate ASC"

        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        listview.Items.Clear()

        Do While dr.Read = True
            newline = listview.Items.Add(dr("T_id"))
            newline.SubItems.Add(dr("U_id"))
            newline.SubItems.Add(dr("G_id"))
            Dim Tran As String = Format(dr("transdate"), "yyyy-MM-dd")
            newline.SubItems.Add(Tran)
            'newline.SubItems.Add(dr("TransDate"))
            newline.SubItems.Add(dr("Status"))
            'newline.SubItems.Add(dr("PAPER"))
            newline.SubItems.Add(dr("PAPER"))
            'newline.SubItems.Add(dr("CheckIn"))
            'newline.SubItems.Add(dr("COUNT(Checkin)"))
            'Dim a As Double = dr("Checkout")
            'Dim b As Double = dr("Discount")
            'Dim c As Double = dr("advance")
            newline.SubItems.Add(dr("Checkout"))
            newline.SubItems.Add(dr("Discount"))
            newline.SubItems.Add(dr("Advance"))
            newline.SubItems.Add(dr("gain"))
            Dim d As Double
            d = dr("Rock")
            newline.SubItems.Add(d.ToString("n2"))
            '
            'newline.SubItems.Add(dr("Gain"))

        Loop

        cmd.Dispose()
        conn.Close()
        computetotal()
    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker4.ValueChanged
        Displaybydate(ListView1)
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        Displaybydate(ListView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Displaybydate(ListView1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connection.Dispose()
        connection.Close()
        connection.Open()
        Dim delete_Print_Transactions As New MySqlCommand("DELETE FROM table_Print_Transactions_by_Date", connection)
        delete_Print_Transactions.ExecuteNonQuery()
        connection.Dispose()
        connection.Close()

        Dim OLD1 As String = DateTimePicker3.Value.ToString("MMM dd, yyyy")
        Dim OLD2 As String = DateTimePicker4.Value.ToString("MMM dd, yyyy")
        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1

            Dim insert_command1 As New MySqlCommand("INSERT INTO `table_Print_Transactions_by_Date`(`Date`,`Transactions`,`Sales`,`DateFirst`,`DateSecond`) VALUES(@a,@b,@c,@d,@e)", connection)
            insert_command1.Parameters.Add("@a", MySqlDbType.VarChar).Value = ListView1.Items(i).SubItems(3).Text
            insert_command1.Parameters.Add("@b", MySqlDbType.Int16).Value = Val(ListView1.Items(i).SubItems(5).Text)
            insert_command1.Parameters.Add("@c", MySqlDbType.Double).Value = ListView1.Items(i).SubItems(10).Text
            insert_command1.Parameters.Add("@d", MySqlDbType.VarChar).Value = OLD1
            insert_command1.Parameters.Add("@e", MySqlDbType.VarChar).Value = OLD2
            execCommand(insert_command1)

        Next i

        Dim xform As New Form_Report_by_date()
        xform.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If ListView1.SelectedItems(0).SubItems(3).Text = Nothing Then
            Else
                daytosee = ListView1.SelectedItems(0).SubItems(3).Text
                Form_Display_Transactions_Date.ShowDialog()
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class