Module Module_Variable
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

    Public gid As Integer
    Public getTid As Integer

End Module
