Public Class Client
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNumber.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Transaction.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtFirstName.Text() = ""
        txtLastName.Text() = ""
        txtMiddleName.Text() = ""
        txtPhoneNumber.Text() = ""
        TextBox2.Text() = ""
        TextBox1.Text() = ""

    End Sub
End Class