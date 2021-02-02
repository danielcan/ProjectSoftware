Imports System.Data.SqlClient
Public Class fContrato

    Inherits Connection
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conexiondb()
            cmd = New SqlCommand("tbl_mcontrato")
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

    Public Function insertar(dts As eContrato) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_icontrato")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Empcodigo", dts.gEmpcodigo)
            cmd.Parameters.AddWithValue("@ConFecha", dts.gConFecha)
            cmd.Parameters.AddWithValue("@ConDescripcion", dts.gConDescripcion)
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

    Public Function editar(dts As eContrato) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_ucontrato")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Empcodigo", dts.gEmpcodigo)
            cmd.Parameters.AddWithValue("@ConFecha", dts.gConFecha)
            cmd.Parameters.AddWithValue("@ConDescripcion", dts.gConDescripcion)
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

    Public Function eliminar(dts As eContrato) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_dcontrato")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@ConCodigo", SqlDbType.NVarChar, 50).Value = dts.gConCodigo
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
