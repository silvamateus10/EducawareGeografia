Imports System.Data.SqlClient


Public Class Conexao

    Dim strCon As String
    Dim con As SqlConnection

    Public Sub New()

        strCon = "Data Source = MATEUS-PC; Initial Catalog = EducawareGeografia; Integrated Security = True"

    End Sub

    Public Function AbrirBanco() As SqlConnection

        con = New SqlConnection(strCon)

        Try
            con.Open()

        Catch ex As Exception

            MessageBox.Show("Falha ao conectar o banco de dados!" _
                       & vbCrLf & ex.Message)

        End Try

        Return con

    End Function


End Class
