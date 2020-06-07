Imports Locadora.ClassesGenerica

Public Class LocacaoAction

    Public Function Salvar(ByRef con As Connection, ByVal locacao As Locacao) As UInteger

        Try
            con.Command.Parameters.Clear()

            If locacao.IdLocacao = 0 Then 'Inserir nova locação

                locacao.IdLocacao = con.GeraCodigo("tblocacao", "idLocacao")

                con.Command.CommandText = "INSERT INTO tbLocacao ( " +
                    "idLocacao, idCliente, dataLocacao, previsaoDevolucao, valorPrevisao, dataDevolucao, valorDevolucao " +
                    ") VALUES ( " +
                    "@idLocacao, @idCliente, @dataLocacao, @previsaoDevolucao, @valorPrevisao, @dataDevolucao, valorDevolucao " +
                    ");"

            Else    'Atualizar Locacao 
                    'já excluído da tbLocacaoVideo os registro vinculado a esse idLocacao, 
                    'atualizar os dados do registro da Locacao
                con.Command.CommandText = "UPDATE tblocacao " +
                    "SET idCliente = @idCliente, dataLocacao = @dataLocacao, dataDevolucao = @dataDevolucao, valorDevolucao = @valorDevolucao " +
                    "WHERE idLocacao = @idLocacao"

            End If

            con.Command.Parameters.Add(con.InserirParametro(locacao.IdLocacao, "@idLocacao", DbType.UInt32))
            con.Command.Parameters.Add(con.InserirParametro(locacao.IdCliente, "@idCliente", DbType.UInt32))
            con.Command.Parameters.Add(con.InserirParametro(locacao.DataLocacao, "@dataLocacao", DbType.Date))
            con.Command.Parameters.Add(con.InserirParametro(locacao.PrevisaoDevolucao, "@previsaoDevolucao", DbType.Date))
            con.Command.Parameters.Add(con.InserirParametro(locacao.ValorPrevisao, "@valorPrevisao", DbType.Double))

            con.Command.Parameters.Add(con.InserirParametro(IIf(locacao.DataDevolucao = Date.MinValue, locacao.DataDevolucao, DBNull.Value), "@dataDevolucao", DbType.Date))

            con.Command.Parameters.Add(con.InserirParametro(locacao.ValorDevolucao, "@valorDevolucao", DbType.Double))

            con.Command.ExecuteNonQuery()

            Return locacao.IdLocacao

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [LocacaoAction - Salvar]: " + ex.Message)
        End Try
    End Function

    Public Function Lista(ByRef con As Connection) As List(Of Locacao)
        Try
            con.Command.Parameters.Clear()

            con.Command.CommandText = "SELECT idLocacao, idCliente, dataLocacao, previsaoDevolucao, valorPrevisao, dataDevolucao, valorDevolucao " +  
                                      "FROM tbLocacao; "

            Dim dt = con.ExecutaComandoDataTable()
            Dim listaLocacao = New List(Of Locacao)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim locacao = New Locacao()
                    locacao.IdLocacao = dt.Rows(i).Item("idLocacao")
                    locacao.IdCliente = dt.Rows(i).Item("idCliente")
                    locacao.DataLocacao = dt.Rows(i).Item("dataLocacao")
                    locacao.PrevisaoDevolucao = dt.Rows(i).Item("previsaoDevolucao")
                    locacao.DataDevolucao = dt.Rows(i).Item("dataDevolucao")
                    locacao.ValorDevolucao = dt.Rows(i).Item("valorDevolucao")

                    listaLocacao.Add(locacao)
                Next
            End If

            Return listaLocacao

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [LocacaoAction - Lista]: " + ex.Message)
        End Try
    End Function

    Public Function ListaPorIdCliente(ByRef con As Connection, ByVal idCliente As UInteger) As List(Of Locacao)
        Try
            con.Command.Parameters.Clear()

            con.Command.CommandText = "SELECT FROM tbLocacao WHERE idCliente = @idCliente"

            con.Command.Parameters.Add(con.InserirParametro(idCliente, "@idCliente", DbType.UInt32))

            Dim dt = con.ExecutaComandoDataTable()
            Dim listaLocacao = New List(Of Locacao)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim locacao = New Locacao()
                    locacao.IdLocacao = dt.Rows(i).Item("idLocacao")
                    locacao.IdCliente = dt.Rows(i).Item("idCliente")
                    locacao.DataLocacao = dt.Rows(i).Item("dataLocacao")
                    locacao.PrevisaoDevolucao = dt.Rows(i).Item("previsaoDevolucao")
                    locacao.DataDevolucao = dt.Rows(i).Item("previsaoDevolucao")
                    locacao.ValorDevolucao = dt.Rows(i).Item("valorDevolucao")

                    listaLocacao.Add(locacao)
                Next
            End If

            Return listaLocacao

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [LocacaoAction - ListaPorIdCliente]: " + ex.Message)
        End Try
    End Function

    Public Function GetDataTableLocacaoPorIdCliente(ByRef con As Connection, ByVal idCliente As UInteger) As DataTable
        Try
            con.Command.Parameters.Clear()

            con.Command.CommandText = "select L.idLocacao, C.nome, L.dataLocacao, L.previsaoDevolucao, V.nome, LV.valorDia, L.dataDevolucao " +
                                                                    "from tbcliente as C " +
                                                                    "inner join tblocacao as L " +
                                                                    "on C.idCliente = L.idCliente " +
                                                                    "inner join tblocacaovideo as LV " +
                                                                    "on L.idLocacao = LV.idLocacao " +
                                                                    "inner join tbvideo as V " +
                                                                    "on LV.idVideo = V.idVideo " +
                                                                    "where C.idCliente = @idCliente " +
                                                                    "order by idLocacao; "

            con.Command.Parameters.Add(con.InserirParametro(idCliente, "@idCliente", DbType.UInt32))

            Dim dt = con.ExecutaComandoDataTable()

            Return dt

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [LocacaoAction - GetDataTableLocacaoPorIdCliente]: " + ex.Message)
        End Try
    End Function

    Public Function Detalhes(ByRef con As Connection, ByVal idLocacao As UInteger) As Locacao
        Try
            con.Command.Parameters.Clear()

            con.Command.CommandText = "SELECT idLocacao, idCliente, dataLocacao, previsaoDevolucao, dataDevolucao, valorDevolucao " +
                                      "FROM tblocacao " +
                                      "WHERE idLocacao = @idLocacao "

            con.Command.Parameters.Add(con.InserirParametro(idLocacao, "@idLocacao", DbType.UInt32))

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count > 0 Then
                Dim locacao = New Locacao()
                locacao.IdLocacao = dt.Rows(0).Item("idLocacao")
                locacao.IdCliente = dt.Rows(0).Item("idCliente")
                locacao.DataLocacao = dt.Rows(0).Item("dataLocacao")
                locacao.PrevisaoDevolucao = dt.Rows(0).Item("previsaoDevolucao")

                IIf(IsDBNull(dt.Rows(0).Item("dataDevolucao")), "", dt.Rows(0).Item("dataDevolucao"))

                IIf(IsDBNull(dt.Rows(0).Item("valorDevolucao")), "", dt.Rows(0).Item("valorDevolucao"))

                Return locacao

            End If

            Return Nothing

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [LocacaoAction - Detalhes]: " + ex.Message)
        End Try
    End Function

    Public Function Excluir(ByRef con As Connection, ByVal idLocacao As UInteger) As Boolean
        Try
            con.Command.Parameters.Clear()

            con.Command.CommandText = "DELETE FROM tblocacao " +
                                      "WHERE idLocacao = @idLocacao; "

            con.Command.Parameters.Add(con.InserirParametro(idLocacao, "@idLocacao", DbType.UInt32))

            If con.Command.ExecuteNonQuery() > 0 Then
                Return True
            End If

            Return False

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [LocacaoAction - Excluir]: " + ex.Message)
        End Try
    End Function
End Class
