<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarForm))
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.GroupDados = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSenha2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtIdade = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvConsultaEditar = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtPesq = New System.Windows.Forms.TextBox()
        Me.GroupDados.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConsultaEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(566, 644)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(110, 23)
        Me.btnLimpar.TabIndex = 19
        Me.btnLimpar.Text = "&Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnVoltar
        '
        Me.btnVoltar.Location = New System.Drawing.Point(40, 644)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(106, 23)
        Me.btnVoltar.TabIndex = 18
        Me.btnVoltar.Text = "&Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(445, 644)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(105, 23)
        Me.btnSalvar.TabIndex = 17
        Me.btnSalvar.Text = "&Salvar Edições"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'GroupDados
        '
        Me.GroupDados.Controls.Add(Me.Label6)
        Me.GroupDados.Controls.Add(Me.Label3)
        Me.GroupDados.Controls.Add(Me.txtCod)
        Me.GroupDados.Controls.Add(Me.Label5)
        Me.GroupDados.Controls.Add(Me.txtSenha2)
        Me.GroupDados.Controls.Add(Me.Label7)
        Me.GroupDados.Controls.Add(Me.txtSenha)
        Me.GroupDados.Controls.Add(Me.Label4)
        Me.GroupDados.Controls.Add(Me.txtSerie)
        Me.GroupDados.Controls.Add(Me.txtIdade)
        Me.GroupDados.Controls.Add(Me.txtNome)
        Me.GroupDados.Controls.Add(Me.Label2)
        Me.GroupDados.Controls.Add(Me.Label1)
        Me.GroupDados.Location = New System.Drawing.Point(40, 376)
        Me.GroupDados.Name = "GroupDados"
        Me.GroupDados.Size = New System.Drawing.Size(636, 251)
        Me.GroupDados.TabIndex = 16
        Me.GroupDados.TabStop = False
        Me.GroupDados.Text = "Dados do Jogador:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(237, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Digite os novos dados a serem editados:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Código:"
        '
        'txtCod
        '
        Me.txtCod.Enabled = False
        Me.txtCod.Location = New System.Drawing.Point(81, 89)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(70, 20)
        Me.txtCod.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(314, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Confirmar senha:"
        '
        'txtSenha2
        '
        Me.txtSenha2.Location = New System.Drawing.Point(406, 213)
        Me.txtSenha2.Name = "txtSenha2"
        Me.txtSenha2.Size = New System.Drawing.Size(133, 20)
        Me.txtSenha2.TabIndex = 6
        Me.txtSenha2.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Escolha uma senha:"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(150, 210)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(129, 20)
        Me.txtSenha.TabIndex = 3
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Série:"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(232, 173)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(70, 20)
        Me.txtSerie.TabIndex = 4
        '
        'txtIdade
        '
        Me.txtIdade.Location = New System.Drawing.Point(75, 173)
        Me.txtIdade.Name = "txtIdade"
        Me.txtIdade.Size = New System.Drawing.Size(67, 20)
        Me.txtIdade.TabIndex = 5
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(123, 133)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(491, 20)
        Me.txtNome.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Idade:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome Completo:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Educaware_Geografia.My.Resources.Resources.EducaWareLOGO
        Me.PictureBox1.Location = New System.Drawing.Point(205, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(345, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(323, 644)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "&Testar Conexão"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvConsultaEditar
        '
        Me.dgvConsultaEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaEditar.Enabled = False
        Me.dgvConsultaEditar.Location = New System.Drawing.Point(40, 210)
        Me.dgvConsultaEditar.Name = "dgvConsultaEditar"
        Me.dgvConsultaEditar.Size = New System.Drawing.Size(636, 150)
        Me.dgvConsultaEditar.TabIndex = 21
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnOK)
        Me.GroupBox2.Controls.Add(Me.txtPesq)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(636, 56)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consulte o usuário a ser editado (nome):"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(506, 19)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtPesq
        '
        Me.txtPesq.Location = New System.Drawing.Point(6, 19)
        Me.txtPesq.Name = "txtPesq"
        Me.txtPesq.Size = New System.Drawing.Size(461, 20)
        Me.txtPesq.TabIndex = 0
        '
        'EditarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(710, 675)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvConsultaEditar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.GroupDados)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditarForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editar Jogador"
        Me.GroupDados.ResumeLayout(False)
        Me.GroupDados.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConsultaEditar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents GroupDados As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtIdade As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSenha2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents dgvConsultaEditar As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPesq As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
