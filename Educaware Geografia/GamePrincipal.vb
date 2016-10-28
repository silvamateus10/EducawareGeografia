Public Class GamePrincipal

    Private Sub Fechar(ByRef Close)

        My.Computer.Audio.Stop()

    End Sub

    Private Sub PictureSemSom_Click(sender As Object, e As EventArgs)

        My.Computer.Audio.Stop()

    End Sub

    Private Sub GamePrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        My.Computer.Audio.Play(My.Resources.Aquarela___Melodia, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub PictureSom_Click(sender As Object, e As EventArgs)

        My.Computer.Audio.Play(My.Resources.Aquarela___Melodia, AudioPlayMode.BackgroundLoop)

    End Sub


    Private Sub SairToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        
        
        Dim result As Integer = MessageBox.Show("Realmente deseja sair Quiz Educaware?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Me.Close()
            My.Computer.Audio.Stop()

        ElseIf result = DialogResult.No Then


        End If


    End Sub


    Private Sub linkQuiz_Click(sender As Object, e As EventArgs)

        

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnVoltar.Visible = False
        btnSeguir.Visible = False
        lblBrasil.Visible = False

        lblCentro.Visible = False
        lblNordeste.Visible = False
        lblNorte.Visible = False
        lblSudeste.Visible = False
        lblSul.Visible = False

        pbEducaware.Visible = True
        pbCentro.Visible = False
        pbNordeste.Visible = False
        pbNorte.Visible = False
        pbSudeste.Visible = False
        pbSul.Visible = False

        linkCentro.Visible = False
        linkNordeste.Visible = False
        linkNorte.Visible = False
        linkSudeste.Visible = False
        linkSul.Visible = False

    End Sub


    Private Sub linkNorte_Click_1(sender As Object, e As EventArgs) Handles linkNorte.Click
        btnVoltar.Visible = True
        pbBrasil.Visible = False
        btnComecarNorte.Visible = True

        lblBrasil.Visible = False
        lblCentro.Visible = False
        lblNordeste.Visible = False
        lblNorte.Visible = True
        lblSudeste.Visible = False
        lblSul.Visible = False

        linkCentro.Visible = False
        linkNordeste.Visible = False
        linkNorte.Visible = True
        linkSudeste.Visible = False
        linkSul.Visible = False
        pbEducaware.Visible = True
        pbNorte.Visible = True
        
    End Sub


    Private Sub linkNordeste_Click_1(sender As Object, e As EventArgs) Handles linkNordeste.Click
        btnVoltar.Visible = True
        btnComecarNordeste.Visible = True
        pbBrasil.Visible = False

        lblBrasil.Visible = False
        lblCentro.Visible = False
        lblNordeste.Visible = True
        lblNorte.Visible = False
        lblSudeste.Visible = False
        lblSul.Visible = False

        linkCentro.Visible = False
        linkNordeste.Visible = True
        linkNorte.Visible = False
        linkSudeste.Visible = False
        linkSul.Visible = False
        pbEducaware.Visible = True
        pbNordeste.Visible = True

    End Sub


    Private Sub linkSudeste_Click_1(sender As Object, e As EventArgs) Handles linkSudeste.Click
        btnVoltar.Visible = True
        btnComecarSudeste.Visible = True
        pbBrasil.Visible = False

        lblBrasil.Visible = False
        lblCentro.Visible = False
        lblNordeste.Visible = False
        lblNorte.Visible = False
        lblSudeste.Visible = True
        lblSul.Visible = False

        linkCentro.Visible = False
        linkNordeste.Visible = False
        linkNorte.Visible = False
        linkSudeste.Visible = True
        linkSul.Visible = False
        pbEducaware.Visible = True
        pbSudeste.Visible = True
    End Sub

    Private Sub linkSul_Click(sender As Object, e As EventArgs) Handles linkSul.Click
        btnVoltar.Visible = True
        btnComecarSul.Visible = True
        pbBrasil.Visible = False

        lblBrasil.Visible = False
        lblCentro.Visible = False
        lblNordeste.Visible = False
        lblNorte.Visible = False
        lblSudeste.Visible = False
        lblSul.Visible = True

        linkCentro.Visible = False
        linkNordeste.Visible = False
        linkNorte.Visible = False
        linkSudeste.Visible = False
        linkSul.Visible = True
        pbEducaware.Visible = True
        pbSul.Visible = True

    End Sub


    Private Sub linkCentro_Click_1(sender As Object, e As EventArgs) Handles linkCentro.Click
        btnVoltar.Visible = True
        btnSeguir.Visible = True
        pbBrasil.Visible = False
        btnSeguir.Visible = True

        lblBrasil.Visible = False
        lblCentro.Visible = True
        lblNordeste.Visible = False
        lblNorte.Visible = False
        lblSudeste.Visible = False
        lblSul.Visible = False

        linkCentro.Visible = True
        linkNordeste.Visible = False
        linkNorte.Visible = False
        linkSudeste.Visible = False
        linkSul.Visible = False
        pbEducaware.Visible = True
        pbCentro.Visible = True

    End Sub


    Private Sub btnSeguir_Click(sender As Object, e As EventArgs)

        btnVoltar.Visible = False
        btnSeguir.Visible = False
        lblBrasil.Visible = False

        lblCentro.Visible = False
        lblNordeste.Visible = False
        lblNorte.Visible = False
        lblSudeste.Visible = False
        lblSul.Visible = False

        pbEducaware.Visible = True
        pbBrasil.Visible = True
        pbCentro.Visible = False
        pbNordeste.Visible = False
        pbNorte.Visible = False
        pbSudeste.Visible = False
        pbSul.Visible = False

        linkCentro.Visible = True
        linkNordeste.Visible = True
        linkNorte.Visible = True
        linkSudeste.Visible = True
        linkSul.Visible = True

        Quiz.Show()

    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs)
        
    End Sub


    Private Sub PictureSemSom_Click_1(sender As Object, e As EventArgs) Handles PictureSemSom.Click

        My.Computer.Audio.Stop()
    End Sub

    Private Sub PictureSom_Click_1(sender As Object, e As EventArgs) Handles PictureSom.Click
        My.Computer.Audio.Play(My.Resources.Aquarela___Melodia, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnVoltar_Click_1(sender As Object, e As EventArgs)


    End Sub

   
    Private Sub linkQuiz_Click_1(sender As Object, e As EventArgs) Handles linkQuiz.Click

        btnVoltar.Visible = False
        btnSeguir.Visible = False
        lblBrasil.Visible = True

        lblCentro.Visible = False
        lblNordeste.Visible = False
        lblNorte.Visible = False
        lblSudeste.Visible = False
        lblSul.Visible = False

        pbEducaware.Visible = True
        pbBrasil.Visible = True
        pbCentro.Visible = False
        pbNordeste.Visible = False
        pbNorte.Visible = False
        pbSudeste.Visible = False
        pbSul.Visible = False

        linkCentro.Visible = True
        linkNordeste.Visible = True
        linkNorte.Visible = True
        linkSudeste.Visible = True
        linkSul.Visible = True

    End Sub

    Private Sub btnVoltar_Click_2(sender As Object, e As EventArgs) Handles btnVoltar.Click

        btnVoltar.Visible = False
        btnSeguir.Visible = False
        lblBrasil.Visible = True
        btnComecarNordeste.Visible = False
        btnComecarNorte.Visible = False
        btnComecarSul.Visible = False
        btnComecarSudeste.Visible = False

        lblCentro.Visible = False
        lblNordeste.Visible = False
        lblNorte.Visible = False
        lblSudeste.Visible = False
        lblSul.Visible = False

        pbEducaware.Visible = True
        pbBrasil.Visible = True
        pbCentro.Visible = False
        pbNordeste.Visible = False
        pbNorte.Visible = False
        pbSudeste.Visible = False
        pbSul.Visible = False

        linkCentro.Visible = True
        linkNordeste.Visible = True
        linkNorte.Visible = True
        linkSudeste.Visible = True
        linkSul.Visible = True

    End Sub

    Private Sub btnSeguir_Click_2(sender As Object, e As EventArgs) Handles btnSeguir.Click

        Quiz.Show()

        btnVoltar.Visible = False
        btnSeguir.Visible = False
        lblBrasil.Visible = True
        btnComecarNordeste.Visible = False
        btnComecarNorte.Visible = False
        btnComecarSul.Visible = False
        btnComecarSudeste.Visible = False

        lblCentro.Visible = False
        lblNordeste.Visible = False
        lblNorte.Visible = False
        lblSudeste.Visible = False
        lblSul.Visible = False

        pbEducaware.Visible = True
        pbBrasil.Visible = True
        pbCentro.Visible = False
        pbNordeste.Visible = False
        pbNorte.Visible = False
        pbSudeste.Visible = False
        pbSul.Visible = False

        linkCentro.Visible = True
        linkNordeste.Visible = True
        linkNorte.Visible = True
        linkSudeste.Visible = True
        linkSul.Visible = True


    End Sub

    Private Sub btnComecarNorte_Click_1(sender As Object, e As EventArgs) Handles btnComecarNorte.Click

        QuizNorte.Show()

        btnVoltar.Visible = False
        btnSeguir.Visible = False
        lblBrasil.Visible = True
        btnComecarNordeste.Visible = False
        btnComecarNorte.Visible = False
        btnComecarSul.Visible = False
        btnComecarSudeste.Visible = False

        lblCentro.Visible = False
        lblNordeste.Visible = False
        lblNorte.Visible = False
        lblSudeste.Visible = False
        lblSul.Visible = False

        pbEducaware.Visible = True
        pbBrasil.Visible = True
        pbCentro.Visible = False
        pbNordeste.Visible = False
        pbNorte.Visible = False
        pbSudeste.Visible = False
        pbSul.Visible = False

        linkCentro.Visible = True
        linkNordeste.Visible = True
        linkNorte.Visible = True
        linkSudeste.Visible = True
        linkSul.Visible = True

    End Sub

    Private Sub btnComecarNordeste_Click(sender As Object, e As EventArgs) Handles btnComecarNordeste.Click

        QuizNordeste.Show()

        btnVoltar.Visible = False
        btnSeguir.Visible = False
        lblBrasil.Visible = True
        btnComecarNordeste.Visible = False
        btnComecarNorte.Visible = False
        btnComecarSul.Visible = False
        btnComecarSudeste.Visible = False

        lblCentro.Visible = False
        lblNordeste.Visible = False
        lblNorte.Visible = False
        lblSudeste.Visible = False
        lblSul.Visible = False

        pbEducaware.Visible = True
        pbBrasil.Visible = True
        pbCentro.Visible = False
        pbNordeste.Visible = False
        pbNorte.Visible = False
        pbSudeste.Visible = False
        pbSul.Visible = False

        linkCentro.Visible = True
        linkNordeste.Visible = True
        linkNorte.Visible = True
        linkSudeste.Visible = True
        linkSul.Visible = True

    End Sub

    Private Sub btnComecarSudeste_Click(sender As Object, e As EventArgs) Handles btnComecarSudeste.Click

        QuizSudeste.Show()

        btnVoltar.Visible = False
        btnSeguir.Visible = False
        lblBrasil.Visible = True
        btnComecarNordeste.Visible = False
        btnComecarNorte.Visible = False
        btnComecarSul.Visible = False
        btnComecarSudeste.Visible = False

        lblCentro.Visible = False
        lblNordeste.Visible = False
        lblNorte.Visible = False
        lblSudeste.Visible = False
        lblSul.Visible = False

        pbEducaware.Visible = True
        pbBrasil.Visible = True
        pbCentro.Visible = False
        pbNordeste.Visible = False
        pbNorte.Visible = False
        pbSudeste.Visible = False
        pbSul.Visible = False

        linkCentro.Visible = True
        linkNordeste.Visible = True
        linkNorte.Visible = True
        linkSudeste.Visible = True
        linkSul.Visible = True

    End Sub

    Private Sub btnComecarSul_Click(sender As Object, e As EventArgs) Handles btnComecarSul.Click

        QuizSul.Show()

        btnVoltar.Visible = False
        btnSeguir.Visible = False
        lblBrasil.Visible = True
        btnComecarNordeste.Visible = False
        btnComecarNorte.Visible = False
        btnComecarSul.Visible = False
        btnComecarSudeste.Visible = False

        lblCentro.Visible = False
        lblNordeste.Visible = False
        lblNorte.Visible = False
        lblSudeste.Visible = False
        lblSul.Visible = False

        pbEducaware.Visible = True
        pbBrasil.Visible = True
        pbCentro.Visible = False
        pbNordeste.Visible = False
        pbNorte.Visible = False
        pbSudeste.Visible = False
        pbSul.Visible = False

        linkCentro.Visible = True
        linkNordeste.Visible = True
        linkNorte.Visible = True
        linkSudeste.Visible = True
        linkSul.Visible = True

    End Sub

    Private Sub AjudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjudaToolStripMenuItem.Click

        Process.Start("file:///C:/Users/Fernando/Desktop/TCC%20-%20Site/index.html")

    End Sub

    Private Sub AjudaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AjudaToolStripMenuItem1.Click

        Process.Start("file:///C:/Users/Fernando/Desktop/TCC%20-%20Site/educaware.html")

    End Sub
End Class