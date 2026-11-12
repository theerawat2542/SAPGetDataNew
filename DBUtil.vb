Public Class DBUtil
    Dim clsFileINI As New ClsINI
    Public Function ConvertNullString(ByVal field As Object) As String

        If IsDBNull(field) Then
            ConvertNullString = ""
        Else
            ConvertNullString = CStr(field)
        End If

    End Function
    Public Function DBConnectString() As String
        Dim directory As String = My.Application.Info.DirectoryPath
        DBConnectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & directory & "\database.mdb;Jet OLEDB:Database Password=;"
        'strConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & directory & "\database.accdb;Persist Security Info=False;"
    End Function
    Public Function DBConnectStringOracle() As String
        Dim FileConfigINI_mcode = Application.StartupPath + "\config.ini"
        'DBConnectStringOracle = "Provider=OraOLEDB.Oracle;" & _
        '                        "Data Source=(DESCRIPTION=(CID=GTU_APP)(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.35.10.7)(PORT=1521)))(CONNECT_DATA=(SID=htcwms)(SERVER=DEDICATED)));" & _
        '                        "User Id=htcwms;Password=htcwms;"
        DBConnectStringOracle = clsFileINI.ReadIni(FileConfigINI_mcode, "Database", "DBConnectStringOracle", "")
    End Function
    Public Function DBConnectStringSQLServer() As String
        Dim FileConfigINI_mcode = Application.StartupPath + "\config.ini"
        'DBConnectStringOracle = "Provider=OraOLEDB.Oracle;" & _
        '                        "Data Source=(DESCRIPTION=(CID=GTU_APP)(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.35.10.7)(PORT=1521)))(CONNECT_DATA=(SID=htcwms)(SERVER=DEDICATED)));" & _
        '                        "User Id=htcwms;Password=htcwms;"
        DBConnectStringSQLServer = clsFileINI.ReadIni(FileConfigINI_mcode, "DatabaseSQLServer", "DBConnectStringSQLServer", "")
    End Function
    Public Function CheckNull(ByVal fieldValue As String) As String
        If fieldValue.Equals(DBNull.Value) Then Return "" Else 
        If fieldValue = "N/A" Then
            Return "N/A"
        Else
            Return fieldValue.ToString
        End If
    End Function
End Class
