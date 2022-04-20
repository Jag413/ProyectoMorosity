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
        Dim valdni = True
        Dim valnie = False
        Dim valcif = False
        If cbTipo.SelectedIndex = 0 Then
            valdni = ValidacionDNI(tbdocumento.Text)
        ElseIf cbTipo.SelectedIndex = 1 Then
            valnie = ValidacionNIE(tbdocumento.Text)
        ElseIf cbTipo.SelectedIndex = 2 Then
            valcif = ValidacionCIF(tbdocumento.Text)
        End If

        If valdni Or valnie Or valcif Then
            Dim mensaje As String = "Prueba"
            Dim style As MsgBoxStyle = MsgBoxStyle.Information
            Dim response As Integer = MsgBox(mensaje, style)
        End If

        'Añadir datos a la base de datos



    End Sub

    Private Sub OnClic_Cancelar(sender As Object, e As RoutedEventArgs)
        Close()
    End Sub
    Public Function ValidacionDNI(ByVal Documento As String) As Boolean

        Dim validar_DNI As Regex = New Regex("/^[0-9]{8}[a-z,A-Z]{1}/i")
        If validar_DNI.IsMatch(Documento) Then
            TxblocInfoNIF.Foreground = Brushes.Black
            Return True
        Else
            TxblocInfoNIF.Foreground = Brushes.Red
            Return False
        End If

    End Function

    Public Function ValidacionNIE(ByVal Documento As String) As Boolean

        Dim validar_NIE As Regex = New Regex("/^ [XYZ][0-9]{7}[TRWAGMYFPDXBNJZSQVHLCKE]$/i")
        If validar_NIE.IsMatch(Documento) Then
            TxblocInfoNIF.Foreground = Brushes.Black
            Return True
        Else
            TxblocInfoNIF.Foreground = Brushes.Red
            Return False
        End If

    End Function

    Public Function ValidacionCIF(ByVal Documento As String) As Boolean

        Dim validar_CIF As Regex = New Regex("/^([ABCDEFGHJKLMNPQRSUVW])(\d{7})([0-9A-J])$/")
        If validar_CIF.IsMatch(Documento) Then
            TxblocInfoNIF.Foreground = Brushes.Black
            Return True
        Else
            TxblocInfoNIF.Foreground = Brushes.Red
            Return False
        End If

    End Function
End Class
