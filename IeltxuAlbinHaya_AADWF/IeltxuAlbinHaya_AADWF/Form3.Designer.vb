<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.cantEntradas = New System.Windows.Forms.NumericUpDown()
        CType(Me.cantEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(98, 42)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(510, 41)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "¿Cuantas entradas quiere comprar?"
        '
        'btnVender
        '
        Me.btnVender.AutoSize = True
        Me.btnVender.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVender.Location = New System.Drawing.Point(263, 169)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(177, 51)
        Me.btnVender.TabIndex = 5
        Me.btnVender.Text = "COMPRAR"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'cantEntradas
        '
        Me.cantEntradas.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cantEntradas.Location = New System.Drawing.Point(222, 111)
        Me.cantEntradas.Name = "cantEntradas"
        Me.cantEntradas.Size = New System.Drawing.Size(252, 34)
        Me.cantEntradas.TabIndex = 6
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 288)
        Me.Controls.Add(Me.cantEntradas)
        Me.Controls.Add(Me.btnVender)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Form3"
        Me.Text = "Comprar Entradas"
        CType(Me.cantEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnVender As Button
    Friend WithEvents cantEntradas As NumericUpDown
End Class
