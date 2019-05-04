Imports MySql.Data.MySqlClient

Public Class Form_Checkin_Item
    Dim tempId As Integer = 0
    Dim price As Double = 0
    Dim selected As Double = 0
    Dim total As Double = 0
    Dim quantity As Integer = 0
    Private Sub Form_Checkin_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearall()
        loaditems()
    End Sub

    Sub clearall()
        tempId = 0
        price = 0
        selected = 0
        total = 0
        quantity = 0
        PictureBox1.ImageLocation = ""
        txtItemName.Text = "_________________"
        ComboBox_Qty.Text = 1
        txtTotal.Text = "_________________"
    End Sub
    Public Sub loaditems()
        mysql = "SELECT * FROM Table_Items WHERE Item_Status = 5"
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

    Private Sub Button_AddItem_Click(sender As Object, e As EventArgs) Handles Button_AddItem.Click
        If tempId = 0 Then
            Exit Sub
        ElseIf ComboBox_Qty.Text <= Nothing Then
            Exit Sub
        ElseIf quantity < ComboBox_Qty.Text Then
            MsgBox("Insufficient product supply", vbCritical, "Out of Order")
            Exit Sub
        End If



        Dim id As Integer
        id = ListView1.SelectedItems.Item(0).SubItems(0).Text

        Dim item As String
        item = "Item [" + txtItemName.Text + "]"
        price = Double.Parse(ListView1.SelectedItems.Item(0).SubItems(3).Text) '.ToString("n2")
        selected = ComboBox_Qty.Text
        total = Double.Parse(selected * price)
        Form_Checkin.SubTot += total

        table2.Rows.Add(id, item, price, selected, total, "I000")

        Form_Checkin.DataGridView1.DataSource = table2

        Dim i As Integer
        For i = 0 To Form_Checkin.DataGridView1.Rows.Count - 1
            Form_Checkin.PartialTotal = Val(Form_Checkin.DataGridView1.Rows(i).Cells(4).Value)
        Next i
        Form_Checkin.GrandTotal = Form_Checkin.GrandTotal + Form_Checkin.PartialTotal
        Form_Checkin.lblGrandTotal.Text = FormatNumber(Form_Checkin.GrandTotal)

        Form_Checkin.ItemsMuch(Form_Checkin.StopI) = ComboBox_Qty.Text
        Form_Checkin.Items(Form_Checkin.StopI) = tempId
        Form_Checkin.StopI += 1

        'Me.Controls.Clear() 'removes all the controls on the form
        'load all the controls again
        'Form_Checkin_Item_Load(e, e)
        Me.Close()

    End Sub

    Private Sub ComboBox_Qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox_Qty.KeyPress
        OnlyNumbers(e)
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

    Private Sub ComboBox_Qty_TextChanged(sender As Object, e As EventArgs) Handles ComboBox_Qty.TextChanged
        SubTotalCount()
    End Sub

    Public Sub SubTotalCount()
        If tempId = 0 Then
            ListView1.Select()
            Exit Sub
        Else
            If ComboBox_Qty.Text = Nothing Then
                Exit Sub
            End If
            Try
                txtTotal.Text = Double.Parse(Val(ComboBox_Qty.Text * Double.Parse(ListView1.SelectedItems.Item(0).SubItems(3).Text))).ToString("n2")

            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        mysql = "SELECT * FROM Table_Items WHERE Item_ID = " & ListView1.SelectedItems(0).Text & ""
        closeDB()
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        Do Until dr.Read = False
            tempId = dr("Item_ID")
            PictureBox1.ImageLocation = dr("Item_Image")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            txtItemName.Text = dr("Item_Name")
            quantity = dr("Item_Qty")
        Loop
        SubTotalCount()
        closeDB()
    End Sub
End Class