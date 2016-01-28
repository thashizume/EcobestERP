Public Class ucInputExpence

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        'TODO:  入力状態を確認して、入力されているようであれば、確認メッセージを表示

        '   Menuの追加
        Dim ucMenu As New MenuControle
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


    Private Sub ucInputExpence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplitContainer1.Height = 400

    End Sub
End Class
