Imports MySql.Data.MySqlClient

Namespace ClassesGenerica
    Public Class Connection

        Public Property Transaction() As MySqlTransaction

        Public Property Command() As MySqlCommand

        Public Property Connection() As MySqlConnection


        Public Sub Script(ByVal sql As String, Optional ByVal delimiter As String = "")
            Try

                Dim script As MySqlScript = New MySqlScript(Connection, sql)
                If delimiter <> "" Then
                    script.Delimiter = delimiter
                End If

                script.Execute()

            Catch ex As Exception
                Throw
            End Try

        End Sub

        Private Sub Inicializa()

            Dim connectionString = "SERVER=192.168.0.70;DATABASE=bd_locadora;UID=ddsinfo;PWD=dds21231;Port=3307"
            'Dim connectionString = "SERVER=localhost;DATABASE=bd_locadora;UID=root;PWD='dds21231';Port=3307"
            Try

                Connection = New MySqlConnection(connectionString)

                Command = New MySqlCommand()

                Command.Connection = Connection

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try

        End Sub

        Public Sub New()
            Call Inicializa()
        End Sub

        'open connection to database
        Public Function OpenConnection() As Boolean
            Try
                Connection.Open()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

        'Close connection
        Public Function CloseConnection() As Boolean
            Try
                Connection.Close()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

        'Open tansaction
        Public Function OpenTransaction() As Boolean
            Try
                Transaction = Connection.BeginTransaction()
                Command.Transaction = Transaction
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function RollBackTransaction() As Boolean
            Try
                Transaction.Rollback()
            Catch ex As Exception
            End Try
            Return True
        End Function

        'Commit transaction
        Public Function CommitTransaction() As Boolean
            Try
                Transaction.Commit()
            Catch ex As Exception
            End Try
            Return True
        End Function

        Public Function GeraCodigo(ByVal nometabela As String, ByVal chave As String, Optional ByVal clausula As String = "") As Double
            Dim codigo As Double = 0

            Command.Parameters.Clear()

            Dim sql As String = "Select IfNull(max(cast(" + chave + " as unsigned)),0) from " + nometabela

            If clausula <> "" Then
                If InStr(1, clausula.ToUpper(), "WHERE") > 0 Then
                    sql += clausula.ToUpper().Replace("WHERE", " AND ")
                Else
                    sql += " And " + clausula
                End If
            End If


            Command.CommandText = sql

            Dim reader = Command.ExecuteReader()

            If reader.Read() Then
                codigo = reader.GetDouble(0)
            End If
            reader.Close()

            Command.Parameters.Clear()

            Return codigo + 1
        End Function

        ''' <summary>
        '''     Inserir parametros. Deve conter o tipoSql ou o tipoDb
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function InserirParametro(ByVal valor As Object, ByVal nome As String,
                                  ByVal tipoDb As DbType) As MySqlParameter
            Try
                Dim myParam As New MySqlParameter
                myParam.Value = valor
                myParam.ParameterName = nome
                myParam.DbType = tipoDb

                Return myParam
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ExecutaComandoDataTable() As DataTable

            Dim myDataAdapter = New MySqlDataAdapter(Command)

            Dim dt = New DataTable

            myDataAdapter.Fill(dt)

            myDataAdapter.Dispose()

            Return dt

        End Function

    End Class

End Namespace