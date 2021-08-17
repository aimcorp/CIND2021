Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports NaicsSearch
Imports System.Math

Public Class IncentPagina1
 'veriaim
 Dim FlagStart As Boolean, actualCtrl As String, ReplaceVar As String, ActCtl As String

 Public Sub New()
  ' This call is required by the designer.
  InitializeComponent() : ReSize1.Enabled = True : Me.WindowState = FormWindowState.Minimized
 End Sub

 Private Sub IncentPagina1_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
  Me.WindowState = FormWindowState.Maximized
 End Sub

 Private Sub IncentPagina1_Load(sender As Object, e As EventArgs) Handles Me.Load
  FlagStart = True
  UsePage = "IncentivosPag1" : PIm = 0 : MdiMain.tbIncPag1.Checked = True : Compdata.UltimaFormaUsada = "IncentivosInd"

  'Que Planilla   
  If IiP1(2) = "" Then IiP1(2) = "01"
  If IiP1(2) = "01" Then ComboBox1.SelectedIndex = 0
  If IiP1(2) = "02" Then ComboBox1.SelectedIndex = 1
  If IiP1(2) = "03" Then ComboBox1.SelectedIndex = 2
  If IiP1(2) = "04" Then ComboBox1.SelectedIndex = 3
  If IiP1(2) = "05" Then ComboBox1.SelectedIndex = 4
  If IiP1(2) = "06" Then ComboBox1.SelectedIndex = 5
  If IiP1(2) = "07" Then ComboBox1.SelectedIndex = 6
  If IiP1(2) = "08" Then ComboBox1.SelectedIndex = 7
  If IiP1(2) = "09" Then ComboBox1.SelectedIndex = 8
  If IiP1(2) = "10" Then ComboBox1.SelectedIndex = 9

  FillInputVar() : FillControls() : ResetTabstop()

  For Each CrR As Control In Me.Controls
   If CrR.Name = FormLastFocus(0) Then CrR.Focus() : c = CrR.Text : CurValue = GetOnlyChars(c) : Exit For
  Next CrR

  FlagStart = False
 End Sub

 Sub ResetTabstop()
  ck1.TabStop = False : ck2.TabStop = False : ck3.TabStop = False : ck4.TabStop = False
  rb01.TabStop = False : rb02.TabStop = False : rb03.TabStop = False : rb04.TabStop = False
  rbA1.TabStop = False : rbA2.TabStop = False : rbB1.TabStop = False : rbB2.TabStop = False

 End Sub

 Private Sub ShowTagBarraDeAyuda(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPaisPos.Enter, tbPaisFis.Enter, tbNomNeg.Enter, tbMunPos.Enter, tbMunFis.Enter, tbLugInc.Enter, tbLocNeg.Enter, tbEmail.Enter, tbDirPost2.Enter, tbDirPost1.Enter, tbDirFisi2.Enter, tbDirFisi1.Enter, tbNGru.Enter, mtelefono.Enter, mFecInc.Enter, mAnoComT.Enter, mAnoComP.Enter, tbNumCom.Enter, tbNumDEst.Enter, tbNumMfg.Enter, tbExten.Enter, mCodNaics.Enter, tbE05.Enter, tbE04.Enter, tbE03.Enter, tbE02.Enter, tbE01.Enter, tb26.Enter, tb25.Enter, tb20.Enter, tb19.Enter, tb17.Enter, tb16.Enter, tb15.Enter, tb14.Enter, tb13.Enter, tb12.Enter, tb11.Enter, tb24.Enter, tb10.Enter, tb09.Enter, tb08.Enter, tb07.Enter, tb05.Enter, tb04.Enter, tb03.Enter, tb02.Enter, tb01.Enter
  If FlagStart = True Then Exit Sub
  CurValue = ActiveControl.Text : CurValue = GetOnlyChars(CurValue)
  FormLastFocus(0) = sender.Name
 End Sub

 Private Sub ClearScreen()
  FlagStart = True
  mAnoComP.Text = "" : mAnoComT.Text = "" : mFecInc.Text = "" : mCodNaics.Text = "" : mZonaPos.Text = "" : mZonaFis.Text = "" : tbNomNeg.Text = "" : tbPaisPos.Text = "" : tbPaisFis.Text = ""
  tbMunPos.Text = "" : tbMunFis.Text = "" : tbLugInc.Text = "" : tbLocNeg.Text = "" : tbEmail.Text = "" : tbDirPost2.Text = "" : tbDirPost1.Text = "" : tbDirFisi2.Text = "" : tbDirFisi1.Text = ""
  tbNumCom.Text = "" : tbNumDEst.Text = "" : tbNumMfg.Text = "" : tbCodTipo.Text = "" : tbNGru.Text = "" : tbNGru.Text = "" : tbExten.Text = "" : tbE05.Text = "" : tbE04.Text = "" : tbE03.Text = ""
  tbE02.Text = "" : tbE01.Text = "" : tb01.Text = "" : tb02.Text = "" : tb03.Text = "" : tb04.Text = "" : tb05.Text = "" : tb06.Text = "" : tb07.Text = "" : tb08.Text = "" : tb09.Text = ""
  tb10.Text = "" : tb11.Text = "" : tb12.Text = "" : tb13.Text = "" : tb14.Text = "" : tb15.Text = "" : tb16.Text = "" : tb17.Text = "" : tb18.Text = "" : tb19.Text = "" : tb20.Text = "" : tb21.Text = ""
  tb22.Text = "" : tb23.Text = "" : tb24.Text = "" : tb25.Text = "" : tb26.Text = "" : tbTotal01.Text = "" : tbTotal02.Text = "" : tbTotal03.Text = "" : tbTotal04.Text = ""
  ck1.Checked = False : ck2.Checked = False : ck3.Checked = False : ck4.Checked = False
  rb01.Checked = True : rbA2.Checked = True : rbB2.Checked = True
 End Sub

 Private Sub FillInputVar()
  'Tipo Entidad
  b = Val(IiP1(28)) : If IiP1(28) = "" Then IiP1(28) = "22"
  SetTipoEntidad() : tbCodTipo.Text = c : ComboBox2.SelectedIndex = b
  'Tipo Ano
  If IiP1(35) = "" Then IiP1(35) = "1"
  If IiP1(35) = "1" Then rb01.Checked = True
  If IiP1(35) = "2" Then rb02.Checked = True
  If IiP1(35) = "3" Then rb03.Checked = True
  If IiP1(35) = "4" Then rb04.Checked = True
  'planilla Enmendada
  If IiP1(34) = "1" Then ck1.Checked = True
  'Solicitud Prorroga
  If IiP1(19) = "1" Then ck2.Checked = True
  'Gran Contribuyente
  If IiP1(31) = "1" Then ck3.Checked = True
  'Indicar si es miembro grupo controlado
  If IiP1(29) = "1" Then ck4.Checked = True : tbNGru.Enabled = True
  'Cambio Direccion
  If IiP1(18) = "1" Then rbB1.Checked = True
  'Organismos gub
  If IiP1(27) = "1" Then rbA1.Checked = True

  'Fechas
  mAnoComP.Text = IiP1(37)
  mAnoComT.Text = IiP1(38)
  mFecInc.Text = IiP1(24)
  mCodNaics.Text = IiP1(15)
  'Heading
  tbNomNeg.Text = IiP1(3)
  '''Dir Postal
  tbDirPost1.Text = IiP1(4)
  tbDirPost2.Text = IiP1(5)
  tbMunPos.Text = IiP1(6)
  tbPaisFis.Text = IiP1(7)
  mZonaPos.Text = IiP1(8)
  '''Dir Fisica
  tbDirFisi1.Text = IiP1(9)
  tbDirFisi2.Text = IiP1(10)
  tbMunFis.Text = IiP1(11)
  tbPaisFis.Text = IiP1(12)
  mZonaFis.Text = IiP1(13)

  tbLocNeg.Text = IiP1(16)
  mNumSegSoc.Text = IiP1(20)
  tbNumDEst.Text = IiP1(21)
  tbNumCom.Text = IiP1(22)
  tbNumMfg.Text = IiP1(14)
  mtelefono.Text = IiP1(23)
  tbExten.Text = IiP1(25)
  tbLugInc.Text = IiP1(26)
  tbEmail.Text = IiP1(17)
  tbNGru.Text = IiP1(30)

  'Cantidades
  '''Numero 1
  tb01.Text = IiP1(50)
  tb02.Text = IiP1(51)
  tb03.Text = IiP1(52)
  tb04.Text = IiP1(53)
  tb05.Text = IiP1(54)
  tb07.Text = IiP1(56)
  tb08.Text = IiP1(57)
  tb09.Text = IiP1(58)
  tb10.Text = IiP1(59)
  '''Numero 2
  tb11.Text = IiP1(65)
  tb13.Text = IiP1(67)
  tb14.Text = IiP1(68)
  tb15.Text = IiP1(69)
  tb16.Text = IiP1(70)
  tb17.Text = IiP1(71)
  '''Inside Fill
  tbE01.Text = IiP1(60)
  tbE02.Text = IiP1(61)
  tbE03.Text = IiP1(62)
  tbE04.Text = IiP1(63)
  tbE05.Text = IiP1(64)
  '''Numero 3
  tb19.Text = IiP1(77)
  tb20.Text = IiP1(78)
  '''Numero 4
  tb24.Text = IiP1(89)
  tb25.Text = IiP1(90)
  tb26.Text = IiP1(91)
 End Sub

 Sub FillControls()
  tb06.Text = IiP1(65)
  tb12.Text = IiP1(66)
  tb18.Text = IiP1(76)
  tb21.Text = IiP1(86)
  tb22.Text = IiP1(87)
  tb23.Text = IiP1(88)
  tbTotal01.Text = IiP1(95)
  tbTotal02.Text = IiP1(96)
  tbTotal03.Text = IiP1(85)
  tbTotal04.Text = IiP1(97)
 End Sub

 Public Sub SaveText()
  If FlagStart = True Then Exit Sub
  FlagStart = True
  'Checks y option
  '''Planilla Enmendada
  IiP1(34) = "" : If ck1.Checked = True Then IiP1(34) = "1"
  'Solicitud Prorroga
  IiP1(19) = "" : If ck2.Checked = True Then IiP1(19) = "1"
  'Gran Contribuyente
  IiP1(31) = "" : If ck3.Checked = True Then IiP1(31) = "1"
  'Indicar si es miembro grupo controlado
  If ck4.Checked = False Then IiP1(29) = "" : tbNGru.Text = "" : tbNGru.Enabled = False
  If ck4.Checked = True Then IiP1(29) = "1" : tbNGru.Enabled = True
  'Cambio Direccion
  IiP1(18) = "" : If rbB1.Checked = True Then IiP1(18) = "1"
  'Organismos gub
  IiP1(27) = "" : If rbA1.Checked = True Then IiP1(27) = "1"

  'Fechas
  IiP1(37) = mAnoComP.Text
  IiP1(38) = mAnoComT.Text
  IiP1(26) = mFecInc.Text
  IiP1(15) = mCodNaics.Text
  'Heading
  IiP1(3) = tbNomNeg.Text
  '''Dir Postal
  IiP1(4) = tbDirPost1.Text
  IiP1(5) = tbDirPost2.Text
  IiP1(6) = tbMunPos.Text
  IiP1(7) = tbPaisFis.Text
  IiP1(8) = mZonaPos.Text
  '''Dir Fisica
  IiP1(9) = tbDirFisi1.Text
  IiP1(10) = tbDirFisi2.Text
  IiP1(11) = tbMunFis.Text
  IiP1(12) = tbPaisFis.Text
  IiP1(13) = mZonaFis.Text

  IiP1(16) = tbLocNeg.Text
  IiP1(20) = mNumSegSoc.Text
  IiP1(21) = tbNumDEst.Text
  IiP1(22) = tbNumCom.Text
  IiP1(14) = tbNumMfg.Text
  IiP1(23) = mtelefono.Text
  IiP1(25) = tbExten.Text
  IiP1(26) = tbLugInc.Text
  IiP1(17) = tbEmail.Text
  IiP1(30) = tbNGru.Text
  FlagStart = False
 End Sub

 Private Sub SetSum()
  '''Numero 1
  IiP1(50) = tb01.Text
  IiP1(51) = tb02.Text
  IiP1(52) = tb03.Text
  IiP1(53) = tb04.Text
  IiP1(54) = tb05.Text
  IiP1(56) = tb07.Text
  IiP1(57) = tb08.Text
  IiP1(58) = tb09.Text
  IiP1(59) = tb10.Text
  '''Numero 2
  IiP1(65) = tb11.Text
  IiP1(66) = tb12.Text
  IiP1(67) = tb13.Text
  IiP1(68) = tb14.Text
  IiP1(69) = tb15.Text
  IiP1(70) = tb16.Text
  IiP1(71) = tb17.Text
  '''Inside Fill
  IiP1(60) = tbE01.Text
  IiP1(61) = tbE02.Text
  IiP1(62) = tbE03.Text
  IiP1(63) = tbE04.Text
  IiP1(64) = tbE05.Text
  '''Numero 3
  IiP1(77) = tb19.Text
  IiP1(78) = tb20.Text
  '''Numero 4
  IiP1(89) = tb24.Text
  IiP1(90) = tb25.Text
  IiP1(91) = tb26.Text
  CalculateThisAnejo() : FillControls() : FlagStart = False
 End Sub

 Private Sub mAnoComT_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
  If FlagStart = True Then Exit Sub
  'mAnoComT.SelectAll()
 End Sub

 Private Sub mFinAno_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
  If FlagStart = True Then Exit Sub
  'mFinAno.SelectAll()
 End Sub

 Private Sub mFecInc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mFecInc.GotFocus
  If FlagStart = True Then Exit Sub
  mFecInc.SelectAll()
 End Sub

 Private Sub CheckFecha(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mFecInc.Validating, mAnoComT.Validating, mAnoComP.Validating
  If FlagStart = True Or Answer = 156 Then Exit Sub
  If mAnoComP.Focused Then
   F = mAnoComP.Text
   If F = "" Then Exit Sub
   If Len(F) <> 6 And Len(F) <> 8 Then mAnoComP.Text = CurValue : mAnoComP.Focus() : Exit Sub
   VerificarFecha(F)
   If Tr = True Then mAnoComP.Text = CurValue : mAnoComP.Focus() : Exit Sub
   Tr = VerifyFechaFutura(F)
   If Tr = True Then mAnoComP.Text = CurValue : mAnoComP.Focus() : Exit Sub
   mAnoComP.Text = F : SaveText()
  End If
  If mAnoComT.Focused Then
   F = mAnoComT.Text
   If F = "" Then Exit Sub
   If Len(F) <> 6 And Len(F) <> 8 Then mAnoComT.Text = CurValue : mAnoComT.Focus() : Exit Sub
   VerificarFecha(F)
   If Tr = True Then mAnoComT.Text = CurValue : mAnoComT.Focus() : Exit Sub
   Tr = VerifyFechaFutura(F)
   If Tr = True Then mAnoComT.Text = CurValue : mAnoComT.Focus() : Exit Sub
   mAnoComT.Text = F : SaveText()
  End If
  If mFecInc.Focused Then
   F = mFecInc.Text
   If F = "" Then Exit Sub
   If Len(F) <> 6 And Len(F) <> 8 Then mFecInc.Text = CurValue : mFecInc.Focus() : Exit Sub
   VerificarFecha(F)
   If Tr = True Then mFecInc.Text = CurValue : mFecInc.Focus() : Exit Sub
   Tr = VerifyFechaFutura(F)
   If Tr = True Then mFecInc.Text = CurValue : mFecInc.Focus() : Exit Sub
   mFecInc.Text = F : SaveText()
  End If
 End Sub

 Private Sub tbCorrElec_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles tbEmail.Validating
  If EmailAddressCheck(tbEmail.Text) = False Then _
     MsgId = "Pag1Email" : ErrMsgDialog.ShowDialog() : e.Cancel = True : Exit Sub
 End Sub

 Private Sub mTelefono_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtelefono.GotFocus
  If FlagStart = True Then Exit Sub
  mtelefono.SelectAll()
 End Sub

 Private Sub mTelefono_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mtelefono.Validating
  Dim s As String = mtelefono.Text
  s = s.Replace(")", "") : s = s.Replace("(", "") : s = s.Replace("-", "")
  If s.ToString() <> "" Then If s.Length <> 10 Then mtelefono.Text = CurValue : e.Cancel = True
  SaveText()
 End Sub

 Private Sub mNumSegSoc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mNumSegSoc.GotFocus
  If FlagStart = True Then Exit Sub
  mNumSegSoc.SelectAll()
 End Sub

 Private Sub CheckSegSoc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mNumSegSoc.Validating
  c = sender.text
  Dim x As Byte = CheckEmployerSocSec(c)
  If x = 200 Then Exit Sub
  If x = False Then sender.Text = CurValue : sender.Focus()
 End Sub

 Private Sub Setvar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mZonaPos.KeyUp, mZonaFis.KeyUp
  If FlagStart = True Then Exit Sub
  SaveText()
 End Sub

 Private Sub mAnoComT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
  SaveText()
  'CurValue = mAnoComT.Text
 End Sub

 Private Sub mZonaPstlZip(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mZonaPos.Enter, mZonaFis.Enter
  ActCtl = "mZonaPstl"
  mZonaPos.SelectAll()
  'save nombre del mun y buscar sus zipcodes
  Word = tbMunPos.Text
 End Sub

#Region "Buttons"

 Private Sub bt01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt01.Click
  MsgId = "EstaSeguroBorrarDatos"
  ErrMsgDialog.ShowDialog()
  If Answer = 0 Then
   'mAnoComT.Focus()
   Exit Sub
  End If
  If Answer = 1 Then
   FlagStart = True
   'Erase IiP1$
   Dim i As Int16
   For i = 0 To 88 : IiP1(i) = "" : Next

   'rbEsp.Checked = True
   FlagStart = False
   'mAnoComT.Focus()
  End If
 End Sub

 Private Sub bt02_Click(sender As Object, e As EventArgs) Handles bt02.Click
  Dim naics As New NaicsSearch.NaicsSearch : naics.ShowDialog()
  If naics.getNaicsCode <> 0 Then mCodNaics.Text = naics.getNaicsCode : SaveText()
 End Sub

 Private Sub bt03_Click(sender As Object, e As EventArgs) Handles bt03.Click
  tbDirFisi1.Text = tbDirPost1.Text
  tbDirFisi2.Text = tbDirPost2.Text
  tbMunFis.Text = tbMunPos.Text
  tbPaisFis.Text = tbPaisPos.Text
  mZonaFis.Text = mZonaPos.Text
  SaveText()
 End Sub


 Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
  If FlagStart = True Or Answer = 156 Then Exit Sub
  'ano previo a esta planilla
  ClearScreen()
  b = ComboBox1.SelectedIndex : If Val(b) < 10 Then b = "0" & b
  IiP1(2) = b
  Refresh() : FlagStart = False : tbNomNeg.Focus()
 End Sub

 Private Sub SetOptions(sender As Object, e As EventArgs) Handles rbB2.Click, rbB1.Click, rbA2.Click, rbA1.Click, rb04.Click, rb03.Click, rb02.Click, rb01.Click, ck4.Click, ck3.Click, ck2.Click, ck1.Click
  If FlagStart = True Or Answer = 156 Then Exit Sub
  SaveText()
  If sender.name = "ck4" And ck4.Checked = True Then tbNGru.Focus()
 End Sub

 Private Sub ComboBox2_DropDownClosed(sender As Object, e As EventArgs) Handles ComboBox2.DropDownClosed
  b = ComboBox2.SelectedIndex : SetTipoEntidad() : IiP1(28) = b : tbCodTipo.Text = c : mCodNaics.Focus()
 End Sub

#End Region

#Region "VerifyChars"

 Private Sub VerifyAllChars(sender As Object, e As EventArgs) Handles tbNomNeg.TextChanged, tbPaisPos.TextChanged, tbPaisFis.TextChanged, tbMunPos.TextChanged, tbMunFis.TextChanged, tbLugInc.TextChanged, tbLocNeg.TextChanged, tbEmail.TextChanged, tbDirPost2.TextChanged, tbDirPost1.TextChanged, tbDirFisi2.TextChanged, tbDirFisi1.TextChanged, tbNumCom.TextChanged, tbNumDEst.TextChanged, tbNumMfg.TextChanged
  If FlagStart = True Or Answer = 156 Then Exit Sub
  c = sender.text : VerifyAcceptedAllChars() : If Answer = 116 Then sender.text = c : sender.SelectionStart = sender.MaxLength : Exit Sub
  SaveText()
  FlagStart = False
 End Sub

 Private Sub VerifyOnlyNumbers(sender As Object, e As EventArgs) Handles tbNGru.TextChanged, tbExten.TextChanged, tbE05.TextChanged, tbE04.TextChanged, tbE03.TextChanged, tbE02.TextChanged, tbE01.TextChanged, tb26.TextChanged, tb25.TextChanged, tb20.TextChanged, tb19.TextChanged, tb17.TextChanged, tb16.TextChanged, tb15.TextChanged, tb14.TextChanged, tb13.TextChanged, tb12.TextChanged, tb11.TextChanged, mCodNaics.TextChanged, tb24.TextChanged, tb10.TextChanged, tb09.TextChanged, tb08.TextChanged, tb07.TextChanged, tb05.TextChanged, tb04.TextChanged, tb03.TextChanged, tb02.TextChanged, tb01.TextChanged
  If FlagStart = True Or Answer = 156 Then Exit Sub
  c = sender.text : VerifyAcceptedOnlyNumbers() : If Answer = 116 Then sender.text = c : sender.SelectionStart = sender.MaxLength : Exit Sub
  If sender.name = "tbExten" Then SaveText() : GoTo 15
  If sender.name = "tbNGru" Then SaveText() : tbNGru.Focus() : GoTo 15
  SetSum()
15: FlagStart = False
 End Sub
#End Region

 Private Sub CalculateThisAnejo()
  'Responsablidad contributiva #1
  Valcal = 0 : For i = 50 To 59 : Valcal = Valcal + Val(IiP1(i)) : Next
  IiP1(95) = Valcal
  'Menos #2
  '''Estimadas
  Valcal = 0 : For i = 60 To 64 : Valcal = Valcal + Val(IiP1(i)) : Next
  IiP1(66) = Valcal
  '''Total
  Valcal = 0 : For i = 65 To 71 : Valcal = Valcal + Val(IiP1(i)) : Next
  IiP1(96) = Valcal
  'Balance a Pagar #3==========

  'diferencia entre 1K y 2H
  Amt = Val(IiP1(95)) - Val(IiP1(96))
  '''3a
  'cual es mayor la linea 2 o la 3
  IiP1(76) = "" : IiP1(85) = ""
  Valcal = Val(IiP1(95)) - Val(IiP1(96)) : Valcal = Abs(Valcal)
  If Val(IiP1(95)) > Val(IiP1(96)) Then IiP1(76) = Valcal Else IiP1(87) = Valcal
  '''3d
  Valcal = 0 : For i = 76 To 78 : Valcal = Valcal + Val(IiP1(i)) : Next
  IiP1(85) = Valcal

  'Linea 6
  Valcal = (Val(IiP1(85)) + Val(IiP1(86))) - Val(IiP1(87)) : IiP1(88) = Valcal

  'Neto para linea 10
  Valcal = Val(IiP1(88)) - (Val(IiP1(89)) + Val(IiP1(90)) + Val(IiP1(91))) : IiP1(97) = Abs(Valcal)
 End Sub
End Class
