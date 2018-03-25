Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim enteredValue As String = TextBox1.Text
        enteredValue = "you typed: " + enteredValue
        Label1.Text = enteredValue
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
