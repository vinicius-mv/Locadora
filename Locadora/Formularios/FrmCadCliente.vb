
Imports Locadora.ClassesGenerica

Public Class FrmCadCliente

    Private Sub btnPesquisarCliente_Click(sender As Object, e As EventArgs) Handles btnPesquisarCliente.Click
        Dim con = New Connection()
        Try
            'dgvClientes.RowCount = 0
            dgvClientes.Rows.Clear()

            con.OpenConnection()
            Dim listaClientes = New ClienteAction().Lista(con)
            con.CloseConnection()

            For i As Integer = 0 To listaClientes.Count - 1
                Dim cliente = listaClientes(i)
                dgvClientes.Rows.Add()
                dgvClientes.Item("IdCliente", i).Value = cliente.IdCliente
                dgvClientes.Item("NomeCliente", i).Value = cliente.Nome
            Next

        Catch ex As Exception
            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim con As New Connection()
        Try
            If String.IsNullOrEmpty(txtNomeCliente.Text) Then
                MsgBox("Registro não encontrado para alteração.")
                Return
            End If

            Dim cliente = New Cliente()
            Dim clienteAction = New ClienteAction()

            cliente.IdCliente = txtIdCliente.Text
            cliente.Nome = txtNomeCliente.Text

            con.OpenConnection()
            Dim result = clienteAction.Salvar(con, cliente)
            con.CloseConnection()

            If result > 0 Then
                MsgBox("Salvo com sucesso.")
                txtIdCliente.Text = result
            End If

        Catch ex As Exception
            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try
            MsgBox(ex.Message)

        Finally
            botoesLayoutPadrao()
            ApagaTextBoxes()

        End Try
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Try
            If btnNovo.Text = "Novo" Then
                ApagaTextBoxes()
                botoesLayoutInserirNovo()

            Else 'btnNovo.Text = "Cancelar" 
                botoesLayoutPadrao()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtIdCliente_TextChanged(sender As Object, e As EventArgs) Handles txtIdCliente.TextChanged
        txtNomeCliente.Text = ""
    End Sub

    Private Sub btnBuscarId_Click(sender As Object, e As EventArgs) Handles btnBuscarId.Click
        Try
            If Not IsNumeric(txtIdCliente.Text) Then
                MsgBox("id inválido.")
                Return
            End If

            Dim con = New Connection()
            con.OpenConnection()

            Dim clienteAction = New ClienteAction()
            Dim id As UInteger = txtIdCliente.Text

            Dim cliente = clienteAction.Detalhe(con, id)

            'id = 0, registro não encontrado
            If cliente.IdCliente = 0 Then
                MsgBox("Não encontrado id: " & id)
                Return
            End If

            txtIdCliente.Text = cliente.IdCliente
            txtNomeCliente.Text = cliente.Nome

            con.CloseConnection()

        Catch ex As ArgumentException
            MsgBox("Não encontrado nenhum registro com a id informada.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim con As New Connection()
        Try
            If String.IsNullOrEmpty(txtIdCliente.Text) OrElse txtIdCliente.Text <= 0 Then
                MsgBox("id informado é inválido.")
                txtIdCliente.Focus()
                Return
            End If

            Dim clienteAction As New ClienteAction()
            Dim idCliente As UInteger = txtIdCliente.Text

            con.OpenConnection()

            If clienteAction.Excluir(con, idCliente) Then
                MsgBox("Cliente id: " & idCliente & " excluído com sucesso.")
                ApagaTextBoxes()
            End If

            con.CloseConnection()

        Catch ex As Exception
            Try
                con.CloseConnection()
            Catch ex1 As Exception
                MsgBox(ex.Message)
            End Try
        End Try

    End Sub

    Private Sub ApagaTextBoxes()
        txtIdCliente.Text = 0
        txtNomeCliente.Text = ""
    End Sub

    Private Sub botoesLayoutInserirNovo()
        txtIdCliente.Enabled = False
        btnNovo.Text = "Cancelar"
        btnExcluir.Enabled = False
    End Sub

    Private Sub botoesLayoutPadrao()
        txtIdCliente.Enabled = True
        btnNovo.Text = "Novo"
        btnExcluir.Enabled = True
    End Sub
End Class