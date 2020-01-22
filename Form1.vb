Public Class Form1

    Dim a(5) As Integer
    Dim b(5) As Integer
    Dim c(5) As Integer
    Dim cadena As String
    Dim cadena2 As String
    Dim cadena3 As String
    Dim total As String
    Dim j As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For j = 0 To 4
            a(j) = InputBox("introduce un numero")
            b(j) = InputBox("ahora el segundo")

            cadena = (cadena & a(j) & (" "))
            cadena2 = (cadena2 & b(j) & (" "))
        Next


        For j = 0 To 4

            c(j) = a(j) + b(j)
            cadena3 = (cadena3 & " La suma es = " & c(j) & vbNewLine)

        Next
        cadena = (cadena & vbNewLine & cadena2 & vbNewLine & cadena3)

        TextBox1.Text = cadena


    End Sub
End Class
