Imports MySql.Data.MySqlClient

Public Class UserManagement
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")
    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        viewusers(ListView1, "")
        txtbox_Address.Text = ""
        txtbox_Contact.Text = ""
        txtbox_CPassword.Text = ""
        txtbox_Email.Text = ""
        txtbox_Fname.Text = ""
        txtbox_Lname.Text = ""
        txtbox_Mname.Text = ""
        txtbox_Password.Text = ""
        txtbox_Username.Text = ""
        combox_Gender.Text = ""
        combox_type.Text = "Staff"
        cmdUpdate.Enabled = False
        If UIDType = "Admin" Or UIDType = "Manager" Then
            Button1.Enabled = True
            cmdUpdate.Enabled = True
        ElseIf UIDType = "NONE" Or UIDType = "Staff" Then
            Button1.Enabled = False
            cmdUpdate.Enabled = False
        Else
            Button1.Enabled = False
            cmdUpdate.Enabled = False
        End If
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        viewusers(ListView1, txtSearch.Text)

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Try
            UIDupdate = ListView1.SelectedItems(0).Text
        Catch ex As Exception
            Return
        End Try


        Dim search_command As New MySqlCommand("SELECT * FROM `tblusers` WHERE `UserID` = @id", connection)
        search_command.Parameters.Add("@id", MySqlDbType.Int64).Value = UIDupdate
        Dim adapter As New MySqlDataAdapter(search_command)
        Dim table As New DataTable()
        Try
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                UpdateUser.txtbox_Fname.Text = table(0)(1)
                UpdateUser.txtbox_Mname.Text = table(0)(2)
                UpdateUser.txtbox_Lname.Text = table(0)(3)
                UpdateUser.combox_Gender.Text = table(0)(4)
                UpdateUser.txtbox_Email.Text = table(0)(5)
                UpdateUser.txtbox_Contact.Text = table(0)(6)
                UpdateUser.txtbox_Address.Text = table(0)(7)
                UpdateUser.PickDate.Value = table(0)(9)
                UpdateUser.combox_type.Text = table(0)(10)
                UpdateUser.txtbox_Username.Text = table(0)(11)
                UpdateUser.txtbox_Password.Text = table(0)(12)
            Else
                MessageBox.Show("No Data Found")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        UpdateUser.txtbox_CPassword.Text = ""
        UpdateUser.ShowDialog()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        UM = 0
        Me.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateNewUser.ShowDialog()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If UIDType = "Admin" Or UIDType = "Manager" Then
            cmdUpdate.Enabled = True
        ElseIf UIDType = "NONE" Or UIDType = "Staff" Then
            cmdUpdate.Enabled = False
        Else
            cmdUpdate.Enabled = False
        End If

        If (Me.ListView1.SelectedItems.Count = 0) Then
            Return
        End If

        UIDupdate = ListView1.SelectedItems(0).Text

        Dim search_command As New MySqlCommand("SELECT * FROM `tblusers` WHERE `UserID` = @id", connection)
        search_command.Parameters.Add("@id", MySqlDbType.Int64).Value = UIDupdate
        Dim adapter As New MySqlDataAdapter(search_command)
        Dim table As New DataTable()
        Try
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                txtbox_Fname.Text = table(0)(1)
                txtbox_Mname.Text = table(0)(2)
                txtbox_Lname.Text = table(0)(3)
                combox_Gender.Text = table(0)(4)
                txtbox_Email.Text = table(0)(5)
                txtbox_Contact.Text = table(0)(6)
                txtbox_Address.Text = table(0)(7)
                PickDate.Value = table(0)(9)
                combox_type.Text = table(0)(10)
                txtbox_Username.Text = table(0)(11)
                txtbox_Password.Text = table(0)(12)
            Else
                MessageBox.Show("No Data Found")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Txtbox_Contact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_Contact.KeyPress
        OnlyNumbers(e)
    End Sub
    Private Sub Txtbox_Lname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_Lname.KeyPress
        OnlyLetters(e)
    End Sub
    Private Sub Txtbox_Fname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_Fname.KeyPress
        OnlyLetters(e)
    End Sub
    Private Sub Txtbox_Mname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_Mname.KeyPress
        OnlyLetters(e)
    End Sub
    Private Sub Combox_Gender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles combox_Gender.KeyPress
        OnlyLetters(e)
    End Sub

End Class