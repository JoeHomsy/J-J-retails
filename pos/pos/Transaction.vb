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

    Private Sub btnClient_Click(sender As Object, e As EventArgs)
        Client.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        CURRENCY.Show()

    End Sub

    Private Sub Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_J_JDataSet.inv_content' table. You can move, or remove it, as needed.
        Me.Inv_contentTableAdapter.Fill(Me._J_JDataSet.inv_content)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Inv_contentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Inv_contentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Inv_contentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._J_JDataSet)

    End Sub
End Class