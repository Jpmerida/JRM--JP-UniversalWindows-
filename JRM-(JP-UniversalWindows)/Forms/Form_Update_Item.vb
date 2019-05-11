
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form_Update_Item
    Dim oldID As Integer = ForUpdateITEM_ID

    Public fileSrc As String
    Public fileDestination As String
    Public filename As String
    Private Sub TxtItemPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemQuantity.KeyPress, txtItemPrice.KeyPress
        OnlyNumbers(e)


    End Sub

    Private Sub Form_Update_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mysql = "SELECT * FROM Table_Items WHERE Item_ID = " & ForUpdateITEM_ID
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader

        Do Until dr.Read = False
            PictureBox1.ImageLocation = dr("Item_Image")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            txtItemName.Text = dr("Item_Name")
            txtItemQuantity.Text = dr("Item_Qty")
            txtItemPrice.Text = dr("Item_Price")
            txtItemDescription.Text = dr("Item_Description")
        Loop
        closeDB()
    End Sub


    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If txtItemName.Text = "" Or txtItemPrice.Text = "" Or txtItemQuantity.Text = "" Or txtItemDescription.Text = Nothing Then
            MsgBox("Lacking Requirements.", vbCritical, "New Item [Canceled]")
            Me.Close()
        Else
            Try
                connection.Close()
            Catch ex As Exception

            End Try
            Dim command As New MySqlCommand("UPDATE `Table_Items` SET `Item_Name` = @aa, `Item_Price` = @bb, `Item_Qty` = @cc, `item_Status` = @ee, `item_description` = @FF WHERE Item_ID = " & oldID, connection)
            command.Parameters.Add("@aa", MySqlDbType.VarChar).Value = txtItemName.Text
            command.Parameters.Add("@bb", MySqlDbType.Double).Value = txtItemPrice.Text
            command.Parameters.Add("@cc", MySqlDbType.Int32).Value = txtItemQuantity.Text
            command.Parameters.Add("@ff", MySqlDbType.VarChar).Value = txtItemDescription.Text
            Dim AvailableIsTrue As String
            If txtItemQuantity.Text >= 0 Then
                AvailableIsTrue = 5
            Else
                AvailableIsTrue = 1
            End If
            command.Parameters.Add("@ee", MySqlDbType.Int32).Value = AvailableIsTrue
            closeDB()
            conndb()

            If execCommand(command) Then
            Else
                MessageBox.Show("Data NOT Updated")
                Exit Sub
            End If
            closeDB()
            MsgBox("New item information has been saved successfuly!", vbInformation, "New Item Information [Saved]")
            Form_Management_Item.loaditems()
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class