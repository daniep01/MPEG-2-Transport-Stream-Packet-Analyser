Imports System.Windows.Forms


Public Class dlgPIDlist

    Sub display_pid_list()

        Dim packet_counter As Integer
        Dim list_index As Integer
        Dim percent As Double
        list_index = 0
        packet_counter = 0

        ' remove any old data
        listviewPID.Items.Clear()

        For k As Integer = 0 To 8191
            If pids(k) <> 0 Then

                percent = (pids(k) / max_packets) * 100

                listviewPID.Items.Add(k.ToString)
                listviewPID.Items(list_index).SubItems.Add(pids(k).ToString)
                listviewPID.Items(list_index).SubItems.Add(FormatNumber(percent, 2))
                listviewPID.Items(list_index).SubItems.Add(decode_pid_value(k))

                list_index = list_index + 1
                packet_counter = packet_counter + pids(k)

            End If
        Next

        lbPIDused.Text = list_index & " PIDs in use"
        lbPacketsAnalysed.Text = packet_counter & " / " & max_packets & " packets analysed"
        Me.ShowDialog()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        generate_csv_pidlist()
    End Sub
End Class
