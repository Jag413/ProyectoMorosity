Imports System
Imports System.Windows

Public Class Inicio



    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub OnClic_Principal(sender As Object, e As RoutedEventArgs)
        Dim peticiones As New Peticiones
        peticiones.Show()
        Me.Close()
    End Sub


End Class