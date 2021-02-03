Imports System.Data.SqlClient

Public Class fFactura

    Inherits Connection
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conexiondb()
            cmd = New SqlCommand("tbl_mfactura")
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

    Public Function insertar(dts As eFactura) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_ifactura")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CliCodigo", dts.gCliCodigo)

            cmd.Parameters.AddWithValue("@FacSubTotal", dts.gFacSubTotal)
            cmd.Parameters.AddWithValue("@FacTotal", dts.gFacTotal)
            cmd.Parameters.AddWithValue("@EmpCodigo", dts.gEmpCodigo)
            cmd.Parameters.AddWithValue("@CatCodigo", dts.gCatCodigo)
            cmd.Parameters.AddWithValue("@CaCodigo", dts.gCaCodigo)
            cmd.Parameters.AddWithValue("@FacDescripcion", dts.gFacDescripcion)
            cmd.Parameters.AddWithValue("@FacFecha", dts.gFacFecha)
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

    Public Function editar(dts As eFactura) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_ufactura")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CliCodigo", dts.gCliCodigo)

            cmd.Parameters.AddWithValue("@FacSubTotal", dts.gFacSubTotal)
            cmd.Parameters.AddWithValue("@FacTotal", dts.gFacTotal)
            cmd.Parameters.AddWithValue("@EmpCodigo", dts.gEmpCodigo)
            cmd.Parameters.AddWithValue("@CatCodigo", dts.gCatCodigo)
            cmd.Parameters.AddWithValue("@CaCodigo", dts.gCaCodigo)
            cmd.Parameters.AddWithValue("@FacDescripcion", dts.gFacDescripcion)
            cmd.Parameters.AddWithValue("@FacFecha", dts.gFacFecha)
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

    Public Function eliminar(dts As eFactura) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_dfactura")
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
