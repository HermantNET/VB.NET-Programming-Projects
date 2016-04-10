Public Class Form1
    Sub Roll()
        Dim rand As New Random
        Dim dice1 As Integer = rand.Next(6) + 1
        Dim dice2 As Integer = rand.Next(6) + 1
        Dim roll As Integer = dice1 + dice2
        Dim active As String
        Dim i As Integer = 0

        PictureBox(dice1, dice2)

        Label1.Text = roll.ToString()
    End Sub
    Sub PictureBox(ByVal dice1, ByVal dice2)
        Select Case dice1
            Case 1
                PictureBox1.Image = My.Resources.Die1
            Case 2
                PictureBox1.Image = My.Resources.Die2
            Case 3
                PictureBox1.Image = My.Resources.Die3
            Case 4
                PictureBox1.Image = My.Resources.Die4
            Case 5
                PictureBox1.Image = My.Resources.Die5
            Case 6
                PictureBox1.Image = My.Resources.Die6
        End Select

        Select Case dice2
            Case 1
                PictureBox2.Image = My.Resources.Die1
            Case 2
                PictureBox2.Image = My.Resources.Die2
            Case 3
                PictureBox2.Image = My.Resources.Die3
            Case 4
                PictureBox2.Image = My.Resources.Die4
            Case 5
                PictureBox2.Image = My.Resources.Die5
            Case 6
                PictureBox2.Image = My.Resources.Die6
        End Select
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Roll()
    End Sub
End Class
