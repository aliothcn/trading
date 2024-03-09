Public Class Reg
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "SDU24581" Then
            WriteStrINI("System", "Reg", TextBox1.Text.Trim)
            MsgBox("激活成功，请重新运行")
            End
        ElseIf TextBox1.Text.Trim = "SDU" Then
            MsgBox("延长试用成功，每次运行3分钟")
            WriteStrINI("System", "Reg", TextBox1.Text.Trim)
            End
        Else
            MsgBox("激活失败!")
        End If
    End Sub

    Private Sub Reg_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub Reg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = GetStrFromINI("System", "Reg", "")
    End Sub
End Class