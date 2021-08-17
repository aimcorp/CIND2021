<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistracion
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistracion))
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label38 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label48 = New System.Windows.Forms.Label()
		Me.ub1 = New System.Windows.Forms.Button()
		Me.DeactivateButton = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(12, 132)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(41, 13)
		Me.Label3.TabIndex = 588
		Me.Label3.Text = "NOTA"
		'
		'Label38
		'
		Me.Label38.BackColor = System.Drawing.Color.MediumSlateBlue
		Me.Label38.Location = New System.Drawing.Point(3, 37)
		Me.Label38.Name = "Label38"
		Me.Label38.Size = New System.Drawing.Size(546, 7)
		Me.Label38.TabIndex = 587
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.MediumVioletRed
		Me.Label2.Location = New System.Drawing.Point(12, 143)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(526, 136)
		Me.Label2.TabIndex = 586
		Me.Label2.Text = resources.GetString("Label2.Text")
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.MediumVioletRed
		Me.Label1.Location = New System.Drawing.Point(12, 56)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(526, 73)
		Me.Label1.TabIndex = 585
		Me.Label1.Text = resources.GetString("Label1.Text")
		'
		'Label48
		'
		Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label48.ForeColor = System.Drawing.Color.OliveDrab
		Me.Label48.Location = New System.Drawing.Point(11, 6)
		Me.Label48.Name = "Label48"
		Me.Label48.Size = New System.Drawing.Size(526, 28)
		Me.Label48.TabIndex = 584
		Me.Label48.Text = "Bienvenido al sistema de Registración de este Programa"
		Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ub1
		'
		Me.ub1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(84, Byte), Integer))
		Me.ub1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod
		Me.ub1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
		Me.ub1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
		Me.ub1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ub1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ub1.Location = New System.Drawing.Point(497, 297)
		Me.ub1.Name = "ub1"
		Me.ub1.Size = New System.Drawing.Size(50, 25)
		Me.ub1.TabIndex = 1819
		Me.ub1.TabStop = False
		Me.ub1.Text = "Salir"
		Me.ub1.UseVisualStyleBackColor = False
		'
		'DeactivateButton
		'
		Me.DeactivateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(149, Byte), Integer))
		Me.DeactivateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.DeactivateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.DeactivateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.DeactivateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
		Me.DeactivateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DeactivateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DeactivateButton.Location = New System.Drawing.Point(401, 298)
		Me.DeactivateButton.Name = "DeactivateButton"
		Me.DeactivateButton.Size = New System.Drawing.Size(89, 24)
		Me.DeactivateButton.TabIndex = 1818
		Me.DeactivateButton.TabStop = False
		Me.DeactivateButton.Text = "Activar Manual"
		Me.DeactivateButton.UseVisualStyleBackColor = False
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(149, Byte), Integer))
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(307, 298)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(87, 24)
		Me.Button1.TabIndex = 1818
		Me.Button1.TabStop = False
		Me.Button1.Text = "Activar Online"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'frmRegistracion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(218, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(552, 327)
		Me.Controls.Add(Me.ub1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.DeactivateButton)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label38)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label48)
		Me.Name = "frmRegistracion"
		Me.Text = "frmRegistracion"
		Me.ResumeLayout(False)
		Me.PerformLayout()

End Sub
				Friend WithEvents Label3 As System.Windows.Forms.Label
				Friend WithEvents Label38 As System.Windows.Forms.Label
				Friend WithEvents Label2 As System.Windows.Forms.Label
				Friend WithEvents Label1 As System.Windows.Forms.Label
				Friend WithEvents Label48 As System.Windows.Forms.Label
				Friend WithEvents ub1 As System.Windows.Forms.Button
				Friend WithEvents DeactivateButton As System.Windows.Forms.Button
				Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
