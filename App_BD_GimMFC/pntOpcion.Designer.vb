<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pntOpcion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pntOpcion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEstudiante = New System.Windows.Forms.Button()
        Me.btnClases = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.bntEmpleados = New System.Windows.Forms.Button()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnRegresarEst = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(259, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Opciones:"
        '
        'btnEstudiante
        '
        Me.btnEstudiante.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstudiante.Image = CType(resources.GetObject("btnEstudiante.Image"), System.Drawing.Image)
        Me.btnEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEstudiante.Location = New System.Drawing.Point(46, 139)
        Me.btnEstudiante.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEstudiante.Name = "btnEstudiante"
        Me.btnEstudiante.Size = New System.Drawing.Size(150, 51)
        Me.btnEstudiante.TabIndex = 22
        Me.btnEstudiante.Text = "Estudiantes"
        Me.btnEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEstudiante.UseVisualStyleBackColor = True
        '
        'btnClases
        '
        Me.btnClases.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClases.Image = CType(resources.GetObject("btnClases.Image"), System.Drawing.Image)
        Me.btnClases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClases.Location = New System.Drawing.Point(250, 139)
        Me.btnClases.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClases.Name = "btnClases"
        Me.btnClases.Size = New System.Drawing.Size(150, 51)
        Me.btnClases.TabIndex = 23
        Me.btnClases.Text = "Clases"
        Me.btnClases.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClases.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.Image = CType(resources.GetObject("btnVentas.Image"), System.Drawing.Image)
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(148, 260)
        Me.btnVentas.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(150, 51)
        Me.btnVentas.TabIndex = 24
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'bntEmpleados
        '
        Me.bntEmpleados.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntEmpleados.Image = CType(resources.GetObject("bntEmpleados.Image"), System.Drawing.Image)
        Me.bntEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntEmpleados.Location = New System.Drawing.Point(464, 139)
        Me.bntEmpleados.Margin = New System.Windows.Forms.Padding(2)
        Me.bntEmpleados.Name = "bntEmpleados"
        Me.bntEmpleados.Size = New System.Drawing.Size(150, 51)
        Me.bntEmpleados.TabIndex = 25
        Me.bntEmpleados.Text = "Empleados"
        Me.bntEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bntEmpleados.UseVisualStyleBackColor = True
        '
        'btnCompras
        '
        Me.btnCompras.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompras.Image = CType(resources.GetObject("btnCompras.Image"), System.Drawing.Image)
        Me.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.Location = New System.Drawing.Point(364, 260)
        Me.btnCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(150, 51)
        Me.btnCompras.TabIndex = 26
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCompras.UseVisualStyleBackColor = True
        '
        'btnRegresarEst
        '
        Me.btnRegresarEst.Font = New System.Drawing.Font("Mongolian Baiti", 8.142858!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresarEst.Image = CType(resources.GetObject("btnRegresarEst.Image"), System.Drawing.Image)
        Me.btnRegresarEst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresarEst.Location = New System.Drawing.Point(582, 365)
        Me.btnRegresarEst.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegresarEst.Name = "btnRegresarEst"
        Me.btnRegresarEst.Size = New System.Drawing.Size(71, 32)
        Me.btnRegresarEst.TabIndex = 27
        Me.btnRegresarEst.Text = "Regresar"
        Me.btnRegresarEst.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresarEst.UseVisualStyleBackColor = True
        '
        'pntOpcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 418)
        Me.Controls.Add(Me.btnRegresarEst)
        Me.Controls.Add(Me.btnCompras)
        Me.Controls.Add(Me.bntEmpleados)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.btnClases)
        Me.Controls.Add(Me.btnEstudiante)
        Me.Controls.Add(Me.Label1)
        Me.Name = "pntOpcion"
        Me.Text = "pntOpcion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnEstudiante As Button
    Friend WithEvents btnClases As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents bntEmpleados As Button
    Friend WithEvents btnCompras As Button
    Friend WithEvents btnRegresarEst As Button
End Class
