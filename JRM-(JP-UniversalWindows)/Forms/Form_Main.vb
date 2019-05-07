Imports MySql.Data.MySqlClient

Public Class Form_Main

    Public CO As Integer = 0 'checkout Form
    Public IM As Integer = 0 'Item Management
    Dim CLogin = New Form_Login()
    Dim ItemsWindow = New Form_Management_Item
    Dim CheckOutForm As New Form_CheckOut_GuestList()

    Private Sub first_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstReset()
        Me.WindowState = FormWindowState.Maximized
        Form_Login_Background.Hide()
        GuestWindow.MdiParent = Me
        'GuestWindow.Text = "Guest Management Form - " + Me.MdiChildren.Length.ToString()

        MMenu.mdiparent = Me

        'MMenu = New Form_Main_Menu()
        'MMenu.MdiParent = Me
        'MMenu.WindowState = FormWindowState.Minimized
        'MMenu.Show()

        'Dim CLogin = New Form_Login()
        'CLogin.MdiParent = Me
        'CLogin.Text = "Login Form - " + Me.MdiChildren.Length.ToString()
        'openLogin(Procced)

        '=============================================== For DATAGRID UserTable Find ==== Test: WORKING!! BWHAHA =================='
        ''Dim table As New DataTable()
        ''Dim adapter As New MySqlDataAdapter("SELECT * FROM tblusers WHERE UserType = 'Manager' OR  Usertype = 'Staff' OR UserType = 'Supervisor'", connection)
        ''adapter.Fill(table)
        ''DataGridView1.DataSource = table
        '==============================================='
    End Sub

    Public Sub firstreset()
        If UIDType = "Admin" Or UIDType = "Manager" Then
            Form_Management_Guest.Button1.Visible = False
        Else
            toolbarUsers.Visible = False
            toolbarItems.Visible = False
            toolbarLocations.Visible = False

            Tab_Main.TabPages.Remove(TabPage4)
            ''Tab_Main.TabPages.Remove(TabPage5)
        End If

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub first_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim message As String = "Do you want to Log-out?"
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
        Me.ToolStripStatusLabel3.Text = "Date and Time : " & datenow.ToString("MMMM dd, yyyy") & " " & TimeOfDay
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



    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles toolbarLogOUT.Click
        UIDType = "NONE"
        Procced = 0
        'MMenu.close()
        Form_Login_Background.Show()
        Form_Login_Confirm.Show()
        Me.Close()
    End Sub

    Private Sub ToolbarCheckIn_Click(sender As Object, e As EventArgs) Handles toolbarCheckIn.Click
        CheckOutForm.Close()
        Form_Checkin.ControlBox = False
        Form_Checkin.ShowIcon = False
        Form_Checkin.ShowDialog()
    End Sub

    Private Sub ToolbarCheckOut_Click(sender As Object, e As EventArgs) Handles toolbarCheckOut.Click
        If CO = 0 Then
            CheckOutForm = New Form_CheckOut_GuestList()
            CheckOutForm.MdiParent = Me
            CheckOutForm.ControlBox = False
            CheckOutForm.ShowIcon = False
            CheckOutForm.Show()
            CO = 1
        Else
            CheckOutForm.WindowState = FormWindowState.Maximized
            CheckOutForm.BringToFront()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles toolbarGuests.Click
        If GM = 0 Then
            GuestWindow = New Form_Management_Guest()
            GuestWindow.mdiparent = Me
            GuestWindow.text = "Guest Management Window [List]"
            GuestWindow.WindowState = FormWindowState.Maximized
            GuestWindow.controlbox = False
            GuestWindow.showicon = False
            GuestWindow.show
            GM = 1
        Else
            GuestWindow.WindowState = FormWindowState.Maximized
            GuestWindow.bringtofront()
        End If
    End Sub

    Private Sub ToolbarRoom_Click(sender As Object, e As EventArgs) Handles toolbarLocations.Click
        If SM = 0 Then
            ServicesFORM = New Form_Management_Venue()
            ServicesFORM.MdiParent = Me
            ServicesFORM.text = "Services Management Window [List]"
            ServicesFORM.WindowState = FormWindowState.Maximized
            ServicesFORM.Show()
            SM = 1
        Else
            ServicesFORM.WindowState = FormWindowState.Maximized
            ServicesFORM.bringtofront()
        End If
    End Sub

    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles toolbarItems.Click
        If IM = 0 Then
            ItemsWindow = New Form_Management_Item
            ItemsWindow.MdiParent = Me
            ItemsWindow.Text = "Item Management Window"
            ItemsWindow.WindowState = FormWindowState.Maximized
            ItemsWindow.Show()
            IM = 1
        Else
            ItemsWindow.WindowState = FormWindowState.Maximized
            ItemsWindow.bringtofront()
        End If
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles toolbarUsers.Click
        If UM = 0 Then
            UserWindow = New Form_Management_User()
            UserWindow.MdiParent = Me
            UserWindow.Text = "User Management Window [List]" +
            UserWindow.Show()
            UM = 1
        Else
            UserWindow.WindowState = FormWindowState.Maximized
            UserWindow.bringtofront()
        End If
    End Sub

    Private Sub ToolbarReserve_Click(sender As Object, e As EventArgs) Handles toolbarReserve.Click
        CheckOutForm.Close()
        Form_Reservation.ShowIcon = False
        Form_Reservation.ShowDialog()
    End Sub

    Private Sub Button_Guests_Update_Click(sender As Object, e As EventArgs) Handles Button_Guests_Update.Click

    End Sub
End Class