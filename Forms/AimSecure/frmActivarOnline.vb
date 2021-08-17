Imports com.softwarekey.Client.Licensing

Namespace ClientLicense
				''' <summary>Online activation form</summary>
Partial Public Class frmActivateOnline
Inherits Form

#Region "Member Variables"
								Private m_mainDialog As frmRegistracion
								Private m_license As ClientLicense
#End Region

#Region "Public Constructors"
	Public Sub New(ByVal mainDialog As frmRegistracion, ByVal license As ClientLicense)
			m_mainDialog = mainDialog
			m_license = license
			InitializeComponent()
		End Sub
#End Region

#Region "Event Handlers"
        '<cancelar>
        Private Sub ub1_Click(sender As System.Object, e As System.EventArgs) Handles ub1.Click
Close()
End Sub

'<summary>Activate button click event handler</summary>
Private Sub ub2_Click(sender As System.Object, e As System.EventArgs) Handles ub2.Click
Dim licenseId As Int32 = 0
			Dim password As String = UCase(txtPassword.Text)
			Dim successful As Boolean = False

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

successful = m_license.ActivateOnline(licenseId, password)

If successful Then
    'ARIEL
    'Check if this is an Individual license
    If m_license.IsIndividualLicense = True Then
					'It is so we do not want to save the license and we do not want to set Demo to "Si"
					'We can check the IsIndividualLicense property of the ClientLicense class when we need to.
					'You may want to customize the messagebox below for an Individual activation.
					MessageBox.Show("Activación Completada", "Activación", MessageBoxButtons.OK, MessageBoxIcon.Information)
					valor10 = "" : Demo = "xx" : Close()
				Else
					MessageBox.Show("Activación Completada", "Activación", MessageBoxButtons.OK, MessageBoxIcon.Information)
					If valor10 = "indlic" Then Demo = "xx" Else Demo = "No"
					valor10 = "" : Close()
				End If
					Else
    Dim errnow As Integer = m_license.LastError.ExtendedErrorNumber
    If errnow = 5008 Then
              MessageBox.Show("Activación Fallida." & Environment.NewLine & Environment.NewLine & _
              "Número de Licencia o Contraseña Incorrecta", "Activación", MessageBoxButtons.OK, _
              MessageBoxIcon.Exclamation) : Exit Sub
    End If
    If errnow = 5013 Then
       MessageBox.Show("Activación Fallida." & Environment.NewLine & Environment.NewLine & _
       "No existen más oportunidades para Registrar", "Activación", MessageBoxButtons.OK, _
       MessageBoxIcon.Exclamation) : Exit Sub
    End If
				MessageBox.Show("Activación Fallida." & Environment.NewLine & Environment.NewLine &
						"Problemas de Comunicación o Licencia o Contraseña Incorrecta", "Activación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			End If
End Sub

'<summary>From load event handler</summary>
Private Sub frmActivarOnline_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
	If m_license.LicenseID > 0 Then
					txtLicenseID.Text = m_license.LicenseID.ToString() : txtPassword.Focus()
	Else
					txtLicenseID.Focus()
	End If
End Sub

'<summary>Activate online key press event handler</summary>
Private Sub frmActivarOnline_KeyPress(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
If Keys.Enter = e.KeyCode Then ub2_Click(sender, e)
End Sub

'<summary>LicenseID text box key press event handler</summary>
Private Sub txtLicenseID_KeyPress(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtLicenseID.KeyDown

End Sub

Friend WithEvents grpCredentials As System.Windows.Forms.GroupBox
Friend WithEvents lblInstructions As System.Windows.Forms.Label
Friend WithEvents txtPassword As System.Windows.Forms.MaskedTextBox
Friend WithEvents lblPassword As System.Windows.Forms.Label
Friend WithEvents txtLicenseID As System.Windows.Forms.TextBox
Friend WithEvents lblLicenseID As System.Windows.Forms.Label
#End Region

Private Sub InitializeComponent()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActivateOnline))
			Me.grpCredentials = New System.Windows.Forms.GroupBox()
			Me.lblInstructions = New System.Windows.Forms.Label()
			Me.txtPassword = New System.Windows.Forms.MaskedTextBox()
			Me.lblPassword = New System.Windows.Forms.Label()
			Me.txtLicenseID = New System.Windows.Forms.TextBox()
			Me.lblLicenseID = New System.Windows.Forms.Label()
			Me.ub1 = New System.Windows.Forms.Button()
			Me.ub2 = New System.Windows.Forms.Button()
			Me.Label1 = New System.Windows.Forms.Label()
			Me.grpCredentials.SuspendLayout()
			Me.SuspendLayout()
			'
			'grpCredentials
			'
			Me.grpCredentials.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(208, Byte), Integer))
			Me.grpCredentials.Controls.Add(Me.lblInstructions)
			Me.grpCredentials.Controls.Add(Me.txtPassword)
			Me.grpCredentials.Controls.Add(Me.lblPassword)
			Me.grpCredentials.Controls.Add(Me.txtLicenseID)
			Me.grpCredentials.Controls.Add(Me.lblLicenseID)
			Me.grpCredentials.Location = New System.Drawing.Point(10, 10)
			Me.grpCredentials.Name = "grpCredentials"
			Me.grpCredentials.Size = New System.Drawing.Size(451, 216)
			Me.grpCredentials.TabIndex = 19
			Me.grpCredentials.TabStop = False
			'
			'lblInstructions
			'
			Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.lblInstructions.ForeColor = System.Drawing.Color.MediumVioletRed
			Me.lblInstructions.Location = New System.Drawing.Point(6, 16)
			Me.lblInstructions.Name = "lblInstructions"
			Me.lblInstructions.Size = New System.Drawing.Size(439, 127)
			Me.lblInstructions.TabIndex = 10
			Me.lblInstructions.Text = resources.GetString("lblInstructions.Text")
			Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			'
			'txtPassword
			'
			Me.txtPassword.Location = New System.Drawing.Point(174, 185)
			Me.txtPassword.Name = "txtPassword"
			Me.txtPassword.Size = New System.Drawing.Size(129, 20)
			Me.txtPassword.TabIndex = 1
			'
			'lblPassword
			'
			Me.lblPassword.Location = New System.Drawing.Point(56, 188)
			Me.lblPassword.Name = "lblPassword"
			Me.lblPassword.Size = New System.Drawing.Size(119, 13)
			Me.lblPassword.TabIndex = 8
			Me.lblPassword.Text = "Contraseña (Password):"
			Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			'
			'txtLicenseID
			'
			Me.txtLicenseID.Location = New System.Drawing.Point(174, 158)
			Me.txtLicenseID.MaxLength = 10
			Me.txtLicenseID.Name = "txtLicenseID"
			Me.txtLicenseID.Size = New System.Drawing.Size(129, 20)
			Me.txtLicenseID.TabIndex = 0
			'
			'lblLicenseID
			'
			Me.lblLicenseID.Location = New System.Drawing.Point(51, 162)
			Me.lblLicenseID.Name = "lblLicenseID"
			Me.lblLicenseID.Size = New System.Drawing.Size(124, 13)
			Me.lblLicenseID.TabIndex = 6
			Me.lblLicenseID.Text = "Licencia Número:"
			Me.lblLicenseID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			'
			'ub1
			'
			Me.ub1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(84, Byte), Integer))
			Me.ub1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod
			Me.ub1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
			Me.ub1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
			Me.ub1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.ub1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.ub1.Location = New System.Drawing.Point(362, 232)
			Me.ub1.Name = "ub1"
			Me.ub1.Size = New System.Drawing.Size(51, 25)
			Me.ub1.TabIndex = 1817
			Me.ub1.TabStop = False
			Me.ub1.Text = "Salir"
			Me.ub1.UseVisualStyleBackColor = False
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
			Me.ub2.Location = New System.Drawing.Point(275, 233)
			Me.ub2.Name = "ub2"
			Me.ub2.Size = New System.Drawing.Size(82, 24)
			Me.ub2.TabIndex = 1816
			Me.ub2.TabStop = False
			Me.ub2.Text = "Activar Copia"
			Me.ub2.UseVisualStyleBackColor = False
			'
			'Label1
			'
			Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.Label1.ForeColor = System.Drawing.Color.Black
			Me.Label1.Location = New System.Drawing.Point(14, 236)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New System.Drawing.Size(255, 16)
			Me.Label1.TabIndex = 10
			Me.Label1.Text = "Sugerimos intentar más de una vez"
			Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			'
			'frmActivateOnline
			'
			Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(218, Byte), Integer))
			Me.ClientSize = New System.Drawing.Size(470, 265)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.ub1)
			Me.Controls.Add(Me.ub2)
			Me.Controls.Add(Me.grpCredentials)
			Me.Name = "frmActivateOnline"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.grpCredentials.ResumeLayout(False)
			Me.grpCredentials.PerformLayout()
			Me.ResumeLayout(False)

		End Sub
		Friend WithEvents ub1 As System.Windows.Forms.Button
Friend WithEvents ub2 As System.Windows.Forms.Button
Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
End Namespace