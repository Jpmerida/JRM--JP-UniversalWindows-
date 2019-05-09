<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tab_Main = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Button_Main_Checkin = New System.Windows.Forms.Button()
        Me.Button_Main_Checkout = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Button_Logout = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button_Guests_Update = New System.Windows.Forms.Button()
        Me.Button_Guests_Create = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_Guests = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button_Categories_Create = New System.Windows.Forms.Button()
        Me.Button_Categories_Update = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Button_Categories = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button_Services_Create = New System.Windows.Forms.Button()
        Me.Button_Services_Update = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button_Services = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button_Users_Create = New System.Windows.Forms.Button()
        Me.Button_Users_Update = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button_Users = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Button_Items = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolbarLogOUT = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbarCheckIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbarCheckOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbarReserve = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbarGuests = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbarLocations = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbarItems = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbarUsers = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuLOGOUT = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.Tab_Main.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 705)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(1260, 24)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(34, 19)
        Me.ToolStripStatusLabel4.Text = "    |    "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Enabled = False
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(94, 19)
        Me.ToolStripStatusLabel1.Text = "User Logged-in :"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(10, 19)
        Me.ToolStripStatusLabel2.Text = " "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(1107, 19)
        Me.ToolStripStatusLabel3.Spring = True
        Me.ToolStripStatusLabel3.Text = "Date and Time :"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Tab_Main
        '
        Me.Tab_Main.Controls.Add(Me.TabPage1)
        Me.Tab_Main.Controls.Add(Me.TabPage2)
        Me.Tab_Main.Controls.Add(Me.TabPage3)
        Me.Tab_Main.Controls.Add(Me.TabPage4)
        Me.Tab_Main.Controls.Add(Me.TabPage5)
        Me.Tab_Main.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tab_Main.Location = New System.Drawing.Point(0, 66)
        Me.Tab_Main.Name = "Tab_Main"
        Me.Tab_Main.SelectedIndex = 0
        Me.Tab_Main.Size = New System.Drawing.Size(789, 122)
        Me.Tab_Main.TabIndex = 8
        Me.Tab_Main.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.GroupBox10)
        Me.TabPage1.Controls.Add(Me.GroupBox9)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(781, 88)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(1022, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Button_Main_Checkin)
        Me.GroupBox10.Controls.Add(Me.Button_Main_Checkout)
        Me.GroupBox10.Location = New System.Drawing.Point(163, 6)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(407, 79)
        Me.GroupBox10.TabIndex = 10
        Me.GroupBox10.TabStop = False
        '
        'Button_Main_Checkin
        '
        Me.Button_Main_Checkin.Location = New System.Drawing.Point(41, 28)
        Me.Button_Main_Checkin.Name = "Button_Main_Checkin"
        Me.Button_Main_Checkin.Size = New System.Drawing.Size(162, 45)
        Me.Button_Main_Checkin.TabIndex = 1
        Me.Button_Main_Checkin.Text = "Check IN"
        Me.Button_Main_Checkin.UseVisualStyleBackColor = True
        '
        'Button_Main_Checkout
        '
        Me.Button_Main_Checkout.Location = New System.Drawing.Point(209, 28)
        Me.Button_Main_Checkout.Name = "Button_Main_Checkout"
        Me.Button_Main_Checkout.Size = New System.Drawing.Size(162, 45)
        Me.Button_Main_Checkout.TabIndex = 2
        Me.Button_Main_Checkout.Text = "Check Out"
        Me.Button_Main_Checkout.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Button_Logout)
        Me.GroupBox9.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(149, 79)
        Me.GroupBox9.TabIndex = 5
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Tag = "  "
        '
        'Button_Logout
        '
        Me.Button_Logout.Location = New System.Drawing.Point(15, 18)
        Me.Button_Logout.Name = "Button_Logout"
        Me.Button_Logout.Size = New System.Drawing.Size(121, 45)
        Me.Button_Logout.TabIndex = 1
        Me.Button_Logout.Text = "Log-out"
        Me.Button_Logout.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(781, 88)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Guests Management"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.Button_Guests_Update)
        Me.GroupBox2.Controls.Add(Me.Button_Guests_Create)
        Me.GroupBox2.Location = New System.Drawing.Point(200, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(418, 79)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Management"
        Me.GroupBox2.Visible = False
        '
        'Button_Guests_Update
        '
        Me.Button_Guests_Update.Location = New System.Drawing.Point(209, 28)
        Me.Button_Guests_Update.Name = "Button_Guests_Update"
        Me.Button_Guests_Update.Size = New System.Drawing.Size(162, 45)
        Me.Button_Guests_Update.TabIndex = 2
        Me.Button_Guests_Update.Text = "Update Guest"
        Me.Button_Guests_Update.UseVisualStyleBackColor = True
        '
        'Button_Guests_Create
        '
        Me.Button_Guests_Create.Location = New System.Drawing.Point(41, 28)
        Me.Button_Guests_Create.Name = "Button_Guests_Create"
        Me.Button_Guests_Create.Size = New System.Drawing.Size(162, 45)
        Me.Button_Guests_Create.TabIndex = 1
        Me.Button_Guests_Create.Text = "Create New Guest"
        Me.Button_Guests_Create.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Guests)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 79)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View List"
        '
        'Button_Guests
        '
        Me.Button_Guests.Location = New System.Drawing.Point(31, 28)
        Me.Button_Guests.Name = "Button_Guests"
        Me.Button_Guests.Size = New System.Drawing.Size(121, 45)
        Me.Button_Guests.TabIndex = 0
        Me.Button_Guests.Text = "Guests"
        Me.Button_Guests.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Orange
        Me.TabPage3.Controls.Add(Me.GroupBox7)
        Me.TabPage3.Controls.Add(Me.GroupBox8)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabPage3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(781, 88)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Services Management"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button_Categories_Create)
        Me.GroupBox7.Controls.Add(Me.Button_Categories_Update)
        Me.GroupBox7.Location = New System.Drawing.Point(816, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(418, 79)
        Me.GroupBox7.TabIndex = 11
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Category Management"
        '
        'Button_Categories_Create
        '
        Me.Button_Categories_Create.Location = New System.Drawing.Point(41, 28)
        Me.Button_Categories_Create.Name = "Button_Categories_Create"
        Me.Button_Categories_Create.Size = New System.Drawing.Size(162, 45)
        Me.Button_Categories_Create.TabIndex = 1
        Me.Button_Categories_Create.Text = "Create New Service"
        Me.Button_Categories_Create.UseVisualStyleBackColor = True
        '
        'Button_Categories_Update
        '
        Me.Button_Categories_Update.Location = New System.Drawing.Point(209, 28)
        Me.Button_Categories_Update.Name = "Button_Categories_Update"
        Me.Button_Categories_Update.Size = New System.Drawing.Size(162, 45)
        Me.Button_Categories_Update.TabIndex = 2
        Me.Button_Categories_Update.Text = "Update Service"
        Me.Button_Categories_Update.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Button_Categories)
        Me.GroupBox8.Location = New System.Drawing.Point(624, 6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(186, 79)
        Me.GroupBox8.TabIndex = 10
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "View Category Type"
        '
        'Button_Categories
        '
        Me.Button_Categories.Location = New System.Drawing.Point(31, 28)
        Me.Button_Categories.Name = "Button_Categories"
        Me.Button_Categories.Size = New System.Drawing.Size(121, 45)
        Me.Button_Categories.TabIndex = 0
        Me.Button_Categories.Text = "Categories"
        Me.Button_Categories.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button_Services_Create)
        Me.GroupBox5.Controls.Add(Me.Button_Services_Update)
        Me.GroupBox5.Location = New System.Drawing.Point(200, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(418, 79)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Services Management"
        '
        'Button_Services_Create
        '
        Me.Button_Services_Create.Location = New System.Drawing.Point(41, 28)
        Me.Button_Services_Create.Name = "Button_Services_Create"
        Me.Button_Services_Create.Size = New System.Drawing.Size(162, 45)
        Me.Button_Services_Create.TabIndex = 1
        Me.Button_Services_Create.Text = "Create New Service"
        Me.Button_Services_Create.UseVisualStyleBackColor = True
        '
        'Button_Services_Update
        '
        Me.Button_Services_Update.Location = New System.Drawing.Point(209, 28)
        Me.Button_Services_Update.Name = "Button_Services_Update"
        Me.Button_Services_Update.Size = New System.Drawing.Size(162, 45)
        Me.Button_Services_Update.TabIndex = 2
        Me.Button_Services_Update.Text = "Update Service"
        Me.Button_Services_Update.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button_Services)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(186, 79)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "View Services Offered"
        '
        'Button_Services
        '
        Me.Button_Services.Location = New System.Drawing.Point(31, 28)
        Me.Button_Services.Name = "Button_Services"
        Me.Button_Services.Size = New System.Drawing.Size(121, 45)
        Me.Button_Services.TabIndex = 0
        Me.Button_Services.Text = "Services"
        Me.Button_Services.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.YellowGreen
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 30)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(781, 88)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Users Management"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button_Users_Create)
        Me.GroupBox3.Controls.Add(Me.Button_Users_Update)
        Me.GroupBox3.Location = New System.Drawing.Point(200, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(418, 79)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Management"
        '
        'Button_Users_Create
        '
        Me.Button_Users_Create.Location = New System.Drawing.Point(41, 28)
        Me.Button_Users_Create.Name = "Button_Users_Create"
        Me.Button_Users_Create.Size = New System.Drawing.Size(162, 45)
        Me.Button_Users_Create.TabIndex = 1
        Me.Button_Users_Create.Text = "Create New User"
        Me.Button_Users_Create.UseVisualStyleBackColor = True
        '
        'Button_Users_Update
        '
        Me.Button_Users_Update.Location = New System.Drawing.Point(209, 28)
        Me.Button_Users_Update.Name = "Button_Users_Update"
        Me.Button_Users_Update.Size = New System.Drawing.Size(162, 45)
        Me.Button_Users_Update.TabIndex = 2
        Me.Button_Users_Update.Text = "Update User"
        Me.Button_Users_Update.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button_Users)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(186, 79)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "View List"
        '
        'Button_Users
        '
        Me.Button_Users.Location = New System.Drawing.Point(31, 28)
        Me.Button_Users.Name = "Button_Users"
        Me.Button_Users.Size = New System.Drawing.Size(121, 45)
        Me.Button_Users.TabIndex = 0
        Me.Button_Users.Text = "Users"
        Me.Button_Users.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox12)
        Me.TabPage5.Location = New System.Drawing.Point(4, 30)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(781, 88)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Item Management"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Button_Items)
        Me.GroupBox12.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(186, 79)
        Me.GroupBox12.TabIndex = 8
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "View List"
        '
        'Button_Items
        '
        Me.Button_Items.Location = New System.Drawing.Point(31, 28)
        Me.Button_Items.Name = "Button_Items"
        Me.Button_Items.Size = New System.Drawing.Size(121, 45)
        Me.Button_Items.TabIndex = 0
        Me.Button_Items.Text = "Items"
        Me.Button_Items.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolbarLogOUT, Me.ToolStripSeparator9, Me.toolbarCheckIn, Me.ToolStripButton11, Me.toolbarCheckOut, Me.ToolStripSeparator6, Me.toolbarReserve, Me.ToolStripSeparator7, Me.toolbarGuests, Me.ToolStripSeparator1, Me.toolbarLocations, Me.ToolStripSeparator8, Me.toolbarItems, Me.ToolStripSeparator10, Me.toolbarUsers, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1260, 39)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.Text = "ToolStrip2"
        '
        'toolbarLogOUT
        '
        Me.toolbarLogOUT.ForeColor = System.Drawing.Color.Maroon
        Me.toolbarLogOUT.Image = Global.JRM__JP_UniversalWindows_.My.Resources.Resources.logout
        Me.toolbarLogOUT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbarLogOUT.Name = "toolbarLogOUT"
        Me.toolbarLogOUT.Size = New System.Drawing.Size(108, 36)
        Me.toolbarLogOUT.Text = "Log-Out"
        Me.toolbarLogOUT.ToolTipText = "Logout"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 39)
        '
        'toolbarCheckIn
        '
        Me.toolbarCheckIn.Image = Global.JRM__JP_UniversalWindows_.My.Resources.Resources.login
        Me.toolbarCheckIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbarCheckIn.Name = "toolbarCheckIn"
        Me.toolbarCheckIn.Size = New System.Drawing.Size(112, 36)
        Me.toolbarCheckIn.Text = "Check-In"
        Me.toolbarCheckIn.ToolTipText = "Check-in"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(6, 39)
        '
        'toolbarCheckOut
        '
        Me.toolbarCheckOut.Image = Global.JRM__JP_UniversalWindows_.My.Resources.Resources.logout1
        Me.toolbarCheckOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbarCheckOut.Name = "toolbarCheckOut"
        Me.toolbarCheckOut.Size = New System.Drawing.Size(125, 36)
        Me.toolbarCheckOut.Text = "Check-Out"
        Me.toolbarCheckOut.ToolTipText = "Check-Out"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
        '
        'toolbarReserve
        '
        Me.toolbarReserve.Image = Global.JRM__JP_UniversalWindows_.My.Resources.Resources.booking
        Me.toolbarReserve.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbarReserve.Name = "toolbarReserve"
        Me.toolbarReserve.Size = New System.Drawing.Size(137, 36)
        Me.toolbarReserve.Text = "Reservation"
        Me.toolbarReserve.ToolTipText = "Reservation"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 39)
        '
        'toolbarGuests
        '
        Me.toolbarGuests.Image = CType(resources.GetObject("toolbarGuests.Image"), System.Drawing.Image)
        Me.toolbarGuests.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbarGuests.Name = "toolbarGuests"
        Me.toolbarGuests.Size = New System.Drawing.Size(96, 36)
        Me.toolbarGuests.Text = "Guests"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'toolbarLocations
        '
        Me.toolbarLocations.Image = CType(resources.GetObject("toolbarLocations.Image"), System.Drawing.Image)
        Me.toolbarLocations.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbarLocations.Name = "toolbarLocations"
        Me.toolbarLocations.Size = New System.Drawing.Size(186, 36)
        Me.toolbarLocations.Text = "Cottage/Locations"
        Me.toolbarLocations.ToolTipText = "Cottage/Locations"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 39)
        '
        'toolbarItems
        '
        Me.toolbarItems.Image = Global.JRM__JP_UniversalWindows_.My.Resources.Resources.menu_5
        Me.toolbarItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbarItems.Name = "toolbarItems"
        Me.toolbarItems.Size = New System.Drawing.Size(187, 36)
        Me.toolbarItems.Text = "Item Management"
        Me.toolbarItems.ToolTipText = "Items"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 39)
        '
        'toolbarUsers
        '
        Me.toolbarUsers.Image = CType(resources.GetObject("toolbarUsers.Image"), System.Drawing.Image)
        Me.toolbarUsers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbarUsers.Name = "toolbarUsers"
        Me.toolbarUsers.Size = New System.Drawing.Size(193, 36)
        Me.toolbarUsers.Text = "Users Management"
        Me.toolbarUsers.ToolTipText = "Users"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "Transaction List"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuLOGOUT})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1260, 29)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'ToolStripMenuLOGOUT
        '
        Me.ToolStripMenuLOGOUT.Image = Global.JRM__JP_UniversalWindows_.My.Resources.Resources.logout
        Me.ToolStripMenuLOGOUT.Name = "ToolStripMenuLOGOUT"
        Me.ToolStripMenuLOGOUT.Size = New System.Drawing.Size(105, 25)
        Me.ToolStripMenuLOGOUT.Text = "Log-OUT"
        '
        'Form_Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackgroundImage = Global.JRM__JP_UniversalWindows_.My.Resources.Resources._2_Blur
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1260, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Tab_Main)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.Name = "Form_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JRM FAMILY RESORT MANAGEMENT INFORMATION SYSTEM"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Tab_Main.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents Tab_Main As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Button_Logout As Button
    Friend WithEvents Button_Users As Button
    Friend WithEvents Button_Users_Create As Button
    Friend WithEvents Button_Users_Update As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_Guests As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button_Guests_Create As Button
    Friend WithEvents Button_Guests_Update As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button_Services_Create As Button
    Friend WithEvents Button_Services_Update As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Button_Services As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Button_Categories_Create As Button
    Friend WithEvents Button_Categories_Update As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Button_Categories As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Button_Main_Checkin As Button
    Friend WithEvents Button_Main_Checkout As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents Button_Items As Button
    Friend WithEvents Panel1 As Panel
    Public WithEvents Timer1 As Timer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents toolbarCheckIn As ToolStripButton
    Friend WithEvents ToolStripButton11 As ToolStripSeparator
    Friend WithEvents toolbarCheckOut As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents toolbarReserve As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents toolbarLocations As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents toolbarUsers As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents toolbarLogOUT As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents toolbarItems As ToolStripButton
    Friend WithEvents toolbarGuests As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuLOGOUT As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
