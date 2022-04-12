Class Informacion
    Private Sub OnClick_CambiaEstado(sender As Object, e As RoutedEventArgs)
        Dim ventana As New Peticiones
        ventana.Show()
        Close()
    End Sub
End Class
