Imports _2018vb

Public NotInheritable Class Profesor
    Inherits Persona
    Implements Empleados
    Private _sueldoBase As Decimal
    Private _legajo As UShort
    Private _totalHoras As Byte

    Public Property legajo As UShort
        Get
            Return _legajo
        End Get
        Set(value As UShort)
            If value > 0 Then
                _legajo = value
            Else
                Throw New Exception("El valor del legajo tiene q ser mayor a cero")
            End If
        End Set
    End Property

    Public Property SueldoBase As Decimal Implements Empleados.SueldoBase
        Get
            Return _sueldoBase
        End Get
        Set(value As Decimal)
            If value > 0 Then
                _sueldoBase = value
            Else
                Throw New Exception("El sueldo debe ser mayor a cero")
            End If

        End Set
    End Property

    Sub New(Nombre As String, dni As UInteger, legajo As UShort, sueldoBase As Decimal)
        MyBase.New(Nombre, dni)
        Me.legajo = legajo
        Me.SueldoBase = sueldoBase
        _totalHoras = 0
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString & " Legajo: " & legajo
    End Function

    Public Overrides Sub AddAsignatura(asignatura As Asignatura)
        asignatura.Profesor = Me
        _asignatura.Add(asignatura)
    End Sub

    Public Overrides Sub removeAsignatura(asignatura As Asignatura)
        _totalHoras -= asignatura.HorasSemanales
        asignatura.Profesor = Nothing
        MyBase.RemoveAsignatura(asignatura)

    End Sub

    Public Function calcularTotalHoras() As Decimal
        For Each horas In _asignatura
            _totalHoras += horas.HorasSemanales
        Next
        Return _totalHoras
    End Function

    Public Function CalcularSueldo() As Decimal Implements Empleados.CalcularSueldo
        _totalHoras = 0
        Dim total As UInteger
        total = calcularTotalHoras()
        total = total * Colegio.MontoHora
        total = total + SueldoBase
        Return total
    End Function
End Class
