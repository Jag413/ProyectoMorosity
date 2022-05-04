Imports System.Text.RegularExpressions
Imports Serilog
Imports Serilog.Events

Public Class AgregarCliente
    Dim ctx As New DAL1StSharp.DAL1stContext

    Public Sub New()

        InitializeComponent()

        Log.Logger = New LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("C:\Users\SabrinaGP\Desktop\logSeqMorosity.log").CreateLogger
        Log.Information("Inicio ventana AgregarCliente.")

    End Sub

    Private Sub OnClic_Aniadir(sender As Object, e As RoutedEventArgs)
        Log.Information("Inicio proceso añadir cliente nuevo.")

        Dim valdni = False
        Dim valnie = False
        Dim valcif = False
        If cbTipo.SelectedIndex = 0 Then
            valdni = Helper.ValidacionDNI(tbdocumento.Text)
        ElseIf cbTipo.SelectedIndex = 1 Then
            valnie = Helper.ValidacionNIE(tbdocumento.Text)
        ElseIf cbTipo.SelectedIndex = 2 Then
            valcif = Helper.ValidacionCIF(tbdocumento.Text)
        End If

        If tbdocumento.Text = "" Or TxboxInfoNombre.Text = "" Or TxbloxInfoApellidos.Text = "" Or TxbloxInfoMovil.Text = "" Or
            TxbloxInfoDireccion.Text = "" Or TxbloxInfoCP.Text = "" Or TxbloxInfoCiudad.Text = "" Or TxbloxInfoProvincia.Text = "" Or
            TxbloxInfoNacionalidad.Text = "" Or TxbloxInfoEmail.Text = "" Then
            Log.Error("Campos vacios.")
            Dim mensaje As String = "¡Hay campos vacios!"
            Dim titulo As String = "Morosity"
            Dim style As MsgBoxStyle = MsgBoxStyle.Information
            Dim response As Integer = MsgBox(mensaje, style, titulo)
        Else
            If valdni Or valnie Or valcif Then
                TxblocInfoNIF.Foreground = Brushes.Black
                If Helper.ValidacionEmail(TxbloxInfoEmail.Text) Then
                    TxbloxInfoEmail.Foreground = Brushes.Black
                    If Helper.ComprobacionTelefono(TxbloxInfotlf.Text) Then
                        TxbloxInfotlf.Foreground = Brushes.Black
                        If Helper.ComprobacionMovil(TxbloxInfoMovil.Text) Then
                            TxbloxInfoMovil.Foreground = Brushes.Black

                            'Insertar en la base de datos


                            Log.Information("Cliente añadido con exito.")
                            Dim mensaje As String = "¡Cliente Añadido!"
                            Dim style As MsgBoxStyle = MsgBoxStyle.Exclamation
                            Dim response As Integer = MsgBox(mensaje, style)

                            ctx.Clientes.Add(New DAL1StSharp.Modelos.Cliente)



                            limpiar()
                        Else
                            TxbloxInfoMovil.Foreground = Brushes.Red
                        End If
                    Else
                        TxbloxInfotlf.Foreground = Brushes.Red
                    End If
                Else
                    TxbloxInfoEmail.Foreground = Brushes.Red
                End If
            Else
                TxblocInfoNIF.Foreground = Brushes.Red
            End If
        End If


        'Añadir datos a la base de datos

    End Sub

    Private Sub OnClic_Cancelar(sender As Object, e As RoutedEventArgs)
        Close()
        Log.Information("Cerrar ventana AgregarCliente.")
    End Sub

    Private Sub limpiar()
        Log.Information("Limpiar campos.")
        tbdocumento.Clear()
        TxblocInfoNIF.Foreground = Brushes.Black
        TxboxInfoNombre.Clear()
        TxbloxInfoApellidos.Clear()
        TxbloxInfotlf.Clear()
        TxbloxInfotlf.Foreground = Brushes.Black
        TxbloxInfoMovil.Clear()
        TxbloxInfoMovil.Foreground = Brushes.Black
        TxbloxInfoDireccion.Clear()
        TxbloxInfoCP.Clear()
        TxbloxInfoCiudad.Clear()
        TxbloxInfoProvincia.Clear()
        TxbloxInfoNacionalidad.Clear()
        TxbloxInfoEmail.Clear()
        TxbloxInfoEmail.Foreground = Brushes.Black
        dpFecha.Text = ""
    End Sub

    Private Sub Seleccion()
        Log.Information("Seleccion de cif para bloquear campos")
        If cbTipo.SelectedIndex = 2 Then
            Log.Information("Campos apellidos y fecha nacimiento bloqueados")
            TxbloxInfoApellidos.IsEnabled = False
            dpFecha.IsEnabled = False
            TxblocInfoApellidos.Foreground = Brushes.Gray
            TxblocInfoFechaNac.Foreground = Brushes.Gray
        Else
            Log.Information("Campos apellidos y fecha nacimiento desbloqueados")
            TxbloxInfoApellidos.IsEnabled = True
            dpFecha.IsEnabled = True
            TxblocInfoApellidos.Foreground = Brushes.Black
            TxblocInfoFechaNac.Foreground = Brushes.Black
        End If
    End Sub




End Class