Imports MySql.Data.MySqlClient

Public Class Form_Login_Confirm

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        mysql = "select * from tblusers where username = '" & txtbox_Username.Text & "' and password = '" & txtbox_Password.Text & "'"

        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        Dim user As String = ""
        Dim pass As String = ""
        Dim Accountname As String = ""

        Do While dr.Read = True
            user = dr("username")
            pass = dr("password")
            UID = dr("userID")
            UIDType = dr("usertype")
            Accountname = dr("Fname") + " " + dr("Mname") + " " + dr("Lname")
        Loop

        If txtbox_Username.Text = user And txtbox_Password.Text = pass AndAlso UIDType = "Admin" Then
            cmd.Dispose()
            conn.Close()

            Me.Close()
            Form_CreateNew_User.ShowDialog()

        ElseIf txtbox_Username.Text = user And txtbox_Password.Text = pass AndAlso UIDType = "Manager" Then
            cmd.Dispose()
            conn.Close()

            Me.Close()
            Form_CreateNew_User.ShowDialog()

        Else

            MsgBox("Account User : " + Accountname + ", does not have the previlage, or does not exist!", vbCritical, "Exiting")
            cmd.Dispose()
            conn.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NewAcc = 0
        Me.Close()
    End Sub
End Class