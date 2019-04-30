Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form_Checkin_Venue

    Private Sub CheckinSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''InitializeComponent()
        txtCatType.Text = ""
        txtPrice.Text = ""
        txtDesc.Text = ""
        txtName.Text = ""
        txtStatus.Text = ""

        If CheckServiceID = 0 Then
            Button4.Enabled = False
        Else
            Button4.Enabled = True
        End If


        populateDatagridview(DataGridView1, "")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckServiceID = 0
        SubTot = 0
        Me.Close()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim id As Integer
        id = Integer.Parse(USERID_table(0)(0))

        Dim item As String
        item = "Service " + txtName.Text

        Dim price As Double
        price = Double.Parse(txtPrice.Text).ToString("n2")

        Dim selected As Double
        selected = 1

        Dim total As Double
        total = Double.Parse(selected * price)
        SubTot += total

        ''CheckinForm.DataGridView1.Rows.Add(id, item, price, "1", total, True)
        table2.Rows.Add(id, item, price, "1", total)

        Form_Checkin.DataGridView1.DataSource = table2

        tempSub = SubTot
        Form_Checkin.TextBox1.Text = tempSub.ToString("n2")
        Me.Close()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        populateDatagridview(DataGridView1, TextBox1.Text)
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim img As Byte()
        img = DataGridView1.CurrentRow.Cells(5).Value
        Dim ms As New MemoryStream(img)

        PictureBox1.Image = Image.FromStream(ms)
        'txtCatType.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtName.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtStatus.Text = DataGridView1.CurrentRow.Cells(3).Value
        Dim price As Double
        price = DataGridView1.CurrentRow.Cells(4).Value
        txtPrice.Text = price.ToString("n2")

        mysql = "select * from tbllocationtype where CategoryID ='" & DataGridView1.CurrentRow.Cells(1).Value & "'"
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        dr.Read()
        txtCatType.Text = dr("CatType")
        txtDesc.Text = dr("CatDescription")
        cmd.Dispose()
        conn.Close()
        Button4.Enabled = True
    End Sub

    Private Sub TxtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
    AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub
End Class