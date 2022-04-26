Imports Serilog

Public Class Peticiones

    Public Sub New()
        InitializeComponent()
        Log.Logger = New LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("C:\Users\SabrinaGP\Desktop\logSeqMorosity.log").CreateLogger
        Log.Information("Inicio ventana peticiones.")
    End Sub

    Private Sub OnClick_Buscar(sender As Object, e As RoutedEventArgs)
        Log.Information("Busca peticion concreta")
    End Sub

    Private Sub OnClic_AniadirPeticion(sender As Object, e As RoutedEventArgs)
        Log.Information("llama a añadir peticion nueva")
        Dim agregarpet As New AgregarPeticion
        agregarpet.Show()

        Dim a As New Informacion
        a.Show()

    End Sub

    Private Sub OnClic_AniadirCliente(sender As Object, e As RoutedEventArgs)
        Log.Information("llama a ventana añadir cliente")
        Dim agregarcli As New AgregarCliente
        agregarcli.Show()
    End Sub

End Class