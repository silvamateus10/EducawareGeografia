Public Class MemoriaNorte

    'Vetor que armazena os números das imagens sorteadas:
    Dim Imagens(15) As Integer
    'Variável para controlar o indíce do vetor:
    Dim IndImg As Integer
    'Vetor para armazenar os 16 PictureBox
    Dim PBs(15) As PictureBox
    'Variável do tipo randômica (gera número aleatórios)
    Dim Rand As New Random
    'Variável para armazenar temporariamente o número sorteado
    Dim NumSorteio As Integer
    'Variável para verificar se o número sorteado já existe no vetor
    Dim Existe As Boolean
    Dim ImgAtual As Integer
    Dim PbAtual As PictureBox
    Dim PrimeiraImg As Boolean = True
    Dim UltPb As PictureBox
    Dim UltImg As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PBs(0) = pb1
        PBs(1) = pb2
        PBs(2) = pb3
        PBs(3) = pb4
        PBs(4) = pb5
        PBs(5) = pb6
        PBs(6) = pb7
        PBs(7) = pb8
        PBs(8) = pb9
        PBs(9) = pb10
        PBs(10) = pb11
        PBs(11) = pb12
        PBs(12) = pb13
        PBs(13) = pb14
        PBs(14) = pb15
        PBs(15) = pb16
        IndImg = 0
        While IndImg < 16
            'Gera um número aleatório a partir do intervalo predefinido
            NumSorteio = Rand.Next(1, 17)
            'Verifica se o número já está no vetor
            For i = 0 To IndImg Step 1
                If Imagens(i) = NumSorteio Then
                    Existe = True
                    Exit For
                End If
                Existe = False
            Next
            'Se número ainda não saiu, adiciona ao vetor
            If Existe = False Then
                Imagens(IndImg) = NumSorteio
                IndImg += 1
            End If
        End While
        'teste:
        'preenche todos os pictures com as imagens do vetor
        For i = 0 To 15 Step 1
            'PBs(i).ImageLocation = "Imagens\" & Imagens(i) & ".png"
            PBs(i).ImageLocation = "Norte\norte.jpg"
            PBs(i).Enabled = True
        Next
        'ajusta o tempo do intervalo do timer
        Timer1.Interval = 500   '<< Meio Segundo'
        'deixa o timer desabilitado
        Timer1.Enabled = False
        txt_pontos.Text = 0
        PrimeiraImg = True
    End Sub
    Private Sub pb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1.Click
        PbAtual = pb1
        ImgAtual = Imagens(0)
        PreSelecionaImagem()
    End Sub
    Private Sub pb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb2.Click
        PbAtual = pb2
        ImgAtual = Imagens(1)
        PreSelecionaImagem()
    End Sub
    Private Sub pb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb3.Click
        PbAtual = pb3
        ImgAtual = Imagens(2)
        PreSelecionaImagem()
    End Sub
    Private Sub pb4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb4.Click
        PbAtual = pb4
        ImgAtual = Imagens(3)
        PreSelecionaImagem()
    End Sub
    Private Sub pb5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb5.Click
        PbAtual = pb5
        ImgAtual = Imagens(4)
        PreSelecionaImagem()
    End Sub
    Private Sub pb6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb6.Click
        PbAtual = pb6
        ImgAtual = Imagens(5)
        PreSelecionaImagem()
    End Sub
    Private Sub pb7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb7.Click
        PbAtual = pb7
        ImgAtual = Imagens(6)
        PreSelecionaImagem()
    End Sub
    Private Sub pb8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb8.Click
        PbAtual = pb8
        ImgAtual = Imagens(7)
        PreSelecionaImagem()
    End Sub
    Private Sub pb9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb9.Click
        PbAtual = pb9
        ImgAtual = Imagens(8)
        PreSelecionaImagem()
    End Sub
    Private Sub pb10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb10.Click
        PbAtual = pb10
        ImgAtual = Imagens(9)
        PreSelecionaImagem()
    End Sub
    Private Sub pb11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb11.Click
        PbAtual = pb11
        ImgAtual = Imagens(10)
        PreSelecionaImagem()
    End Sub
    Private Sub pb12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb12.Click
        PbAtual = pb12
        ImgAtual = Imagens(11)
        PreSelecionaImagem()
    End Sub
    Private Sub pb13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb13.Click
        PbAtual = pb13
        ImgAtual = Imagens(12)
        PreSelecionaImagem()
    End Sub
    Private Sub pb14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb14.Click
        PbAtual = pb14
        ImgAtual = Imagens(13)
        PreSelecionaImagem()
    End Sub
    Private Sub pb15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb15.Click
        PbAtual = pb15
        ImgAtual = Imagens(14)
        PreSelecionaImagem()
    End Sub
    Private Sub pb16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb16.Click
        PbAtual = pb16
        ImgAtual = Imagens(15)
        PreSelecionaImagem()
    End Sub
    Private Sub PreSelecionaImagem()
        'exibe e desabilita a imagem selecionada:
        PbAtual.ImageLocation = "Norte\" & ImgAtual & ".jpg"
        PbAtual.Enabled = False
        If PrimeiraImg = True Then
            'se for a primeira imagem selecionada, ajusta as variaveis
            PrimeiraImg = False
            UltImg = ImgAtual
            UltPb = PbAtual
        Else
            'Se for a segunda imagem selecionada:
            PrimeiraImg = True
            Timer1.Enabled = True
            Me.Enabled = False
        End If
    End Sub
    Private Function VericaAcerto() As Boolean
        'Verifica se é par ou impar
        If ImgAtual Mod 2 = 1 Then
            'É impar
            If UltImg = ImgAtual + 1 Then
                'Acertou
                txt_pontos.Text += 10
                Return True
            End If

        Else
            'É par
            If UltImg = ImgAtual - 1 Then
                'Acertou
                txt_pontos.Text += 10
                Return True
            End If
        End If
        'Errou
        txt_pontos.Text -= 1
        Return False
    End Function
    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Valida se errou a última imagem
        If VericaAcerto() = False Then
            'Se errou, volta as imagens para a lupa e reabilita as imagens
            PbAtual.ImageLocation = "Norte\norte.jpg"
            PbAtual.Enabled = True
            UltPb.ImageLocation = "Norte\norte.jpg"
            UltPb.Enabled = True
        End If
        'Desabilita o timer e reabilita o formulário
        Timer1.Enabled = False
        Me.Enabled = True
    End Sub
    Private Sub bt_recomecar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_recomecar.Click
        Form1_Load(sender, e)
    End Sub

End Class