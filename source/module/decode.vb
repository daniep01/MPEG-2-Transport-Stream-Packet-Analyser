Module decode

    ' Core decoding of packets, adaptation, video

    Sub decode_ts_packet(ByVal full_decode As Boolean, ByVal display_results As Boolean, ByVal packet_to_decode As Integer)

        ' note on flags
        '
        ' full_decode?     : continue after ts header and look for other headers (adaptation, pes, etc)
        ' display_results? : update main dialogue and viewer with info from decode (slow)
        '
        ' true,   true     : decode everything, display everything (when interesting packet found)
        ' true,   false    : decode everything, display nothing (for CSV export)
        ' false,  true     : not allowed
        ' false,  false    : decode ts headers only, display nothing (for fast searching)

        Debug.Print("Decode ts packet: " & packet_to_decode & " full_decode: " & full_decode & " display_reaults: " & display_results)

        ' always read all bytes
        ' TODO : can this be better if full_decode = false?
        read_ts_pkt(packet_to_decode, 188)

        ' reset so we don't remeber old data
        ts_header = Nothing
        'sync_error = False
        adaptation = Nothing
        pes_header = Nothing
        video_header = Nothing
        table_header = Nothing

        decode_ts_header()

        ' stop here if we only need the header, saves time
        If full_decode = False Then Exit Sub

        ' reset
        Dim decode_result As String = Nothing
        packet_note1 = Nothing
        packet_note2 = Nothing
        dlgMain.viewer.Text = ""
        packet_note1 = decode_pid_value(ts_header.pid)

        Select Case ts_header.adaptation_control
            Case 0
                ' reserved
            Case 1
                ' no adaptation
                adaptation.length = 0
            Case 2, 3
                ' 2 = adaptation only for the rest of the packet
                ' 3 = adaptation followed by payload
                decode_result += decode_adaptation()
                decode_result += vbCrLf
                decode_result += vbCrLf
        End Select

        ' could this be the first packet in a table?
        If ts_header.payload_start = 1 And dlgTablePIDs.listPID.FindStringExact(ts_header.pid.ToString) <> -1 Then
            decode_result += decode_table_header()
        End If

        ' or the first packet in a PES?
        If ts_header.payload_start = 1 And ts_header.adaptation_control <> 2 Then
            If pes_start() = True Then
                packet_note1 = "PES start code found at byte " & adaptation.length + 4
                packet_note2 = decode_stream_id(ts_bytes(adaptation.length + 7))
                decode_result += decode_pes_header()
            End If
        End If

        ' some video perhaps?
        If pes_header.stream_id >= &HE0 And pes_header.stream_id <= &HEF Then
            decode_result += vbCrLf & vbCrLf & decode_video_header()
        End If

        ' show results?
        If display_results = True Then
            dlgMain.grp_packet.Text = "TS packet " & packet_to_decode
            dlgMain.viewer.Text = decode_result
            update_dlgMain() ' update ts headers
        End If

    End Sub

    Sub decode_ts_header()

        ' byte 0 : sync (0x47)
        ts_header.sync_byte = ts_bytes(0)
        ' bit 1 byte 1 : ts error indicator
        ts_header.transport_error = (ts_bytes(1) And 128) >> 7
        ' bit 2 byte 1 : payload start
        ts_header.payload_start = (ts_bytes(1) And 64) >> 6
        ' bit 3 byte 1 : transport priority
        ts_header.transport_priority = (ts_bytes(1) And 32) >> 5
        ' bit of byte 1 and byte 2 : pid
        ts_header.pid = (ts_bytes(1) And 31) << 8 Or ts_bytes(2)
        ' bit 1+2 of byte 3
        ts_header.scrambling_control = (ts_bytes(3) And 192) >> 6
        ' bit 3+4 of byte 4
        ts_header.adaptation_control = (ts_bytes(3) And 48) >> 4
        ' last 4 bits
        ts_header.continuity = (ts_bytes(3) And 15)

        If ts_header.sync_byte <> &H47 Then
            Dim result As DialogResult = MessageBox.Show("Error: TS sync byte not equal to 0x47." & vbCrLf & "Click OK to skip packet and continue." & vbCrLf & "Click Cancel to close the stream.", "Packet " & current_packet.ToString, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If result = vbOK Then move_next()
            If result = vbCancel Then stop_search = True : ts_close()

            'sync_error = True

        End If

    End Sub

    Function decode_adaptation() As String

        Dim result As String = "Adaptation fields"

        adaptation.length = ts_bytes(4) + 1 ' add one, this value is used to skip over the adaptation fields when decoding other headers

        Debug.Print("Decode adaptation, length: " & adaptation.length)
        If adaptation.length > 184 Then
            ' should be 183 but we added one to the number above
            result = "Illegal adaptation length! Skipping..."
            adaptation.length = 0
            Return result
        End If

        ' remember which byte we're looking at in the table
        ' start at 5, the first byte after the length field

        Dim adapt_pointer As Integer = 5

        result += (vbCrLf & "   Adaptation_field_length: " & adaptation.length - 1)
        ' just one stuffing byte so nothing to decode
        If adaptation.length = 1 Then Return result

        adaptation.discontinuity_indicator = (IsBitSet(ts_bytes(5), 7))
        adaptation.random_access_indicator = (IsBitSet(ts_bytes(5), 6))
        adaptation.elementary_stream_priority_indicator = (IsBitSet(ts_bytes(5), 5))
        adaptation.PCR_flag = (IsBitSet(ts_bytes(5), 4))
        adaptation.OPCR_flag = (IsBitSet(ts_bytes(5), 3))
        adaptation.splicing_point_flag = (IsBitSet(ts_bytes(5), 2))
        adaptation.transport_private_data_flag = (IsBitSet(ts_bytes(5), 1))
        adaptation.adaptation_field_extension_flag = (IsBitSet(ts_bytes(5), 0))

        adapt_pointer += 1

        result += (vbCrLf & "   discontinuity_indicator: " & adaptation.discontinuity_indicator)
        result += (vbCrLf & "   random_access_indicator: " & adaptation.random_access_indicator)
        result += (vbCrLf & "   ES_priority_indicator: " & adaptation.elementary_stream_priority_indicator)
        result += (vbCrLf & "   PCR_flag: " & adaptation.PCR_flag)
        result += (vbCrLf & "   OPCR_flag: " & adaptation.OPCR_flag)
        result += (vbCrLf & "   splicing_point_flag: " & adaptation.splicing_point_flag)
        result += (vbCrLf & "   transport_private_data_flag: " & adaptation.transport_private_data_flag)
        result += (vbCrLf & "   adaptation_field_extension_flag: " & adaptation.adaptation_field_extension_flag)

        If adaptation.PCR_flag = True Then

            decode_PCR(adapt_pointer)
            adapt_pointer += 6
            result += (vbCrLf & "   PCR: " & adaptation.PCR)

        End If

        If adaptation.OPCR_flag = True Then

            decode_PCR(adapt_pointer)
            adapt_pointer += 6
            result += (vbCrLf & "   OPCR: " & adaptation.PCR)

        End If

        If adaptation.splicing_point_flag = True Then

            result += (vbCrLf & "   Splice_countdown: " & ts_bytes(adapt_pointer))
            adapt_pointer += 1

        End If

        If adaptation.transport_private_data_flag = True Then

            adaptation.transport_private_data_length = ts_bytes(adapt_pointer)
            adapt_pointer += 1
            result += (vbCrLf & "   Transport_private_data_length: " & adaptation.transport_private_data_length)

            For j As Integer = 1 To adaptation.transport_private_data_length

                result += (vbCrLf & "      private_data_byte: " & ts_bytes(adapt_pointer))
                adapt_pointer += 1

            Next

        End If

        ' TODO adaptation headers
        '
        ' adaptation extension

        Return result

    End Function

    Function decode_pes_header() As String
        Debug.Print("decode pes header")

        Dim result As String = "PES header"

        pes_header.stream_id = ts_bytes(adaptation.length + 7)
        result += (vbCrLf & "   stream_id: " & Hex(pes_header.stream_id))
        result += (" (" & decode_stream_id(pes_header.stream_id) & ")")

        pes_header.PES_packet_length = ((ts_bytes(adaptation.length + 8) And 255) << 8) Or ts_bytes(adaptation.length + 9)
        result += (vbCrLf & "   PES_packet_length: " & pes_header.PES_packet_length)
        If pes_header.PES_packet_length = 0 Then
            result += (" (undefined)")
        End If

        If pes_header.stream_id <> &HBC And _
           pes_header.stream_id <> &HBE And _
           pes_header.stream_id <> &HBF And _
           pes_header.stream_id <> &HF0 And _
           pes_header.stream_id <> &HF1 And _
           pes_header.stream_id <> &HF2 And _
           pes_header.stream_id <> &HF8 And _
           pes_header.stream_id <> &HFF Then

            ' decode some PES headers
            ' TODO Reserved 10, 2bits
            ' TODO PES scrambling control, 2bits
            pes_header.PES_scrambling_control = (ts_bytes(adaptation.length + 10) And &H30) >> 4
            pes_header.PES_priority = IsBitSet(ts_bytes(adaptation.length + 10), 3)
            pes_header.data_alignment_indicator = IsBitSet(ts_bytes(adaptation.length + 10), 2)
            pes_header.copyright = IsBitSet(ts_bytes(adaptation.length + 10), 1)
            pes_header.original_or_copy = IsBitSet(ts_bytes(adaptation.length + 10), 0)

            pes_header.PTS_flag = IsBitSet(ts_bytes(adaptation.length + 11), 7)
            pes_header.DTS_flag = IsBitSet(ts_bytes(adaptation.length + 11), 6)
            pes_header.ESCR_flag = IsBitSet(ts_bytes(adaptation.length + 11), 5)
            pes_header.ES_rate_flag = IsBitSet(ts_bytes(adaptation.length + 11), 4)
            pes_header.DSM_trick_mode_flag = IsBitSet(ts_bytes(adaptation.length + 11), 3)
            pes_header.additional_copy_info_flag = IsBitSet(ts_bytes(adaptation.length + 11), 2)
            pes_header.PES_CRC_flag = IsBitSet(ts_bytes(adaptation.length + 11), 1)
            pes_header.PES_extension_flag = IsBitSet(ts_bytes(adaptation.length + 11), 0)

            pes_header.PES_header_data_length = ts_bytes(adaptation.length + 12)

            result += (vbCrLf & "   PES_scrambling: " & pes_header.PES_scrambling_control)
            result += (vbCrLf & "   PES_priority: " & pes_header.PES_priority)
            result += (vbCrLf & "   data_alignment: " & pes_header.data_alignment_indicator)
            result += (vbCrLf & "   copyright: " & pes_header.copyright)
            result += (vbCrLf & "   original_or_copy: " & pes_header.original_or_copy)
            result += (vbCrLf & "   PTS_flag: " & pes_header.PTS_flag)
            result += (vbCrLf & "   DTS_flag: " & pes_header.DTS_flag)
            result += (vbCrLf & "   ESCR_flag: " & pes_header.ESCR_flag)
            result += (vbCrLf & "   ES_rate_flag: " & pes_header.ES_rate_flag)
            result += (vbCrLf & "   DSM_trick_mode_flag: " & pes_header.DSM_trick_mode_flag)
            result += (vbCrLf & "   additional_copy_info_flag: " & pes_header.additional_copy_info_flag)
            result += (vbCrLf & "   PES_CRC_flag: " & pes_header.PES_CRC_flag)
            result += (vbCrLf & "   PES_extension_flag: " & pes_header.PES_extension_flag) ' Audio description
            result += (vbCrLf & "   PES_header_data_length: " & pes_header.PES_header_data_length)

            If pes_header.PTS_flag = True Then
                pes_header.PTS = decode_timestamp(adaptation.length + 13)
                result += (vbCrLf & "   PTS: " & pes_header.PTS)
            End If

            If pes_header.DTS_flag = True Then
                pes_header.DTS = decode_timestamp(adaptation.length + 18)
                result += (vbCrLf & "   DTS: " & pes_header.DTS)
            End If


            If pes_header.PES_extension_flag = True Then
                Debug.Print("Look for AD fade/pad data")
                Dim ad_start As Integer

                ' look for AD code "DTGA"
                ad_start = find_4bytes(0, &H44, &H54, &H47, &H41)
                If Not ad_start = CInt(False) Then
                    result += (vbCrLf & vbCrLf & "Audio Description start code found: " & ad_start)
                    result += (vbCrLf & "   AD_text_tag: " & Chr(ts_bytes(ad_start)) & Chr(ts_bytes(ad_start + 1)) & Chr(ts_bytes(ad_start + 2)) & Chr(ts_bytes(ad_start + 3)) & Chr(ts_bytes(ad_start + 4)))
                    result += (vbCrLf & "   AD_revision_text_tag: " & Hex(ts_bytes(ad_start + 5)))

                    audio_description.ad_fade = (ts_bytes(ad_start + 6))
                    audio_description.ad_pan = (ts_bytes(ad_start + 7))

                    result += (vbCrLf & "   AD_fade_byte: " & audio_description.ad_fade)
                    result += (vbCrLf & "   AD_pan_byte: " & audio_description.ad_pan)
                Else
                    audio_description.ad_fade = Nothing
                    audio_description.ad_pan = Nothing

                End If
            End If

        End If

        Return result

        ' this next line should move out of here I think
        ' If pes_header.stream_id >= &HE0 And pes_header.stream_id <= &HEF Then decode_video_header()

    End Function

    Function decode_video_header() As String

        Debug.Print("decode video headers")

        Dim result As String = "Video sequence"

        Dim afd_start, afd, sequence_header_code, user_data_start_code, group_start_code, picture_start_code, ar As Integer
        Dim hor_size, ver_size, frame_rate As Integer

        ' look for sequence start code B3 in video stream
        sequence_header_code = find_4bytes(0, 0, 0, 1, &HB3)

        If Not sequence_header_code = CInt(False) Then
            result += (vbCrLf & "Sequence header code (00 00 01 B3) found at " & sequence_header_code)

            hor_size = ((ts_bytes(sequence_header_code + 4) And &HFF) << 4) Or (ts_bytes(sequence_header_code + 5) And &HF0)
            ver_size = ((ts_bytes(sequence_header_code + 5) And &HF) << 8) Or (ts_bytes(sequence_header_code + 6) And &HFF)
            ar = ((ts_bytes(sequence_header_code + 7) And &HF0) >> 4)
            frame_rate = ((ts_bytes(sequence_header_code + 7) And &HF))

            result += (vbCrLf & "   horizontal_size: " & hor_size)
            result += (vbCrLf & "   vertical_size: " & ver_size)
            result += (vbCrLf & "   aspect_ratio: " & decode_ar(ar))
            result += (vbCrLf & "   frame_rate: " & decode_frame_rate(frame_rate))
            video_header.ar = decode_ar(ar)
        Else
            result += (vbCrLf & "Sequence header code not found in this packet")
            video_header.ar = "not found"
        End If

        ' look for user data B2
        user_data_start_code = find_4bytes(0, 0, 0, 1, &HB2)
        If Not user_data_start_code = CInt(False) Then
            result += (vbCrLf & "User data start code (00 00 01 B2) found at " & user_data_start_code)
        End If

        ' video streams may also have AFD
        afd_start = find_4bytes(0, &H44, &H54, &H47, &H31)

        If Not afd_start = CInt(False) Then
            Debug.Print("AFD found")

            afd = ts_bytes(afd_start + 5) And 15
            video_header.afd = afd.ToString
            video_header.description = decode_afd(afd)
            result += (vbCrLf & "AFD start code (44 54 47 31) found at " & afd_start)
            result += vbCrLf & "   AFD_identifier: " & Chr(ts_bytes(afd_start)) & Chr(ts_bytes(afd_start + 1)) & Chr(ts_bytes(afd_start + 2)) & Chr(ts_bytes(afd_start + 3))
            result += vbCrLf & "   active_format: " & afd
            result += vbCrLf & "   description: " & decode_afd(afd)
        Else
            Debug.Print("AFD not found in this packet, but it might be in the next one!`")
            result += (vbCrLf & "AFD not found in this packet")
            video_header.afd = "not found"
            video_header.description = Nothing
        End If

        ' look for group start code B8
        group_start_code = find_4bytes(0, 0, 0, 1, &HB8)

        If Not group_start_code = CInt(False) Then
            result += (vbCrLf & "Group start code (00 00 01 B8) found at " & group_start_code)
        End If

        ' look for picture start code 00
        picture_start_code = find_4bytes(0, 0, 0, 1, 0)

        If Not picture_start_code = CInt(False) Then
            result += (vbCrLf & "Picture start code (00 00 01 00) found at " & picture_start_code)

            If picture_start_code + 5 <= 188 Then
                video_header.temporal_reference = (ts_bytes(picture_start_code + 4) And &HFF) << 2 Or (ts_bytes(picture_start_code + 5) And &HC0) >> 6
                video_header.picture_type = Int((ts_bytes(picture_start_code + 5) And &H38) >> 3)
                'video_header.vbv_delay = (ts_bytes(picture_start_code + 5) And &H7) << 13 Or (ts_bytes(picture_start_code + 6) And &HFF) << 5 Or (ts_bytes(picture_start_code + 7) And &HF8) >> 3

                'Debug.Print((ts_bytes(picture_start_code + 5) And &H7) << 13)
                'Debug.Print((ts_bytes(picture_start_code + 6) And &HFF) << 5)
                'Debug.Print((ts_bytes(picture_start_code + 7) And &HF8) >> 3)

                result += (vbCrLf & "   temporal_reference: " & video_header.temporal_reference)
                result += (vbCrLf & "   picture_coding_type: " & video_header.picture_type)
                result += " " & decode_picture_type(video_header.picture_type)
                'result += (vbCrLf & "   vbv_delay: " & video_header.vbv_delay)
            End If
        End If
        Return result

    End Function

    Function find_4bytes(ByVal start_byte As Integer, ByVal s1 As Byte, ByVal s2 As Byte, ByVal s3 As Byte, ByVal s4 As Byte) As Integer

        Debug.Print("Looking for: " & s1 & s2 & s3 & s4)

        Do
            If ts_bytes(start_byte + 0) = s1 Then
                If ts_bytes(start_byte + 1) = s2 Then
                    If ts_bytes(start_byte + 2) = s3 Then
                        If ts_bytes(start_byte + 3) = s4 Then
                            Debug.Print("byte pattern: " & Hex(s1) & "-" & Hex(s2) & "-" & Hex(s3) & "-" & Hex(s4) & " found at " & start_byte)
                            Return start_byte
                            Exit Function
                        End If
                    End If
                End If
            End If

            start_byte = start_byte + 1

        Loop Until start_byte = 185

        Debug.Print("string " & s1 & s2 & s3 & s4 & " NOT found")
        Return CInt(False)

    End Function

    Sub displayHexBytes()

        ' Display the entire packet as 2 character hex bytes

        Dim b As Integer = 0
        Dim k As Integer = 1
        Dim s1, s2 As String
        s1 = Nothing
        s2 = Nothing

        For b = 0 To 3
            s2 += ts_bytes(b).ToString("X").PadLeft(2, Convert.ToChar("0"))
            s2 += " "
            k = k + 1
        Next

        For b = 4 To 187
            If dlgMain.ToolStripButton2.Checked = True Then

                If ts_bytes(b) < 127 Then
                    If ts_bytes(b) > 32 Then
                        s2 += Convert.ToChar(ts_bytes(b)) & " "
                    Else
                        s2 += ts_bytes(b).ToString("X").PadLeft(2, Convert.ToChar("0"))
                    End If
                Else
                    s2 += ts_bytes(b).ToString("X").PadLeft(2, Convert.ToChar("0"))
                End If
            Else
                s2 += ts_bytes(b).ToString("X").PadLeft(2, Convert.ToChar("0"))
            End If

            If k = 16 Then
                s2 += vbCrLf
                k = 1
            Else
                s2 += " "
                k = k + 1
            End If
        Next


        dlgMain.tbData.Text = s2

    End Sub

    Function pes_start() As Boolean

        ' Look for PES start code 0x00 0x00 0x01

        If ts_bytes(adaptation.length + 4) = 0 Then
            If ts_bytes(adaptation.length + 5) = 0 Then
                If ts_bytes(adaptation.length + 6) = 1 Then
                    Debug.Print("PES header 00 00 01 found.")
                    ' return true if found
                    Return True
                End If
            End If
        End If
        Debug.Print("PES header 00 00 01 NOT found.")
        ' return false if not found
        Return False

    End Function

    'Function table_start(ByVal p As Integer) As Boolean

    '    If ts_bytes(p + 4) = 0 Then
    '        Debug.Print("Table pointer found at " & p)
    '        Return True
    '    End If

    '    Return False

    'End Function


    Public Sub decode_PCR(ByVal pointer As Integer)

        ' PCR(i) = PCR_base(i) * 300 + PCR_ext(i)
        '
        ' PCR_base(i) = ((system_clock_f * t(i)) DIV 300) MOD 2^33
        ' 
        ' PCR_ext(i) = ((system_clock_f * t(i)) DIV 1) MOD 300
        '
        Dim PCR_base1, PCR_base2, PCR_base3, PCR_base4, PCR_base5, PCR_base As Long
        Dim PCR_ext As Long

        PCR_base1 = ts_bytes(pointer)
        PCR_base1 <<= 25

        PCR_base2 = ts_bytes(pointer + 1)
        PCR_base2 <<= 17

        PCR_base3 = ts_bytes(pointer + 2)
        PCR_base3 <<= 9

        PCR_base4 = ts_bytes(pointer + 3)
        PCR_base4 <<= 1

        PCR_base5 = (ts_bytes(pointer + 4) And 128) >> 7

        PCR_base = PCR_base1 + PCR_base2 + PCR_base3 + PCR_base4 + PCR_base5
        Debug.Print("PCR base: " & PCR_base)

        PCR_ext = ((ts_bytes(pointer + 4) And 1) << 8) + ts_bytes(pointer + 5)
        Debug.Print("PCR ext: " & PCR_ext)

        adaptation.PCR = (PCR_base * 300) + PCR_ext
        Debug.Print("PCR: " & adaptation.PCR)

    End Sub

    Function decode_timestamp(ByVal pointer As Integer) As Long

        ' Used to display PTS or DTS

        Dim timestamp As Long
        Dim b1 As Long
        Dim b2, b3, b4, b5 As Long

        ' 3 bits
        b5 = (ts_bytes(pointer) And &HE)
        b5 <<= 29
        'Debug.Print(b5)

        ' 8 bits
        b4 = ts_bytes(pointer + 1)
        b4 <<= 22
        'Debug.Print(b4)

        ' 7 bits
        b3 = (ts_bytes(pointer + 2) And &HFE)
        b3 <<= 14
        'Debug.Print(b3)

        ' 8 bits
        b2 = ts_bytes(pointer + 3)
        b2 <<= 7
        'Debug.Print(b2)

        ' 7 bits
        b1 = (ts_bytes(pointer + 4) And &HFE)
        b1 >>= 1
        'Debug.Print(b1)

        timestamp = b1 + b2 + b3 + b4 + b5
        Debug.Print("timestamp decode: " & timestamp)
        Return timestamp

    End Function

End Module
