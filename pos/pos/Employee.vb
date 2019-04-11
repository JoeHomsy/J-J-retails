Public Class Employee
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        txtaddress.Text() = ""
        txtdob.Text() = ""
        txtFirstName.Text() = ""
        txtLastName.Text() = ""
        txtPhoneNumber.Text() = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Main.Show()
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub

    Private Sub ClientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientBindingNavigatorSaveItem.Click

    End Sub
End Class