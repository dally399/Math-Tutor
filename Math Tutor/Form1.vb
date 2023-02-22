Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim Answer As Integer

        Num1 = txtNum1.Text
        Num2 = txtNum2.Text


        Answer = Num1 + Num2
        txtAnswer.Text = Answer




    End Sub
End Class
