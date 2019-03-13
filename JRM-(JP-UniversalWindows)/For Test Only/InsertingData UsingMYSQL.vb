Imports MySql.Data.MySqlClient

Public Class InsertingData_UsingMYSQL
    Private Sub InsertingData_UsingMYSQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")

    End Sub

    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click

        Dim params(2) As MySqlParameter

        params(0) = New MySqlParameter("FLNM", MySqlDbType.VarChar)
        params(0).Value = TextBox1.Text

        params(1) = New MySqlParameter("ADRS", MySqlDbType.VarChar)
        params(1).Value = TextBox2.Text

        params(2) = New MySqlParameter("DT", MySqlDbType.Date)
        params(2).Value = DateTimePicker1.Value

        Dim cmd As New MySqlCommand()

        cmd.Connection = connection
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "tabletest2"

        cmd.Parameters.AddRange(params)

        connection.Open()

        If cmd.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Inserted")
        Else
            MessageBox.Show("Not Inserted")
        End If

        connection.Close()

    End Sub
End Class