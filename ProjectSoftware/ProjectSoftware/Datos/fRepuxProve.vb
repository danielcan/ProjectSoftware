Imports System.Data.SqlClient

Public Class fRepuxProve
    Inherits Connection
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conexiondb()
            cmd = New SqlCommand("tbl_mcatalogo")
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

    Public Function insertar(dts As eRepuxProve) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_irepuxprove")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CatCodigo", dts.gCatCodigo)
            cmd.Parameters.AddWithValue("@CatCantidad", dts.gReCodigo)
            cmd.Parameters.AddWithValue("@CatFecha", dts.gProCodigo)
            cmd.Parameters.AddWithValue("@CatCategorias", dts.gFechaCompra)
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

    Public Function editar(dts As eRepuxProve) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_urepuxprove")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CatCodigo", dts.gCatCodigo)
            cmd.Parameters.AddWithValue("@CatCantidad", dts.gReCodigo)
            cmd.Parameters.AddWithValue("@CatFecha", dts.gProCodigo)
            cmd.Parameters.AddWithValue("@CatCategorias", dts.gFechaCompra)
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

    Public Function eliminar(dts As eRepuxProve) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_drepuxprove")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@CatCodigo", SqlDbType.NVarChar, 50).Value = dts.gCatCodigo
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
