<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Services
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cboCatname = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRoomno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboLStatus = New System.Windows.Forms.ComboBox()
        Me.txtLocationname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(450, 447)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 50)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(592, 447)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 50)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.cboSize)
        Me.GroupBox1.Controls.Add(Me.txtDesc)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.cboCatname)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRoomno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboLStatus)
        Me.GroupBox1.Controls.Add(Me.txtLocationname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(712, 393)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'cboSize
        '
        Me.cboSize.BackColor = System.Drawing.Color.LightGray
        Me.cboSize.Enabled = False
        Me.cboSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cboSize.Location = New System.Drawing.Point(275, 272)
        Me.cboSize.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(108, 38)
        Me.cboSize.TabIndex = 5
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.LightGray
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtPrice.Location = New System.Drawing.Point(275, 176)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(247, 40)
        Me.txtPrice.TabIndex = 4
        '
        'cboCatname
        '
        Me.cboCatname.BackColor = System.Drawing.Color.LightGray
        Me.cboCatname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cboCatname.FormattingEnabled = True
        Me.cboCatname.Items.AddRange(New Object() {"101", "105"})
        Me.cboCatname.Location = New System.Drawing.Point(275, 224)
        Me.cboCatname.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCatname.Name = "cboCatname"
        Me.cboCatname.Size = New System.Drawing.Size(320, 38)
        Me.cboCatname.TabIndex = 3
        Me.cboCatname.Text = "101 - Cottage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(179, 275)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 31)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Size :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(169, 179)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 31)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Price :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(44, 227)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 31)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Category Type :"
        '
        'txtRoomno
        '
        Me.txtRoomno.BackColor = System.Drawing.Color.LightGray
        Me.txtRoomno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtRoomno.Location = New System.Drawing.Point(275, 80)
        Me.txtRoomno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRoomno.Name = "txtRoomno"
        Me.txtRoomno.Size = New System.Drawing.Size(247, 37)
        Me.txtRoomno.TabIndex = 1
        Me.txtRoomno.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(190, 83)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 31)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "No. :"
        Me.Label3.Visible = False
        '
        'cboLStatus
        '
        Me.cboLStatus.BackColor = System.Drawing.Color.LightGray
        Me.cboLStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cboLStatus.FormattingEnabled = True
        Me.cboLStatus.Items.AddRange(New Object() {"Available", "N/A", "Reserve", "Maintenance"})
        Me.cboLStatus.Location = New System.Drawing.Point(275, 128)
        Me.cboLStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cboLStatus.Name = "cboLStatus"
        Me.cboLStatus.Size = New System.Drawing.Size(320, 38)
        Me.cboLStatus.TabIndex = 2
        Me.cboLStatus.Text = "Available"
        '
        'txtLocationname
        '
        Me.txtLocationname.BackColor = System.Drawing.Color.LightGray
        Me.txtLocationname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocationname.Location = New System.Drawing.Point(275, 32)
        Me.txtLocationname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLocationname.Multiline = True
        Me.txtLocationname.Name = "txtLocationname"
        Me.txtLocationname.Size = New System.Drawing.Size(399, 40)
        Me.txtLocationname.TabIndex = 0
        Me.txtLocationname.Text = "name here"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(33, 131)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 31)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Location Status :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 31)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Location Name :"
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.LightGray
        Me.txtDesc.Enabled = False
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtDesc.Location = New System.Drawing.Point(275, 320)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(399, 40)
        Me.txtDesc.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(88, 323)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 31)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Description :"
        '
        'New_Services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 510)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "New_Services"
        Me.Text = "New_Services"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboSize As ComboBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cboCatname As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRoomno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboLStatus As ComboBox
    Friend WithEvents txtLocationname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label7 As Label
End Class
