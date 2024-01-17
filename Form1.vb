Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstNumber, secondNumber As Integer
        firstNumber = Val(TextBox1.Text)
        secondNumber = Val(TextBox2.Text)

        Sum(firstNumber, secondNumber)

    End Sub

End Class
