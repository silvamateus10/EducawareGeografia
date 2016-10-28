
Imports System.Data.SqlClient
'Imports System.Data.OleDb

Public Class Quiz
    Public ponto As Integer
    Dim pergBanco As New PerguntasBanco
    Dim dt As New DataTable
    Dim sorteadas As New ArrayList

    Dim numero As Integer
    Dim t As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        rdbA.Checked = False
        rdbB.Checked = False
        rdbC.Checked = False
        rdbD.Checked = False

        dt = pergBanco.chamarPerguntasCentro(1)
        txtQuestao.Text = dt.Rows(0).Item("pergunta")
        
        'Dim resp As String
        dt = pergBanco.trazerAlternativaCentro(1)
        lblA.Text = dt.Rows(0).Item("alternativa_A")
        lblB.Text = dt.Rows(0).Item("alternativa_B")
        lblC.Text = dt.Rows(0).Item("alternativa_C")
        lblD.Text = dt.Rows(0).Item("alternativa_D")
        sorteadas.Add(1)

        'Shell("c:\meuprojeto\bin\debug\meuprojeto.exe")

        rdbA.Checked = False
        rdbB.Checked = False
        rdbC.Checked = False
        rdbD.Checked = False
    End Sub

    Public Sub validaResposta()
        Dim scr As Integer
        If t = 1 And rdbA.Checked Or t = 2 And rdbC.Checked Or t = 3 And rdbC.Checked Or t = 4 And rdbA.Checked Or t = 5 And rdbC.Checked Then
            scr = lblPlacar.Text + 1
            lblPlacar.Text = scr
        ElseIf t = 6 And rdbB.Checked Or t = 7 And rdbA.Checked Or t = 8 And rdbD.Checked Or t = 9 And rdbB.Checked Or t = 10 And rdbA.Checked Or t = 11 And rdbB.Checked Then
            scr = lblPlacar.Text + 1
            lblPlacar.Text = scr
        ElseIf t = 12 And rdbD.Checked Or t = 13 And rdbA.Checked Or t = 14 And rdbD.Checked Or t = 15 And rdbC.Checked Or t = 16 And rdbA.Checked Or t = 17 And rdbC.Checked Then
            scr = lblPlacar.Text + 1
            lblPlacar.Text = scr
        ElseIf t = 18 And rdbB.Checked Or t = 19 And rdbD.Checked Or t = 20 And rdbA.Checked Then
            scr = lblPlacar.Text + 1
            lblPlacar.Text = scr
        End If
    End Sub

    Private Sub linkParar_Click(sender As Object, e As EventArgs) Handles linkParar.Click

        txtQuestao.Text = ""
        lblA.Text = ""
        lblB.Text = ""
        lblC.Text = ""
        lblD.Text = ""

        MsgBox("Obrigado pela Participação!" & vbCrLf & "Seu placar é : " & lblPlacar.Text, MsgBoxStyle.Information, "Sair")


        Dim result As Integer = MessageBox.Show("Deseja jogar outra Região?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Me.Close()

        ElseIf result = DialogResult.No Then

            Me.Close()
            GamePrincipal.Close()

        End If


    End Sub


    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles gpAlternativas.Enter
        rdbA.Checked = False
        rdbB.Checked = False
        rdbC.Checked = False
        rdbD.Checked = False
    End Sub

    Private Sub lblProxima_MouseClick(sender As Object, e As MouseEventArgs) Handles lblProxima.MouseClick

        Dim repetiu As Boolean = False
        Dim resp As String
        Dim Numero As Integer
        

sorteia_de_novo:
        Dim RDN As Random
        RDN = New Random

        repetiu = False

        Numero = RDN.Next(1, 6)

        For i As Integer = 0 To sorteadas.Count - 1
            If Numero = sorteadas(i) Then
                repetiu = True
                Exit For

            End If

        Next

        If repetiu = True Then
            GoTo sorteia_de_novo

        End If

        sorteadas.Add(Numero)
        resp = ""


        If rdbA.Checked = True Then

            resp = "A"
            If resp = dt.Rows(0).Item("respostaCerta") Then

                ponto += 10
                lblPlacar.Text = ponto.ToString

            Else
                ponto -= 10
                lblPlacar.Text = ponto.ToString

                '"Resposta Correta:" & dt.Rows(0).Item("respostaCerta")

                MsgBox("Você errou!" & vbCrLf & "Resposta Correta: Alternativa " & dt.Rows(0).Item("respostaCerta"), MsgBoxStyle.Critical, "MENSAGEM")

            End If

        End If

        If rdbB.Checked = True Then

            resp = "B"

            If resp = dt.Rows(0).Item("respostaCerta") Then
                ponto += 10
                lblPlacar.Text = ponto.ToString
            Else
                ponto -= 10
                lblPlacar.Text = ponto.ToString

                MsgBox("Você errou!" & vbCrLf & "Resposta Correta: Alternativa " & dt.Rows(0).Item("respostaCerta"), MsgBoxStyle.Critical, "MENSAGEM")
            End If

        End If

        If rdbC.Checked = True Then

            resp = "C"

            If resp = dt.Rows(0).Item("respostaCerta") Then
                ponto += 10
                lblPlacar.Text = ponto.ToString
            Else
                ponto -= 10
                lblPlacar.Text = ponto.ToString

                MsgBox("Você errou!" & vbCrLf & "Resposta Correta: Alternativa " & dt.Rows(0).Item("respostaCerta"), MsgBoxStyle.Critical, "MENSAGEM")

            End If

        End If


        If rdbD.Checked = True Then

            resp = "D"

            If resp = dt.Rows(0).Item("respostaCerta") Then
                ponto += 10
                lblPlacar.Text = ponto.ToString
            Else
                ponto -= 10
                lblPlacar.Text = ponto.ToString

                MsgBox("Você errou!" & vbCrLf & "Resposta Correta: Alternativa " & dt.Rows(0).Item("respostaCerta"), MsgBoxStyle.Critical, "MENSAGEM")
            End If

        End If

        rdbA.Checked = False

        If ponto = 30 And ponto < 40 Then

            Dim result As Integer = MessageBox.Show("Deseja jogar o Bônus Educaware Geografia?", "Bônus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                MemoriaCentro.Show()

                lblProxima.Enabled = False
                lblProxima.Visible = False

                linkParar.Enabled = False
                linkParar.Visible = False

                gpQuestoes.Enabled = False
                gpAlternativas.Enabled = False

                lblContinuar.Enabled = True
                lblContinuar.Visible = True


            ElseIf result = DialogResult.No Then


            End If

            
        End If

        dt = pergBanco.chamarPerguntasCentro(Numero)
        txtQuestao.Text = dt.Rows(0).Item("pergunta")

        dt = pergBanco.trazerAlternativaCentro(Numero)
        lblA.Text = dt.Rows(0).Item("alternativa_A")
        lblB.Text = dt.Rows(0).Item("alternativa_B")
        lblC.Text = dt.Rows(0).Item("alternativa_C")
        lblD.Text = dt.Rows(0).Item("alternativa_D")


        If sorteadas.Count >= 5 Then

            'JOGAR O PARABÉNS
            lblParabens.Visible = True
            lblVcVenceu.Visible = True

            gpAlternativas.Visible = False
            gpQuestoes.Visible = False
            gpPlacar.Visible = False
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False

            GamePrincipal.Show()

            lblProxima.Visible = False
            linkParar.Visible = False

            MsgBox("Obrigado pela Participação!" & vbCrLf & "Seu placar é : " & lblPlacar.Text, MsgBoxStyle.Information, "FIM")

            Dim result As Integer = MessageBox.Show("Deseja jogar outra Região?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Me.Close()

            ElseIf result = DialogResult.No Then

                Me.Close()
                GamePrincipal.Close()


            End If


        End If

    End Sub
    
    Private Sub btnMemoria_Click(sender As Object, e As EventArgs)
        MemoriaCentro.Show()
    End Sub

    Private Sub lblContinuar_Click(sender As Object, e As EventArgs) Handles lblContinuar.Click

        MsgBox("Você ganhou 30 pontos por jogar o " _
               & vbCrLf & "Bônus Educaware Geografia!" & vbCrLf & "Seu placar atual é de " & lblPlacar.Text + 30 _
               & " pontos!", MsgBoxStyle.Information, "MENSAGEM")

        gpAlternativas.Enabled = True
        gpQuestoes.Enabled = True

        lblProxima.Enabled = True
        lblProxima.Visible = True

        linkParar.Enabled = True
        linkParar.Visible = True

        lblContinuar.Enabled = False
        lblContinuar.Visible = False

        Dim mem As New MemoriaCentro

        ponto += 30

        lblPlacar.Text = ponto.ToString


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gpPlacar.Enter

    End Sub
End Class
