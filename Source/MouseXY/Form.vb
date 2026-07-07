Imports DevCase.Core.Application.Forms

Public Class Main

#Region " Fields "

    Private magnetizer As WindowMagnetizer

    Public MoveForm As Boolean
    Public MoveForm_Mouse_Position As Point
    Public MoveForm_Temporal_Point As Point

#End Region

#Region "Label coordinates"

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim pt As Point = Control.MousePosition
        Me.label_X_coordenates.Text = $"X: {pt.X}"
        Me.label_Y_coordenates.Text = $"Y: {pt.Y}"
    End Sub

#End Region

#Region "STOP / EXIT buttons"

    Private Sub Button_exit_Click(sender As Object, e As EventArgs) Handles button_exit.Click
        Me.Close()
    End Sub

    Private Sub Button_stop_Click(sender As Object, e As EventArgs) Handles button_stop.Click
        If Me.Timer1.Enabled = False Then
            Me.Timer1.Enabled = True
            Me.button_stop.BackgroundImage = Global.My.Resources.Resources.stop1
            Me.label_stop.Text = "PAUSE"
            Me.label_stop.Location = New Point(Me.label_stop.Location.X * 2, Me.label_stop.Location.Y)
        Else
            Me.Timer1.Enabled = False
            Me.button_stop.BackgroundImage = Global.My.Resources.Resources.stop2
            Me.label_stop.Text = "RESUME"
            Me.label_stop.Location = New Point(Me.label_stop.Location.X / 2, Me.label_stop.Location.Y)
        End If
    End Sub

#End Region

#Region " NotifyIcon "

    Private Sub Button_minimize_Click(sender As Object, e As EventArgs) Handles Button_minimize.Click
        Me.Hide()
        Me.NotifyIcon1.Visible = True
        Me.NotifyIcon1.ShowBalloonTip(1500, "MouXY", "Click to restore window", ToolTipIcon.None)
    End Sub

    Public Sub NotifyIcon1_Click(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.Click
        If Me.Visible = True Then
            Me.Hide()
            Me.NotifyIcon1.Visible = True
        Else
            Me.Show()
            Me.NotifyIcon1.Visible = False
        End If
    End Sub

#End Region

#Region " Move form "

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        Me.MouseDown,
        picturebox_girl.MouseDown,
        picturebox_logo.MouseDown,
        picturebox_X.MouseDown,
        picturebox_Y.MouseDown,
        label_copytoclipboard.MouseDown,
        label_X_coordenates.MouseDown,
        label_Y_coordenates.MouseDown,
        label_exit.MouseDown,
        label_stop.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.MoveForm = True
            Me.MoveForm_Mouse_Position = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
        Me.MouseMove,
        picturebox_girl.MouseMove,
        picturebox_logo.MouseMove,
        picturebox_X.MouseMove,
        picturebox_Y.MouseMove,
        label_copytoclipboard.MouseMove,
        label_X_coordenates.MouseMove,
        label_Y_coordenates.MouseMove,
        label_exit.MouseMove,
        label_stop.MouseMove

        If Me.MoveForm Then
            Me.MoveForm_Temporal_Point = Me.Location + e.Location - Me.MoveForm_Mouse_Position
            Me.Location = Me.MoveForm_Temporal_Point
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
        Me.MouseUp,
        picturebox_girl.MouseUp,
        picturebox_logo.MouseUp,
        picturebox_X.MouseUp,
        picturebox_Y.MouseUp,
        label_copytoclipboard.MouseUp,
        label_X_coordenates.MouseUp,
        label_Y_coordenates.MouseUp,
        label_exit.MouseUp,
        label_stop.MouseUp

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.MoveForm = False
        End If

    End Sub

#End Region

#Region " Set Window on top "

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button_ontop.Click
        If Me.TopMost = True Then
            Me.TopMost = False
            Me.Button_ontop.Image = Global.My.Resources.Resources.right_up
            Me.ToolTip1.SetToolTip(Me.Button_ontop, "Set window topmost")
        Else
            Me.Button_ontop.Image = Global.My.Resources.Resources.right_up_pressed
            Me.ToolTip1.SetToolTip(Me.Button_ontop, "Restore window topmost")
            Me.TopMost = True
        End If
    End Sub

#End Region

#Region " Copy to clipboard "

    Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(3) Then
            Dim pt As Point = Control.MousePosition
            Clipboard.SetDataObject(pt.ToString())
            Me.ToolTip1.Hide(Me.Label_Clipboard)
            Me.ToolTip1.Show($"Copied to clipboard: {pt}", Me.Label_Clipboard, 2000)
        End If
    End Sub

    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.magnetizer = New WindowMagnetizer(Me) With
        {
            .Enabled = True,
            .AllowOffscreen = False,
            .Threshold = 20
        }
    End Sub

#End Region

End Class