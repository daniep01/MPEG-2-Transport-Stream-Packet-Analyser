Module utc

    Function hex_byte_format(ByVal b As Integer) As String

        Dim t1, t2 As String
        t1 = Nothing
        t2 = Nothing

        t1 = String.Format("{0,2:X}", ts_bytes(b))

        If Left(t1, 1) = " " Then
            t2 += "0" & Right(t1, 1)
        Else
            t2 = t1
        End If

        Return t2

    End Function

    Function decode_time(ByVal start_byte As Integer) As String


        Dim t As String

        t = hex_byte_format(start_byte) & ":" & hex_byte_format(start_byte + 1) & ":" & hex_byte_format(start_byte + 2)

        Debug.Print("time>" & t)
        Return t

    End Function

    Function decode_date(ByVal start_byte As Integer) As String

        Dim utc_date As String

        Dim mjd As Long
        Dim d, y, m, y1, m1, k As Double

        mjd = get2bytes(start_byte)


        y1 = Int((mjd - 15078.2) / 365.25)
        m1 = Int((mjd - 14956.1 - Int(y1 * 365.25)) / 30.6001)
        d = mjd - 14956 - Int(y1 * 365.25) - Int(m1 * 30.6001)

        If m1 = 14 Or m1 = 15 Then
            k = 1
        Else
            k = 0
        End If

        y = y1 + k + 1900
        m = m1 - 1 - k * 12

        't = (ts_bytes(start_byte + 2)) & ":" & (ts_bytes(start_byte + 3)) & ":" & (ts_bytes(start_byte + 4))

        utc_date = d & "/" & m & "/" & y ' & " " & t
        Debug.Print("date>" & utc_date)
        Return utc_date

    End Function


End Module
