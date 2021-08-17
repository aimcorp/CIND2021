Imports System.IO
Imports System.Net

Public Class AutoUpdate
 Public sfile As String = "cind2021update.txt" 'Cambiar con Applicacion

 Public Function AutoUpdate(ByRef CommandLine As String, ByVal RemotePath As String) As Boolean
  ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
  Dim Key As String = "&**#@!" ' any unique sequence of characters
  Dim AssemblyName As String = System.Reflection.Assembly.GetEntryAssembly.GetName.Name
  Dim RemoteUri As String = RemotePath & "/"
  CommandLine = Replace(Microsoft.VisualBasic.Command(), Key, "")
  Directory.CreateDirectory(PatchDir)
  If InStr(Microsoft.VisualBasic.Command(), Key) > 0 Then
   Try
    System.IO.File.Delete(PatchDir & "\" & PatchFile)
   Catch ex As Exception
   End Try
   Return False

  Else

   Dim ret As Boolean = False    ' Default – no update needed
   Try
    Dim myWebClient As New System.Net.WebClient 'the webclient
    Dim file As New System.IO.StreamReader(myWebClient.OpenRead(RemoteUri & sfile))
    Dim Contents As String = file.ReadToEnd()
    file.Close()

    If Contents <> "" Then
     Dim x() As String = Split(Contents, "|")
     If x(0) > Application.ProductVersion Then
      MsgId = "UpdateMsg" : ErrMsgDialog.ShowDialog()
      MdiMain.Refresh()
      If Answer <> 1 Then Exit Function
      c = RemotePath : DownloadUpdate.ShowDialog()
      If Down = True Then
       System.Diagnostics.Process.Start(PatchDir & "\" & PatchFile)
       Application.Exit()
       ret = True
      End If
     Else
      i2 = 255
     End If
    End If
   Catch ex As Exception
    ret = True
    MdiMain.Refresh()
   End Try
   Return ret
  End If
 End Function
End Class
