Imports MySql.Data.MySqlClient

Public Class first


    Dim CLogin = New LoginForm()

    Private Sub first_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StatusStrip1.Visible = False
        Me.WindowState = FormWindowState.Maximized



        GuestWindow.MdiParent = Me
        GuestWindow.Text = "Guest Management Form - " + Me.MdiChildren.Length.ToString()
        MMenu.mdiparent = Me

        Dim CLogin = New LoginForm()
        CLogin.MdiParent = Me
        CLogin.Text = "Login Form - " + Me.MdiChildren.Length.ToString()


        If UIDType = "Admin" Or UIDType = "Manager" Then
            ToolStripMenuUM.Enabled = True
            ToolStripMenuUM.Visible = True
        ElseIf UIDType = "NONE" Or UIDType = "Staff" Then
            ToolStripMenuUM.Enabled = False
            ToolStripMenuUM.Visible = False
        Else
            ToolStripMenuUM.Enabled = False
            ToolStripMenuUM.Visible = False
        End If


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

    Private Sub CreateNewGuesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If NewAcc = 0 Then
            CLogin.Close()
            Dim f = New LoginConfirm()
            f.MdiParent = Me
            f.Show()
            NewAcc = 1
        End If

    End Sub

    Private Sub LOGINToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LOGINToolStripMenuItem1.Click
        If Procced = 0 Then
            CLogin.Show()
            Procced = 1
        End If
    End Sub

    Private Sub ManagementWindowToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If UM = 0 Then
            Dim UserWindow = New UserManagement()
            UserWindow.MdiParent = Me
            UserWindow.Text = "User Management Form - " + Me.MdiChildren.Length.ToString()
            UserWindow.Show()
            UM = 1
        End If
    End Sub




    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
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

    Private Sub GuestManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuestManagementToolStripMenuItem.Click
        'openGWindow(GM)
        If GM = 0 Then
            GuestWindow = New GuestsManagement()
            GuestWindow.mdiparent = Me
            GuestWindow.Dock = DockStyle.Right
            GuestWindow.show
            GM = 1
        End If
    End Sub

    Private Sub ToolStripMenuUM_Click(sender As Object, e As EventArgs) Handles ToolStripMenuUM.Click
        If UM = 0 Then
            UserWindow = New UserManagement()
            UserWindow.MdiParent = Me
            UserWindow.Text = "User Management Form - " + Me.MdiChildren.Length.ToString()
            UserWindow.Show()
            UM = 1
        End If
    End Sub

    Private Sub ServicesManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServicesManagementToolStripMenuItem.Click
        If SM = 0 Then
            ServicesFORM = New VenueManagementForm()
            ServicesFORM.MdiParent = Me
            ServicesFORM.Dock = DockStyle.Right
            ServicesFORM.Show()
            SM = 1
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim datenow As Date = Now
        StatusStrip1.Items(3).Text = "Date and Time : " & datenow.ToString("MMMM dd, yyyy") & " " & TimeOfDay
    End Sub
End Class