<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewServices
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
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cboCatname = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRoomno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboLStatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOperable = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCatType = New System.Windows.Forms.TextBox()
        Me.txtCatID = New System.Windows.Forms.TextBox()
        Me.txtname2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(338, 363)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 41)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(444, 363)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 41)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtname2)
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
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 319)
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
        Me.cboSize.Location = New System.Drawing.Point(206, 221)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(82, 33)
        Me.cboSize.TabIndex = 5
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.LightGray
        Me.txtDesc.Enabled = False
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtDesc.Location = New System.Drawing.Point(206, 260)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(300, 33)
        Me.txtDesc.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.LightGray
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtPrice.Location = New System.Drawing.Point(206, 143)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(186, 33)
        Me.txtPrice.TabIndex = 4
        '
        'cboCatname
        '
        Me.cboCatname.BackColor = System.Drawing.Color.LightGray
        Me.cboCatname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cboCatname.FormattingEnabled = True
        Me.cboCatname.Items.AddRange(New Object() {"101", "105"})
        Me.cboCatname.Location = New System.Drawing.Point(206, 182)
        Me.cboCatname.Name = "cboCatname"
        Me.cboCatname.Size = New System.Drawing.Size(241, 33)
        Me.cboCatname.TabIndex = 3
        Me.cboCatname.Text = "101 - Cottage"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(66, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 25)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Description :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(134, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 25)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Size :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(127, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 25)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Price :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(33, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Category Type :"
        '
        'txtRoomno
        '
        Me.txtRoomno.BackColor = System.Drawing.Color.LightGray
        Me.txtRoomno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtRoomno.Location = New System.Drawing.Point(206, 65)
        Me.txtRoomno.Name = "txtRoomno"
        Me.txtRoomno.Size = New System.Drawing.Size(186, 31)
        Me.txtRoomno.TabIndex = 1
        Me.txtRoomno.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(142, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 25)
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
        Me.cboLStatus.Location = New System.Drawing.Point(206, 104)
        Me.cboLStatus.Name = "cboLStatus"
        Me.cboLStatus.Size = New System.Drawing.Size(241, 33)
        Me.cboLStatus.TabIndex = 2
        Me.cboLStatus.Text = "Available"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(25, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 25)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Location Status :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Location Name :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(760, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 24)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(741, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 24)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Description"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(560, 262)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(456, 29)
        Me.TextBox1.TabIndex = 65
        Me.TextBox1.Text = "Description"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(640, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 24)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Operable"
        '
        'txtOperable
        '
        Me.txtOperable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperable.Location = New System.Drawing.Point(597, 199)
        Me.txtOperable.Name = "txtOperable"
        Me.txtOperable.Size = New System.Drawing.Size(170, 29)
        Me.txtOperable.TabIndex = 63
        Me.txtOperable.Text = "Available"
        Me.txtOperable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(864, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 24)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Price"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(791, 199)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 29)
        Me.TextBox2.TabIndex = 61
        Me.TextBox2.Text = "Price"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(630, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 24)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Category ID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(816, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 24)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Category Type"
        '
        'txtCatType
        '
        Me.txtCatType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatType.Location = New System.Drawing.Point(791, 136)
        Me.txtCatType.Name = "txtCatType"
        Me.txtCatType.Size = New System.Drawing.Size(192, 29)
        Me.txtCatType.TabIndex = 58
        Me.txtCatType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCatID
        '
        Me.txtCatID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatID.Location = New System.Drawing.Point(597, 136)
        Me.txtCatID.Name = "txtCatID"
        Me.txtCatID.Size = New System.Drawing.Size(170, 29)
        Me.txtCatID.TabIndex = 57
        Me.txtCatID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtname2
        '
        Me.txtname2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname2.Location = New System.Drawing.Point(222, 26)
        Me.txtname2.Name = "txtname2"
        Me.txtname2.Size = New System.Drawing.Size(170, 29)
        Me.txtname2.TabIndex = 69
        Me.txtname2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CreateNewServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 414)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtOperable)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCatType)
        Me.Controls.Add(Me.txtCatID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "CreateNewServices"
        Me.Text = "New_Services"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtOperable As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCatType As TextBox
    Friend WithEvents txtCatID As TextBox
    Friend WithEvents txtname2 As TextBox
End Class
