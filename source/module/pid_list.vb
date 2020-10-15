Module pid_list



    Public Sub get_pid_list()

        If pids_known = True Then Exit Sub

        Dim stopwatch As New Stopwatch
        Dim curr_pkt As Integer
        Dim current_pid As Integer

        Array.Clear(pids, 0, UBound(pids))

        move_first()
        dlgMain.status1.Text = "Looking for PID values... (press stop for partial list)"
        dlgMain.Cursor = Cursors.AppStarting
        Application.DoEvents()
        stopwatch.Start()

        fs.Seek(0 + offset, IO.SeekOrigin.Begin)

        For curr_pkt = 1 To max_packets

            ' only update gui every 64 packets, saves a lot of time
            If curr_pkt Mod 64 = 0 Then
                Application.DoEvents()
                dlgMain.FileProgressBar.Value = curr_pkt
            End If

            If stop_search = True Then
                MsgBox("Search aborted. Partial PID list will be displayed.", MsgBoxStyle.Information, Application.ProductName)
                stop_search = False
                Exit For
            End If

            fs.Read(ts_bytes, 0, 3)
            fs.Seek(packet_size - 3, IO.SeekOrigin.Current)

            If ts_bytes(0) <> &H47 Then
                MsgBox("Sync byte not found, packet: " & curr_pkt & ". Partial PID list will be displayed.", MsgBoxStyle.Exclamation, Application.ProductName)
                Exit For
            End If

            current_pid = (ts_bytes(1) And 31) << 8 Or ts_bytes(2)
            pids(current_pid) = pids(current_pid) + 1

        Next
        stopwatch.Stop()
        dlgMain.Cursor = Cursors.Arrow
        Debug.Print("pid list exit at packet: " & curr_pkt)
        Debug.Print("elapsed time: " & stopwatch.ElapsedMilliseconds.ToString)

        ' if all packets analysed then set flag to avoid doing it again
        If curr_pkt - 1 = max_packets Then pids_known = True

        move_first()
        dlgMain.status1.Text = "Ready."

    End Sub

    Sub generate_csv_pidlist()
        Debug.Print("Generate CSV pidlist")
        Dim p As Integer
        Dim savepath As String = Nothing

        dlgMain.SaveFileDialog1.Title = "Save PID list"
        dlgMain.SaveFileDialog1.FileName = Nothing
        dlgMain.SaveFileDialog1.AddExtension = True
        dlgMain.SaveFileDialog1.DefaultExt = ".csv"
        dlgMain.SaveFileDialog1.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*"

        If dlgMain.SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Try
                savepath = dlgMain.SaveFileDialog1.FileName
                If (savepath IsNot Nothing) Then
                    Debug.Print(savepath)

                    get_pid_list()

                    My.Computer.FileSystem.WriteAllText(savepath, "PID,Count,Type", False, System.Text.Encoding.ASCII)

                    For p = 0 To 8191
                        If pids(p) <> 0 Then
                            My.Computer.FileSystem.WriteAllText(savepath, vbCrLf & p & "," & pids(p) & "," & decode_pid_value(p), True)
                        End If
                    Next

                    move_first()
                    MsgBox("PID analysis from " & max_packets & " TS packets saved to " & savepath, MsgBoxStyle.Information)

                End If

            Catch Ex As Exception
                MessageBox.Show("Cannot write file to disk. Error: " & Ex.Message)
            End Try
        End If
        'dlgMain.Cursor = Cursors.Arrow
    End Sub

End Module
