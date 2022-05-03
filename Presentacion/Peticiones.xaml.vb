Imports Serilog

Public Class Peticiones

    Public Sub New()
        InitializeComponent()
        Log.Logger = New LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("C:\Users\SabrinaGP\Desktop\logSeqMorosity.log").CreateLogger
        Log.Information("Inicio ventana peticiones.")

    End Sub

    Private Sub PantallaInformacion(sender As Object, e As RoutedEventArgs)
        'Dim item As ListViewItem
        If lvPeticiones.Items.IsEmpty Then
        Else
            For i = 0 To lvPeticiones.SelectedItems.Count
                Dim dni = Me.lvPeticiones.Items.Item(i).ToString



                Dim infor As New Informacion(dni)
                infor.Show()
            Next

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

        For i = 1 To 2

            lvPeticiones.Items.Add(New With {.id = i, .documento = i, .estado = i})

        Next
        'StrSql = "select * from colores order by DescripcionColor"

        'Dim DatareaderSQL As SqlDataReader = Conexion.EjecutaDataReaderSQL(StrSql)

        'If DatareaderSQL.HasRows Then

        '    While DatareaderSQL.Read

        '        If Not IsDBNull(DatareaderSQL.Item("IDColor")) Then

        '            Dim Codex As String = Trim(DatareaderSQL.Item("IDColor"))

        '            Dim Descrip As String = Trim(DatareaderSQL.Item("DescripcionColor"))

        '            ListView1.Items.Add(New With {.codigo = Codex.Trim, .descrip = Descrip.Trim})

        '        End If

        '    End While

        'End If
    End Sub
End Class