Imports System.Data.SqlClient

Public Class CadastroBanco

    Dim comando As SqlCommand
    Dim conexaoBanco As SqlConnection
    Dim dadosConexao As Conexao

    Public Function Cadastro(ByVal Cas As CadastroUsuario) As Boolean

        Dim Salvo As Boolean = False

        comando = New SqlCommand

        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "cadastrarUsuario"

        comando.Parameters.AddWithValue("@nomeUsuario", Cas.NomeAluno)
        comando.Parameters.AddWithValue("@senhaUsuario", Cas.SenhaAluno)
        comando.Parameters.AddWithValue("@idadeUsuario", Cas.IdadeAluno)
        comando.Parameters.AddWithValue("@serieUsuario", Cas.SerieAluno)


        dadosConexao = New Conexao()

        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco
        comando.Connection = conexaoBanco

        Try
            Dim regAfetados As Integer = comando.ExecuteNonQuery

            If regAfetados > 0 Then

                Salvo = True

            End If
        Catch ex As Exception

            MessageBox.Show("Falha ao inserir usuário!" _
                            & vbCrLf & ex.Message)

        Finally

            conexaoBanco.Close()

        End Try

        Return Salvo

    End Function

    Public Function consultarParaEditar(nome As String) As DataTable

        Dim dadosUsuario As New DataTable
        Dim adaptUsuario As SqlDataAdapter

        dadosConexao = New Conexao
        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco

        adaptUsuario = New SqlDataAdapter("consultarEditar", conexaoBanco)
        adaptUsuario.SelectCommand.CommandType = CommandType.StoredProcedure

        adaptUsuario.SelectCommand.Parameters.AddWithValue("@nomeUsuario", nome)

        Try
            adaptUsuario.Fill(dadosUsuario)

        Catch ex As Exception
            MessageBox.Show("Falha ao localizar o usuário" & vbCrLf & ex.Message)

        Finally
            conexaoBanco.Close()

        End Try

        Return dadosUsuario

    End Function

    Public Function editarUsuario(usuario As CadastroUsuario) As Boolean

        Dim editou As Boolean = False

        comando = New SqlCommand

        comando.CommandType = CommandType.StoredProcedure

        comando.CommandText = "editarUsuario"

        comando.Parameters.AddWithValue("@codigo", usuario.CodigoAluno)
        comando.Parameters.AddWithValue("@nomeUsuario", usuario.NomeAluno)
        comando.Parameters.AddWithValue("@senhaUsuario", usuario.SenhaAluno)
        comando.Parameters.AddWithValue("@idadeUsuario", usuario.IdadeAluno)
        comando.Parameters.AddWithValue("@serieUsuario", usuario.SerieAluno)

        dadosConexao = New Conexao()

        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco
        comando.Connection = conexaoBanco

        Try
            Dim regAfetados As Integer = comando.ExecuteNonQuery

            If regAfetados > 0 Then
                editou = True

            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao editar dados do usuário!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()

        End Try

        Return editou

    End Function

    Public Function excluirUsuario(ByVal codigo As Integer) As Boolean

        Dim excluiu As Boolean = False

        comando = New SqlCommand

        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "excluirUsuario"

        comando.Parameters.AddWithValue("@codigo", codigo)

        dadosConexao = New Conexao

        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco
        comando.Connection = conexaoBanco

        Try
            Dim regAfetados As Integer = comando.ExecuteNonQuery

            If regAfetados > 0 Then
                excluiu = True

            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao excluir dados do usuário!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()

        End Try

        Return excluiu

    End Function

    Public Function loginDoJogador(ByVal nome As String, senha As String) As DataTable

        Dim dadosJogador As New DataTable
        Dim adaptJogador As New SqlDataAdapter

        dadosConexao = New Conexao
        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco()

        adaptJogador = New SqlDataAdapter("loginDoJogador", conexaoBanco)
        adaptJogador.SelectCommand.CommandType = CommandType.StoredProcedure

        adaptJogador.SelectCommand.Parameters.AddWithValue("@login", nome)
        adaptJogador.SelectCommand.Parameters.AddWithValue("@senha", senha)

        Try
            adaptJogador.Fill(dadosJogador)

        Catch ex As Exception


        Finally
            conexaoBanco.Close()

        End Try

        Return dadosJogador

    End Function

End Class
