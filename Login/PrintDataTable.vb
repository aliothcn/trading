Imports System.Drawing.Printing

Public Class PrintDataTable

    '用户可自定义
    Private TableFont As New Font("宋体", 9)           '当前要打印文本的字体及字号
    Private HeadFont As New Font("黑体", 12, FontStyle.Underline) '表头字体
    Private SubHeadFont As New Font("楷体_GB2312", 10, FontStyle.Regular) '副表头字体
    Private HeadText As String   '表头文字
    Private SubHeadLeftText As String  '副表头左文字
    Private SubHeadRightText As String  '副表头右文字
    Private HeadHeight As Integer = 40 '表头高度
    Private SubHeadHeight As Integer = 30 '副表头高度
    Private FootFont As New Font("黑体", 12, FontStyle.Underline) '表脚字体
    Private SubFootFont As New Font("楷体_GB2312", 10, FontStyle.Regular) '副表脚字体
    Private FootText As String  '表脚文字
    Private SubFootLeftText As String  '副表脚左文字
    Private SubfootRightText As String
    Private FootHeight As Integer = 40 '表脚高度
    Private SubFootHeight As Integer = 30 '副表脚高度
    Dim X_unit As Integer                               '表的基本单位
    Dim Y_unit As Integer = TableFont.Height * 2.5

    '以下为模块内部使用
    Private ev As PrintPageEventArgs
    Private PrintDocument1 As PrintDocument
    Private DataGridColumn As DataColumn
    Private DataGridRow As DataRow
    Private DataTable1 As DataTable
    Private Cols As Integer                             '当前要打印的列
    Private Rows As Integer = 0                         '当前要打印的行
    Private ColsCount As Integer                        '当前DATAGRID共有多少列
    Private PrintingLineNumber As Integer = 0           '当前正要打印的行号
    Private PageRecordNumber As Integer                 '当前要所要打印的记录行数,由计算得到.
    Private PrintingPageNumber As Integer = 0           '正要打印的页号
    Private PageNumber As Integer                       '共需要打印的页数
    Private PrintRecordLeave As Integer                 '当前还有多少页没有打印
    Private PrintRecordComplete As Integer = 0         '已经打印完的记录数
    Private Pleft As Integer
    Private Ptop As Integer
    Private Pright As Integer
    Private Pbottom As Integer
    Private Pwidth As Integer
    Private Pheigh As Integer

    Private DrawBrush As New SolidBrush(System.Drawing.Color.Black)     '当前画笔颜色
    Private PrintRecordNumber As Integer '每页打印的记录条数
    Private Totalpage As Integer '总共应该打印的页数

    Sub New(ByVal TableSource As DataTable)
        DataTable1 = New DataTable
        DataTable1 = TableSource
        ColsCount = DataTable1.Columns.Count
    End Sub

    '用户自定义字体及字号
    Public WriteOnly Property SetTableFont() As System.Drawing.Font
        Set(ByVal Value As System.Drawing.Font)
            TableFont = Value
        End Set
    End Property
    Public WriteOnly Property SetHeadFont() As System.Drawing.Font
        Set(ByVal Value As System.Drawing.Font)
            HeadFont = Value
        End Set
    End Property
    Public WriteOnly Property SetSubHeadFont() As System.Drawing.Font
        Set(ByVal Value As System.Drawing.Font)
            SubHeadFont = Value
        End Set
    End Property
    Public WriteOnly Property SetFootFont() As System.Drawing.Font
        Set(ByVal Value As System.Drawing.Font)
            FootFont = Value
        End Set
    End Property
    Public WriteOnly Property SetSubFootFont() As System.Drawing.Font
        Set(ByVal Value As System.Drawing.Font)
            SubFootFont = Value
        End Set
    End Property
    Public WriteOnly Property SetHeadText() As String
        Set(ByVal Value As String)
            HeadText = Value
        End Set
    End Property
    Public WriteOnly Property SetSubHeadLeftText() As String
        Set(ByVal Value As String)
            SubHeadLeftText = Value
        End Set
    End Property
    Public WriteOnly Property SetSubHeadRightText() As String
        Set(ByVal Value As String)
            SubHeadRightText = Value
        End Set
    End Property
    Public WriteOnly Property SetFootText() As String
        Set(ByVal Value As String)
            FootText = Value
        End Set
    End Property
    Public WriteOnly Property SetSubFootLeftText() As String
        Set(ByVal Value As String)
            SubFootLeftText = Value
        End Set
    End Property
    Public WriteOnly Property SetSubFootRightText() As String
        Set(ByVal Value As String)
            SubfootRightText = Value
        End Set
    End Property
    Public WriteOnly Property SetHeadHeight() As Integer
        Set(ByVal Value As Integer)
            HeadHeight = Value
        End Set
    End Property
    Public WriteOnly Property SetSubHeadHeight() As Integer
        Set(ByVal Value As Integer)
            SubHeadHeight = Value
        End Set
    End Property
    Public WriteOnly Property SetFootHeight() As Integer
        Set(ByVal Value As Integer)
            FootHeight = Value
        End Set
    End Property
    Public WriteOnly Property SetSubFootHeight() As Integer
        Set(ByVal Value As Integer)
            SubFootHeight = Value
        End Set
    End Property
    Public WriteOnly Property SetCellHeight() As Integer
        Set(ByVal Value As Integer)
            Y_unit = Value
        End Set
    End Property

    Public Sub Print()
        Try
            PrintDocument1 = New Printing.PrintDocument
            AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintDocument1_PrintPage

            Dim PageSetup As PageSetupDialog
            PageSetup = New PageSetupDialog
            PageSetup.Document = PrintDocument1
            PrintDocument1.DefaultPageSettings = PageSetup.PageSettings
            If PageSetup.ShowDialog() = DialogResult.Cancel Then
                Exit Sub
            End If

            Pleft = PrintDocument1.DefaultPageSettings.Margins.Left
            Ptop = PrintDocument1.DefaultPageSettings.Margins.Top
            Pright = PrintDocument1.DefaultPageSettings.Margins.Right
            Pbottom = PrintDocument1.DefaultPageSettings.Margins.Bottom
            Pwidth = PrintDocument1.DefaultPageSettings.Bounds.Width
            Pheigh = PrintDocument1.DefaultPageSettings.Bounds.Height

            '将当前页分成基本的单元
            X_unit = (Pwidth - Pleft - Pright) / DataTable1.Columns.Count - 1
            PrintRecordNumber = (Pheigh - Ptop - Pbottom - HeadHeight - SubHeadHeight - FootHeight - SubFootHeight - Y_unit) / Y_unit

            If DataTable1.Rows.Count > PrintRecordNumber Then
                If DataTable1.Rows.Count Mod PrintRecordNumber = 0 Then
                    Totalpage = DataTable1.Rows.Count / PrintRecordNumber
                Else
                    Totalpage = DataTable1.Rows.Count / PrintRecordNumber + 1
                End If
            Else
                Totalpage = 1
            End If

            PrintDocument1.DocumentName = Totalpage.ToString
            Dim PrintPriview As PrintPreviewDialog
            PrintPriview = New PrintPreviewDialog
            PrintPriview.Document = PrintDocument1
            PrintPriview.WindowState = FormWindowState.Maximized
            PrintPriview.ShowDialog()
        Catch ex As Exception
            MsgBox("打印错误，请检查打印设置！", 16, "错误")
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal ev As System.Drawing.Printing.PrintPageEventArgs)

        'Dim row_count As Integer '当前要打印的行
        PrintRecordLeave = DataTable1.Rows.Count - PrintRecordComplete '还有多少条记录没有打印
        If PrintRecordLeave > 0 Then
            If PrintRecordLeave Mod PrintRecordNumber = 0 Then
                PageNumber = PrintRecordLeave \ PrintRecordNumber
            Else
                PageNumber = PrintRecordLeave \ PrintRecordNumber + 1
            End If
        Else
            PageNumber = 0
        End If

        '正在打印的页数
        PrintingPageNumber = 0       '因为每打印一个新页都要计算还有多少页没有打印所以以打印的页数初始为0
        '计算,余下的记录条数是否还可以在一页打印,不满一页时为假
        If DataTable1.Rows.Count - PrintingPageNumber * PrintRecordNumber >= PrintRecordNumber Then
            PageRecordNumber = PrintRecordNumber
        Else
            PageRecordNumber = (DataTable1.Rows.Count - PrintingPageNumber * PrintRecordNumber) Mod PrintRecordNumber
        End If

        Dim fmt As New StringFormat
        fmt.LineAlignment = StringAlignment.Center '上下对齐
        fmt.FormatFlags = StringFormatFlags.LineLimit '自动换行

        Dim Rect As New Rectangle '打印区域
        Dim Pen As New Pen(Brushes.Black, 1) '打印表格线格式

        While PrintingPageNumber <= PageNumber
            fmt.Alignment = StringAlignment.Center '表头中间对齐
            Rect.Width = Pwidth - Pleft - Pright '表头和副表头宽度等于设置区域宽度
            Rect.Height = HeadHeight
            Rect.X = Pleft
            Rect.Y = Ptop
            ev.Graphics.DrawString(HeadText, HeadFont, Brushes.Black, RectangleF.op_Implicit(Rect), fmt) '打印表头

            fmt.Alignment = StringAlignment.Near  '副表头左对齐
            Rect.Width = (Pwidth - Pleft - Pright) / 2 - 1
            Rect.Height = SubHeadHeight
            Rect.Y = Ptop + HeadHeight
            ev.Graphics.DrawString(SubHeadLeftText, SubHeadFont, Brushes.Black, RectangleF.op_Implicit(Rect), fmt) '打印副表头左

            fmt.FormatFlags = StringFormatFlags.DirectionRightToLeft '右副表头文字从右往左排列
            fmt.Alignment = StringAlignment.Near    '右副表头右对齐
            Rect.X = Pleft + (Pwidth - Pleft - Pright) / 2
            ev.Graphics.DrawString(SubHeadRightText, SubHeadFont, Brushes.Black, RectangleF.op_Implicit(Rect), fmt) '打印副表头右

            fmt.Alignment = StringAlignment.Center
            Rect.X = Pleft
            Rect.Y = Ptop + HeadHeight + SubHeadHeight + (PrintRecordNumber + 1) * (Y_unit) + SubFootHeight
            Rect.Height = FootHeight
            Rect.Width = Pwidth - Pleft - Pright
            ev.Graphics.DrawString(FootText, FootFont, Brushes.Black, RectangleF.op_Implicit(Rect), fmt)   '打印表脚

            fmt.Alignment = StringAlignment.Far   '副表左左对齐
            Rect.X = Pleft
            Rect.Y = Ptop + HeadHeight + SubHeadHeight + (PrintRecordNumber + 1) * (Y_unit)
            Rect.Height = SubFootHeight
            Rect.Width = (Pwidth - Pleft - Pright) / 2 - 1
            If DataTable1.Rows.Count = 0 Then
                SubFootLeftText = "第" & Totalpage & "页，共" & Totalpage & "页"
            Else
                SubFootLeftText = "第" & Totalpage - PageNumber + 1 & "页，共" & Totalpage & "页"
            End If
            ev.Graphics.DrawString(SubFootLeftText, SubFootFont, Brushes.Black, RectangleF.op_Implicit(Rect), fmt) '打印左表脚

            fmt.Alignment = StringAlignment.Near   '副表头右对齐
            Rect.X = Pleft + (Pwidth - Pleft - Pright) / 2

            ev.Graphics.DrawString(SubfootRightText, SubFootFont, Brushes.Black, RectangleF.op_Implicit(Rect), fmt) '打印右表脚

            '得到datatable的所有列名
            fmt.Alignment = StringAlignment.Center
            Dim ColumnText(DataTable1.Columns.Count) As String
            'Dim Table As Integer
            For Cols = 0 To DataTable1.Columns.Count - 1
                ColumnText(Cols) = DataTable1.Columns(Cols).ToString         '得到当前所有的列名
                Rect.X = Pleft + X_unit * Cols
                Rect.Y = Ptop + HeadHeight + SubHeadHeight
                Rect.Width = X_unit
                Rect.Height = Y_unit
                ev.Graphics.DrawString(ColumnText(Cols), New Font(TableFont, FontStyle.Bold), DrawBrush, RectangleF.op_Implicit(Rect), fmt)
                ev.Graphics.DrawRectangle(Pen, Rect)
            Next
            '结束---------------------得到datatable的所有列名
            Dim PrintingLine As Integer = 0                         '当前页面已经打印的记录行数
            While PrintingLine < PageRecordNumber
                DataGridRow = DataTable1.Rows(PrintRecordComplete)        '确定要当前要打印的记录的行号
                For Cols = 0 To DataTable1.Columns.Count - 1
                    Rect.X = Pleft + X_unit * Cols
                    Rect.Y = Ptop + HeadHeight + SubHeadHeight + (PrintingLine + 1) * (Y_unit)
                    Rect.Width = X_unit
                    Rect.Height = Y_unit
                    If DataGridRow(ColumnText(Cols)) Is System.DBNull.Value = False Then
                        ev.Graphics.DrawString(DataGridRow(ColumnText(Cols)), TableFont, DrawBrush, RectangleF.op_Implicit(Rect), fmt)
                    End If
                    ev.Graphics.DrawRectangle(Pen, Rect)
                Next
                PrintingLine += 1
                PrintRecordComplete += 1
                If PrintRecordComplete >= DataTable1.Rows.Count Then
                    ev.HasMorePages = False
                    PrintRecordComplete = 0
                    Exit Sub
                End If
            End While
            PrintingPageNumber += 1
            If PrintingPageNumber >= PageNumber Then
                ev.HasMorePages = False
            Else
                ev.HasMorePages = True
                Exit While
            End If
        End While

    End Sub

End Class
