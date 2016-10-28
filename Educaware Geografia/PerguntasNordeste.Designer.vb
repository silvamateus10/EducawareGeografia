<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PerguntasNordeste
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim SnoLabel As System.Windows.Forms.Label
        Dim QuestaoLabel As System.Windows.Forms.Label
        Dim OpaLabel As System.Windows.Forms.Label
        Dim OpbLabel As System.Windows.Forms.Label
        Dim OpcLabel As System.Windows.Forms.Label
        Dim OpdLabel As System.Windows.Forms.Label
        Dim RespostaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PerguntasNordeste))
        Me.dgvPerguntasNordeste = New System.Windows.Forms.DataGridView()
        Me.btnOKalt = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNumQuestãoAlt = New System.Windows.Forms.TextBox()
        Me.txtQuestaoAlt = New System.Windows.Forms.TextBox()
        Me.txtOPAalt = New System.Windows.Forms.TextBox()
        Me.txtOPBalt = New System.Windows.Forms.TextBox()
        Me.txtOPCalt = New System.Windows.Forms.TextBox()
        Me.txtOPDalt = New System.Windows.Forms.TextBox()
        Me.txtRespAlt = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InserirPerguntasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarPerguntasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirPerguntasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gpAlterarQuestoes = New System.Windows.Forms.GroupBox()
        Me.txtAltB = New System.Windows.Forms.TextBox()
        Me.txtAltA = New System.Windows.Forms.TextBox()
        Me.gpInserirQuestoes = New System.Windows.Forms.GroupBox()
        Me.txtNumPergunta = New System.Windows.Forms.TextBox()
        Me.txtPergunta = New System.Windows.Forms.TextBox()
        Me.txtAltC = New System.Windows.Forms.TextBox()
        Me.txtAltD = New System.Windows.Forms.TextBox()
        Me.txtRespCerta = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        SnoLabel = New System.Windows.Forms.Label()
        QuestaoLabel = New System.Windows.Forms.Label()
        OpaLabel = New System.Windows.Forms.Label()
        OpbLabel = New System.Windows.Forms.Label()
        OpcLabel = New System.Windows.Forms.Label()
        OpdLabel = New System.Windows.Forms.Label()
        RespostaLabel = New System.Windows.Forms.Label()
        CType(Me.dgvPerguntasNordeste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpAlterarQuestoes.SuspendLayout()
        Me.gpInserirQuestoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(30, 35)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(32, 16)
        Label1.TabIndex = 0
        Label1.Text = "No."
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(30, 61)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(74, 16)
        Label2.TabIndex = 2
        Label2.Text = "Questão :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(30, 158)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(68, 16)
        Label3.TabIndex = 4
        Label3.Text = "Opção A"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(30, 197)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(68, 16)
        Label4.TabIndex = 6
        Label4.Text = "Opção B"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(30, 240)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(68, 16)
        Label5.TabIndex = 8
        Label5.Text = "Opção C"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(30, 282)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(69, 16)
        Label6.TabIndex = 10
        Label6.Text = "Opção D"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(27, 122)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(75, 16)
        Label7.TabIndex = 12
        Label7.Text = "Resposta"
        '
        'SnoLabel
        '
        SnoLabel.AutoSize = True
        SnoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SnoLabel.Location = New System.Drawing.Point(30, 35)
        SnoLabel.Name = "SnoLabel"
        SnoLabel.Size = New System.Drawing.Size(32, 16)
        SnoLabel.TabIndex = 0
        SnoLabel.Text = "No."
        '
        'QuestaoLabel
        '
        QuestaoLabel.AutoSize = True
        QuestaoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuestaoLabel.Location = New System.Drawing.Point(30, 61)
        QuestaoLabel.Name = "QuestaoLabel"
        QuestaoLabel.Size = New System.Drawing.Size(74, 16)
        QuestaoLabel.TabIndex = 2
        QuestaoLabel.Text = "Questão :"
        '
        'OpaLabel
        '
        OpaLabel.AutoSize = True
        OpaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OpaLabel.Location = New System.Drawing.Point(30, 158)
        OpaLabel.Name = "OpaLabel"
        OpaLabel.Size = New System.Drawing.Size(68, 16)
        OpaLabel.TabIndex = 4
        OpaLabel.Text = "Opção A"
        '
        'OpbLabel
        '
        OpbLabel.AutoSize = True
        OpbLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OpbLabel.Location = New System.Drawing.Point(30, 197)
        OpbLabel.Name = "OpbLabel"
        OpbLabel.Size = New System.Drawing.Size(68, 16)
        OpbLabel.TabIndex = 6
        OpbLabel.Text = "Opção B"
        '
        'OpcLabel
        '
        OpcLabel.AutoSize = True
        OpcLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OpcLabel.Location = New System.Drawing.Point(30, 240)
        OpcLabel.Name = "OpcLabel"
        OpcLabel.Size = New System.Drawing.Size(68, 16)
        OpcLabel.TabIndex = 8
        OpcLabel.Text = "Opção C"
        '
        'OpdLabel
        '
        OpdLabel.AutoSize = True
        OpdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OpdLabel.Location = New System.Drawing.Point(30, 282)
        OpdLabel.Name = "OpdLabel"
        OpdLabel.Size = New System.Drawing.Size(69, 16)
        OpdLabel.TabIndex = 10
        OpdLabel.Text = "Opção D"
        '
        'RespostaLabel
        '
        RespostaLabel.AutoSize = True
        RespostaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RespostaLabel.Location = New System.Drawing.Point(27, 122)
        RespostaLabel.Name = "RespostaLabel"
        RespostaLabel.Size = New System.Drawing.Size(75, 16)
        RespostaLabel.TabIndex = 12
        RespostaLabel.Text = "Resposta"
        '
        'dgvPerguntasNordeste
        '
        Me.dgvPerguntasNordeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPerguntasNordeste.Location = New System.Drawing.Point(74, 151)
        Me.dgvPerguntasNordeste.Name = "dgvPerguntasNordeste"
        Me.dgvPerguntasNordeste.Size = New System.Drawing.Size(1183, 178)
        Me.dgvPerguntasNordeste.TabIndex = 12
        '
        'btnOKalt
        '
        Me.btnOKalt.Location = New System.Drawing.Point(173, 32)
        Me.btnOKalt.Name = "btnOKalt"
        Me.btnOKalt.Size = New System.Drawing.Size(63, 23)
        Me.btnOKalt.TabIndex = 14
        Me.btnOKalt.Text = "OK"
        Me.btnOKalt.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(479, 19)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 4
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(276, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Alterar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNumQuestãoAlt
        '
        Me.txtNumQuestãoAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumQuestãoAlt.Location = New System.Drawing.Point(108, 35)
        Me.txtNumQuestãoAlt.Name = "txtNumQuestãoAlt"
        Me.txtNumQuestãoAlt.Size = New System.Drawing.Size(39, 21)
        Me.txtNumQuestãoAlt.TabIndex = 1
        '
        'txtQuestaoAlt
        '
        Me.txtQuestaoAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestaoAlt.Location = New System.Drawing.Point(108, 61)
        Me.txtQuestaoAlt.Multiline = True
        Me.txtQuestaoAlt.Name = "txtQuestaoAlt"
        Me.txtQuestaoAlt.Size = New System.Drawing.Size(446, 46)
        Me.txtQuestaoAlt.TabIndex = 3
        '
        'txtOPAalt
        '
        Me.txtOPAalt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOPAalt.Location = New System.Drawing.Point(108, 158)
        Me.txtOPAalt.Multiline = True
        Me.txtOPAalt.Name = "txtOPAalt"
        Me.txtOPAalt.Size = New System.Drawing.Size(446, 33)
        Me.txtOPAalt.TabIndex = 5
        '
        'txtOPBalt
        '
        Me.txtOPBalt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOPBalt.Location = New System.Drawing.Point(108, 197)
        Me.txtOPBalt.Multiline = True
        Me.txtOPBalt.Name = "txtOPBalt"
        Me.txtOPBalt.Size = New System.Drawing.Size(446, 37)
        Me.txtOPBalt.TabIndex = 7
        '
        'txtOPCalt
        '
        Me.txtOPCalt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOPCalt.Location = New System.Drawing.Point(108, 240)
        Me.txtOPCalt.Multiline = True
        Me.txtOPCalt.Name = "txtOPCalt"
        Me.txtOPCalt.Size = New System.Drawing.Size(446, 36)
        Me.txtOPCalt.TabIndex = 9
        '
        'txtOPDalt
        '
        Me.txtOPDalt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOPDalt.Location = New System.Drawing.Point(108, 282)
        Me.txtOPDalt.Multiline = True
        Me.txtOPDalt.Name = "txtOPDalt"
        Me.txtOPDalt.Size = New System.Drawing.Size(446, 32)
        Me.txtOPDalt.TabIndex = 11
        '
        'txtRespAlt
        '
        Me.txtRespAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespAlt.Location = New System.Drawing.Point(108, 113)
        Me.txtRespAlt.Multiline = True
        Me.txtRespAlt.Name = "txtRespAlt"
        Me.txtRespAlt.Size = New System.Drawing.Size(83, 32)
        Me.txtRespAlt.TabIndex = 13
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpçõesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpçõesToolStripMenuItem
        '
        Me.OpçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InserirPerguntasToolStripMenuItem, Me.AlterarPerguntasToolStripMenuItem, Me.ExcluirPerguntasToolStripMenuItem})
        Me.OpçõesToolStripMenuItem.Name = "OpçõesToolStripMenuItem"
        Me.OpçõesToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.OpçõesToolStripMenuItem.Text = "&Opções"
        '
        'InserirPerguntasToolStripMenuItem
        '
        Me.InserirPerguntasToolStripMenuItem.Name = "InserirPerguntasToolStripMenuItem"
        Me.InserirPerguntasToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.InserirPerguntasToolStripMenuItem.Text = "Inserir Perguntas"
        '
        'AlterarPerguntasToolStripMenuItem
        '
        Me.AlterarPerguntasToolStripMenuItem.Name = "AlterarPerguntasToolStripMenuItem"
        Me.AlterarPerguntasToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AlterarPerguntasToolStripMenuItem.Text = "Alterar Perguntas"
        '
        'ExcluirPerguntasToolStripMenuItem
        '
        Me.ExcluirPerguntasToolStripMenuItem.Name = "ExcluirPerguntasToolStripMenuItem"
        Me.ExcluirPerguntasToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ExcluirPerguntasToolStripMenuItem.Text = "Excluir Perguntas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Educaware_Geografia.My.Resources.Resources.EducaWareLOGO
        Me.PictureBox1.Location = New System.Drawing.Point(484, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(393, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'gpAlterarQuestoes
        '
        Me.gpAlterarQuestoes.Controls.Add(Me.btnOKalt)
        Me.gpAlterarQuestoes.Controls.Add(Me.Button1)
        Me.gpAlterarQuestoes.Controls.Add(Label1)
        Me.gpAlterarQuestoes.Controls.Add(Me.txtNumQuestãoAlt)
        Me.gpAlterarQuestoes.Controls.Add(Label2)
        Me.gpAlterarQuestoes.Controls.Add(Me.txtQuestaoAlt)
        Me.gpAlterarQuestoes.Controls.Add(Label3)
        Me.gpAlterarQuestoes.Controls.Add(Me.txtOPAalt)
        Me.gpAlterarQuestoes.Controls.Add(Label4)
        Me.gpAlterarQuestoes.Controls.Add(Me.txtOPBalt)
        Me.gpAlterarQuestoes.Controls.Add(Label5)
        Me.gpAlterarQuestoes.Controls.Add(Me.txtOPCalt)
        Me.gpAlterarQuestoes.Controls.Add(Label6)
        Me.gpAlterarQuestoes.Controls.Add(Me.txtOPDalt)
        Me.gpAlterarQuestoes.Controls.Add(Label7)
        Me.gpAlterarQuestoes.Controls.Add(Me.txtRespAlt)
        Me.gpAlterarQuestoes.Enabled = False
        Me.gpAlterarQuestoes.Location = New System.Drawing.Point(687, 350)
        Me.gpAlterarQuestoes.Name = "gpAlterarQuestoes"
        Me.gpAlterarQuestoes.Size = New System.Drawing.Size(587, 336)
        Me.gpAlterarQuestoes.TabIndex = 9
        Me.gpAlterarQuestoes.TabStop = False
        Me.gpAlterarQuestoes.Text = "Alterar Questões"
        '
        'txtAltB
        '
        Me.txtAltB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAltB.Location = New System.Drawing.Point(108, 197)
        Me.txtAltB.Multiline = True
        Me.txtAltB.Name = "txtAltB"
        Me.txtAltB.Size = New System.Drawing.Size(446, 37)
        Me.txtAltB.TabIndex = 7
        '
        'txtAltA
        '
        Me.txtAltA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAltA.Location = New System.Drawing.Point(108, 158)
        Me.txtAltA.Multiline = True
        Me.txtAltA.Name = "txtAltA"
        Me.txtAltA.Size = New System.Drawing.Size(446, 33)
        Me.txtAltA.TabIndex = 5
        '
        'gpInserirQuestoes
        '
        Me.gpInserirQuestoes.Controls.Add(Me.btnSalvar)
        Me.gpInserirQuestoes.Controls.Add(SnoLabel)
        Me.gpInserirQuestoes.Controls.Add(Me.txtNumPergunta)
        Me.gpInserirQuestoes.Controls.Add(QuestaoLabel)
        Me.gpInserirQuestoes.Controls.Add(Me.txtPergunta)
        Me.gpInserirQuestoes.Controls.Add(OpaLabel)
        Me.gpInserirQuestoes.Controls.Add(Me.txtAltA)
        Me.gpInserirQuestoes.Controls.Add(OpbLabel)
        Me.gpInserirQuestoes.Controls.Add(Me.txtAltB)
        Me.gpInserirQuestoes.Controls.Add(OpcLabel)
        Me.gpInserirQuestoes.Controls.Add(Me.txtAltC)
        Me.gpInserirQuestoes.Controls.Add(OpdLabel)
        Me.gpInserirQuestoes.Controls.Add(Me.txtAltD)
        Me.gpInserirQuestoes.Controls.Add(RespostaLabel)
        Me.gpInserirQuestoes.Controls.Add(Me.txtRespCerta)
        Me.gpInserirQuestoes.Enabled = False
        Me.gpInserirQuestoes.Location = New System.Drawing.Point(44, 350)
        Me.gpInserirQuestoes.Name = "gpInserirQuestoes"
        Me.gpInserirQuestoes.Size = New System.Drawing.Size(587, 336)
        Me.gpInserirQuestoes.TabIndex = 8
        Me.gpInserirQuestoes.TabStop = False
        Me.gpInserirQuestoes.Text = "Formular Questões"
        '
        'txtNumPergunta
        '
        Me.txtNumPergunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumPergunta.Location = New System.Drawing.Point(108, 35)
        Me.txtNumPergunta.Name = "txtNumPergunta"
        Me.txtNumPergunta.Size = New System.Drawing.Size(39, 21)
        Me.txtNumPergunta.TabIndex = 1
        '
        'txtPergunta
        '
        Me.txtPergunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPergunta.Location = New System.Drawing.Point(108, 61)
        Me.txtPergunta.Multiline = True
        Me.txtPergunta.Name = "txtPergunta"
        Me.txtPergunta.Size = New System.Drawing.Size(446, 46)
        Me.txtPergunta.TabIndex = 3
        '
        'txtAltC
        '
        Me.txtAltC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAltC.Location = New System.Drawing.Point(108, 240)
        Me.txtAltC.Multiline = True
        Me.txtAltC.Name = "txtAltC"
        Me.txtAltC.Size = New System.Drawing.Size(446, 36)
        Me.txtAltC.TabIndex = 9
        '
        'txtAltD
        '
        Me.txtAltD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAltD.Location = New System.Drawing.Point(108, 282)
        Me.txtAltD.Multiline = True
        Me.txtAltD.Name = "txtAltD"
        Me.txtAltD.Size = New System.Drawing.Size(446, 32)
        Me.txtAltD.TabIndex = 11
        '
        'txtRespCerta
        '
        Me.txtRespCerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespCerta.Location = New System.Drawing.Point(108, 113)
        Me.txtRespCerta.Multiline = True
        Me.txtRespCerta.Name = "txtRespCerta"
        Me.txtRespCerta.Size = New System.Drawing.Size(83, 32)
        Me.txtRespCerta.TabIndex = 13
        '
        'PerguntasNordeste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 738)
        Me.Controls.Add(Me.dgvPerguntasNordeste)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gpAlterarQuestoes)
        Me.Controls.Add(Me.gpInserirQuestoes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PerguntasNordeste"
        Me.Text = "Perguntas Nordeste"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvPerguntasNordeste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpAlterarQuestoes.ResumeLayout(False)
        Me.gpAlterarQuestoes.PerformLayout()
        Me.gpInserirQuestoes.ResumeLayout(False)
        Me.gpInserirQuestoes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPerguntasNordeste As System.Windows.Forms.DataGridView
    Friend WithEvents btnOKalt As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtNumQuestãoAlt As System.Windows.Forms.TextBox
    Friend WithEvents txtQuestaoAlt As System.Windows.Forms.TextBox
    Friend WithEvents txtOPAalt As System.Windows.Forms.TextBox
    Friend WithEvents txtOPBalt As System.Windows.Forms.TextBox
    Friend WithEvents txtOPCalt As System.Windows.Forms.TextBox
    Friend WithEvents txtOPDalt As System.Windows.Forms.TextBox
    Friend WithEvents txtRespAlt As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InserirPerguntasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarPerguntasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcluirPerguntasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gpAlterarQuestoes As System.Windows.Forms.GroupBox
    Friend WithEvents txtAltB As System.Windows.Forms.TextBox
    Friend WithEvents txtAltA As System.Windows.Forms.TextBox
    Friend WithEvents gpInserirQuestoes As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumPergunta As System.Windows.Forms.TextBox
    Friend WithEvents txtPergunta As System.Windows.Forms.TextBox
    Friend WithEvents txtAltC As System.Windows.Forms.TextBox
    Friend WithEvents txtAltD As System.Windows.Forms.TextBox
    Friend WithEvents txtRespCerta As System.Windows.Forms.TextBox
End Class
