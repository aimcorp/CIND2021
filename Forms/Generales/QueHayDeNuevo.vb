Imports System.IO

Public Class QueHayDeNuevo

Private Sub QueHayDeNuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  RichTextBox1.LoadFile(AppDir & "QHDNO21.rtf", RichTextBoxStreamType.RichText)
  RichTextBox1.Focus()
End Sub
End Class
