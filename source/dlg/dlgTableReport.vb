Imports System
Imports System.IO
Imports System.Convert
Imports System.Collections.Generic
Imports System.Collections.ObjectModel



Public Class dlgTableReport

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
        'Dim delta_time As Long
        Dim k As Integer ' counter
        'Dim this_time, last_time As Date
        Dim skip_packet As Boolean
        Dim out, tables, delta As String
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
        'If cb_PIDfilter.Checked = True Then
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
        'End If

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
                    ' do the full decoding
                    decode_ts_packet(True, False, this_pkt)
                    Debug.Print("pid: " & ts_header.pid & " payload start: " & ts_header.payload_start & " adaption: " & ts_header.adaptation_control)
                    ToolStrip_Progress.Value = this_pkt

                    ' check if we want this packet in the output
                    'If cb_PIDfilter.Checked = True Then
                    If Array.IndexOf(pid_list_i, ts_header.pid) = -1 Then
                        skip_packet = True
                    End If
                    'End If

                    'If cb_PayloadFilter.Checked = True Then
                    If ts_header.payload_start = 0 Then
                        skip_packet = True
                    End If
                    'End If

                    If cb_subtable.Checked = True Then

                        If table_header.sub_table_id <> Convert.ToDouble(txt_subtable.Text) Then
                            skip_packet = True
                        End If

                    End If
                    'If cb_adaptation_filter.Checked = True Then
                    '    If ts_header.adaptation_control = 1 Then
                    '        skip_packet = True
                    '    End If
                    'End If

                    'If cb_pcr_filter.Checked = True Then
                    '    If adaptation.PCR_flag = False Then
                    '        skip_packet = True
                    '    End If
                    'End If



                    If skip_packet = False Then

                        Debug.Print("> packet match, adding to report...")
                        'decode_ts_packet(True, False, this_pkt)
                        ' write to file, checking for check box status
                        out = this_pkt.ToString
                        tables = ""
                        delta = ""

                        If cb_PID.Checked = True Then tables += "," & ts_header.pid
                        If cb_PIDinfo.Checked = True Then tables += ("," & decode_pid_value(ts_header.pid))
                        If cb_pointer.Checked = True Then tables += ("," & table_header.pointer_field)
                        If cb_tableid.Checked = True Then tables += ("," & table_header.table_id)
                        If cb_sectionLength.Checked = True Then tables += ("," & table_header.section_length)
                        If cb_subTableId.Checked = True Then tables += ("," & table_header.sub_table_id)
                        If cb_version.Checked = True Then tables += ("," & table_header.version_number)
                        If cb_currentNext.Checked = True Then tables += ("," & table_header.current_next)
                        If cb_section.Checked = True Then tables += ("," & table_header.section_number)
                        If cb_lastSection.Checked = True Then tables += ("," & table_header.last_section_number)


                        ' check for duplicates
                        If (cb_no_duplicates.Checked = True And Not tables_history.Contains(tables)) Or (cb_no_duplicates.Checked = False) Then

                            ' Packet delta
                            If cb_PacketDelta.Checked = True Then
                                delta_pkt = this_pkt - last_pkt
                                delta = ("," & delta_pkt)
                            End If

                            tables_history.Add(tables)
                            out += tables + delta
                            sw.WriteLine(out)
                            count_pkt += 1
                            last_pkt = this_pkt
                            ToolStrip_Counter.Text = count_pkt.ToString

                        End If

                        'Else
                        '    tables_history.Add(tables)
                        '    out += tables
                        '    sw.WriteLine(out)
                        '    count_pkt += 1
                        '    last_pkt = this_pkt
                        '    ToolStrip_Counter.Text = count_pkt.ToString
                        'End If

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

    'Private Sub cb_PIDfilter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If cb_PIDfilter.Checked = True Then
    '        tb_pid.Enabled = True
    '    Else
    '        tb_pid.Enabled = False
    '    End If
    'End Sub

    'Private Sub Fill_Tables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    cb_PIDfilter.Checked = True
    '    tb_pid.Text = "0,1,2"
    'End Sub



    Function csv_headers() As String

        Dim header_line As String

        header_line = "Packet"

        If cb_PID.Checked = True Then header_line += ",PID"
        If cb_PIDinfo.Checked = True Then header_line += ",PID_info"
        If cb_pointer.Checked = True Then header_line += ",Pointer"
        If cb_tableid.Checked = True Then header_line += ",Table_id"
        If cb_sectionLength.Checked = True Then header_line += ",Section_length"
        If cb_subTableId.Checked = True Then header_line += ",Sub_table_id"
        If cb_version.Checked = True Then header_line += ",Version_number"
        If cb_currentNext.Checked = True Then header_line += ",Current_next"
        If cb_section.Checked = True Then header_line += ",Section_number"
        If cb_lastSection.Checked = True Then header_line += ",Last_section_number"
        If cb_PacketDelta.Checked = True Then header_line += ",Packet_delta"

        Return header_line

    End Function

    Private Sub btn_Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Stop.Click
        export_stop = True
    End Sub

    'Private Sub cb_TimeDelta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_TimeDelta.CheckedChanged
    '    ' don't allow delta without time
    '    If cb_TimeDelta.Checked = True Then cb_TDT_TOT.Checked = True
    'End Sub

    'Private Sub cb_TDT_TOT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_TDT_TOT.CheckedChanged
    '    ' don't allow delta without time
    '    If cb_TDT_TOT.Checked = False Then cb_TimeDelta.Checked = False
    'End Sub



    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    cb_PIDfilter.Checked = True
    '    tb_pid.Text = "16,17,18,19,20"
    'End Sub


    Private Sub dlgTableReport_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ' get pid list from dlgpidlist
        Debug.Print("update pid list in table report dlg")
        Dim pidlist, item As String
        pidlist = ""

        For Each item In dlgTablePIDs.listPID.Items
            pidlist += item + ","
        Next
        If pidlist.Length > 0 Then pidlist = pidlist.TrimEnd(",")
        tb_pid.Text = pidlist
        Debug.Print(pidlist)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dlgTablePIDs.Show()
    End Sub
End Class
