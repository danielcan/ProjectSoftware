
Public Class eEmpleados

    Dim EmpCodigo, TurCodigo, Orcodigo As Integer
    Dim EmpNombre, EmpApellido, EmpTelefono, EmpCargo, EmpDireccion, EmpCorreo, EmpCelular, EmpSueldo As String
    Dim EmpFechaIngreso As Date

    Public Property gEmpCodigo
        Get
            Return EmpCodigo
        End Get
        Set(value)
            EmpCodigo = value
        End Set
    End Property

    Public Property gTurCodigo
        Get
            Return TurCodigo
        End Get
        Set(value)
            TurCodigo = value
        End Set
    End Property

    Public Property gOrcodigo
        Get
            Return Orcodigo
        End Get
        Set(value)
            Orcodigo = value
        End Set
    End Property

    Public Property gEmpNombre
        Get
            Return EmpNombre
        End Get
        Set(value)
            EmpNombre = value
        End Set
    End Property

    Public Property gEmpApellido
        Get
            Return EmpApellido
        End Get
        Set(value)
            EmpApellido = value
        End Set
    End Property


    Public Property gEmpTelefono
        Get
            Return EmpTelefono
        End Get
        Set(value)
            EmpTelefono = value
        End Set
    End Property

    Public Property gEmpCargo
        Get
            Return EmpCargo
        End Get
        Set(value)
            EmpCargo = value
        End Set
    End Property

    Public Property gEmpDireccion
        Get
            Return EmpDireccion
        End Get
        Set(value)
            EmpDireccion = value
        End Set
    End Property

    Public Property gEmpCorreo
        Get
            Return EmpCorreo
        End Get
        Set(value)
            EmpCorreo = value
        End Set
    End Property

    Public Property gEmpCelular
        Get
            Return EmpCelular
        End Get
        Set(value)
            EmpCelular = value
        End Set
    End Property

    Public Property gEmpSueldo
        Get
            Return EmpSueldo
        End Get
        Set(value)
            EmpSueldo = value
        End Set
    End Property

    Public Property gEmpFechaIngreso
        Get
            Return EmpFechaIngreso
        End Get
        Set(value)
            EmpFechaIngreso = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(EmpCodigo As Integer, TurCodigo As Integer, Orcodigo As Integer,
    EmpNombreCompleto As String, EmpTelefono As String, EmpCargo As String, EmpDirrecion As String,
    EmpCorreo As String, EmpApellido As String, EmpCelular As String, EmpSueldo As String, EmpFechaIngreso As Date)

        gEmpCodigo = EmpCodigo
        gTurCodigo = TurCodigo
        gOrcodigo = Orcodigo
        gEmpNombre = EmpNombre
        gEmpApellido = EmpApellido
        gEmpTelefono = EmpTelefono
        gEmpCargo = EmpCargo
        gEmpDireccion = EmpDireccion
        gEmpCorreo = EmpCorreo
        gEmpCelular = EmpCelular
        gEmpSueldo = EmpSueldo
        gEmpFechaIngreso = EmpFechaIngreso

    End Sub

End Class
