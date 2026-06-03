<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pntVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pntVentas))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnRegresarVen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscarVenta = New System.Windows.Forms.Button()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.cbOpcionFecha = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(99, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 36)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ventas"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(35, 17)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(59, 45)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'btnRegresarVen
        '
        Me.btnRegresarVen.Font = New System.Drawing.Font("Mongolian Baiti", 8.142858!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresarVen.Image = CType(resources.GetObject("btnRegresarVen.Image"), System.Drawing.Image)
        Me.btnRegresarVen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresarVen.Location = New System.Drawing.Point(520, 340)
        Me.btnRegresarVen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegresarVen.Name = "btnRegresarVen"
        Me.btnRegresarVen.Size = New System.Drawing.Size(97, 45)
        Me.btnRegresarVen.TabIndex = 21
        Me.btnRegresarVen.Text = "Regresar"
        Me.btnRegresarVen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresarVen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 15)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Selecciona el mes, para ver el registro de ventas:"
        '
        'btnBuscarVenta
        '
        Me.btnBuscarVenta.Image = CType(resources.GetObject("btnBuscarVenta.Image"), System.Drawing.Image)
        Me.btnBuscarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarVenta.Location = New System.Drawing.Point(396, 88)
        Me.btnBuscarVenta.Name = "btnBuscarVenta"
        Me.btnBuscarVenta.Size = New System.Drawing.Size(106, 46)
        Me.btnBuscarVenta.TabIndex = 24
        Me.btnBuscarVenta.Text = "Buscar"
        Me.btnBuscarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarVenta.UseVisualStyleBackColor = True
        '
        'dgvVentas
        '
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(12, 166)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.Size = New System.Drawing.Size(671, 155)
        Me.dgvVentas.TabIndex = 25
        '
        'cbOpcionFecha
        '
        Me.cbOpcionFecha.FormattingEnabled = True
        Me.cbOpcionFecha.Location = New System.Drawing.Point(105, 113)
        Me.cbOpcionFecha.Name = "cbOpcionFecha"
        Me.cbOpcionFecha.Size = New System.Drawing.Size(167, 21)
        Me.cbOpcionFecha.TabIndex = 26
        '
        'pntVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 406)
        Me.Controls.Add(Me.cbOpcionFecha)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.btnBuscarVenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegresarVen)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label4)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "pntVentas"
        Me.Text = "pntVentas"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnRegresarVen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscarVenta As Button
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents cbOpcionFecha As ComboBox
End Class
