Imports System.Text.RegularExpressions
Public Class NewPassword
    Dim sql As New SQLControl
    Dim val As New ValidCredentials
    Dim hash, username, password As String
    Dim score As Integer

    Private Sub Button_close_Click(sender As Object, e As EventArgs) Handles Button_close.Click
        Dim result = MessageBox.Show(" Are you sure you want to quit", "Are you sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox_FirstP.Text = TextBox_SecondP.Text Then 'checks if the new passwords entered are equal
            username = MainAccount.loggedInUser.getUsername
            sql.AddParam("@pUser", username)
            sql.ExecQuery("SELECT HashedPass FROM tblMainAccount WHERE Username= @pUser")
            For Each r In sql.SQLDS.Tables(0).Rows
                hash = r("HashedPass")
                If val.CheckCreds(username, TextBox_OldPass.Text) = True Then 'checks to see if the user exists
                    If score <= 2 Then
                        MsgBox("Please enter a stronger password")
                    Else
                        val.ChangePass(TextBox_FirstP.Text, username) 'changes and updates the password in table
                        MsgBox("Password has been successfully changed", MsgBoxStyle.OkOnly)
                        TextBox_FirstP.Text = "" ' clears the textboxes so inforamtion is not saved and closes the form
                        TextBox_SecondP.Text = ""
                        TextBox_OldPass.Text = ""
                        Me.Hide()
                    End If
                Else
                    MsgBox("Old password was incorrect")
                End If

            Next
        Else
            MsgBox("Passwords do not match, please try again") 'error handling in case the passwords are not equal
        End If

    End Sub
    Private StrengthWords() As String = {"Weak", "Weak", "Good", "Good", "Strong", "Strong"}
    'regular expressions are used to identify strong passwords
    'subrputine to determine strength of a password
    Sub CalculateMeter()
        password = TextBox_FirstP.Text
        If (password.Length > 6) Then
            score += 1 'Length more than 6 
        End If
        If Regex.IsMatch(password, "[a-z]") And Regex.IsMatch(password, "[A-Z]") Then
            score += 1 'upper and lower case 
        End If
        If Regex.IsMatch(password, "\d+") Then
            score += 1 'number
        End If


        If Regex.IsMatch(password, "[!,@,#,$,%,^,&,*,?,_,~,-,/""]") Then
            score += 1 'special character
        End If

        If (password.Length > 8) Then
            score += 1 'length more than 8
        End If
        ProgressBar1.Value = score / 5 * 100 'finding percentage to increase the progress bar
        Label_Medium.Width = 50 * score 'label width is not auto so seeting it to show color amount 
        Label_Medium.Text = StrengthWords(score) 'Getting strength word from string array declarred above 
        Label_Medium.TextAlign = ContentAlignment.MiddleCenter 'alignning to center can be done one time in design 
        Label_Medium.BackColor = GetColor(score) 'Getting color and setting 
        ProgressBar1.ForeColor = GetColor(score)

    End Sub
    Sub ClearScore()
        score = 0
        password = ""
    End Sub
    Private Function GetColor(ByVal score As Integer) As Color
        'sets the background colour of the password strength depending on whether the passwords is very weak to strongest
        Select Case score
            Case 0
                Return Color.Red
            Case 1
                Return Color.Red
            Case 2
                Return Color.LightYellow
            Case 3
                Return Color.YellowGreen
            Case 4
                Return Color.LightGreen
            Case 5
                Return Color.Green
        End Select
    End Function
End Class