Module decode_data

    'Public Function get_data(ByVal bit_length As Integer, ByVal start_byte As Integer, ByVal start_bit As Integer) As Integer

    '    Dim t, j, shift As Integer
    '    Dim mask As Double = 0

    '    If start_byte > 187 Then
    '        MsgBox("get_data : start byte out of range - " & start_byte)
    '        Exit Function
    '    End If

    '    ' bits within a single byte
    '    If bit_length <= 8 Then
    '        ' generate mask, which is setting the bits we need to 1 and the rest to 0
    '        For j = 1 To bit_length
    '            mask = mask + 2 ^ (start_bit - j)
    '        Next
    '        ' shift to the right to get real value
    '        shift = start_bit - bit_length
    '        ' do the calculation
    '        't = (raw_packet(start_byte) And mask) >> shift
    '        t = (ts_bytes(start_byte) And mask) >> shift
    '        ' check result
    '        'Debug.Print("mask: " & mask & " shift: " & shift & " data: " & t)
    '        Return t
    '    End If

    '    ' bits split over 2 bytes
    '    If bit_length > 8 And bit_length <= 16 Then
    '        Dim byte1, byte2, byte1_len, byte2_len As Integer
    '        byte1_len = bit_length - 8
    '        byte2_len = 8 ' this only works when the bit string fills the second byte

    '        ' sort out byte 1
    '        For j = 1 To byte1_len
    '            mask = mask + 2 ^ (start_bit - j)
    '        Next
    '        ' shift up, assuming the next byte is full
    '        'byte1 = (raw_packet(start_byte) And mask) << 8
    '        byte1 = (ts_bytes(start_byte) And mask) << 8

    '        ' now do byte 2, no need to mask if we assume the second byte is full
    '        'byte2 = (raw_packet(start_byte + 1))
    '        byte2 = (ts_bytes(start_byte + 1))

    '        ' put it together
    '        t = byte1 Or byte2
    '        Return t

    '    End If

    '    Return -1
    'End Function

    'Function get_bit(ByVal bit As Integer, ByVal input As Byte) As Integer

    '    Dim out_bit As String
    '    Dim mask, shift As Integer

    '    Debug.Print("decode bit  " & bit & " from " & input)

    '    ' calculate shift to right
    '    shift = 8 - bit

    '    ' calculate a mask to make all other bits zero
    '    mask = 2 ^ shift

    '    ' do the calculation
    '    out_bit = (input And mask) >> shift

    '    Debug.Print("out_bit: " & out_bit)

    '    Return out_bit

    'End Function

    'Function byte_to_binary(ByVal input As Integer)

    '    Dim b As Integer = 0
    '    Dim output As String = Nothing

    '    For b = 1 To 8
    '        output += (get_bit(b, input))
    '    Next

    '    Return output

    'End Function

    'Sub debug_get_data()

    '    'Debug.Print("current byte: " & current_byte)
    '    'Debug.Print("current bit : " & current_bit)
    '    Dim raw_bytes(188) As Byte
    '    raw_bytes(0) = &H47
    '    raw_bytes(1) = &HFF
    '    raw_bytes(2) = &HF2
    '    raw_bytes(3) = &HF3
    '    raw_bytes(4) = &HF4
    '    raw_bytes(5) = &HF5
    '    raw_bytes(6) = &HF6
    '    raw_bytes(7) = &HF7
    '    raw_bytes(8) = &HF8
    '    raw_bytes(9) = &HF9
    '    raw_bytes(10) = &HFA
    '    raw_bytes(11) = &HFB
    '    raw_bytes(12) = &HFC
    '    raw_bytes(13) = &HFD
    '    raw_bytes(14) = &HFE
    '    raw_bytes(15) = &HFF

    '    'Debug.Print(raw_bytes(start_byte))
    '    Debug.Print("BIT LENGTH 1")
    '    Dim b As Integer
    '    For b = 1 To 8
    '        get_data(1, 1, b)
    '    Next

    '    Debug.Print("BIT LENGTH 2")
    '    For b = 2 To 8
    '        get_data(2, 1, b)
    '    Next

    '    Debug.Print("BIT LENGTH 3")
    '    For b = 3 To 8
    '        get_data(3, 1, b)
    '    Next

    '    Debug.Print("BIT LENGTH 4")
    '    For b = 4 To 8
    '        get_data(4, 1, b)
    '    Next

    '    Debug.Print("BIT LENGTH 5")
    '    For b = 5 To 8
    '        get_data(5, 1, b)
    '    Next

    '    Debug.Print("BIT LENGTH 8")
    '    get_data(8, 1, 8)
    'End Sub

End Module
