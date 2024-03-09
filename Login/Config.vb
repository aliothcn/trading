Public Class Config
    Private Sub Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = GetStrFromINI("System", "Title", "")
        TextBox3.Text = GetStrFromINI("System", "Header", "")
        TextBox4.Text = GetStrFromINI("System", "Footer", "")
        TextBox2.Text = GetStrFromINI("System", "Unit", "")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WriteStrINI("System", "Title", TextBox1.Text.Trim)
        WriteStrINI("System", "Header", TextBox3.Text.Trim)
        WriteStrINI("System", "Footer", TextBox4.Text.Trim)
        WriteStrINI("System", "Unit", TextBox2.Text.Trim)
    End Sub

    Private Sub TextBox1_Paint(sender As Object, e As PaintEventArgs) Handles TextBox1.Paint

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress
        If e.KeyChar = ChrW(13) Then
            e.Handled = True
            SendKeys.Send("{tab}")
        End If
    End Sub
End Class