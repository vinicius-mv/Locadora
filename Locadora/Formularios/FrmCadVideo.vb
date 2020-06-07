Imports Locadora.ClassesGenerica

Public Class FrmCadVideo

    Private _listaGenero As List(Of Genero)

    Private Sub FrmCadVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cboGenero.Items.Clear()

            Dim con = New Connection()
            con.OpenConnection()
            _listaGenero = New GeneroAction().Lista(con)

            For Each gen In _listaGenero
                cboGenero.Items.Add(gen)
            Next
            cboGenero.ValueMember = "IdGenero"
            cboGenero.DisplayMember = "Nome"

            con.CloseConnection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Try
            Dim con = New Connection()
            con.OpenConnection()

            dgvVideos.Rows.Clear()
            Dim listaVideo = New VideoAction().Lista(con)
            Dim listaGenero = New GeneroAction().Lista(con)

            con.CloseConnection()

            For i As Integer = 0 To listaVideo.Count - 1
                dgvVideos.Rows.Add()
                dgvVideos.Item("IdVideo", i).Value = listaVideo(i).IdVideo
                dgvVideos.Item("Nome", i).Value = listaVideo(i).Nome
                dgvVideos.Item("Genero", i).Value = listaGenero(i).Nome
                dgvVideos.Item("AnoLancamento", i).Value = listaVideo(i).AnoLancamento
                dgvVideos.Item("Sinopse", i).Value = listaVideo(i).Sinopse
                dgvVideos.Item("ValorLocacaoDia", i).Value = listaVideo(i).ValorLocacaoDia
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim con = New Connection()
        Try
            If Not IsNumeric(txtIdVideo.Text) Then
                MsgBox("id inválido.")
                Return
            End If

            Dim videoAction = New VideoAction()
            Dim id As UInteger = txtIdVideo.Text

            con.OpenConnection()
            Dim video = videoAction.Detalhe(con, id)
            con.CloseConnection()

            'id = 0, registro não encontrado
            If video.IdVideo = 0 Then
                MsgBox("Não encontrado id: " & id)
                Return
            End If

            txtIdVideo.Text = video.IdVideo
            txtNome.Text = video.Nome

            Dim indexGenero = EncontraIndexGeneroNaListaGenero(video)
            cboGenero.SelectedIndex = indexGenero

            txtLancamento.Text = video.AnoLancamento
            txtSinopse.Text = video.Sinopse
            txtValorDia.Text = video.ValorLocacaoDia

        Catch ex As Exception
            Try
                con.CloseConnection()
            Catch ex1 As Exception
                MsgBox(ex.Message)
            End Try
        End Try
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Try
            If btnNovo.Text = "Novo" Then
                ApagaTextBoxes()
                BotoesLayoutInserirNovo()

            Else 'btnNovo = "Cancelar"
                ApagaTextBoxes()
                BotoesLayoutPadrao()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim con = New Connection()
        Try

            If String.IsNullOrEmpty(txtNome.Text) Then
                MsgBox("Insira os dados do Video")
                Return
            End If

            Dim genero = CType(cboGenero.Items(cboGenero.SelectedIndex), Genero)

            Dim video = New Video()
            video.IdVideo = txtIdVideo.Text
            video.Nome = txtNome.Text
            video.IdGenero = genero.IdGenero
            video.AnoLancamento = txtLancamento.Text
            video.Sinopse = txtSinopse.Text
            video.ValorLocacaoDia = txtValorDia.Text

            con.OpenConnection()
            Dim result = New VideoAction().Salvar(con, video)
            con.CloseConnection()

            If result > 0 Then
                MsgBox("Salvo com sucesso.")
                txtIdVideo.Text = result
            End If

            BotoesLayoutPadrao()

        Catch ex As Exception
            Try
                con.CloseConnection()
                BotoesLayoutPadrao()

            Catch ex1 As Exception
            End Try
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim con = New Connection()
        Try
            If String.IsNullOrEmpty(txtIdVideo.Text) orelse txtIdVideo.Text <= 0 then
                MsgBox("id informado é inválido.")
                txtIdVideo.Focus()
                Return
            End If

            Dim videoAction = New VideoAction()
            Dim idVideo = txtIdVideo.Text

            con.OpenConnection()

            If videoAction.Excluir(con, idVideo) Then
                MsgBox("Video id: " & idVideo & " excluído com sucesso.")
                ApagaTextBoxes()
            End If

            con.CloseConnection()

        Catch ex As Exception
            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ApagaTextBoxes()
        txtIdVideo.Text = 0
        txtNome.Text = ""
        cboGenero.SelectedIndex = -1
        txtLancamento.Text = ""
        txtSinopse.Text = ""
        txtValorDia.Text = ""
    End Sub

    Private Sub txtIdVideo_TextChanged(sender As Object, e As EventArgs) Handles txtIdVideo.TextChanged
        'apaga todos os txtBoxes menos o ID
        txtNome.Text = ""
        cboGenero.SelectedIndex = -1
        txtLancamento.Text = ""
        txtSinopse.Text = ""
        txtValorDia.Text = ""
    End Sub

    'encontra o index do Genero na lista 
    'retorna Index como integer 
    Private Function EncontraIndexGeneroNaListaGenero(ByVal video As Video) As Integer

        Dim indexGenero As Integer = 0
        For Each gen In _listaGenero
            If gen.IdGenero = video.IdGenero Then
                Exit For
            End If
            indexGenero += 1
        Next
        Return indexGenero
    End Function

    Private Sub BotoesLayoutInserirNovo()
        txtIdVideo.Enabled = False
        btnNovo.Text = "Cancelar"
        btnExcluir.Enabled = False
    End Sub

    Private Sub BotoesLayoutPadrao()
        txtIdVideo.Enabled = True
        btnNovo.Text = "Novo"
        btnExcluir.Enabled = True
    End Sub

End Class