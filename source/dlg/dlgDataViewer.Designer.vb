<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgViewer
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
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.ButtonCopy = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(62, 110)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 1
        Me.ButtonClose.Text = "&Hide"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonCopy
        '
        Me.ButtonCopy.Location = New System.Drawing.Point(62, 139)
        Me.ButtonCopy.Name = "ButtonCopy"
        Me.ButtonCopy.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCopy.TabIndex = 2
        Me.ButtonCopy.Text = "&Copy"
        Me.ButtonCopy.UseVisualStyleBackColor = True
        '
        'dlgViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 442)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonCopy)
        Me.Controls.Add(Me.ButtonClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(200, 150)
        Me.Name = "dlgViewer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Data viewer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonCopy As System.Windows.Forms.Button
End Class
