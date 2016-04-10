Public Class Form1
    Dim rand As New Random
    Dim intUser As Integer
    Dim intChoice As Integer = rand.Next(1, 3)
    Dim strCompChoice As String
    Dim strUserChoice As String
    Dim strResult As String
    Dim strWin As String = "You win!"
    Dim strLose As String = "You lose."
    Dim strTie As String = "Tie."

    Function Type(choice)
        Select Case choice
            Case 1
                Return "Rock"
            Case 2
                Return "Paper"
            Case 3
                Return "Scissors"
        End Select
    End Function

    Sub CompChoice()
        intChoice = rand.Next(1, 3)

        strCompChoice = Type(intChoice)
        strUserChoice = Type(intUser)
        strResult = "The Computer chose " & strCompChoice & " and you chose " & strUserChoice & ". "

        If intChoice = 1 Then
            If intUser = 1 Then
                MessageBox.Show(strResult & strTie)
            ElseIf intUser = 2 Then
                MessageBox.Show(strResult & strWin)
            ElseIf intUser = 3 Then
                MessageBox.Show(strResult & strLose)
            End If

        ElseIf intChoice = 2 Then
            If intUser = 1 Then
                MessageBox.Show(strResult & strLose)
            ElseIf intUser = 2 Then
                MessageBox.Show(strResult & strTie)
            ElseIf intUser = 3 Then
                MessageBox.Show(strResult & strWin)
            End If

        ElseIf intChoice = 3 Then
            If intUser = 1 Then
                MessageBox.Show(strResult & strWin)
            ElseIf intUser = 2 Then
                MessageBox.Show(strResult & strLose)
            ElseIf intUser = 3 Then
                MessageBox.Show(strResult & strTie)
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        intUser = 1
        CompChoice()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        intUser = 2
        CompChoice()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        intUser = 3
        CompChoice()
    End Sub
End Class
