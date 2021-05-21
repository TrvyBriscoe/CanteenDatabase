Imports System.Security.Cryptography
Imports System.Text
Public Class ValidCredentials
    Dim sql As New SQLControl

    Public Function CreateRandomSalt() As String
        'the following is the string that will hold the salt characters
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=][}{<>"
        Dim salt As String = ""
        Dim rnd As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 100 'Length of the salt
            Dim x As Integer = rnd.Next(0, mix.Length - 1)
            salt &= (mix.Substring(x, 1))
        Next
        Return salt
    End Function
    Public Function Hash512(Password As String, salt As String) As String
        'convertes the password and the salt into a byte
        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(Password & salt)
        'sets the hashing alogoritm 
        Dim hashType As HashAlgorithm = New SHA512Managed()
        'Hash the password and hash together as a byte
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        'converts the hash as a string and then stores it as hashed result
        Dim hashedResult As String = Convert.ToBase64String(hashBytes)
        Return hashedResult
    End Function
    Public Function CheckCreds(Username As String, Password As String) As Boolean
        'checks the username to see if it exists
        sql.AddParam("@pUser", Username)
        sql.ExecQuery("SELECT Username FROM tblMainAccount WHERE Username = @pUser")
        'if the recordcount>0 then the user exists
        If sql.RecordCount > 0 Then
            sql.AddParam("@pUserN", Username)
            'checks to see if when the raw, plaintext password is hashed are the values returned equal
            sql.ExecQuery("SELECT HashedPass, Salt FROM tblMainAccount WHERE Username = @pUserN")
            For Each c In sql.SQLDS.Tables(0).Rows
                If Hash512(Password, c("Salt")) = c("HashedPass") Then
                    Return True
                Else
                    Return False
                End If
            Next
        Else
            Return False
        End If
    End Function
    Public Function ForgotP(inUsername As String, inMaiden As String) As Boolean
        Dim Maid As String
        sql.AddParam("@pUser", inUsername)
        sql.AddParam("@pMaiden", inMaiden)
        sql.ExecQuery("SELECT Maiden FROM tblMainAccount WHERE Username = @pUser")
        If sql.RecordCount > 0 Then
            For Each r In sql.SQLDS.Tables(0).Rows
                Maid = r("Maiden")
            Next
            If Maid = inMaiden Then
                Return True
            Else
                MsgBox("Details are incorrect")
                Return False
            End If
        Else
            MsgBox("Username is incorrect")
            Return False
        End If
    End Function

    Public Sub ChangePass(PlainPass As String, inusername As String)
        'Hashes the new password using a salt and the password entered 
        Dim Salt As String = CreateRandomSalt()
        Dim HashedPassword As String = Hash512(PlainPass, Salt)
        sql.AddParam("@pHashPass", HashedPassword)
        sql.AddParam("@pNewSalt", Salt)
        sql.AddParam("@pUser", inusername)
        'updates the current hashed password with the new hash
        sql.UpdateRecord("UPDATE tblMainAccount SET HashedPass = @pHashPass, Salt = @pNewSalt WHERE Username = @pUser")
    End Sub
    Public Function Duplicate(username As String) As Boolean
        'checks to see if the user name already exists within the database
        sql.AddParam("@pUserN", username)
        sql.ExecQuery("SELECT Username FROM tblMainAccount WHERE Username = @pUserN")
        If sql.RecordCount > 0 Then
            'returns true if the user exists if not it returns false
            Return True
        Else
            Return False
        End If
    End Function
    Public Function childDuplicate(username As String) As Boolean
        'checks to see if the unique identifier of the child has been used already
        sql.AddParam("@pPUser", username)
        sql.ExecQuery("SELECT UniqueID FROM tblStudent WHERE PUserName = @pPUser")
        'returns true if the identifier exists and false if not
        If sql.RecordCount > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
