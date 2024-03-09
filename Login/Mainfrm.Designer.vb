<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainfrm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainfrm))
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.系统设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.参数设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改密码ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出系统ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.基础数据ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.商品ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.供应商ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.客户ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.数据备份ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.导入数据ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.销售ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.销售开单ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.销售数据查询ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.采购ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新增ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查看ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.采购清单ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.结账ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.采购结账ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.销售结账ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.采购未结账统计ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.销售未结账统计ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.Toollab0 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toollab1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Toollab2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MainMenu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Status.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.系统设置ToolStripMenuItem, Me.基础数据ToolStripMenuItem, Me.销售ToolStripMenuItem, Me.采购ToolStripMenuItem, Me.结账ToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MainMenu.Size = New System.Drawing.Size(880, 30)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        '系统设置ToolStripMenuItem
        '
        Me.系统设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.参数设置ToolStripMenuItem, Me.修改密码ToolStripMenuItem, Me.ToolStripSeparator2, Me.退出系统ToolStripMenuItem})
        Me.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem"
        Me.系统设置ToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.系统设置ToolStripMenuItem.Text = "系统设置"
        '
        '参数设置ToolStripMenuItem
        '
        Me.参数设置ToolStripMenuItem.Name = "参数设置ToolStripMenuItem"
        Me.参数设置ToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.参数设置ToolStripMenuItem.Text = "参数设置"
        '
        '修改密码ToolStripMenuItem
        '
        Me.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem"
        Me.修改密码ToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.修改密码ToolStripMenuItem.Text = "修改密码"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(139, 6)
        '
        '退出系统ToolStripMenuItem
        '
        Me.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem"
        Me.退出系统ToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.退出系统ToolStripMenuItem.Text = "退出系统"
        '
        '基础数据ToolStripMenuItem
        '
        Me.基础数据ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.商品ToolStripMenuItem, Me.供应商ToolStripMenuItem, Me.客户ToolStripMenuItem, Me.ToolStripSeparator1, Me.数据备份ToolStripMenuItem, Me.导入数据ToolStripMenuItem})
        Me.基础数据ToolStripMenuItem.Name = "基础数据ToolStripMenuItem"
        Me.基础数据ToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.基础数据ToolStripMenuItem.Text = "数据管理"
        '
        '商品ToolStripMenuItem
        '
        Me.商品ToolStripMenuItem.Name = "商品ToolStripMenuItem"
        Me.商品ToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.商品ToolStripMenuItem.Text = "商品"
        '
        '供应商ToolStripMenuItem
        '
        Me.供应商ToolStripMenuItem.Name = "供应商ToolStripMenuItem"
        Me.供应商ToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.供应商ToolStripMenuItem.Text = "供应商"
        '
        '客户ToolStripMenuItem
        '
        Me.客户ToolStripMenuItem.Name = "客户ToolStripMenuItem"
        Me.客户ToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.客户ToolStripMenuItem.Text = "客户"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(139, 6)
        '
        '数据备份ToolStripMenuItem
        '
        Me.数据备份ToolStripMenuItem.Name = "数据备份ToolStripMenuItem"
        Me.数据备份ToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.数据备份ToolStripMenuItem.Text = "数据备份"
        '
        '导入数据ToolStripMenuItem
        '
        Me.导入数据ToolStripMenuItem.Name = "导入数据ToolStripMenuItem"
        Me.导入数据ToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.导入数据ToolStripMenuItem.Text = "导入数据"
        '
        '销售ToolStripMenuItem
        '
        Me.销售ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.销售开单ToolStripMenuItem, Me.销售数据查询ToolStripMenuItem})
        Me.销售ToolStripMenuItem.Name = "销售ToolStripMenuItem"
        Me.销售ToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.销售ToolStripMenuItem.Text = "销售"
        '
        '销售开单ToolStripMenuItem
        '
        Me.销售开单ToolStripMenuItem.Name = "销售开单ToolStripMenuItem"
        Me.销售开单ToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.销售开单ToolStripMenuItem.Text = "添加"
        '
        '销售数据查询ToolStripMenuItem
        '
        Me.销售数据查询ToolStripMenuItem.Name = "销售数据查询ToolStripMenuItem"
        Me.销售数据查询ToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.销售数据查询ToolStripMenuItem.Text = "查看"
        '
        '采购ToolStripMenuItem
        '
        Me.采购ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新增ToolStripMenuItem, Me.查看ToolStripMenuItem, Me.ToolStripSeparator3, Me.采购清单ToolStripMenuItem})
        Me.采购ToolStripMenuItem.Name = "采购ToolStripMenuItem"
        Me.采购ToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.采购ToolStripMenuItem.Text = "采购"
        '
        '新增ToolStripMenuItem
        '
        Me.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem"
        Me.新增ToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.新增ToolStripMenuItem.Text = "添加"
        '
        '查看ToolStripMenuItem
        '
        Me.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem"
        Me.查看ToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.查看ToolStripMenuItem.Text = "查看"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(139, 6)
        '
        '采购清单ToolStripMenuItem
        '
        Me.采购清单ToolStripMenuItem.Name = "采购清单ToolStripMenuItem"
        Me.采购清单ToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.采购清单ToolStripMenuItem.Text = "采购清单"
        '
        '结账ToolStripMenuItem
        '
        Me.结账ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.采购结账ToolStripMenuItem, Me.销售结账ToolStripMenuItem, Me.采购未结账统计ToolStripMenuItem, Me.销售未结账统计ToolStripMenuItem})
        Me.结账ToolStripMenuItem.Name = "结账ToolStripMenuItem"
        Me.结账ToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.结账ToolStripMenuItem.Text = "结账"
        '
        '采购结账ToolStripMenuItem
        '
        Me.采购结账ToolStripMenuItem.Name = "采购结账ToolStripMenuItem"
        Me.采购结账ToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.采购结账ToolStripMenuItem.Text = "采购结账"
        '
        '销售结账ToolStripMenuItem
        '
        Me.销售结账ToolStripMenuItem.Name = "销售结账ToolStripMenuItem"
        Me.销售结账ToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.销售结账ToolStripMenuItem.Text = "销售结账"
        '
        '采购未结账统计ToolStripMenuItem
        '
        Me.采购未结账统计ToolStripMenuItem.Name = "采购未结账统计ToolStripMenuItem"
        Me.采购未结账统计ToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.采购未结账统计ToolStripMenuItem.Text = "采购未结账统计"
        '
        '销售未结账统计ToolStripMenuItem
        '
        Me.销售未结账统计ToolStripMenuItem.Name = "销售未结账统计ToolStripMenuItem"
        Me.销售未结账统计ToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.销售未结账统计ToolStripMenuItem.Text = "销售未结账统计"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AllowItemReorder = True
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator4, Me.ToolStripButton4, Me.ToolStripButton6, Me.ToolStripButton5, Me.ToolStripSeparator5, Me.ToolStripButton8, Me.ToolStripButton3, Me.ToolStripButton7})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 30)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(880, 57)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Winfrm.My.Resources.Resources.sale1
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(54, 54)
        Me.ToolStripButton1.Text = "开单"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Winfrm.My.Resources.Resources.buy
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(54, 54)
        Me.ToolStripButton2.Text = "采购"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.Winfrm.My.Resources.Resources.product
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(54, 54)
        Me.ToolStripButton4.Text = "商品管理"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = Global.Winfrm.My.Resources.Resources.Farmer
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(54, 54)
        Me.ToolStripButton6.Text = "供应商管理"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.Winfrm.My.Resources.Resources.Customer
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(54, 54)
        Me.ToolStripButton5.Text = "客户管理"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = Global.Winfrm.My.Resources.Resources.print_1081px_1191618_easyicon_net
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(54, 54)
        Me.ToolStripButton8.Text = "采购清单"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.Winfrm.My.Resources.Resources._in
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(54, 54)
        Me.ToolStripButton3.Text = "导入数据"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = Global.Winfrm.My.Resources.Resources.exit_128px_28429_easyicon_net
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(54, 54)
        Me.ToolStripButton7.Text = "退出系统"
        '
        'Status
        '
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Toollab0, Me.toollab1, Me.ToolStripStatusLabel1, Me.Toollab2})
        Me.Status.Location = New System.Drawing.Point(0, 535)
        Me.Status.Name = "Status"
        Me.Status.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.Status.Size = New System.Drawing.Size(880, 30)
        Me.Status.TabIndex = 2
        Me.Status.Text = "StatusStrip1"
        '
        'Toollab0
        '
        Me.Toollab0.AutoSize = False
        Me.Toollab0.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.Toollab0.Name = "Toollab0"
        Me.Toollab0.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.Toollab0.Size = New System.Drawing.Size(100, 25)
        Me.Toollab0.Text = "操作员："
        Me.Toollab0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'toollab1
        '
        Me.toollab1.AutoSize = False
        Me.toollab1.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.toollab1.Name = "toollab1"
        Me.toollab1.Size = New System.Drawing.Size(200, 25)
        Me.toollab1.Text = "1"
        Me.toollab1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(260, 25)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "欢迎使用本系统"
        '
        'Toollab2
        '
        Me.Toollab2.AutoSize = False
        Me.Toollab2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.Toollab2.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.Toollab2.Name = "Toollab2"
        Me.Toollab2.Size = New System.Drawing.Size(300, 25)
        Me.Toollab2.Text = "2"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Mainfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(880, 565)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MainMenu)
        Me.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainMenu
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Mainfrm"
        Me.Text = "信息系统"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents 系统设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 参数设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 修改密码ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents 退出系统ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 基础数据ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 商品ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 供应商ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 客户ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 数据备份ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 销售ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 销售开单ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 销售数据查询ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 导入数据ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 采购ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新增ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 查看ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents 采购清单ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 结账ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 采购结账ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 销售结账ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 采购未结账统计ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 销售未结账统计ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Status As StatusStrip
    Friend WithEvents toollab1 As ToolStripStatusLabel
    Friend WithEvents Toollab0 As ToolStripStatusLabel
    Friend WithEvents Toollab2 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents Timer2 As Timer
End Class
