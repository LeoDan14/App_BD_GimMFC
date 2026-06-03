Imports System.Data.SqlClient
'convierte el numero de mes en texto'
Imports System.Globalization

Public Class pntVentas

    Private Sub btnRegresarVen_Click(sender As Object, e As EventArgs) Handles btnRegresarVen.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarVenta_Click(sender As Object, e As EventArgs) Handles btnBuscarVenta.Click
        ' conexión a la  bd  Gimnasio'
        Dim conexion As New SqlConnection("Data Source=DESKTOP-P1KRNOI\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True")

        ' valida que se seleccione algo en el ComboBox'
        If cbOpcionFecha.SelectedItem Is Nothing Then
            MsgBox("Seleccione un mes y año en el combo antes de buscar.", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        Dim seleccion As String = cbOpcionFecha.SelectedItem.ToString()
        Dim partes() As String = seleccion.Split(" "c)
        Dim anio As Integer = Convert.ToInt32(partes(0))
        Dim mesNombre As String = partes(1)

        'se convierte el  nombre de mes a número'
        Dim mes As Integer = DateTime.ParseExact(mesNombre, "MMMM", CultureInfo.CurrentCulture).Month

        ' consulta con JOIN para traer ventas y artículos'
        Dim Query As String = "SELECT 
                                   v.IdVenta,
                                   v.FechaVenta,
                                   v.Total,
                                   e.Nombre_Empleado,
                                   a.Nombre_Art,
                                   dv.Cantidad
                               FROM Venta v
                               INNER JOIN Empleado e ON v.IdEmpleado = e.IdEmpleado
                               INNER JOIN Detalle_Venta dv ON v.IdVenta = dv.IdVenta
                               INNER JOIN Articulo a ON dv.IdArticulo = a.IdArticulo
                               WHERE MONTH(v.FechaVenta) = @mes AND YEAR(v.FechaVenta) = @anio
                               ORDER BY v.IdVenta, v.FechaVenta"

        Dim cmd As New SqlClient.SqlCommand(Query, conexion)
        cmd.Parameters.AddWithValue("@mes", mes)
        cmd.Parameters.AddWithValue("@anio", anio)

        Try
            conexion.Open()
            Dim adapter As New SqlClient.SqlDataAdapter(cmd)
            Dim tabla As New DataTable()
            adapter.Fill(tabla)

            dgvVentas.DataSource = tabla

            If tabla.Rows.Count = 0 Then
                MsgBox("No se encontraron ventas para el mes y año seleccionados.", MsgBoxStyle.Exclamation, "Aviso")
            End If

        Catch ex As Exception
            MsgBox("Error al buscar ventas: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub pntVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' llena del  combo con meses y años'
        cbOpcionFecha.Items.Add("2026 Enero")
        cbOpcionFecha.Items.Add("2026 Febrero")
        cbOpcionFecha.Items.Add("2026 Marzo")
        cbOpcionFecha.Items.Add("2026 Abril")
        cbOpcionFecha.Items.Add("2026 Mayo")
    End Sub

    Private Sub cbOpcionFecha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOpcionFecha.SelectedIndexChanged

    End Sub

End Class
