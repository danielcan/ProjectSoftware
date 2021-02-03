Imports System.Data.SqlClient
Public Class fPedidos

    Inherits Connection
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conexiondb()
            cmd = New SqlCommand("tbl_mpedido")
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

    Public Function insertar(dts As ePedidos) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_ipedido")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@OrCodigo", dts.gOrCodigo)
            cmd.Parameters.AddWithValue("@PeFecha", dts.gPeFecha)
            cmd.Parameters.AddWithValue("@PeDescripcion", dts.gPeDescripcion)
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

    Public Function editar(dts As ePedidos) As Boolean

        Try
            conexiondb()

            cmd = New SqlCommand("sp_upedido")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@OrCodigo", dts.gOrCodigo)
            cmd.Parameters.AddWithValue("@PeFecha", dts.gPeFecha)
            cmd.Parameters.AddWithValue("@PeDescripcion", dts.gPeDescripcion)
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

    Public Function eliminar(dts As ePedidos) As Boolean
        Try
            conexiondb()
            cmd = New SqlCommand("sp_dpedido")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@PeCodigo", SqlDbType.NVarChar, 50).Value = dts.gPeCodigo
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
