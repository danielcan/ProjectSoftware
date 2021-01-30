Imports System.Data.SqlClient

Public Class fBono


    Inherits Connection
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conexiondb()
            cmd = New SqlCommand("tbl_mbono")
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

    Public Function insertar(dts As eBono) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_ibono")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@BoCodigo", dts.gBoCodigo)
            cmd.Parameters.AddWithValue("@BoPorCentaje", dts.gBoPorCentaje)
            cmd.Parameters.AddWithValue("@OrCodigo", dts.gOrCodigo)
            cmd.Parameters.AddWithValue("@BoFecha", dts.gBoFecha)
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

    Public Function editar(dts As eBono) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_ubono")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@BoCodigo", dts.gBoCodigo)
            cmd.Parameters.AddWithValue("@BoPorCentaje", dts.gBoPorCentaje)
            cmd.Parameters.AddWithValue("@OrCodigo", dts.gOrCodigo)
            cmd.Parameters.AddWithValue("@BoFecha", dts.gBoFecha)
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

    Public Function eliminar(dts As eBono) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_dbono")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@BoCodigo", SqlDbType.NVarChar, 50).Value = dts.gBoCodigo
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
