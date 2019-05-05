Imports MySql.Data.MySqlClient

Public Class Form_Management_Item
    Private Sub Form_Management_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaditems()
        loadagain()
    End Sub
    Sub loadagain()
        If UIDType = "Admin" Or UIDType = "Manager" Then
            Panel2.Visible = True
        Else
            Panel2.Visible = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        mysql = "SELECT * FROM Table_Items where CONCAT(Item_Name, Item_Price) like '%" & TextBox1.Text & "%' AND Item_Status = 5"
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        Do Until dr.Read = False
            newline = ListView1.Items.Add(dr("Item_ID"))
            newline.SubItems.Add(dr("Item_Name"))
            newline.SubItems.Add(dr("Item_Qty"))
            newline.SubItems.Add(dr("Item_Price"))
        Loop
        closeDB()
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        mysql = "SELECT * FROM Table_Items WHERE Item_ID = " & ListView1.SelectedItems(0).Text & ""
        closeDB()
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        Do Until dr.Read = False
            PictureBox1.ImageLocation = dr("Item_Image")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            txtItemDescription.Text = dr("Item_Description")
            txtItemName.Text = dr("Item_Name")
            txtItemPrice.Text = dr("Item_Price")
            txtItemQuantity.Text = dr("Item_qty")
        Loop
        closeDB()
    End Sub

    Private Sub Btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        loaditems()
    End Sub

    Public Sub loaditems()
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

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Form_Main.IM = 0
        Me.Close()
    End Sub
End Class