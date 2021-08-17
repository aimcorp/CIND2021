Imports System.Configuration
Imports System.IO
Imports System.Reflection
Imports System.Xml
Imports com.softwarekey.Client.Licensing
Imports com.softwarekey.Client.Utils
Imports com.softwarekey.Client.WebService.XmlActivationService
Imports com.softwarekey.Client.WebService.XmlLicenseFileService

Namespace ClientLicense
    ''' <summary>Implements the <see cref="License"/> class to use read-only licenses.</summary>
    Public Class ClientLicense
        Inherits License
        'ARIEL
#Region "Public Properties"
        Public Property IsIndividualLicense() As Boolean
            Get
                Return m_isIndividual
            End Get
            Set(value As Boolean)
                m_isIndividual = value
            End Set
        End Property
#End Region

#Region " Constants "
  'TODO: Update the Product ID, Envelope Key, Envelope, before using in your own products!
  Private Const m_myProductId As Int32 = 444256
  Private Shared ReadOnly m_EncryptionKey As New AuthorEncryptionKey("EoedPYheMRV1tpMSuUHs9lJ4Mwti9PHU89MF6s8OkhBC0aqvD0S6U454OjQyF1b2",
      "voVu+tvade3C6Fr3Ci4KkTkCUFG9/muPVbXcafphggZEPfcgv6SFTdnMNQgBxsDi5ce5KV8Smq0/DSCnelWsDftYEJ6csnPa0qxPIGEGiEYBmjQLQq/yGdZ3KgyuVgO8iOFi+yLoC6qLGWhMKZ03ocA3qtL8b4jSFfIwsrLG1itmrKsIuLnlgobuHzqTmFdj/Fhm5N7cqUXe" &
      "RmnNz7kLuVGiTlEOJTe4WaM9pRQYuH92vQ1mWcI7XV64OSWbFpt1TRifubLX9BVs3sPtgWNHQusciQx87As0ofVBq5j1hrNmByMzMA+JYCp2RkTRmyHZU8aZWCPZzBeFwXButAomaCPGXD3IGkOjYz2Zv8sQm4RqlVI0vGorXuwhJ9jX8GYoZxX6ZT+d0QDBeY31nfm4GIfT" &
      "NYUbdW+3aco478IzFK2ylX0JYzoElvbQIig5nB+H0uEmXL8t1VI0AoT0x1kqBhxjmQdbcWIivfAGGVVI073aG7Uj69Xvfl6xQq+dyMBecmI4ot6XbUDKNujRpOofNfWlZTe7v9OaPc+naZ2BZo9go9sTGXCZGi3+4MfARB6EB7WTR2WKGb/GIkbpInq8eV9YMIhQEShDbG/y" &
      "av8Uo4zq0IQKrRyyH7ngxWBAOs2zkf96r2Ha4T03deY/tomQW0TfuB2cG8aQNasnBLILQRxY5V4mcDmFxzACX4mpKsPz/whb4yEtPhCO8QLtCHAlYiruddEkOncGSgBQYpYKgWrUsTqWQWFGsCtnuwttF2Wk2bbH29EDVJcoQq4AF1tahceP/WWlRwg3dBuWBXYuXeyjRKmS" &
      "unHuG5GvoUap8qme8qHoyNHvqvbZY5XMnWQxvwWP/kOyFWbNcO6qhtHGiJe8kG4Ll+xPoUdXUXfpnScUwkoGzOfomtBofHhRimkwFEc3UTcRt8seVdpK8ef+dZ83/AZ0PVsRBUIhe4MVNAQ+L6WWCpw3oTlof/DRyLxtc0FzXdTH6hAt/Knt2qjMjdhuB/0fCV1BtpQPuQOE" &
      "opfI29OvMzfWQJ8QPON/ux1Oio8u3m/L2hLA7BSn0c7LbPU38Hhguun311tXW0nbKjdqZE85zmn8lzpietFpiPModJc5060MulqCeSh1r6OeDDmJb30rV54Ge4F04NHS2SRKI0vF3fa38/n5qZRP87JubFN9dUwwizoqWEtyyVKVJmhBmfOTdUJA9Eq5KmGNX+EoLbU+MIHk" &
      "pGacqh5KRb508ZEo/2iFfZx+3nctmlSOz8QTeEkCI0rpDErQ1nTwl947i7va65lI+E7BEJIsMQtFKO1CnxMYUzWmnW6Ej0FLDCczWD+x11gbB0OvhQ1qxs0fz8A0xIr+3VCgnukzRoN9cTt/zzhmRA7GnscImOMiVempLR8w6EczH08X+mg8oqe/PtRirWsUCpFJKCN/X6uo" &
      "02JoocEQGbPiZ7U+aAf/k9I/AmA+LkD3iJClzTaELw5R3yKadkrGny0gotie9hPt0LW2CzVy7AQQWCc8JJyrUOGkYio5wm+BzBYn6NB7E5g+B4uJr4uIDahFjnphM9VrMdyCobHHt4ZovDORm/SnvoGW0vC7cOZfiFsGx/+nSWaf4aw8NWL+CEQ9xZxTPQQ+HIAfnp5jneiE" &
      "wu5Od1ntoOwvftUq+dEQgOdY7RoCXHyOcH9c35gIwo1pGEmhCjR45aJXtapopGAlnjRNCExKkq9HEKkekP6YyKTVIJISqROUy494a5F7d/mhP4Sf1d316sQB6pDEQi+C2J7JYVJgxaXdDrSpuO5N7W/OUQ88KIxA0X4wzsX7Ug/IFGoOtcViBB4aJLPloYn18Oh2VbtX0Yyp" &
      "UcI5LklUUxduijz6y/1lvoE81dqUZrKS/pO55EPlEgNUJItvsHLMjsFWkJHuWUcTqHpiecncI1gi4kugGeS72l2GeBlWNM51iKOzQ8z5MOTL/iWIt4MnmPeRoRNBp+PfiYJHghvBziWvJTH0SA2CxULGIqSbxdFPJ40ZrjDsNECHKY58/8kkgiGf81+qvQkw7vg1IoO9dlDY" &
      "faVv/gAKHcqRtWHspN5S+tYmJe7LiL6eYga8pEDld5QcONX5ZENHX30AIWIHppalWb0bTM3iXsePUnzw2xLtowdbgkXvdg==", False)
  Private Shared m_WebServiceHelper As New WebServiceHelper()
  'When set to true, RefreshLicense will be called every time the application runs.
  Private Const m_RefreshLicenseAlwaysRequired As Boolean = True
        'TODO: Set this value per your licensing requirements!
        '  For example, to attempt to check and refresh the license with SOLO Server every 7 days, set this value to 7.
        Private Const m_RefreshLicenseAttemptFrequency As Int32 = 0

        'TODO: Set this value per your licensing requirements!
        ' For example, to require the license to be checked and refreshed with SOLO Server every 14 days, set this 
        ' value to 14.
        ' Setting this value to zero to allows the application to make RefreshLicense attempts without requiring them.
        Private m_RefreshLicenseRequireFrequency As Int32 = 0

        'TODO: Update the algorithms below as needed for your application's licensing requirements!
        Private Shared ReadOnly Property SystemIdentifierAlgorithms As List(Of SystemIdentifierAlgorithm)
            Get
                If Environment.OSVersion.Platform = PlatformID.Win32NT Then
                    'Algorithms for Windows:
                    Return New List(Of SystemIdentifierAlgorithm)(New SystemIdentifierAlgorithm() {New NicIdentifierAlgorithm(),
                    New ComputerNameIdentifierAlgorithm(),
                    New HardDiskVolumeSerialIdentifierAlgorithm(HardDiskVolumeSerialFilterType.OperatingSystemRootVolume),
                    New BiosUuidIdentifierAlgorithm(),
                    New ProcessorIdentifierAlgorithm(New ProcessorIdentifierAlgorithmTypes() {ProcessorIdentifierAlgorithmTypes.ProcessorName, ProcessorIdentifierAlgorithmTypes.ProcessorVendor, ProcessorIdentifierAlgorithmTypes.ProcessorVersion})})
                End If

                'Algorithms for other platforms:
                'The HardDiskVolumeSerialIdentifierAlgorithm may be added for Linux, but it is not supported in OS X.
                Return New List(Of SystemIdentifierAlgorithm)(New SystemIdentifierAlgorithm() {New NicIdentifierAlgorithm(), New ComputerNameIdentifierAlgorithm()})
            End Get
        End Property
#End Region

#Region " Member Variables "
        Private m_licenseFilePath As String = ""
        Private m_isIndividual As Boolean = False
#End Region

#Region " Constructors "
 ''' <summary>Default ClientLicense constructor</summary>
 Public Sub New(ByVal licenseFilePath As String)
     MyBase.New(m_EncryptionKey, True, True, m_myProductId, IOHelper.GetAssemblyFileVersion _
                         (Assembly.GetEntryAssembly()), SystemIdentifierAlgorithms)

     'NOTE: the two boolean arguments where the base class's constructor is
     ' called above are for using an encrypted License File and encrypting
     ' web service calls, respectively.

     m_licenseFilePath = licenseFilePath
 End Sub
#End Region

#Region " Private Properties "
''' <summary>Whether the Refresh License Attempt is due or not</summary>
Private ReadOnly Property IsRefreshLicenseAttemptDue() As Boolean
    Get
        'Calculate the date difference between signature date and the current date
        Dim dateDiff As TimeSpan = DateTime.UtcNow.Subtract(SignatureDate)

        If (m_RefreshLicenseAlwaysRequired OrElse
                        (m_RefreshLicenseAttemptFrequency > 0 AndAlso
                        (dateDiff.TotalDays > m_RefreshLicenseAttemptFrequency OrElse
                        (m_RefreshLicenseRequireFrequency > 0 AndAlso dateDiff.TotalDays > m_RefreshLicenseRequireFrequency)))) Then
            Return True
        End If
        Return False
    End Get
End Property

'<summary>Whether the Refresh License is Required or not</summary>
Private ReadOnly Property IsRefreshLicenseRequired() As Boolean
    Get
        'Calculate the date difference between signature date and the current date
        Dim dateDiff As TimeSpan = DateTime.UtcNow.Subtract(Me.SignatureDate)

        If (m_RefreshLicenseAlwaysRequired Or (m_RefreshLicenseRequireFrequency > 0 And dateDiff.TotalDays >
                            m_RefreshLicenseRequireFrequency)) Then Return True

        Return False
    End Get
End Property
#End Region

#Region " Public Methods "
''' <summary>Loads a license file and stores the path for later use</summary>
''' <returns>bool</returns>
Public Overloads Function LoadFile() As Boolean
    Return MyBase.LoadFile(m_licenseFilePath)
End Function

''' <summary>Returns true if the license is valid</summary>
''' <returns>bool</returns>
Public Function Validate() As Boolean
    'Refresh the license if date difference is greater than m_RefreshLicenseAttemptFrequency (days).
    If IsRefreshLicenseAttemptDue Then
        'If refresh license fails and date difference is greater than m_RefreshLicenseRequireFrequency (days) set license as invalid.
        If Not RefreshLicense() AndAlso IsRefreshLicenseRequired Then
            Return False
        End If
    End If

    'Create a list of validations to perform.
    Dim validations As New List(Of SystemValidation)

    'Add a validation to make sure there is no active system clock tampering taking place.
    validations.Add(New SystemClockValidation())

    'Validate the Product ID authorized in the license to make sure the license file was issued for this application.
    validations.Add(New LicenseProductValidation(Me, ThisProductID))

    'Add a validation to make sure this system is authorized to use the activated license.  (This implements copy-protection.)
    validations.Add(New SystemIdentifierValidation(AuthorizedIdentifiers, CurrentIdentifiers, SystemIdentifierValidation.REQUIRE_EXACT_MATCH))

    'Run all of the validations (in the order they were added).
    If Not Me.ValidateIdentifiers() Then
        Return False
    End If

    'If we got this far, all validations were successful, so return true to indicate success and a valid license.
    Return True
End Function

Private Function ValidateIdentifiers() As Boolean
Dim formatSerials As Integer = 0
Dim formatSerialMatches As Integer = 0
Dim nics As Integer = 0
Dim nicMatches As Integer = 0
Dim computerNames As Integer = 0
Dim computerNameMatches As Integer = 0
Dim IsBiosMatch As Boolean = False
Dim isProcessorNameMatch As Boolean = False

'calculate the number of authorized identifiers of each type, and calculate how many matches are found
For Each authorizedIdentifier As SystemIdentifier In Me.AuthorizedIdentifiers
    Dim matchingIdentifier As SystemIdentifier = Nothing

    For Each currentIdentifier As SystemIdentifier In Me.CurrentIdentifiers
        'Use the SystemIdentifier class's Equals override method to compare the value hash and type
        If currentIdentifier.Equals(authorizedIdentifier) Then
            'we found a match
            matchingIdentifier = currentIdentifier
            Exit For
        End If
    Next

    'A match was found - update our counters for the match
    Select Case authorizedIdentifier.Type
        Case "NicIdentifier"
            nics += 1
            If Not matchingIdentifier Is Nothing Then nicMatches += 1
        Case "HardDiskVolumeSerialIdentifier"
            formatSerials += 1
            If Not matchingIdentifier Is Nothing Then formatSerialMatches += 1
        Case "ComputerNameIdentifier"
            computerNames += 1
            If Not matchingIdentifier Is Nothing Then computerNameMatches += 1
        Case "BiosUuidIdentifier"
            If Not matchingIdentifier Is Nothing Then IsBiosMatch = True
        Case "ProcessorNameIdentifier"
            If Not matchingIdentifier Is Nothing Then isProcessorNameMatch = True
    End Select
Next

'NEW PARTS 05-07-17
Dim totalIdentifierMatches As Integer
 'total Equipmen
'totalIdentifierMatches = formatSerialMatches + nicMatches + BoolToCount(IsBiosMatch) + BoolToCount(isProcessorNameMatch) + BoolToCount(isProcessorNameMatch)
totalIdentifierMatches = formatSerialMatches + BoolToCount(IsBiosMatch) + BoolToCount(isProcessorNameMatch)
If (totalIdentifierMatches < 1) Then
    LastError = New LicenseError(LicenseError.ERROR_LICENSE_SYSTEM_IDENTIFIERS_DONT_MATCH)
    Return False
End If
Return True
End Function

Private Function BoolToCount(bVal As Boolean) As Integer
    Return If(bVal, 1, 0)
End Function


''' <summary>Activates the license online</summary>
''' <param name="licenseId">Int32</param>
''' <param name="password">string</param>
''' <returns>bool</returns>
Public Overloads Function ActivateOnline(ByVal licenseId As Int32, ByVal password As String) As Boolean
    Dim licenseContent As String = ""

    'initialize the object used for calling the web service method
    Dim ws As XmlActivationService = m_WebServiceHelper.GetNewXmlActivationServiceObject()
    If ws Is Nothing Then
        Me.LastError = m_WebServiceHelper.LastError
        Return False
    End If

    'activate online using our endpoint configuration from app.config
    If Not Me.ActivateInstallationLicenseFile(licenseId, password, ws, licenseContent) Then
        Return False
    End If

    'Load the license into memory.
    If (Me.Load(licenseContent) = False) Then
        Return False
    End If

    'Validate the license
    If (Me.Validate() = False) Then
        Return False
    End If

    'ARIEL
    'Check if this is an Individual License by reading the value from the CustomData of the license
    'if it is present.
    'If it is an Individual license we do not save the license to the application folder.
    'Also, we set our member variable to True for the IsIndividual property
    If String.IsNullOrEmpty(Me.ProductOption.CustomData) = False Then
        Try
            Dim xml As New XmlDocument
            xml.LoadXml(Me.ProductOption.CustomData)
            Dim licenseType As String = String.Empty
            XmlHelper.GetNodeValue(xml, "/*/LicenseType", licenseType)
            If licenseType.Equals("Individual", StringComparison.OrdinalIgnoreCase) Then
                m_isIndividual = True
                Return True
            End If
        Catch
            'Return false if an exception was thrown
            Return False
        End Try
    End If
    'It is not an Individual License so save it and return
    Return Me.SaveLicenseFile(licenseContent)
End Function

''' <summary>Deactivates the installation online</summary>
''' <returns>bool</returns>
Public Function DeactivateOnline() As Boolean
    'initialize the object used for calling the web service method
    Dim ws As XmlActivationService = m_WebServiceHelper.GetNewXmlActivationServiceObject()
    If ws Is Nothing Then
        Me.LastError = m_WebServiceHelper.LastError
        Return False
    End If

    Dim successful As Boolean = Me.DeactivateInstallation(ws)
    If (successful) Then
        File.Delete(m_licenseFilePath)
    End If
    Return successful
End Function

'<summary>Returns true if it successfully refreshes the license file</summary>
'<returns>bool</returns>
Public Overloads Function RefreshLicense() As Boolean
'initialize the object used for calling the web service method
Dim ws As XmlLicenseFileService = m_WebServiceHelper.GetNewXmlLicenseFileServiceObject()
If ws Is Nothing Then
    Return True
End If

Dim licenseContent As String = ""

If Not Me.RefreshLicense(ws, licenseContent) Then
    If Me.LastError.ExtendedErrorNumber = 5010 Or Me.LastError.ExtendedErrorNumber = 5015 Or
                        Me.LastError.ExtendedErrorNumber = 5016 Or Me.LastError.ExtendedErrorNumber = 5017 Then
        File.Delete(m_licenseFilePath)
        Return False
    End If
    Return True
End If

If Not Me.SaveLicenseFile(licenseContent) Then
    Return False
End If
Return True
End Function

'<summary>Saves a new license file to the file system</summary>
Public Function SaveLicenseFile(ByVal lfContent As String) As Boolean
    'try to save the license file to the file system
    Try
        File.WriteAllText(m_licenseFilePath, lfContent)
    Catch ex As Exception
        Me.LastError = New LicenseError(LicenseError.ERROR_COULD_NOT_SAVE_LICENSE, ex)
        Return False
    End Try

    Return True
End Function

#End Region

End Class
End Namespace