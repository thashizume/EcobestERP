Public Class ucListDailyReport

    Private _localData As System.Data.DataTable


    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Call defineLocalDataTable()
        Call sampleData()
        DataGridView1.DataSource = _localData

    End Sub

    Private Sub sampleData()

        Dim n As Date = CDate(Now.Year & "/" & Now.Month & "/1")

        For i As Long = 1 To 31
            Dim nn As Date = n.AddDays(i)
            Dim row As System.Data.DataRow = _localData.NewRow
            If n.Year = nn.Year And n.Year = nn.Month Then
                row(0) = i
                row(1) = nn
                row(2) = 8
                If nn.Day > 20 Then
                    row(3) = ""
                Else
                    If nn.Day / 3 Mod 4 Then
                        row(3) = "未入力"
                    End If
                End If

                _localData.Rows.Add(row)
            End If

        Next


    End Sub

    Private Sub defineLocalDataTable()
        _localData = New System.Data.DataTable

        _localData.Columns.Add("DailyReportID", GetType(Long))
        _localData.Columns.Add("DailyReportWorkDay", GetType(Date))
        _localData.Columns.Add("DailyReportWorkTime", GetType(Long))
        _localData.Columns.Add("DailyReportState", GetType(Long))
        _localData.Columns.Add("DailyReportState", GetType(Long))


    End Sub

End Class
