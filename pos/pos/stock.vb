Public Class stock
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Main.Show()
        Me.Hide()

    End Sub

    Private Sub Item_StockBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Item_StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Item_StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._J_JDataSet)
        txt1.Text = ""
        txt2.Text = ""
        txt33.Text = ""
        txt4.Text = ""
        txt6.Text = ""
        txt5.Text = ""
        txt7.Text = ""
    End Sub

    Private Sub stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_J_JDataSet.Item_Stock' table. You can move, or remove it, as needed.
        Me.Item_StockTableAdapter.Fill(Me._J_JDataSet.Item_Stock)

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        txt1.Text = ""
        txt2.Text = ""
        txt33.Text = ""
        txt4.Text = ""
        txt6.Text = ""
        txt5.Text = ""
        txt7.Text = ""
    End Sub
End Class