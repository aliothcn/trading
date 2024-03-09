Public Class buyBLL
#Region "查询所有记录"
    Public Function getall() As DataTable
        Dim dal As New DAL.buyDAL
        Return dal.getall
    End Function
#End Region
#Region "按供应商编号查询"
    Public Function getbysid(sid) As DataTable
        Dim dal As New DAL.BuyDAL
        Return dal.getbysid(sid)
    End Function
#End Region
#Region "按供应商编号查询所有未结账"
    Public Function getbysid(sid, b) As DataTable
        Dim dal As New DAL.BuyDAL
        Return dal.getbysid(sid, True)
    End Function
#End Region
#Region "按日期查询记录"
    Public Function getbyday(ByVal day As Date) As DataTable
        Dim dal As New DAL.BuyDAL
        Return dal.getByDay(day)
    End Function
#End Region
#Region "添加一条记录"
    Public Function insert(ByVal b As Model.buy) As Integer
        Dim dal As New DAL.BuyDAL
        Return dal.insert(b)
    End Function
#End Region
#Region "修改一条记录"
    Public Function update(ByVal b As Model.buy) As Boolean
        Dim dal As New DAL.BuyDAL
        Return dal.update(b)
    End Function
#End Region
#Region "删除一条记录"
    Public Function delete(ByVal id As Integer) As Boolean
        Dim dal As New DAL.BuyDAL
        Return dal.Delete(id)
    End Function
#End Region
End Class
