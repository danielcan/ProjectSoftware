Imports System.Data.SqlClient


Public Class fClientes

    Inherits Connection
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conexiondb()
            cmd = New SqlCommand("tbl_mclientes")
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

    Public Function insertar(dts As eClientes) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_iclientes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@CliIdentidad", dts.gCliIdentidad)
            cmd.Parameters.AddWithValue("@CliNombreCompleto", dts.gCliNombreCompleto)
            cmd.Parameters.AddWithValue("@CliTelefono", dts.gCliTelefono)
            cmd.Parameters.AddWithValue("@CliCorreo", dts.gCliCorreo)
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

    Public Function editar(dts As eClientes) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_uclientes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@CliIdentidad", dts.gCliIdentidad)
            cmd.Parameters.AddWithValue("@CliNombreCompleto", dts.gCliNombreCompleto)
            cmd.Parameters.AddWithValue("@CliTelefono", dts.gCliTelefono)
            cmd.Parameters.AddWithValue("@CliCorreo", dts.gCliCorreo)
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

    Public Function eliminar(dts As eClientes) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_dclientes")
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
