Public Class eCatalogo

    Dim CatCodigo, CatCantidad As Integer
    Dim CatFecha As Date
    Dim CatCategorias As String

    Public Property gCatCodigo
        Get
            Return CatCodigo
        End Get
        Set(value)
            CatCodigo = value
        End Set
    End Property

    Public Property gCatCantidad
        Get
            Return CatCantidad
        End Get
        Set(value)
            CatCantidad = value
        End Set
    End Property

    Public Property gCatFecha
        Get
            Return CatFecha
        End Get
        Set(value)
            CatFecha = value
        End Set
    End Property

    Public Property gCatCategorias
        Get
            Return CatCategorias
        End Get
        Set(value)
            CatCategorias = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(CatCodigo As Integer, CatCantidad As Integer, CatFecha As Date, CatCategorias As String)

        gCatCodigo = CatCodigo
        gCatCantidad = CatCantidad
        gCatFecha = CatFecha
        gCatCategorias = CatCategorias

    End Sub

End Class
