Public Class Form1
    Dim list_diccionario As New List(Of String)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim palabra, definicion, dic As String
        palabra = txtPalabra.Text
        definicion = txtDefinicion.Text
        dic = palabra + ":" + definicion
        Dim item1 As ListViewItem
        item1 = New ListViewItem(palabra, 0)
        item1.SubItems.Add(palabra)
        item1.SubItems.Add(definicion)

        Form2.lvDiccionario.Items.Add(item1)
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Form2.lvDiccionario =


    End Sub
End Class
