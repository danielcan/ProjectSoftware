
Public Class eEmpleados

    Dim EmpCodigo, TurCodigo, Orcodigo As Integer
    Dim EmpNombreCompleto, EmpTelefono, EmpCargo, EmpCorreo, EmpCelular, EmSueldo As String
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

    Public Property gEmpNombreCompleto
        Get
            Return EmpNombreCompleto
        End Get
        Set(value)
            EmpNombreCompleto = value
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

    Public Property gEmSueldo
        Get
            Return EmSueldo
        End Get
        Set(value)
            EmSueldo = value
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
    EmpNombreCompleto As String, EmpTelefono As String, EmpCargo As String,
    EmpCorreo As String, EmpCelular As String, EmSueldo As String, EmpFechaIngreso As Date)

        gEmpCodigo = EmpCodigo
        gTurCodigo = TurCodigo
        gOrcodigo = Orcodigo
        gEmpNombreCompleto = EmpNombreCompleto
        gEmpTelefono = EmpTelefono
        gEmpCargo = EmpCargo
        gEmpCorreo = EmpCorreo
        gEmpCelular = EmpCelular
        gEmSueldo = EmSueldo
        gEmpFechaIngreso = EmpFechaIngreso

    End Sub

End Class
