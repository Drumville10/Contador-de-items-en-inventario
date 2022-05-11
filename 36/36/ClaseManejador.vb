Imports System.Data.SqlClient
Public Class ClaseManejador
    Public cn As SqlConnection
    Public articulo As New ClaseArticulos
    Public Sub Conectar()
        cn = New SqlConnection("Data Source=DESKTOP-MILLTC0;Initial Catalog=NETVENTAS;Integrated Security=True")
        articulo.IniciaArticulos(cn)
    End Sub
End Class
