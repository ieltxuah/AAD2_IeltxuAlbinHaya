Public Class Form1
    Dim cine As Cine
    Dim peliculas As List(Of Pelicula)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cine = New Cine()
        peliculas = cine.ObtenerPeliculas()
        If peliculas IsNot Nothing AndAlso peliculas.Count >= 5 Then
            PictureBox1.Load(peliculas(0).PUrlImagen)
            lblSala1.Text += vbCrLf + peliculas(0).PTitulo
            PictureBox2.Load(peliculas(1).PUrlImagen)
            lblSala2.Text += vbCrLf + peliculas(1).PTitulo
            PictureBox3.Load(peliculas(2).PUrlImagen)
            lblSala3.Text += vbCrLf + peliculas(2).PTitulo
            PictureBox4.Load(peliculas(3).PUrlImagen)
            lblSala4.Text += vbCrLf + peliculas(3).PTitulo
            PictureBox5.Load(peliculas(4).PUrlImagen)
            lblSala5.Text += vbCrLf + peliculas(4).PTitulo
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Mostrar(peliculas(0))
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form2.Mostrar(peliculas(1))
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form2.Mostrar(peliculas(2))
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Form2.Mostrar(peliculas(3))
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Form2.Mostrar(peliculas(4))
    End Sub

    Private Sub btnCreditos_Click(sender As Object, e As EventArgs) Handles btnCreditos.Click
        Form4.ShowDialog()
    End Sub
End Class
