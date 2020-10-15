Public Class dlgViewer

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCopy.Click
        '   Me.txt.SelectAll()
        '   Me.txt.Copy()
    End Sub



    Private Sub dlgDetails_ResizeEnd_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd, MyBase.Load
        Debug.Print("size changed to : " & Me.Width & ":" & Me.Height)
        ' Me.txt.Width = Me.Width - 22 - 12
        '   Me.txt.Height = Me.Height - 60 - 12

        Dim new_loc As Point

        new_loc.X = Me.Width - 75 - 22
        new_loc.Y = Me.Height - 23 - 31
        Me.ButtonClose.Location = new_loc

        new_loc.X = 12
        Me.ButtonCopy.Location = new_loc

    End Sub

    Private Sub dlgDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click

    End Sub

    Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub dock_now()
        Dim new_loc As Point
        new_loc = dlgMain.Location
        new_loc.X += dlgMain.Width
        Me.Location = new_loc
    End Sub
End Class