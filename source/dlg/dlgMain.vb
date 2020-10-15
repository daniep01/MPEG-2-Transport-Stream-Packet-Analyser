Imports System
Imports System.IO
'Imports System.Collections
'Imports System.ComponentModel
'Imports System.Threading

Public Class dlgMain

    Public Sub open_file_dialogue(ByVal type As String)

        Debug.Print("Open_file /\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\")
        Debug.Print(type)

        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Filter = "Transport streams|*.ts;*.trp;*.m2t;*.m2ts;*.mts|All files|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                ' clear any previous file details
                ts_close()

                ' get filepath
                ' check filepath is valid
                filepath = openFileDialog1.FileName
                Debug.Print("file open: " & filepath)
                If (filepath IsNot Nothing) Then

                    ts_open(filepath)

                End If

            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Error: " & Ex.Message)
            End Try
        End If

    End Sub

    Sub ts_open(ByVal filepath As String)

        ' open
        Dim fi As New FileInfo(filepath)
        fs = fi.OpenRead()

        ' get length and number of packets
        Dim length As Long = FileLen(filepath)
        Debug.Print("file length: " & length)

        'check removed to allow single ts packets
        'If length < 1024 Then
        '    MsgBox("File is not long enough to be a valid MPEG-2 transport stream and cannot be opened.", MsgBoxStyle.Critical, Application.ProductName)
        '    ts_close()
        '    Exit Sub
        'End If

        ' count bytes looking for TS sync bytes
        Dim byte_loop As Integer
        ' add extra packet sizes here if required
        Dim test_lengths() As Integer = {188, 192, 204, 208}
        ' store byte read from file before checking
        Dim check_byte(1) As Byte
        ' flag to exit for loop and generate error message
        Dim sync_found As Boolean = False
        ' assume no offset to start with
        offset = 0
        pre_header = 0

        ' move to start of file
        fs.Seek(0, IO.SeekOrigin.Begin)

        ' loop looking for first sync byte, if not in first 2 packets then stop
        For byte_loop = 0 To (208 * 2)

            If sync_found = True Then Exit For

            ' ensure we are in the right place, check_sync function could have
            ' moved us on too far
            fs.Seek(byte_loop, SeekOrigin.Begin)
            fs.Read(check_byte, 0, 1)

            If check_byte(0) = &H47 Then

                Debug.Print("potential sync byte @ " & byte_loop)

                ' check for 3 more sync bytes, intervals are in array test_lengths
                For k As Integer = 0 To UBound(test_lengths)

                    If check_sync(byte_loop, test_lengths(k)) = True Then

                        offset = byte_loop
                        Debug.Print(byte_loop.ToString)

                        packet_size = test_lengths(k)
                        Debug.Print("packet size: " & packet_size)

                        ' bit of a bodge
                        If packet_size = 192 Then
                            pre_header = 4
                        End If

                        Debug.Print("pre header: " & pre_header.ToString)
                        offset = offset - pre_header

                        ReDim ts_bytes(packet_size - 1)
                        Debug.Print("sync found, packet size: " & packet_size)
                        Debug.Print("offset: " & offset.ToString)

                        sync_found = True

                        Exit For
                    End If

                Next

            End If

        Next

        ' no match found
        If sync_found = False Then
            Debug.Print("3 sync bytes not found, closing file")
            MsgBox("0x47 sync bytes not found at regular intervals or packet size is not supported. File cannot be opened.", MsgBoxStyle.Critical, Application.ProductName)
            ts_close()
            Exit Sub
        End If

        ' round down the nearest whole packet
        max_packets = System.Convert.ToInt32((length - offset) / packet_size)

        ' update progress bars and txt box
        Me.FileProgressBar.Maximum = max_packets
        dlgReport.txt_End.Text = max_packets.ToString
        dlgTableReport.txt_End.Text = max_packets.ToString
        dlgDemux.txt_trimend.Text = max_packets.ToString
        dlgSpacing.txt_pktstop.Text = max_packets.ToString
        'dlgProgress.pb1.Maximum = max_packets

        ' update status text
        Me.tbPath.Text = filepath
        Me.tbSize.Text = Format(Int(length / 1024), "#,0.") & " Kb, " & Format(max_packets, "#,0.") & " " & packet_size & "-byte packets, offset " & offset & ", pre ts header " & pre_header
        ' enable buttons and menus
        Me.setup_buttons(True)

        ' decode and display first packet
        'dlgPlot.Refresh()
        move_first()



    End Sub

    Function check_sync(ByVal location As Integer, ByVal interval As Integer) As Boolean

        Dim check(3) As Byte
        Dim read(1) As Byte

        For j As Integer = 0 To 2
            location = location + (j * interval)
            fs.Seek(location, SeekOrigin.Begin)
            fs.Read(read, 0, 1)
            check(j) = read(0)
            Debug.Print(j & " : " & location & " : " & check(j))
        Next

        If check(0) = &H47 Then
            If check(1) = &H47 Then
                If check(2) = &H47 Then
                    Debug.Print("3 sync byte matches at " & interval & " intervals!")
                    Return True
                End If
            End If
        End If

        Debug.Print("no match at " & interval & " intervals!")
        Return False


    End Function


    Private Sub Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Open.Click, Menu_Open.Click
        open_file_dialogue("Stream")
    End Sub

    Private Sub Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Exit.Click
        Me.Close()
    End Sub

    Private Sub tbNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Next.Click
        move_next()
    End Sub

    Private Sub tbFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_First.Click
        move_first()
    End Sub

    Private Sub tbPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Prev.Click
        move_prev()
    End Sub

    Private Sub About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_About.Click, Tool_About.Click
        dlgAbout.ShowDialog()
    End Sub

    Public Sub setup_buttons(ByVal mode As Boolean)
        Me.Tool_First.Enabled = mode
        Me.Tool_Next.Enabled = mode
        Me.Tool_Prev.Enabled = mode
        Me.Tool_PIDlist.Enabled = mode
        Me.Tool_DropDownTables.Enabled = mode
        Me.Tool_Check.Enabled = mode
        Me.Tool_Goto.Enabled = mode
        Me.Tool_Stop.Enabled = mode
        'Me.toolbPlot.Enabled = mode

        Me.Menu_Close.Enabled = mode
        Me.Menu_Report.Enabled = mode
        Me.Menu_TableReport.Enabled = mode
        Me.Menu_Demux.Enabled = mode
        Me.Tools_Menu.Enabled = mode
        Me.Menu_SavePacket.Enabled = mode

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Goto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Goto.Click
        dlgGoto.ShowDialog()
    End Sub

    Private Sub PAT_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PATToolStripMenuItem.Click
        find_pid(0)
    End Sub

    Private Sub CAT_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CATToolStripMenuItem.Click
        find_pid(1)
    End Sub

    Private Sub NIT_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NITToolStripMenuItem.Click
        find_pid(16)
    End Sub

    Private Sub SDT_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SDTToolStripMenuItem.Click
        find_pid(17)
    End Sub

    Private Sub EIT_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EITToolStripMenuItem.Click
        find_pid(18)
    End Sub

    Private Sub TDTTOT_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDTTOTToolStripMenuItem.Click
        find_pid(20)
    End Sub

    Private Sub PIDList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_PIDlist.Click, Tool_PIDlist.Click
        get_pid_list()
        dlgPIDlist.display_pid_list()
    End Sub

    Private Sub cboxPID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxPID.CheckedChanged
        If cboxPID.Checked = True Then
            Me.tbPidFilter.Enabled = True
            Me.tbPidFilter.Text = Me.tbTSpid.Text
        Else
            Me.tbPidFilter.Enabled = False
        End If
    End Sub

    Private Sub Check_CC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Check_CCount.Click, Tool_Check.Click
        dlgCheck.tb_check_results.Text = Nothing
        dlgCheck.Show()
        dlgCheck.Activate()
    End Sub

    Private Sub cboxPayloadStart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxPayloadStart.CheckedChanged
        If cboxPayloadStart.Checked = True Then
            Me.tbPayloadFilter.Enabled = True
        Else
            Me.tbPayloadFilter.Enabled = False
        End If
    End Sub

    Private Sub Demux_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Demux.Click
        get_pid_list()

        With dlgDemux
            '.pbarDemux.Value = 0
            .lbPIDdest.Items.Clear()
            .Label_destcount.Text = "0"
            .populate_source_list()
            .btAdd.Enabled = True
            .btAddAll.Enabled = True
            .btRemove.Enabled = True
            .btRemoveAll.Enabled = True
            .btn_start.Enabled = True
            .btn_stop.Enabled = False
            .btn_close.Enabled = True

            Debug.Print(packet_size.ToString)
            If packet_size = 188 Then .cb_188ByteOutput.Enabled = False Else .cb_188ByteOutput.Enabled = True

            .ToolTip1.SetToolTip(.cb_188ByteOutput, "Source is " & packet_size)

            dlgDemux.ShowDialog()
        End With

    End Sub

    Private Sub PID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        generate_csv_pidlist()
    End Sub

    Private Sub Website_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Website.Click
        System.Diagnostics.Process.Start("http://www.pjdaniel.org.uk/mpeg/")
    End Sub

    Private Sub Check_Sync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Check_Sync_Bytes.Click
        Dim pkt As Integer
        Dim c As Integer
        'Dim sync(1) As Byte
        c = 0

        ' read the first packet
        move_first()

        status1.Text = "Checking sync bytes..."
        Cursor = Cursors.AppStarting
        Application.DoEvents()

        Dim sw As New Stopwatch
        sw.Start()

        ' move to start of file
        fs.Seek(0 + offset, SeekOrigin.Begin)

        For pkt = 1 To max_packets

            If stop_search = True Then Exit For
            'Debug.Print(pkt & ";" & fs.Position.ToString())

            ' only update every 32 packets for speed
            If pkt Mod 32 = 0 Then
                Application.DoEvents()
                FileProgressBar.Value = pkt
            End If

            ' read a byte
            fs.Read(ts_bytes, 0, 1)
            ' move forward to start of next packet
            fs.Seek(packet_size - 1, IO.SeekOrigin.Current)

            ' check the sync byte
            If ts_bytes(0) <> &H47 Then
                Cursor = Cursors.Arrow
                Dim q As Integer = MsgBox("Error in packet " & pkt & ". Sync byte read as " & Hex(ts_bytes(0)) & vbCr & "Continue with check?", MsgBoxStyle.YesNo)
                If q = 7 Then
                    move_first()
                    Exit Sub
                Else
                    Cursor = Cursors.AppStarting
                    Application.DoEvents()
                End If
            Else

                c = c + 1
            End If

            'Debug.Print(pkt & ";end;" & fs.Position.ToString())
        Next

        sw.Stop()

        Cursor = Cursors.Arrow

        MsgBox(c & " / " & max_packets & " sync bytes present and correct. " & vbCrLf & sw.ElapsedMilliseconds & "ms.", MsgBoxStyle.Information)
        stop_search = False
        move_first()
    End Sub

    Private Sub Debug1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dlgDebug.Show()
    End Sub

    Private Sub Debug2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim g As Graphics = Me.CreateGraphics
        'MessageBox.Show(String.Format("{0}x{1}", g.DpiX.ToString(), g.DpiY.ToString()))
        'g.Dispose()
        dlgTableReport.Show()
    End Sub

    Private Sub Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Stop.Click
        stop_search = True
    End Sub

    Private Sub dlgMain_ResizeEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd, MyBase.SizeChanged, MyBase.Load
        ' Debug.Print("size changed to: " & Me.Width & ":" & Me.Height)
        Dim g As Graphics = Me.CreateGraphics
        Dim dpi_y As Single = g.DpiY
        Dim dpi_x As Single = g.DpiX
        '        MessageBox.Show(String.Format("{0}x{1}", g.DpiX.ToString(), g.DpiY.ToString()))
        g.Dispose()

        If dpi_y = 120 And dpi_x = 120 Then
            viewer.Width = Me.Width - 681 - 70 - 180
            viewer.Height = Me.Height - 126 - 28
        Else
            viewer.Width = Me.Width - 681 - 70
            viewer.Height = Me.Height - 126
        End If



    End Sub

    Private Sub Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Report.Click
        dlgReport.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        System.Diagnostics.Process.Start("http://www.pjdaniel.org.uk/mpeg/")
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Close.Click
        Debug.Print("menu_close")
        ts_close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AnalysePacketSpacingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnalysePacketSpacingToolStripMenuItem.Click
        dlgSpacing.Show()
        dlgSpacing.Activate()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_SavePacket.Click
        Debug.Print("save packet")

        Dim savepath As String
        Dim cur_byte As Integer
        SaveFileDialog1.Title = "Save packet " & current_packet.ToString
        SaveFileDialog1.FileName = Nothing
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.DefaultExt = ".ts"
        SaveFileDialog1.Filter = "TS files (*.ts)|*.ts|MPEG files (*.mpg)|*.mpg|All files (*.*)|*.*"
        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Try
                savepath = SaveFileDialog1.FileName
                If (savepath IsNot Nothing) Then
                    Dim fsOutput As New FileStream(savepath, FileMode.Create, FileAccess.Write, FileShare.None)
                    Dim bwOutput As New BinaryWriter(fsOutput)
                    read_ts_pkt(current_packet, 188)

                    For cur_byte = 0 To 187
                        bwOutput.Write(ts_bytes(cur_byte))
                    Next

                    bwOutput.Close()
                    fsOutput.Close()
                    fsOutput.Dispose()
                End If

            Catch Ex As Exception
                MessageBox.Show("Cannot write file to disk. Error: " & Ex.Message)

            End Try

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TablePIDListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TablePIDListToolStripMenuItem.Click
        dlgTablePIDs.Show()
    End Sub


    Private Sub Bytes_Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_bytes.Click

        ' generate label for hex byte viewer either starting at 1 or 0
        ' toggle between when clicking on control

        Dim out As String = ""
        If lbl_bytes.Text.StartsWith("1") Then
            out = "0"
            For j As Integer = 16 To 176 Step 16
                out += vbCrLf + j.ToString
            Next
        Else
            out = "1"
            For j As Integer = 17 To 177 Step 16
                out += vbCrLf + j.ToString
            Next
        End If
        lbl_bytes.Text = out

    End Sub

    Private Sub dlgMain_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown, ToolStrip1.KeyDown, MenuStrip1.KeyDown, StatusStrip1.KeyDown
        Debug.Print("key down: " & e.KeyCode)

        'check for open file
        If max_packets = 0 Then Exit Sub

        Select Case e.KeyCode
            Case Keys.PageDown
                move_next()
                Exit Sub
            Case Keys.PageUp
                move_prev()
                Exit Sub
            Case Keys.Home
                move_first()
                Exit Sub
            Case Keys.End
                dlgGoto.ShowDialog()
                Exit Sub
            Case Keys.Escape
                stop_search = True
                Exit Sub
        End Select

    End Sub

    Private Sub KeyboardShortcutsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeyboardShortcutsToolStripMenuItem.Click
        MsgBox("Keyboard shortcuts for navigation in the packet viewer: " & vbCrLf & vbCrLf & "PageDown : Next packet" & vbCrLf & "PageUp : Prev packet" & vbCrLf & "Home : First packet" & vbCrLf & "End : Goto packet" & vbCrLf & "Escape : Stop search", MsgBoxStyle.Information, Application.ProductName)
    End Sub

    Private Sub GenerateTableReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_TableReport.Click
        dlgTableReport.ShowDialog()
    End Sub

    Private Sub tbPacketNote2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPacketNote2.TextChanged

    End Sub

    Private Sub dlgMain_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            For Each fileLoc As String In filePaths


                If File.Exists(filePaths(0)) Then
                    ts_close()
                    ts_open(filePaths(0))
                End If

            Next fileLoc
        End If
    End Sub

    Private Sub dlgMain_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Menu_Packet_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        open_file_dialogue("Packet")
    End Sub

    Private Sub tbTSSync_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTSSync.TextChanged

    End Sub

    Private Sub ToolStripMenuItem1_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        dlgOptions.Show()
        dlgOptions.Activate()
    End Sub

    Private Sub LicenceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LicenceToolStripMenuItem.Click
        Dim waranty As String = "THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS ""AS IS"" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE."
        DialogResult = MessageBox.Show("This application is released as SHAREWARE." & vbCrLf & "If you have not done so please purchase a licence from www.pjdaniel.org.uk/mpeg" & vbCrLf & vbCrLf & waranty, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_debug1.Click
        displayHexBytes()
    End Sub

    Private Sub ToolStripButton2_Click_2(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ToolStripButton2.Checked = Not ToolStripButton2.Checked
        update_dlgMain()
    End Sub
End Class

'Private Sub toolbarDataViewer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    'dlgViewer.Show()
'End Sub

'Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    debug_byte_to_binary(16)
'    'decode_video_header()
'End Sub

'Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    dlgAFDGOPexport.tb_start.Text = 1
'    dlgAFDGOPexport.tb_end.Text = max_packets
'    dlgAFDGOPexport.tb_pid.Select()
'    dlgAFDGOPexport.Show()
'End Sub

'Private Sub dlgmain_Move(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusStrip1.Move
'    'Debug.Print("I've moved! " & Me.Location.ToString)
'    ' If DockMenuItem.Checked = True Then
'    'dlgViewer.dock_now()
'    '  End If
'End Sub

'Private Sub DockDataViewerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    '  If Me.DockMenuItem.Checked = True Then
'    'Me.DockMenuItem.Checked = False
'    '   Else
'    '   Me.DockMenuItem.Checked = True
'    '   dlgViewer.dock_now()
'    '  End If
'End Sub

'Private Sub TDTAndTOTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    dlgTDTcheck.tb_start.Text = 1
'    dlgTDTcheck.tb_end.Text = max_packets
'    dlgTDTcheck.Show()
'End Sub

'Private Sub TablesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    dlgTablesExport.tb_start.Text = 1
'    dlgTablesExport.tb_end.Text = max_packets
'    dlgTablesExport.Show()
'End Sub

'Private Sub TSHeadersToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    dlgHeaderExport.tb_start.Text = 1
'    dlgHeaderExport.tb_end.Text = max_packets
'    dlgHeaderExport.Show()
'End Sub