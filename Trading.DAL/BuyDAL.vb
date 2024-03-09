Imports System.Data.OleDb

Public Class BuyDAL
    Function getall() As DataTable
        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "select a.id as 内部编号,a.sid as 供应商编号,b.pname as 供应商名称,a.sday as 日期,a.money as 金额,a.ispay as 是否结账,a.remarks as 备注 from buy a left join supplier b on a.sid=b.id"
        'sqlstr = "select [id],[sid],[sday] from [buy]"
        'sqlstr = "select * from buy"
        cmd.CommandText = sqlstr
        conn.Open()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As New Data.DataTable

        Try
            da.Fill(ds, "buy")
            dt = ds.Tables("buy")
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
    Function getbysid(ByVal sid As String, Optional ByVal pay As Boolean = False) As DataTable
        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        If pay Then
            sqlstr = "select a.id as 内部编号,b.pname as 供应商名称,a.sday as 日期,a.money as 金额,a.ispay as 是否结账,a.remarks as 备注 from buy a left join supplier b on a.sid=b.id  where ispay=false and a.sid like '" & sid & "' order by a.sid"
        Else
            sqlstr = "select id as 内部编号,sday as 日期,money as 金额,ispay as 是否结账,remarks as 备注 from buy where sid=" & Val(sid)
        End If
        'sqlstr = "select [id],[sid],[sday] from [buy]"
        'sqlstr = "select * from sale"
        cmd.CommandText = sqlstr
        conn.Open()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As New Data.DataTable

        Try
            da.Fill(ds, "sale")
            dt = ds.Tables("sale")
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
    Function getByDay(ByVal day As Date) As DataTable
        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "select a.id as 内部编号,a.sid as 供应商编号,b.pname as 供应商名称,a.sday as 日期,a.money as 金额,a.ispay as 是否结账,a.remarks as 备注 from buy a left join supplier b on a.sid=b.id where a.sday=#" & day & "#"
        cmd.CommandText = sqlstr
        conn.Open()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As New Data.DataTable

        Try
            da.Fill(ds, "buy")
            dt = ds.Tables("buy")
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
    Function update(ByVal b As Model.buy) As Boolean

        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "update [buy] set [sid]=" & b.sid & ",sday=#" & b.sday & "#,[money]=" & b.money & ",ispay=" & b.ispay & ",remarks='" & b.text & "' where id=" & b.id
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
        sqlstr = "delete from [buy] where [id]=" & id
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
    Function insert(ByVal b As Model.buy) As Integer

        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "insert into [buy] ([sid],[sday],[money],[ispay],[remarks]) values (" & b.sid & ",#" & b.sday & "#," & b.money & "," & b.ispay & ",'" & b.text & "')"
        cmd.CommandText = sqlstr
        Try
            conn.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                sqlstr = "select id from [buy] order by id desc"
                cmd.CommandText = sqlstr
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "buy")
                Dim dr As DataRow = ds.Tables("buy").Rows(0)
                Return dr.Item(0)
            End If
            Return -2
        Catch ex As Exception
            Return -1
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
