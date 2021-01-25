<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formFactura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPagDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCliNombre = New System.Windows.Forms.TextBox()
        Me.txtCliApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPagCodigo = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtEmpCodigo = New System.Windows.Forms.TextBox()
        Me.btnEmpleado = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmpNombre = New System.Windows.Forms.TextBox()
        Me.txtEmpPuesto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCliCodigo = New System.Windows.Forms.TextBox()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnCancelarProducto = New System.Windows.Forms.Button()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnActualizarProducto = New System.Windows.Forms.Button()
        Me.btnInsertarProducto = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGuardarProducto = New System.Windows.Forms.Button()
        Me.ckbQuitarProducto = New System.Windows.Forms.CheckBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.btnQuitarProducto = New System.Windows.Forms.Button()
        Me.txtNomProducto = New System.Windows.Forms.TextBox()
        Me.txtCatProducto = New System.Windows.Forms.TextBox()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.txtVencimiento = New System.Windows.Forms.TextBox()
        Me.txtCodProducto = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtImpuesto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.dataListadoProducto = New System.Windows.Forms.DataGridView()
        Me.eliminarProducto = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.ckbEliminar = New System.Windows.Forms.CheckBox()
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dataListadoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(189, 392)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(189, 323)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(107, 323)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 15
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(25, 323)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertar.TabIndex = 14
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Forma de Pago"
        '
        'txtPagDescripcion
        '
        Me.txtPagDescripcion.Location = New System.Drawing.Point(124, 278)
        Me.txtPagDescripcion.Name = "txtPagDescripcion"
        Me.txtPagDescripcion.Size = New System.Drawing.Size(99, 20)
        Me.txtPagDescripcion.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'txtCliNombre
        '
        Me.txtCliNombre.Location = New System.Drawing.Point(91, 16)
        Me.txtCliNombre.Name = "txtCliNombre"
        Me.txtCliNombre.Size = New System.Drawing.Size(110, 20)
        Me.txtCliNombre.TabIndex = 2
        '
        'txtCliApellido
        '
        Me.txtCliApellido.Location = New System.Drawing.Point(91, 42)
        Me.txtCliApellido.Name = "txtCliApellido"
        Me.txtCliApellido.Size = New System.Drawing.Size(110, 20)
        Me.txtCliApellido.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellido"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(189, 362)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 17
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(54, 21)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(59, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(75, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 37)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Factura"
        '
        'txtPagCodigo
        '
        Me.txtPagCodigo.Location = New System.Drawing.Point(91, 278)
        Me.txtPagCodigo.Name = "txtPagCodigo"
        Me.txtPagCodigo.Size = New System.Drawing.Size(31, 20)
        Me.txtPagCodigo.TabIndex = 24
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(54, 47)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(120, 20)
        Me.dtpFecha.TabIndex = 23
        '
        'btnPago
        '
        Me.btnPago.Location = New System.Drawing.Point(229, 278)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(30, 23)
        Me.btnPago.TabIndex = 22
        Me.btnPago.Text = "..."
        Me.btnPago.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox4.Controls.Add(Me.txtEmpCodigo)
        Me.GroupBox4.Controls.Add(Me.btnEmpleado)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtEmpNombre)
        Me.GroupBox4.Controls.Add(Me.txtEmpPuesto)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 179)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(248, 72)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Informacion del Empleado"
        '
        'txtEmpCodigo
        '
        Me.txtEmpCodigo.Location = New System.Drawing.Point(59, 16)
        Me.txtEmpCodigo.Name = "txtEmpCodigo"
        Me.txtEmpCodigo.Size = New System.Drawing.Size(31, 20)
        Me.txtEmpCodigo.TabIndex = 23
        '
        'btnEmpleado
        '
        Me.btnEmpleado.Location = New System.Drawing.Point(203, 16)
        Me.btnEmpleado.Name = "btnEmpleado"
        Me.btnEmpleado.Size = New System.Drawing.Size(30, 23)
        Me.btnEmpleado.TabIndex = 22
        Me.btnEmpleado.Text = "..."
        Me.btnEmpleado.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre"
        '
        'txtEmpNombre
        '
        Me.txtEmpNombre.Location = New System.Drawing.Point(91, 16)
        Me.txtEmpNombre.Name = "txtEmpNombre"
        Me.txtEmpNombre.Size = New System.Drawing.Size(110, 20)
        Me.txtEmpNombre.TabIndex = 2
        '
        'txtEmpPuesto
        '
        Me.txtEmpPuesto.Location = New System.Drawing.Point(91, 42)
        Me.txtEmpPuesto.Name = "txtEmpPuesto"
        Me.txtEmpPuesto.Size = New System.Drawing.Size(110, 20)
        Me.txtEmpPuesto.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Puesto"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(201, 505)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.txtCliCodigo)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtCliNombre)
        Me.GroupBox3.Controls.Add(Me.btnCliente)
        Me.GroupBox3.Controls.Add(Me.txtCliApellido)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 85)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 72)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informacion del Cliente"
        '
        'txtCliCodigo
        '
        Me.txtCliCodigo.Location = New System.Drawing.Point(59, 16)
        Me.txtCliCodigo.Name = "txtCliCodigo"
        Me.txtCliCodigo.Size = New System.Drawing.Size(31, 20)
        Me.txtCliCodigo.TabIndex = 22
        '
        'btnCliente
        '
        Me.btnCliente.Location = New System.Drawing.Point(203, 14)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(30, 23)
        Me.btnCliente.TabIndex = 21
        Me.btnCliente.Text = "..."
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Fecha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtPagCodigo)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.btnPago)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.btnInsertar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPagDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 430)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento de Datos"
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.ckbEliminar)
        Me.GroupBox2.Controls.Add(Me.dataListado)
        Me.GroupBox2.Location = New System.Drawing.Point(288, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(486, 532)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnCancelarProducto)
        Me.GroupBox6.Controls.Add(Me.txtPrecioVenta)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.btnActualizarProducto)
        Me.GroupBox6.Controls.Add(Me.btnInsertarProducto)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.btnGuardarProducto)
        Me.GroupBox6.Controls.Add(Me.ckbQuitarProducto)
        Me.GroupBox6.Controls.Add(Me.txtStock)
        Me.GroupBox6.Controls.Add(Me.btnQuitarProducto)
        Me.GroupBox6.Controls.Add(Me.txtNomProducto)
        Me.GroupBox6.Controls.Add(Me.txtCatProducto)
        Me.GroupBox6.Controls.Add(Me.nudCantidad)
        Me.GroupBox6.Controls.Add(Me.txtVencimiento)
        Me.GroupBox6.Controls.Add(Me.txtCodProducto)
        Me.GroupBox6.Location = New System.Drawing.Point(7, 418)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(474, 104)
        Me.GroupBox6.TabIndex = 42
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Productos"
        '
        'btnCancelarProducto
        '
        Me.btnCancelarProducto.Location = New System.Drawing.Point(107, 74)
        Me.btnCancelarProducto.Name = "btnCancelarProducto"
        Me.btnCancelarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarProducto.TabIndex = 26
        Me.btnCancelarProducto.Text = "Cancelar"
        Me.btnCancelarProducto.UseVisualStyleBackColor = True
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(332, 19)
        Me.txtPrecioVenta.MaxLength = 13
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(51, 20)
        Me.txtPrecioVenta.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(117, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Vencimiento"
        '
        'btnActualizarProducto
        '
        Me.btnActualizarProducto.Location = New System.Drawing.Point(10, 72)
        Me.btnActualizarProducto.Name = "btnActualizarProducto"
        Me.btnActualizarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizarProducto.TabIndex = 15
        Me.btnActualizarProducto.Text = "Actualizar"
        Me.btnActualizarProducto.UseVisualStyleBackColor = True
        '
        'btnInsertarProducto
        '
        Me.btnInsertarProducto.Location = New System.Drawing.Point(10, 17)
        Me.btnInsertarProducto.Name = "btnInsertarProducto"
        Me.btnInsertarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertarProducto.TabIndex = 14
        Me.btnInsertarProducto.Text = "Insertar"
        Me.btnInsertarProducto.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(271, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Existencia"
        '
        'btnGuardarProducto
        '
        Me.btnGuardarProducto.Location = New System.Drawing.Point(393, 43)
        Me.btnGuardarProducto.Name = "btnGuardarProducto"
        Me.btnGuardarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarProducto.TabIndex = 16
        Me.btnGuardarProducto.Text = "Guardar"
        Me.btnGuardarProducto.UseVisualStyleBackColor = True
        '
        'ckbQuitarProducto
        '
        Me.ckbQuitarProducto.AutoSize = True
        Me.ckbQuitarProducto.Location = New System.Drawing.Point(364, 77)
        Me.ckbQuitarProducto.Name = "ckbQuitarProducto"
        Me.ckbQuitarProducto.Size = New System.Drawing.Size(100, 17)
        Me.ckbQuitarProducto.TabIndex = 3
        Me.ckbQuitarProducto.Text = "Quitar Producto"
        Me.ckbQuitarProducto.UseVisualStyleBackColor = True
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(332, 45)
        Me.txtStock.MaxLength = 13
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(55, 20)
        Me.txtStock.TabIndex = 39
        '
        'btnQuitarProducto
        '
        Me.btnQuitarProducto.Location = New System.Drawing.Point(283, 71)
        Me.btnQuitarProducto.Name = "btnQuitarProducto"
        Me.btnQuitarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitarProducto.TabIndex = 4
        Me.btnQuitarProducto.Text = "Quitar"
        Me.btnQuitarProducto.UseVisualStyleBackColor = True
        '
        'txtNomProducto
        '
        Me.txtNomProducto.Location = New System.Drawing.Point(126, 20)
        Me.txtNomProducto.MaxLength = 13
        Me.txtNomProducto.Name = "txtNomProducto"
        Me.txtNomProducto.Size = New System.Drawing.Size(200, 20)
        Me.txtNomProducto.TabIndex = 27
        '
        'txtCatProducto
        '
        Me.txtCatProducto.Location = New System.Drawing.Point(10, 46)
        Me.txtCatProducto.MaxLength = 13
        Me.txtCatProducto.Name = "txtCatProducto"
        Me.txtCatProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtCatProducto.TabIndex = 28
        '
        'nudCantidad
        '
        Me.nudCantidad.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudCantidad.Location = New System.Drawing.Point(389, 17)
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(58, 20)
        Me.nudCantidad.TabIndex = 29
        '
        'txtVencimiento
        '
        Me.txtVencimiento.Location = New System.Drawing.Point(188, 45)
        Me.txtVencimiento.MaxLength = 13
        Me.txtVencimiento.Name = "txtVencimiento"
        Me.txtVencimiento.Size = New System.Drawing.Size(77, 20)
        Me.txtVencimiento.TabIndex = 31
        '
        'txtCodProducto
        '
        Me.txtCodProducto.Location = New System.Drawing.Point(91, 19)
        Me.txtCodProducto.MaxLength = 13
        Me.txtCodProducto.Name = "txtCodProducto"
        Me.txtCodProducto.Size = New System.Drawing.Size(29, 20)
        Me.txtCodProducto.TabIndex = 32
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txtTotal)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txtImpuesto)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.txtSubTotal)
        Me.GroupBox5.Controls.Add(Me.dataListadoProducto)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 172)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(473, 240)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalle de la Venta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(290, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(354, 207)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(290, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Impuesto"
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Location = New System.Drawing.Point(354, 181)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.txtImpuesto.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(290, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Sub-Total"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(354, 155)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubTotal.TabIndex = 33
        '
        'dataListadoProducto
        '
        Me.dataListadoProducto.AllowUserToAddRows = False
        Me.dataListadoProducto.AllowUserToDeleteRows = False
        Me.dataListadoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListadoProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminarProducto})
        Me.dataListadoProducto.Location = New System.Drawing.Point(6, 19)
        Me.dataListadoProducto.Name = "dataListadoProducto"
        Me.dataListadoProducto.ReadOnly = True
        Me.dataListadoProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListadoProducto.Size = New System.Drawing.Size(458, 132)
        Me.dataListadoProducto.TabIndex = 2
        '
        'eliminarProducto
        '
        Me.eliminarProducto.HeaderText = "eliminar"
        Me.eliminarProducto.Name = "eliminarProducto"
        Me.eliminarProducto.ReadOnly = True
        Me.eliminarProducto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.eliminarProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(400, 148)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'ckbEliminar
        '
        Me.ckbEliminar.AutoSize = True
        Me.ckbEliminar.Location = New System.Drawing.Point(289, 152)
        Me.ckbEliminar.Name = "ckbEliminar"
        Me.ckbEliminar.Size = New System.Drawing.Size(62, 17)
        Me.ckbEliminar.TabIndex = 3
        Me.ckbEliminar.Text = "Eliminar"
        Me.ckbEliminar.UseVisualStyleBackColor = True
        '
        'dataListado
        '
        Me.dataListado.AllowUserToAddRows = False
        Me.dataListado.AllowUserToDeleteRows = False
        Me.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        Me.dataListado.Location = New System.Drawing.Point(6, 19)
        Me.dataListado.Name = "dataListado"
        Me.dataListado.ReadOnly = True
        Me.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListado.Size = New System.Drawing.Size(474, 123)
        Me.dataListado.TabIndex = 2
        '
        'formFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 559)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "formFactura"
        Me.Text = "formFactura"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dataListadoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPagDescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCliNombre As TextBox
    Friend WithEvents txtCliApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPagCodigo As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnPago As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtEmpCodigo As TextBox
    Friend WithEvents btnEmpleado As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmpNombre As TextBox
    Friend WithEvents txtEmpPuesto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCliCodigo As TextBox
    Friend WithEvents btnCliente As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnCancelarProducto As Button
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnActualizarProducto As Button
    Friend WithEvents btnInsertarProducto As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btnGuardarProducto As Button
    Friend WithEvents ckbQuitarProducto As CheckBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents btnQuitarProducto As Button
    Friend WithEvents txtNomProducto As TextBox
    Friend WithEvents txtCatProducto As TextBox
    Friend WithEvents nudCantidad As NumericUpDown
    Friend WithEvents txtVencimiento As TextBox
    Friend WithEvents txtCodProducto As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtImpuesto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents dataListadoProducto As DataGridView
    Friend WithEvents eliminarProducto As DataGridViewCheckBoxColumn
    Friend WithEvents btnEliminar As Button
    Friend WithEvents ckbEliminar As CheckBox
    Friend WithEvents dataListado As DataGridView
End Class
