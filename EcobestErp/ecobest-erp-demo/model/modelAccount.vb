Public Class modelAccount

    Private _accountID As Long
    Private _invalid As Long
    Private _personID As Long
    Private _account As String
    Private _accountPass As String
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


End Class
