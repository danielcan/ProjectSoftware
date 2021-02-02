Imports System.Data.SqlClient

Public Class fRepuesto

    Inherits Connection
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conexiondb()
            cmd = New SqlCommand("tbl_mrepuesto")
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

    Public Function insertar(dts As eRepuesto) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_irepuesto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@RePrecio", dts.gRePrecio)
            cmd.Parameters.AddWithValue("@ReMarca", dts.gReMarca)
            cmd.Parameters.AddWithValue("@ReTraido", dts.gReTraido)
            cmd.Parameters.AddWithValue("@ReDescripcion", dts.gReDescripcion)
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

    Public Function editar(dts As eRepuesto) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_urepuesto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@RePrecio", dts.gRePrecio)
            cmd.Parameters.AddWithValue("@ReMarca", dts.gReMarca)
            cmd.Parameters.AddWithValue("@ReTraido", dts.gReTraido)
            cmd.Parameters.AddWithValue("@ReDescripcion", dts.gReDescripcion)
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

    Public Function eliminar(dts As eRepuesto) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_drepuesto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@ReCodigo", SqlDbType.NVarChar, 50).Value = dts.gReCodigo
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
