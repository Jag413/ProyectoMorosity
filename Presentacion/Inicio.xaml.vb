Imports System.Timers
Imports System.Windows.Media.Animation

Public Class Inicio
    Dim wc As New WaitControl
    Public Sub New()
        InitializeComponent()
        Logo.Children.Add(wc)


    End Sub

    Private Sub OnClic_Principal(sender As Object, e As RoutedEventArgs)
        ' System.Threading.Thread.Sleep(3000)
        '
        Dim p As New Peticiones
        p.Show()
        Close()
    End Sub
    Private Sub Inicio(sender As Object, e As RoutedEventArgs)
        Iniciar()
        For j As Integer = 1 To 10
            ' System.Threading.Thread.Sleep(1000)
        Next

        'Cargar()
    End Sub
    Private Sub Iniciar()

        WaitControl.AnimationOn = True : MainGridFondo.Visibility = Visibility.Hidden

        WaitControl.AnimationOn = False : MainGridFondo.Visibility = Visibility.Visible

        If  Then
            Cargar()
        End If

    End Sub

    Private Sub Cargar()

        Dim p As New Peticiones
        p.Show()
        Close()
    End Sub
End Class
