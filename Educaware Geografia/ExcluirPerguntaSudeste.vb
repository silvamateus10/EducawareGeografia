Public Class ExcluirPerguntasSudeste

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If txtNumQuestExc.Text = Nothing Then

            MsgBox("Digite o número da pergunta à ser excluída!", MsgBoxStyle.Information)

        Else

            If MessageBox.Show("Deseja realmente excluir?", _
                               "Excluir Pergunta", MessageBoxButtons.YesNo, _
                               MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                'CÓDIGO DO BOTÃO ALTERAR
                Dim numero As Integer = txtNumQuestExc.Text
                Dim pergBanco As New PerguntasBanco
                Dim apagou As Boolean

                'OS TRATAMENTOS DE CAMPOS (NUMERO, NÃO VAZIO, ETC)
                'SÃO FEITOS AQUI!

                apagou = pergBanco.excluirPerguntaSudeste(numero)

                If apagou = True Then
                    MessageBox.Show("Registro apagado!")
                    txtNumQuestExc.Text = ""
                    txtNumQuestExc.Focus()

                End If
            End If
        End If


    End Sub

    Private Sub txtNumQuestExc_TextChanged(sender As Object, e As EventArgs) Handles txtNumQuestExc.TextChanged

        Dim pergBanco As New PerguntasBanco
        Dim dadosPergunta As New DataTable

        If txtNumQuestExc.Text = Nothing Then
            Exit Sub
        End If

        dadosPergunta = pergBanco.localizarPorNumeroSudeste(txtNumQuestExc.Text)
        dgvExcluirSudeste.DataSource = dadosPergunta

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class