Imports System.Windows.Forms

Public Class dlgOptions

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        update_dlgMain()

        Try

            ' read radio buttons and put into settings file
            If rSyncHex.Checked = True Then My.Settings.DisplaySyncHex = True Else My.Settings.DisplaySyncHex = False
            If rPidHex.Checked = True Then My.Settings.DisplayPidHex = True Else My.Settings.DisplayPidHex = False
            If rContinuityHex.Checked = True Then My.Settings.DisplayContinuityHex = True Else My.Settings.DisplayContinuityHex = False


            My.Settings.Save()
        Catch ex As Exception
            MsgBox("Error saving settings. " & ex.Message)
        End Try

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub rSyncDec_Click(sender As System.Object, e As System.EventArgs) Handles rSyncDec.Click
        rSyncDec.Checked = Not rSyncDec.Checked
        rSyncHex.Checked = Not rSyncHex.Checked

    End Sub

    Private Sub rSyncHex_Click(sender As System.Object, e As System.EventArgs) Handles rSyncHex.Click
        rSyncDec.Checked = Not rSyncDec.Checked
        rSyncHex.Checked = Not rSyncHex.Checked

    End Sub

    Private Sub rPidDec_Click(sender As System.Object, e As System.EventArgs) Handles rPidDec.Click
        rPidDec.Checked = Not rPidDec.Checked
        rPidHex.Checked = Not rPidHex.Checked

    End Sub

    Private Sub rPidHex_Click(sender As System.Object, e As System.EventArgs) Handles rPidHex.Click
        rPidDec.Checked = Not rPidDec.Checked
        rPidHex.Checked = Not rPidHex.Checked

    End Sub

    Private Sub rCCdec_Click(sender As System.Object, e As System.EventArgs) Handles rContinuityDec.Click
        rContinuityDec.Checked = Not rContinuityDec.Checked
        rContinuityHex.Checked = Not rContinuityHex.Checked

    End Sub

    Private Sub rCChex_Click(sender As System.Object, e As System.EventArgs) Handles rContinuityHex.Click
        rContinuityDec.Checked = Not rContinuityDec.Checked
        rContinuityHex.Checked = Not rContinuityHex.Checked

    End Sub

    Private Sub rPacketDec_CheckedChanged(sender As Object, e As EventArgs) 

    End Sub
End Class
