Public Class SaleBLL
#Region "查询所有记录"
    Public Function getall() As DataTable
        Dim dal As New DAL.SaleDAL
        Return dal.getall
        End Function
#End Region
#Region "按客户编号查询"
    Public Function getbycid(cid) As DataTable
        Dim dal As New DAL.SaleDAL
        Return dal.getbycid(cid)
    End Function
#End Region
#Region "按客户编号查询所有未结账"
    Public Function getbycid(cid, b) As DataTable
        Dim dal As New DAL.SaleDAL
        Return dal.getbycid(cid, True)
    End Function
#End Region
#Region "按日期查询记录"
    Public Function getbyday(ByVal day As Date) As DataTable
        Dim dal As New DAL.SaleDAL
        Return dal.getByDay(day)
        End Function
#End Region
#Region "添加一条记录"
    Public Function insert(ByVal b As Model.sale) As Integer
        Dim dal As New DAL.SaleDAL
        Return dal.insert(b)
    End Function
#End Region
#Region "修改一条记录"
    Public Function update(ByVal b As Model.sale) As Boolean
        Dim dal As New DAL.SaleDAL
        Return dal.update(b)
    End Function
#End Region
#Region "删除一条记录"
    Public Function delete(ByVal id As Integer) As Boolean
        Dim dal As New DAL.SaleDAL
        Return dal.Delete(id)
        End Function
#End Region

    End Class
