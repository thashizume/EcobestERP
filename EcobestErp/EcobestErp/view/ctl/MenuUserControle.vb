Public Class MenuUserControle
    Private _account As AccountModel = Nothing
    Public Property Account As AccountModel
        Get
            Return _account
        End Get
        Set(value As AccountModel)
            _account = value
        End Set
    End Property

    Private Sub removeMenuByDatabase()

        Dim mc As jp.polestar.ecobest.erp.MenuController = New jp.polestar.ecobest.erp.MenuController(_account.AccountID)

        For Each lvi As System.Windows.Forms.ListViewItem In ListView1.Items
            Dim match As Boolean = False
            For Each row As MenuModel In mc.Menu
                If lvi.Text = row.Title Then
                    match = True
                    Exit For
                End If
            Next

            If match Then ListView1.Items.RemoveByKey(lvi.Text)

        Next

    End Sub

    Private Sub setMenuByDatabase()

        Dim mc As jp.polestar.ecobest.erp.MenuController = New jp.polestar.ecobest.erp.MenuController(_account.AccountID)
        For Each row1 As MenuGroupModel In mc.MenuGroup
            Dim g As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup(CStr(row1.MenuGroupID), row1.Title)

            ListView1.Groups.Add(g)
            For Each row2 As MenuModel In mc.Menu
                If row1.MenuGroupID = row2.MenuGroupID Then
                    Dim v As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem
                    v.Group = g
                    v.ImageKey = row2.ImageNmae
                    v.Text = row2.Title
                    v.ToolTipText = row2.TipText

                    ListView1.Items.Add(v)
                End If

            Next

        Next
        ListView1.LargeImageList = ImageList1
        ListView1.SmallImageList = ImageList1

    End Sub

    Public Sub New(a As AccountModel)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        _account = a
        If _account Is Nothing Then Exit Sub

        setMenuByDatabase()

    End Sub

    Private Sub DockFill(nameOfControl As String)
        For i As Integer = 0 To Me.Parent.Parent.Controls.Item(0).Controls.Count - 1
            If Me.Parent.Parent.Controls.Item(0).Controls.Item(i).Name = nameOfControl Then
                Me.Parent.Parent.Controls.Item(0).Controls.Item(i).Dock = DockStyle.Fill
                Exit For
            End If
        Next
    End Sub

    Private Sub Unload()
        For i As Integer = 0 To Me.Parent.Parent.Controls.Item(0).Controls.Count - 1
            Debug.Print(Me.Parent.Parent.Controls.Item(0).Controls.Item(i).GetType.Name)
            If Me.Parent.Parent.Controls.Item(0).Controls.Item(i).GetType.Name = Me.GetType.Name Then
                Me.Parent.Parent.Controls.Item(0).Controls.RemoveByKey(Me.Parent.Parent.Controls.Item(0).Controls.Item(i).Name)
                Exit For
            End If

        Next
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Dim menuString As String = ListView1.SelectedItems(0).Text
        Dim ucInputTimeSheet As ucInputDailyReportTimesheet
        Dim ucInputExpence As ucInputExpence

        Select Case menuString

            Case "作業日報の入力"
                ucInputTimeSheet = New ucInputDailyReportTimesheet
                Me.Parent.Parent.Controls.Item(0).Controls.Add(ucInputTimeSheet)
                DockFill(ucInputTimeSheet.Name)
                Unload()

            Case "経費の入力"
                ucInputExpence = New ucInputExpence
                Me.Parent.Parent.Controls.Item(0).Controls.Add(ucInputExpence)
                DockFill(ucInputExpence.Name)
                Unload()


            Case "現場原価の確認"



            Case Else

        End Select
    End Sub


End Class
