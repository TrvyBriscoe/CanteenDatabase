Imports System.Data.OleDb
Public Class Breakfast
    Dim Sql As New SQLControl
    Dim i As Integer
    Dim j As Integer
    Public Tprice As Decimal
    Public FoodList As New List(Of String)

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label_BreakfastTime.Text = Format(Now, "HH:mm:ss")
    End Sub
    Public Sub Button_1_Click(sender As Object, e As EventArgs) Handles Button_1.Click
        j = 1
    End Sub 'sets the number of iterations to 1

    Public Sub Button_2_Click(sender As Object, e As EventArgs) Handles Button_2.Click
        j = 2
    End Sub 'sets the number of iterations to 2

    Public Sub Button_3_Click(sender As Object, e As EventArgs) Handles Button_3.Click
        j = 3
    End Sub 'sets the number of iterations to 3

    Public Sub Button_4_Click(sender As Object, e As EventArgs) Handles Button_4.Click
        j = 4
    End Sub 'sets the number of iterations to 4

    Public Sub Button_5_Click(sender As Object, e As EventArgs) Handles Button_5.Click
        j = 5
    End Sub 'sets the number of iterations to 5

    Public Sub Button_6_Click(sender As Object, e As EventArgs) Handles Button_6.Click
        j = 6
    End Sub 'sets the number of iterations to 6

    Public Sub Button_7_Click(sender As Object, e As EventArgs) Handles Button_7.Click
        j = 7
    End Sub 'sets the number of iterations to 7

    Public Sub Button_8_Click(sender As Object, e As EventArgs) Handles Button_8.Click
        j = 8
    End Sub 'sets the number of iterations to 8
    '
    Public Sub Button_9_Click(sender As Object, e As EventArgs) Handles Button_9.Click
        j = 9
    End Sub 'sets the number of iterations to

    Public Sub Button_ItemList_Click(sender As Object, e As EventArgs) Handles Button_ItemList.Click
        'this subroutine is used to convert the list into a string to display 
        Dim itemList As String = ""
        For Each elem As String In FoodList
            itemList &= elem & " ,"
        Next
        MsgBox(itemList, MsgBoxStyle.OkOnly) 'displays the list of items within a message box
    End Sub

    Public Sub Button_Remove_Click(sender As Object, e As EventArgs) Handles Button_Remove.Click
        Sql.AddParam("@PItemPrice", Label_Recent.Text)
        Sql.ExecQuery("SELECT Price FROM tblBreakfast WHERE Item = @PItemname")
        For Each r In Sql.SQLDS.Tables(0).Rows
            Tprice = Tprice - r("Price") 'removes the price from the total price
            Label_Price.Text = Tprice 'updates the price label with the current price
        Next
        FoodList.Remove(Label_Recent.Text) ' removes the item in the list that is shown in the recent albel
        If FoodList IsNot Nothing And FoodList.Count = 0 Then 'if the list has no item then it displays nothing in the most recent label
            FoodList.Clear()
            Label_Recent.Text = ""
        Else
            Label_Recent.Text = FoodList.Last 'if the count is greater than 0 the list displays the final item in the list
        End If
    End Sub
    Public Sub Order(special As String)
        Do Until i = j And i < 10 'sets the number of iterations =j 
            Sql.AddParam("@PFooditem", special)
            Sql.ExecQuery("SELECT Item, Price FROM tblBreakfast WHERE Item = @PFooditem")
            For Each r In Sql.SQLDS.Tables(0).Rows
                FoodList.Add(r("Item")) 'adds the item name to the list
                Label_Recent.Text = r("Item") 'updates the recent label with the new item
                Label_Price.Text = Tprice + r("Price") 'updates the price label with the new price
                Tprice = Label_Price.Text 'sets TPrice to the new price
            Next
            i = i + 1 'adds 1 to the iteration giving a stopping clause
        Loop
        i = 0 'resets the vlaue of i after iterations complete
        j = 0
    End Sub
    Public Sub Button_EggScramble_Click(sender As Object, e As EventArgs) Handles Button_EggScramble.Click
        Dim special As String = "Scrambled Egg"
        Order(special) 'sets the food item = special
    End Sub
    Public Sub Button_Bacon_Click(sender As Object, e As EventArgs) Handles Button_Bacon.Click
        Dim special As String = "Bacon"
        Order(special) 'sets the food item = special
    End Sub

    Private Sub Button_BaconBagel_Click(sender As Object, e As EventArgs) Handles Button_BaconBagel.Click
        Dim special As String = "Bacon Bagel"
        Order(special) 'sets the food item = special
    End Sub

    Private Sub Button_BaconRoll_Click(sender As Object, e As EventArgs) Handles Button_BaconRoll.Click
        Dim special As String = "Bacon Roll"
        Order(special) 'sets the food item = special
    End Sub

    Private Sub Button_Sausage_Click(sender As Object, e As EventArgs) Handles Button_Sausage.Click
        Dim special As String = "Sausage"
        Order(special) 'sets the food item = special
    End Sub

    Private Sub Button_SausageRoll_Click(sender As Object, e As EventArgs) Handles Button_SausageRoll.Click
        Dim special As String = "Sausage Roll"
        Order(special) 'sets the food item = special
    End Sub

    Private Sub Button_Pain_Click(sender As Object, e As EventArgs) Handles Button_Pain.Click
        Dim special As String = "Pain au Chocolat"
        Order(special) 'sets the food item = special
    End Sub

    Private Sub Button_BottledDrink_Click(sender As Object, e As EventArgs) Handles Button_BottledDrink.Click
        Dim special As String = "Bottled Drink"
        Order(special) 'sets the food item = special
    End Sub

    Private Sub Button_CartonJuice_Click(sender As Object, e As EventArgs) Handles Button_CartonJuice.Click
        Dim special As String = "Carton Juice"
        Order(special) 'sets the food item = special
    End Sub

    Private Sub Button_Water_Click(sender As Object, e As EventArgs) Handles Button_Water.Click
        Dim special As String = "Water"
        Order(special) 'sets the food item = special
    End Sub

    Private Sub Button_Biscuits_Click(sender As Object, e As EventArgs) Handles Button_Biscuits.Click
        Dim special As String = "Biscuits"
        Order(special) 'sets the food item = special
    End Sub

    Private Sub Button_BlueberryMuffin_Click(sender As Object, e As EventArgs) Handles Button_BlueberryMuffin.Click
        Dim special As String = "Blueberry Muffin"
        Order(special) 'sets the food item = special
    End Sub

    Private Sub Button_Crisps_Click(sender As Object, e As EventArgs) Handles Button_Crisps.Click
        Dim special As String = "Crisps"
        Order(special) 'sets the food item = special
    End Sub

    Private Sub Button_ChocolateCookie_Click(sender As Object, e As EventArgs) Handles Button_ChocolateCookie.Click
        Dim special As String = "Chocolate Cookie"
        Order(special) 'sets the food item = special
    End Sub

    Private Sub Button_WCCookie_Click(sender As Object, e As EventArgs) Handles Button_WCCookie.Click
        Dim special As String = "White Chocolate Cookie"
        Order(special) 'sets the food item = special
    End Sub
    Private Sub Button_Fruit_Click(sender As Object, e As EventArgs) Handles Button_Fruit.Click
        Dim special As String = "Fruit"
        Order(special) 'sets the food item = special
    End Sub
    Public Sub Button_Checkout_Click(sender As Object, e As EventArgs) Handles Button_Checkout.Click
        Cashout.Label_FinalPrice.Text = Label_Price.Text 'sets final price in the new form = total price of the order
        Dim newList As String = ""
        Dim totalHealthPoints As Integer = 0
        For Each item In FoodList
            Sql.AddParam("@pFoodName", item)
            Sql.ExecQuery("SELECT Points FROM tblAllFood WHERE Food = @pFoodName")
            For Each r In Sql.SQLDS.Tables(0).Rows
                totalHealthPoints = totalHealthPoints + r("Points")
            Next
        Next

        For Each elem As String In FoodList 'turns the list into a string to be inserted into the database
            newList &= elem & " ,"
        Next
        Cashout.Label_hp.Text = Convert.ToString(totalHealthPoints)
        Cashout.BreakList = newList 'sets the variable breaklist as the new string 
        Cashout.Show()
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Dim result = MessageBox.Show(" Are you sure you want to quit", "Are you sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then ' closes down the form and send the user back to the menu chocie form
            Label_Price.Text = "" 'resets the values within the form so they are not saved
            Label_Recent.Text = ""
            Tprice = 0
            FoodList.Clear()
            CanteenMenuChoice.Show()
            Me.Hide()
        End If
    End Sub


End Class