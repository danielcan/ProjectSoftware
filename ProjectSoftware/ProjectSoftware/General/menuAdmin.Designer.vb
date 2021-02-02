<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuAdmin
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
        Me.MenuAdminlado = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenubtnEmpleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAdminlado.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuAdminlado
        '
        Me.MenuAdminlado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuAdminlado.Location = New System.Drawing.Point(0, 0)
        Me.MenuAdminlado.Name = "MenuAdminlado"
        Me.MenuAdminlado.Size = New System.Drawing.Size(567, 24)
        Me.MenuAdminlado.TabIndex = 1
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenubtnEmpleado})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'MenubtnEmpleado
        '
        Me.MenubtnEmpleado.Name = "MenubtnEmpleado"
        Me.MenubtnEmpleado.Size = New System.Drawing.Size(127, 22)
        Me.MenubtnEmpleado.Text = "Empleado"
        '
        'menuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 389)
        Me.Controls.Add(Me.MenuAdminlado)
        Me.Name = "menuAdmin"
        Me.Text = "menuAdmin"
        Me.MenuAdminlado.ResumeLayout(False)
        Me.MenuAdminlado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuAdminlado As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenubtnEmpleado As ToolStripMenuItem
End Class
