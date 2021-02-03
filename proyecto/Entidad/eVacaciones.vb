Public Class eVacaciones

    Dim VacCodigo, VacDiasTomados, EmpCodigo As Integer
    Dim VacDia, VacAnio As Date

    Public Property gVacCodigo
        Get
            Return VacCodigo
        End Get
        Set(value)
            VacCodigo = value
        End Set
    End Property

    Public Property gVacDiasTomados
        Get
            Return VacDiasTomados
        End Get
        Set(value)
            VacDiasTomados = value
        End Set
    End Property

    Public Property gEmpCodigo
        Get
            Return EmpCodigo
        End Get
        Set(value)
            EmpCodigo = value
        End Set
    End Property

    Public Property gVacDia
        Get
            Return VacDia
        End Get
        Set(value)
            VacDia = value
        End Set
    End Property

    Public Property gVacAnio
        Get
            Return VacAnio
        End Get
        Set(value)
            VacAnio = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(VacCodigo As Integer, VacDiasTomados As Integer, EmpCodigo As Integer, VacDia As Date, VacAnio As Date)
        gVacCodigo = VacCodigo
        gVacDiasTomados = VacDiasTomados
        gEmpCodigo = EmpCodigo
        gVacDia = VacDia
        gVacAnio = VacAnio
    End Sub

End Class
