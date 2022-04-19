Class Informacion
    Private Sub OnClick_CambiaEstado(sender As Object, e As RoutedEventArgs)
        Dim ventana As New Peticiones
        ventana.Show()
        Close()
    End Sub

    Private Sub OnClick_Salir(sender As Object, e As RoutedEventArgs)

    End Sub
End Class
