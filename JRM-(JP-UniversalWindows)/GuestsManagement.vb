Imports MySql.Data.MySqlClient

Public Class GuestsManagement
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")

    Private GIDupdate As Integer

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

    Private Sub GuestsManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewguests(ListView1, "")
        txtSearch.Text = ""
        txtFname.Text = ""
        txtMname.Text = ""
        txtLname.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        txtContact.Text = ""
        ComboBox1.Text = ""
    End Sub



    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        GIDupdate = ListView1.SelectedItems(0).SubItems(0).Text


        mysql = "select * from tblguestdetails where GuestID ='" & GIDupdate & "'"
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        dr.Read()
        txtFname.Text = dr("Fname")
        txtMname.Text = dr("Mname")
        txtLname.Text = dr("Lname")
        ComboBox1.Text = dr("Gender")
        cmd.Dispose()
        conn.Close()

        mysql = "select * from tblguests where GuestID ='" & GIDupdate & "'"
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        dr.Read()
        txtGroupName.Text = dr("Name")
        cmd.Dispose()
        conn.Close()

        txtEmail.Text = ListView1.SelectedItems(0).SubItems(2).Text
        txtContact.Text = ListView1.SelectedItems(0).SubItems(3).Text
        txtAddress.Text = ListView1.SelectedItems(0).SubItems(4).Text
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        viewguests(ListView1, txtSearch.Text)
    End Sub


    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Dim fn As String = txtFname.Text
        Dim mn As String = txtMname.Text
        Dim ln As String = txtLname.Text
        'Dim newname As String = (fn + " " + mn + " " + ln)
        If (txtGroupName.Text = "") Then
            MsgBox("Cannot Update Information.", vbInformation, "Missing Required Information")
            Exit Sub
        ElseIf (txtLname.Text = "") Then
            MsgBox("Cannot Update Information.", vbInformation, "Missing Required Information")
            Exit Sub
        ElseIf (txtFname.Text = "") Then
            MsgBox("Cannot Update Information.", vbInformation, "Missing Required Information")
            Exit Sub
        ElseIf (txtMname.Text = "") Then
            MsgBox("Cannot Update Information.", vbInformation, "Missing Required Information")
            Exit Sub
        ElseIf (txtContact.Text = "") Then
            MsgBox("Cannot Update Information.", vbInformation, "Missing Required Information")
            Exit Sub
        ElseIf GIDupdate = GIDupdate Then
            '------------'

            Dim update_command1 As New MySqlCommand("UPDATE `tblguestdetails` SET `Fname`=@fn,`Mname`=@mn,`Lname`=@ln,`Gender`=@g WHERE `GuestID` = @id", connection)
            Dim update_command2 As New MySqlCommand("UPDATE `tblguests` SET `Name`=@Gn,`Email`=@E,`ContactNo`=@C,`Address`=@Add WHERE `GuestID` = @id2", connection)

            update_command1.Parameters.Add("@id", MySqlDbType.Int64).Value = GIDupdate
            update_command1.Parameters.Add("@fn", MySqlDbType.VarChar).Value = txtFname.Text
            update_command1.Parameters.Add("@mn", MySqlDbType.VarChar).Value = txtMname.Text
            update_command1.Parameters.Add("@ln", MySqlDbType.VarChar).Value = txtLname.Text
            update_command1.Parameters.Add("@g", MySqlDbType.VarChar).Value = ComboBox1.Text

            If execCommand(update_command1) Then
                'MessageBox.Show("Data Up  dated")
            Else
                MessageBox.Show("Data NOT Updated")
                Exit Sub
            End If
            update_command2.Parameters.Add("@id2", MySqlDbType.Int64).Value = GIDupdate
            update_command2.Parameters.Add("@Gn", MySqlDbType.VarChar).Value = txtGroupName.Text
            update_command2.Parameters.Add("@E", MySqlDbType.VarChar).Value = txtEmail.Text
            update_command2.Parameters.Add("@C", MySqlDbType.VarChar).Value = txtContact.Text
            update_command2.Parameters.Add("@Add", MySqlDbType.VarChar).Value = txtAddress.Text

            If execCommand(update_command2) Then
                MessageBox.Show("Data Updated")
                viewguests(ListView1, "")
            Else
                MessageBox.Show("Data NOT Updated")
                Exit Sub
            End If

        Else
            MsgBox("Guest Selected do not match", vbInformation, "Mismatch")
        End If
    End Sub

    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        CreateNewGuest.ShowDialog()

    End Sub
End Class