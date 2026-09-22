Imports System.Data.SqlClient
Imports System.Data
Imports System.IO


Public Class Form1
    Dim clsDBUtil As New DBUtil

    Dim sapID As String
    Dim sapPassword As String
    Dim sapServer As String
    Dim sapCon As Object
    Dim sapSession As Object
    Dim sap As Object
    Dim fs As Object
    Dim fs_file As Object
    Dim fname As String
    'In SAP need config disable scripting about notify

    'Private Function ConnectSAP() As Boolean

    '    Try
    '        'อ่านข้อมูลจากหน้าจอ
    '        sapID = txtUsername.Text.Trim()
    '        sapPassword = txtPassword.Text
    '        sapServer = txtServer.Text.Trim()

    '        'ตรวจสอบชื่อ SAP Logon Entry
    '        If sapServer = "" Then
    '            MsgBox("กรุณาระบุชื่อ SAP Server")
    '            Return False
    '        End If

    '        'เชื่อมต่อกับ SAP GUI ที่เปิดอยู่
    '        Dim SapGuiAuto As Object = GetObject("SAPGUI")

    '        'เรียกใช้งาน SAP GUI Scripting Engine
    '        Dim sapApplication As Object =
    '        SapGuiAuto.GetScriptingEngine

    '        'เปิด SAP Connection จากชื่อใน SAP Logon
    '        sapCon = sapApplication.OpenConnection(
    '        sapServer,
    '        True
    '    )

    '        'ตรวจสอบว่าเชื่อมต่อสำเร็จหรือไม่
    '        If sapCon Is Nothing Then
    '            MsgBox("ไม่สามารถเปิด SAP Connection ได้")
    '            Return False
    '        End If

    '        'ตรวจสอบว่ามี SAP Session หรือไม่
    '        If sapCon.Children.Count = 0 Then
    '            MsgBox("ไม่พบ SAP Session")
    '            Return False
    '        End If

    '        'เก็บ Session ไว้ใช้งาน
    '        sapSession = sapCon.Children(0)

    '        Return True

    '    Catch ex As Exception

    '        MsgBox(
    '        "ไม่สามารถเชื่อมต่อ SAP ได้" &
    '        vbCrLf &
    '        vbCrLf &
    '        ex.Message
    '    )

    '        Return False

    '    End Try

    'End Function
    'Private Function ConnectSAP() As Boolean

    '    Try

    '        '==================================================
    '        ' 1. อ่านข้อมูลจากหน้าจอ
    '        '==================================================
    '        sapID = txtUsername.Text.Trim()
    '        sapPassword = txtPassword.Text
    '        sapServer = txtServer.Text.Trim()

    '        If sapServer.Trim() = "" Then
    '            MsgBox("กรุณาระบุชื่อ SAP Server")
    '            Return False
    '        End If


    '        '==================================================
    '        ' 2. เชื่อมต่อกับ SAP GUI ที่เปิดอยู่
    '        '==================================================
    '        Dim SapGuiAuto As Object = Nothing

    '        Try

    '            SapGuiAuto = GetObject("SAPGUI")

    '        Catch ex As Exception

    '            MsgBox(
    '            "ไม่พบ SAP GUI ที่กำลังเปิดอยู่" &
    '            vbCrLf & vbCrLf &
    '            "กรุณาเปิด SAP Logon ก่อน" &
    '            vbCrLf &
    '            "แล้วลองกดปุ่มใหม่อีกครั้ง" &
    '            vbCrLf & vbCrLf &
    '            "Error: " & ex.Message
    '        )

    '            Return False

    '        End Try


    '        If SapGuiAuto Is Nothing Then

    '            MsgBox("ไม่สามารถเรียก SAP GUI ได้")

    '            Return False

    '        End If


    '        '==================================================
    '        ' 3. เรียก SAP GUI Scripting Engine
    '        '==================================================
    '        Dim sapApplication As Object = Nothing

    '        Try

    '            sapApplication = SapGuiAuto.GetScriptingEngine

    '        Catch ex As Exception

    '            MsgBox(
    '            "ไม่สามารถเรียก SAP GUI Scripting Engine ได้" &
    '            vbCrLf & vbCrLf &
    '            "ให้ตรวจสอบว่า SAP GUI Scripting ถูกติดตั้งและเปิดใช้งานแล้ว" &
    '            vbCrLf & vbCrLf &
    '            "Error: " & ex.Message
    '        )

    '            Return False

    '        End Try


    '        If sapApplication Is Nothing Then

    '            MsgBox("SAP GUI Scripting Engine ไม่พร้อมใช้งาน")

    '            Return False

    '        End If


    '        '==================================================
    '        ' 4. เปิด SAP Connection
    '        '==================================================
    '        Try

    '            sapCon = sapApplication.OpenConnection(
    '            sapServer,
    '            True
    '        )

    '        Catch ex As Exception

    '            MsgBox(
    '            "ไม่สามารถเปิด SAP Connection ได้" &
    '            vbCrLf & vbCrLf &
    '            "ชื่อ SAP Server ที่ใส่คือ:" &
    '            vbCrLf &
    '            sapServer &
    '            vbCrLf & vbCrLf &
    '            "กรุณาตรวจสอบว่าชื่อนี้ตรงกับ SAP Logon Entry" &
    '            vbCrLf & vbCrLf &
    '            "Error: " & ex.Message
    '        )

    '            Return False

    '        End Try


    '        If sapCon Is Nothing Then

    '            MsgBox("SAP Connection เป็น Nothing")

    '            Return False

    '        End If


    '        '==================================================
    '        ' 5. รอ SAP Session
    '        '==================================================
    '        Dim waitCount As Integer = 0

    '        Do While sapCon.Children.Count = 0 AndAlso waitCount < 20

    '            System.Threading.Thread.Sleep(500)

    '            waitCount += 1

    '        Loop


    '        If sapCon.Children.Count = 0 Then

    '            MsgBox(
    '            "เปิด SAP Connection แล้ว แต่ไม่พบ SAP Session" &
    '            vbCrLf & vbCrLf &
    '            "กรุณาตรวจสอบว่าหน้า SAP Login เปิดขึ้นมาหรือไม่"
    '        )

    '            Return False

    '        End If


    '        '==================================================
    '        ' 6. เก็บ Session ไว้ใช้งาน
    '        '==================================================
    '        sapSession = sapCon.Children(0)


    '        If sapSession Is Nothing Then

    '            MsgBox("ไม่สามารถอ่าน SAP Session ได้")

    '            Return False

    '        End If


    '        Return True


    '    Catch ex As Exception

    '        MsgBox(
    '        "ไม่สามารถเชื่อมต่อ SAP ได้" &
    '        vbCrLf & vbCrLf &
    '        "Error: " &
    '        ex.Message
    '    )

    '        Return False

    '    End Try

    'End Function

    Private Function ConnectSAP() As Boolean

        Try

            '==================================================
            ' 1. อ่านข้อมูลจากหน้าจอ
            '==================================================
            sapID = txtUsername.Text.Trim()
            sapPassword = txtPassword.Text
            sapServer = txtServer.Text.Trim()

            If sapServer.Trim() = "" Then

                MsgBox("กรุณาระบุชื่อ SAP Server")

                Return False

            End If


            '==================================================
            ' 2. เชื่อมต่อกับ SAP GUI ที่เปิดอยู่
            '==================================================
            Dim SapGuiAuto As Object = Nothing

            Try

                SapGuiAuto = GetObject("SAPGUI")

            Catch ex As Exception

                MsgBox(
                "ไม่พบ SAP GUI ที่กำลังเปิดอยู่" &
                vbCrLf & vbCrLf &
                "กรุณาเปิด SAP Logon ก่อน" &
                vbCrLf &
                "แล้วลองกดปุ่มใหม่อีกครั้ง" &
                vbCrLf & vbCrLf &
                "Error: " & ex.Message
            )

                Return False

            End Try


            If SapGuiAuto Is Nothing Then

                MsgBox("ไม่สามารถเรียก SAP GUI ได้")

                Return False

            End If


            '==================================================
            ' 3. เรียก SAP GUI Scripting Engine
            '==================================================
            Dim sapApplication As Object = Nothing

            Try

                sapApplication = SapGuiAuto.GetScriptingEngine

            Catch ex As Exception

                MsgBox(
                "ไม่สามารถเรียก SAP GUI Scripting Engine ได้" &
                vbCrLf & vbCrLf &
                "ให้ตรวจสอบว่า SAP GUI Scripting ถูกติดตั้งและเปิดใช้งานแล้ว" &
                vbCrLf & vbCrLf &
                "Error: " & ex.Message
            )

                Return False

            End Try


            If sapApplication Is Nothing Then

                MsgBox("SAP GUI Scripting Engine ไม่พร้อมใช้งาน")

                Return False

            End If


            '==================================================
            ' 4. เปิด SAP Connection
            '==================================================
            Try

                sapCon = sapApplication.OpenConnection(
                sapServer,
                True
            )

            Catch ex As Exception

                MsgBox(
                "ไม่สามารถเปิด SAP Connection ได้" &
                vbCrLf & vbCrLf &
                "ชื่อ SAP Server ที่ใส่คือ:" &
                vbCrLf &
                sapServer &
                vbCrLf & vbCrLf &
                "กรุณาตรวจสอบว่าชื่อนี้ตรงกับ SAP Logon Entry" &
                vbCrLf & vbCrLf &
                "Error: " & ex.Message
            )

                Return False

            End Try


            If sapCon Is Nothing Then

                MsgBox("SAP Connection เป็น Nothing")

                Return False

            End If


            '==================================================
            ' 5. รอ SAP Session
            '==================================================
            Dim waitCount As Integer = 0

            Do While sapCon.Children.Count = 0 AndAlso waitCount < 20

                System.Threading.Thread.Sleep(500)

                waitCount += 1

            Loop


            If sapCon.Children.Count = 0 Then

                MsgBox(
                "เปิด SAP Connection แล้ว แต่ไม่พบ SAP Session" &
                vbCrLf & vbCrLf &
                "กรุณาตรวจสอบว่าหน้า SAP Login เปิดขึ้นมาหรือไม่"
            )

                Return False

            End If


            '==================================================
            ' 6. เก็บ Session
            '==================================================
            sapSession = sapCon.Children(0)


            If sapSession Is Nothing Then

                MsgBox("ไม่สามารถอ่าน SAP Session ได้")

                Return False

            End If


            Return True


        Catch ex As Exception

            MsgBox(
            "ไม่สามารถเชื่อมต่อ SAP ได้" &
            vbCrLf & vbCrLf &
            "Error: " &
            ex.Message
        )

            Return False

        End Try

    End Function

    Private Sub Write_log(ByVal linestr As String)
        fs_file.writeline(linestr)
    End Sub

    Private Sub Create_File()
        fs = CreateObject("Scripting.FileSystemObject")
        fname = My.Application.Info.DirectoryPath + "\Log" + Date.Now.ToString("yyyyMMddHHmmss") & ".csv"
        fs_file = fs.CreateTextFile(fname, True)
    End Sub


    Private Sub BSEG_Payment_Voucher()
        Try
            Dim TotalRow
            Dim DblValue As Double

            Dim ImportedFile As String
            Dim ImportedLines() As String
            Dim OneLine() As String
            Dim i As Integer

            Dim objConn As New SqlConnection
            Dim objCmd As New SqlCommand
            'Dim dtAdapter As SqlDataAdapter
            Dim dt As New DataTable
            Dim strSQL As String
            Dim intNumRows As Integer

            'save the current settings for easier restoration later
            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture

            'change the settings
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

            Dim Dateformat As String = "yyyyMMdd HH:mm:ss"

            'Dim FileConfigINI_mcode = Application.StartupPath + "\config.ini"

            objConn.ConnectionString = clsDBUtil.DBConnectStringSQLServer
            objConn.Open()

            With sapSession
                .findById("wnd[0]").maximize()
                .findById("wnd[0]/tbar[0]/okcd").text = "se16"
                .findById("wnd[0]").sendVKey(0)
                '.findById("wnd[0]/usr/ctxtZHTC_CLA-CLASS").text = "fi"
                '.findById("wnd[0]/usr/ctxtZHTC_CLA-CLASS").caretPosition = 2
                '.findById("wnd[0]").sendVKey(0)
                '.findById("wnd[0]/usr/tblZHTC_MENUREPREPORT").getAbsoluteRow(13).selected = True
                '.findById("wnd[0]/usr/tblZHTC_MENUREPREPORT/txtREP-ZNAME[0,13]").setFocus()
                '.findById("wnd[0]/usr/tblZHTC_MENUREPREPORT/txtREP-ZNAME[0,13]").caretPosition = 0
                '.findById("wnd[0]/tbar[1]/btn[8]").press()
                .findById("wnd[0]/usr/ctxtDATABROWSE-TABLENAME").text = "bseg"
                .findById("wnd[0]/usr/ctxtDATABROWSE-TABLENAME").caretPosition = 4
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/usr/ctxtI1-LOW").text = "9770"
                .findById("wnd[0]/usr/txtI2-LOW").setFocus()
                .findById("wnd[0]/usr/txtI2-LOW").caretPosition = 0
                .findById("wnd[0]/usr/btn%_I2_%_APP_%-VALU_PUSH").press()
                .findById("wnd[1]/tbar[0]/btn[24]").press()
                .findById("wnd[1]/tbar[0]/btn[8]").press()
                .findById("wnd[0]/usr/txtI3-LOW").text = Mid(txtStartDate.Text, 1, 4)
                .findById("wnd[0]/usr/txtI3-LOW").setFocus()
                .findById("wnd[0]/usr/txtI3-LOW").caretPosition = 4
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/usr/txtMAX_SEL").text = ""
                .findById("wnd[0]/usr/txtMAX_SEL").setFocus()
                .findById("wnd[0]/usr/txtMAX_SEL").caretPosition = 11
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/tbar[1]/btn[8]").press()

                .findById("wnd[0]/tbar[1]/btn[33]").press()
                .findById("wnd[1]/usr/subSUB_CONFIGURATION:SAPLSALV_CUL_LAYOUT_CHOOSE:0500/cntlD500_CONTAINER/shellcont/shell").currentCellRow = txtBSEG_PV.Text '3
                .findById("wnd[1]/usr/subSUB_CONFIGURATION:SAPLSALV_CUL_LAYOUT_CHOOSE:0500/cntlD500_CONTAINER/shellcont/shell").selectedRows = txtBSEG_PV.Text '"3"
                .findById("wnd[1]/usr/subSUB_CONFIGURATION:SAPLSALV_CUL_LAYOUT_CHOOSE:0500/cntlD500_CONTAINER/shellcont/shell").clickCurrentCell()
                .findById("wnd[0]/tbar[1]/btn[45]").press()
                .findById("wnd[1]/tbar[0]/btn[0]").press()
                .findById("wnd[1]/usr/ctxtDY_PATH").text = txtExportPath.Text
                '.findById("wnd[1]/usr/ctxtDY_PATH").text = Directory.GetCurrentDirectory()
                .findById("wnd[1]/usr/ctxtDY_FILENAME").text = "BSEG_Payment_Voucher.txt"
                '.findById("wnd[1]/usr/ctxtDY_FILENAME").caretPosition = 14
                .findById("wnd[1]").sendVKey(0)
                .findById("wnd[0]/tbar[1]/btn[8]").press()

                TotalRow = .FindById("wnd[0]/usr/cntlGRID1/shellcont/shell")
                'MsgBox(TotalRow.rowcount)


                'For sapRow = 0 To TotalRow.rowCount - 1

                '    strSQL = ""
                '    strSQL = "INSERT INTO BSEG_Payment_Voucher(Cl,CoCd,DocumentNo,Year,Itm,Clearing,ClgEntDate,Clrngdoc,PK,DC,WT,AmountinLC,Curr,Withhldtaxbase,GL,Customer,Vendor)"
                '    strSQL = strSQL & " VALUES("
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "MANDT")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUKRS")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BELNR")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "GJAHR")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUZEI")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGDT")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGCP")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGBL")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BSCHL")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "SHKZG")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "QSSKZ")) & "',"
                '    If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "DMBTR"), DblValue) Then
                '        strSQL = strSQL & DblValue & ","
                '    Else
                '        strSQL = strSQL & "0,"
                '    End If
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "PSWSL")) & "',"
                '    If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "QSSHB"), DblValue) Then
                '        strSQL = strSQL & DblValue & ","
                '    Else
                '        strSQL = strSQL & "0,"
                '    End If
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "HKONT")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "KUNNR")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "LIFNR")) & "'"
                '    strSQL = strSQL & ")"

                '    objCmd = New SqlCommand(strSQL, objConn)
                '    intNumRows = objCmd.ExecuteNonQuery()

                'Next
                .findById("wnd[0]").maximize()
                .findById("wnd[0]/tbar[0]/btn[15]").press()
                .findById("wnd[0]/tbar[0]/btn[15]").press()
                '.findById("wnd[0]/tbar[0]/btn[15]").press()
                '.findById("wnd[0]/tbar[0]/btn[15]").press()
                '.findById("wnd[0]/tbar[0]/btn[15]").press()
                '.findById("wnd[1]/usr/btnSPOP-OPTION1").press()

                If My.Computer.FileSystem.FileExists(txtExportPath.Text & "\BSEG_Payment_Voucher.txt") Then
                    ImportedFile = My.Computer.FileSystem.ReadAllText(txtExportPath.Text & "\BSEG_Payment_Voucher.txt")
                    ImportedLines = Strings.Split(ImportedFile, Environment.NewLine)
                    For i = 5 To ImportedLines.GetUpperBound(0)
                        OneLine = Strings.Split(ImportedLines(i), "|")
                        Console.WriteLine("Insert : BSEG_Payment_Voucher : OneLine :" & OneLine.GetUpperBound(0))
                        If OneLine.GetUpperBound(0) = 18 Then '18 คือจำนวน Fields หลังจากการแยกด้วย |
                            strSQL = ""
                            strSQL = "INSERT INTO BSEG_Payment_Voucher(Cl,CoCd,DocumentNo,Year,Itm,Clearing,ClgEntDate,Clrngdoc,PK,DC,WT,AmountinLC,Curr,Withhldtaxbase,GL,Customer,Vendor)"
                            strSQL = strSQL & " VALUES("
                            strSQL = strSQL & "'" & Trim(OneLine(1)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(2)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(3)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(4)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(5)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(6)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(7)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(8)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(9)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(10)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(11)) & "',"
                            If Double.TryParse(OneLine(12), DblValue) Then
                                strSQL = strSQL & DblValue & ","
                            Else
                                strSQL = strSQL & "0,"
                            End If
                            strSQL = strSQL & "'" & Trim(OneLine(13)) & "',"
                            If Double.TryParse(OneLine(14), DblValue) Then
                                strSQL = strSQL & DblValue & ","
                            Else
                                strSQL = strSQL & "0,"
                            End If
                            strSQL = strSQL & "'" & Trim(OneLine(15)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(16)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(17)) & "'"
                            strSQL = strSQL & ")"

                            objCmd = New SqlCommand(strSQL, objConn)
                            intNumRows = objCmd.ExecuteNonQuery()

                        Else
                            'MessageBox.Show("Wrong number of fields", "Notification", MessageBoxButtons.OK)
                        End If
                    Next
                Else
                    MessageBox.Show("No record found.", "Notification", MessageBoxButtons.OK)
                End If

                objConn.Close()
                objConn = Nothing

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BSEG_Payment_Voucher_WriteFile()
        Try
            Dim TotalRow
            Dim stt As String
            Dim DblValue As Double

            Dim objConn As New SqlConnection
            Dim objCmd As New SqlCommand
            'Dim dtAdapter As SqlDataAdapter
            Dim dt As New DataTable
            Dim strSQL As String
            Dim intNumRows As Integer

            'save the current settings for easier restoration later
            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture

            'change the settings
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

            Dim Dateformat As String = "yyyyMMdd HH:mm:ss"

            'Dim FileConfigINI_mcode = Application.StartupPath + "\config.ini"

            objConn.ConnectionString = clsDBUtil.DBConnectStringSQLServer
            objConn.Open()

            With sapSession
                .findById("wnd[0]").maximize()
                .findById("wnd[0]/tbar[0]/okcd").text = "zmenhtc"
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/usr/ctxtZHTC_CLA-CLASS").text = "fi"
                .findById("wnd[0]/usr/ctxtZHTC_CLA-CLASS").caretPosition = 2
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/usr/tblZHTC_MENUREPREPORT").getAbsoluteRow(13).selected = True
                .findById("wnd[0]/usr/tblZHTC_MENUREPREPORT/txtREP-ZNAME[0,13]").setFocus()
                .findById("wnd[0]/usr/tblZHTC_MENUREPREPORT/txtREP-ZNAME[0,13]").caretPosition = 0
                .findById("wnd[0]/tbar[1]/btn[8]").press()
                .findById("wnd[0]/usr/ctxtDATABROWSE-TABLENAME").text = "bseg"
                .findById("wnd[0]/usr/ctxtDATABROWSE-TABLENAME").caretPosition = 4
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/usr/ctxtI1-LOW").text = "9770"
                .findById("wnd[0]/usr/txtI2-LOW").setFocus()
                .findById("wnd[0]/usr/txtI2-LOW").caretPosition = 0
                .findById("wnd[0]/usr/btn%_I2_%_APP_%-VALU_PUSH").press()
                .findById("wnd[1]/tbar[0]/btn[24]").press()
                .findById("wnd[1]/tbar[0]/btn[8]").press()
                .findById("wnd[0]/usr/txtI3-LOW").text = Mid(txtStartDate.Text, 1, 4)
                .findById("wnd[0]/usr/txtI3-LOW").setFocus()
                .findById("wnd[0]/usr/txtI3-LOW").caretPosition = 4
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/usr/txtMAX_SEL").text = ""
                .findById("wnd[0]/usr/txtMAX_SEL").setFocus()
                .findById("wnd[0]/usr/txtMAX_SEL").caretPosition = 11
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/tbar[1]/btn[8]").press()

                TotalRow = .FindById("wnd[0]/usr/cntlGRID1/shellcont/shell")
                'MsgBox(TotalRow.rowcount)


                For sapRow = 0 To TotalRow.rowCount - 1

                    'stt = .findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUTXT")
                    'stt = TotalRow.GetCellValue(sapRow, "BUTXT")

                    stt = ""                   
                    stt = stt & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "MANDT")) & "',"
                    stt = stt & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUKRS")) & "',"
                    stt = stt & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BELNR")) & "',"
                    'stt = stt & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "GJAHR")) & "',"
                    'stt = stt & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUZEI")) & "',"
                    'stt = stt & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGDT")) & "',"
                    'stt = stt & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGCP")) & "',"
                    'stt = stt & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGBL")) & "',"
                    'stt = stt & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BSCHL")) & "',"
                    'stt = stt & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "SHKZG")) & "',"
                    'stt = stt & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "QSSKZ")) & "',"
                    'If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "DMBTR"), DblValue) Then
                    '    stt = stt & DblValue & ","
                    'Else
                    '    stt = stt & "0,"
                    'End If
                    'stt = stt & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "PSWSL")) & "',"
                    'If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "QSSHB"), DblValue) Then
                    '    stt = stt & DblValue & ","
                    'Else
                    '    stt = stt & "0,"
                    'End If
                    'stt = stt & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "HKONT")) & "',"
                    'stt = stt & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "KUNNR")) & "',"
                    stt = stt & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "LIFNR")) & "'"                    

                    Write_log(stt)


                    'strSQL = ""
                    'strSQL = "INSERT INTO BSEG_Payment_Voucher(Cl,CoCd,DocumentNo,Year,Itm,Clearing,ClgEntDate,Clrngdoc,PK,DC,WT,AmountinLC,Curr,Withhldtaxbase,GL,Customer,Vendor)"
                    'strSQL = strSQL & " VALUES("
                    'strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "MANDT")) & "',"
                    'strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUKRS")) & "',"
                    'strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BELNR")) & "',"
                    'strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "GJAHR")) & "',"
                    'strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUZEI")) & "',"
                    'strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGDT")) & "',"
                    'strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGCP")) & "',"
                    'strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGBL")) & "',"
                    'strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BSCHL")) & "',"
                    'strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "SHKZG")) & "',"
                    'strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "QSSKZ")) & "',"
                    'If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "DMBTR"), DblValue) Then
                    '    strSQL = strSQL & DblValue & ","
                    'Else
                    '    strSQL = strSQL & "0,"
                    'End If
                    'strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "PSWSL")) & "',"
                    'If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "QSSHB"), DblValue) Then
                    '    strSQL = strSQL & DblValue & ","
                    'Else
                    '    strSQL = strSQL & "0,"
                    'End If
                    'strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "HKONT")) & "',"
                    'strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "KUNNR")) & "',"
                    'strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "LIFNR")) & "'"
                    'strSQL = strSQL & ")"

                    'objCmd = New SqlCommand(strSQL, objConn)
                    'intNumRows = objCmd.ExecuteNonQuery()


                Next
                .findById("wnd[0]").maximize()
                .findById("wnd[0]/tbar[0]/btn[15]").press()
                .findById("wnd[0]/tbar[0]/btn[15]").press()
                '.findById("wnd[0]/tbar[0]/btn[15]").press()
                '.findById("wnd[0]/tbar[0]/btn[15]").press()
                '.findById("wnd[0]/tbar[0]/btn[15]").press()
                '.findById("wnd[1]/usr/btnSPOP-OPTION1").press()

                objConn.Close()
                objConn = Nothing

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BSEG_Payment_Voucher_Export()
        Try
            Dim TotalRow
            Dim DblValue As Double

            Dim objConn As New SqlConnection
            Dim objCmd As New SqlCommand
            'Dim dtAdapter As SqlDataAdapter
            Dim dt As New DataTable
            Dim strSQL As String
            Dim intNumRows As Integer

            'save the current settings for easier restoration later
            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture

            'change the settings
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

            Dim Dateformat As String = "yyyyMMdd HH:mm:ss"

            'Dim FileConfigINI_mcode = Application.StartupPath + "\config.ini"

            objConn.ConnectionString = clsDBUtil.DBConnectStringSQLServer
            objConn.Open()

            With sapSession
                .findById("wnd[0]").maximize()
                .findById("wnd[0]/tbar[0]/okcd").text = "zmenhtc"
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/usr/ctxtZHTC_CLA-CLASS").text = "fi"
                .findById("wnd[0]/usr/ctxtZHTC_CLA-CLASS").caretPosition = 2
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/usr/tblZHTC_MENUREPREPORT").getAbsoluteRow(13).selected = True
                .findById("wnd[0]/usr/tblZHTC_MENUREPREPORT/txtREP-ZNAME[0,13]").setFocus()
                .findById("wnd[0]/usr/tblZHTC_MENUREPREPORT/txtREP-ZNAME[0,13]").caretPosition = 0
                .findById("wnd[0]/tbar[1]/btn[8]").press()
                .findById("wnd[0]/usr/ctxtDATABROWSE-TABLENAME").text = "bseg"
                .findById("wnd[0]/usr/ctxtDATABROWSE-TABLENAME").caretPosition = 4
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/usr/ctxtI1-LOW").text = "9770"
                .findById("wnd[0]/usr/txtI2-LOW").setFocus()
                .findById("wnd[0]/usr/txtI2-LOW").caretPosition = 0
                .findById("wnd[0]/usr/btn%_I2_%_APP_%-VALU_PUSH").press()
                .findById("wnd[1]/tbar[0]/btn[24]").press()
                .findById("wnd[1]/tbar[0]/btn[8]").press()
                .findById("wnd[0]/usr/txtI3-LOW").text = "2019"
                .findById("wnd[0]/usr/txtI3-LOW").setFocus()
                .findById("wnd[0]/usr/txtI3-LOW").caretPosition = 4
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/usr/txtMAX_SEL").text = ""
                .findById("wnd[0]/usr/txtMAX_SEL").setFocus()
                .findById("wnd[0]/usr/txtMAX_SEL").caretPosition = 11
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/tbar[1]/btn[8]").press()
                .findById("wnd[0]/tbar[1]/btn[33]").press()
                .findById("wnd[1]/usr/ssubD0500_SUBSCREEN:SAPLSLVC_DIALOG:0501/cntlG51_CONTAINER/shellcont/shell").currentCellRow = 3
                .findById("wnd[1]/usr/ssubD0500_SUBSCREEN:SAPLSLVC_DIALOG:0501/cntlG51_CONTAINER/shellcont/shell").selectedRows = "3"
                .findById("wnd[1]/usr/ssubD0500_SUBSCREEN:SAPLSLVC_DIALOG:0501/cntlG51_CONTAINER/shellcont/shell").clickCurrentCell()
                .findById("wnd[0]/tbar[1]/btn[45]").press()
                ' ####### For Excel Format
                '.findById("wnd[1]/usr/subSUBSCREEN_STEPLOOP:SAPLSPO5:0150/sub:SAPLSPO5:0150/radSPOPLI-SELFLAG[1,0]").select()
                '.findById("wnd[1]/usr/subSUBSCREEN_STEPLOOP:SAPLSPO5:0150/sub:SAPLSPO5:0150/radSPOPLI-SELFLAG[1,0]").setFocus()
                ' ####### 
                .findById("wnd[1]/tbar[0]/btn[0]").press()
                .findById("wnd[1]/usr/ctxtDY_PATH").text = "C:\Users\ongart\Desktop\SAP VBA Connect"
                .findById("wnd[1]/usr/ctxtDY_FILENAME").text = "testexport.txt"
                .findById("wnd[1]/usr/ctxtDY_FILENAME").caretPosition = 14
                .findById("wnd[1]").sendVKey(0)
                .findById("wnd[0]/tbar[1]/btn[8]").press()

                TotalRow = .FindById("wnd[0]/usr/cntlGRID1/shellcont/shell")
                'MsgBox(TotalRow.rowcount)


                'For sapRow = 0 To TotalRow.rowCount - 1

                '    strSQL = ""
                '    strSQL = "INSERT INTO BSEG_Payment_Voucher(Cl,CoCd,DocumentNo,Year,Itm,Clearing,ClgEntDate,Clrngdoc,PK,DC,WT,AmountinLC,Curr,Withhldtaxbase,GL,Customer,Vendor)"
                '    strSQL = strSQL & " VALUES("
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "MANDT")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUKRS")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BELNR")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "GJAHR")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUZEI")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGDT")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGCP")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGBL")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BSCHL")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "SHKZG")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "QSSKZ")) & "',"
                '    If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "DMBTR"), DblValue) Then
                '        strSQL = strSQL & DblValue & ","
                '    Else
                '        strSQL = strSQL & "0,"
                '    End If
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "PSWSL")) & "',"
                '    If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "QSSHB"), DblValue) Then
                '        strSQL = strSQL & DblValue & ","
                '    Else
                '        strSQL = strSQL & "0,"
                '    End If
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "HKONT")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "KUNNR")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "LIFNR")) & "'"
                '    strSQL = strSQL & ")"

                '    objCmd = New SqlCommand(strSQL, objConn)
                '    intNumRows = objCmd.ExecuteNonQuery()

                'Next
                .findById("wnd[0]").maximize()
                .findById("wnd[0]/tbar[0]/btn[15]").press()
                .findById("wnd[0]/tbar[0]/btn[15]").press()
                '.findById("wnd[0]/tbar[0]/btn[15]").press()
                '.findById("wnd[0]/tbar[0]/btn[15]").press()
                '.findById("wnd[0]/tbar[0]/btn[15]").press()
                '.findById("wnd[1]/usr/btnSPOP-OPTION1").press()

                objConn.Close()
                objConn = Nothing

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BSAK_Payment_Voucher()
        Try
            Dim TotalRow
            Dim DblValue As Double

            Dim ImportedFile As String
            Dim ImportedLines() As String
            Dim OneLine() As String
            Dim i As Integer

            Dim objConn As New SqlConnection
            Dim objCmd As New SqlCommand
            'Dim dtAdapter As SqlDataAdapter
            Dim dt As New DataTable
            Dim strSQL As String
            Dim intNumRows As Integer

            'save the current settings for easier restoration later
            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture

            'change the settings
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

            Dim Dateformat As String = "yyyyMMdd HH:mm:ss"

            'Dim FileConfigINI_mcode = Application.StartupPath + "\config.ini"

            objConn.ConnectionString = clsDBUtil.DBConnectStringSQLServer
            objConn.Open()

            With sapSession
                .findById("wnd[0]").maximize()
                '.findById("wnd[0]/tbar[0]/okcd").text = "zmenhtc"
                '.findById("wnd[0]").sendVKey(0)
                '.findById("wnd[0]/usr/ctxtZHTC_CLA-CLASS").text = "fi"
                '.findById("wnd[0]/usr/ctxtZHTC_CLA-CLASS").caretPosition = 2
                '.findById("wnd[0]").sendVKey(0)
                '.findById("wnd[0]/usr/tblZHTC_MENUREPREPORT").getAbsoluteRow(13).selected = True
                '.findById("wnd[0]/usr/tblZHTC_MENUREPREPORT/txtREP-ZNAME[0,13]").setFocus()
                '.findById("wnd[0]/usr/tblZHTC_MENUREPREPORT/txtREP-ZNAME[0,13]").caretPosition = 0
                '.findById("wnd[0]/tbar[1]/btn[8]").press()
                .findById("wnd[0]/usr/ctxtDATABROWSE-TABLENAME").text = "bsak"
                .findById("wnd[0]/usr/ctxtDATABROWSE-TABLENAME").caretPosition = 4
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/usr/ctxtI1-LOW").text = "9770"
                .findById("wnd[0]/usr/ctxtI1-LOW").caretPosition = 4
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/usr/ctxtI5-LOW").text = txtStartDate.Text
                .findById("wnd[0]/usr/ctxtI5-HIGH").text = txtEndDate.Text
                .findById("wnd[0]/usr/ctxtI5-HIGH").setFocus()
                .findById("wnd[0]/usr/ctxtI5-HIGH").caretPosition = 10
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/usr/txtI6-LOW").setFocus()
                .findById("wnd[0]/usr/txtI6-LOW").caretPosition = 0
                .findById("wnd[0]/usr/btn%_I6_%_APP_%-VALU_PUSH").press()
                .findById("wnd[1]/tbar[0]/btn[24]").press()
                .findById("wnd[1]/tbar[0]/btn[8]").press()
                .findById("wnd[0]/usr/txtMAX_SEL").text = ""
                .findById("wnd[0]/usr/txtMAX_SEL").setFocus()
                .findById("wnd[0]/usr/txtMAX_SEL").caretPosition = 11
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/tbar[1]/btn[8]").press()

                .findById("wnd[0]/tbar[1]/btn[33]").press()
                .findById("wnd[1]/usr/subSUB_CONFIGURATION:SAPLSALV_CUL_LAYOUT_CHOOSE:0500/cntlD500_CONTAINER/shellcont/shell").currentCellRow = txtBSAK_PV.Text '1
                .findById("wnd[1]/usr/subSUB_CONFIGURATION:SAPLSALV_CUL_LAYOUT_CHOOSE:0500/cntlD500_CONTAINER/shellcont/shell").selectedRows = txtBSAK_PV.Text '"1"
                .findById("wnd[1]/usr/subSUB_CONFIGURATION:SAPLSALV_CUL_LAYOUT_CHOOSE:0500/cntlD500_CONTAINER/shellcont/shell").clickCurrentCell()
                .findById("wnd[0]/tbar[1]/btn[45]").press()
                .findById("wnd[1]/tbar[0]/btn[0]").press()
                .findById("wnd[1]/usr/ctxtDY_PATH").text = txtExportPath.Text
                '.findById("wnd[1]/usr/ctxtDY_PATH").text = Directory.GetCurrentDirectory()
                .findById("wnd[1]/usr/ctxtDY_FILENAME").text = "BSAK_Payment_Voucher.txt"
                '.findById("wnd[1]/usr/ctxtDY_FILENAME").caretPosition = 14
                .findById("wnd[1]").sendVKey(0)
                .findById("wnd[0]/tbar[1]/btn[8]").press()

                TotalRow = .FindById("wnd[0]/usr/cntlGRID1/shellcont/shell")
                'MsgBox(TotalRow.rowcount)


                'For sapRow = 0 To TotalRow.rowCount - 1

                '    strSQL = ""
                '    strSQL = "INSERT INTO BSAK_Payment_Voucher(Cl,CoCd,Vendor,Clearing,Clrngdoc,Year,DocumentNo,DocYear,Itm,PstngDate,DocDate,Crcy,Reference,DocType,Period,PK,DC,Tx,AmountinLC,GL,Discountbase,Withhldtaxbase,Withholdingtax)"
                '    strSQL = strSQL & " VALUES("
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "MANDT")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUKRS")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "LIFNR")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGDT")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGBL")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "GJAHR")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BELNR")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BELNR")) & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "GJAHR")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUZEI")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUDAT")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BLDAT")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "WAERS")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "XBLNR")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BLART")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "MONAT")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BSCHL")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "SHKZG")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "MWSKZ")) & "',"
                '    If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "DMBTR"), DblValue) Then
                '        strSQL = strSQL & DblValue & ","
                '    Else
                '        strSQL = strSQL & "0,"
                '    End If

                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "HKONT")) & "',"
                '    If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "SKFBT"), DblValue) Then
                '        strSQL = strSQL & DblValue & ","
                '    Else
                '        strSQL = strSQL & "0,"
                '    End If

                '    If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "QSSHB"), DblValue) Then
                '        strSQL = strSQL & DblValue & ","
                '    Else
                '        strSQL = strSQL & "0,"
                '    End If

                '    If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "QBSHB"), DblValue) Then
                '        strSQL = strSQL & DblValue & ""
                '    Else
                '        strSQL = strSQL & "0"
                '    End If

                '    strSQL = strSQL & ")"

                '    objCmd = New SqlCommand(strSQL, objConn)
                '    intNumRows = objCmd.ExecuteNonQuery()

                'Next
                .findById("wnd[0]").maximize()
                .findById("wnd[0]/tbar[0]/btn[15]").press()
                .findById("wnd[0]/tbar[0]/btn[15]").press()
                '.findById("wnd[0]/tbar[0]/btn[15]").press()
                '.findById("wnd[0]/tbar[0]/btn[15]").press()
                '.findById("wnd[0]/tbar[0]/btn[15]").press()
                '.findById("wnd[1]/usr/btnSPOP-OPTION1").press()

                If My.Computer.FileSystem.FileExists(txtExportPath.Text & "\BSAK_Payment_Voucher.txt") Then
                    ImportedFile = My.Computer.FileSystem.ReadAllText(txtExportPath.Text & "\BSAK_Payment_Voucher.txt")
                    ImportedLines = Strings.Split(ImportedFile, Environment.NewLine)
                    For i = 5 To ImportedLines.GetUpperBound(0)
                        OneLine = Strings.Split(ImportedLines(i), "|")
                        If OneLine.GetUpperBound(0) = 23 Then '23 คือจำนวน Fields หลังจากการแยกด้วย |			
                            strSQL = ""
                            strSQL = "INSERT INTO BSAK_Payment_Voucher(Cl,CoCd,Vendor,Clearing,Clrngdoc,Year,DocumentNo,DocYear,Itm,PstngDate,DocDate,Crcy,Reference,DocType,Period,PK,DC,Tx,AmountinLC,GL,Discountbase,Withhldtaxbase,Withholdingtax)"
                            strSQL = strSQL & " VALUES("
                            strSQL = strSQL & "'" & Trim(OneLine(1)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(2)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(3)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(4)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(5)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(6)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(7)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(7)) & "_" & Trim(OneLine(6)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(8)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(9)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(10)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(11)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(12)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(13)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(14)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(15)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(16)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(17)) & "',"
                            If Double.TryParse(OneLine(18), DblValue) Then
                                strSQL = strSQL & DblValue & ","
                            Else
                                strSQL = strSQL & "0,"
                            End If

                            strSQL = strSQL & "'" & Trim(OneLine(19)) & "',"
                            If Double.TryParse(OneLine(20), DblValue) Then
                                strSQL = strSQL & DblValue & ","
                            Else
                                strSQL = strSQL & "0,"
                            End If

                            If Double.TryParse(OneLine(21), DblValue) Then
                                strSQL = strSQL & DblValue & ","
                            Else
                                strSQL = strSQL & "0,"
                            End If

                            If Double.TryParse(OneLine(22), DblValue) Then
                                strSQL = strSQL & DblValue & ""
                            Else
                                strSQL = strSQL & "0"
                            End If

                            strSQL = strSQL & ")"

                            objCmd = New SqlCommand(strSQL, objConn)
                            intNumRows = objCmd.ExecuteNonQuery()
                        Else
                            'MessageBox.Show("Wrong number of fields", "Notification", MessageBoxButtons.OK)
                        End If
                    Next
                Else
                    MessageBox.Show("No record found.", "Notification", MessageBoxButtons.OK)
                End If


                objConn.Close()
                objConn = Nothing

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub WHT_Amt()
        Try
            Dim ImportedFile As String
            Dim ImportedLines() As String
            Dim OneLine() As String
            Dim i As Integer

            Dim TotalRow
            Dim DblValue As Double
            Dim objConn As New SqlConnection
            Dim objCmd As New SqlCommand
            Dim dt As New DataTable
            Dim strSQL As String
            Dim intNumRows As Integer

            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
            Dim Dateformat As String = "yyyyMMdd HH:mm:ss"

            objConn.ConnectionString = clsDBUtil.DBConnectStringSQLServer
            objConn.Open()

            'If Trim(Mid(txtStartDate.Text, 1, 4)) <> "2023" Then 'fix value first. because error from no data found

            With sapSession
                .findById("wnd[0]").maximize()
                .findById("wnd[0]/usr/ctxtDATABROWSE-TABLENAME").text = "WITH_ITEM"
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/usr/ctxtI1-LOW").text = "9770"
                .findById("wnd[0]/usr/ctxtI1-LOW").caretPosition = 4
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/usr/txtI2-LOW").setFocus()
                .findById("wnd[0]/usr/txtI2-LOW").caretPosition = 0
                .findById("wnd[0]/usr/btn%_I2_%_APP_%-VALU_PUSH").press()
                .findById("wnd[1]/tbar[0]/btn[24]").press()
                .findById("wnd[1]/tbar[0]/btn[8]").press()
                .findById("wnd[0]/usr/txtI3-LOW").text = Mid(txtStartDate.Text, 1, 4)
                .findById("wnd[0]/usr/txtI3-LOW").setFocus()
                .findById("wnd[0]/usr/txtI3-LOW").caretPosition = 4
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/usr/txtMAX_SEL").text = ""
                .findById("wnd[0]/usr/txtMAX_SEL").setFocus()
                .findById("wnd[0]/usr/txtMAX_SEL").caretPosition = 11
                .findById("wnd[0]").sendVKey(0)
                .findById("wnd[0]/tbar[1]/btn[8]").press()

                .findById("wnd[0]/tbar[1]/btn[33]").press()
                .findById("wnd[1]/usr/subSUB_CONFIGURATION:SAPLSALV_CUL_LAYOUT_CHOOSE:0500/cntlD500_CONTAINER/shellcont/shell").currentCellRow = txtWHT_AMT.Text '9
                .findById("wnd[1]/usr/subSUB_CONFIGURATION:SAPLSALV_CUL_LAYOUT_CHOOSE:0500/cntlD500_CONTAINER/shellcont/shell").selectedRows = txtWHT_AMT.Text '"9"
                .findById("wnd[1]/usr/subSUB_CONFIGURATION:SAPLSALV_CUL_LAYOUT_CHOOSE:0500/cntlD500_CONTAINER/shellcont/shell").clickCurrentCell()
                .findById("wnd[0]/tbar[1]/btn[45]").press()
                .findById("wnd[1]/tbar[0]/btn[0]").press()
                .findById("wnd[1]/usr/ctxtDY_PATH").text = txtExportPath.Text
                '.findById("wnd[1]/usr/ctxtDY_PATH").text = Directory.GetCurrentDirectory()
                .findById("wnd[1]/usr/ctxtDY_FILENAME").text = "WHT_Amt.txt"
                '.findById("wnd[1]/usr/ctxtDY_FILENAME").caretPosition = 14
                .findById("wnd[1]").sendVKey(0)
                .findById("wnd[0]/tbar[1]/btn[8]").press()

                TotalRow = .FindById("wnd[0]/usr/cntlGRID1/shellcont/shell")
                'MsgBox(TotalRow.rowcount)


                'For sapRow = 0 To TotalRow.rowCount - 1

                '    strSQL = ""
                '    strSQL = "INSERT INTO WHT_Amt(Cl,CoCd,DocumentNo,Year,Itm,Withhldtaxtype,Wtaxbat,Withholdingtaxamnt,AccTy,VCaccnt,GL,Recty,Clrngdoc,Clearing,Wtaxrate)"
                '    strSQL = strSQL & " VALUES("
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "MANDT")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUKRS")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BELNR")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "GJAHR")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUZEI")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "WITHT")) & "',"
                '    If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "WT_QSSHH"), DblValue) Then
                '        strSQL = strSQL & DblValue & ","
                '    Else
                '        strSQL = strSQL & "0,"
                '    End If

                '    If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "WT_QBSHH"), DblValue) Then
                '        strSQL = strSQL & DblValue & ","
                '    Else
                '        strSQL = strSQL & "0,"
                '    End If

                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "KOART")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "WT_ACCO")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "HKONT")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "QSREC")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGBL")) & "',"
                '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGDT")) & "',"
                '    If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "QSATZ"), DblValue) Then
                '        strSQL = strSQL & DblValue & ""
                '    Else
                '        strSQL = strSQL & "0"
                '    End If

                '    strSQL = strSQL & ")"

                '    objCmd = New SqlCommand(strSQL, objConn)
                '    intNumRows = objCmd.ExecuteNonQuery()

                'Next
                .findById("wnd[0]").maximize()
                .findById("wnd[0]/tbar[0]/btn[15]").press()
                .findById("wnd[0]/tbar[0]/btn[15]").press()

                If My.Computer.FileSystem.FileExists(txtExportPath.Text & "\WHT_Amt.txt") Then
                    ImportedFile = My.Computer.FileSystem.ReadAllText(txtExportPath.Text & "\WHT_Amt.txt")
                    ImportedLines = Strings.Split(ImportedFile, Environment.NewLine)
                    For i = 5 To ImportedLines.GetUpperBound(0)
                        OneLine = Strings.Split(ImportedLines(i), "|")
                        Console.WriteLine("Insert : WHT_Amt : OneLine :" & OneLine.GetUpperBound(0) & " : " & OneLine.ToString())
                        If OneLine.GetUpperBound(0) = 16 Then '16 คือจำนวน Fields หลังจากการแยกด้วย |			
                            strSQL = ""
                            strSQL = "INSERT INTO WHT_Amt(Cl,CoCd,DocumentNo,Year,Itm,Withhldtaxtype,Wtaxbat,Withholdingtaxamnt,AccTy,VCaccnt,GL,Recty,Clrngdoc,Clearing,Wtaxrate)"
                            strSQL = strSQL & " VALUES("
                            strSQL = strSQL & "'" & Trim(OneLine(1)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(2)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(3)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(4)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(5)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(6)) & "',"
                            If Double.TryParse(OneLine(7), DblValue) Then
                                strSQL = strSQL & DblValue & ","
                            Else
                                strSQL = strSQL & "0,"
                            End If

                            If Double.TryParse(OneLine(8), DblValue) Then
                                strSQL = strSQL & DblValue & ","
                            Else
                                strSQL = strSQL & "0,"
                            End If

                            strSQL = strSQL & "'" & Trim(OneLine(9)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(10)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(11)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(12)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(13)) & "',"
                            strSQL = strSQL & "'" & Trim(OneLine(14)) & "',"
                            If Double.TryParse(OneLine(15), DblValue) Then
                                strSQL = strSQL & DblValue & ""
                            Else
                                strSQL = strSQL & "0"
                            End If

                            strSQL = strSQL & ")"

                            objCmd = New SqlCommand(strSQL, objConn)
                            intNumRows = objCmd.ExecuteNonQuery()
                        Else
                            'MessageBox.Show("Wrong number of fields", "Notification", MessageBoxButtons.OK)
                        End If
                    Next
                Else
                    MessageBox.Show("No record found.", "Notification", MessageBoxButtons.OK)
                End If

                objConn.Close()
                objConn = Nothing

            End With
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BSEG_VAT()
        Try
            Dim ImportedFile As String
            Dim ImportedLines() As String
            Dim OneLine() As String
            Dim i As Integer

            Dim TotalRow
            Dim DblValue As Double
            Dim objConn As New SqlConnection
            Dim objCmd As New SqlCommand
            Dim dtAdapter As SqlDataAdapter
            Dim dt As New DataTable
            Dim dtDoc As New DataTable
            Dim strSQL As String
            Dim intNumRows As Integer

            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
            Dim Dateformat As String = "yyyyMMdd HH:mm:ss"

            objConn.ConnectionString = clsDBUtil.DBConnectStringSQLServer
            objConn.Open()

            strSQL = "Select distinct Year from BSAK_Payment_Voucher (NOLOCK)"

            dtAdapter = New SqlDataAdapter(strSQL, objConn)
            dtAdapter.Fill(dt)


            For Each drRow As DataRow In dt.Rows

                RichTextBox2.Clear()

                strSQL = "Select DocumentNo from BSAK_Payment_Voucher (NOLOCK) where Year='" & Trim(drRow.Item("Year")) & "' "
                dtAdapter = New SqlDataAdapter(strSQL, objConn)
                dtAdapter.Fill(dtDoc)
                For Each drRowDoc As DataRow In dtDoc.Rows
                    RichTextBox2.Text = RichTextBox2.Text & drRowDoc.Item("DocumentNo") & vbCrLf
                Next

                RichTextBox2.SelectAll()
                RichTextBox2.Copy()

                With sapSession
                    .findById("wnd[0]").maximize()
                    .findById("wnd[0]/usr/ctxtDATABROWSE-TABLENAME").text = "bseg"
                    .findById("wnd[0]/usr/ctxtDATABROWSE-TABLENAME").caretPosition = 4
                    .findById("wnd[0]").sendVKey(0)
                    .findById("wnd[0]/usr/ctxtI1-LOW").text = "9770"
                    .findById("wnd[0]/usr/txtI2-LOW").setFocus()
                    .findById("wnd[0]/usr/txtI2-LOW").caretPosition = 0
                    .findById("wnd[0]/usr/btn%_I2_%_APP_%-VALU_PUSH").press()
                    .findById("wnd[1]/tbar[0]/btn[24]").press()
                    .findById("wnd[1]/tbar[0]/btn[8]").press()
                    .findById("wnd[0]/usr/txtI3-LOW").text = Trim(drRow.Item("Year"))
                    .findById("wnd[0]/usr/txtI3-LOW").setFocus()
                    .findById("wnd[0]/usr/txtI3-LOW").caretPosition = 4
                    .findById("wnd[0]").sendVKey(0)
                    .findById("wnd[0]/usr/ctxtI18-LOW").setFocus()
                    .findById("wnd[0]/usr/ctxtI18-LOW").caretPosition = 0
                    .findById("wnd[0]/usr/btn%_I18_%_APP_%-VALU_PUSH").press()
                    .findById("wnd[1]/usr/tabsTAB_STRIP/tabpSIVA/ssubSCREEN_HEADER:SAPLALDB:3010/tblSAPLALDBSINGLE/ctxtRSCSEL_255-SLOW_I[1,0]").text = "2121020000"
                    .findById("wnd[1]/usr/tabsTAB_STRIP/tabpSIVA/ssubSCREEN_HEADER:SAPLALDB:3010/tblSAPLALDBSINGLE/ctxtRSCSEL_255-SLOW_I[1,1]").text = "2181030000"
                    .findById("wnd[1]/usr/tabsTAB_STRIP/tabpSIVA/ssubSCREEN_HEADER:SAPLALDB:3010/tblSAPLALDBSINGLE/ctxtRSCSEL_255-SLOW_I[1,1]").setFocus()
                    .findById("wnd[1]/usr/tabsTAB_STRIP/tabpSIVA/ssubSCREEN_HEADER:SAPLALDB:3010/tblSAPLALDBSINGLE/ctxtRSCSEL_255-SLOW_I[1,1]").caretPosition = 10
                    .findById("wnd[1]").sendVKey(0)
                    .findById("wnd[1]/tbar[0]/btn[8]").press()
                    .findById("wnd[0]/usr/txtMAX_SEL").text = ""
                    .findById("wnd[0]/usr/txtMAX_SEL").setFocus()
                    .findById("wnd[0]/usr/txtMAX_SEL").caretPosition = 11
                    .findById("wnd[0]/tbar[1]/btn[8]").press()

                    .findById("wnd[0]/tbar[1]/btn[33]").press()
                    .findById("wnd[1]/usr/subSUB_CONFIGURATION:SAPLSALV_CUL_LAYOUT_CHOOSE:0500/cntlD500_CONTAINER/shellcont/shell").currentCellRow = txtBSEG_VAT.Text '4
                    .findById("wnd[1]/usr/subSUB_CONFIGURATION:SAPLSALV_CUL_LAYOUT_CHOOSE:0500/cntlD500_CONTAINER/shellcont/shell").selectedRows = txtBSEG_VAT.Text '"4"
                    .findById("wnd[1]/usr/subSUB_CONFIGURATION:SAPLSALV_CUL_LAYOUT_CHOOSE:0500/cntlD500_CONTAINER/shellcont/shell").clickCurrentCell()
                    .findById("wnd[0]/tbar[1]/btn[45]").press()
                    .findById("wnd[1]/tbar[0]/btn[0]").press()
                    .findById("wnd[1]/usr/ctxtDY_PATH").text = txtExportPath.Text
                    '.findById("wnd[1]/usr/ctxtDY_PATH").text = Directory.GetCurrentDirectory()
                    .findById("wnd[1]/usr/ctxtDY_FILENAME").text = "BSEG_VAT_" & Trim(drRow.Item("Year")) & ".txt"
                    '.findById("wnd[1]/usr/ctxtDY_FILENAME").text = "BSEG_VAT.txt"
                    '.findById("wnd[1]/usr/ctxtDY_FILENAME").caretPosition = 14
                    .findById("wnd[1]").sendVKey(0)
                    .findById("wnd[0]/tbar[1]/btn[8]").press()

                    TotalRow = .FindById("wnd[0]/usr/cntlGRID1/shellcont/shell")
                    'MsgBox(TotalRow.rowcount)


                    'For sapRow = 0 To TotalRow.rowCount - 1

                    '    strSQL = ""
                    '    strSQL = "INSERT INTO BSEG_VAT(Cl,CoCd,DocumentNo,Year,DocYear,Itm,PK,DC,Tx,WT,[Amount in LC],GL)"
                    '    strSQL = strSQL & " VALUES("
                    '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "MANDT")) & "',"
                    '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUKRS")) & "',"
                    '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BELNR")) & "',"
                    '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "GJAHR")) & "',"
                    '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BELNR")) & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "GJAHR")) & "',"
                    '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUZEI")) & "',"
                    '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BSCHL")) & "',"
                    '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "SHKZG")) & "',"
                    '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "MWSKZ")) & "',"
                    '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "QSSKZ")) & "',"
                    '    If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "DMBTR"), DblValue) Then
                    '        strSQL = strSQL & DblValue & ","
                    '    Else
                    '        strSQL = strSQL & "0,"
                    '    End If


                    '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "HKONT")) & "'"
                    '    strSQL = strSQL & ")"

                    '    objCmd = New SqlCommand(strSQL, objConn)
                    '    intNumRows = objCmd.ExecuteNonQuery()

                    'Next
                    .findById("wnd[0]").maximize()
                    .findById("wnd[0]/tbar[0]/btn[15]").press()
                    .findById("wnd[0]/tbar[0]/btn[15]").press()

                    If My.Computer.FileSystem.FileExists(txtExportPath.Text & "\BSEG_VAT_" & Trim(drRow.Item("Year")) & ".txt") Then
                        ImportedFile = My.Computer.FileSystem.ReadAllText(txtExportPath.Text & "\BSEG_VAT_" & Trim(drRow.Item("Year")) & ".txt")
                        ImportedLines = Strings.Split(ImportedFile, Environment.NewLine)
                        For i = 5 To ImportedLines.GetUpperBound(0)
                            OneLine = Strings.Split(ImportedLines(i), "|")
                            Console.WriteLine("Insert : BSEG_VAT : OneLine :" & OneLine.GetUpperBound(0) & " : " & OneLine.ToString())
                            If OneLine.GetUpperBound(0) = 12 Then '12 คือจำนวน Fields หลังจากการแยกด้วย |			
                                strSQL = ""
                                strSQL = "INSERT INTO BSEG_VAT(Cl,CoCd,DocumentNo,Year,DocYear,Itm,PK,DC,Tx,WT,[Amount in LC],GL)"
                                strSQL = strSQL & " VALUES("
                                strSQL = strSQL & "'" & Trim(OneLine(1)) & "',"
                                strSQL = strSQL & "'" & Trim(OneLine(2)) & "',"
                                strSQL = strSQL & "'" & Trim(OneLine(3)) & "',"
                                strSQL = strSQL & "'" & Trim(OneLine(4)) & "',"
                                strSQL = strSQL & "'" & Trim(OneLine(3)) & "_" & Trim(OneLine(4)) & "',"
                                strSQL = strSQL & "'" & Trim(OneLine(5)) & "',"
                                strSQL = strSQL & "'" & Trim(OneLine(6)) & "',"
                                strSQL = strSQL & "'" & Trim(OneLine(7)) & "',"
                                strSQL = strSQL & "'" & Trim(OneLine(8)) & "',"
                                strSQL = strSQL & "'" & Trim(OneLine(9)) & "',"
                                If Double.TryParse(OneLine(10), DblValue) Then
                                    strSQL = strSQL & DblValue & ","
                                Else
                                    strSQL = strSQL & "0,"
                                End If


                                strSQL = strSQL & "'" & Trim(OneLine(11)) & "'"
                                strSQL = strSQL & ")"

                                objCmd = New SqlCommand(strSQL, objConn)
                                intNumRows = objCmd.ExecuteNonQuery()
                            Else
                                'MessageBox.Show("Wrong number of fields", "Notification", MessageBoxButtons.OK)
                            End If
                        Next
                    Else
                        MessageBox.Show("No record found.", "Notification", MessageBoxButtons.OK)
                    End If

                End With

            Next

            objConn.Close()
            objConn = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BSEG_Invoice()
        Try
            Dim ImportedFile As String
            Dim ImportedLines() As String
            Dim OneLine() As String
            Dim i As Integer

            Dim TotalRow
            Dim DblValue As Double
            Dim objConn As New SqlConnection
            Dim objCmd As New SqlCommand
            Dim dtAdapter As SqlDataAdapter
            Dim dt As New DataTable
            Dim dtDoc As New DataTable
            Dim strSQL As String
            Dim intNumRows As Integer

            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
            Dim Dateformat As String = "yyyyMMdd HH:mm:ss"

            objConn.ConnectionString = clsDBUtil.DBConnectStringSQLServer
            objConn.Open()

            strSQL = "Select distinct Year from BSAK_Payment_Voucher (NOLOCK)"

            dtAdapter = New SqlDataAdapter(strSQL, objConn)
            dtAdapter.Fill(dt)


            For Each drRow As DataRow In dt.Rows

                RichTextBox2.Clear()

                strSQL = "Select DocumentNo from BSAK_Payment_Voucher (NOLOCK) where Year='" & Trim(drRow.Item("Year")) & "' "
                dtAdapter = New SqlDataAdapter(strSQL, objConn)
                dtAdapter.Fill(dtDoc)
                For Each drRowDoc As DataRow In dtDoc.Rows
                    RichTextBox2.Text = RichTextBox2.Text & drRowDoc.Item("DocumentNo") & vbCrLf
                Next

                RichTextBox2.SelectAll()
                RichTextBox2.Copy()

                'If Trim(drRow.Item("Year")) <> "2023" Then 'fix value first. because error from no data found

                With sapSession
                        .findById("wnd[0]").maximize()
                        .findById("wnd[0]/usr/ctxtDATABROWSE-TABLENAME").text = "BSEG"
                        .findById("wnd[0]/usr/ctxtDATABROWSE-TABLENAME").caretPosition = 4
                        .findById("wnd[0]").sendVKey(0)
                        .findById("wnd[0]/usr/ctxtI1-LOW").text = "9770"
                        .findById("wnd[0]/usr/ctxtI1-LOW").caretPosition = 4
                        .findById("wnd[0]").sendVKey(0)
                        .findById("wnd[0]/usr/txtI2-LOW").setFocus()
                        .findById("wnd[0]/usr/txtI2-LOW").caretPosition = 0
                        .findById("wnd[0]/usr/btn%_I2_%_APP_%-VALU_PUSH").press()
                        .findById("wnd[1]/tbar[0]/btn[24]").press()
                        .findById("wnd[1]/tbar[0]/btn[8]").press()
                        .findById("wnd[0]/usr/txtI3-LOW").text = Trim(drRow.Item("Year"))
                        .findById("wnd[0]/usr/txtI3-LOW").setFocus()
                        .findById("wnd[0]/usr/txtI3-LOW").caretPosition = 4
                        .findById("wnd[0]").sendVKey(0)
                        .findById("wnd[0]/usr/ctxtI6-LOW").setFocus()
                        .findById("wnd[0]/usr/ctxtI6-LOW").caretPosition = 0
                        .findById("wnd[0]/usr/btn%_I6_%_APP_%-VALU_PUSH").press()
                        .findById("wnd[1]/usr/tabsTAB_STRIP/tabpSIVA/ssubSCREEN_HEADER:SAPLALDB:3010/tblSAPLALDBSINGLE/ctxtRSCSEL_255-SLOW_I[1,0]").text = "21"
                        .findById("wnd[1]/usr/tabsTAB_STRIP/tabpSIVA/ssubSCREEN_HEADER:SAPLALDB:3010/tblSAPLALDBSINGLE/ctxtRSCSEL_255-SLOW_I[1,1]").text = "31"
                        .findById("wnd[1]/usr/tabsTAB_STRIP/tabpSIVA/ssubSCREEN_HEADER:SAPLALDB:3010/tblSAPLALDBSINGLE/ctxtRSCSEL_255-SLOW_I[1,1]").setFocus()
                        .findById("wnd[1]/usr/tabsTAB_STRIP/tabpSIVA/ssubSCREEN_HEADER:SAPLALDB:3010/tblSAPLALDBSINGLE/ctxtRSCSEL_255-SLOW_I[1,1]").caretPosition = 2
                        .findById("wnd[1]/tbar[0]/btn[8]").press()
                        .findById("wnd[0]/usr/txtMAX_SEL").text = ""
                        .findById("wnd[0]/usr/txtMAX_SEL").setFocus()
                        .findById("wnd[0]/usr/txtMAX_SEL").caretPosition = 11
                        .findById("wnd[0]").sendVKey(0)
                        .findById("wnd[0]/tbar[1]/btn[8]").press()

                        'If Trim(drRow.Item("Year")) <> "2023" Then
                        .findById("wnd[0]/tbar[1]/btn[33]").press()
                        .findById("wnd[1]/usr/subSUB_CONFIGURATION:SAPLSALV_CUL_LAYOUT_CHOOSE:0500/cntlD500_CONTAINER/shellcont/shell").currentCellRow = txtBSEG_Invoice.Text '2                                        
                        .findById("wnd[1]/usr/subSUB_CONFIGURATION:SAPLSALV_CUL_LAYOUT_CHOOSE:0500/cntlD500_CONTAINER/shellcont/shell").selectedRows = txtBSEG_Invoice.Text '"2"
                        .findById("wnd[1]/usr/subSUB_CONFIGURATION:SAPLSALV_CUL_LAYOUT_CHOOSE:0500/cntlD500_CONTAINER/shellcont/shell").clickCurrentCell()
                        .findById("wnd[0]/tbar[1]/btn[45]").press()
                        .findById("wnd[1]/tbar[0]/btn[0]").press()
                        .findById("wnd[1]/usr/ctxtDY_PATH").text = txtExportPath.Text
                        '.findById("wnd[1]/usr/ctxtDY_PATH").text = Directory.GetCurrentDirectory()
                        .findById("wnd[1]/usr/ctxtDY_FILENAME").text = "BSEG_Invoice_" & Trim(drRow.Item("Year")) & ".txt"
                        '.findById("wnd[1]/usr/ctxtDY_FILENAME").text = "BSEG_Invoice.txt"
                        '.findById("wnd[1]/usr/ctxtDY_FILENAME").caretPosition = 14
                        .findById("wnd[1]").sendVKey(0)
                        .findById("wnd[0]/tbar[1]/btn[8]").press()

                        TotalRow = .FindById("wnd[0]/usr/cntlGRID1/shellcont/shell")
                        'MsgBox(TotalRow.rowcount)


                        'For sapRow = 0 To TotalRow.rowCount - 1

                        '    strSQL = ""
                        '    strSQL = "INSERT INTO BSEG_Invoice(Cl,CoCd,DocumentNo,Year,DocYear,Itm,Clearing,ClgEntDate,Clrngdoc,PK,AccTy,DC,Tx,WT,AmountinLC,Curr,Withhldtaxbase,GL,Vendor)"
                        '    strSQL = strSQL & " VALUES("
                        '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "MANDT")) & "',"
                        '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUKRS")) & "',"
                        '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BELNR")) & "',"
                        '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "GJAHR")) & "',"
                        '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BELNR")) & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "GJAHR")) & "',"
                        '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUZEI")) & "',"
                        '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGDT")) & "',"
                        '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGCP")) & "',"
                        '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "AUGBL")) & "',"
                        '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BSCHL")) & "',"
                        '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "KOART")) & "',"
                        '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "SHKZG")) & "',"
                        '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "MWSKZ")) & "',"
                        '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "QSSKZ")) & "',"
                        '    If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "DMBTR"), DblValue) Then
                        '        strSQL = strSQL & DblValue & ","
                        '    Else
                        '        strSQL = strSQL & "0,"
                        '    End If

                        '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "PSWSL")) & "',"

                        '    If Double.TryParse(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "QSSHB"), DblValue) Then
                        '        strSQL = strSQL & DblValue & ","
                        '    Else
                        '        strSQL = strSQL & "0,"
                        '    End If                        
                        '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "HKONT")) & "',"
                        '    strSQL = strSQL & "'" & Trim(.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "LIFNR")) & "'"
                        '    strSQL = strSQL & ")"

                        '    objCmd = New SqlCommand(strSQL, objConn)
                        '    intNumRows = objCmd.ExecuteNonQuery()

                        'Next
                        .findById("wnd[0]").maximize()
                        .findById("wnd[0]/tbar[0]/btn[15]").press()
                        .findById("wnd[0]/tbar[0]/btn[15]").press()

                        If My.Computer.FileSystem.FileExists(txtExportPath.Text & "\BSEG_Invoice_" & Trim(drRow.Item("Year")) & ".txt") Then
                            ImportedFile = My.Computer.FileSystem.ReadAllText(txtExportPath.Text & "\BSEG_Invoice_" & Trim(drRow.Item("Year")) & ".txt")
                            ImportedLines = Strings.Split(ImportedFile, Environment.NewLine)
                            For i = 5 To ImportedLines.GetUpperBound(0)
                                OneLine = Strings.Split(ImportedLines(i), "|")
                                Console.WriteLine("Insert : BSEG_Invoice_ : OneLine :" & OneLine.GetUpperBound(0) & " : " & OneLine.ToString())
                                If OneLine.GetUpperBound(0) = 19 Then '19 คือจำนวน Fields หลังจากการแยกด้วย |			
                                    strSQL = ""
                                    strSQL = "INSERT INTO BSEG_Invoice(Cl,CoCd,DocumentNo,Year,DocYear,Itm,Clearing,ClgEntDate,Clrngdoc,PK,AccTy,DC,Tx,WT,AmountinLC,Curr,Withhldtaxbase,GL,Vendor)"
                                    strSQL = strSQL & " VALUES("
                                    strSQL = strSQL & "'" & Trim(OneLine(1)) & "',"
                                    strSQL = strSQL & "'" & Trim(OneLine(2)) & "',"
                                    strSQL = strSQL & "'" & Trim(OneLine(3)) & "',"
                                    strSQL = strSQL & "'" & Trim(OneLine(4)) & "',"
                                    strSQL = strSQL & "'" & Trim(OneLine(3)) & "_" & Trim(OneLine(4)) & "',"
                                    strSQL = strSQL & "'" & Trim(OneLine(5)) & "',"
                                    strSQL = strSQL & "'" & Trim(OneLine(6)) & "',"
                                    strSQL = strSQL & "'" & Trim(OneLine(7)) & "',"
                                    strSQL = strSQL & "'" & Trim(OneLine(8)) & "',"
                                    strSQL = strSQL & "'" & Trim(OneLine(9)) & "',"
                                    strSQL = strSQL & "'" & Trim(OneLine(10)) & "',"
                                    strSQL = strSQL & "'" & Trim(OneLine(11)) & "',"
                                    strSQL = strSQL & "'" & Trim(OneLine(12)) & "',"
                                    strSQL = strSQL & "'" & Trim(OneLine(13)) & "',"
                                    If Double.TryParse(OneLine(14), DblValue) Then
                                        strSQL = strSQL & DblValue & ","
                                    Else
                                        strSQL = strSQL & "0,"
                                    End If

                                    strSQL = strSQL & "'" & Trim(OneLine(15)) & "',"

                                    If Double.TryParse(OneLine(16), DblValue) Then
                                        strSQL = strSQL & DblValue & ","
                                    Else
                                        strSQL = strSQL & "0,"
                                    End If
                                    strSQL = strSQL & "'" & Trim(OneLine(17)) & "',"
                                    strSQL = strSQL & "'" & Trim(OneLine(18)) & "'"
                                    strSQL = strSQL & ")"

                                    objCmd = New SqlCommand(strSQL, objConn)
                                    intNumRows = objCmd.ExecuteNonQuery()
                                Else
                                    'MessageBox.Show("Wrong number of fields", "Notification", MessageBoxButtons.OK)
                                End If
                            Next
                        Else
                            MessageBox.Show("No record found.", "Notification", MessageBoxButtons.OK)
                        End If
                        'Else
                        '    .findById("wnd[0]").maximize()
                        '    .findById("wnd[0]/tbar[0]/btn[15]").press()
                        '    .findById("wnd[0]/tbar[0]/btn[15]").press()
                        'End If

                    End With
                'End If

            Next

            objConn.Close()
            objConn = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub process_data()
        Dim TotalRow
        Dim stt As String
        With sapSession
            .findById("wnd[0]").maximize()
            .findById("wnd[0]/tbar[0]/okcd").Text = "zmenhtc"
            .findById("wnd[0]").sendVKey(0)
            .findById("wnd[0]/usr/ctxtZHTC_CLA-CLASS").Text = "fi"
            .findById("wnd[0]/usr/ctxtZHTC_CLA-CLASS").caretPosition = 2
            .findById("wnd[0]").sendVKey(0)
            .findById("wnd[0]/usr/tblZHTC_MENUREPREPORT").getAbsoluteRow(13).Selected = True
            .findById("wnd[0]/usr/tblZHTC_MENUREPREPORT/txtREP-ZNAME[0,13]").SetFocus()
            .findById("wnd[0]/usr/tblZHTC_MENUREPREPORT/txtREP-ZNAME[0,13]").caretPosition = 0
            .findById("wnd[0]/tbar[1]/btn[8]").press()
            .findById("wnd[0]/usr/ctxtDATABROWSE-TABLENAME").Text = "t001"
            .findById("wnd[0]/usr/ctxtDATABROWSE-TABLENAME").caretPosition = 4
            .findById("wnd[0]").sendVKey(0)
            .findById("wnd[0]/usr/ctxtI1-LOW").Text = "9770"
            .findById("wnd[0]/usr/ctxtI1-LOW").caretPosition = 4
            .findById("wnd[0]/tbar[1]/btn[8]").press()

            TotalRow = .FindById("wnd[0]/usr/cntlGRID1/shellcont/shell")
            'MsgBox(TotalRow.rowcount)


            For sapRow = 0 To TotalRow.rowCount - 1
                stt = .findById("wnd[0]/usr/cntlGRID1/shellcont/shell").GetCellValue(sapRow, "BUTXT")
                'stt = TotalRow.GetCellValue(sapRow, "BUTXT")

                Write_log(stt)
            Next
            .findById("wnd[0]").maximize()
            .findById("wnd[0]/tbar[0]/btn[15]").press()
            .findById("wnd[0]/tbar[0]/btn[15]").press()
            .findById("wnd[0]/tbar[0]/btn[15]").press()
            .findById("wnd[0]/tbar[0]/btn[15]").press()
            .findById("wnd[0]/tbar[0]/btn[15]").press()
            .findById("wnd[1]/usr/btnSPOP-OPTION1").press()

            MsgBox("Export Done")

        End With
    End Sub

    'Private Sub loginInfo()
    '    sapSession = sapCon.Children(0)
    '    With sapSession
    '        ' MsgBox(.FindById("wnd[0]/usr/txtRSYST-MANDT").Text)
    '        ' .FindById("wnd[0]/usr/txtRSYST-MANDT").Text = "200"
    '        ' MsgBox(.FindById("wnd[0]/usr/txtRSYST-MANDT").Text)
    '        .FindById("wnd[0]/usr/txtRSYST-BNAME").Text = sapID
    '        .FindById("wnd[0]/usr/pwdRSYST-BCODE").Text = sapPassword
    '        .FindById("wnd[0]/usr/txtRSYST-LANGU").Text = "EN"
    '        .FindById("wnd[0]").SendVKey(0)
    '    End With
    'End Sub

    Private Sub loginInfo()

        Try

            If sapCon Is Nothing Then
                Throw New Exception("ไม่พบ SAP Connection")
            End If

            If sapCon.Children.Count = 0 Then
                Throw New Exception("ไม่พบ SAP Session")
            End If

            sapSession = sapCon.Children(0)

            With sapSession

                .FindById("wnd[0]/usr/txtRSYST-BNAME").Text =
                sapID

                .FindById("wnd[0]/usr/pwdRSYST-BCODE").Text =
                sapPassword

                .FindById("wnd[0]/usr/txtRSYST-LANGU").Text =
                "EN"

                .FindById("wnd[0]").SendVKey(0)

            End With

        Catch ex As Exception

            Throw New Exception(
            "เกิดข้อผิดพลาดระหว่าง Login SAP: " &
            ex.Message
        )

        End Try

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub ExitSAP()
        With sapSession
            .findById("wnd[0]/tbar[0]/btn[15]").press()
            .findById("wnd[0]/tbar[0]/btn[15]").press()
            .findById("wnd[0]/tbar[0]/btn[15]").press()
            .findById("wnd[1]/usr/btnSPOP-OPTION1").press()
        End With
    End Sub

    Private Sub ClearDataForFirst()
        Try

            Dim objConn As New SqlConnection
            Dim objCmd As New SqlCommand
            Dim dt As New DataTable
            Dim strSQL As String
            Dim intNumRows As Integer
            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
            Dim Dateformat As String = "yyyyMMdd HH:mm:ss"

            objConn.ConnectionString = clsDBUtil.DBConnectStringSQLServer
            objConn.Open()

            strSQL = "delete from dbo.BSAK_Payment_Voucher "
            objCmd = New SqlCommand(strSQL, objConn)
            intNumRows = objCmd.ExecuteNonQuery()

            strSQL = "delete from dbo.BSEG_Invoice "
            objCmd = New SqlCommand(strSQL, objConn)
            intNumRows = objCmd.ExecuteNonQuery()

            strSQL = "delete from dbo.BSEG_Payment_Voucher "
            objCmd = New SqlCommand(strSQL, objConn)
            intNumRows = objCmd.ExecuteNonQuery()

            strSQL = "delete from dbo.BSEG_VAT "
            objCmd = New SqlCommand(strSQL, objConn)
            intNumRows = objCmd.ExecuteNonQuery()

            strSQL = "delete from dbo.WHT_Amt "
            objCmd = New SqlCommand(strSQL, objConn)
            intNumRows = objCmd.ExecuteNonQuery()


            objConn.Close()
            objConn = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeleteAllFiles()
        Dim m_sFileName
        For Each m_sFileName In System.IO.Directory.GetFiles(txtExportPath.Text)
            Dim FilesToExclude As String() = {"exceptme.txt", "exceptmetoo.txt", "igonemetoo.txt"}
            If Not Array.Exists(FilesToExclude, Function(element) element = m_sFileName) Then
                System.IO.File.Delete(m_sFileName)
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            'sapID = txtUsername.Text '"80006112"
            'sapPassword = txtPassword.Text '"banana,07"
            'sapServer = txtServer.Text '"/H/10.138.1.7/S/3203"
            ''sapServer = "/H/10.138.1.3/S/3230"
            'sap = CreateObject("SAPGUI.Scriptingctrl.1")
            'sapCon = sap.OpenConnectionByConnectionString(sapServer, True)
            If Not ConnectSAP() Then
                Exit Sub
            End If

            txtSuggestion.Text = ""

            'Create_File()
            loginInfo()
            'process_data()

            ClearDataForFirst()
            DeleteAllFiles()
            VirifyData()

            '### --------- Step 1
            RichTextBox1.Clear()
            Get_15_Document()
            RichTextBox1.SelectAll()
            RichTextBox1.Copy()
            BSEG_Payment_Voucher()

            '### --------- Step 2                        
            RichTextBox1.SelectAll()
            RichTextBox1.Copy()
            BSAK_Payment_Voucher()

            '### --------- Step 3                                  
            BSEG_VAT()

            '### --------- Step 4
            RichTextBox1.SelectAll()
            RichTextBox1.Copy()
            WHT_Amt()

            '### --------- Step 5                               
            BSEG_Invoice()

            ExitSAP()

            ChkSuggestion()

            MsgBox("Export Done")

            'fs = Nothing
            sap = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim SapGuiAuto As Object
        'Dim Application As Object
        'Dim connection As Object
        'Dim session As Object

        'SapGuiAuto = GetObject("SAPGUI")
        'Application = SapGuiAuto.GetScriptingEngine

        'connection = Application.OpenConnection("HGVS 800 PRD", True, False)

        'session = connection.Children.Item(0)
    End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    '    Dim LogonControl As Object
    '    Dim conn As Object
    '    Dim retcd As Boolean
    '    Dim funcControl As Object
    '    Dim strSystemName As String
    '    'Dim Session As Object

    '    strSystemName = "HE5"

    '    LogonControl = CreateObject("SAP.LogonControl.1")
    '    conn = LogonControl.NewConnection
    '    conn.System = "HGVS 800 PRD"
    '    conn.Client = "800"
    '    conn.Language = "EN"
    '    conn.User = "80006112"
    '    conn.Password = "banana,07"
    '    retcd = conn.Logon(0, True) 'True = No logon GUI 'False = logon GUI

    '    If retcd <> True Then
    '        MsgBox("Login failed for- " & strSystemName & " -UserName or Password are incorrect, check them and run try again .")
    '        Exit Sub
    '    End If
    '    MsgBox("Login successed" & strSystemName)


    '    funcControl = CreateObject("SAP.Functions")
    '    funcControl.Connection = conn
    'End Sub

    Private Sub btnCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCut.Click
        'Checks to see if the user selected anything
        If txtTextBox.SelectedText <> "" Then
            'Good, the user selected something
            'Copy the information to the clipbaord
            Clipboard.SetText(txtTextBox.SelectedText)
            'Since this is a cut command, we want to clear whatever 
            'text they had selected when they clicked cut
            txtTextBox.SelectedText = ""
        Else
            'If there was no text selected, print out an error message box
            MsgBox("No text is selected to cut")
        End If
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        'Checks to see if the user selected anything
        If txtTextBox.SelectedText <> "" Then
            'Copy the information to the clipboard
            Clipboard.SetText(txtTextBox.SelectedText)

        Else
            'If no text was selected, print out an error message box
            MsgBox("No text is selected to copy")
        End If
    End Sub

    Private Sub btnPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaste.Click
        'Get the data stored in the clipboard
        Dim iData As IDataObject = Clipboard.GetDataObject()
        'Check to see if the data is in a text format
        If iData.GetDataPresent(DataFormats.Text) Then
            'If it's text, then paste it into the textbox
            txtTextBox.SelectedText = CType(iData.GetData(DataFormats.Text), String)
        Else
            'If it's not text, print a warning message
            MsgBox("Data in the clipboard is not availble for entry into a textbox")
        End If
    End Sub

    Private Sub Get_15_Document()
        Try

            Dim objConn As New SqlConnection
            Dim objCmd As New SqlCommand
            Dim dtAdapter As SqlDataAdapter
            Dim dt As New DataTable
            Dim strSQL As String

            'save the current settings for easier restoration later
            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture

            'change the settings
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

            Dim Dateformat As String = "yyyyMMdd HH:mm:ss"

            'Dim FileConfigINI_mcode = Application.StartupPath + "\config.ini"

            objConn.ConnectionString = clsDBUtil.DBConnectStringSQLServer
            objConn.Open()

            strSQL = "Select DocumentNo From tbPaymentDocument (NOLOCK)"

            dtAdapter = New SqlDataAdapter(strSQL, objConn)
            dtAdapter.Fill(dt)

            RichTextBox1.Clear()
            'RichTextBox1.SelectAll () 
            'RichTextBox1.Copy ()
            'RichTextBox1.Paste() 

            For Each drRow As DataRow In dt.Rows

                RichTextBox1.Text = RichTextBox1.Text & drRow.Item("DocumentNo") & vbCrLf

            Next


            'restore the previous settings
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI



            dt.Clear()
            objConn.Close()
            objConn = Nothing
            dt = Nothing
            dtAdapter = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ChkSuggestion()
        Try

            Dim objConn As New SqlConnection
            Dim objCmd As New SqlCommand
            Dim dtAdapter As SqlDataAdapter
            Dim dt As New DataTable
            Dim strSQL As String
            Dim StrSuggestion As String

            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
            Dim Dateformat As String = "yyyyMMdd HH:mm:ss"

            objConn.ConnectionString = clsDBUtil.DBConnectStringSQLServer
            objConn.Open()

            strSQL = "Select DocumentNo from BSEG_Payment_Voucher (NOLOCK) where gl='2221020100' and wt is null"

            dtAdapter = New SqlDataAdapter(strSQL, objConn)
            dtAdapter.Fill(dt)

            StrSuggestion = ""

            For Each drRow As DataRow In dt.Rows

                StrSuggestion = StrSuggestion & drRow.Item("DocumentNo") & vbCrLf

            Next
            If StrSuggestion <> "" Then
                txtSuggestion.Text = "WT is Null => Please check" & vbCrLf & StrSuggestion
            End If

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI



            dt.Clear()
            objConn.Close()
            objConn = Nothing
            dt = Nothing
            dtAdapter = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub VirifyData()
        Try

            Dim objConn As New SqlConnection
            Dim objCmd As New SqlCommand
            Dim dt As New DataTable
            Dim strSQL As String
            Dim intNumRows As Integer

            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

            Dim Dateformat As String = "yyyyMMdd HH:mm:ss"

            objConn.ConnectionString = clsDBUtil.DBConnectStringSQLServer
            objConn.Open()

            strSQL = "Update vendor set [tax id]=NULL where [tax id]='' "            
            objCmd = New SqlCommand(strSQL, objConn)
            intNumRows = objCmd.ExecuteNonQuery()

            strSQL = "Update vendor set [tax id]=LTRIM(RTRIM([tax id])) "
            objCmd = New SqlCommand(strSQL, objConn)
            intNumRows = objCmd.ExecuteNonQuery()

            objConn.Close()
            objConn = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        Get_15_Document()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        RichTextBox1.SelectAll()
        RichTextBox1.Copy()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim DblValue As Double
        If Double.TryParse(" ", DblValue) Then
            MsgBox(DblValue.ToString)
        Else
            MsgBox("0")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Try
            'sapID = txtUsername.Text '"80006112"
            'sapPassword = txtPassword.Text '"banana,07"
            'sapServer = txtServer.Text '"/H/10.138.1.7/S/3203"
            ''sapServer = "/H/10.138.1.3/S/3230"
            'sap = CreateObject("SAPGUI.Scriptingctrl.1")
            'sapCon = sap.OpenConnectionByConnectionString(sapServer, True)

            If Not ConnectSAP() Then
                Exit Sub
            End If

            txtSuggestion.Text = ""

            'Create_File()
            loginInfo()
            'process_data()

            ClearDataForFirst()

            '### --------- Step 1
            RichTextBox1.Clear()
            Get_15_Document()
            RichTextBox1.SelectAll()
            RichTextBox1.Copy()
            BSEG_Payment_Voucher_Export()


            ExitSAP()

            MsgBox("Export Done")

            'fs = Nothing
            sap = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            'sapID = txtUsername.Text '"80006112"
            'sapPassword = txtPassword.Text '"banana,07"
            'sapServer = txtServer.Text '"/H/10.138.1.7/S/3203"
            ''sapServer = "/H/10.138.1.3/S/3230"
            'sap = CreateObject("SAPGUI.Scriptingctrl.1")
            'sapCon = sap.OpenConnectionByConnectionString(sapServer, True)

            If Not ConnectSAP() Then
                Exit Sub
            End If

            txtSuggestion.Text = ""

            Create_File()
            loginInfo()
            'process_data()

            ClearDataForFirst()

            '### --------- Step 1
            RichTextBox1.Clear()
            Get_15_Document()
            RichTextBox1.SelectAll()
            RichTextBox1.Copy()
            BSEG_Payment_Voucher_WriteFile()

            ExitSAP()

            MsgBox("Export Done")

            fs = Nothing
            sap = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MsgBox(Directory.GetCurrentDirectory)
    End Sub
End Class
