﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CreateNew_User
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
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(400, 202)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'PickDate
        '
        Me.PickDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickDate.Location = New System.Drawing.Point(132, 154)
        Me.PickDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PickDate.Name = "PickDate"
        Me.PickDate.Size = New System.Drawing.Size(254, 26)
        Me.PickDate.TabIndex = 9
        '
        'combox_Gender
        '
        Me.combox_Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combox_Gender.FormattingEnabled = True
        Me.combox_Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.combox_Gender.Location = New System.Drawing.Point(132, 123)
        Me.combox_Gender.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.combox_Gender.Name = "combox_Gender"
        Me.combox_Gender.Size = New System.Drawing.Size(110, 28)
        Me.combox_Gender.TabIndex = 8
        Me.combox_Gender.Text = "Male"
        '
        'txtbox_Mname
        '
        Me.txtbox_Mname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Mname.Location = New System.Drawing.Point(132, 93)
        Me.txtbox_Mname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbox_Mname.MaxLength = 1
        Me.txtbox_Mname.Name = "txtbox_Mname"
        Me.txtbox_Mname.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_Mname.TabIndex = 7
        Me.txtbox_Mname.Text = "Middle"
        '
        'txtbox_Fname
        '
        Me.txtbox_Fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Fname.Location = New System.Drawing.Point(132, 64)
        Me.txtbox_Fname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbox_Fname.MaxLength = 25
        Me.txtbox_Fname.Name = "txtbox_Fname"
        Me.txtbox_Fname.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_Fname.TabIndex = 6
        Me.txtbox_Fname.Text = "First"
        '
        'txtbox_Lname
        '
        Me.txtbox_Lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Lname.Location = New System.Drawing.Point(132, 35)
        Me.txtbox_Lname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbox_Lname.MaxLength = 15
        Me.txtbox_Lname.Name = "txtbox_Lname"
        Me.txtbox_Lname.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_Lname.TabIndex = 5
        Me.txtbox_Lname.Text = "Last"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 158)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Birthdate :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 125)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Middle Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
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
        Me.GroupBox2.Location = New System.Drawing.Point(9, 216)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(400, 140)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contact Information"
        '
        'txtbox_Email
        '
        Me.txtbox_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Email.Location = New System.Drawing.Point(132, 93)
        Me.txtbox_Email.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbox_Email.Name = "txtbox_Email"
        Me.txtbox_Email.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_Email.TabIndex = 7
        Me.txtbox_Email.Text = "Email"
        '
        'txtbox_Contact
        '
        Me.txtbox_Contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Contact.Location = New System.Drawing.Point(132, 64)
        Me.txtbox_Contact.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbox_Contact.Name = "txtbox_Contact"
        Me.txtbox_Contact.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_Contact.TabIndex = 6
        Me.txtbox_Contact.Text = "Contact"
        '
        'txtbox_Address
        '
        Me.txtbox_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Address.Location = New System.Drawing.Point(132, 35)
        Me.txtbox_Address.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbox_Address.Name = "txtbox_Address"
        Me.txtbox_Address.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_Address.TabIndex = 5
        Me.txtbox_Address.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(69, 96)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Email :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(44, 67)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Contact# :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(49, 37)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 20)
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
        Me.GroupBox3.Location = New System.Drawing.Point(414, 20)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(353, 256)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contact Information"
        '
        'combox_type
        '
        Me.combox_type.Enabled = False
        Me.combox_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combox_type.FormattingEnabled = True
        Me.combox_type.Items.AddRange(New Object() {"Staff", "Supervisor", "Manager"})
        Me.combox_type.Location = New System.Drawing.Point(79, 210)
        Me.combox_type.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.combox_type.Name = "combox_type"
        Me.combox_type.Size = New System.Drawing.Size(254, 28)
        Me.combox_type.TabIndex = 9
        Me.combox_type.Text = "Staff"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 187)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 20)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Account Type :"
        '
        'txtbox_CPassword
        '
        Me.txtbox_CPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_CPassword.Location = New System.Drawing.Point(79, 160)
        Me.txtbox_CPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbox_CPassword.MaxLength = 15
        Me.txtbox_CPassword.Name = "txtbox_CPassword"
        Me.txtbox_CPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_CPassword.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_CPassword.TabIndex = 7
        Me.txtbox_CPassword.Text = "Confirm Password"
        '
        'txtbox_Password
        '
        Me.txtbox_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Password.Location = New System.Drawing.Point(79, 110)
        Me.txtbox_Password.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbox_Password.MaxLength = 15
        Me.txtbox_Password.Name = "txtbox_Password"
        Me.txtbox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_Password.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_Password.TabIndex = 6
        Me.txtbox_Password.Text = "Password"
        '
        'txtbox_Username
        '
        Me.txtbox_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Username.Location = New System.Drawing.Point(79, 60)
        Me.txtbox_Username.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbox_Username.MaxLength = 15
        Me.txtbox_Username.Name = "txtbox_Username"
        Me.txtbox_Username.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_Username.TabIndex = 5
        Me.txtbox_Username.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 137)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Confirm Password :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 88)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Password :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 37)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Username :"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.Salmon
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(438, 298)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(97, 46)
        Me.btn_Cancel.TabIndex = 12
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_CreateAccount
        '
        Me.btn_CreateAccount.BackColor = System.Drawing.Color.SpringGreen
        Me.btn_CreateAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CreateAccount.Location = New System.Drawing.Point(539, 298)
        Me.btn_CreateAccount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_CreateAccount.Name = "btn_CreateAccount"
        Me.btn_CreateAccount.Size = New System.Drawing.Size(228, 46)
        Me.btn_CreateAccount.TabIndex = 13
        Me.btn_CreateAccount.Text = "Create New Account"
        Me.btn_CreateAccount.UseVisualStyleBackColor = False
        '
        'CreateNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 366)
        Me.Controls.Add(Me.btn_CreateAccount)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "CreateNewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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