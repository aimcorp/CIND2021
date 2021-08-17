Imports System.Configuration
Imports System.Net
Imports System.Web.Services.Protocols
Imports System.Windows.Forms
Imports com.softwarekey.Client.Licensing
Imports com.softwarekey.Client.Utils
Imports com.softwarekey.Client.WebService.XmlActivationService
Imports com.softwarekey.Client.WebService.XmlLicenseService
Imports com.softwarekey.Client.WebService.XmlLicenseFileService
Imports com.softwarekey.Client.WebService.XmlNetworkFloatingService

Namespace ClientLicense
    ''' <summary>Web service helper class, which helps with setting endpoint URLs, proxy server settings, etc...</summary>
    Friend Class WebServiceHelper

#Region "Private Member Variables"
		Private m_ConnectionInformation As InternetConnectionInformation = Nothing
		Private m_ProxyAuthenticationCredentials As NetworkCredential = Nothing
		Private m_LastError As New LicenseError(LicenseError.ERROR_NONE)

		' TODO: If you are using your own domain name (instead of secure.softwarekey.com) for SOLO Server, you should update the default values for these URLs.
		Private m_XmlActivationServiceUrl As String = "https://secure.softwarekey.com/solo/webservices/XmlActivationService.asmx"
		Private m_XmlLicenseServiceUrl As String = "https://secure.softwarekey.com/solo/webservices/XmlLicenseService.asmx"
		Private m_XmlLicenseFileServiceUrl As String = "https://secure.softwarekey.com/solo/webservices/XmlLicenseFileService.asmx"
		Private m_XmlNetworkFloatingServiceUrl As String = "https://secure.softwarekey.com/solo/webservices/XmlNetworkFloatingService.asmx"
#End Region

#Region "Constructors"
''' <summary>Creates a new <see cref="WebServiceHelper"/> object.</summary>
Public Sub New()
Me.Initialize()
End Sub
#End Region

#Region "Private Methods"
	''' <summary>Initializes the connection information object</summary>
	Private Sub Initialize()
					'start by initializing any URL overrides in the app.config file.
					'TODO: This is here as a convenience in the sample applications, and it should be removed!  
											'These values should never be initialized from the app.config file in your application!
					If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("XmlActivationServiceUrl")) Then
									Me.m_XmlActivationServiceUrl = ConfigurationManager.AppSettings("XmlActivationServiceUrl")
					End If

					If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("XmlLicenseServiceUrl")) Then
									Me.m_XmlLicenseServiceUrl = ConfigurationManager.AppSettings("XmlLicenseServiceUrl")
					End If

					If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("XmlLicenseFileServiceUrl")) Then
									Me.m_XmlLicenseFileServiceUrl = ConfigurationManager.AppSettings("XmlLicenseFileServiceUrl")
					End If

					If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("XmlNetworkFloatingServiceUrl")) Then
									Me.m_XmlNetworkFloatingServiceUrl = ConfigurationManager.AppSettings("XmlNetworkFloatingServiceUrl")
					End If

					'now that the URLs are initialized, we can proceed to initialize the connection information:
					'TODO: if you wish to test the connection with your own web site/server, change the timeout
					'      for the test (which is 10 seconds by default), and/or specify a proxy server to use
					'      for the test (none or the system default is used by default), then you should call
					'      the appropriate overload below.
					PIm = CheckConection()
					If PIm = 255 Then Me.m_ConnectionInformation = New InternetConnectionInformation(Me.m_XmlActivationServiceUrl)
		End Sub

	''' <summary>Initializes proxy authentication credentials only when they are not already initialized.</summary>
	''' <returns>Returns true if we have proxy authentication credentials to use.</returns>
	Private Function InitializeProxyAuthenticationCredentials() As Boolean
					If Me.m_ProxyAuthenticationCredentials IsNot Nothing Then
									Return True
					End If

					Return Me.ShowProxyAuthenticationCredentialsDialog()
	End Function

	''' <summary>Shows the proxy authentication credentials dialog to obtain the credentials from the user.</summary>
	''' <returns>Returns true if we got data from the proxy authentication credentials dialog.</returns>
	Private Function ShowProxyAuthenticationCredentialsDialog() As Boolean
					'we don't have any credentials, so let's ask for them...
					Using credentialForm As New ProxyCredentialsForm()
									If DialogResult.OK = credentialForm.ShowDialog() Then
													Me.m_ProxyAuthenticationCredentials = credentialForm.Credentials
													Return True
									End If
					End Using

					Return False
	End Function

	''' <summary>Initializes a web service object.</summary>
	''' <param name="ws">The object which will be used to call web service methods.</param>
	''' <returns>Returns true if the object was initialized and is considered usable.</returns>
Private Function InitializeWebServiceObject(ByRef ws As SoapHttpClientProtocol) As Boolean
Try
  PIm = CheckConection() : If PIm = False Then Exit Function
  If Me.m_ConnectionInformation.ProxyRequired Then
          If Me.m_ConnectionInformation.ProxyAuthenticationRequired Then
                  'this connection requires proxy authentication...
                  If Me.m_ProxyAuthenticationCredentials Is Nothing Then
                          'no proxy authentication credentials have been entered yet, so let's ask for them...
                          Dim done As Boolean = False
                          Dim dialogResult As Boolean = True
                          Do
                                  'clear any credentials entered earlier and ask the user for new credentials
                                  Me.ResetProxyAuthenticationCredentials()
                                  dialogResult = Me.ShowProxyAuthenticationCredentialsDialog()
                                  If Not dialogResult Then
                                          'the user clicked cancel on the dialog
                                          Return False
                                  End If

                                  'cache this info in our proxy object
                                  Me.m_ConnectionInformation.Proxy.Credentials = Me.m_ProxyAuthenticationCredentials

                                  'test the proxy authentication info -- if it fails, we should ask the user for credentials again
                                  done = Me.m_ConnectionInformation.RunTestRequest()
                          Loop While Not done
                  End If
          End If

          'now set the web service object's proxy information
          ws.Proxy = Me.m_ConnectionInformation.Proxy
  End If
Catch
End Try
Return True
End Function
#End Region

#Region "Public Read-Only Properties"
        ''' <summary>The <see cref="InternetConnectionInformation"/> object, which contains data about the application's Internet connectivity.</summary>
        Public ReadOnly Property ConnectionInformation() As InternetConnectionInformation
            Get
                Return Me.m_ConnectionInformation
            End Get
        End Property

        ''' <summary>The <see cref="LicenseError"/> object, containing details about the last error that occurred.</summary>
        Public ReadOnly Property LastError() As LicenseError
            Get
                Return Me.m_LastError
            End Get
        End Property
#End Region

#Region "Public Properties"
        ''' <summary>Contains the username and password credentials used for authenticating with a proxy server (may be null if unused).</summary>
        Public Property ProxyAuthenticationCredentials() As NetworkCredential
            Get
                Return Me.m_ProxyAuthenticationCredentials
            End Get
            Set(ByVal value As NetworkCredential)
                Me.m_ProxyAuthenticationCredentials = value
            End Set
        End Property
#End Region

#Region "Public Methods"
        ''' <summary>Resets/disregards any prior proxy authentication credentials that may have been entered.</summary>
        Public Sub ResetProxyAuthenticationCredentials()
            Me.m_ProxyAuthenticationCredentials = Nothing
        End Sub

        ''' <summary>Gets a new <see cref="XmlActivationService"/> object, which may be used for processing web service methods centered around activation.</summary>
        ''' <returns>Returns a new <see cref="XmlActivationService"/> object.</returns>
        Public Function GetNewXmlActivationServiceObject() As XmlActivationService
            'create the new web service object with our URL
            Dim ws As SoapHttpClientProtocol = New XmlActivationService()
            ws.Url = Me.m_XmlActivationServiceUrl

            If Not Me.InitializeWebServiceObject(ws) Then
                Return Nothing
            End If

            'return the web service object
            Return DirectCast(ws, XmlActivationService)
        End Function

        ''' <summary>Gets a new <see cref="XmlLicenseService"/> object, which may be used for processing web service methods centered retrieving and update SOLO Server's license data.</summary>
        ''' <returns>Returns a new <see cref="XmlLicenseService"/> object.</returns>
        Public Function GetNewXmlLicenseServiceObject() As XmlLicenseService
            'create the new web service object with our URL
            Dim ws As SoapHttpClientProtocol = New XmlLicenseService()
            ws.Url = Me.m_XmlLicenseServiceUrl

            If Not Me.InitializeWebServiceObject(ws) Then
                Return Nothing
            End If

            'return the web service object
            Return DirectCast(ws, XmlLicenseService)
        End Function

        ''' <summary>Gets a new <see cref="XmlLicenseFileService"/> object, which may be used for processing web service methods centered around XML license file calls to SOLO Server.</summary>
        ''' <returns>Returns a new <see cref="XmlLicenseFileService"/> object.</returns>
        Public Function GetNewXmlLicenseFileServiceObject() As XmlLicenseFileService
            'create the new web service object with our URL
            Dim ws As SoapHttpClientProtocol = New XmlLicenseFileService()
            ws.Url = Me.m_XmlLicenseFileServiceUrl

            If Not Me.InitializeWebServiceObject(ws) Then
                Return Nothing
            End If

            'return the web service object
            Return DirectCast(ws, XmlLicenseFileService)
        End Function

        ''' <summary>Gets a new <see cref="XmlNetworkFloatingService"/> object, which may be used for processing web service methods centered around network floating licensing via SOLO Server.</summary>
        ''' <returns>Returns a new <see cref="XmlNetworkFloatingService"/> object.</returns>
        Public Function GetNewXmlNetworkFloatingServiceObject() As XmlNetworkFloatingService
            'create the new web service object with our URL
            Dim ws As SoapHttpClientProtocol = New XmlNetworkFloatingService()
            ws.Url = Me.m_XmlNetworkFloatingServiceUrl

            If Not Me.InitializeWebServiceObject(ws) Then
                Return Nothing
            End If

            'return the web service object
            Return DirectCast(ws, XmlNetworkFloatingService)
        End Function
#End Region
    End Class
End Namespace