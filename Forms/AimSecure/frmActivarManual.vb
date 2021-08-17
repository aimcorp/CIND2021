Imports com.softwarekey.Client.Licensing
Imports System.Configuration

Namespace ClientLicense
				''' <summary>Manual activation form</summary>
				Partial Public Class frmActivarManual
								Inherits Form

#Region "Member Variables"
	Public m_mainDialog As frmRegistracion
	Public m_license As ClientLicense
#End Region

#Region "Constructors"
'<summary>ActivateManuallyForm default constructor - takes a reference to the MainForm class and 
' AboutForm class</summary> <param name="mainDialog">MainForm</param>
'<param name="license">AboutForm</param>
Public Sub New(ByVal mainDialog As frmRegistracion, ByVal license As ClientLicense)
		m_mainDialog = mainDialog
		m_license = license
		InitializeComponent()
End Sub
#End Region

#Region "Button Event Handlers"
	''' <summary>Activate button click event handler</summary>
	''' <param name="sender">Object</param>
	''' <param name="e">EventArgs</param>
	Private Sub btnActivate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnActivate.Click
				Dim lfContent As String = ""
				Dim successful As Boolean = False

				'TODO: set the value of m_License.CurrentSessionCode to the value stored when the Generate button was clicked
				successful = m_license.ProcessActivateInstallationLicenseFileResponse(txtActivationCode.Text, lfContent)
				If Not successful Then
						MessageBox.Show("Falló la Activación" & _
							Environment.NewLine & Environment.NewLine & "Posiblemente porque el certificado está incorrecto o " & _
							Environment.NewLine & "Ya no existen más oportunidades para Registrar", "Activación Manual", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
						Return
				End If
				If m_license.SaveLicenseFile(lfContent) Then
								MessageBox.Show("Activación Completada", "Activación Manual", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
								m_license.ResetSessionCode()
								Demo = "No" : Close()
				End If
	End Sub

'<summary>Generate Request button click event handler</summary>
Private Sub btnGenerateRequest_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerateRequest.Click
Dim licenseId As Int32 = 0
Dim password As String = txtPassword.Text
Dim request As String = ""

m_license.ResetSessionCode()
'TODO: store the value of m_license.CurrentSessionCode in some hidden location

If "" = txtLicenseID.Text Then
				MessageBox.Show("Entre su número de Licencia.", "Activación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				txtLicenseID.Focus()
				Return
End If

If Not Int32.TryParse(txtLicenseID.Text, licenseId) Then
				MessageBox.Show("La Licencia sólo acepta números.", "Activación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				txtLicenseID.Focus()
				Return
End If

If Not Int32.TryParse(txtLicenseID.Text, licenseId) Then
				MessageBox.Show("La Licencia sólo acepta números.", "Activación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				txtLicenseID.Focus()
				Return
End If

If "" = txtPassword.Text Then
				MessageBox.Show("Entre la Contraseña (password).", "Activación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				txtPassword.Focus()
				Return
End If

request = m_license.GetActivationInstallationLicenseFileRequest(licenseId, password)

txtActivationRequest.Text = request
btnCopy.Enabled = True
btnPaste.Enabled = True
btnActivationPage.Enabled = True
txtActivationCode.Enabled = True
End Sub

'<summary>Button copy click event handler</summary>
Private Sub btnCopy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCopy.Click
Clipboard.SetDataObject(txtActivationRequest.Text, False, 100, 10)
End Sub

'<summary>Button paste click event handler</summary>
Private Sub btnPaste_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPaste.Click
txtActivationCode.Text = Clipboard.GetText()
End Sub

'<summary>Button activation page click event handler</summary>
Private Sub btnActivationPage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnActivationPage.Click
Process.Start(ConfigurationManager.AppSettings("ManualActivationUrl"))
End Sub

#End Region

#Region "TextBox Event Handlers"
'<summary>Activation code text changed event handler</summary>
Private Sub txtActivationCode_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtActivationCode.TextChanged
If "" <> txtActivationCode.Text Then btnActivate.Enabled = True Else btnActivate.Enabled = False
End Sub
#End Region

#Region "Form Event Handlers"
'<summary>Activate Manually form Load event handler</summary>
Private Sub frmActivateManually_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
	If m_license.LicenseID > 0 Then
				txtLicenseID.Text = m_license.LicenseID.ToString()
				txtPassword.Focus()
	Else
				txtLicenseID.Focus()
	End If
End Sub
#End Region

#Region "Botones de Limpiar"
Private Sub ub1_Click(sender As System.Object, e As System.EventArgs) Handles ub1.Click
txtActivationRequest.Text = "" : txtActivationCode.Text = ""
End Sub

Private Sub ub2_Click(sender As System.Object, e As System.EventArgs) Handles ub2.Click
txtActivationCode.Text = ""
End Sub
Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
Friend WithEvents btnActivate As System.Windows.Forms.Button
Friend WithEvents btnPaste As System.Windows.Forms.Button
Private WithEvents txtActivationCode As System.Windows.Forms.TextBox
Friend WithEvents ub2 As System.Windows.Forms.Button
Private WithEvents lblActivationCode As System.Windows.Forms.Label
Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
Friend WithEvents btnActivationPage As System.Windows.Forms.Button
Friend WithEvents btnCopy As System.Windows.Forms.Button
Friend WithEvents ub1 As System.Windows.Forms.Button
Private WithEvents txtActivationRequest As System.Windows.Forms.TextBox
Private WithEvents lblActivationRequest As System.Windows.Forms.Label
Private WithEvents grpStep1 As System.Windows.Forms.GroupBox
Friend WithEvents btnGenerateRequest As System.Windows.Forms.Button
Private WithEvents txtPassword As System.Windows.Forms.TextBox
Private WithEvents lblPassword As System.Windows.Forms.Label
Private WithEvents Label1 As System.Windows.Forms.Label
Private WithEvents txtLicenseID As System.Windows.Forms.TextBox
Private WithEvents lblLicenseID As System.Windows.Forms.Label
#End Region

Private Sub InitializeComponent()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.btnActivate = New System.Windows.Forms.Button()
		Me.btnPaste = New System.Windows.Forms.Button()
		Me.txtActivationCode = New System.Windows.Forms.TextBox()
		Me.ub2 = New System.Windows.Forms.Button()
		Me.lblActivationCode = New System.Windows.Forms.Label()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnActivationPage = New System.Windows.Forms.Button()
		Me.btnCopy = New System.Windows.Forms.Button()
		Me.ub1 = New System.Windows.Forms.Button()
		Me.txtActivationRequest = New System.Windows.Forms.TextBox()
		Me.lblActivationRequest = New System.Windows.Forms.Label()
		Me.grpStep1 = New System.Windows.Forms.GroupBox()
		Me.btnGenerateRequest = New System.Windows.Forms.Button()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.lblPassword = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtLicenseID = New System.Windows.Forms.TextBox()
		Me.lblLicenseID = New System.Windows.Forms.Label()
			Me.groupBox2.SuspendLayout()
			Me.groupBox1.SuspendLayout()
			Me.grpStep1.SuspendLayout()
			Me.SuspendLayout()
			'
			'groupBox2
			'
			Me.groupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(208, Byte), Integer))
			Me.groupBox2.Controls.Add(Me.btnActivate)
			Me.groupBox2.Controls.Add(Me.btnPaste)
			Me.groupBox2.Controls.Add(Me.txtActivationCode)
			Me.groupBox2.Controls.Add(Me.ub2)
			Me.groupBox2.Controls.Add(Me.lblActivationCode)
			Me.groupBox2.Location = New System.Drawing.Point(12, 357)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(514, 216)
			Me.groupBox2.TabIndex = 20
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Paso 3: Copie el Texto de la página de Internet y péguelo aquí, luego presione Ac" &
	"tivar "
			'
			'btnActivate
			'
			Me.btnActivate.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(84, Byte), Integer))
			Me.btnActivate.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod
			Me.btnActivate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
			Me.btnActivate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
			Me.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.btnActivate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.btnActivate.Location = New System.Drawing.Point(441, 181)
			Me.btnActivate.Name = "btnActivate"
			Me.btnActivate.Size = New System.Drawing.Size(68, 25)
			Me.btnActivate.TabIndex = 1815
			Me.btnActivate.TabStop = False
			Me.btnActivate.Text = "Activar"
			Me.btnActivate.UseVisualStyleBackColor = False
			'
			'btnPaste
			'
			Me.btnPaste.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(149, Byte), Integer))
			Me.btnPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.btnPaste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
			Me.btnPaste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
			Me.btnPaste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
			Me.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.btnPaste.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.btnPaste.Location = New System.Drawing.Point(352, 182)
			Me.btnPaste.Name = "btnPaste"
			Me.btnPaste.Size = New System.Drawing.Size(83, 24)
			Me.btnPaste.TabIndex = 1814
			Me.btnPaste.TabStop = False
			Me.btnPaste.Text = "Pegar (Paste)"
			Me.btnPaste.UseVisualStyleBackColor = False
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
			'ub2
			'
			Me.ub2.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(149, Byte), Integer))
			Me.ub2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.ub2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
			Me.ub2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
			Me.ub2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
			Me.ub2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.ub2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.ub2.Location = New System.Drawing.Point(6, 182)
			Me.ub2.Name = "ub2"
			Me.ub2.Size = New System.Drawing.Size(54, 24)
			Me.ub2.TabIndex = 1814
			Me.ub2.TabStop = False
			Me.ub2.Text = "Limpiar"
			Me.ub2.UseVisualStyleBackColor = False
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
			Me.groupBox1.Controls.Add(Me.btnActivationPage)
			Me.groupBox1.Controls.Add(Me.btnCopy)
			Me.groupBox1.Controls.Add(Me.ub1)
			Me.groupBox1.Controls.Add(Me.txtActivationRequest)
			Me.groupBox1.Controls.Add(Me.lblActivationRequest)
			Me.groupBox1.Location = New System.Drawing.Point(10, 138)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(516, 209)
			Me.groupBox1.TabIndex = 19
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Paso 2: Copie el texto en el encasillado y péguelo a la página de activación en I" &
	"nternet"
			'
			'btnActivationPage
			'
			Me.btnActivationPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(84, Byte), Integer))
			Me.btnActivationPage.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod
			Me.btnActivationPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
			Me.btnActivationPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
			Me.btnActivationPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.btnActivationPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.btnActivationPage.Location = New System.Drawing.Point(313, 177)
			Me.btnActivationPage.Name = "btnActivationPage"
			Me.btnActivationPage.Size = New System.Drawing.Size(196, 25)
			Me.btnActivationPage.TabIndex = 1815
			Me.btnActivationPage.TabStop = False
			Me.btnActivationPage.Text = "Abrir Página de Activación en Internet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
			Me.btnActivationPage.UseVisualStyleBackColor = False
			'
			'btnCopy
			'
			Me.btnCopy.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(149, Byte), Integer))
			Me.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
			Me.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
			Me.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
			Me.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.btnCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.btnCopy.Location = New System.Drawing.Point(228, 178)
			Me.btnCopy.Name = "btnCopy"
			Me.btnCopy.Size = New System.Drawing.Size(79, 24)
			Me.btnCopy.TabIndex = 1814
			Me.btnCopy.TabStop = False
			Me.btnCopy.Text = "Copiar Texto"
			Me.btnCopy.UseVisualStyleBackColor = False
			'
			'ub1
			'
			Me.ub1.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(149, Byte), Integer))
			Me.ub1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.ub1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
			Me.ub1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
			Me.ub1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
			Me.ub1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.ub1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.ub1.Location = New System.Drawing.Point(6, 178)
			Me.ub1.Name = "ub1"
			Me.ub1.Size = New System.Drawing.Size(54, 24)
			Me.ub1.TabIndex = 1814
			Me.ub1.TabStop = False
			Me.ub1.Text = "Limpiar"
			Me.ub1.UseVisualStyleBackColor = False
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
			Me.grpStep1.Controls.Add(Me.btnGenerateRequest)
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
			'btnGenerateRequest
			'
			Me.btnGenerateRequest.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(149, Byte), Integer))
			Me.btnGenerateRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.btnGenerateRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
			Me.btnGenerateRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
			Me.btnGenerateRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
			Me.btnGenerateRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.btnGenerateRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.btnGenerateRequest.Location = New System.Drawing.Point(118, 82)
			Me.btnGenerateRequest.Name = "btnGenerateRequest"
			Me.btnGenerateRequest.Size = New System.Drawing.Size(147, 24)
			Me.btnGenerateRequest.TabIndex = 1814
			Me.btnGenerateRequest.TabStop = False
			Me.btnGenerateRequest.Text = "Generar Pedido Activación"
			Me.btnGenerateRequest.UseVisualStyleBackColor = False
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
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.grpStep1.ResumeLayout(False)
			Me.grpStep1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub
End Class
End Namespace
