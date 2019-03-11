Imports MySql.Data.MySqlClient


Public Class CreateNewUser
    Private Sub btn_CreateAccount_Click(sender As Object, e As EventArgs) Handles btn_CreateAccount.Click
        If txtbox_Password.Text = txtbox_CPassword.Text Then
            mysql = "insert into tblusers (fname, mname, lname, gender, email, contactno, address, birthdate, usercreated, usertype, username, password)" &
                "values ('" & txtbox_Fname.Text & "','" & txtbox_Mname.Text & "','" & txtbox_Lname.Text & "','" & combox_Gender.Text & "' ,'" & txtbox_Email.Text & "','" & txtbox_Contact.Text & "','" & txtbox_Address.Text & "','" & Format$(PickDate.Value, "yyyy-MM-dd") & "','" & Format$(Date.Now, "yyyy-MM-dd hh:mm:ss") & "','" & combox_type.Text & "','" & txtbox_Username.Text & "','" & txtbox_Password.Text & "')"

            conndb()
            cmd = New MySqlCommand(mysql, conn)
            cmd.ExecuteNonQuery()

            cmd.Dispose()
            conn.Close()

            MsgBox("User information successfully saved", vbInformation, "Saved")

            ''viewusers(User.ListView1, "")
            Me.Close()
        Else
            MsgBox("Passwords do not match", vbCritical, "Error")
            txtbox_Password.Text = ""
            txtbox_CPassword.Text = ""
        End If
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub
End Class