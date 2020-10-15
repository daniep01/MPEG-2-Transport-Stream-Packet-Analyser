Public Class dlgProgress

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        stop_search = True
        Me.Close()
    End Sub
End Class