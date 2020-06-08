<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadLocacao
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabPrincipal = New System.Windows.Forms.TabControl()
        Me.tabPesquisa = New System.Windows.Forms.TabPage()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.cboClientesBusca = New System.Windows.Forms.ComboBox()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.dgvPesquisa = New System.Windows.Forms.DataGridView()
        Me.tbPesquisa_IdLocacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbPesquisa_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbPesquisa_DataLocacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbPesquisa_DataPrevisaoDevolucao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbPesquisa_Video = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbPesquisa_ValorDia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbPesquisa_DataDevolucao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabCadLocacao = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgvVideos = New System.Windows.Forms.DataGridView()
        Me.idVideo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Video = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataLocacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrevisaoDevolucao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorLocacaoDia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemoveRow = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtValorDia = New System.Windows.Forms.TextBox()
        Me.cboVideo = New System.Windows.Forms.ComboBox()
        Me.txtAnoLancamento = New System.Windows.Forms.TextBox()
        Me.txtSinopse = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.gbxLocacao = New System.Windows.Forms.GroupBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDataDevolucao = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVarlorDevolucao = New System.Windows.Forms.TextBox()
        Me.txtDataLocacao = New System.Windows.Forms.MaskedTextBox()
        Me.txtDataPrevDevolucao = New System.Windows.Forms.MaskedTextBox()
        Me.txtValorPrevPagamento = New System.Windows.Forms.TextBox()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdLocacao = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.tabPrincipal.SuspendLayout()
        Me.tabPesquisa.SuspendLayout()
        CType(Me.dgvPesquisa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCadLocacao.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvVideos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.gbxLocacao.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabPrincipal
        '
        Me.tabPrincipal.Controls.Add(Me.tabPesquisa)
        Me.tabPrincipal.Controls.Add(Me.tabCadLocacao)
        Me.tabPrincipal.Location = New System.Drawing.Point(12, 12)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.SelectedIndex = 0
        Me.tabPrincipal.Size = New System.Drawing.Size(772, 644)
        Me.tabPrincipal.TabIndex = 0
        '
        'tabPesquisa
        '
        Me.tabPesquisa.Controls.Add(Me.btnExportar)
        Me.tabPesquisa.Controls.Add(Me.btnRelatorio)
        Me.tabPesquisa.Controls.Add(Me.cboClientesBusca)
        Me.tabPesquisa.Controls.Add(Me.btnPesquisar)
        Me.tabPesquisa.Controls.Add(Me.dgvPesquisa)
        Me.tabPesquisa.Controls.Add(Me.Label9)
        Me.tabPesquisa.Location = New System.Drawing.Point(4, 22)
        Me.tabPesquisa.Name = "tabPesquisa"
        Me.tabPesquisa.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPesquisa.Size = New System.Drawing.Size(764, 618)
        Me.tabPesquisa.TabIndex = 0
        Me.tabPesquisa.Text = "Pesquisa"
        Me.tabPesquisa.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(602, 30)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 23)
        Me.btnExportar.TabIndex = 4
        Me.btnExportar.Text = "Export Excel"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnRelatorio
        '
        Me.btnRelatorio.Location = New System.Drawing.Point(683, 30)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(75, 23)
        Me.btnRelatorio.TabIndex = 4
        Me.btnRelatorio.Text = "Relatório"
        Me.btnRelatorio.UseVisualStyleBackColor = True
        '
        'cboClientesBusca
        '
        Me.cboClientesBusca.FormattingEnabled = True
        Me.cboClientesBusca.Location = New System.Drawing.Point(9, 32)
        Me.cboClientesBusca.Name = "cboClientesBusca"
        Me.cboClientesBusca.Size = New System.Drawing.Size(270, 21)
        Me.cboClientesBusca.TabIndex = 1
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(285, 32)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisar.TabIndex = 2
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'dgvPesquisa
        '
        Me.dgvPesquisa.AllowUserToAddRows = False
        Me.dgvPesquisa.AllowUserToDeleteRows = False
        Me.dgvPesquisa.AllowUserToOrderColumns = True
        Me.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPesquisa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tbPesquisa_IdLocacao, Me.tbPesquisa_Cliente, Me.tbPesquisa_DataLocacao, Me.tbPesquisa_DataPrevisaoDevolucao, Me.tbPesquisa_Video, Me.tbPesquisa_ValorDia, Me.tbPesquisa_DataDevolucao})
        Me.dgvPesquisa.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvPesquisa.Location = New System.Drawing.Point(3, 61)
        Me.dgvPesquisa.Name = "dgvPesquisa"
        Me.dgvPesquisa.ReadOnly = True
        Me.dgvPesquisa.Size = New System.Drawing.Size(758, 554)
        Me.dgvPesquisa.TabIndex = 3
        '
        'tbPesquisa_IdLocacao
        '
        DataGridViewCellStyle11.NullValue = Nothing
        Me.tbPesquisa_IdLocacao.DefaultCellStyle = DataGridViewCellStyle11
        Me.tbPesquisa_IdLocacao.HeaderText = "id-Locação"
        Me.tbPesquisa_IdLocacao.MaxInputLength = 20
        Me.tbPesquisa_IdLocacao.Name = "tbPesquisa_IdLocacao"
        Me.tbPesquisa_IdLocacao.ReadOnly = True
        '
        'tbPesquisa_Cliente
        '
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.tbPesquisa_Cliente.DefaultCellStyle = DataGridViewCellStyle12
        Me.tbPesquisa_Cliente.HeaderText = "NomeCliente"
        Me.tbPesquisa_Cliente.MaxInputLength = 100
        Me.tbPesquisa_Cliente.Name = "tbPesquisa_Cliente"
        Me.tbPesquisa_Cliente.ReadOnly = True
        '
        'tbPesquisa_DataLocacao
        '
        DataGridViewCellStyle13.Format = "d"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.tbPesquisa_DataLocacao.DefaultCellStyle = DataGridViewCellStyle13
        Me.tbPesquisa_DataLocacao.HeaderText = "D. Locação"
        Me.tbPesquisa_DataLocacao.MaxInputLength = 20
        Me.tbPesquisa_DataLocacao.Name = "tbPesquisa_DataLocacao"
        Me.tbPesquisa_DataLocacao.ReadOnly = True
        '
        'tbPesquisa_DataPrevisaoDevolucao
        '
        DataGridViewCellStyle14.Format = "d"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.tbPesquisa_DataPrevisaoDevolucao.DefaultCellStyle = DataGridViewCellStyle14
        Me.tbPesquisa_DataPrevisaoDevolucao.HeaderText = "D. Prev. Dev"
        Me.tbPesquisa_DataPrevisaoDevolucao.MaxInputLength = 20
        Me.tbPesquisa_DataPrevisaoDevolucao.Name = "tbPesquisa_DataPrevisaoDevolucao"
        Me.tbPesquisa_DataPrevisaoDevolucao.ReadOnly = True
        '
        'tbPesquisa_Video
        '
        Me.tbPesquisa_Video.HeaderText = "Vídeo"
        Me.tbPesquisa_Video.MaxInputLength = 100
        Me.tbPesquisa_Video.Name = "tbPesquisa_Video"
        Me.tbPesquisa_Video.ReadOnly = True
        '
        'tbPesquisa_ValorDia
        '
        DataGridViewCellStyle15.Format = "C2"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.tbPesquisa_ValorDia.DefaultCellStyle = DataGridViewCellStyle15
        Me.tbPesquisa_ValorDia.HeaderText = "Valor Dia"
        Me.tbPesquisa_ValorDia.MaxInputLength = 20
        Me.tbPesquisa_ValorDia.Name = "tbPesquisa_ValorDia"
        Me.tbPesquisa_ValorDia.ReadOnly = True
        '
        'tbPesquisa_DataDevolucao
        '
        DataGridViewCellStyle16.Format = "d"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.tbPesquisa_DataDevolucao.DefaultCellStyle = DataGridViewCellStyle16
        Me.tbPesquisa_DataDevolucao.HeaderText = "D. Devolução"
        Me.tbPesquisa_DataDevolucao.MaxInputLength = 20
        Me.tbPesquisa_DataDevolucao.Name = "tbPesquisa_DataDevolucao"
        Me.tbPesquisa_DataDevolucao.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Nome Cliente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tabCadLocacao
        '
        Me.tabCadLocacao.Controls.Add(Me.GroupBox4)
        Me.tabCadLocacao.Controls.Add(Me.gbxLocacao)
        Me.tabCadLocacao.Location = New System.Drawing.Point(4, 22)
        Me.tabCadLocacao.Name = "tabCadLocacao"
        Me.tabCadLocacao.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCadLocacao.Size = New System.Drawing.Size(764, 618)
        Me.tabCadLocacao.TabIndex = 1
        Me.tabCadLocacao.Text = "Cadastro"
        Me.tabCadLocacao.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 202)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(744, 409)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Videos Locados"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgvVideos)
        Me.GroupBox6.Location = New System.Drawing.Point(10, 221)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(734, 188)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Relação de Video Adicionados"
        '
        'dgvVideos
        '
        Me.dgvVideos.AllowUserToAddRows = False
        Me.dgvVideos.AllowUserToDeleteRows = False
        Me.dgvVideos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVideos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idVideo, Me.Video, Me.DataLocacao, Me.PrevisaoDevolucao, Me.ValorLocacaoDia, Me.RemoveRow})
        Me.dgvVideos.Location = New System.Drawing.Point(6, 14)
        Me.dgvVideos.Name = "dgvVideos"
        Me.dgvVideos.ReadOnly = True
        Me.dgvVideos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvVideos.Size = New System.Drawing.Size(722, 178)
        Me.dgvVideos.TabIndex = 23
        '
        'idVideo
        '
        Me.idVideo.HeaderText = "idVideo"
        Me.idVideo.MaxInputLength = 20
        Me.idVideo.Name = "idVideo"
        Me.idVideo.ReadOnly = True
        Me.idVideo.Visible = False
        '
        'Video
        '
        Me.Video.HeaderText = "Vídeo"
        Me.Video.MaxInputLength = 100
        Me.Video.Name = "Video"
        Me.Video.ReadOnly = True
        Me.Video.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Video.Width = 97
        '
        'DataLocacao
        '
        DataGridViewCellStyle17.Format = "d"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.DataLocacao.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataLocacao.HeaderText = "D. Locação"
        Me.DataLocacao.MaxInputLength = 20
        Me.DataLocacao.Name = "DataLocacao"
        Me.DataLocacao.ReadOnly = True
        Me.DataLocacao.Width = 97
        '
        'PrevisaoDevolucao
        '
        DataGridViewCellStyle18.Format = "d"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.PrevisaoDevolucao.DefaultCellStyle = DataGridViewCellStyle18
        Me.PrevisaoDevolucao.HeaderText = "D. Prev. Devolução"
        Me.PrevisaoDevolucao.MaxInputLength = 20
        Me.PrevisaoDevolucao.Name = "PrevisaoDevolucao"
        Me.PrevisaoDevolucao.ReadOnly = True
        '
        'ValorLocacaoDia
        '
        DataGridViewCellStyle19.Format = "C2"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.ValorLocacaoDia.DefaultCellStyle = DataGridViewCellStyle19
        Me.ValorLocacaoDia.HeaderText = "Valor-Dia"
        Me.ValorLocacaoDia.MaxInputLength = 20
        Me.ValorLocacaoDia.Name = "ValorLocacaoDia"
        Me.ValorLocacaoDia.ReadOnly = True
        Me.ValorLocacaoDia.Width = 97
        '
        'RemoveRow
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle20.Padding = New System.Windows.Forms.Padding(2)
        Me.RemoveRow.DefaultCellStyle = DataGridViewCellStyle20
        Me.RemoveRow.HeaderText = ""
        Me.RemoveRow.Name = "RemoveRow"
        Me.RemoveRow.ReadOnly = True
        Me.RemoveRow.Text = ""
        Me.RemoveRow.Width = 97
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.btnAdicionar)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.txtValorDia)
        Me.GroupBox5.Controls.Add(Me.cboVideo)
        Me.GroupBox5.Controls.Add(Me.txtAnoLancamento)
        Me.GroupBox5.Controls.Add(Me.txtSinopse)
        Me.GroupBox5.Controls.Add(Me.txtGenero)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(734, 199)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Dados Principais"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(618, 31)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 13)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Valor Dia"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(623, 170)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(105, 23)
        Me.btnAdicionar.TabIndex = 22
        Me.btnAdicionar.Text = "Adicionar na Lista"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(512, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Ano Lançamento"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(27, 79)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Sinopse"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(358, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Gênero"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Vídeo"
        '
        'txtValorDia
        '
        Me.txtValorDia.Location = New System.Drawing.Point(621, 49)
        Me.txtValorDia.MaxLength = 20
        Me.txtValorDia.Name = "txtValorDia"
        Me.txtValorDia.ReadOnly = True
        Me.txtValorDia.Size = New System.Drawing.Size(107, 20)
        Me.txtValorDia.TabIndex = 20
        Me.txtValorDia.TabStop = False
        '
        'cboVideo
        '
        Me.cboVideo.Location = New System.Drawing.Point(6, 47)
        Me.cboVideo.Name = "cboVideo"
        Me.cboVideo.Size = New System.Drawing.Size(349, 21)
        Me.cboVideo.TabIndex = 17
        '
        'txtAnoLancamento
        '
        Me.txtAnoLancamento.Location = New System.Drawing.Point(515, 48)
        Me.txtAnoLancamento.MaxLength = 20
        Me.txtAnoLancamento.Name = "txtAnoLancamento"
        Me.txtAnoLancamento.ReadOnly = True
        Me.txtAnoLancamento.Size = New System.Drawing.Size(100, 20)
        Me.txtAnoLancamento.TabIndex = 19
        Me.txtAnoLancamento.TabStop = False
        '
        'txtSinopse
        '
        Me.txtSinopse.Location = New System.Drawing.Point(6, 95)
        Me.txtSinopse.MaxLength = 255
        Me.txtSinopse.Multiline = True
        Me.txtSinopse.Name = "txtSinopse"
        Me.txtSinopse.ReadOnly = True
        Me.txtSinopse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSinopse.Size = New System.Drawing.Size(722, 68)
        Me.txtSinopse.TabIndex = 21
        Me.txtSinopse.TabStop = False
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(361, 48)
        Me.txtGenero.MaxLength = 45
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.ReadOnly = True
        Me.txtGenero.Size = New System.Drawing.Size(148, 20)
        Me.txtGenero.TabIndex = 18
        Me.txtGenero.TabStop = False
        '
        'gbxLocacao
        '
        Me.gbxLocacao.Controls.Add(Me.btnSalvar)
        Me.gbxLocacao.Controls.Add(Me.btnExcluir)
        Me.gbxLocacao.Controls.Add(Me.btnNovo)
        Me.gbxLocacao.Controls.Add(Me.btnBuscar)
        Me.gbxLocacao.Controls.Add(Me.GroupBox1)
        Me.gbxLocacao.Controls.Add(Me.txtDataLocacao)
        Me.gbxLocacao.Controls.Add(Me.txtDataPrevDevolucao)
        Me.gbxLocacao.Controls.Add(Me.txtValorPrevPagamento)
        Me.gbxLocacao.Controls.Add(Me.cboCliente)
        Me.gbxLocacao.Controls.Add(Me.Label2)
        Me.gbxLocacao.Controls.Add(Me.Label5)
        Me.gbxLocacao.Controls.Add(Me.Label4)
        Me.gbxLocacao.Controls.Add(Me.Label3)
        Me.gbxLocacao.Controls.Add(Me.Label8)
        Me.gbxLocacao.Controls.Add(Me.Label1)
        Me.gbxLocacao.Controls.Add(Me.txtIdLocacao)
        Me.gbxLocacao.Controls.Add(Me.txtIdCliente)
        Me.gbxLocacao.Location = New System.Drawing.Point(7, 6)
        Me.gbxLocacao.Name = "gbxLocacao"
        Me.gbxLocacao.Size = New System.Drawing.Size(750, 262)
        Me.gbxLocacao.TabIndex = 0
        Me.gbxLocacao.TabStop = False
        Me.gbxLocacao.Text = "Dados Principais"
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(316, 36)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 25)
        Me.btnSalvar.TabIndex = 8
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(397, 36)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 25)
        Me.btnExcluir.TabIndex = 9
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(235, 36)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 25)
        Me.btnNovo.TabIndex = 7
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(88, 36)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDataDevolucao)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtVarlorDevolucao)
        Me.GroupBox1.Location = New System.Drawing.Point(557, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(193, 73)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recebimento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "D. Devolução"
        '
        'txtDataDevolucao
        '
        Me.txtDataDevolucao.Location = New System.Drawing.Point(4, 48)
        Me.txtDataDevolucao.Mask = "00/00/0000"
        Me.txtDataDevolucao.Name = "txtDataDevolucao"
        Me.txtDataDevolucao.Size = New System.Drawing.Size(66, 20)
        Me.txtDataDevolucao.TabIndex = 15
        Me.txtDataDevolucao.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(79, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Valor Pagamento"
        '
        'txtVarlorDevolucao
        '
        Me.txtVarlorDevolucao.Location = New System.Drawing.Point(82, 48)
        Me.txtVarlorDevolucao.MaxLength = 20
        Me.txtVarlorDevolucao.Name = "txtVarlorDevolucao"
        Me.txtVarlorDevolucao.Size = New System.Drawing.Size(105, 20)
        Me.txtVarlorDevolucao.TabIndex = 16
        '
        'txtDataLocacao
        '
        Me.txtDataLocacao.Location = New System.Drawing.Point(12, 153)
        Me.txtDataLocacao.Mask = "00/00/0000"
        Me.txtDataLocacao.Name = "txtDataLocacao"
        Me.txtDataLocacao.Size = New System.Drawing.Size(70, 20)
        Me.txtDataLocacao.TabIndex = 12
        Me.txtDataLocacao.ValidatingType = GetType(Date)
        '
        'txtDataPrevDevolucao
        '
        Me.txtDataPrevDevolucao.Location = New System.Drawing.Point(121, 153)
        Me.txtDataPrevDevolucao.Mask = "00/00/0000"
        Me.txtDataPrevDevolucao.Name = "txtDataPrevDevolucao"
        Me.txtDataPrevDevolucao.Size = New System.Drawing.Size(66, 20)
        Me.txtDataPrevDevolucao.TabIndex = 13
        Me.txtDataPrevDevolucao.ValidatingType = GetType(Date)
        '
        'txtValorPrevPagamento
        '
        Me.txtValorPrevPagamento.Location = New System.Drawing.Point(193, 154)
        Me.txtValorPrevPagamento.MaxLength = 20
        Me.txtValorPrevPagamento.Name = "txtValorPrevPagamento"
        Me.txtValorPrevPagamento.ReadOnly = True
        Me.txtValorPrevPagamento.Size = New System.Drawing.Size(113, 20)
        Me.txtValorPrevPagamento.TabIndex = 14
        Me.txtValorPrevPagamento.TabStop = False
        '
        'cboCliente
        '
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(88, 91)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(656, 21)
        Me.cboCliente.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(190, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Valor Prev. Pagamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "D. Prev. Dev."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "D. Locação"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "ID Locação"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Cliente"
        '
        'txtIdLocacao
        '
        Me.txtIdLocacao.Location = New System.Drawing.Point(10, 39)
        Me.txtIdLocacao.MaxLength = 20
        Me.txtIdLocacao.Name = "txtIdLocacao"
        Me.txtIdLocacao.Size = New System.Drawing.Size(70, 20)
        Me.txtIdLocacao.TabIndex = 5
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(12, 91)
        Me.txtIdCliente.MaxLength = 20
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.ReadOnly = True
        Me.txtIdCliente.Size = New System.Drawing.Size(70, 20)
        Me.txtIdCliente.TabIndex = 10
        Me.txtIdCliente.TabStop = False
        '
        'FrmCadLocacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 662)
        Me.Controls.Add(Me.tabPrincipal)
        Me.Name = "FrmCadLocacao"
        Me.Text = "Locação "
        Me.tabPrincipal.ResumeLayout(False)
        Me.tabPesquisa.ResumeLayout(False)
        Me.tabPesquisa.PerformLayout()
        CType(Me.dgvPesquisa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCadLocacao.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgvVideos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout
        Me.gbxLocacao.ResumeLayout(false)
        Me.gbxLocacao.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents tabPrincipal As TabControl
    Friend WithEvents tabPesquisa As TabPage
    Friend WithEvents tabCadLocacao As TabPage
    Friend WithEvents gbxLocacao As GroupBox
    Friend WithEvents cboCliente As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents txtValorPrevPagamento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtVarlorDevolucao As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtValorDia As TextBox
    Friend WithEvents cboVideo As ComboBox
    Friend WithEvents txtAnoLancamento As TextBox
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtSinopse As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgvVideos As DataGridView
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents txtDataDevolucao As MaskedTextBox
    Friend WithEvents txtDataPrevDevolucao As MaskedTextBox
    Friend WithEvents txtDataLocacao As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents cboClientesBusca As ComboBox
    Friend WithEvents dgvPesquisa As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIdLocacao As TextBox
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents tbPesquisa_IdLocacao As DataGridViewTextBoxColumn
    Friend WithEvents tbPesquisa_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents tbPesquisa_DataLocacao As DataGridViewTextBoxColumn
    Friend WithEvents tbPesquisa_DataPrevisaoDevolucao As DataGridViewTextBoxColumn
    Friend WithEvents tbPesquisa_Video As DataGridViewTextBoxColumn
    Friend WithEvents tbPesquisa_ValorDia As DataGridViewTextBoxColumn
    Friend WithEvents tbPesquisa_DataDevolucao As DataGridViewTextBoxColumn
    Friend WithEvents idVideo As DataGridViewTextBoxColumn
    Friend WithEvents Video As DataGridViewTextBoxColumn
    Friend WithEvents DataLocacao As DataGridViewTextBoxColumn
    Friend WithEvents PrevisaoDevolucao As DataGridViewTextBoxColumn
    Friend WithEvents ValorLocacaoDia As DataGridViewTextBoxColumn
    Friend WithEvents RemoveRow As DataGridViewButtonColumn
    Friend WithEvents btnRelatorio As Button
    Friend WithEvents btnExportar As Button
End Class
