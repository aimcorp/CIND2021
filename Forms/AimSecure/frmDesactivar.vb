Imports System.IO
Imports System.Text
Imports com.softwarekey.Client.Licensing

Namespace ClientLicense
'<summary>Main form</summary>
Partial Public Class frmDesactivar
Inherits Form

#Region "Public Constructors"	'<summary>Default main form constructor</summary>
Public Sub New()
				InitializeComponent()
				m_license = New ClientLicense(m_licenseFilePath)
End Sub
#End Region

#Region "Form Load"
'<summary>Main form Load event handler</summary>
Private Sub frmDesactivar_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
ReloadLicense()
PIm = CheckConection()
If PIm = False Then
		lblStatusText.ForeColor = Color.DeepPink
		lblStatusText.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
		lblStatusText.Text = "No hay conexión al Internet, si desactiva ahora no " &
								"se hará reset del servidor y luego no podrá reactivar en esta " &
								"u otra maquina por Internet"
End If
End Sub

#End Region

#Region "Public Methods"

'<summary>Deactivate license button click event handler</summary>
Private Sub DeactivateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeactivateButton.Click
If PIm = False Then		'no hay conexion al internet
		File.Delete(m_licenseFilePath) : Demo = "Si" : Close() : Exit Sub
End If
If (m_license.DeactivateOnline()) Then
				MessageBox.Show("La Desactivación de esta Licencia a sido completada.", "Desactivación", _
									MessageBoxButtons.OK, MessageBoxIcon.Information) : Demo = "Si" : Close()
Else
				MessageBox.Show("La Desactivación de esta Licencia no fue completada.  El Error es: (" & _
								m_license.LastError.ErrorNumber & ")" & m_license.LastError.ErrorString, "Desactivación", _
										MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
End If
End Sub

'<summary>Reloads the license file and refreshes the status on the main form.</summary>
Public Sub ReloadLicense()
If Not m_license.LoadFile() Then
			DeactivateButton.Enabled = False

			If m_license.LastError.ErrorNumber = LicenseError.ERROR_PLUS_EVALUATION_INVALID Then
							'Invalid Protection PLUS 5 evaluation envelope.
						lblStatusText.Text = m_license.LastError.ErrorString
			Else
							lblStatusText.Text = "No se puede Desactivar, no existe Licencia Válida"
			End If
			Return
End If
RefreshLicenseStatus()
End Sub

'' <summary>Refreshes the license status on the main form</summary>
Public Sub RefreshLicenseStatus()
If Not m_license.Validate() Then
	lblStatusText.Text = "The license is invalid or expired."
	Return
End If

Dim registerInfo As New StringBuilder()

'Check if first name is not empty and not unregistered
If m_license.Customer.FirstName <> "" And m_license.Customer.FirstName <> "UNREGISTERED" Then
			registerInfo.Append("Registered To: ")
			'Append first name
			registerInfo.Append(m_license.Customer.FirstName)
End If

'Check if last name is not empty and not unregistered
If m_license.Customer.LastName <> "" And m_license.Customer.LastName <> "UNREGISTERED" Then
			If registerInfo.ToString() = "" Then
							registerInfo.Append("Registered To:")
			End If
			registerInfo.Append(" ")

			'Append last name
			registerInfo.Append(m_license.Customer.LastName)
End If

'Check if company name is not empty and not unregistered
If m_license.Customer.CompanyName <> "" And m_license.Customer.CompanyName <> "UNREGISTERED" Then
			If registerInfo.ToString() = "" Then
							registerInfo.Append("Registered To:")
			End If
			registerInfo.Append(" ")

			'Append company name
			registerInfo.Append("[" & m_license.Customer.CompanyName & "]")
End If

If registerInfo.ToString() <> "" Then
			registerInfo.Append(Environment.NewLine)
End If

'Append license ID
registerInfo.Append("License ID: " & m_license.LicenseID)
lblStatusText.Text = "Fully Licensed. " & Environment.NewLine & registerInfo.ToString()
End Sub
#End Region

#Region "Button Click Event Handler"

Private Sub ub1_Click(sender As System.Object, e As System.EventArgs) Handles ub1.Click
Me.Close()
End Sub

Private WithEvents lblStatusText As System.Windows.Forms.Label
Friend WithEvents Label38 As System.Windows.Forms.Label
Friend WithEvents Label2 As System.Windows.Forms.Label
Friend WithEvents Label1 As System.Windows.Forms.Label
Friend WithEvents Label48 As System.Windows.Forms.Label
Friend WithEvents ub1 As System.Windows.Forms.Button
Friend WithEvents DeactivateButton As System.Windows.Forms.Button

#End Region

Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDesactivar))
		Me.lblStatusText = New System.Windows.Forms.Label()
		Me.Label38 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label48 = New System.Windows.Forms.Label()
		Me.ub1 = New System.Windows.Forms.Button()
		Me.DeactivateButton = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			'
			'lblStatusText
			'
			Me.lblStatusText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.lblStatusText.ForeColor = System.Drawing.Color.Black
			Me.lblStatusText.Location = New System.Drawing.Point(14, 215)
			Me.lblStatusText.Name = "lblStatusText"
			Me.lblStatusText.Size = New System.Drawing.Size(532, 68)
			Me.lblStatusText.TabIndex = 589
			Me.lblStatusText.Text = "[License Status]"
			'
			'Label38
			'
			Me.Label38.BackColor = System.Drawing.Color.MediumSlateBlue
			Me.Label38.Location = New System.Drawing.Point(3, 37)
			Me.Label38.Name = "Label38"
			Me.Label38.Size = New System.Drawing.Size(546, 7)
			Me.Label38.TabIndex = 588
			'
			'Label2
			'
			Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.Label2.ForeColor = System.Drawing.Color.MediumSlateBlue
			Me.Label2.Location = New System.Drawing.Point(12, 169)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New System.Drawing.Size(518, 39)
			Me.Label2.TabIndex = 587
			Me.Label2.Text = resources.GetString("Label2.Text")
			Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			'
			'Label1
			'
			Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.Label1.ForeColor = System.Drawing.Color.BlueViolet
			Me.Label1.Location = New System.Drawing.Point(12, 56)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New System.Drawing.Size(526, 96)
			Me.Label1.TabIndex = 586
			Me.Label1.Text = resources.GetString("Label1.Text")
			'
			'Label48
			'
			Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.Label48.ForeColor = System.Drawing.Color.OliveDrab
			Me.Label48.Location = New System.Drawing.Point(11, 6)
			Me.Label48.Name = "Label48"
			Me.Label48.Size = New System.Drawing.Size(526, 28)
			Me.Label48.TabIndex = 585
			Me.Label48.Text = "Módulo para la desactivación de este Programa"
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
			Me.ub1.Location = New System.Drawing.Point(499, 289)
			Me.ub1.Name = "ub1"
			Me.ub1.Size = New System.Drawing.Size(50, 25)
			Me.ub1.TabIndex = 1817
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
			Me.DeactivateButton.Location = New System.Drawing.Point(392, 290)
			Me.DeactivateButton.Name = "DeactivateButton"
			Me.DeactivateButton.Size = New System.Drawing.Size(100, 24)
			Me.DeactivateButton.TabIndex = 1816
			Me.DeactivateButton.TabStop = False
			Me.DeactivateButton.Text = "Desactivar Copia"
			Me.DeactivateButton.UseVisualStyleBackColor = False
			'
			'frmDesactivar
			'
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(218, Byte), Integer))
			Me.ClientSize = New System.Drawing.Size(552, 320)
			Me.Controls.Add(Me.ub1)
			Me.Controls.Add(Me.DeactivateButton)
			Me.Controls.Add(Me.lblStatusText)
			Me.Controls.Add(Me.Label38)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.Label48)
			Me.Name = "frmDesactivar"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "frmDesactivar"
			Me.ResumeLayout(False)

		End Sub

End Class
End Namespace