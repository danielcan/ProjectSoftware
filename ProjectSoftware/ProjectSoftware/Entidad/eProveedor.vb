Public Class eProveedor
    Dim ProCodigo As Integer
    Dim ProNombre, ProTelefono, ProCelular, ProCorreo, ProIdentidad As String

    Public Property gProCodigo
        Get
            Return ProCodigo
        End Get
        Set(value)
            ProCodigo = value
        End Set
    End Property


    Public Property gProIdentidad
        Get
            Return ProIdentidad
        End Get
        Set(value)
            ProIdentidad = value
        End Set
    End Property

    Public Property gProNombre
        Get
            Return ProNombre
        End Get
        Set(value)
            ProNombre = value
        End Set
    End Property

    Public Property gProTelefono
        Get
            Return ProTelefono
        End Get
        Set(value)
            ProTelefono = value
        End Set
    End Property


    Public Property gProCelular
        Get
            Return ProCelular
        End Get
        Set(value)
            ProCelular = value
        End Set
    End Property

    Public Property gProCorreo
        Get
            Return ProCorreo
        End Get
        Set(value)
            ProCorreo = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ProCodigo As Integer, ProIdentidad As String,
                   ProNombre As String, ProTelefono As String, ProCelular As String, ProCorreo As String)

        gProCodigo = ProCodigo
        gProIdentidad = ProIdentidad
        gProNombre = ProNombre
        gProTelefono = ProTelefono
        gProCelular = ProCelular
        gProCorreo = ProCorreo

    End Sub

End Class
