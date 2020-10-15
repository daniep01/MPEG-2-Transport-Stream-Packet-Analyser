<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgGoto
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
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rb_end = New System.Windows.Forms.RadioButton
        Me.rb_current = New System.Windows.Forms.RadioButton
        Me.rb_start = New System.Windows.Forms.RadioButton
        Me.tbPacket = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(138, 150)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(172, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.OK_Button.Location = New System.Drawing.Point(7, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(71, 22)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(93, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(71, 22)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_end)
        Me.GroupBox1.Controls.Add(Me.rb_current)
        Me.GroupBox1.Controls.Add(Me.rb_start)
        Me.GroupBox1.Controls.Add(Me.tbPacket)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 132)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Goto packet"
        '
        'rb_end
        '
        Me.rb_end.AutoSize = True
        Me.rb_end.Location = New System.Drawing.Point(141, 74)
        Me.rb_end.Name = "rb_end"
        Me.rb_end.Size = New System.Drawing.Size(94, 17)
        Me.rb_end.TabIndex = 5
        Me.rb_end.Text = "from &end of file"
        Me.rb_end.UseVisualStyleBackColor = True
        '
        'rb_current
        '
        Me.rb_current.AutoSize = True
        Me.rb_current.Location = New System.Drawing.Point(141, 97)
        Me.rb_current.Name = "rb_current"
        Me.rb_current.Size = New System.Drawing.Size(117, 17)
        Me.rb_current.TabIndex = 4
        Me.rb_current.Text = "from &current packet"
        Me.rb_current.UseVisualStyleBackColor = True
        '
        'rb_start
        '
        Me.rb_start.AutoSize = True
        Me.rb_start.Checked = True
        Me.rb_start.Location = New System.Drawing.Point(141, 51)
        Me.rb_start.Name = "rb_start"
        Me.rb_start.Size = New System.Drawing.Size(96, 17)
        Me.rb_start.TabIndex = 3
        Me.rb_start.TabStop = True
        Me.rb_start.Text = "from &start of file"
        Me.rb_start.UseVisualStyleBackColor = True
        '
        'tbPacket
        '
        Me.tbPacket.Location = New System.Drawing.Point(141, 26)
        Me.tbPacket.Name = "tbPacket"
        Me.tbPacket.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.tbPacket.Size = New System.Drawing.Size(106, 20)
        Me.tbPacket.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number of packets"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dlgGoto
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(322, 190)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgGoto"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Goto packet"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbPacket As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rb_current As System.Windows.Forms.RadioButton
    Friend WithEvents rb_start As System.Windows.Forms.RadioButton
    Friend WithEvents rb_end As System.Windows.Forms.RadioButton

End Class
