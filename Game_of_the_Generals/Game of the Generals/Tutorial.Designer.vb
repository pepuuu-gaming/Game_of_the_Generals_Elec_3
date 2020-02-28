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
        Me.ButtonProceed = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.back_to_menu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonProceed
        '
        Me.ButtonProceed.BackColor = System.Drawing.Color.White
        Me.ButtonProceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonProceed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonProceed.FlatAppearance.BorderSize = 0
        Me.ButtonProceed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ButtonProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonProceed.Font = New System.Drawing.Font("OCR A Extended", 30.0!)
        Me.ButtonProceed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonProceed.Location = New System.Drawing.Point(508, 401)
        Me.ButtonProceed.Name = "ButtonProceed"
        Me.ButtonProceed.Size = New System.Drawing.Size(232, 51)
        Me.ButtonProceed.TabIndex = 136
        Me.ButtonProceed.Text = "PROCEED"
        Me.ButtonProceed.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 50.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(272, 270)
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
        'Tutorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.back_to_menu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonProceed)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Tutorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game of the Generals"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonProceed As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents back_to_menu As Button
End Class
