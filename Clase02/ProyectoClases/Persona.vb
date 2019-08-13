Public Class Persona

    Private id As Integer
    Private paterno As String
    Private materno As String
    Private nombres As String
    Private nombreCompleto As String
    Private edad As Integer
    Private fechaNacimiento As DateTime




    Public Sub nombreCompletoPersona()
        nombreCompleto = nombres + materno + paterno
    End Sub


    Public Sub New(
                  id As Integer,
                  paterno As String,
                  materno As String,
                  nombres As String,
                  nombreCompleto As String,
                  edad As Integer,
                  fechaNacimiento As DateTime)
        id = id
        paterno = paterno
        materno = materno
        nombres = nombres
        nombreCompleto = nombreCompleto
        edad = edad
        fechaNacimiento = fechaNacimiento
    End Sub

    Public Sub New(
                  id As Integer,
                  paterno As String,
                  materno As String,
                  nombres As String,
                  fechaNacimiento As DateTime)
        id = id
        paterno = paterno
        materno = materno
        nombres = nombres
        fechaNacimiento = fechaNacimiento
    End Sub

End Class
