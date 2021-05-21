Public Class CanteenMenuChoice
    Private Sub Button_Brekky_Click(sender As Object, e As EventArgs) Handles Button_Brekky.Click
        Breakfast.Show() 'opens the breakfast form
        Me.Hide()
    End Sub

    Private Sub Button_Lunch_Click(sender As Object, e As EventArgs) Handles Button_Lunch.Click
        Lunch.Show() 'opens the lunch form
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Quit.Click
        Dim result = MessageBox.Show(" Are you sure you want to quit", "Are you sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then 'quits the program
            Application.Exit()
        End If
    End Sub

    Private Sub Button_LogO_Click(sender As Object, e As EventArgs) Handles Button_LogO.Click
        Dim result = MessageBox.Show(" Are you sure you want to logout", "Are you sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then 'logout out of the account and returns you to the login page
            LoginPage.Show()
            Me.Hide()
        End If
    End Sub
End Class