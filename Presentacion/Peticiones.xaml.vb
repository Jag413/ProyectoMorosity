Public Class Peticiones



    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub OnClick_Buscar(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub OnClic_AniadirNueva(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub OnClic_AniadirPeticion(sender As Object, e As RoutedEventArgs)
        Dim agregarpet As New AgregarPeticion
        agregarpet.Show()

        Dim a As New Informacion
        a.Show()

    End Sub

    Private Sub OnClic_AniadirCliente(sender As Object, e As RoutedEventArgs)
        Dim agregarcli As New AgregarCliente
        agregarcli.Show()
    End Sub
End Class