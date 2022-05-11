Imports System.Data.SqlClient
Public Class ClaseArticulos
    Public xcn As SqlConnection
    Public xcomando As SqlCommand
    Public xdata As SqlDataReader
    Private xcodart, xnomart, xpreart As String
    Public Sub IniciaArticulos(ByVal cn As SqlConnection)
        xcn = cn
    End Sub

    Public Sub LlenarCombo(ByVal xcomboBox As ComboBox)
        xcn.Open()
        xcomando = xcn.CreateCommand
        xcomando.CommandText = "Select* from articulos"
        xdata = xcomando.ExecuteReader()
        Do While xdata.Read()
            xnomart = xdata(1)
            xcomboBox.Items.Add(xnomart)
        Loop
        xcn.Close()
    End Sub
    Public Sub BuscarNombreArticulo(ByVal nom As String)
        xcn.Open()
        xcomando = xcn.CreateCommand
        xcomando.CommandText = "Select * from articulos where nombreArt='" + nom + "'"
        xdata = xcomando.ExecuteReader()
        If xdata.Read() Then
            xcodart = xdata(0)
            xnomart = xdata(1)
            xpreart = xdata(2)
        End If
        xcn.Close()
    End Sub
    Public Sub GetCodigo(ByVal xtext As TextBox)
        xtext.Text = xcodart
    End Sub
    Public Sub GetNombre(ByVal xtext As TextBox)
        xtext.Text = xnomart
    End Sub
    Public Sub GetPrecio(ByVal xtext As TextBox)
        xtext.Text = xpreart
    End Sub
End Class
