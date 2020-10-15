Module lookup
    Function decode_adaptation_type(ByVal a As Integer) As String

        Select Case a
            Case 0
                Return "Reserved for future use by ISO/IEC"
            Case 1
                Return "No adaptation field, payload only"
            Case 2
                Return "Adaptation field only, no payload"
            Case 3
                Return "Adaptation field followed by payload"
            Case Else
                Return "Unknown adaptation field code"
        End Select

    End Function
    Function decode_pid_value(ByVal pid As Integer) As String
        ' taken from EN 300 468 v1.6.1, section 5.1.3
        Dim description As String

        Select Case pid
            Case 0
                description = "PAT"
            Case 1
                description = "CAT"
            Case 2
                description = "TSDT"
            Case 3 To &HF
                description = "reserved"
            Case &H10
                description = "NIT"
            Case &H11
                description = "SDT/BAT"
            Case &H12
                description = "EIT"
            Case &H13
                description = "RST"
            Case &H14
                description = "TDT/TOT"
            Case &H15
                description = "network synchronization"
            Case &H16
                description = "RNT"
            Case &H17 To &H1B
                description = "reserved for future use"
            Case &H1C
                description = "inband signalling"
            Case &H1D
                description = "measurement"
            Case &H1E
                description = "DIT"
            Case &H1F
                description = "SIT"
            Case &H20
                description = "PID32 (UK DTG)"
            Case &H1FFF
                description = "null packet"
            Case Else
                description = ""
        End Select
        Return description
    End Function
    Function decode_afd(ByVal afd_code As Integer) As String

        ' complete list from TS 101 154
        ' codes 0-7 not defined in D-Book

        Dim description As String = Nothing

        Select Case afd_code
            Case 0
                description += "AFD unknown"
            Case 1
                description += "Reserved"
            Case 2
                description += "box 16:9 (top)"
            Case 3
                description += "box 14:9 (top)"
            Case 4
                description += "box 16:9 (centre)"
            Case 5
                description += "Reserved"
            Case 6
                description += "Reserved"
            Case 7
                description += "Reserved"
            Case 8
                description += "Active region is the same as the coded frame"
            Case 9
                description += "4:3"
            Case 10
                description += "16:9"
            Case 11
                description += "14:9"
            Case 12
                description += "Reserved"
            Case 13
                description += "4:3 (with shoot and protect 14:9 centre)"
            Case 14
                description += "16:9 (with shoot & protect 14:9 centre)"
            Case 15
                description += "16:9 (with shoot & protect 4:3 centre)"
            Case Else
                description += "unknown or invalid"
        End Select

        Return description

    End Function
    Function decode_table_id(ByVal table_id As Integer) As String
        Dim description As String
        ' EN 300 468 v1.9.1
        Select Case table_id
            Case &H0
                description = "program_association_section"
            Case &H1
                description = "conditional_access_section"
            Case &H2
                description = "program_map_section"
            Case &H3
                description = "transport_stream_description_section"
            Case &H4 To &H3A
                description = "reserved"
            Case &H3B
                description = "DSM-CC DSI or DII" ' ETSI TR 101 202 V1.2.1
            Case &H3C
                description = "DSM-CC DDB" ' ETSI TR 101 202 V1.2.1
            Case &H3D
                description = "reserved"
            Case &H3E
                description = "reserved"
            Case &H3F
                description = "reserved"
            Case &H40
                description = "network_information_section - actual_network"
            Case &H41
                description = "network_information_section - other_network"
            Case &H42
                description = "service_description_section - actual_transport_stream"
            Case &H43 To &H45
                description = "reserved for future use"
            Case &H46
                description = "service_description_section - other_transport_stream"
            Case &H47 To &H49
                description = "reserved for future use"
            Case &H4A
                description = "bouquet_association_section"
            Case &H4B To &H4D
                description = "reserved for future use"
            Case &H4E
                description = "event_information_section - actual_transport_stream, present/following"
            Case &H4F
                description = "event_information_section - other_transport_stream, present/following"
            Case &H50 To &H5F
                description = "event_information_section - actual_transport_stream, schedule"
            Case &H60 To &H6F
                description = "event_information_section - other_transport_stream, schedule"
            Case &H70
                description = "time_date_section"
            Case &H71
                description = "running_status_section"
            Case &H72
                description = "stuffing_section"
            Case &H73
                description = "time_offset_section"
            Case &H74
                description = "application_information_section"
            Case &H75
                description = "container_section"
            Case &H76
                description = "related_content_section"
            Case &H77
                description = "content_identifier_section"
            Case &H78
                description = "MPE-FEC_section"
            Case &H79
                description = "resolution_notification_section"
            Case &H7A To &H7D
                description = "reserved for future use"
            Case &H7E
                description = "discontinuity_information_section"
            Case &H7F
                description = "selection_information_section"
            Case &H80 To &HFE
                description = "user defined"
            Case &HFF
                description = "reserved"
            Case Else
                description = "unknown table_id"
        End Select

        Return description

    End Function

    Function decode_stream_id(ByVal id As Integer) As String
        Dim description As String

        Select Case id
            Case &HBC
                description = "program stream map"
            Case &HBD
                description = "private stream 1"
            Case &HBE
                description = "padding stream"
            Case &HBF
                description = "private stream 2"
            Case &HC0 To &HDF
                description = "audio stream " & (id)
            Case &HE0 To &HEF
                description = "video stream " & (id)
            Case &HF0
                description = "ECM stream"
            Case &HF1
                description = "EMM stream"
            Case &HF2
                description = "DSMCC stream"
            Case &HF3
                description = "ISO/IEC 13522 stream"
            Case &HF4
                description = "H.222.1 type A"
            Case &HF5
                description = "H.222.1 type B"
            Case &HF6
                description = "H.222.1 type C"
            Case &HF7
                description = "H.222.1 type D"
            Case &HF8
                description = "H.222.1 type E"
            Case &HF9
                description = "ancillary stream"
            Case &HFA
                description = "SL-packetized stream"
            Case &HFB
                description = "FlexMux stream"
            Case &HFC To &HFE
                description = "reserved data stream"
            Case &HFF
                description = "program stream directory"
            Case Else
                description = "unknown stream type"
        End Select

        Return description

    End Function

    Function decode_start_code(ByVal start_code As Integer) As String

        Dim description As String

        Select Case start_code

            Case &H0
                description = "picture start code"
            Case &H1 To &HAF
                description = "slice start code"
            Case &HB0
                description = "reserved"
            Case &HB1
                description = "reserved"
            Case &HB2
                description = "user data start code"
            Case &HB3
                description = "sequence header code"
            Case &HB4
                description = "sequence error code"
            Case &HB5
                description = "extension start code"
            Case &HB6
                description = "reserved"
            Case &HB7
                description = "sequence end code"
            Case &HB8
                description = "group start code"
            Case Else
                description = "other/system start code"
        End Select

        Return description

    End Function

    Function decode_ar(ByVal ar_lookup As Integer) As String

        Dim description As String

        Select Case ar_lookup
            Case 0
                description = "forbidden"
            Case 1
                description = "square samples"
            Case 2
                description = "4:3"
            Case 3
                description = "16:9"
            Case 3
                description = "2.21:1"
            Case Else
                description = "reserved"
        End Select

        Return description

    End Function

    Function decode_frame_rate(ByVal frame_lookup As Integer) As String

        Dim description As String

        Select Case frame_lookup
            Case 0
                description = "forbidden"
            Case 1
                description = "23.976"
            Case 2
                description = "24"
            Case 3
                description = "25"
            Case 4
                description = "29.97"
            Case 5
                description = "30"
            Case 6
                description = "50"
            Case 7
                description = "59.94"
            Case 8
                description = "60"
            Case Else
                description = "reserved"
        End Select

        Return description

    End Function

    Function decode_picture_type(ByVal pic_type As Integer) As String

        Dim description As String

        Select Case pic_type
            Case 0
                description = "Forbidden"
            Case 1
                description = "Intra (I)"
            Case 2
                description = "Predictive (P)"
            Case 3
                description = "Bidirectionally-predictive (B)"
            Case 4
                description = "Shall not be used (D)"
            Case 5, 6, 7
                description = "Reserved"
            Case Else
                description = "unknown"
        End Select

        Return description

    End Function

    Function decode_picture_type_short(ByVal pic_type As Integer) As String
        Dim description As String

        Select Case pic_type
            Case 1
                description = "I"
            Case 2
                description = "P"
            Case 3
                description = "B"
            Case 4
                description = "D"
            Case Else
                description = "not found"
        End Select

        Return description

    End Function
End Module
