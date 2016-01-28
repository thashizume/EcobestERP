Public Class AccountModel

    Private _accountID As Long = 0
    Private _invalid As Long = 0
    Private _personID As Long = 0
    Private _account As String = String.Empty
    Private _accountPass As String = String.Empty
    Private _createDate As Date
    Private _modifyDate As Date

    Public Property AccountID As Long
        Get
            Return _accountID
        End Get
        Set(value As Long)
            _accountID = value
        End Set
    End Property

    Public Property Invalid As Long
        Get
            Return _invalid
        End Get
        Set(value As Long)
            _invalid = value
        End Set
    End Property

    Public Property PersonID As Long
        Get
            Return _personID
        End Get
        Set(value As Long)
            _personID = value
        End Set
    End Property

    Public Property Account As String
        Get
            Return _account
        End Get
        Set(value As String)
            _account = value
        End Set
    End Property

    Public Property AccountPass As String
        Get
            Return _accountPass
        End Get
        Set(value As String)
            _accountPass = value
        End Set
    End Property

    Public Property CreateDate As Date
        Get
            Return _createDate
        End Get
        Set(value As Date)
            _createDate = value
        End Set
    End Property

    Public Property ModifyDate As Date
        Get
            Return _modifyDate
        End Get
        Set(value As Date)
            _modifyDate = value
        End Set
    End Property

    Public ReadOnly Property InsertString() As String
        Get
            Dim result As String = String.Empty
            result += "insert into Account ( INVALID, PERSON_ID, ACCOUNT, ACCOUNT_PASS, CREATE_DATE, MODIFY_DATE) values ( "
            result += " " & _invalid
            result += ", " & _personID
            result += ", '" & (New jp.polestar.security.Cryptography).Encrypt(_account, jp.polestar.ecobest.erp.mdFingerPrint.FingerPrint) & "'"
            result += ", '" & (New jp.polestar.security.Cryptography).Encrypt(_accountPass, jp.polestar.ecobest.erp.mdFingerPrint.FingerPrint) & "'"
            result += ", getdate()"
            result += ", getdate()"
            result += ")"
            Return result
        End Get
    End Property

    Public ReadOnly Property DeleteString() As String
        Get
            Dim result As String = String.Empty
            result += "update Account set INVALID=1 , MODIFY_DATE=getDate() where ACCOUNT_ID=" & _accountID & "  "
            Return result
        End Get
    End Property

    Public ReadOnly Property ChangePasswordString(newPassword As String) As String
        Get
            Dim result As String = String.Empty
            result += "update Account set ACCOUNT_PASS ='" & newPassword & "', MODIFY_DATE=getDate() where ACCOUNT_ID=" & _accountID & "  "
            Return result
        End Get
    End Property

    Public Function getAccountIDByAccount(account As String, db As jp.polestar.db.SQLServer) As Long
        Return getAccountByAccount(account, db).AccountID
    End Function

    Public Function getAccountByAccount(account As String, db As jp.polestar.db.SQLServer) As AccountModel
        Dim result As AccountModel = New AccountModel

        Dim r As SqlClient.SqlDataReader
        r = db.ExecuteQuery("select * from Account where 1=1 and INVALID=0 and ACCOUNT='" & (New jp.polestar.security.Cryptography).Encrypt(account) & "'")
        If r.Read() Then
            result.AccountID = CLng(r.Item(0))
            result.Invalid = CLng(r.Item(1))
            result.PersonID = CLng(r.Item(2))
            result.Account = CStr((New jp.polestar.security.Cryptography).Decrypt(r.Item(3)))
            result.AccountPass = CStr((New jp.polestar.security.Cryptography).Decrypt(r.Item(4)))
            result.CreateDate = CDate(r.Item(5))
            result.ModifyDate = CDate(r.Item(6))
        End If
        r.Close()
        Return result
    End Function


End Class
