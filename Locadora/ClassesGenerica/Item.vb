Namespace ClassesGenerica
    Public Class Item

        Public Property Codigo as Double
        Public Property Texto as string

        Public Sub New (ByVal codigo as Double, byval texto As String)
            Me.Codigo = codigo
            Me.Texto = texto
        End Sub

    End Class

End NameSpace