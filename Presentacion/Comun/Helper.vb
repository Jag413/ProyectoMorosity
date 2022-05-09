Imports System.Text
Imports System.Text.RegularExpressions

Public Class Helper

    Public Shared Function ValidacionDNI(ByVal documento As String) As Boolean

        If Regex.IsMatch(documento.ToUpper(), "[0-9]{8}[TRWAGMYFPDXBNJZSQVHLCKE]{1}") Then
            Dim l = documento.ToUpper.LastOrDefault.ToString
            Dim n = Mid(documento, 1, 8)
            Dim num = Integer.Parse(n) Mod 23
            If letra(num).Equals(l) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function

    Public Shared Function ValidacionNIE(ByVal Documento As String) As Boolean
        'Ejemplo nie -> y1235467x

        If Regex.IsMatch(Documento.ToUpper(), "[XYZ]{1}[0-9]{7}[TRWAGMYFPDXBNJZSQVHLCKE]{1}") Then
            Dim l2 = Documento.ToUpper.LastOrDefault.ToString
            Dim l1 = Documento.ToUpper.First.ToString
            Dim n = Mid(Documento, 2, 7)
            Dim nl
            If l1 = "X" Then
                nl = 0
            ElseIf l1 = "Y" Then
                nl = 1
            Else
                nl = 2
            End If
            Dim numS = String.Concat(nl, n)
            Dim num = Integer.Parse(numS) Mod 23
            If letra(num).Equals(l2) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function

    Public Shared Function ValidacionCIF(ByVal valor As String) As Boolean
        'Ejemplo cif -> x1234567l

        Dim strLetra As String, strNumero As String, strDigit As String
        Dim strDigitAux As String
        Dim auxNum As Integer
        Dim i As Integer
        Dim suma As Integer
        Dim letras As String

        letras = "ABCDEFGHKLMPQSX"

        valor = UCase(valor)

        If Len(valor) < 9 OrElse Not IsNumeric(Mid(valor, 2, 7)) Then
            Return False
        End If

        strLetra = Mid(valor, 1, 1)     ' letra del CIF
        strNumero = Mid(valor, 2, 7)    ' Codigo de Control
        strDigit = Mid(valor, 9)        ' CIF menos primera y ultima posiciones

        If InStr(letras, strLetra) = 0 Then ' comprobamos la letra del CIF (1ª posicion)
            Return False
        End If

        For i = 1 To 7
            If i Mod 2 = 0 Then
                suma = suma + CInt(Mid(strNumero, i, 1))
            Else
                auxNum = CInt(Mid(strNumero, i, 1)) * 2
                suma = suma + (auxNum \ 10) + (auxNum Mod 10)
            End If
        Next

        suma = (10 - (suma Mod 10)) Mod 10

        Select Case strLetra
            Case "K", "P", "Q", "S"
                suma = suma + 64
                strDigitAux = Chr(suma)
            Case "X"
                strDigitAux = Mid(CalculaNIF(strNumero), 8, 1)
            Case Else
                strDigitAux = CStr(suma)
        End Select

        If strDigit = strDigitAux Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Shared Function CalculaNIF(ByVal strA As String) As String
        Const cCADENA As String = "TRWAGMYFPDXBNJZSQVHLCKE"
        Const cNUMEROS As String = "0123456789"
        Dim a, b, c, NIF As Integer
        Dim sb As New StringBuilder

        strA = Trim(strA)
        If Len(strA) = 0 Then Return ""

        ' Dejar sólo los números
        For i As Integer = 0 To strA.Length - 1
            If cNUMEROS.IndexOf(strA(i)) > -1 Then
                sb.Append(strA(i))
            End If
        Next

        strA = sb.ToString
        a = 0
        NIF = CInt(Val(strA))
        Do
            b = CInt(Int(NIF / 24))
            c = NIF - (24 * b)
            a = a + c
            NIF = b
        Loop While b <> 0
        b = CInt(Int(a / 23))
        c = a - (23 * b)

        Return strA & Mid(cCADENA, CInt(c + 1), 1)
    End Function

    Public Shared Function letra(ByVal num As Integer) As String
        Dim _letra As String
        _letra = ""
        Select Case (num)
            Case 0
                _letra = "T"
            Case 1
                _letra = "R"
            Case 2
                _letra = "W"
            Case 3
                _letra = "A"
            Case 4
                _letra = "G"
            Case 5
                _letra = "M"
            Case 6
                _letra = "Y"
            Case 7
                _letra = "F"
            Case 8
                _letra = "P"
            Case 9
                _letra = "D"
            Case 10
                _letra = "X"
            Case 11
                _letra = "B"
            Case 12
                _letra = "N"
            Case 13
                _letra = "J"
            Case 14
                _letra = "Z"
            Case 15
                _letra = "S"
            Case 16
                _letra = "Q"
            Case 17
                _letra = "V"
            Case 18
                _letra = "H"
            Case 19
                _letra = "L"
            Case 20
                _letra = "C"
            Case 21
                _letra = "K"
            Case 22
                _letra = "E"

        End Select
        Return _letra
    End Function



    Public Shared Function ValidacionEmail(ByVal Email As String) As Boolean
        If Regex.IsMatch(Email, "[\w._%+-]+@[\w.-]+\.[a-zA-Z]{2,4}") Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function ComprobacionTelefono(ByVal tlf As String) As Boolean
        If Regex.IsMatch(tlf, "[0-9]{9}") Then
            Dim l = tlf.First.ToString
            If l = "9" Or l = "8" Then
                Return True
            Else
                Return False
            End If

        Else
            Return False
        End If
    End Function

    Public Shared Function ComprobacionMovil(ByVal tlfM As String) As Boolean
        If Regex.IsMatch(tlfM, "[0-9]{9}") Then
            Dim l = tlfM.First.ToString
            If l = "6" Or l = "7" Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
End Class
