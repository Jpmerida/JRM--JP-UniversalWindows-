Imports MySql.Data.MySqlClient

Public Class MainMenu
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")

    Private Sub btn_SManage_Click(sender As Object, e As EventArgs)
        ServicesManagement.ShowDialog()
    End Sub


    Private Sub btn_UManage_Click(sender As Object, e As EventArgs)
        UserManagement.ShowDialog()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        UIDType = "NONE"
        Procced = 0
        openLogin(Procced)
        first.StatusStrip1.Visible = False
        first.ToolStripMenuUM.Enabled = False
        first.ToolStripMenuUM.Visible = False
        Me.Hide()

    End Sub

    Private Sub btn_Checkin_Click(sender As Object, e As EventArgs) Handles btn_Checkin.Click
        CInForm = New CheckinForm()
        CInForm.MdiParent = Me.MdiParent
        CInForm.show()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        Me.Refresh()
        '====== for tooltip =====' (not really needed)
        Dim search_command As New MySqlCommand("SELECT * FROM `tblusers` WHERE `UserID` = @id", connection)
        search_command.Parameters.Add("@id", MySqlDbType.Int64).Value = UID
        Dim adapter As New MySqlDataAdapter(search_command)
        Try
            adapter.Fill(USERID_table)
            If USERID_table.Rows.Count > 0 Then
                first.ToolStripStatusLabel2.Text = USERID_table(0)(1)
            Else
                MessageBox.Show("No Data Found")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        '====== END for tooltip =====' (not really needed)
    End Sub

    Private Sub MainMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        UIDType = "NONE"
        Procced = 0
        openLogin(Procced)
        first.StatusStrip1.Visible = False
        first.ToolStripMenuUM.Enabled = False
        first.ToolStripMenuUM.Visible = False
        Me.Hide()

    End Sub

End Class