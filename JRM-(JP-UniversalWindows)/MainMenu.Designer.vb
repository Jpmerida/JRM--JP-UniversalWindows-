<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_Checkin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_Exit
        '
        Me.btn_Exit.Font = New System.Drawing.Font("Minion Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.Location = New System.Drawing.Point(1186, 12)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(136, 53)
        Me.btn_Exit.TabIndex = 3
        Me.btn_Exit.Text = "LOG-OUT"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btn_Checkin
        '
        Me.btn_Checkin.Font = New System.Drawing.Font("Minion Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Checkin.Location = New System.Drawing.Point(12, 12)
        Me.btn_Checkin.Name = "btn_Checkin"
        Me.btn_Checkin.Size = New System.Drawing.Size(200, 53)
        Me.btn_Checkin.TabIndex = 4
        Me.btn_Checkin.Text = "CHECK-IN"
        Me.btn_Checkin.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1334, 711)
        Me.Controls.Add(Me.btn_Checkin)
        Me.Controls.Add(Me.btn_Exit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainMenu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Main Menu"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_Checkin As Button
End Class
