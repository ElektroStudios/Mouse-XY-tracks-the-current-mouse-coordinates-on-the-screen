<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.label_X_coordenates = New System.Windows.Forms.Label()
        Me.label_Y_coordenates = New System.Windows.Forms.Label()
        Me.label_copytoclipboard = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button_minimize = New System.Windows.Forms.Button()
        Me.Button_ontop = New System.Windows.Forms.Button()
        Me.picturebox_logo = New System.Windows.Forms.PictureBox()
        Me.label_stop = New System.Windows.Forms.Label()
        Me.label_exit = New System.Windows.Forms.Label()
        Me.Label_Clipboard = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.button_stop = New System.Windows.Forms.Button()
        Me.picturebox_X = New System.Windows.Forms.PictureBox()
        Me.picturebox_Y = New System.Windows.Forms.PictureBox()
        Me.button_exit = New System.Windows.Forms.Button()
        Me.picturebox_girl = New System.Windows.Forms.PictureBox()
        CType(Me.picturebox_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picturebox_X, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picturebox_Y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picturebox_girl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 15
        '
        'label_X_coordenates
        '
        Me.label_X_coordenates.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.label_X_coordenates.AutoSize = True
        Me.label_X_coordenates.BackColor = System.Drawing.Color.Transparent
        Me.label_X_coordenates.Font = New System.Drawing.Font("Lucida Console", 20.0!)
        Me.label_X_coordenates.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.label_X_coordenates.Location = New System.Drawing.Point(9, 177)
        Me.label_X_coordenates.Margin = New System.Windows.Forms.Padding(0)
        Me.label_X_coordenates.Name = "label_X_coordenates"
        Me.label_X_coordenates.Size = New System.Drawing.Size(42, 33)
        Me.label_X_coordenates.TabIndex = 4
        Me.label_X_coordenates.Text = "X:"
        Me.label_X_coordenates.UseCompatibleTextRendering = True
        '
        'label_Y_coordenates
        '
        Me.label_Y_coordenates.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.label_Y_coordenates.AutoSize = True
        Me.label_Y_coordenates.BackColor = System.Drawing.Color.Transparent
        Me.label_Y_coordenates.Font = New System.Drawing.Font("Lucida Console", 20.0!)
        Me.label_Y_coordenates.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.label_Y_coordenates.Location = New System.Drawing.Point(9, 220)
        Me.label_Y_coordenates.Name = "label_Y_coordenates"
        Me.label_Y_coordenates.Size = New System.Drawing.Size(42, 33)
        Me.label_Y_coordenates.TabIndex = 5
        Me.label_Y_coordenates.Text = "Y:"
        Me.label_Y_coordenates.UseCompatibleTextRendering = True
        '
        'label_copytoclipboard
        '
        Me.label_copytoclipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.label_copytoclipboard.BackColor = System.Drawing.Color.Transparent
        Me.label_copytoclipboard.Cursor = System.Windows.Forms.Cursors.Help
        Me.label_copytoclipboard.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.label_copytoclipboard.Font = New System.Drawing.Font("Lucida Console", 11.0!)
        Me.label_copytoclipboard.ForeColor = System.Drawing.Color.LightGray
        Me.label_copytoclipboard.Location = New System.Drawing.Point(0, 256)
        Me.label_copytoclipboard.Name = "label_copytoclipboard"
        Me.label_copytoclipboard.Size = New System.Drawing.Size(324, 23)
        Me.label_copytoclipboard.TabIndex = 7
        Me.label_copytoclipboard.Text = " Ctrl+C (Copy XY to clipboard)"
        Me.label_copytoclipboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.label_copytoclipboard, "Use the 'Ctrl+C' hotkey to copy the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mouse coordinates into the clipboard.")
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Info"
        '
        'Button_minimize
        '
        Me.Button_minimize.BackColor = System.Drawing.Color.Black
        Me.Button_minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_minimize.ForeColor = System.Drawing.Color.Black
        Me.Button_minimize.Image = Global.MouseXY.My.Resources.Resources.left_down
        Me.Button_minimize.Location = New System.Drawing.Point(0, 255)
        Me.Button_minimize.Name = "Button_minimize"
        Me.Button_minimize.Size = New System.Drawing.Size(26, 21)
        Me.Button_minimize.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.Button_minimize, "Minimize to tray")
        Me.Button_minimize.UseVisualStyleBackColor = False
        '
        'Button_ontop
        '
        Me.Button_ontop.BackColor = System.Drawing.Color.Black
        Me.Button_ontop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_ontop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_ontop.ForeColor = System.Drawing.Color.Black
        Me.Button_ontop.Image = Global.MouseXY.My.Resources.Resources.right_up
        Me.Button_ontop.Location = New System.Drawing.Point(299, 255)
        Me.Button_ontop.Name = "Button_ontop"
        Me.Button_ontop.Size = New System.Drawing.Size(26, 21)
        Me.Button_ontop.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.Button_ontop, "Set window on top")
        Me.Button_ontop.UseVisualStyleBackColor = False
        '
        'picturebox_logo
        '
        Me.picturebox_logo.BackColor = System.Drawing.Color.Transparent
        Me.picturebox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picturebox_logo.Cursor = System.Windows.Forms.Cursors.Help
        Me.picturebox_logo.Image = Global.MouseXY.My.Resources.Resources.logo
        Me.picturebox_logo.Location = New System.Drawing.Point(9, -6)
        Me.picturebox_logo.Name = "picturebox_logo"
        Me.picturebox_logo.Size = New System.Drawing.Size(113, 107)
        Me.picturebox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picturebox_logo.TabIndex = 8
        Me.picturebox_logo.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picturebox_logo, "Mouse XY v1.2  (by Elektro H@cker)")
        '
        'label_stop
        '
        Me.label_stop.AutoSize = True
        Me.label_stop.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_stop.ForeColor = System.Drawing.Color.Silver
        Me.label_stop.Location = New System.Drawing.Point(15, 142)
        Me.label_stop.Name = "label_stop"
        Me.label_stop.Size = New System.Drawing.Size(43, 13)
        Me.label_stop.TabIndex = 15
        Me.label_stop.Text = "STOP"
        '
        'label_exit
        '
        Me.label_exit.AutoSize = True
        Me.label_exit.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_exit.ForeColor = System.Drawing.Color.Silver
        Me.label_exit.Location = New System.Drawing.Point(75, 142)
        Me.label_exit.Name = "label_exit"
        Me.label_exit.Size = New System.Drawing.Size(43, 13)
        Me.label_exit.TabIndex = 16
        Me.label_exit.Text = "EXIT"
        '
        'Label_Clipboard
        '
        Me.Label_Clipboard.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label_Clipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Clipboard.ForeColor = System.Drawing.Color.Transparent
        Me.Label_Clipboard.Location = New System.Drawing.Point(216, 43)
        Me.Label_Clipboard.Name = "Label_Clipboard"
        Me.Label_Clipboard.Size = New System.Drawing.Size(1, 1)
        Me.Label_Clipboard.TabIndex = 19
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Maximize window"
        Me.NotifyIcon1.BalloonTipTitle = "Mouse XY"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Mouse XY"
        '
        'button_stop
        '
        Me.button_stop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.button_stop.BackColor = System.Drawing.Color.Transparent
        Me.button_stop.BackgroundImage = Global.MouseXY.My.Resources.Resources.stop1
        Me.button_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button_stop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_stop.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_stop.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.button_stop.FlatAppearance.BorderSize = 0
        Me.button_stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_stop.ForeColor = System.Drawing.Color.Black
        Me.button_stop.Location = New System.Drawing.Point(10, 89)
        Me.button_stop.Name = "button_stop"
        Me.button_stop.Size = New System.Drawing.Size(54, 50)
        Me.button_stop.TabIndex = 12
        Me.button_stop.UseVisualStyleBackColor = False
        '
        'picturebox_X
        '
        Me.picturebox_X.BackColor = System.Drawing.Color.Transparent
        Me.picturebox_X.Image = Global.MouseXY.My.Resources.Resources.x2
        Me.picturebox_X.Location = New System.Drawing.Point(9, 168)
        Me.picturebox_X.Name = "picturebox_X"
        Me.picturebox_X.Size = New System.Drawing.Size(54, 37)
        Me.picturebox_X.TabIndex = 9
        Me.picturebox_X.TabStop = False
        '
        'picturebox_Y
        '
        Me.picturebox_Y.BackColor = System.Drawing.Color.Transparent
        Me.picturebox_Y.Image = Global.MouseXY.My.Resources.Resources.YY
        Me.picturebox_Y.Location = New System.Drawing.Point(9, 211)
        Me.picturebox_Y.Name = "picturebox_Y"
        Me.picturebox_Y.Size = New System.Drawing.Size(54, 40)
        Me.picturebox_Y.TabIndex = 10
        Me.picturebox_Y.TabStop = False
        '
        'button_exit
        '
        Me.button_exit.BackColor = System.Drawing.Color.Transparent
        Me.button_exit.BackgroundImage = Global.MouseXY.My.Resources.Resources._exit
        Me.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_exit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.button_exit.FlatAppearance.BorderSize = 0
        Me.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_exit.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Bold)
        Me.button_exit.ForeColor = System.Drawing.Color.Black
        Me.button_exit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button_exit.Location = New System.Drawing.Point(69, 89)
        Me.button_exit.Name = "button_exit"
        Me.button_exit.Size = New System.Drawing.Size(54, 50)
        Me.button_exit.TabIndex = 13
        Me.button_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button_exit.UseVisualStyleBackColor = False
        '
        'picturebox_girl
        '
        Me.picturebox_girl.BackColor = System.Drawing.Color.Transparent
        Me.picturebox_girl.Image = Global.MouseXY.My.Resources.Resources.dofus3
        Me.picturebox_girl.Location = New System.Drawing.Point(114, -58)
        Me.picturebox_girl.Name = "picturebox_girl"
        Me.picturebox_girl.Size = New System.Drawing.Size(232, 400)
        Me.picturebox_girl.TabIndex = 6
        Me.picturebox_girl.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.button_stop
        Me.ClientSize = New System.Drawing.Size(324, 279)
        Me.ControlBox = False
        Me.Controls.Add(Me.picturebox_X)
        Me.Controls.Add(Me.picturebox_Y)
        Me.Controls.Add(Me.Label_Clipboard)
        Me.Controls.Add(Me.Button_minimize)
        Me.Controls.Add(Me.Button_ontop)
        Me.Controls.Add(Me.button_stop)
        Me.Controls.Add(Me.label_exit)
        Me.Controls.Add(Me.label_stop)
        Me.Controls.Add(Me.button_exit)
        Me.Controls.Add(Me.picturebox_logo)
        Me.Controls.Add(Me.label_copytoclipboard)
        Me.Controls.Add(Me.label_Y_coordenates)
        Me.Controls.Add(Me.label_X_coordenates)
        Me.Controls.Add(Me.picturebox_girl)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mouse XY  (by Elektro H@cker)"
        CType(Me.picturebox_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picturebox_X, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picturebox_Y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picturebox_girl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents picturebox_girl As System.Windows.Forms.PictureBox
    Public WithEvents label_Y_coordenates As System.Windows.Forms.Label
    Public WithEvents label_X_coordenates As System.Windows.Forms.Label
    Friend WithEvents label_copytoclipboard As System.Windows.Forms.Label
    Friend WithEvents picturebox_logo As System.Windows.Forms.PictureBox
    Friend WithEvents picturebox_X As System.Windows.Forms.PictureBox
    Friend WithEvents picturebox_Y As System.Windows.Forms.PictureBox
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents button_exit As System.Windows.Forms.Button
    Friend WithEvents button_stop As System.Windows.Forms.Button
    Friend WithEvents label_stop As System.Windows.Forms.Label
    Friend WithEvents label_exit As System.Windows.Forms.Label
    Friend WithEvents Button_ontop As System.Windows.Forms.Button
    Friend WithEvents Button_minimize As System.Windows.Forms.Button
    Friend WithEvents Label_Clipboard As System.Windows.Forms.Label
    Public WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon

End Class
