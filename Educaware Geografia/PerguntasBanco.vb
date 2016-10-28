Imports System.Data.SqlClient

Public Class PerguntasBanco

    Dim comando As SqlCommand
    Dim conexaoBanco As SqlConnection
    Dim dadosConexao As Conexao


    '-----------------------------------C E N T R O --- O E S T E ------------------------------------------------------------------


    Public Function InserirPerguntaCentro(ByVal perg As PerguntasClass) As Boolean

        Dim Inseriu As Boolean = False

        comando = New SqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "inserirPerguntasCentro"

        comando.Parameters.AddWithValue("@numPergunta", perg.numPergunta)
        comando.Parameters.AddWithValue("@pergunta", perg.pergunta)
        comando.Parameters.AddWithValue("@respostaCerta", perg.respostaCerta)
        comando.Parameters.AddWithValue("@alternativaA", perg.alternativaA)
        comando.Parameters.AddWithValue("@alternativaB", perg.alternativaB)
        comando.Parameters.AddWithValue("@alternativaC", perg.alternativaC)
        comando.Parameters.AddWithValue("@alternativaD", perg.alternativaD)

        dadosConexao = New Conexao()

        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco
        comando.Connection = conexaoBanco

        Try

            Dim pergInseridas As Integer = comando.ExecuteNonQuery

            If pergInseridas > 0 Then

                Inseriu = True

            End If

        Catch ex As Exception

            MessageBox.Show("Falha ao inserir a pergunta de Região Centro-Oeste!" _
                            & vbCrLf & ex.Message)


        Finally
            conexaoBanco.Close()

        End Try

        Return Inseriu

    End Function

    Public Function alterarPerguntasCentro(perg As PerguntasClass) As Boolean

        Dim alterou As Boolean = False

        comando = New SqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "alterarPerguntasCentro"

        comando.Parameters.AddWithValue("@numPergunta", perg.numPergunta)
        comando.Parameters.AddWithValue("@pergunta", perg.pergunta)
        comando.Parameters.AddWithValue("@respostaCerta", perg.respostaCerta)
        comando.Parameters.AddWithValue("@alternativaA", perg.alternativaA)
        comando.Parameters.AddWithValue("@alternativaB", perg.alternativaB)
        comando.Parameters.AddWithValue("@alternativaC", perg.alternativaC)
        comando.Parameters.AddWithValue("@alternativaD", perg.alternativaD)

        dadosConexao = New Conexao()

        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco
        comando.Connection = conexaoBanco

        Try
            Dim regAfetados As Integer = comando.ExecuteNonQuery

            If regAfetados > 0 Then
                alterou = True

            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao alterar a pergunta de Região Centro-Oeste!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()

        End Try

        Return alterou

    End Function

    Public Function localizarPorNumero(numero As Integer) As DataTable

        Dim dadosPergunta As New DataTable
        Dim adaptPergunta As SqlDataAdapter

        dadosConexao = New Conexao
        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco

        adaptPergunta = New SqlDataAdapter("perguntaPorNumeroCentro", conexaoBanco)
        adaptPergunta.SelectCommand.CommandType = CommandType.StoredProcedure

        adaptPergunta.SelectCommand.Parameters.AddWithValue("@numPergunta", numero)

        Try
            adaptPergunta.Fill(dadosPergunta)

        Catch ex As Exception
            MessageBox.Show("Falha ao localizar a pergunta!" _
                            & vbCrLf & ex.Message)

        Finally
            conexaoBanco.Close()

        End Try

        Return dadosPergunta

    End Function


    Public Function chamarPerguntasCentro(Pergunta As Integer) As DataTable

        'Dim Q As New Quiz
        Dim dadosPergunta As New DataTable
        Dim adaptPergunta As SqlDataAdapter
        'Dim rdm As New Random

        dadosConexao = New Conexao
        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco

        adaptPergunta = New SqlDataAdapter("trazerQuestaoCentro", conexaoBanco)
        adaptPergunta.SelectCommand.CommandType = CommandType.StoredProcedure

        adaptPergunta.SelectCommand.Parameters.AddWithValue("@numPergunta", Pergunta)

        Try
            adaptPergunta.Fill(dadosPergunta)

        Catch ex As Exception
            MessageBox.Show("Falha ao trazer a questão!" _
                            & vbCrLf & ex.Message)

        Finally
            conexaoBanco.Close()

        End Try

        Return dadosPergunta

        'rdm.Next(14 + 1)


        'adaptPergunta = New SqlDataAdapter("trazerQuestaoCentro", Q.txtQuestao.Text)

    End Function

    Public Function trazerAlternativaCentro(numero As Integer) As DataTable

        'Dim Q As New Quiz
        Dim dadosAlternativa As New DataTable
        Dim adaptAlternativa As SqlDataAdapter
        'Dim rdm As New Random

        dadosConexao = New Conexao
        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco

        adaptAlternativa = New SqlDataAdapter("trazerAlternativaCentro", conexaoBanco)
        adaptAlternativa.SelectCommand.CommandType = CommandType.StoredProcedure

        adaptAlternativa.SelectCommand.Parameters.AddWithValue("@numPergunta", numero)

        Try
            adaptAlternativa.Fill(dadosAlternativa)

        Catch ex As Exception
            MessageBox.Show("Falha ao trazer a questão!" _
                            & vbCrLf & ex.Message)

        Finally
            conexaoBanco.Close()

        End Try

        Return dadosAlternativa

        'rdm.Next(14 + 1)


        'adaptPergunta = New SqlDataAdapter("trazerQuestaoCentro", Q.txtQuestao.Text)

    End Function


    Public Function excluirPerguntaCentro(ByVal numero As Integer) As Boolean

        Dim excluiu As Boolean = False

        comando = New SqlCommand

        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "excluirPerguntaCentro"

        comando.Parameters.AddWithValue("@numPergunta", numero)

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
            MessageBox.Show("Falha ao apagar dados da Pergunta!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()

        End Try

        Return excluiu

    End Function




        '---------------------------------------------------- N O R D E S T E ------------------------------------------------------------------



    Public Function InserirPerguntaNordeste(ByVal perg As PerguntasClass) As Boolean
        Dim Inseriu As Boolean = False

        comando = New SqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "inserirPerguntasNordeste"

        comando.Parameters.AddWithValue("@numPergunta", perg.numPergunta)
        comando.Parameters.AddWithValue("@pergunta", perg.pergunta)
        comando.Parameters.AddWithValue("@respostaCerta", perg.respostaCerta)
        comando.Parameters.AddWithValue("@alternativaA", perg.alternativaA)
        comando.Parameters.AddWithValue("@alternativaB", perg.alternativaB)
        comando.Parameters.AddWithValue("@alternativaC", perg.alternativaC)
        comando.Parameters.AddWithValue("@alternativaD", perg.alternativaD)

        dadosConexao = New Conexao()

        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco
        comando.Connection = conexaoBanco

        Try
            Dim pergInseridas As Integer = comando.ExecuteNonQuery

            If pergInseridas > 0 Then
                Inseriu = True
            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao inserir a pergunta de Região Nordeste!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return Inseriu

    End Function

    Public Function alterarPerguntasNordeste(perg As PerguntasClass) As Boolean
        Dim alterou As Boolean = False

        comando = New SqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "alterarPerguntasNordeste"

        comando.Parameters.AddWithValue("@numPergunta", perg.numPergunta)
        comando.Parameters.AddWithValue("@pergunta", perg.pergunta)
        comando.Parameters.AddWithValue("@respostaCerta", perg.respostaCerta)
        comando.Parameters.AddWithValue("@alternativaA", perg.alternativaA)
        comando.Parameters.AddWithValue("@alternativaB", perg.alternativaB)
        comando.Parameters.AddWithValue("@alternativaC", perg.alternativaC)
        comando.Parameters.AddWithValue("@alternativaD", perg.alternativaD)

        dadosConexao = New Conexao()

        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco
        comando.Connection = conexaoBanco

        Try
            Dim regAfetados As Integer = comando.ExecuteNonQuery

            If regAfetados > 0 Then
                alterou = True
            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao alterar a pergunta de Região Nordeste!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return alterou

    End Function

    Public Function localizarPorNumeroNordeste(numero As Integer) As DataTable

        Dim dadosPergunta As New DataTable
        Dim adaptPergunta As SqlDataAdapter

        dadosConexao = New Conexao
        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco

        adaptPergunta = New SqlDataAdapter("perguntaPorNumeroNordeste", conexaoBanco)
        adaptPergunta.SelectCommand.CommandType = CommandType.StoredProcedure

        adaptPergunta.SelectCommand.Parameters.AddWithValue("@numPergunta", numero)

        Try
            adaptPergunta.Fill(dadosPergunta)
        Catch ex As Exception
            MessageBox.Show("Falha ao localizar a pergunta!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return dadosPergunta

    End Function

    Public Function chamarPerguntasNordeste(Pergunta As Integer) As DataTable

        Dim dadosPergunta As New DataTable
        Dim adaptPergunta As SqlDataAdapter

        dadosConexao = New Conexao
        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco

        adaptPergunta = New SqlDataAdapter("trazerQuestaoNordeste", conexaoBanco)
        adaptPergunta.SelectCommand.CommandType = CommandType.StoredProcedure

        adaptPergunta.SelectCommand.Parameters.AddWithValue("@numPergunta", Pergunta)

        Try
            adaptPergunta.Fill(dadosPergunta)
        Catch ex As Exception
            MessageBox.Show("Falha ao trazer a questão!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return dadosPergunta

    End Function

    Public Function trazerAlternativaNordeste(numero As Integer) As DataTable
        Dim dadosAlternativa As New DataTable
        Dim adaptAlternativa As SqlDataAdapter

        dadosConexao = New Conexao
        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco

        adaptAlternativa = New SqlDataAdapter("trazerAlternativaNordeste", conexaoBanco)
        adaptAlternativa.SelectCommand.CommandType = CommandType.StoredProcedure

        adaptAlternativa.SelectCommand.Parameters.AddWithValue("@numPergunta", numero)

        Try
            adaptAlternativa.Fill(dadosAlternativa)
        Catch ex As Exception
            MessageBox.Show("Falha ao trazer a questão!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return dadosAlternativa

    End Function


    Public Function excluirPerguntaNordeste(ByVal numero As Integer) As Boolean
        Dim excluiu As Boolean = False

        comando = New SqlCommand

        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "excluirPerguntaNordeste"

        comando.Parameters.AddWithValue("@numPergunta", numero)

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
            MessageBox.Show("Falha ao apagar dados da Pergunta!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return excluiu

    End Function


    '-------------------------------------------- N O R T E ------------------------------------------------------------------


    Public Function InserirPerguntaNorte(ByVal perg As PerguntasClass) As Boolean

        Dim Inseriu As Boolean = False

        comando = New SqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "inserirPerguntasNorte"

        comando.Parameters.AddWithValue("@numPergunta", perg.numPergunta)
        comando.Parameters.AddWithValue("@pergunta", perg.pergunta)
        comando.Parameters.AddWithValue("@respostaCerta", perg.respostaCerta)
        comando.Parameters.AddWithValue("@alternativaA", perg.alternativaA)
        comando.Parameters.AddWithValue("@alternativaB", perg.alternativaB)
        comando.Parameters.AddWithValue("@alternativaC", perg.alternativaC)
        comando.Parameters.AddWithValue("@alternativaD", perg.alternativaD)

        dadosConexao = New Conexao()

        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco
        comando.Connection = conexaoBanco

        Try
            Dim pergInseridas As Integer = comando.ExecuteNonQuery

            If pergInseridas > 0 Then
                Inseriu = True
            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao inserir a pergunta de Região Norte!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return Inseriu

    End Function

    Public Function alterarPerguntasNorte(perg As PerguntasClass) As Boolean
        Dim alterou As Boolean = False

        comando = New SqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "alterarPerguntasNorte"

        comando.Parameters.AddWithValue("@numPergunta", perg.numPergunta)
        comando.Parameters.AddWithValue("@pergunta", perg.pergunta)
        comando.Parameters.AddWithValue("@respostaCerta", perg.respostaCerta)
        comando.Parameters.AddWithValue("@alternativaA", perg.alternativaA)
        comando.Parameters.AddWithValue("@alternativaB", perg.alternativaB)
        comando.Parameters.AddWithValue("@alternativaC", perg.alternativaC)
        comando.Parameters.AddWithValue("@alternativaD", perg.alternativaD)

        dadosConexao = New Conexao()

        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco
        comando.Connection = conexaoBanco

        Try
            Dim regAfetados As Integer = comando.ExecuteNonQuery

            If regAfetados > 0 Then
                alterou = True
            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao alterar a pergunta de Região Norte!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return alterou

    End Function

    Public Function localizarPorNumeroNorte(numero As Integer) As DataTable

        Dim dadosPergunta As New DataTable
        Dim adaptPergunta As SqlDataAdapter

        dadosConexao = New Conexao
        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco

        adaptPergunta = New SqlDataAdapter("perguntaPorNumeroNorte", conexaoBanco)
        adaptPergunta.SelectCommand.CommandType = CommandType.StoredProcedure

        adaptPergunta.SelectCommand.Parameters.AddWithValue("@numPergunta", numero)

        Try
            adaptPergunta.Fill(dadosPergunta)
        Catch ex As Exception
            MessageBox.Show("Falha ao localizar a pergunta!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return dadosPergunta

    End Function

    Public Function chamarPerguntasNorte(Pergunta As Integer) As DataTable

        Dim dadosPergunta As New DataTable
        Dim adaptPergunta As SqlDataAdapter

        dadosConexao = New Conexao
        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco

        adaptPergunta = New SqlDataAdapter("trazerQuestaoNorte", conexaoBanco)
        adaptPergunta.SelectCommand.CommandType = CommandType.StoredProcedure

        adaptPergunta.SelectCommand.Parameters.AddWithValue("@numPergunta", Pergunta)

        Try
            adaptPergunta.Fill(dadosPergunta)
        Catch ex As Exception
            MessageBox.Show("Falha ao trazer a questão!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return dadosPergunta

    End Function

    Public Function trazerAlternativaNorte(numero As Integer) As DataTable
        Dim dadosAlternativa As New DataTable
        Dim adaptAlternativa As SqlDataAdapter

        dadosConexao = New Conexao
        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco

        adaptAlternativa = New SqlDataAdapter("trazerAlternativaNorte", conexaoBanco)
        adaptAlternativa.SelectCommand.CommandType = CommandType.StoredProcedure

        adaptAlternativa.SelectCommand.Parameters.AddWithValue("@numPergunta", numero)

        Try
            adaptAlternativa.Fill(dadosAlternativa)
        Catch ex As Exception
            MessageBox.Show("Falha ao trazer a questão!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return dadosAlternativa

    End Function


    Public Function excluirPerguntaNorte(ByVal numero As Integer) As Boolean
        Dim excluiu As Boolean = False

        comando = New SqlCommand

        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "excluirPerguntaNorte"

        comando.Parameters.AddWithValue("@numPergunta", numero)

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
            MessageBox.Show("Falha ao apagar dados da Pergunta!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return excluiu

    End Function

    '-------------------------------------------- S U L ------------------------------------------------------------------

    Public Function InserirPerguntaSul(ByVal perg As PerguntasClass) As Boolean
        Dim Inseriu As Boolean = False

        comando = New SqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "inserirPerguntasSul"

        comando.Parameters.AddWithValue("@numPergunta", perg.numPergunta)
        comando.Parameters.AddWithValue("@pergunta", perg.pergunta)
        comando.Parameters.AddWithValue("@respostaCerta", perg.respostaCerta)
        comando.Parameters.AddWithValue("@alternativaA", perg.alternativaA)
        comando.Parameters.AddWithValue("@alternativaB", perg.alternativaB)
        comando.Parameters.AddWithValue("@alternativaC", perg.alternativaC)
        comando.Parameters.AddWithValue("@alternativaD", perg.alternativaD)

        dadosConexao = New Conexao()

        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco
        comando.Connection = conexaoBanco

        Try
            Dim pergInseridas As Integer = comando.ExecuteNonQuery

            If pergInseridas > 0 Then
                Inseriu = True
            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao inserir a pergunta de Região Sul!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return Inseriu

    End Function

    Public Function alterarPerguntasSul(perg As PerguntasClass) As Boolean
        Dim alterou As Boolean = False

        comando = New SqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "alterarPerguntasSul"

        comando.Parameters.AddWithValue("@numPergunta", perg.numPergunta)
        comando.Parameters.AddWithValue("@pergunta", perg.pergunta)
        comando.Parameters.AddWithValue("@respostaCerta", perg.respostaCerta)
        comando.Parameters.AddWithValue("@alternativaA", perg.alternativaA)
        comando.Parameters.AddWithValue("@alternativaB", perg.alternativaB)
        comando.Parameters.AddWithValue("@alternativaC", perg.alternativaC)
        comando.Parameters.AddWithValue("@alternativaD", perg.alternativaD)

        dadosConexao = New Conexao()

        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco
        comando.Connection = conexaoBanco

        Try
            Dim regAfetados As Integer = comando.ExecuteNonQuery

            If regAfetados > 0 Then
                alterou = True
            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao alterar a pergunta de Região Sul!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return alterou

    End Function

    Public Function localizarPorNumeroSul(numero As Integer) As DataTable

        Dim dadosPergunta As New DataTable
        Dim adaptPergunta As SqlDataAdapter

        dadosConexao = New Conexao
        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco

        adaptPergunta = New SqlDataAdapter("perguntaPorNumeroSul", conexaoBanco)
        adaptPergunta.SelectCommand.CommandType = CommandType.StoredProcedure

        adaptPergunta.SelectCommand.Parameters.AddWithValue("@numPergunta", numero)

        Try
            adaptPergunta.Fill(dadosPergunta)
        Catch ex As Exception
            MessageBox.Show("Falha ao localizar a pergunta!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return dadosPergunta

    End Function

    Public Function chamarPerguntasSul(Pergunta As Integer) As DataTable

        Dim dadosPergunta As New DataTable
        Dim adaptPergunta As SqlDataAdapter

        dadosConexao = New Conexao
        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco

        adaptPergunta = New SqlDataAdapter("trazerQuestaoSul", conexaoBanco)
        adaptPergunta.SelectCommand.CommandType = CommandType.StoredProcedure

        adaptPergunta.SelectCommand.Parameters.AddWithValue("@numPergunta", Pergunta)

        Try
            adaptPergunta.Fill(dadosPergunta)
        Catch ex As Exception
            MessageBox.Show("Falha ao trazer a questão!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return dadosPergunta

    End Function

    Public Function trazerAlternativaSul(numero As Integer) As DataTable
        Dim dadosAlternativa As New DataTable
        Dim adaptAlternativa As SqlDataAdapter

        dadosConexao = New Conexao
        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco

        adaptAlternativa = New SqlDataAdapter("trazerAlternativaSul", conexaoBanco)
        adaptAlternativa.SelectCommand.CommandType = CommandType.StoredProcedure

        adaptAlternativa.SelectCommand.Parameters.AddWithValue("@numPergunta", numero)

        Try
            adaptAlternativa.Fill(dadosAlternativa)
        Catch ex As Exception
            MessageBox.Show("Falha ao trazer a questão!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return dadosAlternativa

    End Function


    Public Function excluirPerguntaSul(ByVal numero As Integer) As Boolean
        Dim excluiu As Boolean = False

        comando = New SqlCommand

        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "excluirPerguntaSul"

        comando.Parameters.AddWithValue("@numPergunta", numero)

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
            MessageBox.Show("Falha ao apagar dados da Pergunta!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return excluiu

    End Function

    '------------------------------------------ S U D E S T E ------------------------------------------------------------------

    Public Function InserirPerguntaSudeste(ByVal perg As PerguntasClass) As Boolean
        Dim Inseriu As Boolean = False

        comando = New SqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "inserirPerguntasSudeste"

        comando.Parameters.AddWithValue("@numPergunta", perg.numPergunta)
        comando.Parameters.AddWithValue("@pergunta", perg.pergunta)
        comando.Parameters.AddWithValue("@respostaCerta", perg.respostaCerta)
        comando.Parameters.AddWithValue("@alternativaA", perg.alternativaA)
        comando.Parameters.AddWithValue("@alternativaB", perg.alternativaB)
        comando.Parameters.AddWithValue("@alternativaC", perg.alternativaC)
        comando.Parameters.AddWithValue("@alternativaD", perg.alternativaD)

        dadosConexao = New Conexao()

        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco
        comando.Connection = conexaoBanco

        Try
            Dim pergInseridas As Integer = comando.ExecuteNonQuery

            If pergInseridas > 0 Then
                Inseriu = True
            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao inserir a pergunta de Região Sudeste!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return Inseriu

    End Function

    Public Function alterarPerguntasSudeste(perg As PerguntasClass) As Boolean
        Dim alterou As Boolean = False

        comando = New SqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "alterarPerguntasSudeste"

        comando.Parameters.AddWithValue("@numPergunta", perg.numPergunta)
        comando.Parameters.AddWithValue("@pergunta", perg.pergunta)
        comando.Parameters.AddWithValue("@respostaCerta", perg.respostaCerta)
        comando.Parameters.AddWithValue("@alternativaA", perg.alternativaA)
        comando.Parameters.AddWithValue("@alternativaB", perg.alternativaB)
        comando.Parameters.AddWithValue("@alternativaC", perg.alternativaC)
        comando.Parameters.AddWithValue("@alternativaD", perg.alternativaD)

        dadosConexao = New Conexao()

        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco
        comando.Connection = conexaoBanco

        Try
            Dim regAfetados As Integer = comando.ExecuteNonQuery

            If regAfetados > 0 Then
                alterou = True
            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao alterar a pergunta de Região Sudeste!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return alterou

    End Function

    Public Function localizarPorNumeroSudeste(numero As Integer) As DataTable
        Dim dadosPergunta As New DataTable
        Dim adaptPergunta As SqlDataAdapter

        dadosConexao = New Conexao
        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco

        adaptPergunta = New SqlDataAdapter("perguntaPorNumeroSudeste", conexaoBanco)
        adaptPergunta.SelectCommand.CommandType = CommandType.StoredProcedure

        adaptPergunta.SelectCommand.Parameters.AddWithValue("@numPergunta", numero)

        Try
            adaptPergunta.Fill(dadosPergunta)
        Catch ex As Exception
            MessageBox.Show("Falha ao localizar a pergunta!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return dadosPergunta

    End Function

    Public Function chamarPerguntasSudeste(Pergunta As Integer) As DataTable

        Dim dadosPergunta As New DataTable
        Dim adaptPergunta As SqlDataAdapter

        dadosConexao = New Conexao
        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco

        adaptPergunta = New SqlDataAdapter("trazerQuestaoSudeste", conexaoBanco)
        adaptPergunta.SelectCommand.CommandType = CommandType.StoredProcedure

        adaptPergunta.SelectCommand.Parameters.AddWithValue("@numPergunta", Pergunta)

        Try
            adaptPergunta.Fill(dadosPergunta)
        Catch ex As Exception
            MessageBox.Show("Falha ao trazer a questão!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return dadosPergunta

    End Function

    Public Function trazerAlternativaSudeste(numero As Integer) As DataTable
        Dim dadosAlternativa As New DataTable
        Dim adaptAlternativa As SqlDataAdapter

        dadosConexao = New Conexao
        conexaoBanco = New SqlConnection
        conexaoBanco = dadosConexao.AbrirBanco

        adaptAlternativa = New SqlDataAdapter("trazerAlternativaSudeste", conexaoBanco)
        adaptAlternativa.SelectCommand.CommandType = CommandType.StoredProcedure

        adaptAlternativa.SelectCommand.Parameters.AddWithValue("@numPergunta", numero)

        Try
            adaptAlternativa.Fill(dadosAlternativa)
        Catch ex As Exception
            MessageBox.Show("Falha ao trazer a questão!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return dadosAlternativa

    End Function

    Public Function excluirPerguntaSudeste(ByVal numero As Integer) As Boolean
        Dim excluiu As Boolean = False

        comando = New SqlCommand

        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "excluirPerguntaSudeste"

        comando.Parameters.AddWithValue("@numPergunta", numero)

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
            MessageBox.Show("Falha ao apagar dados da Pergunta!" _
                            & vbCrLf & ex.Message)
        Finally
            conexaoBanco.Close()
        End Try

        Return excluiu

    End Function


End Class


