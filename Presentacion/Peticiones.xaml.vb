Imports Serilog

Public Class Peticiones


    Public Sub New()
        InitializeComponent()
        Log.Logger = New LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("C:\Users\SabrinaGP\Desktop\logSeqMorosity.log").CreateLogger
        Log.Information("Inicio ventana peticiones.")
        cargar()

    End Sub

    Private Sub PantallaInformacion(sender As Object, e As RoutedEventArgs)

        Dim migrid As ListViewItem = sender


        If lvPeticiones.Items.IsEmpty Then
        Else
            Dim dni = migrid.DataContext.documento
            Dim infor As New Informacion(dni)
            infor.Show()

        End If
    End Sub

    Private Sub OnClick_Buscar(sender As Object, e As RoutedEventArgs)
        Log.Information("Busca peticion concreta")
    End Sub

    Private Sub OnClic_AniadirPeticion(sender As Object, e As RoutedEventArgs)
        Log.Information("llama a añadir peticion nueva")
        Dim agregarpet As New AgregarPeticion
        agregarpet.Show()
        'OPCION -> QUE SE RECARGUE SOLAS LAS PETICIONES
    End Sub

    Private Sub OnClic_AniadirCliente(sender As Object, e As RoutedEventArgs)
        Log.Information("llama a ventana añadir cliente")
        Dim agregarcli As New AgregarCliente
        agregarcli.Show()
    End Sub

    Private Sub OnClick_Recargar(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub cargar()

        Dim ctx As New DAL1StSharp.DAL1stContext
        Dim consultaPet = ctx.Peticiones.ToList
        Dim consultacli = ctx.Clientes.ToList


        For Each i In consultaPet
            For Each e In consultacli
                If i.Cliente.IdCliente = e.IdCliente Then
                    lvPeticiones.Items.Add(New With {.id = i.IdPeticion, .documento = e.DocumentoId, .estado = i.Estado})
                End If
            Next


        Next

    End Sub
End Class