Imports Gnostice.PDFOne
Imports Gnostice.PDFOne.PDFPrinter
Imports Gnostice.PDFOne.PDFProAnnot
Imports System.Drawing.Printing
Imports System.IO

Public Class Viewer

Private Sub Viewer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
PdfPrinter1.Dispose()
PdfViewer1.CloseDocument()
Try
				If System.IO.File.Exists(AppDir & "AimPr\AimTmp.pdf") Then System.IO.Directory.Delete(AppDir & "AimPr")
Catch
End Try
End Sub

Private Sub Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
If Rsolution = True Then ReSize1.Enabled = True
PdfViewer1.LoadDocument(AppDir & "AimPr\AimTmp.pdf")
PdfViewer1.Focus()
End Sub

Private Sub ToolSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSalvar.Click
Dim dlg As SaveFileDialog = New SaveFileDialog()
dlg.DefaultExt = "pdf"
dlg.Filter = "PDF files (*.pdf)|*.pdf"
dlg.OverwritePrompt = True
dlg.Title = "Save File"
f = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\AimCpwData\SavedPDF\"
If Compdata.UltDirPDF <> "" Then f = Compdata.UltDirPDF Else IO.Directory.CreateDirectory(f)
dlg.InitialDirectory = f
If dlg.ShowDialog() = DialogResult.OK Then
				System.IO.File.Copy(AppDir & "AimPr\AimTmp.pdf", dlg.FileName)
				f = Path.GetDirectoryName(dlg.FileName) : Compdata.UltDirPDF = f
				CompdataXmlSave()
End If
End Sub

Private Sub ToolPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolPrint.Click
Dim doc As New PDFDocument
Dim dlg As New PrintDialog
doc.Load(AppDir & "AimPr\AimTmp.pdf")
If dlg.ShowDialog() = DialogResult.OK Then
	PdfPrinter1.PrintOptions = dlg.PrinterSettings
	If PTy = 0 Then PdfPrinter1.PageScaleType = PrintScaleType.None
	If PTy = 1 Then PdfPrinter1.PageScaleType = PrintScaleType.FitToPrintableArea
	If PTy = 2 Then PdfPrinter1.PageScaleType = PrintScaleType.ReduceToPrintableArea
	PdfPrinter1.PrintOptions.DefaultPageSettings.Margins.Left = MargL
	PdfPrinter1.PrintOptions.DefaultPageSettings.Margins.Right = MargR
	PdfPrinter1.PrintOptions.DefaultPageSettings.Margins.Top = MargT
	PdfPrinter1.PrintOptions.DefaultPageSettings.Margins.Bottom = MargB
	PdfPrinter1.LoadDocument(doc)
	PdfPrinter1.Print()
	PdfPrinter1.CloseDocument()
	doc.Dispose()
End If
End Sub
End Class