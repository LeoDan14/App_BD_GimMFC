Imports System.Data.SqlClient

Public Class pntEmpleados
    Private Sub btnRegresarEmp_Click(sender As Object, e As EventArgs) Handles btnRegresarEmp.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarEmpleado_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpleado.Click
        ' crear conexión a la base de datos Gimnasio
        Dim conexion As New SqlConnection("Data Source=DESKTOP-P1KRNOI\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True")

        ' consulta sql con parámetro para evitar inyección
        Dim Query As String = "SELECT IdEmpleado, Nombre_Empleado, Contrasena, Puesto, Contacto
                           FROM Empleado
                           WHERE IdEmpleado=@id"

        Dim cmd As New SqlClient.SqlCommand(Query, conexion)
        cmd.Parameters.AddWithValue("@id", txtIdEmpleado.Text)

        Try
            conexion.Open() ' abrir conexión
            Dim sqlread As SqlDataReader = cmd.ExecuteReader()

            If sqlread.HasRows Then
                While sqlread.Read()
                    ' asignar los valores a los cuadros de texto
                    txtIdEmpleado.Text = sqlread("IdEmpleado").ToString()
                    txtNombreEmpleado.Text = sqlread("Nombre_Empleado").ToString()
                    txtContraseñaEmpleado.Text = sqlread("Contrasena").ToString()
                    txtPuesto.Text = sqlread("Puesto").ToString()
                    txtContacto.Text = sqlread("Contacto").ToString()
                End While
            Else
                MsgBox("No se encontró empleado con ese ID.", MsgBoxStyle.Exclamation, "Aviso")
                txtIdEmpleado.Focus()
            End If

            sqlread.Close()
        Catch ex As Exception
            MsgBox("Error al buscar empleado: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            conexion.Close() ' cerrar conexión
        End Try
    End Sub


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub pntEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtIdEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtIdEmpleado.TextChanged

    End Sub

    Private Sub txtNombreEmpleado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombreEmpleado.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtContraseñaEmpleado.Focus()
        End If
    End Sub


    Private Sub txtContraseñaEmpleado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContraseñaEmpleado.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPuesto.Focus()
        End If
    End Sub
    Private Sub txtPuesto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPuesto.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtContacto.Focus()
        End If
    End Sub

    Private Sub txtContacto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContacto.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnRegistrarEmpleado.PerformClick()
        End If
    End Sub


    Private Sub btnRegistrarEmpleado_Click(sender As Object, e As EventArgs) Handles btnRegistrarEmpleado.Click
        ' 1. Validar que todos los campos estén llenos
        If String.IsNullOrWhiteSpace(txtNombreEmpleado.Text) OrElse
       String.IsNullOrWhiteSpace(txtContraseñaEmpleado.Text) OrElse
       String.IsNullOrWhiteSpace(txtPuesto.Text) OrElse
       String.IsNullOrWhiteSpace(txtContacto.Text) Then

            MsgBox("Por favor, complete todos los campos antes de registrar.", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        ' 2. Crear conexión
        Dim conexion As New SqlConnection("Data Source=DESKTOP-P1KRNOI\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True")

        Try
            conexion.Open()

            ' 3. Verificar si ya existe un empleado con el mismo nombre y puesto
            Dim QueryVerificar As String = "SELECT COUNT(*) FROM Empleado WHERE Nombre_Empleado=@nombre AND Puesto=@puesto"
            Dim cmdVerificar As New SqlClient.SqlCommand(QueryVerificar, conexion)
            cmdVerificar.Parameters.AddWithValue("@nombre", txtNombreEmpleado.Text)
            cmdVerificar.Parameters.AddWithValue("@puesto", txtPuesto.Text)

            Dim resultado As Object = cmdVerificar.ExecuteScalar()
            Dim existe As Integer = If(IsDBNull(resultado), 0, Convert.ToInt32(resultado))

            If existe > 0 Then
                ' 4. Ya existe un empleado con ese nombre y puesto
                MsgBox("El empleado ya existe en la base de datos.", MsgBoxStyle.Critical, "Duplicado")
            Else
                ' 5. Obtener el IdEmpleado mayor y sumarle 1
                Dim QueryMaxId As String = "SELECT ISNULL(MAX(IdEmpleado),0) FROM Empleado"
                Dim cmdMaxId As New SqlClient.SqlCommand(QueryMaxId, conexion)
                Dim maxId As Integer = Convert.ToInt32(cmdMaxId.ExecuteScalar())
                Dim nuevoId As Integer = maxId + 1

                ' 6. Insertar nuevo empleado con el Id generado
                Dim QueryInsertar As String = "INSERT INTO Empleado (IdEmpleado, Nombre_Empleado, Contrasena, Puesto, Contacto)
                                           VALUES (@id, @nombre, @contrasena, @puesto, @contacto)"

                Dim cmdInsertar As New SqlClient.SqlCommand(QueryInsertar, conexion)
                cmdInsertar.Parameters.AddWithValue("@id", nuevoId)
                cmdInsertar.Parameters.AddWithValue("@nombre", txtNombreEmpleado.Text)
                cmdInsertar.Parameters.AddWithValue("@contrasena", txtContraseñaEmpleado.Text)
                cmdInsertar.Parameters.AddWithValue("@puesto", txtPuesto.Text)
                cmdInsertar.Parameters.AddWithValue("@contacto", txtContacto.Text)

                cmdInsertar.ExecuteNonQuery()

                ' 7. Mensaje de éxito con el ID y el nombre
                MsgBox("Empleado registrado correctamente." & vbCrLf &
                   "ID asignado: " & nuevoId & vbCrLf &
                   "Nombre: " & txtNombreEmpleado.Text,
                   MsgBoxStyle.Information, "Éxito")
            End If

        Catch ex As Exception
            ' 8. Capturar errores
            MsgBox("Error al registrar empleado: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            conexion.Close()

            ' 9. Limpiar todos los campos siempre
            txtIdEmpleado.Clear()
            txtNombreEmpleado.Clear()
            txtContraseñaEmpleado.Clear()
            txtPuesto.Clear()
            txtContacto.Clear()
        End Try
    End Sub

    Private Sub btnActualizarEmpleado_Click(sender As Object, e As EventArgs) Handles btnActualizarEmpleado.Click
        ' 1. Validar que todos los campos estén llenos
        If String.IsNullOrWhiteSpace(txtIdEmpleado.Text) OrElse
           String.IsNullOrWhiteSpace(txtNombreEmpleado.Text) OrElse
           String.IsNullOrWhiteSpace(txtContraseñaEmpleado.Text) OrElse
           String.IsNullOrWhiteSpace(txtPuesto.Text) OrElse
           String.IsNullOrWhiteSpace(txtContacto.Text) Then

            MsgBox("Por favor, complete todos los campos antes de actualizar.", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        ' 2. Crear conexión
        Dim conexion As New SqlConnection("Data Source=DESKTOP-P1KRNOI\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True")

        Try
            conexion.Open()

            ' 3. Verificar si existe el empleado con ese ID
            Dim QueryVerificar As String = "SELECT COUNT(*) FROM Empleado WHERE IdEmpleado=@id"
            Dim cmdVerificar As New SqlClient.SqlCommand(QueryVerificar, conexion)
            cmdVerificar.Parameters.AddWithValue("@id", Convert.ToInt32(txtIdEmpleado.Text))

            Dim resultado As Object = cmdVerificar.ExecuteScalar()
            Dim existe As Integer = If(IsDBNull(resultado), 0, Convert.ToInt32(resultado))

            If existe = 0 Then
                MsgBox("No existe un empleado con ese ID.", MsgBoxStyle.Critical, "Error")
            Else
                ' 4. Actualizar datos del empleado
                Dim QueryActualizar As String = "UPDATE Empleado 
                                             SET Nombre_Empleado=@nombre, 
                                                 Contrasena=@contrasena, 
                                                 Puesto=@puesto, 
                                                 Contacto=@contacto
                                             WHERE IdEmpleado=@id"

                Dim cmdActualizar As New SqlClient.SqlCommand(QueryActualizar, conexion)
                cmdActualizar.Parameters.AddWithValue("@id", Convert.ToInt32(txtIdEmpleado.Text))
                cmdActualizar.Parameters.AddWithValue("@nombre", txtNombreEmpleado.Text)
                cmdActualizar.Parameters.AddWithValue("@contrasena", txtContraseñaEmpleado.Text)
                cmdActualizar.Parameters.AddWithValue("@puesto", txtPuesto.Text)
                cmdActualizar.Parameters.AddWithValue("@contacto", txtContacto.Text)

                Dim filasAfectadas As Integer = cmdActualizar.ExecuteNonQuery()

                If filasAfectadas > 0 Then
                    MsgBox("Empleado actualizado correctamente." & vbCrLf &
                           "ID: " & txtIdEmpleado.Text & vbCrLf &
                           "Nombre: " & txtNombreEmpleado.Text,
                           MsgBoxStyle.Information, "Éxito")
                Else
                    MsgBox("No se pudo actualizar el empleado.", MsgBoxStyle.Critical, "Error")
                End If
            End If

        Catch ex As Exception
            ' 5. Capturar errores
            MsgBox("Error al actualizar empleado: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            conexion.Close()

            ' 6. Limpiar todos los campos siempre
            txtIdEmpleado.Clear()
            txtNombreEmpleado.Clear()
            txtContraseñaEmpleado.Clear()
            txtPuesto.Clear()
            txtContacto.Clear()
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' 1. Validar que el campo IdEmpleado esté lleno
        If String.IsNullOrWhiteSpace(txtIdEmpleado.Text) Then
            MsgBox("Por favor, ingrese el ID del empleado que desea eliminar.", MsgBoxStyle.Exclamation, "Aviso")
            txtIdEmpleado.Focus()
            Exit Sub
        End If

        ' 2. Crear conexión
        Dim conexion As New SqlConnection("Data Source=DESKTOP-P1KRNOI\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True")

        Try
            conexion.Open()

            ' 3. Verificar si existe el empleado con ese ID
            Dim QueryVerificar As String = "SELECT COUNT(*) FROM Empleado WHERE IdEmpleado=@id"
            Dim cmdVerificar As New SqlClient.SqlCommand(QueryVerificar, conexion)
            cmdVerificar.Parameters.AddWithValue("@id", Convert.ToInt32(txtIdEmpleado.Text))

            Dim resultado As Object = cmdVerificar.ExecuteScalar()
            Dim existe As Integer = If(IsDBNull(resultado), 0, Convert.ToInt32(resultado))

            If existe = 0 Then
                MsgBox("No existe un empleado con ese ID.", MsgBoxStyle.Critical, "Error")
            Else
                ' 4. Confirmar eliminación
                Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro de eliminar al empleado con ID " & txtIdEmpleado.Text & "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If respuesta = DialogResult.Yes Then
                    ' 5. Eliminar empleado
                    Dim QueryEliminar As String = "DELETE FROM Empleado WHERE IdEmpleado=@id"
                    Dim cmdEliminar As New SqlClient.SqlCommand(QueryEliminar, conexion)
                    cmdEliminar.Parameters.AddWithValue("@id", Convert.ToInt32(txtIdEmpleado.Text))

                    Dim filasAfectadas As Integer = cmdEliminar.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MsgBox("Empleado eliminado correctamente." & vbCrLf &
                               "ID: " & txtIdEmpleado.Text & vbCrLf &
                               "Nombre: " & txtNombreEmpleado.Text,
                               MsgBoxStyle.Information, "Éxito")
                    Else
                        MsgBox("No se pudo eliminar el empleado.", MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If

        Catch ex As Exception
            ' 6. Capturar errores
            MsgBox("Error al eliminar empleado: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            conexion.Close()

            ' 7. Limpiar todos los campos siempre
            txtIdEmpleado.Clear()
            txtNombreEmpleado.Clear()
            txtContraseñaEmpleado.Clear()
            txtPuesto.Clear()
            txtContacto.Clear()
        End Try
    End Sub

End Class