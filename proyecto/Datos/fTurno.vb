Imports System.Data.SqlClient

Public Class fTurno

    Inherits Connection
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conexiondb()
            cmd = New SqlCommand("tbl_mturno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconecciondb()
        End Try
    End Function

    Public Function insertar(dts As eTurno) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_iturno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@TurFecha", dts.gTurFecha)
            cmd.Parameters.AddWithValue("@TurHorarioEntrada", dts.gTurHorarioEntrada)
            cmd.Parameters.AddWithValue("@TurHorarioSalida", dts.gTurHorarioSalida)
            cmd.Parameters.AddWithValue("@TurJornada", dts.gTurJornada)
            cmd.Parameters.AddWithValue("@TurDarBaja", dts.gTurDarBaja)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconecciondb()
        End Try

    End Function

    Public Function editar(dts As eTurno) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_uturno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@TurFecha", dts.gTurFecha)
            cmd.Parameters.AddWithValue("@TurHorarioEntrada", dts.gTurHorarioEntrada)
            cmd.Parameters.AddWithValue("@TurHorarioSalida", dts.gTurHorarioSalida)
            cmd.Parameters.AddWithValue("@TurJornada", dts.gTurJornada)
            cmd.Parameters.AddWithValue("@TurDarBaja", dts.gTurDarBaja)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconecciondb()
        End Try

    End Function

    Public Function eliminar(dts As eTurno) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_dturno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@TurCodigo", SqlDbType.NVarChar, 50).Value = dts.gTurCodigo
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconecciondb()
        End Try

    End Function

End Class
