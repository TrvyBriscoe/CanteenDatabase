Imports System.Data

Public Class userInstance
    Dim SQL As New SQLControl

    Private firstname As String
    Private surname As String
    Private username As String
    Private childfname As String
    Private AdminPriviledge As String
    Private Balance As String
    Private BreakHist As String
    Private LunchHist As String
    Private UniqueID As String
    Private CAllowance As String
    Private TotalSpent As String

    Public Sub New(uName As String)
        updateCurrentUser(uName)
    End Sub

    ' GETTERS
    Public Function getAccountType() As String
        Return AdminPriviledge 'get the account type of the user
    End Function
    Public Function getFirstname() As String
        Return firstname ' retrieves the first name of the user
    End Function
    Public Function getSurname() As String
        Return surname ' returns the surname of the user
    End Function
    Public Function getUsername() As String
        Return username '  returns the username
    End Function
    Public Function getChild() As String
        Return childfname ' returns the name of the users child
    End Function
    Public Function getBalance() As String
        'Updates the starting balance
        SQL.AddParam("@pUsername", getUsername())
        SQL.ExecQuery("SELECT Balance FROM tblMainAccount WHERE Username = @pUsername")
        For Each r In SQL.SQLDS.Tables(0).Rows
            Balance = r("Balance")
        Next
        ' this updates the balance and THEN return it so everytime you get balance it
        ' will check if it has changed at all
        Return Balance
    End Function
    'checks to see if the account is an admin or not and returns either true or false depending on the privilege field in the database
    Public Function isAdmin() As Boolean
        If getAccountType() = "Admin" Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function isCanteen() As Boolean
        If getAccountType() = "Canteen" Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function getallowance() As String
        Return CAllowance ' retrieves the childs allowance
    End Function
    Public Function getBreakHistory() As String
        Return BreakHist 'retrieves the breakfast items that the child purchased
    End Function
    Public Function getLunchHistory() As String
        Return LunchHist 'retrieces the lunch items that the child purchased
    End Function
    Public Function gettotalspent() As String
        Return TotalSpent 'retirves the total amount of money that the child has spent
    End Function

    'SETTERS
    Public Sub updateFirstname(fName As String) 'updates the firstname of a user
        firstname = fName
    End Sub
    Public Sub updateSurname(sName As String) 'updates the surname of a user
        surname = sName
    End Sub
    Public Sub updateUsername(uName As String) ' updates the username of a user
        username = uName
    End Sub

    Private Sub updateCurrentUser(uName As String)
        ' LOAD USERS DATA INTO INSTANCE OF A USER

        ' ADD PARAMETERS
        SQL.AddParam("@uNameID", uName, SqlDbType.VarChar)

        ' EXECUTE QUERY
        SQL.ExecQuery("SELECT Username, FirstName, LastName, ChildFName, Balance, Privilege FROM tblMainAccount WHERE Username = @uNameID")

        ' IF VALUES ARE FOUND FOR THESE FIELDS
        If SQL.RecordCount > 0 Then

            ' LOAD THE OBJECT VARIABLES WITH DATA
            For Each c In SQL.SQLDS.Tables(0).Rows
                username = c("Username")
                firstname = c("FirstName")
                surname = c("LastName")
                Balance = c("Balance")
                AdminPriviledge = c("Privilege")
                childfname = c("ChildFName")
            Next
        End If
        'add parameters
        SQL.AddParam("@pChild", childfname)
        'execture query
        SQL.ExecQuery("SELECT BreakfastHistory, UniqueID, LunchHistory, Allowance, TotalSpent FROM tblStudent WHERE ChildFName = @pChild")
        ' IF VALUES ARE FOUND FOR THESE FIELDS
        If SQL.RecordCount > 0 Then
            ' LOAD THE OBJECT VARIABLES WITH DATA
            For Each c In SQL.SQLDS.Tables(0).Rows
                BreakHist = c("BreakfastHistory")
                UniqueID = c("UniqueID")
                LunchHist = c("LunchHistory")
                CAllowance = c("Allowance")
                TotalSpent = c("TotalSpent")
            Next
        End If
    End Sub

End Class

