Public Class Transaction


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        txtClient.Enabled = True

    End Sub


    Private Sub txtInvoice_TextChanged(sender As Object, e As EventArgs) Handles txtInvoice.TextChanged
        txtInvoice.Enabled = True
    End Sub


    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub txtItemCode_TextChanged_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtClient_TextChanged(sender As Object, e As EventArgs) Handles txtClient.TextChanged
        txtClient.Enabled = True
    End Sub

    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        Client.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CURRENCY.Show()

    End Sub

    Private Sub Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class