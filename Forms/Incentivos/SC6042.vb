
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class SC6042
Dim FlagStart As Boolean, vrr(52) As String, fc As Byte

Private Sub SC6042_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
If Rsolution = True Then ReSize1.Enabled = True
Me.WindowState = FormWindowState.Minimized
End Sub

Private Sub SC6042_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
Me.WindowState = FormWindowState.Maximized : ReSize1.Enabled = False
End Sub

Private Sub SC6042_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
FlagStart = True : UsePage = "SC6042" : Me.BackColor = Color.Wheat
If Compdata.UltimaFormaUsada = "IncentivosInd" Then MdiMain.tbSC6042.Checked = True : fc = 104
ReadvarPlan() : ResetTabStop()
For Each CrR As Control In Me.Panel1.Controls
  If CrR.Name = FormLastFocus(fc) Then CrR.Focus() : c = CrR.Text : CurValue = GetOnlyChars(c) : Exit For
Next CrR
FlagStart = False
End Sub

Private Sub ResetTabStop()
rbBenDef.TabStop = False : rbApoDef.TabStop = False
cbPar1.TabStop = False : cbPar2.TabStop = False : cbPar3.TabStop = False
cbPar4.TabStop = False : cbPar5.TabStop = False : cbPar6.TabStop = False
End Sub

Private Sub ShowTagBarraDeAyuda(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPI5.Enter, tbPIIB.Enter, tbPIIA.Enter, tbPI1.Enter, mNumIdPat.Enter, tbPI4.Enter, tbPI3.Enter, tbPI2.Enter, tbPIV16.Enter, tbPIV15.Enter, tbPIII13.Enter, tbPIII12.Enter, tbPVB.Enter, tbPVA.Enter, tbPV6.Enter, tbPV5.Enter, tbPV9.Enter, tbPV8.Enter, mFec4.Enter, mFec3.Enter, mFec2.Enter, mFec1.Enter, tbNPR.Enter
If FlagStart = True Then Exit Sub
CurValue = ActiveControl.Text : CurValue = GetOnlyChars(CurValue)
FormLastFocus(fc) = sender.Name
End Sub

Private Sub SetVarText(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mFec4.KeyUp, mFec3.KeyUp, mFec2.KeyUp, mFec1.KeyUp
SaveText()
End Sub

Sub SaveText()
vrr(0) = tbNPR.Text : vrr(1) = mNumIdPat.Text
vrr(40) = mFec1.Text : vrr(41) = mFec2.Text : vrr(42) = mFec3.Text : vrr(43) = mFec4.Text
SavePlan()
End Sub

Private Sub VerifyChars2(sender As System.Object, e As System.EventArgs) Handles tbNPR.TextChanged
'allow spaces, no numbers and symbols
If FlagStart = True Then Exit Sub
Dim StrLength As Int32 = Len(sender.Text)
If sender.name = "" Then GoTo 16
For x = 1 To StrLength
	c = Mid$(sender.Text, x, 1)
	Dim bba As Integer
	bba = Asc(c)
	If bba = 32 Then GoTo 15
	If bba = 38 Then GoTo 15
	If bba < 48 Or bba > 57 Then GoTo 16
	If bba < 65 Or bba > 90 Then _
			b = sender.text : sender.text = b.Substring(0, StrLength - 1) : sender.SelectionStart = sender.MaxLength
15:	Next
16:	SaveText()
End Sub

Private Sub VerifyNumbers2(sender As System.Object, e As System.EventArgs) Handles tbPI1.TextChanged, tbPVB.TextChanged, tbPVA.TextChanged, tbPV9.TextChanged, tbPV8.TextChanged, tbPV6.TextChanged, tbPV5.TextChanged, tbPIV16.TextChanged, tbPIV15.TextChanged, tbPIII13.TextChanged, tbPIII12.TextChanged, tbPIIB.TextChanged, tbPIIA.TextChanged, tbPI5.TextChanged, tbPI4.TextChanged, tbPI3.TextChanged, tbPI2.TextChanged
If FlagStart = True Then Exit Sub
FlagStart = True
Dim StrLength As Int32 = Len(sender.Text)
If sender.text = "" Then GoTo 15
For x = 1 To StrLength
	c = Mid$(sender.Text, x, 1)
	Dim bba As Integer
	bba = Asc(c)
	If bba < 48 Or bba > 57 Then b = sender.text _
		: sender.text = b.Substring(0, StrLength - 1) : sender.SelectionStart = sender.MaxLength
Next
15:		SetAmounts()
FlagStart = False
End Sub

Private Sub SetAmounts()
vrr(12) = tbPI1.Text : vrr(13) = tbPI2.Text : vrr(14) = tbPI3.Text : vrr(15) = tbPI4.Text : vrr(17) = tbPI5.Text
vrr(23) = tbPIIA.Text : vrr(24) = tbPIIB.Text : vrr(30) = tbPIII12.Text : vrr(31) = tbPIII13.Text
vrr(35) = tbPIV15.Text : vrr(36) = tbPIV16.Text
vrr(46) = tbPV5.Text : vrr(47) = tbPV6.Text : vrr(48) = tbPVA.Text : vrr(49) = tbPVB.Text
vrr(51) = tbPV8.Text : vrr(52) = tbPV9.Text
SavePlan() : FillControls()
End Sub

Private Sub CheckSegSocComplete(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles mNumIdPat.Validating
If FlagStart = True Then Exit Sub
c = sender.text : If c = "" Then Exit Sub
If c.Length < 9 Then sender.text = "" : sender.focus()
End Sub

Private Sub CheckSegSoc(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles mNumIdPat.KeyUp
If e.KeyCode = 107 Then sender.text = "" : Exit Sub
c = sender.text : If c.Length < 9 Then SaveText() : sender.Focus() : Exit Sub
SaveText()
End Sub

Private Sub LimpiarScreen()
tbNPR.Text = "" : mNumIdPat.Text = ""
rbBenDef.Checked = False : rbApoDef.Checked = False : cbPar1.Checked = False : cbPar2.Checked = False
cbPar3.Checked = False : cbPar4.Checked = False : cbPar5.Checked = False : cbPar6.Checked = False
tbPI1.Text = "" : tbPI2.Text = "" : tbPI3.Text = "" : tbPI4.Text = "" : tbPITot2.Text = "" : tbPI5.Text = ""
tbPITot4.Text = "" : tbPITot5.Text = "" : tbPITot6.Text = "" : tbPIITot7.Text = "" : tbPIIA.Text = ""
tbPIIB.Text = "" : tbPIITot9.Text = "" : tbPIITot11.Text = "" : tbPIII12.Text = "" : tbPIII13.Text = ""
tbPIIITot14.Text = "" : tbPIV15.Text = "" : tbPIV16.Text = "" : tbPIVTot17.Text = "" : tbPIVTot19.Text = ""
mFec1.Text = "" : mFec2.Text = "" : mFec3.Text = "" : mFec4.Text = ""
tbPV5.Text = "" : tbPV6.Text = "" : tbPVA.Text = "" : tbPVB.Text = "" : tbPVT7.Text = ""
tbPV8.Text = "" : tbPV9.Text = ""
ResetTabStop()
End Sub

Private Sub FillControls()
tbPITot2.Text = vrr(16) : tbPITot4.Text = vrr(18) : tbPITot5.Text = vrr(19) : tbPITot6.Text = vrr(20)
tbPIITot7.Text = vrr(22) : tbPIITot9.Text = vrr(25) : tbPIITot11.Text = vrr(26)
tbPIIITot14.Text = vrr(32) : tbPIVTot17.Text = vrr(37) : tbPIVTot19.Text = vrr(38)
tbPVT7.Text = vrr(50)
End Sub

Private Sub ReadvarPlan()
FlagStart = True
LimpiarScreen()
If Flgv(8) = "" Then Flgv(8) = "1" : rbp1.Checked = True
If Flgv(8) = "1" Then rbp1.Checked = True : For i = 0 To 52 : vrr(i) = sc6a(i) : Next : GoTo FillScreen
If Flgv(8) = "2" Then rbp2.Checked = True : For i = 0 To 52 : vrr(i) = sc6b(i) : Next : GoTo FillScreen
If Flgv(8) = "3" Then rbp3.Checked = True : For i = 0 To 52 : vrr(i) = sc6c(i) : Next : GoTo FillScreen
If Flgv(8) = "4" Then rbp4.Checked = True : For i = 0 To 52 : vrr(i) = sc6d(i) : Next : GoTo FillScreen
Exit Sub

FillScreen:
If vrr(2) = "" Then vrr(2) = "0"
If vrr(2) = "0" Then rbBenDef.Checked = True
If vrr(2) = "1" Then
    rbApoDef.Checked = True
    cbPar1.Enabled = True : cbPar2.Enabled = True : cbPar3.Enabled = True
    cbPar4.Enabled = True : cbPar5.Enabled = True : cbPar6.Enabled = True
End If
If vrr(4) = "1" Then cbPar1.Checked = True
If vrr(5) = "1" Then cbPar2.Checked = True
If vrr(6) = "1" Then cbPar3.Checked = True
If vrr(7) = "1" Then cbPar4.Checked = True
If vrr(8) = "1" Then cbPar5.Checked = True
If vrr(9) = "1" Then cbPar6.Checked = True

  'cuestionario
tbNPR.Text = vrr(0) : mNumIdPat.Text = vrr(1)

tbPI1.Text = vrr(12) : tbPI2.Text = vrr(13) : tbPI3.Text = vrr(14) : tbPI4.Text = vrr(15) : tbPI5.Text = vrr(17)
tbPIIA.Text = vrr(23) : tbPIIB.Text = vrr(24) : tbPIII12.Text = vrr(30) : tbPIII13.Text = vrr(31)
tbPIV15.Text = vrr(35) : tbPIV16.Text = vrr(36)

  'fecha
mFec1.Text = vrr(40) : mFec2.Text = vrr(41) : mFec3.Text = vrr(42) : mFec4.Text = vrr(43)

tbPV5.Text = vrr(46) : tbPV6.Text = vrr(47) : tbPVA.Text = vrr(48) : tbPVB.Text = vrr(49)
tbPV8.Text = vrr(51) : tbPV9.Text = vrr(52)
FillControls()
FlagStart = False
End Sub

Private Sub SaveTipoPlan(sender As System.Object, e As System.EventArgs) Handles rbApoDef.Click, rbBenDef.Click
If FlagStart = True Then Exit Sub
'part I
If rbBenDef.Checked = True Then
			vrr(2) = "0"
			cbPar1.Enabled = False : cbPar2.Enabled = False : cbPar3.Enabled = False
			cbPar4.Enabled = False : cbPar5.Enabled = False : cbPar6.Enabled = False
			cbPar1.Checked = False : cbPar2.Checked = False : cbPar3.Checked = False
			cbPar4.Checked = False : cbPar5.Checked = False : cbPar6.Checked = False
End If
If rbApoDef.Checked = True Then
			vrr(2) = "1"
			cbPar1.Enabled = True : cbPar2.Enabled = True : cbPar3.Enabled = True
			cbPar4.Enabled = True : cbPar5.Enabled = True : cbPar6.Enabled = True
End If
mNumIdPat.Focus()
SavePlan()
End Sub

Private Sub ckFocusNP(sender As System.Object, e As System.EventArgs) Handles rbp1.Click, rbp2.Click, rbp3.Click, rbp4.Click
If FlagStart = True Then Exit Sub
b = 0
If sender.name = "rbp1" Then b = 1
If sender.name = "rbp2" Then b = 2
If sender.name = "rbp3" Then b = 3
If sender.name = "rbp4" Then b = 4
If b <> 0 Then Flgv(8) = b : ReadvarPlan() : ResetTabStop()
tbNPR.Focus()
End Sub

Private Sub SavePlan()
If rbp1.Checked = True Then For i = 0 To UBound(sc6a) : sc6a(i) = vrr(i) : Next
If rbp2.Checked = True Then For i = 0 To UBound(sc6b) : sc6b(i) = vrr(i) : Next
If rbp3.Checked = True Then For i = 0 To UBound(sc6c) : sc6c(i) = vrr(i) : Next
If rbp4.Checked = True Then For i = 0 To UBound(sc6d) : sc6d(i) = vrr(i) : Next
		'veriaim 'veriaim IncentivosCalR()
		If rbp1.Checked = True Then For i = 0 To UBound(sc6a) : vrr(i) = sc6a(i) : Next
If rbp2.Checked = True Then For i = 0 To UBound(sc6b) : vrr(i) = sc6b(i) : Next
If rbp3.Checked = True Then For i = 0 To UBound(sc6c) : vrr(i) = sc6c(i) : Next
If rbp4.Checked = True Then For i = 0 To UBound(sc6d) : vrr(i) = sc6d(i) : Next
End Sub

Private Sub AporDefcb(sender As System.Object, e As System.EventArgs) Handles cbPar1.Click, cbPar6.Click, cbPar5.Click, cbPar4.Click, cbPar3.Click, cbPar2.Click
If FlagStart = True Then Exit Sub
If cbPar1.Checked = True Then vrr(4) = "1" Else vrr(4) = ""
If cbPar2.Checked = True Then vrr(5) = "1" Else vrr(5) = ""
If cbPar3.Checked = True Then vrr(6) = "1" Else vrr(6) = ""
If cbPar4.Checked = True Then vrr(7) = "1" Else vrr(7) = ""
If cbPar5.Checked = True Then vrr(8) = "1" Else vrr(8) = ""
If cbPar6.Checked = True Then vrr(9) = "1" Else vrr(9) = ""
SaveText() : ResetTabStop() : mNumIdPat.Focus()
End Sub

Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
MsgId = "SegBorrarPlan" : ErrMsgDialog.ShowDialog()
If answer = 0 Then tbNPR.Focus() : Exit Sub
For i = 0 To UBound(sc6a) : vrr(i) = "" : Next
FlagStart = True
LimpiarScreen() : SavePlan() : tbNPR.Focus()
FlagStart = False
End Sub

Private Sub CheckFecha(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles mFec4.Validating, mFec3.Validating, mFec2.Validating, mFec1.Validating
If FlagStart = True Then Exit Sub
If sender.Focused Then
		f = sender.Text
		If f = "" Then Exit Sub
		If Len(f) < 5 Then sender.Text = CurValue : sender.Focus() : Exit Sub
		If Len(f) <> 6 And Len(f) <> 8 Then sender.Focus() : Exit Sub
		VerificarFecha(f)
		If Tr = True Then sender.Text = CurValue : sender.Focus() : Exit Sub
		If f.Substring(6, 4) > AnoInUse Then Tr = True
		If Tr = True Then sender.Text = CurValue : sender.Focus() : Exit Sub
'all good save date
			sender.Text = f
			SaveText()
End If
End Sub
End Class