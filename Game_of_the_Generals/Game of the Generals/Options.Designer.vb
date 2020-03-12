<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Options
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.back_to_menu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnPlayerName = New System.Windows.Forms.Button()
        Me.BtnSounds = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BtnEnableMusic = New System.Windows.Forms.Button()
        Me.BtnDisableMusic = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'back_to_menu
        '
        Me.back_to_menu.BackgroundImage = CType(resources.GetObject("back_to_menu.BackgroundImage"), System.Drawing.Image)
        Me.back_to_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.back_to_menu.FlatAppearance.BorderSize = 0
        Me.back_to_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.back_to_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back_to_menu.Location = New System.Drawing.Point(40, 40)
        Me.back_to_menu.Name = "back_to_menu"
        Me.back_to_menu.Size = New System.Drawing.Size(63, 54)
        Me.back_to_menu.TabIndex = 212
        Me.back_to_menu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(400, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 54)
        Me.Label1.TabIndex = 213
        Me.Label1.Text = "Player Name"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(400, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 54)
        Me.Label2.TabIndex = 214
        Me.Label2.Text = "Sounds"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(400, 400)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 54)
        Me.Label3.TabIndex = 215
        Me.Label3.Text = "Music"
        '
        'BtnPlayerName
        '
        Me.BtnPlayerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.BtnPlayerName.BackgroundImage = CType(resources.GetObject("BtnPlayerName.BackgroundImage"), System.Drawing.Image)
        Me.BtnPlayerName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPlayerName.FlatAppearance.BorderSize = 0
        Me.BtnPlayerName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BtnPlayerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPlayerName.Location = New System.Drawing.Point(900, 200)
        Me.BtnPlayerName.Name = "BtnPlayerName"
        Me.BtnPlayerName.Size = New System.Drawing.Size(63, 54)
        Me.BtnPlayerName.TabIndex = 217
        Me.BtnPlayerName.UseVisualStyleBackColor = False
        '
        'BtnSounds
        '
        Me.BtnSounds.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.BtnSounds.BackgroundImage = CType(resources.GetObject("BtnSounds.BackgroundImage"), System.Drawing.Image)
        Me.BtnSounds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSounds.FlatAppearance.BorderSize = 0
        Me.BtnSounds.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BtnSounds.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSounds.Location = New System.Drawing.Point(900, 310)
        Me.BtnSounds.Name = "BtnSounds"
        Me.BtnSounds.Size = New System.Drawing.Size(63, 54)
        Me.BtnSounds.TabIndex = 218
        Me.BtnSounds.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(321, 200)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 220
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(321, 400)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 221
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(321, 310)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(46, 54)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 222
        Me.PictureBox3.TabStop = False
        '
        'BtnEnableMusic
        '
        Me.BtnEnableMusic.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.BtnEnableMusic.BackgroundImage = CType(resources.GetObject("BtnEnableMusic.BackgroundImage"), System.Drawing.Image)
        Me.BtnEnableMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEnableMusic.FlatAppearance.BorderSize = 0
        Me.BtnEnableMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BtnEnableMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnableMusic.Location = New System.Drawing.Point(900, 400)
        Me.BtnEnableMusic.Name = "BtnEnableMusic"
        Me.BtnEnableMusic.Size = New System.Drawing.Size(63, 54)
        Me.BtnEnableMusic.TabIndex = 223
        Me.BtnEnableMusic.UseVisualStyleBackColor = False
        '
        'BtnDisableMusic
        '
        Me.BtnDisableMusic.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.BtnDisableMusic.BackgroundImage = CType(resources.GetObject("BtnDisableMusic.BackgroundImage"), System.Drawing.Image)
        Me.BtnDisableMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnDisableMusic.FlatAppearance.BorderSize = 0
        Me.BtnDisableMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BtnDisableMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDisableMusic.Location = New System.Drawing.Point(900, 400)
        Me.BtnDisableMusic.Name = "BtnDisableMusic"
        Me.BtnDisableMusic.Size = New System.Drawing.Size(63, 54)
        Me.BtnDisableMusic.TabIndex = 224
        Me.BtnDisableMusic.UseVisualStyleBackColor = False
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.BtnDisableMusic)
        Me.Controls.Add(Me.BtnEnableMusic)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnSounds)
        Me.Controls.Add(Me.BtnPlayerName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.back_to_menu)
        Me.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents back_to_menu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnPlayerName As Button
    Friend WithEvents BtnSounds As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnEnableMusic As Button
    Friend WithEvents BtnDisableMusic As Button
End Class
