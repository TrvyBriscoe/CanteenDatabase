Imports System.Data.OleDb
Public Class AddFunds
    Dim SQL As New SQLControl
    Dim loggedInUser As userInstance
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userbal = MainAccount.loggedInUser.getBalance
        Dim username = MainAccount.loggedInUser.getUsername
        Dim addedBalance As Decimal = Convert.ToDecimal(TextBox_Topup.Text) 'DECIMAL USED TO REPLICATE CURRENCY
        Dim newBal As Decimal = Convert.ToDecimal(userbal) + addedBalance ' ACQUIRES THE NEW BALANCE

        If addedBalance > 0 Then ' PREVENTS ENTRY OF NEGATIVE NUMBERS
            If TextBox_CNumbers.Text.Length = 16 And TextBox_CExpiry.Text.Length = 4 And TextBox_CVV.Text.Length = 3 Then
                SQL.AddParam("@pNewBalance", Convert.ToString(newBal))
                SQL.AddParam("@pUsername", username)
                SQL.UpdateRecord("UPDATE tblMainAccount SET Balance = @pNewBalance WHERE Username = @pUsername") ' UPDATES THE DATABASE WITH THE NEW INFORMATION
                MainAccount.Label_Balance.Text = updateBalance(username) ' UPDATES THE LABEL BALANCE
                MsgBox("Balance has been updated")
                Me.Hide()
            Else
                MsgBox("Please fill in the fields correctly, check the ? icon for help") ' ERROR MESSAGE INCASE THE AMOUNT ADDED IS INVALID I.E. A NEGATIVE VALUE
            End If
        Else
            MsgBox("Please enter a valid value to top up")
        End If
    End Sub
    Public Function updateBalance(inUsername As String) ' SUBROUTINE USED TO UPDATE THE BALANCE LABEL
        SQL.AddParam("@pUsername", inUsername)
        SQL.ExecQuery("SELECT Balance FROM tblMainAccount WHERE Username= @pUsername") ' TAKES THE NEW BALANCE FROM THE DATABASE
        For Each r In SQL.SQLDS.Tables(0).Rows
            ' UPDATES THE LABEL
            Return r("Balance")
        Next
    End Function

    Private Sub Button_Help_Click(sender As Object, e As EventArgs) Handles Button_Help.Click
        MsgBox("Card Number must be 16 digits " & "Expiry Date comes in the format mmyy")
    End Sub

End Class