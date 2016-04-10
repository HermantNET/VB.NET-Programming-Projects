Public Class Form1
    Dim strAllowed = "ABCD"

    Dim strAnswers() As String = {"B", "D", "A", "A", "C",
                                  "A", "B", "A", "C", "D",
                                  "B", "C", "D", "A", "D",
                                  "C", "C", "B", "D", "A"}

    Private OrderNumbers() As TextBox
    Dim intScore As Integer = 0

    'Code found on StackOverflow
    Public Sub New()
        InitializeComponent()
        OrderNumbers = New TextBox() {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12, TextBox13,
                                      TextBox14, TextBox15, TextBox16, TextBox17, TextBox18, TextBox19, TextBox20}
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim score As New Score
        Dim strPass As String
        Dim i As Integer

        For i = 0 To 19
            If OrderNumbers(i).Text <> String.Empty Then
                If String.Equals(OrderNumbers(i).Text, strAnswers(i)) Then
                    score.ListBox1.Items.Add((i + 1).ToString & ". Correct")
                    intScore += 1
                Else
                    score.ListBox1.Items.Add((i + 1).ToString & ". Incorrect")
                End If
            Else
                score.ListBox1.Items.Add((i + 1).ToString & ". Incorrect")
            End If
        Next

        If intScore > 14 Then
            strPass = "Congragulations! You passed the exam."
        Else
            strPass = "Sorry, you've failed the exam."
        End If
        score.Label1.Text = strPass
        score.Label2.Text = intScore.ToString() & "/20"
        intScore = 0
        score.Show()
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged, TextBox5.TextChanged, TextBox6.TextChanged, TextBox7.TextChanged, TextBox8.TextChanged,
            TextBox9.TextChanged, TextBox10.TextChanged, TextBox11.TextChanged, TextBox12.TextChanged, TextBox13.TextChanged, TextBox14.TextChanged, TextBox15.TextChanged, TextBox16.TextChanged, TextBox17.TextChanged, TextBox18.TextChanged, TextBox19.TextChanged, TextBox20.TextChanged

        If strAllowed.Contains(sender.Text) = False Then
            sender.Text = String.Empty
        End If
    End Sub
End Class
