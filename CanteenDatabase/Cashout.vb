Public Class Cashout
    Dim sql As New SQLControl
    Dim Balance As Decimal
    Dim newbalance As Decimal
    Dim allowance As Decimal
    Dim healthp As Integer
    Dim pname, ID, username, hp As String
    Public BreakList As String
    Public LunchList As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql.AddParam("@pID", TextBox1.Text)
        ID = TextBox1.Text
        sql.ExecQuery("SELECT PUserName, Allowance, HealthPoints FROM tblStudent WHERE UniqueID= @pID")
        For Each r In sql.SQLDS.Tables(0).Rows
            pname = r("PUserName")
            allowance = r("Allowance")
            hp = r("HealthPoints")
        Next
        healthp = Convert.ToInt32(Label_hp.Text) + Convert.ToInt32(hp)
        MsgBox(pname)
        sql.AddParam("@PName", pname)
        sql.ExecQuery("SELECT Username, Balance FROM tblMainAccount WHERE UserName= @PName")
        For Each r In sql.SQLDS.Tables(0).Rows
            username = r("Username")
            Balance = r("Balance")
        Next
        Dim minusBalance As Decimal = Convert.ToDecimal(Label_FinalPrice.Text)
        If minusBalance > allowance Then
            MsgBox("Order Cannot be Completed allowance exceeded, the childs allowance is curreently £" & allowance) 'error message if order price exceeds the allowance
        Else
            If Balance - minusBalance > 0 Then
                newbalance = Balance - minusBalance
                MsgBox("Order Completed", MsgBoxStyle.OkOnly)
                TextBox1.Text = ""
                If LunchList = "" Then
                    sql.AddParam("@pBreakHist", BreakList)
                    sql.AddParam("@pTotal", minusBalance)
                    sql.AddParam("@pHealthPoint", Convert.ToString(healthp))
                    sql.AddParam("@pChild", ID)
                    sql.UpdateRecord("UPDATE tblStudent SET BreakfastHistory = @pBreakHist, TotalSpent = @pTotal, HealthPoints = @pHealthPoint WHERE UniqueID = @pChild")
                    Breakfast.Label_Recent.Text = ""
                    Breakfast.FoodList.Clear()
                    Breakfast.Label_Price.Text = ""
                    Breakfast.Tprice = 0
                    BreakList = ""
                    Me.Hide()
                Else
                    sql.AddParam("@pLunchHist", LunchList)
                    sql.AddParam("@pTotal", minusBalance)
                    sql.AddParam("@pHealthPoint", Convert.ToString(healthp))
                    sql.AddParam("@pChild", ID)
                    sql.UpdateRecord("UPDATE tblStudent SET LunchHistory = @pLunchHist, TotalSpent = @pTotal, HealthPoints = @pHealthPoint WHERE UniqueID = @pChild")
                    Lunch.Label_Recent.Text = ""
                    Lunch.FoodList.Clear()
                    Lunch.Label_Price.Text = ""
                    Lunch.Tprice = 0
                    LunchList = ""
                    Me.Hide()
                End If
                sql.AddParam("pNewBalance", Convert.ToString(newbalance))
                sql.AddParam("@pUsername", username)
                sql.UpdateRecord("UPDATE tblMainAccount SET Balance = @pNewBalance WHERE Username = @pUsername")
                Me.Hide()
            Else
                MsgBox("Cannot complete order the current balance is " & Balance, MsgBoxStyle.OkOnly)
                newbalance = 0
                healthp = 0
                TextBox1.Text = ""
                Me.Hide()
            End If
        End If
    End Sub
End Class