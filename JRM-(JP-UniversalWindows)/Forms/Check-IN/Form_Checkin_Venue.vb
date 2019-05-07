Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form_Checkin_Venue

    Private Sub CheckinSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''InitializeComponent()
        CheckServiceID = 0
        clearall()

        populateDatagridview10(ListView1, "")
        Label2.Text = test5

    End Sub
    Sub clearall()
        txtCatType.Text = ""
        txtPrice.Text = ""
        txtDesc.Text = ""
        txtName.Text = ""
        txtStatus.Text = ""
        CheckServiceID = 0
        If CheckServiceID = 0 Then
            Button4.Enabled = False
        Else
            Button4.Enabled = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckServiceID = 0
        'SubTot = 0
        Me.Close()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim id As Integer
        id = CheckServiceID

        Dim item As String
        item = "Service [" + txtName.Text + "]"

        Dim price As Double
        price = Double.Parse(txtPrice.Text).ToString("n2")

        Dim selected As Double
        selected = 1

        Dim total As Double
        total = Double.Parse(selected * price)
        'SubTot += total

        ''CheckinForm.DataGridView1.Rows.Add(id, item, price, "1", total, True)
        table2.Rows.Add(id, item, price, 1, total, "V000")

        ''For Form_Reservation_Checkin FORM
        Form_Reservation_Checkin.DataGridView1.Rows.Add(id, item, price, 1, total, "V000")
        Form_Reservation_Checkin.Venues(Form_Reservation_Checkin.StopV) = CheckServiceID
        Form_Reservation_Checkin.StopV += 1
        ''=-=-=---=-=-=-=-=-=-=-=-=-=-=-=-=

        Form_Checkin.DataGridView1.DataSource = table2
        Form_Reservation.DataGridView1.DataSource = table2



        Dim i As Integer
        For i = 0 To Form_Checkin.DataGridView1.Rows.Count - 1
            Form_Checkin.PartialTotal = Val(Form_Checkin.DataGridView1.Rows(i).Cells(4).Value)
        Next i
        Form_Checkin.GrandTotal = Form_Checkin.GrandTotal + Form_Checkin.PartialTotal
        Form_Checkin.lblGrandTotal.Text = FormatNumber(Form_Checkin.GrandTotal)

        Form_Checkin.Venues(Form_Checkin.StopV) = CheckServiceID
        Form_Checkin.StopV += 1

        Dim x As Integer
        For x = 0 To Form_Reservation.DataGridView1.Rows.Count - 1
            Form_Reservation.PartialTotal = Val(Form_Reservation.DataGridView1.Rows(x).Cells(4).Value)
        Next x
        Form_Reservation.GrandTotal = Form_Reservation.GrandTotal + Form_Reservation.PartialTotal
        Form_Reservation.lblGrandTotal.Text = FormatNumber(Form_Reservation.GrandTotal)
        Form_Reservation.Venues(Form_Reservation.StopV) = CheckServiceID
        Form_Reservation.StopV += 1

        Me.Close()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        populateDatagridview10(ListView1, TextBox1.Text)
    End Sub


    Private Sub TxtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
    AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click

        Try
            PictureBox1.ImageLocation = ListView1.SelectedItems(0).SubItems(5).Text

            CheckServiceID = ListView1.SelectedItems(0).SubItems(0).Text
            ''CheckServiceTypeID = DataGridView1.CurrentRow.Cells(1).Value
            txtName.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtStatus.Text = ListView1.SelectedItems(0).SubItems(3).Text
            Dim price As Double
            price = ListView1.SelectedItems(0).SubItems(4).Text
            txtPrice.Text = price.ToString("n2")

            mysql = "select * from tbllocationtype where CategoryID ='" & ListView1.SelectedItems(0).SubItems(1).Text & "'"
            conndb()
            cmd = New MySqlCommand(mysql, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dr.Read()
            txtCatType.Text = dr("CatType")
            txtDesc.Text = dr("CatDescription")
            cmd.Dispose()
            conn.Close()
            Button4.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
End Class