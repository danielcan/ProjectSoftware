'Class connection to data base. 
'Create for Daniel Canales 


Imports System.Data.SqlClient
Public Class Connection


	Protected cnn As New SqlConnection

	Protected Function conexiondb() As Boolean
		Try
			cnn = New SqlConnection("Data Source=DESKTOP-P6B53T5\LOCALHOST;initial catalog=electronicaHN;integrated security=True")
			cnn.Open()
			Return True
		Catch ex As Exception
			MsgBox(ex.Message)
			Return False
		End Try
	End Function

	Public Function desconecciondb() As Boolean
		Try
			If cnn.State = ConnectionState.Open Then
				cnn.Close()
				Return True
			Else
				Return False
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
			Return False
		End Try

	End Function

End Class

