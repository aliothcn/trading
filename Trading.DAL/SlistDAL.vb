Imports System.Data.OleDb

Public Class SlistDAL

    Function getByid(ByVal id As Integer) As DataTable
        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "select slist.id as 内部编号,slist.pid as 商品编号,product.pname as 商品名称,slist.unit as 单位,slist.num as 数量,slist.price as 单价,round(slist.price*slist.num,2) as 小计,slist.remarks as 备注 from slist left join product on slist.pid=product.id where slist.sid=" & id
        cmd.CommandText = sqlstr
        conn.Open()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As New Data.DataTable

        Try
            da.Fill(ds, "slist")
            dt = ds.Tables("slist")
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
    Function update(ByVal b As Model.slist) As Boolean

        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "update [slist] set [sid]='" & b.sid & "',pid='" & b.pid & "',price='" & b.price & "',num='" & b.num & "',unit='" & b.unit & "',remarks='" & b.text & "' where id=" & b.id
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
        sqlstr = "delete from [slist] where [id]=" & id
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
    Function insert(ByVal b As Model.slist) As Integer

        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "insert into [slist] ([sid],[pid],[price],[num],[unit],[remarks]) values ('" & b.sid & "','" & b.pid & "','" & b.price & "','" & b.num & "','" & b.unit & "','" & b.text & "')"
        cmd.CommandText = sqlstr
        Try
            conn.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                sqlstr = "select id from [slist] order by id desc"
                cmd.CommandText = sqlstr
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "slist")
                Dim dr As DataRow = ds.Tables("slist").Rows(0)
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

    Function count(ByVal sday As DateTime) As DataTable

        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "select product.pname as 商品,slist.num as 数量,client.pname as 客户 from ((slist inner join (select id,cid from sale where sday=#" & sday & "#) a on slist.sid=a.id) left join product on slist.pid=product.id) left join client on a.cid=client.id order by product.pname"
        'sqlstr = "select b.* from slist b left join (select id from sale where sday=#" & sday & "#) a on b.sid=a.id"
        'sqlstr = "select ta.pname as 商品名称,tb.tj as 采购数量 from product ta inner join (SELECT slist.pid as pid, sum(slist.num) as tj From slist, sale Where (((slist.sid) = [sale].[id]) and sday=#" & sday & "#)  group by slist.pid) tb on ta.id=tb.pid"
        cmd.CommandText = sqlstr
        conn.Open()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As New Data.DataTable

        Try
            da.Fill(ds, "product")
            dt = ds.Tables("product")
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
End Class
