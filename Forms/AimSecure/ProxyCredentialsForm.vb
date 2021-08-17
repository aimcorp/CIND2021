Imports System.Net
Imports System.Windows.Forms

Namespace ClientLicense
    ''' <summary>Proxy server authentication credentials form</summary>
    Partial Public Class ProxyCredentialsForm
        Inherits Form
#Region "Member Variables"
        Private m_Username As String = ""
        Private m_Password As String = ""
#End Region

#Region "Public Method"
        ''' <summary>The proxy authentication credentials entered by the user.</summary>
        Public ReadOnly Property Credentials() As NetworkCredential
            Get
                Return New NetworkCredential(Me.m_Username, Me.m_Password)
            End Get
        End Property
#End Region

#Region "Public Constructor"
        ''' <summary>ProxyCredentialsForm default constructor</summary>
        Public Sub New()
            InitializeComponent()
        End Sub
#End Region

#Region "Event Handlers"
        ''' <summary>Ok button click event handler</summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub okButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            If String.IsNullOrEmpty(Me.usernameTextBox.Text) Then
                MessageBox.Show(Me, "Please enter your username.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.usernameTextBox.Focus()
                Return
            End If

            If String.IsNullOrEmpty(Me.passwordTextBox.Text) Then
                MessageBox.Show(Me, "Please enter your password.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.passwordTextBox.Focus()
                Return
            End If

            Me.m_Username = Me.usernameTextBox.Text
            Me.m_Password = Me.passwordTextBox.Text

            Me.DialogResult = System.Windows.Forms.DialogResult.OK

            Me.Close()
        End Sub

        ''' <summary>Cancel button click event handler</summary>
        ''' <param name="sender">object</param>
        ''' <param name="e">EventArgs</param>
        Private Sub cancelButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub
#End Region
    End Class
End Namespace