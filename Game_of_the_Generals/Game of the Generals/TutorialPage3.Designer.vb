﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TutorialPage3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TutorialPage3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.back_to_menu = New System.Windows.Forms.Button()
        Me.BtnTutorialNext = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "BASIC TUTORIAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 30.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(116, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(369, 43)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "THE SOLDIERS :"
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
        Me.back_to_menu.TabIndex = 214
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
        Me.BtnTutorialNext.TabIndex = 215
        Me.BtnTutorialNext.Text = "NEXT"
        Me.BtnTutorialNext.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 20.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(160, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(797, 87)
        Me.Label3.TabIndex = 216
        Me.Label3.Text = "• Flag(1): The most important piece of the game. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  The Flag can be eliminated b" &
    "y any piece " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  including the enemy Flag."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("OCR A Extended", 20.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(160, 382)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(781, 87)
        Me.Label4.TabIndex = 217
        Me.Label4.Text = "• A Flag eliminates opposing Flag when it takes " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  aggressive action by moving i" &
    "nto same square " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  occupied by the other Flag."
        '
        'TutorialPage3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnTutorialNext)
        Me.Controls.Add(Me.back_to_menu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TutorialPage3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game of the Generals"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents back_to_menu As Button
    Friend WithEvents BtnTutorialNext As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
