<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pntEstudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pntEstudiante))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdEstudiante = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombreEstudiantes = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.btnRegresarEst = New System.Windows.Forms.Button()
        Me.btnBuscarEstudiante = New System.Windows.Forms.Button()
        Me.btnRegistrarEstudiante = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID del Estudiante:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(316, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Para buscar a un estudiante:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(657, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Para registrar nuevo estudiante, llena los siguientes campos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(219, 58)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 48)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Estudiante"
        '
        'txtIdEstudiante
        '
        Me.txtIdEstudiante.Location = New System.Drawing.Point(275, 248)
        Me.txtIdEstudiante.Name = "txtIdEstudiante"
        Me.txtIdEstudiante.Size = New System.Drawing.Size(280, 29)
        Me.txtIdEstudiante.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 394)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nombre completo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 439)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Dirección:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 483)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Fecha de nacimiento:"
        '
        'txtNombreEstudiantes
        '
        Me.txtNombreEstudiantes.Location = New System.Drawing.Point(275, 390)
        Me.txtNombreEstudiantes.Name = "txtNombreEstudiantes"
        Me.txtNombreEstudiantes.Size = New System.Drawing.Size(319, 29)
        Me.txtNombreEstudiantes.TabIndex = 10
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(275, 435)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(319, 29)
        Me.txtDireccion.TabIndex = 11
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Location = New System.Drawing.Point(275, 477)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(319, 29)
        Me.dtpFechaNac.TabIndex = 12
        Me.dtpFechaNac.Value = New Date(2026, 5, 30, 0, 29, 11, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(65, 590)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 23)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "ID del empleado:"
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Location = New System.Drawing.Point(275, 590)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(319, 29)
        Me.txtIdEmpleado.TabIndex = 14
        '
        'btnRegresarEst
        '
        Me.btnRegresarEst.Font = New System.Drawing.Font("Mongolian Baiti", 8.142858!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresarEst.Image = CType(resources.GetObject("btnRegresarEst.Image"), System.Drawing.Image)
        Me.btnRegresarEst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresarEst.Location = New System.Drawing.Point(641, 666)
        Me.btnRegresarEst.Name = "btnRegresarEst"
        Me.btnRegresarEst.Size = New System.Drawing.Size(129, 49)
        Me.btnRegresarEst.TabIndex = 20
        Me.btnRegresarEst.Text = "Regresar"
        Me.btnRegresarEst.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresarEst.UseVisualStyleBackColor = True
        '
        'btnBuscarEstudiante
        '
        Me.btnBuscarEstudiante.Font = New System.Drawing.Font("Mongolian Baiti", 8.142858!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarEstudiante.Image = CType(resources.GetObject("btnBuscarEstudiante.Image"), System.Drawing.Image)
        Me.btnBuscarEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarEstudiante.Location = New System.Drawing.Point(583, 241)
        Me.btnBuscarEstudiante.Name = "btnBuscarEstudiante"
        Me.btnBuscarEstudiante.Size = New System.Drawing.Size(112, 50)
        Me.btnBuscarEstudiante.TabIndex = 21
        Me.btnBuscarEstudiante.Text = "Buscar"
        Me.btnBuscarEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarEstudiante.UseVisualStyleBackColor = True
        '
        'btnRegistrarEstudiante
        '
        Me.btnRegistrarEstudiante.Font = New System.Drawing.Font("Mongolian Baiti", 8.142858!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarEstudiante.Image = CType(resources.GetObject("btnRegistrarEstudiante.Image"), System.Drawing.Image)
        Me.btnRegistrarEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarEstudiante.Location = New System.Drawing.Point(227, 664)
        Me.btnRegistrarEstudiante.Name = "btnRegistrarEstudiante"
        Me.btnRegistrarEstudiante.Size = New System.Drawing.Size(136, 51)
        Me.btnRegistrarEstudiante.TabIndex = 22
        Me.btnRegistrarEstudiante.Text = "Registrar"
        Me.btnRegistrarEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrarEstudiante.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Mongolian Baiti", 8.142858!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(452, 666)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(142, 50)
        Me.btnActualizar.TabIndex = 23
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(88, 39)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(109, 82)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'txtContacto
        '
        Me.txtContacto.Location = New System.Drawing.Point(275, 521)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(319, 29)
        Me.txtContacto.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(65, 527)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 23)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Contacto:"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(965, 39)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(280, 29)
        Me.dtpFechaIngreso.TabIndex = 26
        '
        'pntEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 772)
        Me.Controls.Add(Me.dtpFechaIngreso)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtContacto)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnRegistrarEstudiante)
        Me.Controls.Add(Me.btnBuscarEstudiante)
        Me.Controls.Add(Me.btnRegresarEst)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtIdEmpleado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpFechaNac)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombreEstudiantes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIdEstudiante)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "pntEstudiante"
        Me.Text = "pntEstudiante"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdEstudiante As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombreEstudiantes As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIdEmpleado As TextBox
    Friend WithEvents btnRegresarEst As Button
    Friend WithEvents btnBuscarEstudiante As Button
    Friend WithEvents btnRegistrarEstudiante As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpFechaIngreso As DateTimePicker
End Class
