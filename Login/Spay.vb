Public Class Spay
    Dim t As DataTable
    Dim ta As DataTable
    Private Sub Spay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sup_bll As New Trading.BLL.clientBLL
        t = sup_bll.getall
        For i = 0 To t.Rows.Count - 1
            ComboBox1.Items.Add(t.Rows(i).Item(1))
        Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim bll As New Trading.BLL.SaleBLL

        ta = bll.getbycid(t.Rows(ComboBox1.SelectedIndex).Item(0))
        DataGridView1.DataSource = ta
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex > -1 Then
            ta.Rows(e.RowIndex).Item("是否结账") = Not ta.Rows(e.RowIndex).Item("是否结账")
            Dim s As New Trading.Model.sale
            s.id = ta.Rows(e.RowIndex).Item("内部编号")
            s.cid = t.Rows(ComboBox1.SelectedIndex).Item(0)
            s.money = ta.Rows(e.RowIndex).Item("金额")
            s.sday = ta.Rows(e.RowIndex).Item("日期")
            s.text = ta.Rows(e.RowIndex).Item("备注")
            s.ispay = ta.Rows(e.RowIndex).Item("是否结账")
            Dim bll As New Trading.BLL.SaleBLL
            If bll.update(s) Then
            Else
                MsgBox("更新错误！",, "系统提示")
            End If
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class