Imports Locadora.ClassesGenerica

Public Class FrmCadGenero

    Private Sub btnPesquisarGenero_Click(sender As Object, e As EventArgs) Handles btnPesquisarGenero.Click
        Try
            Dim con As New Connection()
            con.OpenConnection()

            'dgvGenero.RowCount = 0
            dgvGenero.Rows.Clear()

            Dim listaGeneros = New GeneroAction().Lista(con)

            For i As Integer = 0 To listaGeneros.Count - 1
                dgvGenero.Rows.Add()
                dgvGenero.Item("IdGenero", i).Value = listaGeneros(i).IdGenero
                dgvGenero.Item("Nome", i).Value = listaGeneros(i).Nome
            Next

            con.CloseConnection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarGenero_Click(sender As Object, e As EventArgs) Handles btnBuscarGenero.Click
        Try
            If Not IsNumeric(txtIdGenero.Text) Then
                MsgBox("id inválido.")
                Return
            End If

            Dim generoAction As New GeneroAction()
            Dim con As New Connection()

            con.OpenConnection()
            Dim genero As New Genero()
            Dim id As UShort = txtIdGenero.Text

            genero = generoAction.Detalhe(con, id)

            'id = 0, registro não encontrado
            If genero.IdGenero = 0 Then
                MsgBox("Não encontrado id: " & id)
                Return
            End If

            txtIdGenero.Text = genero.IdGenero
            txtNomeGenero.Text = genero.Nome

            con.CloseConnection()

        Catch ex As ArgumentException
            MsgBox("Não encontrado nenhum registro com a id informada.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnNovoGenero_Click(sender As Object, e As EventArgs) Handles btnNovoGenero.Click
        Try
            If btnNovoGenero.Text = "Novo" Then

                ApagaTextBoxes()
                BotoesLayoutInserirNovo()

            Else 
                ApagaTextBoxes()
                BotoesLayoutPadrao()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSalvarGenero_Click(sender As Object, e As EventArgs) Handles btnSalvarGenero.Click
        Dim con As New Connection()
        Try
            If String.IsNullOrEmpty(txtNomeGenero.Text) Then
                MsgBox("Insira o Genêro.")
                Return
            End If

            Dim generoAction As New GeneroAction()
            Dim genero As New Genero()

            genero.IdGenero = txtIdGenero.Text
            genero.Nome = txtNomeGenero.Text

            
            con.OpenConnection()
            Dim result = generoAction.Salvar(con, genero)
            con.CloseConnection()

            If result > 0 Then
                MsgBox("Salvo com sucesso.")
                txtIdGenero.Text = result
            End If

            BotoesLayoutPadrao()

        Catch ex As Exception
            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnExcluirGenero_Click(sender As Object, e As EventArgs) Handles btnExcluirGenero.Click
        Dim con As New Connection()
        Try
            If String.IsNullOrEmpty(txtNomeGenero.Text) OrElse txtIdGenero.Text <= 0 Then
                MsgBox("ID Gênero inválido.")
                txtIdGenero.Focus()
                Return
            End If

            con.OpenConnection()

            Dim generoAction As New GeneroAction()
            Dim id As UShort = txtIdGenero.Text

            If generoAction.Excluir(con, id) Then
                MsgBox("Genêro id: " & id & " excluído com sucesso.")
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
        txtIdGenero.Text = 0
        txtNomeGenero.Text = ""
    End Sub

    Private Sub txtCodigoGenero_TextChanged(sender As Object, e As EventArgs) Handles txtIdGenero.TextChanged
        txtNomeGenero.Text = ""
    End Sub

    Private Sub BotoesLayoutInserirNovo()
        txtIdGenero.Enabled = False
        btnNovoGenero.Text = "Cancelar"
        btnExcluirGenero.Enabled = False
    End Sub

    Private Sub BotoesLayoutPadrao()
        btnNovoGenero.Text = "Novo"
        txtIdGenero.Enabled = True
        btnExcluirGenero.Enabled = True
    End Sub


End Class