Imports System.Data.SqlClient
Imports System.Globalization

Public Class pntCompras

    Private Sub btnRegresarComp_Click(sender As Object, e As EventArgs) Handles btnRegresarComp.Click
        Me.Close()
    End Sub

    Private Sub pntCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' llenar combo con meses y años disponibles
        cbOpcionFecha.Items.Add("2026 Enero")
        cbOpcionFecha.Items.Add("2026 Febrero")
        cbOpcionFecha.Items.Add("2026 Marzo")
        cbOpcionFecha.Items.Add("2026 Abril")
        cbOpcionFecha.Items.Add("2026 Mayo")
    End Sub

    Private Sub btnBuscarCompras_Click(sender As Object, e As EventArgs) Handles btnBuscarCompras.Click
        Dim conexion As New SqlConnection("Data Source=DESKTOP-P1KRNOI\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True")

        If cbOpcionFecha.SelectedItem Is Nothing Then
            MsgBox("Seleccione un mes y año en el combo antes de buscar.", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        ' ejemplo: "2026 Enero"
        Dim seleccion As String = cbOpcionFecha.SelectedItem.ToString()
        Dim partes() As String = seleccion.Split(" "c)
        Dim año As Integer = Convert.ToInt32(partes(0))
        Dim mesNombre As String = partes(1)

        ' convertir nombre de mes a número (forzar español)
        Dim mes As Integer = DateTime.ParseExact(mesNombre, "MMMM", New CultureInfo("es-ES")).Month

        ' consulta directa con JOIN
        Dim Query As String = "SELECT 
                                   c.IdCompras,
                                   c.Descripcion,
                                   c.Fecha_Comp,
                                   c.Monto_Comp,
                                   e.Nombre_Empleado,
                                   p.Nombre_Proveedor,
                                   a.Nombre_Art,
                                   dc.Cantidad
                               FROM Compras c
                               INNER JOIN Empleado e ON c.IdEmpleado = e.IdEmpleado
                               INNER JOIN Proveedor p ON c.IdProv = p.IdProv
                               INNER JOIN Detalle_Compra dc ON c.IdCompras = dc.IdCompras
                               INNER JOIN Articulo a ON dc.IdArticulo = a.IdArticulo
                               WHERE MONTH(c.Fecha_Comp) = @mes AND YEAR(c.Fecha_Comp) = @anio
                               ORDER BY c.IdCompras, c.Fecha_Comp"

        Dim cmd As New SqlClient.SqlCommand(Query, conexion)
        cmd.Parameters.AddWithValue("@mes", mes)
        cmd.Parameters.AddWithValue("@anio", año) ' ← aquí está la clave: usar "anio" sin ñ

        Try
            conexion.Open()
            Dim adapter As New SqlClient.SqlDataAdapter(cmd)
            Dim tabla As New DataTable()
            adapter.Fill(tabla)

            dgvCompras.DataSource = tabla

            If tabla.Rows.Count = 0 Then
                MsgBox("No se encontraron compras para el mes y año seleccionados.", MsgBoxStyle.Exclamation, "Aviso")
            End If

        Catch ex As Exception
            MsgBox("Error al buscar compras: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub cbOpcionFecha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOpcionFecha.SelectedIndexChanged
        ' la búsqueda se hace únicamente al presionar el botón
    End Sub

End Class
