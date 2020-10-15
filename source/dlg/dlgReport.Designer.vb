<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_Stop = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btn_Start = New System.Windows.Forms.Button()
        Me.txt_Filepath = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_End = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Start = New System.Windows.Forms.TextBox()
        Me.GroupBoxFields = New System.Windows.Forms.GroupBox()
        Me.cb_PacketDelta = New System.Windows.Forms.CheckBox()
        Me.cb_PES_PTS_DTS = New System.Windows.Forms.CheckBox()
        Me.cb_PID = New System.Windows.Forms.CheckBox()
        Me.cb_TimeDelta = New System.Windows.Forms.CheckBox()
        Me.cb_TDT_TOT = New System.Windows.Forms.CheckBox()
        Me.cb_tsheaders = New System.Windows.Forms.CheckBox()
        Me.cb_TableHeaders = New System.Windows.Forms.CheckBox()
        Me.cb_GOP_AFD = New System.Windows.Forms.CheckBox()
        Me.cb_PES_streamid = New System.Windows.Forms.CheckBox()
        Me.cb_adaptationPCR = New System.Windows.Forms.CheckBox()
        Me.cb_adaptation = New System.Windows.Forms.CheckBox()
        Me.cb_PIDinfo = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cb_no_repeat = New System.Windows.Forms.CheckBox()
        Me.cb_limit64k = New System.Windows.Forms.CheckBox()
        Me.cb_preamble_filepath = New System.Windows.Forms.CheckBox()
        Me.cb_preamble_time = New System.Windows.Forms.CheckBox()
        Me.cb_PIDfilter = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cb_pcr_filter = New System.Windows.Forms.CheckBox()
        Me.cb_adaptation_filter = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cb_PayloadFilter = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_pid = New System.Windows.Forms.TextBox()
        Me.SaveReport = New System.Windows.Forms.SaveFileDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip_Progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStrip_Counter = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cb_ad = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBoxFields.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_close)
        Me.GroupBox1.Controls.Add(Me.btn_Stop)
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.Controls.Add(Me.btn_Start)
        Me.GroupBox1.Controls.Add(Me.txt_Filepath)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(739, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filename"
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(657, 17)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(73, 22)
        Me.btn_close.TabIndex = 6
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_Stop
        '
        Me.btn_Stop.Enabled = False
        Me.btn_Stop.Location = New System.Drawing.Point(578, 17)
        Me.btn_Stop.Name = "btn_Stop"
        Me.btn_Stop.Size = New System.Drawing.Size(73, 22)
        Me.btn_Stop.TabIndex = 8
        Me.btn_Stop.Text = "Stop"
        Me.btn_Stop.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(420, 17)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(73, 22)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btn_Start
        '
        Me.btn_Start.Location = New System.Drawing.Point(499, 17)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(73, 22)
        Me.btn_Start.TabIndex = 5
        Me.btn_Start.Text = "Start"
        Me.btn_Start.UseVisualStyleBackColor = True
        '
        'txt_Filepath
        '
        Me.txt_Filepath.Location = New System.Drawing.Point(18, 18)
        Me.txt_Filepath.Name = "txt_Filepath"
        Me.txt_Filepath.Size = New System.Drawing.Size(395, 20)
        Me.txt_Filepath.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_End)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_Start)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(212, 82)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Source range filter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last packet"
        '
        'txt_End
        '
        Me.txt_End.Location = New System.Drawing.Point(18, 46)
        Me.txt_End.Name = "txt_End"
        Me.txt_End.Size = New System.Drawing.Size(80, 20)
        Me.txt_End.TabIndex = 2
        Me.txt_End.Text = "2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First packet"
        '
        'txt_Start
        '
        Me.txt_Start.Location = New System.Drawing.Point(18, 21)
        Me.txt_Start.Name = "txt_Start"
        Me.txt_Start.Size = New System.Drawing.Size(80, 20)
        Me.txt_Start.TabIndex = 0
        Me.txt_Start.Text = "1"
        '
        'GroupBoxFields
        '
        Me.GroupBoxFields.Controls.Add(Me.cb_ad)
        Me.GroupBoxFields.Controls.Add(Me.cb_PacketDelta)
        Me.GroupBoxFields.Controls.Add(Me.cb_PES_PTS_DTS)
        Me.GroupBoxFields.Controls.Add(Me.cb_PID)
        Me.GroupBoxFields.Controls.Add(Me.cb_TimeDelta)
        Me.GroupBoxFields.Controls.Add(Me.cb_TDT_TOT)
        Me.GroupBoxFields.Controls.Add(Me.cb_tsheaders)
        Me.GroupBoxFields.Controls.Add(Me.cb_TableHeaders)
        Me.GroupBoxFields.Controls.Add(Me.cb_GOP_AFD)
        Me.GroupBoxFields.Controls.Add(Me.cb_PES_streamid)
        Me.GroupBoxFields.Controls.Add(Me.cb_adaptationPCR)
        Me.GroupBoxFields.Controls.Add(Me.cb_adaptation)
        Me.GroupBoxFields.Controls.Add(Me.cb_PIDinfo)
        Me.GroupBoxFields.Location = New System.Drawing.Point(540, 67)
        Me.GroupBoxFields.Name = "GroupBoxFields"
        Me.GroupBoxFields.Size = New System.Drawing.Size(212, 304)
        Me.GroupBoxFields.TabIndex = 2
        Me.GroupBoxFields.TabStop = False
        Me.GroupBoxFields.Text = "CSV fields"
        '
        'cb_PacketDelta
        '
        Me.cb_PacketDelta.AutoSize = True
        Me.cb_PacketDelta.Location = New System.Drawing.Point(18, 267)
        Me.cb_PacketDelta.Name = "cb_PacketDelta"
        Me.cb_PacketDelta.Size = New System.Drawing.Size(100, 17)
        Me.cb_PacketDelta.TabIndex = 13
        Me.cb_PacketDelta.Text = "Packet spacing"
        Me.cb_PacketDelta.UseVisualStyleBackColor = True
        '
        'cb_PES_PTS_DTS
        '
        Me.cb_PES_PTS_DTS.AutoSize = True
        Me.cb_PES_PTS_DTS.Location = New System.Drawing.Point(18, 133)
        Me.cb_PES_PTS_DTS.Name = "cb_PES_PTS_DTS"
        Me.cb_PES_PTS_DTS.Size = New System.Drawing.Size(102, 17)
        Me.cb_PES_PTS_DTS.TabIndex = 12
        Me.cb_PES_PTS_DTS.Text = "PES PTS, DTS "
        Me.cb_PES_PTS_DTS.UseVisualStyleBackColor = True
        '
        'cb_PID
        '
        Me.cb_PID.AutoSize = True
        Me.cb_PID.Location = New System.Drawing.Point(18, 21)
        Me.cb_PID.Name = "cb_PID"
        Me.cb_PID.Size = New System.Drawing.Size(44, 17)
        Me.cb_PID.TabIndex = 11
        Me.cb_PID.Text = "PID"
        Me.cb_PID.UseVisualStyleBackColor = True
        '
        'cb_TimeDelta
        '
        Me.cb_TimeDelta.AutoSize = True
        Me.cb_TimeDelta.Location = New System.Drawing.Point(18, 246)
        Me.cb_TimeDelta.Name = "cb_TimeDelta"
        Me.cb_TimeDelta.Size = New System.Drawing.Size(123, 17)
        Me.cb_TimeDelta.TabIndex = 10
        Me.cb_TimeDelta.Text = "TDT/TOT time delta"
        Me.cb_TimeDelta.UseVisualStyleBackColor = True
        '
        'cb_TDT_TOT
        '
        Me.cb_TDT_TOT.AutoSize = True
        Me.cb_TDT_TOT.Location = New System.Drawing.Point(18, 224)
        Me.cb_TDT_TOT.Name = "cb_TDT_TOT"
        Me.cb_TDT_TOT.Size = New System.Drawing.Size(142, 17)
        Me.cb_TDT_TOT.TabIndex = 7
        Me.cb_TDT_TOT.Text = "TDT/TOT decoded time"
        Me.cb_TDT_TOT.UseVisualStyleBackColor = True
        '
        'cb_tsheaders
        '
        Me.cb_tsheaders.AutoSize = True
        Me.cb_tsheaders.Location = New System.Drawing.Point(18, 43)
        Me.cb_tsheaders.Name = "cb_tsheaders"
        Me.cb_tsheaders.Size = New System.Drawing.Size(103, 17)
        Me.cb_tsheaders.TabIndex = 0
        Me.cb_tsheaders.Text = "TS header fields"
        Me.cb_tsheaders.UseVisualStyleBackColor = True
        '
        'cb_TableHeaders
        '
        Me.cb_TableHeaders.AutoSize = True
        Me.cb_TableHeaders.Location = New System.Drawing.Point(18, 201)
        Me.cb_TableHeaders.Name = "cb_TableHeaders"
        Me.cb_TableHeaders.Size = New System.Drawing.Size(116, 17)
        Me.cb_TableHeaders.TabIndex = 6
        Me.cb_TableHeaders.Text = "Table header fields"
        Me.cb_TableHeaders.UseVisualStyleBackColor = True
        '
        'cb_GOP_AFD
        '
        Me.cb_GOP_AFD.AutoSize = True
        Me.cb_GOP_AFD.Location = New System.Drawing.Point(18, 155)
        Me.cb_GOP_AFD.Name = "cb_GOP_AFD"
        Me.cb_GOP_AFD.Size = New System.Drawing.Size(94, 17)
        Me.cb_GOP_AFD.TabIndex = 5
        Me.cb_GOP_AFD.Text = "GOP and AFD"
        Me.cb_GOP_AFD.UseVisualStyleBackColor = True
        '
        'cb_PES_streamid
        '
        Me.cb_PES_streamid.AutoSize = True
        Me.cb_PES_streamid.Location = New System.Drawing.Point(18, 110)
        Me.cb_PES_streamid.Name = "cb_PES_streamid"
        Me.cb_PES_streamid.Size = New System.Drawing.Size(148, 17)
        Me.cb_PES_streamid.TabIndex = 4
        Me.cb_PES_streamid.Text = "PES stream id, scrambling"
        Me.cb_PES_streamid.UseVisualStyleBackColor = True
        '
        'cb_adaptationPCR
        '
        Me.cb_adaptationPCR.AutoSize = True
        Me.cb_adaptationPCR.Location = New System.Drawing.Point(18, 88)
        Me.cb_adaptationPCR.Name = "cb_adaptationPCR"
        Me.cb_adaptationPCR.Size = New System.Drawing.Size(102, 17)
        Me.cb_adaptationPCR.TabIndex = 3
        Me.cb_adaptationPCR.Text = "Adaptation PCR"
        Me.cb_adaptationPCR.UseVisualStyleBackColor = True
        '
        'cb_adaptation
        '
        Me.cb_adaptation.AutoSize = True
        Me.cb_adaptation.Location = New System.Drawing.Point(18, 66)
        Me.cb_adaptation.Name = "cb_adaptation"
        Me.cb_adaptation.Size = New System.Drawing.Size(124, 17)
        Me.cb_adaptation.TabIndex = 2
        Me.cb_adaptation.Text = "Adaptation flag fields"
        Me.cb_adaptation.UseVisualStyleBackColor = True
        '
        'cb_PIDinfo
        '
        Me.cb_PIDinfo.AutoSize = True
        Me.cb_PIDinfo.Location = New System.Drawing.Point(74, 21)
        Me.cb_PIDinfo.Name = "cb_PIDinfo"
        Me.cb_PIDinfo.Size = New System.Drawing.Size(64, 17)
        Me.cb_PIDinfo.TabIndex = 1
        Me.cb_PIDinfo.Text = "PID info"
        Me.cb_PIDinfo.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cb_no_repeat)
        Me.GroupBox4.Controls.Add(Me.cb_limit64k)
        Me.GroupBox4.Controls.Add(Me.cb_preamble_filepath)
        Me.GroupBox4.Controls.Add(Me.cb_preamble_time)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 155)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(212, 216)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Output options"
        '
        'cb_no_repeat
        '
        Me.cb_no_repeat.AutoSize = True
        Me.cb_no_repeat.Location = New System.Drawing.Point(18, 88)
        Me.cb_no_repeat.Name = "cb_no_repeat"
        Me.cb_no_repeat.Size = New System.Drawing.Size(162, 17)
        Me.cb_no_repeat.TabIndex = 3
        Me.cb_no_repeat.Text = "Mark repeated table headers"
        Me.cb_no_repeat.UseVisualStyleBackColor = True
        '
        'cb_limit64k
        '
        Me.cb_limit64k.AutoSize = True
        Me.cb_limit64k.Location = New System.Drawing.Point(18, 65)
        Me.cb_limit64k.Name = "cb_limit64k"
        Me.cb_limit64k.Size = New System.Drawing.Size(137, 17)
        Me.cb_limit64k.TabIndex = 2
        Me.cb_limit64k.Text = "Limit output to 64k lines"
        Me.cb_limit64k.UseVisualStyleBackColor = True
        '
        'cb_preamble_filepath
        '
        Me.cb_preamble_filepath.AutoSize = True
        Me.cb_preamble_filepath.Location = New System.Drawing.Point(18, 42)
        Me.cb_preamble_filepath.Name = "cb_preamble_filepath"
        Me.cb_preamble_filepath.Size = New System.Drawing.Size(122, 17)
        Me.cb_preamble_filepath.TabIndex = 1
        Me.cb_preamble_filepath.Text = "Add source filename"
        Me.cb_preamble_filepath.UseVisualStyleBackColor = True
        '
        'cb_preamble_time
        '
        Me.cb_preamble_time.AutoSize = True
        Me.cb_preamble_time.Location = New System.Drawing.Point(18, 20)
        Me.cb_preamble_time.Name = "cb_preamble_time"
        Me.cb_preamble_time.Size = New System.Drawing.Size(125, 17)
        Me.cb_preamble_time.TabIndex = 0
        Me.cb_preamble_time.Text = "Add export date/time"
        Me.cb_preamble_time.UseVisualStyleBackColor = True
        '
        'cb_PIDfilter
        '
        Me.cb_PIDfilter.AutoSize = True
        Me.cb_PIDfilter.Location = New System.Drawing.Point(10, 18)
        Me.cb_PIDfilter.Name = "cb_PIDfilter"
        Me.cb_PIDfilter.Size = New System.Drawing.Size(66, 17)
        Me.cb_PIDfilter.TabIndex = 0
        Me.cb_PIDfilter.Text = "PID filter"
        Me.cb_PIDfilter.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.cb_pcr_filter)
        Me.GroupBox5.Controls.Add(Me.cb_adaptation_filter)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.cb_PayloadFilter)
        Me.GroupBox5.Controls.Add(Me.cb_PIDfilter)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.tb_pid)
        Me.GroupBox5.Location = New System.Drawing.Point(231, 67)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(302, 304)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Stream filters"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(116, 150)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 22)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Fill DVB tables"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cb_pcr_filter
        '
        Me.cb_pcr_filter.AutoSize = True
        Me.cb_pcr_filter.Location = New System.Drawing.Point(10, 223)
        Me.cb_pcr_filter.Name = "cb_pcr_filter"
        Me.cb_pcr_filter.Size = New System.Drawing.Size(140, 17)
        Me.cb_pcr_filter.TabIndex = 11
        Me.cb_pcr_filter.Text = "Adaptation PCR flag = 1"
        Me.cb_pcr_filter.UseVisualStyleBackColor = True
        '
        'cb_adaptation_filter
        '
        Me.cb_adaptation_filter.AutoSize = True
        Me.cb_adaptation_filter.Location = New System.Drawing.Point(10, 201)
        Me.cb_adaptation_filter.Name = "cb_adaptation_filter"
        Me.cb_adaptation_filter.Size = New System.Drawing.Size(115, 17)
        Me.cb_adaptation_filter.TabIndex = 10
        Me.cb_adaptation_filter.Text = "Adaptation present"
        Me.cb_adaptation_filter.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 22)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Fill MPEG tables"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cb_PayloadFilter
        '
        Me.cb_PayloadFilter.AutoSize = True
        Me.cb_PayloadFilter.Location = New System.Drawing.Point(10, 178)
        Me.cb_PayloadFilter.Name = "cb_PayloadFilter"
        Me.cb_PayloadFilter.Size = New System.Drawing.Size(105, 17)
        Me.cb_PayloadFilter.TabIndex = 8
        Me.cb_PayloadFilter.Text = "Payload start = 1"
        Me.cb_PayloadFilter.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Use commas to specify multiple PIDs (decimal)"
        '
        'tb_pid
        '
        Me.tb_pid.Enabled = False
        Me.tb_pid.Location = New System.Drawing.Point(10, 54)
        Me.tb_pid.MaxLength = 9000
        Me.tb_pid.Multiline = True
        Me.tb_pid.Name = "tb_pid"
        Me.tb_pid.Size = New System.Drawing.Size(279, 90)
        Me.tb_pid.TabIndex = 0
        Me.tb_pid.Text = "0"
        '
        'SaveReport
        '
        Me.SaveReport.Filter = "Comma Separated Variable (*.csv)|*.csv|All files|*.*"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStrip_Progress, Me.ToolStrip_Counter})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 374)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 15, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(766, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(91, 17)
        Me.ToolStripStatusLabel1.Text = "Export progress:"
        '
        'ToolStrip_Progress
        '
        Me.ToolStrip_Progress.ForeColor = System.Drawing.Color.ForestGreen
        Me.ToolStrip_Progress.Name = "ToolStrip_Progress"
        Me.ToolStrip_Progress.Size = New System.Drawing.Size(214, 16)
        Me.ToolStrip_Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'ToolStrip_Counter
        '
        Me.ToolStrip_Counter.Name = "ToolStrip_Counter"
        Me.ToolStrip_Counter.Size = New System.Drawing.Size(13, 17)
        Me.ToolStrip_Counter.Text = "0"
        '
        'cb_ad
        '
        Me.cb_ad.AutoSize = True
        Me.cb_ad.Location = New System.Drawing.Point(18, 178)
        Me.cb_ad.Name = "cb_ad"
        Me.cb_ad.Size = New System.Drawing.Size(109, 17)
        Me.cb_ad.TabIndex = 14
        Me.cb_ad.Text = "Audio Description"
        Me.cb_ad.UseVisualStyleBackColor = True
        '
        'dlgReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(766, 396)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBoxFields)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "dlgReport"
        Me.ShowInTaskbar = False
        Me.Text = "Generate report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBoxFields.ResumeLayout(False)
        Me.GroupBoxFields.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txt_Filepath As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_End As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Start As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxFields As System.Windows.Forms.GroupBox
    Friend WithEvents cb_TimeDelta As System.Windows.Forms.CheckBox
    Friend WithEvents cb_TDT_TOT As System.Windows.Forms.CheckBox
    Friend WithEvents cb_TableHeaders As System.Windows.Forms.CheckBox
    Friend WithEvents cb_GOP_AFD As System.Windows.Forms.CheckBox
    Friend WithEvents cb_PES_streamid As System.Windows.Forms.CheckBox
    Friend WithEvents cb_adaptationPCR As System.Windows.Forms.CheckBox
    Friend WithEvents cb_adaptation As System.Windows.Forms.CheckBox
    Friend WithEvents cb_PIDinfo As System.Windows.Forms.CheckBox
    Friend WithEvents cb_tsheaders As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_PIDfilter As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_pid As System.Windows.Forms.TextBox
    Friend WithEvents cb_preamble_time As System.Windows.Forms.CheckBox
    Friend WithEvents cb_PayloadFilter As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Start As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents SaveReport As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cb_PID As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Stop As System.Windows.Forms.Button
    Friend WithEvents cb_PES_PTS_DTS As System.Windows.Forms.CheckBox
    Friend WithEvents cb_PacketDelta As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip_Progress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStrip_Counter As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cb_preamble_filepath As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cb_adaptation_filter As System.Windows.Forms.CheckBox
    Friend WithEvents cb_pcr_filter As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cb_limit64k As System.Windows.Forms.CheckBox
    Friend WithEvents cb_no_repeat As System.Windows.Forms.CheckBox
    Friend WithEvents cb_ad As CheckBox
End Class
