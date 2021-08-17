<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadUpdate
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
Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
Me.btnCancel = New System.Windows.Forms.Button()
Me.Label4 = New System.Windows.Forms.Label()
Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
Me.Label3 = New System.Windows.Forms.Label()
Me.Label2 = New System.Windows.Forms.Label()
Me.SuspendLayout()
'
'BackgroundWorker1
'
Me.BackgroundWorker1.WorkerReportsProgress = True
Me.BackgroundWorker1.WorkerSupportsCancellation = True
'
'btnCancel
'
Me.btnCancel.Location = New System.Drawing.Point(439, 118)
Me.btnCancel.Name = "btnCancel"
Me.btnCancel.Size = New System.Drawing.Size(68, 22)
Me.btnCancel.TabIndex = 20
Me.btnCancel.TabStop = False
Me.btnCancel.Text = "Cancel"
Me.btnCancel.UseVisualStyleBackColor = True
'
'Label4
'
Me.Label4.AutoSize = True
Me.Label4.Location = New System.Drawing.Point(12, 92)
Me.Label4.Name = "Label4"
Me.Label4.Size = New System.Drawing.Size(23, 13)
Me.Label4.TabIndex = 17
Me.Label4.Text = "lbl4"
'
'ProgressBar1
'
Me.ProgressBar1.Location = New System.Drawing.Point(12, 66)
Me.ProgressBar1.Name = "ProgressBar1"
Me.ProgressBar1.Size = New System.Drawing.Size(495, 23)
Me.ProgressBar1.TabIndex = 14
'
'Label3
'
Me.Label3.AutoSize = True
Me.Label3.Location = New System.Drawing.Point(12, 9)
Me.Label3.Name = "Label3"
Me.Label3.Size = New System.Drawing.Size(47, 13)
Me.Label3.TabIndex = 13
Me.Label3.Text = "File size:"
'
'Label2
'
Me.Label2.AutoSize = True
Me.Label2.Location = New System.Drawing.Point(12, 36)
Me.Label2.Name = "Label2"
Me.Label2.Size = New System.Drawing.Size(90, 13)
Me.Label2.TabIndex = 12
Me.Label2.Text = "Download speed:"
'
'DownloadUpdate
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.BackColor = System.Drawing.Color.Wheat
Me.ClientSize = New System.Drawing.Size(520, 158)
Me.Controls.Add(Me.btnCancel)
Me.Controls.Add(Me.Label4)
Me.Controls.Add(Me.ProgressBar1)
Me.Controls.Add(Me.Label3)
Me.Controls.Add(Me.Label2)
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
Me.MaximizeBox = False
Me.MinimizeBox = False
Me.Name = "DownloadUpdate"
Me.Text = "Downloading Update"
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
				Friend WithEvents btnCancel As System.Windows.Forms.Button
				Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
