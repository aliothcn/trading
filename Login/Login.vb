Public Class Login
    Public bResult As Boolean = False
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim person As New Trading.Model.Person
        Dim pBll As New Trading.BLL.PersonBLL
        If txb_name.Text = "" Then
            MsgBox("请输入用户名！",, "系统提示")
        ElseIf txb_pwd.Text = "" Then
            MsgBox("请输入密码！",, "系统提示")
        Else
            person.name = txb_name.Text.Trim
            person.password = txb_pwd.Text.Trim
            If pBll.loginChk(person.name, person.password) Then
                If Now > #2016-8-15# Then
                    If GetStrFromINI("System", "Reg", "") = "" Then
                        MsgBox("试用期已过！",, "系统提示")
                        Reg.Show()
                        Mainfrm.Timer2.Interval = 500
                        Mainfrm.Timer2.Enabled = True
                        Me.Hide()
                    ElseIf GetStrFromINI("System", "Reg", "") = "SDU24581" Then
                        '已经注册
                        bResult = True
                        Me.Hide()
                    Else
                        Reg.Show()
                        Mainfrm.Timer2.Interval = 180000
                        Mainfrm.Timer2.Enabled = True
                        Me.Hide()
                    End If
                Else
                    bResult = True
                    Me.Hide()
                End If
            Else
                MsgBox("登录失败！",, "系统提示")
                txb_pwd.Text = ""
                txb_name.Text = ""
                txb_name.Select()
            End If

        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lab_title.BackColor = System.Drawing.Color.Transparent
        Me.lab_name.BackColor = System.Drawing.Color.Transparent
        Me.lab_pwd.BackColor = System.Drawing.Color.Transparent
        txb_name.Text = "admin"
        txb_pwd.Text = "admin"
        Label1.Visible = False
        If Now > #2016-8-1# Then
            Label1.Visible = True
            Label1.Text = "试用即将到期！"
        End If
    End Sub

    Private Sub txb_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_name.KeyPress
        If e.KeyChar = ChrW(13) Then
            txb_pwd.Select()

        End If
    End Sub

    Private Sub txb_pwd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_pwd.KeyPress
        If e.KeyChar = ChrW(13) Then
            btn_login_Click(sender, e)

        End If
    End Sub
End Class
