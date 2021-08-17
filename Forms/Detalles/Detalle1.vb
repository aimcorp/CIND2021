Public Class Detalle1
 Dim FlagStart As Boolean, bba As Integer, i As Integer
 Dim Csi(292) As String

 Private Sub _FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
  SetVarBeforeDispose() : Me.Dispose()
 End Sub

 Private Sub _Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
  FlagStart = True
  ReadVariables() : FillInput() : FillControls()
  For Each CrR As Control In Me.Controls
   If CrR.Name = FormLastFocus(i5) Then CrR.Focus() : c = CrR.Text : CurValue = GetOnlyChars(c) : Exit For
  Next CrR
  FlagStart = False : Answer = 0
 End Sub

 Private Sub ReadVariables()
  If z1 = 1 Then lbTitle.Text = "Detalle Página 2, Reconciliación, Línea 4" : i5 = 2 : For i = 0 To UBound(IPx1) : Csi(i) = IPx1(i) : Next : Exit Sub
 End Sub

 Private Sub ShowTagBarraAyuda(sender As Object, e As EventArgs) Handles tbTotColC.Enter, tbColC24.Enter, tbColC23.Enter, tbColC22.Enter, tbColC21.Enter, tbColC20.Enter, tbColC19.Enter, tbColC18.Enter, tbColC17.Enter, tbColC16.Enter, tbColC15.Enter, tbColC14.Enter, tbColC13.Enter, tbColC12.Enter, tbColC11.Enter, tbColC10.Enter, tbColC09.Enter, tbColC08.Enter, tbColC07.Enter, tbColC06.Enter, tbColC05.Enter, tbColC04.Enter, tbColC03.Enter, tbColC02.Enter, tbColC01.Enter, tb24.Enter, tb23.Enter, tb22.Enter, tb21.Enter, tb20.Enter, tb19.Enter, tb18.Enter, tb17.Enter, tb16.Enter, tb15.Enter, tb14.Enter, tb13.Enter, tb12.Enter, tb11.Enter, tb10.Enter, tb09.Enter, tb08.Enter, tb07.Enter, tb06.Enter, tb05.Enter, tb04.Enter, tb03.Enter, tb02.Enter, tb01.Enter, tbColC25.Enter, tb25.Enter
  If FlagStart = True Or Answer = 156 Then Exit Sub
  CurValue = ActiveControl.Text : CurValue = GetOnlyChars(CurValue)
  FormLastFocus(i5) = ActiveControl.Name
 End Sub

 Private Sub FillInput()
  'Nombre de la persona que realizó el pago
  tb01.Text = Csi(0) : tb02.Text = Csi(1) : tb03.Text = Csi(2) : tb04.Text = Csi(3) : tb05.Text = Csi(4) : tb06.Text = Csi(5) : tb07.Text = Csi(6) : tb08.Text = Csi(7)
  tb09.Text = Csi(8) : tb10.Text = Csi(9) : tb11.Text = Csi(10) : tb12.Text = Csi(11) : tb13.Text = Csi(12) : tb14.Text = Csi(13) : tb15.Text = Csi(14) : tb16.Text = Csi(15)
  tb17.Text = Csi(16) : tb18.Text = Csi(17) : tb19.Text = Csi(18) : tb20.Text = Csi(19) : tb21.Text = Csi(20) : tb22.Text = Csi(21) : tb23.Text = Csi(22) : tb24.Text = Csi(23) : tb25.Text = Csi(24)
  'Columna C
  tbColC01.Text = Csi(30) : tbColC02.Text = Csi(31) : tbColC03.Text = Csi(32) : tbColC04.Text = Csi(33) : tbColC05.Text = Csi(34) : tbColC06.Text = Csi(35) : tbColC07.Text = Csi(36)
  tbColC08.Text = Csi(37) : tbColC09.Text = Csi(38) : tbColC10.Text = Csi(39) : tbColC11.Text = Csi(40) : tbColC12.Text = Csi(41) : tbColC13.Text = Csi(42) : tbColC14.Text = Csi(43)
  tbColC15.Text = Csi(44) : tbColC16.Text = Csi(45) : tbColC17.Text = Csi(46) : tbColC18.Text = Csi(47) : tbColC19.Text = Csi(48) : tbColC20.Text = Csi(49) : tbColC21.Text = Csi(50)
  tbColC22.Text = Csi(51) : tbColC23.Text = Csi(52) : tbColC24.Text = Csi(53) : tbColC25.Text = Csi(54)
 End Sub

 Private Sub FillControls()
  tbTotColC.Text = Val(Csi(60))
 End Sub

 Private Sub SaveText()
  'Nombre de la persona que realizó 
  Csi(0) = tb01.Text : Csi(1) = tb02.Text : Csi(2) = tb03.Text : Csi(3) = tb04.Text : Csi(4) = tb05.Text
  Csi(5) = tb06.Text : Csi(6) = tb07.Text : Csi(7) = tb08.Text : Csi(8) = tb09.Text : Csi(9) = tb10.Text
  Csi(10) = tb11.Text : Csi(11) = tb12.Text : Csi(12) = tb13.Text : Csi(13) = tb14.Text : Csi(14) = tb15.Text
  Csi(15) = tb16.Text : Csi(16) = tb17.Text : Csi(17) = tb18.Text : Csi(18) = tb19.Text : Csi(19) = tb20.Text
  Csi(20) = tb21.Text : Csi(21) = tb22.Text : Csi(22) = tb23.Text : Csi(23) = tb24.Text : Csi(24) = tb25.Text
 End Sub

 Private Sub SaveAmounts()
  Csi(30) = tbColC01.Text : Csi(31) = tbColC02.Text : Csi(32) = tbColC03.Text : Csi(33) = tbColC04.Text : Csi(34) = tbColC05.Text : Csi(35) = tbColC06.Text : Csi(36) = tbColC07.Text
  Csi(37) = tbColC08.Text : Csi(38) = tbColC09.Text : Csi(39) = tbColC10.Text : Csi(40) = tbColC11.Text : Csi(41) = tbColC12.Text : Csi(42) = tbColC13.Text : Csi(43) = tbColC14.Text
  Csi(44) = tbColC15.Text : Csi(45) = tbColC16.Text : Csi(46) = tbColC17.Text : Csi(47) = tbColC18.Text : Csi(48) = tbColC19.Text : Csi(49) = tbColC20.Text : Csi(50) = tbColC21.Text
  Csi(51) = tbColC22.Text : Csi(52) = tbColC23.Text : Csi(53) = tbColC24.Text : Csi(54) = tbColC25.Text
 End Sub

 Private Sub CalcularCsi()
  Valcal = 0 : For i = 30 To 54 : Valcal = Valcal + Val(Csi(i)) : Next : Csi(60) = Valcal
  FillControls()
 End Sub

 Private Sub LimpiarScr()
  'Nombre de la persona que realizó 
  tb01.Text = "" : tb02.Text = "" : tb03.Text = "" : tb04.Text = "" : tb05.Text = "" : tb06.Text = "" : tb07.Text = "" : tb08.Text = "" : tb09.Text = ""
  tb10.Text = "" : tb11.Text = "" : tb12.Text = "" : tb13.Text = "" : tb14.Text = "" : tb15.Text = "" : tb16.Text = "" : tb17.Text = "" : tb18.Text = ""
  tb19.Text = "" : tb20.Text = "" : tb21.Text = "" : tb22.Text = "" : tb23.Text = "" : tb24.Text = "" : tb25.Text = ""
  'Columna C
  tbColC01.Text = "" : tbColC02.Text = "" : tbColC03.Text = "" : tbColC04.Text = "" : tbColC05.Text = "" : tbColC06.Text = "" : tbColC07.Text = "" : tbColC08.Text = ""
  tbColC09.Text = "" : tbColC10.Text = "" : tbColC11.Text = "" : tbColC12.Text = "" : tbColC13.Text = "" : tbColC14.Text = "" : tbColC15.Text = "" : tbColC16.Text = ""
  tbColC17.Text = "" : tbColC18.Text = "" : tbColC19.Text = "" : tbColC20.Text = "" : tbColC21.Text = "" : tbColC22.Text = "" : tbColC23.Text = "" : tbColC24.Text = "" : tbColC25.Text = ""
  SaveAmounts() : SaveText()
 End Sub

 Private Sub VerifyNumbers(sender As Object, e As EventArgs) Handles tbColC24.TextChanged, tbColC23.TextChanged, tbColC22.TextChanged, tbColC21.TextChanged, tbColC20.TextChanged, tbColC19.TextChanged, tbColC18.TextChanged, tbColC17.TextChanged, tbColC16.TextChanged, tbColC15.TextChanged, tbColC14.TextChanged, tbColC13.TextChanged, tbColC12.TextChanged, tbColC11.TextChanged, tbColC10.TextChanged, tbColC09.TextChanged, tbColC08.TextChanged, tbColC07.TextChanged, tbColC06.TextChanged, tbColC05.TextChanged, tbColC04.TextChanged, tbColC03.TextChanged, tbColC02.TextChanged, tbColC01.TextChanged, tbColC25.TextChanged
  'no allow spaces, numbers and symbols
  If FlagStart = True Then Exit Sub
  FlagStart = True
  b = "" : If sender.text = "" Then GoTo 15
  i4 = Len(sender.Text) : If i4 = 0 Then GoTo 15
  ib = sender.text
  For x = 1 To i4
   c = Mid(sender.text, x, 1) : bba = Asc(c) : If bba > 47 And bba < 58 Then b = b & c
  Next
  'eliminar leading zeros
  Dim mn As String = b : mn = mn.TrimStart("0"c) : sender.text = mn
  sender.SelectionStart = sender.MaxLength
15: SaveAmounts() : CalcularCsi() : FlagStart = False
 End Sub

 Private Sub SetVarBeforeDispose()
  If z1 = 1 Then For i = 0 To UBound(IPx1) : IPx1(i) = Csi(i) : Next : IiES(63) = IPx1(60) 'poner el tmp0
 End Sub

 Private Sub SaveTexto(sender As Object, e As EventArgs) Handles tb24.Leave, tb23.Leave, tb22.Leave, tb21.Leave, tb20.Leave, tb19.Leave, tb18.Leave, tb17.Leave, tb16.Leave, tb15.Leave, tb14.Leave, tb13.Leave, tb12.Leave, tb11.Leave, tb10.Leave, tb09.Leave, tb08.Leave, tb07.Leave, tb06.Leave, tb05.Leave, tb04.Leave, tb03.Leave, tb02.Leave, tb01.Leave, tb25.Leave
  SaveText()
 End Sub

 Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
  Me.Dispose()
 End Sub

 Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
  Me.Dispose()
 End Sub

 Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
  LimpiarScr()
 End Sub
End Class