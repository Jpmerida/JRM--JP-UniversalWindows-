
Imports MySql.Data.MySqlClient
Imports System.IO


Public Class Form_CreateNew_Item
    Public fileSrc As String
    Public fileDestination As String
    Public filename As String

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub TxtItemPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemPrice.KeyPress
        OnlyNumbers(e)
    End Sub
    Private Sub TxtItemQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemQuantity.KeyPress
        OnlyNumbers(e)
    End Sub

    Private Sub SelectImage_Click(sender As Object, e As EventArgs) Handles SelectImage.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = DialogResult.OK Then
            fileSrc = opf.FileName
            PictureBox1.ImageLocation = fileSrc
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If fileSrc = "" Or txtItemName.Text = "" Or txtItemPrice.Text = "" Or txtItemQuantity.Text = "" Then
            MsgBox("Lacking Requirements.", vbCritical, "New Item [Canceled]")
            Me.Close()
        Else
            If (Not System.IO.Directory.Exists(Application.StartupPath & "\JRM_images\Items\")) Then
                System.IO.Directory.CreateDirectory(Application.StartupPath & "\JRM_images\Items\")
            End If
            If fileSrc = "" Then
                fileDestination = Application.StartupPath & "\JRM_images\Items\noimg.jpg"
            Else
                filename = Format(Date.Now, "ddhhss") + ".jpg"
                fileDestination = Application.StartupPath & "\JRM_images\Items\" & filename
                FileCopy(fileSrc, fileDestination)
            End If
            Try
                connection.Close()
            Catch ex As Exception

            End Try
            Dim command As New MySqlCommand("INSERT INTO `Table_Items`(`Item_Name`, `Item_Price`, `Item_Qty`, `Item_Image`, `item_Status`) VALUES (@aa,@bb,@cc,@dd,@ee)", connection)
            command.Parameters.Add("@aa", MySqlDbType.VarChar).Value = txtItemName.Text
            command.Parameters.Add("@bb", MySqlDbType.Double).Value = txtItemPrice.Text
            command.Parameters.Add("@cc", MySqlDbType.Int32).Value = txtItemQuantity.Text
            command.Parameters.Add("@dd", MySqlDbType.VarChar).Value = fileDestination
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
                MsgBox("New Information has been saved", vbInformation, "Saved")
            Else
                MessageBox.Show("Data NOT Updated")
                Exit Sub
            End If
            closeDB()
            MsgBox("New item has been saved successfuly!", vbInformation, "New Item [Saved]")
            Me.Close()
        End If

    End Sub
End Class