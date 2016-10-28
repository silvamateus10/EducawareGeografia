Public Class PerguntasSul

    Private Sub InserirPerguntasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InserirPerguntasToolStripMenuItem.Click
        gpInserirQuestoes.Enabled = True
        gpAlterarQuestoes.Enabled = False

    End Sub

    Private Sub AlterarPerguntasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarPerguntasToolStripMenuItem.Click
        gpInserirQuestoes.Enabled = False
        gpAlterarQuestoes.Enabled = True

    End Sub

    Private Sub ExcluirPerguntasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirPerguntasToolStripMenuItem.Click
        ExcluirPerguntasSul.show()

    End Sub


    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim perg As New PerguntasClass
        Dim pergBanco As New PerguntasBanco
        Dim inseriu As Boolean

        perg.numPergunta = txtNumPergunta.Text
        perg.pergunta = txtPergunta.Text
        perg.respostaCerta = txtRespCerta.Text
        perg.alternativaA = txtAltA.Text
        perg.alternativaB = txtAltB.Text
        perg.alternativaC = txtAltC.Text
        perg.alternativaD = txtAltD.Text

        inseriu = pergBanco.InserirPerguntaSul(perg)

        If inseriu = True Then
            MessageBox.Show("Pergunta cadastrada com sucesso!")
        End If

        txtNumPergunta.Text = ""
        txtPergunta.Text = ""
        txtRespCerta.Text = ""
        txtAltA.Text = ""
        txtAltB.Text = ""
        txtAltC.Text = ""
        txtAltD.Text = ""
        txtNumPergunta.Focus()

    End Sub

    Private Sub btnOKalt_Click(sender As Object, e As EventArgs) Handles btnOKalt.Click

        If txtNumQuestãoAlt.Text = Nothing And Not IsNumeric(txtNumQuestãoAlt.Text) Then
            MsgBox("Digite o número da pergunta à ser alterada!", MsgBoxStyle.Information)

        Else


            Dim linhaselecionada As DataGridViewRow

            linhaselecionada = dgvPerguntasSul.CurrentRow

            Me.txtNumQuestãoAlt.Text = linhaselecionada.Cells(0).Value
            Me.txtQuestaoAlt.Text = linhaselecionada.Cells(1).Value
            Me.txtRespAlt.Text = linhaselecionada.Cells(2).Value
            Me.txtOPAalt.Text = linhaselecionada.Cells(3).Value
            Me.txtOPBalt.Text = linhaselecionada.Cells(4).Value
            Me.txtOPCalt.Text = linhaselecionada.Cells(5).Value
            Me.txtOPDalt.Text = linhaselecionada.Cells(6).Value

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim perg As New PerguntasClass
        Dim pergBanco As New PerguntasBanco
        Dim alterou As Boolean

        perg.numPergunta = txtNumQuestãoAlt.Text
        perg.pergunta = txtQuestaoAlt.Text
        perg.respostaCerta = txtRespAlt.Text
        perg.alternativaA = txtOPAalt.Text
        perg.alternativaB = txtOPBalt.Text
        perg.alternativaC = txtOPCalt.Text
        perg.alternativaD = txtOPDalt.Text

        alterou = pergBanco.alterarPerguntasSul(perg)

        If alterou = True Then
            MessageBox.Show("Pergunta alterada com sucesso!")
        End If

        txtNumQuestãoAlt.Text = ""
        txtQuestaoAlt.Text = ""
        txtRespAlt.Text = ""
        txtOPAalt.Text = ""
        txtOPBalt.Text = ""
        txtOPCalt.Text = ""
        txtOPDalt.Text = ""
        txtNumQuestãoAlt.Focus()

    End Sub

    Private Sub txtNumQuestãoAlt_TextChanged(sender As Object, e As EventArgs) Handles txtNumQuestãoAlt.TextChanged

        Dim pergBanco As New PerguntasBanco
        Dim dadosPergunta As New DataTable

        If txtNumQuestãoAlt.Text = Nothing Then
            Exit Sub
        End If

        dadosPergunta = pergBanco.localizarPorNumeroSul(txtNumQuestãoAlt.Text)
        dgvPerguntasSul.DataSource = dadosPergunta

    End Sub
End Class