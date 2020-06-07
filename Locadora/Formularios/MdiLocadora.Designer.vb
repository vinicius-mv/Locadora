<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MdiLocadora
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCadastroUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCadastroCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCadastroAgenda = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCadastroGenero = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVideo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOperacional = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLocacao = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout
        Me.StatusStrip.SuspendLayout
        Me.SuspendLayout
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastro, Me.mnuOperacional})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(909, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mnuCadastro
        '
        Me.mnuCadastro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastroUsuario, Me.mnuCadastroCliente, Me.mnuCadastroAgenda, Me.mnuCadastroGenero, Me.mnuVideo})
        Me.mnuCadastro.Name = "mnuCadastro"
        Me.mnuCadastro.Size = New System.Drawing.Size(66, 20)
        Me.mnuCadastro.Text = "Cadastro"
        '
        'mnuCadastroUsuario
        '
        Me.mnuCadastroUsuario.Name = "mnuCadastroUsuario"
        Me.mnuCadastroUsuario.Size = New System.Drawing.Size(152, 22)
        Me.mnuCadastroUsuario.Text = "Usuário"
        '
        'mnuCadastroCliente
        '
        Me.mnuCadastroCliente.Name = "mnuCadastroCliente"
        Me.mnuCadastroCliente.Size = New System.Drawing.Size(152, 22)
        Me.mnuCadastroCliente.Text = "Cliente"
        '
        'mnuCadastroAgenda
        '
        Me.mnuCadastroAgenda.Name = "mnuCadastroAgenda"
        Me.mnuCadastroAgenda.Size = New System.Drawing.Size(152, 22)
        Me.mnuCadastroAgenda.Text = "Agenda"
        '
        'mnuCadastroGenero
        '
        Me.mnuCadastroGenero.Name = "mnuCadastroGenero"
        Me.mnuCadastroGenero.Size = New System.Drawing.Size(152, 22)
        Me.mnuCadastroGenero.Text = "Gênero"
        '
        'mnuVideo
        '
        Me.mnuVideo.Name = "mnuVideo"
        Me.mnuVideo.Size = New System.Drawing.Size(152, 22)
        Me.mnuVideo.Text = "Vídeo"
        '
        'mnuOperacional
        '
        Me.mnuOperacional.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLocacao})
        Me.mnuOperacional.Name = "mnuOperacional"
        Me.mnuOperacional.Size = New System.Drawing.Size(83, 20)
        Me.mnuOperacional.Text = "Operacional"
        '
        'mnuLocacao
        '
        Me.mnuLocacao.Name = "mnuLocacao"
        Me.mnuLocacao.Size = New System.Drawing.Size(152, 22)
        Me.mnuLocacao.Text = "Locação"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(909, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MdiLocadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = true
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MdiLocadora"
        Me.Text = "Sistema de Gerenciamento de Locadora - SisGeLoc"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(false)
        Me.MenuStrip.PerformLayout
        Me.StatusStrip.ResumeLayout(false)
        Me.StatusStrip.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuCadastro As ToolStripMenuItem
    Friend WithEvents mnuCadastroUsuario As ToolStripMenuItem
    Friend WithEvents mnuCadastroCliente As ToolStripMenuItem
    Friend WithEvents mnuCadastroAgenda As ToolStripMenuItem
    Friend WithEvents mnuCadastroGenero As ToolStripMenuItem
    Friend WithEvents mnuVideo As ToolStripMenuItem
    Friend WithEvents mnuOperacional As ToolStripMenuItem
    Friend WithEvents mnuLocacao As ToolStripMenuItem
End Class
