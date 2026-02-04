Public Class Pelicula
    Private Property Titulo As String
    Private Property AnioEstreno As Integer
    Private Property Duracion As Integer
    Private Property Precio As Decimal
    Private Property Sinopsis As String
    Private Property UrlImagen As String
    Private Property EntradasDisponibles As Integer
    Private Property EntradasVendidas As Integer

    Public Sub New(titulo As String, anioEstreno As Integer, duracion As Integer, precio As Double, sinopsis As String, urlImagen As String, entradasDisponibles As Integer)
        Me.Titulo = titulo
        Me.AnioEstreno = anioEstreno
        Me.Duracion = duracion
        Me.Precio = precio
        Me.Sinopsis = sinopsis
        Me.UrlImagen = urlImagen
        Me.EntradasDisponibles = entradasDisponibles
        Me.EntradasVendidas = 0
    End Sub

    Public Property PTitulo() As String
        Get
            Return Titulo
        End Get
        Set(ByVal value As String)
            Titulo = value
        End Set
    End Property
    Public Property PAnioEstreno() As Integer
        Get
            Return AnioEstreno
        End Get
        Set(ByVal value As Integer)
            AnioEstreno = value
        End Set
    End Property
    Public Property PDuracion() As Integer
        Get
            Return Duracion
        End Get
        Set(ByVal value As Integer)
            Duracion = value
        End Set
    End Property
    Public Property PPrecio() As Double
        Get
            Return Precio
        End Get
        Set(ByVal value As Double)
            Precio = value
        End Set
    End Property
    Public Property PSinopsis() As String
        Get
            Return Sinopsis
        End Get
        Set(ByVal value As String)
            Sinopsis = value
        End Set
    End Property
    Public Property PUrlImagen() As String
        Get
            Return UrlImagen
        End Get
        Set(ByVal value As String)
            UrlImagen = value
        End Set
    End Property
    Public Property PEntradasDisponibles() As Integer
        Get
            Return EntradasDisponibles
        End Get
        Set(ByVal value As Integer)
            EntradasDisponibles = value
        End Set
    End Property

    Public Function venderEntradas(cantEntradas As Integer) As String
        If cantEntradas > 10 Then
            Return "No se pueden comprar más de diez entradas"
        Else
            If Me.EntradasVendidas + cantEntradas < Me.EntradasDisponibles Then
                Return "Se puede comprar todas las entradas"
            Else
                Return $"No pueden comprar todas las entradas, como máximo puedes comprar: {Me.EntradasDisponibles - EntradasVendidas}"
            End If
        End If
    End Function
End Class
