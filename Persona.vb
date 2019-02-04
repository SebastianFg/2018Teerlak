Public MustInherit Class Persona
    Private _nombre As String
    Private _DNI As UInteger
    Protected _asignatura As List(Of Asignatura)

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Count >= 3 Then
                _nombre = value
            Else
                Throw New Exception("El nombre es muy corto")
            End If
        End Set
    End Property

    Public Property DNI As UInteger
        Get
            Return _DNI
        End Get
        Set(value As UInteger)
            If value > 0 Then
                _DNI = value
            Else
                Throw New Exception("Debe ser mayor a cero")
            End If

        End Set
    End Property

    Sub New(nombre As String, dni As UInteger)
        Me.Nombre = nombre
        Me.DNI = dni
        _asignatura = New List(Of Asignatura)
    End Sub

    Public Overrides Function ToString() As String
        Return "Nombre " & Nombre & " DNI " & DNI
    End Function

    Public MustOverride Sub AddAsignatura(_asignatura As Asignatura)

    Public Function getAllAsignaturas() As List(Of Asignatura)
        Return _asignatura
    End Function

    Public Overridable Sub RemoveAsignatura(asignatura As Asignatura)
        _asignatura.Remove(asignatura)
    End Sub


End Class
