Public Class formCajaIn

    Private Sub formCajaIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDCaja_Click(sender As Object, e As EventArgs) Handles btnDCaja.Click
        Dim formFacturaObjeto As New formFactura
        formFacturaObjeto.bandera = 0
        formFacturaObjeto.ShowDialog()

    End Sub
End Class