Imports MySql.Data.MySqlClient

Public Class Cine
    Private peliculas As List(Of Pelicula)

    Public Sub New()
        peliculas = New List(Of Pelicula)()
        CargarPeliculas()
    End Sub

    Public Sub CargarPeliculas()
        Dim conn As New MySqlConnection(My.Settings.connString)
        Dim command As New MySqlCommand("SELECT * FROM PELICULA", conn)

        Try
            conn.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            peliculas.Clear()

            While reader.Read()
                Dim nuevaPelicula As New Pelicula(
                    reader("titulo").ToString(),
                    Convert.ToInt32(reader("anio_estreno")),
                    Convert.ToInt32(reader("duracion")),
                    Convert.ToDouble(reader("precio")),
                    reader("sinopsis").ToString(),
                    reader("url_imagen").ToString(),
                    Convert.ToInt32(reader("entradas_disponibles"))
                )
                peliculas.Add(nuevaPelicula)
            End While
        Catch ex As Exception
            Console.WriteLine("Error al cargar las películas: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Function ObtenerPeliculas() As List(Of Pelicula)
        Return peliculas
    End Function
End Class
