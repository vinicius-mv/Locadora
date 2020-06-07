<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadGenero
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPesquisa = New System.Windows.Forms.TabPage()
        Me.dgvGenero = New System.Windows.Forms.DataGridView()
        Me.IdGenero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPesquisarGenero = New System.Windows.Forms.Button()
        Me.tabCadastro = New System.Windows.Forms.TabPage()
        Me.btnNovoGenero = New System.Windows.Forms.Button()
        Me.txtNomeGenero = New System.Windows.Forms.TextBox()
        Me.btnSalvarGenero = New System.Windows.Forms.Button()
        Me.txtIdGenero = New System.Windows.Forms.TextBox()
        Me.btnExcluirGenero = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscarGenero = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1.SuspendLayout
        Me.tabPesquisa.SuspendLayout
        CType(Me.dgvGenero,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabCadastro.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPesquisa)
        Me.TabControl1.Controls.Add(Me.tabCadastro)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(407, 345)
        Me.TabControl1.TabIndex = 0
        '
        'tabPesquisa
        '
        Me.tabPesquisa.Controls.Add(Me.dgvGenero)
        Me.tabPesquisa.Controls.Add(Me.btnPesquisarGenero)
        Me.tabPesquisa.Location = New System.Drawing.Point(4, 22)
        Me.tabPesquisa.Name = "tabPesquisa"
        Me.tabPesquisa.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPesquisa.Size = New System.Drawing.Size(399, 319)
        Me.tabPesquisa.TabIndex = 0
        Me.tabPesquisa.Text = "Pesquisa"
        Me.tabPesquisa.UseVisualStyleBackColor = true
        '
        'dgvGenero
        '
        Me.dgvGenero.AllowUserToAddRows = false
        Me.dgvGenero.AllowUserToDeleteRows = false
        Me.dgvGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGenero.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdGenero, Me.Nome})
        Me.dgvGenero.Location = New System.Drawing.Point(7, 37)
        Me.dgvGenero.Name = "dgvGenero"
        Me.dgvGenero.ReadOnly = true
        Me.dgvGenero.Size = New System.Drawing.Size(387, 276)
        Me.dgvGenero.TabIndex = 2
        '
        'IdGenero
        '
        Me.IdGenero.HeaderText = "id"
        Me.IdGenero.Name = "IdGenero"
        Me.IdGenero.ReadOnly = true
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = true
        '
        'btnPesquisarGenero
        '
        Me.btnPesquisarGenero.Location = New System.Drawing.Point(7, 7)
        Me.btnPesquisarGenero.Name = "btnPesquisarGenero"
        Me.btnPesquisarGenero.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisarGenero.TabIndex = 1
        Me.btnPesquisarGenero.Text = "Pesquisar"
        Me.btnPesquisarGenero.UseVisualStyleBackColor = true
        '
        'tabCadastro
        '
        Me.tabCadastro.Controls.Add(Me.GroupBox1)
        Me.tabCadastro.Location = New System.Drawing.Point(4, 22)
        Me.tabCadastro.Name = "tabCadastro"
        Me.tabCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCadastro.Size = New System.Drawing.Size(399, 319)
        Me.tabCadastro.TabIndex = 1
        Me.tabCadastro.Text = "Cadastro"
        Me.tabCadastro.UseVisualStyleBackColor = true
        '
        'btnNovoGenero
        '
        Me.btnNovoGenero.Location = New System.Drawing.Point(28, 128)
        Me.btnNovoGenero.Name = "btnNovoGenero"
        Me.btnNovoGenero.Size = New System.Drawing.Size(75, 23)
        Me.btnNovoGenero.TabIndex = 6
        Me.btnNovoGenero.Text = "Novo"
        Me.btnNovoGenero.UseVisualStyleBackColor = true
        '
        'txtNomeGenero
        '
        Me.txtNomeGenero.Location = New System.Drawing.Point(79, 74)
        Me.txtNomeGenero.MaxLength = 45
        Me.txtNomeGenero.Name = "txtNomeGenero"
        Me.txtNomeGenero.Size = New System.Drawing.Size(186, 20)
        Me.txtNomeGenero.TabIndex = 5
        '
        'btnSalvarGenero
        '
        Me.btnSalvarGenero.Location = New System.Drawing.Point(109, 128)
        Me.btnSalvarGenero.Name = "btnSalvarGenero"
        Me.btnSalvarGenero.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvarGenero.TabIndex = 7
        Me.btnSalvarGenero.Text = "Salvar"
        Me.btnSalvarGenero.UseVisualStyleBackColor = true
        '
        'txtIdGenero
        '
        Me.txtIdGenero.Location = New System.Drawing.Point(79, 37)
        Me.txtIdGenero.MaxLength = 20
        Me.txtIdGenero.Name = "txtIdGenero"
        Me.txtIdGenero.Size = New System.Drawing.Size(105, 20)
        Me.txtIdGenero.TabIndex = 3
        '
        'btnExcluirGenero
        '
        Me.btnExcluirGenero.Location = New System.Drawing.Point(190, 128)
        Me.btnExcluirGenero.Name = "btnExcluirGenero"
        Me.btnExcluirGenero.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluirGenero.TabIndex = 8
        Me.btnExcluirGenero.Text = "Excluir"
        Me.btnExcluirGenero.UseVisualStyleBackColor = true
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(25, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gênero: "
        '
        'btnBuscarGenero
        '
        Me.btnBuscarGenero.Location = New System.Drawing.Point(190, 35)
        Me.btnBuscarGenero.Name = "btnBuscarGenero"
        Me.btnBuscarGenero.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarGenero.TabIndex = 4
        Me.btnBuscarGenero.Text = "Buscar"
        Me.btnBuscarGenero.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(25, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBuscarGenero)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnExcluirGenero)
        Me.GroupBox1.Controls.Add(Me.txtIdGenero)
        Me.GroupBox1.Controls.Add(Me.btnSalvarGenero)
        Me.GroupBox1.Controls.Add(Me.txtNomeGenero)
        Me.GroupBox1.Controls.Add(Me.btnNovoGenero)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 174)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Dados Gênero"
        '
        'FrmCadGenero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 359)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmCadGenero"
        Me.Text = "Gênero"
        Me.TabControl1.ResumeLayout(false)
        Me.tabPesquisa.ResumeLayout(false)
        CType(Me.dgvGenero,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabCadastro.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabPesquisa As TabPage
    Friend WithEvents tabCadastro As TabPage
    Friend WithEvents dgvGenero As DataGridView
    Friend WithEvents btnPesquisarGenero As Button
    Friend WithEvents IdGenero As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscarGenero As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExcluirGenero As Button
    Friend WithEvents txtIdGenero As TextBox
    Friend WithEvents btnSalvarGenero As Button
    Friend WithEvents txtNomeGenero As TextBox
    Friend WithEvents btnNovoGenero As Button
End Class
