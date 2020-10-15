Public Class dlgDebug

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Result.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For j As Integer = 0 To 7
            txt_Result.Text += vbCrLf & j & " : " & IsBitSet(txt_input.Text, j)
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txt_Result.Text = Nothing
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txt_Result.Text = Hex(txt_input.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txt_Result.Text = CLng("&H" & txt_input.Text)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        txt_Result.Text = decode_pid_value(txt_input.Text)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim n As Integer
        For x As Integer = 0 To 100
            txt_Result.Text = txt_Result.Text & vbCrLf & n
            n = (n + 1) Mod 16
        Next
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        txt_Result.Text = int_to_hex(ts_bytes(txt_input.Text)) & " : " & ts_bytes(txt_input.Text)

    End Sub
End Class