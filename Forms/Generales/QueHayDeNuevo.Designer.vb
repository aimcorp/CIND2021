<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueHayDeNuevo
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
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'RichTextBox1
		'
		Me.RichTextBox1.BackColor = System.Drawing.Color.White
		Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.RichTextBox1.Location = New System.Drawing.Point(8, 8)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.Size = New System.Drawing.Size(943, 860)
		Me.RichTextBox1.TabIndex = 1
		Me.RichTextBox1.Text = ""
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.White
		Me.Panel1.Controls.Add(Me.RichTextBox1)
		Me.Panel1.Location = New System.Drawing.Point(5, 7)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(959, 877)
		Me.Panel1.TabIndex = 2
		'
		'QueHayDeNuevo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Crimson
		Me.CausesValidation = False
		Me.ClientSize = New System.Drawing.Size(969, 889)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.MinimizeBox = False
		Me.Name = "QueHayDeNuevo"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "I M P O R T A N T E"
		Me.Panel1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
