<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lab_title = New System.Windows.Forms.Label()
        Me.lab_name = New System.Windows.Forms.Label()
        Me.lab_pwd = New System.Windows.Forms.Label()
        Me.txb_name = New System.Windows.Forms.TextBox()
        Me.txb_pwd = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lab_title
        '
        Me.lab_title.AutoSize = True
        Me.lab_title.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lab_title.Location = New System.Drawing.Point(316, 48)
        Me.lab_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lab_title.Name = "lab_title"
        Me.lab_title.Size = New System.Drawing.Size(106, 24)
        Me.lab_title.TabIndex = 5
        Me.lab_title.Text = "系统登录"
        '
        'lab_name
        '
        Me.lab_name.AutoSize = True
        Me.lab_name.Location = New System.Drawing.Point(265, 136)
        Me.lab_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lab_name.Name = "lab_name"
        Me.lab_name.Size = New System.Drawing.Size(56, 16)
        Me.lab_name.TabIndex = 6
        Me.lab_name.Text = "用户名"
        '
        'lab_pwd
        '
        Me.lab_pwd.AutoSize = True
        Me.lab_pwd.Location = New System.Drawing.Point(265, 209)
        Me.lab_pwd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lab_pwd.Name = "lab_pwd"
        Me.lab_pwd.Size = New System.Drawing.Size(56, 16)
        Me.lab_pwd.TabIndex = 7
        Me.lab_pwd.Text = "密  码"
        '
        'txb_name
        '
        Me.txb_name.Location = New System.Drawing.Point(353, 132)
        Me.txb_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txb_name.Name = "txb_name"
        Me.txb_name.Size = New System.Drawing.Size(132, 26)
        Me.txb_name.TabIndex = 0
        '
        'txb_pwd
        '
        Me.txb_pwd.Location = New System.Drawing.Point(353, 205)
        Me.txb_pwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txb_pwd.Name = "txb_pwd"
        Me.txb_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txb_pwd.Size = New System.Drawing.Size(132, 26)
        Me.txb_pwd.TabIndex = 1
        '
        'btn_login
        '
        Me.btn_login.BackgroundImage = Global.Winfrm.My.Resources.Resources.loginButton
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_login.Location = New System.Drawing.Point(268, 284)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(72, 37)
        Me.btn_login.TabIndex = 2
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.BackgroundImage = Global.Winfrm.My.Resources.Resources.exitButton
        Me.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_exit.Location = New System.Drawing.Point(417, 284)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(72, 37)
        Me.btn_exit.TabIndex = 3
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(350, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.Winfrm.My.Resources.Resources.login
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(639, 385)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txb_pwd)
        Me.Controls.Add(Me.txb_name)
        Me.Controls.Add(Me.lab_pwd)
        Me.Controls.Add(Me.lab_name)
        Me.Controls.Add(Me.lab_title)
        Me.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.Text = "系统登录"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub Login_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Friend WithEvents lab_title As Label
    Friend WithEvents lab_name As Label
    Friend WithEvents lab_pwd As Label
    Friend WithEvents txb_name As TextBox
    Friend WithEvents txb_pwd As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents Label1 As Label
End Class
