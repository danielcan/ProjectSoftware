Public Class eServicio

    Dim ServCodigo, OrCodigo As Integer
    Dim ServTipoServicio, SerDescripcion As String

    Public Property gServCodigo
        Get
            Return ServCodigo
        End Get
        Set(value)
            ServCodigo = value
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

    Public Property gServTipoServicio
        Get
            Return ServTipoServicio
        End Get
        Set(value)
            ServTipoServicio = value
        End Set
    End Property

    Public Property gSerDescripcion
        Get
            Return SerDescripcion
        End Get
        Set(value)
            SerDescripcion = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ServCodigo As Integer, OrCodigo As Integer, ServTipoServicio As String, SerDescripcion As String)
        gServTipoServicio = ServTipoServicio
        gServCodigo = ServCodigo
        gOrCodigo = OrCodigo
        gSerDescripcion = SerDescripcion
    End Sub
End Class
