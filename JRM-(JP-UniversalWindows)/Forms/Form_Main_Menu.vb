Imports MySql.Data.MySqlClient

Public Class Form_Main_Menu
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")

    Private Sub MainMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        UIDType = "NONE"
        Procced = 0
        'openLogin(Procced)
        Me.Hide()

    End Sub

End Class