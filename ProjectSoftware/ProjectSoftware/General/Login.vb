Public Class Login

	Public connection As SqlClient.SqlConnection
	Dim accion As String, id As String, sql As String
	Dim res As Integer, nom, pass, pass1 As String
	Dim com As SqlClient.SqlCommand, dr As SqlClient.SqlDataReader
	Dim da As SqlClient.SqlDataAdapter, cb As SqlClient.SqlCommandBuilder

	Dim ds As DataSet

	Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		btnEntrada.BackColor = Color.FromArgb(100, 30, 139, 195)
	End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Application.Exit()
	End Sub

	Private Sub btnEntrada_Click_1(sender As Object, e As EventArgs) Handles btnEntrada.Click
		'Call Me.verificar()
		Dim menuAdminObjeto As New menuAdmin
		'menuAdminObjeto.bandera = 0
		menuAdminObjeto.ShowDialog()
	End Sub


	'Connection DataBase.
	Public Sub Connect()
		connection = New SqlClient.SqlConnection
		connection.ConnectionString = ("Data Source=DESKTOP-OQV1GKC\LOCALHOST;initial catalog=ElectronicaHN;integrated security=True")
		connection.Open()
	End Sub


	Private Sub verificar()
		id = txtUsuario.Text
		pass = txtPassw.Text

		If id <> "" And pass <> "" Then
			sql = "exec ver_users '" + id + "'"
			Connect()
			com = New SqlClient.SqlCommand(sql, connection)
			dr = com.ExecuteReader
			If dr.Read Then
				If id = dr(1) And pass = dr(2) Then
					If "administracion" <> dr(3) Then
						Dim a As New menuAdmin
						a.Show()
					ElseIf "caja" = dr(3) Then
						'Aqui otra ventana
					ElseIf "tecnico" = dr(3) Then

						'aqui otra ventana 1
					End If

				Else
					MsgBox("Contraseña incorrecta", MsgBoxStyle.Exclamation, "Acceso Denegado")
				End If
			Else
				MsgBox("Por favor Registrese", MsgBoxStyle.Exclamation, "Acceso Denegado")
			End If
		End If
	End Sub
End Class