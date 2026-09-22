<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnCut = New System.Windows.Forms.Button()
        Me.txtTextBox = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSuggestion = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.txtExportPath = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBSEG_Invoice = New System.Windows.Forms.TextBox()
        Me.txtWHT_AMT = New System.Windows.Forms.TextBox()
        Me.txtBSEG_VAT = New System.Windows.Forms.TextBox()
        Me.txtBSAK_PV = New System.Windows.Forms.TextBox()
        Me.txtBSEG_PV = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(220, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Process"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(451, 519)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(322, 519)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Connect with LogonControl"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(99, 12)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(68, 20)
        Me.txtUsername.TabIndex = 3
        Me.txtUsername.Text = "80006112"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(245, 12)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(68, 20)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.Text = "banana,07"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(417, 12)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(214, 20)
        Me.txtServer.TabIndex = 5
        'Me.txtServer.Text = "/H/10.163.251.11/S/3200"
        Me.txtServer.Text = "S4 HANA PRD (AWS Cloud)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "User : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(328, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Server : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnQuery)
        Me.GroupBox1.Controls.Add(Me.btnPaste)
        Me.GroupBox1.Controls.Add(Me.btnCopy)
        Me.GroupBox1.Controls.Add(Me.btnCut)
        Me.GroupBox1.Controls.Add(Me.txtTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 468)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 73)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cut / Copy / Paste"
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(32, 46)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(53, 24)
        Me.btnQuery.TabIndex = 4
        Me.btnQuery.Text = "Query"
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'btnPaste
        '
        Me.btnPaste.Location = New System.Drawing.Point(209, 46)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(53, 24)
        Me.btnPaste.TabIndex = 3
        Me.btnPaste.Text = "Paste"
        Me.btnPaste.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(150, 46)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(53, 24)
        Me.btnCopy.TabIndex = 2
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnCut
        '
        Me.btnCut.Location = New System.Drawing.Point(91, 46)
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(53, 24)
        Me.btnCut.TabIndex = 1
        Me.btnCut.Text = "Cut"
        Me.btnCut.UseVisualStyleBackColor = True
        '
        'txtTextBox
        '
        Me.txtTextBox.Location = New System.Drawing.Point(7, 19)
        Me.txtTextBox.Multiline = True
        Me.txtTextBox.Name = "txtTextBox"
        Me.txtTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtTextBox.Size = New System.Drawing.Size(255, 21)
        Me.txtTextBox.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(13, 173)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(299, 291)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(828, 517)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(53, 24)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Copy"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(322, 173)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(295, 291)
        Me.RichTextBox2.TabIndex = 12
        Me.RichTextBox2.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Start Date : "
        '
        'txtStartDate
        '
        Me.txtStartDate.Location = New System.Drawing.Point(99, 58)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(214, 20)
        Me.txtStartDate.TabIndex = 14
        Me.txtStartDate.Text = "2026.01.01"
        '
        'txtEndDate
        '
        Me.txtEndDate.Location = New System.Drawing.Point(417, 58)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(214, 20)
        Me.txtEndDate.TabIndex = 15
        Me.txtEndDate.Text = "2026.01.31"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(330, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "End Date : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(645, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 183)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ขั้นตอนการทำงาน"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(7, 67)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(150, 13)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "4. เช็คลำดับของ View ใน SAP "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "9. ส่งไฟล์ให้บัญชี"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(156, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "8. สั่งให้ Store Procedure ทำงาน"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "7. ดึงข้อมูลฐานภาษีเพื่อแก้ไข"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "6. ตรวจสอบ Suggestion ด้านล่าง"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "5. กดปุ่ม Process"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(249, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "3. Import ข้อมูลเข้า ตาราง tbPaymentDocument ก่อน"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "2. ใส่เงื่อนไข ในส่วน Start Date และ End Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "1. ต้องไม่มีการ Login SAP ค้างไว้"
        '
        'txtSuggestion
        '
        Me.txtSuggestion.Location = New System.Drawing.Point(645, 213)
        Me.txtSuggestion.Multiline = True
        Me.txtSuggestion.Name = "txtSuggestion"
        Me.txtSuggestion.Size = New System.Drawing.Size(308, 251)
        Me.txtSuggestion.TabIndex = 18
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(535, 520)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 21)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Test TryParse"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(762, 520)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(60, 21)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(635, 520)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(55, 21)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(696, 518)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(60, 23)
        Me.Button8.TabIndex = 21
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'txtExportPath
        '
        Me.txtExportPath.Location = New System.Drawing.Point(99, 35)
        Me.txtExportPath.Name = "txtExportPath"
        Me.txtExportPath.Size = New System.Drawing.Size(532, 20)
        Me.txtExportPath.TabIndex = 22
        Me.txtExportPath.Text = "D:\Account\GetFile\File"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Export Path : "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtBSEG_Invoice)
        Me.GroupBox3.Controls.Add(Me.txtWHT_AMT)
        Me.GroupBox3.Controls.Add(Me.txtBSEG_VAT)
        Me.GroupBox3.Controls.Add(Me.txtBSAK_PV)
        Me.GroupBox3.Controls.Add(Me.txtBSEG_PV)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(14, 84)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(617, 49)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "View in SAP (Index of view เริ่มต้นที่ 0)"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(209, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "BSEG_VAT"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(317, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 13)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "WHT_AMT"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(426, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "BSEG_Invoice"
        '
        'txtBSEG_Invoice
        '
        Me.txtBSEG_Invoice.Location = New System.Drawing.Point(507, 20)
        Me.txtBSEG_Invoice.Name = "txtBSEG_Invoice"
        Me.txtBSEG_Invoice.Size = New System.Drawing.Size(34, 20)
        Me.txtBSEG_Invoice.TabIndex = 15
        Me.txtBSEG_Invoice.Text = "19"
        '
        'txtWHT_AMT
        '
        Me.txtWHT_AMT.Location = New System.Drawing.Point(386, 20)
        Me.txtWHT_AMT.Name = "txtWHT_AMT"
        Me.txtWHT_AMT.Size = New System.Drawing.Size(34, 20)
        Me.txtWHT_AMT.TabIndex = 15
        Me.txtWHT_AMT.Text = "1"
        '
        'txtBSEG_VAT
        '
        Me.txtBSEG_VAT.Location = New System.Drawing.Point(276, 20)
        Me.txtBSEG_VAT.Name = "txtBSEG_VAT"
        Me.txtBSEG_VAT.Size = New System.Drawing.Size(34, 20)
        Me.txtBSEG_VAT.TabIndex = 15
        Me.txtBSEG_VAT.Text = "21"
        '
        'txtBSAK_PV
        '
        Me.txtBSAK_PV.Location = New System.Drawing.Point(171, 20)
        Me.txtBSAK_PV.Name = "txtBSAK_PV"
        Me.txtBSAK_PV.Size = New System.Drawing.Size(34, 20)
        Me.txtBSAK_PV.TabIndex = 15
        Me.txtBSAK_PV.Text = "2"
        '
        'txtBSEG_PV
        '
        Me.txtBSEG_PV.Location = New System.Drawing.Point(68, 20)
        Me.txtBSEG_PV.Name = "txtBSEG_PV"
        Me.txtBSEG_PV.Size = New System.Drawing.Size(34, 20)
        Me.txtBSEG_PV.TabIndex = 15
        Me.txtBSEG_PV.Text = "20"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(111, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "BSAK_PV"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "BSEG_PV"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(642, 193)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 13)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Suggestion : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 470)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtExportPath)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtSuggestion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEndDate)
        Me.Controls.Add(Me.txtStartDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAP Export Data to Bank V 2.0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnCut As System.Windows.Forms.Button
    Friend WithEvents txtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnPaste As System.Windows.Forms.Button
    Friend WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents txtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSuggestion As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents txtExportPath As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtBSEG_Invoice As System.Windows.Forms.TextBox
    Friend WithEvents txtWHT_AMT As System.Windows.Forms.TextBox
    Friend WithEvents txtBSEG_VAT As System.Windows.Forms.TextBox
    Friend WithEvents txtBSAK_PV As System.Windows.Forms.TextBox
    Friend WithEvents txtBSEG_PV As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label

End Class
