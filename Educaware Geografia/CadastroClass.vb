Public Class CadastroUsuario

    Private _CodigoAluno As String
    Private _NomeAluno As String
    Private _IdadeAluno As Integer
    Private _SerieAluno As String
    Private _SenhaAluno As String

    Public Sub New()

    End Sub

    Public Property NomeAluno As String
        Get
            Return _NomeAluno

        End Get
        Set(value As String)
            _NomeAluno = value

        End Set
    End Property

    Public Property IdadeAluno As Integer
        Get
            Return _IdadeAluno

        End Get

        Set(value As Integer)

            _IdadeAluno = value

        End Set
    End Property

    Public Property SerieAluno As String
        Get
            Return _SerieAluno

        End Get
        Set(value As String)
            _SerieAluno = value


        End Set
    End Property

    Public Property SenhaAluno As String
        Get
            Return _SenhaAluno

        End Get
        Set(value As String)
            _SenhaAluno = value

        End Set
    End Property

    Public Property CodigoAluno As Integer
        Get
            Return _CodigoAluno

        End Get
        Set(value As Integer)
            _CodigoAluno = value

        End Set
    End Property

End Class
