Imports System.Data.OleDb

Public Class clientDAL

    Function getall() As DataTable
        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "select * from [client]"
        cmd.CommandText = sqlstr
        conn.Open()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As New Data.DataTable

        Try
            da.Fill(ds, "client")
            dt = ds.Tables("client")
            Return dt
        Catch ex As Exception
            Return Nothing
        Finally
            If Not IsNothing(da) Then
                da.Dispose()
                da = Nothing
            End If
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
    Function getById(ByVal id As Integer) As Model.Client

        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "select * from client where id='" & id & "'"
        cmd.CommandText = sqlstr
        conn.Open()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim ds As New DataSet

        Dim client As New Model.Client
        Try
            da.Fill(ds, "client")
            Dim dr As DataRow = ds.Tables("client").Rows(0)
            client.id = dr("id")
            client.name = dr("pname")
            client.address = dr("address")
            client.person = dr("person")
            client.tel = dr("tel")
            client.phone = dr("phone")
            client.scope = dr("scope")
            client.text = dr("remarks")
            Return client
        Catch ex As Exception
            Return Nothing
        Finally
            If Not IsNothing(da) Then
                da.Dispose()
                da = Nothing
            End If
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
    Function update(ByVal client As Model.Client) As Boolean

        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "update [client] set [pname]='" & client.name & "',address='" & client.address & "',person='" & client.person & "',tel='" & client.tel & "',phone='" & client.phone & "',scope='" & client.scope & "',remarks='" & client.text & "' where id=" & client.id
        cmd.CommandText = sqlstr
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        Try
            conn.Open()
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
    Function Delete(ByVal id As Integer) As Boolean

        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "delete from [client] where [id]=" & id
        cmd.CommandText = sqlstr
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        Try
            conn.Open()
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
    Function insert(ByVal client As Model.Client) As Boolean

        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "insert into [client] ([pname],[address],[person],[tel],[phone],[scope],[remarks]) values ('" & client.name & "','" & client.address & "','" & client.person & "','" & client.tel & "','" & client.phone & "','" & client.scope & "','" & client.text & "')"
        cmd.CommandText = sqlstr
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        Try
            conn.Open()
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
