Public Class frmMisc
    Private Sub frmMisc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Text = Products.misc(1).name
        CheckBox2.Text = Products.misc(2).name
        CheckBox3.Text = Products.misc(3).name
        CheckBox4.Text = Products.misc(4).name
        CheckBox5.Text = Products.misc(5).name
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            Products.myMisc(1) = Products.misc(1)
        End If

        If CheckBox2.Checked Then
            Products.myMisc(2) = Products.misc(2)
        End If

        If CheckBox3.Checked Then
            Products.myMisc(3) = Products.misc(3)
        End If

        If CheckBox4.Checked Then
            Products.myMisc(4) = Products.misc(4)
        End If

        If CheckBox5.Checked Then
            Products.myMisc(5) = Products.misc(5)
        End If

        Me.Close()
    End Sub
End Class