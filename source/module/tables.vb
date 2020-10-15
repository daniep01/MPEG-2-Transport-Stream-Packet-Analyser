Module tables

    Dim byte_offset As Integer

    Function decode_table_header() As String

        Dim result As String = "Table"

        table_header.pointer_field = (ts_bytes(4))

        If table_header.pointer_field <> 0 Then
            ' can't decode tables that start partway through packet
            ' cause it's too hard
            packet_note2 = ("Pointer_field " & table_header.pointer_field & " (0x" & Hex(table_header.pointer_field) & ")")
            Return Nothing
        End If

        table_header.table_id = (ts_bytes(5))
        table_header.section_syntax_indicator = IsBitSet(ts_bytes(6), 7)
        table_header.section_length = (ts_bytes(6) And 15) << 8 Or ts_bytes(7) ' get_data(12, 6, 4)

        Debug.Print("Decode table header, id : " & table_header.table_id)

        result += (vbCrLf & "   table_id: 0x" & Hex(table_header.table_id))
        result += " (" & decode_table_id(table_header.table_id) & ")"
        result += (vbCrLf & "   section_length: " & table_header.section_length)
        ' maximum section length in 1 packet is 180 bytes, counting starts immediately 
        ' after the section length field and includes the CRC

        packet_note2 = decode_table_id(table_header.table_id)

        Select Case table_header.table_id

            Case 0
                ' PAT
                result += decode_table_sub_header("   transport_stream_id")
                result += decode_pat(table_header.section_length)
                result += decode_crc()

            Case 1
                ' CAT
                result += decode_table_sub_header("   reserved")
                If table_header.section_length > 9 Then
                    'result += decode_descriptor(12)
                Else
                    result += vbCrLf & "No CA descriptors!"
                End If
                result += decode_crc()

            Case 2
                ' PMT
                result += decode_table_sub_header("   program_number")
                If table_header.section_length < 180 Then
                    ' all in this packet so attempt decode
                    result += decode_pmt(table_header.section_length)
                End If
                result += decode_crc()

            Case &H40, &H41
                ' NIT
                result += decode_table_sub_header("   network_id")
                result += decode_crc()

            Case &H42, &H46
                ' SDT
                result += decode_table_sub_header("   transport_stream_id")
                result += decode_crc()

            Case &H4A
                ' BAT
                result += decode_table_sub_header("   bouquet_id")
                result += decode_crc()

            Case &H4E To &H6F
                ' EIT
                result += decode_table_sub_header("   service_id")
                result += decode_eit()
                result += decode_crc()

            Case &H70
                ' TDT
                result += decode_tdt()
                ' no descriptors or CRC in TDT

            Case &H71
                ' RST

            Case &H72
                ' Stuffing

            Case &H73
                ' TOT
                result += decode_tdt()
                result += decode_crc()
                'TODO should add descriptor decoding in here...

            Case &H76
                ' RCT
                result += decode_table_sub_header("   service_id")

            Case &H90
                ' PID32 
                result += decode_table_sub_header("   injector_id")

            Case &HD1
                ' Freesat EIT pf++
                result += decode_table_sub_header("   service_id")
                result += decode_eit()
                result += decode_crc()

            Case Else
                'result += vbCrLf & "Unknown table id."
        End Select



        ' warn if the table is more than 1 TS packet
        If table_header.section_length > 180 Then result += vbCrLf & "Incomplete table decoded..."

        Return result

    End Function

    Function decode_table_sub_header(ByVal sub_table As String) As String

        table_header.sub_table_id = get2bytes(8)
        table_header.version_number = (ts_bytes(10) And 62) >> 1 ' get_data(5, 10, 6)
        table_header.current_next = IsBitSet(ts_bytes(10), 7) ' get_data(1, 10, 7)       
        table_header.section_number = ts_bytes(11)
        table_header.last_section_number = ts_bytes(12)

        Dim s As String = Nothing
        s += vbCrLf & sub_table & ": " & table_header.sub_table_id
        s += vbCrLf & "   version_number: " & table_header.version_number
        s += vbCrLf & "   current_next: " & table_header.current_next
        s += vbCrLf & "   section_number: " & table_header.section_number
        s += vbCrLf & "   last_section_number: " & table_header.last_section_number
        s += vbCrLf
        Return s

    End Function

    Function decode_eit() As String

        Dim s As String = Nothing
        byte_offset = 12

        s += vbCrLf & "   transport_stream_id: " & next_16()
        s += vbCrLf & "   original_network_id: " & next_16()
        s += vbCrLf & "   segment_last_section_number: " & next_8()
        s += vbCrLf & "   last_table_id: 0x" & int_to_hex(next_8())

        Return s

    End Function

    Function decode_tdt() As String

        Dim s As String = Nothing

        s = vbCrLf & vbCrLf
        s += "   date: " & decode_date(8)
        s += vbCrLf
        s += "   time: " & decode_time(10)
        Return s

    End Function

    Function decode_pat(ByVal section_length As Integer) As String
        Debug.Print("decode pat, section length: " & section_length)

        Dim s As String = Nothing
        Dim b, program, pmt_pid As Integer

        b = 13 ' (tsheader + pointer + tableheaders)
        Do
            ' each loop is 4 bytes
            program = get2bytes(b)
            b = b + 2
            pmt_pid = (ts_bytes(b) And 31) << 8 Or ts_bytes(b + 1)
            b = b + 2
            s += vbCrLf & "   program_number: " & program '& " 0x" & int_to_hex(program)
            s += vbCrLf & "   program_map_PID: " & pmt_pid '& " 0x" & int_to_hex(pmt_pid)

            ' check we aren't at the end of the section or the end of the packet
            ' add 4 to section length 
        Loop While (b < section_length + 4 And b < 184)



        Return s

    End Function

    Function decode_pmt(ByVal section_length As Integer) As String
        ' very experimental

        Dim s As String = Nothing
        Dim b, stream_type, component_pid, prog_length, es_length As Integer
        Dim pcr_pid As Integer

        b = 13

        pcr_pid = (ts_bytes(b) And 31) << 8 Or ts_bytes(b + 1)
        b = b + 2
        prog_length = (ts_bytes(b) And 15) << 8 Or ts_bytes(b + 1)
        b = b + 2 + prog_length

        s += vbCrLf & "   PCR_PID: " & pcr_pid
        s += vbCrLf & "   Program_descriptor_length: " & prog_length

        Do
            s += vbCrLf '& "   b: " & b
            stream_type = ts_bytes(b)
            ' sohuld be And 31?
            component_pid = (ts_bytes(b + 1) And 31) << 8 Or ts_bytes(b + 2)

            es_length = (ts_bytes(b + 3) And 15) << 8 Or ts_bytes(b + 4)


            'component_pid = (ts_bytes(b) And 31) << 8 Or ts_bytes(b + 1)
            s += vbCrLf & "   stream_type: " & stream_type
            s += vbCrLf & "   elementary_PID: " & component_pid
            s += vbCrLf & "   ES_descriptor_length: " & es_length
            b = b + 4

            If es_length > 0 Then
                s += decode_descriptor(b)
            End If

            b = b + 1 + es_length

        Loop While (b < section_length + 4)

        Return s

    End Function

    Function decode_descriptor(ByVal b As Integer) As String
        Debug.Print("decode descriptors")

        ' still experimental!

        Dim s As String = Nothing
        Dim tag, length, ca_pid As Integer

        byte_offset = b

        tag = next_8()
        Debug.Print(tag.ToString)
        's += vbCrLf & tag

        length = next_8()
        Debug.Print(length.ToString)
        's += vbCrLf & length

        If length + b > 188 Then
            Return s
        End If

        Select Case tag

            Case 9 ' conditional access descriptor
                s += vbCrLf & "Conditional access descriptor (" & tag & ")"
                s += vbCrLf & "  Length: " & length
                s += vbCrLf & "  CA system id: " & next_16()
                b = b + 2
                ca_pid = (next_8() And 31) << 8 Or next_8()
                s += vbCrLf & "  CA PID: " & ca_pid
                s += vbCrLf & "  Private data: "

                For j As Integer = 1 To (length - 4)
                    s += int_to_hex(next_8())
                Next

            Case &H52 ' stream identifier

                s += vbCrLf & "   Component tag: " & next_8()

            Case Else

                s += vbCrLf & "No known descriptors"

        End Select

        Return s

    End Function

    Function decode_crc() As String

        ' CRC is the last 4 bytes in the section
        ' add 8 bytes which preceed the section_length field
        ' subtract 4 bytes so that we are at the start of the CRC
        Dim start_pos As Integer = table_header.section_length + 4

        ' check that we aren't looking outside the current TS packet
        If start_pos > 184 Then Return vbCrLf & vbCrLf & "CRC not in this packet!"

        Dim r As String = vbCrLf & vbCrLf & "Section CRC: "
        Dim x As Integer

        ' loop for 4 bytes, adding to string with spaces and leading zeros as required
        For a As Integer = start_pos To start_pos + 3
            x = ts_bytes(a)
            r += int_to_hex(x)
        Next

        Debug.Print(r & "@ byte_position " & start_pos)
        Return r

    End Function

    Function next_8() As Integer

        ' check not going to exceed array max of 187
        If byte_offset > 186 Then Return 0

        byte_offset = byte_offset + 1
        Return ts_bytes(byte_offset)

    End Function

    Function next_16() As Integer

        ' check not going to exceed array max of 187
        If byte_offset > 185 Then Return 0

        Dim i As Integer

        i = (ts_bytes(byte_offset + 1) And 255) << 8 Or ts_bytes(byte_offset + 2)
        byte_offset = byte_offset + 2

        Return i

    End Function

    Function int_to_hex(ByVal i As Integer) As String

        Dim r As String
        r = i.ToString("X")
        If r.Length = 1 Then r = "0" & r
        r = r + " "
        Return r

    End Function

End Module
