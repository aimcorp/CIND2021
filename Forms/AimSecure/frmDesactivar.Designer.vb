<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDesactivar
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDesactivar))
		Me.lblStatusText = New System.Windows.Forms.Label()
		Me.Label38 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label48 = New System.Windows.Forms.Label()
		Me.btnActivationPage = New System.Windows.Forms.Button()
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
		'btnActivationPage
		'
		Me.btnActivationPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(84, Byte), Integer))
		Me.btnActivationPage.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod
		Me.btnActivationPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
		Me.btnActivationPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
		Me.btnActivationPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnActivationPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnActivationPage.Location = New System.Drawing.Point(499, 289)
		Me.btnActivationPage.Name = "btnActivationPage"
		Me.btnActivationPage.Size = New System.Drawing.Size(50, 25)
		Me.btnActivationPage.TabIndex = 1817
		Me.btnActivationPage.TabStop = False
		Me.btnActivationPage.Text = "Salir"
		Me.btnActivationPage.UseVisualStyleBackColor = False
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
		Me.Controls.Add(Me.btnActivationPage)
		Me.Controls.Add(Me.DeactivateButton)
		Me.Controls.Add(Me.lblStatusText)
		Me.Controls.Add(Me.Label38)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label48)
		Me.Name = "frmDesactivar"
		Me.Text = "frmDesactivar"
		Me.ResumeLayout(False)

End Sub
				Private WithEvents lblStatusText As System.Windows.Forms.Label
				Friend WithEvents Label38 As System.Windows.Forms.Label
				Friend WithEvents Label2 As System.Windows.Forms.Label
				Friend WithEvents Label1 As System.Windows.Forms.Label
				Friend WithEvents Label48 As System.Windows.Forms.Label
				Friend WithEvents btnActivationPage As System.Windows.Forms.Button
				Friend WithEvents DeactivateButton As System.Windows.Forms.Button
End Class
