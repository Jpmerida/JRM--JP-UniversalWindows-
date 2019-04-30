Module Module_Forms
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~' For Opening New Forms (LIMITING only 1 window to open)
    Public Procced As Integer = 0 'for LOGIN FORM
    Public NewAcc As Integer = 0 'for CREATING NEW FORM
    Public UM As Integer = 0 'for USER MANAGEMENT FORM
    Public GM As Integer = 0 'for GUEST MANAGEMENT FORM
    Public SM As Integer = 0 'for SERVICES MANAGEMENT FORM
    Public SC As Integer = 0 'for SERVICE CATEGORIES FORM
    Public SC2 As Integer = 0 'for NEW SERVICE CATEGORIES FORM
    Public CI As Integer = 0 'for CHECK-IN FORM
    Public CG As Integer = 0 'for CHECKIN GUEST FORM
    Public NF As Integer = 0 'for ADDING SERVICES MANAGEMENT FORM
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~' 

    Public first1 = New Form_Main()
    Public GuestWindow = New Form_Management_Guest()
    Public CLogin As New Form_Login()
    Public MMenu = New Form_Main_Menu()
    Public ServicesFORM = New Form_Management_Venue()
    Public CategoryForm = New ServiceCategories()
    Public NewCategoryFORM = New Form_CreateNew_CategoryType()
    Public ADDServicesForm = New Form_CreateNew_Services()
    Public UserWindow = New Form_Management_User()
    Public CInForm = New Form_Checkin()
    Public CheckInG As New Form_Checkin_Guest()

    Public Sub openLogin(NoNumber As Integer)
        If Procced = 0 Then
            CLogin = New Form_Login()
            CLogin.MdiParent = Form_Main
            CLogin.LayoutMdi(MdiLayout.TileHorizontal)
            CLogin.Dock = DockStyle.Left
            CLogin.Show()
            Procced = 1
        Else
            CLogin.BringToFront()
            CLogin.LayoutMdi(MdiLayout.TileHorizontal)
            CLogin.Dock = DockStyle.Left
        End If
    End Sub

    Public Sub openGWindow(NoNumber As Integer)
        If GM = 0 Then
            'GuestsManagement.ShowDialog()
            GuestWindow = New Form_Management_Guest()
            GuestWindow.MdiParent = Form_Main
            GuestWindow.Text = "Guest Management Form - " + Form_Main.MdiChildren.Length.ToString()
            GuestWindow.show
            GM = 1
        Else
            GuestWindow.BringToFront()
        End If
    End Sub

End Module
