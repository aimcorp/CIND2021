Public Class AnejoB
Dim FlagStart As Boolean

Private Sub AnejoB_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
If Rsolution = True Then ReSize1.Enabled = True
Me.WindowState = FormWindowState.Minimized
End Sub

Private Sub AnejoB_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
Me.WindowState = FormWindowState.Maximized : ReSize1.Enabled = False
End Sub

Private Sub AnejoB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		FlagStart = True : UsePage = "IncentivosAnejoB" : PIm = 0
		MdiMain.tbIncB.Checked = True
		'read var
		tbColA.Text = IiB0(0) : mColA.Text = IiB0(1) : tbColB.Text = IiB0(2) : mColB.Text = IiB0(3)
		tbColC.Text = IiB0(4) : mColC.Text = IiB0(5)
		tbTotCreInv.Text = IiB0(12) : tbRecEx.Text = IiB0(13)
		'llenar los encasillados ==================
		'combo Col a - c
		If IiB0(9) <> "" Then cbColA.Text = IiB0(9)
		If IiB0(10) <> "" Then cbColB.Text = IiB0(10)
		If IiB0(11) <> "" Then cbColC.Text = IiB0(11)
		'otras
		If IiB0(9) = "OTRA" Then tbOtra1.Text = IiB0(6) : tbOtra1.Enabled = True
		If IiB0(10) = "OTRA" Then tbOtra2.Text = IiB0(7) : tbOtra2.Enabled = True
		If IiB0(11) = "OTRA" Then tbOtra3.Text = IiB0(8) : tbOtra3.Enabled = True
		'opcion transfer linea 3
		If IiB0(51) = "L" Then rbL.Checked = True
		If IiB0(51) = "N" Then rbN.Checked = True
		If IiB0(51) = "P" Then rbP.Checked = True
		If IiB0(51) = "V" Then rbV.Checked = True
		If IiB0(51) = "W" Then rbW.Checked = True
		If IiB0(51) = "X" Then rbX.Checked = True
		If IiB0(51) = "Y" Then rbY.Checked = True
		'desarollo industrial
		If IiP1(110) = "1" Then
			rbL.Enabled = False : rbL.Checked = False
			rbW.Enabled = False : rbW.Checked = False
			rbY.Enabled = False : rbY.Checked = False
		End If
		'desarrollo turistico
		If IiP1(110) = "2" Then
			rbL.Enabled = True
			rbN.Enabled = False : rbN.Checked = False
			rbV.Enabled = False : rbV.Checked = False
			rbX.Enabled = False : rbX.Checked = False
			rbW.Enabled = False : rbW.Checked = False
			rbY.Enabled = False : rbY.Checked = False
		End If
		If IiP1(110) <> "3" Then
			rbL.Enabled = False : rbL.Checked = False
			rbN.Enabled = False : rbN.Checked = False
			rbV.Enabled = False : rbV.Checked = False
			rbX.Enabled = False : rbX.Checked = False
			rbY.Enabled = False : rbY.Checked = False
		End If

		'poner linea 2 disable para primer ano -cambia si se salvo asi
		rbPriA.Checked = True
		If Not IsDBNull(IiB0(100)) Then
			x = Val(IiB0(100))
			If x = 1 Then
				rbAnoSub.Checked = True
				tbRecEx.Enabled = True : Label9.Enabled = True
			End If
		End If
		'Parte II
		tbNumPII2.Text = IiB0(21) : tbNumPII3.Text = IiB0(22) : tbNumPII4.Text = IiB0(23) : tbNumPII6.Text = IiB0(25)
		tbNumPII7.Text = IiB0(26) : tbNumPII8.Text = IiB0(27) : tbNumPII10.Text = IiB0(29) : tbNumPII11.Text = IiB0(30)
		tbNumPII12.Text = IiB0(31) : tbNumPII13.Text = IiB0(32) : tbNumPII14.Text = IiB0(33)

		'clean no se usan 2013
		IiB0(40) = ""

		tbNumPII22.Text = IiB0(41) : tbNumPII25.Text = IiB0(50)

		'Parte III
		If IiB0(81) = "x" Then chk1.Checked = True : tbPIII1.Enabled = True : tbPIII1.TabStop = True : tbPIII1.Text = IiB0(60)
		If IiB0(82) = "x" Then chk2.Checked = True : tbPIII2.Enabled = True : tbPIII2.TabStop = True : tbPIII2.Text = IiB0(61)
		If IiB0(83) = "x" Then chk3.Checked = True : tbPIII3.Enabled = True : tbPIII3.TabStop = True : tbPIII3.Text = IiB0(62)
		If IiB0(84) = "x" Then chk4.Checked = True : tbPIII4.Enabled = True : tbPIII4.TabStop = True : tbPIII4.Text = IiB0(63)
		If IiB0(85) = "x" Then chk5.Checked = True : tbPIII5.Enabled = True : tbPIII5.TabStop = True : tbPIII5.Text = IiB0(64)
		If IiB0(86) = "x" Then chk6.Checked = True : tbPIII6.Enabled = True : tbPIII6.TabStop = True : tbPIII6.Text = IiB0(65)
		If IiB0(87) = "x" Then chk7.Checked = True : tbPIII7.Enabled = True : tbPIII7.TabStop = True : tbPIII7.Text = IiB0(66)
		If IiB0(88) = "x" Then chk8.Checked = True : tbPIII8.Enabled = True : tbPIII8.TabStop = True : tbPIII8.Text = IiB0(67)
		If IiB0(89) = "x" Then chk9.Checked = True : tbPIII9.Enabled = True : tbPIII9.TabStop = True : tbPIII9.Text = IiB0(68)
		If IiB0(90) = "x" Then chk10.Checked = True : tbPIII10.Enabled = True : tbPIII10.TabStop = True : tbPIII10.Text = IiB0(69)
		If IiB0(91) = "x" Then chk11.Checked = True : tbPIII11.Enabled = True : tbPIII11.TabStop = True : tbPIII11.Text = IiB0(70)
		If IiB0(92) = "x" Then chk12.Checked = True : tbPIII12.Enabled = True : tbPIII12.TabStop = True : tbPIII12.Text = IiB0(71)
		If IiB0(93) = "x" Then chk13.Checked = True : tbPIII13.Enabled = True : tbPIII13.TabStop = False : tbPIII13.Text = IiB0(72)
		If IiB0(94) = "x" Then chk14.Checked = True : tbPIII14.Enabled = True : tbPIII14.TabStop = True : tbPIII14.Text = IiB0(73)
		If IiB0(95) = "x" Then
			chk15.Checked = True : tbOtr.Enabled = True : tbOtr.TabStop = True : tbOtr.Text = IiB0(96)
			tbPIII15.Enabled = True : tbPIII15.Text = IiB0(74) : tbPIII15.TabStop = True
		End If
		FillControls()
		b = Val(LCtr(5)) : taa = b : SetFocusAndTag()
		FlagStart = False
	End Sub

Private Sub FillControls()
		tbRecCre.Text = IiB0(14) : tbExCred.Text = IiB0(15) : tbNumPII1.Text = IiB0(20) : tbNumPII5.Text = IiB0(24)
		tbNumPII9.Text = IiB0(28)
		tbNumPII15.Text = IiB0(34) : tbNumPII16.Text = IiB0(35) : tbNumPII17.Text = IiB0(36) : tbNumPII18.Text = IiB0(37)
		tbNumPII19.Text = IiB0(38) : tbNumPII20.Text = IiB0(39) : tbNumPII23.Text = IiB0(42)
		tbNumPII24.Text = IiB0(43) : tbNumPII25.Text = IiB0(50) : tbTotCre.Text = IiB0(80)
	End Sub

Sub ResetTabStop()
chk1.TabStop = False : chk2.TabStop = False : chk3.TabStop = False : chk4.TabStop = False : chk5.TabStop = False
chk6.TabStop = False : chk7.TabStop = False : chk8.TabStop = False : chk9.TabStop = False : chk10.TabStop = False
chk11.TabStop = False : chk12.TabStop = False : chk12.TabStop = False : chk13.TabStop = False : chk14.TabStop = False
rbPriA.TabStop = False : rbAnoSub.TabStop = False
rbL.TabStop = False : rbN.TabStop = False : rbP.TabStop = False : rbV.TabStop = False : rbW.TabStop = False
End Sub

Private Sub SetFocusAndTag() Handles TabControl1.Click
If taa = 0 Then
				TabControl1.SelectedIndex = 0
				For Each CrR As Control In Me.TabPage1.Controls
								If CrR.Name = FormLastFocus(7) Then CrR.Focus() : Exit For
				Next CrR
End If
If taa = 1 Then
				TabControl1.SelectedIndex = 1
				For Each CrR As Control In Me.TabPage2.Controls
								If CrR.Name = FormLastFocus(8) Then CrR.Focus() : Exit For
				Next CrR
End If
End Sub

Private Sub ChangeTab(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
taa = TabControl1.SelectedIndex : LCtr(5) = taa : SetFocusAndTag()
End Sub

Private Sub ShowTagBarraDeAyuda(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbColC.Enter, tbColB.Enter, tbColA.Enter, mColC.Enter, mColB.Enter, mColA.Enter, tbTotCreInv.Enter, tbTotCre.Enter, tbPIII10.Enter, tbPIII11.Enter, tbRecEx.Enter, tbRecCre.Enter, tbOtr.Enter, tbPIII7.Enter, tbPIII14.Enter, tbPIII13.Enter, tbPIII12.Enter, tbPIII3.Enter, tbPIII4.Enter, tbExCred.Enter, tbPIII5.Enter, tbPIII1.Enter, tbPIII2.Enter, tbPIII6.Enter, tbPIII8.Enter, tbPIII9.Enter, tbPIII15.Enter, tbOtra3.Enter, tbOtra2.Enter, tbOtra1.Enter, tbNumPII2.Enter, tbNumPII1.Enter, tbNumPII5.Enter, tbNumPII7.Enter, tbNumPII6.Enter, tbNumPII8.Enter, tbNumPII4.Enter, tbNumPII3.Enter, tbNumPII9.Enter, tbNumPII10.Enter, tbNumPII12.Enter, tbNumPII11.Enter, tbNumPII13.Enter, tbNumPII14.Enter, tbNumPII18.Enter, tbNumPII17.Enter, tbNumPII16.Enter, tbNumPII15.Enter, tbNumPII20.Enter, tbNumPII19.Enter, tbNumPII25.Enter, tbNumPII24.Enter, tbNumPII22.Enter, tbNumPII23.Enter
If FlagStart = True Then Exit Sub
CurValue = ActiveControl.Text : CurValue = GetOnlyChars(CurValue)
If sender.name Is "TabPage1" Then Exit Sub
If sender.name Is "TabPage2" Then Exit Sub
If TabControl1.SelectedIndex = 0 Then taa = 0 : FormLastFocus(7) = sender.Name
If TabControl1.SelectedIndex = 1 Then taa = 1 : FormLastFocus(8) = sender.Name
End Sub

Private Sub tbColA_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbColA.GotFocus, tbColB.GotFocus, tbColC.GotFocus
If tbColA.Focused Then CurValue = tbColA.Text
If tbColB.Focused Then CurValue = tbColB.Text
If tbColC.Focused Then CurValue = tbColC.Text
End Sub

Private Sub mColA_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mColA.GotFocus, mColB.GotFocus, mColC.GotFocus
If FlagStart = True Then Exit Sub
If mColA.Focused Then mColA.SelectAll()
If mColB.Focused Then mColB.SelectAll()
If mColC.Focused Then mColC.SelectAll()
End Sub

Private Sub NumberOnly(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbTotCreInv.KeyUp, tbRecEx.KeyUp, tbPIII10.KeyUp, tbPIII11.KeyUp, tbPIII7.KeyUp, tbPIII14.KeyUp, tbPIII13.KeyUp, tbPIII12.KeyUp, tbPIII3.KeyUp, tbPIII4.KeyUp, tbPIII5.KeyUp, tbPIII1.KeyUp, tbPIII2.KeyUp, tbPIII6.KeyUp, tbPIII8.KeyUp, tbPIII9.KeyUp, tbPIII15.KeyUp, tbNumPII2.KeyUp, tbNumPII7.KeyUp, tbNumPII6.KeyUp, tbNumPII8.KeyUp, tbNumPII4.KeyUp, tbNumPII3.KeyUp, tbNumPII10.KeyUp, tbNumPII12.KeyUp, tbNumPII11.KeyUp, tbNumPII13.KeyUp, tbNumPII14.KeyUp, tbNumPII22.KeyUp, tbNumPII25.KeyUp
If InStr(sender.text, ".") > 0 Then
		sender.text = CurValue
		sender.selectionstart = sender.textlength
		Exit Sub
End If
If e.KeyCode = Keys.Tab Then Exit Sub
If e.KeyCode = Keys.Back Then GoTo 10
If e.KeyCode = Keys.Delete Then GoTo 10
If e.KeyCode = Keys.Left Then Exit Sub
If e.KeyCode = Keys.Right Then Exit Sub
If e.KeyCode = 109 Or e.KeyCode = 189 Then GoTo 10
If e.KeyCode = 46 Or e.KeyCode = 110 Then GoTo 10
If e.KeyCode > 46 And e.KeyCode < 58 Then GoTo 10
If e.KeyCode > 95 And e.KeyCode < 106 Then GoTo 10
sender.text = CurValue
sender.selectionstart = sender.textlength
Exit Sub
10:
CurValue = sender.text
setvar()
End Sub

Private Sub setvar()
		'parte I
		IiB0(0) = tbColA.Text : IiB0(1) = mColA.Text : IiB0(2) = tbColB.Text : IiB0(3) = mColB.Text
		IiB0(4) = tbColC.Text : IiB0(5) = mColC.Text : IiB0(6) = tbOtra1.Text : IiB0(7) = tbOtra2.Text
		IiB0(8) = tbOtra3.Text : IiB0(12) = tbTotCreInv.Text : IiB0(13) = tbRecEx.Text
		'parte II
		IiB0(21) = tbNumPII2.Text : IiB0(22) = tbNumPII3.Text : IiB0(23) = tbNumPII4.Text : IiB0(25) = tbNumPII6.Text
		IiB0(26) = tbNumPII7.Text : IiB0(27) = tbNumPII8.Text : IiB0(29) = tbNumPII10.Text : IiB0(30) = tbNumPII11.Text
		IiB0(31) = tbNumPII12.Text : IiB0(32) = tbNumPII13.Text : IiB0(33) = tbNumPII14.Text
		IiB0(41) = tbNumPII22.Text : IiB0(50) = tbNumPII25.Text
		'Parte III
		IiB0(60) = tbPIII1.Text : IiB0(61) = tbPIII2.Text : IiB0(62) = tbPIII3.Text : IiB0(63) = tbPIII4.Text
		IiB0(64) = tbPIII5.Text : IiB0(65) = tbPIII6.Text : IiB0(66) = tbPIII7.Text : IiB0(67) = tbPIII8.Text
		IiB0(68) = tbPIII9.Text : IiB0(69) = tbPIII10.Text : IiB0(70) = tbPIII11.Text : IiB0(71) = tbPIII12.Text
		IiB0(72) = tbPIII13.Text : IiB0(73) = tbPIII14.Text : IiB0(74) = tbPIII15.Text
		IiB0(96) = tbOtr.Text

		IiB0(9) = cbColA.Text : IiB0(10) = cbColB.Text : IiB0(11) = cbColC.Text
		''veriaim IncentivosCalR()
		If IiB0(51) = "1" Then tbRecEx.Text = "" : tbRecEx.Enabled = False
		FillControls()
	End Sub

	Sub chk1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk1.Click
		If FlagStart = True Then Exit Sub
		If chk1.Checked = True Then
			IiB0(81) = "x" : setvar() : tbPIII1.Enabled = True : tbPIII1.TabStop = True : tbPIII1.Focus()
		Else
			IiB0(81) = "" : IiB0(60) = "" : tbPIII1.Text = "" : tbPIII1.Enabled = False : tbPIII1.TabStop = False
			setvar()
		End If
	End Sub

	Sub chk2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk2.Click
		If chk2.Checked = True Then
			IiB0(82) = "x" : setvar() : tbPIII2.Enabled = True : tbPIII2.TabStop = True : tbPIII2.Focus()
		Else
			IiB0(82) = "" : IiB0(61) = "" : tbPIII2.Text = "" : tbPIII2.Enabled = False : tbPIII2.TabStop = False
			setvar()
		End If
	End Sub

	Private Sub chk3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk3.Click
		If chk3.Checked = True Then
			IiB0(83) = "x" : setvar() : tbPIII3.Enabled = True : tbPIII3.TabStop = True : tbPIII3.Focus()
		Else
			IiB0(83) = "" : IiB0(62) = "" : tbPIII3.Text = "" : tbPIII3.Enabled = False : tbPIII3.TabStop = False
			setvar()
		End If
	End Sub

	Private Sub chk4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk4.Click
		If chk4.Checked = True Then
			IiB0(84) = "x" : setvar() : tbPIII4.Enabled = True : tbPIII4.TabStop = True : tbPIII4.Focus()
		Else
			IiB0(84) = "" : IiB0(63) = "" : tbPIII4.Text = "" : tbPIII4.Enabled = False : tbPIII4.TabStop = False
			setvar()
		End If
	End Sub

	Sub chk5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk5.Click
		If chk5.Checked = True Then
			IiB0(85) = "x" : setvar() : tbPIII5.Enabled = True : tbPIII5.TabStop = True : tbPIII5.Focus()
		Else
			IiB0(85) = "" : IiB0(64) = "" : tbPIII5.Text = "" : tbPIII5.Enabled = False : tbPIII5.TabStop = False
			setvar()
		End If
	End Sub

	Sub chk6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk6.Click
		If chk6.Checked = True Then
			IiB0(86) = "x" : setvar() : tbPIII6.Enabled = True : tbPIII6.TabStop = True : tbPIII6.Focus()
		Else
			IiB0(86) = "" : IiB0(65) = "" : tbPIII6.Text = "" : tbPIII6.Enabled = False : tbPIII6.TabStop = False
			setvar()
		End If
	End Sub

	Sub chk7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk7.Click
		If chk7.Checked = True Then
			IiB0(87) = "x" : setvar() : tbPIII7.Enabled = True : tbPIII7.TabStop = True : tbPIII7.Focus()
		Else
			IiB0(87) = "" : IiB0(66) = "" : tbPIII7.Text = "" : tbPIII7.Enabled = False : tbPIII7.TabStop = False
			setvar()
		End If
	End Sub

	Sub chk8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk8.Click
		If chk8.Checked = True Then
			IiB0(88) = "x" : setvar() : tbPIII8.Enabled = True : tbPIII8.TabStop = True : tbPIII8.Focus()
		Else
			IiB0(88) = "" : IiB0(67) = "" : tbPIII8.Text = "" : tbPIII8.Enabled = False : tbPIII8.TabStop = False
			setvar()
		End If
	End Sub

	Sub chk9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk9.Click
		If chk9.Checked = True Then
			IiB0(89) = "x" : setvar() : tbPIII9.Enabled = True : tbPIII9.TabStop = True : tbPIII9.Focus()
		Else
			IiB0(89) = "" : IiB0(68) = "" : tbPIII9.Text = "" : tbPIII9.Enabled = False : tbPIII9.TabStop = False
			setvar()
		End If
	End Sub

	Sub chk10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk10.Click
		If chk10.Checked = True Then
			IiB0(90) = "x" : setvar() : tbPIII10.Enabled = True : tbPIII10.TabStop = True : tbPIII10.Focus()
		Else
			IiB0(90) = "" : IiB0(69) = "" : tbPIII10.Text = "" : tbPIII10.Enabled = False : tbPIII10.TabStop = False
			setvar()
		End If
	End Sub

	Sub chk11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk11.Click
		If chk11.Checked = True Then
			IiB0(91) = "x" : setvar() : tbPIII11.Enabled = True : tbPIII11.TabStop = True : tbPIII11.Focus()
		Else
			IiB0(91) = "" : IiB0(70) = "" : tbPIII11.Text = "" : tbPIII11.Enabled = False : tbPIII11.TabStop = False
			setvar()
		End If
	End Sub

	Sub chk12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk12.Click
		If chk12.Checked = True Then
			IiB0(92) = "x" : setvar() : tbPIII12.Enabled = True : tbPIII12.TabStop = True : tbPIII12.Focus()
		Else
			IiB0(92) = "" : IiB0(71) = "" : tbPIII12.Text = "" : tbPIII12.Enabled = False : tbPIII12.TabStop = False
			setvar()
		End If
	End Sub

	Sub chk13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk13.Click
		If chk13.Checked = True Then
			IiB0(93) = "x" : setvar() : tbPIII13.Enabled = True : tbPIII13.TabStop = True : tbPIII13.Focus()
		Else
			IiB0(93) = "" : IiB0(72) = "" : tbPIII13.Text = "" : tbPIII13.Enabled = False : tbPIII13.TabStop = False
			setvar()
		End If
	End Sub

	Sub chk14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk14.Click
		If chk14.Checked = True Then
			IiB0(94) = "x" : setvar() : tbPIII14.Enabled = True : tbPIII14.TabStop = True : tbPIII14.Focus()
		Else
			IiB0(94) = "" : IiB0(73) = "" : tbPIII14.Text = "" : tbPIII14.Enabled = False : tbPIII14.TabStop = False
			setvar()
		End If
	End Sub

	Private Sub chk15_Click(sender As System.Object, e As System.EventArgs) Handles chk15.Click
		If chk15.Checked = True Then
			IiB0(95) = "x" : setvar() : tbPIII15.Enabled = True : tbPIII15.TabStop = True
			tbOtr.TabStop = True : tbOtr.Enabled = True : tbPIII15.Focus()
		Else
			IiB0(95) = "" : IiB0(74) = "" : tbPIII15.Text = "" : tbPIII15.Enabled = False : tbPIII15.TabStop = False
			tbOtr.Text = "" : tbOtr.TabStop = False : tbOtr.Enabled = False : setvar()
		End If
	End Sub

	Private Sub SetTransfer(sender As System.Object, e As System.EventArgs) Handles rbY.Click, rbX.Click, rbW.Click, rbV.Click, rbP.Click, rbN.Click, rbL.Click
		If FlagStart = True Then Exit Sub

		'veriaim
		'IiN0(107) = "" : IiPP(269) = "" : IiV0(69) = "" : IiX0(72) = ""
		'IiN0(108) = "" : IiPP(270) = ""

		ValR = Val(IiB0(14)) : ValCal1 = Val(IiB0(50))
		If rbL.Checked = True Then x = x : IiB0(51) = "L"
		'If rbN.Checked = True Then IiN0(107) = ValR : IiN0(108) = ValCal1 : IiB0(43) = IiN0(106) : IiB0(51) = "N"
		'If rbP.Checked = True Then IiPP(269) = ValR : IiPP(270) = ValCal1 : IiB0(43) = IiPP(268) : IiB0(51) = "P"
		'If rbV.Checked = True Then IiV0(69) = ValR : IiB0(43) = IiV0(79) : IiB0(51) = "V"
		'If rbW.Checked = True Then IiW0(6) = ValR : IiB0(51) = "W"
		'If rbX.Checked = True Then IiX0(72) = ValR : IiB0(43) = IiX0(92) : IiB0(51) = "X"
		If rbY.Checked = True Then x = x : IiB0(51) = "Y"
		ValR = 0 : ValCal1 = 0
		'veriaim IncentivosCalR() : FillControls() : tbNumPII2.Focus()
	End Sub

	Private Sub rbPrimAno_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPriA.Click, rbAnoSub.Click
		If rbPriA.Checked = True Then _
						IiB0(100) = "0" : tbRecEx.Enabled = False : tbRecEx.Text = "" : Label9.Enabled = False : tbTotCreInv.Focus()
		If rbAnoSub.Checked = True Then _
						IiB0(100) = "1" : tbRecEx.Enabled = True : Label9.Enabled = True : tbRecEx.Focus()
		setvar() : ResetTabStop()
	End Sub

	Private Sub CheckSegSoc(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mColA.Validating, mColB.Validating, mColC.Validating
		c = sender.text
		Dim x As Byte = CheckEmployerSocSec(c)
		If x = 200 Then Exit Sub
		If x = False Then sender.Text = CurValue : sender.Focus()
	End Sub

	Private Sub setvarall(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbColC.KeyUp, tbColB.KeyUp, tbColA.KeyUp, mColC.KeyUp, mColB.KeyUp, mColA.KeyUp, tbOtr.KeyUp, tbOtra3.KeyUp, tbOtra2.KeyUp, tbOtra1.KeyUp
		setvar()
	End Sub

	Private Sub SetDropdown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbColA.SelectedIndexChanged, cbColC.SelectedIndexChanged, cbColB.SelectedIndexChanged
If FlagStart = True Then Exit Sub
		IiB0(9) = cbColA.Text : IiB0(10) = cbColB.Text : IiB0(11) = cbColC.Text
		If IiB0(9) <> "OTRA" Then tbOtra1.Text = "" : tbOtra1.Enabled = False
		If IiB0(10) <> "OTRA" Then tbOtra2.Text = "" : tbOtra2.Enabled = False
		If IiB0(11) <> "OTRA" Then tbOtra3.Text = "" : tbOtra3.Enabled = False
		If sender.name = "cbColA" Then If cbColA.Text = "OTRA" Then tbOtra1.Enabled = True : tbOtra1.Focus() : Exit Sub
		If sender.name = "cbColB" Then If cbColB.Text = "OTRA" Then tbOtra2.Enabled = True : tbOtra2.Focus() : Exit Sub
		If sender.name = "cbColC" Then If cbColC.Text = "OTRA" Then tbOtra3.Enabled = True : tbOtra3.Focus() : Exit Sub
		If sender.name = "cbColA" Then tbColA.Focus()
		If sender.name = "cbColB" Then tbColB.Focus()
		If sender.name = "cbColC" Then tbColC.Focus()
	End Sub
End Class