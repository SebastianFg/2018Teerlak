Public Class Asignatura
    Private _nombre As String
    Private _profesor As Profesor
    Private _alumnos As List(Of Alumno)
    Private _horasSemanales As Byte
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Count >= 3 Then
                _nombre = value
            Else
                Throw New Exception("El nombre es muy corto o muy largo")
            End If
        End Set
    End Property

    Public Property Profesor As Profesor
        Get
            Return _profesor
        End Get
        Friend Set(value As Profesor)
            _profesor = value
        End Set
    End Property

    Public Property HorasSemanales As Byte
        Get
            Return _horasSemanales
        End Get
        Set(value As Byte)
            If value > 0 Then
                _horasSemanales = value
            End If
        End Set
    End Property

    Sub New(nombre As String)
        Me.Nombre = nombre
        _alumnos = New List(Of Alumno)
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    'bidireccional * a * no responsable
    '====================================
    Friend Sub AddAlumno(alumno As Alumno)
        _alumnos.Add(alumno)
    End Sub

    Friend Sub removeAlumno(alumno As Alumno)
        _alumnos.Remove(alumno)
    End Sub

    '=====================================

End Class
