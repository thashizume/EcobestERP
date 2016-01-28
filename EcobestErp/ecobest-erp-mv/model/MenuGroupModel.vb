Public Class MenuGroupModel

    Private _menuGroupID As Long
    Private _invalid As Long
    Private _title As String
    Private _createDate As String
    Private _modifyDate As String

    Public Property MenuGroupID As Long
        Get
            Return _menuGroupID
        End Get
        Set(value As Long)
            _menuGroupID = value
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

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
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
            result += "insert into MenuGroup ( INVALID, TITLE, CREATE_DATE, MODIFY_DATE) values ( "
            result += " " & _invalid
            result += ", '" & _title & "'"
            result += ", getdate()"
            result += ", getdate()"
            result += ")"
            Return result
        End Get
    End Property

End Class
