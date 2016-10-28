Public NotInheritable Class SplashScreen1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        prg1.Increment(1)

        If prg1.Value >= 100 Then

            LoginForm1.Show()
            Me.Hide()

        End If

    End Sub



End Class
