Imports System.Data.OleDb
Imports System.Data
Imports System.Security.Cryptography
Imports System.Text

Public Class SQLControl
    ' SQL CONNECTION TO THE DATABASE
    Public SQLCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= TroyDatabase.accdb;Persist Security Info=False;")
    Public SQLCmd As OleDbCommand
    ' SLQ DATA 
    Public SQLDA As OleDbDataAdapter
    Public SQLDS As DataSet
    Public SQLDT As DataTable
    ' QUERY PARAMETERS
    Public SQLParams As New List(Of OleDbParameter)
    ' QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String


    ' CONNECTION TEST
    Public Function HasConnection() As Boolean
        Try
            SQLCon.Open()
            SQLCon.Close()
            Return True
        Catch ex As Exception
            Exception = ex.Message
            MsgBox(Exception)
            Return False
        End Try
    End Function

    ' EXECUTE PARAMETERISED QUERY
    Public Function returnQuery(Query As String) As List(Of Object)
        Dim listofItems As List(Of Object)
        Try
            SQLCon.Open()
            SQLCmd = New OleDbCommand(Query, SQLCon)
            For Each p In SQLParams
                SQLCmd.Parameters.Add(p)
                SQLCmd.Parameters(p.ParameterName).Value = p.Value
            Next
            SQLParams.Clear()
            SQLDA = New OleDbDataAdapter(SQLCmd)
            SQLDS = New DataSet

            RecordCount = SQLDA.Fill(SQLDS)
            SQLCon.Close()

            For Each r As DataRow In SQLDS.Tables(0).Rows
                listofItems.Add(r)
            Next
            Return listofItems
        Catch ex As Exception
        End Try
    End Function
    Public Sub ExecQuery(Query As String)
        Try
            SQLCon.Open()

            SQLCmd = New OleDbCommand(Query, SQLCon)

            For Each p In SQLParams
                SQLCmd.Parameters.Add(p)
                SQLCmd.Parameters(p.ParameterName).Value = p.Value
            Next

            SQLParams.Clear()

            SQLDA = New OleDbDataAdapter(SQLCmd)
            SQLDS = New DataSet
            RecordCount = SQLDA.Fill(SQLDS)
            SQLCon.Close()
        Catch ex As Exception
            Exception = ex.Message
            MsgBox(Exception)
        End Try

        If SQLCon.State = ConnectionState.Open Then
            SQLCon.Close()
        End If

    End Sub
    Public Sub AddParam(Name As String, Value As Object, Optional DataType As SqlDbType = SqlDbType.VarChar)
        Dim newParam As New OleDbParameter With {.ParameterName = Name, .Value = Value, .DbType = DataType}
        SQLParams.Add(newParam)
    End Sub
    Public Sub ClearParams()
        SQLParams.Clear()
    End Sub

    Public Sub UpdateRecord(Query As String)
        Try
            SQLCon.Open()
            SQLCmd = New OleDbCommand(Query, SQLCon)

            For Each p In SQLParams
                SQLCmd.Parameters.Add(p)
                SQLCmd.Parameters(p.ParameterName).Value = p.Value
            Next
            SQLParams.Clear()

            RecordCount = SQLCmd.ExecuteNonQuery()

            SQLCon.Close()

        Catch ex As Exception
            Exception = ex.Message
            MsgBox(Exception)
        End Try

        If SQLCon.State = ConnectionState.Open Then
            SQLCon.Close()
        End If
    End Sub

    Public Sub deleteRecord(Query As String)
        Try
            SQLCon.Open()
            SQLCmd = New OleDbCommand(Query, SQLCon)
            SQLCmd.ExecuteNonQuery()
            SQLCon.Close()
        Catch ex As Exception
            Exception = ex.Message
            MsgBox(Exception)
        End Try

        If SQLCon.State = ConnectionState.Open Then
            SQLCon.Close()
        End If
    End Sub

    Public Function CreateRandomSalt() As String
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=][}{<>"
        Dim salt As String = ""
        Dim rnd As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 100
            Dim x As Integer = rnd.Next(0, mix.Length - 1)
            salt &= (mix.Substring(x, 1))
        Next
        Return salt
    End Function
    Public Function Hash512(Password As String, salt As String) As String
        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(Password & salt)
        Dim hashType As HashAlgorithm = New SHA512Managed() 'encrypts the password with the salt
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        Dim hashedResult As String = Convert.ToBase64String(hashBytes)
        Return hashedResult
    End Function

    Public Sub addUserAdult(inUsername As String, inPassword As String, inFirst As String, inLast As String, inChild As String, inBalance As String, inPrivilege As String, inMaiden As String)

        Dim NewSalt As String = CreateRandomSalt()
        Dim hashedPassword As String = Hash512(inPassword, NewSalt)
        Try
            AddParam("@pNUser", inUsername)
            AddParam("@pFirst", inFirst)
            AddParam("@pLast", inLast)
            AddParam("@pChild", inChild)
            AddParam("@pBalance", inBalance)
            AddParam("@pPrivilege", inPrivilege)
            AddParam("@pHashPass", hashedPassword)
            AddParam("@pSalt", NewSalt)
            AddParam("@pMaiden", inMaiden)
            Dim insertstring As String = "INSERT INTO tblMainAccount (Username, FirstName, LastName, ChildFName, Balance, Privilege, HashedPass, Salt, Maiden) VALUES (@pNUser, @pFirst, @pLast, @pChild, @pBalance, @pPrivilege, @pHashPass, @pSalt, @pMaiden)"
            SQLCon.Open()
            SQLCmd = New OleDbCommand(insertstring, SQLCon)
            For Each p In SQLParams
                SQLCmd.Parameters.Add(p)
                SQLCmd.Parameters(p.ParameterName).Value = p.Value
            Next
            SQLParams.Clear()
            SQLCmd.ExecuteNonQuery()
            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If SQLCon.State = ConnectionState.Open Then
            SQLCon.Close()
        End If
    End Sub
    Public Sub addUserChild(inUsername As String, inChild As String, inUnique As String)
        Try
            AddParam("@pUser", inUsername)
            AddParam("@pChild", inChild)
            AddParam("@pUnique", inUnique)
            Dim insertstring As String = "INSERT INTO tblStudent (PUserName,ChildFName, UniqueID) VALUES (@pChild, @pUser, @pUnique)"
            SQLCon.Open()
            SQLCmd = New OleDbCommand(insertstring, SQLCon)
            For Each p In SQLParams
                SQLCmd.Parameters.Add(p)
                SQLCmd.Parameters(p.ParameterName).Value = p.Value
            Next
            SQLParams.Clear()
            SQLCmd.ExecuteNonQuery()
            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If SQLCon.State = ConnectionState.Open Then
            SQLCon.Close()
        End If
    End Sub

    Public Sub loadDataGrid(Query As String, DGV As DataGridView)
        DGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        SQLDT = New DataTable
        ExecQuery(Query)
        SQLDA.Fill(SQLDT)
        DGV.DataSource = SQLDT
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.MultiSelect = False
        DGV.ReadOnly = True
        DGV.RowHeadersVisible = False
        DGV.AllowUserToAddRows = False
    End Sub
End Class


