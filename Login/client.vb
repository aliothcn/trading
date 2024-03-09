Public Class client
    Private Sub client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtv()
    End Sub
    Private Sub dtv()
        Dim cbll As New Trading.BLL.clientBLL
        dview.DataSource = cbll.getall()
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
            Dim cl As New Trading.Model.Client
            Dim cbll As New Trading.BLL.clientBLL
            cl.name = TextBox1.Text.Trim
            cl.address = TextBox2.Text.Trim
            cl.person = TextBox3.Text.Trim
            cl.tel = TextBox4.Text.Trim
            cl.phone = TextBox5.Text.Trim
            cl.scope = TextBox6.Text.Trim
            cl.text = TextBox7.Text.Trim
            Try
                If cbll.insert(cl) Then
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
            Dim cbll As New Trading.BLL.clientBLL
            Dim cl As New Trading.Model.Client
            cl.id = TextBox8.Text.Trim
            cl.name = TextBox1.Text.Trim
            cl.address = TextBox2.Text.Trim
            cl.person = TextBox3.Text.Trim
            cl.tel = TextBox4.Text.Trim
            cl.phone = TextBox5.Text.Trim
            cl.scope = TextBox6.Text.Trim
            cl.text = TextBox7.Text.Trim
            Try
                If cbll.update(cl) Then
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

            Dim cbll As New Trading.BLL.clientBLL

            Try
                If cbll.delete(Int(TextBox8.Text.Trim)) Then
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