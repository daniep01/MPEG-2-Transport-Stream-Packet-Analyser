Imports System.Windows.Forms
Imports System.IO

Public Class dlgDemux

    Public demux_stop As Boolean = False

    Public Sub Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_start.Click

        If lbPIDdest.Items.Count = 0 Then
            MsgBox("No PIDs in destination list.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If cb_PES.Checked = True And lbPIDdest.Items.Count <> 1 Then
            MsgBox("Only one destination PID allowed when converting to PES.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim curPkt, curPid, packetsWritten, trimBegin, trimEnd, trimOutput As Integer
        Dim savepath As String = Nothing

        Try
            trimBegin = System.Convert.ToInt32(txt_trimbegin.Text)
            trimEnd = System.Convert.ToInt32(txt_trimend.Text)

            If radio_OutputTrim2.Checked = True Then
                trimOutput = System.Convert.ToInt32(txt_trimoutput.Text)
            Else

            End If

        Catch exp As System.Exception
            MsgBox(exp.Message & " Invalid input in filter.", MsgBoxStyle.Critical)
            Exit Sub
        End Try

        If check_start_end(trimBegin, trimEnd) = False Then Exit Sub


        Me.btAdd.Enabled = False
        Me.btAddAll.Enabled = False
        Me.btRemove.Enabled = False
        Me.btRemoveAll.Enabled = False
        Me.btn_start.Enabled = False
        Me.btn_close.Enabled = False
        Me.btn_stop.Enabled = True

        Try
            savepath = txt_Filepath.Text

            Debug.Print(savepath)

            Dim fsOutput As New FileStream(savepath, FileMode.Create, FileAccess.Write, FileShare.None)
            Dim bwOutput As New BinaryWriter(fsOutput)
            Dim trim_begin_offset As Integer = offset + ((trimBegin - 1) * packet_size)
            Dim outPacketSize As Integer = 188
            Dim skipBytes As Integer = 0

            Me.Cursor = Cursors.AppStarting
            Application.DoEvents()

            Dim sw As New Stopwatch
            sw.Start()

            ' find start of first packet
            fs.Seek(trim_begin_offset, SeekOrigin.Begin)

            Debug.Print("Starting at: " & fs.Position)

            If cb_PES.Checked = True Then
                ' conversion to PES
                Debug.Print("demux to PES")

                ' array to read into
                Dim tsHeaderBytes(4) As Byte
                Dim adaptionControl As Integer
                Dim adaptionLength As Integer = 0
                Dim payloadStart As Integer
                Dim pessize As Integer
                Dim extractPID As Integer = System.Convert.ToInt32(lbPIDdest.Items.Item(0))

                Debug.Print("target pid: " & extractPID)

                skipBytes = packet_size - outPacketSize
                Debug.Print("Skip bytes: " & skipBytes)


                For curPkt = trimBegin To trimEnd

                    If curPkt Mod 256 = 0 Then
                        dlgMain.FileProgressBar.Value = curPkt
                        Application.DoEvents()
                    End If

                    If demux_stop = True Then Exit For

                    ' read from file into byte array
                    fs.Read(tsHeaderBytes, 0, 4)

                    ' move to start of next packet
                    If skipBytes <> 0 Then fs.Seek(skipBytes, SeekOrigin.Current)

                    ' decode pid and adaption field
                    curPid = (tsHeaderBytes(1) And 31) << 8 Or tsHeaderBytes(2)
                    adaptionControl = (tsHeaderBytes(3) And 48) >> 4
                    payloadStart = 0

                    ' check for pid match
                    If curPid = extractPID Then

                        Debug.Print("packet: " & curPkt & " pid: " & curPid & " adaption: " & adaptionControl)

                        Select Case adaptionControl
                            Case 0, 1
                                ' no adaption, skip ts header
                                pessize = 184
                            Case 2
                                pessize = 0
                            Case 3
                                adaptionLength = fs.ReadByte
                                pessize = 184 - adaptionLength
                        End Select

                        Debug.Print("pes size: " & pessize)


                        packetsWritten = packetsWritten + 1
                        bwOutput.Write(tsHeaderBytes)

                        'Debug.Print(pkt_written & " match for pid: " & cur_pid & " in pkt: " & cur_pkt)
                        If radio_OutputTrim2.Checked = True And packetsWritten = trimOutput Then Exit For

                    End If


                Next


            Else
                ' demux to TS
                Debug.Print("demux to TS")

                ' convert to 188-byte packets? 
                If cb_188ByteOutput.Checked = True Then
                    outPacketSize = 188
                    skipBytes = packet_size - outPacketSize
                Else
                    outPacketSize = packet_size
                    skipBytes = 0
                End If

                Debug.Print(skipBytes & " : " & outPacketSize)

                Dim demuxTsBytes(outPacketSize - 1) As Byte

                For curPkt = trimBegin To trimEnd

                    If curPkt Mod 256 = 0 Then
                        dlgMain.FileProgressBar.Value = curPkt
                        Application.DoEvents()
                    End If

                    If demux_stop = True Then Exit For

                    ' read from file into byte array
                    fs.Read(demuxTsBytes, 0, outPacketSize)

                    ' move to start of next packet
                    If skipBytes <> 0 Then fs.Seek(skipBytes, SeekOrigin.Current)

                    ' decode pid
                    curPid = (demuxTsBytes(1) And 31) << 8 Or demuxTsBytes(2)

                    Debug.Print("packet: " & curPkt & " pid: " & curPid)

                    If lbPIDdest.FindStringExact(curPid.ToString) <> -1 Then

                        packetsWritten = packetsWritten + 1
                        bwOutput.Write(demuxTsBytes)

                        'Debug.Print(pkt_written & " match for pid: " & cur_pid & " in pkt: " & cur_pkt)
                        If radio_OutputTrim2.Checked = True And packetsWritten = trimOutput Then Exit For

                    End If

                Next

            End If

            bwOutput.Close()
            fsOutput.Close()
            fsOutput.Dispose()
            btn_close.Enabled = True
            btn_stop.Enabled = False
            demux_stop = False

            sw.Stop()

            MsgBox(packetsWritten & " packets extracted" & vbCrLf & _
                   outPacketSize & "-bytes per packet" & vbCrLf & _
                   "Written to " & savepath & vbCrLf & "Elapsed " & _
                   sw.ElapsedMilliseconds & "ms", MsgBoxStyle.Information)


        Catch Ex As Exception

            MsgBox("Error during export." & vbCrLf & Ex.Message, vbCritical, "Demux error")

        Finally
            Me.Cursor = Cursors.Arrow
            Me.btAdd.Enabled = True
            Me.btAddAll.Enabled = True
            Me.btRemove.Enabled = True
            Me.btRemoveAll.Enabled = True
            Me.btn_start.Enabled = True
            Me.btn_close.Enabled = True
            Me.btn_stop.Enabled = False


            move_first()
        End Try



    End Sub

    Private Sub Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click

        ' check there are items in the list
        If lbPIDsource.Items.Count = 0 Then Exit Sub
        If lbPIDsource.SelectedIndex < 0 Then Exit Sub

        While lbPIDsource.SelectedItems.Count > 0
            lbPIDdest.Items.Add(lbPIDsource.SelectedItem)
            lbPIDsource.Items.Remove(lbPIDsource.SelectedItem)
        End While

        lbPIDsource.TopIndex = 0
        update_count()

    End Sub

    Private Sub btRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRemove.Click

        ' check there are items in the list
        If lbPIDdest.Items.Count = 0 Then Exit Sub
        If lbPIDdest.SelectedIndex < 0 Then Exit Sub

        While lbPIDdest.SelectedItems.Count > 0
            lbPIDsource.Items.Add(lbPIDdest.SelectedItem)
            lbPIDdest.Items.RemoveAt(lbPIDdest.SelectedIndex)
        End While

        lbPIDdest.TopIndex = 0
        update_count()

    End Sub

    Public Sub populate_source_list()

        Dim k As Integer

        k = 0

        ' remove any old data
        Me.lbPIDsource.Items.Clear()

        For k = 0 To 8191
            If pids(k) <> 0 Then

                Me.lbPIDsource.Items.Add(k)

            End If
        Next
        update_count()
        lbPIDdest.TopIndex = 0
        lbPIDsource.SelectedIndex = 0

    End Sub

    Private Sub btAddAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddAll.Click
        If lbPIDsource.Items.Count = 0 Then Exit Sub

        Dim j As Integer

        For j = 0 To lbPIDsource.Items.Count - 1
            lbPIDdest.Items.Add(lbPIDsource.Items.Item(j).ToString)

        Next

        lbPIDsource.Items.Clear()
        update_count()

    End Sub

    Private Sub btRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRemoveAll.Click
        If lbPIDdest.Items.Count = 0 Then Exit Sub

        Dim j As Integer

        For j = 0 To lbPIDdest.Items.Count - 1
            lbPIDsource.Items.Add(lbPIDdest.Items.Item(j).ToString)

        Next

        lbPIDdest.Items.Clear()
        update_count()

    End Sub

    Sub update_count()
        Label_sourcecount.Text = lbPIDsource.Items.Count.ToString
        Label_destcount.Text = lbPIDdest.Items.Count.ToString
    End Sub

    Private Sub Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_stop.Click
        demux_stop = True
    End Sub


    Private Sub radio_outputtrim2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radio_OutputTrim2.CheckedChanged
        Me.txt_trimoutput.Enabled = True
    End Sub

    Private Sub radio_outputtrim1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radio_outputtrim1.CheckedChanged
        Me.txt_trimoutput.Enabled = False
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        'dlgMain.SaveFileDialog1.Title = "Demux"
        'dlgMain.SaveFileDialog1.FileName = Nothing
        'dlgMain.SaveFileDialog1.AddExtension = True
        'dlgMain.SaveFileDialog1.DefaultExt = ".ts"
        'dlgMain.SaveFileDialog1.Filter = "TS files (*.ts)|*.ts|MPEG files (*.mpg)|*.mpg|All files (*.*)|*.*"

        DemuxSaveFileDialog.DefaultExt = ".ts"
        DemuxSaveFileDialog.AddExtension = True

        If DemuxSaveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txt_Filepath.Text = DemuxSaveFileDialog.FileName
        End If

    End Sub


    Private Sub cb_PES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_PES.CheckedChanged
        cb_188ByteOutput.Checked = cb_PES.Checked
    End Sub
End Class
