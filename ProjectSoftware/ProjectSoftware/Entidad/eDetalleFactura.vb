Public Class eDetalleFactura

    Dim FacCodigo, DFCantidad As String
    Dim TipoPago As String

    Public Property gFacCodigo
        Get
            Return FacCodigo
        End Get
        Set(value)
            FacCodigo = value
        End Set
    End Property

    Public Property gDFCantidad
        Get
            Return DFCantidad
        End Get
        Set(value)
            DFCantidad = value
        End Set
    End Property

    Public Property gTipoPago
        Get
            Return TipoPago
        End Get
        Set(value)
            TipoPago = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(FacCodigo As Integer, DFCantidad As Integer, TipoPago As String)

        gFacCodigo = FacCodigo
        gDFCantidad = DFCantidad
        gTipoPago = TipoPago
    End Sub
End Class
