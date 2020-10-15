Public Class dlgTablePIDs


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonClose.Click
        Me.Hide()

        Try
            My.Settings.TablePidList.Clear()

            For Each item As String In listPID.Items
                My.Settings.TablePidList.Add(item)
            Next

            My.Settings.Save()

        Catch ex As Exception
            MsgBox("Error saving table PID list. " & ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAdd.Click
        add_pid()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonRemove.Click
        listPID.Items.Remove(listPID.SelectedItem)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonClearAll.Click
        listPID.Items.Clear()
    End Sub

    Private Sub dlgTablePIDs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Activated
        textNewPID.Focus()

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textNewPID.KeyDown

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Or e.KeyCode = Keys.Menu Then
            add_pid()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
        End If
    End Sub

    Private Sub add_pid()
        Dim new_pid As Integer
        Try
            new_pid = System.Convert.ToInt16(Me.textNewPID.Text)
            If new_pid < 0 Or new_pid > 8191 Then
                MsgBox("PID must be in range 0 to 8191", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If listPID.FindStringExact(new_pid.ToString) <> -1 Then
                MsgBox("PID is already in list", MsgBoxStyle.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Invalid value for PID", MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

        Me.listPID.Items.Add(Me.textNewPID.Text)
        Me.textNewPID.Text = Nothing

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim defaultPids As Array = {0, 1, 2, 16, 17, 18, 20}
        listPID.Items.Clear()
        For Each item As String In defaultPids
            listPID.Items.Add(item)
        Next
    End Sub
End Class