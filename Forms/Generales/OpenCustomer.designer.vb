<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenCustomer
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
		Me.components = New System.ComponentModel.Container()
		Me.OpenClientFile = New System.Windows.Forms.OpenFileDialog()
		Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
		Me.ReSize1 = New LarcomAndYoung.Windows.Forms.ReSize(Me.components)
		Me.SuspendLayout()
		'
		'OpenClientFile
		'
		Me.OpenClientFile.DefaultExt = "c11"
		'
		'SaveFileDialog
		'
		'
		'ReSize1
		'
		Me.ReSize1.About = Nothing
		Me.ReSize1.AutoCenterFormOnLoad = False
		Me.ReSize1.Enabled = True
		Me.ReSize1.HostContainer = Me
		Me.ReSize1.InitialHostContainerHeight = 315.0R
		Me.ReSize1.InitialHostContainerWidth = 435.0R
		Me.ReSize1.Tag = Nothing
		'
		'OpenCustomer
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(435, 315)
		Me.ControlBox = False
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "OpenCustomer"
		Me.ShowInTaskbar = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.ResumeLayout(False)

End Sub
  Friend WithEvents OpenClientFile As System.Windows.Forms.OpenFileDialog
		Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
		Friend WithEvents ReSize1 As LarcomAndYoung.Windows.Forms.ReSize

End Class
