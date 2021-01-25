Public Class formFactura

    'creación de objetos generales
    Private tablaDatosClase As New DataTable
    Private tablaDatosProducto As New DataTable
    Public bandera As New Boolean

    'evento de carga de inicial del formulario
    Private Sub formFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Enabled = False
        txtCliCodigo.Enabled = False
        txtCliNombre.Enabled = False
        txtCliApellido.Enabled = False
        txtEmpCodigo.Enabled = False
        txtEmpNombre.Enabled = False
        txtEmpPuesto.Enabled = False
        txtPagCodigo.Enabled = False
        txtPagDescripcion.Enabled = False
        txtSubTotal.Enabled = False
        txtImpuesto.Enabled = False
        txtTotal.Enabled = False
        txtCodProducto.Enabled = False
        txtNomProducto.Enabled = False
        txtPrecioVenta.Enabled = False
        txtCatProducto.Enabled = False
        txtVencimiento.Enabled = False
        txtStock.Enabled = False
        dataListadoProducto.Visible = False
        nudCantidad.Enabled = False
        ckbQuitarProducto.Enabled = False
        txtImpuesto.TextAlign = HorizontalAlignment.Right
        txtSubTotal.TextAlign = HorizontalAlignment.Right
        txtTotal.TextAlign = HorizontalAlignment.Right
        txtPrecioVenta.TextAlign = HorizontalAlignment.Right
        If bandera Then
            btnLimpiar.Visible = False
            btnCancelar.Visible = False
        Else
            btnLimpiar.Visible = True
            btnCancelar.Visible = True
        End If
        'mostrar()
        'limpiar()
    End Sub

    'Private Sub mostrar()
    '    Try
    '        Dim funcion As New ffactura
    '        tablaDatosClase = funcion.mostrar
    '        dataListado.Columns.Item("eliminar").Visible = False
    '        If tablaDatosClase.Rows.Count <> 0 Then
    '            dataListado.DataSource = tablaDatosClase
    '            dataListado.ColumnHeadersVisible = True
    '            ocultarColumna()
    '        Else
    '            dataListado.DataSource = Nothing
    '            dataListado.ColumnHeadersVisible = False
    '        End If
    '    Catch evento As Exception
    '        MsgBox(evento.Message)
    '    End Try
    'End Sub

    'Private Sub mostrarProducto()
    '    Try
    '        Dim funcion As New fdetalle
    '        Dim tablaDatos As New eDetalle
    '        tablaDatos.pfacCodigo = txtCodigo.Text
    '        tablaDatosProducto = funcion.mostrar(tablaDatos)
    '        dataListadoProducto.Columns.Item("eliminarProducto").Visible = False
    '        If tablaDatosProducto.Rows.Count <> 0 Then
    '            dataListadoProducto.DataSource = tablaDatosProducto
    '            dataListadoProducto.ColumnHeadersVisible = True
    '            ocultarColumnaProduto()
    '        Else
    '            dataListadoProducto.DataSource = Nothing
    '            dataListadoProducto.ColumnHeadersVisible = False
    '        End If
    '    Catch evento As Exception
    '        MsgBox(evento.Message)
    '    End Try
    '    sumarizar()
    'End Sub

    'Private Sub ocultarColumna()
    '    dataListado.Columns(1).Visible = False
    '    dataListado.Columns(3).Visible = False
    '    dataListado.Columns(6).Visible = False
    '    dataListado.Columns(9).Visible = False
    'End Sub

    'Private Sub ocultarColumnaProduto()
    '    dataListadoProducto.Columns(1).Visible = False
    '    dataListadoProducto.Columns(2).Visible = False
    'End Sub

    'Private Sub limpiar()
    '    txtCodigo.Text = ""
    '    dtpFecha.Value = DateTime.Now
    '    txtCliCodigo.Text = ""
    '    txtCliNombre.Text = ""
    '    txtCliApellido.Text = ""
    '    txtEmpCodigo.Text = ""
    '    txtEmpNombre.Text = ""
    '    txtEmpPuesto.Text = ""
    '    txtPagCodigo.Text = ""
    '    txtPagDescripcion.Text = ""
    '    dtpFecha.Enabled = False
    '    btnCliente.Enabled = False
    '    btnEmpleado.Enabled = False
    '    btnPago.Enabled = False
    '    txtNomProducto.Text = ""
    '    txtPrecioVenta.Text = ""
    '    txtCatProducto.Text = ""
    '    txtVencimiento.Text = ""
    '    txtStock.Text = ""
    '    txtImpuesto.Text = ".00"
    '    txtSubTotal.Text = ".00"
    '    txtTotal.Text = ".00"
    '    dataListadoProducto.DataSource = Nothing
    '    dataListadoProducto.ColumnHeadersVisible = False
    '    txtNomProducto.Enabled = False
    '    txtPrecioVenta.Enabled = False
    '    txtCatProducto.Enabled = False
    '    txtVencimiento.Enabled = False
    '    txtStock.Enabled = False
    '    dataListadoProducto.Enabled = False
    '    btnInsertarProducto.Visible = False
    '    btnGuardarProducto.Visible = False
    '    btnActualizarProducto.Visible = False
    '    btnQuitarProducto.Visible = False
    '    btnCancelarProducto.Visible = False
    '    ckbQuitarProducto.Enabled = False
    '    nudCantidad.Enabled = False
    '    nudCantidad.Text = 0
    '    btnActualizar.Visible = False
    '    btnGuardar.Visible = False
    '    btnEliminar.Visible = False
    '    If bandera Then
    '        btnInsertar.Visible = False
    '    Else
    '        btnInsertar.Visible = True
    '    End If
    'End Sub

    'Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
    '    limpiar()
    'End Sub

    'Private Sub dataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellClick
    '    traslado_informacion()
    '    mostrarProducto()
    '    If dataListadoProducto.Rows.Count <> 0 Then
    '        dataListadoProducto.Rows(0).Selected = True
    '        trasladoInformacionProducto()
    '    End If
    '    If bandera Then
    '        btnActualizar.Visible = False
    '    Else
    '        btnActualizar.Visible = True
    '    End If
    '    btnInsertar.Visible = False
    '    dataListadoProducto.Enabled = True
    '    habilitar()
    '    deshabilitarProducto()
    'End Sub

    'Private Sub dataListadoProducto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoProducto.CellClick
    '    trasladoInformacionProducto()
    '    habilitarProducto()
    'End Sub

    'Private Sub traslado_informacion()
    '    txtCodigo.Text = dataListado.SelectedCells.Item(1).Value
    '    dtpFecha.Value = dataListado.SelectedCells.Item(2).Value
    '    txtCliCodigo.Text = dataListado.SelectedCells.Item(3).Value
    '    txtCliNombre.Text = dataListado.SelectedCells.Item(4).Value
    '    txtCliApellido.Text = dataListado.SelectedCells.Item(5).Value
    '    txtPagCodigo.Text = dataListado.SelectedCells.Item(6).Value
    '    txtPagDescripcion.Text = dataListado.SelectedCells.Item(7).Value
    '    txtEmpCodigo.Text = dataListado.SelectedCells.Item(8).Value
    '    txtEmpNombre.Text = dataListado.SelectedCells.Item(9).Value
    '    txtEmpPuesto.Text = dataListado.SelectedCells.Item(10).Value
    'End Sub

    'Private Sub trasladoInformacionProducto()
    '    txtCodProducto.Text = dataListadoProducto.SelectedCells.Item(2).Value
    '    txtNomProducto.Text = dataListadoProducto.SelectedCells.Item(3).Value
    '    txtCatProducto.Text = dataListadoProducto.SelectedCells.Item(4).Value
    '    txtPrecioVenta.Text = dataListadoProducto.SelectedCells.Item(5).Value
    '    nudCantidad.Text = dataListadoProducto.SelectedCells.Item(6).Value
    '    txtVencimiento.Text = dataListadoProducto.SelectedCells.Item(7).Value
    '    txtStock.Text = dataListadoProducto.SelectedCells.Item(9).Value
    '    btnActualizarProducto.Enabled = True
    '    habilitarProducto()
    '    deshabilitar()
    'End Sub

    'Private Sub habilitar()
    '    dtpFecha.Enabled = True
    '    btnCliente.Enabled = True
    '    btnEmpleado.Enabled = True
    '    btnPago.Enabled = True
    '    btnGuardar.Visible = True
    '    btnLimpiar.Visible = True
    '    btnCancelar.Visible = True
    'End Sub

    'Private Sub deshabilitar()
    '    dtpFecha.Enabled = False
    '    btnCliente.Enabled = False
    '    btnEmpleado.Enabled = False
    '    btnPago.Enabled = False
    '    btnGuardar.Visible = False
    '    btnLimpiar.Visible = False
    '    btnCancelar.Visible = False
    'End Sub

    'Private Sub habilitarProducto()
    '    nudCantidad.Enabled = True
    '    btnInsertarProducto.Enabled = True
    '    btnInsertarProducto.Visible = True
    '    btnGuardarProducto.Visible = True
    '    btnActualizarProducto.Visible = True
    '    btnQuitarProducto.Visible = True
    '    btnCancelarProducto.Visible = True
    '    ckbQuitarProducto.Enabled = True
    'End Sub

    'Private Sub deshabilitarProducto()
    '    nudCantidad.Enabled = False
    '    btnInsertarProducto.Enabled = False

    '    btnInsertarProducto.Visible = False
    '    btnGuardarProducto.Visible = False
    '    btnActualizarProducto.Visible = False
    '    btnQuitarProducto.Visible = False
    '    btnCancelarProducto.Visible = False
    '    ckbQuitarProducto.Enabled = False
    'End Sub

    'Private Sub btnCancelarProducto_Click(sender As Object, e As EventArgs) Handles btnCancelarProducto.Click
    '    habilitar()
    '    deshabilitarProducto()
    'End Sub

    'Private Sub sumarizar()
    '    Dim sumatoria, impuesto, final As Double
    '    For Each row As DataGridViewRow In Me.dataListadoProducto.Rows
    '        sumatoria += Val(row.Cells("total").Value)
    '    Next
    '    impuesto = sumatoria * 0.15
    '    final = sumatoria + impuesto
    '    Me.txtSubTotal.Text = sumatoria.ToString("#,###.00")
    '    Me.txtImpuesto.Text = impuesto.ToString("#,###.00")
    '    Me.txtTotal.Text = final.ToString("#,###.00")
    'End Sub

    'Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
    '    limpiar()
    '    habilitar()
    '    btnGuardar.Visible = True
    '    btnInsertar.Visible = False
    'End Sub

    'Private Sub btnInsertarProducto_Click(sender As Object, e As EventArgs) Handles btnInsertarProducto.Click
    '    habilitarProducto()
    '    nudCantidad.Text = 0
    '    btnGuardarProducto.Enabled = True
    '    btnInsertarProducto.Enabled = True
    '    frmproducto.bandera = True
    '    frmproducto.ShowDialog()
    '    txtCodProducto.Text = frmproducto.txtCodigo.Text
    '    txtNomProducto.Text = frmproducto.txtDescripcion.Text
    '    txtPrecioVenta.Text = frmproducto.txtPrecioVenta.Text
    '    txtVencimiento.Text = frmproducto.dtpFechaVencimiento.Value
    '    txtStock.Text = frmproducto.txtStock.Text
    '    txtCatProducto.Text = frmproducto.txtCategoria.Text
    'End Sub

    'Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
    '    If txtCliCodigo.Text <> "" And
    '        txtEmpCodigo.Text <> "" And
    '        txtPagCodigo.Text <> "" Then
    '        Try
    '            Dim tablaDatos As New eFactura
    '            Dim funcion As New ffactura
    '            tablaDatos.pfacFecha = dtpFecha.Value
    '            tablaDatos.pcliCodigo = txtCliCodigo.Text
    '            tablaDatos.pempCodigo = txtEmpCodigo.Text
    '            tablaDatos.ppagCodigo = txtPagCodigo.Text
    '            If funcion.insertar(tablaDatos) Then
    '                MessageBox.Show("Factura fue registrado correctamente",
    '                                "Guardando registro", MessageBoxButtons.OK,
    '                                MessageBoxIcon.Information)
    '            Else
    '                MessageBox.Show("Factura no fue registrado correctamente",
    '                                "Guardando registro", MessageBoxButtons.OK,
    '                                MessageBoxIcon.Error)
    '            End If
    '            mostrar()
    '            dataListado.Rows(0).Selected = True
    '            traslado_informacion()
    '            habilitarProducto()
    '        Catch evento As Exception
    '            MsgBox(evento.Message)
    '        End Try
    '    Else
    '        MessageBox.Show("Falta informacion para almacenar",
    '                        "Guardando registro", MessageBoxButtons.OK,
    '                        MessageBoxIcon.Information)
    '    End If
    'End Sub

    'Private Sub btnGuardarProducto_Click(sender As Object, e As EventArgs) Handles btnGuardarProducto.Click
    '    If nudCantidad.Text > 0 And
    '        txtCodProducto.Text <> "" And
    '        txtStock.Text = 0 Then
    '        Try
    '            Dim tablaDatos As New eDetalle
    '            Dim funcion As New fdetalle
    '            tablaDatos.pfacCodigo = txtCodigo.Text
    '            tablaDatos.pproCodigo = txtCodProducto.Text
    '            tablaDatos.pdfaCantidad = nudCantidad.Text
    '            If funcion.insertar(tablaDatos) Then
    '                funcion.disminuirProducto(tablaDatos)
    '                MessageBox.Show("Producto fue registrado correctamente",
    '                                "Guardando registro", MessageBoxButtons.OK,
    '                                MessageBoxIcon.Information)
    '            Else
    '                MessageBox.Show("Producto no fue registrado correctamente",
    '                                "Guardando registro", MessageBoxButtons.OK,
    '                                MessageBoxIcon.Error)
    '            End If
    '            mostrarProducto()
    '            Dim resultado As DialogResult
    '            resultado = MessageBox.Show("Desea insertar otro producto",
    '                            "Guardando registro", MessageBoxButtons.YesNo,
    '                            MessageBoxIcon.Question)
    '            If resultado = Windows.Forms.DialogResult.No Then
    '                limpiar()
    '            End If
    '        Catch evento As Exception
    '            MsgBox(evento.Message)
    '        End Try
    '    Else
    '        MessageBox.Show("Falta informacion para almacenar",
    '                        "Guardando registro", MessageBoxButtons.OK,
    '                        MessageBoxIcon.Information)
    '    End If
    'End Sub


    'Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
    '    If txtCliCodigo.Text <> "" And
    '        txtEmpCodigo.Text <> "" And
    '        txtPagCodigo.Text <> "" Then
    '        Dim resultado As DialogResult
    '        resultado = MessageBox.Show("Desea modificar los datos",
    '                        "Actualizando registro", MessageBoxButtons.OKCancel,
    '                        MessageBoxIcon.Question)
    '        If resultado = Windows.Forms.DialogResult.OK Then
    '            Try
    '                Dim tablaDatos As New eFactura
    '                Dim funcion As New ffactura
    '                tablaDatos.pfacCodigo = txtCodigo.Text
    '                tablaDatos.pfacFecha = dtpFecha.Value
    '                tablaDatos.pcliCodigo = txtCliCodigo.Text
    '                tablaDatos.pempCodigo = txtEmpCodigo.Text
    '                tablaDatos.ppagCodigo = txtPagCodigo.Text
    '                If funcion.editar(tablaDatos) Then
    '                    MessageBox.Show("Factura fue actualizado correctamente",
    '                                    "Actualizando registro", MessageBoxButtons.OK,
    '                                    MessageBoxIcon.Information)
    '                Else
    '                    MessageBox.Show("Factura no fue actualizado correctamente",
    '                                    "Actualizando registro", MessageBoxButtons.OK,
    '                                    MessageBoxIcon.Error)
    '                End If
    '                mostrar()
    '                habilitarProducto()

    '            Catch evento As Exception
    '                MsgBox(evento.Message)
    '            End Try
    '        Else
    '            MessageBox.Show("Cancelando actualizado por el usuario",
    '                            "Actualizando registro", MessageBoxButtons.OK,
    '                            MessageBoxIcon.Information)
    '        End If
    '    Else
    '        MessageBox.Show("Falta informacion para almacenar",
    '                        "Actualizando registro", MessageBoxButtons.OK,
    '                        MessageBoxIcon.Information)
    '    End If
    'End Sub

    'Private Sub btnActualizarProducto_Click(sender As Object, e As EventArgs) Handles btnActualizarProducto.Click
    '    If nudCantidad.Text > 0 And
    '        txtCodProducto.Text <> "" And
    '        txtStock.Text = 0 Then
    '        Dim resultado As DialogResult
    '        resultado = MessageBox.Show("Desea modificar los datos",
    '                        "Actualizando registro", MessageBoxButtons.OKCancel,
    '                        MessageBoxIcon.Question)
    '        If resultado = Windows.Forms.DialogResult.OK Then
    '            Try
    '                Dim tablaDatos As New eDetalle
    '                Dim funcion As New fdetalle
    '                tablaDatos.pfacCodigo = txtCodigo.Text
    '                tablaDatos.pproCodigo = txtCodProducto.Text
    '                tablaDatos.pdfaCantidad = nudCantidad.Text
    '                If funcion.editar(tablaDatos) Then
    '                    If nudCantidad.Value < dataListadoProducto.SelectedCells.Item(6).Value Then
    '                        tablaDatos.pdfaCantidad = dataListadoProducto.SelectedCells.Item(6).Value - nudCantidad.Value
    '                        funcion.aumentarProducto(tablaDatos)
    '                    Else
    '                        tablaDatos.pdfaCantidad = nudCantidad.Value - dataListadoProducto.SelectedCells.Item(6).Value
    '                        funcion.disminuirProducto(tablaDatos)
    '                    End If


    '                    MessageBox.Show("Producto fue actualizado correctamente",
    '                                    "Actualizando registro", MessageBoxButtons.OK,
    '                                    MessageBoxIcon.Information)
    '                Else
    '                    MessageBox.Show("Producto no fue actualizado correctamente",
    '                                    "Actualizando registro", MessageBoxButtons.OK,
    '                                    MessageBoxIcon.Error)
    '                End If
    '                mostrarProducto()
    '                limpiar()
    '            Catch evento As Exception
    '                MsgBox(evento.Message)
    '            End Try
    '        Else
    '            MessageBox.Show("Cancelando actualizado por el usuario",
    '                            "Actualizando registro", MessageBoxButtons.OK,
    '                            MessageBoxIcon.Information)
    '        End If
    '    Else
    '        MessageBox.Show("Falta informacion para almacenar",
    '                        "Actualizando registro", MessageBoxButtons.OK,
    '                        MessageBoxIcon.Information)
    '    End If
    'End Sub


    'Private Sub ckbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles ckbEliminar.CheckedChanged
    '    If ckbEliminar.CheckState = CheckState.Checked Then
    '        dataListado.Columns.Item("eliminar").Visible = True
    '        btnEliminar.Visible = True
    '        btnInsertar.Visible = False
    '    Else
    '        dataListado.Columns.Item("eliminar").Visible = False
    '        btnEliminar.Visible = False
    '        btnInsertar.Visible = True
    '    End If
    'End Sub

    'Private Sub ckbQuitarProducto_CheckedChanged(sender As Object, e As EventArgs) Handles ckbQuitarProducto.CheckedChanged
    '    If ckbQuitarProducto.CheckState = CheckState.Checked Then
    '        dataListadoProducto.Columns.Item("eliminarProducto").Visible = True
    '        btnQuitarProducto.Enabled = True
    '        btnInsertarProducto.Enabled = False
    '    Else
    '        dataListadoProducto.Columns.Item("eliminarProducto").Visible = False
    '        btnQuitarProducto.Enabled = False
    '        btnInsertarProducto.Enabled = True
    '    End If
    'End Sub

    'Private Sub dataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellContentClick
    '    If e.ColumnIndex = Me.dataListado.Columns.Item("eliminar").Index Then
    '        Dim chkcell As DataGridViewCheckBoxCell = Me.dataListado.Rows(e.RowIndex).Cells("eliminar")
    '        chkcell.Value = Not chkcell.Value
    '    End If
    'End Sub



    'Private Sub dataListadoProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoProducto.CellContentClick
    '    If e.ColumnIndex = Me.dataListadoProducto.Columns.Item("eliminarProducto").Index Then
    '        Dim chkcell As DataGridViewCheckBoxCell = Me.dataListadoProducto.Rows(e.RowIndex).Cells("eliminarProducto")
    '        chkcell.Value = Not chkcell.Value
    '    End If
    'End Sub

    'Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
    '    Dim resultado As DialogResult
    '    resultado = MessageBox.Show("Desea eliminar los datos",
    '                    "Eliminando registro", MessageBoxButtons.OKCancel,
    '                    MessageBoxIcon.Question)
    '    If resultado = Windows.Forms.DialogResult.OK Then
    '        Try
    '            For Each row As DataGridViewRow In dataListado.Rows
    '                Dim lineaMarcada As Boolean = Convert.ToBoolean(row.Cells("eliminar").Value)
    '                If lineaMarcada Then
    '                    Dim llavePrimaria As Integer = Convert.ToInt32(row.Cells("facCodigo").Value)
    '                    Dim tablaDatos As New eFactura
    '                    Dim funcion As New ffactura
    '                    tablaDatos.pfacCodigo = llavePrimaria
    '                    If funcion.eliminar(tablaDatos) Then
    '                        MessageBox.Show("Factura fue eliminado correctamente",
    '                                        "Eliminando registro", MessageBoxButtons.OK,
    '                                        MessageBoxIcon.Information)
    '                    Else
    '                        MessageBox.Show("Factura no fue eliminado correctamente",
    '                                        "Elimando registro", MessageBoxButtons.OK,
    '                                        MessageBoxIcon.Error)
    '                    End If
    '                End If
    '            Next
    '            Call mostrar()
    '            Call limpiar()
    '        Catch evento As Exception
    '            MsgBox(evento.Message)
    '        End Try
    '    Else
    '        MessageBox.Show("Cancelando eliminacion por el usuario",
    '                     "Eliminando registro", MessageBoxButtons.OK,
    '                     MessageBoxIcon.Information)
    '        mostrar()
    '        limpiar()
    '    End If
    'End Sub

    'Private Sub btnQuitarProducto_Click(sender As Object, e As EventArgs) Handles btnQuitarProducto.Click
    '    Dim resultado As DialogResult
    '    resultado = MessageBox.Show("Desea eliminar los datos",
    '                    "Eliminando registro", MessageBoxButtons.OKCancel,
    '                    MessageBoxIcon.Question)
    '    If resultado = Windows.Forms.DialogResult.OK Then
    '        Try
    '            For Each row As DataGridViewRow In dataListadoProducto.Rows
    '                Dim lineaMarcada As Boolean = Convert.ToBoolean(row.Cells("eliminarProducto").Value)
    '                If lineaMarcada Then
    '                    Dim llavePrimaria1 As Integer = Convert.ToInt32(row.Cells("facCodigo").Value)
    '                    Dim llavePrimaria2 As Integer = Convert.ToInt32(row.Cells("proCodigo").Value)
    '                    Dim tablaDatos As New eDetalle
    '                    Dim funcion As New fdetalle
    '                    tablaDatos.pfacCodigo = llavePrimaria1
    '                    tablaDatos.pproCodigo = llavePrimaria2
    '                    If funcion.eliminar(tablaDatos) Then
    '                        funcion.aumentarProducto(tablaDatos)
    '                        MessageBox.Show("Producto fue eliminado correctamente",
    '                                        "Eliminando registro", MessageBoxButtons.OK,
    '                                        MessageBoxIcon.Information)
    '                    Else
    '                        MessageBox.Show("Producto no fue eliminado correctamente",
    '                                        "Elimando registro", MessageBoxButtons.OK,
    '                                        MessageBoxIcon.Error)
    '                    End If
    '                End If
    '            Next
    '            Call mostrarProducto()
    '            Call limpiar()
    '        Catch evento As Exception
    '            MsgBox(evento.Message)
    '        End Try
    '    Else
    '        MessageBox.Show("Cancelando eliminacion por el usuario",
    '                     "Eliminando registro", MessageBoxButtons.OK,
    '                     MessageBoxIcon.Information)
    '        mostrarProducto()
    '        limpiar()
    '    End If
    'End Sub


    'Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
    '    mostrar()
    '    limpiar()
    'End Sub

    'Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
    '    Me.Close()
    'End Sub

    'Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
    '    frmcliente.bandera = True
    '    frmcliente.ShowDialog()
    '    txtCliCodigo.Text = frmcliente.txtCodigo.Text
    '    txtCliNombre.Text = frmcliente.txtNombre.Text
    '    txtCliApellido.Text = frmcliente.txtApellido.Text
    'End Sub

    'Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
    '    frmempleado.bandera = True
    '    frmempleado.ShowDialog()
    '    txtEmpCodigo.Text = frmempleado.txtCodigo.Text
    '    txtEmpNombre.Text = frmempleado.txtNombre.Text
    '    txtEmpPuesto.Text = frmempleado.txtPuesto.Text
    'End Sub

    'Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
    '    frmpago.bandera = True
    '    frmpago.ShowDialog()
    '    txtPagCodigo.Text = frmpago.txtCodigo.Text
    '    txtPagDescripcion.Text = frmpago.txtDescripcion.Text
    'End Sub

    'Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
    '    If txtCodigo.Text <> "" Then
    '        dataListadoProducto.Visible = True
    '    Else
    '        dataListadoProducto.Visible = False
    '    End If
    'End Sub

    'Private Sub nudCantidad_ValueChanged(sender As Object, e As EventArgs) Handles nudCantidad.ValueChanged
    '    If dataListadoProducto.Rows.Count <> 0 Then
    '        If nudCantidad.Value > (dataListadoProducto.SelectedCells.Item(6).Value + dataListadoProducto.SelectedCells.Item(9).Value) Then
    '            nudCantidad.Value = (dataListadoProducto.SelectedCells.Item(6).Value + dataListadoProducto.SelectedCells.Item(9).Value)
    '            MessageBox.Show("No puede seleccionar un valor mayor a la existencia",
    '                         "Cantidad de Producto", MessageBoxButtons.OK,
    '                         MessageBoxIcon.Information)
    '        ElseIf nudCantidad.Value <= 0 Then
    '            nudCantidad.Value = 0
    '        End If
    '    End If
    'End Sub
End Class