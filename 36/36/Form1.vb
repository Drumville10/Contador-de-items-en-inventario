Public Class Form1
    Dim myDB As New ClaseManejador
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myDB.Conectar()
        myDB.articulo.LlenarCombo(ComboBox1)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim nomart As String
        nomart = ComboBox1.Text
        myDB.articulo.BuscarNombreArticulo(nomart)
        myDB.articulo.GetCodigo(TextBox1)
        myDB.articulo.GetPrecio(TextBox2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim importe, total As String
        total = Val(Label6.Text)
        importe = Str(Val(TextBox2.Text) * Val(TextBox3.Text))
        total = Str(Val(total) + Val(importe))
        Dim fila As New ListViewItem(TextBox1.Text)
        fila.SubItems.Add(ComboBox1.Text)
        fila.SubItems.Add(TextBox2.Text)
        fila.SubItems.Add(TextBox3.Text)
        fila.SubItems.Add(importe)
        ListView1.Items.Add(fila)
        Label6.Text = total
    End Sub
End Class
