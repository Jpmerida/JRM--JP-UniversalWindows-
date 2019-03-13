Public Class MainMenu
    Private Sub btn_SManage_Click(sender As Object, e As EventArgs) Handles btn_SManage.Click
        ServicesManagement.ShowDialog()
    End Sub

    Private Sub btn_GManage_Click(sender As Object, e As EventArgs) Handles btn_GManage.Click
        GuestsManagement.ShowDialog()
    End Sub

    Private Sub btn_UManage_Click(sender As Object, e As EventArgs) Handles btn_UManage.Click
        UserManagement.ShowDialog()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub
End Class