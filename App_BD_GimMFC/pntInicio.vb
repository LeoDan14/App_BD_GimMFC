Imports System.Data.SqlClient

Public Class pntInicio
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click

        ' validar que los campos no estén vacíos
        If String.IsNullOrWhiteSpace(txtUsuario.Text) OrElse String.IsNullOrWhiteSpace(txtContraseña.Text) Then
            MessageBox.Show("Por favor llenen todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsuario.Focus()
            Exit Sub
        End If

        Dim conexion As New SqlConnection("Data Source=DESKTOP-P1KRNOI\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True")
        'busca en la tabla Empleado un registro que coincida con los valores ingresados en las cajas de texto'
        Dim comando As New SqlCommand("SELECT * FROM Empleado WHERE Nombre_Empleado=@usuario AND Contrasena=@contrasena", conexion)

        'se definen parametros'
        comando.Parameters.AddWithValue("@usuario", txtUsuario.Text)
        comando.Parameters.AddWithValue("@contrasena", txtContraseña.Text)
        'asigna valores a los parametros de la conslta sql'
        Try
            conexion.Open()
            Dim lector As SqlDataReader = comando.ExecuteReader()
            'sqldatareader lee los resultados de la consulta sql, executereader ejecuta la consulta y devuelve los registros encontrados'
            If lector.HasRows Then
                'lector.hasrows veriifica si la consulta devolvio algun registro'
                Dim frm As New pntOpcion()
                frm.ShowDialog()

                ' limpiar campos después de acceder
                txtUsuario.Clear()
                txtContraseña.Clear()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsuario.Focus()
            End If

            lector.Close()
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
            txtUsuario.Focus()
        Finally
            txtUsuario.Clear()
            txtContraseña.Clear()
            conexion.Close()
        End Try
    End Sub


    ' cuando el usuario presiona enter en txtUsuario, pasa a txtContraseña
    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtContraseña.Focus()
        End If
    End Sub

    ' cuando el usuario presiona enter en txtContraseña, ejecuta el botón iniciar
    Private Sub txtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnIniciar.PerformClick()
        End If
    End Sub




    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
