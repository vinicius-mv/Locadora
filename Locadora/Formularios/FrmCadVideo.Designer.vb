<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadVideo
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
        Me.tabPrincipal = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvVideos = New System.Windows.Forms.DataGridView()
        Me.IdVideo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnoLancamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sinopse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorLocacaoDia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cboGenero = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.txtValorDia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSinopse = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLancamento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGeneroVideo = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtNomeVideo = New System.Windows.Forms.Label()
        Me.txtIdVideo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tabPrincipal.SuspendLayout
        Me.TabPage1.SuspendLayout
        CType(Me.dgvVideos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage2.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'tabPrincipal
        '
        Me.tabPrincipal.Controls.Add(Me.TabPage1)
        Me.tabPrincipal.Controls.Add(Me.TabPage2)
        Me.tabPrincipal.Location = New System.Drawing.Point(12, 12)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.SelectedIndex = 0
        Me.tabPrincipal.Size = New System.Drawing.Size(686, 305)
        Me.tabPrincipal.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvVideos)
        Me.TabPage1.Controls.Add(Me.btnPesquisar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(678, 279)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pesquisa"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'dgvVideos
        '
        Me.dgvVideos.AllowUserToAddRows = false
        Me.dgvVideos.AllowUserToDeleteRows = false
        Me.dgvVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVideos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdVideo, Me.Nome, Me.Genero, Me.AnoLancamento, Me.Sinopse, Me.ValorLocacaoDia})
        Me.dgvVideos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvVideos.Location = New System.Drawing.Point(3, 36)
        Me.dgvVideos.Name = "dgvVideos"
        Me.dgvVideos.ReadOnly = true
        Me.dgvVideos.Size = New System.Drawing.Size(672, 240)
        Me.dgvVideos.TabIndex = 2
        '
        'IdVideo
        '
        Me.IdVideo.HeaderText = "id"
        Me.IdVideo.Name = "IdVideo"
        Me.IdVideo.ReadOnly = true
        '
        'Nome
        '
        Me.Nome.HeaderText = "nome"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = true
        '
        'Genero
        '
        Me.Genero.HeaderText = "Gênero"
        Me.Genero.Name = "Genero"
        Me.Genero.ReadOnly = true
        '
        'AnoLancamento
        '
        Me.AnoLancamento.HeaderText = "Lançamento"
        Me.AnoLancamento.Name = "AnoLancamento"
        Me.AnoLancamento.ReadOnly = true
        '
        'Sinopse
        '
        Me.Sinopse.HeaderText = "sinopse"
        Me.Sinopse.Name = "Sinopse"
        Me.Sinopse.ReadOnly = true
        '
        'ValorLocacaoDia
        '
        Me.ValorLocacaoDia.HeaderText = "valor-dia"
        Me.ValorLocacaoDia.Name = "ValorLocacaoDia"
        Me.ValorLocacaoDia.ReadOnly = true
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(6, 6)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisar.TabIndex = 1
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = true
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(678, 279)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cadastro"
        Me.TabPage2.UseVisualStyleBackColor = true
        '
        'cboGenero
        '
        Me.cboGenero.FormattingEnabled = true
        Me.cboGenero.Location = New System.Drawing.Point(113, 80)
        Me.cboGenero.Name = "cboGenero"
        Me.cboGenero.Size = New System.Drawing.Size(121, 21)
        Me.cboGenero.TabIndex = 6
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(219, 26)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = true
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(182, 222)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 12
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = true
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(101, 222)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 11
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = true
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(20, 222)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNovo.TabIndex = 10
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = true
        '
        'txtValorDia
        '
        Me.txtValorDia.Location = New System.Drawing.Point(113, 190)
        Me.txtValorDia.MaxLength = 20
        Me.txtValorDia.Name = "txtValorDia"
        Me.txtValorDia.Size = New System.Drawing.Size(100, 20)
        Me.txtValorDia.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(17, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Valor-Dia:"
        '
        'txtSinopse
        '
        Me.txtSinopse.Location = New System.Drawing.Point(113, 132)
        Me.txtSinopse.MaxLength = 255
        Me.txtSinopse.Multiline = true
        Me.txtSinopse.Name = "txtSinopse"
        Me.txtSinopse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSinopse.Size = New System.Drawing.Size(356, 52)
        Me.txtSinopse.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(17, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sinopse: "
        '
        'txtLancamento
        '
        Me.txtLancamento.Location = New System.Drawing.Point(113, 106)
        Me.txtLancamento.MaxLength = 20
        Me.txtLancamento.Name = "txtLancamento"
        Me.txtLancamento.Size = New System.Drawing.Size(356, 20)
        Me.txtLancamento.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(17, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ano Lançamento: "
        '
        'txtGeneroVideo
        '
        Me.txtGeneroVideo.AutoSize = true
        Me.txtGeneroVideo.Location = New System.Drawing.Point(17, 83)
        Me.txtGeneroVideo.Name = "txtGeneroVideo"
        Me.txtGeneroVideo.Size = New System.Drawing.Size(48, 13)
        Me.txtGeneroVideo.TabIndex = 0
        Me.txtGeneroVideo.Text = "Genero: "
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(113, 54)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(100, 20)
        Me.txtNome.TabIndex = 5
        '
        'txtNomeVideo
        '
        Me.txtNomeVideo.AutoSize = true
        Me.txtNomeVideo.Location = New System.Drawing.Point(17, 57)
        Me.txtNomeVideo.Name = "txtNomeVideo"
        Me.txtNomeVideo.Size = New System.Drawing.Size(41, 13)
        Me.txtNomeVideo.TabIndex = 0
        Me.txtNomeVideo.Text = "Nome: "
        '
        'txtIdVideo
        '
        Me.txtIdVideo.Location = New System.Drawing.Point(113, 28)
        Me.txtIdVideo.MaxLength = 20
        Me.txtIdVideo.Name = "txtIdVideo"
        Me.txtIdVideo.Size = New System.Drawing.Size(100, 20)
        Me.txtIdVideo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(17, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboGenero)
        Me.GroupBox1.Controls.Add(Me.txtIdVideo)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtNomeVideo)
        Me.GroupBox1.Controls.Add(Me.btnExcluir)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.btnSalvar)
        Me.GroupBox1.Controls.Add(Me.txtGeneroVideo)
        Me.GroupBox1.Controls.Add(Me.btnNovo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtValorDia)
        Me.GroupBox1.Controls.Add(Me.txtLancamento)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtSinopse)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 251)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Dados Vídeo"
        '
        'FrmCadVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 331)
        Me.Controls.Add(Me.tabPrincipal)
        Me.Name = "FrmCadVideo"
        Me.Text = "Vídeo"
        Me.tabPrincipal.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        CType(Me.dgvVideos,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage2.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents tabPrincipal As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvVideos As DataGridView
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents txtValorDia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSinopse As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLancamento As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGeneroVideo As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtNomeVideo As Label
    Friend WithEvents txtIdVideo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents cboGenero As ComboBox
    Friend WithEvents IdVideo As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Genero As DataGridViewTextBoxColumn
    Friend WithEvents AnoLancamento As DataGridViewTextBoxColumn
    Friend WithEvents Sinopse As DataGridViewTextBoxColumn
    Friend WithEvents ValorLocacaoDia As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
End Class
