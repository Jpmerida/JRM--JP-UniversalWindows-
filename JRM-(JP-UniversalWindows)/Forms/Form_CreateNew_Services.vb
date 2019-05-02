Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form_CreateNew_Services
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")
    Dim newcatID As Integer = 0

    Dim fileSrc As String
    Dim fileDestination As String
    Dim filename As String
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
        newcatID = dr("CategoryID")
        txtDesc.Text = dr("CatDescription")
        cmd.Dispose()
        conn.Close()
    End Sub

    Private Sub BTN_INSERT_Click(sender As Object, e As EventArgs) Handles BTN_INSERT.Click
        If (Not System.IO.Directory.Exists(Application.StartupPath & "\JRM_images\")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\JRM_images\")
        End If
        If fileSrc = "" Then
            fileDestination = Application.StartupPath & "\JRM_images\noimg.jpg"
        Else
            filename = Format(Date.Now, "ddhhss") + ".jpg"
            fileDestination = Application.StartupPath & "\JRM_images\" & filename
            FileCopy(fileSrc, fileDestination)
        End If
        Try
            connection.Close()
        Catch ex As Exception
        End Try
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Dim command As New MySqlCommand("INSERT INTO `tblVenue`(`CategoryID`, `Name`, `Status`, `Price`, `Image`, `Image_Location`) VALUES (@ci,@vn,@vs,@vp,@img,@imgLocation)", connection)
        command.Parameters.Add("@ci", MySqlDbType.VarChar).Value = newcatID
        command.Parameters.Add("@vn", MySqlDbType.VarChar).Value = txtName.Text
        command.Parameters.Add("@vs", MySqlDbType.VarChar).Value = ComboBox2.Text
        command.Parameters.Add("@vp", MySqlDbType.Double).Value = txtPrice.Text
        command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = ms.ToArray()
        command.Parameters.Add("@imgLocation", MySqlDbType.VarChar).Value = fileDestination
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
        mysql = "select * from tblvenue where VenueID ='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        Do Until dr.Read = False
            PictureBox1.ImageLocation = dr("Image_Location")
        Loop
        cmd.Dispose()
        conn.Close()
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
            fileSrc = opf.FileName
            PictureBox1.ImageLocation = fileSrc
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        NF = 0
        Me.Button_Update.Visible = True
        Me.BTN_INSERT.Visible = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Update.Click

        ''''''''
        '''
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Dim img() As Byte
        img = ms.ToArray()
        Dim updateQuery As String = "UPDATE tblVenue SET CategoryID = '" & newcatID & "', Name = '" & txtName.Text & "', Status = '" & ComboBox2.Text & "', Price = '" & txtPrice.Text & "', Image = @img WHERE id = " & DataGridView1.CurrentRow.Cells(1).Value

        Dim command As New MySqlCommand(updateQuery, connection)
        command.Parameters.Add("@img", MySqlDbType.Blob).Value = img

        connection.Open()

        If execCommand(command) Then
            MsgBox("Image Updated", vbInformation, "Saved")
            'MessageBox.Show("Data added successfully!")
        Else
            MessageBox.Show("Data NOT Updated")
            Exit Sub
        End If

        connection.Close()
        populateDatagridview(DataGridView1, "")
    End Sub
End Class