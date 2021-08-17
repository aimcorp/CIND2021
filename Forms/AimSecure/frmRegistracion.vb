Imports System.Text
Imports com.softwarekey.Client.Licensing

Namespace ClientLicense
'<summary>Main form</summary>
Partial Public Class frmRegistracion
				Inherits Form

#Region "Public Constructors"	'<summary>Default main form constructor</summary>
Public Sub New()
				InitializeComponent()
				m_license = New ClientLicense(m_licenseFilePath)
End Sub
#End Region

#Region "Button Click Event Handler"

Private Sub ub1_Click(sender As System.Object, e As System.EventArgs) Handles ub1.Click
Me.Close()
End Sub

'<summary>Activate Online button click event handler</summary>
Private Sub ub2_Click(sender As System.Object, e As System.EventArgs) Handles ub2.Click
Dim activationDialog As New frmActivateOnline(Me, m_license)
activationDialog.ShowDialog()
If Demo = "No" Then Close()
End Sub

'<summary>Activate Manually button click event handler</summary>
Private Sub ub3_Click(sender As System.Object, e As System.EventArgs) Handles ub3.Click
Dim activationDialog As New frmActivarManual(Me, m_license)
activationDialog.ShowDialog()
If Demo = "No" Then Close()
End Sub

Friend WithEvents Label3 As System.Windows.Forms.Label
Friend WithEvents Label38 As System.Windows.Forms.Label
Friend WithEvents Label2 As System.Windows.Forms.Label
Friend WithEvents Label1 As System.Windows.Forms.Label
Friend WithEvents Label48 As System.Windows.Forms.Label
Friend WithEvents ub1 As System.Windows.Forms.Button
Friend WithEvents ub3 As System.Windows.Forms.Button
Friend WithEvents ub2 As System.Windows.Forms.Button

#End Region

Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistracion))
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label38 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label48 = New System.Windows.Forms.Label()
		Me.ub1 = New System.Windows.Forms.Button()
		Me.ub3 = New System.Windows.Forms.Button()
		Me.ub2 = New System.Windows.Forms.Button()
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
			'ub3
			'
			Me.ub3.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(149, Byte), Integer))
			Me.ub3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.ub3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
			Me.ub3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
			Me.ub3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
			Me.ub3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.ub3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.ub3.Location = New System.Drawing.Point(401, 298)
			Me.ub3.Name = "ub3"
			Me.ub3.Size = New System.Drawing.Size(89, 24)
			Me.ub3.TabIndex = 1818
			Me.ub3.TabStop = False
			Me.ub3.Text = "Activar Manual"
			Me.ub3.UseVisualStyleBackColor = False
			'
			'ub2
			'
			Me.ub2.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(149, Byte), Integer))
			Me.ub2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.ub2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
			Me.ub2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
			Me.ub2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
			Me.ub2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.ub2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.ub2.Location = New System.Drawing.Point(307, 298)
			Me.ub2.Name = "ub2"
			Me.ub2.Size = New System.Drawing.Size(87, 24)
			Me.ub2.TabIndex = 1818
			Me.ub2.TabStop = False
			Me.ub2.Text = "Activar Online"
			Me.ub2.UseVisualStyleBackColor = False
			'
			'frmRegistracion
			'
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(218, Byte), Integer))
			Me.ClientSize = New System.Drawing.Size(552, 327)
			Me.Controls.Add(Me.ub1)
			Me.Controls.Add(Me.ub2)
			Me.Controls.Add(Me.ub3)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Label38)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.Label48)
			Me.Name = "frmRegistracion"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
End Class
End Namespace