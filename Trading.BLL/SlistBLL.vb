Public Class SlistBLL
#Region "查询记录 by buy_id"
    Public Function getbyid(ByVal id As Integer) As DataTable
        Dim dal As New DAL.SlistDAL
        Return dal.getByid(id)
    End Function
#End Region
#Region "添加一条记录"
    Public Function insert(ByVal b As Model.slist) As Integer
        Dim dal As New DAL.SlistDAL
        Return dal.insert(b)
    End Function
#End Region
#Region "修改一条记录"
    Public Function update(ByVal b As Model.slist) As Boolean
        Dim dal As New DAL.SlistDAL
        Return dal.update(b)
    End Function
#End Region
#Region "删除一条记录"
    Public Function delete(ByVal id As Integer) As Boolean
        Dim dal As New DAL.SlistDAL
        Return dal.Delete(id)
    End Function
#End Region

#Region "按日期统计"
    Public Function count(ByVal sday As DateTime) As DataTable
        Dim dal As New DAL.SlistDAL
        Return dal.count(sday)
    End Function
#End Region
End Class
