<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEmployee
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
        Me.lblEmpInfoWind = New System.Windows.Forms.Label()
        Me.lblEmpNo = New System.Windows.Forms.Label()
        Me.txtEmpNum = New System.Windows.Forms.TextBox()
        Me.lbltkNo = New System.Windows.Forms.Label()
        Me.txtTkNo = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTPicker = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbRemarks = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtDesPass = New System.Windows.Forms.TextBox()
        Me.lblDesPass = New System.Windows.Forms.Label()
        Me.txtConPass = New System.Windows.Forms.TextBox()
        Me.lblConPass = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbAccess = New System.Windows.Forms.ComboBox()
        Me.lblPIN = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAddPic = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtSss = New System.Windows.Forms.MaskedTextBox()
        Me.txtTin = New System.Windows.Forms.MaskedTextBox()
        Me.txtPHealth = New System.Windows.Forms.MaskedTextBox()
        Me.txtPagibig = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.lblEmpInfoWind)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(857, 61)
        Me.Panel1.TabIndex = 0
        '
        'lblEmpInfoWind
        '
        Me.lblEmpInfoWind.AutoSize = True
        Me.lblEmpInfoWind.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpInfoWind.Location = New System.Drawing.Point(11, 16)
        Me.lblEmpInfoWind.Name = "lblEmpInfoWind"
        Me.lblEmpInfoWind.Size = New System.Drawing.Size(188, 28)
        Me.lblEmpInfoWind.TabIndex = 0
        Me.lblEmpInfoWind.Text = "ADD EMPLOYEE"
        '
        'lblEmpNo
        '
        Me.lblEmpNo.AutoSize = True
        Me.lblEmpNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpNo.Location = New System.Drawing.Point(189, 82)
        Me.lblEmpNo.Name = "lblEmpNo"
        Me.lblEmpNo.Size = New System.Drawing.Size(135, 17)
        Me.lblEmpNo.TabIndex = 1
        Me.lblEmpNo.Text = "Employee Number :"
        '
        'txtEmpNum
        '
        Me.txtEmpNum.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpNum.Location = New System.Drawing.Point(324, 76)
        Me.txtEmpNum.MaxLength = 3
        Me.txtEmpNum.Name = "txtEmpNum"
        Me.txtEmpNum.Size = New System.Drawing.Size(127, 22)
        Me.txtEmpNum.TabIndex = 1
        '
        'lbltkNo
        '
        Me.lbltkNo.AutoSize = True
        Me.lbltkNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltkNo.Location = New System.Drawing.Point(465, 81)
        Me.lbltkNo.Name = "lbltkNo"
        Me.lbltkNo.Size = New System.Drawing.Size(153, 17)
        Me.lbltkNo.TabIndex = 3
        Me.lbltkNo.Text = "Timekeeping Number :"
        '
        'txtTkNo
        '
        Me.txtTkNo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTkNo.Location = New System.Drawing.Point(618, 76)
        Me.txtTkNo.MaxLength = 4
        Me.txtTkNo.Name = "txtTkNo"
        Me.txtTkNo.Size = New System.Drawing.Size(121, 22)
        Me.txtTkNo.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(189, 113)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(56, 17)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name :"
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(251, 110)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(150, 22)
        Me.txtlname.TabIndex = 3
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(409, 110)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(176, 22)
        Me.txtfname.TabIndex = 4
        '
        'txtmname
        '
        Me.txtmname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.Location = New System.Drawing.Point(595, 110)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(144, 22)
        Me.txtmname.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(308, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Last"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(478, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "First"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(644, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Middle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(190, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Position :"
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition.Location = New System.Drawing.Point(256, 160)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(174, 22)
        Me.txtPosition.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(445, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Birthdate :"
        '
        'DTPicker
        '
        Me.DTPicker.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPicker.Location = New System.Drawing.Point(520, 160)
        Me.DTPicker.Name = "DTPicker"
        Me.DTPicker.Size = New System.Drawing.Size(219, 22)
        Me.DTPicker.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(190, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "SSS No. :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(465, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "TIN No. :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(190, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Philhealth :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(465, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Pag-Ibig No. :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(189, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Employee Type :"
        '
        'cmbRemarks
        '
        Me.cmbRemarks.AllowDrop = True
        Me.cmbRemarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbRemarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRemarks.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRemarks.FormattingEnabled = True
        Me.cmbRemarks.Items.AddRange(New Object() {"Regular", "Contractual", "Probationary", "Special Project", "OJT"})
        Me.cmbRemarks.Location = New System.Drawing.Point(303, 258)
        Me.cmbRemarks.Name = "cmbRemarks"
        Me.cmbRemarks.Size = New System.Drawing.Size(189, 25)
        Me.cmbRemarks.TabIndex = 12
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(449, 410)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 33)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(545, 410)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(90, 33)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(641, 410)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 33)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(748, 452)
        Me.ShapeContainer1.TabIndex = 23
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 8
        Me.LineShape1.X2 = 738
        Me.LineShape1.Y1 = 294
        Me.LineShape1.Y2 = 293
        '
        'txtDesPass
        '
        Me.txtDesPass.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesPass.Location = New System.Drawing.Point(143, 340)
        Me.txtDesPass.MaxLength = 12
        Me.txtDesPass.Name = "txtDesPass"
        Me.txtDesPass.Size = New System.Drawing.Size(184, 22)
        Me.txtDesPass.TabIndex = 14
        Me.txtDesPass.UseSystemPasswordChar = True
        '
        'lblDesPass
        '
        Me.lblDesPass.AutoSize = True
        Me.lblDesPass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesPass.Location = New System.Drawing.Point(6, 343)
        Me.lblDesPass.Name = "lblDesPass"
        Me.lblDesPass.Size = New System.Drawing.Size(128, 17)
        Me.lblDesPass.TabIndex = 25
        Me.lblDesPass.Text = "Desired Password :"
        '
        'txtConPass
        '
        Me.txtConPass.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConPass.Location = New System.Drawing.Point(143, 368)
        Me.txtConPass.MaxLength = 12
        Me.txtConPass.Name = "txtConPass"
        Me.txtConPass.Size = New System.Drawing.Size(184, 22)
        Me.txtConPass.TabIndex = 15
        Me.txtConPass.UseSystemPasswordChar = True
        '
        'lblConPass
        '
        Me.lblConPass.AutoSize = True
        Me.lblConPass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConPass.Location = New System.Drawing.Point(6, 371)
        Me.lblConPass.Name = "lblConPass"
        Me.lblConPass.Size = New System.Drawing.Size(133, 17)
        Me.lblConPass.TabIndex = 27
        Me.lblConPass.Text = "Confirm Password :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 312)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 17)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Access Level :"
        '
        'cmbAccess
        '
        Me.cmbAccess.AllowDrop = True
        Me.cmbAccess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAccess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAccess.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccess.FormattingEnabled = True
        Me.cmbAccess.Items.AddRange(New Object() {"Administrator", "Employee"})
        Me.cmbAccess.Location = New System.Drawing.Point(108, 306)
        Me.cmbAccess.Name = "cmbAccess"
        Me.cmbAccess.Size = New System.Drawing.Size(219, 25)
        Me.cmbAccess.TabIndex = 13
        '
        'lblPIN
        '
        Me.lblPIN.AutoSize = True
        Me.lblPIN.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPIN.Location = New System.Drawing.Point(569, 335)
        Me.lblPIN.Name = "lblPIN"
        Me.lblPIN.Size = New System.Drawing.Size(104, 56)
        Me.lblPIN.TabIndex = 30
        Me.lblPIN.Text = "----"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(450, 357)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 17)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "PIN Number :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(11, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'btnAddPic
        '
        Me.btnAddPic.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPic.Location = New System.Drawing.Point(11, 231)
        Me.btnAddPic.Name = "btnAddPic"
        Me.btnAddPic.Size = New System.Drawing.Size(155, 33)
        Me.btnAddPic.TabIndex = 33
        Me.btnAddPic.Text = "&Upload Photo"
        Me.btnAddPic.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(13, 269)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(149, 20)
        Me.txtFileName.TabIndex = 34
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(448, 304)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(126, 33)
        Me.btnGenerate.TabIndex = 16
        Me.btnGenerate.Text = "&Generate PIN"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'txtSss
        '
        Me.txtSss.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSss.Location = New System.Drawing.Point(256, 195)
        Me.txtSss.Mask = "00-0000000-0"
        Me.txtSss.Name = "txtSss"
        Me.txtSss.Size = New System.Drawing.Size(174, 22)
        Me.txtSss.TabIndex = 8
        '
        'txtTin
        '
        Me.txtTin.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTin.Location = New System.Drawing.Point(530, 195)
        Me.txtTin.Mask = "000-000-000-000"
        Me.txtTin.Name = "txtTin"
        Me.txtTin.Size = New System.Drawing.Size(209, 22)
        Me.txtTin.TabIndex = 9
        '
        'txtPHealth
        '
        Me.txtPHealth.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHealth.Location = New System.Drawing.Point(272, 227)
        Me.txtPHealth.Mask = "00-000000000-0"
        Me.txtPHealth.Name = "txtPHealth"
        Me.txtPHealth.Size = New System.Drawing.Size(158, 22)
        Me.txtPHealth.TabIndex = 10
        '
        'txtPagibig
        '
        Me.txtPagibig.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagibig.Location = New System.Drawing.Point(565, 225)
        Me.txtPagibig.Mask = "0000-0000-0000"
        Me.txtPagibig.Name = "txtPagibig"
        Me.txtPagibig.Size = New System.Drawing.Size(174, 22)
        Me.txtPagibig.TabIndex = 11
        '
        'frmAddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 452)
        Me.Controls.Add(Me.txtPagibig)
        Me.Controls.Add(Me.txtPHealth)
        Me.Controls.Add(Me.txtTin)
        Me.Controls.Add(Me.txtSss)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.btnAddPic)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblPIN)
        Me.Controls.Add(Me.cmbAccess)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtConPass)
        Me.Controls.Add(Me.lblConPass)
        Me.Controls.Add(Me.txtDesPass)
        Me.Controls.Add(Me.lblDesPass)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbRemarks)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DTPicker)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtTkNo)
        Me.Controls.Add(Me.lbltkNo)
        Me.Controls.Add(Me.txtEmpNum)
        Me.Controls.Add(Me.lblEmpNo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAddEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblEmpInfoWind As System.Windows.Forms.Label
    Friend WithEvents lblEmpNo As System.Windows.Forms.Label
    Friend WithEvents txtEmpNum As System.Windows.Forms.TextBox
    Friend WithEvents lbltkNo As System.Windows.Forms.Label
    Friend WithEvents txtTkNo As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbRemarks As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtDesPass As System.Windows.Forms.TextBox
    Friend WithEvents lblDesPass As System.Windows.Forms.Label
    Friend WithEvents txtConPass As System.Windows.Forms.TextBox
    Friend WithEvents lblConPass As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbAccess As System.Windows.Forms.ComboBox
    Friend WithEvents lblPIN As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddPic As System.Windows.Forms.Button
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents txtSss As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPHealth As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPagibig As System.Windows.Forms.MaskedTextBox
End Class
