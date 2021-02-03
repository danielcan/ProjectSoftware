Imports System.Data.SqlClient

Public Class fEmpleados

    Inherits Connection
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conexiondb()
            cmd = New SqlCommand("tbl_mempleados")
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

    Public Function insertar(dts As eEmpleados) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_iempleados")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@EmpNombre", dts.gEmpNombre)
            cmd.Parameters.AddWithValue("@EmpApellido", dts.gEmpApellido)
            cmd.Parameters.AddWithValue("@EmpTelefono", dts.gEmpTelefono)
            cmd.Parameters.AddWithValue("@EmpCargo", dts.gEmpCargo)
            cmd.Parameters.AddWithValue("@EmpDireccion", dts.gEmpDireccion)
            cmd.Parameters.AddWithValue("@EmpCorreo", dts.gEmpCorreo)
            cmd.Parameters.AddWithValue("@EmpCelular", dts.gEmpCelular)
            cmd.Parameters.AddWithValue("@EmpSueldo", dts.gEmpSueldo)
            cmd.Parameters.AddWithValue("@EmpFechaIngreso", dts.gEmpFechaIngreso)
            cmd.Parameters.AddWithValue("@TurCodigo", dts.gTurCodigo)
            cmd.Parameters.AddWithValue("@Orcodigo", dts.gOrcodigo)
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

    Public Function editar(dts As eEmpleados) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_uempleados")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@EmpNombre", dts.gEmpNombre)
            cmd.Parameters.AddWithValue("@EmpApellido", dts.gEmpApellido)
            cmd.Parameters.AddWithValue("@EmpTelefono", dts.gEmpTelefono)
            cmd.Parameters.AddWithValue("@EmpCargo", dts.gEmpCargo)
            cmd.Parameters.AddWithValue("@EmpDireccion", dts.gEmpDireccion)
            cmd.Parameters.AddWithValue("@EmpCorreo", dts.gEmpCorreo)
            cmd.Parameters.AddWithValue("@EmpCelular", dts.gEmpCelular)
            cmd.Parameters.AddWithValue("@EmpSueldo", dts.gEmpSueldo)
            cmd.Parameters.AddWithValue("@EmpFechaIngreso", dts.gEmpFechaIngreso)
            cmd.Parameters.AddWithValue("@TurCodigo", dts.gTurCodigo)
            cmd.Parameters.AddWithValue("@Orcodigo", dts.gOrcodigo)
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

    Public Function eliminar(dts As eEmpleados) As Boolean

        Try
            conexiondb()
            cmd = New SqlCommand("sp_dempleados")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@EmpCodigo", SqlDbType.NVarChar, 50).Value = dts.gEmpCodigo
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
