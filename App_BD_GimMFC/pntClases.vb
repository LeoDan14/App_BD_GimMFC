Imports System.Data.SqlClient

Public Class pntClases
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub


    Private Sub btnBuscarClases_Click(sender As Object, e As EventArgs) Handles btnBuscarClases.Click
        ' conexión a la base de datos gimnasio
        Dim conexion As New SqlConnection("Data Source=DESKTOP-P1KRNOI\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True")

        ' consulta con join para traer alumnos de la clase seleccionada
        Dim Query As String = "SELECT e.IdEstudiante, e.Nombre_Estudiante, e.Fecha_Ingreso
                           FROM Estudiante e
                           INNER JOIN Estudiante_Clase ec ON e.IdEstudiante = ec.IdEstudiante
                           INNER JOIN Clase c ON ec.IdClase = c.IdClase
                           WHERE c.Nombre_Disciplina = @nombreClase"

        Dim cmd As New SqlClient.SqlCommand(Query, conexion)
        ' tomar el nombre de la clase desde el combobox
        cmd.Parameters.AddWithValue("@nombreClase", cbClases.SelectedItem.ToString())

        Try
            conexion.Open()

            ' usar sqldataadapter para llenar un datatable
            Dim adapter As New SqlClient.SqlDataAdapter(cmd)
            Dim tabla As New DataTable()
            adapter.Fill(tabla)

            ' asignar el datatable como fuente de datos del datagridview
            dgvEstudiantes.DataSource = tabla

            ' si no hay filas, mostrar aviso
            If tabla.Rows.Count = 0 Then
                MsgBox("No se encontraron alumnos para la clase seleccionada.", MsgBoxStyle.Exclamation, "Aviso")
                cbClases.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error al buscar alumnos: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            conexion.Close()
        End Try
    End Sub


    Private Sub dgvClases_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstudiantes.CellContentClick

    End Sub

    Private Sub pntClases_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' crear conexión a la base de datos gimnasio
        Dim conexion As New SqlConnection("Data Source=DESKTOP-P1KRNOI\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True")

        ' consulta sql para traer todas las disciplinas
        Dim Query As String = "SELECT Nombre_Disciplina FROM Clase"

        Dim cmd As New SqlClient.SqlCommand(Query, conexion)

        Try
            conexion.Open() ' abrir conexión
            Dim sqlread As SqlDataReader = cmd.ExecuteReader()

            ' limpiar combobox antes de llenarlo
            cbClases.Items.Clear()

            ' recorrer los registros y agregarlos al combobox
            While sqlread.Read()
                cbClases.Items.Add(sqlread("Nombre_Disciplina").ToString())
            End While

            sqlread.Close()
            cbClases.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("error al cargar disciplinas: " & ex.Message, MsgBoxStyle.Critical, "error")
        Finally
            conexion.Close() ' cerrar conexión
        End Try
    End Sub

    Private Sub cbClases_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClases.SelectedIndexChanged

    End Sub

    Private Sub btnRegresarComp_Click(sender As Object, e As EventArgs) Handles btnRegresarComp.Click
        Me.Close()
    End Sub
End Class