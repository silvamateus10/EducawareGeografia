Public Class ExcluirForm

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If MessageBox.Show("Deseja realmente excluir?", _
                          "Exclusão", MessageBoxButtons.YesNo, _
                          MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


            'CÓDIGO DO BOTÃO ALTERAR
            Dim codigo As Integer = txtCod.Text
            Dim casBanco As New CadastroBanco
            Dim excluiu As Boolean

            'OS TRATAMENTOS DE CAMPOS (NUMERO, NÃO VAZIO, ETC)
            'SÃO FEITOS AQUI!

            excluiu = casBanco.excluirUsuario(codigo)

            If excluiu = True Then
                MessageBox.Show("Registro apagado!")
                txtCod.Text = ""
                txtPesq.ResetText()
                txtCod.ResetText()
                txtPesq.Focus()
                dgvExcluir.Refresh()

            End If

        End If

    End Sub

    Private Sub txtPesq_TextChanged(sender As Object, e As EventArgs) Handles txtPesq.TextChanged

        Dim casBanco As New CadastroBanco
        Dim dadosUsuario As DataTable

        If txtPesq.Text = Nothing Then

            Exit Sub

        End If

        dadosUsuario = casBanco.consultarParaEditar(txtPesq.Text)
        dgvExcluir.DataSource = dadosUsuario

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim linhaSelecionada As DataGridViewRow

        linhaSelecionada = dgvExcluir.CurrentRow()

        txtCod.Text = linhaSelecionada.Cells(0).Value

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class