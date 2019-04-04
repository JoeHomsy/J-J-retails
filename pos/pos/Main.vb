Public Class Main
    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        Transaction.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
    End Sub

    Private Sub ShutDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutDownToolStripMenuItem.Click
        Me.Close()
        Close()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        Employee.Show()
    End Sub

    Private Sub InquiryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InquiryToolStripMenuItem.Click
        stock.Show()
        Me.Hide()

    End Sub
End Class