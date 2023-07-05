Imports System.Linq.Expressions

Public Class Form1
    Public signo, n1, n2 As String
    Public int1, int2 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Boton1.Click
        operacion.Text = operacion.Text & Boton1.Text

    End Sub

    Private Sub operacion_Click(sender As Object, e As EventArgs) Handles operacion.Click

    End Sub

    Private Sub Boton2_Click(sender As Object, e As EventArgs) Handles Boton2.Click
        operacion.Text = operacion.Text & Boton2.Text

    End Sub

    Private Sub boton3_Click(sender As Object, e As EventArgs) Handles boton3.Click
        operacion.Text = operacion.Text & boton3.Text

    End Sub

    Private Sub boton4_Click(sender As Object, e As EventArgs) Handles boton4.Click
        operacion.Text = operacion.Text & boton4.Text

    End Sub

    Private Sub boton5_Click(sender As Object, e As EventArgs) Handles boton5.Click
        operacion.Text = operacion.Text & boton5.Text

    End Sub

    Private Sub boton6_Click(sender As Object, e As EventArgs) Handles boton6.Click
        operacion.Text = operacion.Text & boton6.Text

    End Sub

    Private Sub boton7_Click(sender As Object, e As EventArgs) Handles boton7.Click
        operacion.Text = operacion.Text & boton7.Text

    End Sub

    Private Sub boton8_Click(sender As Object, e As EventArgs) Handles boton8.Click
        operacion.Text = operacion.Text & boton8.Text

    End Sub

    Private Sub boton9_Click(sender As Object, e As EventArgs) Handles boton9.Click
        operacion.Text = operacion.Text & boton9.Text

    End Sub

    Private Sub boton0_Click(sender As Object, e As EventArgs) Handles boton0.Click
        operacion.Text = operacion.Text & boton0.Text

    End Sub

    Private Sub botonSuma_Click(sender As Object, e As EventArgs) Handles botonSuma.Click
        operacion.Text = operacion.Text & botonSuma.Text

    End Sub

    Private Sub botonResta_Click(sender As Object, e As EventArgs) Handles botonResta.Click
        operacion.Text = operacion.Text & botonResta.Text

    End Sub

    Private Sub botonMultiplicacion_Click(sender As Object, e As EventArgs) Handles botonMultiplicacion.Click
        operacion.Text = operacion.Text & botonMultiplicacion.Text

    End Sub

    Private Sub botonDivision_Click(sender As Object, e As EventArgs) Handles botonDivision.Click
        operacion.Text = operacion.Text & botonDivision.Text
    End Sub

    Private Sub botonIgual_Click(sender As Object, e As EventArgs) Handles botonIgual.Click
        For Each i As Char In operacion.Text
            If Not IsNumeric(i) Then
                signo = i
            End If
            If IsNumeric(i) AndAlso String.IsNullOrEmpty(signo) Then
                n1 = n1 & i
            End If
            If IsNumeric(i) = True AndAlso Not String.IsNullOrEmpty(signo) Then
                n2 = n2 & i
            End If
        Next
        Select Case signo
            Case "+"
                Integer.TryParse(n1, int1)
                Integer.TryParse(n2, int2)
                Result.Text = int1 + int2
            Case "-"
                Integer.TryParse(n1, int1)
                Integer.TryParse(n2, int2)
                Result.Text = int1 - int2
            Case "*"
                Integer.TryParse(n1, int1)
                Integer.TryParse(n2, int2)
                Result.Text = int1 * int2
            Case "/"
                Integer.TryParse(n1, int1)
                Integer.TryParse(n2, int2)
                Result.Text = int1 / int2
        End Select
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        operacion.Text = ""
        Result.Text = ""
        int1 = 0
        int2 = 0
        n1 = 0
        n2 = 0
        signo = ""
    End Sub
End Class
