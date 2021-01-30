Imports System.Data.SqlClient

Public Class fServicio

    Inherits Connection
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conexiondb()
            cmd = New SqlCommand("tbl_mservicio")
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

    Public Function insertar(dts As eServicio) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_iservicio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CliCodigo", dts.gServTipoServicio)
            cmd.Parameters.AddWithValue("@ServCodigo", dts.gServCodigo)
            cmd.Parameters.AddWithValue("@OrCodigo", dts.gOrCodigo)
            cmd.Parameters.AddWithValue("@RecepcionEquipo", dts.gSerDescripcion)
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

    Public Function editar(dts As eServicio) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_uservicio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CliCodigo", dts.gServTipoServicio)
            cmd.Parameters.AddWithValue("@ServCodigo", dts.gServCodigo)
            cmd.Parameters.AddWithValue("@OrCodigo", dts.gOrCodigo)
            cmd.Parameters.AddWithValue("@RecepcionEquipo", dts.gSerDescripcion)
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

    Public Function eliminar(dts As eServicio) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_dservicio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@ServTipoServicio", SqlDbType.NVarChar, 50).Value = dts.gServTipoServicio
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
