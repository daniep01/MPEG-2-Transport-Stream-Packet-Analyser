Imports System.Windows.Forms

Public Class dlgGoto

    Private Sub do_goto()

        ' get number of packet from dialogue box
        Dim offset As Integer = System.Convert.ToInt32(tbPacket.Text)
        ' where are we moving from?
        Dim base_packet As Integer

        Debug.Print("goto, " & offset)


        If rb_start.Checked = True Then base_packet = 0
        If rb_end.Checked = True Then
            base_packet = max_packets
            offset = 0 - offset
        End If

        If rb_current.Checked = True Then base_packet = current_packet

        If (offset + base_packet) < 1 Or (offset + base_packet) > max_packets Then
            MsgBox("Packet must be between 1 and " & max_packets & ".", MsgBoxStyle.Information)
            Me.tbPacket.Focus()
            Exit Sub
        End If

        move_goto(base_packet + offset)

        Me.Hide()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Hide()
    End Sub

    Private Sub on_activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.tbPacket.Focus()
    End Sub

    Private Sub tbPacket_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbPacket.KeyDown
        If e.KeyCode = Keys.Enter Then do_goto()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        do_goto()
    End Sub
End Class
