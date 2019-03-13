Imports MySql.Data.MySqlClient

Public Class Test4Adding

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")

    Private Sub Test4Adding_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' populate datagridview from datatable 
        Dim table As New DataTable("Table")

        ' Add columns to your datatable 
        table.Columns.Add("Id", Type.GetType("System.Int32"))
        table.Columns.Add("First Name", Type.GetType("System.String"))
        table.Columns.Add("Last Name", Type.GetType("System.String"))
        table.Columns.Add("Age", Type.GetType("System.Int32"))

        ' Add rows to the datatable 
        table.Rows.Add(1, "aaaa", "bbbb", 21)
        table.Rows.Add(2, "SSDD", "hGSQ", 33)
        table.Rows.Add(3, "fgfgd", "jgfdd", 53)
        table.Rows.Add(4, "cvfghyghj", "sdrgtyh", 19)
        table.Rows.Add(5, "hghfd", "ghjgdf", 36)
        table.Rows.Add(6, "cvvdfgh", "juyrfdvc", 63)

        DataGridView1.DataSource = table

    End Sub

    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click

        Dim cmd As MySqlCommand

        connection.Open()

        For i As Integer = 0 To DataGridView1.Rows.Count - 2 Step +1

            cmd = New MySqlCommand("INSERT INTO `tabletest`(`id`, `first_name`, `last_name`, `age`) VALUES (@ID, @FN, @LN, @AGE)", connection)

            cmd.Parameters.Add("@ID", MySqlDbType.Int64).Value = DataGridView1.Rows(i).Cells(0).Value.ToString()
            cmd.Parameters.Add("@FN", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(1).Value.ToString()
            cmd.Parameters.Add("@LN", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(2).Value.ToString()
            cmd.Parameters.Add("@AGE", MySqlDbType.Int64).Value = DataGridView1.Rows(i).Cells(3).Value.ToString()

            cmd.ExecuteNonQuery()

        Next

        connection.Close()

        MessageBox.Show("All Data Inserted")

    End Sub
End Class

