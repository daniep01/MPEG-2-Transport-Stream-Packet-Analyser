<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTablePIDs
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.listPID = New System.Windows.Forms.ListBox()
        Me.textNewPID = New System.Windows.Forms.TextBox()
        Me.buttonAdd = New System.Windows.Forms.Button()
        Me.buttonRemove = New System.Windows.Forms.Button()
        Me.buttonClearAll = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Specify PIDs which contain table sections"
        '
        'buttonClose
        '
        Me.buttonClose.Location = New System.Drawing.Point(3, 181)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(80, 22)
        Me.buttonClose.TabIndex = 6
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        '
        'listPID
        '
        Me.listPID.FormattingEnabled = True
        Me.listPID.Location = New System.Drawing.Point(103, 67)
        Me.listPID.Name = "listPID"
        Me.TableLayoutPanel1.SetRowSpan(Me.listPID, 4)
        Me.listPID.Size = New System.Drawing.Size(106, 147)
        Me.listPID.TabIndex = 1
        '
        'textNewPID
        '
        Me.textNewPID.Location = New System.Drawing.Point(103, 29)
        Me.textNewPID.Name = "textNewPID"
        Me.textNewPID.Size = New System.Drawing.Size(106, 20)
        Me.textNewPID.TabIndex = 0
        '
        'buttonAdd
        '
        Me.buttonAdd.Location = New System.Drawing.Point(3, 29)
        Me.buttonAdd.Name = "buttonAdd"
        Me.buttonAdd.Size = New System.Drawing.Size(80, 22)
        Me.buttonAdd.TabIndex = 2
        Me.buttonAdd.Text = "Add"
        Me.buttonAdd.UseVisualStyleBackColor = True
        '
        'buttonRemove
        '
        Me.buttonRemove.Location = New System.Drawing.Point(3, 67)
        Me.buttonRemove.Name = "buttonRemove"
        Me.buttonRemove.Size = New System.Drawing.Size(80, 22)
        Me.buttonRemove.TabIndex = 3
        Me.buttonRemove.Text = "Remove"
        Me.buttonRemove.UseVisualStyleBackColor = True
        '
        'buttonClearAll
        '
        Me.buttonClearAll.Location = New System.Drawing.Point(3, 105)
        Me.buttonClearAll.Name = "buttonClearAll"
        Me.buttonClearAll.Size = New System.Drawing.Size(80, 22)
        Me.buttonClearAll.TabIndex = 4
        Me.buttonClearAll.Text = "Clear all"
        Me.buttonClearAll.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.buttonRemove, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.buttonClearAll, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.listPID, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.textNewPID, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.buttonAdd, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.buttonClose, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 18)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.085008!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.97859!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.97859!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.97859!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.97859!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.97859!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(252, 219)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Default"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dlgTablePIDs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(275, 254)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "dlgTablePIDs"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Table section PIDs"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents listPID As System.Windows.Forms.ListBox
    Friend WithEvents textNewPID As System.Windows.Forms.TextBox
    Friend WithEvents buttonAdd As System.Windows.Forms.Button
    Friend WithEvents buttonRemove As System.Windows.Forms.Button
    Friend WithEvents buttonClearAll As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
