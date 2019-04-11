Public Class CURRENCY
    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Transaction.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 

    End Sub



    Private Sub CURRENCY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_J_JDataSet.currency' table. You can move, or remove it, as needed.
        Me.CurrencyTableAdapter.Fill(Me._J_JDataSet.currency)

    End Sub
End Class