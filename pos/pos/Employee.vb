Public Class Employee
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtaddress.Text() = ""
        txtdob.Text() = ""
        txtFirstName.Text() = ""
        txtLastName.Text() = ""
        txtMiddleName.Text() = ""
        txtPhoneNumber.Text() = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Me.Close()

    End Sub
End Class