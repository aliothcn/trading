Public Class Counts
    Dim t As DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Mainfrm.toollab1.Text = "试用用户" Then
            MsgBox("试用版无此功能")
        Else
            Dim bll As New Trading.BLL.SlistBLL
            t = bll.count(DateTimePicker1.Text)
            DataGridView1.DataSource = t
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If t.Rows.Count > 0 Then
            Dim ta As New DataTable
            ta.Columns.Add("商品名称1", GetType(String))
            ta.Columns.Add("数量1", GetType(String))
            ta.Columns.Add("客户1", GetType(String))
            ta.Columns.Add("|", GetType(String))
            ta.Columns.Add("商品名称2", GetType(String))
            ta.Columns.Add("数量2", GetType(String))
            ta.Columns.Add("客户2", GetType(String))
            For i = 0 To t.Rows.Count - 1
                If i Mod 2 = 0 Then
                    ta.Rows.Add()
                    ta.Rows(i \ 2).Item(0) = t.Rows(i).Item(0)
                    ta.Rows(i \ 2).Item(1) = t.Rows(i).Item(1)
                    ta.Rows(i \ 2).Item(2) = t.Rows(i).Item(2)
                ElseIf i Mod 2 = 1 Then

                    ta.Rows(i \ 2).Item(4) = t.Rows(i).Item(0)
                    ta.Rows(i \ 2).Item(5) = t.Rows(i).Item(1)
                    ta.Rows(i \ 2).Item(6) = t.Rows(i).Item(2)
                End If
            Next
            Dim pt As New PrintDataTable(t)
            pt.SetHeadText = GetStrFromINI("System", "Header", "") & "-采购日报表"
            pt.SetSubHeadLeftText = ""
            pt.SetSubHeadRightText = DateTimePicker1.Text
            pt.SetSubFootRightText = ""
            pt.SetFootText = GetStrFromINI("System", "Footer", "")
            pt.Print()
        End If
    End Sub

    Private Sub Counts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class