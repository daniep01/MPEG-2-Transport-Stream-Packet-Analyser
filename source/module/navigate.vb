Module navigate
    Sub move_first()

        Debug.Print("Move first")
        current_packet = 1
        decode_ts_packet(True, True, current_packet)
        dlgMain.status1.Text = "Ready."
    End Sub

    Sub move_next()
        Debug.Print("Move next: " & current_packet)

        stop_search = False
        dlgMain.status1.Text = "Searching..."

        While current_packet < max_packets And stop_search = False

            current_packet = current_packet + 1
            decode_ts_packet(False, False, current_packet)

            If dlgMain.cboxPayloadStart.Checked = False Or CStr(ts_header.payload_start) = dlgMain.tbPayloadFilter.Text Then
                If dlgMain.cboxPID.Checked = False Or CStr(ts_header.pid) = dlgMain.tbPidFilter.Text Then
                    ' success!
                    Exit While
                End If
            End If

        End While

        If stop_search = True Then
            Dim j As Integer = MsgBox("Search stopped by user", MsgBoxStyle.Critical)
            stop_search = False
        End If

        ' display results
        decode_ts_packet(True, True, current_packet)
        dlgMain.status1.Text = "Ready."

        If current_packet = max_packets Then MsgBox("End of file reached", MsgBoxStyle.Information)

    End Sub

    Sub move_prev()
        Debug.Print("Move prev: " & current_packet)

        stop_search = False
        dlgMain.status1.Text = "Searching..."

        While current_packet > 1 And stop_search = False

            current_packet = current_packet - 1
            decode_ts_packet(False, False, current_packet)

            If dlgMain.cboxPayloadStart.Checked = False Or CStr(ts_header.payload_start) = dlgMain.tbPayloadFilter.Text Then
                If dlgMain.cboxPID.Checked = False Or CStr(ts_header.pid) = dlgMain.tbPidFilter.Text Then
                    ' success!
                    Exit While
                End If
            End If

        End While

        If stop_search = True Then
            Dim j As Integer = MsgBox("Search stopped by user", MsgBoxStyle.Critical)
            stop_search = False
        End If

        ' display results
        decode_ts_packet(True, True, current_packet)
        dlgMain.status1.Text = "Ready."

        If current_packet = 1 Then MsgBox("Start of file reached", MsgBoxStyle.Information)

    End Sub

    Sub move_goto(ByVal p As Integer)
        Debug.Print("Goto packet: " & p)

        current_packet = p
        decode_ts_packet(True, True, current_packet)

    End Sub

    Sub find_pid(ByVal search_pid As Integer)

        Debug.Print("Find PID " & search_pid)

        stop_search = False
        Dim current_pid As Integer

        dlgMain.status1.Text = "Looking for PID " & search_pid

        While current_packet < max_packets And stop_search = False
            current_packet = current_packet + 1
            ' make it quicker by only reading 4 bytes and decoding here
            read_ts_pkt(current_packet, 4)
            current_pid = (ts_bytes(1) And 31) << 8 Or ts_bytes(2)

            If current_pid = search_pid Then
                Exit While
            End If

        End While

        If stop_search = True Then
            Dim j As Integer = MsgBox("Search stopped by user", MsgBoxStyle.Critical)
            stop_search = False
        End If

        decode_ts_packet(True, True, current_packet)
        dlgMain.status1.Text = "Ready."

        If current_packet = max_packets Then
            MsgBox("End of file reached, PID " & search_pid & " not found.", MsgBoxStyle.Information)
            move_first()
        End If

    End Sub

End Module
