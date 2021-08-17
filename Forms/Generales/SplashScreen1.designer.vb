<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
		Me.Version = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Version
		'
		Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Version.BackColor = System.Drawing.Color.Transparent
		Me.Version.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Version.ForeColor = System.Drawing.Color.AliceBlue
		Me.Version.Location = New System.Drawing.Point(231, 576)
		Me.Version.Name = "Version"
		Me.Version.Size = New System.Drawing.Size(116, 28)
		Me.Version.TabIndex = 2
		Me.Version.Text = "Revision"
		Me.Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'SplashScreen1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.AIMContribucionesIncentivos.My.Resources.Resources.CIND_Opening_V3
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ClientSize = New System.Drawing.Size(1142, 653)
		Me.ControlBox = False
		Me.Controls.Add(Me.Version)
		Me.DoubleBuffered = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "SplashScreen1"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Version As System.Windows.Forms.Label

End Class
