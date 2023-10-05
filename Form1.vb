Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.Aquamarine
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim MyPhrase As String
        Dim pos, n As Integer
        MyPhrase = TextBox1.Text
        pos = TextBox3.Text
        n = TextBox3.Text
        TextBox5.Text = Mid(MyPhrase, pos, n)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
