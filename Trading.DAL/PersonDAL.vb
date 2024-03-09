Imports System.Data.OleDb

Public Class PersonDAL

    Function getPersonByName(ByVal name As String) As Model.Person
        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "select * from person where pname='" & name & "'"
        cmd.CommandText = sqlstr
        Try
            conn.Open()
            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader()  '执行查询    

            Dim users As New Model.Person
            While (reader.Read())          '读取字段  
                If users Is Nothing Then
                    users = New Model.Person
                End If
                users.id = Int(reader.Item("id"))
                users.name = reader.Item("pname").ToString
                users.password = reader.Item("password").ToString
                users.text = reader.Item("remarks").ToString
            End While
            conn.Close()
            Return users    '返回查询结果  
        Catch ex As Exception
            Return Nothing
        Finally
            If Not IsNothing(cmd) Then
                cmd.Dispose()
                cmd = Nothing
            End If
            If Not IsNothing(conn) Then
                conn.Close()
                conn = Nothing
            End If
        End Try

    End Function

    Function edit(ByVal person As Model.Person) As Boolean
        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "update [person] set [password]='" & person.password & "' where [id]=" & person.id
        cmd.CommandText = sqlstr
        Try
            conn.Open()
            Dim i As Integer
            i = cmd.ExecuteNonQuery()
            Return cmd.ExecuteNonQuery() > 0
        Catch ex As Exception
            Return False
        Finally
            If Not IsNothing(cmd) Then
                cmd.Dispose()
                cmd = Nothing
            End If
            If Not IsNothing(conn) Then
                conn.Close()
                conn = Nothing
            End If
        End Try


    End Function

End Class
