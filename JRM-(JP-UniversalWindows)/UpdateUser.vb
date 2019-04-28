Imports MySql.Data.MySqlClient

Public Class UpdateUser
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")
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
            connection.Close()
        End If

    End Function

    Private Sub btn_UpdateAccount_Click(sender As Object, e As EventArgs) Handles btn_UpdateAccount.Click
        If txtbox_Password.Text = txtbox_CPassword.Text Then

            Dim update_command As New MySqlCommand("UPDATE `tblusers` SET `fname`=@fn,`mname`=@mn,`lname`=@ln,`gender`=@g,`email`=@e,`contactno`=@c,`address`=@add,`birthdate`=@b,`usertype`=@ut,`username`=@u,`password`=@p WHERE `userid` = @id", connection)

            update_command.Parameters.Add("@id", MySqlDbType.Int64).Value = UIDupdate
            update_command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = txtbox_Fname.Text
            update_command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = txtbox_Mname.Text
            update_command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = txtbox_Lname.Text
            update_command.Parameters.Add("@g", MySqlDbType.VarChar).Value = combox_Gender.Text

            update_command.Parameters.Add("@e", MySqlDbType.VarChar).Value = txtbox_Email.Text
            update_command.Parameters.Add("@c", MySqlDbType.VarChar).Value = txtbox_Contact.Text
            update_command.Parameters.Add("@add", MySqlDbType.VarChar).Value = txtbox_Address.Text

            update_command.Parameters.Add("@b", MySqlDbType.Date).Value = PickDate.Value
            update_command.Parameters.Add("@ut", MySqlDbType.VarChar).Value = combox_type.Text
            update_command.Parameters.Add("@u", MySqlDbType.VarChar).Value = txtbox_Username.Text
            update_command.Parameters.Add("@p", MySqlDbType.VarChar).Value = txtbox_Password.Text
            '---'
            If execCommand(update_command) Then
                MsgBox("User: " & txtbox_Fname.Text & " has been successfully updated", vbInformation, "Updated")
                viewusers(UserManagement.ListView1, "")
            Else
                MessageBox.Show("Data NOT Updated")
                txtbox_Password.Text = ""
                txtbox_CPassword.Text = ""
                Exit Sub
            End If

            Me.Close()
        Else
            MsgBox("Passwords do not match", vbInformation, "Mismatch")
            txtbox_Password.Text = ""
            txtbox_CPassword.Text = ""
        End If
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

End Class