Public Class Form2
    Dim peli As Pelicula

    Public Sub Mostrar(pelicula As Pelicula)
        peli = pelicula
        Me.ShowDialog()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Load(peli.PUrlImagen)
        lblTitulo.Text = peli.PTitulo
        lblAnioEstreno.Text = "Año de Estreno: " + peli.PAnioEstreno.ToString()
        lblDuracion.Text = "Duracción: " + peli.PDuracion.ToString() + " min"
        lblPrecio.Text = "Precio: " + peli.PPrecio.ToString("C")
        lblDetalle.Text = peli.PSinopsis
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        Dim ventaEntradas As New Form3(peli)
        ventaEntradas.ShowDialog()
    End Sub
End Class