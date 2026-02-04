<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.lblSinopsis = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.lblAnioEstreno = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(50, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 294)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblDetalle)
        Me.Panel1.Controls.Add(Me.lblSinopsis)
        Me.Panel1.Controls.Add(Me.lblPrecio)
        Me.Panel1.Controls.Add(Me.lblDuracion)
        Me.Panel1.Controls.Add(Me.lblAnioEstreno)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Location = New System.Drawing.Point(318, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 293)
        Me.Panel1.TabIndex = 1
        '
        'lblDetalle
        '
        Me.lblDetalle.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalle.Location = New System.Drawing.Point(45, 179)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(365, 89)
        Me.lblDetalle.TabIndex = 7
        '
        'lblSinopsis
        '
        Me.lblSinopsis.AutoSize = True
        Me.lblSinopsis.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblSinopsis.Location = New System.Drawing.Point(39, 151)
        Me.lblSinopsis.Name = "lblSinopsis"
        Me.lblSinopsis.Size = New System.Drawing.Size(93, 28)
        Me.lblSinopsis.TabIndex = 6
        Me.lblSinopsis.Text = "Sinopsis: "
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblPrecio.Location = New System.Drawing.Point(39, 123)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(75, 28)
        Me.lblPrecio.TabIndex = 5
        Me.lblPrecio.Text = "Precio: "
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblDuracion.Location = New System.Drawing.Point(39, 95)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(109, 28)
        Me.lblDuracion.TabIndex = 4
        Me.lblDuracion.Text = "Duracción: "
        '
        'lblAnioEstreno
        '
        Me.lblAnioEstreno.AutoSize = True
        Me.lblAnioEstreno.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblAnioEstreno.Location = New System.Drawing.Point(39, 67)
        Me.lblAnioEstreno.Name = "lblAnioEstreno"
        Me.lblAnioEstreno.Size = New System.Drawing.Size(154, 28)
        Me.lblAnioEstreno.TabIndex = 3
        Me.lblAnioEstreno.Text = "Año de Estreno: "
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(37, 26)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(102, 41)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Titulo"
        '
        'btnVender
        '
        Me.btnVender.AutoSize = True
        Me.btnVender.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVender.Location = New System.Drawing.Point(298, 367)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(257, 51)
        Me.btnVender.TabIndex = 2
        Me.btnVender.Text = "Vender Entradas"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.AutoSize = True
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(724, 400)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(86, 38)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 450)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnVender)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form2"
        Me.Text = "Pelicula"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAnioEstreno As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblDuracion As Label
    Friend WithEvents lblDetalle As Label
    Friend WithEvents lblSinopsis As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents btnVender As Button
    Friend WithEvents btnVolver As Button
End Class
