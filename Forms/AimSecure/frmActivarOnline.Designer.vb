<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivateOnline
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
    'Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActivarOnline))
    'Me.grpCredentials = New System.Windows.Forms.GroupBox()
    'Me.lblInstructions = New System.Windows.Forms.Label()
    'Me.txtPassword = New System.Windows.Forms.MaskedTextBox()
    'Me.lblPassword = New System.Windows.Forms.Label()
    'Me.txtLicenseID = New System.Windows.Forms.TextBox()
    'Me.lblLicenseID = New System.Windows.Forms.Label()
    'Me.ub1 = New System.Windows.Forms.Button()
    'Me.ub2 = New System.Windows.Forms.Button()
    'Me.grpCredentials.SuspendLayout()
    'Me.SuspendLayout()
    ''
    'grpCredentials
    '
    Me.grpCredentials.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(208, Byte), Integer))
    Me.grpCredentials.Controls.Add(Me.lblInstructions)
    Me.grpCredentials.Controls.Add(Me.txtPassword)
    Me.grpCredentials.Controls.Add(Me.lblPassword)
    Me.grpCredentials.Controls.Add(Me.txtLicenseID)
    Me.grpCredentials.Controls.Add(Me.lblLicenseID)
    Me.grpCredentials.Location = New System.Drawing.Point(11, 10)
    Me.grpCredentials.Name = "grpCredentials"
    Me.grpCredentials.Size = New System.Drawing.Size(401, 161)
    Me.grpCredentials.TabIndex = 19
    Me.grpCredentials.TabStop = False
    '
    'lblInstructions
    '
    Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblInstructions.ForeColor = System.Drawing.Color.MediumVioletRed
    Me.lblInstructions.Location = New System.Drawing.Point(6, 16)
    Me.lblInstructions.Name = "lblInstructions"
    Me.lblInstructions.Size = New System.Drawing.Size(389, 82)
    Me.lblInstructions.TabIndex = 10
 '   Me.lblInstructions.Text = resources.GetString("lblInstructions.Text")
    '
    'txtPassword
    '
    Me.txtPassword.Location = New System.Drawing.Point(153, 132)
    Me.txtPassword.Name = "txtPassword"
    Me.txtPassword.Size = New System.Drawing.Size(129, 20)
    Me.txtPassword.TabIndex = 1
    '
    'lblPassword
    '
    Me.lblPassword.Location = New System.Drawing.Point(35, 135)
    Me.lblPassword.Name = "lblPassword"
    Me.lblPassword.Size = New System.Drawing.Size(119, 13)
    Me.lblPassword.TabIndex = 8
    Me.lblPassword.Text = "Contraseña (Password):"
    Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'txtLicenseID
    '
    Me.txtLicenseID.Location = New System.Drawing.Point(153, 105)
    Me.txtLicenseID.MaxLength = 10
    Me.txtLicenseID.Name = "txtLicenseID"
    Me.txtLicenseID.Size = New System.Drawing.Size(129, 20)
    Me.txtLicenseID.TabIndex = 0
    '
    'lblLicenseID
    '
    Me.lblLicenseID.Location = New System.Drawing.Point(30, 109)
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
    Me.ub1.Location = New System.Drawing.Point(365, 183)
    Me.ub1.Name = "ub1"
    Me.ub1.Size = New System.Drawing.Size(46, 25)
    Me.ub1.TabIndex = 1817
    Me.ub1.TabStop = False
    Me.ub1.Text = "Salir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
    Me.ub2.Location = New System.Drawing.Point(280, 184)
    Me.ub2.Name = "ub2"
    Me.ub2.Size = New System.Drawing.Size(81, 24)
    Me.ub2.TabIndex = 1816
    Me.ub2.TabStop = False
    Me.ub2.Text = "Activar Copia"
    Me.ub2.UseVisualStyleBackColor = False
    '
    'frmActivarOnline
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(218, Byte), Integer))
    Me.ClientSize = New System.Drawing.Size(423, 220)
    Me.Controls.Add(Me.ub1)
    Me.Controls.Add(Me.ub2)
    Me.Controls.Add(Me.grpCredentials)
    Me.Name = "frmActivarOnline"
    Me.Text = "frmActivarOnline"
    Me.grpCredentials.ResumeLayout(False)
    Me.grpCredentials.PerformLayout()
    Me.ResumeLayout(False)

End Sub

        Friend WithEvents grpCredentials As System.Windows.Forms.GroupBox
        Friend WithEvents lblInstructions As System.Windows.Forms.Label
        Friend WithEvents txtPassword As System.Windows.Forms.MaskedTextBox
        Friend WithEvents lblPassword As System.Windows.Forms.Label
        Friend WithEvents txtLicenseID As System.Windows.Forms.TextBox
        Friend WithEvents lblLicenseID As System.Windows.Forms.Label
        Friend WithEvents ub1 As System.Windows.Forms.Button
        Friend WithEvents ub2 As System.Windows.Forms.Button
End Class
