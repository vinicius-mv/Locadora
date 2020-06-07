Public Class Video
    
    public Property IdVideo as UInteger 'PK

    Public Property Nome As String

    Public property IdGenero as UInt16 'FK

    public Property AnoLancamento As UShort

    Public Property Sinopse As String

    Public Property ValorLocacaoDia As Double


    sub New()
        IdVideo = 0
        Nome = ""
        IdGenero = 0
        AnoLancamento = 0
        Sinopse = 0
        ValorLocacaoDia = 0.0
    End sub

End Class
