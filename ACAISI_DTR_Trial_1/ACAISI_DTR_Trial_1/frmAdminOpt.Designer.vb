<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminOpt
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAdminHeader = New System.Windows.Forms.Label()
        Me.btnAdminLog = New System.Windows.Forms.Button()
        Me.btnAdminMenu = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.lblAdminHeader)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(287, 52)
        Me.Panel1.TabIndex = 0
        '
        'lblAdminHeader
        '
        Me.lblAdminHeader.AutoSize = True
        Me.lblAdminHeader.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminHeader.ForeColor = System.Drawing.Color.White
        Me.lblAdminHeader.Location = New System.Drawing.Point(4, 12)
        Me.lblAdminHeader.Name = "lblAdminHeader"
        Me.lblAdminHeader.Size = New System.Drawing.Size(199, 28)
        Me.lblAdminHeader.TabIndex = 0
        Me.lblAdminHeader.Text = "ADMINISTRATOR"
        '
        'btnAdminLog
        '
        Me.btnAdminLog.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminLog.Location = New System.Drawing.Point(76, 77)
        Me.btnAdminLog.Name = "btnAdminLog"
        Me.btnAdminLog.Size = New System.Drawing.Size(133, 35)
        Me.btnAdminLog.TabIndex = 1
        Me.btnAdminLog.Text = "&Time Log"
        Me.btnAdminLog.UseVisualStyleBackColor = True
        '
        'btnAdminMenu
        '
        Me.btnAdminMenu.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminMenu.Location = New System.Drawing.Point(76, 122)
        Me.btnAdminMenu.Name = "btnAdminMenu"
        Me.btnAdminMenu.Size = New System.Drawing.Size(133, 35)
        Me.btnAdminMenu.TabIndex = 2
        Me.btnAdminMenu.Text = "Admin &Menu"
        Me.btnAdminMenu.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(177, 182)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(98, 35)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "&Log-out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'frmAdminOpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(284, 225)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnAdminMenu)
        Me.Controls.Add(Me.btnAdminLog)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAdminOpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblAdminHeader As System.Windows.Forms.Label
    Friend WithEvents btnAdminLog As System.Windows.Forms.Button
    Friend WithEvents btnAdminMenu As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
