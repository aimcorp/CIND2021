<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivarManual
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
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.txtActivationCode = New System.Windows.Forms.TextBox()
		Me.lblActivationCode = New System.Windows.Forms.Label()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.txtActivationRequest = New System.Windows.Forms.TextBox()
		Me.lblActivationRequest = New System.Windows.Forms.Label()
		Me.grpStep1 = New System.Windows.Forms.GroupBox()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.lblPassword = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtLicenseID = New System.Windows.Forms.TextBox()
		Me.lblLicenseID = New System.Windows.Forms.Label()
		Me.btImp = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.btDes = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.groupBox2.SuspendLayout()
		Me.groupBox1.SuspendLayout()
		Me.grpStep1.SuspendLayout()
		Me.SuspendLayout()
		'
		'groupBox2
		'
		Me.groupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.groupBox2.Controls.Add(Me.Button5)
		Me.groupBox2.Controls.Add(Me.Button4)
		Me.groupBox2.Controls.Add(Me.txtActivationCode)
		Me.groupBox2.Controls.Add(Me.Button3)
		Me.groupBox2.Controls.Add(Me.lblActivationCode)
		Me.groupBox2.Location = New System.Drawing.Point(12, 357)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(514, 216)
		Me.groupBox2.TabIndex = 20
		Me.groupBox2.TabStop = False
		Me.groupBox2.Text = "Paso 3: Copie el Texto de la página de Internet y péguelo aquí, luego presione Ac" & _
				"tivar "
		'
		'txtActivationCode
		'
		Me.txtActivationCode.Enabled = False
		Me.txtActivationCode.Location = New System.Drawing.Point(6, 33)
		Me.txtActivationCode.Multiline = True
		Me.txtActivationCode.Name = "txtActivationCode"
		Me.txtActivationCode.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtActivationCode.Size = New System.Drawing.Size(502, 145)
		Me.txtActivationCode.TabIndex = 10
		'
		'lblActivationCode
		'
		Me.lblActivationCode.AutoSize = True
		Me.lblActivationCode.Location = New System.Drawing.Point(7, 17)
		Me.lblActivationCode.Name = "lblActivationCode"
		Me.lblActivationCode.Size = New System.Drawing.Size(105, 13)
		Me.lblActivationCode.TabIndex = 9
		Me.lblActivationCode.Text = "Texto de Activación:"
		'
		'groupBox1
		'
		Me.groupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.groupBox1.Controls.Add(Me.btDes)
		Me.groupBox1.Controls.Add(Me.Button2)
		Me.groupBox1.Controls.Add(Me.Button1)
		Me.groupBox1.Controls.Add(Me.txtActivationRequest)
		Me.groupBox1.Controls.Add(Me.lblActivationRequest)
		Me.groupBox1.Location = New System.Drawing.Point(10, 138)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(516, 209)
		Me.groupBox1.TabIndex = 19
		Me.groupBox1.TabStop = False
		Me.groupBox1.Text = "Paso 2: Copie el texto en el encasillado y péguelo a la página de activación en I" & _
				"nternet"
		'
		'txtActivationRequest
		'
		Me.txtActivationRequest.Location = New System.Drawing.Point(6, 37)
		Me.txtActivationRequest.Multiline = True
		Me.txtActivationRequest.Name = "txtActivationRequest"
		Me.txtActivationRequest.ReadOnly = True
		Me.txtActivationRequest.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtActivationRequest.Size = New System.Drawing.Size(504, 137)
		Me.txtActivationRequest.TabIndex = 12
		'
		'lblActivationRequest
		'
		Me.lblActivationRequest.AutoSize = True
		Me.lblActivationRequest.Location = New System.Drawing.Point(7, 21)
		Me.lblActivationRequest.Name = "lblActivationRequest"
		Me.lblActivationRequest.Size = New System.Drawing.Size(174, 13)
		Me.lblActivationRequest.TabIndex = 11
		Me.lblActivationRequest.Text = "Encasillado de Texto de Activation:"
		'
		'grpStep1
		'
		Me.grpStep1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.grpStep1.Controls.Add(Me.btImp)
		Me.grpStep1.Controls.Add(Me.txtPassword)
		Me.grpStep1.Controls.Add(Me.lblPassword)
		Me.grpStep1.Controls.Add(Me.Label1)
		Me.grpStep1.Controls.Add(Me.txtLicenseID)
		Me.grpStep1.Controls.Add(Me.lblLicenseID)
		Me.grpStep1.Location = New System.Drawing.Point(10, 13)
		Me.grpStep1.Name = "grpStep1"
		Me.grpStep1.Size = New System.Drawing.Size(518, 112)
		Me.grpStep1.TabIndex = 18
		Me.grpStep1.TabStop = False
		Me.grpStep1.Text = "Paso 1: Entre su Licencia y Contraseña y presione Generar Pedido de Activación"
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(130, 54)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
		Me.txtPassword.Size = New System.Drawing.Size(122, 20)
		Me.txtPassword.TabIndex = 16
		'
		'lblPassword
		'
		Me.lblPassword.AutoSize = True
		Me.lblPassword.Location = New System.Drawing.Point(10, 57)
		Me.lblPassword.Name = "lblPassword"
		Me.lblPassword.Size = New System.Drawing.Size(119, 13)
		Me.lblPassword.TabIndex = 15
		Me.lblPassword.Text = "Contraseña (Password):"
		Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Crimson
		Me.Label1.Location = New System.Drawing.Point(253, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(197, 30)
		Me.Label1.TabIndex = 11
		Me.Label1.Text = "Usualmente la encuentra en el Email que recibió al ordenar"
		'
		'txtLicenseID
		'
		Me.txtLicenseID.Location = New System.Drawing.Point(130, 26)
		Me.txtLicenseID.Name = "txtLicenseID"
		Me.txtLicenseID.Size = New System.Drawing.Size(122, 20)
		Me.txtLicenseID.TabIndex = 14
		'
		'lblLicenseID
		'
		Me.lblLicenseID.Location = New System.Drawing.Point(10, 30)
		Me.lblLicenseID.Name = "lblLicenseID"
		Me.lblLicenseID.Size = New System.Drawing.Size(118, 13)
		Me.lblLicenseID.TabIndex = 13
		Me.lblLicenseID.Text = "Número de Licencia:"
		Me.lblLicenseID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'btImp
		'
		Me.btImp.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(149, Byte), Integer))
		Me.btImp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btImp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btImp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.btImp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
		Me.btImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btImp.Location = New System.Drawing.Point(118, 82)
		Me.btImp.Name = "btImp"
		Me.btImp.Size = New System.Drawing.Size(147, 24)
		Me.btImp.TabIndex = 1814
		Me.btImp.TabStop = False
		Me.btImp.Text = "Generar Pedido Activación"
		Me.btImp.UseVisualStyleBackColor = False
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
		Me.Button1.Location = New System.Drawing.Point(6, 178)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(54, 24)
		Me.Button1.TabIndex = 1814
		Me.Button1.TabStop = False
		Me.Button1.Text = "Limpiar"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(149, Byte), Integer))
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.Location = New System.Drawing.Point(228, 178)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(79, 24)
		Me.Button2.TabIndex = 1814
		Me.Button2.TabStop = False
		Me.Button2.Text = "Copiar Texto"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'btDes
		'
		Me.btDes.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(84, Byte), Integer))
		Me.btDes.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod
		Me.btDes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
		Me.btDes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
		Me.btDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btDes.Location = New System.Drawing.Point(313, 177)
		Me.btDes.Name = "btDes"
		Me.btDes.Size = New System.Drawing.Size(196, 25)
		Me.btDes.TabIndex = 1815
		Me.btDes.TabStop = False
		Me.btDes.Text = "Abrir Página de Activación en Internet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		Me.btDes.UseVisualStyleBackColor = False
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(149, Byte), Integer))
		Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.Location = New System.Drawing.Point(6, 182)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(54, 24)
		Me.Button3.TabIndex = 1814
		Me.Button3.TabStop = False
		Me.Button3.Text = "Limpiar"
		Me.Button3.UseVisualStyleBackColor = False
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(149, Byte), Integer))
		Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button4.Location = New System.Drawing.Point(352, 182)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(83, 24)
		Me.Button4.TabIndex = 1814
		Me.Button4.TabStop = False
		Me.Button4.Text = "Pegar (Paste)"
		Me.Button4.UseVisualStyleBackColor = False
		'
		'Button5
		'
		Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(84, Byte), Integer))
		Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod
		Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
		Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
		Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button5.Location = New System.Drawing.Point(441, 181)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(68, 25)
		Me.Button5.TabIndex = 1815
		Me.Button5.TabStop = False
		Me.Button5.Text = "Activar"
		Me.Button5.UseVisualStyleBackColor = False
		'
		'frmActivarManual
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(218, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(538, 586)
		Me.Controls.Add(Me.groupBox2)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.grpStep1)
		Me.Name = "frmActivarManual"
		Me.Text = "frmActivarManual"
		Me.groupBox2.ResumeLayout(False)
		Me.groupBox2.PerformLayout()
		Me.groupBox1.ResumeLayout(False)
		Me.groupBox1.PerformLayout()
		Me.grpStep1.ResumeLayout(False)
		Me.grpStep1.PerformLayout()
		Me.ResumeLayout(False)

End Sub
				Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
				Private WithEvents txtActivationCode As System.Windows.Forms.TextBox
				Private WithEvents lblActivationCode As System.Windows.Forms.Label
				Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
				Private WithEvents txtActivationRequest As System.Windows.Forms.TextBox
				Private WithEvents lblActivationRequest As System.Windows.Forms.Label
				Private WithEvents grpStep1 As System.Windows.Forms.GroupBox
				Private WithEvents txtPassword As System.Windows.Forms.TextBox
				Private WithEvents lblPassword As System.Windows.Forms.Label
				Private WithEvents Label1 As System.Windows.Forms.Label
				Private WithEvents txtLicenseID As System.Windows.Forms.TextBox
				Private WithEvents lblLicenseID As System.Windows.Forms.Label
				Friend WithEvents Button2 As System.Windows.Forms.Button
				Friend WithEvents Button1 As System.Windows.Forms.Button
				Friend WithEvents btImp As System.Windows.Forms.Button
				Friend WithEvents Button5 As System.Windows.Forms.Button
				Friend WithEvents Button4 As System.Windows.Forms.Button
				Friend WithEvents Button3 As System.Windows.Forms.Button
				Friend WithEvents btDes As System.Windows.Forms.Button
End Class
