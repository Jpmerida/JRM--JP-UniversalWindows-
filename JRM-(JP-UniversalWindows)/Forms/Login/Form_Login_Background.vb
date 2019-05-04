Public Class Form_Login_Background
    Private Sub Form_Login_Background_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form_Login_Confirm.ShowDialog()
        Form_Login_Confirm.BringToFront()
    End Sub
End Class