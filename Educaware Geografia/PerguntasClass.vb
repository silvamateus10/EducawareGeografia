Imports System.Data.SqlClient


Public Class PerguntasClass

    Private _codRegiao As Integer
    Private _numPergunta As Integer
    Private _pergunta As String
    Private _respostaCerta As String
    Private _alternativaA As String
    Private _alternativaB As String
    Private _alternativaC As String
    Private _alternativaD As String


    Public Sub New()

    End Sub

    Public Property codRegiao As Integer
        Get
            Return _codRegiao

        End Get
        Set(value As Integer)
            _codRegiao = value

        End Set
    End Property

    Public Property numPergunta As Integer
        Get
            Return _numPergunta

        End Get
        Set(value As Integer)
            _numPergunta = value

        End Set
    End Property

    Public Property pergunta As String
        Get
            Return _pergunta

        End Get
        Set(value As String)
            _pergunta = value

        End Set
    End Property

    Public Property respostaCerta As String
        Get
            Return _respostaCerta

        End Get
        Set(value As String)
            _respostaCerta = value

        End Set
    End Property

    Public Property alternativaA As String
        Get
            Return _alternativaA

        End Get
        Set(value As String)
            _alternativaA = value

        End Set
    End Property

    Public Property alternativaB As String
        Get
            Return _alternativaB

        End Get
        Set(value As String)
            _alternativaB = value

        End Set
    End Property

    Public Property alternativaC As String
        Get
            Return _alternativaC

        End Get
        Set(value As String)
            _alternativaC = value

        End Set
    End Property

    Public Property alternativaD As String
        Get
            Return _alternativaD

        End Get
        Set(value As String)
            _alternativaD = value

        End Set
    End Property

End Class
