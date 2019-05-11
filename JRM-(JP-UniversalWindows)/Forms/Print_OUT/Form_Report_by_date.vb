Imports MySql.Data.MySqlClient

Public Class Form_Report_by_date
    Private Sub Form_Report_by_date_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adp As New MySqlDataAdapter
        Dim dt As New DataSet

        mysql = "SELECT * FROM table_Print_Transactions_by_Date"
        ' OpenConn()
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        adp.SelectCommand = cmd
        adp.Fill(dt, "table_Print_Transactions_by_Date")
        Dim report As New CrystalReport_Report
        report.Load()
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
        adp.Dispose()
        dt.Dispose()
        closeDB()

        mysql = "SELECT * FROM tblusers WHERE UserID = " & UID
        ' OpenConn()
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        adp.SelectCommand = cmd
        adp.Fill(dt, "tblusers")
        Dim report1 As New CrystalReport_Report
        report1.Load()
        report1.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report1
        CrystalReportViewer1.Refresh()
        adp.Dispose()
        dt.Dispose()
        closeDB()
    End Sub
End Class