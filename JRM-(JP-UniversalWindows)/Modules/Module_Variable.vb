﻿Module Module_Variable
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~' UserID
    Public USERID_table As New DataTable()
    Public UID As Integer = 0
    Public UIDType As String = "NONE"
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~' For Updating User & Guest/ Location/Spot/Venue
    Public UIDupdate As Integer = 0
    Public GIDupdate As Integer = 0
    Public UsableID As Integer = 0
    Public VUIupdate As Integer = 0
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~' Use for inputing CheckIn

    Public ItsOKAY As Integer = 0
    Public trans_ID As Integer = 0              'Transaction ID
    Public CheckGuestID As Integer = 0
    Public CheckServiceID As Integer = 0
    Public CheckServiceTypeID As Integer = 0


    Public continueonce As Integer = 0
    Public table2 As New DataTable("Table")

    '________________________Reservation______________
    Public ReservedID As Integer = 0
    ''Public Venues(5) As Integer
    ''Public StopV = 0
    ''Public Items(5) As Integer
    ''Public ItemsMuch(5) As Integer
    ''Public StopI = 0


    Public gid As Integer
    Public getTid As Integer

    Public getID2 As Integer
    Public getTID2 As Integer
    Public ForUpdateITEM_ID As Integer = 0 ''For Update ITEM ID

    Public test3 As DateTime
    Public test5 As String


    '=================
    Public RecentTID As Integer

    Public Reportd1 As String
    Public Reportd2 As String
End Module
