Public Class Lunch
    Dim sql As New SQLControl
    Dim i As Integer
    Dim j As Integer
    Dim special As String
    Public Tprice As Decimal
    Public FoodList As New List(Of String)
    Public Sub Button_ItemList_Click(sender As Object, e As EventArgs) Handles Button_ItemList.Click
        Dim itemList As String = ""
        For Each elem As String In FoodList 'takes each element in the list and adds it to a string 
            itemList &= elem & " ,"
        Next
        MsgBox(itemList, MsgBoxStyle.OkOnly) 'displays the string in a message box
    End Sub
    Public Sub Button_1_Click(sender As Object, e As EventArgs) Handles Button_1.Click
        j = 1
    End Sub 'sets number of iterations to 1

    Public Sub Button_2_Click(sender As Object, e As EventArgs) Handles Button_2.Click
        j = 2
    End Sub 'sets number of iterations to 2

    Public Sub Button_3_Click(sender As Object, e As EventArgs) Handles Button_3.Click
        j = 3
    End Sub 'sets number of iterations to 3

    Public Sub Button_4_Click(sender As Object, e As EventArgs) Handles Button_4.Click
        j = 4
    End Sub 'sets number of iterations to 4

    Public Sub Button_5_Click(sender As Object, e As EventArgs) Handles Button_5.Click
        j = 5
    End Sub 'sets number of iterations to 5

    Public Sub Button_6_Click(sender As Object, e As EventArgs) Handles Button_6.Click
        j = 6
    End Sub 'sets number of iterations to 6

    Public Sub Button_7_Click(sender As Object, e As EventArgs) Handles Button_7.Click
        j = 7
    End Sub 'sets number of iterations to 7

    Public Sub Button_8_Click(sender As Object, e As EventArgs) Handles Button_8.Click
        j = 8
    End Sub 'sets number of iterations to 8
    '
    Public Sub Button_9_Click(sender As Object, e As EventArgs) Handles Button_9.Click
        j = 9
    End Sub 'sets number of iterations to 8
    Public Sub Button_Remove_Click(sender As Object, e As EventArgs) Handles Button_Remove.Click
        Sql.AddParam("@PItemPrice", Label_Recent.Text)
        sql.ExecQuery("SELECT Price FROM tblLunch WHERE Item = @PItemname")
        For Each r In Sql.SQLDS.Tables(0).Rows
            Tprice = Tprice - r("Price") 'subtracts the price of a given item from the total price
            Label_Price.Text = Tprice 'updates the label
        Next
        FoodList.Remove(Label_Recent.Text) 'removes the food iten from the list

        If FoodList IsNot Nothing And FoodList.Count = 0 Then
            FoodList.Clear()
            Label_Recent.Text = "" 'sets the text to a blank when there are no items present in the list
        Else
            Label_Recent.Text = FoodList.Last 'sets the label to the last item in the list
        End If
    End Sub
    Public Sub Order(special As String)
        Do Until i = j And i < 10
            Sql.AddParam("@PFooditem", special)
            sql.ExecQuery("SELECT Item, Price,FoodID FROM tblLunch WHERE Item = @PFooditem")
            For Each r In Sql.SQLDS.Tables(0).Rows
                FoodList.Add(r("Item"))
                Label_Recent.Text = r("Item") 'sets the recently purchased item label to the item found in the database
                Label_Price.Text = Tprice + r("Price") 'adds the price to the total price and updates the label
                Tprice = Label_Price.Text 'updates the total balance
            Next
            i = i + 1 'adds 1 until all iterations are complete
        Loop
        i = 0 'resets the value of i
        j = 0
    End Sub
    Private Sub Button_Curry_Click(sender As Object, e As EventArgs) Handles Button_Curry.Click
        special = "Chicken Curry" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_Fish_Click(sender As Object, e As EventArgs) Handles Button_Fish.Click
        special = "Fish, Chips and Beans" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_SRoll_Click(sender As Object, e As EventArgs) Handles Button_SRoll.Click
        special = "Sausage Roll and Potoato Wedges" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_BTacos_Click(sender As Object, e As EventArgs) Handles Button_BTacos.Click
        special = "Beef Tacos and Rice" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_Chicken_Click(sender As Object, e As EventArgs) Handles Button_Chicken.Click
        special = "Fried Chicken and Roast Peppers" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_Las_Click(sender As Object, e As EventArgs) Handles Button_Las.Click
        special = "Lasagne" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_Omolette_Click(sender As Object, e As EventArgs) Handles Button_Omolette.Click
        special = "Tomato and Basil Omolette" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_MVTortilla_Click(sender As Object, e As EventArgs) Handles Button_MVTortilla.Click
        special = "Mixed Vegetable Tortilla" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_TBCWrap_Click(sender As Object, e As EventArgs) Handles Button_TBCWrap.Click
        special = "Texan Bean Chilli Wrap" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_Kebab_Click(sender As Object, e As EventArgs) Handles Button_Kebab.Click
        special = "Vegetable Kebab" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_Pasty_Click(sender As Object, e As EventArgs) Handles Button_Pasty.Click
        special = "Vegetable Pasty" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_VStew_Click(sender As Object, e As EventArgs) Handles Button_VStew.Click
        special = "Vegetable and Bean Stew" 'sets the food item = special
        Order(special)
    End Sub
    Private Sub Button_GBread_Click(sender As Object, e As EventArgs) Handles Button_GBread.Click
        special = "Garlic Bread" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_Panini_Click(sender As Object, e As EventArgs) Handles Button_Panini.Click
        special = "Panini" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_SWich_Click(sender As Object, e As EventArgs) Handles Button_SWich.Click
        special = "Sandwich" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_Fruit_Click(sender As Object, e As EventArgs) Handles Button_Fruit.Click
        special = "Fruit" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_Salad_Click(sender As Object, e As EventArgs) Handles Button_Salad.Click
        special = "Salad" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_Water_Click(sender As Object, e As EventArgs) Handles Button_Water.Click
        special = "Water" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_CartonJ_Click(sender As Object, e As EventArgs) Handles Button_CartonJ.Click
        special = "Carton Juice" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_Bottle_Click(sender As Object, e As EventArgs) Handles Button_Bottle.Click
        special = "Bottled Drink" 'sets the food item = special
        Order(special)
    End Sub

    Private Sub Button_Checkout_Click(sender As Object, e As EventArgs) Handles Button_Checkout.Click
        Cashout.Label_FinalPrice.Text = Label_Price.Text 'sets the final price in the cashout form
        Dim LunchList As String = ""
        ' this will compile the health points of each item in the list of the item
        Dim totalHealthPoints As Integer = 0
        For Each item In FoodList
            sql.AddParam("@pFoodName", item)
            sql.ExecQuery("SELECT Points FROM tblAllFood WHERE Food = @pFoodName")
            For Each r In sql.SQLDS.Tables(0).Rows
                totalHealthPoints = totalHealthPoints + r("Points")
            Next
        Next
        For Each elem As String In FoodList 'turns the list into a string
            LunchList &= elem & " ,"
        Next
        MsgBox(LunchList)
        Cashout.LunchList = LunchList 'transfers the string to the next form
        Cashout.Label_hp.Text = Convert.ToString(totalHealthPoints) ' transfers health points
        Cashout.Show() 'displays the new form
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Dim result = MessageBox.Show(" Are you sure you want to quit", "Are you sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then 'closes the form and clears all information
            Tprice = 0
            FoodList.Clear()
            Label_Recent.Text = ""
            Label_Price.Text = ""
            CanteenMenuChoice.Show()
            Me.Hide()
        End If
    End Sub

End Class