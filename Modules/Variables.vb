'PROGRAMA INCENTIVOS INDUSTRIALES 
'VERSION 2021 Comenzada 07-02-2021

Imports System.IO
Imports System.Net
Imports System.Environment
Imports System.Net.Mail
Imports System.Runtime.Serialization.Formatters.Binary

Module Variables 'Public Variables ===============================================
 Public FormLastFocus As New ArrayList()
 Public ZipCodesList As New List(Of String)
 Public CodigoIndustrialList As New List(Of String)
 Public Revision As String = My.Application.Info.Version.ToString
 Public PatchDir As String, Crev As Byte, CPos As Byte, Fech1 As String, Fech2 As String, FlagImpDialog As Byte
 Public Rsolution As Boolean, SiWpd As Boolean
 Public Answer As Byte, IndexN As Integer, UVP As Integer 'UVP para usar viewer=1 o pdf reader=0
 Public FileNow As Integer, CuY As Integer, Cux As Integer, Cy1 As Integer, CkInt As Long
 Public Cu0 As Integer, Cu1 As Integer, Cu2 As Integer, Cu3 As Integer, Cu4 As Integer, Cu5 As Integer
 Public Cu6 As Integer, Cu7 As Integer, Cu8 As Integer, Cu9 As Integer, Cu10 As Integer
 Public Cuz As Long, Cub As Integer, Cuc As Integer
 Public PitchUse As Integer, FontUse As String
 Public MargTopF As Integer, MargIzqF As Integer, ib As Integer
 Public MargTopC As Integer, MargIzqC As Integer, Valx As Integer, Ya As Byte
 Public x As Long, y As Long, i As Long, x1 As Boolean, y1 As Long
 Public i2 As Long, i3 As Long, i4 As Long, i5 As Long, Clo As Byte
 Public mt As Integer, mi As Integer, taa As Byte
 Public MargT As Int16, MargL As Int16, MargR As Int16, MargB As Int16
 Public ovL As Int16, ovT As Int16, ovW As Int16, ovH As Int16, PTy As Byte
 Public Flag7 As Integer
 Public CT As Decimal
 'string
 Public AppDir As String, F As String, AnoInUse As String, WDir As String, MsgId As String, FlagStart As Boolean, FlgRes As Boolean
 Public AnyFile As String, CurValue As String
 Public LenToRW As String, VarToRW As String
 Public AreaErr As String, UsePage As String, UsePage2 As String
 Public b As String, b1 As String, c As String, c1 As String, UPla As String, NCo As String, NSo As String, z1 As String, z2 As String
 Public Udir As String, NewDir As String, UltBackDir As String
 Public UNam As String, UCom As String, TipoPapel As String
 Public Word As String, Revar As String, OtraVar As String
 Public NegTipo As String, Dev As String, valor As String, Valor1 As String, Valor2 As String, Valor3 As String
 Public Valor7 As String, Valor8 As String, Valor9 As String, Valor10 As String, Valor11 As String, valor12 As String
 Public PlaInUse As String, prt As String, Demo As String
 Public Mnsj As Byte, PIm As Byte
 Public NomArcUso As String
 'printing
 Public FileToOpen As String, FileToSave As String, FileTemp As String, FileToPrint As String, FileToAdd As String
 Public FileToZip As String
 'variant y otras
 Public UndoVar As Object, ImpAArchivo As Boolean
 Public Ve As Object, Amt As Decimal
 Public SetFlag As Boolean, SetFlag4 As Boolean, SetFlag5 As Byte, FormFlag As Byte, Flagver As Boolean
 Public Flag As Boolean, OrientFlag As Byte, Flag3 As Boolean, FlagM As Integer, FgS As Byte
 Public Flag4 As Boolean, Flag5 As Boolean, Flag6 As Integer, SFlag As Integer, FPrt As Boolean
 Public Valcal As VariantType, ValCal1 As VariantType, ValCal2 As VariantType, ValCal3 As VariantType,
        ValCal4 As VariantType, ValCal5 As VariantType, ValR As Double, Valz As VariantType,
         valcal6 As VariantType, valcal7 As VariantType, valcal8 As VariantType, valcal9 As VariantType
 'para caudal relicto 2011
 Public ValL1@, ValL2@, ValL3@, ValL4@, ValL5@, ValL6@, ValL7@, ValL8@, ValL9@, ValL10@
 Public ValCalx As Single, FlagL As Integer
 Public msg As String, PDFCreatorScaleToPrinter As Boolean
 Public Cae As Boolean, ShowWin As Boolean, ImpresoraT As String, resolution As Long
 'licences for Security
 Public m_licenseFilePath As String
 Public m_license As ClientLicense.ClientLicense
 Public DatosEspFile As String, curityFolder As String, WDataEsp As String

 Public Function App_Path() As String
  Return System.AppDomain.CurrentDomain.BaseDirectory()
 End Function

 Public Sub ReadDiccionarios()
  Dim line As String
  FileTemp = AppDir & "AimCode\aCtasIncentivos.cind"
  If Not System.IO.File.Exists(FileTemp) Then MsgId = "ErrorNoFileNecesarioAlt" : ErrMsgDialog.ShowDialog() : Exit Sub
  Using r As StreamReader = New StreamReader(FileTemp)
   line = r.ReadLine
   Do While (Not line Is Nothing)
    CodigoIndustrialList.Add(line)
    line = r.ReadLine
   Loop
  End Using
GetOut:
 End Sub

 Sub VerifySecLocation()
  'where is programs Files
  b = System.Environment.GetFolderPath(SpecialFolder.ApplicationData)
  DatosEspFile = b & "\AimCorporation\"
  curityFolder = b & "\VarWindowsNoLog\"  'lo cambie de RetroWindows
  WDataEsp = b & "\VarWindowsDataLog\"  'lo cambie de RetroWindows
  m_licenseFilePath = curityFolder & "DsIoc.xml"
  IO.Directory.CreateDirectory(DatosEspFile)
  IO.Directory.CreateDirectory(curityFolder)
  IO.Directory.CreateDirectory(WDataEsp)
 End Sub

 Public Function CheckConection() As Boolean
  Try
   If My.Computer.Network.Ping("secure.softwarekey.com", 200) Then Return True : Exit Function
  Catch ex As Exception
   Return False
  End Try
  Return False
 End Function

 Sub EnviarEscenario()
  WithSendBlaster()
 End Sub

 Sub WithSendBlaster()
  Dim mailTo As New Mail.MailAddress("aimcorp@aimcorporation.net")
  Dim mail As New Mail.MailMessage()
  mail.To.Add(mailTo)
  mail.Subject = "Escenario para Analizar"
  Try
   mail.From = New System.Net.Mail.MailAddress("aimcorp@aimcorporation.net")
   mail.IsBodyHtml = True
  Catch
   MsgId = "VerifyEmail" : ErrMsgDialog.ShowDialog()
   Answer = 90 : Exit Sub
  End Try
  Dim cred As New NetworkCredential("aimcorp@aimsite.com", "roman99")
  AppDir = AppDomain.CurrentDomain.BaseDirectory
  'set archivo de cliente para enviarnos
  Try
   FileClose(FileToLock)
   c = NomArcUso
   mail.Attachments.Add(New Attachment(c))
   Dim mess As String = vbVerticalTab & F & vbVerticalTab & valor & vbVerticalTab & Valor1
   mail.Body = mess
   Dim smtp As New SmtpClient("sendblastersmtp.com", 25025)
   smtp.UseDefaultCredentials = False
   smtp.Credentials = cred
   Answer = 0
   smtp.Send(mail)
   MsgId = "EscEnviado" : ErrMsgDialog.ShowDialog()
  Catch ex As Exception
   MsgId = "PauseNow" : ErrMsgDialog.ShowDialog()
  End Try
 End Sub
End Module
