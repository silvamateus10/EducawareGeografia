<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExcluirPerguntarCentro
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
        Dim Label8 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExcluirPerguntarCentro))
        Me.gpExcluirPerg = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtNumQuestExc = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvExcluirCentro = New System.Windows.Forms.DataGridView()
        Label8 = New System.Windows.Forms.Label()
        Me.gpExcluirPerg.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvExcluirCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(61, 33)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(25, 16)
        Label8.TabIndex = 0
        Label8.Text = "Nº"
        '
        'gpExcluirPerg
        '
        Me.gpExcluirPerg.Controls.Add(Me.Button1)
        Me.gpExcluirPerg.Controls.Add(Me.Button5)
        Me.gpExcluirPerg.Controls.Add(Label8)
        Me.gpExcluirPerg.Controls.Add(Me.txtNumQuestExc)
        Me.gpExcluirPerg.Location = New System.Drawing.Point(23, 270)
        Me.gpExcluirPerg.Name = "gpExcluirPerg"
        Me.gpExcluirPerg.Size = New System.Drawing.Size(587, 68)
        Me.gpExcluirPerg.TabIndex = 7
        Me.gpExcluirPerg.TabStop = False
        Me.gpExcluirPerg.Text = "Excluir Questões"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(415, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Fechar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(319, 28)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Excluir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtNumQuestExc
        '
        Me.txtNumQuestExc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumQuestExc.Location = New System.Drawing.Point(108, 30)
        Me.txtNumQuestExc.Name = "txtNumQuestExc"
        Me.txtNumQuestExc.Size = New System.Drawing.Size(39, 21)
        Me.txtNumQuestExc.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Educaware_Geografia.My.Resources.Resources.EducaWareLOGO
        Me.PictureBox1.Location = New System.Drawing.Point(159, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(318, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'dgvExcluirCentro
        '
        Me.dgvExcluirCentro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExcluirCentro.Location = New System.Drawing.Point(23, 140)
        Me.dgvExcluirCentro.Name = "dgvExcluirCentro"
        Me.dgvExcluirCentro.Size = New System.Drawing.Size(587, 114)
        Me.dgvExcluirCentro.TabIndex = 9
        '
        'ExcluirPerguntarCentro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 370)
        Me.Controls.Add(Me.dgvExcluirCentro)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gpExcluirPerg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ExcluirPerguntarCentro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Excluir Perguntas"
        Me.gpExcluirPerg.ResumeLayout(False)
        Me.gpExcluirPerg.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvExcluirCentro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpExcluirPerg As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtNumQuestExc As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvExcluirCentro As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
