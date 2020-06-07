
Public Class MdiLocadora
    Private Sub mnuCadastroCliente_Click(sender As Object, e As EventArgs) Handles mnuCadastroCliente.Click

        dim frmCliente = New FrmCadCliente()
        frmCliente.MdiParent = Me
        frmCliente.Show()
    End Sub

    Private Sub mnuCadastroGenero_Click(sender As Object, e As EventArgs) Handles mnuCadastroGenero.Click

        dim frmGenero = new FrmCadGenero()
        frmGenero.MdiParent = Me
        frmGenero.Show()
    End Sub

    Private Sub mnuVídeo_Click(sender As Object, e As EventArgs) Handles mnuVideo.Click
        Dim frmVideo = New FrmCadVideo()
        frmVideo.MdiParent = Me
        frmVideo.Show()
    End Sub

    Private Sub mnuLocacao_Click(sender As Object, e As EventArgs) Handles mnuLocacao.Click
        Dim frmCadLocacao = New FrmCadLocacao()
        frmCadLocacao.MdiParent = Me
        frmCadLocacao.Show()
    End Sub

End Class
