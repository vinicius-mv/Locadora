Imports Locadora.ClassesGenerica

Public Class LocacaoVideoAction

    Public Function Salvar(ByRef con As Connection, ByVal locacaoVideo As LocacaoVideo) As UInteger
        Try
            con.Command.Parameters.Clear()

            If locacaoVideo.IdLocacaoVideo = 0 Then

                locacaoVideo.IdLocacaoVideo = con.GeraCodigo("tbLocacaoVideo", "idLocacaoVideo")

                con.Command.CommandText = "INSERT INTO tbLocacaoVideo ( " +
                    "idLocacaoVideo, idLocacao, idVideo, valorDia " +
                    ") VALUES (" +
                    "@idLocacaoVideo, @idLocacao, @idVideo, @valorDia " +
                    "); "

            Else
                con.Command.CommandText = "UPDATE tbLocacaoVideo SET " +
                    "idLocacao = @idLocacao, idVideo = @idVideo " +
                    "WHERE idLocacaoVideo = @idLocacaoVideo"

            End If

            con.Command.Parameters.Add(con.InserirParametro(locacaoVideo.IdLocacaoVideo, "@idLocacaoVideo", DbType.UInt32))
            con.Command.Parameters.Add(con.InserirParametro(locacaoVideo.IdLocacao, "@idLocacao", DbType.UInt32))
            con.Command.Parameters.Add(con.InserirParametro(locacaoVideo.IdVideo, "@idVideo", DbType.UInt32))
            con.Command.Parameters.Add(con.InserirParametro(locacaoVideo.ValorDia, "valorDia", DbType.Double))

            con.Command.ExecuteNonQuery()

            Return locacaoVideo.IdLocacaoVideo

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [LocacaoVideoAction - Salvar]: " + ex.Message)
        End Try
    End Function

    Public Function Excluir(ByRef con As Connection, ByVal idLocacaoVideo As UInteger) As Boolean
        Try
            con.Command.Parameters.Clear()

            con.Command.CommandText = "DELETE FROM tbLocacaoVideo " +
                                      "WHERE idLocacaoVideo = @idLocacaoVideo;"

            con.Command.Parameters.Add(con.InserirParametro(idLocacaoVideo, "@idLocacaoVideo", DbType.UInt32))

            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [LocacaoVideoAction - Excluir]: " + ex.Message)
        End Try
    End Function

    Public Function ExcluirPorIdLocacao(ByRef con As Connection, ByVal idLocacao As UInteger) As Boolean
        Try
            con.Command.Parameters.Clear()

            con.Command.CommandText = "DELETE FROM tbLocacaoVideo " +
                                      "WHERE idLocacao = @idLocacao;"

            con.Command.Parameters.Add(con.InserirParametro(idLocacao, "@idLocacao", DbType.UInt32))
            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [LocacaoVideoAction - ExcluirPorIdLocacao]: " + ex.Message)
        End Try
    End Function

    public Function Lista(ByRef con As Connection) As List(Of LocacaoVideo)
        Try
            Dim listaLocacaoVideo = new List(Of LocacaoVideo)

            con.Command.Parameters.Clear()

            con.Command.CommandText = "SELECT idLocacaoVideo, idLocacao, idVideo, valorDia " +
                                      "FROM tbLocacaoVideo;"

            dim dt = con.ExecutaComandoDataTable()


            If dt.Rows.Count > 0 Then
                for i As Integer = 0 To dt.Rows.Count - 1
                    Dim locacaoVideo = New LocacaoVideo()
                    locacaoVideo.IdLocacaoVideo = dt.Rows(i).Item("idLocacaoVideo")
                    locacaoVideo.IdVideo = dt.Rows(i).Item("idVideo")
                    locacaoVideo.IdLocacao = dt.Rows(i).Item("idLocacao") 

                    listaLocacaoVideo.Add(locacaoVideo)
                Next
            End If

            Return listaLocacaoVideo

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [LocacaoVideoAction - Lista]: " + ex.Message)
        End Try
        
    End Function

    public Function ListaPorIdLocacao(ByRef con As Connection, byval idLocacao As UInteger) As List(Of LocacaoVideo)
        Try
            Dim listaLocacaoVideo = new List(Of LocacaoVideo)

            con.Command.Parameters.Clear()

            con.Command.CommandText = "SELECT idLocacaoVideo, idLocacao, idVideo, valorDia " +
                                      "FROM tbLocacaoVideo " +
                                      "WHERE idLocacao = @idLocacao"

            con.Command.Parameters.Add(con.InserirParametro(idLocacao, "@idLocacao", DbType.UInt32))

            Dim dt = con.ExecutaComandoDataTable()

            If dt.Rows.Count > 0 Then
                for i as Integer = 0 To dt.Rows.Count - 1
                    Dim locacaoVideo = New LocacaoVideo()
                    locacaoVideo.IdLocacaoVideo = dt.Rows(i).Item("idLocacaoVideo")
                    locacaoVideo.IdLocacao = dt.Rows(i).Item("idLocacao")
                    locacaoVideo.IdVideo = dt.Rows(i).Item("idVideo")
                    locacaoVideo.ValorDia = dt.Rows(i).Item("valorDia")

                    listaLocacaoVideo.Add(locacaoVideo)
                Next
            End If

            return listaLocacaoVideo

        Catch ex As Exception

        End Try
    End Function

    public Function Detalhe(ByRef con as Connection, byval idLocacaoVideo As UInteger) As LocacaoVideo
        Try
            con.Command.Parameters.Clear()

            con.Command.CommandText = "SELECT idLocacaoVideo, idLocacao, idVideo, valorDia " +
                                      "FROM tbLocacaoVideo " +
                                      "WHERE idLocacaoVideo = @idLocacaoVideo;"

            con.Command.Parameters.Add(con.InserirParametro(idLocacaoVideo, "@idLocacaoVideo", DbType.UInt32))

            Dim dt = con.ExecutaComandoDataTable()
            Dim locacaoVideo = new LocacaoVideo()

            If dt.Rows.Count > 0 Then
                locacaoVideo.IdLocacaoVideo = dt.Rows(0).Item("idLocacaoVideo")
                locacaoVideo.IdLocacao = dt.Rows(0).Item("idLocacao")
                locacaoVideo.IdVideo = dt.Rows(0).Item("idVideo")
                locacaoVideo.ValorDia = dt.Rows(0).Item("valorDia")
            End If

            return locacaoVideo

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [LocacaoVideoAction - Detalhe]: " + ex.Message)
        End Try
    End Function
End Class
