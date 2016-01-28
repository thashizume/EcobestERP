Public Class authController

    Private _model As AccountModel = New AccountModel
    Private _account As jp.polestar.ecobest.erp.AccountModel = Nothing
    Private _accountName As String = String.Empty
    Private _accountPassword As String = String.Empty
    Private _errReason As String = String.Empty
    Private _hasError As Boolean = False


    Public Sub New()

    End Sub

    Public ReadOnly Property Account
        Get
            Return _account
        End Get
    End Property

    Public Property AccountName As String
        Get
            Return _accountName
        End Get
        Set(value As String)
            _accountName = value
        End Set
    End Property

    Public Property AccountPassword As String
        Get
            Return _accountPassword
        End Get
        Set(value As String)
            _accountPassword = value
        End Set
    End Property

    Public ReadOnly Property HasError As Boolean
        Get
            Return _haserror
        End Get
    End Property

    Public ReadOnly Property ErrorReason As String
        Get
            Return _errReason
        End Get
    End Property

    Public Function SignIn() As Boolean
        Dim result As Boolean = False
        Dim a As AccountModel
        Dim db As jp.polestar.db.SQLServer = New jp.polestar.db.SQLServer(ConnectionString, False)
        Dim reader As SqlClient.SqlDataReader = _
            db.ExecuteQuery("select * from Account where 1=1 and invalid=0 and Account='" & (New jp.polestar.security.Cryptography).Encrypt(_accountName) & "'")

        If reader.HasRows Then
            a = New AccountModel
            reader.Read()
            a.AccountID = reader(0)
            a.Invalid = reader(1)
            a.PersonID = reader(2)
            a.Account = (New jp.polestar.security.Cryptography).Decrypt(reader(3))
            a.AccountPass = (New jp.polestar.security.Cryptography).Decrypt(reader(4))
            a.CreateDate = reader(5)
            a.ModifyDate = reader(6)

            If a.AccountPass <> _accountPassword Then
                _errReason = "パスワードが違います"
                result = False
                _hasError = True
            Else
                result = True
                _account = a
            End If

            reader.Close()
            db.Close()

        Else
            _errReason = "ユーザ名が不明です"
            _hasError = True
            result = False
        End If

        Return result
    End Function

    Public Function Add(account As AccountModel) As Boolean
        Dim result As Boolean = False
        Dim db As jp.polestar.db.SQLServer
        Try
            db = New jp.polestar.db.SQLServer(ConnectionString, False)
            db.ExecuteQueryNoResult(account.InsertString)
            result = True
        Catch ex As Exception
            result = False
            _hasError = True
            _errReason = ex.InnerException.ToString
        End Try

        Return result
    End Function



End Class
