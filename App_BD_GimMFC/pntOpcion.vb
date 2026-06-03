Public Class pntOpcion
    Private Sub btnSalirOP_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        'crear una nueva instancia del formulario pntEstudiante'
        Dim frmEstudiante As New pntEstudiante()

        'mostrar el formulario en pantalla'
        frmEstudiante.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        pntClases.ShowDialog()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEstudiante_Click(sender As Object, e As EventArgs) Handles btnEstudiante.Click
        Me.Hide() ' ocultar pntOpcion
        Dim frmEstudiante As New pntEstudiante()
        frmEstudiante.ShowDialog() ' mostrar como modal
        Me.Show() ' volver a mostrar pntOpcion al cerrar
    End Sub

    Private Sub btnClases_Click(sender As Object, e As EventArgs) Handles btnClases.Click
        Me.Hide()
        Dim frmClases As New pntClases()
        frmClases.ShowDialog()
        Me.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bntEmpleados_Click(sender As Object, e As EventArgs) Handles bntEmpleados.Click
        Me.Hide()
        Dim frmEmpleados As New pntEmpleados()
        frmEmpleados.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnRegresarEst_Click(sender As Object, e As EventArgs) Handles btnRegresarEst.Click
        Me.Close()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Me.Hide()
        Dim frmVentas As New pntVentas()
        frmVentas.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        Me.Hide()
        Dim frmCompras As New pntCompras()
        frmCompras.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class