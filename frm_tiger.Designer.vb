<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tiger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tiger))
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_load = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_newpet = New System.Windows.Forms.Button()
        Me.btn_sleep = New System.Windows.Forms.Button()
        Me.btn_love = New System.Windows.Forms.Button()
        Me.txt_health = New System.Windows.Forms.TextBox()
        Me.lbl_health = New System.Windows.Forms.Label()
        Me.txt_time = New System.Windows.Forms.TextBox()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.txt_energy = New System.Windows.Forms.TextBox()
        Me.txt_hunger = New System.Windows.Forms.TextBox()
        Me.txt_boredom = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_feed = New System.Windows.Forms.Button()
        Me.btn_play = New System.Windows.Forms.Button()
        Me.lbl_energy = New System.Windows.Forms.Label()
        Me.lbl_hunger = New System.Windows.Forms.Label()
        Me.lbl_boredom = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.pb_mouse = New System.Windows.Forms.PictureBox()
        Me.pb_m = New System.Windows.Forms.PictureBox()
        Me.rtxt_menu = New System.Windows.Forms.RichTextBox()
        CType(Me.pb_mouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_m, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_exit.Location = New System.Drawing.Point(52, 421)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(94, 32)
        Me.btn_exit.TabIndex = 123
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        Me.btn_exit.Visible = False
        '
        'btn_load
        '
        Me.btn_load.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_load.Location = New System.Drawing.Point(330, 361)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(95, 32)
        Me.btn_load.TabIndex = 121
        Me.btn_load.Text = "Load"
        Me.btn_load.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.BackgroundImage = CType(resources.GetObject("btn_save.BackgroundImage"), System.Drawing.Image)
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.Location = New System.Drawing.Point(644, 403)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(74, 50)
        Me.btn_save.TabIndex = 120
        Me.btn_save.UseVisualStyleBackColor = False
        Me.btn_save.Visible = False
        '
        'Timer1
        '
        '
        'btn_newpet
        '
        Me.btn_newpet.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_newpet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_newpet.Location = New System.Drawing.Point(52, 361)
        Me.btn_newpet.Name = "btn_newpet"
        Me.btn_newpet.Size = New System.Drawing.Size(94, 32)
        Me.btn_newpet.TabIndex = 118
        Me.btn_newpet.Text = "New Pet "
        Me.btn_newpet.UseVisualStyleBackColor = False
        Me.btn_newpet.Visible = False
        '
        'btn_sleep
        '
        Me.btn_sleep.BackColor = System.Drawing.Color.Transparent
        Me.btn_sleep.BackgroundImage = CType(resources.GetObject("btn_sleep.BackgroundImage"), System.Drawing.Image)
        Me.btn_sleep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sleep.Location = New System.Drawing.Point(644, 323)
        Me.btn_sleep.Name = "btn_sleep"
        Me.btn_sleep.Size = New System.Drawing.Size(74, 50)
        Me.btn_sleep.TabIndex = 117
        Me.btn_sleep.UseVisualStyleBackColor = False
        Me.btn_sleep.Visible = False
        '
        'btn_love
        '
        Me.btn_love.BackColor = System.Drawing.Color.Transparent
        Me.btn_love.BackgroundImage = CType(resources.GetObject("btn_love.BackgroundImage"), System.Drawing.Image)
        Me.btn_love.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_love.Location = New System.Drawing.Point(644, 247)
        Me.btn_love.Name = "btn_love"
        Me.btn_love.Size = New System.Drawing.Size(74, 47)
        Me.btn_love.TabIndex = 116
        Me.btn_love.UseVisualStyleBackColor = False
        Me.btn_love.Visible = False
        '
        'txt_health
        '
        Me.txt_health.Enabled = False
        Me.txt_health.ForeColor = System.Drawing.Color.Yellow
        Me.txt_health.Location = New System.Drawing.Point(317, 44)
        Me.txt_health.Name = "txt_health"
        Me.txt_health.ReadOnly = True
        Me.txt_health.Size = New System.Drawing.Size(56, 22)
        Me.txt_health.TabIndex = 115
        Me.txt_health.Visible = False
        '
        'lbl_health
        '
        Me.lbl_health.AutoSize = True
        Me.lbl_health.BackColor = System.Drawing.Color.DimGray
        Me.lbl_health.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_health.Location = New System.Drawing.Point(312, 9)
        Me.lbl_health.Name = "lbl_health"
        Me.lbl_health.Size = New System.Drawing.Size(80, 27)
        Me.lbl_health.TabIndex = 114
        Me.lbl_health.Text = "Health : "
        Me.lbl_health.Visible = False
        '
        'txt_time
        '
        Me.txt_time.Enabled = False
        Me.txt_time.ForeColor = System.Drawing.Color.Yellow
        Me.txt_time.Location = New System.Drawing.Point(696, 14)
        Me.txt_time.Name = "txt_time"
        Me.txt_time.ReadOnly = True
        Me.txt_time.Size = New System.Drawing.Size(56, 22)
        Me.txt_time.TabIndex = 113
        Me.txt_time.Visible = False
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.BackColor = System.Drawing.Color.DimGray
        Me.lbl_time.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(626, 9)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(64, 27)
        Me.lbl_time.TabIndex = 112
        Me.lbl_time.Text = "Time :"
        Me.lbl_time.Visible = False
        '
        'txt_energy
        '
        Me.txt_energy.Enabled = False
        Me.txt_energy.ForeColor = System.Drawing.Color.Yellow
        Me.txt_energy.Location = New System.Drawing.Point(431, 44)
        Me.txt_energy.Name = "txt_energy"
        Me.txt_energy.ReadOnly = True
        Me.txt_energy.Size = New System.Drawing.Size(54, 22)
        Me.txt_energy.TabIndex = 111
        Me.txt_energy.Visible = False
        '
        'txt_hunger
        '
        Me.txt_hunger.Enabled = False
        Me.txt_hunger.ForeColor = System.Drawing.Color.Yellow
        Me.txt_hunger.Location = New System.Drawing.Point(528, 44)
        Me.txt_hunger.Name = "txt_hunger"
        Me.txt_hunger.ReadOnly = True
        Me.txt_hunger.Size = New System.Drawing.Size(54, 22)
        Me.txt_hunger.TabIndex = 110
        Me.txt_hunger.Visible = False
        '
        'txt_boredom
        '
        Me.txt_boredom.Enabled = False
        Me.txt_boredom.ForeColor = System.Drawing.Color.Yellow
        Me.txt_boredom.Location = New System.Drawing.Point(188, 44)
        Me.txt_boredom.Name = "txt_boredom"
        Me.txt_boredom.ReadOnly = True
        Me.txt_boredom.Size = New System.Drawing.Size(54, 22)
        Me.txt_boredom.TabIndex = 109
        Me.txt_boredom.Visible = False
        '
        'txt_name
        '
        Me.txt_name.Enabled = False
        Me.txt_name.ForeColor = System.Drawing.Color.Yellow
        Me.txt_name.Location = New System.Drawing.Point(30, 44)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(103, 22)
        Me.txt_name.TabIndex = 108
        Me.txt_name.Visible = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_cancel.Location = New System.Drawing.Point(330, 421)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(95, 32)
        Me.btn_cancel.TabIndex = 107
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_start.Location = New System.Drawing.Point(330, 301)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(95, 32)
        Me.btn_start.TabIndex = 106
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = False
        '
        'btn_feed
        '
        Me.btn_feed.BackColor = System.Drawing.Color.Transparent
        Me.btn_feed.BackgroundImage = CType(resources.GetObject("btn_feed.BackgroundImage"), System.Drawing.Image)
        Me.btn_feed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_feed.Location = New System.Drawing.Point(644, 169)
        Me.btn_feed.Name = "btn_feed"
        Me.btn_feed.Size = New System.Drawing.Size(74, 47)
        Me.btn_feed.TabIndex = 105
        Me.btn_feed.Text = "Feed"
        Me.btn_feed.UseVisualStyleBackColor = False
        Me.btn_feed.Visible = False
        '
        'btn_play
        '
        Me.btn_play.BackColor = System.Drawing.Color.Transparent
        Me.btn_play.BackgroundImage = CType(resources.GetObject("btn_play.BackgroundImage"), System.Drawing.Image)
        Me.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_play.Location = New System.Drawing.Point(644, 96)
        Me.btn_play.Name = "btn_play"
        Me.btn_play.Size = New System.Drawing.Size(74, 50)
        Me.btn_play.TabIndex = 104
        Me.btn_play.UseVisualStyleBackColor = False
        Me.btn_play.Visible = False
        '
        'lbl_energy
        '
        Me.lbl_energy.AutoSize = True
        Me.lbl_energy.BackColor = System.Drawing.Color.DimGray
        Me.lbl_energy.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_energy.Location = New System.Drawing.Point(426, 9)
        Me.lbl_energy.Name = "lbl_energy"
        Me.lbl_energy.Size = New System.Drawing.Size(80, 27)
        Me.lbl_energy.TabIndex = 103
        Me.lbl_energy.Text = "Energy :"
        Me.lbl_energy.Visible = False
        '
        'lbl_hunger
        '
        Me.lbl_hunger.AutoSize = True
        Me.lbl_hunger.BackColor = System.Drawing.Color.DimGray
        Me.lbl_hunger.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hunger.Location = New System.Drawing.Point(523, 9)
        Me.lbl_hunger.Name = "lbl_hunger"
        Me.lbl_hunger.Size = New System.Drawing.Size(82, 27)
        Me.lbl_hunger.TabIndex = 102
        Me.lbl_hunger.Text = "Hunger :"
        Me.lbl_hunger.Visible = False
        '
        'lbl_boredom
        '
        Me.lbl_boredom.AutoSize = True
        Me.lbl_boredom.BackColor = System.Drawing.Color.DimGray
        Me.lbl_boredom.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_boredom.Location = New System.Drawing.Point(183, 9)
        Me.lbl_boredom.Name = "lbl_boredom"
        Me.lbl_boredom.Size = New System.Drawing.Size(97, 27)
        Me.lbl_boredom.TabIndex = 101
        Me.lbl_boredom.Text = "Boredom :"
        Me.lbl_boredom.Visible = False
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.DimGray
        Me.lbl_name.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(28, 9)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(105, 27)
        Me.lbl_name.TabIndex = 100
        Me.lbl_name.Text = "Pet Name :"
        Me.lbl_name.Visible = False
        '
        'pb_mouse
        '
        Me.pb_mouse.Image = CType(resources.GetObject("pb_mouse.Image"), System.Drawing.Image)
        Me.pb_mouse.Location = New System.Drawing.Point(290, 96)
        Me.pb_mouse.Name = "pb_mouse"
        Me.pb_mouse.Size = New System.Drawing.Size(182, 183)
        Me.pb_mouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_mouse.TabIndex = 99
        Me.pb_mouse.TabStop = False
        Me.pb_mouse.Visible = False
        '
        'pb_m
        '
        Me.pb_m.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_m.Image = CType(resources.GetObject("pb_m.Image"), System.Drawing.Image)
        Me.pb_m.Location = New System.Drawing.Point(290, 96)
        Me.pb_m.Name = "pb_m"
        Me.pb_m.Size = New System.Drawing.Size(182, 183)
        Me.pb_m.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_m.TabIndex = 119
        Me.pb_m.TabStop = False
        '
        'rtxt_menu
        '
        Me.rtxt_menu.BackColor = System.Drawing.Color.DimGray
        Me.rtxt_menu.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.rtxt_menu.Location = New System.Drawing.Point(-3, -3)
        Me.rtxt_menu.Name = "rtxt_menu"
        Me.rtxt_menu.Size = New System.Drawing.Size(807, 84)
        Me.rtxt_menu.TabIndex = 122
        Me.rtxt_menu.Text = ""
        Me.rtxt_menu.Visible = False
        '
        'frm_tiger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(783, 466)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_load)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_newpet)
        Me.Controls.Add(Me.btn_sleep)
        Me.Controls.Add(Me.btn_love)
        Me.Controls.Add(Me.txt_health)
        Me.Controls.Add(Me.lbl_health)
        Me.Controls.Add(Me.txt_time)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.txt_energy)
        Me.Controls.Add(Me.txt_hunger)
        Me.Controls.Add(Me.txt_boredom)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.btn_feed)
        Me.Controls.Add(Me.btn_play)
        Me.Controls.Add(Me.lbl_energy)
        Me.Controls.Add(Me.lbl_hunger)
        Me.Controls.Add(Me.lbl_boredom)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.pb_mouse)
        Me.Controls.Add(Me.pb_m)
        Me.Controls.Add(Me.rtxt_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_tiger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_tiger"
        CType(Me.pb_mouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_m, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_load As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_newpet As Button
    Friend WithEvents btn_sleep As Button
    Friend WithEvents btn_love As Button
    Friend WithEvents txt_health As TextBox
    Friend WithEvents lbl_health As Label
    Friend WithEvents txt_time As TextBox
    Friend WithEvents lbl_time As Label
    Friend WithEvents txt_energy As TextBox
    Friend WithEvents txt_hunger As TextBox
    Friend WithEvents txt_boredom As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_start As Button
    Friend WithEvents btn_feed As Button
    Friend WithEvents btn_play As Button
    Friend WithEvents lbl_energy As Label
    Friend WithEvents lbl_hunger As Label
    Friend WithEvents lbl_boredom As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents pb_mouse As PictureBox
    Friend WithEvents pb_m As PictureBox
    Friend WithEvents rtxt_menu As RichTextBox
End Class
