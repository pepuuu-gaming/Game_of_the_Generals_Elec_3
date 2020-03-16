<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tutorial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tutorial))
        Me.BtnBattlefield = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.back_to_menu = New System.Windows.Forms.Button()
        Me.BtnObjective = New System.Windows.Forms.Button()
        Me.BtnSoldiers = New System.Windows.Forms.Button()
        Me.BtnGameplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnBattlefield
        '
        Me.BtnBattlefield.BackColor = System.Drawing.Color.White
        Me.BtnBattlefield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnBattlefield.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BtnBattlefield.FlatAppearance.BorderSize = 0
        Me.BtnBattlefield.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BtnBattlefield.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBattlefield.Font = New System.Drawing.Font("OCR A Extended", 30.0!)
        Me.BtnBattlefield.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BtnBattlefield.Location = New System.Drawing.Point(480, 266)
        Me.BtnBattlefield.Name = "BtnBattlefield"
        Me.BtnBattlefield.Size = New System.Drawing.Size(309, 51)
        Me.BtnBattlefield.TabIndex = 136
        Me.BtnBattlefield.Text = "BATTLEFIELD"
        Me.BtnBattlefield.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 50.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(270, 138)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(750, 69)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SERIES OF TUTORIAL"
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
        Me.back_to_menu.TabIndex = 211
        Me.back_to_menu.UseVisualStyleBackColor = True
        '
        'BtnObjective
        '
        Me.BtnObjective.BackColor = System.Drawing.Color.White
        Me.BtnObjective.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnObjective.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BtnObjective.FlatAppearance.BorderSize = 0
        Me.BtnObjective.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BtnObjective.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnObjective.Font = New System.Drawing.Font("OCR A Extended", 30.0!)
        Me.BtnObjective.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BtnObjective.Location = New System.Drawing.Point(480, 349)
        Me.BtnObjective.Name = "BtnObjective"
        Me.BtnObjective.Size = New System.Drawing.Size(309, 51)
        Me.BtnObjective.TabIndex = 212
        Me.BtnObjective.Text = "OBJECTIVE "
        Me.BtnObjective.UseVisualStyleBackColor = False
        '
        'BtnSoldiers
        '
        Me.BtnSoldiers.BackColor = System.Drawing.Color.White
        Me.BtnSoldiers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSoldiers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BtnSoldiers.FlatAppearance.BorderSize = 0
        Me.BtnSoldiers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BtnSoldiers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSoldiers.Font = New System.Drawing.Font("OCR A Extended", 30.0!)
        Me.BtnSoldiers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BtnSoldiers.Location = New System.Drawing.Point(480, 425)
        Me.BtnSoldiers.Name = "BtnSoldiers"
        Me.BtnSoldiers.Size = New System.Drawing.Size(309, 51)
        Me.BtnSoldiers.TabIndex = 213
        Me.BtnSoldiers.Text = "SOLDIERS"
        Me.BtnSoldiers.UseVisualStyleBackColor = False
        '
        'BtnGameplay
        '
        Me.BtnGameplay.BackColor = System.Drawing.Color.White
        Me.BtnGameplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnGameplay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BtnGameplay.FlatAppearance.BorderSize = 0
        Me.BtnGameplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BtnGameplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGameplay.Font = New System.Drawing.Font("OCR A Extended", 30.0!)
        Me.BtnGameplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BtnGameplay.Location = New System.Drawing.Point(480, 495)
        Me.BtnGameplay.Name = "BtnGameplay"
        Me.BtnGameplay.Size = New System.Drawing.Size(309, 51)
        Me.BtnGameplay.TabIndex = 214
        Me.BtnGameplay.Text = "GAMEPLAY"
        Me.BtnGameplay.UseVisualStyleBackColor = False
        '
        'Tutorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.BtnGameplay)
        Me.Controls.Add(Me.BtnSoldiers)
        Me.Controls.Add(Me.BtnObjective)
        Me.Controls.Add(Me.back_to_menu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBattlefield)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Tutorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game of the Generals"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBattlefield As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents back_to_menu As Button
    Friend WithEvents BtnObjective As Button
    Friend WithEvents BtnSoldiers As Button
    Friend WithEvents BtnGameplay As Button
End Class
