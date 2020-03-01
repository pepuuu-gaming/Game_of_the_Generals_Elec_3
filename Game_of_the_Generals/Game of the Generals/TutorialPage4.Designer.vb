<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TutorialPage4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TutorialPage4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.back_to_menu = New System.Windows.Forms.Button()
        Me.BtnTutorialNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 50.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(368, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(590, 69)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "BASIC TUTORIAL"
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
        Me.back_to_menu.TabIndex = 215
        Me.back_to_menu.UseVisualStyleBackColor = True
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
        Me.BtnTutorialNext.TabIndex = 216
        Me.BtnTutorialNext.Text = "NEXT"
        Me.BtnTutorialNext.UseVisualStyleBackColor = False
        '
        'TutorialPage4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.BtnTutorialNext)
        Me.Controls.Add(Me.back_to_menu)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TutorialPage4"
        Me.Text = "Game of the Generals"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents back_to_menu As Button
    Friend WithEvents BtnTutorialNext As Button
End Class
