<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCheck
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Stop_Button = New System.Windows.Forms.Button
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tb_check_results = New System.Windows.Forms.TextBox
        Me.cbPIDfilter = New System.Windows.Forms.CheckBox
        Me.tb_filter_pid = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cb_stop_sbe = New System.Windows.Forms.CheckBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Stop_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(138, 319)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(273, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Stop_Button
        '
        Me.Stop_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Stop_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Stop_Button.Location = New System.Drawing.Point(99, 3)
        Me.Stop_Button.Name = "Stop_Button"
        Me.Stop_Button.Size = New System.Drawing.Size(71, 22)
        Me.Stop_Button.TabIndex = 2
        Me.Stop_Button.Text = "Stop"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(9, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(71, 22)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Start"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(191, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(71, 22)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_check_results)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 230)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Results"
        '
        'tb_check_results
        '
        Me.tb_check_results.Location = New System.Drawing.Point(6, 18)
        Me.tb_check_results.Multiline = True
        Me.tb_check_results.Name = "tb_check_results"
        Me.tb_check_results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_check_results.Size = New System.Drawing.Size(385, 206)
        Me.tb_check_results.TabIndex = 0
        '
        'cbPIDfilter
        '
        Me.cbPIDfilter.AutoSize = True
        Me.cbPIDfilter.Location = New System.Drawing.Point(30, 21)
        Me.cbPIDfilter.Name = "cbPIDfilter"
        Me.cbPIDfilter.Size = New System.Drawing.Size(66, 17)
        Me.cbPIDfilter.TabIndex = 4
        Me.cbPIDfilter.Text = "PID filter"
        Me.cbPIDfilter.UseVisualStyleBackColor = True
        '
        'tb_filter_pid
        '
        Me.tb_filter_pid.Enabled = False
        Me.tb_filter_pid.Location = New System.Drawing.Point(109, 19)
        Me.tb_filter_pid.Name = "tb_filter_pid"
        Me.tb_filter_pid.Size = New System.Drawing.Size(56, 20)
        Me.tb_filter_pid.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_stop_sbe)
        Me.GroupBox2.Controls.Add(Me.tb_filter_pid)
        Me.GroupBox2.Controls.Add(Me.cbPIDfilter)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 65)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'cb_stop_sbe
        '
        Me.cb_stop_sbe.AutoSize = True
        Me.cb_stop_sbe.Location = New System.Drawing.Point(30, 42)
        Me.cb_stop_sbe.Name = "cb_stop_sbe"
        Me.cb_stop_sbe.Size = New System.Drawing.Size(135, 17)
        Me.cb_stop_sbe.TabIndex = 5
        Me.cb_stop_sbe.Text = "Stop on sync byte error"
        Me.cb_stop_sbe.UseVisualStyleBackColor = True
        '
        'dlgCheck
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(423, 359)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCheck"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TS continuity check"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_check_results As System.Windows.Forms.TextBox
    Friend WithEvents tb_filter_pid As System.Windows.Forms.TextBox
    Friend WithEvents cbPIDfilter As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Stop_Button As System.Windows.Forms.Button
    Friend WithEvents cb_stop_sbe As System.Windows.Forms.CheckBox

End Class
