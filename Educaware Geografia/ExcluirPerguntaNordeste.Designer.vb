<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExcluirPerguntaNordeste
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExcluirPerguntaNordeste))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gpExcluirPerg = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtNumQuestExc = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvExcluirNordeste = New System.Windows.Forms.DataGridView()
        Label8 = New System.Windows.Forms.Label()
        Me.gpExcluirPerg.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvExcluirNordeste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(30, 35)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(25, 16)
        Label8.TabIndex = 0
        Label8.Text = "Nº"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(491, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Fechar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gpExcluirPerg
        '
        Me.gpExcluirPerg.Controls.Add(Me.Button1)
        Me.gpExcluirPerg.Controls.Add(Me.Button5)
        Me.gpExcluirPerg.Controls.Add(Label8)
        Me.gpExcluirPerg.Controls.Add(Me.txtNumQuestExc)
        Me.gpExcluirPerg.Location = New System.Drawing.Point(35, 259)
        Me.gpExcluirPerg.Name = "gpExcluirPerg"
        Me.gpExcluirPerg.Size = New System.Drawing.Size(587, 69)
        Me.gpExcluirPerg.TabIndex = 10
        Me.gpExcluirPerg.TabStop = False
        Me.gpExcluirPerg.Text = "Excluir Questões"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(390, 32)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Excluir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtNumQuestExc
        '
        Me.txtNumQuestExc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumQuestExc.Location = New System.Drawing.Point(108, 35)
        Me.txtNumQuestExc.Name = "txtNumQuestExc"
        Me.txtNumQuestExc.Size = New System.Drawing.Size(39, 21)
        Me.txtNumQuestExc.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Educaware_Geografia.My.Resources.Resources.EducaWareLOGO
        Me.PictureBox1.Location = New System.Drawing.Point(171, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(318, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'dgvExcluirNordeste
        '
        Me.dgvExcluirNordeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExcluirNordeste.Location = New System.Drawing.Point(21, 126)
        Me.dgvExcluirNordeste.Name = "dgvExcluirNordeste"
        Me.dgvExcluirNordeste.Size = New System.Drawing.Size(616, 114)
        Me.dgvExcluirNordeste.TabIndex = 12
        '
        'ExcluirPerguntaNordeste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 347)
        Me.Controls.Add(Me.dgvExcluirNordeste)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gpExcluirPerg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ExcluirPerguntaNordeste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Excluir Pergunta"
        Me.gpExcluirPerg.ResumeLayout(False)
        Me.gpExcluirPerg.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvExcluirNordeste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents gpExcluirPerg As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtNumQuestExc As System.Windows.Forms.TextBox
    Friend WithEvents dgvExcluirNordeste As System.Windows.Forms.DataGridView
End Class
