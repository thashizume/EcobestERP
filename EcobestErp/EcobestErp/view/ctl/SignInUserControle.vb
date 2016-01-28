Public Class SignInUserControle

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub


    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Dim uc As MenuUserControle

        'TODO:  認証
        Dim auth As jp.polestar.ecobest.erp.authController = New jp.polestar.ecobest.erp.authController
        auth.AccountName = txtAccount.Text
        auth.AccountPassword = txtPassword.Text

        If auth.SignIn Then

            '   認証OK, 画面の切替え
            uc = New MenuUserControle(auth.Account)

            Me.Parent.Controls.Add(uc)

            For i As Integer = 0 To Me.Parent.Controls.Count - 1
                Debug.Print(Me.Parent.Controls(i).Name)
                Me.Parent.Controls(i).Dock = DockStyle.Fill
            Next

            '   MenuStrip, StatusStrip を表示
            For i As Integer = 0 To Me.Parent.Parent.Controls.Count - 1
                If InStr(UCase(Me.Parent.Parent.Controls(i).GetType.Name), UCase("strip")) > 0 Then Me.Parent.Parent.Controls(i).Visible = True
            Next

            '   画面の最大化
            CType(Me.Parent.Parent, jp.polestar.ecobest.erp.main).WindowState = FormWindowState.Maximized

            '   自信を消滅
            Me.Parent.Controls.RemoveByKey(Me.Name)

        Else


        End If

    End Sub




End Class
