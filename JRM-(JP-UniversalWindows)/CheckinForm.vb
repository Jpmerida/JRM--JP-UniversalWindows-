Imports MySql.Data.MySqlClient

Public Class CheckinForm

    Dim selectedRowIndex As Integer

    Public checkinform
    Private Sub CheckinForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.WindowState = FormWindowState.Normal


        Dim continueonce As Integer = 0
        If continueonce = 0 Then
            table2.Columns.Add("ID", Type.GetType("System.Int32"))
            table2.Columns.Add("ITEM", Type.GetType("System.String"))
            table2.Columns.Add("PRICE", Type.GetType("System.Double"))
            table2.Columns.Add("SELECTED", Type.GetType("System.Double"))
            table2.Columns.Add("TOTAL", Type.GetType("System.Double"))
            DataGridView1.DataSource = table2
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
            Me.DataGridView1.Columns(0).Width = 0
            Me.DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
            Me.DataGridView1.Columns(1).Width = 200
            Me.DataGridView1.Columns(2).DefaultCellStyle.Format = "n2"
            Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.DataGridView1.Columns(3).DefaultCellStyle.Format = "n2"
            Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.DataGridView1.Columns(4).DefaultCellStyle.Format = "n2"
            Me.DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            continueonce = 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CG = 0 Then
            CheckInG = New CheckinGuest()
            'CheckInG.MdiParent = Me.MdiParent
            CheckInG.ShowDialog()
            CG = 1
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (ItsOKAY = 1) Then


        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim id As Integer
        id = Integer.Parse(USERID_table(0)(0))

        Dim item As String
        item = "Number of Persons"

        Dim price As Double
        price = Double.Parse(ComboBox1.Text).ToString("n2")

        Dim selected As Double
        selected = Double.Parse(InputBox("Enter How Many Persons", "Enter Data", 1, -1, -1))

        Dim total As Double
        total = Double.Parse(selected * price)
        SubTot += total

        table2.Rows.Add(id, item, price, selected, total)

        DataGridView1.DataSource = table2

        Dim tempSub As Double
        tempSub = SubTot
        TextBox1.Text = tempSub.ToString("n2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        table2.Rows.Clear()
        table2.Columns.Clear()
        SubTot = 0
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fdata As New CheckinSelector()
        fdata.MdiParent = Me.MdiParent
        fdata.Show()
        'CheckinSelector.ShowDialog()
    End Sub

    Private Sub Down_Click(sender As Object, e As EventArgs) Handles Down.Click
        'If DataGridView1.Rows.Count >= 1 Then
        'Dim i As Integer = DataGridView1.CurrentRow.Index + 1
        'If (i >= -1 And i < DataGridView1.Rows.Count) Then
        'DataGridView1.CurrentCell = DataGridView1.Rows(1).Cells(0)
        'End If
        'End If
    End Sub

    Private Sub Up_Click(sender As Object, e As EventArgs) Handles Up.Click
        'If DataGridView1.Rows.Count >= 1 Then
        'Dim i As Integer = DataGridView1.CurrentRow.Index - 1
        'If (i >= -1 And i < DataGridView1.Rows.Count) Then
        'taGridView1.CurrentCell = DataGridView1.Rows(1).Cells(0)
        'End If
        'End If
    End Sub
End Class