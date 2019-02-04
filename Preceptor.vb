Public Class Preceptor
    Inherits Persona
    Implements Empleados
    Private _sueldoBase As Decimal

    Sub New(Nombre As String, dni As UInteger, SueldoBase As Decimal)
        MyBase.New(Nombre, dni)
        Me.SueldoBase = SueldoBase
    End Sub

    Public Property SueldoBase As Decimal Implements Empleados.SueldoBase
        Get
            Return _sueldoBase
        End Get
        Set(value As Decimal)
            If value > 0 Then
                _sueldoBase = value
            Else
                Throw New Exception("El nombre es muy corto o muy largo")
            End If
        End Set
    End Property

    'No implementa ADdAsignatura
    Public Overrides Sub AddAsignatura(_asignatura As Asignatura)
        Throw New NotImplementedException()
    End Sub

    Public Function CalcularSueldo() As Decimal Implements Empleados.CalcularSueldo
        Return SueldoBase * 2
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString & " Sueldo : " & CalcularSueldo()
    End Function
End Class
