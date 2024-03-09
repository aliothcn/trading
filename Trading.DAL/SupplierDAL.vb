Imports System.Data.OleDb
Public Class SupplierDAL
    Function getall() As DataTable
        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "select * from [supplier]"
        cmd.CommandText = sqlstr
        conn.Open()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As New Data.DataTable

        Try
            da.Fill(ds, "supplier")
            dt = ds.Tables("supplier")
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
    Function getById(ByVal id As Integer) As Model.Supplier

        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "select * from supplier where id='" & id & "'"
        cmd.CommandText = sqlstr
        conn.Open()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim ds As New DataSet

        Dim supplier As New Model.Supplier
        Try
            conn.Open()
            da.Fill(ds, "supplier")
            Dim dr As DataRow = ds.Tables("supplier").Rows(0)
            supplier.id = dr("id")
            supplier.name = dr("pname")
            supplier.address = dr("address")
            supplier.person = dr("person")
            supplier.tel = dr("tel")
            supplier.phone = dr("phone")
            supplier.scope = dr("scope")
            supplier.text = dr("remarks")
            Return supplier
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
    Function update(ByVal supplier As Model.Supplier) As Boolean

        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "update [supplier] set [pname]='" & supplier.name & "',address='" & supplier.address & "',person='" & supplier.person & "',tel='" & supplier.tel & "',phone='" & supplier.phone & "',scope='" & supplier.scope & "',remarks='" & supplier.text & "' where id=" & supplier.id
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
        sqlstr = "delete from [supplier] where [id]=" & id
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
    Function insert(ByVal supplier As Model.Supplier) As Boolean

        Dim sqlstr As String
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn = New OleDbConnection(Db.connstring())
        cmd.Connection = conn
        sqlstr = "insert into [supplier] ([pname],[address],[person],[tel],[phone],[scope],[remarks]) values ('" & supplier.name & "','" & supplier.address & "','" & supplier.person & "','" & supplier.tel & "','" & supplier.phone & "','" & supplier.scope & "','" & supplier.text & "')"
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
