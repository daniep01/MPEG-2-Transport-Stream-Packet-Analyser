Module eit

    Sub extract_eit()

        Debug.Print("Extract EIT")

        Dim pid, payload_start, table_id, service_id, ts_id, on_id As Integer
        'Dim eit_event()

        For this_pkt As Integer = 1 To 100 'max_packets


            read_ts_pkt(this_pkt, 188)

            pid = (ts_bytes(1) And 31) << 8 Or ts_bytes(2)

            If pid = 18 Then

                payload_start = (ts_bytes(1) And 64) >> 6

                If payload_start = 1 Then

                    ' start of table
                    table_id = ts_bytes(5)
                    service_id = get2bytes(8)
                    ts_id = get2bytes(13)
                    on_id = get2bytes(15)

                    Debug.Print("packet: " & this_pkt & " pid: " & pid & " payload_start: " & payload_start)
                    Debug.Print("table id: " & table_id)
                    Debug.Print("service_id: " & service_id)
                    Debug.Print("ts_id: " & ts_id)
                    Debug.Print("on_id: " & on_id)

                    ' event loop


                Else

                    ' continuation


                End If
            End If ' pid check
        Next

    End Sub

End Module
