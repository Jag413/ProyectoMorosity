Public Class Peticiones
    Dim agregarpet As New AgregarPeticion
    Dim agregarcli As New AgregarCliente
    Private Sub OnClick_Buscar(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub OnClic_AniadirNueva(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub OnClic_AniadirPeticion(sender As Object, e As RoutedEventArgs)
        agregarpet.Show()

    End Sub

    Private Sub OnClic_AniadirCliente(sender As Object, e As RoutedEventArgs)

    End Sub
End Class
