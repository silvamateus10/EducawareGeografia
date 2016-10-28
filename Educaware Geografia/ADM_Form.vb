Public Class ADM_Form

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click

        EditarForm.ShowDialog()

    End Sub


    Private Sub SairToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem1.Click

        Dim result As Integer = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Me.Close()

        ElseIf result = DialogResult.No Then


        End If

    End Sub

    Private Sub ADM_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExluirToolStripMenuItem.Click
        ExcluirForm.ShowDialog()
    End Sub

    Private Sub JogadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JogadorToolStripMenuItem.Click

        PerguntasNorte.Show()

    End Sub

    Private Sub RegiãoCentroOesteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegiãoCentroOesteToolStripMenuItem.Click

        PerguntasCentroOeste.Show()

    End Sub

    Private Sub LogarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogarToolStripMenuItem.Click

    End Sub

    Private Sub RegiãoNordesteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegiãoNordesteToolStripMenuItem.Click

        PerguntasNordeste.Show()

    End Sub

    Private Sub RegiãoSudesteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegiãoSudesteToolStripMenuItem.Click

        PerguntasSudeste.show()

    End Sub

    Private Sub RegiãoSulToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegiãoSulToolStripMenuItem.Click

        PerguntasSul.show()

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click

        Process.Start("file:///C:/Users/Fernando/Desktop/TCC%20-%20Site/index.html")

    End Sub

End Class
