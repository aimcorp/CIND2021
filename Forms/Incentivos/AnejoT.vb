Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class AnejoT
Dim FlagStart As Boolean, taa As Byte

Private Sub AnejoT_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
If Rsolution = True Then ReSize1.Enabled = True
Me.WindowState = FormWindowState.Minimized
End Sub

Private Sub AnejoT14_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
Me.WindowState = FormWindowState.Maximized : ReSize1.Enabled = False
End Sub

Private Sub AnejoT14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
FlagStart = True : UsePage = "IncentivosAnejoT" : PIm = 0 : MdiMain.tbIncT.Checked = True
'reset a cero las que no se usen este ano 2013
IiT0(1) = "" : IiT0(2) = "" : IiT0(12) = ""
  'veriaim 'veriaim IncentivosCalR() : FillTextVars() : FillControls()
  For Each CrR As Control In Me.Panel1.Controls
   If CrR.Name = FormLastFocus(52) Then CrR.Focus() : c = CrR.Text : CurValue = GetOnlyChars(c) : Exit For
  Next CrR
  ResetTabStop()
  FlagStart = False
 End Sub

 Private Sub ResetTabStop()
  rbAnoNat.TabStop = False : rbAnoEco.TabStop = False
 End Sub

 Private Sub FillTextVars()
  'tipo de estimada 25% 33% 50% 100%
  If IiT0(12) = "" Then IiT0(12) = "0"
  If IiT0(12) = "0" Then rbPor1.Checked = True
  If IiT0(12) = "1" Then rbPor2.Checked = True
  If IiT0(12) = "2" Then rbPor3.Checked = True
  If IiT0(12) = "3" Then rbPor4.Checked = True
  If IiT0(12) = "4" Then rbPor5.Checked = True

  tbConDet.Text = IiT0(6)
  tbLin26a.Text = IiT0(51) : tbLin26b.Text = IiT0(54) : tbLin26c.Text = IiT0(57) : tbLin26d.Text = IiT0(60)
  'prorrateo linea 8
  mFecPg1.Text = IiT0(66) : mFecPg2.Text = IiT0(68) : mFecPg3.Text = IiT0(70) : mFecPg4.Text = IiT0(72)
  If IiT0(11) = "1" Then
   rbAnoEco.Checked = True
   mFecPrim.Enabled = True : mFecSegu.Enabled = True : mFecTerc.Enabled = True : mFecCuar.Enabled = True
   mFecPrim.Text = IiT0(65) : mFecSegu.Text = IiT0(67) : mFecTerc.Text = IiT0(69) : mFecCuar.Text = IiT0(71)
  Else        'cambiar-anual
   rbAnoNat.Checked = True
   If AnoInUse = 2020 Then
    mFecPrim.Text = "15042020" : mFecSegu.Text = "15062020" : mFecTerc.Text = "15092020" : mFecCuar.Text = "15122020"
   End If
   If AnoInUse = 2019 Then
    mFecPrim.Text = "15042019" : mFecSegu.Text = "15062019" : mFecTerc.Text = "15092019" : mFecCuar.Text = "15122019"
   End If
   If AnoInUse = 2018 Then
    mFecPrim.Text = "15042018" : mFecSegu.Text = "15062018" : mFecTerc.Text = "15092018" : mFecCuar.Text = "15122018"
   End If
   If AnoInUse = 2017 Then
    mFecPrim.Text = "15042017" : mFecSegu.Text = "15062017" : mFecTerc.Text = "15092017" : mFecCuar.Text = "15122017"
   End If
   If AnoInUse = 2016 Then
    mFecPrim.Text = "15042016" : mFecSegu.Text = "15062016" : mFecTerc.Text = "15092016" : mFecCuar.Text = "15122016"
   End If
   If AnoInUse = 2015 Then
    mFecPrim.Text = "15042015" : mFecSegu.Text = "15062015" : mFecTerc.Text = "15092015" : mFecCuar.Text = "15122015"
   End If
   If AnoInUse = 2014 Then
    mFecPrim.Text = "15042014" : mFecSegu.Text = "15062014" : mFecTerc.Text = "15092014" : mFecCuar.Text = "15122014"
   End If
   If AnoInUse = 2013 Then
    mFecPrim.Text = "15042013" : mFecSegu.Text = "15062013" : mFecTerc.Text = "15092013" : mFecCuar.Text = "15122013"
   End If
  End If
 End Sub

 Sub FillControls()
  'part I
  tbResp1.Text = IiT0(0) : tbSum22.Text = IiT0(3) : tbContEst.Text = IiT0(4)
  tbAgr.Text = IiT0(5) : tbtotal.Text = IiT0(7) : tbtotalP1.Text = IiT0(8)
  'part II
  tbPart2E1.Text = IiT0(15) : tbPart2E2.Text = IiT0(22) : tbPart2E3.Text = IiT0(32) : tbPart2E4.Text = IiT0(42) : tbCanPagPri.Text = IiT0(16)
  tbCanPagSeg.Text = IiT0(23) : tbCanPagTer.Text = IiT0(33) : tbCanPagCua.Text = IiT0(43) : tbLinea25Seg.Text = IiT0(25) : tbLinea25Ter.Text = IiT0(35)
  tbLinea25Cua.Text = IiT0(45) : tbSumL17a.Text = IiT0(18) : tbSumL17b.Text = IiT0(26) : tbSumL17c.Text = IiT0(36) : tbSumL17d.Text = IiT0(46)
  tbRestLinPri.Text = IiT0(19) : tbRestLinSeg.Text = IiT0(27) : tbRestLinTer.Text = IiT0(37) : tbRestLinCua.Text = IiT0(47) : tbFaltaPagPri.Text = IiT0(20)
  tbFaltaPagSeg.Text = IiT0(28) : tbFaltaPagTer.Text = IiT0(38) : tbFaltaPagCua.Text = IiT0(48) : tbSumeLasSeg.Text = IiT0(29) : tbSumeLasTer.Text = IiT0(39)
  tbSumeLasQui.Text = IiT0(95) : tbLina23a.Text = IiT0(30) : tbLina23b.Text = IiT0(40) : tbLina23c.Text = IiT0(96) : tbSobrePri.Text = IiT0(21)
  tbSobreSeg.Text = IiT0(31) : tbSobreTer.Text = IiT0(41) : tbSobreCua.Text = IiT0(97)
  'part III
  tbPena1.Text = IiT0(50) : tbPena2.Text = IiT0(53) : tbPena3.Text = IiT0(56) : tbPena4.Text = IiT0(59) : tbMula.Text = IiT0(52) : tbMulb.Text = IiT0(55)
  tbMulc.Text = IiT0(58) : tbMuld.Text = IiT0(61) : tbTotFin.Text = IiT0(62)
 End Sub

 Private Sub SaveText()
  'part III
  IiT0(65) = mFecPrim.Text : IiT0(67) = mFecSegu.Text : IiT0(69) = mFecTerc.Text : IiT0(71) = mFecCuar.Text : IiT0(66) = mFecPg1.Text
  IiT0(68) = mFecPg2.Text : IiT0(70) = mFecPg3.Text : IiT0(72) = mFecPg4.Text
 End Sub

 Private Sub SaveText(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mFecTerc.KeyUp, mFecSegu.KeyUp, mFecPrim.KeyUp, mFecCuar.KeyUp
  SaveText()
 End Sub

 Private Sub rbOptionsSave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
  If FlagStart = True Then Exit Sub
  If sender.name = "rbAnoNat" Then IiT0(214) = "0"
  If sender.name = "rbAnoEco" Then IiT0(214) = "1"
  mFecPrim.Focus()
 End Sub

 Private Sub ShowTagBarraDeAyuda(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbConDet.Enter, mFecTerc.Enter, mFecSegu.Enter, mFecPrim.Enter, mFecPg4.Enter, mFecPg3.Enter, mFecPg2.Enter, mFecPg1.Enter, mFecCuar.Enter, tbLin26d.Enter, tbLin26c.Enter, tbLin26b.Enter, tbLin26a.Enter
  If FlagStart = True Then Exit Sub
  CurValue = ActiveControl.Text : CurValue = GetOnlyChars(CurValue)
  FormLastFocus(52) = sender.Name
 End Sub

 Private Sub CheckFecha(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mFecTerc.Validating, mFecSegu.Validating, mFecPrim.Validating, mFecPg3.Validating, mFecPg2.Validating, mFecPg1.Validating, mFecPg4.Validating, mFecCuar.Validating
  If FlagStart = True Then Exit Sub
  If sender.Focused Then
   F = sender.Text
   If F = "" Then Exit Sub
   If Len(F) < 5 Then sender.Text = CurValue : sender.Focus() : Exit Sub
   If Len(F) <> 6 And Len(F) <> 8 Then sender.Focus() : Exit Sub
   VerificarFecha(F)
   If (sender.name = "mFecQuin" Or sender.name = "mFecPg5") Then If Mid(F, 7, 4) = "2014" Then GoTo 133
   If F.Substring(6, 4) > AnoInUse Then Tr = True
   If Tr = True Then sender.Text = CurValue : sender.Focus() : Exit Sub
133:  'all good save date
   sender.Text = F
   SaveText()
  End If
 End Sub

 Private Sub mFecPg1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mFecPg1.KeyUp
  SaveText()
 End Sub

 Private Sub mFecPg2_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mFecPg2.KeyUp
  SaveText()
 End Sub

 Private Sub mFecPg3_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mFecPg3.KeyUp
  SaveText()
 End Sub

 Private Sub mFecPg4_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mFecPg4.KeyUp
  SaveText()
 End Sub

 Private Sub mFecPg5_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
  SaveText()
 End Sub

 Private Sub rbAnoNat_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbAnoNat.MouseClick
  If FlagStart = True Then Exit Sub
  IiT0(11) = "0"
  mFecPrim.Enabled = False : mFecSegu.Enabled = False : mFecTerc.Enabled = False
  mFecCuar.Enabled = False
  If AnoInUse >= 2014 Then mFecPrim.Text = "15042014" : mFecSegu.Text = "15062014" : mFecTerc.Text = "15092014" : mFecCuar.Text = "15122014"
  If AnoInUse = 2013 Then mFecPrim.Text = "15042013" : mFecSegu.Text = "15062013" : mFecTerc.Text = "15092013" : mFecCuar.Text = "15102013"
  IiT0(65) = mFecPrim.Text : IiT0(67) = mFecSegu.Text : IiT0(69) = mFecTerc.Text : IiT0(71) = mFecCuar.Text
  ResetTabStop() : tbConDet.Focus()
 End Sub

 Private Sub rbAnoEco_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbAnoEco.MouseClick
  If FlagStart = True Then Exit Sub
  IiT0(11) = "1"
  mFecPrim.Text = "" : mFecSegu.Text = "" : mFecTerc.Text = "" : mFecCuar.Text = ""
  mFecPrim.Enabled = True : mFecSegu.Enabled = True : mFecTerc.Enabled = True : mFecCuar.Enabled = True
  IiT0(65) = "" : IiT0(67) = "" : IiT0(69) = "" : IiT0(71) = "" : IiT0(81) = ""
  ResetTabStop() : mFecPrim.Focus()
 End Sub

 Sub SetAmounts()
  'part I y II
  IiT0(6) = tbConDet.Text : IiT0(51) = tbLin26a.Text : IiT0(54) = tbLin26b.Text : IiT0(57) = tbLin26c.Text : IiT0(60) = tbLin26d.Text
  'veriaim IncentivosCalR() : FillControls()
 End Sub

 Sub VerifyNumbers(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbLin26d.TextChanged, tbLin26c.TextChanged, tbLin26b.TextChanged, tbLin26a.TextChanged, tbConDet.TextChanged
  'no allow spaces, numbers and symbols
  If FlagStart = True Then Exit Sub
  If Answer = 156 Then Exit Sub
  Dim StrLength As Int32 = Len(sender.Text)
  If StrLength = 0 Then GoTo 12
  For x = 1 To StrLength
   c = Mid$(sender.Text, x, 1)
   Dim bba As Integer
   bba = Asc(c)
   If bba < 48 Or bba > 57 Then b = sender.text : sender.text = b.Substring(0, StrLength - 1) : sender.SelectionStart = sender.MaxLength
  Next
12: SetAmounts()
 End Sub

 Private Sub rbPor1_Click(sender As System.Object, e As System.EventArgs) Handles rbPor1.Click
  IiT0(12) = "0"
  'veriaim 'veriaim IncentivosCalR() : FillControls() : ResetTabStop() : tbCanPagPri.Focus()
 End Sub

 Private Sub rbPor2_Click(sender As System.Object, e As System.EventArgs) Handles rbPor2.Click
  'veriaim IiT0(12) = "1"
  'veriaim IncentivosCalR() : FillControls() : ResetTabStop() : tbCanPagPri.Focus()
 End Sub

 Private Sub rbPor3_Click(sender As System.Object, e As System.EventArgs) Handles rbPor3.Click
  'veriaim IiT0(12) = "2"
  'veriaim IncentivosCalR() : FillControls() : ResetTabStop() : tbCanPagPri.Focus()
 End Sub

 Private Sub rbPor4_Click(sender As System.Object, e As System.EventArgs) Handles rbPor4.Click
  IiT0(12) = "3"
  'veriaim 'veriaim IncentivosCalR() : FillControls() : ResetTabStop() : tbCanPagPri.Focus()
 End Sub

 Private Sub rbPor5_Click(sender As System.Object, e As System.EventArgs) Handles rbPor5.Click
  IiT0(12) = "4"
  'veriaim 'veriaim IncentivosCalR() : FillControls() : ResetTabStop() : tbCanPagPri.Focus()
 End Sub
End Class

