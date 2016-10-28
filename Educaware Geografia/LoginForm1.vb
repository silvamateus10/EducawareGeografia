Public Class LoginForm1

    Dim cadBanco As New CadastroBanco
    Dim cadClass As New CadastroUsuario

    'ATRIBUTOS DO LOGIN

    Private _SenhaAdm As String
    Private _NomeAdm As String

    'Propriedade NOME ADM E SENHA ADM

    Public Property NomeAdm As String

        Get
            Return _NomeAdm

        End Get
        Set(value As String)

            _NomeAdm = value

        End Set
    End Property


    Public Property SenhaAdm As String

        Get
            Return _SenhaAdm

        End Get
        Set(value As String)
            _SenhaAdm = value

        End Set
    End Property

    '------------------------------------FIM ADM-----------------------------------------

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOKADM.Click

        'VERIFICAR LOGIN DO ADMINISTRADOR

        'Recebendo os atributos*

        NomeAdm = "admin"
        SenhaAdm = "admin"

        If txtNomeADM.Text = Nothing Or txtNomeADM.Text <> NomeAdm Then

            MessageBox.Show("Corrija os campos!", "MENSAGEM!", MessageBoxButtons.RetryCancel)
            txtNomeADM.Focus()

        ElseIf txtSenhaADM.Text = Nothing Or txtSenhaADM.Text <> SenhaAdm Then

            MessageBox.Show("Corrija sua senha!", "MENSAGEM!", MessageBoxButtons.RetryCancel)
            txtSenhaADM.Focus()

        Else

            ADM_Form.Show()
            txtNomeADM.ResetText()
            txtSenhaADM.ResetText()
            txtNomeADM.Focus()

        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelADM.Click

        txtNomeADM.ResetText()
        txtSenhaADM.ResetText()
        txtNomeADM.Focus()

    End Sub

    Private Sub AdministradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdmToolStrip.Click

        GroupJog.Visible = False
        GroupADM.Show()

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GroupJog.Visible = True
        GroupADM.Visible = False

    End Sub

    Private Sub JogadorToolStrip_Click(sender As Object, e As EventArgs) Handles JogadorToolStrip.Click
        GroupADM.Visible = False
        GroupJog.Show()
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click

        Dim result As Integer = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            End

        ElseIf result = DialogResult.No Then


        End If

    End Sub

    Private Sub btnOKJog_Click(sender As Object, e As EventArgs) Handles btnOKJog.Click

        If txtSenhaJog.TextLength > 8 Then

            MessageBox.Show("Máximo 8 caracteres!")

        Else

            If txtSenhaJog.TextLength < 6 Then

                MessageBox.Show("Mínimo 6 caracteres!")

            End If

        End If

        Dim dataTable As New DataTable

        dataTable = cadBanco.loginDoJogador(txtNomeJog.Text, txtSenhaJog.Text)

        If dataTable.Rows.Count > 0 Then

            GamePrincipal.ShowDialog()

        Else
            MessageBox.Show("Login ou Senha inválidos!" & vbCrLf & "Caso tenha perdido sua senha, contate o administrador!")

            Dim result As Integer = MessageBox.Show("Deseja cadastrar um novo usuário?", "Cadastrar Novo Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Cadastro_Form.Show()

            ElseIf result = DialogResult.No Then

            End If

        End If

        txtSenhaJog.ResetText()
        txtNomeJog.Focus()


    End Sub

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        Cadastro_Form.ShowDialog()
    End Sub

    Private Sub FaleConoscoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FaleConoscoToolStripMenuItem.Click

        Process.Start("file:///C:/Users/Fernando/Desktop/TCC%20-%20Site/contato.html")


    End Sub

    Private Sub btnCancelJog_Click(sender As Object, e As EventArgs) Handles btnCancelJog.Click

        txtNomeJog.ResetText()
        txtSenhaJog.ResetText()
        txtNomeJog.Focus()

    End Sub

    Private Sub GroupJog_Enter(sender As Object, e As EventArgs) Handles GroupJog.Enter

    End Sub
End Class
