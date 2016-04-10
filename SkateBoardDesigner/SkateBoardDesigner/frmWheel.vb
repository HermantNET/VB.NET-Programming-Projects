Public Class frmWheel
    Private Sub frmWheel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 1
        For i = 1 To 4
            ListBox1.Items.Add(Products.Wheel(i).name)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Products.myWheel = Products.Wheel(ListBox1.SelectedIndex + 1)
        Me.Close()
    End Sub
End Class