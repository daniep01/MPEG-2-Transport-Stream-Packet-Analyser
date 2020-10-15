<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTableReport
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
        Me.components = New System.ComponentModel.Container()
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
        Me.cb_version = New System.Windows.Forms.CheckBox()
        Me.cb_PID = New System.Windows.Forms.CheckBox()
        Me.cb_lastSection = New System.Windows.Forms.CheckBox()
        Me.cb_section = New System.Windows.Forms.CheckBox()
        Me.cb_pointer = New System.Windows.Forms.CheckBox()
        Me.cb_currentNext = New System.Windows.Forms.CheckBox()
        Me.cb_subTableId = New System.Windows.Forms.CheckBox()
        Me.cb_sectionLength = New System.Windows.Forms.CheckBox()
        Me.cb_tableid = New System.Windows.Forms.CheckBox()
        Me.cb_PIDinfo = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cb_no_duplicates = New System.Windows.Forms.CheckBox()
        Me.cb_limit64k = New System.Windows.Forms.CheckBox()
        Me.cb_preamble_filepath = New System.Windows.Forms.CheckBox()
        Me.cb_preamble_time = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_subtable = New System.Windows.Forms.TextBox()
        Me.cb_subtable = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tb_pid = New System.Windows.Forms.TextBox()
        Me.SaveReport = New System.Windows.Forms.SaveFileDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip_Progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStrip_Counter = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.GroupBoxFields.Controls.Add(Me.cb_PacketDelta)
        Me.GroupBoxFields.Controls.Add(Me.cb_version)
        Me.GroupBoxFields.Controls.Add(Me.cb_PID)
        Me.GroupBoxFields.Controls.Add(Me.cb_lastSection)
        Me.GroupBoxFields.Controls.Add(Me.cb_section)
        Me.GroupBoxFields.Controls.Add(Me.cb_pointer)
        Me.GroupBoxFields.Controls.Add(Me.cb_currentNext)
        Me.GroupBoxFields.Controls.Add(Me.cb_subTableId)
        Me.GroupBoxFields.Controls.Add(Me.cb_sectionLength)
        Me.GroupBoxFields.Controls.Add(Me.cb_tableid)
        Me.GroupBoxFields.Controls.Add(Me.cb_PIDinfo)
        Me.GroupBoxFields.Location = New System.Drawing.Point(540, 67)
        Me.GroupBoxFields.Name = "GroupBoxFields"
        Me.GroupBoxFields.Size = New System.Drawing.Size(212, 273)
        Me.GroupBoxFields.TabIndex = 2
        Me.GroupBoxFields.TabStop = False
        Me.GroupBoxFields.Text = "CSV fields"
        '
        'cb_PacketDelta
        '
        Me.cb_PacketDelta.AutoSize = True
        Me.cb_PacketDelta.Location = New System.Drawing.Point(18, 221)
        Me.cb_PacketDelta.Name = "cb_PacketDelta"
        Me.cb_PacketDelta.Size = New System.Drawing.Size(100, 17)
        Me.cb_PacketDelta.TabIndex = 13
        Me.cb_PacketDelta.Text = "Packet spacing"
        Me.cb_PacketDelta.UseVisualStyleBackColor = True
        '
        'cb_version
        '
        Me.cb_version.AutoSize = True
        Me.cb_version.Checked = True
        Me.cb_version.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_version.Location = New System.Drawing.Point(18, 133)
        Me.cb_version.Name = "cb_version"
        Me.cb_version.Size = New System.Drawing.Size(99, 17)
        Me.cb_version.TabIndex = 12
        Me.cb_version.Text = "Version number"
        Me.cb_version.UseVisualStyleBackColor = True
        '
        'cb_PID
        '
        Me.cb_PID.AutoSize = True
        Me.cb_PID.Checked = True
        Me.cb_PID.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_PID.Location = New System.Drawing.Point(18, 21)
        Me.cb_PID.Name = "cb_PID"
        Me.cb_PID.Size = New System.Drawing.Size(44, 17)
        Me.cb_PID.TabIndex = 11
        Me.cb_PID.Text = "PID"
        Me.cb_PID.UseVisualStyleBackColor = True
        '
        'cb_lastSection
        '
        Me.cb_lastSection.AutoSize = True
        Me.cb_lastSection.Checked = True
        Me.cb_lastSection.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_lastSection.Location = New System.Drawing.Point(18, 200)
        Me.cb_lastSection.Name = "cb_lastSection"
        Me.cb_lastSection.Size = New System.Drawing.Size(121, 17)
        Me.cb_lastSection.TabIndex = 10
        Me.cb_lastSection.Text = "Last section number"
        Me.cb_lastSection.UseVisualStyleBackColor = True
        '
        'cb_section
        '
        Me.cb_section.AutoSize = True
        Me.cb_section.Checked = True
        Me.cb_section.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_section.Location = New System.Drawing.Point(18, 178)
        Me.cb_section.Name = "cb_section"
        Me.cb_section.Size = New System.Drawing.Size(100, 17)
        Me.cb_section.TabIndex = 7
        Me.cb_section.Text = "Section number"
        Me.cb_section.UseVisualStyleBackColor = True
        '
        'cb_pointer
        '
        Me.cb_pointer.AutoSize = True
        Me.cb_pointer.Location = New System.Drawing.Point(18, 43)
        Me.cb_pointer.Name = "cb_pointer"
        Me.cb_pointer.Size = New System.Drawing.Size(59, 17)
        Me.cb_pointer.TabIndex = 0
        Me.cb_pointer.Text = "Pointer"
        Me.cb_pointer.UseVisualStyleBackColor = True
        '
        'cb_currentNext
        '
        Me.cb_currentNext.AutoSize = True
        Me.cb_currentNext.Checked = True
        Me.cb_currentNext.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_currentNext.Location = New System.Drawing.Point(18, 155)
        Me.cb_currentNext.Name = "cb_currentNext"
        Me.cb_currentNext.Size = New System.Drawing.Size(128, 17)
        Me.cb_currentNext.TabIndex = 5
        Me.cb_currentNext.Text = "Current Next indicator"
        Me.cb_currentNext.UseVisualStyleBackColor = True
        '
        'cb_subTableId
        '
        Me.cb_subTableId.AutoSize = True
        Me.cb_subTableId.Checked = True
        Me.cb_subTableId.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_subTableId.Location = New System.Drawing.Point(18, 110)
        Me.cb_subTableId.Name = "cb_subTableId"
        Me.cb_subTableId.Size = New System.Drawing.Size(82, 17)
        Me.cb_subTableId.TabIndex = 4
        Me.cb_subTableId.Text = "Sub table id"
        Me.cb_subTableId.UseVisualStyleBackColor = True
        '
        'cb_sectionLength
        '
        Me.cb_sectionLength.AutoSize = True
        Me.cb_sectionLength.Checked = True
        Me.cb_sectionLength.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_sectionLength.Location = New System.Drawing.Point(18, 88)
        Me.cb_sectionLength.Name = "cb_sectionLength"
        Me.cb_sectionLength.Size = New System.Drawing.Size(94, 17)
        Me.cb_sectionLength.TabIndex = 3
        Me.cb_sectionLength.Text = "Section length"
        Me.cb_sectionLength.UseVisualStyleBackColor = True
        '
        'cb_tableid
        '
        Me.cb_tableid.AutoSize = True
        Me.cb_tableid.Checked = True
        Me.cb_tableid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_tableid.Location = New System.Drawing.Point(18, 66)
        Me.cb_tableid.Name = "cb_tableid"
        Me.cb_tableid.Size = New System.Drawing.Size(64, 17)
        Me.cb_tableid.TabIndex = 2
        Me.cb_tableid.Text = "Table id"
        Me.cb_tableid.UseVisualStyleBackColor = True
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
        Me.GroupBox4.Controls.Add(Me.cb_no_duplicates)
        Me.GroupBox4.Controls.Add(Me.cb_limit64k)
        Me.GroupBox4.Controls.Add(Me.cb_preamble_filepath)
        Me.GroupBox4.Controls.Add(Me.cb_preamble_time)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 155)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(212, 185)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Output options"
        '
        'cb_no_duplicates
        '
        Me.cb_no_duplicates.AutoSize = True
        Me.cb_no_duplicates.Checked = True
        Me.cb_no_duplicates.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_no_duplicates.Location = New System.Drawing.Point(18, 88)
        Me.cb_no_duplicates.Name = "cb_no_duplicates"
        Me.cb_no_duplicates.Size = New System.Drawing.Size(115, 17)
        Me.cb_no_duplicates.TabIndex = 3
        Me.cb_no_duplicates.Text = "Exclude duplicates"
        Me.cb_no_duplicates.UseVisualStyleBackColor = True
        '
        'cb_limit64k
        '
        Me.cb_limit64k.AutoSize = True
        Me.cb_limit64k.Location = New System.Drawing.Point(18, 65)
        Me.cb_limit64k.Name = "cb_limit64k"
        Me.cb_limit64k.Size = New System.Drawing.Size(137, 17)
        Me.cb_limit64k.TabIndex = 2
        Me.cb_limit64k.Text = "Limit output to 64k lines"
        Me.ToolTip1.SetToolTip(Me.cb_limit64k, "Some spreadsheet applications can only import 64k lines")
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
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.txt_subtable)
        Me.GroupBox5.Controls.Add(Me.cb_subtable)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.tb_pid)
        Me.GroupBox5.Location = New System.Drawing.Point(231, 67)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(302, 273)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Stream filter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PID filter"
        '
        'txt_subtable
        '
        Me.txt_subtable.Location = New System.Drawing.Point(110, 131)
        Me.txt_subtable.Name = "txt_subtable"
        Me.txt_subtable.Size = New System.Drawing.Size(100, 20)
        Me.txt_subtable.TabIndex = 4
        '
        'cb_subtable
        '
        Me.cb_subtable.AutoSize = True
        Me.cb_subtable.Location = New System.Drawing.Point(11, 133)
        Me.cb_subtable.Name = "cb_subtable"
        Me.cb_subtable.Size = New System.Drawing.Size(93, 17)
        Me.cb_subtable.TabIndex = 3
        Me.cb_subtable.Text = "Sub table filter"
        Me.cb_subtable.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(215, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Edit PID list"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tb_pid
        '
        Me.tb_pid.BackColor = System.Drawing.SystemColors.Info
        Me.tb_pid.Location = New System.Drawing.Point(11, 40)
        Me.tb_pid.MaxLength = 9000
        Me.tb_pid.Multiline = True
        Me.tb_pid.Name = "tb_pid"
        Me.tb_pid.ReadOnly = True
        Me.tb_pid.Size = New System.Drawing.Size(279, 85)
        Me.tb_pid.TabIndex = 0
        Me.tb_pid.Text = "0"
        Me.ToolTip1.SetToolTip(Me.tb_pid, "Use Edit PID list button to modify")
        '
        'SaveReport
        '
        Me.SaveReport.Filter = "Comma Separated Variable (*.csv)|*.csv|All files|*.*"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStrip_Progress, Me.ToolStrip_Counter})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 360)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 15, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(766, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(88, 17)
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
        'dlgTableReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(766, 382)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBoxFields)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "dlgTableReport"
        Me.ShowInTaskbar = False
        Me.Text = "Generate tables report"
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
    Friend WithEvents cb_lastSection As System.Windows.Forms.CheckBox
    Friend WithEvents cb_section As System.Windows.Forms.CheckBox
    Friend WithEvents cb_currentNext As System.Windows.Forms.CheckBox
    Friend WithEvents cb_subTableId As System.Windows.Forms.CheckBox
    Friend WithEvents cb_sectionLength As System.Windows.Forms.CheckBox
    Friend WithEvents cb_tableid As System.Windows.Forms.CheckBox
    Friend WithEvents cb_PIDinfo As System.Windows.Forms.CheckBox
    Friend WithEvents cb_pointer As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_pid As System.Windows.Forms.TextBox
    Friend WithEvents cb_preamble_time As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Start As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents SaveReport As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cb_PID As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Stop As System.Windows.Forms.Button
    Friend WithEvents cb_version As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip_Progress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStrip_Counter As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cb_preamble_filepath As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cb_limit64k As System.Windows.Forms.CheckBox
    Friend WithEvents cb_no_duplicates As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cb_PacketDelta As System.Windows.Forms.CheckBox
    Friend WithEvents txt_subtable As System.Windows.Forms.TextBox
    Friend WithEvents cb_subtable As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
