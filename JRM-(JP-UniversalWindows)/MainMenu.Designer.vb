<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.btn_SManage = New System.Windows.Forms.Button()
        Me.btn_GManage = New System.Windows.Forms.Button()
        Me.btn_UManage = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_SManage
        '
        Me.btn_SManage.Font = New System.Drawing.Font("Minion Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SManage.Location = New System.Drawing.Point(375, 29)
        Me.btn_SManage.Name = "btn_SManage"
        Me.btn_SManage.Size = New System.Drawing.Size(298, 53)
        Me.btn_SManage.TabIndex = 0
        Me.btn_SManage.Text = "Services Management"
        Me.btn_SManage.UseVisualStyleBackColor = True
        '
        'btn_GManage
        '
        Me.btn_GManage.Font = New System.Drawing.Font("Minion Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_GManage.Location = New System.Drawing.Point(679, 29)
        Me.btn_GManage.Name = "btn_GManage"
        Me.btn_GManage.Size = New System.Drawing.Size(298, 53)
        Me.btn_GManage.TabIndex = 1
        Me.btn_GManage.Text = "Guest Management"
        Me.btn_GManage.UseVisualStyleBackColor = True
        '
        'btn_UManage
        '
        Me.btn_UManage.Font = New System.Drawing.Font("Minion Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UManage.Location = New System.Drawing.Point(71, 29)
        Me.btn_UManage.Name = "btn_UManage"
        Me.btn_UManage.Size = New System.Drawing.Size(298, 53)
        Me.btn_UManage.TabIndex = 2
        Me.btn_UManage.Text = "User Management"
        Me.btn_UManage.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Font = New System.Drawing.Font("Minion Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.Location = New System.Drawing.Point(1218, 703)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(136, 53)
        Me.btn_Exit.TabIndex = 3
        Me.btn_Exit.Text = "EXIT"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_UManage)
        Me.Controls.Add(Me.btn_GManage)
        Me.Controls.Add(Me.btn_SManage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_SManage As Button
    Friend WithEvents btn_GManage As Button
    Friend WithEvents btn_UManage As Button
    Friend WithEvents btn_Exit As Button
End Class
