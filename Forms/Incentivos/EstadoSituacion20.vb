
Imports System.Windows.Forms

Public Class EstadoSituacion20
 Dim FlagStart As Boolean, bba As Integer

 Public Sub New()
  InitializeComponent() : ReSize1.Enabled = True : Me.WindowState = FormWindowState.Minimized
 End Sub

 Private Sub _HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
  Me.WindowState = FormWindowState.Maximized : ReSize1.Enabled = False
 End Sub

 Private Sub CorpEstSit15_Activated(sender As Object, e As EventArgs) Handles Me.Activated
  FlagStart = True : MdiMain.tbEstSit.Checked = True : UsePage = "IndEstadoSit"
 FillInputControl() : FillControls()
 End Sub

 Private Sub _Load(sender As Object, e As EventArgs) Handles Me.Load
  For Each CrR As Control In Me.Controls
   If CrR.Name = FormLastFocus(1) Then CrR.Focus() : Exit For
  Next CrR
  FlagStart = False
 End Sub

 Private Sub ShowTagBarraDeAyuda(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbESB04.Enter, tbESA04.Enter, tbESB10.Enter, tbESA10.Enter, tbESB22.Enter, tbESA22.Enter, tbESB21.Enter, tbESA21.Enter, tbESB23.Enter, tbESA23.Enter, tbESB18.Enter, tbESA18.Enter, tbESB12.Enter, tbESA12.Enter, tbESB16.Enter, tbESA16.Enter, tbESB03.Enter, tbESA03.Enter, tbESB09.Enter, tbESA09.Enter, tbESB07.Enter, tbESA07.Enter, tbESB05.Enter, tbESA05.Enter, tbESB14.Enter, tbESA14.Enter, tbESB13.Enter, tbESA13.Enter, tbESB02.Enter, tbESA02.Enter, tbESB08.Enter, tbESA08.Enter, tbESB19.Enter, tbESA19.Enter, tbESB20.Enter, tbESA20.Enter, tbPXV03.Enter, tbPXV01.Enter, tbPXV07.Enter, tbPXV06.Enter, tbPXV05.Enter, tbPXV02.Enter, tbESB01.Enter, tbESA01.Enter, tbESA21.Enter, tbESB21.Enter, tbESB06.Enter, tbESA06.Enter, tbESB15.Enter, tbESA15.Enter, tbESB11.Enter, tbESA11.Enter, tbESB17.Enter, tbESA17.Enter, tbPXV08.Enter, tbPXV09.Enter
  If FlagStart = True Or Answer = 156 Then Exit Sub
  CurValue = ActiveControl.Text : CurValue = GetOnlyChars(CurValue)
  FormLastFocus(1) = sender.name
 End Sub

 Private Sub FillInputControl()
  'Estado Situacion
  'comienzo(ano)
  tbESA01.Text = IiES(0) : tbESA02.Text = IiES(1) : tbESA03.Text = IiES(2) : tbESA04.Text = IiES(4) : tbESA05.Text = IiES(5) : tbESA06.Text = IiES(6)
  tbESA07.Text = IiES(7) : tbESA08.Text = IiES(8) : tbESA09.Text = IiES(9) : tbESA10.Text = IiES(11) : tbESA11.Text = IiES(12) : tbESA12.Text = IiES(13)
  tbESA13.Text = IiES(15) : tbESA14.Text = IiES(16) : tbESA15.Text = IiES(17) : tbESA16.Text = IiES(18) : tbESA17.Text = IiES(19) : tbESA18.Text = IiES(20)
  tbESA19.Text = IiES(22) : tbESA20.Text = IiES(23) : tbESA21.Text = IiES(24) : tbESA22.Text = IiES(25) : tbESA23.Text = IiES(26)

  'terminar del ano
  tbESB01.Text = IiES(30) : tbESB02.Text = IiES(31) : tbESB03.Text = IiES(32) : tbESB04.Text = IiES(34) : tbESB05.Text = IiES(35) : tbESB06.Text = IiES(36)
  tbESB07.Text = IiES(37) : tbESB08.Text = IiES(38) : tbESB09.Text = IiES(39) : tbESB10.Text = IiES(41) : tbESB11.Text = IiES(42) : tbESB12.Text = IiES(43)
  tbESB13.Text = IiES(45) : tbESB14.Text = IiES(46) : tbESB15.Text = IiES(47) : tbESB16.Text = IiES(48) : tbESB17.Text = IiES(49) : tbESB18.Text = IiES(50)
  tbESB19.Text = IiES(52) : tbESB20.Text = IiES(53) : tbESB21.Text = IiES(54) : tbESB22.Text = IiES(55) : tbESB23.Text = IiES(56)

  'Parte XV
  tbPXV01.Text = IiES(60)
  tbPXV02.Text = IiES(61)
  tbPXV03.Text = IiES(62)
  tbPXV05.Text = IiES(64)
  tbPXV06.Text = IiES(65)
  tbPXV07.Text = IiES(66)
  tbPXV08.Text = IiES(68)

 End Sub

 Private Sub FillControls()
  FlagStart = True

  'Estado Situacion
  'comienzo ano
  tbESATot1.Text = IiES(3) : tbESATot2.Text = IiES(10) : tbESATot3.Text = IiES(14) : tbESATot4.Text = IiES(21) : tbESATot5.Text = IiES(27) : tbESATot6.Text = IiES(28)
  'Terminaar ano
  tbESBTot1.Text = IiES(33) : tbESBTot2.Text = IiES(40) : tbESBTot3.Text = IiES(44) : tbESBTot4.Text = IiES(51) : tbESBTot5.Text = IiES(57) : tbESBTot6.Text = IiES(58)
  tbPXV09.Text = IiES(73)
  'Parte XV
  tbPXV04.Text = IiES(63)

  tbPXV11.Text = IiES(80) : tbPXV12.Text = IiES(81) : tbPXV13.Text = IiES(82)
  tbPXV14.Text = IiES(99) : tbPXV15.Text = IiES(100)
  'dif entre activos y pasivo
  tbDifCom.Text = IiES(29) : tbDifTer.Text = IiES(59)
 End Sub

 Sub SetSum()
  If FlagStart = True Or Answer = 156 Then Exit Sub
  'Estado Situacion
  'comienzo(ano)
  IiES(0) = tbESA01.Text : IiES(1) = tbESA02.Text : IiES(2) = tbESA03.Text : IiES(4) = tbESA04.Text : IiES(5) = tbESA05.Text : IiES(6) = tbESA06.Text
  IiES(7) = tbESA07.Text : IiES(8) = tbESA08.Text : IiES(9) = tbESA09.Text : IiES(11) = tbESA10.Text : IiES(12) = tbESA11.Text : IiES(13) = tbESA12.Text
  IiES(15) = tbESA13.Text : IiES(16) = tbESA14.Text : IiES(17) = tbESA15.Text : IiES(18) = tbESA16.Text : IiES(19) = tbESA17.Text : IiES(20) = tbESA18.Text
  IiES(22) = tbESA19.Text : IiES(23) = tbESA20.Text : IiES(24) = tbESA21.Text : IiES(25) = tbESA22.Text : IiES(26) = tbESA23.Text

  'terminar del ano
  IiES(30) = tbESB01.Text : IiES(31) = tbESB02.Text : IiES(32) = tbESB03.Text : IiES(34) = tbESB04.Text : IiES(35) = tbESB05.Text : IiES(36) = tbESB06.Text
  IiES(37) = tbESB07.Text : IiES(38) = tbESB08.Text : IiES(39) = tbESB09.Text : IiES(41) = tbESB10.Text : IiES(42) = tbESB11.Text : IiES(43) = tbESB12.Text
  IiES(45) = tbESB13.Text : IiES(46) = tbESB14.Text : IiES(47) = tbESB15.Text : IiES(48) = tbESB16.Text : IiES(49) = tbESB17.Text : IiES(50) = tbESB18.Text
  IiES(52) = tbESB19.Text : IiES(53) = tbESB20.Text : IiES(54) = tbESB21.Text : IiES(55) = tbESB22.Text : IiES(56) = tbESB23.Text
  'Parte XV
  IiES(60) = tbPXV01.Text
  IiES(61) = tbPXV02.Text
  IiES(62) = tbPXV03.Text
  IiES(64) = tbPXV05.Text
  IiES(65) = tbPXV06.Text
  IiES(66) = tbPXV07.Text
  IiES(68) = tbPXV08.Text

  CalculateThisAnejo() : FillControls()
  FlagStart = False
 End Sub

 Private Sub CalculateThisAnejo()
  'Comenzar el ano ==========================
  '3
  Valcal = Val(IiES(1)) - Val(IiES(2))
  IiES(3) = Valcal
  '8
  Valcal = Val(IiES(8)) - Val(IiES(9))
  IiES(10) = Valcal
  'Total activos
  Valcal = 0
  For i = 3 To 7 : Valcal = Valcal + Val(IiES(i)) : Next
  For i = 10 To 13 : Valcal = Valcal + Val(IiES(i)) : Next
  Valcal = Valcal + Val(IiES(0))
  IiES(14) = Valcal

  'total pasivos
  Valcal = 0
  For i = 15 To 20 : Valcal = Valcal + Val(IiES(i)) : Next
  IiES(21) = Valcal
  'total capital
  Valcal = 0
  For i = 22 To 26 : Valcal = Valcal + Val(IiES(i)) : Next
  IiES(27) = Valcal
  'total Pasivo y capital
  Valcal = Val(IiES(21)) + Val(IiES(27))
  IiES(28) = Valcal

  'al terminar el ano
  '3
  Valcal = Val(IiES(31)) - Val(IiES(32))
  IiES(33) = Valcal
  '8
  Valcal = Val(IiES(38)) - Val(IiES(39))
  IiES(40) = Valcal
  'total activos
  Valcal = 0
  For i = 33 To 37 : Valcal = Valcal + Val(IiES(i)) : Next
  For i = 40 To 43 : Valcal = Valcal + Val(IiES(i)) : Next
  Valcal = Valcal + Val(IiES(30))
  IiES(44) = Valcal
  'total pasivos
  Valcal = 0
  For i = 45 To 50 : Valcal = Valcal + Val(IiES(i)) : Next
  IiES(51) = Valcal
  'total capital
  Valcal = 0
  For i = 52 To 56 : Valcal = Valcal + Val(IiES(i)) : Next
  IiES(57) = Valcal
  'total Pasivo y capital
  Valcal = Val(IiES(51)) + Val(IiES(57))
  IiES(58) = Valcal

  'sacar diferencias activos contra pasivos  Comienzo y terminar ano
  Valcal = Val(IiES(14)) - Val(IiES(28)) : IiES(29) = Valcal
  Valcal = Val(IiES(44)) - Val(IiES(58)) : IiES(59) = Valcal

  ''''''''' Reconciliacion '''''''''''
  Valcal = Val(IiES(64)) + Val(IiES(65)) + Val(IiES(66)) + Val(IiES(67)) + Val(IiES(68)) + Val(IiES(69)) : IiES(70) = Valcal
  'total Linea 6
  Valcal = Val(IiES(60)) + Val(IiES(61)) + Val(IiES(62)) + Val(IiES(63)) + Val(IiES(70)) : IiES(71) = Valcal
  'total Linea 9
  Valcal = Val(IiES(74)) + Val(IiES(75)) : IiES(76) = Valcal
  'total Linea 10
  Valcal = Val(IiES(71)) - Val(IiES(76)) : IiES(79) = Valcal
 End Sub

 Private Sub bt01_Click(sender As Object, e As EventArgs) Handles bt01.Click
  z1 = 1 : Detalle1.ShowDialog() : CalculateThisAnejo() : FillControls() : FlagStart = False
 End Sub

 Sub VerifyNumbers(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbESA01.TextChanged, tbESB04.TextChanged, tbESA04.TextChanged, tbESB10.TextChanged, tbESB21.TextChanged, tbESB22.TextChanged, tbESA22.TextChanged, tbESA21.TextChanged, tbESB23.TextChanged, tbESA23.TextChanged, tbESB18.TextChanged, tbESA18.TextChanged, tbESB12.TextChanged, tbESB16.TextChanged, tbESA16.TextChanged, tbESB03.TextChanged, tbESA03.TextChanged, tbESB09.TextChanged, tbESA09.TextChanged, tbESB07.TextChanged, tbESA07.TextChanged, tbESB05.TextChanged, tbESA05.TextChanged, tbESB14.TextChanged, tbESA14.TextChanged, tbESB01.TextChanged, tbESB13.TextChanged, tbESA13.TextChanged, tbESB02.TextChanged, tbESA02.TextChanged, tbESB08.TextChanged, tbESA08.TextChanged, tbESB19.TextChanged, tbESA19.TextChanged, tbESB20.TextChanged, tbESA20.TextChanged, tbPXV03.TextChanged, tbPXV07.TextChanged, tbPXV06.TextChanged, tbPXV05.TextChanged, tbPXV02.TextChanged, tbPXV01.TextChanged, tbESA10.TextChanged, tbESA12.TextChanged, tbESA06.TextChanged, tbESB06.TextChanged, tbESA15.TextChanged, tbESB15.TextChanged, tbESB11.TextChanged, tbESA11.TextChanged, tbESB17.TextChanged, tbESA17.TextChanged, tbPXV08.TextChanged, tbPXV09.TextChanged
  If FlagStart = True Or Answer = 156 Then Exit Sub
  c = sender.text : VerifyAcceptedOnlyNumbers() : If Answer = 116 Then sender.text = c : sender.SelectionStart = sender.MaxLength : Exit Sub
  SetSum()
15: FlagStart = False
 End Sub
End Class