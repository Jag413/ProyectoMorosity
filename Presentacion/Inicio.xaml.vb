﻿Imports Microsoft.VisualBasic.Logging

Public Class Inicio
    'Dim wc As New WaitControl

    Public Sub New()
        InitializeComponent()
        'Logo.Children.Add(wc)
        'Traductor.TraducirIdioma(Me, If(SessionInformationDTO.UsuarioActivo(SessionInformationClientDTO.IdUsuario), New UsuarioDTO()).Culture)


    End Sub

    Private Sub OnClic_Principal(sender As Object, e As RoutedEventArgs)
        ' System.Threading.Thread.Sleep(3000)

        Dim p As New Peticiones
        p.Show()
        Close()
    End Sub

    Private Sub Inicio(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub Cargar()
        'System.Threading.Thread.Sleep(10000)
        Dim p As New Peticiones
        p.Show()
        Close()
    End Sub
End Class
