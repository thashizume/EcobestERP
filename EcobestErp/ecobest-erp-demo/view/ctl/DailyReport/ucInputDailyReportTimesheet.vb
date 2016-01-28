Public Class ucInputDailyReportTimesheet



    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        'TODO:  入力状態を確認して、入力されているようであれば、確認メッセージを表示

        '   Menuの追加
        Dim ucMenu As New MenuUserControle(Nothing)
        Me.Parent.Parent.Controls.Item(0).Controls.Add(ucMenu)
        DockFill(ucMenu.Name)
        Unload()

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




    Private Sub holiday_CheckedChanged(sender As Object, e As EventArgs) Handles holiday.CheckedChanged

        If holiday.Checked = True Then
            If MsgBox("休暇が選択されました。半一日お休みですか？", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                workTime.Value = 4

                workType.Enabled = True
                workDetail.Enabled = True
                workTime.Enabled = True

                Dim h(3) As String
                h(0) = "4.0"
                h(1) = "半休"
                h(2) = ""
                dvg.Rows.Add(h)

            Else
                workTime.Value = 8
                workType.Enabled = False
                workDetail.Enabled = False
                workTime.Enabled = False

                Dim h(3) As String
                h(0) = "8.0"
                h(1) = "半休"
                h(2) = ""
                dvg.Rows.Add(h)

            End If


        Else
            workType.Enabled = True
            workDetail.Enabled = True
            workTime.Enabled = True

        End If

    End Sub
End Class
