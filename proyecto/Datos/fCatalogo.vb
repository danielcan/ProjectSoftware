Imports System.Data.SqlClient

Public Class fCatalogo
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

    Public Function insertar(dts As eCatalogo) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_icatalogo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@CatCantidad", dts.gCatCantidad)
            cmd.Parameters.AddWithValue("@CatFecha", dts.gCatFecha)
            cmd.Parameters.AddWithValue("@CatCategorias", dts.gCatCategorias)
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

    Public Function editar(dts As eCatalogo) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_ucatalogo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@CatCantidad", dts.gCatCantidad)
            cmd.Parameters.AddWithValue("@CatFecha", dts.gCatFecha)
            cmd.Parameters.AddWithValue("@CatCategorias", dts.gCatCategorias)
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

    Public Function eliminar(dts As eCatalogo) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_dcatalogo")
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
