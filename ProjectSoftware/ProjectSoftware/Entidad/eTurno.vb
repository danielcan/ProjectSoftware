
Public Class eTurno

    Dim TurCodigo As Integer
    Dim TurFecha, TurHorarioEntrada, TurHorarioSalida As Date
    Dim TurJornada, TurDarBaja As String

    Public Property gTurCodigo
        Get
            Return TurCodigo
        End Get
        Set(value)
            TurCodigo = value
        End Set
    End Property

    Public Property gTurFecha
        Get
            Return TurFecha
        End Get
        Set(value)
            TurFecha = value
        End Set
    End Property

    Public Property gTurHorarioEntrada
        Get
            Return TurHorarioEntrada
        End Get
        Set(value)
            TurHorarioEntrada = value
        End Set
    End Property

    Public Property gTurHorarioSalida
        Get
            Return TurHorarioSalida
        End Get
        Set(value)
            TurHorarioSalida = value
        End Set
    End Property

    Public Property gTurJornada
        Get
            Return TurJornada
        End Get
        Set(value)
            TurJornada = value
        End Set
    End Property

    Public Property gTurDarBaja
        Get
            Return TurDarBaja
        End Get
        Set(value)
            TurDarBaja = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(TurCodigo As Integer, TurFecha As Date, TurHorarioEntrada As Date, TurHorarioSalida As Date, TurJornada As String, TurDarBaja As String)
        gTurCodigo = TurCodigo
        gTurFecha = TurFecha
        gTurHorarioEntrada = TurHorarioEntrada
        gTurHorarioSalida = TurHorarioSalida
        gTurJornada = TurJornada
        gTurDarBaja = TurDarBaja
    End Sub
End Class
