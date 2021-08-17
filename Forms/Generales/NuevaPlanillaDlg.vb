Imports System.IO
Imports System.Windows.Forms

Public Class NuevaPlanillaDlg
Dim fbd As FolderBrowserDialog

Public Sub New()
MyBase.New() : InitializeComponent() : fbd = New FolderBrowserDialog
End Sub

Private Sub NuevaPlanillaDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
If Rsolution = True Then ReSize1.Enabled = True
Panel1.Location = New System.Drawing.Point(4, 2)
Panel2.Location = New System.Drawing.Point(4, 2)
Panel3.Location = New System.Drawing.Point(4, 2)
Me.Text = "Crear o abrir fólder previo"
If Flag7 <> 229 Then Panel1.BringToFront() : Panel1.Visible = True Else _
			Panel3.BringToFront() : Panel3.Visible = True
End Sub

Private Sub btBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btBrowse.Click
BrowseFolders()
End Sub

Private Sub BrowseFolders()
fbd.SelectedPath = Udir
fbd.Description = "Seleccione el fólder para salvar sus planillas o cree uno nuevo para esta versión"
If fbd.ShowDialog = Windows.Forms.DialogResult.Cancel Then fbd.SelectedPath = "" : Udir = "" : Exit Sub
Udir = fbd.SelectedPath
Panel2.BringToFront() : Panel2.Visible = True : Panel1.Visible = False
Me.Text = "Crear o abrir Planilla Existente"
End Sub

Private Sub btExit_Click(sender As System.Object, e As System.EventArgs) Handles btExit.Click
Me.Close()
End Sub

Private Sub btCrear_Click(sender As System.Object, e As System.EventArgs) Handles btCrear.Click
Flag7 = 102 : OpenCustomer.CreateClientFile()
If UPla = "" Then Exit Sub
Me.Dispose()
End Sub

Private Sub btAbrir_Click(sender As System.Object, e As System.EventArgs) Handles btAbrir.Click
OpenCustomer.OpenFileNuevaPlanilla()
If UPla = "" Then Exit Sub
Me.Dispose()
End Sub

Private Sub btCCopia_Click(sender As System.Object, e As System.EventArgs) Handles btCCopia.Click
If tbNombCont.Text = "" Then tbNombCont.Focus() : Exit Sub
If InStr(UPla, tbNombCont.Text) > 0 Then tbNombCont.Focus() : Exit Sub
CrearCopiaPlanilla(tbNombCont.Text)
Me.Dispose()
End Sub

Private Sub btCancCopia_Click(sender As System.Object, e As System.EventArgs) Handles btCancCopia.Click
Me.Dispose()
End Sub

Private Sub btBack_Click(sender As System.Object, e As System.EventArgs) Handles btBack.Click
Panel1.Visible = True : Panel2.Visible = False
End Sub

Private Sub NuevaPlanillaDlg_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
If Flag7 = 229 Then Exit Sub 'cuando esta creando un nuevo nombre sale de este rutina
Udir = fbd.SelectedPath
If Udir = "" Or UPla = "" Then
				MsgId = "EstaSeguroDeSalirFolder" : ErrMsgDialog.ShowDialog()
				If Answer = 0 Then Application.ExitThread()
				If Answer = 1 Then e.Cancel = 1 : Exit Sub
Else
				Compdata.CompUDir = Udir
				CompdataXmlSave()
				Me.Dispose()
End If
End Sub

Private Sub VerifySPChar(sender As System.Object, e As System.EventArgs) Handles tbNombCont.TextChanged
'allow space, # sign and numbers
If FlagStart = True Then Exit Sub
Dim StrLength As Int32 = Len(sender.Text)
If StrLength = 0 Then Exit Sub
Dim bba As Integer
For x = 1 To StrLength
	c = Mid$(sender.Text, x, 1)
	If c = "" Then GoTo 15
	bba = Asc(c)
	If bba = 32 Then GoTo 15
	If bba >= 48 And bba <= 57 Then GoTo 15
	If bba >= 97 And bba <= 122 Then GoTo 15
	If bba < 65 Or bba > 90 Then _
			b = sender.text : sender.text = b.Substring(0, StrLength - 1) : sender.SelectionStart = sender.MaxLength
15:	Next
End Sub
End Class
