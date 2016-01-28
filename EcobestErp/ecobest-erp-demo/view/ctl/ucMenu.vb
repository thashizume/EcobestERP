Public Class ucMenu

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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
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
