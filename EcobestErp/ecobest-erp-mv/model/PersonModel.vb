Public Class PersonModel

    Private _personID As Long = 0
    Private _invalid As Long = 0
    Private _firstNameKJ = String.Empty
    Private _lastNameKJ = String.Empty
    Private _createDate As Date
    Private _modifyDate As Date

    Public Property PersonID As Long
        Get
            Return _personID
        End Get
        Set(value As Long)
            _personID = value
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

    Public Property FirstNameKanji As String
        Get
            Return _firstNameKJ
        End Get
        Set(value As String)
            _firstNameKJ = value
        End Set
    End Property

    Public Property LastNameKanji As String
        Get
            Return _lastNameKJ
        End Get
        Set(value As String)
            _lastNameKJ = value
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
            result += "insert into Person ( INVALID, FIRST_NAME_KJ, LAST_NAME_KJ, CREATE_DATE, MODIFY_DATE) values ( "
            result += " " & _invalid
            result += ", '" & (New jp.polestar.security.Cryptography).Encrypt(_firstNameKJ, FingerPrint) & "'"
            result += ", '" & (New jp.polestar.security.Cryptography).Encrypt(_lastNameKJ, FingerPrint) & "'"
            result += ", getdate()"
            result += ", getdate()"
            result += ")"
            Return result
        End Get
    End Property

End Class
