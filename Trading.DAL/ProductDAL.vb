Imports System.Data.OleDb

Public Class ProductDAL
    Function getall() As DataTable
        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "select id as 内部编号,pname as 名称,num as 编号,remarks as 备注 from product"
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
    Function getById(ByVal id As String) As Model.Product
        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "select * from [product] where [num]='" & id & "'"
        cmd.CommandText = sqlstr
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim ds As New DataSet

        Dim product As New Model.Product
        Try
            conn.Open()
            da.Fill(ds, "product")
            Dim dr As DataRow = ds.Tables("product").Rows(0)
            product.id = dr("id")
            product.name = dr("pname")
            If dr("num").ToString.Length = 0 Then
                product.num = ""
            Else
                product.num = dr("num").ToString
            End If
            If dr("remarks").ToString.Length = 0 Then
                product.text = ""
            Else
                product.text = dr("remarks")
            End If
            Return product
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
    Function getByName(ByVal name As String) As Model.Product
        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "select * from [product] where [pname]='" & name & "'"
        cmd.CommandText = sqlstr
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim ds As New DataSet

        Dim product As New Model.Product
        Try
            conn.Open()
            da.Fill(ds, "product")
            Dim dr As DataRow = ds.Tables("product").Rows(0)
            product.id = dr("id")
            product.name = dr("pname")
            If dr("num").ToString.Length = 0 Then
                product.num = ""
            Else
                product.num = dr("num").ToString
            End If
            If dr("remarks").ToString.Length = 0 Then
                product.text = ""
            Else
                product.text = dr("remarks")
            End If
            Return product
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
    Function update(ByVal product As Model.Product) As Boolean

        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "update [product] set [pname]='" & product.name & "',num='" & product.num & "',remarks='" & product.text & "' where id=" & product.id
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
        sqlstr = "delete from [product] where [id]=" & id
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
    Function insert(ByVal product As Model.Product) As Boolean

        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "insert into [product] ([pname],[num],[remarks]) values ('" & product.name & "','" & product.num & "','" & product.text & "')"
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
