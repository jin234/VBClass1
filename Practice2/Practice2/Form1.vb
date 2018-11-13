Public Class Form1
    Private Sub ButtonSum_Click(sender As Object, e As EventArgs) Handles ButtonSum.Click
        MessageBox.Show(CInt(TextBoxNumber1.Text) + CInt(TextBoxNumber2.Text))
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxNumber1.Text = " "
        TextBoxNumber1.Text = " "
    End Sub
End Class
