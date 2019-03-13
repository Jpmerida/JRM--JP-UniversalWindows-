Imports MySql.Data.MySqlClient

Public Class New_Services
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
            mysql = "insert into tblLocation (LocationID, CategoryID, LocationName, LocationPrice, LocationStatus)" &
                       "values ('" & cboCatname.Text & "','" & txtLocationname.Text & "','" & txtPrice.Text & "','" & cboLStatus.Text & "')"

            conndb()
            cmd = New MySqlCommand(mysql, conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()

            viewLocation(ServicesManagement.ListView1, "")

            MsgBox("New Information has been saved", vbInformation, "Saved")

            Me.Close()
        End If


    End Sub
End Class