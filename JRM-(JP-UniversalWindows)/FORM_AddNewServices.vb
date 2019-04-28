Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FORM_AddNewServices
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")

    Private Sub FORM_AddNewServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conndb()
            mysql = "select * from tbllocationtype"
            cmd = New MySqlCommand(mysql, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read()
                Dim Nametype = dr("CatType")
                ComboBox1.Items.Add(Nametype)
            End While
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            Return
        End Try
        populateDatagridview(DataGridView1, "")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        cmd.Dispose()
        conn.Close()
        mysql = "select * from tbllocationtype where CatType ='" & ComboBox1.SelectedItem.ToString() & "'"
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        dr.Read()
        txtDesc.Text = dr("CatDescription")
        cmd.Dispose()
        conn.Close()
    End Sub

    Private Sub BTN_INSERT_Click(sender As Object, e As EventArgs) Handles BTN_INSERT.Click
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Dim command As New MySqlCommand("INSERT INTO `tblVenue`(`CategoryID`, `Name`, `Status`, `Price`, `Image`) VALUES (@ci,@vn,@vs,@vp,@img)", connection)
        command.Parameters.Add("@ci", MySqlDbType.VarChar).Value = ComboBox1.Text
        command.Parameters.Add("@vn", MySqlDbType.VarChar).Value = txtName.Text
        command.Parameters.Add("@vs", MySqlDbType.VarChar).Value = ComboBox2.Text
        command.Parameters.Add("@vp", MySqlDbType.Double).Value = txtPrice.Text
        command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = ms.ToArray()
        connection.Open()
        If execCommand(command) Then
            MsgBox("New Information has been saved", vbInformation, "Saved")
        Else
            MessageBox.Show("Data NOT Updated")
            Exit Sub
        End If
        connection.Close()
        populateDatagridview(DataGridView1, "")
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim img As Byte()
        img = DataGridView1.CurrentRow.Cells(5).Value
        Dim ms As New MemoryStream(img)
        PictureBox1.Image = Image.FromStream(ms)
        txtName.Text = DataGridView1.CurrentRow.Cells(2).Value
        ComboBox2.Text = DataGridView1.CurrentRow.Cells(3).Value
        Dim price As Double
        price = DataGridView1.CurrentRow.Cells(4).Value
        txtPrice.Text = price.ToString("n2")
        mysql = "select * from tbllocationtype where CategoryID ='" & DataGridView1.CurrentRow.Cells(1).Value & "'"
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        dr.Read()
        ComboBox1.Text = dr("CatType")
        cmd.Dispose()
        conn.Close()
    End Sub

    Private Sub SelectImage_Click(sender As Object, e As EventArgs) Handles SelectImage.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        NF = 0
        Me.Close()
    End Sub
End Class