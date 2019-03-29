Public Class Transaction


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBarcode.TextChanged
        txtClient.Enabled = True

    End Sub


    Private Sub txtInvoice_TextChanged(sender As Object, e As EventArgs) Handles txtInvoice.TextChanged
        txtInvoice.Enabled = True
    End Sub


    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtItemDescription.TextChanged
        txtItemDescription.Enabled = True
    End Sub


    Private Sub txtItemCode_TextChanged_1(sender As Object, e As EventArgs) Handles txtItemCode.TextChanged
        txtItemCode.Enabled = True

    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        txtPrice.Enabled = True
    End Sub

    Private Sub txtClient_TextChanged(sender As Object, e As EventArgs) Handles txtClient.TextChanged
        txtClient.Enabled = True
    End Sub

    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        Client.Show()
    End Sub
End Class