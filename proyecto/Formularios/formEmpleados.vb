Public Class formEmpleados

    'creación de objetos generales
    Private tablaDatosClase As New DataTable
    Public bandera As New Boolean

    Private Sub formEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbbBuscar.Items.Add("EmpNombre")
        cbbBuscar.Items.Add("EmpApellido")
        cbbBuscar.Items.Add("EmpDireccion")
        cbbBuscar.Items.Add("EmpPuesto")
        cbbBuscar.Text = "EmpCodigo"
        txtCodigo.Enabled = False
        If bandera Then
            btnLimpiar.Visible = False
            btnCancelar.Visible = False
        Else
            btnLimpiar.Visible = True
            btnCancelar.Visible = True
        End If
        mostrar()
        limpiar()

    End Sub


    Private Sub mostrar()
        Try
            Dim funcion As New fEmpleados
            tablaDatosClase = funcion.mostrar
            dataListado.Columns.Item("eliminar").Visible = False
            If tablaDatosClase.Rows.Count <> 0 Then
                dataListado.DataSource = tablaDatosClase
                dataListado.ColumnHeadersVisible = True
            Else
                dataListado.DataSource = Nothing
                dataListado.ColumnHeadersVisible = False
            End If
        Catch evento As Exception
            MsgBox(evento.Message)
        End Try
        buscar()
    End Sub

    Private Sub buscar()
        Try
            Dim conjuntoDatos As New DataSet
            conjuntoDatos.Tables.Add(tablaDatosClase.Copy)
            Dim vistaDatos As New DataView(conjuntoDatos.Tables(0))
            vistaDatos.RowFilter = cbbBuscar.Text & " like '" & txtBuscar.Text & "%'"
            If vistaDatos.Count <> 0 Then
                dataListado.DataSource = vistaDatos
                ocultarColumna()
            Else
                dataListado.DataSource = Nothing
            End If
        Catch evento As Exception
            MsgBox(evento.Message)
        End Try
    End Sub

    Private Sub ocultarColumna()
        'dataListado.Columns(1).Visible = False
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub limpiar()
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtCorreo.Text = ""
        txtSueldo.Text = ""
        txtPuesto.Text = ""
        txtCelular.Text = ""
        dtpIngreso.Value = DateTime.Now
        txtBuscar.Text = ""
        cbbBuscar.Text = "EmpNombre"
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        txtDireccion.Enabled = False
        txtSueldo.Enabled = False
        txtPuesto.Enabled = False
        txtCelular.Enabled = False
        txtCorreo.Enabled = False

        dtpIngreso.Enabled = False
        btnActualizar.Visible = False
        btnGuardar.Visible = False
        btnEliminar.Visible = False
        If bandera Then
            btnInsertar.Visible = False
        Else
            btnInsertar.Visible = True
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub dataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellClick
        traslado_informacion()
        If bandera Then
            btnActualizar.Visible = False
        Else
            btnActualizar.Visible = True
        End If
        btnInsertar.Visible = False
        habilitar()
    End Sub

    Private Sub traslado_informacion()
        txtCodigo.Text = dataListado.SelectedCells.Item(1).Value
        txtNombre.Text = dataListado.SelectedCells.Item(2).Value
        txtApellido.Text = dataListado.SelectedCells.Item(3).Value
        txtTelefono.Text = dataListado.SelectedCells.Item(4).Value
        txtPuesto.Text = dataListado.SelectedCells.Item(5).Value
        txtDireccion.Text = dataListado.SelectedCells.Item(6).Value
        txtCorreo.Text = dataListado.SelectedCells.Item(7).Value
        txtCelular.Text = dataListado.SelectedCells.Item(8).Value
        txtSueldo.Text = dataListado.SelectedCells.Item(9).Value
        dtpIngreso.Value = dataListado.SelectedCells.Item(10).Value
        'falta


    End Sub

    Private Sub habilitar()
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtDireccion.Enabled = True
        txtTelefono.Enabled = True
        txtCorreo.Enabled = True
        txtCelular.Enabled = True
        txtSueldo.Enabled = True
        txtPuesto.Enabled = True
        dtpIngreso.Enabled = True
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        limpiar()
        habilitar()
        btnGuardar.Visible = True
        btnInsertar.Visible = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text <> "" And
            txtDireccion.Text <> "" And
            txtPuesto.Text <> "" And
            txtSueldo.Text <> "" Then
            Try
                Dim tablaDatos As New eEmpleados
                Dim funcion As New fEmpleados
                tablaDatos.gEmpNombre = txtNombre.Text
                tablaDatos.gEmpApellido = txtApellido.Text
                tablaDatos.gEmpTelefono = txtTelefono.Text
                tablaDatos.gEmpCargo = txtPuesto.Text
                tablaDatos.gEmpDireccion = txtDireccion.Text
                tablaDatos.gEmpCorreo = txtCorreo.Text
                tablaDatos.gEmpCelular = txtCelular.Text
                tablaDatos.gEmpSueldo = txtSueldo.Text
                tablaDatos.gEmpFechaIngreso = dtpIngreso.Value
                If funcion.insertar(tablaDatos) Then
                    MessageBox.Show("Empleado fue registrado correctamente",
                                    "Guardando registro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Empleado no fue registrado correctamente",
                                    "Guardando registro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error)
                End If
                mostrar()
                limpiar()
            Catch evento As Exception
                MsgBox(evento.Message)
            End Try
        Else
            MessageBox.Show("Falta informacion para almacenar",
                            "Guardando registro", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtNombre.Text <> "" And
            txtDireccion.Text <> "" And
            txtPuesto.Text <> "" And
            txtSueldo.Text <> "" Then
            Dim resultado As DialogResult
            resultado = MessageBox.Show("Desea modificar los datos",
                            "Actualizando registro", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question)
            If resultado = Windows.Forms.DialogResult.OK Then
                Try
                    Dim tablaDatos As New eEmpleados
                    Dim funcion As New fEmpleados
                    tablaDatos.gEmpNombre = txtNombre.Text
                    tablaDatos.gEmpApellido = txtApellido.Text
                    tablaDatos.gEmpTelefono = txtTelefono.Text
                    tablaDatos.gEmpCargo = txtPuesto.Text
                    tablaDatos.gEmpDireccion = txtDireccion.Text
                    tablaDatos.gEmpCorreo = txtCorreo.Text
                    tablaDatos.gEmpCelular = txtCelular.Text
                    tablaDatos.gEmpSueldo = txtSueldo.Text
                    tablaDatos.gEmpFechaIngreso = dtpIngreso.Value
                    If funcion.editar(tablaDatos) Then
                        MessageBox.Show("Empleado fue actualizado correctamente",
                                        "Actualizando registro", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Empleado no fue actualizado correctamente",
                                        "Actualizando registro", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
                    End If
                    mostrar()
                    limpiar()
                Catch evento As Exception
                    MsgBox(evento.Message)
                End Try
            Else
                MessageBox.Show("Cancelando actualizado por el usuario",
                                "Actualizando registro", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Falta informacion para almacenar",
                            "Actualizando registro", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cbxEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbxEliminar.CheckedChanged
        If cbxEliminar.CheckState = CheckState.Checked Then
            dataListado.Columns.Item("eliminar").Visible = True
            btnEliminar.Visible = True
            btnInsertar.Visible = False
        Else
            dataListado.Columns.Item("eliminar").Visible = False
            btnEliminar.Visible = False
            btnInsertar.Visible = True
        End If
    End Sub

    Private Sub dataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellContentClick
        If e.ColumnIndex = Me.dataListado.Columns.Item("eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.dataListado.Rows(e.RowIndex).Cells("eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("Desea eliminar los datos",
                        "Eliminando registro", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question)
        If resultado = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dataListado.Rows
                    Dim lineaMarcada As Boolean = Convert.ToBoolean(row.Cells("eliminar").Value)
                    If lineaMarcada Then
                        Dim llavePrimaria As Integer = Convert.ToInt32(row.Cells("empCodigo").Value)
                        Dim tablaDatos As New eEmpleados
                        Dim funcion As New fEmpleados
                        tablaDatos.gEmpCodigo = llavePrimaria
                        If funcion.eliminar(tablaDatos) Then
                            MessageBox.Show("Empleado fue eliminado correctamente",
                                            "Eliminando registro", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Empleado no fue eliminado correctamente",
                                            "Elimando registro", MessageBoxButtons.OK,
                                            MessageBoxIcon.Error)
                        End If
                    End If
                Next
                Call mostrar()
                Call limpiar()
            Catch evento As Exception
                MsgBox(evento.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminacion por el usuario",
                         "Eliminando registro", MessageBoxButtons.OK,
                         MessageBoxIcon.Information)
            mostrar()
            limpiar()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        mostrar()
        limpiar()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


End Class