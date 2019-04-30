Imports MySql.Data.MySqlClient


Public Class Form_CreateNew_User
    Private Sub btn_CreateAccount_Click(sender As Object, e As EventArgs) Handles btn_CreateAccount.Click
        If (combox_type.Text = "Staff" Or combox_type.Text = "Supervisor" Or combox_type.Text = "Manager" Or combox_type.Text = "Administrator") Then
            If txtbox_Username.Text.Length < 8 Or txtbox_Username.Text.Length > 15 Then
                MessageBox.Show(txtbox_Username.Text + " must be 8-15 characters.", "ERROR")
                txtbox_Username.Text = ""
            Else
                If txtbox_Password.Text.Length < 8 Or txtbox_Password.Text.Length > 15 Then
                    txtbox_Password.Text = ""
                    txtbox_CPassword.Text = ""
                    MessageBox.Show("Password must be 8-15 characters.", "ERROR")
                Else
                    ''MessageBox.Show(txtbox_Password.Text + " IS 8-15 characters.", "Accepted")
                    If txtbox_Password.Text = txtbox_CPassword.Text Then
                        Dim test2 As String = ""

                        Dim search_command As New MySqlCommand("SELECT * FROM `tblusers` WHERE `username` = @id", connection)
                        search_command.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtbox_Username.Text
                        Dim adapter As New MySqlDataAdapter(search_command)
                        Dim table As New DataTable()
                        Try
                            adapter.Fill(table)
                            If table.Rows.Count > 0 Then
                                test2 = table(0)(11)
                                MessageBox.Show(txtbox_Username.Text + " Exists")
                            Else
                                ''MessageBox.Show(txtbox_Username.Text + " Does not Exists")
                                mysql = "insert into tblusers (fname, mname, lname, gender, email, contactno, address, birthdate, usercreated, usertype, username, password)" &
                                "values ('" & txtbox_Fname.Text & "','" & txtbox_Mname.Text & "','" & txtbox_Lname.Text & "','" & combox_Gender.Text & "' ,'" & txtbox_Email.Text & "','" & txtbox_Contact.Text & "','" & txtbox_Address.Text & "','" & Format$(PickDate.Value, "yyyy-MM-dd") & "','" & Format$(Date.Now, "yyyy-MM-dd hh:mm:ss") & "','" & combox_type.Text & "','" & txtbox_Username.Text & "','" & txtbox_Password.Text & "') "

                                cmd = New MySqlCommand(mysql, conn)
                                cmd.ExecuteNonQuery()
                                cmd.Dispose()
                                conn.Close()
                                MsgBox("User information successfully saved", vbInformation, "Saved")
                                viewusers(Form_Management_User.ListView1, "")
                                Me.Close()
                            End If
                        Catch ex As Exception
                            MessageBox.Show("ERROR")
                        End Try
                    Else
                        MsgBox("Passwords do not match", vbCritical, "Error")
                        txtbox_Password.Text = ""
                        txtbox_CPassword.Text = ""
                    End If

                End If
                ''MessageBox.Show(txtbox_Username.Text + " IS 8-15 characters.", "Accepted")
            End If
        Else
            MessageBox.Show("Try Again.", "ERROR")
            combox_type.Text = "Staff"
        End If


    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub CreateNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        If UIDType = "Admin" Then
            combox_type.Enabled = True
        ElseIf UIDType = "NONE" Or UIDType = "Staff" Or UIDType = "Manager" Then
            combox_type.Enabled = False
        Else
            combox_type.Enabled = False
        End If

    End Sub
End Class