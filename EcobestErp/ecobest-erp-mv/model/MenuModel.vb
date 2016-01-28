Public Class MenuModel

    Private _menuID As Long = 0
    Private _invalid As Long = 0
    Private _menuGroupID = 0
    Private _title As String
    Private _imageName As String
    Private _tipText As String
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

    Public Property MenuGroupID As Long
        Get
            Return _menuGroupID
        End Get
        Set(value As Long)
            _menuGroupID = value
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

    Public Property ImageNmae As String
        Get
            Return _imageName
        End Get
        Set(value As String)
            _imageName = value
        End Set
    End Property

    Public Property TipText As String
        Get
            Return _tipText
        End Get
        Set(value As String)
            _tipText = value
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
            result += "insert into Menu ( INVALID, MENU_GROUP_ID, TITLE, IMAGE_NAME, TiP_TEXT, CREATE_DATE, MODIFY_DATE) values ( "
            result += "  " & _invalid
            result += ", " & _menuGroupID
            result += ", '" & _title & "'"
            result += ", '" & _imageName & "'"
            result += ", '" & _tipText & "'"
            result += ", getdate()"
            result += ", getdate()"
            result += ")"
            Return result
        End Get
    End Property

    Public Function getMenuIDByName(menuName As String, db As jp.polestar.db.SQLServer) As Long
        Dim result As Long = 0
        Dim r As SqlClient.SqlDataReader
        r = db.ExecuteQuery("select MENU_ID from Menu where 1=1 and INVALID=0 and TITLE='" & menuName & "'")
        If r.Read() Then result = CLng(r.Item(0))
        r.Close()
        Return result
    End Function

    Public Function getMenuGroupIDByName(menuGroupName As String, db As jp.polestar.db.SQLServer) As Long
        Dim result As Long = 0
        Dim r As SqlClient.SqlDataReader
        r = db.ExecuteQuery("select MENU_GROUP_ID from MenuGroup where 1=1 and INVALID=0 and TITLE='" & menuGroupName & "'")
        If r.Read() Then result = CLng(r.Item(0))
        r.Close()
        Return result
    End Function

End Class
