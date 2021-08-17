Public Class AnejoE
	Dim FlagStart As Boolean

	Private Sub AnejoE_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		setvar()
		Me.Dispose()
	End Sub

	Private Sub AnejoE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		FlagStart = True
		'veriaim
		'If Compdata.UltimaFormaUsada = "IncentivosInd" Then i2 = 300 : For i = 0 To 102 : vtm(i) = IiTm(i2) : i2 += 1 : Next : GoTo 250 'Incentivos Ind

250:  'fill
		tb1Desc1C1.Text = vtm(0) : tb2Desc1C1.Text = vtm(1) : tb3Desc1C1.Text = vtm(2)
		tb1Desc2C1.Text = vtm(3) : tb2Desc2C1.Text = vtm(4) : tb3Desc2C1.Text = vtm(5)
		tb1Desc3C1.Text = vtm(6) : tb2Desc3C1.Text = vtm(7) : tb3Desc3C1.Text = vtm(8)
		tb1Desc4C1.Text = vtm(9) : tb2Desc4C1.Text = vtm(10) : tb3Desc4C1.Text = vtm(11)
		tb1Desc5C1.Text = vtm(12) : tb2Desc5C1.Text = vtm(13) : tb3Desc5C1.Text = vtm(14)
		tb1FechaAdq1C2.Text = vtm(15) : tb2FechaAdq1C2.Text = vtm(16) : tb3FechaAdq1C2.Text = vtm(17)
		tb1FechaAdq2C2.Text = vtm(18) : tb2FechaAdq2C2.Text = vtm(19) : tb3FechaAdq2C2.Text = vtm(20)
		tb1FechaAdq3C2.Text = vtm(21) : tb2FechaAdq3C2.Text = vtm(22) : tb3FechaAdq3C2.Text = vtm(23)
		tb1FechaAdq4C2.Text = vtm(24) : tb2FechaAdq4C2.Text = vtm(25) : tb3FechaAdq4C2.Text = vtm(26)
		tb1FechaAdq5C2.Text = vtm(27) : tb2FechaAdq5C2.Text = vtm(28) : tb3FechaAdq5C2.Text = vtm(29)
		tb1Costo1C3.Text = vtm(30) : tb2Costo1C3.Text = vtm(31) : tb3Costo1C3.Text = vtm(32)
		tb1Dep1C4.Text = vtm(33) : tb2Dep1C4.Text = vtm(34) : tb3Dep1C4.Text = vtm(35)
		tb1Est1C5.Text = vtm(36) : tb2Est1C5.Text = vtm(37) : tb3Est1C5.Text = vtm(38)
		tb1Dep1C6.Text = vtm(39) : tb2Dep1C6.Text = vtm(40) : tb3Dep1C6.Text = vtm(41)
		tbDepCon1Total1.Text = vtm(42) : tbDep1Total2.Text = vtm(43)
		tb1Costo2C3.Text = vtm(44) : tb2Costo2C3.Text = vtm(45) : tb3Costo2C3.Text = vtm(46)
		tb1Dep2C4.Text = vtm(47) : tb2Dep2C4.Text = vtm(48) : tb3Dep2C4.Text = vtm(49)
		tb1Est2C5.Text = vtm(50) : tb2Est2C5.Text = vtm(51) : tb3Est2C5.Text = vtm(52)
		tb1Dep2C6.Text = vtm(53) : tb2Dep2C6.Text = vtm(54) : tb3Dep2C6.Text = vtm(55)
		tbDepCon2Total1.Text = vtm(56) : tbDep2Total2.Text = vtm(57)
		tb1Costo3C3.Text = vtm(58) : tb2Costo3C3.Text = vtm(59) : tb3Costo3C3.Text = vtm(60)
		tb1Dep3C4.Text = vtm(61) : tb2Dep3C4.Text = vtm(62) : tb3Dep3C4.Text = vtm(63)
		tb1Est3C5.Text = vtm(64) : tb2Est3C5.Text = vtm(65) : tb3Est3C5.Text = vtm(66)
		tb1Dep3C6.Text = vtm(67) : tb2Dep3C6.Text = vtm(68) : tb3Dep3C6.Text = vtm(69)
		tbDepCon3Total1.Text = vtm(70) : tbDep3Total2.Text = vtm(71)
		tb1Costo4C3.Text = vtm(72) : tb2Costo4C3.Text = vtm(73) : tb3Costo4C3.Text = vtm(74)
		tb1Dep4C4.Text = vtm(75) : tb2Dep4C4.Text = vtm(76) : tb3Dep4C4.Text = vtm(77)
		tb1Est4C5.Text = vtm(78) : tb2Est4C5.Text = vtm(79) : tb3Est4C5.Text = vtm(80)
		tb1Dep4C6.Text = vtm(81) : tb2Dep4C6.Text = vtm(82) : tb3Dep4C6.Text = vtm(83)
		tbDepCon4Total1.Text = vtm(84) : tbDep4Total2.Text = vtm(85)
		tb1Costo5C3.Text = vtm(86) : tb2Costo5C3.Text = vtm(87) : tb3Costo5C3.Text = vtm(88)
		tb1Dep5C4.Text = vtm(89) : tb2Dep5C4.Text = vtm(90) : tb3Dep5C4.Text = vtm(91)
		tb1Est5C5.Text = vtm(92) : tb2Est5C5.Text = vtm(93) : tb3Est5C5.Text = vtm(94)
		tb1Dep5C6.Text = vtm(95) : tb2Dep5C6.Text = vtm(96) : tb3Dep5C6.Text = vtm(97)
		tbDepCon5Total1.Text = vtm(98) : tbDep5Total2.Text = vtm(99) : tbTotal.Text = vtm(100)
		tbVehA.Text = vtm(101) : tbCV.Text = vtm(102)
		If Compdata.UltimaFormaUsada = "Sociedades" Or Compdata.UltimaFormaUsada = "SocEsp" Then b = 8
		If Compdata.UltimaFormaUsada = "CorpIndv" Then b = 8
		If Compdata.UltimaFormaUsada = "IncentivosInd" Then b = 33

		For Each CrR As Control In Me.Controls
			If CrR.Name = FormLastFocus(b) Then CrR.Focus() : Exit For
		Next CrR
		FlagStart = False
	End Sub

	Private Sub setvar()
		vtm(0) = tb1Desc1C1.Text : vtm(1) = tb2Desc1C1.Text : vtm(2) = tb3Desc1C1.Text
		vtm(3) = tb1Desc2C1.Text : vtm(4) = tb2Desc2C1.Text : vtm(5) = tb3Desc2C1.Text
		vtm(6) = tb1Desc3C1.Text : vtm(7) = tb2Desc3C1.Text : vtm(8) = tb3Desc3C1.Text
		vtm(9) = tb1Desc4C1.Text : vtm(10) = tb2Desc4C1.Text : vtm(11) = tb3Desc4C1.Text
		vtm(12) = tb1Desc5C1.Text : vtm(13) = tb2Desc5C1.Text : vtm(14) = tb3Desc5C1.Text
		vtm(15) = tb1FechaAdq1C2.Text : vtm(16) = tb2FechaAdq1C2.Text : vtm(17) = tb3FechaAdq1C2.Text
		vtm(18) = tb1FechaAdq2C2.Text : vtm(19) = tb2FechaAdq2C2.Text : vtm(20) = tb3FechaAdq2C2.Text
		vtm(21) = tb1FechaAdq3C2.Text : vtm(22) = tb2FechaAdq3C2.Text : vtm(23) = tb3FechaAdq3C2.Text
		vtm(24) = tb1FechaAdq4C2.Text : vtm(25) = tb2FechaAdq4C2.Text : vtm(26) = tb3FechaAdq4C2.Text
		vtm(27) = tb1FechaAdq5C2.Text : vtm(28) = tb2FechaAdq5C2.Text : vtm(29) = tb3FechaAdq5C2.Text
		vtm(30) = tb1Costo1C3.Text : vtm(31) = tb2Costo1C3.Text : vtm(32) = tb3Costo1C3.Text
		vtm(33) = tb1Dep1C4.Text : vtm(34) = tb2Dep1C4.Text : vtm(35) = tb3Dep1C4.Text
		vtm(36) = tb1Est1C5.Text : vtm(37) = tb2Est1C5.Text : vtm(38) = tb3Est1C5.Text
		vtm(39) = tb1Dep1C6.Text : vtm(40) = tb2Dep1C6.Text : vtm(41) = tb3Dep1C6.Text
		vtm(42) = tbDepCon1Total1.Text : vtm(43) = tbDep1Total2.Text : vtm(44) = tb1Costo2C3.Text
		vtm(45) = tb2Costo2C3.Text : vtm(46) = tb3Costo2C3.Text
		vtm(47) = tb1Dep2C4.Text : vtm(48) = tb2Dep2C4.Text : vtm(49) = tb3Dep2C4.Text
		vtm(50) = tb1Est2C5.Text : vtm(51) = tb2Est2C5.Text : vtm(52) = tb3Est2C5.Text
		vtm(53) = tb1Dep2C6.Text : vtm(54) = tb2Dep2C6.Text : vtm(55) = tb3Dep2C6.Text
		vtm(56) = tbDepCon2Total1.Text : vtm(57) = tbDep2Total2.Text
		vtm(58) = tb1Costo3C3.Text : vtm(59) = tb2Costo3C3.Text : vtm(60) = tb3Costo3C3.Text
		vtm(61) = tb1Dep3C4.Text : vtm(62) = tb2Dep3C4.Text : vtm(63) = tb3Dep3C4.Text
		vtm(64) = tb1Est3C5.Text : vtm(65) = tb2Est3C5.Text : vtm(66) = tb3Est3C5.Text
		vtm(67) = tb1Dep3C6.Text : vtm(68) = tb2Dep3C6.Text : vtm(69) = tb3Dep3C6.Text
		vtm(70) = tbDepCon3Total1.Text : vtm(71) = tbDep3Total2.Text
		vtm(72) = tb1Costo4C3.Text : vtm(73) = tb2Costo4C3.Text : vtm(74) = tb3Costo4C3.Text
		vtm(75) = tb1Dep4C4.Text : vtm(76) = tb2Dep4C4.Text : vtm(77) = tb3Dep4C4.Text
		vtm(78) = tb1Est4C5.Text : vtm(79) = tb2Est4C5.Text : vtm(80) = tb3Est4C5.Text
		vtm(81) = tb1Dep4C6.Text : vtm(82) = tb2Dep4C6.Text : vtm(83) = tb3Dep4C6.Text
		vtm(84) = tbDepCon4Total1.Text : vtm(85) = tbDep4Total2.Text
		vtm(86) = tb1Costo5C3.Text : vtm(87) = tb2Costo5C3.Text : vtm(88) = tb3Costo5C3.Text
		vtm(89) = tb1Dep5C4.Text : vtm(90) = tb2Dep5C4.Text : vtm(91) = tb3Dep5C4.Text
		vtm(92) = tb1Est5C5.Text : vtm(93) = tb2Est5C5.Text : vtm(94) = tb3Est5C5.Text
		vtm(95) = tb1Dep5C6.Text : vtm(96) = tb2Dep5C6.Text : vtm(97) = tb3Dep5C6.Text
		vtm(98) = tbDepCon5Total1.Text : vtm(99) = tbDep5Total2.Text
		vtm(100) = tbTotal.Text : vtm(101) = tbVehA.Text : vtm(102) = tbCV.Text

		'Calculation
		Valcal = 0
		Valcal = Val(vtm(33)) + Val(vtm(34)) + Val(vtm(35))
		vtm(42) = Valcal
		Valcal = 0
		Valcal = Val(vtm(47)) + Val(vtm(48)) + Val(vtm(49))
		vtm(56) = Valcal
		Valcal = 0
		Valcal = Val(vtm(61)) + Val(vtm(62)) + Val(vtm(63))
		vtm(70) = Valcal

		Valcal = 0
		Valcal = Val(vtm(89)) + Val(vtm(90)) + Val(vtm(91))
		vtm(98) = Valcal
		Valcal = 0
		Valcal = Val(vtm(75)) + Val(vtm(76)) + Val(vtm(77))
		vtm(84) = Valcal

		Valcal = 0
		Valcal = Val(vtm(39)) + Val(vtm(40)) + Val(vtm(41))
		vtm(43) = Valcal
		Valcal = 0
		Valcal = Val(vtm(53)) + Val(vtm(54)) + Val(vtm(55))
		vtm(57) = Valcal
		Valcal = 0
		Valcal = Val(vtm(67)) + Val(vtm(68)) + Val(vtm(69))
		vtm(71) = Valcal

		Valcal = 0
		Valcal = Val(vtm(81)) + Val(vtm(82)) + Val(vtm(83))
		vtm(85) = Valcal
		Valcal = 0
		Valcal = Val(vtm(95)) + Val(vtm(96)) + Val(vtm(97))
		vtm(99) = Valcal

		vtm(100) = Val(vtm(43)) + Val(vtm(57)) + Val(vtm(71)) + Val(vtm(85)) + Val(vtm(99))

		tbTotal.Text = vtm(100)

		tbDepCon1Total1.Text = vtm(42) : tbDep1Total2.Text = vtm(43) : tbDepCon2Total1.Text = vtm(56)
		tbDep2Total2.Text = vtm(57) : tbDepCon4Total1.Text = vtm(84) : tbDep4Total2.Text = vtm(85)
		tbDepCon5Total1.Text = vtm(98) : tbDep5Total2.Text = vtm(99) : tbDepCon3Total1.Text = vtm(70)
		tbDep3Total2.Text = vtm(71)

		'save var
		ReDim Tmp0(500)
		Select Case UsePage
			Case "CorpAnejoAA"
				i2 = 200 : For i = 0 To 102 : Tmp1(i2) = vtm(i) : i2 += 1 : Next : Tmp1(99) = vtm(100) : Exit Sub

			Case "IncentivosInd"
				'			i2 = 300 : For i = 0 To 101 : IiTm(i2) = vtm(i) : i2 += 1 : Next : IiTm(100) = vtm(100) : Exit Sub
		End Select
	End Sub

	Private Sub NumberOnly(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb3Est5C5.KeyUp, tb3Est4C5.KeyUp, tb3Est3C5.KeyUp, tb3Est2C5.KeyUp, tb3Est1C5.KeyUp, tb3Dep5C6.KeyUp, tb3Dep5C4.KeyUp, tb3Dep4C6.KeyUp, tb3Dep4C4.KeyUp, tb3Dep3C6.KeyUp, tb3Dep3C4.KeyUp, tb3Dep2C6.KeyUp, tb3Dep2C4.KeyUp, tb3Dep1C6.KeyUp, tb3Dep1C4.KeyUp, tb3Costo5C3.KeyUp, tb3Costo4C3.KeyUp, tb3Costo3C3.KeyUp, tb3Costo2C3.KeyUp, tb3Costo1C3.KeyUp, tb2Est5C5.KeyUp, tb2Est4C5.KeyUp, tb2Est3C5.KeyUp, tb2Est2C5.KeyUp, tb2Est1C5.KeyUp, tb2Dep5C6.KeyUp, tb2Dep5C4.KeyUp, tb2Dep4C6.KeyUp, tb2Dep4C4.KeyUp, tb2Dep3C6.KeyUp, tb2Dep3C4.KeyUp, tb2Dep2C6.KeyUp, tb2Dep2C4.KeyUp, tb2Dep1C6.KeyUp, tb2Dep1C4.KeyUp, tb2Costo5C3.KeyUp, tb2Costo4C3.KeyUp, tb2Costo3C3.KeyUp, tb2Costo2C3.KeyUp, tb2Costo1C3.KeyUp, tb1Est5C5.KeyUp, tb1Est4C5.KeyUp, tb1Est3C5.KeyUp, tb1Est2C5.KeyUp, tb1Est1C5.KeyUp, tb1Dep5C6.KeyUp, tb1Dep5C4.KeyUp, tb1Dep4C6.KeyUp, tb1Dep4C4.KeyUp, tb1Dep3C6.KeyUp, tb1Dep3C4.KeyUp, tb1Dep2C6.KeyUp, tb1Dep2C4.KeyUp, tb1Dep1C6.KeyUp, tb1Dep1C4.KeyUp, tb1Costo5C3.KeyUp, tb1Costo4C3.KeyUp, tb1Costo3C3.KeyUp, tb1Costo2C3.KeyUp, tb1Costo1C3.KeyUp, tbVehA.KeyUp, tbCV.KeyUp
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

	Private Sub setvarall(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb3Desc5C1.KeyUp, tb3Desc4C1.KeyUp, tb3Desc3C1.KeyUp, tb3Desc2C1.KeyUp, tb3Desc1C1.KeyUp, tb2Desc5C1.KeyUp, tb2Desc4C1.KeyUp, tb2Desc3C1.KeyUp, tb2Desc2C1.KeyUp, tb2Desc1C1.KeyUp, tb1Desc5C1.KeyUp, tb1Desc4C1.KeyUp, tb1Desc3C1.KeyUp, tb1Desc2C1.KeyUp, tb1Desc1C1.KeyUp
		setvar()
	End Sub

	Private Sub ShowTagBarraDeAyuda(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb3FechaAdq5C2.Enter, tb3FechaAdq4C2.Enter, tb3FechaAdq3C2.Enter, tb3FechaAdq2C2.Enter, tb3FechaAdq1C2.Enter, tb3Desc5C1.Enter, tb3Desc4C1.Enter, tb3Desc3C1.Enter, tb3Desc2C1.Enter, tb3Desc1C1.Enter, tb2FechaAdq5C2.Enter, tb2FechaAdq4C2.Enter, tb2FechaAdq3C2.Enter, tb2FechaAdq2C2.Enter, tb2FechaAdq1C2.Enter, tb2Desc5C1.Enter, tb2Desc4C1.Enter, tb2Desc3C1.Enter, tb2Desc2C1.Enter, tb2Desc1C1.Enter, tb1FechaAdq5C2.Enter, tb1FechaAdq4C2.Enter, tb1FechaAdq3C2.Enter, tb1FechaAdq2C2.Enter, tb1FechaAdq1C2.Enter, tb1Desc5C1.Enter, tb1Desc4C1.Enter, tb1Desc3C1.Enter, tb1Desc2C1.Enter, tb1Desc1C1.Enter, tbDepCon5Total1.Enter, tbDepCon4Total1.Enter, tbDepCon3Total1.Enter, tbDepCon2Total1.Enter, tbDepCon1Total1.Enter, tbDep5Total2.Enter, tbDep4Total2.Enter, tbDep3Total2.Enter, tbDep2Total2.Enter, tbDep1Total2.Enter, tb3Est5C5.Enter, tb3Est4C5.Enter, tb3Est3C5.Enter, tb3Est2C5.Enter, tb3Est1C5.Enter, tb3Dep5C6.Enter, tb3Dep5C4.Enter, tb3Dep4C4.Enter, tb3Dep3C6.Enter, tb3Dep3C4.Enter, tb3Dep2C6.Enter, tb3Dep2C4.Enter, tb3Dep1C6.Enter, tb3Dep1C4.Enter, tb3Costo5C3.Enter, tb3Costo4C3.Enter, tb3Costo3C3.Enter, tb3Costo2C3.Enter, tb3Costo1C3.Enter, tb2Est5C5.Enter, tb2Est4C5.Enter, tb2Est3C5.Enter, tb2Est2C5.Enter, tb2Est1C5.Enter, tb2Dep5C6.Enter, tb2Dep5C4.Enter, tb2Dep4C6.Enter, tb2Dep4C4.Enter, tb2Dep3C6.Enter, tb2Dep3C4.Enter, tb2Dep2C6.Enter, tb2Dep2C4.Enter, tb2Dep1C6.Enter, tb2Dep1C4.Enter, tb2Costo5C3.Enter, tb2Costo4C3.Enter, tb2Costo3C3.Enter, tb2Costo2C3.Enter, tb2Costo1C3.Enter, tb1Est5C5.Enter, tb1Est4C5.Enter, tb1Est3C5.Enter, tb1Est2C5.Enter, tb1Est1C5.Enter, tb1Dep5C6.Enter, tb1Dep5C4.Enter, tb1Dep4C6.Enter, tb1Dep4C4.Enter, tb1Dep3C6.Enter, tb1Dep3C4.Enter, tb1Dep2C6.Enter, tb1Dep2C4.Enter, tb1Dep1C6.Enter, tb1Dep1C4.Enter, tb1Costo5C3.Enter, tb1Costo4C3.Enter, tb1Costo3C3.Enter, tb1Costo2C3.Enter, tb1Costo1C3.Enter, tbVehA.Enter, tbCV.Enter
		If FlagStart = True Then Exit Sub
		CurValue = ActiveControl.Text : CurValue = GetOnlyChars(CurValue)
		If Compdata.UltimaFormaUsada = "Sociedades" Then b = 8
		If Compdata.UltimaFormaUsada = "CorpIndv" Then b = 8
		If Compdata.UltimaFormaUsada = "IncentivosInd" Then b = 33
		FormLastFocus(b) = ActiveControl.Name
	End Sub

	Private Sub CheckFecha(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb3FechaAdq5C2.Validated, tb3FechaAdq4C2.Validated, tb3FechaAdq3C2.Validated, tb3FechaAdq2C2.Validated, tb3FechaAdq1C2.Validated, tb2FechaAdq5C2.Validated, tb2FechaAdq4C2.Validated, tb2FechaAdq3C2.Validated, tb2FechaAdq2C2.Validated, tb2FechaAdq1C2.Validated, tb1FechaAdq5C2.Validated, tb1FechaAdq4C2.Validated, tb1FechaAdq3C2.Validated, tb1FechaAdq2C2.Validated, tb1FechaAdq1C2.Validated
		If FlagStart = True Then Exit Sub
		If tb1FechaAdq1C2.Focused Then
			F = tb1FechaAdq1C2.Text
			If F = "" Then Exit Sub
			If Len(F) <> 6 And Len(F) <> 8 Then tb1FechaAdq1C2.Text = CurValue : tb1FechaAdq1C2.Focus() : Exit Sub
			VerificarFecha(F)
			If Tr = True Then tb1FechaAdq1C2.Text = CurValue : tb1FechaAdq1C2.Focus() : Exit Sub
			tb1FechaAdq1C2.Text = F
		End If
		If tb2FechaAdq1C2.Focused Then
			F = tb2FechaAdq1C2.Text
			If F = "" Then Exit Sub
			If Len(F) <> 6 And Len(F) <> 8 Then tb2FechaAdq1C2.Text = CurValue : tb2FechaAdq1C2.Focus() : Exit Sub
			VerificarFecha(F)
			If Tr = True Then tb2FechaAdq1C2.Text = CurValue : tb2FechaAdq1C2.Focus() : Exit Sub
			tb2FechaAdq1C2.Text = F
		End If
		If tb3FechaAdq1C2.Focused Then
			F = tb3FechaAdq1C2.Text
			If F = "" Then Exit Sub
			If Len(F) <> 6 And Len(F) <> 8 Then tb3FechaAdq1C2.Text = CurValue : tb3FechaAdq1C2.Focus() : Exit Sub
			VerificarFecha(F)
			If Tr = True Then tb3FechaAdq1C2.Text = CurValue : tb3FechaAdq1C2.Focus() : Exit Sub
			tb3FechaAdq1C2.Text = F
		End If
		If tb1FechaAdq2C2.Focused Then
			F = tb1FechaAdq2C2.Text
			If F = "" Then Exit Sub
			If Len(F) <> 6 And Len(F) <> 8 Then tb1FechaAdq2C2.Text = CurValue : tb1FechaAdq2C2.Focus() : Exit Sub
			VerificarFecha(F)
			If Tr = True Then tb1FechaAdq2C2.Text = CurValue : tb1FechaAdq2C2.Focus() : Exit Sub
			tb1FechaAdq2C2.Text = F
		End If
		If tb2FechaAdq2C2.Focused Then
			F = tb2FechaAdq2C2.Text
			If F = "" Then Exit Sub
			If Len(F) <> 6 And Len(F) <> 8 Then tb2FechaAdq2C2.Text = CurValue : tb2FechaAdq2C2.Focus() : Exit Sub
			VerificarFecha(F)
			If Tr = True Then tb2FechaAdq2C2.Text = CurValue : tb2FechaAdq2C2.Focus() : Exit Sub
			tb2FechaAdq2C2.Text = F
		End If
		If tb3FechaAdq2C2.Focused Then
			F = tb3FechaAdq2C2.Text
			If F = "" Then Exit Sub
			If Len(F) <> 6 And Len(F) <> 8 Then tb3FechaAdq2C2.Text = CurValue : tb3FechaAdq2C2.Focus() : Exit Sub
			VerificarFecha(F)
			If Tr = True Then tb3FechaAdq2C2.Text = CurValue : tb3FechaAdq2C2.Focus() : Exit Sub
			tb3FechaAdq2C2.Text = F
		End If
		If tb1FechaAdq3C2.Focused Then
			F = tb1FechaAdq3C2.Text
			If F = "" Then Exit Sub
			If Len(F) <> 6 And Len(F) <> 8 Then tb1FechaAdq3C2.Text = CurValue : tb1FechaAdq3C2.Focus() : Exit Sub
			VerificarFecha(F)
			If Tr = True Then tb1FechaAdq3C2.Text = CurValue : tb1FechaAdq3C2.Focus() : Exit Sub
			tb1FechaAdq3C2.Text = F
		End If
		If tb2FechaAdq3C2.Focused Then
			F = tb2FechaAdq3C2.Text
			If F = "" Then Exit Sub
			If Len(F) <> 6 And Len(F) <> 8 Then tb2FechaAdq3C2.Text = CurValue : tb2FechaAdq3C2.Focus() : Exit Sub
			VerificarFecha(F)
			If Tr = True Then tb2FechaAdq3C2.Text = CurValue : tb2FechaAdq3C2.Focus() : Exit Sub
			tb2FechaAdq3C2.Text = F
		End If
		If tb3FechaAdq3C2.Focused Then
			F = tb3FechaAdq3C2.Text
			If F = "" Then Exit Sub
			If Len(F) <> 6 And Len(F) <> 8 Then tb3FechaAdq3C2.Text = CurValue : tb3FechaAdq3C2.Focus() : Exit Sub
			VerificarFecha(F)
			If Tr = True Then tb3FechaAdq3C2.Text = CurValue : tb3FechaAdq3C2.Focus() : Exit Sub
			tb3FechaAdq3C2.Text = F
		End If
		If tb1FechaAdq4C2.Focused Then
			F = tb1FechaAdq4C2.Text
			If F = "" Then Exit Sub
			If Len(F) <> 6 And Len(F) <> 8 Then tb1FechaAdq4C2.Text = CurValue : tb1FechaAdq4C2.Focus() : Exit Sub
			VerificarFecha(F)
			If Tr = True Then tb1FechaAdq4C2.Text = CurValue : tb1FechaAdq4C2.Focus() : Exit Sub
			tb1FechaAdq4C2.Text = F
		End If
		If tb2FechaAdq4C2.Focused Then
			F = tb2FechaAdq4C2.Text
			If F = "" Then Exit Sub
			If Len(F) <> 6 And Len(F) <> 8 Then tb2FechaAdq4C2.Text = CurValue : tb2FechaAdq4C2.Focus() : Exit Sub
			VerificarFecha(F)
			If Tr = True Then tb2FechaAdq4C2.Text = CurValue : tb2FechaAdq4C2.Focus() : Exit Sub
			tb2FechaAdq4C2.Text = F
		End If
		If tb3FechaAdq4C2.Focused Then
			F = tb3FechaAdq4C2.Text
			If F = "" Then Exit Sub
			If Len(F) <> 6 And Len(F) <> 8 Then tb3FechaAdq4C2.Text = CurValue : tb3FechaAdq4C2.Focus() : Exit Sub
			VerificarFecha(F)
			If Tr = True Then tb3FechaAdq4C2.Text = CurValue : tb3FechaAdq4C2.Focus() : Exit Sub
			tb3FechaAdq4C2.Text = F
		End If
		If tb1FechaAdq5C2.Focused Then
			F = tb1FechaAdq5C2.Text
			If F = "" Then Exit Sub
			If Len(F) <> 6 And Len(F) <> 8 Then tb1FechaAdq5C2.Text = CurValue : tb1FechaAdq5C2.Focus() : Exit Sub
			VerificarFecha(F)
			If Tr = True Then tb1FechaAdq5C2.Text = CurValue : tb1FechaAdq5C2.Focus() : Exit Sub
			tb1FechaAdq5C2.Text = F
		End If
		If tb2FechaAdq5C2.Focused Then
			F = tb2FechaAdq5C2.Text
			If F = "" Then Exit Sub
			If Len(F) <> 6 And Len(F) <> 8 Then tb2FechaAdq5C2.Text = CurValue : tb2FechaAdq5C2.Focus() : Exit Sub
			VerificarFecha(F)
			If Tr = True Then tb2FechaAdq5C2.Text = CurValue : tb2FechaAdq5C2.Focus() : Exit Sub
			tb2FechaAdq5C2.Text = F
		End If
		If tb3FechaAdq5C2.Focused Then
			F = tb3FechaAdq5C2.Text
			If F = "" Then Exit Sub
			If Len(F) <> 6 And Len(F) <> 8 Then tb3FechaAdq5C2.Text = CurValue : tb3FechaAdq5C2.Focus() : Exit Sub
			VerificarFecha(F)
			If Tr = True Then tb3FechaAdq5C2.Text = CurValue : tb3FechaAdq5C2.Focus() : Exit Sub
			tb3FechaAdq5C2.Text = F
		End If
		setvar()
	End Sub

	Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
		Me.Close()
	End Sub
End Class