Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class Form4
    Public Shared ReadOnly client As New HttpClient()
    Dim html_url As String

    Private Async Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0")

            Dim respuesta As HttpResponseMessage = Await client.GetAsync(My.Settings.githubAPIString)
            respuesta.EnsureSuccessStatusCode()

            Dim contenido As String = Await respuesta.Content.ReadAsStringAsync()
            Dim entity As JObject = JObject.Parse(contenido)
            html_url = entity("html_url").ToString()
            PictureBox1.Load(entity("avatar_url").ToString())
            lblNombre.Text = "Nombre de Perfil: " + entity("login").ToString()
            lblPublic.Text = "Numero de Repositorios Publicos: " + entity("public_repos").ToString()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Not String.IsNullOrEmpty(html_url) Then
            Process.Start(html_url)
        End If
    End Sub
End Class