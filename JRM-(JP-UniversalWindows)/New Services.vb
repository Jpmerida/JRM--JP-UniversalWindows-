Imports MySql.Data.MySqlClient

Public Class New_Services
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtLocationname.Text = "" Then
            MsgBox("There is no Name inputted!", vbInformation, "Error! Try Again!")
        ElseIf txtPrice.Text = "" Then
            MsgBox("There is no Price inputted!", vbInformation, "Error! Try Again!")
        ElseIf cboLStatus.Text = "" Then
            MsgBox("There is no Status inputted!", vbInformation, "Error! Try Again!")
        Else

            '------'
            Dim insert_command As New MySqlCommand("INSERT INTO `tblLocation`(`CategoryID`,`LocationName`, `LocationPrice`, `LocationStatus`) VALUES (@CID,@LN,@LP,@LS)", connection)

            insert_command.Parameters.Add("@CID", MySqlDbType.VarChar).Value = cboCatname.Text
            insert_command.Parameters.Add("@LN", MySqlDbType.VarChar).Value = txtLocationname.Text
            insert_command.Parameters.Add("@LP", MySqlDbType.VarChar).Value = txtPrice.Text
            insert_command.Parameters.Add("@LS", MySqlDbType.VarChar).Value = cboLStatus.Text
            If execCommand(insert_command) Then
                viewLocation(ServicesManagement.ListView1, "")
                MsgBox("New Information has been saved", vbInformation, "Saved")
                MessageBox.Show("Data added successfully!")
            Else
                MessageBox.Show("Data NOT Updated")
                Exit Sub
            End If

            Me.Close()
        End If


    End Sub
End Class