Imports System.Globalization
Imports Locadora.ClassesGenerica
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop

Public Class FrmCadLocacao

    Private _listaVideo As List(Of Video)

    Private _listaCliente As List(Of Cliente)

    Private _listaGenero As List(Of Genero)

    Private Sub FrmCadLocacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As Connection
        Try
            con = New Connection()

            con.OpenConnection()
            _listaCliente = New ClienteAction().Lista(con)
            _listaVideo = New VideoAction().Lista(con)
            _listaGenero = New GeneroAction().Lista(con)
            con.CloseConnection()

            CarregaComboBoxCliente()
            cboCliente.DisplayMember = "Nome"

            CarregaComboBoxVideo()
            cboVideo.DisplayMember = "Nome"

            BotoesLayoutPadrao()

        Catch ex As Exception
            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged
        Try
            If cboCliente.SelectedIndex < 0 Then
                Return
            End If

            Dim cliente = New Cliente()
            cliente = CType(cboCliente.Items(cboCliente.SelectedIndex), Cliente)
            txtIdCliente.Text = cliente.IdCliente
            txtDataLocacao.Text = Date.Today
            txtDataPrevDevolucao.Text = Date.Today.AddDays(1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CarregaComboBoxCliente()
        For Each cliente In _listaCliente
            cboCliente.Items.Add(cliente)
            cboClientesBusca.Items.Add(cliente)
        Next
        cboCliente.DisplayMember = "Nome"
        cboClientesBusca.DisplayMember = "Nome"
    End Sub

    Private Sub CarregaComboBoxVideo()
        For Each video As Video In _listaVideo
            cboVideo.Items.Add(video)
        Next
    End Sub

    Private Sub cboVideo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVideo.SelectedIndexChanged
        Try
            If cboVideo.SelectedIndex = -1 Then
                Return
            End If

            Dim video = CType(cboVideo.Items(cboVideo.SelectedIndex), Video)
            txtAnoLancamento.Text = video.AnoLancamento
            txtValorDia.Text = video.ValorLocacaoDia
            txtSinopse.Text = video.Sinopse

            Dim indexGenero = EncontraIndexGeneroNaListaGenero(video.IdGenero)
            txtGenero.Text = _listaGenero.Item(indexGenero).Nome
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click

        Dim video = CType(cboVideo.Items(cboVideo.SelectedIndex), Video)

        For Each row As DataGridViewRow In dgvVideos.Rows
            If row.Cells("Video").Value = video.Nome Then
                MsgBox("Vídeo já adicionado.")
                Return
            End If
        Next

        Dim locacao = New Locacao()
        locacao.DataLocacao = txtDataLocacao.Text
        locacao.PrevisaoDevolucao = txtDataPrevDevolucao.Text
        locacao.DataDevolucao = Nothing
        locacao.ValorDevolucao = 0

        With dgvVideos
            .Rows.Add()
            Dim indexRow = .Rows.Count - 1
            .Item("idVideo", indexRow).Value = video.IdVideo
            .Item("Video", indexRow).Value = video.Nome
            .Item("DataLocacao", indexRow).Value = locacao.DataLocacao.ToString("dd/MM/yyyy")
            .Item("PrevisaoDevolucao", indexRow).Value = locacao.PrevisaoDevolucao.ToString("dd/MM/yyyy")
            .Item("ValorLocacaoDia", indexRow).Value = txtValorDia.Text
            .Item("RemoveRow", indexRow).Value = "excluir"
        End With

        'libera o botao excluir na dgv
        dgvVideos.Columns("RemoveRow").Visible = True
        CalculaValorPagamento()
        cboVideo.Focus()

    End Sub

    Private Sub txtValorDia_TextChanged(sender As Object, e As EventArgs) Handles txtValorDia.TextChanged

        If String.IsNullOrEmpty(txtDataLocacao.Text) Or String.IsNullOrEmpty(txtDataPrevDevolucao.Text) Then
            Return
        End If

        CalculaValorPagamento()

    End Sub

    Private Sub dgvVideos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVideos.CellClick
        'click no btn RemoverRow da dataGridView 
        If e.ColumnIndex = 5 Then
            dgvVideos.Rows.Remove(dgvVideos.Rows(e.RowIndex))
        End If

    End Sub

    Private Sub txtDataPrevDevolucao_Leave(sender As Object, e As EventArgs) Handles txtDataPrevDevolucao.Leave

        If txtDataPrevDevolucao.Text = "  /  /" OrElse String.IsNullOrEmpty(txtDataPrevDevolucao.Text) Then
            CalculaValorPagamento()
        End If

    End Sub

    Private Sub txtDataLocacao_Leave(sender As Object, e As EventArgs) Handles txtDataLocacao.Leave

        If String.IsNullOrEmpty(txtDataLocacao.Text) Or String.IsNullOrEmpty(txtDataPrevDevolucao.Text) Or String.IsNullOrEmpty(txtValorDia.Text) Then
            Return
        End If

        CalculaValorPagamento()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim con As Connection
        Try
            Dim cliente = CType(cboCliente.Items(cboCliente.SelectedIndex), Cliente)
            Dim locacao = New Locacao()

            If txtIdLocacao.Text = 0 Then 'Inseri Nova Locação

                locacao.IdLocacao = 0
                locacao.IdCliente = cliente.IdCliente
                locacao.DataLocacao = Date.Parse(txtDataLocacao.Text)
                locacao.PrevisaoDevolucao = Date.Parse(txtDataPrevDevolucao.Text)
                locacao.DataDevolucao = Date.MinValue
                locacao.ValorDevolucao = 0.0

                Dim locacaoAction = New LocacaoAction()

                con = New Connection()
                con.OpenConnection()
                con.OpenTransaction()

                locacao.IdLocacao = locacaoAction.Salvar(con, locacao)
                SalvaRowsDoDgvVideoNoBD(con, locacao.IdLocacao)

                con.Transaction.Commit()
                con.CloseConnection()

            Else 'atualiza dados da Locação - Pagamento

                locacao.IdLocacao = txtIdLocacao.Text
                locacao.IdCliente = cliente.IdCliente
                locacao.DataLocacao = Date.Parse(txtDataLocacao.Text)
                locacao.PrevisaoDevolucao = Date.Parse(txtDataPrevDevolucao.Text)
                locacao.DataDevolucao = txtDataDevolucao.Text
                locacao.ValorDevolucao = txtVarlorDevolucao.Text

                Dim locacaoAction = New LocacaoAction()
                Dim locacaoVideoAction = New LocacaoVideoAction()

                con = New Connection()
                con.OpenConnection()
                con.OpenTransaction()

                locacao.IdLocacao = locacaoAction.Salvar(con, locacao)
                locacaoVideoAction.ExcluirPorIdLocacao(con, locacao.IdLocacao) 'exclui rows da tbLocacaoVideo
                SalvaRowsDoDgvVideoNoBD(con, locacao.IdLocacao)  'reinsere com os dados atualizados

                con.CommitTransaction()
                con.CloseConnection()

            End If

            MsgBox("Salvo com sucesso.")

        Catch ex As Exception
            Try
                con.RollBackTransaction()
                con.CloseConnection()
                BotoesLayoutPadrao()
            Catch ex1 As Exception
            End Try
            MsgBox(ex.Message)
        Finally
            BotoesLayoutPadrao()
            LimpaControles()
        End Try
    End Sub

    'salva cada row da dgvVideos na tabela LocacaoVideo, com o respectivo idLocacao vinculado
    Private Sub SalvaRowsDoDgvVideoNoBD(ByRef con As Connection, ByVal idLocacao As UInteger)
        Try
            For Each row In dgvVideos.Rows
                Dim locacaoVideo = New LocacaoVideo()
                locacaoVideo.IdLocacaoVideo = 0
                locacaoVideo.IdLocacao = idLocacao
                locacaoVideo.IdVideo = row.Cells("idVideo").Value
                locacaoVideo.ValorDia = row.Cells("ValorLocacaoDia").Value

                Dim locacaoVideoAction = New LocacaoVideoAction()

                locacaoVideo.IdLocacaoVideo = locacaoVideoAction.Salvar(con, locacaoVideo)

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click

        If cboClientesBusca.SelectedIndex < 0 Then
            MsgBox("Selecione um cliente para efetuar a pesquisa.")
            Return
        End If

        Dim con = New Connection()
        Try
            dgvPesquisa.Rows.Clear()
            Dim cliente = CType(cboClientesBusca.Items(cboClientesBusca.SelectedIndex), Cliente)

            con.OpenConnection()
            Dim dt = New LocacaoAction().GetDataTableLocacaoPorIdCliente(con, cliente.IdCliente)
            con.CloseConnection()

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    dgvPesquisa.Rows.Add()
                    dgvPesquisa.Item("tbPesquisa_idLocacao", i).Value = CType(dt.Rows(i).Item(0), Integer)
                    dgvPesquisa.Item("tbPesquisa_Cliente", i).Value = dt.Rows(i).Item(1)
                    dgvPesquisa.Item("tbPesquisa_DataLocacao", i).Value = dt.Rows(i).Item(2)
                    dgvPesquisa.Item("tbPesquisa_DataPrevisaoDevolucao", i).Value = dt.Rows(i).Item(3)
                    dgvPesquisa.Item("tbPesquisa_Video", i).Value = dt.Rows(i).Item(4)
                    dgvPesquisa.Item("tbPesquisa_ValorDia", i).Value = dt.Rows(i).Item(5)
                    dgvPesquisa.Item("tbPesquisa_DataDevolucao", i).Value = dt.Rows(i).Item(6)

                    If Not IsDBNull(dgvPesquisa.Item("tbPesquisa_DataDevolucao", i).Value) AndAlso dgvPesquisa.Item("tbPesquisa_DataDevolucao", i).Value <> Date.MinValue Then
                        dgvPesquisa.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                    End If
                Next
            Else
                MsgBox("Nenhum registro encontrado para o cliente informado.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        LimpaControles()
        If btnNovo.Text = "Novo" Then 'Modo Inserir Novo
            BotoesLayoutInserirNovo()
            txtIdLocacao.Text = 0

        Else 'btnNovo.Text = "Cancelar"
            BotoesLayoutPadrao()
            txtIdLocacao.Text = ""

        End If
    End Sub

    Private Sub LimpaControles()
        Try
            Dim controles = gbxLocacao.Controls

            For Each control In controles
                If control.GetType() = GetType(TextBox) Then
                    control.Text = ""
                End If

                If control.GetType() = GetType(MaskedTextBox) Then
                    control.Text = ""
                End If

                If control.GetType() = GetType(ComboBox) Then
                    Try
                        control.SelectedIndex = -1
                    Catch ex As Exception
                    End Try

                End If
            Next

            dgvVideos.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'excluir todos os registros LocacaoVideo associados ao idLocacao(FK)
    'excluir registro Locacao vinculado idLocacao(PK)
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim con As Connection = New Connection()
        Try

            If String.IsNullOrEmpty(txtIdLocacao.Text) OrElse Not IsNumeric(txtIdLocacao.Text) Then
                MsgBox("ID Locação é inválido.")
                txtIdLocacao.Focus()
                Return
            End If

            Dim idLocacao As UInteger = txtIdLocacao.Text

            Dim locacaoVideoAction = New LocacaoVideoAction()
            Dim locacaoAction = New LocacaoAction()

            con.OpenConnection()
            con.OpenTransaction()

            locacaoVideoAction.ExcluirPorIdLocacao(con, idLocacao)
            Dim result As Boolean = locacaoAction.Excluir(con, idLocacao)

            con.CommitTransaction()
            con.CloseConnection()

            If result Then
                MsgBox("Excluído com sucesso.")
            End If

        Catch ex As Exception
            Try
                con.RollBackTransaction()
            Catch ex1 As Exception
            End Try
            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try
            MsgBox(ex.Message)
        Finally
            LimpaControles()
            BotoesLayoutPadrao()
        End Try
    End Sub

    'Busca por IdLocação e preenche as TxtBoxes
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim con = New Connection()
        Try
            If String.IsNullOrEmpty(txtIdLocacao.Text) OrElse Not IsNumeric(txtIdLocacao.Text) Then
                MsgBox("idLocação inválido.")
                Return
            End If

            Dim idLocacao As UInteger = txtIdLocacao.Text

            'busca lista de LocacaoVideo e Detalhes da Locacao informada
            con.OpenConnection()
            Dim locacao = New LocacaoAction().Detalhes(con, idLocacao)
            Dim listaLocacaoVideo = New LocacaoVideoAction().ListaPorIdLocacao(con, idLocacao)
            con.CloseConnection()

            cboCliente.SelectedIndex = EncontraIndexClienteNaListaCliente(locacao.IdCliente)

            'preenche os textBoxes dataDevolução
            txtDataPrevDevolucao.Text = locacao.PrevisaoDevolucao
            txtDataLocacao.Text = locacao.DataLocacao
            If locacao.DataDevolucao.Ticks > Date.MinValue.Ticks Then
                txtDataDevolucao.Text = locacao.DataDevolucao
                CalculaValorPagamento()
            End If

            'limpa dgvVideos
            dgvVideos.Rows.Clear()

            'preenche dgvVideos
            For i As UInteger = 0 To listaLocacaoVideo.Count - 1

                Dim locacaoVideo = listaLocacaoVideo(i)
                Dim video = EncontraVideoPorIdVideoNaLista(locacaoVideo.IdVideo)

                dgvVideos.Rows.Add()
                With dgvVideos.Rows(i)
                    .Cells("idVideo").Value = locacaoVideo.IdVideo
                    .Cells("Video").Value = video.Nome
                    .Cells("DataLocacao").Value = locacao.DataLocacao
                    .Cells("PrevisaoDevolucao").Value = locacao.PrevisaoDevolucao
                    .Cells("ValorLocacaoDia").Value = locacaoVideo.ValorDia
                    .Cells("RemoveRow").Value = "excluir"
                End With
                'esconde o botão excluir
                dgvVideos.Columns("RemoveRow").Visible = False
            Next

            'carregar dados video
            'Dim cliente = CType(cboCliente.Items(indexCliente), Cliente)

        Catch ex As Exception
            Try
                con.CloseConnection()
            Catch ex1 As Exception

            End Try
            MsgBox(ex.Message)
        End Try
    End Sub

    'encontra o video por IdVideo na _listaVideo
    'retorna o Video ou nothing
    Private Function EncontraVideoPorIdVideoNaLista(ByVal idVideo As UInt32) As Video

        For Each video As Video In _listaVideo
            If video.IdVideo = idVideo Then
                Return video
            End If
        Next
        Return Nothing

    End Function

    'encontra o index do Genero na _listaGenero
    'retorna Index ou -1 
    Private Function EncontraIndexGeneroNaListaGenero(ByVal idGenero As UShort) As Integer 'retorna UShort ou -1

        Dim indexGenero As UShort = 0
        For Each gen In _listaGenero
            If gen.IdGenero = idGenero Then
                Return indexGenero
            End If
            indexGenero += 1
        Next
        Return -1
    End Function

    'encontra o index do Cliente na _listaCliente
    'retorna Index ou -1
    Private Function EncontraIndexClienteNaListaCliente(ByVal idCliente As UInteger) As Long 'retorna UInteger ou -1

        Dim indexCliente As UInteger = 0
        For Each cli In _listaCliente
            If cli.IdCliente = idCliente Then
                Return indexCliente
            End If
            indexCliente += 1
        Next
        Return -1
    End Function

    Private Sub BotoesLayoutPadrao()

        btnNovo.Text = "Novo"
        btnExcluir.Enabled = True
        btnBuscar.Enabled = True
        txtIdLocacao.Text = ""
        txtIdLocacao.Enabled = True
        btnAdicionar.Enabled = False

    End Sub

    Private Sub BotoesLayoutInserirNovo()

        btnNovo.Text = "Cancelar"
        btnExcluir.Enabled = False
        btnBuscar.Enabled = False
        txtIdLocacao.Enabled = False
        btnAdicionar.Enabled = True
    End Sub

    Private Sub txtDataDevolucao_Leave(sender As Object, e As EventArgs) Handles txtDataDevolucao.Leave
        CalculaValorPagamento()
    End Sub


    Private Sub CalculaValorPagamento()
        Try
            If String.IsNullOrEmpty(txtDataLocacao.Text) OrElse txtDataLocacao.Text = "  /  /" OrElse String.IsNullOrEmpty(txtDataPrevDevolucao.Text) OrElse txtDataPrevDevolucao.Text = "  /  /" Then
                Return
            End If

            'calcula valor previsão
            Dim date1 = Date.Parse(txtDataLocacao.Text)
            Dim date2 = Date.Parse(txtDataPrevDevolucao.Text)

            'calcula o valor diário total da locação
            Dim valorDia As Double = 0
            If date2.Ticks > date1.Ticks Then
                For Each row As DataGridViewRow In dgvVideos.Rows
                    valorDia += row.Cells("ValorLocacaoDia").Value()
                Next

                Dim ticks As ULong = date2.Ticks - date1.Ticks
                Dim days = New TimeSpan(ticks).Days
                txtValorPrevPagamento.Text = days * valorDia
            End If

            'calcula valor final pagamento
            If String.IsNullOrEmpty(txtDataDevolucao.Text) OrElse txtDataDevolucao.Text = "  /  /" Then
                Return
            End If

            Dim date3 = Date.Parse(txtDataDevolucao.Text)
            If date3.Ticks > date1.Ticks Then
                Dim ticks As ULong = date3.Ticks - date1.Ticks
                Dim days = New TimeSpan(ticks).Days
                txtVarlorDevolucao.Text = days * valorDia
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click

        Dim frmReport = New FrmRelLocacao()
        frmReport.ShowDialog()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            Dim xlApp = New Excel.Application()
            Dim xlWorkBook = xlApp.Workbooks.Add(Type.Missing)
            Dim xlWorkSheet As Excel.Worksheet

            Try
                xlWorkSheet = xlWorkBook.Sheets("Planilha1")
            Catch ex As Exception
                Try
                    xlWorkSheet = xlWorkBook.Sheets("Plan1")
                Catch ex1 As Exception
                End Try
            End Try

            xlApp.Visible = True

            For k = 1 To dgvPesquisa.ColumnCount
                xlWorkSheet.Cells(1, k) = dgvPesquisa.Columns(k - 1).HeaderText
                xlWorkSheet.Range("A1:G1").Interior.Color = Color.LightGray
                xlWorkSheet.Range("A1:G1").Font.Bold = True
            Next

            Dim i As Integer
            Dim j As Integer
            For i = 0 To dgvPesquisa.RowCount - 1
                For j = 0 To dgvPesquisa.ColumnCount - 1
                    xlWorkSheet.Cells(i + 2, j + 1) = dgvPesquisa.Item(j, i).Value
                Next
            Next
            'formatando valores R$
            xlWorkSheet.Columns(6).NumberFormat = "R$###,##0.00"
            'auto size cells
            xlWorkSheet.Columns.AutoFit()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class