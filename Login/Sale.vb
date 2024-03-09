﻿Public Class Sale

    Private s_old As New Trading.Model.sale
    Private slist_old As New Trading.Model.slist
    Dim oldrow As Integer

    Private Sub Sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim str_unit As String
        Dim unit() As String
        str_unit = GetStrFromINI("System", "Unit", "")
        unit = str_unit.Split(" ")
        For i = 0 To unit.Length - 1
            ComboBox1.Items.Add(unit(i))
        Next
        ComboBox1.SelectedIndex = 0
        btv()
    End Sub
    Private Sub btv()
        Dim bll As New Trading.BLL.SaleBLL
        dview.DataSource = bll.getall()
        If dview.ColumnCount <> 0 Then
            dview.Columns(0).Visible = False
            dview.Columns(1).Visible = False
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Dispose()
    End Sub

    Private Sub dview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dview.CellClick
        If e.RowIndex > -1 Then

            Dim day As Date
            day = CDate(dview.Rows(e.RowIndex).Cells(3).Value.ToString)
            s_old.id = dview.Rows(e.RowIndex).Cells（0).Value.ToString
            s_old.cid = dview.Rows(e.RowIndex).Cells（1).Value.ToString
            s_old.sday = dview.Rows(e.RowIndex).Cells（3).Value.ToString
            s_old.money = dview.Rows(e.RowIndex).Cells（4).Value.ToString
            s_old.ispay = dview.Rows(e.RowIndex).Cells（5).Value.ToString
            s_old.text = dview.Rows(e.RowIndex).Cells（6).Value.ToString

            TextBox1.Text = dview.Rows(e.RowIndex).Cells(2).Value.ToString
            TextBox2.Text = day.Year & "-" & day.Month & "-" & day.Day
            TextBox3.Text = s_old.money
            TextBox4.Text = s_old.text
            btv1()
        End If
    End Sub
    Private Sub btv1()
        Dim bll As New Trading.BLL.SlistBLL
        DView1.DataSource = bll.getbyid(s_old.id)
        If DView1.ColumnCount <> 0 Then
            DView1.Columns(0).Visible = False
            DView1.Columns(1).Visible = False
        End If

    End Sub

    Private Sub DView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DView1.CellClick
        oldrow = e.RowIndex
        slist_old.id = DView1.Rows(e.RowIndex).Cells（0).Value.ToString
        slist_old.sid = s_old.id
        slist_old.pid = DView1.Rows(e.RowIndex).Cells（1).Value.ToString
        slist_old.price = DView1.Rows(e.RowIndex).Cells（5).Value.ToString
        slist_old.num = DView1.Rows(e.RowIndex).Cells（4).Value.ToString
        slist_old.unit = DView1.Rows(e.RowIndex).Cells（3).Value.ToString
        slist_old.text = DView1.Rows(e.RowIndex).Cells（7).Value.ToString

        TextBox5.Text = DView1.Rows(e.RowIndex).Cells（2).Value.ToString
        TextBox6.Text = DView1.Rows(e.RowIndex).Cells（5).Value.ToString
        TextBox7.Text = DView1.Rows(e.RowIndex).Cells（4).Value.ToString
        ComboBox1.SelectedItem = DView1.Rows(e.RowIndex).Cells（3).Value.ToString
        TextBox9.Text = DView1.Rows(e.RowIndex).Cells（6).Value.ToString
        TextBox10.Text = DView1.Rows(e.RowIndex).Cells(7).Value.ToString

        TextBox22.Text = slist_old.pid
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If s_old.id = 0 Then
            MsgBox("请选择销售单！")
        Else
            If TextBox22.Text.Trim = "" Then
                MsgBox("请输入商品！")
            Else
                If TextBox6.Text.Trim = "" Or TextBox7.Text.Trim = "" Or ComboBox1.SelectedItem = "" Then
                    MsgBox("请输入商品信息")
                Else
                    If Not IsNumeric(TextBox7.Text.Trim) Then
                        MsgBox("数量必须为数字")
                        Exit Sub
                    End If
                    If Not IsNumeric(TextBox6.Text.Trim) Then
                        MsgBox("单价必须为数字")
                        Exit Sub
                    End If
                    Dim bll As New Trading.BLL.SlistBLL
                    Dim bl As New Trading.Model.slist
                    Dim temp As Integer
                    bl.sid = s_old.id
                    bl.pid = TextBox22.Text.Trim
                    bl.price = TextBox6.Text.Trim
                    bl.num = TextBox7.Text.Trim
                    bl.unit = ComboBox1.SelectedItem
                    bl.text = TextBox10.Text.Trim
                    TextBox9.Text = bl.num * bl.price
                    s_old.money = s_old.money + Val(TextBox9.Text.Trim)
                    temp = bll.insert(bl）
                    If temp > 0 Then
                        Dim bbll As New Trading.BLL.SaleBLL
                        If bbll.update(s_old) Then
                            MsgBox("OK")
                        Else
                            bll.delete(temp)
                        End If
                        btv()
                        btv1()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim bll As New Trading.BLL.SaleBLL
        dview.DataSource = bll.getbyday(DateTimePicker1.Text)
        If dview.ColumnCount <> 0 Then
            dview.Columns(0).Visible = False
            dview.Columns(1).Visible = False
        End If
    End Sub

    Private Sub TextBox5_GotFocus(sender As Object, e As EventArgs) Handles TextBox5.GotFocus
        TextBox11.Select()
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If e.KeyChar = ChrW(13) Then
            Dim bll As New Trading.BLL.ProductBLL
            Dim p As New Trading.Model.Product
            p = bll.getbyid(Val(TextBox11.Text))
            Try
                TextBox5.Text = p.name
                TextBox11.Text = ""
                TextBox22.Text = p.id
            Catch
                TextBox5.Text = ""
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If slist_old.id = 0 Then
            MsgBox("请选择要修改的条目！")
        Else
            If Not IsNumeric(TextBox7.Text.Trim) Then
                MsgBox("数量必须为数字")
                Exit Sub
            End If
            If Not IsNumeric(TextBox6.Text.Trim) Then
                MsgBox("单价必须为数字")
                Exit Sub
            End If
            Dim bll As New Trading.BLL.SlistBLL
            Dim bl As New Trading.Model.slist
            bl.id = slist_old.id
            bl.sid = s_old.id
            bl.pid = TextBox22.Text.Trim
            bl.price = TextBox6.Text.Trim
            bl.num = TextBox7.Text.Trim
            bl.unit = ComboBox1.SelectedItem
            bl.text = TextBox10.Text.Trim
            TextBox9.Text = bl.num * bl.price
            s_old.money = s_old.money - slist_old.price * slist_old.num + Val(TextBox9.Text.Trim)
            If bll.update(bl） Then
                Dim bbll As New Trading.BLL.SaleBLL
                If bbll.update(s_old) Then

                Else
                    bll.delete(slist_old.id)
                    MsgBox("错误")
                End If
                btv()
                btv1()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If slist_old.id = 0 Then
            MsgBox("请选择要修改的条目！")
        Else
            Dim bll As New Trading.BLL.SlistBLL
            Dim temp As Integer
            TextBox9.Text = Val(TextBox7.Text.Trim) * Val(TextBox6.Text.Trim)
            temp = s_old.money
            s_old.money = s_old.money - Val(TextBox9.Text.Trim)
            Dim bbll As New Trading.BLL.SaleBLL
            If bbll.update(s_old) Then
                If bll.delete(slist_old.id) Then
                    MsgBox("OK")
                Else
                    s_old.money = temp
                    bbll.update(s_old)

                End If
                btv()
                btv1()
            End If
        End If
    End Sub


    Private Sub TextBox6_LostFocus(sender As Object, e As EventArgs) Handles TextBox6.LostFocus
        TextBox9.Text = Val(TextBox7.Text.Trim) * Val(TextBox6.Text.Trim)
    End Sub

    Private Sub TextBox7_LostFocus(sender As Object, e As EventArgs) Handles TextBox7.LostFocus
        TextBox9.Text = Val(TextBox7.Text.Trim) * Val(TextBox6.Text.Trim)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Mainfrm.toollab1.Text = "试用用户" Then
            MsgBox("试用版无此功能")
            Exit Sub
        End If
        Dim tab As New DataTable
        Dim strrmb As New Rmb
        strrmb.InputString = TextBox3.Text.Trim
        tab.Columns.Add("商品名称", GetType(String))
        tab.Columns.Add("单位", GetType(String))
        tab.Columns.Add("数量", GetType(Decimal))
        tab.Columns.Add("单价", GetType(Decimal))
        tab.Columns.Add("小计", GetType(Decimal))
        tab.Columns.Add("备注", GetType(String))
        For i = 0 To DView1.Rows.Count - 1
            tab.Rows.Add()
            tab.Rows(i).Item("商品名称") = DView1.Rows(i).Cells(2).Value.ToString
            tab.Rows(i).Item("单位") = DView1.Rows(i).Cells(3).Value.ToString
            tab.Rows(i).Item("数量") = DView1.Rows(i).Cells(4).Value.ToString
            tab.Rows(i).Item("单价") = Format(Val(DView1.Rows(i).Cells（5).Value.ToString), "0.00")
            tab.Rows(i).Item("小计") = Format(Val(DView1.Rows(i).Cells（6).Value.ToString), "0.00")
            tab.Rows(i).Item("备注") = DView1.Rows(i).Cells（7).Value.ToString
        Next
        If tab.Rows.Count > 0 Then
            Dim pt As New PrintDataTable(tab)
            pt.SetHeadText = GetStrFromINI("System", "Header", "") & "-销售单"
            pt.SetSubHeadLeftText = TextBox1.Text.Trim
            pt.SetSubHeadRightText = TextBox2.Text.Trim
            pt.SetSubFootRightText = "合计：¥" & Format（Val(TextBox3.Text.Trim）, "0.00"） & "  人民币：" & strrmb.OutString
            pt.SetFootText = GetStrFromINI("System", "Footer", "")
            pt.Print()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DView1.CellValueChanged
        Try
            TextBox5.Text = DView1.Rows(e.RowIndex).Cells（2).Value.ToString
            TextBox6.Text = DView1.Rows(e.RowIndex).Cells（5).Value.ToString
            TextBox7.Text = DView1.Rows(e.RowIndex).Cells（4).Value.ToString
            ComboBox1.SelectedItem = DView1.Rows(e.RowIndex).Cells（3).Value.ToString
            TextBox9.Text = DView1.Rows(e.RowIndex).Cells（6).Value.ToString
            TextBox10.Text = DView1.Rows(e.RowIndex).Cells(7).Value.ToString

            TextBox22.Text = slist_old.pid
            If Not IsNumeric(TextBox7.Text.Trim) Then
                MsgBox("数量必须为数字")
                Exit Sub
            End If
            If Not IsNumeric(TextBox6.Text.Trim) Then
                MsgBox("单价必须为数字")
                Exit Sub
            End If
            Button3_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        oldrow = e.RowIndex
    End Sub

    Private Sub DView1_KeyUp(sender As Object, e As KeyEventArgs) Handles DView1.KeyUp
        slist_old.id = DView1.Rows(DView1.CurrentCell.RowIndex).Cells（0).Value.ToString
        slist_old.sid = s_old.id
        slist_old.pid = DView1.Rows(DView1.CurrentCell.RowIndex).Cells（1).Value.ToString
        slist_old.price = DView1.Rows(DView1.CurrentCell.RowIndex).Cells（5).Value.ToString
        slist_old.num = DView1.Rows(DView1.CurrentCell.RowIndex).Cells（4).Value.ToString
        slist_old.unit = DView1.Rows(DView1.CurrentCell.RowIndex).Cells（3).Value.ToString
        slist_old.text = DView1.Rows(DView1.CurrentCell.RowIndex).Cells（7).Value.ToString
        'MsgBox(slist_old.price)
    End Sub
End Class