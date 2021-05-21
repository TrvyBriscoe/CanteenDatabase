Public Class AddChild
    Dim user As New ValidCredentials
    Dim sql As New SQLControl
    Dim Balance, Privilege, username As String
    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        username = MainAccount.loggedInUser.getUsername
        If user.childDuplicate(TextBox2.Text) = True Then
            MsgBox("Unique ID already exists")
        Else
            'sets some defualt values to be added into the database with the user information
            Balance = "0"
            Privilege = "Standard"
            sql.addUserChild(username, TextBox1.Text, TextBox2.Text)
            MsgBox("Your child has been successfully added")
            MainAccount.PopulateCombo()
            Me.Hide()
            MainAccount.Show()
        End If
    End Sub
End Class