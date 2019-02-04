Public Class Colegio
    Private Shared _montoHora As Decimal
    Private Shared _Personas As List(Of Persona)
    Private Shared _totalSueldos As Decimal
    Private Shared _listaDePersonas As List(Of Persona)
    Private Shared _listaProfesores As List(Of Profesor)

    Shared Sub New()
        _Personas = New List(Of Persona)
        _listaProfesores = New List(Of Profesor)
    End Sub

    Public Shared Property MontoHora As Decimal
        Get
            Return _montoHora
        End Get
        Set(value As Decimal)
            _montoHora = value
        End Set
    End Property

    Public Shared Sub addPersona(persona As Persona)
        _Personas.Add(persona)
    End Sub

    Public Shared Function getAllProfesores() As List(Of Profesor)
        For Each profesor In _Personas.OfType(Of Profesor)
            _listaProfesores.Add(profesor)
        Next
        Return _listaProfesores
    End Function

    Public Shared Function getTotalSueldos() As Decimal
        For Each empleado In _Personas.OfType(Of Empleados)
            _totalSueldos += empleado.CalcularSueldo
        Next
        Return _totalSueldos
    End Function

    Public Shared Function getPersona(dni As UInteger) As Persona
        For Each persona In _Personas
            If persona.DNI.Equals(dni) Then
                Return persona
            End If
        Next
    End Function

    Public Shared Function getPersonas(nombre As String) As List(Of Persona)
        Dim _listaDePersonas = New List(Of Persona)
        For Each persona In _Personas
            If persona.Nombre.Equals(nombre) Then
                _listaDePersonas.Add(persona)
            End If
        Next
        Return _listaDePersonas
    End Function
End Class
