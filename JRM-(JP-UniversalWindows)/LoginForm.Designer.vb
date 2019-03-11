<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.txtbox_Username = New System.Windows.Forms.TextBox()
        Me.txtbox_Password = New System.Windows.Forms.TextBox()
        Me.txtLink_CreateUser = New System.Windows.Forms.LinkLabel()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtbox_Username
        '
        Me.txtbox_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Username.Location = New System.Drawing.Point(265, 153)
        Me.txtbox_Username.Name = "txtbox_Username"
        Me.txtbox_Username.Size = New System.Drawing.Size(255, 41)
        Me.txtbox_Username.TabIndex = 0
        Me.txtbox_Username.Text = "Username"
        '
        'txtbox_Password
        '
        Me.txtbox_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Password.Location = New System.Drawing.Point(265, 200)
        Me.txtbox_Password.Name = "txtbox_Password"
        Me.txtbox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_Password.Size = New System.Drawing.Size(255, 41)
        Me.txtbox_Password.TabIndex = 1
        Me.txtbox_Password.Text = "Password"
        '
        'txtLink_CreateUser
        '
        Me.txtLink_CreateUser.AutoSize = True
        Me.txtLink_CreateUser.Location = New System.Drawing.Point(40, 383)
        Me.txtLink_CreateUser.Name = "txtLink_CreateUser"
        Me.txtLink_CreateUser.Size = New System.Drawing.Size(115, 17)
        Me.txtLink_CreateUser.TabIndex = 2
        Me.txtLink_CreateUser.TabStop = True
        Me.txtLink_CreateUser.Text = "Create New User"
        '
        'btn_Login
        '
        Me.btn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Login.Location = New System.Drawing.Point(594, 338)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(126, 62)
        Me.btn_Login.TabIndex = 3
        Me.btn_Login.Text = "LOGIN"
        Me.btn_Login.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.txtLink_CreateUser)
        Me.Controls.Add(Me.txtbox_Password)
        Me.Controls.Add(Me.txtbox_Username)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbox_Username As TextBox
    Friend WithEvents txtbox_Password As TextBox
    Friend WithEvents txtLink_CreateUser As LinkLabel
    Friend WithEvents btn_Login As Button
End Class
