Namespace My

    ' The following events are availble for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

            Debug.Print("shutdown: " & sender.ToString)

            ts_close()

            Debug.Print("END! " & Now())
            End
        End Sub

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Debug.Print("START APPLICATON " & sender.ToString & " " & Now())

            If Application.CommandLineArgs.Contains("debug_134") Then
                dlgMain.btn_debug1.Visible = True
                dlgMain.btn_debug1.Enabled = True
                dlgMain.btn_debug2.Visible = True
                dlgMain.btn_debug2.Enabled = True
            End If

            dlgMain.Text = Application.Info.ProductName & " " & My.Application.Info.Version.ToString

            Debug.Print("Load settings")

            Try


                dlgOptions.rSyncHex.Checked = My.Settings.DisplaySyncHex
                dlgOptions.rPidHex.Checked = My.Settings.DisplayPidHex
                dlgOptions.rContinuityHex.Checked = My.Settings.DisplayContinuityHex

                dlgOptions.rSyncDec.Checked = Not My.Settings.DisplaySyncHex
                dlgOptions.rPidDec.Checked = Not My.Settings.DisplayPidHex
                dlgOptions.rContinuityDec.Checked = Not My.Settings.DisplayContinuityHex

                dlgTablePIDs.listPID.Items.Clear()
                For Each item As String In My.Settings.TablePidList
                    dlgTablePIDs.listPID.Items.Add(item)
                Next



            Catch er As Exception

                Debug.Print(er.Message)

            Finally

                Debug.Print("Settings loaded")

            End Try

        End Sub

    End Class

End Namespace

