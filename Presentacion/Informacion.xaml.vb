Class Informacion
    Dim ctx As New DAL1StSharp.DAL1stContext
    Dim idd As Integer
    Dim pantallaOr As Peticiones
    Public Sub New(id As Integer)
        idd = id
        InitializeComponent()
        GetDatos(id)
    End Sub
    Public Sub New(id As Integer, pantalla As Peticiones)
        idd = id
        pantallaOr = pantalla
        InitializeComponent()
        GetDatos(id)
    End Sub
    Private Sub OnClick_CambiaEstado(sender As Object, e As RoutedEventArgs)

        'Cambiar el estado al que corresponda
        Dim mensaje As String = "¿Deseas cambiar el estado?
     Si para Aceptada, No para Denegada"
        Dim titulo As String = "Morosity"
        Dim style As MsgBoxStyle = MsgBoxStyle.YesNoCancel
        Dim response As Integer = MsgBox(mensaje, style, titulo)
        Dim mipeticion
        If response = 6 Then
            TxblocInfoEstadoActual.Text = "Aceptada"
            mipeticion = ctx.Peticiones.Where(Function(p) p.IdPeticion = idd).FirstOrDefault
            mipeticion.Estado = "Aceptada"

        ElseIf response = 7 Then
            TxblocInfoEstadoActual.Text = "Denegada"
            mipeticion = ctx.Peticiones.Where(Function(p) p.IdPeticion = idd).FirstOrDefault
            mipeticion.Estado = "Denegada"

        End If
        ctx.SaveChanges()
    End Sub

    Private Sub OnClick_Salir(sender As Object, e As RoutedEventArgs)

        Close()
    End Sub

    Private Sub OnClick_Aceptar(sender As Object, e As RoutedEventArgs)
        If TxblocInfoEstadoActual.Text = "Pendiente" Then
            Dim mensaje As String = "No se puede aceptar una peticion con estado en Pendiente"
            Dim titulo As String = "Morosity"
            Dim style As MsgBoxStyle = MsgBoxStyle.Exclamation
            Dim response As Integer = MsgBox(mensaje, style, titulo)
        Else
            Dim mensaje As String = "¿Deseas aceptar la peticion?"
            Dim titulo As String = "Morosity"
            Dim style As MsgBoxStyle = MsgBoxStyle.OkCancel
            Dim response As Integer = MsgBox(mensaje, style, titulo)
            Dim mipeticion

            If response = 1 Then
                mipeticion = ctx.Peticiones.Where(Function(p) p.IdPeticion = idd).FirstOrDefault
                mipeticion.IsOk = True
                ctx.SaveChanges()
                pantallaOr.cargar()
                Close()
            End If
        End If

        'Dim mipeticion = ctx.Peticiones.Where(Function(p) p.IdPeticion = idd).FirstOrDefault


    End Sub

    Private Sub GetDatos(id As Integer)

        Dim consultaPet = ctx.Peticiones.ToList
        Dim consultacli = ctx.Clientes.ToList
        For Each i In consultaPet
            For Each e In consultacli
                If i.IdPeticion = id Then
                    If i.Cliente.IdCliente = e.IdCliente Then
                        TxboxInfoNIF.Text = e.DocumentoId.ToUpper
                        TxboxInfoEmail.Text = e.Email
                        TxblocInfoEstadoActual.Text = i.Estado
                        If IsDBNull(e.RazonSocial) Then
                            TxboxInfoNombre.Text = e.RazonSocial
                        Else
                            TxboxInfoNombre.Text = e.Nombre + " " + e.Apellidos
                        End If
                        If Not i.IsOk Then
                            If i.Estado = "Pendiente" Then
                                TxblocInfoRazones.Text = ""
                            Else
                                TxblocInfoRazones.Text = "OK"
                            End If

                        Else
                            TxblocInfoRazones.Text = i.Razones
                        End If
                    End If
                End If
            Next
        Next

    End Sub
End Class
