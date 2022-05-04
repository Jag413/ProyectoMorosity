Public Class PeticionDTO
    Public Property IdPeticion As Integer
    Public Property DocumentoId As String
    Public Property Estado As String

    Public Shared Widening Operator CType(v As Boolean) As PeticionDTO
        Throw New NotImplementedException()
    End Operator
End Class
