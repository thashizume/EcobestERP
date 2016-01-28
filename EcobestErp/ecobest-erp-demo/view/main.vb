Public Class main

    Private _account As AccountModel = Nothing

    Public ReadOnly Property AccountID As Long
        Get
            If _account Is Nothing Then
                Return -1
            Else
                Return _account.AccountID
            End If
        End Get
    End Property


    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim uc As New SignInUserControle
        Panel1.Controls.Add(uc)
        Panel1.Controls.Item(0).Dock = DockStyle.Fill

    End Sub


    Private Sub DebugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebugToolStripMenuItem.Click

        Dim s1 As String = (New jp.polestar.security.Cryptography).Encrypt("toshinobu.hashizume@'''gmail.com", "12qwaszx")
        Dim s2 As String = (New jp.polestar.security.Cryptography).Encrypt("toshinobu.hashizume@'''gmail.com", "12qwaszx")

        Debug.Print(s1)
        Debug.Print(s2)
        Debug.Print("---")
        Debug.Print((New jp.polestar.security.Cryptography).Decrypt(s1, "12qwaszx"))

    End Sub

    Private Sub GenerateInitDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateInitDataToolStripMenuItem.Click

        Dim d As jp.polestar.ecobest.erp.InitData = New jp.polestar.ecobest.erp.InitData
        d.GenerateInitData()

    End Sub
End Class