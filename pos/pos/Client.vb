Public Class Client
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Transaction.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        txtFirstName.Text() = ""
        txtLastName.Text() = ""
        txtPhoneNumber.Text() = ""
        C_addressTextBox.Text() = ""


    End Sub





    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_J_JDataSet.Client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me._J_JDataSet.Client)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub


End Class