<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUserControle
    Inherits System.Windows.Forms.UserControl

    'UserControl はコンポーネント一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUserControle))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("施工現場", System.Windows.Forms.HorizontalAlignment.Right)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("施工管理", System.Windows.Forms.HorizontalAlignment.Right)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("施工書類", System.Windows.Forms.HorizontalAlignment.Right)
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("業者登録", System.Windows.Forms.HorizontalAlignment.Right)
        Dim ListViewGroup5 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("エコ・ベスト管理業務", System.Windows.Forms.HorizontalAlignment.Right)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("作業日報の入力", "table-add-icon.png")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("経費の入力", "Cash-register-icon_1.png")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("施工現場写真", "Pictures-Nikon-icon.png")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("施工現場", "Map-icon.png")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("施工図面", "Drawing-icon.png")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("元請会社", "company-building-icon.png")
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("下請会社", "office-building-icon.png")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("産業廃棄物会社", "longhaul-icon.png")
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("マニュフェスト票", "document-construction-icon.png")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("委託契約書", "Contract-icon.png")
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("フローチャート", "flow-chart-icon.png")
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("施工スケジュール", "project-plan-icon.png")
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("現場原価の確認", "SEO-icon.png")
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("作業日報の確認", "tables-icon.png")
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("経費の確認", "cash-register-icon.png")
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Actions-dialog-cancel-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "Actions-dialog-close-icon.png")
        Me.ImageList1.Images.SetKeyName(2, "Actions-dialog-ok-apply-icon.png")
        Me.ImageList1.Images.SetKeyName(3, "Actions-go-jump-today-icon.png")
        Me.ImageList1.Images.SetKeyName(4, "Actions-mail-mark-task-icon.png")
        Me.ImageList1.Images.SetKeyName(5, "Actions-view-calendar-icon.png")
        Me.ImageList1.Images.SetKeyName(6, "Actions-view-calendar-tasks-icon.png")
        Me.ImageList1.Images.SetKeyName(7, "Actions-view-calendar-upcoming-events-icon.png")
        Me.ImageList1.Images.SetKeyName(8, "Admin-icon.png")
        Me.ImageList1.Images.SetKeyName(9, "Adobe-PDF-Document-icon.png")
        Me.ImageList1.Images.SetKeyName(10, "Apps-preferences-system-bluetooth-icon.png")
        Me.ImageList1.Images.SetKeyName(11, "Apps-preferences-system-time-icon.png")
        Me.ImageList1.Images.SetKeyName(12, "arrow-down-icon.png")
        Me.ImageList1.Images.SetKeyName(13, "arrow-right-icon.png")
        Me.ImageList1.Images.SetKeyName(14, "Avengers-War-Machine-icon.png")
        Me.ImageList1.Images.SetKeyName(15, "Cart-icon.png")
        Me.ImageList1.Images.SetKeyName(16, "cash-register-icon.png")
        Me.ImageList1.Images.SetKeyName(17, "City-Gas-Station-icon.png")
        Me.ImageList1.Images.SetKeyName(18, "Comics-War-Machine-icon.png")
        Me.ImageList1.Images.SetKeyName(19, "company-building-icon.png")
        Me.ImageList1.Images.SetKeyName(20, "Company-icon.png")
        Me.ImageList1.Images.SetKeyName(21, "Contract-icon.png")
        Me.ImageList1.Images.SetKeyName(22, "Custom-reports-icon.png")
        Me.ImageList1.Images.SetKeyName(23, "Distributor-report-icon.png")
        Me.ImageList1.Images.SetKeyName(24, "document-construction-icon.png")
        Me.ImageList1.Images.SetKeyName(25, "document-excel-icon.png")
        Me.ImageList1.Images.SetKeyName(26, "Document-Gant-Chart-icon.png")
        Me.ImageList1.Images.SetKeyName(27, "Document-Microsoft-Excel-icon.png")
        Me.ImageList1.Images.SetKeyName(28, "Document-Microsoft-PowerPoint-icon.png")
        Me.ImageList1.Images.SetKeyName(29, "Document-Microsoft-Word-icon.png")
        Me.ImageList1.Images.SetKeyName(30, "Document-save-icon.png")
        Me.ImageList1.Images.SetKeyName(31, "document-word-icon.png")
        Me.ImageList1.Images.SetKeyName(32, "Drawing-icon.png")
        Me.ImageList1.Images.SetKeyName(33, "file-cabinet-icon.png")
        Me.ImageList1.Images.SetKeyName(34, "flow-chart-icon.png")
        Me.ImageList1.Images.SetKeyName(35, "folder-tools-icon.png")
        Me.ImageList1.Images.SetKeyName(36, "gas-icon.png")
        Me.ImageList1.Images.SetKeyName(37, "gas-icon_1.png")
        Me.ImageList1.Images.SetKeyName(38, "Gas-pump-icon.png")
        Me.ImageList1.Images.SetKeyName(39, "Household-Garage-icon.png")
        Me.ImageList1.Images.SetKeyName(40, "longhaul-icon.png")
        Me.ImageList1.Images.SetKeyName(41, "Map-icon.png")
        Me.ImageList1.Images.SetKeyName(42, "Microsoft-Sync-icon.png")
        Me.ImageList1.Images.SetKeyName(43, "Mimetypes-text-x-rpm-spec-icon.png")
        Me.ImageList1.Images.SetKeyName(44, "Notepad-Bloc-notes-icon.png")
        Me.ImageList1.Images.SetKeyName(45, "Notepad-icon.png")
        Me.ImageList1.Images.SetKeyName(46, "office-building-icon.png")
        Me.ImageList1.Images.SetKeyName(47, "Places-trash-full-icon.png")
        Me.ImageList1.Images.SetKeyName(48, "Presentation-icon.png")
        Me.ImageList1.Images.SetKeyName(49, "project-plan-icon.png")
        Me.ImageList1.Images.SetKeyName(50, "scavenger-icon.png")
        Me.ImageList1.Images.SetKeyName(51, "SEO-icon.png")
        Me.ImageList1.Images.SetKeyName(52, "table-add-icon.png")
        Me.ImageList1.Images.SetKeyName(53, "tables-icon.png")
        Me.ImageList1.Images.SetKeyName(54, "train-icon.png")
        Me.ImageList1.Images.SetKeyName(55, "Transport-Gas-Pump-icon.png")
        Me.ImageList1.Images.SetKeyName(56, "Trash-full-icon.png")
        Me.ImageList1.Images.SetKeyName(57, "User-Group-icon.png")
        Me.ImageList1.Images.SetKeyName(58, "Users-Workers-icon.png")
        Me.ImageList1.Images.SetKeyName(59, "Actions-dialog-cancel-icon.png")
        Me.ImageList1.Images.SetKeyName(60, "Actions-dialog-close-icon.png")
        Me.ImageList1.Images.SetKeyName(61, "Actions-dialog-ok-apply-icon.png")
        Me.ImageList1.Images.SetKeyName(62, "Actions-go-jump-today-icon.png")
        Me.ImageList1.Images.SetKeyName(63, "Actions-mail-mark-task-icon.png")
        Me.ImageList1.Images.SetKeyName(64, "Actions-view-calendar-icon.png")
        Me.ImageList1.Images.SetKeyName(65, "Actions-view-calendar-tasks-icon.png")
        Me.ImageList1.Images.SetKeyName(66, "Actions-view-calendar-upcoming-events-icon.png")
        Me.ImageList1.Images.SetKeyName(67, "Admin-icon.png")
        Me.ImageList1.Images.SetKeyName(68, "Adobe-PDF-Document-icon.png")
        Me.ImageList1.Images.SetKeyName(69, "Apps-preferences-system-bluetooth-icon.png")
        Me.ImageList1.Images.SetKeyName(70, "Apps-preferences-system-time-icon.png")
        Me.ImageList1.Images.SetKeyName(71, "arrow-down-icon.png")
        Me.ImageList1.Images.SetKeyName(72, "arrow-right-icon.png")
        Me.ImageList1.Images.SetKeyName(73, "Avengers-War-Machine-icon.png")
        Me.ImageList1.Images.SetKeyName(74, "Cart-icon.png")
        Me.ImageList1.Images.SetKeyName(75, "cash-register-icon.png")
        Me.ImageList1.Images.SetKeyName(76, "Cash-register-icon_1.png")
        Me.ImageList1.Images.SetKeyName(77, "City-Gas-Station-icon.png")
        Me.ImageList1.Images.SetKeyName(78, "Comics-War-Machine-icon.png")
        Me.ImageList1.Images.SetKeyName(79, "company-building-icon.png")
        Me.ImageList1.Images.SetKeyName(80, "Company-icon.png")
        Me.ImageList1.Images.SetKeyName(81, "Contract-icon.png")
        Me.ImageList1.Images.SetKeyName(82, "Custom-reports-icon.png")
        Me.ImageList1.Images.SetKeyName(83, "Distributor-report-icon.png")
        Me.ImageList1.Images.SetKeyName(84, "document-construction-icon.png")
        Me.ImageList1.Images.SetKeyName(85, "document-excel-icon.png")
        Me.ImageList1.Images.SetKeyName(86, "Document-Gant-Chart-icon.png")
        Me.ImageList1.Images.SetKeyName(87, "Document-Microsoft-Excel-icon.png")
        Me.ImageList1.Images.SetKeyName(88, "Document-Microsoft-PowerPoint-icon.png")
        Me.ImageList1.Images.SetKeyName(89, "Document-Microsoft-Word-icon.png")
        Me.ImageList1.Images.SetKeyName(90, "Document-save-icon.png")
        Me.ImageList1.Images.SetKeyName(91, "document-word-icon.png")
        Me.ImageList1.Images.SetKeyName(92, "Drawing-icon.png")
        Me.ImageList1.Images.SetKeyName(93, "file-cabinet-icon.png")
        Me.ImageList1.Images.SetKeyName(94, "flow-chart-icon.png")
        Me.ImageList1.Images.SetKeyName(95, "folder-tools-icon.png")
        Me.ImageList1.Images.SetKeyName(96, "gas-icon.png")
        Me.ImageList1.Images.SetKeyName(97, "gas-icon_1.png")
        Me.ImageList1.Images.SetKeyName(98, "Gas-pump-icon.png")
        Me.ImageList1.Images.SetKeyName(99, "Household-Garage-icon.png")
        Me.ImageList1.Images.SetKeyName(100, "longhaul-icon.png")
        Me.ImageList1.Images.SetKeyName(101, "Map-icon.png")
        Me.ImageList1.Images.SetKeyName(102, "Microsoft-Sync-icon.png")
        Me.ImageList1.Images.SetKeyName(103, "Mimetypes-text-x-rpm-spec-icon.png")
        Me.ImageList1.Images.SetKeyName(104, "Notepad-Bloc-notes-icon.png")
        Me.ImageList1.Images.SetKeyName(105, "Notepad-icon.png")
        Me.ImageList1.Images.SetKeyName(106, "office-building-icon.png")
        Me.ImageList1.Images.SetKeyName(107, "Pictures-Nikon-icon.png")
        Me.ImageList1.Images.SetKeyName(108, "Places-trash-full-icon.png")
        Me.ImageList1.Images.SetKeyName(109, "Presentation-icon.png")
        Me.ImageList1.Images.SetKeyName(110, "project-plan-icon.png")
        Me.ImageList1.Images.SetKeyName(111, "scavenger-icon.png")
        Me.ImageList1.Images.SetKeyName(112, "SEO-icon.png")
        Me.ImageList1.Images.SetKeyName(113, "table-add-icon.png")
        Me.ImageList1.Images.SetKeyName(114, "tables-icon.png")
        Me.ImageList1.Images.SetKeyName(115, "train-icon.png")
        Me.ImageList1.Images.SetKeyName(116, "Transport-Gas-Pump-icon.png")
        Me.ImageList1.Images.SetKeyName(117, "Trash-full-icon.png")
        Me.ImageList1.Images.SetKeyName(118, "User-Group-icon.png")
        Me.ImageList1.Images.SetKeyName(119, "Users-Workers-icon.png")
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = "施工現場"
        ListViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Right
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "施工管理"
        ListViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Right
        ListViewGroup2.Name = "ListViewGroup4"
        ListViewGroup3.Header = "施工書類"
        ListViewGroup3.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Right
        ListViewGroup3.Name = "ListViewGroup2"
        ListViewGroup4.Header = "業者登録"
        ListViewGroup4.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Right
        ListViewGroup4.Name = "ListViewGroup3"
        ListViewGroup5.Header = "エコ・ベスト管理業務"
        ListViewGroup5.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Right
        ListViewGroup5.Name = "ListViewGroup5"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3, ListViewGroup4, ListViewGroup5})
        ListViewItem1.Group = ListViewGroup1
        ListViewItem2.Group = ListViewGroup1
        ListViewItem3.Group = ListViewGroup1
        ListViewItem4.Group = ListViewGroup3
        ListViewItem5.Group = ListViewGroup3
        ListViewItem6.Group = ListViewGroup4
        ListViewItem7.Group = ListViewGroup4
        ListViewItem8.Group = ListViewGroup4
        ListViewItem9.Group = ListViewGroup3
        ListViewItem10.Group = ListViewGroup3
        ListViewItem11.Group = ListViewGroup3
        ListViewItem12.Group = ListViewGroup3
        ListViewItem13.Group = ListViewGroup2
        ListViewItem14.Group = ListViewGroup2
        ListViewItem15.Group = ListViewGroup2
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15})
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(640, 480)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'MenuUserControle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Meiryo UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MenuUserControle"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ListView1 As System.Windows.Forms.ListView

End Class
