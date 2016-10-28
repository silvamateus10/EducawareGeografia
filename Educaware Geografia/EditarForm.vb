Imports System.Data.SqlClient


Public Class EditarForm

    Private Sub Limpar()

        txtPesq.ResetText()
        txtCod.ResetText()
        txtIdade.ResetText()
        txtNome.ResetText()
        txtSerie.ResetText()
        txtSenha.ResetText()
        txtSenha2.ResetText()
        txtPesq.Focus()

    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Close()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim usuario As New CadastroUsuario
        Dim casBanco As New CadastroBanco
        Dim Editou As Boolean

        If txtNome.Text = Nothing Then

            MsgBox("Digite um nome", MsgBoxStyle.Information)

        ElseIf txtIdade.Text = Nothing And Not IsNumeric(txtIdade.Text) Then

            MsgBox("Digite uma idade válida", MsgBoxStyle.Information)

        ElseIf txtSerie.Text = Nothing Then

            MsgBox("Digite uma série válida", MsgBoxStyle.Information)

            'MsgBox("Senha no mínimo 6 caractéres!", MsgBoxStyle.Information)

            'MsgBox("Senha no máximo 8 caracteres!", MsgBoxStyle.Information)

            '

        ElseIf txtSenha.Text <> txtSenha2.Text Then

            MsgBox("As senhas não correspondem!", MsgBoxStyle.Information)
            
        ElseIf txtSenha.TextLength > 8 Then
            MsgBox("Senha muito longa!" & vbCrLf & "Máximo 8 caracteres.", MsgBoxStyle.Information)

        ElseIf txtSenha.TextLength < 6 Then
            MsgBox("Senha muito curta!" & vbCrLf & "Mínimo 6 caracteres.", MsgBoxStyle.Information)

        Else


            usuario.CodigoAluno = txtCod.Text
            usuario.NomeAluno = txtNome.Text
            usuario.IdadeAluno = txtIdade.Text
            usuario.SerieAluno = txtSerie.Text

            usuario.SenhaAluno = txtSenha.Text

            Editou = casBanco.editarUsuario(usuario)

            If Editou = True Then
                MsgBox("Usuário cadastrado com êxito!", MsgBoxStyle.Information)

            End If

            txtIdade.ResetText()
            txtNome.ResetText()
            txtSerie.ResetText()
            txtSenha.ResetText()
            txtSenha2.ResetText()
            txtNome.Focus()

        End If

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click

        Limpar()
    End Sub

    Private Sub EditarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim c As New Conexao
        Dim con As New SqlConnection

        con = c.AbrirBanco

        If con.State = ConnectionState.Open Then
            MessageBox.Show("Conexão com o banco ativa!")
        Else

            MessageBox.Show("Conexão fechada por algum motivo!")

        End If

    End Sub

    Private Sub txtPesq_TextChanged(sender As Object, e As EventArgs) Handles txtPesq.TextChanged

        Dim casBanco As New CadastroBanco
        Dim dadosUsuario As DataTable

        If txtPesq.Text = Nothing Then

            Exit Sub

        End If

        dadosUsuario = casBanco.consultarParaEditar(txtPesq.Text)
        dgvConsultaEditar.DataSource = dadosUsuario


    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        If txtPesq.Text = Nothing Then

            MsgBox("Digite o nome do usuário", MsgBoxStyle.Information)
        Else

            Dim linhaSelecionada As DataGridViewRow

            linhaSelecionada = dgvConsultaEditar.CurrentRow

            txtCod.Text = linhaSelecionada.Cells(0).Value
            txtNome.Text = linhaSelecionada.Cells(1).Value
            txtSenha.Text = linhaSelecionada.Cells(2).Value
            txtIdade.Text = linhaSelecionada.Cells(3).Value
            txtSerie.Text = linhaSelecionada.Cells(4).Value
            txtSenha2.Text = linhaSelecionada.Cells(2).Value

        End If

    End Sub
End Class