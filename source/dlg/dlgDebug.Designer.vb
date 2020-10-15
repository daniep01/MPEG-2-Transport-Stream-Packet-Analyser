<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDebug
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
        Me.txt_input = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txt_Result = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txt_input
        '
        Me.txt_input.Location = New System.Drawing.Point(13, 12)
        Me.txt_input.Name = "txt_input"
        Me.txt_input.Size = New System.Drawing.Size(106, 20)
        Me.txt_input.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "IsBitSet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_Result
        '
        Me.txt_Result.AcceptsReturn = True
        Me.txt_Result.AcceptsTab = True
        Me.txt_Result.Location = New System.Drawing.Point(126, 12)
        Me.txt_Result.Multiline = True
        Me.txt_Result.Name = "txt_Result"
        Me.txt_Result.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_Result.Size = New System.Drawing.Size(273, 334)
        Me.txt_Result.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 323)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 22)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(13, 294)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 22)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(13, 66)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 22)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "To Hex"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(13, 94)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 22)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "To Dec"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(13, 152)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 22)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "PID"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(13, 123)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 22)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Counter"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(13, 180)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 22)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "TS_byte(x) ?"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'dlgDebug
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(412, 358)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_Result)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_input)
        Me.Name = "dlgDebug"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_input As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_Result As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
