Imports System
Imports System.IO
Imports System.Text



Module export
    Sub generate_csv_pidlist()
        Debug.Print("Generate CSV pidlist")
        Dim p As Integer
        Dim savepath As String = Nothing

        dlgMain.SaveFileDialog1.FileName = Nothing
        dlgMain.SaveFileDialog1.AddExtension = True
        dlgMain.SaveFileDialog1.DefaultExt = ".csv"
        dlgMain.SaveFileDialog1.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*"

        If dlgMain.SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Try
                savepath = dlgMain.SaveFileDialog1.FileName
                If (savepath IsNot Nothing) Then
                    Debug.Print(savepath)

                    dlgMain.Invalidate()
                    dlgMain.Update()
                    dlgMain.Cursor = Cursors.WaitCursor

                    get_pid_list()

                    My.Computer.FileSystem.WriteAllText(savepath, vbCrLf & "PID,Count", False)

                    For p = 0 To 8191
                        If pids(p) <> 0 Then
                            My.Computer.FileSystem.WriteAllText(savepath, vbCrLf & p & "," & pids(p), True)
                        End If
                    Next

                    move_first()
                    MsgBox("PID details from " & max_packets & " TS packets saved to " & savepath, MsgBoxStyle.Information)

                End If

            Catch Ex As Exception
                MessageBox.Show("Cannot write file to disk. Error: " & Ex.Message)
            End Try
        End If
        dlgMain.Cursor = Cursors.Arrow
    End Sub
End Module
