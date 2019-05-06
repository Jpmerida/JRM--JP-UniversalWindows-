<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Management_User
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtbox_Email = New System.Windows.Forms.TextBox()
        Me.txtbox_Contact = New System.Windows.Forms.TextBox()
        Me.txtbox_Address = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PickDate = New System.Windows.Forms.DateTimePicker()
        Me.combox_Gender = New System.Windows.Forms.ComboBox()
        Me.txtbox_Mname = New System.Windows.Forms.TextBox()
        Me.txtbox_Fname = New System.Windows.Forms.TextBox()
        Me.txtbox_Lname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_Users_Create = New System.Windows.Forms.Button()
        Me.Button_Users_Update = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.cmdCancel.Location = New System.Drawing.Point(1131, 12)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(145, 28)
        Me.cmdCancel.TabIndex = 21
        Me.cmdCancel.Text = "CLOSE"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(175, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Search :"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Location = New System.Drawing.Point(236, 15)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(234, 25)
        Me.txtSearch.TabIndex = 18
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(48, 46)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(422, 450)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "FIRST NAME"
        Me.ColumnHeader2.Width = 182
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "M.I."
        Me.ColumnHeader7.Width = 51
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "LAST NAME"
        Me.ColumnHeader8.Width = 181
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "GENDER"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "EMAIL"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "CONTACT #"
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ADDRESS"
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "BIRTHDATE"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "CREATED"
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "USERTYPE"
        Me.ColumnHeader11.Width = 0
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "USERNAME"
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "PASSWORD"
        Me.ColumnHeader13.Width = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtbox_Email)
        Me.GroupBox2.Controls.Add(Me.txtbox_Contact)
        Me.GroupBox2.Controls.Add(Me.txtbox_Address)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(506, 303)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(532, 193)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contact Information"
        '
        'txtbox_Email
        '
        Me.txtbox_Email.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Email.Location = New System.Drawing.Point(170, 82)
        Me.txtbox_Email.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbox_Email.Name = "txtbox_Email"
        Me.txtbox_Email.ReadOnly = True
        Me.txtbox_Email.Size = New System.Drawing.Size(312, 29)
        Me.txtbox_Email.TabIndex = 7
        Me.txtbox_Email.Text = "Email"
        '
        'txtbox_Contact
        '
        Me.txtbox_Contact.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Contact.Location = New System.Drawing.Point(170, 49)
        Me.txtbox_Contact.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbox_Contact.Name = "txtbox_Contact"
        Me.txtbox_Contact.ReadOnly = True
        Me.txtbox_Contact.Size = New System.Drawing.Size(312, 29)
        Me.txtbox_Contact.TabIndex = 6
        Me.txtbox_Contact.Text = "Contact"
        '
        'txtbox_Address
        '
        Me.txtbox_Address.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Address.Location = New System.Drawing.Point(170, 115)
        Me.txtbox_Address.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbox_Address.Multiline = True
        Me.txtbox_Address.Name = "txtbox_Address"
        Me.txtbox_Address.ReadOnly = True
        Me.txtbox_Address.Size = New System.Drawing.Size(312, 55)
        Me.txtbox_Address.TabIndex = 5
        Me.txtbox_Address.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(105, 85)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 21)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Email :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(80, 52)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 21)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Contact# :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(88, 118)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 21)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Address :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PickDate)
        Me.GroupBox1.Controls.Add(Me.combox_Gender)
        Me.GroupBox1.Controls.Add(Me.txtbox_Mname)
        Me.GroupBox1.Controls.Add(Me.txtbox_Fname)
        Me.GroupBox1.Controls.Add(Me.txtbox_Lname)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(506, 46)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(532, 253)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'PickDate
        '
        Me.PickDate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickDate.Location = New System.Drawing.Point(172, 190)
        Me.PickDate.Margin = New System.Windows.Forms.Padding(2)
        Me.PickDate.Name = "PickDate"
        Me.PickDate.Size = New System.Drawing.Size(312, 29)
        Me.PickDate.TabIndex = 9
        '
        'combox_Gender
        '
        Me.combox_Gender.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combox_Gender.FormattingEnabled = True
        Me.combox_Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.combox_Gender.Location = New System.Drawing.Point(172, 157)
        Me.combox_Gender.Margin = New System.Windows.Forms.Padding(2)
        Me.combox_Gender.Name = "combox_Gender"
        Me.combox_Gender.Size = New System.Drawing.Size(109, 29)
        Me.combox_Gender.TabIndex = 8
        Me.combox_Gender.Text = "Male"
        '
        'txtbox_Mname
        '
        Me.txtbox_Mname.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Mname.Location = New System.Drawing.Point(172, 124)
        Me.txtbox_Mname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbox_Mname.Name = "txtbox_Mname"
        Me.txtbox_Mname.ReadOnly = True
        Me.txtbox_Mname.Size = New System.Drawing.Size(312, 29)
        Me.txtbox_Mname.TabIndex = 7
        Me.txtbox_Mname.Text = "Middle"
        '
        'txtbox_Fname
        '
        Me.txtbox_Fname.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Fname.Location = New System.Drawing.Point(172, 91)
        Me.txtbox_Fname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbox_Fname.Name = "txtbox_Fname"
        Me.txtbox_Fname.ReadOnly = True
        Me.txtbox_Fname.Size = New System.Drawing.Size(312, 29)
        Me.txtbox_Fname.TabIndex = 6
        Me.txtbox_Fname.Text = "First"
        '
        'txtbox_Lname
        '
        Me.txtbox_Lname.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Lname.Location = New System.Drawing.Point(172, 58)
        Me.txtbox_Lname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbox_Lname.Name = "txtbox_Lname"
        Me.txtbox_Lname.ReadOnly = True
        Me.txtbox_Lname.Size = New System.Drawing.Size(312, 29)
        Me.txtbox_Lname.TabIndex = 5
        Me.txtbox_Lname.Text = "Last"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(79, 194)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Birthdate :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(95, 160)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 127)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Middle Name :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(68, 94)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 21)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "First Name :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(70, 61)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 21)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Last Name :"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button_Users_Update)
        Me.Panel1.Controls.Add(Me.Button_Users_Create)
        Me.Panel1.Location = New System.Drawing.Point(1043, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 434)
        Me.Panel1.TabIndex = 127
        '
        'Button_Users_Create
        '
        Me.Button_Users_Create.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Users_Create.Location = New System.Drawing.Point(31, 91)
        Me.Button_Users_Create.Name = "Button_Users_Create"
        Me.Button_Users_Create.Size = New System.Drawing.Size(173, 87)
        Me.Button_Users_Create.TabIndex = 2
        Me.Button_Users_Create.Text = "Create New User"
        Me.Button_Users_Create.UseVisualStyleBackColor = True
        '
        'Button_Users_Update
        '
        Me.Button_Users_Update.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Users_Update.Location = New System.Drawing.Point(31, 258)
        Me.Button_Users_Update.Name = "Button_Users_Update"
        Me.Button_Users_Update.Size = New System.Drawing.Size(173, 87)
        Me.Button_Users_Update.TabIndex = 3
        Me.Button_Users_Update.Text = "Update"
        Me.Button_Users_Update.UseVisualStyleBackColor = True
        '
        'Form_Management_User
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(1334, 497)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.ListView1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form_Management_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[User Management]"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtbox_Email As TextBox
    Friend WithEvents txtbox_Contact As TextBox
    Friend WithEvents txtbox_Address As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PickDate As DateTimePicker
    Friend WithEvents combox_Gender As ComboBox
    Friend WithEvents txtbox_Mname As TextBox
    Friend WithEvents txtbox_Fname As TextBox
    Friend WithEvents txtbox_Lname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_Users_Create As Button
    Friend WithEvents Button_Users_Update As Button
End Class
