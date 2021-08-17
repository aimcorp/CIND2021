Imports System.Net

Public Class DownloadUpdate
Dim whereToSave As String = PatchDir & "\" & PatchFile
Dim RemotePath As String = c
Delegate Sub ChangeTextsSafe(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)
Delegate Sub DownloadCompleteSafe(ByVal cancelled As Boolean)

Private Sub DownloadUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
BackgroundWorker1.RunWorkerAsync()
End Sub

Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
'Creating the request and getting the response
Dim theResponse As HttpWebResponse
Dim theRequest As HttpWebRequest
Try	'Checks if the file exist
			theRequest = WebRequest.Create(RemotePath & "/" & PatchFile)
			theResponse = theRequest.GetResponse
Catch ex As Exception
			MsgId = "GenAutoErrDownLoad" : ErrMsgDialog.ShowDialog()
			Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)
			Me.Invoke(cancelDelegate, True)
			Exit Sub
End Try
Dim length As Long = theResponse.ContentLength	'Size of the response (in bytes)
Dim safedelegate As New ChangeTextsSafe(AddressOf ChangeTexts)
Me.Invoke(safedelegate, length, 0, 0, 0)	'Invoke the TreadsafeDelegate
Dim writeStream As New IO.FileStream(Me.whereToSave, IO.FileMode.Create)
'Replacement for Stream.Position (webResponse stream doesn't support seek)
Dim nRead As Integer
'To calculate the download speed
Dim speedtimer As New Stopwatch
Dim currentspeed As Double = -1
Dim readings As Integer = 0
Do
			If BackgroundWorker1.CancellationPending Then Exit Do 'If user abort download 
			speedtimer.Start()
			Dim readBytes(4095) As Byte
			Dim bytesread As Integer = theResponse.GetResponseStream.Read(readBytes, 0, 4096)
			nRead += bytesread
			Dim percent As Short = (nRead * 100) / length
			Me.Invoke(safedelegate, length, nRead, percent, currentspeed)
			If bytesread = 0 Then Exit Do
			writeStream.Write(readBytes, 0, bytesread)
			speedtimer.Stop()
			readings += 1
			If readings >= 5 Then	'For increase precision, the speed it's calculated only every five cicles
							currentspeed = 20480 / (speedtimer.ElapsedMilliseconds / 1000)
							speedtimer.Reset()
							readings = 0
			End If
Loop
	'Close the streams
theResponse.GetResponseStream.Close()
writeStream.Close()
If Me.BackgroundWorker1.CancellationPending Then
			IO.File.Delete(Me.whereToSave)
			Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)
			Me.Invoke(cancelDelegate, True)
			Exit Sub
End If
Dim completeDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)
Me.Invoke(completeDelegate, False)
End Sub

Public Sub DownloadComplete(ByVal cancelled As Boolean)
If cancelled Then
				MsgId = "GeAutoUpdateCancel" : ErrMsgDialog.ShowDialog()
				Me.Dispose()
Else
				Down = True
				Me.Dispose()
End If
Me.ProgressBar1.Value = 0
End Sub

Public Sub ChangeTexts(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)
Label3.Text = "File Size: " & Math.Round((length / 1024), 2) & " KB"
Me.Label4.Text = "Downloaded " & Math.Round((position / 1024), 2) & " KB of " & Math.Round((length / 1024), 2) & "KB (" & Me.ProgressBar1.Value & "%)"
If speed = -1 Then
			Me.Label2.Text = "Speed: calculating..."
Else
			Me.Label2.Text = "Speed: " & Math.Round((speed / 1024), 2) & " KB/s"
End If
Me.ProgressBar1.Value = percent
End Sub

Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
Me.BackgroundWorker1.CancelAsync()	'Send cancel request
End Sub
End Class