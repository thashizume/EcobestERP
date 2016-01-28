Public Class InitData
    Dim db As jp.polestar.db.SQLServer

    Public Sub GenerateInitData()
        Call genarateMenuGroup()
        Call genarateMenu()
        Call generateAccount()
        Call generateAccountMenuRole()



    End Sub

    Public Sub New()

    End Sub


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub generateAccountMenuRole()

        db = New jp.polestar.db.SQLServer(ConnectionString, True)
        Dim o As jp.polestar.ecobest.erp.AccountMenuRoleModel
        db.ExecuteQueryNoResult("delete from AccountMenuRole")

        o = New jp.polestar.ecobest.erp.AccountMenuRoleModel
        o.AccountID = (New jp.polestar.ecobest.erp.AccountModel).getAccountIDByAccount("asano", db)
        o.MenuID = (New jp.polestar.ecobest.erp.MenuModel).getMenuIDByName("現場原価の確認", db)
        db.ExecuteQueryNoResult(o.InsertString)

        o = New jp.polestar.ecobest.erp.AccountMenuRoleModel
        o.AccountID = (New jp.polestar.ecobest.erp.AccountModel).getAccountIDByAccount("asano", db)
        o.MenuID = (New jp.polestar.ecobest.erp.MenuModel).getMenuIDByName("施工現場情報の入力", db)
        db.ExecuteQueryNoResult(o.InsertString)



        o = New jp.polestar.ecobest.erp.AccountMenuRoleModel
        o.AccountID = (New jp.polestar.ecobest.erp.AccountModel).getAccountIDByAccount("sawaki", db)
        o.MenuID = (New jp.polestar.ecobest.erp.MenuModel).getMenuIDByName("作業日報の入力", db)
        db.ExecuteQueryNoResult(o.InsertString)

        o = New jp.polestar.ecobest.erp.AccountMenuRoleModel
        o.AccountID = (New jp.polestar.ecobest.erp.AccountModel).getAccountIDByAccount("sawaki", db)
        o.MenuID = (New jp.polestar.ecobest.erp.MenuModel).getMenuIDByName("経費の入力", db)
        db.ExecuteQueryNoResult(o.InsertString)




        o = New jp.polestar.ecobest.erp.AccountMenuRoleModel
        o.AccountID = (New jp.polestar.ecobest.erp.AccountModel).getAccountIDByAccount("hayasaka", db)
        o.MenuID = (New jp.polestar.ecobest.erp.MenuModel).getMenuIDByName("現場原価の確認", db)
        db.ExecuteQueryNoResult(o.InsertString)

        db.Commit()
        db.Close()

    End Sub

    Private Sub generateAccount()

        db = New jp.polestar.db.SQLServer(ConnectionString, True)

        Dim a As jp.polestar.ecobest.erp.AccountModel

        db.ExecuteQueryNoResult("delete from Account")

        a = New jp.polestar.ecobest.erp.AccountModel
        a.Account = "asano"
        a.AccountPass = "asano999"
        db.ExecuteQueryNoResult(a.InsertString)

        a = New jp.polestar.ecobest.erp.AccountModel
        a.Account = "sawaki"
        a.AccountPass = "sawaki999"
        db.ExecuteQueryNoResult(a.InsertString)

        a = New jp.polestar.ecobest.erp.AccountModel
        a.Account = "hayasaka"
        a.AccountPass = "hayasaka999"
        db.ExecuteQueryNoResult(a.InsertString)

        db.Commit()
        db.Close()

    End Sub

    Private Sub genarateMenuGroup()

        db = New jp.polestar.db.SQLServer(ConnectionString, True)

        Dim mg As jp.polestar.ecobest.erp.MenuGroupModel

        db.ExecuteQueryNoResult("delete from MenuGroup")

        mg = New MenuGroupModel
        mg.Title = "施工現場"
        db.ExecuteQueryNoResult(mg.InsertString)

        mg = New MenuGroupModel
        mg.Title = "施工管理"
        db.ExecuteQueryNoResult(mg.InsertString)

        mg = New MenuGroupModel
        mg.Title = "施工書類"
        db.ExecuteQueryNoResult(mg.InsertString)

        mg = New MenuGroupModel
        mg.Title = "業者登録"
        db.ExecuteQueryNoResult(mg.InsertString)

        mg = New MenuGroupModel
        mg.Title = "エコ・ベスト管理業務"
        db.ExecuteQueryNoResult(mg.InsertString)

        db.Commit()
        db.Close()

    End Sub

    Private Sub genarateMenu()

        db = New jp.polestar.db.SQLServer(ConnectionString, True)

        Dim m As jp.polestar.ecobest.erp.MenuModel

        db.ExecuteQueryNoResult("delete from Menu")

        '   Menu
        m = New jp.polestar.ecobest.erp.MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("施工現場", db)
        m.Title = "作業日報の入力"
        m.TipText = "xxx"
        m.ImageNmae = "table-add-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("施工現場", db)
        m.Title = "経費の入力"
        m.TipText = "xxx"
        m.ImageNmae = "cash-register-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("施工管理", db)
        m.Title = "作業日報の確認"
        m.TipText = "xxx"
        m.ImageNmae = "tables-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("施工管理", db)
        m.Title = "経費の確認"
        m.TipText = "xxx"
        m.ImageNmae = "n/a"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("施工管理", db)
        m.Title = "現場原価の確認"
        m.TipText = "xxx"
        m.ImageNmae = "SEO-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("施工書類", db)
        m.Title = "施工現場情報の入力"
        m.TipText = "xxx"
        m.ImageNmae = "Map-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("施工書類", db)
        m.Title = "施工図面"
        m.TipText = "xxx"
        m.ImageNmae = "Map-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("施工書類", db)
        m.Title = "安全書類"
        m.TipText = "xxx"
        m.ImageNmae = "Map-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("施工書類", db)
        m.Title = "届出書（リサイクル届け）"
        m.TipText = "xxx"
        m.ImageNmae = "Map-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("施工書類", db)
        m.Title = "特定建設作業実施届出書"
        m.TipText = "xxx"
        m.ImageNmae = "Map-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("施工書類", db)
        m.Title = "説明会等報告書"
        m.TipText = "xxx"
        m.ImageNmae = "Map-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("施工書類", db)
        m.Title = "標識接地報告書"
        m.TipText = "xxx"
        m.ImageNmae = "Map-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("施工書類", db)
        m.Title = "産業廃棄物委託契約書"
        m.TipText = "xxx"
        m.ImageNmae = "Map-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("施工書類", db)
        m.Title = "産業廃棄物処理フローチャート"
        m.TipText = "xxx"
        m.ImageNmae = "Map-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("施工書類", db)
        m.Title = "産業廃棄物マニフェスト"
        m.TipText = "xxx"
        m.ImageNmae = "Map-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("業者登録", db)
        m.Title = "元請業者"
        m.TipText = "xxx"
        m.ImageNmae = "Map-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("業者登録", db)
        m.Title = "下請け業者"
        m.TipText = "xxx"
        m.ImageNmae = "Map-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("業者登録", db)
        m.Title = "産業廃棄物運搬業者"
        m.TipText = "xxx"
        m.ImageNmae = "Map-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("業者登録", db)
        m.Title = "産業廃棄物処分業者"
        m.TipText = "xxx"
        m.ImageNmae = "Map-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        m = New MenuModel
        m.MenuGroupID = m.getMenuGroupIDByName("エコ・ベスト管理業務", db)
        m.Title = "利用者管理"
        m.TipText = "xxx"
        m.ImageNmae = "Map-icon"
        db.ExecuteQueryNoResult(m.InsertString)

        db.Commit()
        db.Close()

    End Sub

End Class
