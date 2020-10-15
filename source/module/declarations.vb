Imports System
Imports System.IO

' Setup global variables and structures

Module declarations

    Public offset As Integer = 0
    Public pre_header As Integer = 0
    Public current_packet As Integer = 0
    Public max_packets As Integer = 0
    Public packet_size As Integer = 0
    Public pids_known As Boolean = False
    Public pids(8192) As Integer
    Public ts_bytes() As Byte ' array to hold 188 bytes (0 to 187)
    'Public sync_error As Boolean = False
    Public filepath As String
    Public fs As FileStream

    Public packet_note1 As String
    Public packet_note2 As String
    Public stop_search As Boolean = False

    Public Structure ts_header_structure
        Public sync_byte As Integer
        Public transport_error As Integer
        Public payload_start As Integer
        Public transport_priority As Integer
        Public pid As Integer
        Public scrambling_control As Integer
        Public adaptation_control As Integer
        Public continuity As Integer
        'Public adaptation_field_length As Integer
    End Structure

    Public Structure adaptation_structure
        Public length As Integer
        Public discontinuity_indicator As Boolean
        Public random_access_indicator As Boolean
        Public elementary_stream_priority_indicator As Boolean
        Public PCR_flag As Boolean
        Public OPCR_flag As Boolean
        Public splicing_point_flag As Boolean
        Public transport_private_data_flag As Boolean
        Public adaptation_field_extension_flag As Boolean
        Public transport_private_data_length As Integer
        Public adaptation_field_extension_length As Integer
        'Public PCR_base As Long
        'Public PCR_ext As Long
        Public PCR As Long
    End Structure

    Public Structure PES_header_structure
        Public start_code As Integer
        Public stream_id As Byte
        Public PES_packet_length As Integer
        Public PES_scrambling_control As Integer
        Public PES_priority As Boolean
        Public data_alignment_indicator As Boolean
        Public copyright As Boolean
        Public original_or_copy As Boolean
        Public PTS_flag As Boolean
        Public DTS_flag As Boolean
        Public ESCR_flag As Boolean
        Public ES_rate_flag As Boolean
        Public DSM_trick_mode_flag As Boolean
        Public additional_copy_info_flag As Boolean
        Public PES_CRC_flag As Boolean
        Public PES_extension_flag As Boolean
        Public PES_header_data_length As Byte
        Public PTS As Long
        Public DTS As Long
    End Structure

    Public Structure table_header_structure
        Public pointer_field As Integer
        Public table_id As Integer
        Public section_syntax_indicator As Boolean
        Public section_length As Integer
        Public sub_table_id As Integer
        Public version_number As Integer
        Public current_next As Boolean
        Public section_number As Integer
        Public last_section_number As Integer
    End Structure

    Public Structure video_header_structure
        Public ar As String
        Public afd As String
        Public description As String
        Public temporal_reference As Integer
        Public picture_type As Integer
        Public vbv_delay As Integer
    End Structure

    Public Structure audio_description_structure
        Public ad_fade As Byte
        Public ad_pan As Byte
    End Structure

    Public ts_header As ts_header_structure
    Public adaptation As adaptation_structure
    Public pes_header As PES_header_structure
    Public table_header As table_header_structure
    Public video_header As video_header_structure
    Public audio_description As audio_description_structure

End Module


