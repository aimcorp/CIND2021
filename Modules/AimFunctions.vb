Imports System
Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.Win32
Imports System.Math

Module AimFunctions
	Dim vz As String, bba As Integer

	Public Sub VerificarFecha(ByRef F)
		If F <> "" And Len(F) < 6 Then F = "" : Tr = True : Exit Sub
		ConvertAno4Dig(F)
		If F = "" Then Tr = True : Exit Sub
		Tr = FechaVer2(F)
	End Sub

	'Convertir dos digitos del ano a cuatro digitos
	'para cumplir con el ano 2000 compliant
	Public Function ConvertAno4Dig(ByRef Fec$)
		'fecha asi 01/01/1999" tiene "/" y todos los digitos  -SALE
		If InStr(Fec$, "/") <> 0 Then _
If Len(Fec$) = 10 And Mid(Fec$, 3, 1) = "/" And
		Mid(Fec$, 6, 1) = "/" Then Return Fec
		'fecha asi 01/01/97 tiene "/" y no año completo
		If InStr(Fec$, "/") <> 0 Then
			If Len(Fec$) = 8 And Mid(Fec$, 3, 1) = "/" And
				Mid(Fec$, 6, 1) = "/" Then _
					If Val(Mid(Fec$, 7, 2)) >= 21 Then _
							Fec$ = Left(Fec$, 6) & "19" & Mid(Fec$, 7, 2) : Return Fec
			If Val(Mid(Fec$, 7, 2)) < 21 Then _
				Fec$ = Left(Fec$, 6) & "20" & Mid(Fec$, 7, 2) : Return Fec
		End If
		Select Case Len(Fec$)
			Case 6  'fecha con seis digitos sin "/"
				If Val(Mid(Fec$, 5, 2)) >= 21 Then _
									Fec$ = Left(Fec$, 2) & "/" & Mid(Fec$, 3, 2) _
										& "/" & "19" & Mid(Fec$, 5, 2) : Return vbEmpty
				If Val(Mid(Fec$, 7, 2)) < 21 Then _
									Fec$ = Left(Fec$, 2) & "/" & Mid(Fec$, 3, 2) _
										& "/" & "20" & Mid(Fec$, 5, 2) : Return vbEmpty
			Case 8  'Fecha con ocho digitos sin "/"
				Fec$ = Left(Fec$, 2) & "/" & Mid(Fec$, 3, 2) _
							& "/" & Mid(Fec$, 5, 4) : Return Fec
		End Select
		Return False
	End Function

	'Verificar que la fecha sea valida * ESTA VERIFICA DD/MM/AAAA
	Public Function FechaVer2(ByVal FechaVeri As String)
		'FechaVer2 = True - Fecha es Mala
		'FechaVer2 = False - Fecha es Buena
		Dim ValDia As Integer, ValMes As Integer, ValAno As Integer
		FechaVer2 = True
		FechaVeri = Trim(FechaVeri)
		If InStr(FechaVeri, "/") = 1 Then Exit Function
		If InStr(FechaVeri, "/") = 0 Then
			FechaVeri = Left(FechaVeri, 2) & "/" & Mid(FechaVeri, 3, 2) & "/" & Mid(FechaVeri, 5, 4)
			x = ConvertAno4Dig(FechaVeri)
		End If
		ValMes = Val(Mid(FechaVeri, 4, 2))
		ValDia = Val(Left(FechaVeri, 2))
		If Len(FechaVeri) = 8 Then ValAno = Val(Right(FechaVeri, 2))
		If Len(FechaVeri) = 10 Then ValAno = Val(Right(FechaVeri, 4))
		'verificar mes y dia
		If ValMes < 1 Or ValMes > 12 Then Exit Function
		If ValDia < 1 Then Exit Function
		AnoBiciesto(ValAno)
		'verificar dia
		Select Case ValMes
			Case 1, 3, 5, 7, 8, 10, 12
				If ValDia > 31 Then Exit Function
			Case 2
				If ValDia > ValAno Then Exit Function
			Case 4, 6, 9, 11
				If ValDia > 30 Then Exit Function
		End Select
		Return False
	End Function

	'Verificar si es Año Biciesto o No
	Public Sub AnoBiciesto(ByRef Ano As Integer)
		Dim wrd As String
		wrd = CStr(Ano)
		wrd = Trim(wrd)
		If Len(wrd) = 2 Then
			If Ano > 22 Then
				Ano = Ano + 1900
			Else
				Ano = 2000
			End If
		End If
		If (Ano Mod 400) = 0 Then Ano = 29 : Exit Sub
		If (Ano Mod 100) = 0 Then Ano = 28 : Exit Sub
		If (Ano Mod 4) = 0 Then Ano = 29 : Exit Sub
		Ano = 28
	End Sub

	Public Function FormatNow()  'Format fecha de hoy
		Dim ba As String, bb As String, bc As String
		b = Format("#m/#d/yyyy", Now)
		ba = b.Substring(0, 2) : bb = b.Substring(3, 2) : bc = b.Substring(6, 4)
		b = ba & bb & bc
		Return b
	End Function

	Public Function VerifyFechaFutura(ByVal F As String) As Boolean 'verify if date is pass the end of submitting year for CPW
		Dim d As String, m As String, y As String
		Dim fac As String, Fc1 As String, Fc2 As String
		Try
			d = F.Substring(0, 2) : m = F.Substring(3, 2) : y = F.Substring(6, 4)
			fac = DateSerial(y, m, d)
			Fc1 = Format("#m/#d/yyyy", fac)
			Fc2 = Format("mm/dd/yyyy", "12/31/" & AnoInUse + 1)
			If CDate(Fc1) > CDate(Fc2) Then Return True Else Return False
		Catch ex As Exception
		End Try
	End Function

	Function EmailAddressCheck(ByVal emailAddress As String) As Boolean
		Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
		Dim emailAddressMatch As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(emailAddress, pattern)
		If emailAddressMatch.Success Then
			Return True
		Else
			Return False
		End If
	End Function

	Public Function GetOnlyChars(ByRef vr As String)
		Dim s As String = vr.ToString
		s = s.Replace(")", "") : s = s.Replace("(", "") : s = s.Replace("-", "") : s = s.Replace("_", "") : s = s.Replace("/", "")
		s = Trim(s)
		Return s
	End Function

	'patronal
	Public Function CheckEmployerSocSec(ByRef c As String) As Byte
		c = c.Replace("_", "") : c = c.Replace("-", String.Empty) : c = Trim(c) : If c = "" Then Return 200 : Exit Function
		If c.Length = 9 Then Return True Else Return False
	End Function

	Public Function BytesLen()
		Dim varlen As Integer
		VarToRW = Trim(VarToRW) : varlen = Len(VarToRW) : LenToRW = CStr(varlen)
		If varlen < 10 Then LenToRW = "00" & LenToRW : GoTo 10
		If varlen < 100 Then LenToRW = "0" & LenToRW
10: Return Nothing
	End Function

	Public Sub ParseString()    'parse pipe |
		Try
			i2 = InStr(valor, "|") : i3 = Len(valor) : i4 = Trim(Len(Mid(valor, i2, i3)))
			Valor1 = Left(valor, i2 - 1) : Valor2 = Right(valor, i4 - 1)
		Catch
			Valor1 = ""
			Valor2 = valor
		End Try
	End Sub

	Public Function ParseAmtAntesPunto2(ByRef c)
		If InStr(c, ".") > 0 Then ib = InStr(c, ".") : c = Left(c, ib - 1) : c = Trim(c)
		Return c
	End Function

	'Eliminar caracteres deseado
	Public Function ParseChar(ByVal word As String, ByRef a As String)
		'Syntax > ParseChar Word, Char
		Dim x As String, Ix As Integer
		x = ""
		For Ix = 1 To Len(word)
			If Mid(word, Ix, 1) <> a Then x = x & Mid(word, Ix, 1)
		Next Ix
		word = Trim(x) : Return x
	End Function

	'Parameters:   Reemplazar un string con otro
	'sOriginal es palabra original
	'sLookFor es lo que va a buscar en la palabra original
	'srStlaceWith es, si lo encuentra lo reemplaza y devuelve una nueva palabra
	Public Function ChangeChar(ByVal sOriginal As String, ByVal sLookFor As String,
		ByVal srStlaceWith As String) As String
		Dim iStart As Integer = 1, intStrLen As Integer = Len(srStlaceWith)
		Do
			iStart = InStr(iStart, sOriginal, sLookFor)
			If iStart > 0 Then
				sOriginal = Left(sOriginal, iStart - 1) + srStlaceWith + Mid(sOriginal, iStart + Len(sLookFor))
				iStart = iStart + intStrLen
			End If
		Loop Until iStart = 0
		Return sOriginal
	End Function

	Public Sub CambiarNumAMes(ByVal Nm As Byte, ByRef ms As String, ByVal Tp As Boolean)
		Select Case Tp
			Case False  'Mes corto
				If Nm = 1 Then ms = "Ene"
				If Nm = 2 Then ms = "Feb"
				If Nm = 3 Then ms = "Mar"
				If Nm = 4 Then ms = "Abr"
				If Nm = 5 Then ms = "May"
				If Nm = 6 Then ms = "Jun"
				If Nm = 7 Then ms = "Jul"
				If Nm = 8 Then ms = "Ago"
				If Nm = 9 Then ms = "Sep"
				If Nm = 10 Then ms = "Oct"
				If Nm = 11 Then ms = "Nov"
				If Nm = 12 Then ms = "Dic"
			Case True   'mes largo
				If Nm = 1 Then ms = "Enero"
				If Nm = 2 Then ms = "Febrero"
				If Nm = 3 Then ms = "Marzo"
				If Nm = 4 Then ms = "Abril"
				If Nm = 5 Then ms = "Mayo"
				If Nm = 6 Then ms = "Junio"
				If Nm = 7 Then ms = "Julio"
				If Nm = 8 Then ms = "Agosto"
				If Nm = 9 Then ms = "Septiembre"
				If Nm = 10 Then ms = "Octubre"
				If Nm = 11 Then ms = "Noviembre"
				If Nm = 12 Then ms = "Diciembre"
		End Select
		Answer = 0
	End Sub

	'Esta funcion Salva cada string antes del pipe "|" y el ultimo tambien
	'  ej. "ariel|maisonet|morales", retorna "ariel", "maisonet","morales" en p1()
	Public Sub StrSavePipe(ByVal wrd As String, ByRef p1() As String, ByRef z3 As Byte)
		Dim o As Integer, i3 As Integer, y As Short
		If Trim(wrd) = "" Then Exit Sub
		For i3 = 0 To z3 : p1(i3) = "" : Next i3
		'primera palabra
		y = 1 : z3 = 0 : x = InStr(y, wrd, "|") : o = x + 1 : y = o
		If x = 0 Then p1(z3) = Mid(wrd, o, 255) : Exit Sub
		If x > 0 Then p1(z3) = Left(wrd, x - 1)

33:     'segunda palabra en adelante
		z3 = z3 + 1
		x = InStr(y, wrd, "|") : If x = 0 Then p1(z3) = Mid(wrd, o, 60) : Exit Sub
		If x > 0 Then p1(z3) = Mid(wrd, o, x - o)
		o = x + 1 : y = o : GoTo 33
	End Sub

	Public Sub DisableUAC()
		Dim regKey As RegistryKey
		Dim ver As Decimal
		Dim keyst As String = "Software\Microsoft\Windows\CurrentVersion\Policies\System"
		regKey = Registry.LocalMachine.OpenSubKey(keyst, True)
		ver = regKey.GetValue("EnableLUA", 0.0)
		If ver = 1.0 Then
			My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\System", "EnableLUA", 0)
		End If
		regKey.Close()
	End Sub

	'example what is needed before calling the function
	'c = spanish data without braket 'get fecha inicial
	'c = c.Substring(2, 2) & "/" & c.Substring(0, 2) & "/" & c.Substring(4, 4) 'convert to formated date
	'i2 = DateSerialF(c) 'call the function

	Public Function DateSerialF(ByRef F As String)
		Dim di As String = Left(F, 2)
		Dim ms As String = Mid(F, 4, 2)
		Dim yr As String = Right(F, 4)
		Return DateSerial(yr, ms, di).ToOADate
	End Function

	'fecha Diff -Devuelve la dif en fechas en dias, meses o anos
	'tp="d" dia / "m" mes /"y" año : Fc1 Fecha ano actual / Fc2 Fecha a Verificar dif
	Public Function FechaDiff(ByVal tp As String, ByVal Fc1 As String, ByRef Fc2 As String)
		Try
			Dim dt1 As Date = Fc1, dt2 As Date = Fc2
			If tp = "d" Then Dim df As Long = DateDiff(DateInterval.Day, dt1, dt2) : Fc2 = df
			If tp = "m" Then Dim dm As Long = DateDiff(DateInterval.Month, dt1, dt2) : Fc2 = dm
			If tp = "y" Then Dim dy As Long = DateDiff(DateInterval.Year, dt1, dt2) : Fc2 = dy
		Catch ex As Exception
			Return Fc2 = "0"
		End Try
		Return Fc2
	End Function

	Public Function SSFormatP(ByVal b)  'formatear seg soc Emp
		If Trim(b) = "" Then Return b
		Dim w As String
		c = Left(b, 2)
		w = Mid(b, 3, 7)
		b = c & "-" & w
		Return b
	End Function

	Public Function SSFormatE(ByRef b)  'formatear seg soc Pat
		If Trim(b) = "" Then Return b
		Dim w As String, z As String
		c = Left(b, 3) : w = Mid(b, 4, 2) : z = Right(b, 4)
		b = c & "-" & w & "-" & z
		Return b
	End Function

	'funcion para formatear num telefono   n = 0 formato 787-257-6566  / n = 1 formato (787) 258-6576
	Public Function FormatTel(ByRef nt As String, ByVal n As Byte)
		If nt = "" Then vz = "" : Return vz
		If n = 0 Then vz = Left(nt, 3) & "-" & Mid(nt, 4, 3) & "-" & Right(nt, 4)
		If n = 1 Then vz = "(" & Left(nt, 3) & ") " & Mid(nt, 4, 3) & "-" & Right(nt, 4)
		Return vz
	End Function

	Public Function FormatFecha(ByRef vz As String)
		If Val(Left(vz, 2)) = 0 Then vz = "" : Return vz
		vz = Left(vz, 2) & "/" & Mid(vz, 3, 2) & "/" & Right(vz, 4)
		Return vz
	End Function

	'convertir el Zip Code a un String Completo
	' para mostrarse en Encasillados
	Public Function ZipChange(ByRef Revar As String) As String
		If Revar = "" Then b = "" : b1 = "" : Return Revar
		If Len(Revar) = 6 Then If Mid(Revar, 6, 1) = "-" Then c = Revar & "0000" : GoTo 20
		If Len(Revar) = 3 Then c = "00" & Revar & "-0000" : GoTo 20
		If Len(Revar) = 5 Then c = Revar & "-0000" : GoTo 20
		If Len(Revar) = 6 Then c = Left(Revar, 5) & "-" & Right(Revar, 4) : GoTo 20
		If Len(Revar) = 7 Then c = "00" & Left(Revar, 3) & "-" & Right(Revar, 4) : GoTo 20
		If Len(Revar) = 8 Then c = Left(Revar, 5) & "-" & Right(Revar, 3) : GoTo 20
		If Len(Revar) = 9 Then c = Left(Revar, 5) & "-" & Right(Revar, 4) : GoTo 20
		'get each part
20: b = Left(c, 5) : b1 = Right(c, 4) : Revar = b & "-" & b1
		Return Revar
	End Function

	Public Function AddValue()    'b = 1505 : For i = 15 To UBound(IiN0) : b = AddValue() : IiN0(i) = b : Next
		b = b + 5
		Return b
	End Function

	Public Sub VerNumTelefono()
		Answer = True
		If c = "1111111111" Then Exit Sub
		If c = "2222222222" Then Exit Sub
		If c = "3333333333" Then Exit Sub
		If c = "4444444444" Then Exit Sub
		If c = "5555555555" Then Exit Sub
		If c = "6666666666" Then Exit Sub
		If c = "7777777777" Then Exit Sub
		If c = "8888888888" Then Exit Sub
		If c = "9999999999" Then Exit Sub
		If c = "0000000000" Then Exit Sub
		Answer = False
	End Sub

	Function GetRight(vr As String, x As Integer)  'to get last three chars of a filename (the extension without perior) example: "cpn"
		Dim vv As String = Right(vr, x)
		Return vv
	End Function

	Function TrimLZeros(ib As String) 'funcion para eliminar ceros antes de un numero ej. "0500" <<eliminar primer cero
		If Val(ib) = 0 Then vz = "" : GoTo 10
		x = Len(ib)
		'buscar primer numero
		For i As Integer = 1 To x
			If Val(Mid(ib, i, 1)) > 0 Then vz = Mid(ib, i, 5000) : vz = Trim(vz) : GoTo 10
5: Next
		vz = ib
10: Return vz
	End Function

	Sub VerifyNoMorethanAYear() 'verificar que no pase de un ano y que no sea anterior al ano adquirido
		Dim f2 As String = f, f3 As String = b, b2 As String
		answer = 0
		'fecha adq
		b1 = Mid(f3, 1, 2) & "/" & Mid(f3, 3, 2) & "/" & Right(f3, 4) : i3 = DateSerialF(b1)  'Fecha adq
		'fecha ven
		b2 = Mid(f2, 1, 2) & "/" & Mid(f2, 4, 2) & "/" & Right(f2, 4) : i4 = DateSerialF(b2)  'Fecha Venta
		If i4 < i3 Then answer = 132 : Exit Sub 'fecha de venta es menor que fecha adq
		b = i4 - i3 : If Abs(Val((b))) > 365 Then answer = 132 'fecha de venta es mas de un ano
	End Sub

	Sub Errhold()
		MsgBox(b, MsgBoxStyle.DefaultButton1)
	End Sub

	Public Function ParseAmtToCompletePercentage() 'convertir un numero a porciento con cuatro decimales
		'con punto y con menos de cuatro caracteres despues del punto
		If c = "" Then Exit Function
		If InStr(c, ".") = 0 And c <> "" Then c = c & ".0000" : GoTo 10

		If InStr(c, ".") > 0 Then
			ib = InStr(c, ".") : b1 = Left(c, ib - 1)
			c1 = Mid(c, ib + 1, 4) & "0000" : c1 = Left(c1, 4)
			c = b1 & "." & c1 : GoTo 10
		End If
10: Return c
	End Function

	Public Function VerifyAcceptedAllChars()   'No aceptar Otros caracteres que no sean los normales (aqui incluye numeros o letras)
		Answer = 0
		Dim StrLength As Int32 = Len(c)
		If StrLength = 0 Then c = "" : GoTo 12
		For x = 1 To StrLength
			b1 = Mid$(c, x, 1) : bba = Asc(b1)
			If bba = 209 Or bba = 201 Or bba = 193 Or bba = 205 Or bba = 211 Or bba = 218 Then GoTo 10 'estas son á é í ó ú ñ Ñ
			If bba >= 94 And bba < 97 Then c = c.Substring(0, StrLength - 1) : Answer = 116 : GoTo 12
			If bba >= 123 And bba <= 129 Then c = c.Substring(0, StrLength - 1) : Answer = 116 : GoTo 12
			If bba >= 131 Then c = c.Substring(0, StrLength - 1) : Answer = 116 : GoTo 12
10: Next
12: Return c
	End Function

	Public Function VerifyAcceptedOnlyChars()   'Aceptar solo caracteres que no sean numeros
		Answer = 0
		Dim StrLength As Int32 = Len(c)
		If StrLength = 0 Then c = "" : GoTo 12
		For x = 1 To StrLength
			b1 = Mid$(c, x, 1) : bba = Asc(b1)
			If bba >= 48 And bba < 58 Then c = c.Substring(0, StrLength - 1) : Answer = 116 : GoTo 12
			If bba = 209 Or bba = 201 Or bba = 193 Or bba = 205 Or bba = 211 Or bba = 218 Then GoTo 10 'estas son á é í ó ú ñ Ñ
			If bba >= 94 And bba < 97 Then c = c.Substring(0, StrLength - 1) : Answer = 116 : GoTo 12
			If bba >= 123 And bba <= 129 Then c = c.Substring(0, StrLength - 1) : Answer = 116 : GoTo 12
			If bba >= 131 Then c = c.Substring(0, StrLength - 1) : Answer = 116 : GoTo 12
10: Next
12: Return c
	End Function

	Public Function VerifyAcceptedOnlyNumbers()   'Aceptar solo Numeros
		Answer = 0
		Dim StrLength As Int32 = Len(c)
		If StrLength = 0 Then c = "" : GoTo 12
		For x = 1 To StrLength
			b1 = Mid$(c, x, 1) : bba = Asc(b1)
			If bba < 48 Or bba >= 58 Then c = c.Substring(0, StrLength - 1) : Answer = 116 : GoTo 12
10: Next
12: Return c
	End Function
End Module


