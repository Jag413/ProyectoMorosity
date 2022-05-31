
Imports Serilog
Imports DAL1StSharp.Modelos

Public Class AgregarCliente
    Dim ctx As New DAL1StSharp.DAL1stContext
    Dim numUsuario As Integer

    Public Sub New()

        InitializeComponent()
        numUsuario = Configuracion.usuariologeado

    End Sub

    Private Sub OnClic_Aniadir(sender As Object, e As RoutedEventArgs)
        Log.Information("Inicio proceso añadir cliente nuevo.")
        Dim agregar = False
        Dim validacion = False
        If cbTipo.SelectedIndex = 0 Then
            validacion = Helper.ValidacionDNI(tbdocumento.Text)
        ElseIf cbTipo.SelectedIndex = 1 Then
            validacion = Helper.ValidacionNIE(tbdocumento.Text)
        ElseIf cbTipo.SelectedIndex = 2 Then
            validacion = Helper.ValidacionCIF(tbdocumento.Text)
        End If

        If cbTipo.SelectedIndex = 2 Then
            TxbloxInfoApellidos.Text = "  "
        End If
        Try
            If cbTipo.SelectedIndex = 0 Or cbTipo.SelectedIndex = 1 Then
                If tbdocumento.Text = "" Or TxboxInfoNombre.Text = "" Or TxbloxInfoApellidos.Text = "" Or TxbloxInfoMovil.Text = "" Or
                TxbloxInfoDireccion.Text = "" Or TxbloxInfoCP.Text = "" Or TxbloxInfoCiudad.Text = "" Or TxbloxInfoProvincia.Text = "" Or
                TxbloxInfoNacionalidad.Text = "" Or TxbloxInfoEmail.Text = "" Or dpFecha.Text = "" Then
                    Dim mensaje As String = "¡Hay campos obligatorios vacios!"
                    Dim titulo As String = "Morosity"
                    Dim style As MsgBoxStyle = MsgBoxStyle.Information
                    Dim response As Integer = MsgBox(mensaje, style, titulo)
                    agregar = False
                Else
                    agregar = True
                End If
            Else
                If tbdocumento.Text = "" Or TxboxInfoNombre.Text = "" Or TxbloxInfoApellidos.Text = "" Or TxbloxInfoMovil.Text = "" Or
                TxbloxInfoDireccion.Text = "" Or TxbloxInfoCP.Text = "" Or TxbloxInfoCiudad.Text = "" Or TxbloxInfoProvincia.Text = "" Or
                TxbloxInfoNacionalidad.Text = "" Or TxbloxInfoEmail.Text = "" Then
                    Dim mensaje As String = "¡Hay campos obligatorios vacios!"
                    Dim titulo As String = "Morosity"
                    Dim style As MsgBoxStyle = MsgBoxStyle.Information
                    Dim response As Integer = MsgBox(mensaje, style, titulo)
                    agregar = False
                Else
                    agregar = True
                End If
            End If

            If agregar Then

                If validacion And Helper.ValidacionEmail(TxbloxInfoEmail.Text) And Helper.ComprobacionTelefono(TxbloxInfotlf.Text) _
                                And Helper.ComprobacionMovil(TxbloxInfoMovil.Text) And Helper.ComprobacionCP(TxbloxInfoCP.Text) Then
                    TxblocInfoNIF.Foreground = Brushes.Black
                    TxblocInfoEmail.Foreground = Brushes.Black
                    TxblocInfotlf.Foreground = Brushes.Black
                    TxblocInfoMovil.Foreground = Brushes.Black
                    TxblocInfoCP.Foreground = Brushes.Black

                    'Insertar en la base de datos
                    Dim c As New Cliente
                    c.DocumentoId = tbdocumento.Text.ToUpper
                    c.Telefono = TxbloxInfotlf.Text
                    c.Movil = TxbloxInfoMovil.Text
                    c.Direccion = TxbloxInfoDireccion.Text
                    c.CodPostal = TxbloxInfoCP.Text
                    c.Ciudad = TxbloxInfoCiudad.Text
                    c.Provincia = TxbloxInfoProvincia.Text
                    c.Nacionalidad = TxbloxInfoNacionalidad.Text
                    c.Email = TxbloxInfoEmail.Text
                    If cbTipo.SelectedIndex = 2 Then
                        c.RazonSocial = TxboxInfoNombre.Text
                        c.Apellidos = ""
                        'c.FechaNacimiento = Nullable
                    Else
                        c.Nombre = TxboxInfoNombre.Text
                        c.Apellidos = TxbloxInfoApellidos.Text
                        c.FechaNacimiento = dpFecha.Text

                    End If
                    c.IdUsuarioInsercion = numUsuario

                    Dim clientes = ctx.Clientes.ToList
                    For Each i In clientes
                        If Not i.DocumentoId.Contains(c.DocumentoId) Then
                            ctx.Clientes.Add(c)
                            ctx.SaveChanges()
                            Log.Information("Cliente añadido con exito.")
                            Dim mensaje As String = "¡Cliente Añadido!"
                            Dim title As String = "Morosity"
                            Dim style As MsgBoxStyle = MsgBoxStyle.Exclamation
                            Dim response As Integer = MsgBox(mensaje, style, title)

                            ctx.Clientes.Add(New DAL1StSharp.Modelos.Cliente)

                            limpiar()
                            Exit For
                        Else
                            Dim mensajes As String = "El DNI/NIF/NIE ya existe en la base de datos."
                            Dim titulos As String = "Morosity"
                            Dim styles As MsgBoxStyle = MsgBoxStyle.Information
                            Dim responses As Integer = MsgBox(mensajes, styles, titulos)

                            Exit For
                        End If
                    Next

                Else
                    If validacion Then
                        TxblocInfoNIF.Foreground = Brushes.Black
                    Else
                        TxblocInfoNIF.Foreground = Brushes.Red
                    End If

                    If Helper.ValidacionEmail(TxbloxInfoEmail.Text) Then
                        TxblocInfoEmail.Foreground = Brushes.Black
                    Else
                        TxblocInfoEmail.Foreground = Brushes.Red
                    End If

                    If Helper.ComprobacionTelefono(TxbloxInfotlf.Text) Then
                        TxblocInfotlf.Foreground = Brushes.Black
                    Else
                        TxblocInfotlf.Foreground = Brushes.Red
                    End If

                    If Helper.ComprobacionMovil(TxbloxInfoMovil.Text) Then
                        TxblocInfoMovil.Foreground = Brushes.Black
                    Else
                        TxblocInfoMovil.Foreground = Brushes.Red
                    End If

                    If Helper.ComprobacionCP(TxbloxInfoCP.Text) Then
                        TxblocInfoCP.Foreground = Brushes.Black
                    Else
                        TxblocInfoCP.Foreground = Brushes.Red
                    End If
                End If
            End If
        Catch ex As InvalidCastException
            Dim mensaje As String = "La fecha de nacimiento no puede contener letras, solo 00/00/0000"
            Dim title As String = "Morosity"
            Dim style As MsgBoxStyle = MsgBoxStyle.Exclamation
            Dim response As Integer = MsgBox(mensaje, style, title)
        End Try
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