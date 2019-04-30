Imports MySql.Data.MySqlClient

Public Class Form_Update_CategoryType
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")
    Function execCommand(ByVal cmd As MySqlCommand) As Boolean

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Try
            If cmd.ExecuteNonQuery() = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

            MessageBox.Show("ERROR")
            Return False

        End Try

        If connection.State = ConnectionState.Open Then
            connection.Dispose()
            connection.Close()
        End If

    End Function
    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Dim update_command As New MySqlCommand("UPDATE `tblVenuetype` SET `CatType`=@CT,`CatDescription`=@CD,`CatNum`=@CN,`CatSize`=@CS WHERE `CategoryID` = @ID", connection)

        update_command.Parameters.Add("@id", MySqlDbType.Int64).Value = UsableID
        update_command.Parameters.Add("@CT", MySqlDbType.VarChar).Value = txtCatType.Text
        update_command.Parameters.Add("@CD", MySqlDbType.VarChar).Value = txtCatDesc.Text
        update_command.Parameters.Add("@CN", MySqlDbType.VarChar).Value = txtCatNum.Text
        update_command.Parameters.Add("@CS", MySqlDbType.VarChar).Value = ComboBox1.Text
        '---'
        If execCommand(update_command) Then
            MsgBox("User has been successfully updated the Category!", vbInformation, "Updated")
            viewCategories(ServiceCategories.ListView1, "")
            Me.Close()
        Else
            MessageBox.Show("Data NOT Updated")
            viewCategories(ServiceCategories.ListView1, "")
            Me.Close()
            Exit Sub
        End If

        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

End Class