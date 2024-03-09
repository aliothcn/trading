Public Class BlistBLL
#Region "查询记录 by buy_id"
    Public Function getbyid(ByVal id As Integer) As DataTable
        Dim dal As New DAL.BlistDAL
        Return dal.getByid(id)
    End Function
#End Region
#Region "添加一条记录"
    Public Function insert(ByVal b As Model.blist) As Integer
        Dim dal As New DAL.BlistDAL
        Return dal.insert(b)
    End Function
#End Region
#Region "修改一条记录"
    Public Function update(ByVal b As Model.blist) As Boolean
        Dim dal As New DAL.BlistDAL
        Return dal.update(b)
    End Function
#End Region
#Region "删除一条记录"
    Public Function delete(ByVal id As Integer) As Boolean
        Dim dal As New DAL.BlistDAL
        Return dal.Delete(id)
    End Function
#End Region
End Class
