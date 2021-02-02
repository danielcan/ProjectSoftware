Imports System.Data.SqlClient
Public Class fCaja

    Inherits Connection
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conexiondb()
            cmd = New SqlCommand("tbl_mcaja")
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

    Public Function insertar(dts As eCaja) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_icaja")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@CaApertura", dts.gCaApertura)
            cmd.Parameters.AddWithValue("@CaCierre", dts.gCaCierre)
            cmd.Parameters.AddWithValue("@Cafecha", dts.gCafecha)
            cmd.Parameters.AddWithValue("@CaDescripcion", dts.gCaDescripcion)
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

    Public Function editar(dts As eCaja) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_ucaja")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@CaApertura", dts.gCaApertura)
            cmd.Parameters.AddWithValue("@CaCierre", dts.gCaCierre)
            cmd.Parameters.AddWithValue("@Cafecha", dts.gCafecha)
            cmd.Parameters.AddWithValue("@CaDescripcion", dts.gCaDescripcion)
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

    Public Function eliminar(dts As eCaja) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_dcaja")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@CaCodigo", SqlDbType.NVarChar, 50).Value = dts.gCaCodigo
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
