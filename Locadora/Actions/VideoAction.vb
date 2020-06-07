Imports Locadora.ClassesGenerica

Public Class VideoAction

    Public Function Salvar(ByRef con As Connection, ByVal video As Video) As UInteger
        Try
            con.Command.Parameters.Clear()

            If video.IdVideo = 0 Then  'inserir novo registro

                video.IdVideo = con.GeraCodigo("tbvideo", "idVideo")

                con.Command.CommandText = "INSERT INTO tbVideo ( " +
                    "idVideo, nome, idGenero, AnoLancamento, sinopse, valorLocacaoDia " +
                    ") VALUES ( " +
                    "@idVideo, @nome, @idGenero, @AnoLancamento, @sinopse, @valorLocacaoDia " +
                    ") "

            Else 'idVideo <> 0 -> atualiza registro existente

                con.Command.CommandText = "UPDATE tbVideo " +
                    "SET nome = @nome, idGenero = @idGenero, anoLancamento = @anoLancamento, sinopse = @sinopse, valorLocacaoDia = @valorLocacaoDia " +
                    "WHERE idVideo = @idVideo "
            End If

            With con.Command.Parameters
                .Add(con.InserirParametro(video.IdVideo, "@idVideo", DbType.UInt32))
                .Add(con.InserirParametro(video.Nome, "@nome", DbType.String))
                .Add(con.InserirParametro(video.IdGenero, "@idGenero", DbType.UInt16))
                .Add(con.InserirParametro(video.AnoLancamento, "@AnoLancamento", DbType.Int16))
                .Add(con.InserirParametro(video.Sinopse, "@sinopse", DbType.String))
                .Add(con.InserirParametro(video.ValorLocacaoDia, "@valorLocacaoDia", DbType.Double))
            End With

            con.Command.ExecuteNonQuery()

            Return video.IdVideo

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [VideoAction - Salvar]: " + ex.Message)
        End Try
    End Function

    Public Function Excluir(ByRef con As Connection, ByVal idVideo As UInteger) As Boolean
        Try
            con.Command.Parameters.Clear()

            con.Command.CommandText = "DELETE FROM tbVideo " +
                                      "WHERE (idVideo = @idVideo) "

            con.Command.Parameters.Add(con.InserirParametro(idVideo, "@idVideo", DbType.UInt32))
            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [VideoAction - Excluir]: " + ex.Message)
        End Try
    End Function

    Public Function Lista(ByRef con As Connection) As List(Of Video)
        Try
            Dim listaVideo = New List(Of Video)

            con.Command.Parameters.Clear()

            con.Command.CommandText = "SELECT " +
                "idVideo, nome, idGenero, AnoLancamento, sinopse, valorLocacaoDia " +
                "FROM tbVideo " +
                "ORDER BY nome "

            Dim dt = con.ExecutaComandoDataTable()

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim video As New Video()
                    video.IdVideo = dt.Rows(i).Item("idVideo")
                    video.Nome = dt.Rows(i).Item("nome")
                    video.IdGenero = dt.Rows(i).Item("idGenero")
                    video.AnoLancamento = dt.Rows(i).Item("AnoLancamento")
                    video.Sinopse = dt.Rows(i).Item("sinopse")
                    video.ValorLocacaoDia = dt.Rows(i).Item("valorLocacaoDia")

                    listaVideo.Add(video)
                Next
            End If

            Return listaVideo

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [VideoeAction - Lista]: " + ex.Message)
        End Try
    End Function

    Public Function Detalhe(ByRef con As Connection, ByVal idVideo As UInteger) As Video
        Try
            con.Command.Parameters.Clear()

            con.Command.CommandText = "SELECT " +
                "idVideo, nome, idGenero, AnoLancamento, sinopse, valorLocacaoDia " +
                "FROM tbVideo " +
                "WHERE idVideo = @idVideo "

            con.Command.Parameters.Add(con.InserirParametro(idVideo, "@idVideo", DbType.UInt32))

            Dim dt = con.ExecutaComandoDataTable()
            Dim video = New Video()

            If dt.Rows.Count > 0 Then
                video.IdVideo = dt.Rows(0).Item("idVideo")
                video.Nome = dt.Rows(0).Item("nome")
                video.IdGenero = dt.Rows(0).Item("idGenero")
                video.AnoLancamento = dt.Rows(0).Item("AnoLancamento")
                video.Sinopse = dt.Rows(0).Item("sinopse")
                video.ValorLocacaoDia = dt.Rows(0).Item("valorLocacaoDia")
            End If

            Return video

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [VideoAction - Detalhe]: " + ex.Message)
        End Try

    End Function
End Class
