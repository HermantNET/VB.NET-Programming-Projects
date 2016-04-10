Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Time
        Dim intTime As Integer
        Dim blnInput As Boolean = True
        Dim intMinutes As Integer = 0
        Dim intSeconds As Integer = 0
        Dim intHours As Integer = 0
        Dim intDays As Integer = 0

        lblResult.Text = String.Empty
        If Integer.TryParse(txtSeconds.Text, intTime) = False Then
            lblResult.Text = "Please Enter a number."
            blnInput = False

        Else

            If blnInput = True Then

                If intTime >= 86400 Then
                    intDays = intTime \ 86400
                    intTime = intTime Mod 86400
                End If

                If intTime >= 3600 Then
                    intHours = intTime \ 3600
                    intTime = intTime Mod 3600
                End If

                If intTime >= 60 Then
                    intMinutes = intTime \ 60
                    intTime = intTime Mod 60
                End If
            End If


            lblResult.Text = intDays.ToString("n0") & " Days, " &
            intHours.ToString("n0") & " hours, " &
            intMinutes.ToString("n0") & " minutes, and " &
            intTime.ToString("n0") & " seconds."
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblResult.Text = String.Empty
    End Sub
End Class
