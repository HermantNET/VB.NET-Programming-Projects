Public Class Form1
    Const decTAX_RATE As Decimal = 0.06F
    Dim decMiscCost As Decimal = 0F

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Products.Boards()
        Products.TruckAssemblies()
        Products.WheelSets()
        Products.Miscellaneous()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmDecks.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmTruck.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmWheel.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmMisc.Show()
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtDeck.Text = Products.myBoard.name
        txtTruck.Text = Products.myTruck.name
        txtWheel.Text = Products.myWheel.name

        Dim i As Integer
        Dim misc(5) As String
        Dim miscString As String = String.Empty

        For i = 1 To 5
            If Products.myMisc(i).name <> String.Empty Then
                misc(i) = Products.myMisc(i).name
                miscString += misc(i) + ", "
                decMiscCost += Products.myMisc(i).price
            End If
        Next

        txtMisc.Text = miscString.Substring(0, miscString.Length)
    End Sub

    Sub SubUpdate()
        Dim decSub As Decimal = 0F
        Dim decTax As Decimal = 0F
        Dim decTotal As Decimal = 0F

        decSub = Products.myBoard.price + Products.myTruck.price + Products.myWheel.price + decMiscCost
        decTax = (decSub * decTAX_RATE)
        txtSub.Text = decSub.ToString("c")
        txtTax.Text = decTax.ToString("c")
        txtTotal.Text = (decSub + decTax).ToString("c")
    End Sub

    Private Sub txtDeck_TextChanged(sender As Object, e As EventArgs) Handles txtDeck.TextChanged, txtWheel.TextChanged, txtTruck.TextChanged, txtMisc.TextChanged
        SubUpdate()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessageBox.Show("Can't connect to server.")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Products.myBoard = Products.Board(0)
        Products.myTruck = Products.Truck(0)
        Products.myWheel = Products.Wheel(0)

        Dim i As Integer
        For i = 1 To Products.myMisc.GetUpperBound(0)
            Products.myMisc(i) = Products.misc(0)
        Next

        txtDeck.Text = String.Empty
        txtTruck.Text = String.Empty
        txtWheel.Text = String.Empty
        txtMisc.Text = String.Empty

        decMiscCost = 0F

        txtSub.Text = String.Empty
        txtTax.Text = String.Empty
        txtTotal.Text = String.Empty
    End Sub
End Class
