Public Class eBono

    Dim BoCodigo, BoPorCentaje, OrCodigo As Integer
    Dim BoFecha As Date

    Public Property gBoCodigo
        Get
            Return BoCodigo
        End Get
        Set(value)
            BoCodigo = value
        End Set
    End Property

    Public Property gBoPorCentaje
        Get
            Return BoPorCentaje
        End Get
        Set(value)
            BoPorCentaje = value
        End Set
    End Property

    Public Property gOrCodigo
        Get
            Return OrCodigo
        End Get
        Set(value)
            OrCodigo = value
        End Set
    End Property

    Public Property gBoFecha
        Get
            Return BoFecha
        End Get
        Set(value)
            BoFecha = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(BoCodigo As Integer, BoPorCentaje As Integer, OrCodigo As Integer, BoFecha As Date)
        gBoCodigo = BoCodigo
        gBoPorCentaje = BoPorCentaje
        gOrCodigo = OrCodigo
        gBoFecha = BoFecha
    End Sub

End Class
