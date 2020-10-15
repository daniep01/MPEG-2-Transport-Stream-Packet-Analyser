Public Class dlgSpacing
    Dim analyse_stop As Boolean = False
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_start.Click
        analyse_spacing()
    End Sub

    Sub analyse_spacing()

        Dim pid_to_analyse As Integer = Nothing
        Dim average_gap As Double = 0
        Dim gaps_analysed, pkt_found, begin_pkt, stop_pkt, current_packet, last_packet, current_gap, min_gap, max_gap, current_pid As Integer
        Dim first_loop As Boolean = True

        Try
            pid_to_analyse = System.Convert.ToInt32(txt_spacingpid.Text)
            begin_pkt = System.Convert.ToInt32(txt_pktbegin.Text)
            stop_pkt = System.Convert.ToInt32(txt_pktstop.Text)
        Catch exp As System.Exception
            MsgBox(exp.Message & " Invalid input in filter.", MsgBoxStyle.Critical)
            Exit Sub
        End Try

        If check_start_end(begin_pkt, stop_pkt) = False Then Exit Sub

        analyse_stop = False
        btn_stop.Enabled = True
        btn_close.Enabled = False
        btn_start.Enabled = False
        txt_analysed.Text = "0"
        txt_pktfound.Text = "0"
        txt_min.Text = Nothing
        txt_max.Text = Nothing

        Debug.Print("* Begin spacing analysis, pid: " & pid_to_analyse)
        For current_packet = begin_pkt To stop_pkt

            If analyse_stop = True Then Exit For

            decode_ts_packet(False, False, current_packet)

            current_pid = ts_header.pid

            If current_pid = pid_to_analyse Then

                pkt_found += 1
                txt_pktfound.Text = pkt_found.ToString

                If first_loop = True Then
                    Debug.Print("pid match, first time so no gap data to display")
                    first_loop = False
                Else

                    gaps_analysed += 1
                    current_gap = current_packet - last_packet - 1 ' subtract 1 so adjacent packets give gap = 0 
                    'average_gap = (average_gap + current_gap) / gaps_analysed

                    If gaps_analysed = 1 Then min_gap = current_gap
                    If current_gap < min_gap Then min_gap = current_gap
                    If current_gap > max_gap Then max_gap = current_gap

                    Debug.Print(gaps_analysed & " pid match; pid: " & ts_header.pid & " gap: " & current_gap & " min: " & min_gap & " max: " & max_gap)

                    txt_analysed.Text = gaps_analysed.ToString
                    txt_min.Text = min_gap.ToString
                    txt_max.Text = max_gap.ToString

                End If

                last_packet = current_packet
            End If

        Next ' packet

        btn_stop.Enabled = False
        btn_start.Enabled = True
        btn_close.Enabled = True
        move_first()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_stop.Click
        analyse_stop = True
        btn_stop.Enabled = False
    End Sub

    Private Sub dlgSpacing_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txt_spacingpid.Focus()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_spacingpid.KeyDown
        If e.KeyCode = Keys.Enter Then
            analyse_spacing()
        End If
    End Sub
End Class