<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bpay
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.内部编号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.日期 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.金额 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.是否结账 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.备注 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.内部编号, Me.日期, Me.金额, Me.是否结账, Me.备注})
        Me.DataGridView1.Location = New System.Drawing.Point(56, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(625, 381)
        Me.DataGridView1.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(121, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(139, 20)
        Me.ComboBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "供应商"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(583, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "退出"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '内部编号
        '
        Me.内部编号.DataPropertyName = "内部编号"
        Me.内部编号.HeaderText = "内部编号"
        Me.内部编号.Name = "内部编号"
        Me.内部编号.ReadOnly = True
        Me.内部编号.Visible = False
        '
        '日期
        '
        Me.日期.DataPropertyName = "日期"
        Me.日期.HeaderText = "日期"
        Me.日期.Name = "日期"
        Me.日期.ReadOnly = True
        '
        '金额
        '
        Me.金额.DataPropertyName = "金额"
        Me.金额.HeaderText = "金额"
        Me.金额.Name = "金额"
        Me.金额.ReadOnly = True
        '
        '是否结账
        '
        Me.是否结账.DataPropertyName = "是否结账"
        Me.是否结账.FalseValue = "False"
        Me.是否结账.HeaderText = "是否结账"
        Me.是否结账.Name = "是否结账"
        Me.是否结账.ReadOnly = True
        Me.是否结账.TrueValue = "True"
        '
        '备注
        '
        Me.备注.DataPropertyName = "备注"
        Me.备注.HeaderText = "备注"
        Me.备注.Name = "备注"
        Me.备注.ReadOnly = True
        Me.备注.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.备注.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'bpay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 464)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "bpay"
        Me.Text = "采购结账"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents 内部编号 As DataGridViewTextBoxColumn
    Friend WithEvents 日期 As DataGridViewTextBoxColumn
    Friend WithEvents 金额 As DataGridViewTextBoxColumn
    Friend WithEvents 是否结账 As DataGridViewCheckBoxColumn
    Friend WithEvents 备注 As DataGridViewTextBoxColumn
End Class
