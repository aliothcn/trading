Public Class supplier
    Private Sub supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtv()
    End Sub
    Private Sub dtv()
        Dim sbll As New Trading.BLL.SupplierBLL
        dview.DataSource = sbll.getall()
        If dview.ColumnCount <> 0 Then
            dview.Columns(0).Visible = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Mainfrm.toollab1.Text = "试用用户" Then
            MsgBox("试用版无此功能")
            Exit Sub
        End If
        If TextBox1.Text = "" Then
            MsgBox("请输入名称！",, "系统提示")
        Else
            Dim supplier As New Trading.Model.Supplier
            Dim sbll As New Trading.BLL.SupplierBLL
            supplier.name = TextBox1.Text.Trim
            supplier.address = TextBox2.Text.Trim
            supplier.person = TextBox3.Text.Trim
            supplier.tel = TextBox4.Text.Trim
            supplier.phone = TextBox5.Text.Trim
            supplier.scope = TextBox6.Text.Trim
            supplier.text = TextBox7.Text.Trim
            Try
                If sbll.insert(supplier) Then
                    MsgBox("添加成功！",, "系统提示")
                    dtv()
                Else
                    MsgBox("添加失败！",, "系统提示")
                End If
            Catch

            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox8.Text = "" Then
            MsgBox("请选择要修改的记录！",, "系统提示")
        Else
            Dim sbll As New Trading.BLL.SupplierBLL
            Dim supplier As New Trading.Model.Supplier
            supplier.id = TextBox8.Text.Trim
            supplier.Name = TextBox1.Text.Trim
            supplier.address = TextBox2.Text.Trim
            supplier.person = TextBox3.Text.Trim
            supplier.tel = TextBox4.Text.Trim
            supplier.phone = TextBox5.Text.Trim
            supplier.scope = TextBox6.Text.Trim
            supplier.Text = TextBox7.Text.Trim
            Try
                If sbll.update(supplier) Then
                    MsgBox("修改成功！",, "系统提示")
                    dtv()
                Else
                    MsgBox("修改失败！",, "系统提示")
                End If
            Catch

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox8.Text = "" Then
            MsgBox("请选择要删除的记录！",, "系统提示")
        Else

            Dim sbll As New Trading.BLL.SupplierBLL

            Try
                If sbll.delete(Int(TextBox8.Text.Trim)) Then
                    MsgBox("删除成功！",, "系统提示")
                    dtv()
                Else
                    MsgBox("删除失败！",, "系统提示")
                End If
            Catch

            End Try
        End If
    End Sub

    Private Sub dview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dview.CellClick
        TextBox1.Text = dview.Rows(e.RowIndex).Cells(1).Value.ToString
        TextBox2.Text = dview.Rows(e.RowIndex).Cells(2).Value.ToString
        TextBox3.Text = dview.Rows(e.RowIndex).Cells(3).Value.ToString
        TextBox4.Text = dview.Rows(e.RowIndex).Cells(4).Value.ToString
        TextBox5.Text = dview.Rows(e.RowIndex).Cells(5).Value.ToString
        TextBox6.Text = dview.Rows(e.RowIndex).Cells(6).Value.ToString
        TextBox7.Text = dview.Rows(e.RowIndex).Cells(7).Value.ToString
        TextBox8.Text = dview.Rows(e.RowIndex).Cells(0).Value.ToString
    End Sub
End Class