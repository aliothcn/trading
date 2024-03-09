Public Class product
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("请输入名称！",, "系统提示")
        ElseIf TextBox2.Text = "" Then
            MsgBox("请输入编号！",, "系统提示")
        Else
            Dim product As New Trading.Model.Product
            Dim pbll As New Trading.BLL.ProductBLL
            product.name = TextBox1.Text.Trim
            product.num = TextBox2.Text.Trim
            product.text = TextBox3.Text.Trim
            Try
                If pbll.insert(product) Then
                    MsgBox("添加成功！",, "系统提示")
                    dtv()
                Else
                    MsgBox("添加失败！",, "系统提示")
                End If
            Catch

            End Try
        End If
    End Sub

    Private Sub product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtv()
    End Sub
    Private Sub dtv()
        Dim pbll As New Trading.BLL.ProductBLL
        dview.DataSource = pbll.getall()
        If dview.ColumnCount <> 0 Then
            dview.Columns(0).Visible = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Dispose()
    End Sub

    Private Sub dview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dview.CellClick
        TextBox1.Text = dview.Rows(e.RowIndex).Cells(1).Value.ToString
        TextBox2.Text = dview.Rows(e.RowIndex).Cells(2).Value.ToString
        TextBox3.Text = dview.Rows(e.RowIndex).Cells(3).Value.ToString
        TextBox4.Text = dview.Rows(e.RowIndex).Cells(0).Value.ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox4.Text = "" Then
            MsgBox("请选择要删除的记录！",, "系统提示")
        Else

            Dim pbll As New Trading.BLL.ProductBLL

            Try
                If pbll.delete(Int(TextBox4.Text.Trim)) Then
                    MsgBox("删除成功！",, "系统提示")
                    dtv()
                Else
                    MsgBox("删除失败！",, "系统提示")
                End If
            Catch

            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox4.Text = "" Then
            MsgBox("请选择要修改的记录！",, "系统提示")
        Else
            Dim pbll As New Trading.BLL.ProductBLL
            Dim product As New Trading.Model.Product
            product.id = TextBox4.Text.Trim
            product.name = TextBox1.Text.ToString.Trim
            product.num = TextBox2.Text.ToString.Trim
            product.text = TextBox3.Text.ToString.Trim
            Try
                If pbll.update(product) Then
                    MsgBox("修改成功！",, "系统提示")
                    dtv()
                Else
                    MsgBox("修改失败！",, "系统提示")
                End If
            Catch

            End Try
        End If
    End Sub

End Class