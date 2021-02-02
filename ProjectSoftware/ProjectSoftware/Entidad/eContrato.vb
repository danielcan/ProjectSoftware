Public Class eContrato

    Dim ConCodigo, Empcodigo As Integer
    Dim ConFecha As Date
    Dim ConDescripcion As String

    Public Property gConCodigo
        Get
            Return ConCodigo
        End Get
        Set(value)
            ConCodigo = value
        End Set
    End Property

    Public Property gEmpcodigo
        Get
            Return Empcodigo
        End Get
        Set(value)
            Empcodigo = value
        End Set
    End Property

    Public Property gConFecha
        Get
            Return ConFecha
        End Get
        Set(value)
            ConFecha = value
        End Set
    End Property

    Public Property gConDescripcion
        Get
            Return ConDescripcion
        End Get
        Set(value)
            ConDescripcion = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ConCodigo As Integer, Empcodigo As Integer, ConFecha As Date, ConDescripcion As String)
        gConCodigo = ConCodigo
        gEmpcodigo = Empcodigo
        gConFecha = ConFecha
        gConDescripcion = ConDescripcion
    End Sub

End Class
