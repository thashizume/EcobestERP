<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListDailyReport
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DailyReportID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyReportWorkDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyReportWorkTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyReportState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyReportDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DailyReportID, Me.DailyReportWorkDay, Me.DailyReportWorkTime, Me.DailyReportState, Me.DailyReportDetail})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(767, 339)
        Me.DataGridView1.TabIndex = 0
        '
        'DailyReportID
        '
        Me.DailyReportID.HeaderText = "DailyReportID"
        Me.DailyReportID.Name = "DailyReportID"
        Me.DailyReportID.ReadOnly = True
        Me.DailyReportID.Visible = False
        '
        'DailyReportWorkDay
        '
        Me.DailyReportWorkDay.HeaderText = "日付"
        Me.DailyReportWorkDay.Name = "DailyReportWorkDay"
        Me.DailyReportWorkDay.ReadOnly = True
        '
        'DailyReportWorkTime
        '
        Me.DailyReportWorkTime.HeaderText = "作業時間"
        Me.DailyReportWorkTime.Name = "DailyReportWorkTime"
        '
        'DailyReportState
        '
        Me.DailyReportState.HeaderText = "状態"
        Me.DailyReportState.Name = "DailyReportState"
        '
        'DailyReportDetail
        '
        Me.DailyReportDetail.HeaderText = "摘要"
        Me.DailyReportDetail.Name = "DailyReportDetail"
        Me.DailyReportDetail.ReadOnly = True
        '
        'ucListDailyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ucListDailyReport"
        Me.Size = New System.Drawing.Size(767, 339)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DailyReportID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DailyReportWorkDay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DailyReportWorkTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DailyReportState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DailyReportDetail As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
