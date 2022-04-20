Imports System.Text.RegularExpressions

Public Class AgregarCliente

    Public Sub Seleccion()
        If cbTipo.SelectedIndex = 2 Then
            TxbloxInfoApellidos.IsEnabled = False
            dpFecha.IsEnabled = False
        Else
            TxbloxInfoApellidos.IsEnabled = True
            dpFecha.IsEnabled = True
        End If
    End Sub

    ' 
    Private Sub OnClic_Aniadir(sender As Object, e As RoutedEventArgs)
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
            Dim mensaje As String = "¡Hay campos vacios!"
            Dim titulo As String = "Morosity"
            Dim style As MsgBoxStyle = MsgBoxStyle.Exclamation
            Dim response As Integer = MsgBox(mensaje, style, titulo)
        Else
            If valdni Or valnie Or valcif Then
                If ValidacionEmail(TxbloxInfoEmail.Text) Then
                    If ComprobacionTelefono(TxbloxInfotlf.Text) Or ComprobacionMovil(TxbloxInfoMovil.Text) Then
                        Dim mensaje As String = "todo OK!!"
                        Dim style As MsgBoxStyle = MsgBoxStyle.Exclamation
                        Dim response As Integer = MsgBox(mensaje, style)

                    End If
                End If
            End If
        End If
        'Añadir datos a la base de datos



    End Sub

    Private Sub OnClic_Cancelar(sender As Object, e As RoutedEventArgs)
        Close()
    End Sub
    Private Function ValidacionDNI(ByVal Documento As String) As Boolean

        If Regex.IsMatch(Documento.ToUpper(), "[0-9]{8}[TRWAGMYFPDXBNJZSQVHLCKE]{1}") Then
            TxblocInfoNIF.Foreground = Brushes.Black
            Return True
        Else
            TxblocInfoNIF.Foreground = Brushes.Red
            Return False
        End If

    End Function

    Private Function ValidacionNIE(ByVal Documento As String) As Boolean

        If Regex.IsMatch(Documento.ToUpper(), "[XYZ]{1}[0-9]{7}[TRWAGMYFPDXBNJZSQVHLCKE]{1}") Then
            TxblocInfoNIF.Foreground = Brushes.Black
            Return True
        Else
            TxblocInfoNIF.Foreground = Brushes.Red
            Return False
        End If

    End Function

    Private Function ValidacionCIF(ByVal Documento As String) As Boolean

        If Regex.IsMatch(Documento.ToUpper(), "[ABCDEFGHJKLMNPQRSUVW]{1}[0-9]{8}") Then
            TxblocInfoNIF.Foreground = Brushes.Black
            Return True
        Else
            TxblocInfoNIF.Foreground = Brushes.Red
            Return False
        End If

    End Function

    Private Function ValidacionEmail(ByVal Email As String) As Boolean

        If Regex.IsMatch(Email, "[\w._%+-]+@[\w.-]+\.[a-zA-Z]{2,4}") Then
            TxbloxInfoEmail.Foreground = Brushes.Black
            Return True
        Else
            TxbloxInfoEmail.Foreground = Brushes.Red
            Return False
        End If
    End Function

    Private Function ComprobacionTelefono(ByVal tlf As String) As Boolean

        If Regex.IsMatch(tlf, "[0-9]{9}") Then
            TxbloxInfotlf.Foreground = Brushes.Black
            Return True
        Else
            TxbloxInfotlf.Foreground = Brushes.Red
            Return False
        End If
    End Function

    Private Function ComprobacionMovil(ByVal tlfM As String) As Boolean

        If Regex.IsMatch(tlfM, "[0-9]{9}") Then
            TxbloxInfoMovil.Foreground = Brushes.Black
            Return True
        Else
            TxbloxInfoMovil.Foreground = Brushes.Red
            Return False
        End If
    End Function

End Class