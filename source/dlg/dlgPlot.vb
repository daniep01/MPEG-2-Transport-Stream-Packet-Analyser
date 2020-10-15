Imports System.Math

Public Class dlgPlot

    Dim colour_empty As Color = Color.FromArgb(&HFF, 150, 150, 150)

    'Public Declare Function ColorHLSToRGB Lib "shlwapi.dll" (ByVal wHue As Long, ByVal wLuminance As Long, ByVal wSaturation As Long) As Long

    Public Structure draw_packet_structure
        Dim pid As UInteger
        Dim payload_start As Boolean
        Dim colour As Color
    End Structure

    Dim draw_packet(100) As draw_packet_structure
    'Dim testpid As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        If txtFirst.Text = 1 Then Exit Sub
        txtFirst.Text = 1
        txtLast.Text = 100
        'testpid = -1
        draw_packets(txtFirst.Text)
    End Sub

    Private Sub draw_packets(ByVal first_pkt As UInteger)

        For j As Short = 1 To 100

            If (j + first_pkt - 1) > max_packets Then
                draw_packet(j).pid = Nothing
                draw_packet(j).colour = colour_empty
            Else
                draw_packet(j).pid = get_pid(first_pkt + j - 1)
                draw_packet(j).colour = get_colour(draw_packet(j).pid)

            End If
            draw_line(j)
        Next

        ' read the current packet again to sort out progress bar in main window
        decode_ts_packet(True, True, current_packet)
    End Sub

    Function get_pid(ByVal ts_packet As UInteger) As Short
        ' Debug.Print("get_pid: " & packet)

        'testpid = testpid + 1
        'If testpid = 8192 Then testpid = 0
        'Return testpid
        '
        Dim current_pid As Short

        read_ts_pkt(ts_packet, 4)

        If ts_bytes(0) <> &H47 Then
            MsgBox("Sync byte not found, packet: " & ts_packet & ". Partial PID plot will be displayed.", MsgBoxStyle.Exclamation, Application.ProductName)
            ts_packet = 1
            move_first()
            Return 0
        End If

        current_pid = (ts_bytes(1) And 31) << 8 Or ts_bytes(2)
        Return current_pid
        'Int((8191 - 0 + 1) * Rnd()) + 1

    End Function

    Function get_colour(ByVal pid) As Color

        Select Case pid
            Case 0 : Return Color.White
            Case 1 : Return Color.Red
            Case 16 : Return Color.Yellow
            Case 17 : Return Color.Lime
            Case 18 : Return Color.Cyan
            Case 20 : Return Color.Fuchsia
            Case 8191 : Return Color.Black
            Case Else
                Dim r, g, b As Short
                If (pid Mod 2) = 0 Then r = 192 Else r = 32
                Return Color.FromArgb(&HFF, r, Abs(Sin(pid) * 220), Abs(Cos(pid) * 220))
        End Select

    End Function

    Private Sub draw_line(ByVal position As Short) ', ByVal linecolour As Color)
        'Debug.Print("draw_line, " & position) ' & ":" & linecolour.ToString)
        Dim graphic As Graphics = panel1.CreateGraphics()
        Dim pidPen As New Pen(draw_packet(position).colour)
        pidPen.Width = 4

        position = (position * pidPen.Width) - 2
        graphic.DrawLine(pidPen, position, 0, position, panel1.Height)

    End Sub

    Private Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft.Click
        If txtFirst.Text = 1 Then Exit Sub
        txtFirst.Text = txtFirst.Text - 100
        txtLast.Text = txtLast.Text - 100
        draw_packets(txtFirst.Text)
    End Sub

    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click
        If txtLast.Text >= max_packets Then Exit Sub
        txtFirst.Text = txtFirst.Text + 100
        txtLast.Text = txtLast.Text + 100
        draw_packets(txtFirst.Text)
    End Sub

    Private Sub panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel1.MouseMove
        'Debug.Print(e.Location.ToString)
        ' work out which packet
        Dim hover_packet = (Int(e.X / 4)) + 1
        Dim stream_packet = hover_packet + txtFirst.Text - 1

        If stream_packet > max_packets Then
            Label1.Text = "no packet"
            Label2.Text = "no packet"
            Label3.Text = "none"
            Label4.BackColor = colour_empty
        Else
            Label1.Text = stream_packet
            Label2.Text = hover_packet
            Label3.Text = draw_packet(hover_packet).pid & " " & decode_pid_value(draw_packet(hover_packet).pid)
            Label8.Text = "Colour: " & draw_packet(hover_packet).colour.ToString
            'Label24.Text = draw_packet(hover_packet).payload_start
            Label4.BackColor = draw_packet(hover_packet).colour
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        draw_packets(txtFirst.Text)
    End Sub

    Private Sub panel1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panel1.MouseLeave
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        'Label24.Visible = False
        Label4.BackColor = colour_empty
    End Sub

    Private Sub panel1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panel1.MouseEnter
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        'Label24.Visible = True
        'Label4.Visible = True
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panel1.Paint
        draw_packets(txtFirst.Text)
    End Sub
End Class