Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Name As String = "Jirapat Kanokmaneeporn"
        Dim Stu_ID As String = "58121003-6"
        Dim Grade As Double = 3.04
        Dim Major As String = "IT / IT"

        MessageBox.Show("Student ID : " & Name & Environment.NewLine & "Full Name : " & Stu_ID & Environment.NewLine & "Major/Branch : " & Major & Environment.NewLine & "Grade : " & Grade, "Student Detail", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class
