Imports System.Data.OleDb

Public Class BlistDAL

    Function getByid(ByVal id As Integer) As DataTable
        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "select blist.id as 内部编号,blist.pid as 商品编号,product.pname as 商品名称,blist.unit as 单位,blist.num as 数量,blist.price as 单价,round(blist.price*blist.num,2) as 小计,blist.remarks as 备注 from blist left join product on blist.pid=product.id where blist.bid=" & id
        cmd.CommandText = sqlstr
        conn.Open()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As New Data.DataTable

        Try
            da.Fill(ds, "blist")
            dt = ds.Tables("blist")
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
    Function update(ByVal b As Model.blist) As Boolean

        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "update [blist] set [bid]='" & b.bid & "',pid='" & b.pid & "',price='" & b.price & "',num='" & b.num & "',unit='" & b.unit & "',remarks='" & b.text & "' where id=" & b.id
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
        sqlstr = "delete from [blist] where [id]=" & id
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
    Function insert(ByVal b As Model.blist) As Integer

        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "insert into [blist] ([bid],[pid],[price],[num],[unit],[remarks]) values ('" & b.bid & "','" & b.pid & "','" & b.price & "','" & b.num & "','" & b.unit & "','" & b.text & "')"
        cmd.CommandText = sqlstr
        Try
            conn.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                sqlstr = "select id from [blist] order by id desc"
                cmd.CommandText = sqlstr
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "blist")
                Dim dr As DataRow = ds.Tables("blist").Rows(0)
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
