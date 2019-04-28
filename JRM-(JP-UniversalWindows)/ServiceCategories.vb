﻿Public Class ServiceCategories
    Private Sub ServiceCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewCategories(ListView1, "")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        viewCategories(ListView1, txtSearch.Text)
    End Sub


    Private Sub btn_AddNew_Click_1(sender As Object, e As EventArgs) Handles btn_AddNew.Click
        If SC2 = 0 Then
            NewCategoryFORM = New CreateNewCategoryType()
            NewCategoryFORM.mdiparent = Me.MdiParent
            NewCategoryFORM.show
            SC2 = 1
        End If
    End Sub


    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        UsableID = ListView1.SelectedItems(0).Text

        UpdateCategoryType.txtCatType.Text = ListView1.SelectedItems(0).SubItems(1).Text
        UpdateCategoryType.txtCatDesc.Text = ListView1.SelectedItems(0).SubItems(2).Text
        UpdateCategoryType.txtCatNum.Text = ListView1.SelectedItems(0).SubItems(3).Text
        UpdateCategoryType.ComboBox1.Text = ListView1.SelectedItems(0).SubItems(4).Text

        UpdateCategoryType.ShowDialog()

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        SC = 0
        SC2 = 0
        Me.Close()
    End Sub
End Class