﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Update_CategoryType
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCatType = New System.Windows.Forms.TextBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCatDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCatNum = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Small", "Medium", "Large", "FunctionHall"})
        Me.ComboBox1.Location = New System.Drawing.Point(338, 111)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(213, 32)
        Me.ComboBox1.TabIndex = 87
        Me.ComboBox1.Text = "Small"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(208, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(189, 24)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Category Name/Type"
        '
        'txtCatType
        '
        Me.txtCatType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatType.Location = New System.Drawing.Point(50, 41)
        Me.txtCatType.Name = "txtCatType"
        Me.txtCatType.Size = New System.Drawing.Size(502, 29)
        Me.txtCatType.TabIndex = 85
        Me.txtCatType.Text = "Category Name"
        '
        'cmdCancel
        '
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdCancel.Location = New System.Drawing.Point(10, 299)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(101, 52)
        Me.cmdCancel.TabIndex = 84
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdUpdate.Location = New System.Drawing.Point(489, 299)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(101, 52)
        Me.cmdUpdate.TabIndex = 83
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(250, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 24)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Description"
        '
        'txtCatDesc
        '
        Me.txtCatDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatDesc.Location = New System.Drawing.Point(50, 178)
        Me.txtCatDesc.Name = "txtCatDesc"
        Me.txtCatDesc.Size = New System.Drawing.Size(502, 29)
        Me.txtCatDesc.TabIndex = 81
        Me.txtCatDesc.Text = "Category Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(417, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 24)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Size"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(60, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 24)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Recommended Person"
        '
        'txtCatNum
        '
        Me.txtCatNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatNum.Location = New System.Drawing.Point(50, 111)
        Me.txtCatNum.Name = "txtCatNum"
        Me.txtCatNum.Size = New System.Drawing.Size(213, 29)
        Me.txtCatNum.TabIndex = 78
        Me.txtCatNum.Text = "1-99 +*"
        '
        'Form_Update_CategoryType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCatType)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCatDesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCatNum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form_Update_CategoryType"
        Me.Text = "UpdateCategoryType"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCatType As TextBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCatDesc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCatNum As TextBox
End Class
