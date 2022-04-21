Imports System
Imports System.Windows
Imports Serilog

Public Class Inicio

    Public Sub New()
        InitializeComponent()
        Log.Logger = New LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("C:\Users\SabrinaGP\Desktop\logSeqMorosity.log").CreateLogger
        Log.Information("")
        Log.Information("Inicio programa.")
        Log.Information("Inicio ventana inicio.")
    End Sub

    Private Sub OnClic_Principal(sender As Object, e As RoutedEventArgs)

        Log.Information("Conexion base de datos.")
        Log.Information("Usuario correcto.")
        Dim peticiones As New Peticiones
        peticiones.Show()
        Me.Close()
        Log.Information("Cierre ventana inicio.")
    End Sub


End Class