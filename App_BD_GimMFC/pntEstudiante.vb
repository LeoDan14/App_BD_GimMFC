Imports System.Data.SqlClient

Public Class pntEstudiante
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    ' este botón sirve para buscar un estudiante por su id
    ' al encontrarlo, muestra sus datos en un mensaje

    Private Sub btnBuscarEstudiante_Click(sender As Object, e As EventArgs)
        ' crear conexión a la base de datos gimnasio
        Dim conexion As New SqlConnection("Data Source=DESKTOP-M9E0OMK\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True")

        ' consulta sql con parámetro para evitar inyección
        Dim Query As String = "SELECT IdEstudiante, Nombre_Estudiante, Direccion, FechNac, Contacto, Fecha_Ingreso
                           FROM Estudiante
                           WHERE IdEstudiante=@id"

        Dim cmd As New SqlClient.SqlCommand(Query, conexion)
        cmd.Parameters.AddWithValue("@id", txtIdEstudiante.Text)

        Try
            conexion.Open() ' abrir conexión
            Dim sqlread As SqlDataReader = cmd.ExecuteReader()

            If sqlread.HasRows Then
                While sqlread.Read()
                    ' armar mensaje con los datos del estudiante
                    Dim mensaje As String = "id: " & sqlread("IdEstudiante").ToString() & vbCrLf &
                                        "nombre: " & sqlread("Nombre_Estudiante").ToString() & vbCrLf &
                                        "dirección: " & sqlread("Direccion").ToString() & vbCrLf &
                                        "fecha nacimiento: " & Convert.ToDateTime(sqlread("FechNac")).ToShortDateString() & vbCrLf &
                                        "contacto: " & sqlread("Contacto").ToString() & vbCrLf &
                                        "fecha ingreso: " & Convert.ToDateTime(sqlread("Fecha_Ingreso")).ToShortDateString()

                    MsgBox(mensaje, MsgBoxStyle.Information, "datos del estudiante")
                End While
            Else
                MsgBox("no se encontró estudiante con ese id.", MsgBoxStyle.Exclamation, "aviso")
                txtIdEstudiante.Focus() ' regresar el cursor a la caja de id
            End If

            sqlread.Close()
        Catch ex As Exception
            MsgBox("error al buscar estudiante: " & ex.Message, MsgBoxStyle.Critical, "error")
        Finally
            conexion.Close() ' cerrar conexión
        End Try
    End Sub


    Private Sub btnRegistrarEstudiante_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtIdEstudiante_TextChanged(sender As Object, e As EventArgs) Handles txtIdEstudiante.TextChanged

    End Sub

    Private Sub btnRegresarEst_Click(sender As Object, e As EventArgs) Handles btnRegresarEst.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarEstudiante_Click_1(sender As Object, e As EventArgs) Handles btnBuscarEstudiante.Click
        ' crear conexión a la base de datos gimnasio
        Dim conexion As New SqlConnection("Data Source=DESKTOP-M9E0OMK\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True")

        ' consulta sql con parámetro para evitar inyección
        Dim Query As String = "SELECT IdEstudiante, Nombre_Estudiante, Direccion, FechNac, Contacto, Fecha_Ingreso
                           FROM Estudiante
                           WHERE IdEstudiante=@id"

        Dim cmd As New SqlClient.SqlCommand(Query, conexion)
        cmd.Parameters.AddWithValue("@id", txtIdEstudiante.Text)

        Try
            conexion.Open() ' abrir conexión
            Dim sqlread As SqlDataReader = cmd.ExecuteReader()

            If sqlread.HasRows Then
                While sqlread.Read()
                    ' asignar los valores a los cuadros de texto y controles
                    txtIdEstudiante.Text = sqlread("IdEstudiante").ToString()
                    txtNombreEstudiantes.Text = sqlread("Nombre_Estudiante").ToString()
                    txtDireccion.Text = sqlread("Direccion").ToString()
                    dtpFechaNac.Value = Convert.ToDateTime(sqlread("FechNac"))
                    txtContacto.Text = sqlread("Contacto").ToString()
                    dtpFechaIngreso.Value = Convert.ToDateTime(sqlread("Fecha_Ingreso"))
                End While
            Else
                MsgBox("no se encontró estudiante con ese id.", MsgBoxStyle.Exclamation, "aviso")
                txtIdEstudiante.Focus() ' regresar el cursor a la caja de id
            End If

            sqlread.Close()
        Catch ex As Exception
            MsgBox("error al buscar estudiante: " & ex.Message, MsgBoxStyle.Critical, "error")
        Finally
            conexion.Close() ' cerrar conexión
        End Try
    End Sub

    Private Sub btnRegistrarEstudiante_Click_1(sender As Object, e As EventArgs) Handles btnRegistrarEstudiante.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNombreEstudiantes.TextChanged

    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged

    End Sub

    Private Sub dtpFechaNac_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaNac.ValueChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtIdEmpleado.TextChanged

    End Sub
End Class