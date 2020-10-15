Imports System
Imports System.IO
Imports System.Convert
Imports System.Collections.Generic
Imports System.Collections.ObjectModel



Public Class dlgReport

    Dim export_stop As Boolean = False

    Private Sub Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        SaveReport.DefaultExt = ".csv"
        SaveReport.AddExtension = True

        If SaveReport.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txt_Filepath.Text = SaveReport.FileName
        End If

    End Sub

    Private Sub Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Hide()
    End Sub

    Private Sub Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Start.Click

        Debug.Print("start report generation")
        Dim start_pkt, end_pkt, count_pkt, last_pkt, delta_pkt As Integer
        Dim pid_list_s() As String = Nothing ' array to split string 
        Dim pid_list_i() As Integer = Nothing ' array to hold values as integers
        Dim this_pkt As Integer
        Dim delta_time As Long
        Dim k As Integer ' counter
        Dim this_time, last_time As Date
        Dim skip_packet As Boolean
        Dim out, tables As String
        Dim tables_history As New Collection(Of String)

        ' verify inputs
        Try
            start_pkt = ToInt32(txt_Start.Text)
            end_pkt = ToInt32(txt_End.Text)
        Catch exp As System.Exception
            MsgBox(exp.Message & " Invalid input in range filter.", MsgBoxStyle.Critical)
            Exit Sub
        End Try

        If check_start_end(start_pkt, end_pkt) = False Then Exit Sub

        ' reset progress bar
        ToolStrip_Progress.Minimum = start_pkt
        ToolStrip_Progress.Maximum = end_pkt
        ToolStrip_Progress.Value = start_pkt
        count_pkt = 0

        ' check pid filters
        ' split string and then convert to integer array
        If cb_PIDfilter.Checked = True Then
            Try
                pid_list_s = Split(tb_pid.Text, ",")
                ReDim pid_list_i(UBound(pid_list_s))
                Debug.Print("PID list for report:")
                For k = 0 To UBound(pid_list_s)
                    pid_list_i(k) = ToInt16(pid_list_s(k))
                    Debug.Print(pid_list_i(k).ToString)
                Next
            Catch exp As System.Exception
                MsgBox(exp.Message & " Cannot parse PID list.", MsgBoxStyle.Critical)
                Exit Sub
            End Try
        End If

        ' create new fle
        Try
            Debug.Print("file create: " & txt_Filepath.Text)

            Using sw As StreamWriter = New StreamWriter(txt_Filepath.Text)


                ' preamble if required
                If cb_preamble_time.Checked = True Then
                    sw.WriteLine("Report created: " & Now())
                End If

                If cb_preamble_filepath.Checked = True Then
                    sw.WriteLine("Export from: " & filepath)
                End If

                ' sort out csv headers...
                sw.WriteLine(csv_headers())

                ' sort out dialog buttons
                export_stop = False
                btn_Stop.Enabled = True
                btn_Start.Enabled = False
                btn_close.Enabled = False

                ' loop through all the packets
                For this_pkt = start_pkt To end_pkt

                    ' check for stop button presed
                    If export_stop = True Then Exit For

                    ' reset
                    skip_packet = False
                    ' look at the packet header, don't display to gui
                    decode_ts_packet(True, False, this_pkt)
                    Debug.Print("pid: " & ts_header.pid & " payload start: " & ts_header.payload_start & " adaption: " & ts_header.adaptation_control)
                    ToolStrip_Progress.Value = this_pkt

                    ' check if we want this packet in the output
                    If cb_PIDfilter.Checked = True Then
                        If Array.IndexOf(pid_list_i, ts_header.pid) = -1 Then
                            skip_packet = True
                        End If
                    End If

                    If cb_PayloadFilter.Checked = True Then
                        If ts_header.payload_start = 0 Then
                            skip_packet = True
                        End If
                    End If

                    If cb_adaptation_filter.Checked = True Then
                        If ts_header.adaptation_control = 1 Then
                            skip_packet = True
                        End If
                    End If

                    If cb_pcr_filter.Checked = True Then
                        If adaptation.PCR_flag = False Then
                            skip_packet = True
                        End If
                    End If

       

                    If skip_packet = False Then
                        ' do the full decoding
                        Debug.Print("> packet match, adding to report...")
                        'decode_ts_packet(True, False, this_pkt)
                        ' write to file, checking for check box status
                        out = this_pkt.ToString
                        
                        ' TS headers
                        If cb_PID.Checked = True Then
                            out += "," & ts_header.pid
                        End If

                        If cb_tsheaders.Checked = True Then
                            out += ("," & ts_header.sync_byte)
                            out += ("," & ts_header.transport_error)
                            out += ("," & ts_header.payload_start)
                            out += ("," & ts_header.transport_priority)
                            ' pid is separate
                            out += ("," & ts_header.scrambling_control)
                            out += ("," & ts_header.adaptation_control)
                            out += ("," & ts_header.continuity)
                        End If

                        If cb_PIDinfo.Checked = True Then
                            out += ("," & decode_pid_value(ts_header.pid))
                        End If

                        ' Adaptation
                        If cb_adaptation.Checked = True Then
                            out += ("," & adaptation.length)
                            out += ("," & adaptation.discontinuity_indicator)
                            out += ("," & adaptation.random_access_indicator)
                            out += ("," & adaptation.elementary_stream_priority_indicator)
                            out += ("," & adaptation.PCR_flag)
                            out += ("," & adaptation.OPCR_flag)
                            out += ("," & adaptation.splicing_point_flag)
                            out += ("," & adaptation.transport_private_data_flag)
                            out += ("," & adaptation.adaptation_field_extension_flag)
                        End If

                        ' PCR
                        If cb_adaptationPCR.Checked = True Then
                            out += ("," & adaptation.PCR)
                        End If

                        ' PES stream id
                        If cb_PES_streamid.Checked = True Then
                            out += ("," & pes_header.stream_id)
                            out += ("," & pes_header.PES_scrambling_control)
                        End If

                        ' PES Audio Description
                        If cb_ad.Checked = True Then
                            out += ("," & audio_description.ad_fade)
                            out += ("," & audio_description.ad_pan)
                        End If

                        ' PTS / DTS
                        If cb_PES_PTS_DTS.Checked = True Then
                                out += ("," & pes_header.PTS)
                                out += ("," & pes_header.DTS)
                            End If

                            ' Video GOP AFD
                            If cb_GOP_AFD.Checked = True Then
                                out += (",""" & video_header.ar & """")
                                out += ("," & video_header.afd)
                                out += (",""" & decode_picture_type_short(video_header.picture_type) & """")
                                out += ("," & video_header.temporal_reference)

                            End If

                            ' TABLES
                            If cb_TableHeaders.Checked = True Then
                                tables = Nothing
                                tables += ("," & table_header.pointer_field)
                                tables += ("," & table_header.table_id)
                                'tables += ("," & table_header.section_syntax_indicator)
                                tables += ("," & table_header.section_length)
                                tables += ("," & table_header.sub_table_id)
                                tables += ("," & table_header.version_number)
                                tables += ("," & table_header.current_next)
                                tables += ("," & table_header.section_number)
                                tables += ("," & table_header.last_section_number)

                                If cb_no_repeat.Checked = True Then
                                    If Not tables_history.Contains(tables) Then
                                        tables_history.Add(tables)

                                        out += tables
                                        out += ","
                                        Debug.Print("writing:  " & tables)
                                    Else
                                        out += tables
                                        out += ",REPEAT!"
                                        Debug.Print("skipping: " & tables)
                                    End If
                                Else
                                    out += tables
                                End If
                            End If

                            ' TDT and TOT
                            If cb_TDT_TOT.Checked = True Then
                                If ts_header.pid = 20 Then

                                    this_time = CDate(decode_time(10))

                                    out += ("," & decode_date(8))
                                    out += ("," & decode_time(10))

                                Else
                                    out += (",,")
                                End If
                            End If

                            If cb_TimeDelta.Checked = True Then
                                delta_time = DateDiff(DateInterval.Second, last_time, this_time)
                                out += ("," & delta_time)
                                last_time = this_time
                            End If

                            ' Packet delta
                            If cb_PacketDelta.Checked = True Then
                                delta_pkt = this_pkt - last_pkt
                                out += ("," & delta_pkt)
                            End If

                            sw.WriteLine(out)
                            count_pkt += 1
                            last_pkt = this_pkt
                            ToolStrip_Counter.Text = count_pkt.ToString

                            If cb_limit64k.Checked = True Then
                                If count_pkt = 64000 Then Exit For
                            End If

                        End If ' skip packet?
                Next ' ts packet

                Debug.Print("file close")
                sw.Close()
            End Using

            'If cb_tables_file.Checked = True Then
            '    Using sw2 As StreamWriter = New StreamWriter(txt_Filepath.Text & "_tables.csv")

            '        For Each item As String In tables_history
            '            sw2.WriteLine(item)
            '        Next item

            '    End Using
            'End If

        Catch exp As Exception
            Debug.Print("report exception: " & exp.Message)
            MsgBox(exp.Message, MsgBoxStyle.Critical)
            Exit Sub
        Finally
            btn_Stop.Enabled = False
            btn_Start.Enabled = True
            btn_close.Enabled = True
        End Try

        move_first()
        MsgBox("Report complete! " & count_pkt & " packets.", MsgBoxStyle.Information)
        ToolStrip_Counter.Text = "0"
        ToolStrip_Progress.Value = 1

    End Sub

    Private Sub cb_PIDfilter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_PIDfilter.CheckedChanged
        If cb_PIDfilter.Checked = True Then
            tb_pid.Enabled = True
        Else
            tb_pid.Enabled = False
        End If
    End Sub

    Private Sub Fill_Tables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cb_PIDfilter.Checked = True
        tb_pid.Text = "0,1,2"
    End Sub



    Function csv_headers() As String

        Dim header_line As String

        header_line = "TS.packet"

        If cb_PID.Checked = True Then
            header_line += ",TS.PID"
        End If

        If cb_tsheaders.Checked = True Then
            header_line += ",TS.sync"
            header_line += ",TS.transport_error"
            header_line += ",TS.payload_start"
            header_line += ",TS.transport_priority"
            header_line += ",TS.scrambling_control"
            header_line += ",TS.adaptation_control"
            header_line += ",TS.continuity_count"
        End If

        If cb_PIDinfo.Checked = True Then
            header_line += ",PID_info"
        End If

        If cb_adaptation.Checked = True Then
            header_line += ",Adaptation.length"
            header_line += ",Adaptation.discontinuity_indicator"
            header_line += ",Adaptation.random_access_indicator"
            header_line += ",Adaptation.elementary_stream_priority_indicator"
            header_line += ",Adaptation.PCR_flag"
            header_line += ",Adaptation.OPCR_flag"
            header_line += ",Adaptation.splicing_point_flag"
            header_line += ",Adaptation.transport_private_data_flag"
            header_line += ",Adaptation.adaptation_field_extension_flag"
        End If

        If cb_adaptationPCR.Checked = True Then
            header_line += ",Adaptation.PCR"
        End If

        If cb_PES_streamid.Checked = True Then
            header_line += ",PES.stream_id"
            header_line += ",PES.scrambling"
        End If

        If cb_ad.Checked = True Then
            header_line += ",AD.fade"
            header_line += ",AD.pan"
        End If

        If cb_PES_PTS_DTS.Checked = True Then
            header_line += ",PES.PTS"
            header_line += ",PES.DTS"
        End If

        If cb_GOP_AFD.Checked = True Then
            header_line += ",Video_header.ar"
            header_line += ",Video_header.afd"
            header_line += ",Video_header.picture_type"
            header_line += ",Video_header.temporal_reference"
        End If

        If cb_TableHeaders.Checked = True Then
            header_line += ",Pointer"
            header_line += ",Table_header.table_id"
            'header_line += ",Table_header.section_syntax_indicator)
            header_line += ",Table_header.section_length"
            header_line += ",Table_header.sub_table_id"
            header_line += ",Table_header.version_number"
            header_line += ",Table_header.current_next"
            header_line += ",Table_header.section_number"
            header_line += ",Table_header.last_section_number"
        End If

        If cb_no_repeat.Checked = True Then
            header_line += ",Table_header.repeat"
        End If

        If cb_TDT_TOT.Checked = True Then
            header_line += ",Table.date"
            header_line += ",Table.time"
        End If

        If cb_TimeDelta.Checked = True Then
            header_line += ",Table.time_delta"
        End If

        If cb_PacketDelta.Checked = True Then
            header_line += ",TS.packet_delta"
        End If

        Return header_line

    End Function

    Private Sub btn_Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Stop.Click
        export_stop = True
    End Sub

    Private Sub cb_TimeDelta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_TimeDelta.CheckedChanged
        ' don't allow delta without time
        If cb_TimeDelta.Checked = True Then cb_TDT_TOT.Checked = True
    End Sub

    Private Sub cb_TDT_TOT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_TDT_TOT.CheckedChanged
        ' don't allow delta without time
        If cb_TDT_TOT.Checked = False Then cb_TimeDelta.Checked = False
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cb_PIDfilter.Checked = True
        tb_pid.Text = "16,17,18,19,20"
    End Sub

 
End Class
