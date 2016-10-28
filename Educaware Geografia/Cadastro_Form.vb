Imports System.Data.SqlClient

Public Class Cadastro_Form

    Public Sub CadastrarJogador(N As LoginForm1, S As LoginForm1)

        N.txtNomeJog = txtNome
        S.txtSenhaJog = txtSenha

    End Sub

    'SUB ROTINA PARA O BOTÃO LIMPAR NO FORMULÁRIO CADASTRO

    Private Sub Limpar()

        txtIdade.ResetText()
        txtNome.ResetText()
        txtSerie.ResetText()
        txtSenha.ResetText()
        txtSenha2.ResetText()
        txtNome.Focus()

    End Sub

    'ACÃO DA SUB ROTINA NO BOTÃO LIMPAR NO FORMULÁRIO CADASTRO
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click

        Limpar()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim Usuario As New CadastroUsuario
        Dim CasBanco As New CadastroBanco
        Dim Salvo As Boolean


        If txtNome.Text = Nothing Then

            MsgBox("Digite um nome", MsgBoxStyle.Information)

        ElseIf txtIdade.Text = Nothing And Not IsNumeric(txtIdade.Text) Then

            MsgBox("Digite uma idade válida", MsgBoxStyle.Information)

        ElseIf txtSerie.Text = Nothing Then

            MsgBox("Digite uma série válida", MsgBoxStyle.Information)

        

        ElseIf txtSenha.TextLength < 6 And txtSenha2.TextLength < 6 Then

            MsgBox("Senha no mínimo 6 caractéres!", MsgBoxStyle.Information)

        Else

            If txtSenha.TextLength > 8 And txtSenha2.TextLength > 8 Then

                MsgBox("Senha no máximo 8 caracteres!", MsgBoxStyle.Information)

            Else

                If txtSenha.Text <> txtSenha2.Text Then
                    MsgBox("As senhas não correspondem!", MsgBoxStyle.Information)

                Else


                    Usuario.NomeAluno = txtNome.Text
                    Usuario.SenhaAluno = txtSenha.Text
                    Usuario.IdadeAluno = txtIdade.Text
                    Usuario.SerieAluno = txtSerie.Text
                    Usuario.SenhaAluno = txtSenha.Text
                    Salvo = CasBanco.Cadastro(Usuario)

                    If Salvo = True Then

                        MsgBox("Usuário cadastrado com êxito!", MsgBoxStyle.Information)

                    End If

                    txtIdade.ResetText()
                    txtNome.ResetText()
                    txtSerie.ResetText()
                    txtSenha.ResetText()
                    txtSenha2.ResetText()
                    txtNome.Focus()


                End If

            End If

        End If


    End Sub

    Private Sub Cadastro_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNome.Focus()

    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click

        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim c As New Conexao
        Dim con As New SqlConnection

        con = c.AbrirBanco

        If con.State = ConnectionState.Open Then
            MessageBox.Show("Conexão ativa!")
        Else

            MessageBox.Show("Conexão fechada por algum motivo!")

        End If

    End Sub

    Private Sub GroupDados_Enter(sender As Object, e As EventArgs) Handles GroupDados.Enter

    End Sub
End Class