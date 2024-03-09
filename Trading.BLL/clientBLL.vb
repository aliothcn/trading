Public Class clientBLL

#Region "查询所有记录"
    Public Function getall() As DataTable
        Dim cdal As New DAL.clientDAL
        Return cdal.getall
    End Function
#End Region
#Region "查询一条记录"
    Public Function getbyid(ByVal id As Integer) As Model.Client
        Dim cdal As New DAL.clientDAL
        Return cdal.getById(id)
    End Function
#End Region
#Region "添加一条记录"
    Public Function insert(ByVal client As Model.Client) As Boolean
        Dim cdal As New DAL.clientDAL
        Return cdal.insert(client)
    End Function
#End Region
#Region "修改一条记录"
    Public Function update(ByVal client As Model.Client) As Boolean
        Dim cdal As New DAL.clientDAL
        Return cdal.update(client)
    End Function
#End Region
#Region "删除一条记录"
    Public Function delete(ByVal id As Integer) As Boolean
        Dim cdal As New DAL.clientDAL
        Return cdal.Delete(id)
    End Function
#End Region

End Class
