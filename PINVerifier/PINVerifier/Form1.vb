Public Class Form1
    Dim intMax() As Integer = {9, 7, 4, 9, 9, 6, 8}
    Dim intMin() As Integer = {7, 5, 0, 0, 6, 3, 4}

    Dim txtBoxes() As TextBox

    Public Sub New()
        InitializeComponent()
        txtBoxes = New TextBox() {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7}
    End Sub

    Sub PinCheck()
        Dim i As Integer
        Dim Valid As Boolean = False

        Try
            For i = 0 To 6
                If CInt(txtBoxes(i).Text) >= intMin(i) And CInt(txtBoxes(i).Text) <= intMax(i) Then
                    Valid = True
                Else
                    Valid = False
                End If
            Next

            If Valid = True Then
                MessageBox.Show("Valid")
            End If
        Catch
            MessageBox.Show("Invalid")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PinCheck()
    End Sub
End Class
