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
        'crear una nueva instancia del formulario pntEstudiante'
        Dim frmEstudiante As New pntEstudiante()

        'mostrar el formulario en pantalla'
        frmEstudiante.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClases.Click
        pntClases.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bntEmpleados.Click
        pntEmpleados.ShowDialog()
    End Sub

    Private Sub btnRegresarEst_Click(sender As Object, e As EventArgs) Handles btnRegresarEst.Click
        Me.Close()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        pntVentas.ShowDialog()
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        pntCompras.ShowDialog()
    End Sub
End Class