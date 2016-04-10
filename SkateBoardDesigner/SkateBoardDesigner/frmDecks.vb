Public Class frmDecks
    Private Sub frmDecks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 1
        For i = 1 To 3
            ListBox1.Items.Add(Products.Board(i).name)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Products.myBoard = Products.Board(ListBox1.SelectedIndex + 1)
        Me.Close()
    End Sub
End Class