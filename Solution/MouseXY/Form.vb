Public Class Main

#Region " Vars "

    Public MoveForm As Boolean
    Public MoveForm_Mouse_Position As Point
    Public MoveForm_Temporal_Point As Point

#End Region

#Region "Label coordinates"

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        label_X_coordenates.Text = "X: " & MousePosition.X
        label_Y_coordenates.Text = "Y: " & MousePosition.Y
    End Sub

#End Region

#Region "STOP / EXIT buttons"

    Private Sub button_exit_Click(sender As Object, e As EventArgs) Handles button_exit.Click
        Me.Close()
    End Sub

    Private Sub button_stop_Click(sender As Object, e As EventArgs) Handles button_stop.Click
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
            Me.button_stop.BackgroundImage = Global.MouseXY.My.Resources.Resources.stop1
            label_stop.Text = "STOP"
            label_stop.Location = New Point(15, 142)
        Else
            Timer1.Enabled = False
            Me.button_stop.BackgroundImage = Global.MouseXY.My.Resources.Resources.stop2
            label_stop.Text = "RESUME"
            label_stop.Location = New Point(7.5, 142)
        End If
    End Sub

#End Region

#Region " NotifyIcon "

    Private Sub Button_minimize_Click(sender As Object, e As EventArgs) Handles Button_minimize.Click
        Me.Hide()
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(2000, "Mouse XY", "Click to restore window", ToolTipIcon.Info)
    End Sub

    Public Sub NotifyIcon1_Click(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.Click
        If Me.Visible = True Then
            Me.Hide()
            NotifyIcon1.Visible = True
        Else
            Me.Show()
            NotifyIcon1.Visible = False
        End If
    End Sub

#End Region

#Region " Move form "

    Public Sub MoveForm_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles _
        Me.MouseDown, _
        picturebox_girl.MouseDown, _
        picturebox_logo.MouseDown, _
        picturebox_X.MouseDown, _
        picturebox_Y.MouseDown, _
        label_copytoclipboard.MouseDown, _
        label_X_coordenates.MouseDown, _
        label_Y_coordenates.MouseDown, _
        label_exit.MouseDown, _
        label_stop.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = True
            MoveForm_Mouse_Position = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles _
        Me.MouseMove, _
        picturebox_girl.MouseMove, _
        picturebox_logo.MouseMove, _
        picturebox_X.MouseMove, _
        picturebox_Y.MouseMove, _
        label_copytoclipboard.MouseMove, _
        label_X_coordenates.MouseMove, _
        label_Y_coordenates.MouseMove, _
        label_exit.MouseMove, _
        label_stop.MouseMove

        If MoveForm Then
            MoveForm_Temporal_Point = Me.Location + e.Location - MoveForm_Mouse_Position
            Me.Location = MoveForm_Temporal_Point
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles _
        Me.MouseUp, _
        picturebox_girl.MouseUp, _
        picturebox_logo.MouseUp, _
        picturebox_X.MouseUp, _
        picturebox_Y.MouseUp, _
        label_copytoclipboard.MouseUp, _
        label_X_coordenates.MouseUp, _
        label_Y_coordenates.MouseUp, _
        label_exit.MouseUp, _
        label_stop.MouseUp

        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = False
        End If

    End Sub

#End Region

#Region " Set Window on top "

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button_ontop.Click
        If Me.TopMost = True Then
            Me.TopMost = False
            Me.Button_ontop.Image = Global.MouseXY.My.Resources.Resources.right_up
            Me.ToolTip1.SetToolTip(Button_ontop, "Set window on top")
        Else
            Me.Button_ontop.Image = Global.MouseXY.My.Resources.Resources.right_up_pressed
            Me.ToolTip1.SetToolTip(Button_ontop, "Set window on background")
            Me.TopMost = True
        End If
    End Sub

#End Region

#Region " Copy to clipboard "

    Sub Form1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(3) Then
            Clipboard.SetDataObject("X:" & MousePosition.X & "  " & "Y:" & MousePosition.Y)
            Me.ToolTip1.Hide(Label_Clipboard)
            Me.ToolTip1.Show("Copied to clipboard > X:" & MousePosition.X & " " & "Y:" & MousePosition.Y, Label_Clipboard, 2000)
        End If
    End Sub

#End Region

End Class