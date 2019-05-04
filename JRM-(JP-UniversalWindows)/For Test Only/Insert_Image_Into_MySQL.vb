Imports MySql.Data.MySqlClient
Imports System.IO

''After 3 hours and 28 minutes, IT FINALLY WORKS ' now experiments

Public Class Insert_Image_Into_MySQL
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")

    Private Sub Insert_Image_Into_MySQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New MySqlCommand("select * from table_images", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table

        imgc = DataGridView1.Columns(4)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
        populateDatagridview("")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)

        End If

    End Sub

    Private Sub BTN_INSERT_Click(sender As Object, e As EventArgs) Handles BTN_INSERT.Click
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

        Dim command As New MySqlCommand("INSERT INTO `table_images`(`PicName`, `PicDescription`, `TheImage`) VALUES (@nm,@ds,@img)", connection)

        command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = TextBoxName.Text
        command.Parameters.Add("@ds", MySqlDbType.VarChar).Value = TextBoxDesc.Text
        command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = ms.ToArray()

        closeDB()
        conndb()
        If execCommand(command) Then
            MsgBox("New Information has been saved", vbInformation, "Saved")
            'MessageBox.Show("Data added successfully!")
        Else
            MessageBox.Show("Data NOT Updated")
            Exit Sub
        End If
        closeDB()
        populateDatagridview("")
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim img As Byte()
        img = DataGridView1.CurrentRow.Cells(4).Value
        Dim ms As New MemoryStream(img)

        PictureBox1.Image = Image.FromStream(ms)
        TextBoxID.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBoxName.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBoxDesc.Text = DataGridView1.CurrentRow.Cells(3).Value
    End Sub



    Private Sub BTN_UPDATE_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Dim img() As Byte
        img = ms.ToArray()
        Dim updateQuery As String = "UPDATE Table_Images SET PicName = '" & TextBoxName.Text & "', PicDescription = '" & TextBoxDesc.Text & "', TheImage = @img WHERE id = " & TextBoxID.Text

        Dim command As New MySqlCommand(updateQuery, connection)
        command.Parameters.Add("@img", MySqlDbType.Blob).Value = img

        closeDB()
        conndb()
        If execCommand(command) Then
            MsgBox("Image Updated", vbInformation, "Saved")
            'MessageBox.Show("Data added successfully!")
        Else
            MessageBox.Show("Data NOT Updated")
            Exit Sub
        End If
        closeDB()
        populateDatagridview("")
    End Sub

    Private Sub BTN_DELETE_Click(sender As Object, e As EventArgs) Handles BTN_DELETE.Click
        Dim deleteQuery As String = "DELETE FROM Table_Images WHERE id = " & TextBoxID.Text
        Dim command As New MySqlCommand(deleteQuery, connection)

        closeDB()
        conndb()
        If execCommand(command) Then
            MsgBox("Information Deleted", vbInformation, "Deleted")
            'MessageBox.Show("Data added successfully!")
        Else
            MessageBox.Show("Deletion Succcessful")
            Exit Sub
        End If
        closeDB()
        populateDatagridview("")
    End Sub



    Public Sub populateDatagridview(valueToSearch As String)

        Dim searchQuery As String = "SELECT * From Table_Images WHERE CONCAT(PicName,PicDescription) like '%" & valueToSearch & "%'"

        Dim command As New MySqlCommand(searchQuery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table

        imgc = DataGridView1.Columns(4)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch

    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        populateDatagridview(TextBoxSearch.Text)
    End Sub

    Private Sub BTN_FIND_Click(sender As Object, e As EventArgs) Handles BTN_FIND.Click
        Dim command As New MySqlCommand("select * from table_images WHERE id = @id ", connection)
        command.Parameters.Add("@id", MySqlDbType.String).Value = TextBoxID.Text
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MessageBox.Show("No Data Found")
        Else
            TextBoxID.Text = table.Rows(0)(0).ToString()
            TextBoxName.Text = table.Rows(0)(2).ToString()
            TextBoxDesc.Text = table.Rows(0)(3).ToString()
            Dim img() As Byte
            img = table.Rows(0)(4)
            Dim ms As New MemoryStream(img)
            PictureBox1.Image = Image.FromStream(ms)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView2.Rows.Add(TextBox1.Text, TextBox2.Text, True)
    End Sub
End Class