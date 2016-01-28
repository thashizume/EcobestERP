<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucInputDailyReportTimesheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucInputDailyReportTimesheet))
        Me.workDay = New System.Windows.Forms.DateTimePicker()
        Me.dvg = New System.Windows.Forms.DataGridView()
        Me.workType = New System.Windows.Forms.ComboBox()
        Me.workDetail = New System.Windows.Forms.TextBox()
        Me.workTime = New System.Windows.Forms.NumericUpDown()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Image16 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.holiday = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Image32 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dbWorkTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dbWorkPlace = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dbWrokDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dvg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.workTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'workDay
        '
        Me.workDay.Location = New System.Drawing.Point(117, 93)
        Me.workDay.Name = "workDay"
        Me.workDay.Size = New System.Drawing.Size(148, 27)
        Me.workDay.TabIndex = 8
        '
        'dvg
        '
        Me.dvg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dvg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dvg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dvg.ColumnHeadersHeight = 25
        Me.dvg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dbWorkTime, Me.dbWorkPlace, Me.dbWrokDetail})
        Me.dvg.Location = New System.Drawing.Point(117, 347)
        Me.dvg.Name = "dvg"
        Me.dvg.RowTemplate.Height = 21
        Me.dvg.Size = New System.Drawing.Size(641, 112)
        Me.dvg.TabIndex = 17
        '
        'workType
        '
        Me.workType.FormattingEnabled = True
        Me.workType.Location = New System.Drawing.Point(117, 159)
        Me.workType.Name = "workType"
        Me.workType.Size = New System.Drawing.Size(641, 27)
        Me.workType.TabIndex = 23
        '
        'workDetail
        '
        Me.workDetail.Location = New System.Drawing.Point(117, 192)
        Me.workDetail.Multiline = True
        Me.workDetail.Name = "workDetail"
        Me.workDetail.Size = New System.Drawing.Size(641, 103)
        Me.workDetail.TabIndex = 25
        '
        'workTime
        '
        Me.workTime.DecimalPlaces = 1
        Me.workTime.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.workTime.Location = New System.Drawing.Point(117, 126)
        Me.workTime.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.workTime.Name = "workTime"
        Me.workTime.Size = New System.Drawing.Size(102, 27)
        Me.workTime.TabIndex = 26
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
        Me.btnPrevious.Location = New System.Drawing.Point(679, 8)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(79, 40)
        Me.btnPrevious.TabIndex = 27
        Me.btnPrevious.Text = "戻る"
        Me.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 64)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "作業日報の入力"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Image16
        '
        Me.Image16.ImageStream = CType(resources.GetObject("Image16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Image16.TransparentColor = System.Drawing.Color.Transparent
        Me.Image16.Images.SetKeyName(0, "Actions-dialog-cancel-icon.png")
        Me.Image16.Images.SetKeyName(1, "Actions-dialog-close-icon.png")
        Me.Image16.Images.SetKeyName(2, "Actions-dialog-ok-apply-icon.png")
        Me.Image16.Images.SetKeyName(3, "Actions-go-jump-today-icon.png")
        Me.Image16.Images.SetKeyName(4, "Actions-mail-mark-task-icon.png")
        Me.Image16.Images.SetKeyName(5, "Actions-view-calendar-icon.png")
        Me.Image16.Images.SetKeyName(6, "Actions-view-calendar-tasks-icon.png")
        Me.Image16.Images.SetKeyName(7, "Actions-view-calendar-upcoming-events-icon.png")
        Me.Image16.Images.SetKeyName(8, "Adobe-PDF-Document-icon.png")
        Me.Image16.Images.SetKeyName(9, "Apps-preferences-system-bluetooth-icon.png")
        Me.Image16.Images.SetKeyName(10, "Apps-preferences-system-time-icon.png")
        Me.Image16.Images.SetKeyName(11, "arrow-down-icon.png")
        Me.Image16.Images.SetKeyName(12, "arrow-right-icon.png")
        Me.Image16.Images.SetKeyName(13, "Avengers-War-Machine-icon.png")
        Me.Image16.Images.SetKeyName(14, "Cart-icon.png")
        Me.Image16.Images.SetKeyName(15, "Cash-register-icon_1.png")
        Me.Image16.Images.SetKeyName(16, "City-Gas-Station-icon.png")
        Me.Image16.Images.SetKeyName(17, "company-building-icon.png")
        Me.Image16.Images.SetKeyName(18, "Company-icon.png")
        Me.Image16.Images.SetKeyName(19, "Contract-icon.png")
        Me.Image16.Images.SetKeyName(20, "currency-yen-icon.png")
        Me.Image16.Images.SetKeyName(21, "document-construction-icon.png")
        Me.Image16.Images.SetKeyName(22, "document-excel-icon.png")
        Me.Image16.Images.SetKeyName(23, "Document-Gant-Chart-icon.png")
        Me.Image16.Images.SetKeyName(24, "Document-Microsoft-Excel-icon.png")
        Me.Image16.Images.SetKeyName(25, "Document-Microsoft-PowerPoint-icon.png")
        Me.Image16.Images.SetKeyName(26, "Document-Microsoft-Word-icon.png")
        Me.Image16.Images.SetKeyName(27, "Document-save-icon.png")
        Me.Image16.Images.SetKeyName(28, "document-word-icon.png")
        Me.Image16.Images.SetKeyName(29, "Drawing-icon.png")
        Me.Image16.Images.SetKeyName(30, "file-cabinet-icon.png")
        Me.Image16.Images.SetKeyName(31, "flow-chart-icon.png")
        Me.Image16.Images.SetKeyName(32, "folder-tools-icon.png")
        Me.Image16.Images.SetKeyName(33, "gas-icon.png")
        Me.Image16.Images.SetKeyName(34, "gas-icon_1.png")
        Me.Image16.Images.SetKeyName(35, "Gas-pump-icon.png")
        Me.Image16.Images.SetKeyName(36, "Household-Garage-icon.png")
        Me.Image16.Images.SetKeyName(37, "longhaul-icon.png")
        Me.Image16.Images.SetKeyName(38, "Map-icon.png")
        Me.Image16.Images.SetKeyName(39, "Mimetypes-text-x-rpm-spec-icon.png")
        Me.Image16.Images.SetKeyName(40, "Notepad-Bloc-notes-icon.png")
        Me.Image16.Images.SetKeyName(41, "Notepad-icon.png")
        Me.Image16.Images.SetKeyName(42, "Parking-Garage-icon.png")
        Me.Image16.Images.SetKeyName(43, "Pictures-Nikon-icon.png")
        Me.Image16.Images.SetKeyName(44, "Places-trash-full-icon.png")
        Me.Image16.Images.SetKeyName(45, "project-plan-icon.png")
        Me.Image16.Images.SetKeyName(46, "scavenger-icon.png")
        Me.Image16.Images.SetKeyName(47, "SEO-icon.png")
        Me.Image16.Images.SetKeyName(48, "train-icon.png")
        Me.Image16.Images.SetKeyName(49, "Transport-Gas-Pump-icon.png")
        Me.Image16.Images.SetKeyName(50, "Trash-full-icon.png")
        Me.Image16.Images.SetKeyName(51, "Users-Workers-icon.png")
        '
        'Label9
        '
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.ImageKey = "Actions-go-jump-today-icon.png"
        Me.Label9.ImageList = Me.Image16
        Me.Label9.Location = New System.Drawing.Point(3, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 25)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "作業日："
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.ImageKey = "Apps-preferences-system-time-icon.png"
        Me.Label2.ImageList = Me.Image16
        Me.Label2.Location = New System.Drawing.Point(3, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 25)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "作業日："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.ImageKey = "Map-icon.png"
        Me.Label7.ImageList = Me.Image16
        Me.Label7.Location = New System.Drawing.Point(3, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 25)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "作業現場："
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.ImageKey = "folder-tools-icon.png"
        Me.Label3.ImageList = Me.Image16
        Me.Label3.Location = New System.Drawing.Point(3, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 25)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "作業内容："
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'holiday
        '
        Me.holiday.AutoSize = True
        Me.holiday.Location = New System.Drawing.Point(290, 95)
        Me.holiday.Name = "holiday"
        Me.holiday.Size = New System.Drawing.Size(58, 23)
        Me.holiday.TabIndex = 33
        Me.holiday.Text = "休暇"
        Me.holiday.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImageKey = "arrow-down-icon.png"
        Me.Button3.ImageList = Me.Image32
        Me.Button3.Location = New System.Drawing.Point(117, 301)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 40)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "入力"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Image32
        '
        Me.Image32.ImageStream = CType(resources.GetObject("Image32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Image32.TransparentColor = System.Drawing.Color.Transparent
        Me.Image32.Images.SetKeyName(0, "Actions-dialog-cancel-icon.png")
        Me.Image32.Images.SetKeyName(1, "Actions-dialog-close-icon.png")
        Me.Image32.Images.SetKeyName(2, "Actions-dialog-ok-apply-icon.png")
        Me.Image32.Images.SetKeyName(3, "Actions-go-jump-today-icon.png")
        Me.Image32.Images.SetKeyName(4, "Actions-mail-mark-task-icon.png")
        Me.Image32.Images.SetKeyName(5, "Actions-view-calendar-icon.png")
        Me.Image32.Images.SetKeyName(6, "Actions-view-calendar-tasks-icon.png")
        Me.Image32.Images.SetKeyName(7, "Actions-view-calendar-upcoming-events-icon.png")
        Me.Image32.Images.SetKeyName(8, "Actions-view-pim-contacts-icon.png")
        Me.Image32.Images.SetKeyName(9, "Admin-icon.png")
        Me.Image32.Images.SetKeyName(10, "Adobe-PDF-Document-icon.png")
        Me.Image32.Images.SetKeyName(11, "Apps-preferences-system-bluetooth-icon.png")
        Me.Image32.Images.SetKeyName(12, "Apps-preferences-system-time-icon.png")
        Me.Image32.Images.SetKeyName(13, "arrow-down-icon.png")
        Me.Image32.Images.SetKeyName(14, "arrow-right-icon.png")
        Me.Image32.Images.SetKeyName(15, "Avengers-War-Machine-icon.png")
        Me.Image32.Images.SetKeyName(16, "Back-icon.png")
        Me.Image32.Images.SetKeyName(17, "Cart-icon.png")
        Me.Image32.Images.SetKeyName(18, "cash-register-icon.png")
        Me.Image32.Images.SetKeyName(19, "Cash-register-icon_1.png")
        Me.Image32.Images.SetKeyName(20, "City-Gas-Station-icon.png")
        Me.Image32.Images.SetKeyName(21, "Comics-War-Machine-icon.png")
        Me.Image32.Images.SetKeyName(22, "company-building-icon.png")
        Me.Image32.Images.SetKeyName(23, "Company-icon.png")
        Me.Image32.Images.SetKeyName(24, "Contract-icon.png")
        Me.Image32.Images.SetKeyName(25, "Custom-reports-icon.png")
        Me.Image32.Images.SetKeyName(26, "Distributor-report-icon.png")
        Me.Image32.Images.SetKeyName(27, "document-construction-icon.png")
        Me.Image32.Images.SetKeyName(28, "document-excel-icon.png")
        Me.Image32.Images.SetKeyName(29, "Document-Gant-Chart-icon.png")
        Me.Image32.Images.SetKeyName(30, "Document-Microsoft-Excel-icon.png")
        Me.Image32.Images.SetKeyName(31, "Document-Microsoft-PowerPoint-icon.png")
        Me.Image32.Images.SetKeyName(32, "Document-Microsoft-Word-icon.png")
        Me.Image32.Images.SetKeyName(33, "Document-save-icon.png")
        Me.Image32.Images.SetKeyName(34, "document-word-icon.png")
        Me.Image32.Images.SetKeyName(35, "Drawing-icon.png")
        Me.Image32.Images.SetKeyName(36, "file-cabinet-icon.png")
        Me.Image32.Images.SetKeyName(37, "flow-chart-icon.png")
        Me.Image32.Images.SetKeyName(38, "folder-tools-icon.png")
        Me.Image32.Images.SetKeyName(39, "gas-icon.png")
        Me.Image32.Images.SetKeyName(40, "gas-icon_1.png")
        Me.Image32.Images.SetKeyName(41, "Gas-pump-icon.png")
        Me.Image32.Images.SetKeyName(42, "Household-Garage-icon.png")
        Me.Image32.Images.SetKeyName(43, "longhaul-icon.png")
        Me.Image32.Images.SetKeyName(44, "Map-icon.png")
        Me.Image32.Images.SetKeyName(45, "Mimetypes-text-x-rpm-spec-icon.png")
        Me.Image32.Images.SetKeyName(46, "Next-icon.png")
        Me.Image32.Images.SetKeyName(47, "Notepad-Bloc-notes-icon.png")
        Me.Image32.Images.SetKeyName(48, "Notepad-icon.png")
        Me.Image32.Images.SetKeyName(49, "office-building-icon.png")
        Me.Image32.Images.SetKeyName(50, "Parking-Garage-icon.png")
        Me.Image32.Images.SetKeyName(51, "Pictures-Nikon-icon.png")
        Me.Image32.Images.SetKeyName(52, "Places-trash-full-icon.png")
        Me.Image32.Images.SetKeyName(53, "Presentation-icon.png")
        Me.Image32.Images.SetKeyName(54, "Previous-icon.png")
        Me.Image32.Images.SetKeyName(55, "project-plan-icon.png")
        Me.Image32.Images.SetKeyName(56, "scavenger-icon.png")
        Me.Image32.Images.SetKeyName(57, "SEO-icon.png")
        Me.Image32.Images.SetKeyName(58, "table-add-icon.png")
        Me.Image32.Images.SetKeyName(59, "tables-icon.png")
        Me.Image32.Images.SetKeyName(60, "train-icon.png")
        Me.Image32.Images.SetKeyName(61, "Transport-Gas-Pump-icon.png")
        Me.Image32.Images.SetKeyName(62, "Trash-full-icon.png")
        Me.Image32.Images.SetKeyName(63, "User-Group-icon.png")
        Me.Image32.Images.SetKeyName(64, "Users-Workers-icon.png")
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.AutoSize = True
        Me.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageKey = "arrow-right-icon.png"
        Me.btnSave.ImageList = Me.Image32
        Me.btnSave.Location = New System.Drawing.Point(117, 465)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 40)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "保存"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dbWorkTime
        '
        Me.dbWorkTime.HeaderText = "作業時間"
        Me.dbWorkTime.Name = "dbWorkTime"
        Me.dbWorkTime.Width = 94
        '
        'dbWorkPlace
        '
        Me.dbWorkPlace.FillWeight = 200.0!
        Me.dbWorkPlace.HeaderText = "作業現場"
        Me.dbWorkPlace.Name = "dbWorkPlace"
        Me.dbWorkPlace.Width = 94
        '
        'dbWrokDetail
        '
        Me.dbWrokDetail.FillWeight = 300.0!
        Me.dbWrokDetail.HeaderText = "作業内容"
        Me.dbWrokDetail.Name = "dbWrokDetail"
        Me.dbWrokDetail.Width = 94
        '
        'ucInputDailyReportTimesheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.holiday)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.workTime)
        Me.Controls.Add(Me.workDetail)
        Me.Controls.Add(Me.workType)
        Me.Controls.Add(Me.dvg)
        Me.Controls.Add(Me.workDay)
        Me.Font = New System.Drawing.Font("Meiryo UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Name = "ucInputDailyReportTimesheet"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(766, 513)
        CType(Me.dvg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.workTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents workDay As System.Windows.Forms.DateTimePicker
    Friend WithEvents dvg As System.Windows.Forms.DataGridView
    Friend WithEvents workType As System.Windows.Forms.ComboBox
    Friend WithEvents workDetail As System.Windows.Forms.TextBox
    Friend WithEvents workTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Image16 As System.Windows.Forms.ImageList
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents holiday As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Image32 As System.Windows.Forms.ImageList
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dbWorkTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dbWorkPlace As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dbWrokDetail As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
