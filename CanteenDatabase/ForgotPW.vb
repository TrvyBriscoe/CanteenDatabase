
Public Class ForgotPW
    Dim val As New ValidCredentials
    Public username As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If val.ForgotP(TextBox1.Text, TextBox2.Text) = True Then
            FPass2.username = TextBox1.Text
            FPass2.Show()
            Me.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else

        End If

    End Sub
End Class