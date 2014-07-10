<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlAdminTop = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.tabReports = New System.Windows.Forms.TabPage()
        Me.tabEmployees = New System.Windows.Forms.TabPage()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.tabAdminOpt = New System.Windows.Forms.TabControl()
        Me.panMenuBar = New System.Windows.Forms.Panel()
        Me.btnDeleteEmp = New System.Windows.Forms.Button()
        Me.btnEditEmp = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.TblEmployeesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlAdminTop.SuspendLayout()
        Me.tabEmployees.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAdminOpt.SuspendLayout()
        Me.panMenuBar.SuspendLayout()
        CType(Me.TblEmployeesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlAdminTop
        '
        Me.pnlAdminTop.BackColor = System.Drawing.Color.Maroon
        Me.pnlAdminTop.Controls.Add(Me.btnLogout)
        Me.pnlAdminTop.Controls.Add(Me.lblWelcome)
        Me.pnlAdminTop.Location = New System.Drawing.Point(1, 1)
        Me.pnlAdminTop.Name = "pnlAdminTop"
        Me.pnlAdminTop.Size = New System.Drawing.Size(1209, 47)
        Me.pnlAdminTop.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(1109, 8)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(90, 33)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "L&og-out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(958, 16)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(136, 18)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome Admin!"
        '
        'tabReports
        '
        Me.tabReports.BackColor = System.Drawing.Color.Gainsboro
        Me.tabReports.Location = New System.Drawing.Point(4, 25)
        Me.tabReports.Name = "tabReports"
        Me.tabReports.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReports.Size = New System.Drawing.Size(1200, 553)
        Me.tabReports.TabIndex = 1
        Me.tabReports.Text = "TIME LOG"
        '
        'tabEmployees
        '
        Me.tabEmployees.BackColor = System.Drawing.Color.DarkGray
        Me.tabEmployees.Controls.Add(Me.panMenuBar)
        Me.tabEmployees.Controls.Add(Me.dgvData)
        Me.tabEmployees.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabEmployees.Location = New System.Drawing.Point(4, 25)
        Me.tabEmployees.Name = "tabEmployees"
        Me.tabEmployees.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEmployees.Size = New System.Drawing.Size(1200, 553)
        Me.tabEmployees.TabIndex = 0
        Me.tabEmployees.Text = "EMPLOYEES"
        '
        'dgvData
        '
        Me.dgvData.AllowUserToOrderColumns = True
        Me.dgvData.AutoGenerateColumns = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.DataSource = Me.TblEmployeesBindingSource1
        Me.dgvData.Location = New System.Drawing.Point(3, 44)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(1194, 506)
        Me.dgvData.TabIndex = 0
        '
        'tabAdminOpt
        '
        Me.tabAdminOpt.Controls.Add(Me.tabEmployees)
        Me.tabAdminOpt.Controls.Add(Me.tabReports)
        Me.tabAdminOpt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAdminOpt.Location = New System.Drawing.Point(2, 49)
        Me.tabAdminOpt.Name = "tabAdminOpt"
        Me.tabAdminOpt.SelectedIndex = 0
        Me.tabAdminOpt.Size = New System.Drawing.Size(1208, 582)
        Me.tabAdminOpt.TabIndex = 1
        '
        'panMenuBar
        '
        Me.panMenuBar.BackColor = System.Drawing.Color.Gainsboro
        Me.panMenuBar.Controls.Add(Me.btnDeleteEmp)
        Me.panMenuBar.Controls.Add(Me.btnEditEmp)
        Me.panMenuBar.Controls.Add(Me.btnAddEmp)
        Me.panMenuBar.Location = New System.Drawing.Point(3, 2)
        Me.panMenuBar.Name = "panMenuBar"
        Me.panMenuBar.Size = New System.Drawing.Size(1194, 36)
        Me.panMenuBar.TabIndex = 1
        '
        'btnDeleteEmp
        '
        Me.btnDeleteEmp.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Delete
        Me.btnDeleteEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteEmp.Location = New System.Drawing.Point(81, 1)
        Me.btnDeleteEmp.Name = "btnDeleteEmp"
        Me.btnDeleteEmp.Size = New System.Drawing.Size(34, 34)
        Me.btnDeleteEmp.TabIndex = 2
        Me.btnDeleteEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteEmp.UseVisualStyleBackColor = True
        '
        'btnEditEmp
        '
        Me.btnEditEmp.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.document_edit
        Me.btnEditEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditEmp.Location = New System.Drawing.Point(42, 1)
        Me.btnEditEmp.Name = "btnEditEmp"
        Me.btnEditEmp.Size = New System.Drawing.Size(34, 34)
        Me.btnEditEmp.TabIndex = 1
        Me.btnEditEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditEmp.UseVisualStyleBackColor = True
        '
        'btnAddEmp
        '
        Me.btnAddEmp.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.add
        Me.btnAddEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddEmp.Location = New System.Drawing.Point(3, 1)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(34, 34)
        Me.btnAddEmp.TabIndex = 0
        Me.btnAddEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddEmp.UseVisualStyleBackColor = True
        '
        'frmAdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1211, 632)
        Me.Controls.Add(Me.tabAdminOpt)
        Me.Controls.Add(Me.pnlAdminTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAdminMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrators Log-in"
        Me.pnlAdminTop.ResumeLayout(False)
        Me.pnlAdminTop.PerformLayout()
        Me.tabEmployees.ResumeLayout(False)
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAdminOpt.ResumeLayout(False)
        Me.panMenuBar.ResumeLayout(False)
        CType(Me.TblEmployeesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAdminTop As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents tabReports As System.Windows.Forms.TabPage
    Friend WithEvents tabEmployees As System.Windows.Forms.TabPage
    Friend WithEvents TblEmployeesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents tabAdminOpt As System.Windows.Forms.TabControl
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddEmp As System.Windows.Forms.Button
    Friend WithEvents panMenuBar As System.Windows.Forms.Panel
    Friend WithEvents btnEditEmp As System.Windows.Forms.Button
    Friend WithEvents btnDeleteEmp As System.Windows.Forms.Button
End Class
