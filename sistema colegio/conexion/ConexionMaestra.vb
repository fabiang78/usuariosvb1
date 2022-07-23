Imports System.Data.SqlClient

Module ConexionMaestra
    Public conexion As New SqlConnection("data source=DESKTOP-PIA95KD\SQLEXPRESS01;initial catalog=baseAlumnos; integrated security=true")
    Sub iniciar()
        If conexion.State = 0 Then
            conexion.Open()

        End If
    End Sub
    Sub terminar()
        If conexion.State = 1 Then
            conexion.Close()

        End If
    End Sub
End Module
