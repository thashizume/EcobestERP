Public Class MenuController

    Private _accountID As Long
    Private _menuGroup As IList(Of MenuGroupModel) = New List(Of MenuGroupModel)
    Private _menu As IList(Of MenuModel) = New List(Of MenuModel)
    Private _menuDic As Dictionary(Of Long, Long) = New Dictionary(Of Long, Long)

    Public Property AccountID As Long
        Get
            Return _accountID
        End Get
        Set(value As Long)
            _accountID = value
        End Set
    End Property

    Public ReadOnly Property MenuGroup As List(Of MenuGroupModel)
        Get
            Return _menuGroup
        End Get
    End Property

    Public ReadOnly Property Menu As List(Of MenuModel)
        Get
            Return _menu
        End Get
    End Property

    Public Sub New(accountID As Long)
        _accountID = accountID
        _menuGroup = getMenuGroup(accountID)
        _menu = getMenu(accountID)

    End Sub

    Private Function getMenu(accountID As Long) As List(Of MenuModel)

        Dim sql As String = String.Empty
        Dim result As List(Of MenuModel) = New List(Of MenuModel)
        Dim db As jp.polestar.db.SQLServer = New jp.polestar.db.SQLServer(ConnectionString, False)
        Dim reader As SqlClient.SqlDataReader

        sql += "select distinct"
        sql += "    t1.*"
        sql += " from"
        sql += "    Menu t1 left outer join MenuGroup t2 on "
        sql += "		( t1.INVALID =0 and t2.INVALID=0 and t1.MENU_GROUP_ID=t2.MENU_GROUP_ID)"
        sql += "	right outer join AccountMenuRole t3 on"
        sql += "		(t3.INVALID=0 and t1.MENU_ID = t3.MENU_ID)"
        sql += "	inner join Account t4 on"
        sql += "		(t4.INVALID=0 and t4.ACCOUNT_ID=t3.ACCOUNT_ID)"
        sql += "        where 1 = 1"
        sql += " and t4.ACCOUNT_ID=" & Me.AccountID & ""
        sql += " order by t1.MENU_ID"

        reader = db.ExecuteQuery(sql)

        While (reader.Read())
            Dim m As MenuModel = New MenuModel
            m.MenuID = reader.Item(0)
            m.Invalid = reader.Item(1)
            m.MenuGroupID = reader.Item(2)
            m.Title = reader.Item(3)
            m.ImageNmae = reader.Item(4)
            m.TipText = reader.Item(5)
            m.CreateDate = reader.Item(6)
            m.ModifyDate = reader.Item(7)

            result.Add(m)

        End While

        Return result
    End Function

    Private Function getMenuGroup(accountID As Long) As List(Of MenuGroupModel)

        Dim sql As String = String.Empty
        Dim result As List(Of MenuGroupModel) = New List(Of MenuGroupModel)
        Dim db As jp.polestar.db.SQLServer = New jp.polestar.db.SQLServer(ConnectionString, False)
        Dim reader As SqlClient.SqlDataReader

        sql += "select distinct"
        sql += "    t2.*"
        sql += " from"
        sql += "    Menu t1 left outer join MenuGroup t2 on "
        sql += "		( t1.INVALID =0 and t2.INVALID=0 and t1.MENU_GROUP_ID=t2.MENU_GROUP_ID)"
        sql += "	right outer join AccountMenuRole t3 on"
        sql += "		(t3.INVALID=0 and t1.MENU_ID = t3.MENU_ID)"
        sql += "	inner join Account t4 on"
        sql += "		(t4.INVALID=0 and t4.ACCOUNT_ID=t3.ACCOUNT_ID)"
        sql += "        where 1 = 1"
        sql += " and t4.ACCOUNT_ID=" & Me.AccountID & ""
        sql += " order by t2.MENU_GROUP_ID"

        reader = db.ExecuteQuery(sql)

        While (reader.Read())
            Dim m As MenuGroupModel = New MenuGroupModel
            m.MenuGroupID = reader.Item(0)
            m.Invalid = reader.Item(1)
            m.Title = reader.Item(2)
            m.CreateDate = reader.Item(3)
            m.ModifyDate = reader.Item(4)

            result.Add(m)

        End While

        Return result
    End Function


End Class
