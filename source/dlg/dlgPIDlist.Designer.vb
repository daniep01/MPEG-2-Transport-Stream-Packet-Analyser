<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPIDlist
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
        Me.btnClose = New System.Windows.Forms.Button
        Me.listviewPID = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.lbPacketsAnalysed = New System.Windows.Forms.Label
        Me.lbPIDused = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClose.Location = New System.Drawing.Point(98, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(71, 22)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        '
        'listviewPID
        '
        Me.listviewPID.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.listviewPID.FullRowSelect = True
        Me.listviewPID.GridLines = True
        Me.listviewPID.LabelWrap = False
        Me.listviewPID.Location = New System.Drawing.Point(13, 12)
        Me.listviewPID.MultiSelect = False
        Me.listviewPID.Name = "listviewPID"
        Me.listviewPID.ShowGroups = False
        Me.listviewPID.Size = New System.Drawing.Size(381, 262)
        Me.listviewPID.TabIndex = 1
        Me.listviewPID.TabStop = False
        Me.listviewPID.UseCompatibleStateImageBehavior = False
        Me.listviewPID.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "PID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Count"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "%"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Description"
        Me.ColumnHeader4.Width = 164
        '
        'lbPacketsAnalysed
        '
        Me.lbPacketsAnalysed.AutoSize = True
        Me.lbPacketsAnalysed.Location = New System.Drawing.Point(13, 282)
        Me.lbPacketsAnalysed.Name = "lbPacketsAnalysed"
        Me.lbPacketsAnalysed.Size = New System.Drawing.Size(99, 13)
        Me.lbPacketsAnalysed.TabIndex = 2
        Me.lbPacketsAnalysed.Text = "0 packets analysed"
        '
        'lbPIDused
        '
        Me.lbPIDused.AutoSize = True
        Me.lbPIDused.Location = New System.Drawing.Point(13, 299)
        Me.lbPIDused.Name = "lbPIDused"
        Me.lbPIDused.Size = New System.Drawing.Size(70, 13)
        Me.lbPIDused.TabIndex = 2
        Me.lbPIDused.Text = "0 PIDs in use"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Location = New System.Drawing.Point(4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 22)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(215, 282)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(179, 30)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'dlgPIDlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(406, 323)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lbPIDused)
        Me.Controls.Add(Me.lbPacketsAnalysed)
        Me.Controls.Add(Me.listviewPID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPIDlist"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PID list"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents listviewPID As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbPacketsAnalysed As System.Windows.Forms.Label
    Friend WithEvents lbPIDused As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

End Class
