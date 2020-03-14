<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PopupNameInputBox
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.setHostName = New System.Windows.Forms.Button()
        Me.check = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("OCR A Extended", 20.0!)
        Me.TextBox1.Location = New System.Drawing.Point(107, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(267, 35)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "ENTER NAME"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'setHostName
        '
        Me.setHostName.Font = New System.Drawing.Font("OCR A Extended", 11.0!)
        Me.setHostName.Location = New System.Drawing.Point(246, 88)
        Me.setHostName.Name = "setHostName"
        Me.setHostName.Size = New System.Drawing.Size(64, 25)
        Me.setHostName.TabIndex = 1
        Me.setHostName.Text = "SET"
        Me.setHostName.UseVisualStyleBackColor = True
        '
        'check
        '
        Me.check.Font = New System.Drawing.Font("OCR A Extended", 11.0!)
        Me.check.Location = New System.Drawing.Point(176, 88)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(64, 25)
        Me.check.TabIndex = 2
        Me.check.Text = "CHECK"
        Me.check.UseVisualStyleBackColor = True
        '
        'PopupNameInputBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 161)
        Me.Controls.Add(Me.check)
        Me.Controls.Add(Me.setHostName)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "PopupNameInputBox"
        Me.Text = "PopupNameInputBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents setHostName As Button
    Friend WithEvents check As Button
End Class
