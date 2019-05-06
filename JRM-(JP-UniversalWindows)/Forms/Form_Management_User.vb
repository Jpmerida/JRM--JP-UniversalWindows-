Imports MySql.Data.MySqlClient

Public Class Form_Management_User
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")
    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        viewusers(ListView1, "")
        txtbox_Address.Text = ""
        txtbox_Contact.Text = ""
        txtbox_Email.Text = ""
        txtbox_Fname.Text = ""
        txtbox_Lname.Text = ""
        txtbox_Mname.Text = ""
        combox_Gender.Text = ""
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        viewusers(ListView1, txtSearch.Text)

    End Sub


    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        UIDupdate = 0
        UM = 0
        Me.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
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

    Private Sub Form_Management_User_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        UM = 0
    End Sub

    Private Sub Button_Users_Create_Click(sender As Object, e As EventArgs) Handles Button_Users_Create.Click
        If UIDType = "Admin" Or UIDType = "Manager" Then
            Form_CreateNew_User.ShowDialog()
        Else
            MsgBox("User is not authorized to create a new account. Please Login with authorized credentials.", vbCritical, "Error")
        End If
    End Sub

    Private Sub Button_Users_Update_Click(sender As Object, e As EventArgs) Handles Button_Users_Update.Click

        If UIDType = "Admin" Or UIDType = "Manager" Then
            If UIDupdate = 0 Then
                Return
            Else
                Dim search_command As New MySqlCommand("SELECT * FROM `tblusers` WHERE `UserID` = @id", connection)
                search_command.Parameters.Add("@id", MySqlDbType.Int64).Value = UIDupdate
                Dim adapter As New MySqlDataAdapter(search_command)
                Dim table As New DataTable()
                Try
                    adapter.Fill(table)
                    If table.Rows.Count > 0 Then
                        Form_Update_User.txtbox_Fname.Text = table(0)(1)
                        Form_Update_User.txtbox_Mname.Text = table(0)(2)
                        Form_Update_User.txtbox_Lname.Text = table(0)(3)
                        Form_Update_User.combox_Gender.Text = table(0)(4)
                        Form_Update_User.txtbox_Email.Text = table(0)(5)
                        Form_Update_User.txtbox_Contact.Text = table(0)(6)
                        Form_Update_User.txtbox_Address.Text = table(0)(7)
                        Form_Update_User.PickDate.Value = table(0)(9)
                        Form_Update_User.combox_type.Text = table(0)(10)
                        Form_Update_User.txtbox_Username.Text = table(0)(11)
                        Form_Update_User.txtbox_Password.Text = table(0)(12)
                    Else
                        MessageBox.Show("No Data Found")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

                Form_Update_User.txtbox_CPassword.Text = ""
                Form_Update_User.ShowDialog()
            End If

        Else
            MsgBox("User is not authorized to create a new account! Please Login with authorized credentials.", vbCritical, "Error")
        End If
    End Sub
End Class