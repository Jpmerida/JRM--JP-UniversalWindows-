Imports MySql.Data.MySqlClient
Public Class LoginForm
    Private Sub txtLink_CreateUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        CreateNewUser.Show()
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

        Do While dr.Read = True
            user = dr("username")
            pass = dr("password")
            UID = dr("userID")
            UIDType = dr("usertype")
        Loop
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

            Dim MMenu = New MainMenu()
            MMenu.MdiParent = Me.MdiParent
            MMenu.windowstate = FormWindowState.Normal
            'MMenu.LayoutMdi(MdiLayout.TileHorizontal)
            MMenu.dock = DockStyle.Fill
            MMenu.Show()

            first.StatusStrip1.Visible = True

            txtbox_Username.Text = ""
            txtbox_Password.Text = ""
            If UIDType = "Admin" Or UIDType = "Manager" Then
                first.ToolStripMenuUM.Enabled = True
                first.ToolStripMenuUM.Visible = True
            Else
                first.ToolStripMenuUM.Enabled = False
                first.ToolStripMenuUM.Visible = False
            End If
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