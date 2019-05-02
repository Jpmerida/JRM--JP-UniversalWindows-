Imports MySql.Data.MySqlClient

Public Class Form_Login_Confirm

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        mysql = "select * from tblusers where username = '" & txtbox_Username.Text & "' and password = '" & txtbox_Password.Text & "'"

        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        Dim user As String = ""
        Dim pass As String = ""
        Dim f1st As String = ""
        Dim l3rd As String = ""
        Dim helloname As String

        Do While dr.Read = True
            f1st = dr("fname")
            l3rd = dr("lname")
            user = dr("username")
            pass = dr("password")
            UID = dr("userID")
            UIDType = dr("usertype")
        Loop
        helloname = f1st + " " + l3rd
        Form_Main.ToolStripStatusLabel2.Text = helloname
        If txtbox_Username.Text = "" And txtbox_Password.Text = "" Then
            MsgBox("Wrong username or password", vbCritical, "Error Login")
            cmd.Dispose()
            conn.Close()
            txtbox_Username.Text = ""
            txtbox_Password.Text = ""
        ElseIf txtbox_Username.Text = user And txtbox_Password.Text = pass Then
            cmd.Dispose()
            conn.Close()

            Form_Main.GroupBox10.Visible = True
            Form_Main.Button_Login.Visible = False
            Form_Main.Button_Logout.Visible = True

            Dim datenow As Date = Now
            Form_Main.ToolStripStatusLabel2.Text = "Date and Time : " & datenow.ToString("MMMM dd, yyyy") & " " & TimeOfDay



            txtbox_Username.Text = ""
            txtbox_Password.Text = ""
            Procced = 1
            Me.Hide()
            Form_Main.ShowDialog()
        Else
            MsgBox("Wrong username or password", vbCritical, "Error Login")
            cmd.Dispose()
            conn.Close()
            txtbox_Username.Text = ""
            txtbox_Password.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NewAcc = 0
        Me.Close()
    End Sub

End Class