<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class homepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homepage))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonPlay = New System.Windows.Forms.Button()
        Me.ButtonTutorials = New System.Windows.Forms.Button()
        Me.ButtonOptions = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(440, 98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(444, 207)
        Me.PictureBox1.TabIndex = 135
        Me.PictureBox1.TabStop = False
        '
        'ButtonPlay
        '
        Me.ButtonPlay.BackColor = System.Drawing.Color.White
        Me.ButtonPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonPlay.FlatAppearance.BorderSize = 0
        Me.ButtonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPlay.Font = New System.Drawing.Font("OCR A Extended", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPlay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonPlay.Location = New System.Drawing.Point(533, 446)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(232, 51)
        Me.ButtonPlay.TabIndex = 136
        Me.ButtonPlay.Text = "PLAY"
        Me.ButtonPlay.UseVisualStyleBackColor = False
        '
        'ButtonTutorials
        '
        Me.ButtonTutorials.BackColor = System.Drawing.Color.White
        Me.ButtonTutorials.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTutorials.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonTutorials.FlatAppearance.BorderSize = 0
        Me.ButtonTutorials.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ButtonTutorials.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTutorials.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTutorials.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonTutorials.Location = New System.Drawing.Point(533, 508)
        Me.ButtonTutorials.Name = "ButtonTutorials"
        Me.ButtonTutorials.Size = New System.Drawing.Size(232, 51)
        Me.ButtonTutorials.TabIndex = 137
        Me.ButtonTutorials.Text = "TUTORIALS"
        Me.ButtonTutorials.UseVisualStyleBackColor = False
        '
        'ButtonOptions
        '
        Me.ButtonOptions.BackColor = System.Drawing.Color.White
        Me.ButtonOptions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonOptions.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonOptions.FlatAppearance.BorderSize = 0
        Me.ButtonOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ButtonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOptions.Font = New System.Drawing.Font("OCR A Extended", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOptions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonOptions.Location = New System.Drawing.Point(533, 570)
        Me.ButtonOptions.Name = "ButtonOptions"
        Me.ButtonOptions.Size = New System.Drawing.Size(232, 51)
        Me.ButtonOptions.TabIndex = 138
        Me.ButtonOptions.Text = "OPTIONS"
        Me.ButtonOptions.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(338, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(663, 54)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "GAME OF THE GENERALS"
        '
        'homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonOptions)
        Me.Controls.Add(Me.ButtonTutorials)
        Me.Controls.Add(Me.ButtonPlay)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Name = "homepage"
        Me.Text = "Game of the Generals"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonPlay As Button
    Friend WithEvents ButtonTutorials As Button
    Friend WithEvents ButtonOptions As Button
End Class
