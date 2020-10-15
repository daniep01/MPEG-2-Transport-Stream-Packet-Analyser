<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDemux
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TrimGroup = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_trimend = New System.Windows.Forms.TextBox()
        Me.txt_trimbegin = New System.Windows.Forms.TextBox()
        Me.OutputGroup = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_trimoutput = New System.Windows.Forms.TextBox()
        Me.radio_OutputTrim2 = New System.Windows.Forms.RadioButton()
        Me.radio_outputtrim1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_PES = New System.Windows.Forms.CheckBox()
        Me.cb_188ByteOutput = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbPIDdest = New System.Windows.Forms.ListBox()
        Me.lbPIDsource = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.txt_Filepath = New System.Windows.Forms.TextBox()
        Me.DemuxSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.btRemoveAll = New System.Windows.Forms.Button()
        Me.btAddAll = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.btRemove = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_destcount = New System.Windows.Forms.Label()
        Me.Label_sourcecount = New System.Windows.Forms.Label()
        Me.DemuxGroup = New System.Windows.Forms.GroupBox()
        Me.TrimGroup.SuspendLayout()
        Me.OutputGroup.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.DemuxGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrimGroup
        '
        Me.TrimGroup.Controls.Add(Me.Label3)
        Me.TrimGroup.Controls.Add(Me.Label4)
        Me.TrimGroup.Controls.Add(Me.txt_trimend)
        Me.TrimGroup.Controls.Add(Me.txt_trimbegin)
        Me.TrimGroup.Location = New System.Drawing.Point(398, 68)
        Me.TrimGroup.Name = "TrimGroup"
        Me.TrimGroup.Size = New System.Drawing.Size(353, 78)
        Me.TrimGroup.TabIndex = 2
        Me.TrimGroup.TabStop = False
        Me.TrimGroup.Text = "Source trim"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Stop demux at packet"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Begin demux at packet"
        '
        'txt_trimend
        '
        Me.txt_trimend.Location = New System.Drawing.Point(163, 47)
        Me.txt_trimend.Name = "txt_trimend"
        Me.txt_trimend.Size = New System.Drawing.Size(114, 20)
        Me.txt_trimend.TabIndex = 3
        '
        'txt_trimbegin
        '
        Me.txt_trimbegin.Location = New System.Drawing.Point(163, 22)
        Me.txt_trimbegin.Name = "txt_trimbegin"
        Me.txt_trimbegin.Size = New System.Drawing.Size(114, 20)
        Me.txt_trimbegin.TabIndex = 1
        Me.txt_trimbegin.Text = "1"
        '
        'OutputGroup
        '
        Me.OutputGroup.Controls.Add(Me.Label6)
        Me.OutputGroup.Controls.Add(Me.txt_trimoutput)
        Me.OutputGroup.Controls.Add(Me.radio_OutputTrim2)
        Me.OutputGroup.Controls.Add(Me.radio_outputtrim1)
        Me.OutputGroup.Location = New System.Drawing.Point(398, 152)
        Me.OutputGroup.Name = "OutputGroup"
        Me.OutputGroup.Size = New System.Drawing.Size(353, 75)
        Me.OutputGroup.TabIndex = 4
        Me.OutputGroup.TabStop = False
        Me.OutputGroup.Text = "Output trim"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(218, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "packets exported"
        '
        'txt_trimoutput
        '
        Me.txt_trimoutput.Enabled = False
        Me.txt_trimoutput.Location = New System.Drawing.Point(164, 42)
        Me.txt_trimoutput.Name = "txt_trimoutput"
        Me.txt_trimoutput.Size = New System.Drawing.Size(48, 20)
        Me.txt_trimoutput.TabIndex = 2
        '
        'radio_OutputTrim2
        '
        Me.radio_OutputTrim2.AutoSize = True
        Me.radio_OutputTrim2.Location = New System.Drawing.Point(82, 42)
        Me.radio_OutputTrim2.Name = "radio_OutputTrim2"
        Me.radio_OutputTrim2.Size = New System.Drawing.Size(71, 17)
        Me.radio_OutputTrim2.TabIndex = 1
        Me.radio_OutputTrim2.Text = "Stop after"
        Me.radio_OutputTrim2.UseVisualStyleBackColor = True
        '
        'radio_outputtrim1
        '
        Me.radio_outputtrim1.AutoSize = True
        Me.radio_outputtrim1.Checked = True
        Me.radio_outputtrim1.Location = New System.Drawing.Point(82, 20)
        Me.radio_outputtrim1.Name = "radio_outputtrim1"
        Me.radio_outputtrim1.Size = New System.Drawing.Size(51, 17)
        Me.radio_outputtrim1.TabIndex = 0
        Me.radio_outputtrim1.TabStop = True
        Me.radio_outputtrim1.Text = "None"
        Me.radio_outputtrim1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_PES)
        Me.GroupBox1.Controls.Add(Me.cb_188ByteOutput)
        Me.GroupBox1.Location = New System.Drawing.Point(401, 233)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 101)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Output packetization"
        '
        'cb_PES
        '
        Me.cb_PES.AutoSize = True
        Me.cb_PES.Enabled = False
        Me.cb_PES.Location = New System.Drawing.Point(164, 42)
        Me.cb_PES.Name = "cb_PES"
        Me.cb_PES.Size = New System.Drawing.Size(99, 17)
        Me.cb_PES.TabIndex = 1
        Me.cb_PES.Text = "Convert to PES"
        Me.cb_PES.UseVisualStyleBackColor = True
        '
        'cb_188ByteOutput
        '
        Me.cb_188ByteOutput.AutoSize = True
        Me.cb_188ByteOutput.Checked = True
        Me.cb_188ByteOutput.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_188ByteOutput.Location = New System.Drawing.Point(164, 19)
        Me.cb_188ByteOutput.Name = "cb_188ByteOutput"
        Me.cb_188ByteOutput.Size = New System.Drawing.Size(160, 17)
        Me.cb_188ByteOutput.TabIndex = 0
        Me.cb_188ByteOutput.Text = "Convert to 188-byte packets"
        Me.cb_188ByteOutput.UseVisualStyleBackColor = True
        '
        'lbPIDdest
        '
        Me.lbPIDdest.FormattingEnabled = True
        Me.lbPIDdest.Location = New System.Drawing.Point(221, 42)
        Me.lbPIDdest.Name = "lbPIDdest"
        Me.lbPIDdest.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbPIDdest.Size = New System.Drawing.Size(148, 212)
        Me.lbPIDdest.Sorted = True
        Me.lbPIDdest.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.lbPIDdest, "Use Shift or Ctrl to make multiple selections")
        '
        'lbPIDsource
        '
        Me.lbPIDsource.FormattingEnabled = True
        Me.lbPIDsource.Location = New System.Drawing.Point(10, 42)
        Me.lbPIDsource.Name = "lbPIDsource"
        Me.lbPIDsource.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbPIDsource.Size = New System.Drawing.Size(148, 212)
        Me.lbPIDsource.Sorted = True
        Me.lbPIDsource.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.lbPIDsource, "Use Shift or Ctrl to make multiple selections")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_close)
        Me.GroupBox2.Controls.Add(Me.btn_stop)
        Me.GroupBox2.Controls.Add(Me.btnBrowse)
        Me.GroupBox2.Controls.Add(Me.btn_start)
        Me.GroupBox2.Controls.Add(Me.txt_Filepath)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(739, 50)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filename"
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(657, 17)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(73, 22)
        Me.btn_close.TabIndex = 4
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.Enabled = False
        Me.btn_stop.Location = New System.Drawing.Point(578, 17)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(73, 22)
        Me.btn_stop.TabIndex = 3
        Me.btn_stop.Text = "Stop"
        Me.btn_stop.UseVisualStyleBackColor = True
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
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(499, 17)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(73, 22)
        Me.btn_start.TabIndex = 2
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'txt_Filepath
        '
        Me.txt_Filepath.Location = New System.Drawing.Point(18, 18)
        Me.txt_Filepath.Name = "txt_Filepath"
        Me.txt_Filepath.Size = New System.Drawing.Size(395, 20)
        Me.txt_Filepath.TabIndex = 0
        '
        'DemuxSaveFileDialog
        '
        Me.DemuxSaveFileDialog.DefaultExt = "ts"
        Me.DemuxSaveFileDialog.Filter = "Transport streams|*.ts;*.trp;*.m2t;*.m2ts;*.mts|All files|*.*"
        Me.DemuxSaveFileDialog.RestoreDirectory = True
        Me.DemuxSaveFileDialog.Title = "Export Transport Stream"
        '
        'btRemoveAll
        '
        Me.btRemoveAll.Location = New System.Drawing.Point(164, 175)
        Me.btRemoveAll.Name = "btRemoveAll"
        Me.btRemoveAll.Size = New System.Drawing.Size(48, 22)
        Me.btRemoveAll.TabIndex = 6
        Me.btRemoveAll.Text = "<<"
        Me.btRemoveAll.UseVisualStyleBackColor = True
        '
        'btAddAll
        '
        Me.btAddAll.Location = New System.Drawing.Point(164, 146)
        Me.btAddAll.Name = "btAddAll"
        Me.btAddAll.Size = New System.Drawing.Size(48, 22)
        Me.btAddAll.TabIndex = 5
        Me.btAddAll.Text = ">>"
        Me.btAddAll.UseVisualStyleBackColor = True
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(164, 62)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(48, 22)
        Me.btAdd.TabIndex = 3
        Me.btAdd.Text = ">"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'btRemove
        '
        Me.btRemove.Location = New System.Drawing.Point(164, 90)
        Me.btRemove.Name = "btRemove"
        Me.btRemove.Size = New System.Drawing.Size(48, 22)
        Me.btRemove.TabIndex = 4
        Me.btRemove.Text = "<"
        Me.btRemove.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "PIDs in new stream"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PIDs in source"
        '
        'Label_destcount
        '
        Me.Label_destcount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_destcount.Location = New System.Drawing.Point(329, 26)
        Me.Label_destcount.Name = "Label_destcount"
        Me.Label_destcount.Size = New System.Drawing.Size(41, 13)
        Me.Label_destcount.TabIndex = 8
        Me.Label_destcount.Text = "0000"
        Me.Label_destcount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_sourcecount
        '
        Me.Label_sourcecount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_sourcecount.Location = New System.Drawing.Point(117, 26)
        Me.Label_sourcecount.Name = "Label_sourcecount"
        Me.Label_sourcecount.Size = New System.Drawing.Size(41, 13)
        Me.Label_sourcecount.TabIndex = 1
        Me.Label_sourcecount.Text = "0000"
        Me.Label_sourcecount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DemuxGroup
        '
        Me.DemuxGroup.Controls.Add(Me.Label_sourcecount)
        Me.DemuxGroup.Controls.Add(Me.Label_destcount)
        Me.DemuxGroup.Controls.Add(Me.Label1)
        Me.DemuxGroup.Controls.Add(Me.lbPIDsource)
        Me.DemuxGroup.Controls.Add(Me.lbPIDdest)
        Me.DemuxGroup.Controls.Add(Me.Label2)
        Me.DemuxGroup.Controls.Add(Me.btRemove)
        Me.DemuxGroup.Controls.Add(Me.btAdd)
        Me.DemuxGroup.Controls.Add(Me.btAddAll)
        Me.DemuxGroup.Controls.Add(Me.btRemoveAll)
        Me.DemuxGroup.Location = New System.Drawing.Point(12, 68)
        Me.DemuxGroup.Name = "DemuxGroup"
        Me.DemuxGroup.Size = New System.Drawing.Size(380, 266)
        Me.DemuxGroup.TabIndex = 1
        Me.DemuxGroup.TabStop = False
        Me.DemuxGroup.Text = "De-multiplex"
        '
        'dlgDemux
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(766, 357)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OutputGroup)
        Me.Controls.Add(Me.TrimGroup)
        Me.Controls.Add(Me.DemuxGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDemux"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "De-multiplex stream"
        Me.TrimGroup.ResumeLayout(False)
        Me.TrimGroup.PerformLayout()
        Me.OutputGroup.ResumeLayout(False)
        Me.OutputGroup.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.DemuxGroup.ResumeLayout(False)
        Me.DemuxGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TrimGroup As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_trimend As System.Windows.Forms.TextBox
    Friend WithEvents txt_trimbegin As System.Windows.Forms.TextBox
    Friend WithEvents OutputGroup As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents radio_OutputTrim2 As System.Windows.Forms.RadioButton
    Friend WithEvents radio_outputtrim1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_trimoutput As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_188ByteOutput As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_stop As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents txt_Filepath As System.Windows.Forms.TextBox
    Friend WithEvents DemuxSaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btRemoveAll As System.Windows.Forms.Button
    Friend WithEvents btAddAll As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents btRemove As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbPIDdest As System.Windows.Forms.ListBox
    Friend WithEvents lbPIDsource As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label_destcount As System.Windows.Forms.Label
    Friend WithEvents Label_sourcecount As System.Windows.Forms.Label
    Friend WithEvents DemuxGroup As System.Windows.Forms.GroupBox
    Friend WithEvents cb_PES As System.Windows.Forms.CheckBox

End Class
