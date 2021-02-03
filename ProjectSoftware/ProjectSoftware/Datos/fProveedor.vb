Imports System.Data.SqlClient

Public Class fProveedor

    Inherits Connection
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conexiondb()
            cmd = New SqlCommand("tbl_mproveedores")
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

    Public Function insertar(dts As eProveedor) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_iproveedores")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ProNombre", dts.gProNombre)
            cmd.Parameters.AddWithValue("@ProIdentidad", dts.gProIdentidad)
            cmd.Parameters.AddWithValue("@ProTelefono", dts.gProTelefono)
            cmd.Parameters.AddWithValue("@ProCelular", dts.gProCelular)
            cmd.Parameters.AddWithValue("@ProCorreo", dts.gProCorreo)
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

    Public Function editar(dts As eProveedor) As Boolean

        Try
            conexiondb()

            cmd = New SqlCommand("sp_uproveedores")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ProNombre", dts.gProNombre)
            cmd.Parameters.AddWithValue("@ProIdentidad", dts.gProIdentidad)
            cmd.Parameters.AddWithValue("@ProTelefono", dts.gProTelefono)
            cmd.Parameters.AddWithValue("@ProCelular", dts.gProCelular)
            cmd.Parameters.AddWithValue("@ProCorreo", dts.gProCorreo)
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

    Public Function eliminar(dts As eProveedor) As Boolean
        Try
            conexiondb()
            cmd = New SqlCommand("sp_dproveedores")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@ProCodigo", SqlDbType.NVarChar, 50).Value = dts.gProCodigo
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
