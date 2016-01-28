Public Class AccountMenuRoleModel

    Private _account As AccountModel = Nothing
    Private _menu As MenuModel = Nothing
    Private _accountMenuID As Long = 0
    Private _invalid As Long = 0
    Private _accountID As Long = 0
    Private _menuID As Long = 0
    Private _createDate As Date
    Private _modifyDate As Date

    Public Property AccountMenuID As Long
        Get
            Return _accountMenuID
        End Get
        Set(value As Long)
            _accountMenuID = value
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

    Public Property AccountID As Long
        Get
            Return _accountID
        End Get
        Set(value As Long)
            _accountID = value
        End Set
    End Property

    Public Property MenuID As Long
        Get
            Return _menuID
        End Get
        Set(value As Long)
            _menuID = value
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

    Public Property Account As AccountModel
        Get
            Return _account
        End Get
        Set(value As AccountModel)
            If value IsNot Nothing Then _account = value
        End Set
    End Property

    Public Property Menu As MenuModel
        Get
            Return _menu
        End Get
        Set(value As MenuModel)
            If value IsNot Nothing Then _menu = value
        End Set
    End Property

    Public ReadOnly Property InsertString() As String
        Get
            Dim result As String = String.Empty
            result += "insert into AccountMenuRole ( INVALID, ACCOUNT_ID,  MENU_ID, CREATE_DATE, MODIFY_DATE) values ( "
            result += " " & _invalid
            result += ", " & _accountID
            result += ", " & _menuID
            result += ", getdate()"
            result += ", getdate()"
            result += ")"
            Return result
        End Get
    End Property

    Public ReadOnly Property DeleteString() As String
        Get
            Dim result As String = String.Empty
            result += "update Account set INVALID=1 , MODIFY_DATE=getDate() where ACCOUNT_ID=" & _account.AccountID & " and MENU_ID = " & _menu.MenuID
            Return result
        End Get
    End Property

End Class
