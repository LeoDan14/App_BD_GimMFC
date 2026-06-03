<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pntEmpleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pntEmpleados))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRegresarEmp = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.btnBuscarEmpleado = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.txtContraseñaEmpleado = New System.Windows.Forms.TextBox()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.btnRegistrarEmpleado = New System.Windows.Forms.Button()
        Me.btnActualizarEmpleado = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(256, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(339, 51)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Empleados MFC"
        '
        'btnRegresarEmp
        '
        Me.btnRegresarEmp.Font = New System.Drawing.Font("Mongolian Baiti", 8.142858!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresarEmp.Image = CType(resources.GetObject("btnRegresarEmp.Image"), System.Drawing.Image)
        Me.btnRegresarEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresarEmp.Location = New System.Drawing.Point(795, 448)
        Me.btnRegresarEmp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegresarEmp.Name = "btnRegresarEmp"
        Me.btnRegresarEmp.Size = New System.Drawing.Size(106, 39)
        Me.btnRegresarEmp.TabIndex = 21
        Me.btnRegresarEmp.Text = "Regresar"
        Me.btnRegresarEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresarEmp.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(667, 200)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(176, 158)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(51, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Para buscar a un empleado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ID del Empleado:"
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Location = New System.Drawing.Point(197, 170)
        Me.txtIdEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(205, 22)
        Me.txtIdEmpleado.TabIndex = 25
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.Font = New System.Drawing.Font("Mongolian Baiti", 8.142858!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarEmpleado.Image = CType(resources.GetObject("btnBuscarEmpleado.Image"), System.Drawing.Image)
        Me.btnBuscarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(433, 161)
        Me.btnBuscarEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(106, 44)
        Me.btnBuscarEmpleado.TabIndex = 26
        Me.btnBuscarEmpleado.Text = "Buscar"
        Me.btnBuscarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarEmpleado.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(51, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(463, 18)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Para registrar nuevo empleado, llena los siguientes campos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Nombre completo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 331)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Contraseña:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 361)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Puesto:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Contacto:"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(204, 289)
        Me.txtNombreEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(205, 22)
        Me.txtNombreEmpleado.TabIndex = 32
        '
        'txtContraseñaEmpleado
        '
        Me.txtContraseñaEmpleado.Location = New System.Drawing.Point(204, 326)
        Me.txtContraseñaEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtContraseñaEmpleado.Name = "txtContraseñaEmpleado"
        Me.txtContraseñaEmpleado.Size = New System.Drawing.Size(205, 22)
        Me.txtContraseñaEmpleado.TabIndex = 33
        '
        'txtPuesto
        '
        Me.txtPuesto.Location = New System.Drawing.Point(204, 361)
        Me.txtPuesto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(205, 22)
        Me.txtPuesto.TabIndex = 34
        '
        'txtContacto
        '
        Me.txtContacto.Location = New System.Drawing.Point(204, 391)
        Me.txtContacto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(205, 22)
        Me.txtContacto.TabIndex = 35
        '
        'btnRegistrarEmpleado
        '
        Me.btnRegistrarEmpleado.Font = New System.Drawing.Font("Mongolian Baiti", 8.142858!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarEmpleado.Image = CType(resources.GetObject("btnRegistrarEmpleado.Image"), System.Drawing.Image)
        Me.btnRegistrarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarEmpleado.Location = New System.Drawing.Point(452, 331)
        Me.btnRegistrarEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegistrarEmpleado.Name = "btnRegistrarEmpleado"
        Me.btnRegistrarEmpleado.Size = New System.Drawing.Size(106, 40)
        Me.btnRegistrarEmpleado.TabIndex = 36
        Me.btnRegistrarEmpleado.Text = "Registrar"
        Me.btnRegistrarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrarEmpleado.UseVisualStyleBackColor = True
        '
        'btnActualizarEmpleado
        '
        Me.btnActualizarEmpleado.Font = New System.Drawing.Font("Mongolian Baiti", 8.142858!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarEmpleado.Image = CType(resources.GetObject("btnActualizarEmpleado.Image"), System.Drawing.Image)
        Me.btnActualizarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarEmpleado.Location = New System.Drawing.Point(489, 448)
        Me.btnActualizarEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnActualizarEmpleado.Name = "btnActualizarEmpleado"
        Me.btnActualizarEmpleado.Size = New System.Drawing.Size(106, 39)
        Me.btnActualizarEmpleado.TabIndex = 37
        Me.btnActualizarEmpleado.Text = "Actualizar"
        Me.btnActualizarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizarEmpleado.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Mongolian Baiti", 8.142858!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(647, 449)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(106, 40)
        Me.btnEliminar.TabIndex = 38
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(51, 448)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 16)
        Me.Label9.TabIndex = 39
        '
        'pntEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 500)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizarEmpleado)
        Me.Controls.Add(Me.btnRegistrarEmpleado)
        Me.Controls.Add(Me.txtContacto)
        Me.Controls.Add(Me.txtPuesto)
        Me.Controls.Add(Me.txtContraseñaEmpleado)
        Me.Controls.Add(Me.txtNombreEmpleado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBuscarEmpleado)
        Me.Controls.Add(Me.txtIdEmpleado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnRegresarEmp)
        Me.Controls.Add(Me.Label4)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "pntEmpleados"
        Me.Text = "pntEmpleados"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegresarEmp As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdEmpleado As TextBox
    Friend WithEvents btnBuscarEmpleado As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents txtContraseñaEmpleado As TextBox
    Friend WithEvents txtPuesto As TextBox
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents btnRegistrarEmpleado As Button
    Friend WithEvents btnActualizarEmpleado As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label9 As Label
End Class
