<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadCliente
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
        Me.tbpPesquisa = New System.Windows.Forms.TabPage()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.IdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPesquisarCliente = New System.Windows.Forms.Button()
        Me.tbpCadastro = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscarId = New System.Windows.Forms.Button()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.tabPrincipal.SuspendLayout
        Me.tbpPesquisa.SuspendLayout
        CType(Me.dgvClientes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tbpCadastro.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'tabPrincipal
        '
        Me.tabPrincipal.Controls.Add(Me.tbpPesquisa)
        Me.tabPrincipal.Controls.Add(Me.tbpCadastro)
        Me.tabPrincipal.Location = New System.Drawing.Point(12, 12)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.SelectedIndex = 0
        Me.tabPrincipal.Size = New System.Drawing.Size(441, 313)
        Me.tabPrincipal.TabIndex = 0
        '
        'tbpPesquisa
        '
        Me.tbpPesquisa.Controls.Add(Me.dgvClientes)
        Me.tbpPesquisa.Controls.Add(Me.btnPesquisarCliente)
        Me.tbpPesquisa.Location = New System.Drawing.Point(4, 22)
        Me.tbpPesquisa.Name = "tbpPesquisa"
        Me.tbpPesquisa.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpPesquisa.Size = New System.Drawing.Size(433, 287)
        Me.tbpPesquisa.TabIndex = 0
        Me.tbpPesquisa.Text = "Pesquisa"
        Me.tbpPesquisa.UseVisualStyleBackColor = true
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = false
        Me.dgvClientes.AllowUserToDeleteRows = false
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCliente, Me.NomeCliente})
        Me.dgvClientes.Location = New System.Drawing.Point(6, 35)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(422, 246)
        Me.dgvClientes.TabIndex = 2
        '
        'IdCliente
        '
        Me.IdCliente.HeaderText = "id"
        Me.IdCliente.Name = "IdCliente"
        '
        'NomeCliente
        '
        Me.NomeCliente.HeaderText = "Nome"
        Me.NomeCliente.Name = "NomeCliente"
        '
        'btnPesquisarCliente
        '
        Me.btnPesquisarCliente.Location = New System.Drawing.Point(6, 6)
        Me.btnPesquisarCliente.Name = "btnPesquisarCliente"
        Me.btnPesquisarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisarCliente.TabIndex = 1
        Me.btnPesquisarCliente.Text = "Pesquisar"
        Me.btnPesquisarCliente.UseVisualStyleBackColor = true
        '
        'tbpCadastro
        '
        Me.tbpCadastro.Controls.Add(Me.GroupBox1)
        Me.tbpCadastro.Location = New System.Drawing.Point(4, 22)
        Me.tbpCadastro.Name = "tbpCadastro"
        Me.tbpCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCadastro.Size = New System.Drawing.Size(433, 287)
        Me.tbpCadastro.TabIndex = 1
        Me.tbpCadastro.Text = "Cadastro"
        Me.tbpCadastro.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExcluir)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBuscarId)
        Me.GroupBox1.Controls.Add(Me.txtIdCliente)
        Me.GroupBox1.Controls.Add(Me.btnNovo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnSalvar)
        Me.GroupBox1.Controls.Add(Me.txtNomeCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 134)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Dados do Cliente"
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(172, 89)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 8
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(23, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID: "
        '
        'btnBuscarId
        '
        Me.btnBuscarId.Location = New System.Drawing.Point(157, 24)
        Me.btnBuscarId.Name = "btnBuscarId"
        Me.btnBuscarId.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarId.TabIndex = 4
        Me.btnBuscarId.Text = "Buscar"
        Me.btnBuscarId.UseVisualStyleBackColor = true
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(51, 27)
        Me.txtIdCliente.MaxLength = 20
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCliente.TabIndex = 3
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(9, 89)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNovo.TabIndex = 6
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = true
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome: "
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(90, 89)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 7
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = true
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.Location = New System.Drawing.Point(51, 53)
        Me.txtNomeCliente.MaxLength = 100
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtNomeCliente.TabIndex = 5
        '
        'FrmCadCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 323)
        Me.Controls.Add(Me.tabPrincipal)
        Me.Name = "FrmCadCliente"
        Me.Text = "Cliente"
        Me.tabPrincipal.ResumeLayout(false)
        Me.tbpPesquisa.ResumeLayout(false)
        CType(Me.dgvClientes,System.ComponentModel.ISupportInitialize).EndInit
        Me.tbpCadastro.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents tabPrincipal As TabControl
    Friend WithEvents tbpPesquisa As TabPage
    Friend WithEvents tbpCadastro As TabPage
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnPesquisarCliente As Button
    Friend WithEvents IdCliente As DataGridViewTextBoxColumn
    Friend WithEvents NomeCliente As DataGridViewTextBoxColumn
    Friend WithEvents txtNomeCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnBuscarId As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
