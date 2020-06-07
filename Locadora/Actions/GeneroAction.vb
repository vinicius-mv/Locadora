Imports Locadora.ClassesGenerica

Public Class GeneroAction

    Public Function Salvar(ByRef con As Connection, ByVal genero As Genero) As UInteger

        Try
            con.Command.Parameters.Clear()

            If genero.IdGenero = 0 Then

                genero.IdGenero = con.GeraCodigo("tbgenero", "idGenero")

                con.Command.CommandText = "INSERT INTO tbGenero ( " +
                    "idGenero, nome " +
                    ") VALUES ( " +
                    "@idGenero, @nome " +
                    ") "

            Else

                con.Command.CommandText = "UPDATE tbgenero SET " +
                        "nome = @nome " +
                        "WHERE idGenero = @idGenero "


            End If

            con.Command.Parameters.Add(con.InserirParametro(genero.IdGenero, "@idGenero", DbType.UInt16))
            con.Command.Parameters.Add(con.InserirParametro(genero.Nome, "@nome", DbType.String))

            con.Command.ExecuteNonQuery()

            Return genero.IdGenero

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [GeneroAction - Salvar]: " + ex.Message)
        End Try

    End Function

    Public Function Excluir(ByRef con As Connection, ByVal idGenero As UInt16)

        Try
            con.Command.Parameters.Clear()

            con.Command.CommandText = "DELETE FROM tbgenero " +
                    "WHERE idGenero=@idGenero "

            con.Command.Parameters.Add(con.InserirParametro(idGenero, "@idGenero", DbType.UInt16))

            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [GeneroAction - Excluir]: " + ex.Message)
        End Try

    End Function

    Public Function Lista(ByRef con As Connection) As List(Of Genero)

        Try
            Dim listaGenero As New List(Of Genero)

            con.Command.Parameters.Clear()

            con.Command.CommandText = "SELECT idGenero, nome " +
                    "FROM tbGenero " +
                    "ORDER BY nome "

            Dim dt = con.ExecutaComandoDataTable()

            If dt.Rows.Count > 0 Then

                For i As Integer = 0 To dt.Rows.Count - 1

                    Dim _genero As New Genero()
                    _genero.IdGenero = dt.Rows(i).Item("idGenero").ToString()
                    _genero.Nome = dt.Rows(i).Item("nome").ToString()

                    listaGenero.Add(_genero)
                Next
            End If

            Return listaGenero

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [GeneroAction - Lista]: " + ex.Message)
        End Try
    End Function

    Public Function Detalhe(ByRef con As Connection, ByVal idGenero As UInt16) As Genero

        Try
            Dim _genero as New Genero()
            con.Command.Parameters.Clear()

            con.Command.CommandText = "SELECT idGenero, nome " +
                                        "FROM tbgenero " +
                                        "WHERE idGenero = @idGenero "

            con.Command.Parameters.Add(con.InserirParametro(idGenero, "@idGenero", DbType.UInt16))

            Dim dt = con.ExecutaComandoDataTable()

            If dt.Rows.Count > 0 Then
                _genero.IdGenero = dt.Rows(0).Item("idGenero").ToString()
                _genero.Nome = dt.Rows(0).Item("nome").ToString()
            End If

            return _genero

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [GeneroAction - Detalhe]: " + ex.Message)
        End Try

    End Function

End Class
