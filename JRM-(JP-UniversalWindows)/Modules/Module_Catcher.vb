Imports MySql.Data.MySqlClient

Module Module_Catcher
    Public Sub OnlyLetters(e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Public Sub OnlyNumbers(e As KeyPressEventArgs)
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
    AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    'Private conn As MySqlConnection
    'Private cmd As New MySqlCommand
    'Private da As New MySqlDataAdapter
    'Private ds As New DataSet
    'Private dt As New DataTable

    'Public Function OpenConn() As Boolean
    '    Try
    '        conn = New MySqlConnection()
    '        conn.ConnectionString = "Server=localhost;user id=root;password=admin;database=jrm"
    '        conn.Open()
    '        If conn.State <> ConnectionState.Open Then
    '            Return False
    '        Else
    '            Return True
    '        End If
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function

    'Public Function Executequery(ByVal query As String) As DataTable
    '    If Not OpenConn() Then
    '        MsgBox("Module_Catcher")
    '        Application.Exit()
    '        Return Nothing
    '        Exit Function
    '    End If
    '    cmd.Connection = conn
    '    cmd.CommandText = query
    '    da.SelectCommand = cmd
    '    ds = New Data.DataSet
    '    da.Fill(ds)
    '    dt = ds.Tables(0)
    '    Return dt
    '    dt = Nothing
    '    ds = Nothing
    '    da = Nothing
    '    cmd = Nothing

    '    If Not IsNothing(conn) Then
    '        conn.Dispose()
    '        conn = Nothing
    '    End If
    ''End Function
    '=========================== for Crystal report ================
    'Dim report As New CrystalReport_OR
    '    report.Load()
    '    report.SetDataSource(Executequery("Select * FROM Table_Transactions WHERE T_id =" & RecentTID))
    '    CrystalReportViewer1.ReportSource = report
    '    CrystalReportViewer1.Refresh()
End Module
