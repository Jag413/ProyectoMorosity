Imports System
Imports System.Windows
Imports Serilog
Imports MySql.Data.MySqlClient
Public Class Inicio
    'Friend conexion As MySqlConnection
    Public Sub New()
        InitializeComponent()
        Log.Logger = New LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("C:\Users\SabrinaGP\Desktop\logSeqMorosity.log").CreateLogger
        Log.Information("")
        Log.Information("Inicio programa.")
        Log.Information("Inicio ventana inicio.")

        Dim con As String = "server=;database=;userid=;password=;port=3306;"
        'conexion = New MySqlConnection(con)

        'Dim cadenaConexion As String = "server=192.168.1.2;database=mibasededatos;userid=root;password=holahola;port=3306;"

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