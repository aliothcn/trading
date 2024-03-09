Option Explicit On

Module INI
    Public inipath As String = "d:\config.ini"
    '声明从INI配置文件中获取类型为Int的配置项的值的系统函数
    Private Declare Function GetPrivateProfileInt Lib "kernel32" Alias "GetPrivateProfileIntA" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal nDefault As Integer, ByVal lpFileName As String) As Integer

    '声明从INI配置文件中获取类型为string的配置项的值的系统函数
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    '声明向INI配置文件中写入类型为string的配置项的值的系统函数

    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    '从INI配置文件中获取类型为Int的配置项的值

    Public Function GetIntFromINI(ByVal sectionName As String, ByVal keyName As String, ByVal defaultValue As Integer) As Integer
        GetIntFromINI = GetPrivateProfileInt(sectionName, keyName, defaultValue, inipath)
    End Function

    '从INI配置文件中获取类型为string的配置项的值
    Public Function GetStrFromINI(ByVal sectionName As String, ByVal keyName As String, ByVal defaultValue As String) As String
        Dim buffer As String
        Dim rc As Integer

        buffer = Space(256)
        rc = GetPrivateProfileString(sectionName, keyName, defaultValue, buffer, buffer.Length, inipath)
        GetStrFromINI = Left(buffer, InStr(buffer, vbNullChar) - 1)
    End Function

    '向INI配置文件中写入类型为string的配置项的值

    Public Function WriteStrINI(ByVal sectionName As String, ByVal keyName As String, ByVal setValue As String) As Integer
        Dim rc As Integer

        rc = WritePrivateProfileString(sectionName, keyName, setValue, inipath)
        If rc Then
            rc = 1
        End If
        WriteStrINI = rc
    End Function

End Module
