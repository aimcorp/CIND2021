
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class AnejosEyE1
 Dim FlagStart As Boolean, bba As Integer
 Dim Csi(292) As String

 Private Sub AnejosEyE1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
  e.Cancel = True
 End Sub

 Private Sub _HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.HandleCreated
  ReSize1.Enabled = False
 End Sub

 Private Sub _Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  FlagStart = True
  Panel1.Location = New System.Drawing.Point(0, 56) : Panel2.Location = New System.Drawing.Point(0, 56)
  Select Case z1
   Case 1, 3, 4, 6, 7, 8, 10
    Panel1.BringToFront() : Panel1.Enabled = True : Panel1.Visible = True
   Case 2, 5, 9, 11
    Panel2.BringToFront() : Panel2.Enabled = True : Panel2.Visible = True
  End Select
  Timer1.Enabled = True
  GetDepreciacion()
  Select Case z1
   Case 1, 3, 4, 6, 7, 8, 10
    ReadDepreciacionE()
   Case 2, 5, 9, 11
    ReadDepreciacionE1()
  End Select
  FillControls() : Answer = 0 : FlagStart = False
 End Sub

 Private Sub ShowBarraDeAyuda(sender As Object, e As EventArgs) Handles tbResEstMej9.Enter, tbResEstMej8.Enter, tbResEstMej7.Enter, tbResEstMej6.Enter, tbResEstMej5.Enter, tbResEstMej4.Enter, tbResEstMej3.Enter, tbResEstMej2.Enter, tbResEstMej1.Enter, tbResEstFle9.Enter, tbResEstFle8.Enter, tbResEstFle7.Enter, tbResEstFle6.Enter, tbResEstFle5.Enter, tbResEstFle4.Enter, tbResEstFle3.Enter, tbResEstFle2.Enter, tbResEstFle1.Enter, tbResEstCor9.Enter, tbResEstCor8.Enter, tbResEstCor7.Enter, tbResEstCor6.Enter, tbResEstCor5.Enter, tbResEstCor4.Enter, tbResEstCor3.Enter, tbResEstCor2.Enter, tbResEstCor1.Enter, tbResEstAce9.Enter, tbResEstAce8.Enter, tbResEstAce7.Enter, tbResEstAce6.Enter, tbResEstAce5.Enter, tbResEstAce4.Enter, tbResEstAce3.Enter, tbResEstAce2.Enter, tbResEstAce1.Enter, tbRecMej9.Enter, tbRecMej8.Enter, tbRecMej7.Enter, tbRecMej6.Enter, tbRecMej5.Enter, tbRecMej4.Enter, tbRecMej3.Enter, tbRecMej2.Enter, tbRecMej1.Enter, tbRecFle9.Enter, tbRecFle8.Enter, tbRecFle7.Enter, tbRecFle6.Enter, tbRecFle5.Enter, tbRecFle4.Enter, tbRecFle3.Enter, tbRecFle2.Enter, tbRecFle1.Enter, tbRecCor9.Enter, tbRecCor8.Enter, tbRecCor7.Enter, tbRecCor6.Enter, tbRecCor5.Enter, tbRecCor4.Enter, tbRecCor3.Enter, tbRecCor2.Enter, tbRecCor1.Enter, tbRecAce9.Enter, tbRecAce8.Enter, tbRecAce7.Enter, tbRecAce6.Enter, tbRecAce5.Enter, tbRecAce4.Enter, tbRecAce3.Enter, tbRecAce2.Enter, tbRecAce1.Enter, tbProp30.Enter, tbProp29.Enter, tbProp28.Enter, tbProp27.Enter, tbProp26.Enter, tbProp25.Enter, tbProp24.Enter, tbProp23.Enter, tbProp22.Enter, tbProp21.Enter, tbProp20.Enter, tbProp19.Enter, tbProp18.Enter, tbProp17.Enter, tbProp16.Enter, tbProp15.Enter, tbProp14.Enter, tbProp13.Enter, tbProp12.Enter, tbProp11.Enter, tbProp10.Enter, tbProp09.Enter, tbProp08.Enter, tbProp07.Enter, tbProp06.Enter, tbProp05.Enter, tbProp04.Enter, tbProp03.Enter, tbProp02.Enter, tbProp01.Enter, tbNomPatMej9.Enter, tbNomPatMej8.Enter, tbNomPatMej7.Enter, tbNomPatMej6.Enter, tbNomPatMej5.Enter, tbNomPatMej4.Enter, tbNomPatMej3.Enter, tbNomPatMej2.Enter, tbNomPatMej1.Enter, tbNomPatFle9.Enter, tbNomPatFle8.Enter, tbNomPatFle7.Enter, tbNomPatFle6.Enter, tbNomPatFle5.Enter, tbNomPatFle4.Enter, tbNomPatFle3.Enter, tbNomPatFle2.Enter, tbNomPatFle1.Enter, tbNomPatCor9.Enter, tbNomPatCor8.Enter, tbNomPatCor7.Enter, tbNomPatCor6.Enter, tbNomPatCor5.Enter, tbNomPatCor4.Enter, tbNomPatCor3.Enter, tbNomPatCor2.Enter, tbNomPatCor1.Enter, tbNomPatAce9.Enter, tbNomPatAce8.Enter, tbNomPatAce7.Enter, tbNomPatAce6.Enter, tbNomPatAce5.Enter, tbNomPatAce4.Enter, tbNomPatAce3.Enter, tbNomPatAce2.Enter, tbNomPatAce1.Enter, tbMejCos9.Enter, tbMejCos8.Enter, tbMejCos7.Enter, tbMejCos6.Enter, tbMejCos5.Enter, tbMejCos4.Enter, tbMejCos3.Enter, tbMejCos2.Enter, tbMejCos1.Enter, tbEstMej9.Enter, tbEstMej8.Enter, tbEstMej7.Enter, tbEstMej6.Enter, tbEstMej5.Enter, tbEstMej4.Enter, tbEstMej3.Enter, tbEstMej2.Enter, tbEstMej1.Enter, tbEstimMej9.Enter, tbEstimMej8.Enter, tbEstimMej7.Enter, tbEstimMej6.Enter, tbEstimMej5.Enter, tbEstimMej4.Enter, tbEstimMej3.Enter, tbEstimMej2.Enter, tbEstimMej1.Enter, tbEstimFle9.Enter, tbEstimFle8.Enter, tbEstimFle7.Enter, tbEstimFle6.Enter, tbEstimFle5.Enter, tbEstimFle4.Enter, tbEstimFle3.Enter, tbEstimFle2.Enter, tbEstimFle1.Enter, tbEstimCor9.Enter, tbEstimCor8.Enter, tbEstimCor7.Enter, tbEstimCor6.Enter, tbEstimCor5.Enter, tbEstimCor4.Enter, tbEstimCor3.Enter, tbEstimCor2.Enter, tbEstimCor1.Enter, tbEstimAce9.Enter, tbEstimAce8.Enter, tbEstimAce7.Enter, tbEstimAce6.Enter, tbEstimAce5.Enter, tbEstimAce4.Enter, tbEstimAce3.Enter, tbEstimAce2.Enter, tbEstimAce1.Enter, tbE1DepRA30.Enter, tbE1DepRA29.Enter, tbE1DepRA28.Enter, tbE1DepRA27.Enter, tbE1DepRA26.Enter, tbE1DepRA25.Enter, tbE1DepRA24.Enter, tbE1DepRA23.Enter, tbE1DepRA22.Enter, tbE1DepRA21.Enter, tbE1DepRA20.Enter, tbE1DepRA19.Enter, tbE1DepRA18.Enter, tbE1DepRA17.Enter, tbE1DepRA16.Enter, tbE1DepRA15.Enter, tbE1DepRA14.Enter, tbE1DepRA13.Enter, tbE1DepRA12.Enter, tbE1DepRA11.Enter, tbE1DepRA10.Enter, tbE1DepRA09.Enter, tbE1DepRA08.Enter, tbE1DepRA07.Enter, tbE1DepRA06.Enter, tbE1DepRA05.Enter, tbE1DepRA04.Enter, tbE1DepRA03.Enter, tbE1DepRA02.Enter, tbE1DepRA01.Enter, tbE1DepEs30.Enter, tbE1DepEs29.Enter, tbE1DepEs28.Enter, tbE1DepEs27.Enter, tbE1DepEs26.Enter, tbE1DepEs25.Enter, tbE1DepEs24.Enter, tbE1DepEs23.Enter, tbE1DepEs22.Enter, tbE1DepEs21.Enter, tbE1DepEs20.Enter, tbE1DepEs19.Enter, tbE1DepEs18.Enter, tbE1DepEs17.Enter, tbE1DepEs16.Enter, tbE1DepEs15.Enter, tbE1DepEs14.Enter, tbE1DepEs13.Enter, tbE1DepEs12.Enter, tbE1DepEs11.Enter, tbE1DepEs10.Enter, tbE1DepEs09.Enter, tbE1DepEs08.Enter, tbE1DepEs07.Enter, tbE1DepEs06.Enter, tbE1DepEs05.Enter, tbE1DepEs04.Enter, tbE1DepEs03.Enter, tbE1DepEs02.Enter, tbE1DepEs01.Enter, tbE1DepDR30.Enter, tbE1DepDR29.Enter, tbE1DepDR28.Enter, tbE1DepDR27.Enter, tbE1DepDR26.Enter, tbE1DepDR25.Enter, tbE1DepDR24.Enter, tbE1DepDR23.Enter, tbE1DepDR22.Enter, tbE1DepDR21.Enter, tbE1DepDR20.Enter, tbE1DepDR19.Enter, tbE1DepDR18.Enter, tbE1DepDR17.Enter, tbE1DepDR16.Enter, tbE1DepDR15.Enter, tbE1DepDR14.Enter, tbE1DepDR13.Enter, tbE1DepDR12.Enter, tbE1DepDR11.Enter, tbE1DepDR10.Enter, tbE1DepDR09.Enter, tbE1DepDR08.Enter, tbE1DepDR07.Enter, tbE1DepDR06.Enter, tbE1DepDR05.Enter, tbE1DepDR04.Enter, tbE1DepDR03.Enter, tbE1DepDR02.Enter, tbE1DepDR01.Enter, tbE1Costo30.Enter, tbE1Costo29.Enter, tbE1Costo28.Enter, tbE1Costo27.Enter, tbE1Costo26.Enter, tbE1Costo25.Enter, tbE1Costo24.Enter, tbE1Costo23.Enter, tbE1Costo22.Enter, tbE1Costo21.Enter, tbE1Costo20.Enter, tbE1Costo19.Enter, tbE1Costo18.Enter, tbE1Costo17.Enter, tbE1Costo16.Enter, tbE1Costo15.Enter, tbE1Costo14.Enter, tbE1Costo13.Enter, tbE1Costo12.Enter, tbE1Costo11.Enter, tbE1Costo10.Enter, tbE1Costo09.Enter, tbE1Costo08.Enter, tbE1Costo07.Enter, tbE1Costo06.Enter, tbE1Costo05.Enter, tbE1Costo04.Enter, tbE1Costo03.Enter, tbE1Costo02.Enter, tbE1Costo01.Enter, tbDRecMej9.Enter, tbDRecMej8.Enter, tbDRecMej7.Enter, tbDRecMej6.Enter, tbDRecMej5.Enter, tbDRecMej4.Enter, tbDRecMej3.Enter, tbDRecMej2.Enter, tbDRecMej1.Enter, tbDescAmor9.Enter, tbDescAmor8.Enter, tbDescAmor7.Enter, tbDescAmor6.Enter, tbDescAmor5.Enter, tbDescAmor4.Enter, tbDescAmor3.Enter, tbDescAmor2.Enter, tbDescAmor1.Enter, tbDepRAno9.Enter, tbDepRAno8.Enter, tbDepRAno7.Enter, tbDepRAno6.Enter, tbDepRAno5.Enter, tbDepRAno4.Enter, tbDepRAno3.Enter, tbDepRAno2.Enter, tbDepRAno1.Enter, tbCVeh.Enter, tbCostaMej9.Enter, tbCostaMej8.Enter, tbCostaMej7.Enter, tbCostaMej6.Enter, tbCostaMej5.Enter, tbCostaMej4.Enter, tbCostaMej3.Enter, tbCostaMej2.Enter, tbCostaMej1.Enter, tbCostaFle9.Enter, tbCostaFle8.Enter, tbCostaFle7.Enter, tbCostaFle6.Enter, tbCostaFle5.Enter, tbCostaFle4.Enter, tbCostaFle3.Enter, tbCostaFle2.Enter, tbCostaFle1.Enter, tbCostaCor9.Enter, tbCostaCor8.Enter, tbCostaCor7.Enter, tbCostaCor6.Enter, tbCostaCor5.Enter, tbCostaCor4.Enter, tbCostaCor3.Enter, tbCostaCor2.Enter, tbCostaCor1.Enter, tbCostaAce9.Enter, tbCostaAce8.Enter, tbCostaAce7.Enter, tbCostaAce6.Enter, tbCostaAce5.Enter, tbCostaAce4.Enter, tbCostaAce3.Enter, tbCostaAce2.Enter, tbCostaAce1.Enter, tbAuto.Enter, mFecPro30.Enter, mFecPro29.Enter, mFecPro28.Enter, mFecPro27.Enter, mFecPro26.Enter, mFecPro25.Enter, mFecPro24.Enter, mFecPro23.Enter, mFecPro22.Enter, mFecPro21.Enter, mFecPro20.Enter, mFecPro19.Enter, mFecPro18.Enter, mFecPro17.Enter, mFecPro16.Enter, mFecPro15.Enter, mFecPro14.Enter, mFecPro13.Enter, mFecPro12.Enter, mFecPro11.Enter, mFecPro10.Enter, mFecPro09.Enter, mFecPro08.Enter, mFecPro07.Enter, mFecPro06.Enter, mFecPro05.Enter, mFecPro04.Enter, mFecPro03.Enter, mFecPro02.Enter, mFecPro01.Enter, mFecMej9.Enter, mFecMej8.Enter, mFecMej7.Enter, mFecMej6.Enter, mFecMej5.Enter, mFecMej4.Enter, mFecMej3.Enter, mFecMej2.Enter, mFecMej1.Enter, mFecFle9.Enter, mFecFle8.Enter, mFecFle7.Enter, mFecFle6.Enter, mFecFle5.Enter, mFecFle4.Enter, mFecFle3.Enter, mFecFle2.Enter, mFecFle1.Enter, mFecCor9.Enter, mFecCor8.Enter, mFecCor7.Enter, mFecCor6.Enter, mFecCor5.Enter, mFecCor4.Enter, mFecCor3.Enter, mFecCor2.Enter, mFecCor1.Enter, mFecAmo9.Enter, mFecAmo8.Enter, mFecAmo7.Enter, mFecAmo6.Enter, mFecAmo5.Enter, mFecAmo4.Enter, mFecAmo3.Enter, mfecAmo2.Enter, mfecAmo1.Enter, mFecAce9.Enter, mFecAce8.Enter, mFecAce7.Enter, mFecAce6.Enter, mFecAce5.Enter, mFecAce4.Enter, mFecAce3.Enter, mFecAce2.Enter, mFecAce1.Enter
  If FlagStart = True Or Answer = 156 Then Exit Sub
  CurValue = ActiveControl.Text : CurValue = GetOnlyChars(CurValue)
  FormLastFocus(i5) = sender.Name
 End Sub

 Private Sub GetDepreciacion()
  'Anejo 
  lbTitle.Text = "Entidad Conducto, Anejo CI, Parte III, Línea 23" : i5 = 37
  If z1 = 10 Then For i = 0 To 292 : Csi(i2) = Trim(x1C(i)) : i2 += 1 : Next : Exit Sub
  lbTitle.Text = "Entidad Conducto, Anejo CI, Parte III, Línea 24" : i5 = 38
  If z1 = 11 Then For i = 0 To 292 : Csi(i2) = Trim(x2C(i)) : i2 += 1 : Next : Exit Sub
  End Sub

 Private Sub ReadDepreciacionE()
  'dep corriente =================================
  tbNomPatCor1.Text = Csi(0) : tbNomPatCor2.Text = Csi(1) : tbNomPatCor3.Text = Csi(2) : tbNomPatCor4.Text = Csi(3) : tbNomPatCor5.Text = Csi(4)
  tbNomPatCor6.Text = Csi(5) : tbNomPatCor7.Text = Csi(6) : tbNomPatCor8.Text = Csi(7) : tbNomPatCor9.Text = Csi(8)
  'fecha
  mFecCor1.Text = Csi(46) : mFecCor2.Text = Csi(47) : mFecCor3.Text = Csi(48) : mFecCor4.Text = Csi(49) : mFecCor5.Text = Csi(50)
  mFecCor6.Text = Csi(51) : mFecCor7.Text = Csi(52) : mFecCor8.Text = Csi(53) : mFecCor9.Text = Csi(54)
  'costo base
  tbCostaCor1.Text = Csi(100) : tbCostaCor2.Text = Csi(101) : tbCostaCor3.Text = Csi(102) : tbCostaCor4.Text = Csi(103) : tbCostaCor5.Text = Csi(104)
  tbCostaCor6.Text = Csi(105) : tbCostaCor7.Text = Csi(106) : tbCostaCor8.Text = Csi(107) : tbCostaCor9.Text = Csi(108)
  'dep reclamada prev ano
  tbRecCor1.Text = Csi(145) : tbRecCor2.Text = Csi(146) : tbRecCor3.Text = Csi(147) : tbRecCor4.Text = Csi(148) : tbRecCor5.Text = Csi(149)
  tbRecCor6.Text = Csi(150) : tbRecCor7.Text = Csi(151) : tbRecCor8.Text = Csi(152) : tbRecCor9.Text = Csi(153)
  'estimado
  tbEstimCor1.Text = Csi(190) : tbEstimCor2.Text = Csi(191) : tbEstimCor3.Text = Csi(192) : tbEstimCor4.Text = Csi(193) : tbEstimCor5.Text = Csi(194)
  tbEstimCor6.Text = Csi(195) : tbEstimCor7.Text = Csi(196) : tbEstimCor8.Text = Csi(197) : tbEstimCor9.Text = Csi(198)
  'dep este ano
  tbResEstCor1.Text = Csi(235) : tbResEstCor2.Text = Csi(236) : tbResEstCor3.Text = Csi(237) : tbResEstCor4.Text = Csi(238) : tbResEstCor5.Text = Csi(239)
  tbResEstCor6.Text = Csi(240) : tbResEstCor7.Text = Csi(241) : tbResEstCor8.Text = Csi(242) : tbResEstCor9.Text = Csi(243)

  'Amortizacion ========================================================
  tbNomPatMej1.Text = Csi(9) : tbNomPatMej2.Text = Csi(10) : tbNomPatMej3.Text = Csi(11) : tbNomPatMej4.Text = Csi(12) : tbNomPatMej5.Text = Csi(13)
  tbNomPatMej6.Text = Csi(14) : tbNomPatMej7.Text = Csi(15) : tbNomPatMej8.Text = Csi(16) : tbNomPatMej9.Text = Csi(17)
  'fecha
  mFecMej1.Text = Csi(55) : mFecMej2.Text = Csi(56) : mFecMej3.Text = Csi(57) : mFecMej4.Text = Csi(58) : mFecMej5.Text = Csi(59)
  mFecMej6.Text = Csi(60) : mFecMej7.Text = Csi(61) : mFecMej8.Text = Csi(62) : mFecMej9.Text = Csi(63)
  'costo base
  tbCostaMej1.Text = Csi(109) : tbCostaMej2.Text = Csi(110) : tbCostaMej3.Text = Csi(111) : tbCostaMej4.Text = Csi(112) : tbCostaMej5.Text = Csi(113)
  tbCostaMej6.Text = Csi(114) : tbCostaMej7.Text = Csi(115) : tbCostaMej8.Text = Csi(116) : tbCostaMej9.Text = Csi(117)
  'dep reclamada prev ano
  tbRecMej1.Text = Csi(154):  tbRecMej2.Text = Csi(155):  tbRecMej3.Text = Csi(156):  tbRecMej4.Text = Csi(157):  tbRecMej5.Text = Csi(158)
  tbRecMej6.Text = Csi(159) : tbRecMej7.Text = Csi(160) : tbRecMej8.Text = Csi(161) : tbRecMej9.Text = Csi(162)
  'estimado
  tbEstimMej1.Text = Csi(199) : tbEstimMej2.Text = Csi(200) : tbEstimMej3.Text = Csi(201) : tbEstimMej4.Text = Csi(202) : tbEstimMej5.Text = Csi(203)
  tbEstimMej6.Text = Csi(204):  tbEstimMej7.Text = Csi(205):  tbEstimMej8.Text = Csi(206):  tbEstimMej9.Text = Csi(207)
  'dep este ano
  tbResEstMej1.Text = Csi(244) : tbResEstMej2.Text = Csi(245) : tbResEstMej3.Text = Csi(246) : tbResEstMej4.Text = Csi(247) : tbResEstMej5.Text = Csi(248)
  tbResEstMej6.Text = Csi(249):  tbResEstMej7.Text = Csi(250):  tbResEstMej8.Text = Csi(251):  tbResEstMej9.Text = Csi(252)

  'Automoviles ===================================================================
  tbDescAmor1.Text = Csi(18) : tbDescAmor2.Text = Csi(19) : tbDescAmor3.Text = Csi(20) : tbDescAmor4.Text = Csi(21) : tbDescAmor5.Text = Csi(22)
  tbDescAmor6.Text = Csi(23) : tbDescAmor7.Text = Csi(24) : tbDescAmor8.Text = Csi(25) : tbDescAmor9.Text = Csi(26)
  'fecha
  mfecAmo1.Text = Csi(64) : mfecAmo2.Text = Csi(65) : mFecAmo3.Text = Csi(66) : mFecAmo4.Text = Csi(67) : mFecAmo5.Text = Csi(68)
  mFecAmo6.Text = Csi(69):  mFecAmo7.Text = Csi(70):  mFecAmo8.Text = Csi(71):  mFecAmo9.Text = Csi(72)
  'costo base
  tbMejCos1.Text = Csi(118) : tbMejCos2.Text = Csi(119) : tbMejCos3.Text = Csi(120) : tbMejCos4.Text = Csi(121) : tbMejCos5.Text = Csi(122)
  tbMejCos6.Text = Csi(123) : tbMejCos7.Text = Csi(124) : tbMejCos8.Text = Csi(125) : tbMejCos9.Text = Csi(126)
  'dep reclamada prev ano
  tbDRecMej1.Text = Csi(163) : tbDRecMej2.Text = Csi(164) : tbDRecMej3.Text = Csi(165) : tbDRecMej4.Text = Csi(166) : tbDRecMej5.Text = Csi(167)
  tbDRecMej6.Text = Csi(168) : tbDRecMej7.Text = Csi(169) : tbDRecMej8.Text = Csi(170) : tbDRecMej9.Text = Csi(171)
  'estimado
  tbEstMej1.Text = Csi(208) : tbEstMej2.Text = Csi(209) : tbEstMej3.Text = Csi(210) : tbEstMej4.Text = Csi(211) : tbEstMej5.Text = Csi(212)
  tbEstMej6.Text = Csi(213) : tbEstMej7.Text = Csi(214) : tbEstMej8.Text = Csi(215) : tbEstMej9.Text = Csi(216)
  'dep este ano
  tbDepRAno1.Text = Csi(253) : tbDepRAno2.Text = Csi(254) : tbDepRAno3.Text = Csi(255) : tbDepRAno4.Text = Csi(256) : tbDepRAno5.Text = Csi(257)
  tbDepRAno6.Text = Csi(258) : tbDepRAno7.Text = Csi(259) : tbDepRAno8.Text = Csi(260) : tbDepRAno9.Text = Csi(261)

  'Dep Flexible ====================================================================
  tbNomPatFle1.Text = Csi(27) : tbNomPatFle2.Text = Csi(28) : tbNomPatFle3.Text = Csi(29) : tbNomPatFle4.Text = Csi(30) : tbNomPatFle5.Text = Csi(31)
  tbNomPatFle6.Text = Csi(32):  tbNomPatFle7.Text = Csi(33):  tbNomPatFle8.Text = Csi(34):  tbNomPatFle9.Text = Csi(35)
  'fecha
  mFecFle1.Text = Csi(73) : mFecFle2.Text = Csi(74) : mFecFle3.Text = Csi(75) : mFecFle4.Text = Csi(76) : mFecFle5.Text = Csi(77)
  mFecFle6.Text = Csi(78) : mFecFle7.Text = Csi(79) : mFecFle8.Text = Csi(80) : mFecFle9.Text = Csi(81)
  'costo base
  tbCostaFle1.Text = Csi(127) : tbCostaFle2.Text = Csi(128) : tbCostaFle3.Text = Csi(129) : tbCostaFle4.Text = Csi(130) : tbCostaFle5.Text = Csi(131)
  tbCostaFle6.Text = Csi(132) : tbCostaFle7.Text = Csi(133) : tbCostaFle8.Text = Csi(134) : tbCostaFle9.Text = Csi(135)
  'dep reclamada prev ano
  tbRecFle1.Text = Csi(172) : tbRecFle2.Text = Csi(173) : tbRecFle3.Text = Csi(174) : tbRecFle4.Text = Csi(175) : tbRecFle5.Text = Csi(176)
  tbRecFle6.Text = Csi(177) : tbRecFle7.Text = Csi(178) : tbRecFle8.Text = Csi(179) : tbRecFle9.Text = Csi(180)
  'estimado
  tbEstimFle1.Text = Csi(217) : tbEstimFle2.Text = Csi(218) : tbEstimFle3.Text = Csi(219) : tbEstimFle4.Text = Csi(220) : tbEstimFle5.Text = Csi(221)
  tbEstimFle6.Text = Csi(222) : tbEstimFle7.Text = Csi(223) : tbEstimFle8.Text = Csi(224) : tbEstimFle9.Text = Csi(225)
  'dep este ano
  tbResEstFle1.Text = Csi(262) : tbResEstFle2.Text = Csi(263) : tbResEstFle3.Text = Csi(264) : tbResEstFle4.Text = Csi(265) : tbResEstFle5.Text = Csi(266)
  tbResEstFle6.Text = Csi(267) : tbResEstFle7.Text = Csi(268) : tbResEstFle8.Text = Csi(269) : tbResEstFle9.Text = Csi(270)

  'Dep Acelerada ====================================================================
  tbNomPatAce1.Text = Csi(36) : tbNomPatAce2.Text = Csi(37) : tbNomPatAce3.Text = Csi(38) : tbNomPatAce4.Text = Csi(39) : tbNomPatAce5.Text = Csi(40)
  tbNomPatAce6.Text = Csi(41) : tbNomPatAce7.Text = Csi(42) : tbNomPatAce8.Text = Csi(43) : tbNomPatAce9.Text = Csi(44)
  'fecha
  mFecAce1.Text = Csi(82) : mFecAce2.Text = Csi(83) : mFecAce3.Text = Csi(84) : mFecAce4.Text = Csi(85) : mFecAce5.Text = Csi(86)
  mFecAce6.Text = Csi(87):  mFecAce7.Text = Csi(88):  mFecAce8.Text = Csi(89):  mFecAce9.Text = Csi(90)
  'costo base
  tbCostaAce1.Text = Csi(136) : tbCostaAce2.Text = Csi(137) : tbCostaAce3.Text = Csi(138) : tbCostaAce4.Text = Csi(139) : tbCostaAce5.Text = Csi(140)
  tbCostaAce6.Text = Csi(141) : tbCostaAce7.Text = Csi(142) : tbCostaAce8.Text = Csi(143) : tbCostaAce9.Text = Csi(144)
  'dep reclamada prev ano
  tbRecAce1.Text = Csi(181):  tbRecAce2.Text = Csi(182):  tbRecAce3.Text = Csi(183):  tbRecAce4.Text = Csi(184):  tbRecAce5.Text = Csi(185)
  tbRecAce6.Text = Csi(186) : tbRecAce7.Text = Csi(187) : tbRecAce8.Text = Csi(188) : tbRecAce9.Text = Csi(189)
  'estimado
  tbEstimAce1.Text = Csi(226) : tbEstimAce2.Text = Csi(227) : tbEstimAce3.Text = Csi(228) : tbEstimAce4.Text = Csi(229) : tbEstimAce5.Text = Csi(230)
  tbEstimAce6.Text = Csi(231) : tbEstimAce7.Text = Csi(232) : tbEstimAce8.Text = Csi(233) : tbEstimAce9.Text = Csi(234)
  'dep este ano
  tbResEstAce1.Text = Csi(271) : tbResEstAce2.Text = Csi(272) : tbResEstAce3.Text = Csi(273) : tbResEstAce4.Text = Csi(274) : tbResEstAce5.Text = Csi(275)
  tbResEstAce6.Text = Csi(276) : tbResEstAce7.Text = Csi(277) : tbResEstAce8.Text = Csi(278) : tbResEstAce9.Text = Csi(279)

  'vehiculos linea inferior
  tbCVeh.Text = Csi(292) : tbAuto.Text = Csi(291)
 End Sub

 Private Sub ReadDepreciacionE1()
  'Tipo Propiedad
  tbProp01.Text = Csi(0) : tbProp02.Text = Csi(1) : tbProp03.Text = Csi(2) : tbProp04.Text = Csi(3) : tbProp05.Text = Csi(4)
  tbProp06.Text = Csi(5):  tbProp07.Text = Csi(6):  tbProp08.Text = Csi(7):  tbProp09.Text = Csi(8)

  tbProp10.Text = Csi(9) : tbProp11.Text = Csi(10) : tbProp12.Text = Csi(11) : tbProp13.Text = Csi(12) : tbProp14.Text = Csi(13) : tbProp15.Text = Csi(14) : tbProp16.Text = Csi(15)
  tbProp17.Text = Csi(16):  tbProp18.Text = Csi(17):  tbProp19.Text = Csi(18):  tbProp20.Text = Csi(19)

  tbProp21.Text = Csi(20) : tbProp22.Text = Csi(21) : tbProp23.Text = Csi(22) : tbProp24.Text = Csi(23) : tbProp25.Text = Csi(24) : tbProp26.Text = Csi(25)
  tbProp27.Text = Csi(26) : tbProp28.Text = Csi(27) : tbProp29.Text = Csi(28) : tbProp30.Text = Csi(29)

  'fecha adq
  mFecPro01.Text = Csi(30) : mFecPro02.Text = Csi(31) : mFecPro03.Text = Csi(32) : mFecPro04.Text = Csi(33) : mFecPro05.Text = Csi(34) : mFecPro06.Text = Csi(35)
  mFecPro07.Text = Csi(36) : mFecPro08.Text = Csi(37) : mFecPro09.Text = Csi(38) : mFecPro10.Text = Csi(39) : mFecPro11.Text = Csi(40) : mFecPro12.Text = Csi(41)
  mFecPro13.Text = Csi(42) : mFecPro14.Text = Csi(43) : mFecPro15.Text = Csi(44) : mFecPro16.Text = Csi(45) : mFecPro17.Text = Csi(46) : mFecPro18.Text = Csi(47)
  mFecPro19.Text = Csi(48) : mFecPro20.Text = Csi(49) : mFecPro21.Text = Csi(50) : mFecPro22.Text = Csi(51) : mFecPro23.Text = Csi(52) : mFecPro24.Text = Csi(53)
  mFecPro25.Text = Csi(54) : mFecPro26.Text = Csi(55) : mFecPro27.Text = Csi(56) : mFecPro28.Text = Csi(57) : mFecPro29.Text = Csi(58) : mFecPro30.Text = Csi(59)

  'Costo u Base
  tbE1Costo01.Text = Csi(60) : tbE1Costo02.Text = Csi(61) : tbE1Costo03.Text = Csi(62) : tbE1Costo04.Text = Csi(63) : tbE1Costo05.Text = Csi(64) : tbE1Costo06.Text = Csi(65)
  tbE1Costo07.Text = Csi(66) : tbE1Costo08.Text = Csi(67) : tbE1Costo09.Text = Csi(68) : tbE1Costo10.Text = Csi(69) : tbE1Costo11.Text = Csi(70) : tbE1Costo12.Text = Csi(71)
  tbE1Costo13.Text = Csi(72) : tbE1Costo14.Text = Csi(73) : tbE1Costo15.Text = Csi(74) : tbE1Costo16.Text = Csi(75) : tbE1Costo17.Text = Csi(76) : tbE1Costo18.Text = Csi(77)
  tbE1Costo19.Text = Csi(78) : tbE1Costo20.Text = Csi(79) : tbE1Costo21.Text = Csi(80) : tbE1Costo22.Text = Csi(81) : tbE1Costo23.Text = Csi(82) : tbE1Costo24.Text = Csi(83)
  tbE1Costo25.Text = Csi(84) : tbE1Costo26.Text = Csi(85) : tbE1Costo27.Text = Csi(86) : tbE1Costo28.Text = Csi(87) : tbE1Costo29.Text = Csi(88) : tbE1Costo30.Text = Csi(89)

  'Dep Reclamada anos ant  (desde la seccion (b) porque la (a) esta dimmed
  tbE1DepRA11.Text = Csi(100) : tbE1DepRA12.Text = Csi(101) : tbE1DepRA13.Text = Csi(102) : tbE1DepRA14.Text = Csi(103) : tbE1DepRA15.Text = Csi(104) : tbE1DepRA16.Text = Csi(105)
  tbE1DepRA17.Text = Csi(106) : tbE1DepRA18.Text = Csi(107) : tbE1DepRA19.Text = Csi(108) : tbE1DepRA20.Text = Csi(109) : tbE1DepRA21.Text = Csi(110) : tbE1DepRA22.Text = Csi(111)
  tbE1DepRA23.Text = Csi(112) : tbE1DepRA24.Text = Csi(113) : tbE1DepRA25.Text = Csi(114) : tbE1DepRA26.Text = Csi(115) : tbE1DepRA27.Text = Csi(116) : tbE1DepRA28.Text = Csi(117)
  tbE1DepRA29.Text = Csi(118):  tbE1DepRA30.Text = Csi(119)

  'Dep Reclamada este ano
  tbE1DepDR01.Text = Csi(150) : tbE1DepDR02.Text = Csi(151) : tbE1DepDR03.Text = Csi(152) : tbE1DepDR04.Text = Csi(153) : tbE1DepDR05.Text = Csi(154) : tbE1DepDR06.Text = Csi(155)
  tbE1DepDR07.Text = Csi(156) : tbE1DepDR08.Text = Csi(157) : tbE1DepDR09.Text = Csi(158) : tbE1DepDR10.Text = Csi(159) : tbE1DepDR11.Text = Csi(160) : tbE1DepDR12.Text = Csi(161)
  tbE1DepDR13.Text = Csi(162) : tbE1DepDR14.Text = Csi(163) : tbE1DepDR15.Text = Csi(164) : tbE1DepDR16.Text = Csi(165) : tbE1DepDR17.Text = Csi(166) : tbE1DepDR18.Text = Csi(167)
  tbE1DepDR19.Text = Csi(168) : tbE1DepDR20.Text = Csi(169) : tbE1DepDR21.Text = Csi(170) : tbE1DepDR22.Text = Csi(171) : tbE1DepDR23.Text = Csi(172) : tbE1DepDR24.Text = Csi(173)
  tbE1DepDR25.Text = Csi(174) : tbE1DepDR26.Text = Csi(175) : tbE1DepDR27.Text = Csi(176) : tbE1DepDR28.Text = Csi(177) : tbE1DepDR29.Text = Csi(178)
  tbE1DepDR30.Text = Csi(179)
 End Sub

 Private Sub SaveTextAll()
  If FlagStart = True Or Answer = 156 Then Exit Sub

  'Anejo E
  If z1 = 1 Or z1 = 3 Or z1 = 4 Or z1 = 6 Or z1 = 7 Or z1 = 8 Or z1 = 10 Then
   'Dep corriente =================================
   Csi(0) = tbNomPatCor1.Text : Csi(1) = tbNomPatCor2.Text : Csi(2) = tbNomPatCor3.Text : Csi(3) = tbNomPatCor4.Text : Csi(4) = tbNomPatCor5.Text
   Csi(5) = tbNomPatCor6.Text : Csi(6) = tbNomPatCor7.Text : Csi(7) = tbNomPatCor8.Text : Csi(8) = tbNomPatCor9.Text
   'fecha
   Csi(46) = mFecCor1.Text : Csi(47) = mFecCor2.Text : Csi(48) = mFecCor3.Text : Csi(49) = mFecCor4.Text : Csi(50) = mFecCor5.Text
   Csi(51) = mFecCor6.Text : Csi(52) = mFecCor7.Text : Csi(53) = mFecCor8.Text : Csi(54) = mFecCor9.Text

   'Amortizacion
   Csi(9) = tbNomPatMej1.Text : Csi(10) = tbNomPatMej2.Text : Csi(11) = tbNomPatMej3.Text : Csi(12) = tbNomPatMej4.Text : Csi(13) = tbNomPatMej5.Text
   Csi(14) = tbNomPatMej6.Text : Csi(15) = tbNomPatMej7.Text : Csi(16) = tbNomPatMej8.Text : Csi(17) = tbNomPatMej9.Text
   'fecha
   Csi(55) = mFecMej1.Text : Csi(56) = mFecMej2.Text : Csi(57) = mFecMej3.Text : Csi(58) = mFecMej4.Text : Csi(59) = mFecMej5.Text
   Csi(60) = mFecMej6.Text : Csi(61) = mFecMej7.Text : Csi(62) = mFecMej8.Text : Csi(63) = mFecMej9.Text

   'Automoviles
   Csi(18) = tbDescAmor1.Text : Csi(19) = tbDescAmor2.Text : Csi(20) = tbDescAmor3.Text : Csi(21) = tbDescAmor4.Text : Csi(22) = tbDescAmor5.Text
   Csi(23) = tbDescAmor6.Text : Csi(24) = tbDescAmor7.Text : Csi(25) = tbDescAmor8.Text : Csi(26) = tbDescAmor9.Text
   'fecha
   Csi(64) = mfecAmo1.Text : Csi(65) = mfecAmo2.Text : Csi(66) = mFecAmo3.Text : Csi(67) = mFecAmo4.Text : Csi(68) = mFecAmo5.Text : Csi(69) = mFecAmo6.Text
   Csi(70) = mFecAmo7.Text : Csi(71) = mFecAmo8.Text : Csi(72) = mFecAmo9.Text

   'Dep Flexible
   Csi(27) = tbNomPatFle1.Text : Csi(28) = tbNomPatFle2.Text : Csi(29) = tbNomPatFle3.Text : Csi(30) = tbNomPatFle4.Text : Csi(31) = tbNomPatFle5.Text
   Csi(32) = tbNomPatFle6.Text : Csi(33) = tbNomPatFle7.Text : Csi(34) = tbNomPatFle8.Text : Csi(35) = tbNomPatFle9.Text
   'fecha
   Csi(73) = mFecFle1.Text : Csi(74) = mFecFle2.Text : Csi(75) = mFecFle3.Text : Csi(76) = mFecFle4.Text : Csi(77) = mFecFle5.Text
   Csi(78) = mFecFle6.Text : Csi(79) = mFecFle7.Text : Csi(80) = mFecFle8.Text : Csi(81) = mFecFle9.Text

   'Dep Acelerada
   Csi(36) = tbNomPatAce1.Text : Csi(37) = tbNomPatAce2.Text : Csi(38) = tbNomPatAce3.Text : Csi(39) = tbNomPatAce4.Text : Csi(40) = tbNomPatAce5.Text
   Csi(41) = tbNomPatAce6.Text : Csi(42) = tbNomPatAce7.Text : Csi(43) = tbNomPatAce8.Text : Csi(44) = tbNomPatAce9.Text
   'fecha
   Csi(82) = mFecAce1.Text : Csi(83) = mFecAce2.Text : Csi(84) = mFecAce3.Text : Csi(85) = mFecAce4.Text : Csi(86) = mFecAce5.Text
   Csi(87) = mFecAce6.Text : Csi(88) = mFecAce7.Text : Csi(89) = mFecAce8.Text : Csi(90) = mFecAce9.Text
  End If

  'Anejo E1
  If z1 = 2 Or z1 = 5 Or z1 = 9 Or z1 = 11 Then
   'Tipo Propiedad
   '''Sistema Computadora
   Csi(0) = tbProp01.Text : Csi(1) = tbProp02.Text : Csi(2) = tbProp03.Text : Csi(3) = tbProp04.Text : Csi(4) = tbProp05.Text
   Csi(5) = tbProp06.Text : Csi(6) = tbProp07.Text : Csi(7) = tbProp08.Text : Csi(8) = tbProp09.Text : Csi(9) = tbProp10.Text
   '''fecha adq
   Csi(30) = mFecPro01.Text : Csi(31) = mFecPro02.Text : Csi(32) = mFecPro03.Text : Csi(33) = mFecPro04.Text : Csi(34) = mFecPro05.Text
   Csi(35) = mFecPro06.Text : Csi(36) = mFecPro07.Text : Csi(37) = mFecPro08.Text : Csi(38) = mFecPro09.Text : Csi(39) = mFecPro10.Text

   '''Equipo Transportacion
   Csi(10) = tbProp11.Text : Csi(11) = tbProp12.Text : Csi(12) = tbProp13.Text : Csi(13) = tbProp14.Text : Csi(14) = tbProp15.Text
   Csi(15) = tbProp16.Text : Csi(16) = tbProp17.Text : Csi(17) = tbProp18.Text : Csi(18) = tbProp19.Text : Csi(19) = tbProp20.Text
   '''fecha adq
   Csi(40) = mFecPro11.Text : Csi(41) = mFecPro12.Text : Csi(42) = mFecPro13.Text : Csi(43) = mFecPro14.Text : Csi(44) = mFecPro15.Text
   Csi(45) = mFecPro16.Text : Csi(46) = mFecPro17.Text : Csi(47) = mFecPro18.Text : Csi(48) = mFecPro19.Text : Csi(49) = mFecPro20.Text

   '''Maq y Equipos Muebles
   Csi(20) = tbProp21.Text : Csi(21) = tbProp22.Text : Csi(22) = tbProp23.Text : Csi(23) = tbProp24.Text : Csi(24) = tbProp25.Text
   Csi(25) = tbProp26.Text : Csi(26) = tbProp27.Text : Csi(27) = tbProp28.Text : Csi(28) = tbProp29.Text : Csi(29) = tbProp30.Text
   '''fecha adq
   Csi(50) = mFecPro21.Text : Csi(51) = mFecPro22.Text : Csi(52) = mFecPro23.Text : Csi(53) = mFecPro24.Text : Csi(54) = mFecPro25.Text
   Csi(55) = mFecPro26.Text : Csi(56) = mFecPro27.Text : Csi(57) = mFecPro28.Text : Csi(58) = mFecPro29.Text : Csi(59) = mFecPro30.Text
  End If
 End Sub

 Private Sub SetAmounts()
  'Anejo E
  If z1 = 1 Or z1 = 3 Or z1 = 4 Or z1 = 6 Or z1 = 7 Or z1 = 8 Or z1 = 10 Then
   'costo base
   Csi(100) = tbCostaCor1.Text : Csi(101) = tbCostaCor2.Text : Csi(102) = tbCostaCor3.Text : Csi(103) = tbCostaCor4.Text : Csi(104) = tbCostaCor5.Text : Csi(105) = tbCostaCor6.Text
   Csi(106) = tbCostaCor7.Text : Csi(107) = tbCostaCor8.Text : Csi(108) = tbCostaCor9.Text
   'dep reclamada prev ano
   Csi(145) = tbRecCor1.Text : Csi(146) = tbRecCor2.Text : Csi(147) = tbRecCor3.Text : Csi(148) = tbRecCor4.Text : Csi(149) = tbRecCor5.Text : Csi(150) = tbRecCor6.Text
   Csi(151) = tbRecCor7.Text : Csi(152) = tbRecCor8.Text : Csi(153) = tbRecCor9.Text
   'estimado
   Csi(190) = tbEstimCor1.Text : Csi(191) = tbEstimCor2.Text : Csi(192) = tbEstimCor3.Text : Csi(193) = tbEstimCor4.Text : Csi(194) = tbEstimCor5.Text : Csi(195) = tbEstimCor6.Text
   Csi(196) = tbEstimCor7.Text : Csi(197) = tbEstimCor8.Text : Csi(198) = tbEstimCor9.Text
   'dep este ano
   Csi(235) = tbResEstCor1.Text : Csi(236) = tbResEstCor2.Text : Csi(237) = tbResEstCor3.Text : Csi(238) = tbResEstCor4.Text : Csi(239) = tbResEstCor5.Text : Csi(240) = tbResEstCor6.Text
   Csi(241) = tbResEstCor7.Text : Csi(242) = tbResEstCor8.Text : Csi(243) = tbResEstCor9.Text

   'Amortizacion ========================================================
   'costo base
   Csi(109) = tbCostaMej1.Text : Csi(110) = tbCostaMej2.Text : Csi(111) = tbCostaMej3.Text : Csi(112) = tbCostaMej4.Text : Csi(113) = tbCostaMej5.Text
   Csi(114) = tbCostaMej6.Text : Csi(115) = tbCostaMej7.Text : Csi(116) = tbCostaMej8.Text : Csi(117) = tbCostaMej9.Text
   'dep reclamada prev ano
   Csi(154) = tbRecMej1.Text : Csi(155) = tbRecMej2.Text : Csi(156) = tbRecMej3.Text : Csi(157) = tbRecMej4.Text : Csi(158) = tbRecMej5.Text : Csi(159) = tbRecMej6.Text
   Csi(160) = tbRecMej7.Text : Csi(161) = tbRecMej8.Text : Csi(162) = tbRecMej9.Text
   'estimado
   Csi(199) = tbEstimMej1.Text : Csi(200) = tbEstimMej2.Text : Csi(201) = tbEstimMej3.Text : Csi(202) = tbEstimMej4.Text : Csi(203) = tbEstimMej5.Text
   Csi(204) = tbEstimMej6.Text : Csi(205) = tbEstimMej7.Text : Csi(206) = tbEstimMej8.Text : Csi(207) = tbEstimMej9.Text
   'dep este ano
   Csi(244) = tbResEstMej1.Text : Csi(245) = tbResEstMej2.Text : Csi(246) = tbResEstMej3.Text : Csi(247) = tbResEstMej4.Text : Csi(248) = tbResEstMej5.Text
   Csi(249) = tbResEstMej6.Text : Csi(250) = tbResEstMej7.Text : Csi(251) = tbResEstMej8.Text : Csi(252) = tbResEstMej9.Text

   'Automoviles ===================================================================
   'costo base
   Csi(118) = tbMejCos1.Text : Csi(119) = tbMejCos2.Text : Csi(120) = tbMejCos3.Text : Csi(121) = tbMejCos4.Text : Csi(122) = tbMejCos5.Text
   Csi(123) = tbMejCos6.Text : Csi(124) = tbMejCos7.Text : Csi(125) = tbMejCos8.Text : Csi(126) = tbMejCos9.Text
   'dep reclamada prev ano
   Csi(163) = tbDRecMej1.Text : Csi(164) = tbDRecMej2.Text : Csi(165) = tbDRecMej3.Text : Csi(166) = tbDRecMej4.Text : Csi(167) = tbDRecMej5.Text
   Csi(168) = tbDRecMej6.Text : Csi(169) = tbDRecMej7.Text : Csi(170) = tbDRecMej8.Text : Csi(171) = tbDRecMej9.Text
   'estimado
   Csi(208) = tbEstMej1.Text : Csi(209) = tbEstMej2.Text : Csi(210) = tbEstMej3.Text : Csi(211) = tbEstMej4.Text : Csi(212) = tbEstMej5.Text
   Csi(213) = tbEstMej6.Text : Csi(214) = tbEstMej7.Text : Csi(215) = tbEstMej8.Text : Csi(216) = tbEstMej9.Text
   'dep este ano
   Csi(253) = tbDepRAno1.Text : Csi(254) = tbDepRAno2.Text : Csi(255) = tbDepRAno3.Text : Csi(256) = tbDepRAno4.Text : Csi(257) = tbDepRAno5.Text
   Csi(258) = tbDepRAno6.Text : Csi(259) = tbDepRAno7.Text : Csi(260) = tbDepRAno8.Text : Csi(261) = tbDepRAno9.Text

   'Dep Flexible ====================================================================
   'costo base
   Csi(127) = tbCostaFle1.Text : Csi(128) = tbCostaFle2.Text : Csi(129) = tbCostaFle3.Text : Csi(130) = tbCostaFle4.Text : Csi(131) = tbCostaFle5.Text
   Csi(132) = tbCostaFle6.Text : Csi(133) = tbCostaFle7.Text : Csi(134) = tbCostaFle8.Text : Csi(135) = tbCostaFle9.Text
   'dep reclamada prev ano
   Csi(172) = tbRecFle1.Text : Csi(173) = tbRecFle2.Text : Csi(174) = tbRecFle3.Text : Csi(175) = tbRecFle4.Text : Csi(176) = tbRecFle5.Text : Csi(177) = tbRecFle6.Text
   Csi(178) = tbRecFle7.Text : Csi(179) = tbRecFle8.Text : Csi(180) = tbRecFle9.Text
   'estimado
   Csi(217) = tbEstimFle1.Text : Csi(218) = tbEstimFle2.Text : Csi(219) = tbEstimFle3.Text : Csi(220) = tbEstimFle4.Text : Csi(221) = tbEstimFle5.Text
   Csi(222) = tbEstimFle6.Text : Csi(223) = tbEstimFle7.Text : Csi(224) = tbEstimFle8.Text : Csi(225) = tbEstimFle9.Text
   'dep este ano
   Csi(262) = tbResEstFle1.Text : Csi(263) = tbResEstFle2.Text : Csi(264) = tbResEstFle3.Text : Csi(265) = tbResEstFle4.Text : Csi(266) = tbResEstFle5.Text
   Csi(267) = tbResEstFle6.Text : Csi(268) = tbResEstFle7.Text : Csi(269) = tbResEstFle8.Text : Csi(270) = tbResEstFle9.Text

   'Dep Acelerada ====================================================================
   'costo base
   Csi(136) = tbCostaAce1.Text : Csi(137) = tbCostaAce2.Text : Csi(138) = tbCostaAce3.Text : Csi(139) = tbCostaAce4.Text : Csi(140) = tbCostaAce5.Text
   Csi(141) = tbCostaAce6.Text : Csi(142) = tbCostaAce7.Text : Csi(143) = tbCostaAce8.Text : Csi(144) = tbCostaAce9.Text
   'dep reclamada prev ano
   Csi(181) = tbRecAce1.Text : Csi(182) = tbRecAce2.Text : Csi(183) = tbRecAce3.Text : Csi(184) = tbRecAce4.Text : Csi(185) = tbRecAce5.Text
   Csi(186) = tbRecAce6.Text : Csi(187) = tbRecAce7.Text : Csi(188) = tbRecAce8.Text : Csi(189) = tbRecAce9.Text
   'estimado
   Csi(226) = tbEstimAce1.Text : Csi(227) = tbEstimAce2.Text : Csi(228) = tbEstimAce3.Text : Csi(229) = tbEstimAce4.Text : Csi(230) = tbEstimAce5.Text
   Csi(231) = tbEstimAce6.Text : Csi(232) = tbEstimAce7.Text : Csi(233) = tbEstimAce8.Text : Csi(234) = tbEstimAce9.Text
   'dep este ano
   Csi(271) = tbResEstAce1.Text : Csi(272) = tbResEstAce2.Text : Csi(273) = tbResEstAce3.Text : Csi(274) = tbResEstAce4.Text : Csi(275) = tbResEstAce5.Text
   Csi(276) = tbResEstAce6.Text : Csi(277) = tbResEstAce7.Text : Csi(278) = tbResEstAce8.Text : Csi(279) = tbResEstAce9.Text

   'vehiculos linea inferior
   Csi(292) = tbCVeh.Text : Csi(291) = tbAuto.Text
  End If
  'Anejo E1
  If z1 = 2 Or z1 = 5 Or z1 = 9 Or z1 = 11 Then
   'Costo u Base
   Csi(60) = tbE1Costo01.Text : Csi(61) = tbE1Costo02.Text : Csi(62) = tbE1Costo03.Text : Csi(63) = tbE1Costo04.Text : Csi(64) = tbE1Costo05.Text
   Csi(65) = tbE1Costo06.Text : Csi(66) = tbE1Costo07.Text : Csi(67) = tbE1Costo08.Text : Csi(68) = tbE1Costo09.Text : Csi(69) = tbE1Costo10.Text

   Csi(70) = tbE1Costo11.Text : Csi(71) = tbE1Costo12.Text : Csi(72) = tbE1Costo13.Text : Csi(73) = tbE1Costo14.Text : Csi(74) = tbE1Costo15.Text
   Csi(75) = tbE1Costo16.Text : Csi(76) = tbE1Costo17.Text : Csi(77) = tbE1Costo18.Text : Csi(78) = tbE1Costo19.Text : Csi(79) = tbE1Costo20.Text

   Csi(80) = tbE1Costo21.Text : Csi(81) = tbE1Costo22.Text : Csi(82) = tbE1Costo23.Text : Csi(83) = tbE1Costo24.Text : Csi(84) = tbE1Costo25.Text
   Csi(85) = tbE1Costo26.Text : Csi(86) = tbE1Costo27.Text : Csi(87) = tbE1Costo28.Text : Csi(88) = tbE1Costo29.Text : Csi(89) = tbE1Costo30.Text

   'Dep Reclamada anos ant  (desde la seccion (b) porque la (a) esta dimmed
   Csi(100) = tbE1DepRA11.Text : Csi(101) = tbE1DepRA12.Text : Csi(102) = tbE1DepRA13.Text : Csi(103) = tbE1DepRA14.Text : Csi(104) = tbE1DepRA15.Text
   Csi(105) = tbE1DepRA16.Text : Csi(106) = tbE1DepRA17.Text : Csi(107) = tbE1DepRA18.Text : Csi(108) = tbE1DepRA19.Text : Csi(109) = tbE1DepRA20.Text

   Csi(110) = tbE1DepRA21.Text : Csi(111) = tbE1DepRA22.Text : Csi(112) = tbE1DepRA23.Text : Csi(113) = tbE1DepRA24.Text : Csi(114) = tbE1DepRA25.Text
   Csi(115) = tbE1DepRA26.Text : Csi(116) = tbE1DepRA27.Text : Csi(117) = tbE1DepRA28.Text : Csi(118) = tbE1DepRA29.Text : Csi(119) = tbE1DepRA30.Text

   'Dep Reclamada este ano
   Csi(150) = tbE1DepDR01.Text : Csi(151) = tbE1DepDR02.Text : Csi(152) = tbE1DepDR03.Text : Csi(153) = tbE1DepDR04.Text : Csi(154) = tbE1DepDR05.Text
   Csi(155) = tbE1DepDR06.Text : Csi(156) = tbE1DepDR07.Text : Csi(157) = tbE1DepDR08.Text : Csi(158) = tbE1DepDR09.Text : Csi(159) = tbE1DepDR10.Text

   Csi(160) = tbE1DepDR11.Text : Csi(161) = tbE1DepDR12.Text : Csi(162) = tbE1DepDR13.Text : Csi(163) = tbE1DepDR14.Text : Csi(164) = tbE1DepDR15.Text
   Csi(165) = tbE1DepDR16.Text : Csi(166) = tbE1DepDR17.Text : Csi(167) = tbE1DepDR18.Text : Csi(168) = tbE1DepDR19.Text : Csi(169) = tbE1DepDR20.Text

   Csi(170) = tbE1DepDR21.Text : Csi(171) = tbE1DepDR22.Text : Csi(172) = tbE1DepDR23.Text : Csi(173) = tbE1DepDR24.Text : Csi(174) = tbE1DepDR25.Text
   Csi(175) = tbE1DepDR26.Text : Csi(176) = tbE1DepDR27.Text : Csi(177) = tbE1DepDR28.Text : Csi(178) = tbE1DepDR29.Text : Csi(179) = tbE1DepDR30.Text
  End If
 End Sub

 Private Sub FillControls()
  'Anejo E
  If z1 = 1 Or z1 = 3 Or z1 = 4 Or z1 = 6 Or z1 = 7 Or z1 = 8 Or z1 = 10 Then
   'dep Corriente
   tbTotalRecl.Text = Csi(280) : tbTotalRecEst.Text = Csi(281)
   'amortizacion
   tbTRecMej.Text = Csi(282) : tbTRecEstMej.Text = Csi(283)
   'automoviles
   tbTotAmoRec.Text = Csi(284) : tbTotAmoRecA.Text = Csi(285)
   'dep flexible
   tbTotalRecFle.Text = Csi(286) : tbTotRecEFle.Text = Csi(287)
   'dep acelerada
   tbTotalRecAce.Text = Csi(288) : tbTotalRecEstAce.Text = Csi(289)
   'gran total
   tbGranTot.Text = Csi(290)
  End If

  'Anejo E1
  If z1 = 2 Or z1 = 5 Or z1 = 9 Or z1 = 11 Then
   tbE1DepDRTot1.Text = Csi(182)
   tbE1DepDRTot2.Text = Csi(185)
   tbE1DepDRTot3.Text = Csi(188)
   tbTot3M.Text = Csi(189)
   'inside Total
   tbE1DepTot1a.Text = Csi(180)
   tbE1DepTot1b.Text = Csi(181)
   tbE1DepDRTot2a.Text = Csi(183)
   tbE1DepDRTot2b.Text = Csi(184)
   tbE1DepDRTot3a.Text = Csi(186)
   tbE1DepDRTot3b.Text = Csi(187)
  End If
 End Sub

 Private Sub CalculateThisAnejo()
  'Anejo E
  If z1 = 1 Or z1 = 3 Or z1 = 4 Or z1 = 6 Or z1 = 7 Or z1 = 8 Or z1 = 10 Then
   'dep corriente ================================
   Valcal = 0 : For i = 145 To 153 : Valcal = Valcal + Val(Csi(i)) : Next
   Csi(280) = Valcal
   Valcal = 0 : For i = 235 To 243 : Valcal = Valcal + Val(Csi(i)) : Next
   Csi(281) = Valcal

   'amortizacion =================================
   Valcal = 0 : For i = 154 To 162 : Valcal = Valcal + Val(Csi(i)) : Next
   Csi(282) = Valcal : tbTotalRecFle.Text = Valcal
   Valcal = 0 : For i = 244 To 252 : Valcal = Valcal + Val(Csi(i)) : Next
   Csi(283) = Valcal

   'automoviles ==================================
   Valcal = 0 : For i = 163 To 171 : Valcal = Valcal + Val(Csi(i)) : Next
   Csi(284) = Valcal : tbTotAmoRec.Text = Valcal
   Valcal = 0 : For i = 253 To 261 : Valcal = Valcal + Val(Csi(i)) : Next
   Csi(285) = Valcal

   'dep flexible =================================
   Valcal = 0 : For i = 172 To 180 : Valcal = Valcal + Val(Csi(i)) : Next
   Csi(286) = Valcal : tbTotalRecFle.Text = Valcal
   Valcal = 0 : For i = 262 To 270 : Valcal = Valcal + Val(Csi(i)) : Next
   Csi(287) = Valcal

   'dep acelerada ================================
   Valcal = 0 : For i = 181 To 189 : Valcal = Valcal + Val(Csi(i)) : Next
   Csi(288) = Valcal : tbTotalRecAce.Text = Valcal
   Valcal = 0 : For i = 271 To 279 : Valcal = Valcal + Val(Csi(i)) : Next
   Csi(289) = Valcal

   'totalizar
   Valcal = Val(Csi(281)) + Val(Csi(283)) + Val(Csi(285)) + Val(Csi(287)) + Val(Csi(289)) + Val(Csi(291))
   Csi(290) = Valcal
  End If

  'Anejo E1
  If z1 = 2 Or z1 = 5 Or z1 = 9 Or z1 = 11 Then
   'sistema computadoras
   Valcal = 0 : For i = 150 To 154 : Valcal = Valcal + Val(Csi(i)) : Next
   Csi(180) = Valcal : tbE1DepTot1a.Text = Valcal
   Valcal = 0 : For i = 155 To 159 : Valcal = Valcal + Val(Csi(i)) : Next
   Csi(181) = Valcal
   'totalizar
   Csi(182) = Val(Csi(180)) + Val(Csi(181))

   'Equipo transportacion terrestre
   Valcal = 0 : For i = 160 To 164 : Valcal = Valcal + Val(Csi(i)) : Next
   Csi(183) = Valcal : tbE1DepDRTot2a.Text = Valcal
   Valcal = 0 : For i = 165 To 169 : Valcal = Valcal + Val(Csi(i)) : Next
   Csi(184) = Valcal
   'totalizar 
   Csi(185) = Val(Csi(183)) + Val(Csi(184))
   'Maquinari y Equipo
   Valcal = 0 : For i = 170 To 174 : Valcal = Valcal + Val(Csi(i)) : Next
   Csi(186) = Valcal
   Valcal = 0 : For i = 175 To 179 : Valcal = Valcal + Val(Csi(i)) : Next
   Csi(187) = Valcal
   'totalizar
   Csi(188) = Val(Csi(186)) + Val(Csi(187))
   'total final
   Csi(189) = Val(Csi(182)) + Val(Csi(185)) + Val(Csi(188))
  End If
 End Sub

 Private Sub VerifyNumber(sender As Object, e As EventArgs) Handles tbResEstMej9.TextChanged, tbResEstMej8.TextChanged, tbResEstMej7.TextChanged, tbResEstMej6.TextChanged, tbResEstMej5.TextChanged, tbResEstMej4.TextChanged, tbResEstMej3.TextChanged, tbResEstMej2.TextChanged, tbResEstMej1.TextChanged, tbResEstFle9.TextChanged, tbResEstFle8.TextChanged, tbResEstFle7.TextChanged, tbResEstFle6.TextChanged, tbResEstFle5.TextChanged, tbResEstFle4.TextChanged, tbResEstFle3.TextChanged, tbResEstFle2.TextChanged, tbResEstFle1.TextChanged, tbResEstCor9.TextChanged, tbResEstCor8.TextChanged, tbResEstCor7.TextChanged, tbResEstCor6.TextChanged, tbResEstCor5.TextChanged, tbResEstCor4.TextChanged, tbResEstCor3.TextChanged, tbResEstCor2.TextChanged, tbResEstCor1.TextChanged, tbResEstAce9.TextChanged, tbResEstAce8.TextChanged, tbResEstAce7.TextChanged, tbResEstAce6.TextChanged, tbResEstAce5.TextChanged, tbResEstAce4.TextChanged, tbResEstAce3.TextChanged, tbResEstAce2.TextChanged, tbResEstAce1.TextChanged, tbRecMej9.TextChanged, tbRecMej8.TextChanged, tbRecMej7.TextChanged, tbRecMej6.TextChanged, tbRecMej5.TextChanged, tbRecMej4.TextChanged, tbRecMej3.TextChanged, tbRecMej2.TextChanged, tbRecMej1.TextChanged, tbRecFle9.TextChanged, tbRecFle8.TextChanged, tbRecFle7.TextChanged, tbRecFle6.TextChanged, tbRecFle5.TextChanged, tbRecFle4.TextChanged, tbRecFle3.TextChanged, tbRecFle2.TextChanged, tbRecFle1.TextChanged, tbRecCor9.TextChanged, tbRecCor8.TextChanged, tbRecCor7.TextChanged, tbRecCor6.TextChanged, tbRecCor5.TextChanged, tbRecCor4.TextChanged, tbRecCor3.TextChanged, tbRecCor2.TextChanged, tbRecCor1.TextChanged, tbRecAce9.TextChanged, tbRecAce8.TextChanged, tbRecAce7.TextChanged, tbRecAce6.TextChanged, tbRecAce5.TextChanged, tbRecAce4.TextChanged, tbRecAce3.TextChanged, tbRecAce2.TextChanged, tbRecAce1.TextChanged, tbMejCos9.TextChanged, tbMejCos8.TextChanged, tbMejCos7.TextChanged, tbMejCos6.TextChanged, tbMejCos5.TextChanged, tbMejCos4.TextChanged, tbMejCos3.TextChanged, tbMejCos2.TextChanged, tbMejCos1.TextChanged, tbEstMej9.TextChanged, tbEstMej8.TextChanged, tbEstMej7.TextChanged, tbEstMej6.TextChanged, tbEstMej5.TextChanged, tbEstMej4.TextChanged, tbEstMej3.TextChanged, tbEstMej2.TextChanged, tbEstMej1.TextChanged, tbEstimMej9.TextChanged, tbEstimMej8.TextChanged, tbEstimMej7.TextChanged, tbEstimMej6.TextChanged, tbEstimMej5.TextChanged, tbEstimMej4.TextChanged, tbEstimMej3.TextChanged, tbEstimMej2.TextChanged, tbEstimMej1.TextChanged, tbEstimFle9.TextChanged, tbEstimFle8.TextChanged, tbEstimFle7.TextChanged, tbEstimFle6.TextChanged, tbEstimFle5.TextChanged, tbEstimFle4.TextChanged, tbEstimFle3.TextChanged, tbEstimFle2.TextChanged, tbEstimFle1.TextChanged, tbEstimCor9.TextChanged, tbEstimCor8.TextChanged, tbEstimCor7.TextChanged, tbEstimCor6.TextChanged, tbEstimCor5.TextChanged, tbEstimCor4.TextChanged, tbEstimCor3.TextChanged, tbEstimCor2.TextChanged, tbEstimCor1.TextChanged, tbEstimAce9.TextChanged, tbEstimAce8.TextChanged, tbEstimAce7.TextChanged, tbEstimAce6.TextChanged, tbEstimAce5.TextChanged, tbEstimAce4.TextChanged, tbEstimAce3.TextChanged, tbEstimAce2.TextChanged, tbEstimAce1.TextChanged, tbE1DepRA30.TextChanged, tbE1DepRA29.TextChanged, tbE1DepRA28.TextChanged, tbE1DepRA27.TextChanged, tbE1DepRA26.TextChanged, tbE1DepRA25.TextChanged, tbE1DepRA24.TextChanged, tbE1DepRA23.TextChanged, tbE1DepRA22.TextChanged, tbE1DepRA21.TextChanged, tbE1DepRA20.TextChanged, tbE1DepRA19.TextChanged, tbE1DepRA18.TextChanged, tbE1DepRA17.TextChanged, tbE1DepRA16.TextChanged, tbE1DepRA15.TextChanged, tbE1DepRA14.TextChanged, tbE1DepRA13.TextChanged, tbE1DepRA12.TextChanged, tbE1DepRA11.TextChanged, tbE1DepRA10.TextChanged, tbE1DepRA09.TextChanged, tbE1DepRA08.TextChanged, tbE1DepRA07.TextChanged, tbE1DepRA06.TextChanged, tbE1DepRA05.TextChanged, tbE1DepRA04.TextChanged, tbE1DepRA03.TextChanged, tbE1DepRA02.TextChanged, tbE1DepRA01.TextChanged, tbE1DepEs30.TextChanged, tbE1DepEs29.TextChanged, tbE1DepEs28.TextChanged, tbE1DepEs27.TextChanged, tbE1DepEs26.TextChanged, tbE1DepEs25.TextChanged, tbE1DepEs24.TextChanged, tbE1DepEs23.TextChanged, tbE1DepEs22.TextChanged, tbE1DepEs21.TextChanged, tbE1DepEs20.TextChanged, tbE1DepEs19.TextChanged, tbE1DepEs18.TextChanged, tbE1DepEs17.TextChanged, tbE1DepEs16.TextChanged, tbE1DepEs15.TextChanged, tbE1DepEs14.TextChanged, tbE1DepEs13.TextChanged, tbE1DepEs12.TextChanged, tbE1DepEs11.TextChanged, tbE1DepEs10.TextChanged, tbE1DepEs09.TextChanged, tbE1DepEs08.TextChanged, tbE1DepEs07.TextChanged, tbE1DepEs06.TextChanged, tbE1DepEs05.TextChanged, tbE1DepEs04.TextChanged, tbE1DepEs03.TextChanged, tbE1DepEs02.TextChanged, tbE1DepEs01.TextChanged, tbE1DepDR30.TextChanged, tbE1DepDR29.TextChanged, tbE1DepDR28.TextChanged, tbE1DepDR27.TextChanged, tbE1DepDR26.TextChanged, tbE1DepDR25.TextChanged, tbE1DepDR24.TextChanged, tbE1DepDR23.TextChanged, tbE1DepDR22.TextChanged, tbE1DepDR21.TextChanged, tbE1DepDR20.TextChanged, tbE1DepDR19.TextChanged, tbE1DepDR18.TextChanged, tbE1DepDR17.TextChanged, tbE1DepDR16.TextChanged, tbE1DepDR15.TextChanged, tbE1DepDR14.TextChanged, tbE1DepDR13.TextChanged, tbE1DepDR12.TextChanged, tbE1DepDR11.TextChanged, tbE1DepDR10.TextChanged, tbE1DepDR09.TextChanged, tbE1DepDR08.TextChanged, tbE1DepDR07.TextChanged, tbE1DepDR06.TextChanged, tbE1DepDR05.TextChanged, tbE1DepDR04.TextChanged, tbE1DepDR03.TextChanged, tbE1DepDR02.TextChanged, tbE1DepDR01.TextChanged, tbE1Costo30.TextChanged, tbE1Costo29.TextChanged, tbE1Costo28.TextChanged, tbE1Costo27.TextChanged, tbE1Costo26.TextChanged, tbE1Costo25.TextChanged, tbE1Costo24.TextChanged, tbE1Costo23.TextChanged, tbE1Costo22.TextChanged, tbE1Costo21.TextChanged, tbE1Costo20.TextChanged, tbE1Costo19.TextChanged, tbE1Costo18.TextChanged, tbE1Costo17.TextChanged, tbE1Costo16.TextChanged, tbE1Costo15.TextChanged, tbE1Costo14.TextChanged, tbE1Costo13.TextChanged, tbE1Costo12.TextChanged, tbE1Costo11.TextChanged, tbE1Costo10.TextChanged, tbE1Costo09.TextChanged, tbE1Costo08.TextChanged, tbE1Costo07.TextChanged, tbE1Costo06.TextChanged, tbE1Costo05.TextChanged, tbE1Costo04.TextChanged, tbE1Costo03.TextChanged, tbE1Costo02.TextChanged, tbE1Costo01.TextChanged, tbDRecMej9.TextChanged, tbDRecMej8.TextChanged, tbDRecMej7.TextChanged, tbDRecMej6.TextChanged, tbDRecMej5.TextChanged, tbDRecMej4.TextChanged, tbDRecMej3.TextChanged, tbDRecMej2.TextChanged, tbDRecMej1.TextChanged, tbDepRAno9.TextChanged, tbDepRAno8.TextChanged, tbDepRAno7.TextChanged, tbDepRAno6.TextChanged, tbDepRAno5.TextChanged, tbDepRAno4.TextChanged, tbDepRAno3.TextChanged, tbDepRAno2.TextChanged, tbDepRAno1.TextChanged, tbCVeh.TextChanged, tbCostaMej9.TextChanged, tbCostaMej8.TextChanged, tbCostaMej7.TextChanged, tbCostaMej6.TextChanged, tbCostaMej5.TextChanged, tbCostaMej4.TextChanged, tbCostaMej3.TextChanged, tbCostaMej2.TextChanged, tbCostaMej1.TextChanged, tbCostaFle9.TextChanged, tbCostaFle8.TextChanged, tbCostaFle7.TextChanged, tbCostaFle6.TextChanged, tbCostaFle5.TextChanged, tbCostaFle4.TextChanged, tbCostaFle3.TextChanged, tbCostaFle2.TextChanged, tbCostaFle1.TextChanged, tbCostaCor9.TextChanged, tbCostaCor8.TextChanged, tbCostaCor7.TextChanged, tbCostaCor6.TextChanged, tbCostaCor5.TextChanged, tbCostaCor4.TextChanged, tbCostaCor3.TextChanged, tbCostaCor2.TextChanged, tbCostaCor1.TextChanged, tbCostaAce9.TextChanged, tbCostaAce8.TextChanged, tbCostaAce7.TextChanged, tbCostaAce6.TextChanged, tbCostaAce5.TextChanged, tbCostaAce4.TextChanged, tbCostaAce3.TextChanged, tbCostaAce2.TextChanged, tbCostaAce1.TextChanged, tbAuto.TextChanged
  'no allow spaces, numbers and symbols
  If FlagStart = True Or Answer = 156 Then Exit Sub
  FlagStart = True
  Try
   F = sender.name
   b = "" : If sender.text = "" Then GoTo 15
   i4 = Len(sender.Text) : If i4 = 0 Then GoTo 15
   ib = sender.text
   For x = 1 To i4
    c = Mid(ib, x, 1) : bba = Asc(c) : If bba > 47 And bba < 58 Then b = b & c
   Next
   'eliminar leading zeros
   Dim mn As String = b : mn = mn.TrimStart("0"c) : sender.text = mn
   sender.SelectionStart = sender.MaxLength
15: SetAmounts() : CalculateThisAnejo() : FillControls() : FlagStart = False
  Catch
   sender.text = ""
  End Try
 End Sub

 Private Sub VerifyChars(sender As Object, e As EventArgs) Handles mFecMej8.TextChanged, mFecMej7.TextChanged, mFecMej6.TextChanged, mFecMej5.TextChanged, mFecMej4.TextChanged, mFecMej3.TextChanged, mFecMej2.TextChanged, mFecMej1.TextChanged
  'allow spaces, no numbers and symbols
  If FlagStart = True Or Answer = 156 Then Exit Sub
  Dim StrLength As Int32 = Len(sender.Text)
  If sender.text = "" Then GoTo 16
  For x = 1 To StrLength
   c = Mid$(sender.Text, x, 1)
   bba = Asc(c)
   If bba = 32 Or bba = 46 Then GoTo 15
   If bba >= 48 And bba <= 57 Then GoTo 15
   If bba < 65 Or bba > 90 Then b = sender.text : sender.text = b.Substring(0, StrLength - 1) : sender.SelectionStart = sender.MaxLength
15: Next
16: SaveTextAll()
 End Sub

 Private Sub VerifyCharsNoLimit(sender As Object, e As EventArgs) Handles tbNomPatCor1.TextChanged, tbProp30.TextChanged, tbProp29.TextChanged, tbProp28.TextChanged, tbProp27.TextChanged, tbProp26.TextChanged, tbProp25.TextChanged, tbProp24.TextChanged, tbProp23.TextChanged, tbProp22.TextChanged, tbProp21.TextChanged, tbProp20.TextChanged, tbProp19.TextChanged, tbProp18.TextChanged, tbProp17.TextChanged, tbProp16.TextChanged, tbProp15.TextChanged, tbProp14.TextChanged, tbProp13.TextChanged, tbProp12.TextChanged, tbProp11.TextChanged, tbProp10.TextChanged, tbProp09.TextChanged, tbProp08.TextChanged, tbProp07.TextChanged, tbProp06.TextChanged, tbProp05.TextChanged, tbProp04.TextChanged, tbProp03.TextChanged, tbProp02.TextChanged, tbProp01.TextChanged, tbNomPatMej9.TextChanged, tbNomPatMej8.TextChanged, tbNomPatMej7.TextChanged, tbNomPatMej6.TextChanged, tbNomPatMej5.TextChanged, tbNomPatMej4.TextChanged, tbNomPatMej3.TextChanged, tbNomPatMej2.TextChanged, tbNomPatMej1.TextChanged, tbNomPatFle9.TextChanged, tbNomPatFle8.TextChanged, tbNomPatFle7.TextChanged, tbNomPatFle6.TextChanged, tbNomPatFle5.TextChanged, tbNomPatFle4.TextChanged, tbNomPatFle3.TextChanged, tbNomPatFle2.TextChanged, tbNomPatFle1.TextChanged, tbNomPatCor9.TextChanged, tbNomPatCor8.TextChanged, tbNomPatCor7.TextChanged, tbNomPatCor6.TextChanged, tbNomPatCor5.TextChanged, tbNomPatCor4.TextChanged, tbNomPatCor3.TextChanged, tbNomPatCor2.TextChanged, tbNomPatAce9.TextChanged, tbNomPatAce8.TextChanged, tbNomPatAce7.TextChanged, tbNomPatAce6.TextChanged, tbNomPatAce5.TextChanged, tbNomPatAce4.TextChanged, tbNomPatAce3.TextChanged, tbNomPatAce2.TextChanged, tbNomPatAce1.TextChanged, tbDescAmor9.TextChanged, tbDescAmor8.TextChanged, tbDescAmor7.TextChanged, tbDescAmor6.TextChanged, tbDescAmor5.TextChanged, tbDescAmor4.TextChanged, tbDescAmor3.TextChanged, tbDescAmor2.TextChanged, tbDescAmor1.TextChanged
  If FlagStart = True Or Answer = 156 Then Exit Sub
  SaveTextAll()
 End Sub

 Private Sub CheckFecha2(sender As Object, e As EventArgs) Handles mFecPro30.Leave, mFecPro29.Leave, mFecPro28.Leave, mFecPro27.Leave, mFecPro26.Leave, mFecPro25.Leave, mFecPro24.Leave, mFecPro23.Leave, mFecPro22.Leave, mFecPro21.Leave, mFecPro20.Leave, mFecPro19.Leave, mFecPro18.Leave, mFecPro17.Leave, mFecPro16.Leave, mFecPro15.Leave, mFecPro14.Leave, mFecPro13.Leave, mFecPro12.Leave, mFecPro11.Leave, mFecPro10.Leave, mFecPro09.Leave, mFecPro08.Leave, mFecPro07.Leave, mFecPro06.Leave, mFecPro05.Leave, mFecPro04.Leave, mFecPro03.Leave, mFecPro02.Leave, mFecPro01.Leave
  If FlagStart = True Or Answer = 156 Then Exit Sub
  If sender.Focused Then
   Try
    F = sender.Text : If F = "" Then SaveTextAll() : Exit Sub
    If Len(F) < 5 Then sender.Text = CurValue : sender.Focus() : Exit Sub
    If Len(F) <> 6 And Len(F) <> 8 Then sender.Focus() : Exit Sub
    VerificarFecha(F)
    If F.Substring(6, 4) > AnoInUse Then Tr = True
    If Tr = True Then sender.Text = "" : sender.Focus() : Exit Sub
    Tr = VerifyFechaFutura(F)
    If Tr = True Then sender.Text = "" : sender.Focus() : Exit Sub
    'all good save date
    sender.text = F : SaveTextAll()
   Catch
    sender.Text = "" : sender.Focus() : Exit Sub
   End Try
  End If
 End Sub

 Private Sub CheckFecha(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mFecMej9.Validating, mFecMej8.Validating, mFecMej7.Validating, mFecMej6.Validating, mFecMej5.Validating, mFecMej4.Validating, mFecMej3.Validating, mFecMej2.Validating, mFecMej1.Validating, mFecCor9.Validating, mFecCor8.Validating, mFecCor7.Validating, mFecCor6.Validating, mFecCor5.Validating, mFecCor4.Validating, mFecCor3.Validating, mFecCor2.Validating, mFecCor1.Validating, mFecAmo9.Validating, mFecAmo8.Validating, mFecAmo7.Validating, mFecAmo6.Validating, mFecAmo5.Validating, mFecAmo4.Validating, mFecAmo3.Validating, mfecAmo2.Validating, mfecAmo1.Validating
  If FlagStart = True Or Answer = 156 Then Exit Sub
  If sender.Focused Then
   Try
    F = sender.Text : If F = "" Then SaveTextAll() : Exit Sub
    If Len(F) < 5 Then sender.Text = CurValue : sender.Focus() : Exit Sub
    If Len(F) <> 6 And Len(F) <> 8 Then sender.Focus() : Exit Sub
    VerificarFecha(F)
    If F.Substring(6, 4) > AnoInUse Then Tr = True
    If Tr = True Then sender.Text = "" : sender.Focus() : Exit Sub
    Tr = VerifyFechaFutura(F)
    If Tr = True Then sender.Text = "" : sender.Focus() : Exit Sub
    'all good save date
    sender.text = F : SaveTextAll()
   Catch
    sender.Text = "" : sender.Focus() : Exit Sub
   End Try
  End If
 End Sub

 Private Sub CheckFechaJun(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mFecFle9.Validating, mFecFle8.Validating, mFecFle7.Validating, mFecFle6.Validating, mFecFle5.Validating, mFecFle4.Validating, mFecFle3.Validating, mFecFle2.Validating, mFecFle1.Validating
  If FlagStart = True Or Answer = 156 Then Exit Sub
  If sender.Focused Then
   Try
    F = sender.Text : If F = "" Then SaveTextAll() : Exit Sub
    If Len(F) < 5 Then sender.Text = CurValue : sender.Focus() : Exit Sub
    If Len(F) <> 6 And Len(F) <> 8 Then sender.Focus() : Exit Sub
    VerificarFecha(F)
    If F.Substring(6, 4) > 1995 Then Tr = True
    If Tr = True Then sender.Text = "" : sender.Focus() : Exit Sub
    Tr = VerifyFechaFutura(F)
    If Tr = True Then sender.Text = "" : sender.Focus() : Exit Sub
    'all good save date
    sender.text = F : SaveTextAll()
   Catch
    sender.Text = "" : sender.Focus() : Exit Sub
   End Try
  End If
 End Sub

 Private Sub CheckFechaDJun(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mFecAce9.Validating, mFecAce8.Validating, mFecAce7.Validating, mFecAce6.Validating, mFecAce5.Validating, mFecAce4.Validating, mFecAce3.Validating, mFecAce2.Validating, mFecAce1.Validating
  If FlagStart = True Or Answer = 156 Then Exit Sub
  If sender.Focused Then
   Try
    F = sender.Text : If F = "" Then SaveTextAll() : Exit Sub
    If Len(F) < 5 Then sender.Text = CurValue : sender.Focus() : Exit Sub
    If Len(F) <> 6 And Len(F) <> 8 Then sender.Focus() : Exit Sub
    VerificarFecha(F)
    If F.Substring(6, 4) < 1996 Then Tr = True
    If Tr = True Then sender.Text = "" : sender.Focus() : Exit Sub
    Tr = VerifyFechaFutura(F)
    If Tr = True Then sender.Text = "" : sender.Focus() : Exit Sub
    'all good save date
    sender.text = F : SaveTextAll()
   Catch
    sender.Text = "" : sender.Focus() : Exit Sub
   End Try
  End If
 End Sub

 Private Sub LimpiarAnejoE()
  'dep corr descp			
  tbNomPatCor1.Text = "" : tbNomPatCor2.Text = "" : tbNomPatCor3.Text = "" : tbNomPatCor4.Text = "" : tbNomPatCor5.Text = ""
  tbNomPatCor6.Text = "" : tbNomPatCor7.Text = "" : tbNomPatCor8.Text = "" : tbNomPatCor9.Text = ""
  'fecha
  mFecCor1.Text = "" : mFecCor2.Text = "" : mFecCor3.Text = "" : mFecCor4.Text = "" : mFecCor5.Text = ""
  mFecCor6.Text = "" : mFecCor7.Text = "" : mFecCor8.Text = "" : mFecCor9.Text = ""
  'costo base
  tbCostaCor1.Text = "" : tbCostaCor2.Text = "" : tbCostaCor3.Text = "" : tbCostaCor4.Text = "" : tbCostaCor5.Text = ""
  tbCostaCor6.Text = "" : tbCostaCor7.Text = "" : tbCostaCor8.Text = "" : tbCostaCor9.Text = ""
  'dep reclamada prev ano
  tbRecCor1.Text = "" : tbRecCor2.Text = "" : tbRecCor3.Text = "" : tbRecCor4.Text = "" : tbRecCor5.Text = ""
  tbRecCor6.Text = "" : tbRecCor7.Text = "" : tbRecCor8.Text = "" : tbRecCor9.Text = ""
  'estimado
  tbEstimCor1.Text = "" : tbEstimCor2.Text = "" : tbEstimCor3.Text = "" : tbEstimCor4.Text = "" : tbEstimCor5.Text = ""
  tbEstimCor6.Text = "" : tbEstimCor7.Text = "" : tbEstimCor8.Text = "" : tbEstimCor9.Text = ""
  'dep este ano
  tbResEstCor1.Text = "" : tbResEstCor2.Text = "" : tbResEstCor3.Text = "" : tbResEstCor4.Text = "" : tbResEstCor5.Text = ""
  tbResEstCor6.Text = "" : tbResEstCor7.Text = "" : tbResEstCor8.Text = "" : tbResEstCor9.Text = ""
  'dep flexible
  tbNomPatFle1.Text = "" : tbNomPatFle2.Text = "" : tbNomPatFle3.Text = "" : tbNomPatFle4.Text = "" : tbNomPatFle5.Text = ""
  tbNomPatFle6.Text = "" : tbNomPatFle7.Text = "" : tbNomPatFle8.Text = "" : tbNomPatFle9.Text = ""
  'fecha
  mFecFle1.Text = "" : mFecFle2.Text = "" : mFecFle3.Text = "" : mFecFle4.Text = "" : mFecFle5.Text = ""
  mFecFle6.Text = "" : mFecFle7.Text = "" : mFecFle8.Text = "" : mFecFle9.Text = ""
  'costo base
  tbCostaFle1.Text = "" : tbCostaFle2.Text = "" : tbCostaFle3.Text = "" : tbCostaFle4.Text = "" : tbCostaFle5.Text = ""
  tbCostaFle6.Text = "" : tbCostaFle7.Text = "" : tbCostaFle8.Text = "" : tbCostaFle9.Text = ""
  'dep reclamada prev ano
  tbRecFle1.Text = "" : tbRecFle2.Text = "" : tbRecFle3.Text = "" : tbRecFle4.Text = "" : tbRecFle5.Text = ""
  tbRecFle6.Text = "" : tbRecFle7.Text = "" : tbRecFle8.Text = "" : tbRecFle9.Text = ""
  'estimado
  tbEstimFle1.Text = "" : tbEstimFle2.Text = "" : tbEstimFle3.Text = "" : tbEstimFle4.Text = "" : tbEstimFle5.Text = ""
  tbEstimFle6.Text = "" : tbEstimFle7.Text = "" : tbEstimFle8.Text = "" : tbEstimFle9.Text = ""
  'dep este ano
  tbResEstFle1.Text = "" : tbResEstFle2.Text = "" : tbResEstFle3.Text = "" : tbResEstFle4.Text = "" : tbResEstFle5.Text = ""
  tbResEstFle6.Text = "" : tbResEstFle7.Text = "" : tbResEstFle8.Text = "" : tbResEstFle9.Text = ""
  'totales
  tbTotalRecFle.Text = "" : tbTotRecEFle.Text = ""
  'dep acelerada
  tbNomPatAce1.Text = "" : tbNomPatAce2.Text = "" : tbNomPatAce3.Text = "" : tbNomPatAce4.Text = "" : tbNomPatAce5.Text = ""
  tbNomPatAce6.Text = "" : tbNomPatAce7.Text = "" : tbNomPatAce8.Text = "" : tbNomPatAce9.Text = ""
  'fecha
  mFecAce1.Text = "" : mFecAce2.Text = "" : mFecAce3.Text = "" : mFecAce4.Text = "" : mFecAce5.Text = ""
  mFecAce6.Text = "" : mFecAce7.Text = "" : mFecAce8.Text = "" : mFecAce9.Text = ""
  'costo base
  tbCostaAce1.Text = "" : tbCostaAce2.Text = "" : tbCostaAce3.Text = "" : tbCostaAce4.Text = "" : tbCostaAce5.Text = ""
  tbCostaAce6.Text = "" : tbCostaAce7.Text = "" : tbCostaAce8.Text = "" : tbCostaAce9.Text = ""
  'dep reclamada prev ano
  tbRecAce1.Text = "" : tbRecAce2.Text = "" : tbRecAce3.Text = "" : tbRecAce4.Text = "" : tbRecAce5.Text = ""
  tbRecAce6.Text = "" : tbRecAce7.Text = "" : tbRecAce8.Text = "" : tbRecAce9.Text = ""
  'estimado
  tbEstimAce1.Text = "" : tbEstimAce2.Text = "" : tbEstimAce3.Text = "" : tbEstimAce4.Text = "" : tbEstimAce5.Text = ""
  tbEstimAce6.Text = "" : tbEstimAce7.Text = "" : tbEstimAce8.Text = "" : tbEstimAce9.Text = ""
  'dep este ano
  tbResEstAce1.Text = "" : tbResEstAce2.Text = "" : tbResEstAce3.Text = "" : tbResEstAce4.Text = "" : tbResEstAce5.Text = ""
  tbResEstAce6.Text = "" : tbResEstAce7.Text = "" : tbResEstAce8.Text = "" : tbResEstAce9.Text = ""
  'totales
  tbTotalRecAce.Text = "" : tbTotalRecEstAce.Text = ""
  'Mejoras & Goodwill =================================================
  tbNomPatMej1.Text = "" : tbNomPatMej2.Text = "" : tbNomPatMej3.Text = "" : tbNomPatMej4.Text = "" : tbNomPatMej5.Text = ""
  tbNomPatMej6.Text = "" : tbNomPatMej7.Text = "" : tbNomPatMej8.Text = "" : tbNomPatMej9.Text = ""
  'fecha
  mFecMej1.Text = "" : mFecMej2.Text = "" : mFecMej3.Text = "" : mFecMej4.Text = "" : mFecMej5.Text = ""
  mFecMej6.Text = "" : mFecMej7.Text = "" : mFecMej8.Text = "" : mFecMej9.Text = ""
  'costo base
  tbCostaMej1.Text = "" : tbCostaMej2.Text = "" : tbCostaMej3.Text = "" : tbCostaMej4.Text = "" : tbCostaMej5.Text = ""
  tbCostaMej6.Text = "" : tbCostaMej7.Text = "" : tbCostaMej8.Text = "" : tbCostaMej9.Text = ""
  'dep reclamada prev ano
  tbRecMej1.Text = "" : tbRecMej2.Text = "" : tbRecMej3.Text = "" : tbRecMej4.Text = "" : tbRecMej5.Text = ""
  tbRecMej6.Text = "" : tbRecMej7.Text = "" : tbRecMej8.Text = "" : tbRecMej9.Text = ""
  'estimado
  tbEstimMej1.Text = "" : tbEstimMej2.Text = "" : tbEstimMej3.Text = "" : tbEstimMej4.Text = "" : tbEstimMej5.Text = ""
  tbEstimMej6.Text = "" : tbEstimMej7.Text = "" : tbEstimMej8.Text = "" : tbEstimMej9.Text = ""
  'dep este ano
  tbResEstMej1.Text = "" : tbResEstMej2.Text = "" : tbResEstMej3.Text = "" : tbResEstMej4.Text = "" : tbResEstMej5.Text = ""
  tbResEstMej6.Text = "" : tbResEstMej7.Text = "" : tbResEstMej8.Text = "" : tbResEstMej9.Text = ""

  'Amortizacion Goodwill
  tbDescAmor1.Text = "" : tbDescAmor2.Text = "" : tbDescAmor3.Text = "" : tbDescAmor4.Text = "" : tbDescAmor5.Text = ""
  tbDescAmor6.Text = "" : tbDescAmor7.Text = "" : tbDescAmor8.Text = "" : tbDescAmor9.Text = ""
  'fecha
  mfecAmo1.Text = "" : mfecAmo2.Text = "" : mFecAmo3.Text = "" : mFecAmo4.Text = "" : mFecAmo5.Text = ""
  mFecAmo6.Text = "" : mFecAmo7.Text = "" : mFecAmo8.Text = "" : mFecAmo9.Text = ""
  'costo base
  tbMejCos1.Text = "" : tbMejCos2.Text = "" : tbMejCos3.Text = "" : tbMejCos4.Text = "" : tbMejCos5.Text = ""
  tbMejCos6.Text = "" : tbMejCos7.Text = "" : tbMejCos8.Text = "" : tbMejCos9.Text = ""
  'dep reclamada prev ano
  tbDRecMej1.Text = "" : tbDRecMej2.Text = "" : tbDRecMej3.Text = "" : tbDRecMej4.Text = "" : tbDRecMej5.Text = ""
  tbDRecMej6.Text = "" : tbDRecMej7.Text = "" : tbDRecMej8.Text = "" : tbDRecMej9.Text = ""
  'estimado
  tbEstMej1.Text = "" : tbEstMej2.Text = "" : tbEstMej3.Text = "" : tbEstMej4.Text = "" : tbEstMej5.Text = ""
  tbEstMej6.Text = "" : tbEstMej7.Text = "" : tbEstMej8.Text = "" : tbEstMej9.Text = ""
  'dep este ano
  tbDepRAno1.Text = "" : tbDepRAno2.Text = "" : tbDepRAno3.Text = "" : tbDepRAno4.Text = "" : tbDepRAno5.Text = ""
  tbDepRAno6.Text = "" : tbDepRAno7.Text = "" : tbDepRAno8.Text = "" : tbDepRAno9.Text = ""
  tbCVeh.Text = "" : tbAuto.Text = ""

  For i = 0 To 292 : Csi(i) = "" : Next

 End Sub

 Private Sub LimpiarAnejoE1()
  'Ano 2019
  tbProp01.Text = "" : tbProp02.Text = "" : tbProp03.Text = "" : tbProp04.Text = "" : tbProp05.Text = ""
  tbProp06.Text = "" : tbProp07.Text = "" : tbProp08.Text = "" : tbProp09.Text = "" : tbProp10.Text = ""
  tbProp11.Text = "" : tbProp12.Text = "" : tbProp13.Text = "" : tbProp14.Text = "" : tbProp15.Text = ""
  tbProp16.Text = "" : tbProp17.Text = "" : tbProp18.Text = "" : tbProp19.Text = "" : tbProp20.Text = ""
  tbProp21.Text = "" : tbProp22.Text = "" : tbProp23.Text = "" : tbProp24.Text = "" : tbProp25.Text = ""
  tbProp26.Text = "" : tbProp27.Text = "" : tbProp28.Text = "" : tbProp29.Text = "" : tbProp30.Text = ""

  mFecPro01.Text = "" : mFecPro02.Text = "" : mFecPro03.Text = "" : mFecPro04.Text = "" : mFecPro05.Text = ""
  mFecPro06.Text = "" : mFecPro07.Text = "" : mFecPro08.Text = "" : mFecPro09.Text = "" : mFecPro10.Text = ""
  mFecPro11.Text = "" : mFecPro12.Text = "" : mFecPro13.Text = "" : mFecPro14.Text = "" : mFecPro15.Text = ""
  mFecPro16.Text = "" : mFecPro17.Text = "" : mFecPro18.Text = "" : mFecPro19.Text = "" : mFecPro20.Text = ""
  mFecPro21.Text = "" : mFecPro22.Text = "" : mFecPro23.Text = "" : mFecPro24.Text = "" : mFecPro25.Text = ""
  mFecPro26.Text = "" : mFecPro27.Text = "" : mFecPro28.Text = "" : mFecPro29.Text = "" : mFecPro30.Text = ""

  tbE1Costo01.Text = "" : tbE1Costo02.Text = "" : tbE1Costo03.Text = "" : tbE1Costo04.Text = "" : tbE1Costo05.Text = ""
  tbE1Costo06.Text = "" : tbE1Costo07.Text = "" : tbE1Costo08.Text = "" : tbE1Costo09.Text = "" : tbE1Costo10.Text = ""
  tbE1Costo11.Text = "" : tbE1Costo12.Text = "" : tbE1Costo13.Text = "" : tbE1Costo14.Text = "" : tbE1Costo15.Text = ""
  tbE1Costo16.Text = "" : tbE1Costo17.Text = "" : tbE1Costo18.Text = "" : tbE1Costo19.Text = "" : tbE1Costo20.Text = ""
  tbE1Costo21.Text = "" : tbE1Costo22.Text = "" : tbE1Costo23.Text = "" : tbE1Costo24.Text = "" : tbE1Costo25.Text = ""
  tbE1Costo26.Text = "" : tbE1Costo27.Text = "" : tbE1Costo28.Text = "" : tbE1Costo29.Text = "" : tbE1Costo30.Text = ""

  'no se prog de la 725-729 /  825-829 / 740-744 / 840-844 Porque estan dimmed

  tbE1DepEs11.Text = "" : tbE1DepEs12.Text = "" : tbE1DepEs13.Text = "" : tbE1DepEs14.Text = ""
  tbE1DepEs15.Text = "" : tbE1DepEs16.Text = "" : tbE1DepEs17.Text = "" : tbE1DepEs18.Text = ""
  tbE1DepEs19.Text = "" : tbE1DepEs20.Text = ""

  tbE1DepEs21.Text = "" : tbE1DepEs22.Text = "" : tbE1DepEs23.Text = "" : tbE1DepEs24.Text = ""
  tbE1DepEs25.Text = "" : tbE1DepEs26.Text = "" : tbE1DepEs27.Text = "" : tbE1DepEs28.Text = ""
  tbE1DepEs29.Text = "" : tbE1DepEs30.Text = ""

  tbE1DepRA11.Text = "" : tbE1DepRA12.Text = "" : tbE1DepRA13.Text = "" : tbE1DepRA14.Text = "" : tbE1DepRA15.Text = ""
  tbE1DepRA16.Text = "" : tbE1DepRA17.Text = "" : tbE1DepRA18.Text = "" : tbE1DepRA19.Text = "" : tbE1DepRA20.Text = ""
  tbE1DepRA21.Text = "" : tbE1DepRA22.Text = "" : tbE1DepRA23.Text = "" : tbE1DepRA24.Text = "" : tbE1DepRA25.Text = ""
  tbE1DepRA26.Text = "" : tbE1DepRA27.Text = "" : tbE1DepRA28.Text = "" : tbE1DepRA29.Text = "" : tbE1DepRA30.Text = ""

  tbE1DepDR01.Text = "" : tbE1DepDR02.Text = "" : tbE1DepDR03.Text = "" : tbE1DepDR04.Text = "" : tbE1DepDR05.Text = ""
  tbE1DepDR06.Text = "" : tbE1DepDR07.Text = "" : tbE1DepDR08.Text = "" : tbE1DepDR09.Text = "" : tbE1DepDR10.Text = ""
  tbE1DepDR11.Text = "" : tbE1DepDR12.Text = "" : tbE1DepDR13.Text = "" : tbE1DepDR14.Text = "" : tbE1DepDR15.Text = ""
  tbE1DepDR16.Text = "" : tbE1DepDR17.Text = "" : tbE1DepDR18.Text = "" : tbE1DepDR19.Text = "" : tbE1DepDR20.Text = ""
  tbE1DepDR21.Text = "" : tbE1DepDR22.Text = "" : tbE1DepDR23.Text = "" : tbE1DepDR24.Text = "" : tbE1DepDR25.Text = ""
  tbE1DepDR26.Text = "" : tbE1DepDR27.Text = "" : tbE1DepDR28.Text = "" : tbE1DepDR29.Text = "" : tbE1DepDR30.Text = ""

  For i = 0 To 292 : Csi(i) = "" : Next

 End Sub

 Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
  For Each CrR As Control In Panel1.Controls
   If CrR.Name = FormLastFocus(i5) Then Panel1.Controls(CrR.Name).Focus() : Exit For
  Next CrR
  FlagStart = False : Timer1.Enabled = False
 End Sub

 Private Sub bt4_Click(sender As Object, e As EventArgs) Handles bt4.Click
  MsgId = "EstSegLimp" : ErrMsgDialog.ShowDialog()
  If Answer = 0 Then Exit Sub
  Select Case z1
   Case 1, 3, 4, 6, 7, 8, 10
    LimpiarAnejoE()
   Case 2, 5, 9, 11
    LimpiarAnejoE1()
  End Select
 End Sub

 Private Sub bt5_Click(sender As Object, e As EventArgs) Handles bt5.Click
  'Anejo Ci
  'If z1 = 10 Then i5 = 31 : For i = 0 To 292 : x1C(i) = Csi(i2) : i2 += 1 : Next : IiP1(81) = x1C(290)
  'If z1 = 11 Then i5 = 32 : For i = 0 To 292 : x2C(i) = Csi(i2) : i2 += 1 : Next : CiI(82) = x2C(189)
  Me.Dispose()
 End Sub
End Class