Imports Locadora.ClassesGenerica

Public Class ClienteAction

    Public Function Salvar(ByRef con As Connection, ByVal cliente As Cliente) As UInteger

        Try
            con.Command.Parameters.Clear()

            If cliente.IdCliente = 0 Then

                cliente.IdCliente = con.GeraCodigo("tbcliente", "idCliente")

                con.Command.CommandText = "Insert Into tbCliente ( " +
                    "idCliente, nome " +
                    ") Values ( " +
                    "@idCliente, @nome " +
                    "); "

            Else

                con.Command.CommandText = "Update tbCliente Set " +
                    " nome=@nome " +
                    " Where idCliente=@idCliente; "

            End If

            'Dim myParam = new MySql.Data.MySqlClient.MySqlParameter
            'myParam.ParameterName = "@idCliente"
            'myParam.Value=cliente.IdCliente
            'myParam.DbType = DbType.UInt32
            'con.Command.Parameters.Add(myParam)

            'Dim myParam = con.InserirParametro(cliente.IdCliente,"@idCliente",DbType.UInt32)
            'con.Command.Parameters.Add(myParam)

            con.Command.Parameters.Add(con.InserirParametro(cliente.IdCliente, "@idCliente", DbType.UInt32))
            con.Command.Parameters.Add(con.InserirParametro(cliente.Nome, "@nome", DbType.String))

            con.Command.ExecuteNonQuery()

            Return cliente.IdCliente

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [ClienteAction - Salvar]: " + ex.Message)
        End Try
    End Function

    Public Function Excluir(ByRef con As Connection, ByVal idCliente As UInteger) As Boolean
        Try
            con.Command.Parameters.Clear()

            con.Command.CommandText = "DELETE FROM tbCliente " +
                                      "WHERE (idCliente = @idCliente)"

            con.Command.Parameters.Add(con.InserirParametro(idCliente, "@idCliente", DbType.UInt32))
            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [ClienteAction - Excluir]: " + ex.Message)
        End Try
    End Function

    Public Function Lista(ByRef con As Connection) As List(Of Cliente)
        Try
            Dim listaCliente = New List(Of Cliente)

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select idCliente, nome" +
                " From tbCliente" +
                " Order by nome"

            Dim dt = con.ExecutaComandoDataTable()

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim cliente = New Cliente()
                    cliente.IdCliente = dt.Rows(i).Item("idCliente").ToString()
                    cliente.Nome = dt.Rows(i).Item("nome").ToString()

                    listaCliente.Add(cliente)
                Next
            End If

            Return listaCliente

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [ClienteAction - Lista]: " + ex.Message)
        End Try

    End Function

    Public Function Detalhe(ByRef con As Connection, ByVal idCliente As UInteger) As Cliente
        Try
            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select idCliente, nome " +
                                      "From tbCliente " +
                                      "Where idCliente=@idCliente; "

            con.Command.Parameters.Add(con.InserirParametro(idCliente,"@idCliente", DbType.UInt32))

            Dim dt = con.ExecutaComandoDataTable()
            Dim cliente = New Cliente

            If dt.Rows.Count > 0 Then
                cliente.IdCliente = dt.Rows(0).Item("idCliente").ToString()
                cliente.Nome = dt.Rows(0).Item("nome").ToString()
            End If

            Return cliente

        Catch ex As Exception
            Throw New Exception("Houve um erro ao tentar executar o método [ClienteAction - Detalhe]: " + ex.Message)
        End Try

    End Function

End Class
