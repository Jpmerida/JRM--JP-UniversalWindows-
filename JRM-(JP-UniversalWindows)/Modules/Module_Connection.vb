﻿Imports MySql.Data.MySqlClient
Module Module_Connection
    '-------Main Thread-------'
    Public connectionString As String
    Public mysql As String
    ''Public connection As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public rs As MySqlDataAdapter
    Public conn As MySqlConnection = New MySqlConnection
    Public newline As ListViewItem 'dim
    Public connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=jrm")


    '-------Main Thread-------'

    Public Function execCommand(ByVal cmd As MySqlCommand) As Boolean
        If connection.State = ConnectionState.Closed Then
            connection.Open()
            conn.Open()
        End If
        Try
            If cmd.ExecuteNonQuery() = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
        If connection.State = ConnectionState.Open Then
            connection.Dispose()
            connection.Close()
            conn.Dispose()
            conn.Close()
        End If
    End Function

    Public Sub conndb()
        conn.ConnectionString = ("Server = localhost; uid = root; pwd = admin; database = jrm")
        conn.Open()
    End Sub

    Public Sub closeDB()
        cmd.Dispose()
        conn.Close()
    End Sub


End Module
