Public Class PriceBLL


#Region "查询一条记录"
    Public Function getone(ByVal pid As Integer, ByVal cname As String, ByVal sday As DateTime) As Model.Price
        Dim dal As New DAL.PriceDAL
        Return dal.getone(pid, cname, sday)
    End Function
    Public Function getone(ByVal pid As Integer, ByVal cname As String) As Model.Price
        Dim dal As New DAL.PriceDAL
        Return dal.getone(pid, cname)
    End Function
#End Region
#Region "添加一条记录"
    Public Function insert(ByVal p As Model.Price) As Boolean
        Dim cdal As New DAL.PriceDAL
        Return cdal.insert(p)
    End Function
#End Region
#Region "修改一条记录"
    Public Function update(ByVal p As Model.Price) As Boolean
        Dim cdal As New DAL.PriceDAL
        Return cdal.update(p)
    End Function
#End Region
#Region "删除一条记录"
    Public Function delete(ByVal id As Integer) As Boolean
        Dim cdal As New DAL.PriceDAL
        Return cdal.Delete(id)
    End Function
#End Region

End Class
