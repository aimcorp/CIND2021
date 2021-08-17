Namespace ClientLicense
    Partial Class ProxyCredentialsForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.usernameLabel = New System.Windows.Forms.Label
            Me.okButton = New System.Windows.Forms.Button
            Me.cnclButton = New System.Windows.Forms.Button
            Me.usernameTextBox = New System.Windows.Forms.TextBox
            Me.passwordTextBox = New System.Windows.Forms.TextBox
            Me.passwordLabel = New System.Windows.Forms.Label
            Me.SuspendLayout()
            '
            'usernameLabel
            '
            Me.usernameLabel.AutoSize = True
            Me.usernameLabel.Location = New System.Drawing.Point(12, 15)
            Me.usernameLabel.Name = "usernameLabel"
            Me.usernameLabel.Size = New System.Drawing.Size(58, 13)
            Me.usernameLabel.TabIndex = 0
            Me.usernameLabel.Text = "Username:"
            '
            'okButton
            '
            Me.okButton.Location = New System.Drawing.Point(165, 64)
            Me.okButton.Name = "okButton"
            Me.okButton.Size = New System.Drawing.Size(75, 23)
            Me.okButton.TabIndex = 4
            Me.okButton.Text = "OK"
            Me.okButton.UseVisualStyleBackColor = True
            '
            'cancelButton
            '
            Me.cnclButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.cnclButton.Location = New System.Drawing.Point(246, 64)
            Me.cnclButton.Name = "cancelButton"
            Me.cnclButton.Size = New System.Drawing.Size(75, 23)
            Me.cnclButton.TabIndex = 5
            Me.cnclButton.Text = "Cancel"
            Me.cnclButton.UseVisualStyleBackColor = True
            '
            'usernameTextBox
            '
            Me.usernameTextBox.Location = New System.Drawing.Point(76, 12)
            Me.usernameTextBox.Name = "usernameTextBox"
            Me.usernameTextBox.Size = New System.Drawing.Size(245, 20)
            Me.usernameTextBox.TabIndex = 1
            '
            'passwordTextBox
            '
            Me.passwordTextBox.Location = New System.Drawing.Point(76, 38)
            Me.passwordTextBox.Name = "passwordTextBox"
            Me.passwordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
            Me.passwordTextBox.Size = New System.Drawing.Size(245, 20)
            Me.passwordTextBox.TabIndex = 3
            '
            'passwordLabel
            '
            Me.passwordLabel.AutoSize = True
            Me.passwordLabel.Location = New System.Drawing.Point(14, 41)
            Me.passwordLabel.Name = "passwordLabel"
            Me.passwordLabel.Size = New System.Drawing.Size(56, 13)
            Me.passwordLabel.TabIndex = 2
            Me.passwordLabel.Text = "Password:"
            '
            'ProxyCredentialsForm
            '
            Me.AcceptButton = Me.okButton
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(333, 99)
            Me.Controls.Add(Me.passwordTextBox)
            Me.Controls.Add(Me.passwordLabel)
            Me.Controls.Add(Me.usernameTextBox)
            Me.Controls.Add(Me.cnclButton)
            Me.Controls.Add(Me.okButton)
            Me.Controls.Add(Me.usernameLabel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "ProxyCredentialsForm"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Please enter your proxy authentication credentials:"
            Me.TopMost = True
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private WithEvents usernameLabel As System.Windows.Forms.Label
        Private WithEvents okButton As System.Windows.Forms.Button
        Private WithEvents cnclButton As System.Windows.Forms.Button
        Private WithEvents usernameTextBox As System.Windows.Forms.TextBox
        Private WithEvents passwordTextBox As System.Windows.Forms.TextBox
        Private WithEvents passwordLabel As System.Windows.Forms.Label

    End Class
End Namespace