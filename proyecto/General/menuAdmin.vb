Public Class menuAdmin
    Private Sub menuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub MenubtnEmpleado_Click(sender As Object, e As EventArgs) Handles MenubtnEmpleado.Click
        Dim formEmpleadooObjeto As New formEmpleados
        formEmpleadooObjeto.bandera = 0
        formEmpleadooObjeto.ShowDialog()
    End Sub



    'Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
    '    Dim frmProductoObjeto As New frmproducto
    '    frmProductoObjeto.bandera = 0
    '    frmProductoObjeto.ShowDialog()
    'End Sub

    'Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
    '    Dim frmClienteObjeto As New frmcliente
    '    frmClienteObjeto.bandera = 0
    '    frmClienteObjeto.ShowDialog()
    'End Sub

    'Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
    '    Dim frmEmpleadoObjeto As New frmempleado
    '    frmEmpleadoObjeto.bandera = 0
    '    frmEmpleadoObjeto.ShowDialog()
    'End Sub

    'Private Sub FormaDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormaDePagoToolStripMenuItem.Click
    '    Dim frmFormaPagoObjeto As New frmpago
    '    frmFormaPagoObjeto.bandera = 0
    '    frmFormaPagoObjeto.ShowDialog()
    'End Sub

    'Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
    '    End
    'End Sub

    'Private Sub FacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaToolStripMenuItem.Click
    '    Dim frmFacturaObjeto As New frmFactura
    '    frmFacturaObjeto.bandera = 0
    '    frmFacturaObjeto.ShowDialog()
    'End Sub
End Class