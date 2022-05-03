Imports Serilog

Public Class Peticiones


    Public Sub New()
        InitializeComponent()
        Log.Logger = New LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("C:\Users\SabrinaGP\Desktop\logSeqMorosity.log").CreateLogger
        Log.Information("Inicio ventana peticiones.")
        cargar()

    End Sub

    Private Sub PantallaInformacion(sender As Object, e As RoutedEventArgs)
        'Dim item As ListViewItem
        Dim migrid As ListViewItem = sender


        If lvPeticiones.Items.IsEmpty Then
        Else
            'With lvPeticiones
            Dim linea = lvPeticiones.SelectedItems(0).SubItems(1).Text
            Dim d = lvPeticiones.Items.Item(linea).id
            Dim dni = lvPeticiones.Items.Item(linea).documento

            Dim infor As New Informacion(dni)
            infor.Show()
            'End With
            'For i = 0 To lvPeticiones.Items.Count
            '    If lvPeticiones.Items.Item(i).id = migrid.Content("Id") Then
            '        Dim dni = lvPeticiones.Items.Item(i).documento

            '        Dim infor As New Informacion(dni)
            '        infor.Show()
            '    End If

            'Next
            'If Me.lvPeticiones.Items.Item(itm).id = i Then
            '    Dim dni = Me.lvPeticiones.Items.Item(i).documento
            '    Dim infor As New Informacion(dni)
            '    infor.Show()
            'End If

            ' Next

            'Dim info = lvPeticiones.SelectedItems
            'Dim dni As String

            'For i = 1 To lvPeticiones.Items.Count

            '    dni = lvPeticiones.Items(lvPeticiones.SelectedIndex)
            '    Dim infor As New Informacion(dni)
            '    infor.Show()
            'Next

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
        Dim consulta = ctx.Peticiones.ToList
        lvPeticiones.DataContext = ctx.Clientes

        For Each i In consulta
            lvPeticiones.Items.Add(i)

        Next

    End Sub
End Class