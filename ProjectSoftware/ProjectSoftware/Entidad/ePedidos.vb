Public Class ePedidos

    Dim PeCodigo, OrCodigo As Integer
    Dim PeFecha As Date
    Dim PeDescripcion As String

    Public Property gPeCodigo
        Get
            Return PeCodigo
        End Get
        Set(value)
            PeCodigo = value
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

    Public Property gPeFecha
        Get
            Return PeFecha
        End Get
        Set(value)
            PeFecha = value
        End Set
    End Property

    Public Property gPeDescripcion
        Get
            Return PeDescripcion
        End Get
        Set(value)
            PeDescripcion = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(PeCodigo As Integer, OrCodigo As Integer, PeFecha As Date, PeDescripcion As String)
        gPeCodigo = PeCodigo
        gOrCodigo = OrCodigo
        gPeFecha = PeFecha
        gPeDescripcion = PeDescripcion
    End Sub

End Class
