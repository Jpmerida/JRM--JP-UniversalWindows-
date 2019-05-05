Imports MySql.Data.MySqlClient

Public Class Form_Management_Guest
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
        Me.WindowState = FormWindowState.Maximized

        viewguests(ListView1, "")
        txtSearch.Text = ""
        txtFname.Text = ""
        txtMname.Text = ""
        txtLname.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        txtContact.Text = ""
        ComboBox1.Text = ""
        Button1.Enabled = False
        Button1.Visible = False
    End Sub

    Private Sub txtSearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        viewguests(ListView1, txtSearch.Text)
    End Sub



    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        GM = 0
        'openLogin(Procced)
        Me.Close()
    End Sub

    Public Sub cmdupdatesub(uidtype As String)
        If uidtype = "Admin" Or uidtype = "Manager" Then
            Dim fn As String = txtFname.Text
            Dim mn As String = txtMname.Text
            Dim ln As String = txtLname.Text
            If (txtGroupName.Text = "" Or txtContact.Text = "" Or txtMname.Text = "" Or txtFname.Text = "" Or txtLname.Text = "" Or ComboBox1.Text = "") Then
                MsgBox("Cannot Update Information.", vbInformation, "Missing Required Information")
                Exit Sub
            ElseIf GIDupdate = GIDupdate Then
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
        Else
            MsgBox("Not Authorized! Please Login with authorized credentials.", vbCritical, "User Not Allowed!")
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If (Me.ListView1.SelectedItems.Count = 0) Then
            Return
        End If

        GIDupdate = ListView1.SelectedItems(0).Text

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
        Button1.Enabled = True
    End Sub

    Private Sub Form_Management_Guest_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        GM = 0
        openLogin(Procced)
    End Sub

    Private Sub Btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        viewguests(ListView1, "")
    End Sub

    Private Sub Button_Guests_Create_Click(sender As Object, e As EventArgs) Handles Button_Guests_Create.Click
        Form_CreateNew_Guest.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GuestWindow.cmdupdatesub(UIDType)
    End Sub
End Class


