<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TutorialPage1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TutorialPage1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnTutorialNext = New System.Windows.Forms.Button()
        Me.back_to_menu = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 50.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(420, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(470, 69)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "HOW TO PLAY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 30.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(116, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(419, 43)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "The Battlefield:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 25.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(160, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(750, 35)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "• Consists of 8 rows and 9 Columns."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("OCR A Extended", 25.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(160, 361)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(813, 70)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "• Arrange your 21 pieces in the first " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  3 rows (In any order)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("OCR A Extended", 25.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(160, 480)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(792, 70)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "• There should be 6 random spaces in " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  your formation."
        '
        'BtnTutorialNext
        '
        Me.BtnTutorialNext.BackColor = System.Drawing.Color.White
        Me.BtnTutorialNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BtnTutorialNext.FlatAppearance.BorderSize = 0
        Me.BtnTutorialNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BtnTutorialNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTutorialNext.Font = New System.Drawing.Font("OCR A Extended", 30.0!)
        Me.BtnTutorialNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BtnTutorialNext.Location = New System.Drawing.Point(1000, 600)
        Me.BtnTutorialNext.Name = "BtnTutorialNext"
        Me.BtnTutorialNext.Size = New System.Drawing.Size(232, 51)
        Me.BtnTutorialNext.TabIndex = 6
        Me.BtnTutorialNext.Text = "NEXT"
        Me.BtnTutorialNext.UseVisualStyleBackColor = False
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
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(166, 263)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 213
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(166, 480)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 214
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(166, 361)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 215
        Me.PictureBox3.TabStop = False
        '
        'TutorialPage1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.back_to_menu)
        Me.Controls.Add(Me.BtnTutorialNext)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Name = "TutorialPage1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game of the Generals"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnTutorialNext As Button
    Friend WithEvents back_to_menu As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
