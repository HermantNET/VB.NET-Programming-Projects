Public Class Form1
    'Words
    Dim strNouns() As String = {"owl", "waffle", "turtle", "fish", "squid"}
    Dim strAdjectives() As String = {"sad", "screaming", "leaky", "benevolent", "intelligent"}
    Dim strVerbs() As String = {"spoke", "broke", "sang", "fought", "wizarded"}
    Dim strPrepositions() As String = {"inside", "before", "above", "below", "behind"}
    Dim strArticles() As String = {"the", "a", "some", "another", "one"}

    Dim rand As New Random(4)

    Sub Sentence()
        Dim strFirst As Integer = 0
        Dim strSentence As String

        strFirst = randomGen()
        strSentence = strArticles(strFirst).Substring(0, 1).ToUpper & strArticles(strFirst).Substring(1) & " " & strAdjectives(randomGen) & " " & strNouns(randomGen) & " " & strVerbs(randomGen) & " " &
            strPrepositions(randomGen) & " " & strArticles(randomGen) & " " & strAdjectives(randomGen) & " " & strNouns(randomGen) & "."

        ListBox1.Items.Add(strSentence)
    End Sub

    Function randomGen()
        Dim random As Integer = rand.Next(5)


        Return random
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Sentence()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
