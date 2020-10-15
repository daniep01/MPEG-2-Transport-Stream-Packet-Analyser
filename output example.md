# Example video decoding from MPEG-2 Transport Stream packet analyser
```
Adaptation fields
   Adaptation_field_length: 7
   discontinuity_indicator: False
   random_access_indicator: True
   ES_priority_indicator: False
   PCR_flag: True
   OPCR_flag: False
   splicing_point_flag: False
   transport_private_data_flag: False
   adaptation_field_extension_flag: False
   PCR: 1335803661212

PES header
   stream_id: E0 (video stream 224)
   PES_packet_length: 0 (undefined)
   PES_scrambling: 0
   PES_priority: True
   data_alignment: False
   copyright: False
   original_or_copy: False
   PTS_flag: True
   DTS_flag: True
   ESCR_flag: False
   ES_rate_flag: False
   DSM_trick_mode_flag: False
   additional_copy_info_flag: False
   PES_CRC_flag: False
   PES_extension_flag: False
   PES_header_data_length: 11
   PTS: 4452723280
   DTS: 4452712480

Video sequence
Sequence header code (00 00 01 B3) found at 32
   horizontal_size: 720
   vertical_size: 576
   aspect_ratio: 16:9
   frame_rate: 25
User data start code (00 00 01 B2) found at 143
AFD start code (44 54 47 31) found at 147
   AFD_identifier: DTG1
   active_format: 14
   description: 16:9 (with shoot &amp; protect 14:9 centre)
Group start code (00 00 01 B8) found at 118
Picture start code (00 00 01 00) found at 126
   temporal_reference: 2
   picture_coding_type: 1 Intra (I)
   vbv_delay: 65535
```