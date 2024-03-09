Public Class backup
    Dim url As String = "D:\"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            SaveFileDialog1.Filter = "数据文件(*.mdb)|*.mdb"
            SaveFileDialog1.FileName = DateTime.Now.ToString("yyyyMMddHHmmss")
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                System.IO.File.Copy(url & "db.mdb", SaveFileDialog1.FileName)
                MsgBox("备份成功！")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "D:\db.mdb"
        Try
            Dim fi As New System.IO.FileInfo("D:\db.mdb")
            TextBox2.Text = Format(fi.Length / 1024 / 1024, "fixed") & " MB"
        Catch
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            OpenFileDialog1.Filter = "数据文件(*.mdb)|*.mdb"
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                System.IO.File.Copy(OpenFileDialog1.FileName, url & "db.mdb", True)
                MsgBox("还原成功！",, "系统提示")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class