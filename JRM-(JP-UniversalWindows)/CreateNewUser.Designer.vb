<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewUser
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PickDate = New System.Windows.Forms.DateTimePicker()
        Me.combox_Gender = New System.Windows.Forms.ComboBox()
        Me.txtbox_Mname = New System.Windows.Forms.TextBox()
        Me.txtbox_Fname = New System.Windows.Forms.TextBox()
        Me.txtbox_Lname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtbox_Email = New System.Windows.Forms.TextBox()
        Me.txtbox_Contact = New System.Windows.Forms.TextBox()
        Me.txtbox_Address = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.combox_type = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtbox_CPassword = New System.Windows.Forms.TextBox()
        Me.txtbox_Password = New System.Windows.Forms.TextBox()
        Me.txtbox_Username = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_CreateAccount = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 248)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'PickDate
        '
        Me.PickDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickDate.Location = New System.Drawing.Point(176, 190)
        Me.PickDate.Name = "PickDate"
        Me.PickDate.Size = New System.Drawing.Size(338, 30)
        Me.PickDate.TabIndex = 9
        '
        'combox_Gender
        '
        Me.combox_Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combox_Gender.FormattingEnabled = True
        Me.combox_Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.combox_Gender.Location = New System.Drawing.Point(176, 151)
        Me.combox_Gender.Name = "combox_Gender"
        Me.combox_Gender.Size = New System.Drawing.Size(145, 33)
        Me.combox_Gender.TabIndex = 8
        Me.combox_Gender.Text = "Male"
        '
        'txtbox_Mname
        '
        Me.txtbox_Mname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Mname.Location = New System.Drawing.Point(176, 115)
        Me.txtbox_Mname.Name = "txtbox_Mname"
        Me.txtbox_Mname.Size = New System.Drawing.Size(338, 30)
        Me.txtbox_Mname.TabIndex = 7
        Me.txtbox_Mname.Text = "Middle"
        '
        'txtbox_Fname
        '
        Me.txtbox_Fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Fname.Location = New System.Drawing.Point(176, 79)
        Me.txtbox_Fname.Name = "txtbox_Fname"
        Me.txtbox_Fname.Size = New System.Drawing.Size(338, 30)
        Me.txtbox_Fname.TabIndex = 6
        Me.txtbox_Fname.Text = "First"
        '
        'txtbox_Lname
        '
        Me.txtbox_Lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Lname.Location = New System.Drawing.Point(176, 43)
        Me.txtbox_Lname.Name = "txtbox_Lname"
        Me.txtbox_Lname.Size = New System.Drawing.Size(338, 30)
        Me.txtbox_Lname.TabIndex = 5
        Me.txtbox_Lname.Text = "Last"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Birthdate :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Middle Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Last Name :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtbox_Email)
        Me.GroupBox2.Controls.Add(Me.txtbox_Contact)
        Me.GroupBox2.Controls.Add(Me.txtbox_Address)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 266)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(534, 172)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contact Information"
        '
        'txtbox_Email
        '
        Me.txtbox_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Email.Location = New System.Drawing.Point(176, 115)
        Me.txtbox_Email.Name = "txtbox_Email"
        Me.txtbox_Email.Size = New System.Drawing.Size(338, 30)
        Me.txtbox_Email.TabIndex = 7
        Me.txtbox_Email.Text = "Email"
        '
        'txtbox_Contact
        '
        Me.txtbox_Contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Contact.Location = New System.Drawing.Point(176, 79)
        Me.txtbox_Contact.Name = "txtbox_Contact"
        Me.txtbox_Contact.Size = New System.Drawing.Size(338, 30)
        Me.txtbox_Contact.TabIndex = 6
        Me.txtbox_Contact.Text = "Contact"
        '
        'txtbox_Address
        '
        Me.txtbox_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Address.Location = New System.Drawing.Point(176, 43)
        Me.txtbox_Address.Name = "txtbox_Address"
        Me.txtbox_Address.Size = New System.Drawing.Size(338, 30)
        Me.txtbox_Address.TabIndex = 5
        Me.txtbox_Address.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(92, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 25)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Email :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(58, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 25)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Contact# :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(65, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Address :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.combox_type)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtbox_CPassword)
        Me.GroupBox3.Controls.Add(Me.txtbox_Password)
        Me.GroupBox3.Controls.Add(Me.txtbox_Username)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(552, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(471, 315)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contact Information"
        '
        'combox_type
        '
        Me.combox_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combox_type.FormattingEnabled = True
        Me.combox_type.Items.AddRange(New Object() {"Staff", "Supervisor", "Manager"})
        Me.combox_type.Location = New System.Drawing.Point(105, 258)
        Me.combox_type.Name = "combox_type"
        Me.combox_type.Size = New System.Drawing.Size(338, 33)
        Me.combox_type.TabIndex = 9
        Me.combox_type.Text = "Staff"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(27, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 25)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Account Type :"
        '
        'txtbox_CPassword
        '
        Me.txtbox_CPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_CPassword.Location = New System.Drawing.Point(105, 197)
        Me.txtbox_CPassword.Name = "txtbox_CPassword"
        Me.txtbox_CPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_CPassword.Size = New System.Drawing.Size(338, 30)
        Me.txtbox_CPassword.TabIndex = 7
        Me.txtbox_CPassword.Text = "Confirm Password"
        '
        'txtbox_Password
        '
        Me.txtbox_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Password.Location = New System.Drawing.Point(105, 136)
        Me.txtbox_Password.Name = "txtbox_Password"
        Me.txtbox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_Password.Size = New System.Drawing.Size(338, 30)
        Me.txtbox_Password.TabIndex = 6
        Me.txtbox_Password.Text = "Password"
        '
        'txtbox_Username
        '
        Me.txtbox_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Username.Location = New System.Drawing.Point(105, 74)
        Me.txtbox_Username.Name = "txtbox_Username"
        Me.txtbox_Username.Size = New System.Drawing.Size(338, 30)
        Me.txtbox_Username.TabIndex = 5
        Me.txtbox_Username.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 25)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Confirm Password :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Password :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(27, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 25)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Username :"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(584, 367)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(129, 56)
        Me.btn_Cancel.TabIndex = 12
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_CreateAccount
        '
        Me.btn_CreateAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CreateAccount.Location = New System.Drawing.Point(762, 367)
        Me.btn_CreateAccount.Name = "btn_CreateAccount"
        Me.btn_CreateAccount.Size = New System.Drawing.Size(261, 56)
        Me.btn_CreateAccount.TabIndex = 13
        Me.btn_CreateAccount.Text = "Create New Account"
        Me.btn_CreateAccount.UseVisualStyleBackColor = True
        '
        'CreateNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 451)
        Me.Controls.Add(Me.btn_CreateAccount)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CreateNewUser"
        Me.Text = "CreateNewUser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PickDate As DateTimePicker
    Friend WithEvents combox_Gender As ComboBox
    Friend WithEvents txtbox_Mname As TextBox
    Friend WithEvents txtbox_Fname As TextBox
    Friend WithEvents txtbox_Lname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtbox_Email As TextBox
    Friend WithEvents txtbox_Contact As TextBox
    Friend WithEvents txtbox_Address As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents combox_type As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtbox_CPassword As TextBox
    Friend WithEvents txtbox_Password As TextBox
    Friend WithEvents txtbox_Username As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_CreateAccount As Button
End Class
