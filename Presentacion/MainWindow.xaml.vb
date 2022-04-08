Class MainWindow
    Private Sub OnClick_CambiaEstado(sender As Object, e As RoutedEventArgs)
        Dim ventana As New Window1
        ventana.Show()
        Close()
    End Sub
End Class
