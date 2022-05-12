Imports System
Imports System.Windows
Imports Serilog
Public Class Inicio
    'Friend conexion As MySqlConnection
    Dim usuarioCorrecto As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub OnClic_Principal(sender As Object, e As RoutedEventArgs)
        Dim ctx As New DAL1StSharp.DAL1stContext
        Try
            Dim usuarios = ctx.Usuarios.ToList
            For Each i In usuarios
                If i.NumUsuario = tbUsuario.Text And i.Password = tbContrasena.Password Then
                    Configuracion.usuariologeado = i.NumUsuario
                    Dim peticiones As New Peticiones()
                    peticiones.Show()
                    Me.Close()
                    usuarioCorrecto = False
                    Exit For
                ElseIf i.NumUsuario = tbUsuario.Text And Not i.Password = tbContrasena.Password Then
                    Dim mensaje As String = "Contraseña incorrecta"
                    Dim titulo As String = "Morosity"
                    Dim style As MsgBoxStyle = MsgBoxStyle.Information
                    Dim response As Integer = MsgBox(mensaje, style, titulo)
                    tbContrasena.Password = ""
                    usuarioCorrecto = False
                    Exit For

                Else
                    usuarioCorrecto = True
                End If
            Next

            If usuarioCorrecto Then
                Dim mensaje As String = "Usuario erroneo o no existe en la base de datos"
                Dim titulo As String = "Morosity"
                Dim style As MsgBoxStyle = MsgBoxStyle.Information
                Dim response As Integer = MsgBox(mensaje, style, titulo)
                tbUsuario.Text = ""
                tbContrasena.Password = ""


            End If



        Catch ex As InvalidCastException
            If tbUsuario.Text = "" And tbContrasena.Password = "" Or tbUsuario.Text = "" Then
                Dim mensaje As String = "Hay campos vacios"
                Dim titulo As String = "Morosity"
                Dim style As MsgBoxStyle = MsgBoxStyle.Information
                Dim response As Integer = MsgBox(mensaje, style, titulo)
            Else
                Dim mensaje As String = "¡Introduce solo numeros!"
                Dim titulo As String = "Morosity"
                Dim style As MsgBoxStyle = MsgBoxStyle.Exclamation
                Dim response As Integer = MsgBox(mensaje, style, titulo)
                tbUsuario.Text = ""
                tbContrasena.Password = ""
            End If
        End Try
    End Sub
End Class