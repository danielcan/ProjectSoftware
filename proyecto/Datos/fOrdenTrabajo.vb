Imports System.Data.SqlClient

Public Class fOrdenTrabajo

    Inherits Connection
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conexiondb()
            cmd = New SqlCommand("tbl_mordentrabajo")
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

    Public Function insertar(dts As eOrdenTrabajo) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_iordentrabajo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CliCodigo", dts.gCliCodigo)
            cmd.Parameters.AddWithValue("@ServCodigo", dts.gServCodigo)

            cmd.Parameters.AddWithValue("@Orfecha", dts.gOrfecha)
            cmd.Parameters.AddWithValue("@RecepcionEquipo", dts.gRecepcionEquipo)
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

    Public Function editar(dts As eOrdenTrabajo) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_uordentrabajo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CliCodigo", dts.gCliCodigo)
            cmd.Parameters.AddWithValue("@ServCodigo", dts.gServCodigo)

            cmd.Parameters.AddWithValue("@Orfecha", dts.gOrfecha)
            cmd.Parameters.AddWithValue("@RecepcionEquipo", dts.gRecepcionEquipo)
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

    Public Function eliminar(dts As eOrdenTrabajo) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_dordentrabajo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@CliCodigo", SqlDbType.NVarChar, 50).Value = dts.gCliCodigo
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

