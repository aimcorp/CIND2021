Public Class SplashScreen1

'This form can easily be set as the splash screen for the application by going to the "Application" tab
'  of the Project Designer ("Properties" under the "Project" menu).

Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
'Set up the dialog text at runtime according to the application's assembly information.  

'Format the version information using the text set into the Version control at design time as the
'  formatting string.  This allows for effective localization if desired.
'  Build and revision information could be included by using the following code and changing the 
'  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
'  String.Format() in Help for more information.
'
'  Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, _
'				My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

Dim s As Int32, s1 As Int32, d As String, m As String, a As String
c = My.Application.Info.Version.ToString
	'mes
s = InStr(c, ".")
If s = 2 Then m = "0" & Mid(c, 1, 1)
If s = 3 Then m = Mid(c, 1, 2)
c = Mid(c, s + 1, 10)
	'dia
s = InStr(c, ".")
If s = 2 Then d = "0" & Mid(c, 1, 1)
If s = 3 Then d = Mid(c, 1, 2)
c = Mid(c, s + 1, 10)
	'ano
a = Mid(c, 1, 4)
Revision = m & "/" & d & "/" & a
Version.Text = Revision
End Sub

Private Sub SplashScreen1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
Me.Close()
End Sub

Private Sub MainLayoutPanel_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
Me.Close()
End Sub
End Class
