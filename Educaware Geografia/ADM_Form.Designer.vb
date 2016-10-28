<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADM_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADM_Form))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CadastrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JogadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegiãoNordesteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegiãoCentroOesteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegiãoSudesteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegiãoSulToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JogosToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RankingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.LogarToolStripMenuItem, Me.SairToolStripMenuItem, Me.RankingToolStripMenuItem, Me.SairToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1310, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.CadastrarToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CadastroToolStripMenuItem.Text = "&Cadastro"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'CadastrarToolStripMenuItem
        '
        Me.CadastrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.ExluirToolStripMenuItem})
        Me.CadastrarToolStripMenuItem.Name = "CadastrarToolStripMenuItem"
        Me.CadastrarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CadastrarToolStripMenuItem.Text = "&Opções"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.EditarToolStripMenuItem.Text = "Editar Cadastro"
        '
        'ExluirToolStripMenuItem
        '
        Me.ExluirToolStripMenuItem.Name = "ExluirToolStripMenuItem"
        Me.ExluirToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ExluirToolStripMenuItem.Text = "Exluir Cadastro"
        '
        'LogarToolStripMenuItem
        '
        Me.LogarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JogadorToolStripMenuItem, Me.RegiãoNordesteToolStripMenuItem, Me.RegiãoCentroOesteToolStripMenuItem, Me.RegiãoSudesteToolStripMenuItem, Me.RegiãoSulToolStripMenuItem})
        Me.LogarToolStripMenuItem.Name = "LogarToolStripMenuItem"
        Me.LogarToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.LogarToolStripMenuItem.Text = "&Inserir Perguntas"
        '
        'JogadorToolStripMenuItem
        '
        Me.JogadorToolStripMenuItem.Name = "JogadorToolStripMenuItem"
        Me.JogadorToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.JogadorToolStripMenuItem.Text = "&Região Norte"
        '
        'RegiãoNordesteToolStripMenuItem
        '
        Me.RegiãoNordesteToolStripMenuItem.Name = "RegiãoNordesteToolStripMenuItem"
        Me.RegiãoNordesteToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RegiãoNordesteToolStripMenuItem.Text = "&Região Nordeste"
        '
        'RegiãoCentroOesteToolStripMenuItem
        '
        Me.RegiãoCentroOesteToolStripMenuItem.Name = "RegiãoCentroOesteToolStripMenuItem"
        Me.RegiãoCentroOesteToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RegiãoCentroOesteToolStripMenuItem.Text = "&Região Centro-Oeste"
        '
        'RegiãoSudesteToolStripMenuItem
        '
        Me.RegiãoSudesteToolStripMenuItem.Name = "RegiãoSudesteToolStripMenuItem"
        Me.RegiãoSudesteToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RegiãoSudesteToolStripMenuItem.Text = "Região Sudeste"
        '
        'RegiãoSulToolStripMenuItem
        '
        Me.RegiãoSulToolStripMenuItem.Name = "RegiãoSulToolStripMenuItem"
        Me.RegiãoSulToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RegiãoSulToolStripMenuItem.Text = "Região Sul"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JogosToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.SairToolStripMenuItem.Text = "Mercury Software"
        '
        'JogosToolStripMenuItem
        '
        Me.JogosToolStripMenuItem.Name = "JogosToolStripMenuItem"
        Me.JogosToolStripMenuItem.Size = New System.Drawing.Size(57, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(57, 6)
        '
        'RankingToolStripMenuItem
        '
        Me.RankingToolStripMenuItem.Name = "RankingToolStripMenuItem"
        Me.RankingToolStripMenuItem.Size = New System.Drawing.Size(12, 20)
        '
        'SairToolStripMenuItem1
        '
        Me.SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        Me.SairToolStripMenuItem1.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem1.Text = "&Sair"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Educaware_Geografia.My.Resources.Resources.EducaWareLOGO
        Me.PictureBox1.Location = New System.Drawing.Point(234, 232)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(897, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ADM_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1310, 665)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ADM_Form"
        Me.Text = "Educaware Geografia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RankingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CadastrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExluirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JogadorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegiãoNordesteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegiãoCentroOesteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegiãoSudesteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegiãoSulToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JogosToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator

End Class
