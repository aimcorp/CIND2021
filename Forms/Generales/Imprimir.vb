Imports System.IO
Imports System.Drawing.Printing
Imports System.Diagnostics
Imports Gnostice.PDFOne
Imports Gnostice.PDFOne.PDFPrinter
Imports Gnostice.PDFOne.PDFProAnnot
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Configuration
Imports System.Resources
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text.RegularExpressions

Public Class Imprimir
 Dim Flagstart As Boolean
 Dim rect As Rectangle, lLine As Integer, lLine1 As Integer, iLineCount As Integer
 Dim FontSize As Single
 Public FontA = New PDFFont(Gnostice.PDFOne.StdType1Font.Times_Roman, 10)
 Public FontB = New PDFFont(Gnostice.PDFOne.StdType1Font.Times_Bold, 10)
 Public FontC = New PDFFont(Gnostice.PDFOne.StdType1Font.Helvetica_Bold, 7)
 Public FontC1 = New PDFFont(Gnostice.PDFOne.StdType1Font.Helvetica_Bold, 8)
 Public FontD = New PDFFont(StdType1Font.Times_Bold, PDFFontStyle.Fill, 20)
 Public FontE = New PDFFont(StdType1Font.Helvetica_Bold, 8)
 Public FontG = New PDFFont(StdType1Font.Helvetica_Bold, 9)
 Public FontF = New PDFFont(StdType1Font.Times_Bold, PDFFontStyle.Fill, 7)
 Public FontSm = New PDFFont(Gnostice.PDFOne.StdType1Font.Helvetica_Bold, 5)

 Public Sub InitializePDFControl()
  PdfPrinter = New PDFPrinter("E000-C134-AEEB-A432-5A1D-541F-2E49-157D")
  With PdfPrinter
   .LoadDocument(FileToSave)
   .PrintOptions.DefaultPageSettings.Margins.Left = MargL
   .PrintOptions.DefaultPageSettings.Margins.Right = MargR
   .PrintOptions.DefaultPageSettings.Margins.Top = MargT
   .PrintOptions.DefaultPageSettings.Margins.Bottom = MargB
   .AutoCenter = True
   If PTy = 0 Then PdfPrinter.PageScaleType = PrintScaleType.None
   If PTy = 1 Then PdfPrinter.PageScaleType = PrintScaleType.FitToPrintableArea
   If PTy = 2 Then PdfPrinter.PageScaleType = PrintScaleType.ReduceToPrintableArea
   .Document.MeasurementUnit = PDFMeasurementUnit.Points
  End With
  FileToPrint = AppDir & "AimPr\AimTmp.pdf"  'Open a PDF document from file
 End Sub

 Private Sub Imprimir_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
  PIm = 0
 End Sub

 Private Sub Imprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  If Rsolution = True Then ReSize1.Enabled = True
  Flagstart = True : FPrt = False : ProgressBar1.Value = 0
  'verify if there are printers
  Dim oPS As New System.Drawing.Printing.PrinterSettings
  Dim DefaultPrinterName As String
  Try
   DefaultPrinterName = oPS.PrinterName
  Catch ex As System.Exception
   DefaultPrinterName = ""
  Finally
   oPS = Nothing
  End Try
  'if no Printer Installed
  If DefaultPrinterName = "" Then
   Panel1.Visible = False
   buttonSalir.Enabled = True
   Exit Sub
  End If
  'printer exist
  cbCopies.SelectedIndex = 0 : x = 0
  'Show available printer
  cbPrinter.Items.Clear()
  i = 1 : Dim ca As Integer = -1
  For Each printer As String In PrinterSettings.InstalledPrinters
   cbPrinter.Items.Add(printer.ToString()) : c = printer.ToString() : ca += 1
   If c = prt Then i = ca
  Next printer
  cbPrinter.SelectedIndex = i : ca = Nothing

  'Imp en ingles
  If Compdata.IIn = True Then ckIng.Checked = True Else ckIng.Checked = False

  'what was the last device used
  If Compdata.ImpImpPDFoReader = 0 Then rbImp.Checked = True
  If Compdata.ImpImpPDFoReader = 2 Then rbReader.Checked = True
  ResetTabStop()
  GetAndSetFormButtons()
  btRep.Focus()
  ReDim vtm(500)
  Flagstart = False : Answer = False
 End Sub

 Sub ResetTabStop()
  ck1.TabStop = False
  ck2.TabStop = False : ck3.TabStop = False : ck4.TabStop = False : ck5.TabStop = False
  ck6.TabStop = False : ck7.TabStop = False : ck8.TabStop = False : ck9.TabStop = False : ck10.TabStop = False
  ck11.TabStop = False : ck12.TabStop = False : ck13.TabStop = False : ck14.TabStop = False : ck15.TabStop = False
  ck16.TabStop = False : ck17.TabStop = False : ck18.TabStop = False : ck19.TabStop = False : ck20.TabStop = False
  ck21.TabStop = False : ck22.TabStop = False : ck23.TabStop = False : ck24.TabStop = False : ck25.TabStop = False
  ck26.TabStop = False : ck27.TabStop = False : ck28.TabStop = False : rbImp.TabStop = False
  rbReader.TabStop = False : ckIng.TabStop = False
 End Sub

 Private Sub GetAndSetFormButtons()
  ResetControls()
  If Demo = "Si" And SiWpd = False Then MsgId = "EsUnDemo" : ErrMsgDialog.ShowDialog() : Me.Dispose() : Exit Sub
  ck1.Text = "Página 1" : ck2.Text = "Página 2" : ck3.Text = "Página 3" : ck4.Text = "Página 4" : ck5.Text = "Página 5 (Est Situación)"
  ck6.Text = "Página 6 Cuestionario" : ck7.Text = "Anejo B" : ck8.Text = "Anejo D" : ck9.Text = "Anejo GI" : ck10.Text = "Anejo IE"
  ck11.Text = "Anejo L" : ck12.Text = "Anejo AA" : ck13.Text = "Anejo BB" : ck14.Text = "Anejo CI"
  'turn cks on
  ck1.Visible = True : ck2.Visible = True : ck3.Visible = True : ck4.Visible = True : ck5.Visible = True : ck6.Visible = True : ck7.Visible = True
  ck8.Visible = True : ck9.Visible = True : ck10.Visible = True : ck11.Visible = True : ck12.Visible = True : ck13.Visible = True : ck14.Visible = True
  'turn buttons on
  bt1.Visible = True : bt2.Visible = True : bt3.Visible = True : bt4.Visible = True : bt5.Visible = True : bt6.Visible = True : bt7.Visible = True
  bt8.Visible = True : bt9.Visible = True : bt10.Visible = True : bt11.Visible = True : bt12.Visible = True : bt13.Visible = True : bt14.Visible = True
  'mark the Cks
  ck1.Checked = True : ck2.Checked = True : ck3.Checked = True : ck4.Checked = True : ck5.Checked = True : ck6.Checked = True
  'WhatToPrint


  '  ResetTabStop()
 End Sub

 Public Sub PrintText()      'print a line of text
  If b = "" Then Exit Sub
  PdfPrinter.Document.WriteText(b, FontE, Cux, CuY)
 End Sub

 Public Sub PrintText2()      'print a line of text
  If b = "" Then Exit Sub
  PdfPrinter.Document.WriteText(b, New PDFFont(StdType1Font.Helvetica_Bold, 9), Cux, CuY)
 End Sub

 Public Sub PrintText4()
  If b = "" Then Exit Sub
  PdfPrinter.Document.WriteText(b, FontC1, Cux, CuY)
 End Sub

 Public Sub PrintText5(ByVal d) 'For boxes
  If b = "" Then Exit Sub
  PdfPrinter.Document.WriteText(d, FontC, Cux, CuY)
 End Sub

 Public Sub PrintAlignRight0()
  If Val(b) = 0 Then Exit Sub
  b = FormatNumber(b, 0)
  rect.Width = 80 : rect.Height = 10
  rect.X = Cux : rect.Y = CuY
  PdfPrinter.Document.Font = FontE
  PdfPrinter.Document.WriteText(b, rect, PDFAlignment.Right)
 End Sub

 Public Sub PrintAlignRight()
  If Val(b) = 0 Then Exit Sub
  b = FormatNumber(b, 0)
  rect.Width = 80 : rect.Height = 10
  rect.X = Cux : rect.Y = CuY
  PdfPrinter.Document.Font = FontE
  PdfPrinter.Document.WriteText(b, rect, PDFAlignment.Right)
 End Sub

 Public Sub PrintAlignRight2()
  If Val(b) = 0 Then Exit Sub
  b = FormatNumber(b, 0)
  rect.Width = 80 : rect.Height = 10
  rect.X = Cux : rect.Y = CuY
  PdfPrinter.Document.Font = New PDFFont(StdType1Font.Helvetica_Bold, 9)
  PdfPrinter.Document.WriteText(b, rect, PDFAlignment.Right)
 End Sub

 Public Sub PrintAlignRight3()
  If Val(b) = 0 Then Exit Sub
  b = FormatNumber(b, 0)
  rect.Width = 80 : rect.Height = 10
  rect.X = Cux : rect.Y = CuY
  PdfPrinter.Document.Font = New PDFFont(StdType1Font.Helvetica_Bold, 8)
  PdfPrinter.Document.WriteText(b, rect, PDFAlignment.Right)
 End Sub

 Public Sub PrintAlignCenter2()
  If b = "" Then Exit Sub
  rect.Width = 605 : rect.Height = 10 : rect.Y = CuY
  PdfPrinter.Document.Font = New PDFFont(StdType1Font.Helvetica_Bold, 9)
  PdfPrinter.Document.WriteText(b, rect, PDFAlignment.Center)
 End Sub

 Public Sub PrintAlignCenter3()
  If b = "" Then Exit Sub
  rect.Width = 180 : rect.Height = 10
  rect.X = Cux : rect.Y = CuY
  PdfPrinter.Document.Font = New PDFFont(StdType1Font.Helvetica_Bold, 9)
  PdfPrinter.Document.WriteText(b, rect, PDFAlignment.Center)
 End Sub

 Public Sub PrintAlignCenter()
  If b = "" Then Exit Sub
  rect.Width = 80 : rect.Height = 10
  rect.X = Cux : rect.Y = CuY
  PdfPrinter.Document.Font = FontE
  PdfPrinter.Document.WriteText(b, rect, PDFAlignment.Center)
 End Sub

 Public Sub PrintSpaceText()                     'print a line of text
  PdfPrinter.Document.Font = FontE
  PdfPrinter.Document.WriteText(b, FontSm, Cux, CuY)
 End Sub

 Public Sub PrintAlignRightEsp()   'caso de IVU de Cabo Rojo que tiene una linea asi _________ . ___
  If Val(b) = 0 Then Exit Sub
  Dim b2 As String, x As Int16
  x = Len(b)
  b1 = b.Substring(0, x - 3)
  b2 = b.Substring(x - 2, 2)
  rect.Width = 80 : rect.Height = 10
  rect.X = Cux : rect.Y = CuY
  PdfPrinter.Document.Font = FontG
  PdfPrinter.Document.WriteText(b1, rect, PDFAlignment.Right)
  rect.X = rect.X + 30
  PdfPrinter.Document.WriteText(b2, rect, PDFAlignment.Right)
 End Sub

 Public Sub PrintReduceText(ByVal v As Byte)
  If b = "" Then Exit Sub
  PdfPrinter.Document.WriteText(b, New PDFFont(Gnostice.PDFOne.StdType1Font.Helvetica_Bold, v), Cux, CuY)
 End Sub

 Public Sub PrintAumText(ByVal v As Byte)
  If b = "" Then Exit Sub
  PdfPrinter.Document.WriteText(b, New PDFFont(Gnostice.PDFOne.StdType1Font.Helvetica_Bold, v), Cux, CuY)
 End Sub

 Public Sub PrintSOvals()                'Print Standard Ovals 
  If ovL = 0 Then Exit Sub
  With PdfPrinter
   .Document.Font = FontE
   .Document.Brush = System.Drawing.Brushes.Black
   .Document.DrawEllipse(ovL, ovT, 15, 7, True, False)
   '(ovL=RightX / ovT=TopLeftY / OvW=Width / OvH=Height)
  End With
 End Sub

 Public Sub PrintSOvalSmall()                                'Print Standard Ovals 
  If ovL = 0 Then Exit Sub
  With PdfPrinter
   .Document.Font = FontE
   .Document.Brush = System.Drawing.Brushes.Black
   .Document.DrawEllipse(ovL, ovT, 10, 7, True, True)
   '(ovL=RightX / ovT=TopLeftY / OvW=Width / OvH=Height)
  End With
 End Sub

 Public Sub PrintSOvalSmall2()                                'Print Standard Ovals longer width, lower height
  If ovL = 0 Then Exit Sub
  With PdfPrinter
   .Document.Font = FontE
   .Document.Brush = System.Drawing.Brushes.Black
   .Document.DrawEllipse(ovL, ovT, 12, 6, True, True)
   '(ovL=RightX / ovT=TopLeftY / OvW=Width / OvH=Height)
  End With
 End Sub

 Public Sub PrintSOvalMedium()                                'Print Standard Ovals 
  If ovL = 0 Then Exit Sub
  With PdfPrinter
   .Document.Font = FontE
   .Document.Brush = System.Drawing.Brushes.Black
   .Document.DrawEllipse(ovL, ovT, 13, 8, True, True)
   '(ovL=RightX / ovT=TopLeftY / OvW=Width / OvH=Height)
  End With
 End Sub

 Public Sub PrintRectangleText()
  If b = "" Then Exit Sub
  rect.Width = 300 : rect.Height = 500
  rect.X = Cux : rect.Y = CuY
  PdfPrinter.Document.Font = FontE
  PdfPrinter.Document.WriteText(b, rect, PDFAlignment.Left)
 End Sub

 Public Sub PrintRectangleTextWM(ByVal t As String)
  If b = "" Then Exit Sub
  If t = "a" Then rect.Width = 300 : rect.Height = 500
  If t = "b" Then rect.Width = 200 : rect.Height = 500
  rect.X = Cux : rect.Y = CuY
  PdfPrinter.Document.Font = FontE
  PdfPrinter.Document.WriteText(b, rect, PDFAlignment.Left)
  lLine = FontE.GetLinesCount(b, rect, 0, PDFMeasurementUnit.Points)
  Cy1 = lLine * FontE.sizeInPoints
  i4 = CuY + Cy1
 End Sub

 Public Sub PrintRectangleTextWMGN(ByVal t As String) 'TO get next Rect lines for form feed
  If b = "" Then Exit Sub
  If t = "a" Then rect.Width = 300 : rect.Height = 500
  If t = "b" Then rect.Width = 200 : rect.Height = 500
  rect.X = Cux : rect.Y = CuY
  PdfPrinter.Document.Font = FontE
  PdfPrinter.Document.WriteText(b, rect, PDFAlignment.Left)
  i5 = FontE.GetLinesCount(b, rect, 0, PDFMeasurementUnit.Points)
 End Sub

 Public Sub PrintCircle()
  If ovL = 0 Then Exit Sub
  With PdfPrinter
   .Document.Font = FontE
   .Document.Brush = System.Drawing.Brushes.Black
   .Document.DrawEllipse(ovL, ovT, 7, 7, True, False)
  End With
 End Sub

 Public Sub PrintNow()
  With PdfPrinter
   .AutoCenter = True : .AutoRotate = True
   'in case system should print
   Try
    .Document.Save(AppDir & "AimPr\AimTmp.pdf")
   Catch
   End Try

   Try
    .LoadDocument(AppDir & "AimPr\AimTmp.pdf")
   Catch
    GoTo 10
   End Try
   .Document.PrintAfterCreate = True
   .PrintOptions.PrinterName = cbPrinter.SelectedItem
   .PrintOptions.Copies = cbCopies.Text
   If rbReader.Checked = True Then PrintToReader() Else .Print()

10:  'finishing
   PdfPrinter.Dispose()
   PdfPrinter.CloseDocument()
   Dim sFile = AppDir & "AimPr\AimTmp.pdf"
   If rbReader.Checked = True Then Exit Sub
   Try
    If System.IO.File.Exists(sFile) Then System.IO.File.Delete(sFile)
   Catch
   End Try
  End With
 End Sub

 Private Sub PrintToReader()
  PdfPrinter.CloseDocument()
  If UVP = 1 Then
   Try
    System.Diagnostics.Process.Start(AppDir & "AimPr\AimTmp.pdf")
    Me.Dispose()
   Catch
   End Try
  End If
  If UVP = 2 Then
   Try
    Viewer.ShowDialog()
   Catch ex As Exception
   End Try
  End If
 End Sub

 Private Sub PrinterChoose()
  If Trim(prt) = "" Then
   Dim prtr As New PrintDocument
   Dim strDefaultPrinter As String = prtr.PrinterSettings.PrinterName
   Dim ExistingsPtrs As String
   For Each ExistingsPtrs In PrinterSettings.InstalledPrinters
    If ExistingsPtrs = strDefaultPrinter Then prt = ExistingsPtrs : SavePrinter() : Exit For
   Next
  End If
 End Sub

 Private Sub SavePrinter()
  Compdata.CompPrinter = prt : CompdataXmlSave()
 End Sub

 Public Sub PrintBoxes()
  If Trim(b) = "" Then Exit Sub
  Dim z As Integer, yy As Int16
  'Answer = 5  Bold y aumentar / Answer = 6  Bold sin aumentar  / else No Aum no Bold

  If b = "0" Then b = ".00"
  'sacar los decimales
  z = Len(b) : i2 = 1 : yy = Cux    'aqui usamos YY para guardar el cux y devolver
  Revar = b.Substring(0, z - 3) : z = Len(Revar)  'la cantidad
  b1 = b.Substring(z + 1, 2)  'los ceros
  If Cub = 0 Then Cub = 15.2 'cub si viene en cero se usa el establecido aqui
  If Cuc = 0 Then Cuc = 12 'cuc si viene en cero se usa el establecido aqui

  CuY = CuY + MargTopC : Cux = Cux + MargIzqC
  'print
  If z = 12 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 11 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 10 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 9 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 8 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 7 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 6 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 5 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 4 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 3 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 2 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 1 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  'los decimales ej .00
  Cux = Cux + Cub + Cuc : b = b1.Substring(0, 1) : PrintText2()
  Cux = Cux + Cub : b = b1.Substring(1, 1) : PrintText2()
  Cux = yy
 End Sub

 Public Sub PrintBoxesNoCents()
  If Trim(b) = "" Then Exit Sub
  Dim z As Integer, yy As Int16
  'Answer = 5  Bold y aumentar / Answer = 6  Bold sin aumentar  / else No Aum no Bold

  'sacar los decimales
  z = Len(b) : i2 = 1 : yy = Cux    'aqui usamos YY para guardar el cux y devolver
  If Cub = 0 Then Cub = 15.2 'cub si viene en cero se usa el establecido aqui
  If Cuc = 0 Then Cuc = 12 'cuc si viene en cero se usa el establecido aqui
  CuY = CuY + MargTopC : Cux = Cux + MargIzqC
  'print
  Revar = b
  If z = 12 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 11 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 10 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 9 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 8 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 7 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 6 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 5 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 4 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 3 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 2 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = Cux + Cub : If z >= 1 Then b = Mid(Revar, i2, 1) : PrintText2() : i2 = i2 + 1
  Cux = yy
 End Sub

 Private Sub cbPrinter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPrinter.SelectedIndexChanged
  If Flagstart = True Then Exit Sub
  prt = cbPrinter.Text
  SavePrinter()
 End Sub

 Private Sub buttonSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonSalir.Click
  Me.Dispose()
 End Sub

 Private Sub ResetControls()
  'checkmark
  ck1.Visible = False : ck2.Visible = False : ck3.Visible = False : ck4.Visible = False
  ck5.Visible = False : ck6.Visible = False : ck7.Visible = False : ck8.Visible = False
  ck9.Visible = False : ck10.Visible = False : ck11.Visible = False : ck12.Visible = False
  ck13.Visible = False : ck14.Visible = False : ck15.Visible = False : ck16.Visible = False
  ck17.Visible = False : ck18.Visible = False : ck19.Visible = False : ck20.Visible = False
  ck21.Visible = False : ck22.Visible = False : ck23.Visible = False : ck24.Visible = False
  ck25.Visible = False : ck26.Visible = False : ck27.Visible = False : ck28.Visible = False
  'buttons
  bt1.Visible = False : bt2.Visible = False : bt3.Visible = False : bt4.Visible = False
  bt5.Visible = False : bt6.Visible = False : bt7.Visible = False : bt8.Visible = False
  bt9.Visible = False : bt10.Visible = False : bt11.Visible = False : bt12.Visible = False
  bt13.Visible = False : bt14.Visible = False : bt15.Visible = False : bt16.Visible = False
  bt17.Visible = False : bt18.Visible = False : bt19.Visible = False : bt20.Visible = False
  bt21.Visible = False : bt22.Visible = False : bt23.Visible = False : bt24.Visible = False
  bt25.Visible = False : bt26.Visible = False : bt27.Visible = False : bt28.Visible = False
 End Sub

 Private Sub rbImp_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbImp.MouseClick
  x = 0 : SaveToCompdata() : btRep.Focus()
 End Sub

 Private Sub rbReader_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbReader.MouseClick
  x = 2 : SaveToCompdata() : btRep.Focus()
 End Sub

 Private Sub SaveToCompdata()
  Compdata.ImpImpPDFoReader = x : CompdataXmlSave()
 End Sub

 'BOTONES ============================================================================================================================================

 Private Sub bt1_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt1.MouseClick
  FPrt = True
  If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd01()
123:
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt2_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt2.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd02()
123:
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt3_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt3.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd03()
123:
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt4_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt4.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd04()
123:
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt5_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt5.MouseClick
  FPrt = True
  '  If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd05()
123:
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt6_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt6.MouseClick
  FPrt = True
  ' If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd06()
123:
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt7_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt7.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd07()
120:
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt8_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt8.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd08()
123:
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt9_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt9.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd09()
120:
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt10_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt10.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd10()
100:
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt11_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt11.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd11()
100:
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt12_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt12.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd12()
100:
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt13_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt13.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd13()
100:
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt14_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt14.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd14()
100:
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt15_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt15.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd15()
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt16_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt16.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd16()
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt17_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt17.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd17()
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt18_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt18.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd18()
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt19_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt19.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd19()
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt20_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt20.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd20()
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt21_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt21.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd21()
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt22_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt22.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd22()
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt23_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt23.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd23()
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt24_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt24.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd24()
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt25_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt25.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd25()
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub bt26_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bt26.MouseClick
  FPrt = True
  'If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintIncentivosCmd26()
  FPrt = False
  btRep.Focus()
 End Sub

 Private Sub btCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRep.Click
  Me.Close()
 End Sub

 Private Sub Deseleccionar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDes.Click
  ck6.Checked = False : ck11.Checked = False : ck16.Checked = False : ck21.Checked = False
  ck2.Checked = False : ck7.Checked = False : ck12.Checked = False : ck17.Checked = False : ck22.Checked = False
  ck3.Checked = False : ck8.Checked = False : ck13.Checked = False : ck18.Checked = False : ck23.Checked = False
  ck4.Checked = False : ck9.Checked = False : ck14.Checked = False : ck19.Checked = False : ck24.Checked = False
  ck5.Checked = False : ck10.Checked = False : ck15.Checked = False : ck20.Checked = False : ck25.Checked = False
  ck26.Checked = False : ck27.Checked = False : ck28.Checked = False
 End Sub

 Public Sub PrintToPrinter()
  Refresh()
  If rbImp.Checked = True Then Me.PrintNow()
 End Sub

 Private Sub ckIng_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ckIng.MouseClick
  'save compdata variables mas recientes
  If ckIng.Checked = True Then Compdata.IIn = True Else Compdata.IIn = False
  CompdataXmlSave()
 End Sub

 Private Sub btImp_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
  btImp.Image = AIMContribucionesIncentivos.My.Resources.Resources.ImprimirH
  btImp.Font = New Font("Sans Serif", 8.25, FontStyle.Regular)
 End Sub

 Private Sub btImp_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
  btImp.Image = AIMContribucionesIncentivos.My.Resources.Resources.Imprimir
  btImp.Font = New Font("Sans Serif", 8.25, FontStyle.Bold)
 End Sub

 'Print Todas
 Private Sub btImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImp.Click
  If Compdata.UltimaFormaUsada = "IncentivosInd" Then PrintTodasIncentivos()
10:
  FPrt = False
 End Sub

 Private Sub PrintTodasIncentivos()
  FPrt = False
  If AnoInUse >= 2013 Then
   If IiP1(110) = "1" Then
    ProgressBar1.Value = 15 : If ck1.Checked = True Then PrintIncentivosCmd01() : PrintToPrinter()
    'ProgressBar1.Value = 20 : If ck2.Checked = True Then PrintIncentivosCmd02() : PrintToPrinter()
    'ProgressBar1.Value = 25 : If ck3.Checked = True Then PrintIncentivosCmd03() : PrintToPrinter()
    'ProgressBar1.Value = 30 : If ck4.Checked = True Then PrintIncentivosCmd04() : PrintToPrinter()
    'ProgressBar1.Value = 35 : If ck5.Checked = True Then PrintIncentivosCmd05() : PrintToPrinter()
    'ProgressBar1.Value = 40 : If ck6.Checked = True Then PrintIncentivosCmd06() : PrintToPrinter()
    'ProgressBar1.Value = 45 : If ck7.Checked = True Then PrintIncentivosCmd07() : PrintToPrinter()
    'ProgressBar1.Value = 50 : If ck8.Checked = True Then PrintIncentivosCmd08() : PrintToPrinter()
    'ProgressBar1.Value = 55 : If ck9.Checked = True Then PrintIncentivosCmd09() : PrintToPrinter()
    'ProgressBar1.Value = 60 : If ck10.Checked = True Then PrintIncentivosCmd10() : PrintToPrinter()
    'ProgressBar1.Value = 65 : If ck11.Checked = True Then PrintIncentivosCmd11() : PrintToPrinter()
    'ProgressBar1.Value = 70 : If ck12.Checked = True Then PrintIncentivosCmd12() : PrintToPrinter()
    'ProgressBar1.Value = 75 : If ck13.Checked = True Then PrintIncentivosCmd13() : PrintToPrinter()
    'ProgressBar1.Value = 80 : If ck14.Checked = True Then PrintIncentivosCmd14() : PrintToPrinter()
    'ProgressBar1.Value = 85 : If ck15.Checked = True Then PrintIncentivosCmd15() : PrintToPrinter()
    'ProgressBar1.Value = 90 : If ck16.Checked = True Then PrintIncentivosCmd16() : PrintToPrinter()
    'ProgressBar1.Value = 95 : If ck17.Checked = True Then PrintIncentivosCmd17() : PrintToPrinter()
    'ProgressBar1.Value = 98 : If ck18.Checked = True Then PrintIncentivosCmd18() : PrintToPrinter()
   End If
   GoTo 100
  End If

100:
  If rbImp.Checked = False Then Me.PrintNow()
  ProgressBar1.Value = 0
 End Sub

 Private Sub MsgNoImpBB()
  MsgId = "MsgNoImpBB" : ErrMsgDialog.ShowDialog()
 End Sub

 Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
  MsgId = "ShowImpMasFacil" : ErrMsgDialog.ShowDialog()
 End Sub
End Class
