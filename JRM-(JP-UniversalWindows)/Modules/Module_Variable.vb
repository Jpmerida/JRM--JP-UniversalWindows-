Module Module_Variable
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~' UserID
    Public USERID_table As New DataTable()
    Public UID As Integer
    Public UIDType As String = "NONE"
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~' For Updating User & Guest/ Location/Spot/Venue
    Public UIDupdate As Integer = 0
    Public GIDupdate As Integer = 0
    Public UsableID As Integer = 0
    Public VUIupdate As Integer = 0
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~' Use for inputing CheckIn

    Public ItsOKAY As Integer = 0
    Public CheckGuestID As Integer = 0
    Public CheckServiceID As Integer = 0
    Public tempSub As Double = 0
    Public SubTot As Double = 0.00

    Public table2 As New DataTable("Table")
End Module
