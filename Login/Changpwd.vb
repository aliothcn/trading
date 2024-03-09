Public Class Changpwd
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("请输入原密码！",, "系统提示")
            TextBox1.Select()
        ElseIf TextBox2.Text = "" Then
            MsgBox("请输入新密码！",, "系统提示")
            TextBox2.Select()
        ElseIf TextBox2.Text.Trim <> TextBox3.Text.Trim Then
            MsgBox("两次输入的新密码不同！",, "系统提示")
            TextBox3.Select()
        Else
            Dim person As New Trading.Model.Person
            Dim pBll As New Trading.BLL.PersonBLL
            person.name = My.Forms.Mainfrm.username
            person.password = TextBox1.Text
            If pBll.loginChk(person.name, person.password) Then
                person = pBll.getbyname(person.name)
                person.password = TextBox2.Text.Trim
                If pBll.edit(person) Then
                    MsgBox("修改成功！",, "系统提示")
                Else

                    MsgBox("修改失败！",, "系统提示")
                End If
            Else
                MsgBox("原密码错误！",, "系统提示")

            End If
        End If


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(13) Then
            TextBox2.Select()

        End If
    End Sub


    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = ChrW(13) Then
            Button1_Click(sender, e)

        End If

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = ChrW(13) Then
            TextBox3.Select()

        End If
    End Sub

    Private Sub Changpwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BackColor = System.Drawing.Color.Transparent
    End Sub
End Class