Imports System.IO

Public Class Form3
    Dim peli As Pelicula

    Public Sub New(pelicula As Pelicula)
        InitializeComponent()
        peli = pelicula
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        Dim numEntradas As Integer = cantEntradas.Value

        If numEntradas <= 0 Then
            MsgBox("Por favor, ingrese cuantas entradas quiere comprar.")
            Return
        ElseIf numEntradas > 10 Then
            MsgBox("Por favor, no se puede comprar más de 10 entradas.")
            Return
        End If

        Dim comprobar As String = peli.venderEntradas(numEntradas)
        If comprobar = "Se puede comprar todas las entradas" Then
            registrarVenta(numEntradas)
        Else
            MsgBox(comprobar)
        End If
    End Sub

    Private Sub registrarVenta(numEntradas As Integer)
        Dim lineaVenta = $"{peli.PTitulo} - {peli.PPrecio}"
        Try
            Dim sw = New StreamWriter("peliculas.txt", True)
            For index = 1 To numEntradas
                sw.WriteLine(lineaVenta)
            Next
            sw.Close()
            MsgBox("Gracias por comprar las entradas")
            Form2.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class