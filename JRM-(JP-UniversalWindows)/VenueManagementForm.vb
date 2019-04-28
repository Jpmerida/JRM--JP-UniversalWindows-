Imports MySql.Data.MySqlClient
Imports System.IO

Public Class VenueManagementForm

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")
    Private Sub CheckinVenueForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        SM = 0
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        SM = 0
        Me.Close()
    End Sub

    Private Sub CheckinVenueForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UIDType = "Admin" Or UIDType = "Manager" Then
            BTN_INSERT.Enabled = True
            BTN_INSERT.Visible = True
            btn_categories.Enabled = True
            btn_categories.Visible = True
        Else
            BTN_INSERT.Enabled = False
            BTN_INSERT.Visible = False
            btn_categories.Enabled = False
            btn_categories.Visible = False

        End If
        populateDatagridview(DataGridView1, "")

    End Sub

    Private Sub BTN_INSERT_Click(sender As Object, e As EventArgs) Handles BTN_INSERT.Click

        If nf = 0 Then
            ADDServicesForm = New FORM_AddNewServices()
            ADDServicesForm.MdiParent = Me.MdiParent
            ADDServicesForm.Show()
            nf = 1
        End If
        ''----------------
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
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        populateDatagridview(DataGridView1, TextBox1.Text)
    End Sub

    Private Sub Btn_categories_Click(sender As Object, e As EventArgs) Handles btn_categories.Click
        If SC = 0 Then
            CategoryForm = New ServiceCategories()
            CategoryForm.mdiparent = Me.MdiParent
            CategoryForm.show
            SC = 1
        End If

    End Sub
End Class