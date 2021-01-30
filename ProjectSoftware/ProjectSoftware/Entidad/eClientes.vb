Public Class eClientes
    Dim CliCodigo As Integer
    Dim CliIdentidad, CliNombreCompleto, CliTelefono, CliCorreo As String

    Public Property gCliCodigo
        Get
            Return CliCodigo
        End Get
        Set(value)
            CliCodigo = value
        End Set
    End Property

    Public Property gCliIdentidad
        Get
            Return CliIdentidad
        End Get
        Set(value)
            CliIdentidad = value
        End Set
    End Property

    Public Property gCliNombreCompleto
        Get
            Return CliNombreCompleto
        End Get
        Set(value)
            CliNombreCompleto = value
        End Set
    End Property

    Public Property gCliTelefono
        Get
            Return CliTelefono
        End Get
        Set(value)
            CliTelefono = value
        End Set
    End Property

    Public Property gCliCorreo
        Get
            Return CliCorreo
        End Get
        Set(value)
            CliCorreo = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(CliCodigo As Integer,
  CliIdentidad As String, CliNombreCompleto As String, CliTelefono As String, CliCorreo As String)
        gCliCodigo = CliCodigo
        gCliIdentidad = CliIdentidad
        gCliNombreCompleto = CliNombreCompleto
        gCliTelefono = CliTelefono
        gCliCorreo = CliCorreo
    End Sub

End Class
