Imports MySql.Data.MySqlClient

Public Class Form_Main_Menu
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")

    Private Sub btn_SManage_Click(sender As Object, e As EventArgs)
        Form_Management_Service.ShowDialog()
    End Sub


    Private Sub btn_UManage_Click(sender As Object, e As EventArgs)
        Form_Management_User.ShowDialog()
    End Sub



    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Refresh()

    End Sub

    Private Sub MainMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        UIDType = "NONE"
        Procced = 0
        openLogin(Procced)
        Me.Hide()

    End Sub

End Class