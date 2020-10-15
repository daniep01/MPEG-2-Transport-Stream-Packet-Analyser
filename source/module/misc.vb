Module misc

    Sub ts_close()

        If fs IsNot Nothing Then
            Debug.Print(fs.Name & " will be closed")
            fs.Close()
            fs.Dispose()
        End If

        clear_dlg()
        reset()
        dlgMain.setup_buttons(False)

    End Sub
    Sub reset()
        Debug.Print("RESET //////////////////////")

        pids_known = False
        ts_header = Nothing
        adaptation = Nothing
        pes_header = Nothing
        table_header = Nothing
        video_header = Nothing
        max_packets = 0
        current_packet = 1

        filepath = ""

        For j As Integer = 0 To 8191
            pids(j) = 0
        Next

    End Sub
    Sub update_dlgMain()

        ' don't display nothing, check first
        If packet_size = 0 Then Exit Sub

        ' ts header
        ' check options for dec/hex display
        If dlgOptions.rSyncDec.Checked = True Then dlgMain.tbTSSync.Text = ts_header.sync_byte.ToString Else dlgMain.tbTSSync.Text = "0x" & Hex(ts_header.sync_byte)
        dlgMain.tbTSerror.Text = ts_header.transport_error.ToString
        dlgMain.tbTSpayloadstart.Text = ts_header.payload_start.ToString
        dlgMain.tbTSpriority.Text = ts_header.transport_priority.ToString
        If dlgOptions.rPidDec.Checked = True Then dlgMain.tbTSpid.Text = ts_header.pid.ToString Else dlgMain.tbTSpid.Text = "0x" & Hex(ts_header.pid)
        dlgMain.tbTSscrambling.Text = ts_header.scrambling_control.ToString
        dlgMain.tbTSadaptation.Text = ts_header.adaptation_control.ToString
        If dlgOptions.rContinuityDec.Checked = True Then dlgMain.tbTScontinuity.Text = ts_header.continuity.ToString Else dlgMain.tbTScontinuity.Text = "0x" & Hex(ts_header.continuity)

        ' adaptation 
        dlgMain.tbAdaptationType.Text = decode_adaptation_type(ts_header.adaptation_control)
        dlgMain.tbAdaptationLength.Text = adaptation.length.ToString

        ' hex view
        displayHexBytes()

        ' notes
        dlgMain.tbPacketNote1.Text = packet_note1
        dlgMain.tbPacketNote2.Text = packet_note2

    End Sub
    Sub clear_dlg()

        ' called from flie_open and file_close sub
        Debug.Print("clear_dlg")

        ' main
        dlgMain.tbData.Text = Nothing
        dlgMain.viewer.Text = Nothing
        dlgMain.grp_packet.Text = "TS packet"

        dlgMain.cboxPayloadStart.Checked = False
        dlgMain.cboxPID.Checked = False
        dlgMain.tbPidFilter.Text = Nothing

        dlgMain.cboxPID.Focus()

        'ts
        dlgMain.tbTSadaptation.Text = Nothing
        dlgMain.tbTScontinuity.Text = Nothing
        dlgMain.tbTSerror.Text = Nothing
        dlgMain.tbTSpayloadstart.Text = Nothing
        dlgMain.tbTSpid.Text = Nothing
        dlgMain.tbTSpriority.Text = Nothing
        dlgMain.tbTSscrambling.Text = Nothing
        dlgMain.tbTSSync.Text = Nothing
        dlgMain.tbAdaptationType.Text = Nothing
        dlgMain.tbAdaptationLength.Text = Nothing
        dlgMain.tbPacketNote1.Text = Nothing
        dlgMain.tbPacketNote2.Text = Nothing

        'file
        dlgMain.tbPath.Text = Nothing
        dlgMain.tbSize.Text = Nothing
        dlgMain.FileProgressBar.Value = 0

        ' goto
        dlgGoto.tbPacket.Text = "1"

        ' pid list
        dlgPIDlist.listviewPID.Items.Clear()

        ' demux
        dlgDemux.lbPIDdest.Items.Clear()
        dlgDemux.lbPIDsource.Items.Clear()
        dlgDemux.txt_trimbegin.Text = "1"
        dlgDemux.txt_trimend.Text = Nothing
        dlgDemux.txt_trimoutput.Text = Nothing
        dlgDemux.radio_outputtrim1.Checked = True
        dlgDemux.txt_trimoutput.Enabled = False
        dlgDemux.cb_188ByteOutput.Checked = False

        ' spacing
        dlgSpacing.txt_analysed.Text = Nothing
        dlgSpacing.txt_max.Text = Nothing
        dlgSpacing.txt_min.Text = Nothing
        dlgSpacing.txt_pktfound.Text = Nothing
        dlgSpacing.txt_spacingpid.Text = Nothing

        'plot
        'dlgPlot.txtFirst.Text = 1
        ' dlgPlot.txtLast.Text = 100
        ' dlgPlot.panel1.BackColor = Color.FromArgb(&HFF, 175, 175, 175)

    End Sub


    Function get2bytes(ByVal start As Integer) As Integer

        Dim output As Integer
        output = (ts_bytes(start) And 255) << 8 Or ts_bytes(start + 1)
        'Debug.Print(Hex(ts_bytes(start)) & Hex(ts_bytes(start + 1)) & " = " & output)
        Return output

    End Function

    Public Function IsBitSet(ByVal InByte As Integer, ByVal Bit As Integer) As Boolean

        IsBitSet = ((InByte And (2 ^ Bit)) > 0)

    End Function

    Public Sub debug_byte_to_binary(ByVal inbyte As Byte)
        Dim j As Integer

        For j = 0 To 7
            Debug.Print(inbyte & ":" & 2 ^ j & ":" & IsBitSet(inbyte, j))
        Next

    End Sub

    Function check_start_end(ByVal s As Integer, ByVal e As Integer) As Boolean

        If s < 1 Then
            MsgBox("Start packet must be at least 1.", MsgBoxStyle.Critical)
            Return False
        End If

        If s > max_packets Then
            MsgBox("Start packet must be less than " & max_packets & ".", MsgBoxStyle.Critical)
            Return False
        End If

        If s > e Then
            MsgBox("Start packet must be less than end packet.", MsgBoxStyle.Critical)
            Return False
        End If

        If e > max_packets Then
            MsgBox("End packet must be less than or equal to " & max_packets & ".", MsgBoxStyle.Critical)
            Return False
        End If

        Return True

    End Function
End Module
