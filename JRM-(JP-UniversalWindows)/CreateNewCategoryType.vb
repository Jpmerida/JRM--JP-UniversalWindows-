Imports MySql.Data.MySqlClient

Public Class CreateNewCategoryType
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

            MsgBox("Catched Exception: " & ex.ToString & " <EndOfLine", vbInformation, "Connection Fault")
            Return False

        End Try

        If connection.State = ConnectionState.Open Then
            connection.Dispose()
            connection.Close()
        End If

    End Function

    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        Dim insert_command As New MySqlCommand("INSERT INTO `tblVenueType`(`CatType`,`CatDescription`,`CatNum`, `CatSize`) VALUES (@CT,@CD,@CN,@CS)", connection)

        insert_command.Parameters.Add("@CT", MySqlDbType.VarChar).Value = txtCatType.Text
        insert_command.Parameters.Add("@CD", MySqlDbType.VarChar).Value = txtCatDesc.Text
        insert_command.Parameters.Add("@CN", MySqlDbType.VarChar).Value = txtCatNum.Text
        insert_command.Parameters.Add("@CS", MySqlDbType.VarChar).Value = ComboBox1.Text

        If execCommand(insert_command) Then
            MessageBox.Show("Data Saved")
            viewCategories(ServiceCategories.ListView1, "")
            Me.Close()
        Else
            MessageBox.Show("Data NOT Inserted")
            Exit Sub
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        SC2 = 0
        Me.Close()
    End Sub
End Class