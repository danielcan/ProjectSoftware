Public Class eCaja



    Dim CaCodigo, CaApertura, CaCierre As Integer
    Dim Cafecha As Date
    Dim CaDescripcion As String


    Public Property pCaCodigo
        Get
            Return CaCodigo
        End Get
        Set(value)
            CaCodigo = value
        End Set
    End Property


    Public Property pCaApertura
        Get
            Return CaApertura
        End Get
        Set(value)
            CaApertura = value
        End Set
    End Property


    Public Property pCaCierre
        Get
            Return CaCierre
        End Get
        Set(value)
            CaCierre = value
        End Set
    End Property


    Public Property pCafecha
        Get
            Return Cafecha
        End Get
        Set(value)
            Cafecha = value
        End Set
    End Property

    Public Property pCaDescripcion
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
        pCaCodigo = CaCodigo
        pCaApertura = CaApertura
        pCaCierre = CaCierre
        pCafecha = Cafecha
        pCaDescripcion = CaDescripcion
    End Sub

End Class
