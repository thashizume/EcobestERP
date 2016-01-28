Public Class modelMenu

    Private _menuID As Long = 0
    Private _invalid As Long = 0
    Private _menuName As String
    Private _menuTitle As String
    Private _imageID As Long
    Private _imageName As String
    Private _createDate As Date
    Private _modifyDate As Date

    Public Property MenuID As Long
        Get
            Return _menuID
        End Get
        Set(value As Long)
            _menuID = value
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

    Public Property MenuName As String
        Get
            Return _menuName
        End Get
        Set(value As String)
            _menuName = value
        End Set
    End Property

End Class
