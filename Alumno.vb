Imports _2018vb

Public Class Alumno
    Inherits Persona

    Sub New(nombre As String, dni As UInteger)
        MyBase.New(nombre, dni)
    End Sub

    'bidireccional multiple
    'clase responsable ====================================
    Public Overrides Sub AddAsignatura(asignatura As Asignatura)
        asignatura.AddAlumno(Me)
        _asignatura.Add(asignatura)
    End Sub
    Public Overrides Sub removeAsignatura(asignatura As Asignatura)
        asignatura.removeAlumno(Me)
        MyBase.RemoveAsignatura(asignatura)
    End Sub

    'Public Function getAllAsignaturas() As List(Of Asignatura)
    ' Ya existe en la clase base
    'End Function
    '===========================================================


End Class
