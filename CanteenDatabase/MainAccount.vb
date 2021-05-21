Imports System.Data.OleDb
Public Class MainAccount
    Private SQL As New SQLControl
    Public loggedInUser As userInstance
    Public Sub loadinUser(inUsername As String)
        LoginPage.TextBoxLPUser.Text = ""
        loggedInUser = New userInstance(inUsername)
        PopulateCombo()
        ClearForm()
        Label1.Text = "Welcome Back " & loggedInUser.getFirstname() & " " & loggedInUser.getSurname() 'CALLS AND DISPLAYS THE NAME OF THE USER
        Label_Balance.Text = "£" + loggedInUser.getBalance() 'DISPLAYS THE BALANCE OF THE USER
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Quitting application now", MsgBoxStyle.OkOnly) 'EXITS THE APPLICATION
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick ' TIME FUNCTION 
        Label_Tiempo.Text = Format(Now, "HH:mm:ss")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_Logout.Click 'LOGS OUT OF THE ACCOUNT
        MsgBox("Logging out now", MsgBoxStyle.OkOnly)
        SQL.ClearParams()
        ClearForm()
        ClearCombo()
        LoginPage.Show()
        Me.Hide()
    End Sub
    Private Sub Button_AddFunds_Click(sender As Object, e As EventArgs) Handles Button_AddFunds.Click
        AddFunds.Show()

    End Sub

    Private Sub Button_UpdateAllowance_Click(sender As Object, e As EventArgs) Handles Button_UpdateAllowance.Click
        Dim Allowance As Decimal
        Try
            Allowance = TextBox_Allowance.Text
        Catch
            MsgBox("Invalid Entry", MsgBoxStyle.OkOnly) 'used if textbox is empty
        End Try
        Dim username As String = loggedInUser.getUsername()
        If Allowance > 0 Then ' prevents entering negative numbers
            SQL.AddParam("@pAllowance", Convert.ToString(Allowance)) ' converts the decimal to a string to store in the database
            SQL.AddParam("@pParent", username)
            SQL.UpdateRecord("UPDATE tblStudent SET Allowance = @pAllowance WHERE PUserName = @pParent") 'updates the allowance in the database
            MsgBox("Allowance has been updated", MsgBoxStyle.OkOnly)
        Else
            MsgBox("Please enter a positive allowance", MsgBoxStyle.OkOnly) 'invalid message shown if number entered is negative
        End If
    End Sub

    Private Sub Button_RemoveAllowance_Click(sender As Object, e As EventArgs) Handles Button_RemoveAllowance.Click
        Dim Allowance As String = 10 'sets the variable at 10
        Dim username As String = loggedInUser.getUsername()
        SQL.AddParam("@pResetAllowance", Allowance)
        SQL.AddParam("@pParent", username)
        SQL.ExecQuery("UPDATE tblStudent SET Allowance = @pResetAllowance WHERE PUserName = @pParent") 'updates whatever the allowance is in the tblStudent
        MsgBox("Allowance has been updated", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub Button_ChangeP_Click(sender As Object, e As EventArgs) Handles Button_ChangeP.Click
        NewPassword.Show() 'opens a form to change your password
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Child.SelectedIndexChanged
        Dim tempHP As Integer
        Dim LHist, BHist, Spent, Cname As String
        Dim UID As String = ComboBox_Child.Text

        SQL.AddParam("@pCName", UID)
        SQL.AddParam("@pPUser", loggedInUser.getUsername)
        SQL.ExecQuery("SELECT ChildFName, HealthPoints, BreakfastHistory, LunchHistory, TotalSpent FROM tblStudent WHERE UniqueID = @pCName AND PUserName = @pPUser")
        For Each r In SQL.SQLDS.Tables(0).Rows
            tempHP = r("HealthPoints")
            Cname = r("ChildFName")
            LHist = r("LunchHistory")
            BHist = r("BreakfastHistory")
            Spent = r("TotalSpent")
            Label_ChildIntro.Text = "Your child " & Cname & " has spent " & Spent 'displays how much a student has spent in total
            Label_BreakIntro.Text = Cname & " has purchased the follwing items at breakfast:"
            Label_Breakfast.Text = BHist ' displays the items that the students purchased at breakfast
            LabelLunchIntro.Text = Cname & " has purchased the follwing items at lunch:"
            Label_Lunch.Text = LHist 'displays what items the student has purchased at lunch

            Label_DisplayHP.Text = "Health Points : " & tempHP
            If tempHP < 0 Then
                Label_Diet.Text = "Your student has a poor diet"
            ElseIf tempHP = 0 Then
                Label_Diet.Text = "Your student has an average diet"
            ElseIf tempHP > 0 Then
                Label_Diet.Text = "Your student has a good diet"
            End If
        Next
    End Sub
    Sub PopulateCombo()
        Dim user = loggedInUser.getUsername()
        SQL.AddParam("@pUser", user)
        SQL.ExecQuery("SELECT UniqueID FROM tblStudent WHERE PUserName = @pUser")
        For Each r In SQL.SQLDS.Tables(0).Rows
            ComboBox_Child.Items.Add(r("UniqueID"))
        Next
    End Sub
    Sub ClearCombo()
        ComboBox_Child.Items.Clear()
        ComboBox_Child.Text = ""
    End Sub
    Sub ClearForm()
        Label1.Text = ""
        LabelLunchIntro.Text = ""
        Label_Balance.Text = ""
        Label_Breakfast.Text = ""
        Label_BreakIntro.Text = ""
        Label_ChildIntro.Text = ""
        Label_Diet.Text = ""
        Label_DisplayHP.Text = ""
        Label_Lunch.Text = ""
    End Sub

End Class