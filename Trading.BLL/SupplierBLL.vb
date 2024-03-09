Public Class SupplierBLL

#Region "查询所有记录"
    Public Function getall() As DataTable
        Dim sdal As New DAL.SupplierDAL
        Return sdal.getall
    End Function
#End Region
#Region "查询一条记录"
    Public Function getbyid(ByVal id As Integer) As Model.Supplier
        Dim sdal As New DAL.SupplierDAL
        Return sdal.getById(id)
    End Function
#End Region
#Region "添加一条记录"
    Public Function insert(ByVal supplier As Model.Supplier) As Boolean
        Dim sdal As New DAL.SupplierDAL
        Return sdal.insert(supplier)
    End Function
#End Region
#Region "修改一条记录"
    Public Function update(ByVal supplier As Model.Supplier) As Boolean
        Dim sdal As New DAL.SupplierDAL
        Return sdal.update(supplier)
    End Function
#End Region
#Region "删除一条记录"
    Public Function delete(ByVal id As Integer) As Boolean
        Dim sdal As New DAL.SupplierDAL
        Return sdal.Delete(id)
    End Function
#End Region

End Class
