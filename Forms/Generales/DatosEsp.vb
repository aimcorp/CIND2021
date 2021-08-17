Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class DatosEsp
Dim FlagStart As Boolean

Private Sub DatosEsp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
If Rsolution = True Then ReSize1.Enabled = True
FlagStart = True
	'fill datos
If EspData.EspCProp = -1 Then cbMarEmp.Checked = True Else EspData.EspCProp = 0
tbNomEsp.Text = EspData.EspNom : mtbNumReg.Text = EspData.EspReg : mtbSegSoc.Text = EspData.EspSS
tbNomCom.Text = EspData.EspNomPatr : mtbSSPat.Text = EspData.EspSSPatr : tbDir1.Text = EspData.EspDir1
tbDir2.Text = EspData.EspDir2 : tbMuni.Text = EspData.EspMun : tbPais.Text = EspData.EspPais
mtbZoPos.Text = EspData.EspZip : tbPTin.Text = EspData.EspPTIN : tbTitulo.Text = EspData.EspTitulo
mTelRes.Text = EspData.EspTel
FlagStart = False
tbNomEsp.Focus()
End Sub

Private Sub SetTextVar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbMuni.KeyUp, tbPais.KeyUp, tbTitulo.KeyUp, tbPTin.KeyUp, mtbZoPos.KeyUp, mTelRes.KeyUp
If FlagStart = True Then Exit Sub
SetTextVarAll()
End Sub

Private Sub SetTextVarAll()
EspData.EspNom = tbNomEsp.Text : EspData.EspReg = mtbNumReg.Text : EspData.EspSS = mtbSegSoc.Text
EspData.EspNomPatr = tbNomCom.Text : EspData.EspSSPatr = mtbSSPat.Text : EspData.EspDir1 = tbDir1.Text
EspData.EspDir2 = tbDir2.Text : EspData.EspMun = tbMuni.Text : EspData.EspPais = tbPais.Text
EspData.EspZip = mtbZoPos.Text : EspData.EspPTIN = tbPTin.Text : EspData.EspTitulo = tbTitulo.Text
EspData.EspTel = mTelRes.Text
End Sub

Private Sub VerifySegSocEsp()
If c = "000000000" Then GoTo MensajeAbajo
If c = "111111111" Then GoTo MensajeAbajo
If c = "222222222" Then GoTo MensajeAbajo
If c = "333333333" Then GoTo MensajeAbajo
If c = "444444444" Then GoTo MensajeAbajo
If c = "555555555" Then GoTo MensajeAbajo
If c = "666666666" Then GoTo MensajeAbajo
If c = "777777777" Then GoTo MensajeAbajo
If c = "888888888" Then GoTo MensajeAbajo
If c = "999999999" Then GoTo MensajeAbajo

'		'Consecutivos
If c = "012345678" Then GoTo MensajeAbajo
If c = "123456789" Then GoTo MensajeAbajo
If c = "234567890" Then GoTo MensajeAbajo
If c = "345678901" Then GoTo MensajeAbajo
If c = "456789012" Then GoTo MensajeAbajo
If c = "567890123" Then GoTo MensajeAbajo
If c = "678901234" Then GoTo MensajeAbajo
If c = "789012345" Then GoTo MensajeAbajo
If c = "890123456" Then GoTo MensajeAbajo
If c = "901234567" Then GoTo MensajeAbajo
cuz = 0
Exit Sub

MensajeAbajo:
cuz = 5
MsgId = "DatosEspSSEsp" : ErrMsgDialog.ShowDialog() : Exit Sub
End Sub

Private Sub btRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRegister.Click
	'verify data is filled
b = 0
If tbNomEsp.Text = "" Then b = 1
If mtbNumReg.Text = "" Then b = 1
If mtbSegSoc.Text = "" Then b = 1
If mtbSSPat.Text = "" Then b = 1
If tbDir1.Text = "" Then b = 1
If tbMuni.Text = "" Then b = 1
If tbPais.Text = "" Then b = 1
If tbTitulo.Text = "" Then b = 1
If b = 1 Then MsgId = "DatosEspReq" : ErrMsgDialog.ShowDialog() : tbNomEsp.Focus() : Exit Sub
	'save Esp Data
FileTemp = WDataEsp & "\w7DE.chm"
FileInUse = FreeFile()
FileOpen(FileInUse, FileTemp, OpenMode.Random, OpenAccess.Write)
FilePut(FileInUse, EspData.EspTitulo & vbCr)
FilePut(FileInUse, EspData.EspNom & vbCr)
FilePut(FileInUse, EspData.EspDir1 & vbCr)
FilePut(FileInUse, EspData.EspDir2 & vbCr)
FilePut(FileInUse, EspData.EspMun & vbCr)
FilePut(FileInUse, EspData.EspPais & vbCr)
FilePut(FileInUse, EspData.EspZip & vbCr)
FilePut(FileInUse, EspData.EspSS & vbCr)
FilePut(FileInUse, EspData.EspReg & vbCr)
FilePut(FileInUse, EspData.EspNomPatr & vbCr)
FilePut(FileInUse, EspData.EspSSPatr & vbCr)
FilePut(FileInUse, EspData.EspCProp & vbCr)
FilePut(FileInUse, EspData.EspUsername & vbCr)
FilePut(FileInUse, EspData.EspPTIN & vbCr)
FilePut(FileInUse, EspData.EspTel & vbCr)
FileClose(FileInUse)
Me.Dispose() : MdiMain.Refresh()
End Sub

Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click
tbNomEsp.Text = "" : mtbNumReg.Text = "" : mtbSegSoc.Text = "" : tbNomCom.Text = "" : mtbSSPat.Text = ""
tbDir1.Text = "" : tbDir2.Text = "" : tbMuni.Text = "" : tbPais.Text = ""
mtbZoPos.Text = "" : tbPTin.Text = "" : tbTitulo.Text = "" : mTelRes.Text = "" : cbMarEmp.Checked = False
EspData.EspCProp = 0 : MdiMain.ImprimirDatosEsp.Checked = False
SetTextVarAll()
Me.Close()
End Sub

Private Sub CheckSegSocial(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mtbSSPat.KeyUp, mtbSegSoc.KeyUp
c = sender.text : If c.Length < 9 Then sender.Focus() : Exit Sub
VerifySegSocEsp()
If Cuz = 5 Then sender.text = "" : sender.focus() : Exit Sub
SetTextVarAll()
End Sub

Private Sub CheckSegSocComplete(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mtbSegSoc.Validating, mtbSSPat.Validating
c = sender.text : If c.Length < 9 Then sender.text = "" : sender.focus()
End Sub

Private Sub cbMarEmp_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbMarEmp.MouseClick
If cbMarEmp.Checked = True Then EspData.EspCProp = -1 Else EspData.EspCProp = 0
End Sub

Private Sub mTelRes_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mTelRes.Validating
Dim s As String = mTelRes.Text
s = s.Replace(")", "") : s = s.Replace("(", "") : s = s.Replace("-", "")
If Trim(s.ToString) <> "" Then If s.Length <> 10 Then mTelRes.Text = CurValue : e.Cancel = True
End Sub

Private Sub btReset_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReset.MouseEnter, Label26.MouseEnter
		btReset.Image = AIMContribucionesIncentivos.My.Resources.Resources.DatosEspH
	End Sub

	Private Sub btReset_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReset.MouseLeave, Label26.MouseLeave
		btReset.Image = AIMContribucionesIncentivos.My.Resources.Resources.DatosEsp
	End Sub

	Private Sub btReset_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btReset.MouseDown, Label26.MouseDown
		btReset.Image = AIMContribucionesIncentivos.My.Resources.Resources.DatosEspHC
	End Sub

	Private Sub btReset_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btReset.MouseUp, Label26.MouseUp
		btReset.Image = AIMContribucionesIncentivos.My.Resources.Resources.DatosEspH
	End Sub

	Private Sub btReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReset.Click
		tbNomEsp.Text = "" : mtbNumReg.Text = "" : mtbSegSoc.Text = "" : tbNomCom.Text = "" : mtbSSPat.Text = ""
		tbDir1.Text = "" : tbDir2.Text = "" : tbMuni.Text = "" : tbPais.Text = ""
		mtbZoPos.Text = "" : tbPTin.Text = "" : tbTitulo.Text = "" : mTelRes.Text = "" : cbMarEmp.Checked = False
	End Sub

	Private Sub btRegister_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRegister.MouseEnter
		btRegister.Image = AIMContribucionesIncentivos.My.Resources.Resources.DatosEspH
	End Sub

	Private Sub btRegister_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRegister.MouseLeave
		btRegister.Image = AIMContribucionesIncentivos.My.Resources.Resources.DatosEsp
	End Sub

	Private Sub btRegister_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btRegister.MouseDown
		btRegister.Image = AIMContribucionesIncentivos.My.Resources.Resources.DatosEspHC
	End Sub

	Private Sub btRegister_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btRegister.MouseUp
		btRegister.Image = AIMContribucionesIncentivos.My.Resources.Resources.DatosEspH
	End Sub

	Private Sub btSalir_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalir.MouseEnter
		btSalir.Image = AIMContribucionesIncentivos.My.Resources.Resources.DatosEspH
	End Sub

	Private Sub btSalir_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalir.MouseLeave
		btSalir.Image = AIMContribucionesIncentivos.My.Resources.Resources.DatosEsp
	End Sub

	Private Sub btSalir_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btSalir.MouseDown
		btSalir.Image = AIMContribucionesIncentivos.My.Resources.Resources.DatosEspHC
	End Sub

	Private Sub btSalir_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btSalir.MouseUp
		btSalir.Image = AIMContribucionesIncentivos.My.Resources.Resources.DatosEspH
	End Sub

Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalir.Click
	Me.Close()
	MdiMain.Refresh()
End Sub
End Class