Imports System.Windows.Forms

Public Class dlgCheck

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Debug.Print("check continuity counts-------------------------")
        tb_check_results.Text = "Checking " & dlgMain.tbPath.Text
        Me.OK_Button.Enabled = False
        Me.Cancel_Button.Enabled = False
        Me.Stop_Button.Enabled = True

        Dim last_ccount(8192) As Integer
        Dim p, n, checked, expected As Integer
        Dim pid, actual_ccount, adaptation As Integer
        Dim strError As String
        Dim errorCount As Integer = 0
        Dim filter_pid As Integer

        If tb_filter_pid.Enabled = True Then
            filter_pid = System.Convert.ToInt32(Me.tb_filter_pid.Text)
        End If

        ' reset last ccount array to -1, nothing has been seen yet
        For n = 0 To UBound(last_ccount)
            last_ccount(n) = -1
        Next

        move_first()
        p = 1

        Dim sw As New Stopwatch
        sw.Start()

        ' look at all the packets
        Do
            ' read some data, just 4 bytes because we only need the TS header
            read_ts_pkt(p, 4)

            ' check for sync error
            If ts_bytes(0) <> &H47 Then
                strError = "ERROR! packet: " & p & " corrupt sync byte"
                tb_check_results.Text += vbCrLf & strError
                If cb_stop_sbe.Checked = True Then
                    tb_check_results.Text += vbCrLf & "Check stopped."
                    Exit Do
                End If
            End If

            ' extract relevant fields from TS header
            pid = (ts_bytes(1) And 31) << 8 Or ts_bytes(2)
            actual_ccount = (ts_bytes(3) And 15)
            adaptation = (ts_bytes(3) And 48) >> 4

            Debug.Print("packet: " & p & " pid: " & pid & " cc: " & actual_ccount)

            ' skip null packets
            If pid <> 8191 Then
                ' check for filter
                If pid = filter_pid Or cbPIDfilter.Checked = False Then

                    checked = checked + 1

                    ' check not first time for the current pid
                    If last_ccount(pid) = -1 Then
                        Debug.Print("first time, pid: " & pid)
                        ' use first value as starting point
                        expected = actual_ccount
                    Else
                        ' add one to expected value, loop back to zero after 15
                        expected = (last_ccount(pid) + 1) Mod 16
                    End If


                    If adaptation = 2 And last_ccount(pid) <> -1 Then
                        ' all adaptation bytes, don't expect cont count to increment in this case
                        ' if this is the first time for this pid then the expected value has already been
                        ' set above.
                        Debug.Print("adaptation control = 2")
                        expected = last_ccount(pid)
                    End If

                    If actual_ccount <> expected Then
                        strError = "ERROR! packet: " & p & " pid: " & pid & " found: " & actual_ccount & " expected: " & expected
                        Debug.Print(strError)
                        errorCount += 1
                        tb_check_results.Text += vbCrLf & strError
                    End If

                    last_ccount(pid) = actual_ccount

                End If
            End If
            p = p + 1
        Loop While p <= max_packets And stop_search = False

        stop_search = False
        sw.Stop()

        Me.OK_Button.Enabled = True
        Me.Stop_Button.Enabled = False
        Me.Cancel_Button.Enabled = True
        tb_check_results.Text += vbCrLf & "Complete, " & checked & " packets checked"
        tb_check_results.Text += vbCrLf & errorCount & " errors found"
        tb_check_results.Text += vbCrLf & sw.ElapsedMilliseconds & " elapsed ms"
        move_first()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub Stop_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Stop_Button.Click
        stop_search = True
        Me.Cancel_Button.Enabled = True
        Me.Stop_Button.Enabled = False
        Me.OK_Button.Enabled = True
    End Sub

    Private Sub cbPIDfilter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPIDfilter.CheckedChanged
        tb_filter_pid.Enabled = cbPIDfilter.Checked
    End Sub
End Class
