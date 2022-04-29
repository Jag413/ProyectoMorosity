Class Informacion
    Private Sub OnClick_CambiaEstado(sender As Object, e As RoutedEventArgs)
        'Cambiar el estado al que corresponda
        Dim ventana As New Peticiones
        ventana.Show()
        Close()
    End Sub

    Private Sub OnClick_Salir(sender As Object, e As RoutedEventArgs)
        Close()
    End Sub

    Private Sub OnClick_Aceptar(sender As Object, e As RoutedEventArgs)

    End Sub
End Class
