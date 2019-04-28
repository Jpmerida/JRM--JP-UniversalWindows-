Imports MySql.Data.MySqlClient

Public Class ServicesManagement
    Public VUIupdate As Integer
    Function execCommand(ByVal cmd As MySqlCommand) As Boolean

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Try
            If cmd.ExecuteNonQuery() = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR")
            Return False
        End Try
        If connection.State = ConnectionState.Open Then
            connection.Dispose()
            connection.Close()
        End If
    End Function

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")

    Private Sub RoomManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VUIupdate = 0
        viewVenue(ListView1, "")
        'txtCatID.Text = ""
        txtCatType.Text = ""
        txtPrice.Text = ""
        txtDesc.Text = ""
        txtName.Text = ""
        txtOperable.Text = ""
        btnUpdate.Enabled = False
        If UIDType = "Admin" Or UIDType = "Manager" Then
            btn_AddNew.Enabled = True
        ElseIf UIDType = "NONE" Or UIDType = "Staff" Then
            btn_AddNew.Enabled = False
        Else
            btn_AddNew.Enabled = False
        End If
    End Sub

    Private Sub btn_AddNew_Click(sender As Object, e As EventArgs) Handles btn_AddNew.Click
        CreateNewServices.ShowDialog()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btn_Categories_Click(sender As Object, e As EventArgs) Handles btn_Categories.Click
        ServiceCategories.ShowDialog()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        VUIupdate = ListView1.SelectedItems(0).SubItems(0).Text

        If VUIupdate = 0 Then
            btnUpdate.Enabled = False
        Else
            If UIDType = "Admin" Or UIDType = "Manager" Then
                btnUpdate.Enabled = True
            ElseIf UIDType = "NONE" Or UIDType = "Staff" Then
                btnUpdate.Enabled = False
            Else
                btnUpdate.Enabled = False
            End If
        End If
        Dim test1 As Double
        mysql = "select * from tblVenue where VenueID ='" & VUIupdate & "'"
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        dr.Read()
        'txtCatID.Text = dr("CategoryID")
        txtName.Text = dr("Name")
        test1 = dr("Price")
        txtOperable.Text = dr("Status")
        cmd.Dispose()
        conn.Close()

        txtPrice.Text = test1.ToString("n2")
        mysql = "select * from tblVenuetype where CategoryID ='" & ListView1.SelectedItems(0).SubItems(1).Text & "'"
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        dr.Read()
        txtCatType.Text = dr("CatType")
        txtDesc.Text = dr("CatDescription")
        cmd.Dispose()
        conn.Close()
    End Sub


End Class