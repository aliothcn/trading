Public Class Slist

    Dim t As New DataTable("slist")
    Dim t_sup As New DataTable("c")

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Dispose()
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If e.KeyChar = ChrW(13) Then
            Dim bll As New Trading.BLL.ProductBLL
            Dim p As New Trading.Model.Product
            p = bll.getbyid(TextBox11.Text)
            Try
                TextBox5.Text = p.name
                TextBox11.Text = ""
                TextBox22.Text = p.id
            Catch
                TextBox5.Text = ""
            End Try
            TextBox8.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox22.Text.Trim = "" Or TextBox5.Text.Trim = "" Then
            MsgBox("请输入商品！",, "系统提示")
        ElseIf TextBox6.Text.Trim = "" Or TextBox7.Text.Trim = "" Or TextBox9.Text.Trim = "" Then
            MsgBox("请输入商品信息！",, "系统提示")
        Else
            Dim pr As New Trading.Model.Price 'pr.id=0  无法修改

            pr.pid = Val(TextBox22.Text.Trim)
            pr.cname = Mid(ComboBox1.Text, 1, 4)
            pr.sday = DateTimePicker1.Text
            pr.price = Val(TextBox6.Text)
            Dim prbll As New Trading.BLL.PriceBLL
            If prbll.getone(pr.pid, pr.cname) Is Nothing Then
                prbll.insert(pr)
            Else
                pr.id = prbll.getone(pr.pid, pr.cname).id
                prbll.update(pr)
            End If
            If Not IsNumeric(TextBox7.Text.Trim) Then
                MsgBox("数量必须为数字")
                Exit Sub
            End If
            If Not IsNumeric(TextBox6.Text.Trim) Then
                MsgBox("单价必须为数字")
                Exit Sub
            End If
            TextBox9.Text = Val(TextBox6.Text.Trim) * Val(TextBox7.Text.Trim)
            Dim dr As DataRow = t.NewRow
            dr("pid") = TextBox22.Text.Trim

            dr("商品名称") = TextBox5.Text.Trim
            dr("单位") = ComboBox2.Text.Trim
            dr("数量") = TextBox7.Text.Trim
            dr("单价") = TextBox6.Text.Trim
            dr("小计") = TextBox9.Text.Trim
            dr("备注") = TextBox10.Text.Trim
            t.Rows.Add(dr)
            TextBox1.Text = Val(TextBox1.Text.Trim) + Val(TextBox9.Text.Trim)
        End If
    End Sub

    Private Sub TextBox6_LostFocus(sender As Object, e As EventArgs) Handles TextBox6.LostFocus
        TextBox9.Text = Val(TextBox6.Text.Trim) * Val(TextBox7.Text.Trim)
    End Sub

    Private Sub TextBox7_LostFocus(sender As Object, e As EventArgs) Handles TextBox7.LostFocus
        TextBox9.Text = Val(TextBox6.Text.Trim) * Val(TextBox7.Text.Trim)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text.Trim = "" Then
            MsgBox("请选择商品！",, "系统提示")
        Else
            t.Rows.RemoveAt(Val(TextBox2.Text.Trim))
            TextBox1.Text = Val(TextBox1.Text.Trim) - Val(TextBox9.Text.Trim)
        End If
    End Sub


    Private Sub DView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DView.CellClick
        If e.RowIndex > -1 Then
            TextBox2.Text = e.RowIndex
            Try
                TextBox5.Text = t.Rows(e.RowIndex).Item("商品名称")
                TextBox6.Text = t.Rows(e.RowIndex).Item("单价")
                TextBox7.Text = t.Rows(e.RowIndex).Item("数量")
                ComboBox2.Text = t.Rows(e.RowIndex).Item("单位").ToString
                TextBox9.Text = t.Rows(e.RowIndex).Item("小计")
                TextBox10.Text = t.Rows(e.RowIndex).Item("备注").ToString

                TextBox22.Text = t.Rows(e.RowIndex).Item("pid")
            Catch
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox2.Text.Trim = "" Then
            MsgBox("请选择商品！",, "系统提示")
        Else

            TextBox9.Text = Val(TextBox6.Text.Trim) * Val(TextBox7.Text.Trim)
            Dim temp As Decimal
            temp = t.Rows(Val(TextBox2.Text.Trim)).Item("小计")
            t.Rows(Val(TextBox2.Text.Trim)).Item("商品名称") = TextBox5.Text.Trim
            t.Rows(Val(TextBox2.Text.Trim)).Item("pid") = TextBox22.Text.Trim
            t.Rows(Val(TextBox2.Text.Trim)).Item("单价") = TextBox6.Text.Trim
            t.Rows(Val(TextBox2.Text.Trim)).Item("数量") = TextBox7.Text.Trim
            t.Rows(Val(TextBox2.Text.Trim)).Item("单位") = ComboBox2.Text.Trim
            t.Rows(Val(TextBox2.Text.Trim)).Item("小计") = TextBox9.Text.Trim
            t.Rows(Val(TextBox2.Text.Trim)).Item("备注") = TextBox10.Text.Trim
            TextBox1.Text = Val(TextBox1.Text.Trim) - temp + Val(TextBox9.Text.Trim)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If t.Rows.Count > 0 Then
            If ComboBox1.SelectedItem <> "" Then
                Dim b As New Trading.Model.sale
                b.cid = t_sup.Rows(ComboBox1.SelectedIndex).Item(0)
                b.sday = DateTimePicker1.Text
                b.money = Val(TextBox1.Text.Trim)
                b.ispay = CheckBox1.Checked
                b.text = TextBox3.Text.Trim
                Dim bb As New Trading.BLL.SaleBLL
                Dim temp As Integer
                temp = bb.insert(b)
                If temp > 0 Then
                    For i = 0 To t.Rows.Count - 1
                        Dim bl As New Trading.Model.slist
                        bl.sid = temp
                        bl.pid = t.Rows(i).Item("pid")
                        bl.price = t.Rows(i).Item("单价")
                        bl.num = t.Rows(i).Item("数量")
                        bl.unit = t.Rows(i).Item("单位")
                        bl.text = t.Rows(i).Item("备注").ToString
                        Dim blist_bll As New Trading.BLL.SlistBLL
                        t.Rows(i).Item("id") = blist_bll.insert(bl)
                    Next

                    MsgBox("添加成功！",, "系统提示")
                End If
            Else
                    MsgBox("请选择客户")

            End If
        Else
                MsgBox("没有添加商品")
        End If
    End Sub
    Private Sub Slist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sup_bll As New Trading.BLL.clientBLL
        t_sup = sup_bll.getall
        For i = 0 To t_sup.Rows.Count - 1
            ComboBox1.Items.Add(t_sup.Rows(i).Item(1))
        Next

        t.Columns.Add("id", GetType(Integer))
        t.Columns.Add("pid", GetType(Integer))
        t.Columns.Add("商品名称", GetType(String))
        t.Columns.Add("单位", GetType(String))
        t.Columns.Add("数量", GetType(Decimal))
        t.Columns.Add("单价", GetType(Decimal))
        t.Columns.Add("小计", GetType(Decimal))
        t.Columns.Add("备注", GetType(String))
        DView.DataSource = t
        DView.Columns(0).Visible = False
        DView.Columns(1).Visible = False
        Dim str_unit As String
        Dim unit() As String
        str_unit = GetStrFromINI("System", "Unit", "")
        unit = str_unit.Split(" ")
        For i = 0 To unit.Length - 1
            ComboBox2.Items.Add(unit(i))
        Next
        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If ComboBox1.SelectedItem <> "" Then
            Dim tab As New DataTable
            Dim strrmb As New Rmb
            strrmb.InputString = TextBox1.Text.Trim
            tab.Columns.Add("商品名称", GetType(String))
            tab.Columns.Add("单位", GetType(String))
            tab.Columns.Add("数量", GetType(Decimal))
            tab.Columns.Add("单价", GetType(Decimal))
            tab.Columns.Add("小计", GetType(Decimal))
            tab.Columns.Add("备注", GetType(String))
            If t.Rows.Count > 0 Then
                For i = 0 To t.Rows.Count - 1
                    tab.Rows.Add()
                    tab.Rows(i).Item("商品名称") = t.Rows(i).Item("商品名称")
                    tab.Rows(i).Item("单位") = t.Rows(i).Item("单位")
                    tab.Rows(i).Item("数量") = t.Rows(i).Item("数量")
                    tab.Rows(i).Item("单价") = Format(t.Rows(i).Item("单价"), "0.00")
                    tab.Rows(i).Item("小计") = Format(t.Rows(i).Item("小计"), "0.00")
                    tab.Rows(i).Item("备注") = t.Rows(i).Item("备注")
                Next
                Dim pt As New PrintDataTable(tab)
                pt.SetHeadText = GetStrFromINI("System", "Header", "") & "-销售单"
                pt.SetSubHeadLeftText = ComboBox1.Text
                pt.SetSubHeadRightText = DateTimePicker1.Text
                pt.SetSubFootRightText = "合计：¥" & Format（Val(TextBox1.Text.Trim）, "0.00"） & "  人民币：" & strrmb.OutString
                pt.SetFootText = GetStrFromINI("System", "Footer", "")
                pt.Print()
            Else
                MsgBox("没有添加商品")
            End If
        Else
            MsgBox("请选择客户")
        End If
    End Sub

    Private Sub TextBox6_GotFocus(sender As Object, e As EventArgs) Handles TextBox6.GotFocus
        If TextBox8.Text = "" Then
            Dim pr As New Trading.Model.Price
            Dim prbll As New Trading.BLL.PriceBLL
            pr = prbll.getone(Val(TextBox22.Text.Trim), Mid(ComboBox1.Text, 1, 4), DateTimePicker1.Text)
            If pr Is Nothing Then
                TextBox8.Visible = False
            Else
                TextBox8.Visible = True
                TextBox8.Text = pr.price
            End If
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox8_Click(sender As Object, e As EventArgs) Handles TextBox8.Click
        TextBox6.Text = TextBox8.Text.Trim
    End Sub

    Private Sub TextBox5_LostFocus(sender As Object, e As EventArgs) Handles TextBox5.LostFocus
        Dim bll As New Trading.BLL.ProductBLL
        Dim p As New Trading.Model.Product
        p = bll.getbyname(TextBox5.Text)
        Try
            TextBox5.Text = p.name
            TextBox11.Text = ""
            TextBox22.Text = p.id
        Catch
            TextBox5.Text = ""
        End Try
        TextBox8.Text = ""
        'TextBox22.Visible = True
    End Sub
    Private Sub isok()
        Dim heji As Decimal
        For i = 0 To t.Rows.Count - 1
            Try
                Dim bll As New Trading.BLL.ProductBLL
                Dim p As New Trading.Model.Product
                p = bll.getbyname(t.Rows(i).Item("商品名称"))
                t.Rows(i).Item("pid") = p.id
                'TextBox22.Text = p.id
            Catch
                MsgBox("商品库中没有商品:" & t.Rows(i).Item("商品名称"),, "系统提示")
                Exit For
            End Try
            If IsNumeric(t.Rows(i).Item("单价")) And IsNumeric(t.Rows(i).Item("数量")) Then
                t.Rows(i).Item("小计") = t.Rows(i).Item("单价") * t.Rows(i).Item("数量")
                heji = heji + t.Rows(i).Item("小计")
            Else
                MsgBox(t.Rows(i).Item("商品名称") & "的单价、数量必须为数字",, "系统提示")
                Exit For
            End If
            If t.Rows(i).Item("单位").ToString = "" Then
                t.Rows(i).Item("单位") = "斤"
            End If
        Next
        TextBox1.Text = heji
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        isok()
    End Sub
End Class