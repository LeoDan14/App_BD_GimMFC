Imports System.Data.SqlClient

Public Class pntCompras

    Private Sub btnRegresarComp_Click(sender As Object, e As EventArgs) Handles btnRegresarComp.Click
        Me.Close()
    End Sub

    Private Sub pntCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' llenar combo con pares Año-Mes en formato numérico
        cbOpcionFecha.Items.Add("2026-01")
        cbOpcionFecha.Items.Add("2026-02")
        cbOpcionFecha.Items.Add("2026-03")
    End Sub

    Private Sub btnBuscarCompras_Click(sender As Object, e As EventArgs) Handles btnBuscarCompras.Click
        Dim conexion As New SqlConnection("Data Source=DESKTOP-P1KRNOI\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True")

        If cbOpcionFecha.SelectedItem Is Nothing Then
            MsgBox("Seleccione un año-mes en el combo antes de buscar.", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        ' ejemplo: "2026-01"
        Dim seleccion As String = cbOpcionFecha.SelectedItem.ToString()
        Dim partes() As String = seleccion.Split("-"c)
        Dim año As Integer = Convert.ToInt32(partes(0))
        Dim mes As Integer = Convert.ToInt32(partes(1))

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
        cmd.Parameters.AddWithValue("@anio", año)

        Try
            conexion.Open()
            Dim adapter As New SqlClient.SqlDataAdapter(cmd)
            Dim tabla As New DataTable()
            adapter.Fill(tabla)

            dgvCompras.DataSource = tabla

            If tabla.Rows.Count = 0 Then
                MsgBox("No se encontraron compras para el año-mes seleccionado.", MsgBoxStyle.Exclamation, "Aviso")
            End If

        Catch ex As Exception
            MsgBox("Error al buscar compras: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            conexion.Close()
        End Try
    End Sub

End Class

