Public Class bpayp

    Dim t As DataTable
    Dim ta As DataTable


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim bll As New Trading.BLL.buyBLL

        ta = bll.getbysid(t.Rows(ComboBox1.SelectedIndex).Item(0), 1)
        DataGridView1.DataSource = ta
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
    Private Sub bpayp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sup_bll As New Trading.BLL.SupplierBLL
        t = sup_bll.getall
        For i = 0 To t.Rows.Count - 1
            ComboBox1.Items.Add(t.Rows(i).Item(1))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bll As New Trading.BLL.buyBLL

        ta = bll.getbysid("%", 1)
        DataGridView1.DataSource = ta
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If ta IsNot Nothing Then
            Dim tab As New DataTable

            tab.Columns.Add("供应商名称", GetType(String))
            tab.Columns.Add("日期", GetType(String))
            tab.Columns.Add("金额", GetType(Decimal))
            tab.Columns.Add("备注", GetType(String))
            For i = 0 To ta.Rows.Count - 1
                tab.Rows.Add()
                tab.Rows(i).Item("供应商名称") = ta.Rows(i).Item("供应商名称")
                tab.Rows(i).Item("日期") = Format(ta.Rows(i).Item("日期"), "yyyy-MM-dd")
                tab.Rows(i).Item("金额") = Format(ta.Rows(i).Item("金额"), "0.00")
                tab.Rows(i).Item("备注") = ta.Rows(i).Item("备注")
            Next
            Dim pt As New PrintDataTable(tab)
            pt.SetHeadText = GetStrFromINI("System", "Header", "") & "-采购未结账单"
            pt.SetSubHeadLeftText = ""
            pt.SetSubHeadRightText = ""
            pt.SetSubFootRightText = ""
            pt.SetFootText = ""
            pt.Print()
        End If
    End Sub
End Class