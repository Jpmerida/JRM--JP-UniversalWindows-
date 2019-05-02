Imports MySql.Data.MySqlClient

Public Class Form_Main


    Dim CLogin = New Form_Login()
    Public IM As Integer 'Item Management
    Private Sub first_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Button_Logout.Visible = False
        GroupBox10.Visible = False

        GuestWindow.MdiParent = Me
        GuestWindow.Text = "Guest Management Form - " + Me.MdiChildren.Length.ToString()
        MMenu.mdiparent = Me

        Dim CLogin = New Form_Login()
        CLogin.MdiParent = Me
        CLogin.Text = "Login Form - " + Me.MdiChildren.Length.ToString()
        openLogin(Procced)

        '=============================================== For DATAGRID UserTable Find ==== Test: WORKING!! BWHAHA =================='
        ''Dim table As New DataTable()
        ''Dim adapter As New MySqlDataAdapter("SELECT * FROM tblusers WHERE UserType = 'Manager' OR  Usertype = 'Staff' OR UserType = 'Supervisor'", connection)
        ''adapter.Fill(table)
        ''DataGridView1.DataSource = table
        '==============================================='
    End Sub



    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub first_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim message As String = "Do you want to exit the application?"
        Dim caption As String = "JRM - Management System"
        Dim icons As Integer = MessageBoxIcon.Question
        Dim buttons As Integer = MessageBoxButtons.YesNo
        Dim result As DialogResult
        result = MessageBox.Show(Me, message, caption, buttons, icons)

        If result = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim datenow As Date = Now
        StatusStrip1.Items(4).Text = "Date and Time : " & datenow.ToString("MMMM dd, yyyy") & " " & TimeOfDay
    End Sub

    Private Sub ExitConfirmation_Click(sender As Object, e As EventArgs) Handles ExitConfirmation.Click
        Me.Close()
    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        openLogin(Procced)
        CLogin.bringtofront()
    End Sub

    Private Sub Button_Logout_Click(sender As Object, e As EventArgs) Handles Button_Logout.Click
        UIDType = "NONE"
        Procced = 0
        MMenu.close()
        Button_Logout.Visible = False
        GroupBox10.Visible = False
        Button_Login.Visible = True
    End Sub

    Private Sub Button_Users_Click(sender As Object, e As EventArgs) Handles Button_Users.Click
        If UM = 0 Then
            UserWindow = New Form_Management_User()
            UserWindow.MdiParent = Me
            UserWindow.Text = "User Management Form - " + Me.MdiChildren.Length.ToString()
            UserWindow.Show()
            UM = 1
        Else
            UserWindow.bringtofront()
        End If
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

    Private Sub Button_Guests_Click(sender As Object, e As EventArgs) Handles Button_Guests.Click
        If GM = 0 Then
            GuestWindow = New Form_Management_Guest()
            GuestWindow.mdiparent = Me
            GuestWindow.WindowState = FormWindowState.Maximized
            ''GuestWindow.Dock = DockStyle.Right
            GuestWindow.show
            GM = 1
        Else
            GuestWindow.bringtofront()
        End If
    End Sub

    Private Sub Button_Guests_Update_Click(sender As Object, e As EventArgs) Handles Button_Guests_Update.Click
        GuestWindow.cmdupdatesub(UIDType)
    End Sub

    Private Sub Button_Guests_Create_Click(sender As Object, e As EventArgs) Handles Button_Guests_Create.Click
        Form_CreateNew_Guest.ShowDialog()
    End Sub

    Private Sub Button_Services_Click(sender As Object, e As EventArgs) Handles Button_Services.Click
        If SM = 0 Then
            ServicesFORM = New Form_Management_Venue()
            ServicesFORM.MdiParent = Me
            ServicesFORM.WindowState = FormWindowState.Maximized
            ''ServicesFORM.Dock = DockStyle.Right
            ServicesFORM.Show()
            SM = 1
        Else
            ServicesFORM.bringtofront()
        End If
    End Sub

    Private Sub Button_Services_Create_Click(sender As Object, e As EventArgs) Handles Button_Services_Create.Click
        If UIDType = "Admin" Or UIDType = "Manager" Then
            Form_CreateNew_Services.Button_Update.Visible = False
            Form_CreateNew_Services.ShowDialog()
        Else
            MsgBox("User is not authorized to create a new account! Please Login with authorized credentials.", vbCritical, "Error")
        End If

    End Sub
    Private Sub Button_Services_Update_Click(sender As Object, e As EventArgs) Handles Button_Services_Update.Click
        If UIDType = "Admin" Or UIDType = "Manager" Then
            Form_CreateNew_Services.BTN_INSERT.Visible = False
            Form_CreateNew_Services.ShowDialog()
        Else
            MsgBox("User is not authorized to create a new account! Please Login with authorized credentials.", vbCritical, "Error")
        End If
    End Sub

    Private Sub Button_Main_Checkin_Click(sender As Object, e As EventArgs) Handles Button_Main_Checkin.Click
        Form_Checkin.ShowDialog()
    End Sub

    Private Sub Button_Main_Exit_Click(sender As Object, e As EventArgs) Handles Button_Main_Exit.Click
        Me.Close()
    End Sub

    Private Sub Button_Items_Click(sender As Object, e As EventArgs) Handles Button_Items.Click

        If IM = 0 Then
            Dim ItemsWindow = New Form_Management_Item
            ItemsWindow.MdiParent = Me
            ItemsWindow.Show()
            IM = 1
        Else
            UserWindow.bringtofront()
        End If
    End Sub

    Private Sub Button_Items_Create_Click(sender As Object, e As EventArgs) Handles Button_Items_Create.Click
        Form_CreateNew_Item.ShowDialog()
    End Sub
End Class