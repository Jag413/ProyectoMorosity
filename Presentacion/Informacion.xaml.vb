Class Informacion

    Public Sub New(id As Integer)
        InitializeComponent()
        GetDatos(id)
    End Sub
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

    Private Sub GetDatos(id As Integer)
        Dim ctx As New DAL1StSharp.DAL1stContext
        Dim consultaPet = ctx.Peticiones.ToList
        Dim consultacli = ctx.Clientes.ToList
        For Each i In consultaPet
            For Each e In consultacli
                If i.IdPeticion = id Then
                    If i.Cliente.IdCliente = e.IdCliente Then
                        TxboxInfoNIF.Text = e.DocumentoId
                    End If
                End If
            Next
        Next

    End Sub
End Class
