Imports MySql.Data.MySqlClient
Public Class Form_Checkin_Guest
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")

    ''Public GIDupdate As Integer

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

    Private Sub CheckinGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewguests(ListView1, "")
        CheckGuestID = 0 'wildcard/ random strangers no need for more info

        txtSearch.Text = ""
        txtFname.Text = ""
        txtMname.Text = ""
        txtLname.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        txtContact.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        CheckGuestID = ListView1.SelectedItems(0).SubItems(0).Text


        mysql = "select * from tblguestdetails where GuestID ='" & CheckGuestID & "'"
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        dr.Read()
        txtFname.Text = dr("Fname")
        txtMname.Text = dr("Mname")
        txtLname.Text = dr("Lname")
        ComboBox1.Text = dr("Gender")
        cmd.Dispose()
        conn.Close()

        mysql = "select * from tblguests where GuestID ='" & CheckGuestID & "'"
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        dr.Read()
        txtGroupName.Text = dr("Name")
        cmd.Dispose()
        conn.Close()

        txtEmail.Text = ListView1.SelectedItems(0).SubItems(2).Text
        txtContact.Text = ListView1.SelectedItems(0).SubItems(3).Text
        txtAddress.Text = ListView1.SelectedItems(0).SubItems(4).Text
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        viewguests(ListView1, txtSearch.Text)
    End Sub

    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        Form_CreateNew_Guest.ShowDialog()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs)
        viewguests(ListView1, "")
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        CheckGuestID = ListView1.SelectedItems(0).SubItems(0).Text

        mysql = "select * from tblguestdetails where GuestID ='" & CheckGuestID & "'"
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        dr.Read()
        txtFname.Text = dr("Fname")
        txtMname.Text = dr("Mname")
        txtLname.Text = dr("Lname")
        ComboBox1.Text = dr("Gender")
        cmd.Dispose()
        conn.Close()

        mysql = "select * from tblguests where GuestID ='" & CheckGuestID & "'"
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        dr.Read()
        txtGroupName.Text = dr("Name")
        cmd.Dispose()
        conn.Close()

        txtEmail.Text = ListView1.SelectedItems(0).SubItems(2).Text
        txtContact.Text = ListView1.SelectedItems(0).SubItems(3).Text
        txtAddress.Text = ListView1.SelectedItems(0).SubItems(4).Text
    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click
        CheckGuestID = ListView1.SelectedItems(0).SubItems(0).Text
        Form_Checkin.txtGuest.Text = txtGroupName.Text
        ''Form_Checkin.txtName.Text = txtGroupName.Text
        ItsOKAY = 1
        CG = 0
        Me.Close()
    End Sub

    Private Sub CheckinGuest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CG = 0
    End Sub

    Private Sub TxtFname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMname.KeyPress, txtLname.KeyPress, txtFname.KeyPress, ComboBox1.KeyPress
        OnlyLetters(e)
    End Sub

    Private Sub TxtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        OnlyNumbers(e)
    End Sub
End Class