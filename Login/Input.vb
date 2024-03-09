Imports System.Data.OleDb

Public Class Input
    Dim filepath As String
    Dim dt As New DataTable
    Dim t_sup As New DataTable("c")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "电子表格(*.xls;*.xlsx)|*.xlsx;*.xls"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            filepath = OpenFileDialog1.FileName
            Dim sheetname As String()
            sheetname = GetExcelSheetNames(filepath)
            ListBox1.Items.Clear()
            For i = 0 To sheetname.Length - 1
                ListBox1.Items.Add(sheetname(i))
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Mainfrm.toollab1.Text = "试用用户" Then
            MsgBox("试用版无此功能")
            Button6.Enabled = False
            Exit Sub
        End If
        If ListBox1.SelectedItem <> "" Then
            dt = GetExcelToDataTableBySheet(filepath, ListBox1.SelectedItem)
            dt.Columns.Add("单价")
            dt.Columns.Add("单位")
            dt.Columns.Add("小计")
            dt.Columns.Add("备注")
            dt.Columns.Add("pid")
            dt.Columns.Add("id")
            For i = 0 To dt.Rows.Count - 1
                Dim p As New Trading.Model.Product
                Dim bll As New Trading.BLL.ProductBLL
                p = bll.getbyname(dt.Rows(i).Item(0))
                If p Is Nothing Then
                    MsgBox("商品库中没有商品:" & dt.Rows(i).Item(0))
                    dt.Clear()
                    Exit Sub

                End If
                dt.Rows(i).Item("pid") = p.id
                dt.Rows(i).Item("单位") = "斤"
            Next
            dt.Columns(0).ColumnName = "商品名称"
            dt.Columns(1).ColumnName = "数量"
            DataGridView1.DataSource = dt
            DataGridView1.Columns("商品名称").ReadOnly = True
            DataGridView1.Columns("id").ReadOnly = True
            DataGridView1.Columns("pid").ReadOnly = True
            DataGridView1.Columns("id").Visible = False
            DataGridView1.Columns("pid").Visible = False
            DataGridView1.Columns("小计").ReadOnly = True

        End If
    End Sub

    Public Shared Function GetExcelToDataTableBySheet(ByVal FileFullPath As String, ByVal SheetName As String) As DataTable
        Dim strConn As String = ("Provider=Microsoft.Ace.OleDb.12.0;" & "data source=") + FileFullPath & ";Extended Properties='Excel 12.0; HDR=NO; IMEX=1'"
        Dim conn As New OleDbConnection(strConn)
        conn.Open()
        Dim ds As New DataSet()
        Dim odda As New OleDbDataAdapter(String.Format("SELECT * FROM [{0}]", SheetName), conn)
        odda.Fill(ds, SheetName)
        conn.Close()
        Return ds.Tables(0)
    End Function
    Public Shared Function GetExcelSheetNames(ByVal excelFile As String) As [String]()
        Dim objConn As OleDbConnection = Nothing
        Dim dt As System.Data.DataTable = Nothing
        Try
            Dim strConn As String = ("Provider=Microsoft.Ace.OleDb.12.0;" & "data source=") + excelFile & ";Extended Properties='Excel 12.0; HDR=NO; IMEX=1'"
            objConn = New OleDbConnection(strConn)
            objConn.Open()
            dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            If dt Is Nothing Then
                Return Nothing
            End If
            Dim excelSheets As [String]() = New [String](dt.Rows.Count - 1) {}
            Dim i As Integer = 0
            For Each row As DataRow In dt.Rows
                excelSheets(i) = row("TABLE_NAME").ToString()
                i += 1
            Next
            Return excelSheets
        Catch
            Return Nothing
        Finally
            If objConn IsNot Nothing Then
                objConn.Close()
                objConn.Dispose()
            End If
            If dt IsNot Nothing Then
                dt.Dispose()
            End If
        End Try
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Dispose()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim heji As Decimal = 0
        Try
            For i = 0 To dt.Rows.Count - 1
                If IsNumeric(dt.Rows(i).Item("单价")) Then

                Else
                    dt.Rows(i).Item("单价") = 0
                End If
                If IsNumeric(dt.Rows(i).Item("数量")) Then

                Else
                    dt.Rows(i).Item("数量") = 0
                End If
                If IsNumeric(dt.Rows(i).Item("小计")) Then
                    heji = heji + dt.Rows(i).Item("小计")
                Else
                    dt.Rows(i).Item("小计") = 0
                End If

            Next
        Catch
        End Try
        TextBox1.Text = heji
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Dim r, c As New Integer
        r = e.RowIndex
        c = e.ColumnIndex
        Try
            dt.Rows(r).Item("小计") = dt.Rows(r).Item("单价") * dt.Rows(r).Item(1)
        Catch
            MsgBox("单价,数量必须为数字！")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox1.SelectedItem = "" Then
            MsgBox("请选择客户！")
            Exit Sub
        End If
        Dim tab As New DataTable
        Dim strrmb As New Rmb
        strrmb.InputString = TextBox1.Text.Trim
        tab.Columns.Add("商品名称", GetType(String))
        tab.Columns.Add("单价", GetType(Decimal))
        tab.Columns.Add("数量", GetType(Decimal))
        tab.Columns.Add("单位", GetType(String))
        tab.Columns.Add("小计", GetType(Decimal))
        tab.Columns.Add("备注", GetType(String))

        If dt.Rows.Count > 0 Then
            If TextBox1.Text = "" Then
                Button6_Click(sender, e)
            End If
            For i = 0 To dt.Rows.Count - 1
                tab.Rows.Add()
                tab.Rows(i).Item("商品名称") = dt.Rows(i).Item("商品名称")
                tab.Rows(i).Item("单价") = Format(dt.Rows(i).Item("单价"), "fixed")
                tab.Rows(i).Item("数量") = dt.Rows(i).Item("数量")
                tab.Rows(i).Item("单位") = dt.Rows(i).Item("单位")
                tab.Rows(i).Item("小计") = Format(dt.Rows(i).Item("小计"), "fixed")
                tab.Rows(i).Item("备注") = dt.Rows(i).Item("备注")
            Next
            Dim pt As New PrintDataTable(tab)
            pt.SetHeadText = GetStrFromINI("System", "Header", "") & "-销售单"
            pt.SetSubHeadLeftText = ComboBox1.Text
            pt.SetSubHeadRightText = DateTimePicker1.Text
            pt.SetSubFootRightText = "合计：¥" & Format（Val(TextBox1.Text.Trim）, "fixed"） & "  人民币：" & strrmb.OutString
            pt.SetFootText = GetStrFromINI("System", "Footer", "")
            pt.Print()
        End If
    End Sub

    Private Sub Input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sup_bll As New Trading.BLL.clientBLL
        t_sup = sup_bll.getall
        For i = 0 To t_sup.Rows.Count - 1
            ComboBox1.Items.Add(t_sup.Rows(i).Item(1))
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ComboBox1.SelectedItem = "" Then
            MsgBox("请选择客户！")
            Exit Sub
        End If
        If dt.Rows.Count > 0 Then
            Dim b As New Trading.Model.sale
            b.cid = t_sup.Rows(ComboBox1.SelectedIndex).Item(0)
            b.sday = DateTimePicker1.Text
            b.money = Val(TextBox1.Text.Trim)
            b.ispay = CheckBox1.Checked
            b.text = TextBox3.Text.Trim
            Dim bb As New Trading.BLL.SaleBLL
            Dim temp As Integer
            temp = bb.insert(b)
            If temp > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    Dim bl As New Trading.Model.slist
                    bl.sid = temp
                    bl.pid = dt.Rows(i).Item("pid")
                    bl.price = dt.Rows(i).Item("单价")
                    bl.num = dt.Rows(i).Item("数量")
                    bl.unit = dt.Rows(i).Item("单位")
                    bl.text = dt.Rows(i).Item("备注").ToString
                    Dim blist_bll As New Trading.BLL.SlistBLL
                    dt.Rows(i).Item("id") = blist_bll.insert(bl)
                Next
                MsgBox("添加成功",, "系统提示")
            End If
        End If
    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        MsgBox("必须为数值！")
    End Sub
End Class