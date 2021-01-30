Public Class eCaja



    Dim CaCodigo, CaApertura, CaCierre As Integer
    Dim Cafecha As Date
    Dim CaDescripcion As String


    Public Property gCaCodigo
        Get
            Return CaCodigo
        End Get
        Set(value)
            CaCodigo = value
        End Set
    End Property


    Public Property gCaApertura
        Get
            Return CaApertura
        End Get
        Set(value)
            CaApertura = value
        End Set
    End Property


    Public Property gCaCierre
        Get
            Return CaCierre
        End Get
        Set(value)
            CaCierre = value
        End Set
    End Property


    Public Property gCafecha
        Get
            Return Cafecha
        End Get
        Set(value)
            Cafecha = value
        End Set
    End Property

    Public Property gCaDescripcion
        Get
            Return CaDescripcion
        End Get
        Set(value)
            CaDescripcion = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(CaCodigo As Integer, CaApertura As Integer, CaCierre As Integer,
    Cafecha As Date, CaDescripcion As String)
        gCaCodigo = CaCodigo
        gCaApertura = CaApertura
        gCaCierre = CaCierre
        gCafecha = Cafecha
        gCaDescripcion = CaDescripcion
    End Sub

End Class
