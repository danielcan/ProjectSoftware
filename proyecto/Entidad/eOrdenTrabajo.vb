Public Class eOrdenTrabajo

    Dim OrCodigo, ServCodigo, CliCodigo As Integer
    Dim Orfecha As Date
    Dim RecepcionEquipo As String

    Public Property gOrCodigo
        Get
            Return OrCodigo
        End Get
        Set(value)
            OrCodigo = value
        End Set
    End Property

    Public Property gServCodigo
        Get
            Return ServCodigo
        End Get
        Set(value)
            ServCodigo = value
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

    Public Property gOrfecha
        Get
            Return Orfecha
        End Get
        Set(value)
            Orfecha = value
        End Set
    End Property

    Public Property gRecepcionEquipo
        Get
            Return RecepcionEquipo
        End Get
        Set(value)
            RecepcionEquipo = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(OrCodigo As String, ServCodigo As String, CliCodigo As Integer,
                   Orfecha As Date, RecepcionEquipo As String)
        gCliCodigo = CliCodigo
        gServCodigo = ServCodigo
        gOrCodigo = OrCodigo
        gOrfecha = Orfecha
        gRecepcionEquipo = RecepcionEquipo
    End Sub
End Class
