Public Class MainForm

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()

    End Sub

    Private Sub InfoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoButton.Click
        InfoDialog.ShowDialog()
    End Sub
End Class
