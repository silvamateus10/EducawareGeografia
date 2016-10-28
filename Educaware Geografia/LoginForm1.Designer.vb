<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtNomeADM As System.Windows.Forms.TextBox
    Friend WithEvents txtSenhaADM As System.Windows.Forms.TextBox
    Friend WithEvents btnOKADM As System.Windows.Forms.Button
    Friend WithEvents btnCancelADM As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm1))
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.txtNomeADM = New System.Windows.Forms.TextBox()
        Me.txtSenhaADM = New System.Windows.Forms.TextBox()
        Me.btnOKADM = New System.Windows.Forms.Button()
        Me.btnCancelADM = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LogarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdmToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.JogadorToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FaleConoscoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.GroupADM = New System.Windows.Forms.GroupBox()
        Me.GroupJog = New System.Windows.Forms.GroupBox()
        Me.btnCancelJog = New System.Windows.Forms.Button()
        Me.btnOKJog = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomeJog = New System.Windows.Forms.TextBox()
        Me.txtSenhaJog = New System.Windows.Forms.TextBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupADM.SuspendLayout()
        Me.GroupJog.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(6, 72)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Senha:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNomeADM
        '
        Me.txtNomeADM.Location = New System.Drawing.Point(9, 42)
        Me.txtNomeADM.Name = "txtNomeADM"
        Me.txtNomeADM.Size = New System.Drawing.Size(220, 20)
        Me.txtNomeADM.TabIndex = 1
        '
        'txtSenhaADM
        '
        Me.txtSenhaADM.Location = New System.Drawing.Point(6, 98)
        Me.txtSenhaADM.Name = "txtSenhaADM"
        Me.txtSenhaADM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaADM.Size = New System.Drawing.Size(220, 20)
        Me.txtSenhaADM.TabIndex = 3
        '
        'btnOKADM
        '
        Me.btnOKADM.Location = New System.Drawing.Point(9, 142)
        Me.btnOKADM.Name = "btnOKADM"
        Me.btnOKADM.Size = New System.Drawing.Size(94, 23)
        Me.btnOKADM.TabIndex = 4
        Me.btnOKADM.Text = "&OK"
        '
        'btnCancelADM
        '
        Me.btnCancelADM.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelADM.Location = New System.Drawing.Point(132, 140)
        Me.btnCancelADM.Name = "btnCancelADM"
        Me.btnCancelADM.Size = New System.Drawing.Size(94, 23)
        Me.btnCancelADM.TabIndex = 5
        Me.btnCancelADM.Text = "&Cancelar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogarComoToolStripMenuItem, Me.CadastroToolStripMenuItem, Me.FaleConoscoToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(671, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LogarComoToolStripMenuItem
        '
        Me.LogarComoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdmToolStrip, Me.JogadorToolStrip})
        Me.LogarComoToolStripMenuItem.Name = "LogarComoToolStripMenuItem"
        Me.LogarComoToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.LogarComoToolStripMenuItem.Text = "&Logar Como"
        '
        'AdmToolStrip
        '
        Me.AdmToolStrip.Name = "AdmToolStrip"
        Me.AdmToolStrip.Size = New System.Drawing.Size(150, 22)
        Me.AdmToolStrip.Text = "Administrador"
        '
        'JogadorToolStrip
        '
        Me.JogadorToolStrip.Name = "JogadorToolStrip"
        Me.JogadorToolStrip.Size = New System.Drawing.Size(150, 22)
        Me.JogadorToolStrip.Text = "Jogador"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.CadastroToolStripMenuItem.Text = "Cadastrar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(57, 6)
        '
        'FaleConoscoToolStripMenuItem
        '
        Me.FaleConoscoToolStripMenuItem.Name = "FaleConoscoToolStripMenuItem"
        Me.FaleConoscoToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.FaleConoscoToolStripMenuItem.Text = "Contato"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'lblNome
        '
        Me.lblNome.Location = New System.Drawing.Point(6, 16)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(220, 23)
        Me.lblNome.TabIndex = 7
        Me.lblNome.Text = "&Nome:"
        Me.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupADM
        '
        Me.GroupADM.Controls.Add(Me.lblNome)
        Me.GroupADM.Controls.Add(Me.PasswordLabel)
        Me.GroupADM.Controls.Add(Me.btnCancelADM)
        Me.GroupADM.Controls.Add(Me.txtNomeADM)
        Me.GroupADM.Controls.Add(Me.txtSenhaADM)
        Me.GroupADM.Controls.Add(Me.btnOKADM)
        Me.GroupADM.Location = New System.Drawing.Point(406, 38)
        Me.GroupADM.Name = "GroupADM"
        Me.GroupADM.Size = New System.Drawing.Size(238, 171)
        Me.GroupADM.TabIndex = 8
        Me.GroupADM.TabStop = False
        Me.GroupADM.Text = "Administrador"
        '
        'GroupJog
        '
        Me.GroupJog.Controls.Add(Me.btnCancelJog)
        Me.GroupJog.Controls.Add(Me.btnOKJog)
        Me.GroupJog.Controls.Add(Me.Label1)
        Me.GroupJog.Controls.Add(Me.Label2)
        Me.GroupJog.Controls.Add(Me.txtNomeJog)
        Me.GroupJog.Controls.Add(Me.txtSenhaJog)
        Me.GroupJog.Location = New System.Drawing.Point(421, 33)
        Me.GroupJog.Name = "GroupJog"
        Me.GroupJog.Size = New System.Drawing.Size(238, 168)
        Me.GroupJog.TabIndex = 9
        Me.GroupJog.TabStop = False
        Me.GroupJog.Text = "Jogador:"
        '
        'btnCancelJog
        '
        Me.btnCancelJog.Location = New System.Drawing.Point(123, 139)
        Me.btnCancelJog.Name = "btnCancelJog"
        Me.btnCancelJog.Size = New System.Drawing.Size(100, 23)
        Me.btnCancelJog.TabIndex = 11
        Me.btnCancelJog.Text = "&Cancelar"
        Me.btnCancelJog.UseVisualStyleBackColor = True
        '
        'btnOKJog
        '
        Me.btnOKJog.Location = New System.Drawing.Point(9, 139)
        Me.btnOKJog.Name = "btnOKJog"
        Me.btnOKJog.Size = New System.Drawing.Size(96, 23)
        Me.btnOKJog.TabIndex = 10
        Me.btnOKJog.Text = "&OK"
        Me.btnOKJog.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "&Gamertag:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Senha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNomeJog
        '
        Me.txtNomeJog.Location = New System.Drawing.Point(9, 42)
        Me.txtNomeJog.Name = "txtNomeJog"
        Me.txtNomeJog.Size = New System.Drawing.Size(220, 20)
        Me.txtNomeJog.TabIndex = 1
        '
        'txtSenhaJog
        '
        Me.txtSenhaJog.Location = New System.Drawing.Point(6, 98)
        Me.txtSenhaJog.Name = "txtSenhaJog"
        Me.txtSenhaJog.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaJog.Size = New System.Drawing.Size(220, 20)
        Me.txtSenhaJog.TabIndex = 3
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LogoPictureBox.Image = Global.Educaware_Geografia.My.Resources.Resources.EducaWareLOGO
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 38)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(378, 163)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'LoginForm1
        '
        Me.AcceptButton = Me.btnOKADM
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelADM
        Me.ClientSize = New System.Drawing.Size(671, 223)
        Me.Controls.Add(Me.GroupJog)
        Me.Controls.Add(Me.GroupADM)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupADM.ResumeLayout(False)
        Me.GroupADM.PerformLayout()
        Me.GroupJog.ResumeLayout(False)
        Me.GroupJog.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LogarComoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdmToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JogadorToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents GroupADM As System.Windows.Forms.GroupBox
    Friend WithEvents GroupJog As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomeJog As System.Windows.Forms.TextBox
    Friend WithEvents txtSenhaJog As System.Windows.Forms.TextBox
    Friend WithEvents CadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelJog As System.Windows.Forms.Button
    Friend WithEvents btnOKJog As System.Windows.Forms.Button
    Friend WithEvents FaleConoscoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
