Imports MySql.Data.MySqlClient

Public Class Form_Management_Item
    Private Sub Form_Management_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mysql = "SELECT * FROM Table_Items WHERE Item_Status = 5"
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader

        Do Until dr.Read = False
            newline = ListView1.Items.Add(dr("Item_ID"))
            newline.SubItems.Add(dr("Item_Name"))
            newline.SubItems.Add(dr("Item_Qty"))
            newline.SubItems.Add(dr("Item_Price"))
        Loop
        closeDB()
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs)
        mysql = "SELECT Item_Image FROM Table_Items WHERE Item_ID = " & ListView1.SelectedItems(0).Text & ""
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        Do Until dr.Read = False
            PictureBox1.ImageLocation = dr("Item_Image")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Loop
        cmd.Dispose()
        conn.Close()
    End Sub

End Class