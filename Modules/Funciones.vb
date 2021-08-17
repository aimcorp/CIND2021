Module Funciones
Sub RandomNumber()
  Dim Lo!, Hi!, Rand#
  'get random number
  Lo! = 21000 : Hi! = 71000 : Randomize()
  Rand# = Int((Hi! - Lo! + 1) * Rnd() + Lo!)
  Revar = Trim(Str(Rand#)) 'change number to string
End Sub

Public Sub VerifySegSocialBen(ByVal Sdr)
cuz = 0
If c = "" Then Exit Sub
'If Sdr <> "mtbNumSSCont" And c = Dg(4) Then GoTo MensajeAbajo

'Repetitivos =====================================================
NumeroRepetitivos()
If answer = 90 Then GoTo MensajeAbajo
Exit Sub

MensajeAbajo:
Cuz = 5 : MsgId = "NumSegSocMal" : ErrMsgDialog.ShowDialog()
End Sub

Sub NumeroRepetitivos()
answer = 0
If c = "000000000" Then answer = 90 : Exit Sub
If c = "111111111" Then answer = 90 : Exit Sub
If c = "222222222" Then answer = 90 : Exit Sub
If c = "333333333" Then answer = 90 : Exit Sub
If c = "444444444" Then answer = 90 : Exit Sub
If c = "555555555" Then answer = 90 : Exit Sub
If c = "666666666" Then answer = 90 : Exit Sub
If c = "777777777" Then answer = 90 : Exit Sub
If c = "888888888" Then answer = 90 : Exit Sub
If c = "999999999" Then answer = 90 : Exit Sub
  'Consecutivos
If c = "012345678" Then answer = 90 : Exit Sub
If c = "123456789" Then answer = 90 : Exit Sub
If c = "234567890" Then answer = 90 : Exit Sub
If c = "345678901" Then answer = 90 : Exit Sub
If c = "456789012" Then answer = 90 : Exit Sub
If c = "567890123" Then answer = 90 : Exit Sub
If c = "678901234" Then answer = 90 : Exit Sub
If c = "789012345" Then answer = 90 : Exit Sub
If c = "890123456" Then answer = 90 : Exit Sub
If c = "901234567" Then answer = 90 : Exit Sub
End Sub

 Sub SetTipoEntidad()
  If b = 0 Then c = "CDASSC"
  If b = 1 Then c = "OTHER"
  If b = 2 Then c = "PFASSC"
  If b = 3 Then c = "RSASSC"
  If b = 4 Then c = "CRCOOP"
  If b = 5 Then c = "GNCOOP"
  If b = 6 Then c = "SGCOOP"
  If b = 7 Then c = "YTCOOP"
  If b = 8 Then c = "CLCORP"
  If b = 9 Then c = "FRCORP"
  If b = 10 Then c = "LCCORP"
  If b = 11 Then c = "LWCORP"
  If b = 12 Then c = "NPCORP"
  If b = 13 Then c = "PBCORP"
  If b = 14 Then c = "PRCORP"
  If b = 15 Then c = "PRSERV"
  If b = 16 Then c = "EXEPTENTITY"
  If b = 17 Then c = "INSCOMP"
  If b = 18 Then c = "INVESTCOMP"
  If b = 19 Then c = "GNPART"
  If b = 20 Then c = "RTTRUST"
  If b = 21 Then c = "STCORP"
  If b = 22 Then c = "RGCORP"
  If b = 23 Then c = "CRCOOP"
  If b = 24 Then c = "GNCOOP"
  If b = 25 Then c = "YTCOOP"
 End Sub
End Module
