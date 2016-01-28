<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMenu))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("従業員用", System.Windows.Forms.HorizontalAlignment.Right)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("事務要員用", System.Windows.Forms.HorizontalAlignment.Right)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("管理者用", System.Windows.Forms.HorizontalAlignment.Right)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("作業日報の入力", 7)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("経費の入力", "cash-register-icon.png")
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Admin-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "Comics-War-Machine-icon.png")
        Me.ImageList1.Images.SetKeyName(2, "Custom-reports-icon.png")
        Me.ImageList1.Images.SetKeyName(3, "Distributor-report-icon.png")
        Me.ImageList1.Images.SetKeyName(4, "Microsoft-Sync-icon.png")
        Me.ImageList1.Images.SetKeyName(5, "office-building-icon.png")
        Me.ImageList1.Images.SetKeyName(6, "Presentation-icon.png")
        Me.ImageList1.Images.SetKeyName(7, "table-add-icon.png")
        Me.ImageList1.Images.SetKeyName(8, "tables-icon.png")
        Me.ImageList1.Images.SetKeyName(9, "User-Group-icon.png")
        Me.ImageList1.Images.SetKeyName(10, "cash-register-icon.png")
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = "従業員用"
        ListViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Right
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "事務要員用"
        ListViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Right
        ListViewGroup2.Name = "ListViewGroup2"
        ListViewGroup3.Header = "管理者用"
        ListViewGroup3.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Right
        ListViewGroup3.Name = "ListViewGroup3"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        ListViewItem1.Group = ListViewGroup1
        ListViewItem2.Group = ListViewGroup1
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(640, 480)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ucMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Meiryo UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucMenu"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ListView1 As System.Windows.Forms.ListView

End Class
