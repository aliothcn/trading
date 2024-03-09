Public Class ProductBLL
#Region "查询所有记录"
    Public Function getall() As DataTable
        Dim pdal As New DAL.ProductDAL
        Return pdal.getall
    End Function
#End Region
#Region "查询一条记录by id"
    Public Function getbyid(ByVal id As String) As Model.Product
        Dim pdal As New DAL.ProductDAL
        Return pdal.getById(id)
    End Function
#End Region
#Region "查询一条记录by name"
    Public Function getbyname(ByVal name As String) As Model.Product
        Dim pdal As New DAL.ProductDAL
        Return pdal.getByName(name)
    End Function
#End Region
#Region "添加一条记录"
    Public Function insert(ByVal product As Model.Product) As Boolean
        Dim pdal As New DAL.ProductDAL
        Return pdal.insert(product)
    End Function
#End Region
#Region "修改一条记录"
    Public Function update(ByVal product As Model.Product) As Boolean
        Dim pdal As New DAL.ProductDAL
        Return pdal.update(product)
    End Function
#End Region
#Region "删除一条记录"
    Public Function delete(ByVal id As Integer) As Boolean
        Dim pdal As New DAL.ProductDAL
        Return pdal.Delete(id)
    End Function
#End Region

End Class
