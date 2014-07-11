<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoggedIn
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
        Me.btnPmOut = New System.Windows.Forms.Button()
        Me.btnPmIn = New System.Windows.Forms.Button()
        Me.btnLunOut = New System.Windows.Forms.Button()
        Me.btnLunIn = New System.Windows.Forms.Button()
        Me.btnAmOut = New System.Windows.Forms.Button()
        Me.btnAmIn = New System.Windows.Forms.Button()
        Me.btnTimeOut = New System.Windows.Forms.Button()
        Me.btnTimeIn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPmOut
        '
        Me.btnPmOut.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPmOut.Location = New System.Drawing.Point(146, 158)
        Me.btnPmOut.Name = "btnPmOut"
        Me.btnPmOut.Size = New System.Drawing.Size(96, 35)
        Me.btnPmOut.TabIndex = 17
        Me.btnPmOut.TabStop = False
        Me.btnPmOut.Text = "PM - OUT"
        Me.btnPmOut.UseVisualStyleBackColor = True
        '
        'btnPmIn
        '
        Me.btnPmIn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPmIn.Location = New System.Drawing.Point(43, 158)
        Me.btnPmIn.Name = "btnPmIn"
        Me.btnPmIn.Size = New System.Drawing.Size(96, 35)
        Me.btnPmIn.TabIndex = 16
        Me.btnPmIn.TabStop = False
        Me.btnPmIn.Text = "PM - IN"
        Me.btnPmIn.UseVisualStyleBackColor = True
        '
        'btnLunOut
        '
        Me.btnLunOut.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLunOut.Location = New System.Drawing.Point(146, 114)
        Me.btnLunOut.Name = "btnLunOut"
        Me.btnLunOut.Size = New System.Drawing.Size(96, 35)
        Me.btnLunOut.TabIndex = 15
        Me.btnLunOut.TabStop = False
        Me.btnLunOut.Text = "LUN - OUT"
        Me.btnLunOut.UseVisualStyleBackColor = True
        '
        'btnLunIn
        '
        Me.btnLunIn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLunIn.Location = New System.Drawing.Point(43, 114)
        Me.btnLunIn.Name = "btnLunIn"
        Me.btnLunIn.Size = New System.Drawing.Size(96, 35)
        Me.btnLunIn.TabIndex = 14
        Me.btnLunIn.TabStop = False
        Me.btnLunIn.Text = "LUN - IN"
        Me.btnLunIn.UseVisualStyleBackColor = True
        '
        'btnAmOut
        '
        Me.btnAmOut.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAmOut.Location = New System.Drawing.Point(146, 70)
        Me.btnAmOut.Name = "btnAmOut"
        Me.btnAmOut.Size = New System.Drawing.Size(96, 35)
        Me.btnAmOut.TabIndex = 13
        Me.btnAmOut.TabStop = False
        Me.btnAmOut.Text = "AM - OUT"
        Me.btnAmOut.UseVisualStyleBackColor = True
        '
        'btnAmIn
        '
        Me.btnAmIn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAmIn.Location = New System.Drawing.Point(43, 70)
        Me.btnAmIn.Name = "btnAmIn"
        Me.btnAmIn.Size = New System.Drawing.Size(96, 35)
        Me.btnAmIn.TabIndex = 12
        Me.btnAmIn.TabStop = False
        Me.btnAmIn.Text = "AM - IN"
        Me.btnAmIn.UseVisualStyleBackColor = True
        '
        'btnTimeOut
        '
        Me.btnTimeOut.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeOut.Location = New System.Drawing.Point(85, 211)
        Me.btnTimeOut.Name = "btnTimeOut"
        Me.btnTimeOut.Size = New System.Drawing.Size(115, 35)
        Me.btnTimeOut.TabIndex = 11
        Me.btnTimeOut.TabStop = False
        Me.btnTimeOut.Text = "TIME OUT"
        Me.btnTimeOut.UseVisualStyleBackColor = True
        '
        'btnTimeIn
        '
        Me.btnTimeIn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeIn.Location = New System.Drawing.Point(85, 16)
        Me.btnTimeIn.Name = "btnTimeIn"
        Me.btnTimeIn.Size = New System.Drawing.Size(115, 35)
        Me.btnTimeIn.TabIndex = 10
        Me.btnTimeIn.TabStop = False
        Me.btnTimeIn.Text = "TIME IN"
        Me.btnTimeIn.UseVisualStyleBackColor = True
        '
        'frmLoggedIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPmOut)
        Me.Controls.Add(Me.btnPmIn)
        Me.Controls.Add(Me.btnLunOut)
        Me.Controls.Add(Me.btnLunIn)
        Me.Controls.Add(Me.btnAmOut)
        Me.Controls.Add(Me.btnAmIn)
        Me.Controls.Add(Me.btnTimeOut)
        Me.Controls.Add(Me.btnTimeIn)
        Me.Name = "frmLoggedIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Log-In"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPmOut As System.Windows.Forms.Button
    Friend WithEvents btnPmIn As System.Windows.Forms.Button
    Friend WithEvents btnLunOut As System.Windows.Forms.Button
    Friend WithEvents btnLunIn As System.Windows.Forms.Button
    Friend WithEvents btnAmOut As System.Windows.Forms.Button
    Friend WithEvents btnAmIn As System.Windows.Forms.Button
    Friend WithEvents btnTimeOut As System.Windows.Forms.Button
    Friend WithEvents btnTimeIn As System.Windows.Forms.Button
End Class
