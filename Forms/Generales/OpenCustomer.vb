Imports System.IO
Imports System.Windows.Forms

Public Class OpenCustomer
 Private m_clsMRU As New System.Collections.Generic.List(Of String)

 Private Sub OpenCustomer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
  ReSize1.Enabled = True
 End Sub

 Public Sub OpenFileRoutine()
  PlaToCheck = PlaInUse : UdirToCheck = Udir : UPlaToCheck = UPla : NewDir = Udir
  Answer = 0
  MdiMain.UseWaitCursor = True
  OpenClientFile.Reset()
  OpenClientFile.Title = "Abrir Planillas de Clientes"
  OpenClientFile.Filter = "*.cin|*.Cin"
  OpenClientFile.InitialDirectory = Udir
  If OpenClientFile.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then PlaInUse = PlaToCheck : Udir = UdirToCheck : UPla = UPlaToCheck : GoTo 10
  If OpenClientFile.FileName.ToString() = "AimTmp.cin" Then
   MsgId = "ArchivoTmpEnUso" : ErrMsgDialog.ShowDialog()
   PlaInUse = PlaToCheck : Udir = UdirToCheck : UPla = UPlaToCheck : GoTo 10
  End If
  c = OpenClientFile.FileName.ToString()

10:
  MdiMain.UseWaitCursor = False
 End Sub

 Private Sub OpenOrCancel(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenClientFile.FileOk
  If FileToZip <> "" Then SaveFile()
  Me.UseWaitCursor = True : NewDir = Udir
  FileToOpen = OpenClientFile.FileName.ToString()
  'verificar version vieja
  If Mid(FileToOpen, Len(FileToOpen) - 3, 4) <> ".cin" Then
   If Val(Mid(FileToOpen, Len(FileToOpen) - 1, 2)) < 12 Then MsgId = "AbrirCtaAtrasada" : ErrMsgDialog.ShowDialog() : Exit Sub
  End If
  'verificar que no está abierto
  If FileAbierto(FileToOpen) = True Then _
    MsgId = "ArchivoAbierto" : ErrMsgDialog.ShowDialog() : Answer = 90 : Me.UseWaitCursor = False : Exit Sub
  'open new file
  If Not (FileToOpen Is Nothing) Then
   FlagStart = True
   Udir = Path.GetDirectoryName(FileToOpen) : NewDir = Udir : UPla = Path.GetFileName(FileToOpen)
   PlaInUse = Udir & "\" & UPla : FileToZip = UPla
   'reset the rest
   MdiMain.UnloadForms() : ResetForNextPlanilla() : ReadThePlanilla() : MdiMain.LoadFormSet()
   MdiMain.ToolAnoInUse.Text = AnoInUse
   FlagStart = False : Answer = 92
  End If
  Me.UseWaitCursor = False
 End Sub

 Public Sub OpenFileNuevaPlanilla()
  OpenClientFile.Title = "Abrir Planillas de Clientes"
  OpenClientFile.InitialDirectory = Udir
  OpenClientFile.ShowDialog()
 End Sub

 Public Sub SaveClientFile()
  SaveFileDialog.Title = "Salvar la Planilla del Cliente"
  SaveFileDialog.InitialDirectory = Udir
  SaveFileDialog.ShowDialog()
 End Sub

 Public Sub CreateClientFile()
  SaveFileDialog.Title = "Crear la Planilla del Cliente"
  SaveFileDialog.InitialDirectory = Udir
  SaveFileDialog.ShowDialog()
 End Sub

 Private Sub SaveOrCancel(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog.FileOk
  If Flag7 = 102 Then SaveNewFile()
  Me.Close()
 End Sub

 Private Sub SaveNewFile()
  If SaveFileDialog.FileName <> "" Then
   FileToSave = SaveFileDialog.FileName
   Try
    FileSystem.Kill(FileToSave & ".cin")
   Catch ex As Exception
    'do nothing
   End Try
   'parse Dir & Filename
   Udir = Path.GetDirectoryName(FileToSave)
   UPla = Path.GetFileName(FileToSave)
   If InStr(UPla, ".c") = 0 Then UPla = UPla & ".c" & AnoInUse.Substring(AnoInUse.Length - 2, 2)
   AnoInUse = MdiMain.ToolAnoInUse.Text
   ResetForNextPlanilla()
   PlaInUse = Udir & "\" & UPla
   Dim ln As Integer = InStr(UPla, ".") : FileToZip = Mid(UPla, 1, ln) & "cin"
   SaveFile() : SetLastFile() : SetMdiMainFileInfo()
   MdiMain.LoadFormSet()
   Answer = 92
  End If
 End Sub
End Class
