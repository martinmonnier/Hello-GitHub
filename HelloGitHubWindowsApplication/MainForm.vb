Public Class MainForm

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click

        ' let give a confirmation
        If MsgBox("Are you shure?", MsgBoxStyle.YesNo, "Close Application") = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class
