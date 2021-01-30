
Public Class eFactura
    Dim FacCodigo, FacSubTotal, FacTotal, EmpCodigo, CliCodigo, CatCodigo, CaCodigo As Integer
    Dim FacDescripcion As Integer
    Dim FacFecha As Date

    Public Property gFacCodigo
        Get
            Return FacCodigo
        End Get
        Set(value)
            FacCodigo = value
        End Set
    End Property

    Public Property gFacSubTotal
        Get
            Return FacSubTotal
        End Get
        Set(value)
            FacSubTotal = value
        End Set
    End Property

    Public Property gFacTotal
        Get
            Return FacTotal
        End Get
        Set(value)
            FacTotal = value
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

    Public Property gCliCodigo
        Get
            Return CliCodigo
        End Get
        Set(value)
            CliCodigo = value
        End Set
    End Property

    Public Property gCatCodigo
        Get
            Return CatCodigo
        End Get
        Set(value)
            CatCodigo = value
        End Set
    End Property

    Public Property gCaCodigo
        Get
            Return CaCodigo
        End Get
        Set(value)
            CaCodigo = value
        End Set
    End Property

    Public Property gFacDescripcion
        Get
            Return FacDescripcion
        End Get
        Set(value)
            FacDescripcion = value
        End Set
    End Property

    Public Property gFacFecha
        Get
            Return FacFecha
        End Get
        Set(value)
            FacFecha = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(FacCodigo As Integer, FacSubTotal As Integer, FacTotal As Integer,
                   EmpCodigo As Integer, CliCodigo As Integer,
                   CatCodigo As Integer, CaCodigo As Integer, FacDescripcion As String, FacFecha As Date)

        gFacCodigo = FacCodigo
        gFacSubTotal = FacSubTotal
        gFacTotal = FacTotal
        gEmpCodigo = EmpCodigo
        gCliCodigo = CliCodigo
        gCatCodigo = CatCodigo
        gCaCodigo = CaCodigo
        gFacDescripcion = FacDescripcion
        gFacFecha = FacFecha

    End Sub

End Class
