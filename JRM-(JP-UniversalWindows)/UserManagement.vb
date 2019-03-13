Public Class UserManagement
    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewusers(ListView1, "")
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        viewusers(ListView1, txtSearch.Text)
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        UIDupdate = ListView1.SelectedItems(0).Text
        UpdateUser.txtbox_Fname.Text = ListView1.SelectedItems(0).SubItems(1).Text
        UpdateUser.txtbox_Mname.Text = ListView1.SelectedItems(0).SubItems(2).Text
        UpdateUser.txtbox_Lname.Text = ListView1.SelectedItems(0).SubItems(3).Text
        UpdateUser.combox_Gender.Text = ListView1.SelectedItems(0).SubItems(4).Text
        UpdateUser.txtbox_Email.Text = ListView1.SelectedItems(0).SubItems(5).Text
        UpdateUser.txtbox_Contact.Text = ListView1.SelectedItems(0).SubItems(6).Text
        UpdateUser.txtbox_Address.Text = ListView1.SelectedItems(0).SubItems(7).Text
        UpdateUser.PickDate.Value = ListView1.SelectedItems(0).SubItems(9).Text
        UpdateUser.combox_type.Text = ListView1.SelectedItems(0).SubItems(10).Text
        UpdateUser.txtbox_Username.Text = ListView1.SelectedItems(0).SubItems(11).Text
        UpdateUser.txtbox_Password.Text = ListView1.SelectedItems(0).SubItems(12).Text
        UpdateUser.txtbox_CPassword.Text = ""
        UpdateUser.ShowDialog()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class