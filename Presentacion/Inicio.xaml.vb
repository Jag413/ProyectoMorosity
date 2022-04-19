Imports System
Imports System.Windows

Public Class Inicio
    Dim peticiones As New Peticiones


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub OnClic_Principal(sender As Object, e As RoutedEventArgs)
        peticiones.Show()
        Close()
    End Sub
End Class