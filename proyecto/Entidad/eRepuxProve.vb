Public Class eRepuxProve
    Dim ReCodigo, ProCodigo, CatCodigo As Integer
    Dim FechaCompra As Date

    Public Property gReCodigo
        Get
            Return ReCodigo
        End Get
        Set(value)
            ReCodigo = value
        End Set
    End Property

    Public Property gProCodigo
        Get
            Return ProCodigo
        End Get
        Set(value)
            ProCodigo = value
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

    Public Property gFechaCompra
        Get
            Return FechaCompra
        End Get
        Set(value)
            FechaCompra = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ReCodigo As Integer, ProCodigo As Integer, CatCodigo As Integer, FechaCompra As Date)
        gReCodigo = ReCodigo
        gProCodigo = ProCodigo
        gCatCodigo = CatCodigo
        gFechaCompra = FechaCompra
    End Sub


End Class

