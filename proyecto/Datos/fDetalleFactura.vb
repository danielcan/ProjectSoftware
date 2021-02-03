Imports System.Data.SqlClient

Public Class fDetalleFactura
    Inherits Connection
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conexiondb()
            cmd = New SqlCommand("tbl_mdetallefactura")
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

    Public Function insertar(dts As eDetalleFactura) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_idetallefactura")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@FacCodigo", dts.gFacCodigo)
            cmd.Parameters.AddWithValue("@DFCantidad", dts.gDFCantidad)
            cmd.Parameters.AddWithValue("@TipoPago", dts.gTipoPago)
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

    Public Function editar(dts As eDetalleFactura) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_udetallefactura")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@FacCodigo", dts.gFacCodigo)
            cmd.Parameters.AddWithValue("@DFCantidad", dts.gDFCantidad)
            cmd.Parameters.AddWithValue("@TipoPago", dts.gTipoPago)
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

    Public Function eliminar(dts As eDetalleFactura) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_ddetallefactura")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@FacCodigo", SqlDbType.NVarChar, 50).Value = dts.gFacCodigo
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
