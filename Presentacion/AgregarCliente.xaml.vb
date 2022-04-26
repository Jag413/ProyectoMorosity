Imports System.Text.RegularExpressions
Imports Serilog
Imports Serilog.Events

Public Class AgregarCliente

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
            valdni = ValidacionDNI(tbdocumento.Text)
        ElseIf cbTipo.SelectedIndex = 1 Then
            valnie = ValidacionNIE(tbdocumento.Text)
        ElseIf cbTipo.SelectedIndex = 2 Then
            valcif = ValidacionCIF(tbdocumento.Text)
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
                If ValidacionEmail(TxbloxInfoEmail.Text) Then
                    If ComprobacionTelefono(TxbloxInfotlf.Text) Or ComprobacionMovil(TxbloxInfoMovil.Text) Then
                        Log.Information("Cliente añadido con exito.")
                        Dim mensaje As String = "¡Cliente Añadido!"
                        Dim style As MsgBoxStyle = MsgBoxStyle.Exclamation
                        Dim response As Integer = MsgBox(mensaje, style)
                        limpiar()
                    End If
                End If
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
            TxblocInfoApellidos.IsEnabled = False
            TxblocInfoFechaNac.IsEnabled = False
        Else
            Log.Information("Campos apellidos y fecha nacimiento desbloqueados")
            TxbloxInfoApellidos.IsEnabled = True
            dpFecha.IsEnabled = True
            TxblocInfoApellidos.IsEnabled = True
            TxblocInfoFechaNac.IsEnabled = True
        End If
    End Sub

    Private Function ValidacionDNI(ByVal Documento As String) As Boolean
        Log.Information("Proceso validacion dni")
        If Regex.IsMatch(Documento.ToUpper(), "[0-9]{8}[TRWAGMYFPDXBNJZSQVHLCKE]{1}") Then
            Log.Information("dni correcto")
            TxblocInfoNIF.Foreground = Brushes.Black
            Return True
        Else
            Log.Error("Dni incorrecto")
            TxblocInfoNIF.Foreground = Brushes.Red
            Return False
        End If

    End Function

    Private Function ValidacionNIE(ByVal Documento As String) As Boolean
        Log.Information("Proceso validacion nie")
        If Regex.IsMatch(Documento.ToUpper(), "[XYZ]{1}[0-9]{7}[TRWAGMYFPDXBNJZSQVHLCKE]{1}") Then
            Log.Information("nie correcto")
            TxblocInfoNIF.Foreground = Brushes.Black
            Return True
        Else
            Log.Error("nie incorrecto")
            TxblocInfoNIF.Foreground = Brushes.Red
            Return False
        End If

    End Function

    Private Function ValidacionCIF(ByVal Documento As String) As Boolean
        Log.Information("Proceso validacion cif")
        If Regex.IsMatch(Documento.ToUpper(), "[ABCDEFGHJKLMNPQRSUVW]{1}[0-9]{8}") Then
            Log.Information("cif correcto")
            TxblocInfoNIF.Foreground = Brushes.Black
            Return True
        Else
            Log.Error("cif incorrecto")
            TxblocInfoNIF.Foreground = Brushes.Red
            Return False
        End If

    End Function

    Private Function ValidacionEmail(ByVal Email As String) As Boolean
        Log.Information("Proceso validacion email")
        If Regex.IsMatch(Email, "[\w._%+-]+@[\w.-]+\.[a-zA-Z]{2,4}") Then
            Log.Information("email correcto")
            TxbloxInfoEmail.Foreground = Brushes.Black
            Return True
        Else
            Log.Error("email incorrecto")
            TxbloxInfoEmail.Foreground = Brushes.Red
            Return False
        End If
    End Function

    Private Function ComprobacionTelefono(ByVal tlf As String) As Boolean
        Log.Information("proceso comprobacion telefono")
        If Regex.IsMatch(tlf, "[0-9]{9}") Then
            Log.Information("telefono correcto")
            TxbloxInfotlf.Foreground = Brushes.Black
            Return True
        Else
            Log.Error("telefono incorrecto")
            TxbloxInfotlf.Foreground = Brushes.Red
            Return False
        End If
    End Function

    Private Function ComprobacionMovil(ByVal tlfM As String) As Boolean
        Log.Information("Proceso comprovacion movil")
        If Regex.IsMatch(tlfM, "[0-9]{9}") Then
            Log.Information("movil correcto")
            TxbloxInfoMovil.Foreground = Brushes.Black
            Return True
        Else
            Log.Error("movil incorrecto")
            TxbloxInfoMovil.Foreground = Brushes.Red
            Return False
        End If
    End Function

End Class