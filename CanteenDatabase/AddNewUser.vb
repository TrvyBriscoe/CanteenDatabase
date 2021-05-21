Imports System.Text.RegularExpressions
Public Class AddNewUser
    Dim SQL As New SQLControl
    Dim user As New ValidCredentials
    Dim score As Integer
    Dim password As String
    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        Dim username, Balance, Privilege As String
        'If any of the fields are empty this will return an error and return an error
        CalculateMeter()
        If score <= 2 Then
            MsgBox("Please pick a stronger password")
            TextBox_Pass1.Text = ""
            TextBox_Pass2.Text = ""
            ClearScore()
        Else

            If TextBox_Child.Text = "" Or TextBox_FirstName.Text = "" Or TextBox_LastName.Text = "" Or TextBox_UID.Text = "" Or TextBox_Pass1.Text = "" Or TextBox_Pass2.Text = "" Or ComboBox_SchoolSelect.Text = "" Or TextBox_Maiden.Text = "" Then
                MsgBox("Please fill in all the required fields")
                ClearScore()
            Else
                ClearScore()
                'checks to see if the passwords match
                If TextBox_Pass1.Text = TextBox_Pass2.Text Then
                    password = TextBox_Pass1.Text
                    If ComboBox_SchoolSelect.SelectedIndex = 0 Then
                        username = TextBox_User.Text & ".438"
                    Else
                        username = TextBox_User.Text & ".319"
                    End If

                    'checks to see if the username already exists
                    If user.Duplicate(username) = True Then
                        MsgBox("User Already Exits")
                        Exit Sub
                    Else

                        'checks to see if the childs userID already exists
                        If user.childDuplicate(TextBox_Child.Text) = True Then
                            MsgBox("Unique ID already exists")
                        Else
                            'sets some defualt values to be added into the database with the user information
                            Balance = "0"
                            Privilege = "Standard"
                            SQL.addUserAdult(username, password, TextBox_FirstName.Text, TextBox_LastName.Text, TextBox_Child.Text, Balance, Privilege, TextBox_Maiden.Text)
                            SQL.addUserChild(username, TextBox_Child.Text, TextBox_UID.Text)
                            MsgBox("You have been successfully added")
                            Me.Hide()
                            LoginPage.Show()
                        End If
                    End If

                Else
                    'error message if passwords are not the same
                    MsgBox("Passwords are not equal")
                End If
            End If
        End If
    End Sub
    Private StrengthWords() As String = {"Weak", "Weak", "Good", "Good", "Strong", "Strong"}
    'regular expressions are used to identify strong passwords
    'subrputine to determine strength of a password
    Sub CalculateMeter()
        password = TextBox_Pass1.Text
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



    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        'closes the program, uses a prompt depending on whether the answer is yes or no
        Dim result = MessageBox.Show(" Are you sure you want to quit", "Are you sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            LoginPage.Show()
            Me.Hide()
        End If
    End Sub


End Class