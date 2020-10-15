<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgProgress
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
        Me.pb1 = New System.Windows.Forms.ProgressBar
        Me.lblDescribe = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'pb1
        '
        Me.pb1.ForeColor = System.Drawing.Color.Green
        Me.pb1.Location = New System.Drawing.Point(12, 25)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(268, 23)
        Me.pb1.Step = 1
        Me.pb1.TabIndex = 0
        Me.pb1.Value = 50
        '
        'lblDescribe
        '
        Me.lblDescribe.AutoSize = True
        Me.lblDescribe.Location = New System.Drawing.Point(12, 9)
        Me.lblDescribe.Name = "lblDescribe"
        Me.lblDescribe.Size = New System.Drawing.Size(90, 13)
        Me.lblDescribe.TabIndex = 1
        Me.lblDescribe.Text = "Describe the task"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(205, 54)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dlgProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 85)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblDescribe)
        Me.Controls.Add(Me.pb1)
        Me.Name = "dlgProgress"
        Me.ShowInTaskbar = False
        Me.Text = "Progress"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblDescribe As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
