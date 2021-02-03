Public Class eRepuesto
    Dim ReCodigo, RePrecio As Integer
    Dim ReMarca, ReTraido, ReDescripcion As String

    Public Property gReCodigo
        Get
            Return ReCodigo
        End Get
        Set(value)
            ReCodigo = value
        End Set
    End Property

    Public Property gRePrecio
        Get
            Return RePrecio
        End Get
        Set(value)
            RePrecio = value
        End Set
    End Property

    Public Property gReMarca
        Get
            Return ReMarca
        End Get
        Set(value)
            ReMarca = value
        End Set
    End Property

    Public Property gReTraido
        Get
            Return ReTraido
        End Get
        Set(value)
            ReTraido = value
        End Set
    End Property

    Public Property gReDescripcion
        Get
            Return ReDescripcion
        End Get
        Set(value)
            ReDescripcion = value
        End Set
    End Property
    Public Sub New()
    End Sub

    Public Sub New(ReCodigo As Integer, RePrecio As Integer, ReMarca As String, ReTraido As String, ReDescripcion As String)
        gReCodigo = ReCodigo
        gRePrecio = RePrecio
        gReMarca = ReMarca
        gReTraido = ReTraido
        gReDescripcion = ReDescripcion
    End Sub
End Class
