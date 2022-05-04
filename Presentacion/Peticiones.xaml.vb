Imports Serilog

Public Class Peticiones

    Dim ctx As New DAL1StSharp.DAL1stContext
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
            Dim id = migrid.DataContext.id
            Dim infor As New Informacion(id, Me)
            infor.Show()

        End If
    End Sub

    Private Sub OnClick_Buscar(sender As Object, e As RoutedEventArgs)
        ctx.Configuration.LazyLoadingEnabled = False
        Dim consultaPet = ctx.Peticiones.ToList

        lvPeticiones.Items.Clear()
        For Each i In consultaPet
            If i.Cliente.DocumentoId.ToUpper = TextBuscador.Text.ToUpper Then
                lvPeticiones.Items.Add(New With {.id = i.IdPeticion, .documento = i.Cliente.DocumentoId.ToUpper, .estado = i.Estado})
            End If
        Next

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
        cargar()
    End Sub

    Public Sub cargar()
        ctx = New DAL1StSharp.DAL1stContext
        Dim consultaPet = Nothing
        Dim consultacli = Nothing
        consultaPet = ctx.Peticiones.ToList
        consultacli = ctx.Clientes.ToList

        lvPeticiones.Items.Clear()
        For Each i In consultaPet
            For Each e In consultacli
                If i.Cliente.IdCliente = e.IdCliente Then
                    lvPeticiones.Items.Add(New With {.id = i.IdPeticion, .documento = e.DocumentoId.ToUpper, .estado = i.Estado})
                End If
            Next


        Next

    End Sub
End Class