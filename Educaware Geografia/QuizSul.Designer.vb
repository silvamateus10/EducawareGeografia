﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuizSul
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuizSul))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblVcVenceu = New System.Windows.Forms.Label()
        Me.lblContinuar = New System.Windows.Forms.Label()
        Me.lblProxima = New System.Windows.Forms.Label()
        Me.rdbC = New System.Windows.Forms.RadioButton()
        Me.rdbB = New System.Windows.Forms.RadioButton()
        Me.rdbA = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbD = New System.Windows.Forms.RadioButton()
        Me.gpQuestoes = New System.Windows.Forms.GroupBox()
        Me.txtQuestao = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.linkParar = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblParabens = New System.Windows.Forms.Label()
        Me.gpAlternativas = New System.Windows.Forms.GroupBox()
        Me.lblPlacar = New System.Windows.Forms.Label()
        Me.gpPlacar = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gpQuestoes.SuspendLayout()
        Me.gpAlternativas.SuspendLayout()
        Me.gpPlacar.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'lblVcVenceu
        '
        Me.lblVcVenceu.AutoSize = True
        Me.lblVcVenceu.BackColor = System.Drawing.Color.Transparent
        Me.lblVcVenceu.Font = New System.Drawing.Font("Buxton Sketch", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVcVenceu.ForeColor = System.Drawing.Color.White
        Me.lblVcVenceu.Location = New System.Drawing.Point(228, 134)
        Me.lblVcVenceu.Name = "lblVcVenceu"
        Me.lblVcVenceu.Size = New System.Drawing.Size(596, 43)
        Me.lblVcVenceu.TabIndex = 54
        Me.lblVcVenceu.Text = "Você venceu o desafio Educaware Geografia!"
        Me.lblVcVenceu.Visible = False
        '
        'lblContinuar
        '
        Me.lblContinuar.AutoSize = True
        Me.lblContinuar.BackColor = System.Drawing.Color.Transparent
        Me.lblContinuar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblContinuar.Enabled = False
        Me.lblContinuar.Font = New System.Drawing.Font("Buxton Sketch", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContinuar.ForeColor = System.Drawing.Color.White
        Me.lblContinuar.Location = New System.Drawing.Point(225, 581)
        Me.lblContinuar.Name = "lblContinuar"
        Me.lblContinuar.Size = New System.Drawing.Size(199, 59)
        Me.lblContinuar.TabIndex = 61
        Me.lblContinuar.Text = "Continuar"
        Me.lblContinuar.Visible = False
        '
        'lblProxima
        '
        Me.lblProxima.AutoSize = True
        Me.lblProxima.BackColor = System.Drawing.Color.Transparent
        Me.lblProxima.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblProxima.Font = New System.Drawing.Font("Buxton Sketch", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProxima.ForeColor = System.Drawing.Color.White
        Me.lblProxima.Location = New System.Drawing.Point(101, 581)
        Me.lblProxima.Name = "lblProxima"
        Me.lblProxima.Size = New System.Drawing.Size(166, 59)
        Me.lblProxima.TabIndex = 60
        Me.lblProxima.Text = "Próxima"
        '
        'rdbC
        '
        Me.rdbC.AutoSize = True
        Me.rdbC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbC.Font = New System.Drawing.Font("Buxton Sketch", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.rdbC.Location = New System.Drawing.Point(16, 166)
        Me.rdbC.Name = "rdbC"
        Me.rdbC.Size = New System.Drawing.Size(124, 30)
        Me.rdbC.TabIndex = 5
        Me.rdbC.Text = "Alternativa C"
        Me.rdbC.UseVisualStyleBackColor = True
        '
        'rdbB
        '
        Me.rdbB.AutoSize = True
        Me.rdbB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbB.Font = New System.Drawing.Font("Buxton Sketch", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.rdbB.Location = New System.Drawing.Point(16, 96)
        Me.rdbB.Name = "rdbB"
        Me.rdbB.Size = New System.Drawing.Size(127, 30)
        Me.rdbB.TabIndex = 4
        Me.rdbB.Text = "Alternativa B"
        Me.rdbB.UseVisualStyleBackColor = True
        '
        'rdbA
        '
        Me.rdbA.AutoSize = True
        Me.rdbA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbA.Font = New System.Drawing.Font("Buxton Sketch", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.rdbA.Location = New System.Drawing.Point(16, 27)
        Me.rdbA.Name = "rdbA"
        Me.rdbA.Size = New System.Drawing.Size(123, 30)
        Me.rdbA.TabIndex = 2
        Me.rdbA.Text = "Alternativa A"
        Me.rdbA.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Buxton Sketch", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(31, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Placar:"
        '
        'rdbD
        '
        Me.rdbD.AutoSize = True
        Me.rdbD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbD.Font = New System.Drawing.Font("Buxton Sketch", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.rdbD.Location = New System.Drawing.Point(16, 234)
        Me.rdbD.Name = "rdbD"
        Me.rdbD.Size = New System.Drawing.Size(126, 30)
        Me.rdbD.TabIndex = 3
        Me.rdbD.Text = "Alternativa D"
        Me.rdbD.UseVisualStyleBackColor = True
        '
        'gpQuestoes
        '
        Me.gpQuestoes.BackColor = System.Drawing.Color.Transparent
        Me.gpQuestoes.Controls.Add(Me.txtQuestao)
        Me.gpQuestoes.Font = New System.Drawing.Font("Buxton Sketch", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpQuestoes.ForeColor = System.Drawing.Color.Yellow
        Me.gpQuestoes.Location = New System.Drawing.Point(30, 12)
        Me.gpQuestoes.Name = "gpQuestoes"
        Me.gpQuestoes.Size = New System.Drawing.Size(956, 181)
        Me.gpQuestoes.TabIndex = 59
        Me.gpQuestoes.TabStop = False
        Me.gpQuestoes.Text = "Questão"
        '
        'txtQuestao
        '
        Me.txtQuestao.BackColor = System.Drawing.Color.Transparent
        Me.txtQuestao.Font = New System.Drawing.Font("Buxton Sketch", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestao.ForeColor = System.Drawing.Color.White
        Me.txtQuestao.Location = New System.Drawing.Point(5, 39)
        Me.txtQuestao.Name = "txtQuestao"
        Me.txtQuestao.Size = New System.Drawing.Size(945, 126)
        Me.txtQuestao.TabIndex = 35
        Me.txtQuestao.Text = "Questao"
        '
        'lblC
        '
        Me.lblC.BackColor = System.Drawing.Color.Transparent
        Me.lblC.Font = New System.Drawing.Font("Buxton Sketch", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.Location = New System.Drawing.Point(15, 199)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(914, 29)
        Me.lblC.TabIndex = 28
        Me.lblC.Text = "C"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(633, 631)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 15)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Todos os direitos reservados"
        '
        'lblA
        '
        Me.lblA.BackColor = System.Drawing.Color.Transparent
        Me.lblA.Font = New System.Drawing.Font("Buxton Sketch", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(15, 56)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(902, 29)
        Me.lblA.TabIndex = 26
        Me.lblA.Text = "A"
        '
        'linkParar
        '
        Me.linkParar.AutoSize = True
        Me.linkParar.BackColor = System.Drawing.Color.Transparent
        Me.linkParar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkParar.Font = New System.Drawing.Font("Buxton Sketch", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkParar.ForeColor = System.Drawing.Color.White
        Me.linkParar.Location = New System.Drawing.Point(415, 582)
        Me.linkParar.Name = "linkParar"
        Me.linkParar.Size = New System.Drawing.Size(121, 59)
        Me.linkParar.TabIndex = 52
        Me.linkParar.Text = "Parar"
        '
        'lblB
        '
        Me.lblB.BackColor = System.Drawing.Color.Transparent
        Me.lblB.Font = New System.Drawing.Font("Buxton Sketch", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(15, 129)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(914, 29)
        Me.lblB.TabIndex = 27
        Me.lblB.Text = "B"
        '
        'lblD
        '
        Me.lblD.BackColor = System.Drawing.Color.Transparent
        Me.lblD.Font = New System.Drawing.Font("Buxton Sketch", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.Location = New System.Drawing.Point(15, 267)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(914, 29)
        Me.lblD.TabIndex = 29
        Me.lblD.Text = "D"
        '
        'lblParabens
        '
        Me.lblParabens.AutoSize = True
        Me.lblParabens.BackColor = System.Drawing.Color.Transparent
        Me.lblParabens.Font = New System.Drawing.Font("Buxton Sketch", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParabens.ForeColor = System.Drawing.Color.White
        Me.lblParabens.Location = New System.Drawing.Point(354, 55)
        Me.lblParabens.Name = "lblParabens"
        Me.lblParabens.Size = New System.Drawing.Size(348, 79)
        Me.lblParabens.TabIndex = 53
        Me.lblParabens.Text = "PARABÉNS!!!"
        Me.lblParabens.Visible = False
        '
        'gpAlternativas
        '
        Me.gpAlternativas.BackColor = System.Drawing.Color.Transparent
        Me.gpAlternativas.Controls.Add(Me.lblB)
        Me.gpAlternativas.Controls.Add(Me.lblD)
        Me.gpAlternativas.Controls.Add(Me.lblA)
        Me.gpAlternativas.Controls.Add(Me.lblC)
        Me.gpAlternativas.Controls.Add(Me.rdbD)
        Me.gpAlternativas.Controls.Add(Me.rdbC)
        Me.gpAlternativas.Controls.Add(Me.rdbB)
        Me.gpAlternativas.Controls.Add(Me.rdbA)
        Me.gpAlternativas.Font = New System.Drawing.Font("Buxton Sketch", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpAlternativas.ForeColor = System.Drawing.Color.White
        Me.gpAlternativas.Location = New System.Drawing.Point(24, 193)
        Me.gpAlternativas.Name = "gpAlternativas"
        Me.gpAlternativas.Size = New System.Drawing.Size(956, 307)
        Me.gpAlternativas.TabIndex = 50
        Me.gpAlternativas.TabStop = False
        Me.gpAlternativas.Text = "Alternativas"
        '
        'lblPlacar
        '
        Me.lblPlacar.AutoSize = True
        Me.lblPlacar.Font = New System.Drawing.Font("Buxton Sketch", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlacar.ForeColor = System.Drawing.Color.Yellow
        Me.lblPlacar.Location = New System.Drawing.Point(138, 41)
        Me.lblPlacar.Name = "lblPlacar"
        Me.lblPlacar.Size = New System.Drawing.Size(49, 39)
        Me.lblPlacar.TabIndex = 1
        Me.lblPlacar.Text = "00"
        '
        'gpPlacar
        '
        Me.gpPlacar.BackColor = System.Drawing.Color.Transparent
        Me.gpPlacar.Controls.Add(Me.lblPlacar)
        Me.gpPlacar.Controls.Add(Me.Label1)
        Me.gpPlacar.Location = New System.Drawing.Point(616, 508)
        Me.gpPlacar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.gpPlacar.Name = "gpPlacar"
        Me.gpPlacar.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.gpPlacar.Size = New System.Drawing.Size(221, 111)
        Me.gpPlacar.TabIndex = 51
        Me.gpPlacar.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(142, 508)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(362, 70)
        Me.PictureBox3.TabIndex = 58
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(857, 508)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(123, 111)
        Me.PictureBox2.TabIndex = 57
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(859, 620)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 26)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'QuizSul
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 650)
        Me.Controls.Add(Me.lblVcVenceu)
        Me.Controls.Add(Me.lblContinuar)
        Me.Controls.Add(Me.lblProxima)
        Me.Controls.Add(Me.gpQuestoes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.linkParar)
        Me.Controls.Add(Me.lblParabens)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gpAlternativas)
        Me.Controls.Add(Me.gpPlacar)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QuizSul"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz"
        Me.gpQuestoes.ResumeLayout(False)
        Me.gpAlternativas.ResumeLayout(False)
        Me.gpAlternativas.PerformLayout()
        Me.gpPlacar.ResumeLayout(False)
        Me.gpPlacar.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblVcVenceu As System.Windows.Forms.Label
    Friend WithEvents lblContinuar As System.Windows.Forms.Label
    Friend WithEvents lblProxima As System.Windows.Forms.Label
    Friend WithEvents rdbC As System.Windows.Forms.RadioButton
    Friend WithEvents rdbB As System.Windows.Forms.RadioButton
    Friend WithEvents rdbA As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdbD As System.Windows.Forms.RadioButton
    Friend WithEvents gpQuestoes As System.Windows.Forms.GroupBox
    Friend WithEvents txtQuestao As System.Windows.Forms.Label
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents linkParar As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblD As System.Windows.Forms.Label
    Friend WithEvents lblParabens As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gpAlternativas As System.Windows.Forms.GroupBox
    Friend WithEvents lblPlacar As System.Windows.Forms.Label
    Friend WithEvents gpPlacar As System.Windows.Forms.GroupBox
End Class
