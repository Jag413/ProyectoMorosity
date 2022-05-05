

Imports System.Net
Imports System.Net.WebException
Imports System.Text
Imports System.Text.RegularExpressions
Imports DAL1StSharp.Modelos
Imports Newtonsoft.Json

Public Class AgregarPeticion
    Dim pant As Peticiones
    Dim numUsuario As Integer
    Dim ctx As New DAL1StSharp.DAL1stContext
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(pantalla As Peticiones)
        InitializeComponent()
        pant = pantalla
        numUsuario = Configuracion.usuariologeado
    End Sub

    Private Async Sub OnClic_Enviar(sender As Object, e As RoutedEventArgs)
        Try
            Dim valdni = False
            Dim valnie = False
            Dim valcif = False
            If cbTipo.SelectedIndex = 0 Then
                valdni = Helper.ValidacionDNI(tbDni.Text)
            ElseIf cbTipo.SelectedIndex = 1 Then
                valnie = Helper.ValidacionNIE(tbDni.Text)
            ElseIf cbTipo.SelectedIndex = 2 Then
                valcif = Helper.ValidacionCIF(tbDni.Text)
            End If

            If cbTipo.SelectedIndex = -1 Or tbDni.Text = "" Then
                Dim mensaje As String = "¡Hay campos vacios!"
                Dim titulo As String = "Morosity"
                Dim style As MsgBoxStyle = MsgBoxStyle.Information
                Dim response As Integer = MsgBox(mensaje, style, titulo)
            Else
                If valdni Or valnie Or valcif Then
                    Dim c As New PersonaScoringBase
                    c.tipo = cbTipo.Text
                    c.documento = tbDni.Text
                    Dim resturl As String = "https://localhost:44371/Equifax/GetDatta"
                    Dim client As New Http.HttpClient
                    Dim jsondata As String = JsonConvert.SerializeObject(c)
                    Dim restcontent As New Http.StringContent(jsondata, Encoding.UTF8, "application/json")
                    Dim restresponse As Http.HttpResponseMessage = Await client.PostAsync(resturl, restcontent)
                    Dim a As New Peticion
                    a.Cliente = ctx.Clientes.Where(Function(p) p.DocumentoId = tbDni.Text).FirstOrDefault
                    a.Estado = "Pendiente"
                    a.IdUsuarioInsercion = numUsuario
                    'a.FechaInsercion = Date.Today
                    ctx.Peticiones.Add(a)
                    ctx.SaveChanges()

                    If restresponse.IsSuccessStatusCode Then
                        Dim mensaje As String = "¡Peticion enviada corecctamente!"
                        Dim titulo As String = "Morosity"
                        Dim style As MsgBoxStyle = MsgBoxStyle.Information
                        Dim response As Integer = MsgBox(mensaje, style, titulo)
                    End If
                    pant.cargar()
                    Close()
                Else
                    Dim titulo As String = "¡ERROR!"
                    Dim mensaje As String = String.Format("¡{0} no valido!", cbTipo.Text)
                    Dim style As MsgBoxStyle = MsgBoxStyle.Exclamation
                    Dim response As Integer = MsgBox(mensaje, style, titulo)
                    tbDni.Clear()
                End If
            End If

        Catch ex As Exception
            Dim titulo As String = "¡ERROR!"
            Dim mensaje As String = "No es posible conectar con el servidor remoto."
            Dim style As MsgBoxStyle = MsgBoxStyle.Exclamation
            Dim response As Integer = MsgBox(mensaje, style, titulo)
            Close()
        End Try


    End Sub

End Class

Public Class PersonaScoringBase

    Public tipo As String
    Public documento As String

    Public Sub New()
        tipo = ""
        documento = ""
    End Sub

End Class