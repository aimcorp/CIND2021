Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing.Color
Imports System.Runtime.Serialization.Formatters.Binary
Imports com.softwarekey.Client.Licensing
Imports System.Net
Imports System.Net.Mail
Imports BackupPrj

Public Class MdiMain

 Dim FlagSet As Int16
 Private m_clsMRU As New System.Collections.Generic.List(Of String)

#Region "LoadUnloadMdiMain"

 Private Sub MDIMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown
  If UPla = "" Then NuevaPlanillaDlg.ShowDialog()
 End Sub

 Private Sub MdiMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
  If Answer = 255 Then e.Cancel = True : Exit Sub
  'save file worked
  If FlgRes = True Then MsgId = "SalvarConOtroNombre2" : ErrMsgDialog.ShowDialog() : e.Cancel = True : Exit Sub

  SaveFile() : If Answer = 255 Then e.Cancel = True : Exit Sub
  FileClose(FileToLock)
  'Delete PDF Dir (son los archivos PDF de imprimir)
  Try
   Dim sDir = AppDir & "AimPr"
   If System.IO.Directory.Exists(sDir) Then System.IO.Directory.Delete(sDir, True)
  Catch
  End Try
  Try
   Dim sMru = AppDir & "mruList.dll"
   'save MRU - delete existing file...
   If System.IO.File.Exists(sMru) Then System.IO.File.Delete(sMru)
   ' write each item to the file...
   For Each sPath As String In m_clsMRU
    If System.IO.File.Exists(sPath) Then System.IO.File.AppendAllText(sMru, sPath & vbCrLf)
   Next
  Catch
  End Try
  Application.ExitThread()
 End Sub

 Private Sub MdiMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  FlagStart = True
  'get Path y Datos de usuario
  AppDir = App_Path.ToString
  'dir de Windows
  WDir = Environment.GetEnvironmentVariable("windir")
  'Patches
  PatchDir = AppDir & "Patches" : PatchFile = "cind2021update.exe"
  'read Codigo Ocupacional
  ReadDiccionarios()
  'set Locations Sec
  VerifySecLocation()
  'read Company Defaults
  ReadCompanyDefaults()
  'para impresion a reader o viewer
  If Compdata.UVoR <> Nothing Then
   If Compdata.UVoR = "R" Then UVP = 1 'reader
   If Compdata.UVoR = "V" Then UVP = 2 'viewer
  End If
  'read mru List
  OpenMruList()
  'read ultima planilla
  Me.Text = "Ninguna Planilla Abierta"
  Me.StatusBarArcEnUso.Text = "Ninguno"
  'in case plainuse was erased by other means
  If Not File.Exists(PlaInUse) Then UPla = "" Else NomArcUso = PlaInUse
  If UPla <> "" Then ReadThePlanilla()
  If UPla = "" Then AnoInUse = 2020 'cambiar-anual
  Me.ToolAnoInUse.Text = AnoInUse

  'Planillas no listas   'BefCompile
  Modv$(1) = ""  'incentivos
  Modv$(2) = "1"  'fideicomisos

  LoadFormSet()
  ToolStripRevision.Text = "Build " & Revision
  Panel1.BringToFront()
  SetFlag4 = False : FlagStart = False
 End Sub

 Public Sub LoadFormSet()
  TSIncentivos.Visible = False : TSFideicomisos.Visible = False
  If Compdata.UltimaFormaUsada = Nothing Or Compdata.UltimaFormaUsada = "IncentivosInd" Then ToolIncentivosInd()
 End Sub

#End Region

#Region "Menu and Button Click"

 Private Sub TSBtnAcerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaToolStripMenuItem.Click
  SplashScreen1.ShowDialog()
 End Sub

 Public Sub OpenFileDePlanilla()
  OpenCustomer.OpenFileRoutine()
  Me.Cursor = Cursors.Default
 End Sub

 Private Sub Tool1AbrirPla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool1AbrirPla.Click
  If FlgRes = True Then MsgId = "SalvarConOtroNombre" : ErrMsgDialog.ShowDialog() : If Answer = 0 Then Exit Sub
  AbrirPlanillas()
 End Sub

 Private Sub AbrirPlanillas()
  Dim npla As String = Udir & "\" & FileToZip : OpenFileDePlanilla()
  If Answer = 92 Then Answer = 0 : AddToMRU(npla) : MruEraseIfActual() : FlgRes = False
  Tool1AbrirPla.Checked = False
 End Sub

 Private Sub ToolSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSalvar.Click
  SaveFile()
 End Sub

 Private Sub ToolSalvarComo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSalvarComo.Click
  If FlgRes = True Then
   SaveFile()
   OpenCustomer.SaveClientFile()
   If FileToSave <> "" Then SaveWithNewName()
   Exit Sub
  End If
  Flag7 = 229 : NuevaPlanillaDlg.ShowDialog()
 End Sub

 Private Sub SaveWithNewName()
  If GetRight(FileToSave, 3) <> "cpo" Then FileToSave = FileToSave & ".cpo"
  Try
   FileSystem.Kill(FileToSave)
  Catch
  End Try
  Try
   Dim FileTmp As String = AppDir & "AimTmp.cpo"
   FileCopy(FileTmp, FileToSave)
   Udir = Path.GetDirectoryName(FileToSave)
   PlaInUse = Udir & "\" & UPla : NomArcUso = FileToSave : FileToZip = Path.GetFileName(FileToSave)
   SetLastFile() : SetMdiMainFileInfo()
   FlgRes = False
  Catch
  End Try
 End Sub

 Private Sub Tool1Nueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool1Nueva.Click
  If FlgRes = True Then MsgId = "SalvarConOtroNombre" : ErrMsgDialog.ShowDialog() : If Answer = 0 Then Exit Sub
  NuevaPlanilla()
 End Sub

 Public Sub NuevaPlanilla()
  If FlgRes = True Then MsgId = "SalvarConOtroNombre" : ErrMsgDialog.ShowDialog() : If Answer = 0 Then Exit Sub
  Flag7 = 102 : OpenCustomer.CreateClientFile()
  Tool1Nueva.Checked = False
 End Sub

#Region "ToolLoad"

 Public Sub ToolIncentivosInd()
  SetInvisibleAllToolbars() : FillIncentivosFocus() : DeHighlightTools()
  TSIncentivos.Visible = True : ToolIncentivos.Checked = True
  If Answer = 240 Then Exit Sub
  Answer = 156
  Dim IncPage1 As New IncentPagina1 : IncPage1.MdiParent = Me : IncPage1.Show()
  Answer = 0
  'cambiar-anual  OJO cambiar todas las demas de este tipo
  If Modv$(1) = "1" And AnoInUse = 2021 Then MsgId = "PlaNoList" : ErrMsgDialog.ShowDialog()
 End Sub

#End Region

 Private Sub SetInvisibleAllToolbars()
  If Compdata.UltimaFormaUsada = "IncentivosInd" Then TSIncentivos.Visible = True
  For i = 0 To UBound(LCtr) : LCtr(i) = "0" : Next
 End Sub

 Public Sub UnloadForms()
  If TSIncentivos.Visible = True Then DeHighlightTabInUseInc()
  CloseAllForms()
 End Sub

#End Region

 Private Sub CloseAllForms()
  If Not Me.MdiChildren Is Nothing Then
   Dim f As System.Windows.Forms.Form
   For Each f In Me.MdiChildren
    f.Close()
   Next
  End If
 End Sub

#Region "DeHightLightTools"

 Public Sub DeHighlightTools()
  With Me
   .ToolIncentivos.Checked = False : .ToolFideicomisos.Checked = False : ToolIndividuos.Checked = False : ToolCorporaciones.Checked = False
  End With
 End Sub

 Public Sub DeHighlightTabInUseInc()
  With Me
   .tbIncPag1.Checked = False : .tbEstSit.Checked = False : .tbIncPag3.Checked = False
   .tbIncB.Checked = False : .tbIncB1.Checked = False : .tbIncC.Checked = False : .tbIncF.Checked = False
   .tbIncK.Checked = False : .tbIncK1.Checked = False : .tbIncL.Checked = False : .tbIncM.Checked = False
   .tbIncM1.Checked = False : .tbIncN.Checked = False : .tbIncN1.Checked = False : .tbIncO.Checked = False
   .tbIncO.Checked = False : .tbIncP.Checked = False : .tbIncT.Checked = False : .tbIncV.Checked = False
   .tbIncV.Checked = False : .tbIncV1.Checked = False : .tbIncW.Checked = False : .tbIncX.Checked = False
   .tbIncX1.Checked = False : .tbIncD.Checked = False : .tbIncY.Checked = False : .tbIncY1.Checked = False
   .tbIncZ.Checked = False : tbIncAA.Checked = False : tbSC6042.Checked = False : tbIncCA.Checked = False
  End With
 End Sub

#End Region

#Region "FillFocus"

 Public Sub FillIncentivosFocus()
  FormLastFocus.Clear()
  FormLastFocus.Add("tbNomNeg")                   '0 - Página 1 (Parte I)
  FormLastFocus.Add("tbESA01")                    '1 - Estado Situacion
  FormLastFocus.Add("tbESA01")                    '2 - Detalle 1
  FormLastFocus.Add("tbESA01")                    '3 - Detalle 1
  FormLastFocus.Add("tbESA01")                    '4 - Detalle 1
  FormLastFocus.Add("tbESA01")                    '5 - Detalle 1


 End Sub

 Private Sub FillEstadoFocus()
  FormLastFocus.Clear()
  FormLastFocus.Add("tbFinEfec")
 End Sub

#End Region

#Region "OpenPagesIncentivos"
 Private Sub ToolIncentivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolIncentivos.Click
  If Compdata.UltimaFormaUsada = "IncentivosInd" Then Exit Sub
  DeHighlightTabInUseInc() : ToolIncentivosInd()
 End Sub

 Private Sub tbEstSit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbEstSit.Click
  If UsePage = "IndEstadoSit" Then Exit Sub
  UnloadForms()
  If Answer = 240 Then Exit Sub
  Answer = 156
  Dim IncES As New EstadoSituacion20 : IncES.MdiParent = Me : IncES.Show()
  Answer = 0
 End Sub

 Private Sub tbIncPag3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncPag3.Click
  If UsePage = "IncentivosPag3" Then Exit Sub
  UnloadForms()
  'Dim IncPag3 As New IncentPagina3 : IncPag3.MdiParent = Me : IncPag3.Show()
 End Sub

 Private Sub tbIncCA_Click(sender As System.Object, e As System.EventArgs) Handles tbIncCA.Click
  If UsePage = "IncentivosAnejoCA" Then Exit Sub
  UnloadForms()
  Answer = 156
  Answer = 0
 End Sub

 Private Sub tbIncAA_Click(sender As System.Object, e As System.EventArgs) Handles tbIncAA.Click
  If UsePage = "IncentivosAnejoAA" Then Exit Sub
  UnloadForms()
  Answer = 156
  Answer = 0
 End Sub

 Private Sub tbIncB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncB.Click
  If UsePage = "IncentivosAnejoB" Then Exit Sub
  UnloadForms()
  Dim IncB As New AnejoB : IncB.MdiParent = Me : IncB.Show()
 End Sub

 Private Sub tbIncB1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncB1.Click
  If UsePage = "IncentivosAnejoB1" Then Exit Sub
  Answer = 156
  UnloadForms()

  Answer = 0
 End Sub

 Private Sub tbIncC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncC.Click
  If UsePage = "IncentivosAnejoCR" Then Exit Sub
  Answer = 156
  UnloadForms()

  Answer = 0
 End Sub

 Private Sub tbIncD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncD.Click
  If UsePage = "CorpAnejoD" Then Exit Sub
  Answer = 156
  UnloadForms()
  Answer = 0
 End Sub

 Private Sub tbIncF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncF.Click
  If UsePage = "IncentivosAnejoF" Then Exit Sub
  UnloadForms()
 End Sub

 Private Sub tbIncK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncK.Click
  If UsePage = "IncentivosAnejoK" Then Exit Sub
  UnloadForms()

 End Sub

 Private Sub tbIncK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncK1.Click
  If UsePage = "IncentivosAnejoK1" Then Exit Sub
  UnloadForms()

 End Sub

 Private Sub tbIncL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncL.Click
  If UsePage = "IncentivosAnejoL" Then Exit Sub
  Answer = 156
  UnloadForms()

  Answer = 0
 End Sub

 Private Sub tbIncM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncM.Click
  If UsePage = "IncentivosAnejoM" Then Exit Sub
  UnloadForms()

 End Sub

 Private Sub tbIncM1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncM1.Click
  If UsePage = "IncentivosAnejoM1" Then Exit Sub
  UnloadForms()

 End Sub

 Private Sub tbIncN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncN.Click
  If UsePage = "IncentivosAnejoN" Then Exit Sub
  Answer = 156
  UnloadForms()

  Answer = 0
 End Sub

 Private Sub tbIncN1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncN1.Click
  If UsePage = "IncentivosAnejoN1" Then Exit Sub
  UnloadForms()

 End Sub

 Private Sub tbIncO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncO.Click
  If UsePage = "IncentivosAnejoO" Then Exit Sub
  UnloadForms()

 End Sub

 Private Sub tbIncP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncP.Click
  If UsePage = "IncentivosAnejoP" Then Exit Sub
  Answer = 156
  UnloadForms()

  Answer = 0
 End Sub

 Private Sub tbIncT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncT.Click
  If UsePage = "IncentivosAnejoT" Then Exit Sub
  Answer = 156
  UnloadForms()

  Answer = 0
 End Sub

 Private Sub tbIncV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncV.Click
  If UsePage = "IncentivosAnejoV" Then Exit Sub
  Answer = 156
  UnloadForms()

  Answer = 0
 End Sub

 Private Sub tbIncV1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncV1.Click
  If UsePage = "IncentivosAnejoV1" Then Exit Sub
  UnloadForms()

 End Sub

 Private Sub tbIncW_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncW.Click
  If UsePage = "IncentivosAnejoW" Then Exit Sub
  UnloadForms()

 End Sub

 Private Sub tbIncX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncX.Click
  If UsePage = "IncentivosAnejoX" Then Exit Sub
  Answer = 156
  UnloadForms()

  Answer = 0
 End Sub

 Private Sub tbIncX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncX1.Click
  If UsePage = "IncentivosAnejoX1" Then Exit Sub
  Answer = 156
  UnloadForms()

  Answer = 0
 End Sub

 Private Sub tbIncY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncY.Click
  If UsePage = "IncentivosAnejoY" Then Exit Sub
  UnloadForms()

 End Sub

 Private Sub tbIncY1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncY1.Click
  If UsePage = "IncentivosAnejoY1" Then Exit Sub
  UnloadForms()

 End Sub

 Private Sub tbIncZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIncZ.Click
  If UsePage = "IncentivosAnejoZ" Then Exit Sub
  UnloadForms()

 End Sub

 Private Sub tbSC6042_Click(sender As System.Object, e As System.EventArgs) Handles tbSC6042.Click
  If UsePage = "IncentivosSC6042" Then Exit Sub
  UnloadForms()
  Dim FSC6042 As New SC6042 : FSC6042.MdiParent = Me : FSC6042.Show()
 End Sub

#End Region

 Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
  System.Diagnostics.Process.Start("http://www.aimsite.com/index.php")
 End Sub

 Private Sub ToolProgAimsite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolProgAimsite.Click
  System.Diagnostics.Process.Start("http://www.aimcorporation.net")
 End Sub

 Private Sub ToolProgForum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolProgForum.Click
  System.Diagnostics.Process.Start("http://www.aimsite.com/index.php")
 End Sub

 Private Sub Tool1ImprimirForma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  If Demo = "Si" And SiWpd = False Then
   MsgId = "EsUnDemo" : ErrMsgDialog.ShowDialog()
   If Answer = 1 Then System.Diagnostics.Process.Start("http://www.aimcorporation.net/productos/")
   Exit Sub
  End If
  If Compdata.UltimaFormaUsada = "EstadoSituacion" Then
   MsgId = "ErrorEstSituacionNoPrint" : ErrMsgDialog.ShowDialog()
   Exit Sub
  End If
  If Me.Text = "Ninguna Planilla Abierta" Then Exit Sub
  If Compdata.UVoR = Nothing Then Dim vrinfo As New ViewerReaderMsg : b = 1 : vrinfo.ShowDialog()
  If Compdata.UVoR = "R" Then UVP = 1
  If Compdata.UVoR = "V" Then UVP = 2
  Imprimir.Dispose() : Imprimir.ShowDialog()
 End Sub

 Private Sub ToolStripCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
  If FlagSet = True Then Exit Sub
  'If ToolStripCombo.SelectedIndex = 1 Then RazonesNoRadicacion()
  'If ToolStripCombo.SelectedIndex = 2 Then PoderRepresentante()
  'If ToolStripCombo.SelectedIndex = 3 Then SolicitudNumeroPat()
  'If ToolStripCombo.SelectedIndex = 4 Then PowerAttorneyP()
 End Sub

 Private Sub EntrarDatosEspecialistaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntrarDatosEspecialistaToolStripMenuItem.Click
  DatosEsp.Dispose()
  DatosEsp.ShowDialog()
 End Sub

 Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
  DatosEsp.Dispose()
  DatosEsp.ShowDialog()
 End Sub

 Private Sub QuéHayDeNuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuéHayDeNuevoToolStripMenuItem.Click
  QueHayDeNuevo.ShowDialog()
 End Sub

 Private Sub ImprimirDatosEsp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirDatosEsp.Click
  If SetFlag4 = True Then Exit Sub
  With EspData
   If ImprimirDatosEsp.Checked = False Then
    If .EspNom = "" Or .EspDir1 = "" Or .EspMun = "" Or .EspPais = "" Or .EspZip = "" Or
             .EspReg = "" Then MsgId = "ImpDatosEsp" : ErrMsgDialog.ShowDialog() : SetFlag4 = True _
    : ImprimirDatosEsp.Checked = False : Compdata.EspImpDatos = False : SetFlag4 = False : Exit Sub
   End If
  End With
  If ImprimirDatosEsp.Checked = False Then ImprimirDatosEsp.Checked = True : Compdata.EspImpDatos = True : Exit Sub
  If ImprimirDatosEsp.Checked = True Then ImprimirDatosEsp.Checked = False : Compdata.EspImpDatos = False : Exit Sub
 End Sub

 Private Sub ToolProgUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolProgUpdate.Click
  i2 = 0
  UpdateNow()
  If i2 = 255 Then MsgId = "GeAutoUpdateMasRec" : ErrMsgDialog.ShowDialog() : i2 = 0
 End Sub

#Region "MRU"
 Sub OpenMruList()
  Dim sMru = AppDir & "mruList.dll"
  ' load MRU...
  If (System.IO.File.Exists(sMru)) Then
   ' read file into array...
   Dim sPaths() As String = System.IO.File.ReadAllLines(sMru)
   ' work through each item...
   For Each sPath As String In sPaths
    ' only add items that are not empty...
    If Not String.IsNullOrEmpty(sPath) Then
     ' only add files that still exist...
     If System.IO.File.Exists(sPath) Then
      ' add to mru...
      m_clsMRU.Add(sPath)
     End If
    End If
   Next
  End If
  ' display MRU if there are any items to display...
  If m_clsMRU.Count > 0 Then UpdateMRU()
 End Sub

 Public Sub AddToMRU(ByVal Path As String)
  c = Path
  If m_clsMRU.Contains(Path) Then m_clsMRU.Remove(Path)
  m_clsMRU.Add(Path)
  While m_clsMRU.Count > 10
   m_clsMRU.RemoveAt(0)
  End While
  UpdateMRU()
 End Sub

 Sub UpdateMRU() ' clear MRU menu items...
  Dim clsItems As New System.Collections.Generic.List(Of ToolStripItem)
  For Each clsMenu As ToolStripItem In ToolStripMRUBut.DropDownItems
   If Not clsMenu.Tag Is Nothing Then _
             If (clsMenu.Tag.ToString().StartsWith("MRU:")) Then clsItems.Add(clsMenu)
  Next
  ' iterate through list and remove each from menu...
  For Each clsMenu As ToolStripItem In clsItems
   ToolStripMRUBut.DropDownItems.Remove(clsMenu)
  Next
  For iCounter As Integer = m_clsMRU.Count - 1 To 0 Step -1
   Dim sPath As String = m_clsMRU(iCounter)
   Dim clsItem As New ToolStripMenuItem(System.IO.Path.GetFileName(sPath))
   If System.IO.File.Exists(sPath) Then
    clsItem.Tag = "MRU:" & sPath
    ToolStripMRUBut.DropDownItems.Insert(ToolStripMRUBut.DropDownItems.Count, clsItem)
   End If
20: Next
 End Sub

 Sub ToolStripMRUBut_DropDownItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStripMRUBut.DropDownItemClicked
  'verify file called exist
  Dim c2 = Mid(e.ClickedItem.Tag, 5, 255) : c2 = Trim(c2)
  If Not System.IO.File.Exists(c2) Then
   MsgId = "MruNoExiste" : ErrMsgDialog.ShowDialog()
   b = PlaInUse : PlaInUse = c2 : MruEraseIfActual() : PlaInUse = b : UpdateMRU()
   Exit Sub
  End If
  'abrir archivo de MRU
  SaveFile()
  AddToMRU(Udir & "\" & FileToZip) : c = Mid(e.ClickedItem.Tag, 5, 255) : c = Trim(c) : FileToOpen = c : mruOpenFile()
  MruEraseIfActual()
 End Sub

 Sub MruEraseIfActual()
  For Each clsMenu As ToolStripItem In ToolStripMRUBut.DropDownItems
   c = Mid(clsMenu.Tag, 5, 255) : c = Trim(c)
   If (c = PlaInUse) Then ToolStripMRUBut.DropDownItems.Remove(clsMenu) : Exit For
  Next
 End Sub

 Sub mruOpenFile()
  FlagStart = True
  Udir = Path.GetDirectoryName(FileToOpen)
  UPla = Path.GetFileName(FileToOpen)
  PlaInUse = Udir & "\" & UPla
  'reset the rest
  UnloadForms() : ResetForNextPlanilla() : ReadThePlanilla() : SetLastFile() : LoadFormSet()
  ToolAnoInUse.Text = AnoInUse
  FlagStart = False
 End Sub
#End Region

 Private Sub RegistrationOpen(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
  ClientLicense.frmRegistracion.ShowDialog()
  If Demo = "No" Then ToolStripButton1.Visible = False
 End Sub

 Private Sub MenuDesactivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDesactivar.Click
  ClientLicense.frmDesactivar.ShowDialog()
 End Sub

 Private Sub UpdateNow()
  Dim MyAutoUpdate As New AutoUpdate
  Dim RemotePath As String = "http://www.aimcorporation.net/Patches"
  Dim CommandLine As String = ""
  If MyAutoUpdate.AutoUpdate(CommandLine, RemotePath) Then Exit Sub
 End Sub

 Sub ToolAnoInUse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolAnoInUse.SelectedIndexChanged
  If FlagStart = True Then Exit Sub
  If AnoInUse = ToolAnoInUse.SelectedItem Then Exit Sub
  'cambiar-anual
  VerifyIfYearChanged()
  Dim ano As String = AnoInUse
  If Answer = 255 Then FlagStart = True : Answer = False : ToolAnoInUse.Text = ano
  AnoInUse = ToolAnoInUse.Text
  If AnoInUse >= 2015 Then ToolCorporaciones.Visible = True
  LoadFormSet()
  FlagStart = False
 End Sub

 Private Sub NoUpdatesAuto_Click(sender As System.Object, e As System.EventArgs) Handles NoUpdatesAuto.Click
  'set off automatic update
  If Compdata.AutoUpdate = True Then Compdata.AutoUpdate = False : NoUpdatesAuto.Checked = False : GoTo 22
  If Compdata.AutoUpdate = False Then Compdata.AutoUpdate = True : NoUpdatesAuto.Checked = True
22:   'save autoupdate
  CompdataXmlSave()
 End Sub

 Private Sub ToolAbrirMismo_DropDownOpening(sender As System.Object, e As System.EventArgs) Handles ToolAbrirMismo.DropDownOpening
  'buscar planillas del mismo ano del mismo cliente
  ToolAbrirMismo.DropDownItems.Clear()
  If Files_In_Zip.Count - 1 > -1 Then
   For i As Integer = 0 To Files_In_Zip.Count - 1
    If UPla <> Files_In_Zip(i) Then ToolAbrirMismo.DropDownItems.Add(Files_In_Zip(i))
   Next
  End If
 End Sub

 Private Sub ToolAbrirMismo_DropDownItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolAbrirMismo.DropDownItemClicked
  'abrir planillas del mismo ano del mismo cliente
  valor12 = e.ClickedItem.Text
  Flag7 = 302 : SaveFile() : Flag7 = 0
  UPla = e.ClickedItem.Text
  ResetForNextPlanilla() : ReadThePlanilla() : LoadFormSet()
  ToolAnoInUse.Text = AnoInUse
  If AnoInUse >= 2015 Then
   'ToolSociedad.Visible = True : ToolSociedadSep.Visible = True
   'ToolSocEsp.Visible = True : ToolSocEspSep.Visible = True
  End If
  FlagStart = False
 End Sub

 Private Sub ToolMenuSalirSinSalvar_Click(sender As Object, e As EventArgs) Handles ToolMenuSalirSinSalvar.Click
  MsgId = "SalirSinSalvar" : ErrMsgDialog.ShowDialog()
  If Answer = 0 Then Application.ExitThread()
 End Sub

 Private Sub ToolStripRestore_Click(sender As Object, e As EventArgs) Handles ToolStripRestore.Click
  If Compdata.UltBackRes <> Nothing Then c = Compdata.UltBackRes Else c = "c:\" 'UltBackRes es a donde se salvó el .zip con los escogidos
  If Compdata.UltResDir <> Nothing Then b = Compdata.UltResDir Else b = "c:\" 'UltResDir es a donde restuararon los archivos
15:
  Dim bc As New BackupPrj.frmBackupRestore
  bc.SetFilePathRes(c, b) : bc.SetRestoreForm() : bc.ShowDialog() : c = bc.GetLastResDir
  If c <> "" Then Compdata.UltResDir = c : CompdataXmlSave() 'UltBackRes es a donde se salvó el .zip con los escogidos
 End Sub

 Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
  If Compdata.UltBackDir <> Nothing Then c = Compdata.UltBackDir Else c = "c:\" 'donde se encontraban los archivos de planillas
  FileClose(FileToLock)
  Dim bc As New BackupPrj.frmBackupRestore
  bc.SetFilePath(c) : bc.SetBackupForm() : bc.ShowDialog() : c = bc.GetLastDir : b = bc.GetLastSaveDir
  If c <> "" Then Compdata.UltBackDir = c : Compdata.UltBackRes = b : CompdataXmlSave() 'UltBackRes es a donde se salvó el .zip con los escogidos
 End Sub

 Private Sub mEnviarEsc_Click(sender As Object, e As EventArgs) Handles mEnviarEsc.Click
  Panel1.Visible = True : tb01.Focus()
 End Sub

 Private Sub UsarViewerOPDFReaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsarViewerOPDFReaderToolStripMenuItem.Click
  Dim vrinfo As New ViewerReaderMsg : b = 1 : vrinfo.ShowDialog()
 End Sub

 Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
  If tb01.Text = "" Then GoTo 22
  If tb02.Text = "" Then GoTo 22
  If rich01.Text = "" Then GoTo 22
  F = tb02.Text : valor = tb01.Text : Valor1 = Trim(rich01.Text)
  EnviarEscenario() : If Answer = 90 Then Exit Sub
  Panel1.Visible = False
  Exit Sub

22:
  MsgId = "FaltaInfEnviarEscenario"
  ErrMsgDialog.ShowDialog() : tb01.Focus()
 End Sub

 Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click
  Panel1.Visible = False
 End Sub

#Region "Security"

 Private Sub VerifySecurity()
  Timer3.Enabled = False
  Demo = "Si"
  Dim m_license As New ClientLicense.ClientLicense(m_licenseFilePath)
  If Not m_license.LoadFile() Then Demo = "Si" Else Demo = "No"
  If PIm = 255 And Demo = "No" Then Flag7 = m_license.Validate() : If Flag7 = False Then Demo = "Si"
  If Demo = "Si" Then ToolStripButton1.Visible = True : ToolStripStatusVersion.Text = "Versión Demo"
  If Demo = "No" Then MenuDesactivar.Visible = True : ToolStripSeparator78.Visible = True : ToolStripButton1.Visible = False : ToolStripStatusVersion.Text = "Versión Completa"
 End Sub

 Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
  'hack
  If System.IO.File.Exists(WDir & "\yds.tuo") Then SiWpd = True : Timer3.Enabled = False : Demo = "No" : Exit Sub

  'Detener el update si es una copia nueva o ha bajado un update
  'en lo que ve lo que dice el "Que hay de nuevo"
  If System.IO.File.Exists(AppDir & "\aupd.cind") Then
   Dim FiUpd As String = AppDir & "aupd.cind"
   If System.IO.File.Exists(FiUpd) Then
    Dim Upd As String
    Using r As StreamReader = New StreamReader(FiUpd)
     Upd = r.ReadLine
    End Using
    Timer3.Enabled = False
    If Upd = "True" Then QueHayDeNuevo.ShowDialog()
    System.IO.File.Delete(FiUpd) : FiUpd = Nothing
    Timer3.Enabled = True
   End If
  End If

  VerifySecurity()
  If Demo = "off" Then Timer3.Enabled = False : Exit Sub

  'salir si no quiere update automatico
  If Compdata.AutoUpdate = True Then Timer3.Enabled = False : Exit Sub
  'first verify internet for update
  Cae = CheckConection() : If Cae = True Then UpdateNow()
  Timer3.Enabled = False
 End Sub

 Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
  Me.CloseAllForms() : Me.Close() : Me.Dispose() : Application.ExitThread()
 End Sub

 Private Sub tbIncPag1_Click(sender As Object, e As EventArgs)

 End Sub
#End Region
End Class
