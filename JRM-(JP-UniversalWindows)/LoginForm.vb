Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        mysql = "select * from tblusers where username = '" & txtbox_Username.Text & "' and password = '" & txtbox_Password.Text & "'"

        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        Dim user As String = ""
        Dim pass As String = ""

        Do While dr.Read = True
            user = dr("username")
            pass = dr("password")
            UID = dr("userID")
        Loop

        If txtbox_Username.Text = user And txtbox_Password.Text = pass Then
            cmd.Dispose()
            conn.Close()
            Me.Hide()
            MainMenu.ShowDialog()

        Else
            MsgBox("Wrong username or password", vbCritical, "Error Login")
            cmd.Dispose()
            conn.Close()
        End If
    End Sub

    Private Sub txtLink_CreateUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtLink_CreateUser.LinkClicked
        CreateNewUser.Show()
    End Sub
End Class