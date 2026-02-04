<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnCreditos = New System.Windows.Forms.Button()
        Me.lblSala1 = New System.Windows.Forms.Label()
        Me.lblSala2 = New System.Windows.Forms.Label()
        Me.lblSala3 = New System.Windows.Forms.Label()
        Me.lblSala4 = New System.Windows.Forms.Label()
        Me.lblSala5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(15, 24)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(254, 41)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "CINE DE BARRIO"
        '
        'PictureBox1
        '
        Me.PictureBox1.ImageLocation = resources.GetString("PictureBox1.ImageLocation")
        Me.PictureBox1.Location = New System.Drawing.Point(22, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 217)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.ImageLocation = resources.GetString("PictureBox2.ImageLocation")
        Me.PictureBox2.Location = New System.Drawing.Point(220, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(182, 217)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.ImageLocation = resources.GetString("PictureBox3.ImageLocation")
        Me.PictureBox3.Location = New System.Drawing.Point(420, 84)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(182, 217)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.ImageLocation = resources.GetString("PictureBox4.ImageLocation")
        Me.PictureBox4.Location = New System.Drawing.Point(622, 83)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(182, 217)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.ImageLocation = resources.GetString("PictureBox5.ImageLocation")
        Me.PictureBox5.Location = New System.Drawing.Point(820, 83)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(182, 217)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'btnCreditos
        '
        Me.btnCreditos.AutoSize = True
        Me.btnCreditos.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreditos.Location = New System.Drawing.Point(825, 22)
        Me.btnCreditos.Name = "btnCreditos"
        Me.btnCreditos.Size = New System.Drawing.Size(177, 51)
        Me.btnCreditos.TabIndex = 6
        Me.btnCreditos.Text = "Créditos"
        Me.btnCreditos.UseVisualStyleBackColor = True
        '
        'lblSala1
        '
        Me.lblSala1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSala1.Location = New System.Drawing.Point(19, 316)
        Me.lblSala1.Name = "lblSala1"
        Me.lblSala1.Size = New System.Drawing.Size(185, 83)
        Me.lblSala1.TabIndex = 7
        Me.lblSala1.Text = "Sala 1 "
        Me.lblSala1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSala2
        '
        Me.lblSala2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSala2.Location = New System.Drawing.Point(217, 316)
        Me.lblSala2.Name = "lblSala2"
        Me.lblSala2.Size = New System.Drawing.Size(185, 83)
        Me.lblSala2.TabIndex = 8
        Me.lblSala2.Text = "Sala 2 "
        Me.lblSala2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSala3
        '
        Me.lblSala3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSala3.Location = New System.Drawing.Point(417, 316)
        Me.lblSala3.Name = "lblSala3"
        Me.lblSala3.Size = New System.Drawing.Size(185, 83)
        Me.lblSala3.TabIndex = 9
        Me.lblSala3.Text = "Sala 3 "
        Me.lblSala3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSala4
        '
        Me.lblSala4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSala4.Location = New System.Drawing.Point(619, 316)
        Me.lblSala4.Name = "lblSala4"
        Me.lblSala4.Size = New System.Drawing.Size(185, 83)
        Me.lblSala4.TabIndex = 10
        Me.lblSala4.Text = "Sala 4 "
        Me.lblSala4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSala5
        '
        Me.lblSala5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSala5.Location = New System.Drawing.Point(821, 316)
        Me.lblSala5.Name = "lblSala5"
        Me.lblSala5.Size = New System.Drawing.Size(185, 83)
        Me.lblSala5.TabIndex = 11
        Me.lblSala5.Text = "Sala 5 "
        Me.lblSala5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 408)
        Me.Controls.Add(Me.lblSala5)
        Me.Controls.Add(Me.lblSala4)
        Me.Controls.Add(Me.lblSala3)
        Me.Controls.Add(Me.lblSala2)
        Me.Controls.Add(Me.lblSala1)
        Me.Controls.Add(Me.btnCreditos)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Form1"
        Me.Text = "Cartelera"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnCreditos As Button
    Friend WithEvents lblSala1 As Label
    Friend WithEvents lblSala2 As Label
    Friend WithEvents lblSala3 As Label
    Friend WithEvents lblSala4 As Label
    Friend WithEvents lblSala5 As Label
End Class
