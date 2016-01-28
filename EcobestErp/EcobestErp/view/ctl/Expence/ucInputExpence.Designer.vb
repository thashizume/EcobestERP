<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucInputExpence
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucInputExpence))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("現場１")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("現場２")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("現場名", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.addExpence1 = New System.Windows.Forms.Button()
        Me.Image32 = New System.Windows.Forms.ImageList(Me.components)
        Me.expenceTrain = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Image64 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Meiryo UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 64)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "経費の入力"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPrevious
        '
        Me.btnPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrevious.AutoSize = True
        Me.btnPrevious.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
        Me.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrevious.Location = New System.Drawing.Point(702, 15)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(79, 40)
        Me.btnPrevious.TabIndex = 21
        Me.btnPrevious.Text = "戻る"
        Me.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(352, 8)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(148, 27)
        Me.DateTimePicker1.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.ImageKey = "Actions-go-jump-today-icon.png"
        Me.Label6.ImageList = Me.ImageList1
        Me.Label6.Location = New System.Drawing.Point(256, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 27)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "日付"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.ImageList1.Images.SetKeyName(8, "Adobe-PDF-Document-icon.png")
        Me.ImageList1.Images.SetKeyName(9, "Apps-preferences-system-bluetooth-icon.png")
        Me.ImageList1.Images.SetKeyName(10, "Apps-preferences-system-time-icon.png")
        Me.ImageList1.Images.SetKeyName(11, "arrow-down-icon.png")
        Me.ImageList1.Images.SetKeyName(12, "arrow-right-icon.png")
        Me.ImageList1.Images.SetKeyName(13, "Avengers-War-Machine-icon.png")
        Me.ImageList1.Images.SetKeyName(14, "Cart-icon.png")
        Me.ImageList1.Images.SetKeyName(15, "Cash-register-icon_1.png")
        Me.ImageList1.Images.SetKeyName(16, "City-Gas-Station-icon.png")
        Me.ImageList1.Images.SetKeyName(17, "company-building-icon.png")
        Me.ImageList1.Images.SetKeyName(18, "Company-icon.png")
        Me.ImageList1.Images.SetKeyName(19, "Contract-icon.png")
        Me.ImageList1.Images.SetKeyName(20, "currency-yen-icon.png")
        Me.ImageList1.Images.SetKeyName(21, "document-construction-icon.png")
        Me.ImageList1.Images.SetKeyName(22, "document-excel-icon.png")
        Me.ImageList1.Images.SetKeyName(23, "Document-Gant-Chart-icon.png")
        Me.ImageList1.Images.SetKeyName(24, "Document-Microsoft-Excel-icon.png")
        Me.ImageList1.Images.SetKeyName(25, "Document-Microsoft-PowerPoint-icon.png")
        Me.ImageList1.Images.SetKeyName(26, "Document-Microsoft-Word-icon.png")
        Me.ImageList1.Images.SetKeyName(27, "Document-save-icon.png")
        Me.ImageList1.Images.SetKeyName(28, "document-word-icon.png")
        Me.ImageList1.Images.SetKeyName(29, "Drawing-icon.png")
        Me.ImageList1.Images.SetKeyName(30, "file-cabinet-icon.png")
        Me.ImageList1.Images.SetKeyName(31, "flow-chart-icon.png")
        Me.ImageList1.Images.SetKeyName(32, "folder-tools-icon.png")
        Me.ImageList1.Images.SetKeyName(33, "gas-icon.png")
        Me.ImageList1.Images.SetKeyName(34, "gas-icon_1.png")
        Me.ImageList1.Images.SetKeyName(35, "Gas-pump-icon.png")
        Me.ImageList1.Images.SetKeyName(36, "Household-Garage-icon.png")
        Me.ImageList1.Images.SetKeyName(37, "longhaul-icon.png")
        Me.ImageList1.Images.SetKeyName(38, "Map-icon.png")
        Me.ImageList1.Images.SetKeyName(39, "Mimetypes-text-x-rpm-spec-icon.png")
        Me.ImageList1.Images.SetKeyName(40, "Notepad-Bloc-notes-icon.png")
        Me.ImageList1.Images.SetKeyName(41, "Notepad-icon.png")
        Me.ImageList1.Images.SetKeyName(42, "Parking-Garage-icon.png")
        Me.ImageList1.Images.SetKeyName(43, "Pictures-Nikon-icon.png")
        Me.ImageList1.Images.SetKeyName(44, "Places-trash-full-icon.png")
        Me.ImageList1.Images.SetKeyName(45, "project-plan-icon.png")
        Me.ImageList1.Images.SetKeyName(46, "scavenger-icon.png")
        Me.ImageList1.Images.SetKeyName(47, "SEO-icon.png")
        Me.ImageList1.Images.SetKeyName(48, "train-icon.png")
        Me.ImageList1.Images.SetKeyName(49, "Transport-Gas-Pump-icon.png")
        Me.ImageList1.Images.SetKeyName(50, "Trash-full-icon.png")
        Me.ImageList1.Images.SetKeyName(51, "Users-Workers-icon.png")
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 70)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(781, 374)
        Me.SplitContainer1.SplitterDistance = 261
        Me.SplitContainer1.TabIndex = 27
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage11)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabControl1.ImageList = Me.Image32
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(781, 261)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.ComboBox2)
        Me.TabPage8.Controls.Add(Me.Label15)
        Me.TabPage8.Controls.Add(Me.addExpence1)
        Me.TabPage8.Controls.Add(Me.expenceTrain)
        Me.TabPage8.Controls.Add(Me.Label11)
        Me.TabPage8.Controls.Add(Me.TextBox3)
        Me.TabPage8.Controls.Add(Me.Label10)
        Me.TabPage8.Controls.Add(Me.Label9)
        Me.TabPage8.Font = New System.Drawing.Font("Meiryo UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage8.ImageKey = "train-icon.png"
        Me.TabPage8.Location = New System.Drawing.Point(4, 39)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(773, 218)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "交通費"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(124, 72)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(299, 25)
        Me.ComboBox2.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.SeaShell
        Me.Label15.Font = New System.Drawing.Font("Meiryo UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label15.Location = New System.Drawing.Point(5, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(761, 34)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "交通費の入力について。電車若しくはタクシーを利用した場合に記入ください。"
        '
        'addExpence1
        '
        Me.addExpence1.AutoSize = True
        Me.addExpence1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.addExpence1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addExpence1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.addExpence1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addExpence1.ImageKey = "arrow-down-icon.png"
        Me.addExpence1.ImageList = Me.Image32
        Me.addExpence1.Location = New System.Drawing.Point(123, 164)
        Me.addExpence1.Name = "addExpence1"
        Me.addExpence1.Size = New System.Drawing.Size(92, 40)
        Me.addExpence1.TabIndex = 31
        Me.addExpence1.Text = "入力"
        Me.addExpence1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.addExpence1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.addExpence1.UseVisualStyleBackColor = False
        '
        'Image32
        '
        Me.Image32.ImageStream = CType(resources.GetObject("Image32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Image32.TransparentColor = System.Drawing.Color.Transparent
        Me.Image32.Images.SetKeyName(0, "Actions-go-jump-today-icon.png")
        Me.Image32.Images.SetKeyName(1, "Actions-mail-mark-task-icon.png")
        Me.Image32.Images.SetKeyName(2, "Actions-view-calendar-icon.png")
        Me.Image32.Images.SetKeyName(3, "Actions-view-calendar-tasks-icon.png")
        Me.Image32.Images.SetKeyName(4, "Actions-view-calendar-upcoming-events-icon.png")
        Me.Image32.Images.SetKeyName(5, "Actions-view-pim-contacts-icon.png")
        Me.Image32.Images.SetKeyName(6, "Admin-icon.png")
        Me.Image32.Images.SetKeyName(7, "Adobe-PDF-Document-icon.png")
        Me.Image32.Images.SetKeyName(8, "Apps-preferences-system-bluetooth-icon.png")
        Me.Image32.Images.SetKeyName(9, "Apps-preferences-system-time-icon.png")
        Me.Image32.Images.SetKeyName(10, "arrow-down-icon.png")
        Me.Image32.Images.SetKeyName(11, "arrow-right-icon.png")
        Me.Image32.Images.SetKeyName(12, "Avengers-War-Machine-icon.png")
        Me.Image32.Images.SetKeyName(13, "Back-icon.png")
        Me.Image32.Images.SetKeyName(14, "Cart-icon.png")
        Me.Image32.Images.SetKeyName(15, "cash-register-icon.png")
        Me.Image32.Images.SetKeyName(16, "Cash-register-icon_1.png")
        Me.Image32.Images.SetKeyName(17, "City-Gas-Station-icon.png")
        Me.Image32.Images.SetKeyName(18, "Comics-War-Machine-icon.png")
        Me.Image32.Images.SetKeyName(19, "company-building-icon.png")
        Me.Image32.Images.SetKeyName(20, "Company-icon.png")
        Me.Image32.Images.SetKeyName(21, "Contract-icon.png")
        Me.Image32.Images.SetKeyName(22, "Custom-reports-icon.png")
        Me.Image32.Images.SetKeyName(23, "Distributor-report-icon.png")
        Me.Image32.Images.SetKeyName(24, "document-construction-icon.png")
        Me.Image32.Images.SetKeyName(25, "document-excel-icon.png")
        Me.Image32.Images.SetKeyName(26, "Document-Gant-Chart-icon.png")
        Me.Image32.Images.SetKeyName(27, "Document-Microsoft-Excel-icon.png")
        Me.Image32.Images.SetKeyName(28, "Document-Microsoft-PowerPoint-icon.png")
        Me.Image32.Images.SetKeyName(29, "Document-Microsoft-Word-icon.png")
        Me.Image32.Images.SetKeyName(30, "Document-save-icon.png")
        Me.Image32.Images.SetKeyName(31, "document-word-icon.png")
        Me.Image32.Images.SetKeyName(32, "Drawing-icon.png")
        Me.Image32.Images.SetKeyName(33, "file-cabinet-icon.png")
        Me.Image32.Images.SetKeyName(34, "flow-chart-icon.png")
        Me.Image32.Images.SetKeyName(35, "folder-tools-icon.png")
        Me.Image32.Images.SetKeyName(36, "gas-icon.png")
        Me.Image32.Images.SetKeyName(37, "gas-icon_1.png")
        Me.Image32.Images.SetKeyName(38, "Gas-pump-icon.png")
        Me.Image32.Images.SetKeyName(39, "Household-Garage-icon.png")
        Me.Image32.Images.SetKeyName(40, "longhaul-icon.png")
        Me.Image32.Images.SetKeyName(41, "Map-icon.png")
        Me.Image32.Images.SetKeyName(42, "Actions-dialog-cancel-icon.png")
        Me.Image32.Images.SetKeyName(43, "Actions-dialog-close-icon.png")
        Me.Image32.Images.SetKeyName(44, "Actions-dialog-ok-apply-icon.png")
        Me.Image32.Images.SetKeyName(45, "Actions-go-jump-today-icon.png")
        Me.Image32.Images.SetKeyName(46, "Actions-mail-mark-task-icon.png")
        Me.Image32.Images.SetKeyName(47, "Actions-view-calendar-icon.png")
        Me.Image32.Images.SetKeyName(48, "Actions-view-calendar-tasks-icon.png")
        Me.Image32.Images.SetKeyName(49, "Actions-view-calendar-upcoming-events-icon.png")
        Me.Image32.Images.SetKeyName(50, "Actions-view-pim-contacts-icon.png")
        Me.Image32.Images.SetKeyName(51, "Admin-icon.png")
        Me.Image32.Images.SetKeyName(52, "Adobe-PDF-Document-icon.png")
        Me.Image32.Images.SetKeyName(53, "Apps-preferences-system-bluetooth-icon.png")
        Me.Image32.Images.SetKeyName(54, "Apps-preferences-system-time-icon.png")
        Me.Image32.Images.SetKeyName(55, "arrow-down-icon.png")
        Me.Image32.Images.SetKeyName(56, "arrow-right-icon.png")
        Me.Image32.Images.SetKeyName(57, "Avengers-War-Machine-icon.png")
        Me.Image32.Images.SetKeyName(58, "Back-icon.png")
        Me.Image32.Images.SetKeyName(59, "Cart-icon.png")
        Me.Image32.Images.SetKeyName(60, "cash-register-icon.png")
        Me.Image32.Images.SetKeyName(61, "Cash-register-icon_1.png")
        Me.Image32.Images.SetKeyName(62, "City-Gas-Station-icon.png")
        Me.Image32.Images.SetKeyName(63, "Comics-War-Machine-icon.png")
        Me.Image32.Images.SetKeyName(64, "company-building-icon.png")
        Me.Image32.Images.SetKeyName(65, "Company-icon.png")
        Me.Image32.Images.SetKeyName(66, "Contract-icon.png")
        Me.Image32.Images.SetKeyName(67, "Custom-reports-icon.png")
        Me.Image32.Images.SetKeyName(68, "Distributor-report-icon.png")
        Me.Image32.Images.SetKeyName(69, "document-construction-icon.png")
        Me.Image32.Images.SetKeyName(70, "document-excel-icon.png")
        Me.Image32.Images.SetKeyName(71, "Document-Gant-Chart-icon.png")
        Me.Image32.Images.SetKeyName(72, "Document-Microsoft-Excel-icon.png")
        Me.Image32.Images.SetKeyName(73, "Document-Microsoft-PowerPoint-icon.png")
        Me.Image32.Images.SetKeyName(74, "Document-Microsoft-Word-icon.png")
        Me.Image32.Images.SetKeyName(75, "Document-save-icon.png")
        Me.Image32.Images.SetKeyName(76, "document-word-icon.png")
        Me.Image32.Images.SetKeyName(77, "Drawing-icon.png")
        Me.Image32.Images.SetKeyName(78, "file-cabinet-icon.png")
        Me.Image32.Images.SetKeyName(79, "flow-chart-icon.png")
        Me.Image32.Images.SetKeyName(80, "folder-tools-icon.png")
        Me.Image32.Images.SetKeyName(81, "gas-icon.png")
        Me.Image32.Images.SetKeyName(82, "gas-icon_1.png")
        Me.Image32.Images.SetKeyName(83, "Gas-pump-icon.png")
        Me.Image32.Images.SetKeyName(84, "Household-Garage-icon.png")
        Me.Image32.Images.SetKeyName(85, "longhaul-icon.png")
        Me.Image32.Images.SetKeyName(86, "Map-icon.png")
        Me.Image32.Images.SetKeyName(87, "Mimetypes-text-x-rpm-spec-icon.png")
        Me.Image32.Images.SetKeyName(88, "Next-icon.png")
        Me.Image32.Images.SetKeyName(89, "Notepad-Bloc-notes-icon.png")
        Me.Image32.Images.SetKeyName(90, "Notepad-icon.png")
        Me.Image32.Images.SetKeyName(91, "office-building-icon.png")
        Me.Image32.Images.SetKeyName(92, "Parking-Garage-icon.png")
        Me.Image32.Images.SetKeyName(93, "Pictures-Nikon-icon.png")
        Me.Image32.Images.SetKeyName(94, "Places-trash-full-icon.png")
        Me.Image32.Images.SetKeyName(95, "Presentation-icon.png")
        Me.Image32.Images.SetKeyName(96, "Previous-icon.png")
        Me.Image32.Images.SetKeyName(97, "project-plan-icon.png")
        Me.Image32.Images.SetKeyName(98, "scavenger-icon.png")
        Me.Image32.Images.SetKeyName(99, "SEO-icon.png")
        Me.Image32.Images.SetKeyName(100, "table-add-icon.png")
        Me.Image32.Images.SetKeyName(101, "tables-icon.png")
        Me.Image32.Images.SetKeyName(102, "train-icon.png")
        Me.Image32.Images.SetKeyName(103, "Transport-Gas-Pump-icon.png")
        Me.Image32.Images.SetKeyName(104, "Trash-full-icon.png")
        Me.Image32.Images.SetKeyName(105, "User-Group-icon.png")
        Me.Image32.Images.SetKeyName(106, "Users-Workers-icon.png")
        '
        'expenceTrain
        '
        Me.expenceTrain.Location = New System.Drawing.Point(124, 42)
        Me.expenceTrain.Name = "expenceTrain"
        Me.expenceTrain.Size = New System.Drawing.Size(123, 24)
        Me.expenceTrain.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(3, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 25)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "備考："
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(123, 103)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(300, 55)
        Me.TextBox3.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(5, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 25)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "区間："
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(3, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 25)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "金額："
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.Button2)
        Me.TabPage9.Controls.Add(Me.Label18)
        Me.TabPage9.Controls.Add(Me.ComboBox3)
        Me.TabPage9.Controls.Add(Me.TextBox1)
        Me.TabPage9.Controls.Add(Me.Label17)
        Me.TabPage9.Controls.Add(Me.Label3)
        Me.TabPage9.Font = New System.Drawing.Font("Meiryo UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage9.ImageKey = "Household-Garage-icon.png"
        Me.TabPage9.Location = New System.Drawing.Point(4, 39)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(773, 218)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "駐車場"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageKey = "arrow-down-icon.png"
        Me.Button2.ImageList = Me.Image32
        Me.Button2.Location = New System.Drawing.Point(124, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 40)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "入力"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(6, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 25)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "区間："
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(124, 72)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(299, 25)
        Me.ComboBox3.TabIndex = 36
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(124, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 24)
        Me.TextBox1.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(4, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(114, 24)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "金額："
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.SeaShell
        Me.Label3.Font = New System.Drawing.Font("Meiryo UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label3.Location = New System.Drawing.Point(5, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(765, 34)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "駐車場の入力について・・・・・・・・・"
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.Label4)
        Me.TabPage10.ImageKey = "Gas-pump-icon.png"
        Me.TabPage10.Location = New System.Drawing.Point(4, 39)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(773, 218)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Text = "燃料代"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.SeaShell
        Me.Label4.Font = New System.Drawing.Font("Meiryo UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label4.Location = New System.Drawing.Point(5, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(765, 34)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "xxxxの入力は・・・・・・入力に関する注意事項を記載"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.ImageKey = "Cart-icon.png"
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(773, 218)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "買い物"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.SeaShell
        Me.Label5.Font = New System.Drawing.Font("Meiryo UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label5.Location = New System.Drawing.Point(5, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(762, 34)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "xxxxの入力は・・・・・・入力に関する注意事項を記載"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.ImageKey = "Users-Workers-icon.png"
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(773, 218)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "下請業者"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.SeaShell
        Me.Label7.Font = New System.Drawing.Font("Meiryo UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label7.Location = New System.Drawing.Point(5, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(762, 34)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "xxxxの入力は・・・・・・入力に関する注意事項を記載"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.ImageKey = "scavenger-icon.png"
        Me.TabPage3.Location = New System.Drawing.Point(4, 39)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(773, 218)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "重機・アタッチメント・リース"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.SeaShell
        Me.Label8.Font = New System.Drawing.Font("Meiryo UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label8.Location = New System.Drawing.Point(5, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(762, 34)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "xxxxの入力は・・・・・・入力に関する注意事項を記載"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.ImageKey = "gas-icon_1.png"
        Me.TabPage4.Location = New System.Drawing.Point(4, 39)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(773, 218)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "重機燃料"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.SeaShell
        Me.Label12.Font = New System.Drawing.Font("Meiryo UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label12.Location = New System.Drawing.Point(5, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(762, 34)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "xxxxの入力は・・・・・・入力に関する注意事項を記載"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label13)
        Me.TabPage5.ImageKey = "Places-trash-full-icon.png"
        Me.TabPage5.Location = New System.Drawing.Point(4, 39)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(773, 218)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "廃材処分"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.SeaShell
        Me.Label13.Font = New System.Drawing.Font("Meiryo UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label13.Location = New System.Drawing.Point(5, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(762, 34)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "xxxxの入力は・・・・・・入力に関する注意事項を記載"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label14)
        Me.TabPage6.ImageKey = "gas-icon.png"
        Me.TabPage6.Location = New System.Drawing.Point(4, 39)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(773, 218)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "ガス・酸素"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.SeaShell
        Me.Label14.Font = New System.Drawing.Font("Meiryo UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label14.Location = New System.Drawing.Point(5, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(762, 34)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "xxxxの入力は・・・・・・入力に関する注意事項を記載"
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.Label16)
        Me.TabPage7.ImageKey = "Trash-full-icon.png"
        Me.TabPage7.Location = New System.Drawing.Point(4, 39)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(773, 218)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "スクラップ・アルミ"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.SeaShell
        Me.Label16.Font = New System.Drawing.Font("Meiryo UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label16.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label16.Location = New System.Drawing.Point(5, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(762, 34)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "xxxxの入力は・・・・・・入力に関する注意事項を記載"
        '
        'TabPage11
        '
        Me.TabPage11.Location = New System.Drawing.Point(4, 39)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(773, 218)
        Me.TabPage11.TabIndex = 10
        Me.TabPage11.Text = "小口現金"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Font = New System.Drawing.Font("Meiryo UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer2.Size = New System.Drawing.Size(781, 109)
        Me.SplitContainer2.SplitterDistance = 288
        Me.SplitContainer2.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.ImageKey = "Map-icon.png"
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.ImageKey = "folder-tools-icon.png"
        TreeNode1.Name = "ノード1"
        TreeNode1.SelectedImageKey = "folder-tools-icon.png"
        TreeNode1.Text = "現場１"
        TreeNode2.ImageKey = "folder-tools-icon.png"
        TreeNode2.Name = "ノード2"
        TreeNode2.SelectedImageKey = "folder-tools-icon.png"
        TreeNode2.Text = "現場２"
        TreeNode3.ImageKey = "Map-icon.png"
        TreeNode3.Name = "ノード0"
        TreeNode3.SelectedImageKey = "Map-icon.png"
        TreeNode3.Text = "現場名"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.TreeView1.SelectedImageKey = "Map-icon.png"
        Me.TreeView1.Size = New System.Drawing.Size(288, 109)
        Me.TreeView1.StateImageList = Me.ImageList1
        Me.TreeView1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(489, 109)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "経費の種類"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "金額"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "摘要"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Image64
        '
        Me.Image64.ImageStream = CType(resources.GetObject("Image64.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Image64.TransparentColor = System.Drawing.Color.Transparent
        Me.Image64.Images.SetKeyName(0, "Actions-dialog-cancel-icon.png")
        Me.Image64.Images.SetKeyName(1, "Actions-dialog-close-icon.png")
        Me.Image64.Images.SetKeyName(2, "Actions-dialog-ok-apply-icon.png")
        Me.Image64.Images.SetKeyName(3, "Actions-go-jump-today-icon.png")
        Me.Image64.Images.SetKeyName(4, "Actions-mail-mark-task-icon.png")
        Me.Image64.Images.SetKeyName(5, "Actions-view-calendar-icon.png")
        Me.Image64.Images.SetKeyName(6, "Actions-view-calendar-tasks-icon.png")
        Me.Image64.Images.SetKeyName(7, "Actions-view-calendar-upcoming-events-icon.png")
        Me.Image64.Images.SetKeyName(8, "Admin-icon.png")
        Me.Image64.Images.SetKeyName(9, "Adobe-PDF-Document-icon.png")
        Me.Image64.Images.SetKeyName(10, "Apps-preferences-system-bluetooth-icon.png")
        Me.Image64.Images.SetKeyName(11, "Apps-preferences-system-time-icon.png")
        Me.Image64.Images.SetKeyName(12, "arrow-down-icon.png")
        Me.Image64.Images.SetKeyName(13, "arrow-right-icon.png")
        Me.Image64.Images.SetKeyName(14, "Avengers-War-Machine-icon.png")
        Me.Image64.Images.SetKeyName(15, "Cart-icon.png")
        Me.Image64.Images.SetKeyName(16, "cash-register-icon.png")
        Me.Image64.Images.SetKeyName(17, "Cash-register-icon_1.png")
        Me.Image64.Images.SetKeyName(18, "City-Gas-Station-icon.png")
        Me.Image64.Images.SetKeyName(19, "Comics-War-Machine-icon.png")
        Me.Image64.Images.SetKeyName(20, "company-building-icon.png")
        Me.Image64.Images.SetKeyName(21, "Company-icon.png")
        Me.Image64.Images.SetKeyName(22, "Contract-icon.png")
        Me.Image64.Images.SetKeyName(23, "Custom-reports-icon.png")
        Me.Image64.Images.SetKeyName(24, "Distributor-report-icon.png")
        Me.Image64.Images.SetKeyName(25, "document-construction-icon.png")
        Me.Image64.Images.SetKeyName(26, "document-excel-icon.png")
        Me.Image64.Images.SetKeyName(27, "Document-Gant-Chart-icon.png")
        Me.Image64.Images.SetKeyName(28, "Document-Microsoft-Excel-icon.png")
        Me.Image64.Images.SetKeyName(29, "Document-Microsoft-PowerPoint-icon.png")
        Me.Image64.Images.SetKeyName(30, "Document-Microsoft-Word-icon.png")
        Me.Image64.Images.SetKeyName(31, "Document-save-icon.png")
        Me.Image64.Images.SetKeyName(32, "document-word-icon.png")
        Me.Image64.Images.SetKeyName(33, "Drawing-icon.png")
        Me.Image64.Images.SetKeyName(34, "file-cabinet-icon.png")
        Me.Image64.Images.SetKeyName(35, "flow-chart-icon.png")
        Me.Image64.Images.SetKeyName(36, "folder-tools-icon.png")
        Me.Image64.Images.SetKeyName(37, "gas-icon.png")
        Me.Image64.Images.SetKeyName(38, "gas-icon_1.png")
        Me.Image64.Images.SetKeyName(39, "Gas-pump-icon.png")
        Me.Image64.Images.SetKeyName(40, "Household-Garage-icon.png")
        Me.Image64.Images.SetKeyName(41, "longhaul-icon.png")
        Me.Image64.Images.SetKeyName(42, "Map-icon.png")
        Me.Image64.Images.SetKeyName(43, "Microsoft-Sync-icon.png")
        Me.Image64.Images.SetKeyName(44, "Mimetypes-text-x-rpm-spec-icon.png")
        Me.Image64.Images.SetKeyName(45, "Notepad-Bloc-notes-icon.png")
        Me.Image64.Images.SetKeyName(46, "Notepad-icon.png")
        Me.Image64.Images.SetKeyName(47, "office-building-icon.png")
        Me.Image64.Images.SetKeyName(48, "Pictures-Nikon-icon.png")
        Me.Image64.Images.SetKeyName(49, "Places-trash-full-icon.png")
        Me.Image64.Images.SetKeyName(50, "Presentation-icon.png")
        Me.Image64.Images.SetKeyName(51, "project-plan-icon.png")
        Me.Image64.Images.SetKeyName(52, "scavenger-icon.png")
        Me.Image64.Images.SetKeyName(53, "SEO-icon.png")
        Me.Image64.Images.SetKeyName(54, "table-add-icon.png")
        Me.Image64.Images.SetKeyName(55, "tables-icon.png")
        Me.Image64.Images.SetKeyName(56, "train-icon.png")
        Me.Image64.Images.SetKeyName(57, "Transport-Gas-Pump-icon.png")
        Me.Image64.Images.SetKeyName(58, "Trash-full-icon.png")
        Me.Image64.Images.SetKeyName(59, "User-Group-icon.png")
        Me.Image64.Images.SetKeyName(60, "Users-Workers-icon.png")
        '
        'Label1
        '
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.ImageKey = "Map-icon.png"
        Me.Label1.ImageList = Me.ImageList1
        Me.Label1.Location = New System.Drawing.Point(256, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 27)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "現場名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(352, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(334, 27)
        Me.ComboBox1.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageKey = "arrow-right-icon.png"
        Me.Button1.ImageList = Me.Image32
        Me.Button1.Location = New System.Drawing.Point(698, 452)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 40)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "保存"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ucInputExpence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Meiryo UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Name = "ucInputExpence"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(789, 500)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Image64 As System.Windows.Forms.ImageList
    Friend WithEvents expenceTrain As System.Windows.Forms.TextBox
    Friend WithEvents Image32 As System.Windows.Forms.ImageList
    Friend WithEvents addExpence1 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
