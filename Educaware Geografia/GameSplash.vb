Public NotInheritable Class GameSplash

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        prgGame.Increment(20)

        If prgGame.Value = 100 Then

            GamePrincipal.Show()
            Me.Close()

        End If

    End Sub

    Private Sub GameSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
