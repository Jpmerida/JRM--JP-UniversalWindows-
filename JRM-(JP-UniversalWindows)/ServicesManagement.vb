Public Class ServicesManagement
    Private Sub RoomManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewLocation(ListView1, "")
    End Sub

    Private Sub btn_AddNew_Click(sender As Object, e As EventArgs) Handles btn_AddNew.Click
        New_Services.ShowDialog()

    End Sub
End Class