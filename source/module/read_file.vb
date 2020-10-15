Option Explicit On
Option Strict On

Imports System.Diagnostics

Module read_file

    Public Sub read_ts_pkt(ByVal packet_to_read As Long, ByVal bytes_to_read As Integer)

        ' redraw things if needed
        dlgMain.Cursor = Cursors.WaitCursor
        Application.DoEvents()

        'Read bytes into ts_bytes array from the specified file.
        Dim packet_address As Long

        Try
            packet_address = pre_header + offset + ((packet_to_read - 1) * packet_size)
            'Debug.Print("read ts packet: " & packet_to_read & " at: " & packet_address)

            fs.Seek(packet_address, IO.SeekOrigin.Begin)
            fs.Read(ts_bytes, 0, bytes_to_read)

            'dlgProgress.pb1.Value = packet_to_read
            dlgMain.FileProgressBar.Value = CInt(packet_to_read)

        Catch Ex As Exception
            MessageBox.Show("Error reading TS packet " & packet_to_read & " from file." & vbCr & Ex.Message, Application.ProductName)
            stop_search = True
        Finally
            dlgMain.Cursor = Cursors.Arrow
        End Try

    End Sub

    'Public Sub read_next_ts_pkt(ByVal bytes_to_read As Integer)

    '    ' redraw things if needed
    '    dlgMain.Cursor = Cursors.WaitCursor

    '    'Application.DoEvents()

    '    Try
    '        ' read some bytes from current position
    '        fs.Read(ts_bytes, 0, bytes_to_read)
    '        ' move forward to start of next packet
    '        fs.Seek(188 - bytes_to_read, IO.SeekOrigin.Current)

    '        dlgMain.FileProgressBar.PerformStep()

    '    Catch Ex As Exception
    '        MessageBox.Show("Error reading TS packet from file." & vbCr & Ex.Message, Application.ProductName)
    '        stop_search = True
    '    Finally
    '        dlgMain.Cursor = Cursors.Arrow
    '    End Try

    'End Sub

    ' Dim fs As New FileStream("c:\data\transport streams\mux1.ts", FileMode.Open, FileAccess.Read)
    ' Dim ip_file As New BinaryReader(fs)

    'Sub read_input_file(ByVal pkt As Integer)

    '    ' this function is only used when opening files a packet or byte at a time

    '    Debug.Print("read_input_file - packet " & pkt)

    '    ' check for end of file
    '    If pkt > max_packets Then
    '        MsgBox("End of input file", MsgBoxStyle.Exclamation)
    '        'Return False
    '        Exit Sub
    '    End If

    '    If pkt = 0 Then
    '        MsgBox("Packet number not valid", MsgBoxStyle.Critical)
    '        'Return False
    '        Exit Sub
    '    End If

    '    Try
    '        ' read data into raw_packet and update main dlg
    '        'FileGet(1, raw_packet, pkt)
    '        'ip_file.readbytes(188)

    '        'raw_packet = ip_file.ReadBytes(188)

    '        'dlgMain.tbTSaddress.Text = pkt
    '        dlgMain.FileProgressBar.Value = pkt
    '    Catch Ex As Exception
    '        ' Some kind of error occurred. Report error and clear collection.
    '        FileClose(1)
    '        MsgBox(Ex.Message & " File closed (read_input_file)", MsgBoxStyle.Critical)
    '        dlgMain.status1.Text = "Ready."
    '        'Return False
    '    End Try

    '    'Return True
    'End Sub
End Module
