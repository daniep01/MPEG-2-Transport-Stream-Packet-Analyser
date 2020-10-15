<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSpacing
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
        Me.btn_start = New System.Windows.Forms.Button
        Me.txt_spacingpid = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_pktstop = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_pktbegin = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btn_close = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.btn_stop = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_pktfound = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_max = New System.Windows.Forms.TextBox
        Me.txt_min = New System.Windows.Forms.TextBox
        Me.txt_analysed = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_start
        '
        Me.btn_start.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_start.Location = New System.Drawing.Point(11, 3)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(80, 22)
        Me.btn_start.TabIndex = 2
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'txt_spacingpid
        '
        Me.txt_spacingpid.Location = New System.Drawing.Point(116, 26)
        Me.txt_spacingpid.Name = "txt_spacingpid"
        Me.txt_spacingpid.Size = New System.Drawing.Size(106, 20)
        Me.txt_spacingpid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gaps analysed"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Minimum gap"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Maximum gap"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_pktstop)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_pktbegin)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_spacingpid)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "stop at packet"
        '
        'txt_pktstop
        '
        Me.txt_pktstop.Location = New System.Drawing.Point(116, 77)
        Me.txt_pktstop.Name = "txt_pktstop"
        Me.txt_pktstop.Size = New System.Drawing.Size(106, 20)
        Me.txt_pktstop.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "begin at packet"
        '
        'txt_pktbegin
        '
        Me.txt_pktbegin.Location = New System.Drawing.Point(116, 51)
        Me.txt_pktbegin.Name = "txt_pktbegin"
        Me.txt_pktbegin.Size = New System.Drawing.Size(106, 20)
        Me.txt_pktbegin.TabIndex = 1
        Me.txt_pktbegin.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(225, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "(decimal)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "PID to analyse"
        '
        'btn_close
        '
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_close.Location = New System.Drawing.Point(215, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(80, 22)
        Me.btn_close.TabIndex = 4
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "A gap of zero indicates adjacent packets."
        '
        'btn_stop
        '
        Me.btn_stop.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_stop.Enabled = False
        Me.btn_stop.Location = New System.Drawing.Point(113, 3)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(80, 22)
        Me.btn_stop.TabIndex = 3
        Me.btn_stop.Text = "Stop"
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_pktfound)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_max)
        Me.GroupBox2.Controls.Add(Me.txt_min)
        Me.GroupBox2.Controls.Add(Me.txt_analysed)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 170)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Results"
        '
        'txt_pktfound
        '
        Me.txt_pktfound.BackColor = System.Drawing.SystemColors.Info
        Me.txt_pktfound.Enabled = False
        Me.txt_pktfound.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_pktfound.Location = New System.Drawing.Point(116, 25)
        Me.txt_pktfound.Name = "txt_pktfound"
        Me.txt_pktfound.Size = New System.Drawing.Size(106, 20)
        Me.txt_pktfound.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Packets found"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(230, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "packets"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(230, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "packets"
        '
        'txt_max
        '
        Me.txt_max.BackColor = System.Drawing.SystemColors.Info
        Me.txt_max.Enabled = False
        Me.txt_max.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_max.Location = New System.Drawing.Point(116, 102)
        Me.txt_max.Name = "txt_max"
        Me.txt_max.Size = New System.Drawing.Size(106, 20)
        Me.txt_max.TabIndex = 3
        '
        'txt_min
        '
        Me.txt_min.BackColor = System.Drawing.SystemColors.Info
        Me.txt_min.Enabled = False
        Me.txt_min.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_min.Location = New System.Drawing.Point(116, 76)
        Me.txt_min.Name = "txt_min"
        Me.txt_min.Size = New System.Drawing.Size(106, 20)
        Me.txt_min.TabIndex = 2
        '
        'txt_analysed
        '
        Me.txt_analysed.BackColor = System.Drawing.SystemColors.Info
        Me.txt_analysed.Enabled = False
        Me.txt_analysed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_analysed.Location = New System.Drawing.Point(116, 50)
        Me.txt_analysed.Name = "txt_analysed"
        Me.txt_analysed.Size = New System.Drawing.Size(106, 20)
        Me.txt_analysed.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_start, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_close, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_stop, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 314)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(307, 42)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'dlgSpacing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(331, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "dlgSpacing"
        Me.ShowInTaskbar = False
        Me.Text = "PID spacing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents txt_spacingpid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_stop As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_max As System.Windows.Forms.TextBox
    Friend WithEvents txt_min As System.Windows.Forms.TextBox
    Friend WithEvents txt_analysed As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_pktfound As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_pktstop As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_pktbegin As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
