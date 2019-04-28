Imports MySql.Data.MySqlClient

Public Class CreateNewGuest
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

    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        If (txtGroupName.Text = Nothing Or txtFname.Text = Nothing Or txtMname.Text = Nothing Or txtLname.Text = Nothing Or
            ComboBox1.Text = Nothing Or txtEmail.Text = Nothing Or txtContact.Text = Nothing Or txtAddress.Text = Nothing) Then
            MsgBox("Missing Details!", vbExclamation, "Note")
        Else
            Dim NewGuestID As Integer
            Dim insert_command1 As New MySqlCommand("INSERT INTO `tblguests`(`Name`,`Email`,`ContactNo`, `Address`, `GuestCreated`) VALUES (@n,@e,@c,@ad,@time)", connection)
            insert_command1.Parameters.Add("@n", MySqlDbType.VarChar).Value = txtGroupName.Text
            insert_command1.Parameters.Add("@e", MySqlDbType.VarChar).Value = txtEmail.Text
            insert_command1.Parameters.Add("@c", MySqlDbType.VarChar).Value = txtContact.Text
            insert_command1.Parameters.Add("@ad", MySqlDbType.VarChar).Value = txtAddress.Text
            insert_command1.Parameters.Add("@time", MySqlDbType.DateTime).Value = DateTime.Now

            If execCommand(insert_command1) Then
                Dim command As New MySqlCommand("SELECT MAX(`GuestID`) FROM `tblguests`", connection)
                NewGuestID = command.ExecuteScalar().ToString()
                connection.Close()
                Dim insert_command2 As New MySqlCommand("INSERT INTO `tblguestdetails`(`GuestID`, `Fname`, `Mname`, `Lname`, `Gender`, `type`) VALUES (@GID,@fn,@mn,@ln,@g,@t)", connection)
                insert_command2.Parameters.Add("@GID", MySqlDbType.Int64).Value = NewGuestID
                insert_command2.Parameters.Add("@fn", MySqlDbType.VarChar).Value = txtFname.Text
                insert_command2.Parameters.Add("@mn", MySqlDbType.VarChar).Value = txtMname.Text
                insert_command2.Parameters.Add("@ln", MySqlDbType.VarChar).Value = txtLname.Text
                insert_command2.Parameters.Add("@g", MySqlDbType.VarChar).Value = ComboBox1.Text
                insert_command2.Parameters.Add("@t", MySqlDbType.VarChar).Value = "N/A"

                If execCommand(insert_command2) Then
                    MessageBox.Show("Data Saved")
                    viewguests(GuestsManagement.ListView1, "")
                    Me.Close()
                Else
                    MessageBox.Show("Data NOT Updated")
                    Exit Sub
                End If
            Else
                MessageBox.Show("Data NOT Inserted")
                Exit Sub
            End If
        End If


    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub CreateNewGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGroupName.Text = ""
        txtEmail.Text = ""
        txtContact.Text = ""
        txtAddress.Text = ""
        txtFname.Text = ""
        txtMname.Text = ""
        txtLname.Text = ""
        ComboBox1.Text = ""
    End Sub
End Class