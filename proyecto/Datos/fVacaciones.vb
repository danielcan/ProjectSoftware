Imports System.Data.SqlClient
Public Class fVacaciones

    Inherits Connection
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conexiondb()
            cmd = New SqlCommand("tbl_mvacaciones")
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

    Public Function insertar(dts As eVacaciones) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_ivacaciones")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@VacDiasTomados", dts.gVacDiasTomados)
            cmd.Parameters.AddWithValue("@VacDia", dts.gVacDia)
            cmd.Parameters.AddWithValue("@VacAnio", dts.gVacAnio)
            cmd.Parameters.AddWithValue("@EmpCodigo", dts.gEmpCodigo)
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

    Public Function editar(dts As eVacaciones) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_uvacaciones")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@VacDiasTomados", dts.gVacDiasTomados)
            cmd.Parameters.AddWithValue("@VacDia", dts.gVacDia)
            cmd.Parameters.AddWithValue("@VacAnio", dts.gVacAnio)
            cmd.Parameters.AddWithValue("@EmpCodigo", dts.gEmpCodigo)
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

    Public Function eliminar(dts As eVacaciones) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_dvacaciones")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@VacCodigo", SqlDbType.NVarChar, 50).Value = dts.gVacCodigo
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
