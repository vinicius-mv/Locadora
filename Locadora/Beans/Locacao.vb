Public Class Locacao

    public Property IdLocacao As UInt32 'PK

    public Property IdCliente As UInt32 'Fk

    public Property DataLocacao As Date

    Public  Property PrevisaoDevolucao As Date

    Public Property ValorPrevisao as Double

    Public Property  DataDevolucao as Date

    Public Property ValorDevolucao As Double

    Sub New ()
        IdLocacao = 0
        IdCliente = 0
        DataLocacao = Nothing
        PrevisaoDevolucao = Nothing
        ValorPrevisao = 0.0
        DataDevolucao = Nothing
        ValorDevolucao = 0.0
    End Sub

End Class
