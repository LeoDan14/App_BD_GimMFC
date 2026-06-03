<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pntCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pntCompras))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnRegresarComp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscarCompras = New System.Windows.Forms.Button()
        Me.cbOpcionFecha = New System.Windows.Forms.ComboBox()
        Me.dgvCompras = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(104, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 36)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Compras"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(29, 32)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(59, 45)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'btnRegresarComp
        '
        Me.btnRegresarComp.Font = New System.Drawing.Font("Mongolian Baiti", 8.142858!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresarComp.Image = CType(resources.GetObject("btnRegresarComp.Image"), System.Drawing.Image)
        Me.btnRegresarComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresarComp.Location = New System.Drawing.Point(507, 336)
        Me.btnRegresarComp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRegresarComp.Name = "btnRegresarComp"
        Me.btnRegresarComp.Size = New System.Drawing.Size(95, 46)
        Me.btnRegresarComp.TabIndex = 21
        Me.btnRegresarComp.Text = "Regresar"
        Me.btnRegresarComp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresarComp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Selecciona el mes, para ver el registro de ventas:"
        '
        'btnBuscarCompras
        '
        Me.btnBuscarCompras.Image = CType(resources.GetObject("btnBuscarCompras.Image"), System.Drawing.Image)
        Me.btnBuscarCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarCompras.Location = New System.Drawing.Point(413, 86)
        Me.btnBuscarCompras.Name = "btnBuscarCompras"
        Me.btnBuscarCompras.Size = New System.Drawing.Size(106, 46)
        Me.btnBuscarCompras.TabIndex = 25
        Me.btnBuscarCompras.Text = "Buscar"
        Me.btnBuscarCompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarCompras.UseVisualStyleBackColor = True
        '
        'cbOpcionFecha
        '
        Me.cbOpcionFecha.FormattingEnabled = True
        Me.cbOpcionFecha.Location = New System.Drawing.Point(110, 111)
        Me.cbOpcionFecha.Name = "cbOpcionFecha"
        Me.cbOpcionFecha.Size = New System.Drawing.Size(178, 21)
        Me.cbOpcionFecha.TabIndex = 26
        '
        'dgvCompras
        '
        Me.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompras.Location = New System.Drawing.Point(46, 159)
        Me.dgvCompras.Name = "dgvCompras"
        Me.dgvCompras.Size = New System.Drawing.Size(600, 150)
        Me.dgvCompras.TabIndex = 27
        '
        'pntCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 406)
        Me.Controls.Add(Me.dgvCompras)
        Me.Controls.Add(Me.cbOpcionFecha)
        Me.Controls.Add(Me.btnBuscarCompras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegresarComp)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label4)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "pntCompras"
        Me.Text = "pntCompras"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnRegresarComp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscarCompras As Button
    Friend WithEvents cbOpcionFecha As ComboBox
    Friend WithEvents dgvCompras As DataGridView
End Class
