Public Class Mainfrm
    Public username As String = ""

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = GetStrFromINI("System", "Title", "")
        Me.Width = My.Computer.Screen.Bounds.Width
        Me.Height = My.Computer.Screen.Bounds.Height - 50
        Me.Left = 0
        Me.Top = 0
        '显示登录对话框
        Dim loginFrm As New Login
        loginFrm.ShowDialog()
        '合法进入系统
        If loginFrm.bResult = True Then
            username = loginFrm.txb_name.Text
            Me.toollab1.Text = username
            My.Forms.Login.Close()
        Else
            Me.toollab1.Text = "试用用户"
            Me.Hide()
        End If
        Toollab2.Text = DateString & "  " & TimeString
    End Sub

    Private Sub 退出系统ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出系统ToolStripMenuItem.Click, ToolStripButton7.Click
        End
    End Sub


    Private Sub 修改密码ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 修改密码ToolStripMenuItem.Click
        closeall()
        Changpwd.Show()
    End Sub

    Private Sub 商品ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 商品ToolStripMenuItem.Click, ToolStripButton4.Click
        closeall()
        product.Show()
    End Sub

    Private Sub 供应商ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 供应商ToolStripMenuItem.Click, ToolStripButton6.Click
        closeall()
        supplier.Show()
    End Sub

    Private Sub 客户ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 客户ToolStripMenuItem.Click, ToolStripButton5.Click
        closeall()
        client.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Toollab2.Text = DateString & "  " & TimeString
    End Sub


    Private Sub closeall()
        My.Forms.backup.Dispose()
        My.Forms.Blist.Dispose()
        My.Forms.bpay.Dispose()
        My.Forms.bpayp.Dispose()
        My.Forms.Buy.Dispose()
        My.Forms.Changpwd.Dispose()
        My.Forms.client.Dispose()
        My.Forms.Config.Dispose()
        My.Forms.Counts.Dispose()
        My.Forms.Input.Dispose()
        My.Forms.Login.Dispose()
        My.Forms.product.Dispose()
        'My.Forms.Reg.Dispose()
        My.Forms.Sale.Dispose()
        My.Forms.Slist.Dispose()
        My.Forms.Spay.Dispose()
        My.Forms.spayp.Dispose()
        My.Forms.supplier.Dispose()
    End Sub

    Private Sub 查看ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 查看ToolStripMenuItem.Click
        closeall()
        Buy.Show()
    End Sub

    Private Sub 新增ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新增ToolStripMenuItem.Click, ToolStripButton2.Click '采购
        closeall()
        Blist.Show()
    End Sub

    Private Sub 销售开单ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 销售开单ToolStripMenuItem.Click, ToolStripButton1.Click
        closeall()
        Slist.Show()
    End Sub

    Private Sub 销售数据查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 销售数据查询ToolStripMenuItem.Click
        closeall()
        Sale.Show()

    End Sub

    Private Sub 数据备份ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 数据备份ToolStripMenuItem.Click
        closeall()
        backup.Show()
    End Sub

    Private Sub 采购清单ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 采购清单ToolStripMenuItem.Click, ToolStripButton8.Click
        closeall()
        Counts.Show()
    End Sub

    Private Sub 销售结账ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 销售结账ToolStripMenuItem.Click
        closeall()
        Spay.Show()
    End Sub

    Private Sub 采购结账ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 采购结账ToolStripMenuItem.Click
        closeall()
        bpay.Show()
    End Sub

    Private Sub 采购未结账统计ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 采购未结账统计ToolStripMenuItem.Click
        closeall()
        bpayp.Show()
    End Sub

    Private Sub 销售未结账统计ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 销售未结账统计ToolStripMenuItem.Click
        closeall()
        spayp.Show()
    End Sub

    Private Sub 导入数据ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 导入数据ToolStripMenuItem.Click, ToolStripButton3.Click
        closeall()
        Input.Show()
    End Sub

    Private Sub 参数设置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 参数设置ToolStripMenuItem.Click
        closeall()
        Config.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        closeall()
        Me.Hide()
    End Sub

    Private Sub Mainfrm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(13) Then
            Reg.Show()
        End If
    End Sub
End Class