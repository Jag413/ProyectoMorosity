Imports Serilog

Public Class Peticiones

    Dim ctx As New DAL1StSharp.DAL1stContext
    'Dim numUsuario As Integer
    Public Sub New()
        InitializeComponent()
        Log.Logger = New LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("C:\Users\SabrinaGP\Desktop\logSeqMorosity.log").CreateLogger
        Log.Information("Inicio ventana peticiones.")
        cargar()
        'numUsuario = Configuracion.usuariologeado
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
        Dim consultaPet = ctx.Peticiones.Include("Cliente").ToList
        lvPeticiones.Items.Clear()
        For Each i In consultaPet
            If i.Cliente.DocumentoId.ToUpper = TextBuscador.Text.ToUpper Or i.IdPeticion.ToString = TextBuscador.Text Then
                lvPeticiones.Items.Add(New With {.id = i.IdPeticion, .documento = i.Cliente.DocumentoId.ToUpper, .estado = i.Estado})
            End If
        Next
        TextBuscador.Text = ""

    End Sub

    Private Sub OnClic_AniadirPeticion(sender As Object, e As RoutedEventArgs)
        Log.Information("llama a añadir peticion nueva")
        Dim agregarpet As New AgregarPeticion(Me)
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
        Dim consultaPet = ctx.Peticiones.Include("Cliente").Where(Function(x) Not x.IsOk).ToList

        lvPeticiones.Items.Clear()
        For Each i In consultaPet
            lvPeticiones.Items.Add(New With {.id = i.IdPeticion, .documento = i.Cliente.DocumentoId.ToUpper, .estado = i.Estado})
        Next

    End Sub
End Class