Imports System
Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization
Imports System.Xml

Public Module FilesDef
 Dim fi As String

 <Serializable()> Public Structure EspecialistaData
  Public EspTitulo As String          'titulo
  Public EspNom As String               'nombre especialista
  Public EspDir1 As String              'dir 1 especialista
  Public EspDir2 As String              'dir 2 especialista
  Public EspMun As String               'mun
  Public EspPais As String              'pais
  Public EspZip As String               'Zona Postal
  Public EspSS As String                  'seg social preparador
  Public EspReg As String               'num registro preparador
  Public EspNomPatr As String       'Nombre del Agencia de Contabilidad
  Public EspSSPatr As String          'seg social patronal
  Public EspCProp As Boolean          'true es cuenta propia / false no lo es
  Public EspUsername As String      'Para EFile Username
  Public EspPassword As String      'Pare EFile Password
  Public EspPTIN As String              'PTin del seguro social
  Public EspTel As String               'Numero Telefono
 End Structure

 <Serializable()>
 Public Class CompDat  'Def Data Compañía Preparadora
  Public CompDir1 As String           'Dirección Línea 1
  Public CompDir2 As String           'Dirección Línea 2
  Public CompCiudad As String       'Dirección Ciudad
  Public CompPais As String           'Dirección Estado
  Public CompZip As String              'Dirección Zip
  Public CompTelV As String           'Teléfono Voz
  Public CompTelF As String           'Teléfono Fax
  Public CompUDir As String           'Ultimo Directorio utilizado
  Public CompUpla As String           'Ultimo Archivo utilizado
  Public CompPrnt As String           'Tipo Impresora
  Public CompTMar As Long               'top margen printer
  Public CompLMar As Long               'left margen printer
  Public CompBMar As Long               'bottom margen printer
  Public CompRMar As Long               'right margen printer
  Public CompNegDet As Integer      'imprimir Anejo Neg Solo | con E |y con Detalles = 0 1 2
  Public CompFont As String           'ultimo font
  Public CompPitch As Byte              'tamano letras
  Public CompUltForm As Byte          'ultima forma 1-csi 2-pmue 3-pat 4-1040 5-corp 6-Inf corp
  Public CompUltAno As String       'ultimo ano en uso
  Public CompTemp As String           'aqui estaban los cuatro archivos, puedo usar para otra cosa
  Public CompCase As Boolean          'utilizar mayusculas o cualquiera False=Mayusculas
  Public CompPrinter As String      'Ultima Impresora utilizada
  'Especialista
  Public EspImpDatos As Boolean   'imprimir o no Datos Esp
  'automatic update
  Public AutoUpdate As Boolean      'True = no verifica al internet false = verifica
  'datos Ini
  Public SalTemp As Byte                      'salvar archivo temp cada
  Public UltBackRes As String           'nombre ultimo para guardar backup (donde se guardo el zip de los escogidos)
  Public UltResDir As String            'folder ultimo que se restuaró
  Public UltBackCli As String                 'nombre ultimo backup
  Public UltBackDir As String                 'Folder ultimo backup
  Public UltDirPDF As String                  'dir archivos salvados PDF
  Public UltimaFormaUsada As String           'Ultima forma que utilizo el usuario si esta en blanco es CSI
  Public PDFCreatorScale As Boolean           'true para scale to fit printer
  Public AimUpdateReady As String             'fecha updates
  Public PlanEspIng As Boolean                'Imp Planilla Ingles o Espanol
  'CRIM
  Public TamCourierCrim As Byte               'fuente de planilla CRIM
  Public CrimFte As String                        'fuente a utilizarce en la planilla del Crim es ARIAL
  Public CrimPtc As Byte                            'pitch a utilizarce en la planilla del Crim es 11,10 o 9
  'imprimir 
  Public ImpSinDet As Boolean                 'imprimir sin detenerse
  Public ImpColor As Boolean                    'true a color False blanco y negro
  Public ImpImpPDFoReader As Byte         'imprimir a Impresora, PDF o Reader
  'labels
  Public LbMarIz As Integer                     'labels sus posiciones
  Public LbMarTp As Integer
  'Anadir al Cuy (mt) y Cux(ml)
  Public MTop As Integer
  Public MLeft As Integer
  'usar teclas keyboard para mover pantallas
  Public UsarTeclas As Boolean
  'salvar por Forma Gastos
  Public GWTop As Long
  Public GWLeft As Long
  'fuente TAMANO
  Public TFu As Int16
  'imp Ingles
  Public IIn As Boolean                             'imprimir en ingles True
  'ult Efile fue como Esp o ind
  Public UEFEoI As Boolean              'True como esp, false como ind
  Public Beta As Integer
  Public UVoR As String                 'usar Viewer ="V" o Reader ="R"
 End Class

#Region "Variables"
 'controls and labels variables
 Dim ZWDir As String, Filesv As String
 Dim varset As String, TipoArray As String, indx As Long
 Public Files_In_Zip As New System.Collections.Generic.List(Of String)
 Public FileToLock As Int32, PlaToCheck As String, UdirToCheck As String, UPlaToCheck As String
 Public Filename As String, Recsize As Long, FileInUse As Integer, Tr As Integer
 Public nbr As String, ses As String

 'Array Datos Generales ========================================================
 Public Compdata As New CompDat()
 Public EspData As New EspecialistaData

 Public Flgv$(8)
 '0 = Cuenta educativa si 50% o todo a uno de los contr
 '1 = Cont Bas Alterna  =0 aplica  =1 no aplica
 '2 = Imprimir .Save AppDir & "\temp.pdf", 2 o 1
 '3 = Para sobretasa especial
 '4 = Para Planilla Soc Esp Ult Accionista en pantalla
 '5 = CSI=Imprimir Todas bal y con W2="1"  sin W2="0"
 '6 = CSI=Cuando viene de anejo E para que recalcule
 '7 = CSI=Anejo ="" one sche but no dg(27) / dg(27)="1"> =0 only one sche for both F =1 Split 50% =2 two sch
 '8 = Ultimo Plan Cualificado utilizado
 Public vt$(0)
 Public Modv$(4)
 '0 = no lista ""

 'ARRAY PLANILLA CONTRIBUCION SOBRE INGRESOS ==========================
 Public LCtr$(35)      'CorpInd 1=Pag1 / 2=Pag2 / 3=Pag3 / 4=Pag4 / 5=C / 6=D / 7=L / 8=R / 9=GI / 10=CI
 'Incentivos Ultimo es AnejoA 27

 '******************* Esto es nuevo 2021 ahora uso una sola para los tres tipos de negocios la razon es que un usuario 
 '                    no va a hacer la misma planilla para entidad condudo de corp inv, soc esp o soc
 'esta es para anejo CI
 Public x1I$(125), x2I$(125), x3I$(125), x4I$(125), x5I$(125)
 Public x1C$(292), x2C$(292) 'depreciacion E y E1 Anejo CI

 '******************* Incentivos Industriales
 Public IiP1$(114), IiES$(144), IiB0$(100), IiT0$(238)
 Public IPx1$(60), IPx2$(60), IPx3$(60), IPx4$(60)

 ', IiP3$(105), IiP4$(110), IiB0$(100), IiB1$(104), IiC0$(154), IiK0$(129), IiK1$(103)
 ' Public IiL0$(340), IiM0$(246), IiM1$(81), IiN0$(386), IiN1$(83), IiO0$(42), IiO1$(42), IiO2$(42), IiO3$(42)
 'Public IiPP$(310), IiT0$(238), IiV0$(386), IiV1$(82), IiW0$(340), IiF0$(50), IiF1$(50), IiF2$(50), IiF3$(50)
 ' Public IiX0$(386), IiX1$(286), IiDa$(310), IiTm$(102), IiY0$(340), IiY1$(205), IiZ0$(340), IiAA$(340), IiCA$(93)
 Public sc6a$(52), sc6b$(52), sc6c$(52), sc6d$(52)


 '******************* Temp Variables to use anywhere
 Public Dat$(55), Tmp0$(1200), Tmp1$(100), vtm$(1200)
 Public Down As Boolean
 Public PatchFile As String
 Public RemoteUri As String
 Public RemotePath As String
#End Region

 Public Function FileAbierto(ByVal sFile As String) As Boolean
  If System.IO.File.Exists(sFile) Then
   Try
    Dim F As Short = FreeFile()
    FileOpen(F, sFile, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.LockReadWrite)
    FileClose(F)
   Catch
    Return True
   End Try
  End If
 End Function

#Region "XML"

 'load xml con Compdata
 Public Function Load(ByVal stream As Stream, ByVal newType As Type) As Object
  Dim serializer As New XmlSerializer(newType)
  Dim newObject As Object = serializer.Deserialize(stream)
  Return newObject
 End Function

 Public Function Load(ByVal filename As String, ByVal newType As Type) As Object
  Dim fileInfo As New FileInfo(filename)
  If fileInfo.Exists = False Then Return System.Activator.CreateInstance(newType)
  Dim stream As New FileStream(filename, FileMode.Open)
  Dim newObject As Object = Load(stream, newType)
  stream.Close()
  Return newObject
 End Function

 Public Sub CreateCompdataXML()
  Udir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\AimCIndData"
  Directory.CreateDirectory(Udir)
  Compdata.CompUDir = Udir : Compdata.CompUpla = " " : Compdata.UltDirPDF = ""
  CompdataXmlSave()
 End Sub

 Public Function CompdataXmlSave()
  Try
   Dim stream As New FileStream(AppDir & "compdata.cind", FileMode.Create)
   ' create a serializer...
   Dim serializer As New XmlSerializer(Compdata.GetType)
   ' save the file...
   serializer.Serialize(stream, Compdata)
   ' close the file...
   stream.Close()
  Catch ex As Exception
   MsgBox(ex.Message)
  End Try
 End Function

#End Region

 Public Sub ReadCompanyDefaults()
  Udir = AppDir : UPla = "" : PlaInUse = "" : Word = ""
  'Verificar si existe compdata.cpw (si no esta, crearlo)
  If Not System.IO.File.Exists(AppDir & "compdata.cind") Then CreateCompdataXML()
  'Check if Stream File has data
  Compdata = Load(AppDir & "compdata.cind", Compdata.GetType)
  'set defaults Dir & Folders
  Udir = Trim(Compdata.CompUDir) : UPla = Trim(Compdata.CompUpla) : PlaInUse = Udir & "\" & UPla
  'get PDFCreator si va a imprimir scale to printer o normal
  PDFCreatorScaleToPrinter = Compdata.PDFCreatorScale
  'set AnoInUse para ano de la ult planilla utilizada  
  AnoInUse = "2020"   'cambiar-anual
  SetFlag4 = True
  'dato esp
  FileTemp = WDataEsp & "\w7DE.chm"
  FileInUse = FreeFile()
  FileOpen(FileInUse, FileTemp, OpenMode.Random, OpenAccess.ReadWrite)
  Try
   FileGet(FileInUse, EspData.EspTitulo)
   FileGet(FileInUse, EspData.EspNom)
   FileGet(FileInUse, EspData.EspDir1)
   FileGet(FileInUse, EspData.EspDir2)
   FileGet(FileInUse, EspData.EspMun)
   FileGet(FileInUse, EspData.EspPais)
   FileGet(FileInUse, EspData.EspZip)
   FileGet(FileInUse, EspData.EspSS)
   FileGet(FileInUse, EspData.EspReg)
   FileGet(FileInUse, EspData.EspNomPatr)
   FileGet(FileInUse, EspData.EspSSPatr)
   FileGet(FileInUse, EspData.EspCProp)
   FileGet(FileInUse, EspData.EspUsername)
   FileGet(FileInUse, EspData.EspPTIN)
   FileGet(FileInUse, EspData.EspTel)
  Catch
   FileClose(FileInUse)
   MdiMain.ImprimirDatosEsp.Checked = False : GoTo 220
  End Try
  FileClose(FileInUse)
  If Compdata.EspImpDatos = True Then MdiMain.ImprimirDatosEsp.Checked = True Else MdiMain.ImprimirDatosEsp.Checked = False

220:  'autoupdate
  If Compdata.AutoUpdate = True Then MdiMain.NoUpdatesAuto.Checked = True

  'Se anade a los margenes de cada Cuy y Cux 
  mt = Compdata.MTop : mi = Compdata.MLeft

  'Fuentes para el programa
  FontUse = "Courier New" : PitchUse = 9

  'Verificar si existe impresora escogida para este prog Si No Salvar la Imp Default
  prt = Trim(Compdata.CompPrinter)
  If prt = Nothing Then
   Dim prtr As New PrintDocument
   Dim strDefaultPrinter As String = prtr.PrinterSettings.PrinterName
   prt = strDefaultPrinter : Compdata.CompPrinter = prt
   CompdataXmlSave()
  End If
 End Sub

 Sub SetMdiMainFileInfo()
  MdiMain.Text = "Planilla en Uso> " & UPla
  MdiMain.StatusBarArcEnUso.Text = NomArcUso
 End Sub

 Function ShrinkLongFilepath(ByVal LongPath As String, ByVal EllipsesAtEnd As Boolean, Optional ByVal DesiredLength As Integer = 15, Optional ByVal AlwaysDisplayFilename As Boolean = False) As String
  Dim ReturnPath, StartPath, EndPath, FileName As String

  'DESIRED LENGTH MUST BE AT LEAST 15
  If DesiredLength < 15 Then DesiredLength = 15

  'STRIPS ONLY THE FILENAME
  FileName = LongPath.Substring(LongPath.LastIndexOf("\"), LongPath.Length - LongPath.LastIndexOf("\"))

  If AlwaysDisplayFilename Then
   If FileName.Length + 3 < DesiredLength Then
    'ELLIPSES WILL BE IN THE MIDDLE
    StartPath = LongPath.Substring(0, (DesiredLength / 2) - 3)
    EndPath = LongPath.Substring(StartPath.Length, DesiredLength - StartPath.Length)
    ReturnPath = StartPath & "..." & FileName
   Else
    ReturnPath = "..." & FileName
   End If
  Else
   If EllipsesAtEnd Then 'IF ELLIPSES AT END OF FILEPATH
    ReturnPath = LongPath.Substring(0, DesiredLength - 3)
    ReturnPath &= "..."
   Else  'ELLIPSES WILL BE IN THE MIDDLE
    If LongPath.Length < DesiredLength Then
     StartPath = LongPath.Substring(0, LongPath.IndexOf("\") + 1)
     EndPath = LongPath.Substring(StartPath.Length + 3, LongPath.Length - (StartPath.Length + 3))
     ReturnPath = StartPath & "..." & EndPath
    Else
     StartPath = LongPath.Substring(0, LongPath.IndexOf("\") + 1)
     EndPath = LongPath.Substring(StartPath.Length + 3, DesiredLength - (StartPath.Length + 3))
     ReturnPath = StartPath & "..." & EndPath
    End If
   End If
  End If
  Return ReturnPath
 End Function

 Sub SetLastFile()
  'Set Nombre del archivo en archivo de Data Usuario
  Compdata.CompUDir = Udir : Compdata.CompUpla = FileToZip
  CompdataXmlSave()
 End Sub

 Public Sub ResetForNextPlanilla()
  ReDim Flgv$(8)
  ReDim vt$(0)
  'ARRAY PLANILLA CONTRIBUCION SOBRE INGRESOS ==========================
  ReDim LCtr$(35) 'CorpInd 1=Pag1 / 2=Pag2 / 3=Pag3 / 4=Pag4 / 5=C / 6=D / 7=L / 8=R / 9=GI / 10=CI

  'esta es para anejo CI (ver explicacion en public para esta variable)
  ReDim x1I$(125), x2I$(125), x3I$(125), x4I$(125), x5I$(125)
  ReDim x1C$(292), x2C$(292) 'depreciacion E y E1 Anejo CI

  '******************* Incentivos Industriales
  ReDim IiP1$(114), IiES$(144), IiB0$(100), IiT0$(238)
  ReDim IPx1$(60), IPx2$(60), IPx3$(60), IPx4$(60)
  ', IiP3$(105), IiP4$(110), IiB1$(104), IiC0$(154), IiK0$(129), IiK1$(103)
  ' ReDim IiL0$(340), IiM0$(246), IiM1$(81), IiN0$(386), IiN1$(83), IiO0$(42), IiO1$(42), IiO2$(42), IiO3$(42)
  ' ReDim IiPP$(310), IiT0$(238), IiV0$(386), IiV1$(82), IiW0$(340), IiF0$(50), IiF1$(50), IiF2$(50), IiF3$(50)
  ' ReDim IiX0$(386), IiX1$(286), IiDa$(310), IiTm$(102), IiY0$(340), IiY1$(205), IiZ0$(340), IiAA$(340), IiCA$(93)
  ' ReDim sc6a$(52), sc6b$(52), sc6c$(52), sc6d$(52)
  'Array Datos reusables ========================================================
  ReDim Dat$(55)
  ReDim Tmp0$(1200), Tmp1$(100), vtm$(1200)
 End Sub

 Sub LockFileToZip()
  FileToLock = FreeFile()
  FileOpen(FileToLock, Udir & "\" & FileToZip, OpenMode.Binary)
 End Sub

 Sub CheckLockFile()
  FileClose(FileToLock)
  Try
   FileToLock = FreeFile()
   FileOpen(FileToLock, PlaInUse, OpenMode.Binary)
   FileClose(FileToLock)
  Catch
   Answer = 90 : PlaInUse = PlaToCheck : Udir = UdirToCheck : UPla = UPlaToCheck
  End Try
 End Sub

 Public Sub ReadThePlanilla()
  PlaToCheck = PlaInUse : UdirToCheck = Udir : UPlaToCheck = UPla
  CheckLockFile() : If Answer = 90 Then Exit Sub
  ReadZipCPN()
 End Sub

 Sub ReadZipCPN()
  Try
   ZWDir = AppDir & "UnZ"
   If My.Computer.FileSystem.DirectoryExists(ZWDir) Then My.Computer.FileSystem.DeleteDirectory(ZWDir, FileIO.DeleteDirectoryOption.DeleteAllContents)
  Catch
  End Try
  IO.Directory.CreateDirectory(ZWDir)
  FileToOpen = PlaInUse : NomArcUso = PlaInUse
  FileToZip = Path.GetFileName(FileToOpen)  'esta la pongo para MRU
  ZipReadFiles()
  fi = ZWDir & "\FileDir"
  Using r As StreamReader = New StreamReader(fi)
   F = r.ReadLine
   r.Close()
  End Using
  PlaInUse = ZWDir & "\" & F : UPla = Path.GetFileName(PlaInUse) 'lo requiero por si el archivo a usar es ext .cin (para cambiarle la ext)
  'read la planilla ultima abierta
  SetMdiMainFileInfo()
  ReadNow()
  Try
   ZWDir = AppDir & "UnZ"
   If My.Computer.FileSystem.DirectoryExists(ZWDir) Then My.Computer.FileSystem.DeleteDirectory(ZWDir, FileIO.DeleteDirectoryOption.DeleteAllContents)
  Catch
  End Try
  LockFileToZip()
 End Sub

 Sub ResetCPNalAnoCorrecto()
  'create Tmp folder 
  Try
   c = AppDir & "UnZTmp"
   If My.Computer.FileSystem.DirectoryExists(c) Then My.Computer.FileSystem.DeleteDirectory(c, FileIO.DeleteDirectoryOption.DeleteAllContents)
  Catch
  End Try
  Try
   Directory.Delete(c)
  Catch
  End Try
  IO.Directory.CreateDirectory(c)
  'copy files except the CPN
  Dim r As String = "1", Rname As String, FileToChange As String
  For i3 As Integer = 0 To Files_In_Zip.Count - 1
   If Right(Files_In_Zip(i3), 3) <> "opn" Then ib = ZWDir & "\" & Files_In_Zip(i3) : FileCopy(ib, c & "\" & Files_In_Zip(i3))
   If Right(Files_In_Zip(i3), 3) = "opn" Then
    FileToChange = ZWDir & "\" & Files_In_Zip(i3)
    Rname = Path.GetFileNameWithoutExtension(FileToChange) & b : If IO.File.Exists(c & "\" & Rname) = False Then GoTo 16
14: Rname = Path.GetFileNameWithoutExtension(FileToChange) & "-" & r & b
    If IO.File.Exists(ZWDir & "\" & Rname) Then r += 1 : GoTo 14
16: FileCopy(FileToChange, c & "\" & Rname)
   End If
  Next
  'actualizar el FileDir
  SaveCPNLastUsedFile(Rname)
  FileCopy(ZWDir & "\FileDir", c & "\FileDir")
  'borrar el Tmp original para copiar el UnzTmp
  Try
   ZWDir = AppDir & "UnZ"
   If My.Computer.FileSystem.DirectoryExists(ZWDir) Then My.Computer.FileSystem.DeleteDirectory(ZWDir, FileIO.DeleteDirectoryOption.DeleteAllContents)
  Catch
  End Try
  FileIO.FileSystem.RenameDirectory(c, "Unz")
  Dim zipFName As String = Udir & "\" & FileToZip
  Dim fileNames As String() = Directory.GetFiles(ZWDir)
  Using zip As Ionic.Zip.ZipFile = New Ionic.Zip.ZipFile
   zip.AddDirectory(ZWDir)
   zip.Save(zipFName)
   zip.Dispose()
  End Using
  Try
   ZWDir = AppDir & "UnZ"
   If My.Computer.FileSystem.DirectoryExists(ZWDir) Then My.Computer.FileSystem.DeleteDirectory(ZWDir, FileIO.DeleteDirectoryOption.DeleteAllContents)
  Catch
  End Try
  IO.Directory.CreateDirectory(ZWDir)
  PlaInUse = Udir & "\" & FileToZip
  ZipReadFiles()
  PlaInUse = ZWDir & "\" & Rname : UPla = Path.GetFileName(PlaInUse)
 End Sub

 Sub ZipReadFiles()
  Files_In_Zip.Clear()
  Dim iozip As Ionic.Zip.ZipFile = New Ionic.Zip.ZipFile(PlaInUse)
  Dim UnpackDir As String = ZWDir
  For Each ZipEntry In iozip
   ZipEntry.Extract(UnpackDir, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently)
   If ZipEntry.FileName <> "FileDir" Then Files_In_Zip.Add(ZipEntry.FileName)
  Next
  iozip.Dispose() : Answer = 0
 End Sub

 Sub ZipFileCPN()
  Try 'borrar contenido de folder de Zip
   ZWDir = AppDir & "UnZ"
   If My.Computer.FileSystem.DirectoryExists(ZWDir) Then My.Computer.FileSystem.DeleteDirectory(ZWDir, FileIO.DeleteDirectoryOption.DeleteAllContents)
  Catch
  End Try
  Try   'borrar el folder UnZ
   Directory.Delete(ZWDir)
  Catch
  End Try
  IO.Directory.CreateDirectory(ZWDir)
  If FlgRes = False Then PlaInUse = Udir & "\" & FileToZip Else PlaInUse = AppDir & "AimTmp.cpo"
  ZipReadFiles()
  FileCopy(Filesv, ZWDir & "\" & UPla)
  Try
   FileSystem.Kill(Filesv)
  Catch ex As Exception
   MsgBox(ex.Message) : Exit Sub
  End Try
  If Flag7 <> 302 Then SaveCPNLastUsedFile(UPla) Else SaveCPNLastUsedFile(valor12)
  ZipFiles(ZWDir, FileToZip)
 End Sub

 Sub ZipFiles(ByVal sDir As String, ByVal sFile As String)
  File.Delete(Udir & "\" & FileToZip)
  If NewDir <> "" Then Udir = NewDir : NewDir = ""
  Dim zipFName As String = Udir & "\" & FileToZip
  Dim fileNames As String() = Directory.GetFiles(sDir)
  Using zip As Ionic.Zip.ZipFile = New Ionic.Zip.ZipFile
   zip.AddDirectory(sDir)
   zip.Save(zipFName)
   zip.Dispose()
  End Using
  'Eliminar folder temp Unz
  If My.Computer.FileSystem.DirectoryExists(ZWDir) Then My.Computer.FileSystem.DeleteDirectory(ZWDir, FileIO.DeleteDirectoryOption.DeleteAllContents)
 End Sub

 Sub CrearCopiaPlanilla(nf As String)
  SaveFile() : FileClose(FileToLock)
  Directory.CreateDirectory(ZWDir)
  PlaInUse = Udir & "\" & FileToZip
  ZipReadFiles()
  nf = nf & ".o" & Right(AnoInUse, 2)
  My.Computer.FileSystem.RenameFile(ZWDir & "\" & UPla, nf)
  FileCopy(ZWDir & "\" & nf, ZWDir & "\" & UPla)
  UPla = nf : SaveCPNLastUsedFile(UPla) : SetMdiMainFileInfo()
  ZipFiles(ZWDir, FileToZip)
 End Sub

 Sub CrearCopiaPlanillaCambioAno()
  FileClose(FileToLock) : Directory.CreateDirectory(ZWDir)
  PlaInUse = Udir & "\" & FileToZip : ZipReadFiles()
  Dim nf As String = UPla : nf = Left(nf, Len(nf) - 2) & Right(AnoInUse, 2)
  My.Computer.FileSystem.RenameFile(ZWDir & "\" & UPla, nf)
  FileCopy(ZWDir & "\" & nf, ZWDir & "\" & UPla)
  UPla = nf : SaveCPNLastUsedFile(UPla) : SetMdiMainFileInfo()
  ZipFiles(ZWDir, FileToZip)
 End Sub

 Sub SaveCPNLastUsedFile(ByRef f As String)
  Dim Document As String = f
  Dim mf As New System.IO.FileStream(ZWDir & "\FileDir", System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None)
  Dim mywriter As New System.IO.StreamWriter(mf)
  mywriter.WriteLine(Document)
  mywriter.Close() : mf.Close()
 End Sub

 Sub ReadNow()
  Dim varset As String, TipoArray As String, indx As Long : Flag = False
  If Not System.IO.File.Exists(PlaInUse) Then Exit Sub
  'leer planilla
  FileInUse = FreeFile()
  FileOpen(FileInUse, PlaInUse, OpenMode.Binary, OpenAccess.ReadWrite)
  Dim unavez As Boolean = False
  Try
   Do While Not EOF(FileInUse)
    'leer version del programa
    LenToRW = Space$(3) : VarToRW = ""
    FileGet(1, LenToRW) : varset = Val(LenToRW)
    VarToRW = Space$(varset) : FileGet(1, VarToRW)
    If VarToRW = "" Then Exit Do
    If unavez = False Then AnoInUse = Right(VarToRW, 4) : unavez = True : If Val(AnoInUse) = 0 Then AnoInUse = 2021 'cambiar-anual
    'buscar que tipo de array es
    TipoArray = Left(VarToRW, 3)
    'Incentivos Ind
    If Left(TipoArray, 2) = "Ii" Then If Mid(VarToRW, 5, Len(VarToRW) - 4) = "" Then VarToRW = VarToRW & " " : GoTo 280
    If Left(TipoArray, 2) = "IP" Then If Mid(VarToRW, 5, Len(VarToRW) - 4) = "" Then VarToRW = VarToRW & " " : GoTo 280

280:                        'buscar que tipo de array es
    TipoArray = Left(VarToRW, 3) : indx = 0
    If Left(TipoArray, 2) = "Ii" Then TipoArray = Left(VarToRW, 4)
    If Left(TipoArray, 2) = "IP" Then TipoArray = Left(VarToRW, 4)

    Select Case TipoArray
  'datos gen ===================================
     Case "dat"
      Do
       If Dat(indx) = "" Then Dat(indx) = Mid(VarToRW, 4, Len(VarToRW) - 3) : GoTo BackToTop
       indx = indx + 1 : If indx > UBound(Dat) Then Exit Do
      Loop

  'Incentivos Industriales =================================
     Case "IiP1"
      Do
       If IiP1(indx) = "" Then IiP1(indx) = Mid(VarToRW, 5, Len(VarToRW) - 4) : GoTo BackToTop
       indx = indx + 1 : If indx > UBound(IiP1) Then Exit Do
      Loop
     Case "IiP2"
      Do
       If IiES(indx) = "" Then IiES(indx) = Mid(VarToRW, 5, Len(VarToRW) - 4) : GoTo BackToTop
       indx = indx + 1 : If indx > UBound(IiES) Then Exit Do
      Loop

       ''''Detalle 1
     Case "IPx1"
      Do
       If IPx1(indx) = "" Then IPx1(indx) = Mid(VarToRW, 5, Len(VarToRW) - 4) : GoTo BackToTop
       indx = indx + 1 : If indx > UBound(IPx1) Then Exit Do
      Loop
     Case "IPx2"
      Do
       If IPx2(indx) = "" Then IPx2(indx) = Mid(VarToRW, 5, Len(VarToRW) - 4) : GoTo BackToTop
       indx = indx + 1 : If indx > UBound(IPx2) Then Exit Do
      Loop
     Case "IPx3"
      Do
       If IPx3(indx) = "" Then IPx3(indx) = Mid(VarToRW, 5, Len(VarToRW) - 4) : GoTo BackToTop
       indx = indx + 1 : If indx > UBound(IPx3) Then Exit Do
      Loop
     Case "IPx4"
      Do
       If IPx4(indx) = "" Then IPx4(indx) = Mid(VarToRW, 5, Len(VarToRW) - 4) : GoTo BackToTop
       indx = indx + 1 : If indx > UBound(IPx4) Then Exit Do
      Loop

      'SC 6042 =====================================
      'Case "s6a"
      ' Do
      '  If sc6a(indx) = "" Then sc6a(indx) = Mid(VarToRW, 4, Len(VarToRW) - 3) : GoTo BackToTop
      '  indx = indx + 1 : If indx > UBound(sc6a) Then Exit Do
      ' Loop
      'Case "s6b"
      ' Do
      '  If sc6b(indx) = "" Then sc6b(indx) = Mid(VarToRW, 4, Len(VarToRW) - 3) : GoTo BackToTop
      '  indx = indx + 1 : If indx > UBound(sc6b) Then Exit Do
      ' Loop
      'Case "s6c"
      ' Do
      '  If sc6c(indx) = "" Then sc6c(indx) = Mid(VarToRW, 4, Len(VarToRW) - 3) : GoTo BackToTop
      '  indx = indx + 1 : If indx > UBound(sc6c) Then Exit Do
      ' Loop
      'Case "s6d"
      ' Do
      '  If sc6d(indx) = "" Then sc6d(indx) = Mid(VarToRW, 4, Len(VarToRW) - 3) : GoTo BackToTop
      '  indx = indx + 1 : If indx > UBound(sc6d) Then Exit Do
      ' Loop

    End Select
BackToTop:
   Loop
  Catch ex As Exception
   FileClose(FileInUse)
   x = indx
   'Stop
   'MsgBox(ex.Message)

   MsgId = "ErroconFile" : ErrMsgDialog.ShowDialog()
   Compdata.CompUpla = " " : CompdataXmlSave()
   Application.Restart() : Exit Sub
  End Try

  FileClose(FileInUse)
  TrimVariables()
 End Sub

 Public Sub SaveFile()
  If UPla = "" Then Exit Sub
  MdiMain.UseWaitCursor = True
  Try
   Filesv = AppDir & "TmpSav"
   FileSystem.Kill(Filesv)
  Catch ex As Exception
   'no existe FileSv continua
  End Try
  Try 'abrir archivo
   FileInUse = FreeFile()
   FileOpen(FileInUse, Filesv, OpenMode.Binary, OpenAccess.ReadWrite)
   SaveThePlanilla()
   FileClose(FileToLock)
   ZipFileCPN() : SetLastFile() : LockFileToZip()
  Catch ex As Exception
   'MsgBox(ex.Message)
  End Try
  MdiMain.UseWaitCursor = False
 End Sub

 Private Sub SaveThePlanilla()     'final de este modulo buscar 'FinSavePlanilla
  Dim i As Integer
  'Salvar Ano Comienzo
  VarToRW = "ver" & AnoInUse : BytesLen()
  FilePut(FileInUse, LenToRW) : FilePut(FileInUse, VarToRW)

  'Datos Generales ===============================================
  For i = 0 To UBound(Dat$)
   VarToRW = "dat" & Dat$(i) : BytesLen()
   FilePut(FileInUse, LenToRW) : FilePut(FileInUse, VarToRW)
  Next

  'Incentivos Industriales ================================
  For i = 0 To UBound(IiP1$)
   VarToRW = "IiP1" & IiP1(i) : BytesLen()
   FilePut(FileInUse, LenToRW) : FilePut(FileInUse, VarToRW)
  Next
  For i = 0 To UBound(IiES)
   VarToRW = "IiP2" & IiES(i) : BytesLen()
   FilePut(FileInUse, LenToRW) : FilePut(FileInUse, VarToRW)
  Next
  ''''Detalle 
  For i = 0 To UBound(IPx1)
   VarToRW = "IPx1" & IPx1(i) : BytesLen()
   FilePut(FileInUse, LenToRW) : FilePut(FileInUse, VarToRW)
  Next
  For i = 0 To UBound(IPx2)
   VarToRW = "IPx2" & IPx2(i) : BytesLen()
   FilePut(FileInUse, LenToRW) : FilePut(FileInUse, VarToRW)
  Next
  For i = 0 To UBound(IPx3)
   VarToRW = "IPx3" & IPx3(i) : BytesLen()
   FilePut(FileInUse, LenToRW) : FilePut(FileInUse, VarToRW)
  Next
  For i = 0 To UBound(IPx4)
   VarToRW = "IPx4" & IPx4(i) : BytesLen()
   FilePut(FileInUse, LenToRW) : FilePut(FileInUse, VarToRW)
  Next

  'SC6042 =====================================================================
  'For i = 0 To UBound(sc6a)
  ' VarToRW = "s6a" & sc6a(i) : BytesLen()
  ' FilePut(FileInUse, LenToRW) : FilePut(FileInUse, VarToRW)
  'Next
  'For i = 0 To UBound(sc6b)
  ' VarToRW = "s6b" & sc6b(i) : BytesLen()
  ' FilePut(FileInUse, LenToRW) : FilePut(FileInUse, VarToRW)
  'Next
  'For i = 0 To UBound(sc6c)
  ' VarToRW = "s6c" & sc6c(i) : BytesLen()
  ' FilePut(FileInUse, LenToRW) : FilePut(FileInUse, VarToRW)
  'Next
  'For i = 0 To UBound(sc6d)
  ' VarToRW = "s6d" & sc6d(i) : BytesLen()
  ' FilePut(FileInUse, LenToRW) : FilePut(FileInUse, VarToRW)
  'Next
  FileClose(FileInUse)
 End Sub

 Public Sub TrimVariables()                            'veriain FINISHFOROTHER
  Dim i As Int16
  For i = 0 To UBound(Dat) : Dat(i) = Trim(Dat(i)) : Next
  'Incentivos Industriales ================================
  For i = 0 To UBound(IiP1) : IiP1(i) = Trim(IiP1(i)) : Next
  For i = 0 To UBound(IiES) : IiES(i) = Trim(IiES(i)) : Next
  For i = 0 To UBound(IPx1) : IPx1(i) = Trim(IPx1(i)) : Next
  For i = 0 To UBound(IPx2) : IPx2(i) = Trim(IPx2(i)) : Next
  For i = 0 To UBound(IPx3) : IPx3(i) = Trim(IPx3(i)) : Next
  For i = 0 To UBound(IPx4) : IPx4(i) = Trim(IPx4(i)) : Next

  'SC6042 ==========================================================
  For i = 0 To UBound(sc6a) : sc6a(i) = Trim(sc6a(i)) : Next
  For i = 0 To UBound(sc6b) : sc6b(i) = Trim(sc6b(i)) : Next
  For i = 0 To UBound(sc6c) : sc6c(i) = Trim(sc6c(i)) : Next
  For i = 0 To UBound(sc6d) : sc6d(i) = Trim(sc6d(i)) : Next
 End Sub

 Public Sub UnzipFile(ByVal sDir As String, ByVal sFile As String)
  Dim iozip As Ionic.Zip.ZipFile = New Ionic.Zip.ZipFile(sDir)
  Dim UnpackDir As String = AppDir & "AimPr"
  c = sFile
  If System.IO.File.Exists(sDir) = False Then _
        MsgId = "ZipFaltaArchivoForma" : ErrMsgDialog.ShowDialog() : Answer = 255 : Exit Sub
  For Each ZipEntry In iozip
   'Extract File
   If ZipEntry.Info.Contains(sFile) Then
    Try
     ZipEntry.Extract(UnpackDir, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently) : Answer = 0 : Exit Sub
    Catch
    End Try
   End If
  Next
  Answer = 255
 End Sub

 Public Sub VerifyIfYearChanged()  'si la planilla original es de un ano difernte
  SaveFile()
  'primero verificar que no exista ya una planilla para ese ano
  ib = AnoInUse
  FileClose(FileToLock) : Directory.CreateDirectory(ZWDir)
  c = Udir & "\" & FileToZip
  Dim nf As String = ".o" & Right(MdiMain.ToolAnoInUse.Text, 2)
  Dim iozip As Ionic.Zip.ZipFile = New Ionic.Zip.ZipFile(c)
  Dim UnpackDir As String = ZWDir
  For Each ZipEntry In iozip
   ZipEntry.Extract(UnpackDir, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently)
   If Right(ZipEntry.FileName, 4) = Right(nf, 4) Then
    Try
     ZWDir = AppDir & "UnZ"
     If My.Computer.FileSystem.DirectoryExists(ZWDir) Then My.Computer.FileSystem.DeleteDirectory(ZWDir, FileIO.DeleteDirectoryOption.DeleteAllContents)
    Catch
    End Try
    MdiMain.ToolAnoInUse.Text = AnoInUse
    iozip.Dispose() : Answer = 0 : MsgId = "YaExistePlanCreada" : ErrMsgDialog.ShowDialog() : Exit Sub
   End If
  Next
  iozip.Dispose() : Answer = 0
  Try
   ZWDir = AppDir & "UnZ"
   If My.Computer.FileSystem.DirectoryExists(ZWDir) Then My.Computer.FileSystem.DeleteDirectory(ZWDir, FileIO.DeleteDirectoryOption.DeleteAllContents)
  Catch
  End Try
  'cambiar-anual
  If MdiMain.Text <> "Ninguna Planilla Abierta" Then
   MsgId = "NuevoAño" : ErrMsgDialog.ShowDialog()
   If Answer = 1 Then Answer = 255 : Exit Sub
   'create nueva en el mismo .cpn
   AnoInUse = MdiMain.ToolAnoInUse.SelectedItem
   'clean var
   'finish corp y otros
   CrearCopiaPlanillaCambioAno()
  End If
 End Sub
End Module
