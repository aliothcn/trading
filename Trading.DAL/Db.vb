Imports System.Data.OleDb

Public Class Db
    Public Shared Function connstring() As String
        connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\db.mdb;Persist Security Info=False"
    End Function

End Class
