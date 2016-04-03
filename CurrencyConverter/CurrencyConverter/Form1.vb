Imports Newtonsoft.Json
Imports System.Net

Public Class Form1
    Dim json = New WebClient().DownloadString("http://api.fixer.io/latest?base=USD")

    Dim DataSet = JsonConvert.DeserializeObject(json)
    Dim dataTable = DataSet("rates")

    Sub Convert()
        Try
            Dim decAmount As Decimal = CDec(txtAmount.Text)
            Dim decEuro As Decimal = decAmount * dataTable("EUR")
            Dim decPounds As Decimal = decAmount * dataTable("GBP")
            Dim decYen As Decimal = decAmount * dataTable("JPY")

            txtEuro.Text = decEuro.ToString()
            txtPounds.Text = decPounds.ToString()
            txtYen.Text = decYen.ToString()
        Catch
            ToolStripStatusLabel1.Text = "Invalid Number"
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ToolStripStatusLabel1.Text = String.Empty
        Convert()
    End Sub
End Class
