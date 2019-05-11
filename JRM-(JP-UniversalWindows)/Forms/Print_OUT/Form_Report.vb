Imports MySql.Data.MySqlClient
Public Class Form_Report
    Private Sub Form_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''MsgBox(RecentTID)

        Dim adp As New MySqlDataAdapter
        Dim dt As New DataSet


        mysql = "SELECT * FROM Table_Transactions WHERE T_ID = " & RecentTID
        ' OpenConn()
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        adp.SelectCommand = cmd
        adp.Fill(dt, "Table_Transactions")
        Dim report As New CrystalReport_OR
        report.Load()
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
        adp.Dispose()
        dt.Dispose()
        closeDB()

        mysql = "SELECT * FROM table_transactiondetailsvenue WHERE T_ID = " & RecentTID
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        adp.SelectCommand = cmd
        adp.Fill(dt, "table_transactiondetailsvenue")
        Dim report2 As New CrystalReport_OR
        report2.Load()
        report2.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report2
        CrystalReportViewer1.Refresh()
        adp.Dispose()
        dt.Dispose()
        closeDB()

        mysql = "SELECT * FROM table_transactiondetails WHERE T_ID = " & RecentTID
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        adp.SelectCommand = cmd
        adp.Fill(dt, "table_transactiondetails")
        Dim report3 As New CrystalReport_OR
        report3.Load()
        report3.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report3
        CrystalReportViewer1.Refresh()
        adp.Dispose()
        dt.Dispose()
        closeDB()

        mysql = "Select * FROM Table_Transactiondetailsitem WHERE T_id = " & RecentTID
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        adp.SelectCommand = cmd
        adp.Fill(dt, "table_transactiondetailsitem")
        Dim report4 As New CrystalReport_OR
        report4.Load()
        report4.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report4
        CrystalReportViewer1.Refresh()
        adp.Dispose()
        dt.Dispose()

        mysql = "Select * FROM tblguests WHERE guestid = " & gid
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        adp.SelectCommand = cmd
        adp.Fill(dt, "tblguests")
        Dim report5 As New CrystalReport_OR
        report5.Load()
        report5.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report5
        CrystalReportViewer1.Refresh()
        adp.Dispose()
        dt.Dispose()

        mysql = "Select * FROM tblguestdetails WHERE guestid = " & gid
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        adp.SelectCommand = cmd
        adp.Fill(dt, "tblguestdetails")
        Dim report6 As New CrystalReport_OR
        report6.Load()
        report6.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report6
        CrystalReportViewer1.Refresh()
        adp.Dispose()
        dt.Dispose()

        mysql = "Select * FROM tblusers WHERE userid = " & UID
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        adp.SelectCommand = cmd
        adp.Fill(dt, "tblusers")
        Dim report7 As New CrystalReport_OR
        report7.Load()
        report7.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report7
        CrystalReportViewer1.Refresh()
        adp.Dispose()
        dt.Dispose()

        mysql = "Select * FROM tblpayment WHERE T_id = " & RecentTID
        conndb()
        cmd = New MySqlCommand(mysql, conn)
        adp.SelectCommand = cmd
        adp.Fill(dt, "tblpayment")
        Dim report8 As New CrystalReport_OR
        report8.Load()
        report8.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report8
        CrystalReportViewer1.Refresh()
        adp.Dispose()
        dt.Dispose()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class