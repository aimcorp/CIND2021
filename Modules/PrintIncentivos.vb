Imports Gnostice.PDFOne
Imports Gnostice.PDFOne.PDFPrinter
Imports Gnostice.PDFOne.PDFProAnnot

Module PrintIncentivos
	Dim ms As String, Pan As Byte, can As Byte, vtn(0) As String

	'''''''''''''''' ANO 2020 ''''''''''''''''''''''

	Sub PrintIncentivosCmd01()
		FileToOpen = "Desarrollo-Ind-2014-DIP1.pdf" : UnzipFile(AppDir & "CproIncentivos-DI14.dll", FileToOpen)
		FileToSave = AppDir & "AimPr\" & FileToOpen
		If Answer = 255 Then Answer = False : Exit Sub
		PTy = 1 : MargL = 0 : MargR = 0 : MargT = 0 : MargB = 0
		With Imprimir
			.InitializePDFControl()
		End With
	End Sub

	Private Sub PrintIncentivos14DIP1()
		FileToOpen = "Desarrollo-Ind-2014-DIP1.pdf" : UnzipFile(AppDir & "CproIncentivos-DI14.dll", FileToOpen)
		FileToSave = AppDir & "AimPr\" & FileToOpen
		If Answer = 255 Then Answer = False : Exit Sub
		PTy = 1 : MargL = 0 : MargR = 0 : MargT = 0 : MargB = 0
		With Imprimir
			.InitializePDFControl()

			'ano
			b = AnoInUse : CuY = 23
			Cux = 162 : .PrintAumText(12)
			Cux = 390 : .PrintAumText(12)


			'Date from
			CuY = 86
			b = Left(IiP1(0), 2) : Cux = 174 : .PrintText()
			ms = "" : Answer = Val(Mid(IiP1(0), 3, 2)) : CambiarNumAMes(Answer, ms, False)
			b = ms : Cux = 208 : .PrintText()
			b = Right(IiP1(0), 2) : Cux = 252 : .PrintText()
			'date to
			b = Left(IiP1(1), 2) : Cux = 315 : .PrintText()
			ms = "" : Answer = Val(Mid(IiP1(1), 3, 2)) : CambiarNumAMes(Answer, ms, False)
			Answer = 0 : b = ms : Cux = 352 : .PrintText()
			b = Right(IiP1(1), 2) : Cux = 395 : .PrintText()
			If FPrt = True Then .ProgressBar1.Value = 10

			Cux = 40 : CuY = 108 : b = IiP1(2) : .PrintText2()
			CuY = 130 : b = IiP1(3) : .PrintText2()
			CuY = 142 : b = IiP1(4) : .PrintText2()
			CuY = 154 : b = IiP1(5) : .PrintText2()
			Cux = 165 : b = IiP1(6) : .PrintText2()
			Cux = 243 : b = IiP1(7) : c = ZipChange(b) : If Val(b1) <> 0 Then b = b & "-" & b1
			.PrintText2()
			'ss
			Cux = 335 : CuY = 106 : b = IiP1(8) : b = SSFormatP(b) : .PrintText2()
			CuY = 125 : b = IiP1(9) : .PrintText2()
			CuY = 142 : Cux = 325 : b = IiP1(10) : .PrintText2()
			Cux = 380 : b = IiP1(11) : .PrintText2()
			CuY = 161 : Cux = 335 : b = IiP1(19) : .PrintText2()
			CuY = 181 : Cux = 320 : b = IiP1(12) : b = FormatTel(b, 1) : .PrintText2()
			Cux = 390 : b = IiP1(13) : .PrintText2()
			If FPrt = True Then .ProgressBar1.Value = 20

			CuY = 202 : Cux = 40
			b = Left(IiP1(14), 2) : Cux = 330 : .PrintText2()
			b = Mid(IiP1(14), 3, 2) : Cux = 362 : .PrintText2()
			b = Right(IiP1(14), 2) : Cux = 399 : .PrintText2()
			Cux = 326 : CuY = 222 : b = IiP1(15) : .PrintText2()
			Cux = 310 : b = IiP1(16)
			If Len(b) > 20 Then CuY = 241 : .PrintReduceText(6) Else CuY = 238 : .PrintText2()
			Cux = 42 : CuY = 180 : b = IiP1(17) : .PrintText2()
			b = IiP1(18)
			If Len(b) > 29 Then Cux = 42 : CuY = 217 : .PrintReduceText(6) Else Cux = 42 : CuY = 215 : .PrintText2()

			'tipo entidad
			Cux = 430 : CuY = 239 : b = IiP1(27) : .PrintText2()
			'numero grupo
			Cux = 430 : CuY = 284 : b = IiP1(90) : .PrintText2()

			If FPrt = True Then .ProgressBar1.Value = 30

			'OVALS
			'planilla enmendada
			If IiP1(23) = "1" Then ovT = 629 : ovL = 551 : .PrintSOvals()
			'cambio dir
			ovT = 219 : b = ""
			If IiP1(21) = "1" Then ovL = 222 : .PrintSOvals()
			If IiP1(21) = "0" Then ovL = 250 : .PrintSOvals()
			'contra gub
			ovT = 240 : b = ""
			If IiP1(20) = "1" Then ovL = 82 : .PrintSOvals()
			If IiP1(20) = "0" Then ovL = 122 : .PrintSOvals()
			'plan esp/ing
			ovT = 240 : b = ""
			If IiP1(22) = "1" Then ovL = 210 : .PrintSOvals()
			If IiP1(22) = "0" Then ovL = 262 : .PrintSOvals()
			'miembro grupo entidades
			ovT = 260 : b = ""
			If IiP1(28) = "1" Then ovL = 468 : .PrintSOvals()
			If IiP1(28) = "0" Then ovL = 501 : .PrintSOvals()
			'ing parc exento
			ovL = 27 : b = "" : Cux = 200
			If IiP1(25) = "1" Then ovT = 262 : .PrintSOvals() : CuY = 259 : b = IiP1(26) : .PrintText2()
			If IiP1(25) = "2" Then ovT = 273 : .PrintSOvals() : CuY = 270 : b = IiP1(26) : .PrintText2()
			If IiP1(25) = "3" Then ovT = 283 : .PrintSOvals() : CuY = 280 : b = IiP1(26) : .PrintText2()
			If IiP1(25) = "7" Then ovT = 294 : .PrintSOvals() : CuY = 291 : b = IiP1(26) : .PrintText2()

			If FPrt = True Then .ProgressBar1.Value = 40

			'cantidades
			Cu0 = 397 : Cu1 = 492

			Cux = Cu0
			CuY = 304 : b = IiP1(100) : .PrintAlignRight2()
			CuY = 314 : b = IiP1(32) : .PrintAlignRight2()
			CuY = 323 : b = IiP1(29) : .PrintAlignRight2()
			CuY = 333 : b = IiP1(113) : .PrintAlignRight2()
			CuY = 343 : b = IiP1(101) : .PrintAlignRight2()

			If FPrt = True Then .ProgressBar1.Value = 50

			Cux = Cu1
			CuY = 353 : b = IiP1(34) : .PrintAlignRight2()

			Cux = Cu0
			CuY = 363 : b = IiP1(36) : .PrintAlignRight2()
			CuY = 373 : b = IiP1(41) : .PrintAlignRight2()
			CuY = 383 : b = IiP1(42) : .PrintAlignRight2()
			CuY = 401 : b = IiP1(43) : .PrintAlignRight2()
			CuY = 411 : b = IiP1(44) : .PrintAlignRight2()
			CuY = 421 : b = IiP1(45) : .PrintAlignRight2()
			CuY = 430 : b = IiP1(46) : .PrintAlignRight2()

			If FPrt = True Then .ProgressBar1.Value = 60

			Cux = Cu1
			CuY = 440 : b = IiP1(47) : .PrintAlignRight2()

			Cux = Cu0
			CuY = 452 : b = IiP1(48) : .PrintAlignRight2()
			CuY = 463 : b = IiP1(49) : .PrintAlignRight2()
			CuY = 474 : b = IiP1(50) : .PrintAlignRight2()

			If FPrt = True Then .ProgressBar1.Value = 70

			Cux = Cu1
			CuY = 484 : b = IiP1(51) : .PrintAlignRight2()
			CuY = 494 : b = IiP1(52) : .PrintAlignRight2()
			CuY = 504 : b = IiP1(53) : .PrintAlignRight2()
			CuY = 514 : b = IiP1(54) : .PrintAlignRight2()
			CuY = 523 : b = IiP1(55) : .PrintAlignRight2()
			CuY = 533 : b = IiP1(59) : .PrintAlignRight2()
			CuY = 542 : b = IiP1(103) : .PrintAlignRight2()
			CuY = 553 : b = IiP1(56) : .PrintAlignRight2()

			If FPrt = True Then .ProgressBar1.Value = 80

			If Compdata.EspImpDatos = True Then
				CuY = 678
				'nombre esp
				Cux = 30 : b = EspData.EspNom : .PrintText2()
				'numero reg
				Cux = 390 : b = EspData.EspReg : .PrintText2()
				'nombre firma
				CuY = 700 : b = EspData.EspNomPatr : Cux = 30 : .PrintText2()

				If FPrt = True Then Imprimir.ProgressBar1.Value = 90

				'cta propia
				If EspData.EspCProp = True Then b = "x" : CuY = 700 : Cux = 523 : .PrintText2()

				'direccion 1 y 2
				Cux = 310
				CuY = 693 : b = EspData.EspDir1 & " " & EspData.EspDir2 : .PrintText2()
				CuY = 702 : b = EspData.EspMun & " " & EspData.EspPais & " " & EspData.EspZip : .PrintText2()

				'pago por hacer plan
				ovT = 745 : ovL = 253 : .PrintSOvals()

			Else
				'sin datos de esp
				ovT = 745 : ovL = 278 : .PrintSOvals()
			End If

			If FPrt = True Then .ProgressBar1.Value = 100 : .PrintNow() : .ProgressBar1.Value = 0

		End With
	End Sub


End Module
