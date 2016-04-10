Public Class Form1
    Dim intDays As Integer = 80
    Dim pennies(intDays) As Decimal

    Sub Calculate()
        Try
            Dim q As Integer = ComboBox1.SelectedIndex
            Label1.Text = pennies(q).ToString("c2")
        Catch
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Calculate()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 1
        Dim decPennies As Decimal = 0.02


        pennies(0) = 0.01

        For i = 1 To intDays
            decPennies = decPennies + decPennies
            pennies(i) = decPennies
            Dim decTotal As Decimal = pennies(i)
        Next

        i = 1

        For i = 1 To intDays Step 1
            ComboBox1.Items.Add("Day " & i.ToString())
        Next
    End Sub
End Class
