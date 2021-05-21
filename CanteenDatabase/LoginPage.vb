Imports System.Data.OleDb
Imports System.Data
Imports System.Security.Cryptography
Imports System.Text

Public Class LoginPage
    Dim SQL As New SQLControl
    Dim Val As New ValidCredentials
    Dim user As userInstance

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button_LPLogin.Click
        If TextBoxLPUser.Text = "" Or TextBox_LPPass.Text = "" Then
            'error message if a null entry is entered into the program
            MsgBox("Pleae fill in all the required fields", MsgBoxStyle.OkOnly)
        Else
            'checks to see if the account credentials are correct and the account exists
            If Val.CheckCreds(TextBoxLPUser.Text, TextBox_LPPass.Text) = True Then
                user = New userInstance(TextBoxLPUser.Text)
                ' checks if the account is a student or admin and opens the admin form
                If user.isAdmin() Then
                    AdminForm.Show()
                    Me.Hide()
                    Call AdminForm.loadAdmin(user)
                ElseIf user.isCanteen() Then
                    Call CanteenMenuChoice.Show()
                    Me.Hide()
                Else
                    'if the account is a standard account this opens the parent account form
                    MainAccount.Show()
                    Me.Hide()
                    Call MainAccount.loadinUser(TextBoxLPUser.Text)
                End If

            Else
                'error message when the incorrect username or password is entered
                MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid Login")
            End If
            'clears the textboxes
            TextBox_LPPass.Text = ""
        End If
    End Sub

    Private Sub Button_AddUser_Click(sender As Object, e As EventArgs) Handles Button_AddUser.Click
        'opens the add user form
        AddNewUser.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 
        'force login used in the testing to make entering the program quicker, would not be featured in the actual programw ere it to be released
        TextBoxLPUser.Text = "watlj007.319"
        TextBox_LPPass.Text = "motor5"
        Button1_Click(sender, New EventArgs)
    End Sub

    Private Sub Label_forgotPW_Click(sender As Object, e As EventArgs) Handles Label_forgotPW.Click
        ForgotPW.Show()
        Me.Hide()
    End Sub

    Private Sub Button_CloseApp_Click(sender As Object, e As EventArgs) Handles Button_CloseApp.Click
        Dim result = MessageBox.Show("Are you sure?", "Closing Application", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
