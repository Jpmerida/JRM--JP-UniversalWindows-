Imports MySql.Data.MySqlClient
Public Class Form_Login
    Private Sub txtLink_CreateUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Form_CreateNew_User.Show()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        txtbox_Username.Text = ""
        txtbox_Password.Text = ""
    End Sub

    Private Sub btn_Login_Click_1(sender As Object, e As EventArgs) Handles btn_Login.Click
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

            Me.Hide()

            MMenu = New Form_Main_Menu()
            MMenu.MdiParent = Me.MdiParent
            MMenu.WindowState = FormWindowState.Maximized
            ''MMenu.Dock = DockStyle.Fill
            MMenu.Show()

            Form_Main.Button_Logout.Visible = True

            txtbox_Username.Text = ""
            txtbox_Password.Text = ""
            Procced = 1
            Me.Close()
        Else
            MsgBox("Wrong username or password", vbCritical, "Error Login")
            cmd.Dispose()
            conn.Close()
            txtbox_Username.Text = ""
            txtbox_Password.Text = ""
        End If
    End Sub

End Class