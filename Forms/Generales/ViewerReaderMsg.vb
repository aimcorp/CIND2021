Imports System.IO
Imports System.Net

Public Class ViewerReaderMsg

Private Sub ViewerReaderMsg_Load(sender As Object, e As EventArgs) Handles Me.Load
Panel1.Left = 1 : Panel1.Top = 1 : Panel2.Left = 1 : Panel2.Top = 1
If b = 1 Then Panel1.Visible = True
If b = 2 Then Panel2.Visible = True
Dim mainScreen As Screen = Screen.FromPoint(Me.Location)
Dim X As Integer = (mainScreen.WorkingArea.Width - Me.Width) / 2 + mainScreen.WorkingArea.Left
Dim Y As Integer = (mainScreen.WorkingArea.Height - Me.Height) / 2 + mainScreen.WorkingArea.Top
Me.StartPosition = FormStartPosition.Manual
Me.Location = New System.Drawing.Point(X, Y)
End Sub

Public Function AutoUpdate2(ByRef CommandLine As String, ByVal RemotePath As String) As Boolean
Dim RemoteUri As String = "http://www.aimcorporation.net/DownloadDir/"
PatchFile = "FoxitReader703.0916_enu_Setup.exe"
Try
  Dim myWebClient As New System.Net.WebClient  'the webclient
  System.Diagnostics.Process.Start(RemoteUri & "\" & PatchFile)
Catch ex As Exception
   MsgBox(ex.Message)
   Me.Refresh()
End Try
End Function

Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
AutoUpdate2(b, c)
End Sub

Private Sub bReader_Click(sender As Object, e As EventArgs) Handles bReader.Click, Button2.Click
Compdata.UVoR = "R" : CompdataXmlSave() : UVP = 1 : Me.Dispose()
End Sub

Private Sub btViewer_Click(sender As Object, e As EventArgs) Handles btViewer.Click
Compdata.UVoR = "V" : CompdataXmlSave() : UVP = 2 : Me.Dispose()
End Sub
End Class
