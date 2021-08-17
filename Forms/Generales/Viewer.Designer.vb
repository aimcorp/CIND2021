<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
Me.components = New System.ComponentModel.Container()
Dim PdfRenderOptions1 As Gnostice.PDFOne.PDFRenderOptions = New Gnostice.PDFOne.PDFRenderOptions()
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Viewer))
Dim PdfRenderOptions2 As Gnostice.PDFOne.PDFRenderOptions = New Gnostice.PDFOne.PDFRenderOptions()
Me.PdfViewer1 = New Gnostice.PDFOne.Windows.PDFViewer.PDFViewer()
Me.PdfPrinter1 = New Gnostice.PDFOne.PDFPrinter.PDFPrinter()
Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
Me.ToolPrint = New System.Windows.Forms.ToolStripButton()
Me.ToolSalvar = New System.Windows.Forms.ToolStripButton()
Me.ReSize1 = New LarcomAndYoung.Windows.Forms.ReSize(Me.components)
Me.ToolStrip1.SuspendLayout()
Me.SuspendLayout()
'
'PdfViewer1
'
Me.PdfViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.PdfViewer1.BorderWidth = 2
Me.PdfViewer1.Document = Nothing
Me.PdfViewer1.HScrollBar = Gnostice.PDFOne.Windows.PDFViewer.ScrollBarVisibility.Always
Me.PdfViewer1.HScrollValue = 0
Me.PdfViewer1.KeyNavigationEnabled = True
Me.PdfViewer1.Location = New System.Drawing.Point(2, 24)
Me.PdfViewer1.Margin = New System.Windows.Forms.Padding(18, 39, 18, 39)
Me.PdfViewer1.Name = "PdfViewer1"
Me.PdfViewer1.PageBufferCount = 2
Me.PdfViewer1.PageRotationAngle = Gnostice.PDFOne.Windows.PDFViewer.RotationAngle.Zero
Me.PdfViewer1.Password = ""
PdfRenderOptions1.SmoothImages = True
PdfRenderOptions1.SmoothLineart = True
PdfRenderOptions1.SmoothText = True
Me.PdfViewer1.RenderingOptions = PdfRenderOptions1
Me.PdfViewer1.Size = New System.Drawing.Size(951, 714)
Me.PdfViewer1.StdZoomType = Gnostice.PDFOne.Windows.PDFViewer.StandardZoomType.FitWidth
Me.PdfViewer1.TabIndex = 0
Me.PdfViewer1.VScrollBar = Gnostice.PDFOne.Windows.PDFViewer.ScrollBarVisibility.Always
Me.PdfViewer1.VScrollValue = 0
Me.PdfViewer1.ZoomPercent = 100.0R
'
'PdfPrinter1
'
Me.PdfPrinter1.AutoCenter = True
Me.PdfPrinter1.AutoRotate = True
Me.PdfPrinter1.CurrentPageNumber = 1
Me.PdfPrinter1.Document = Nothing
Me.PdfPrinter1.OffsetHardMargins = False
Me.PdfPrinter1.PageScaleType = Gnostice.PDFOne.PDFPrinter.PrintScaleType.None
Me.PdfPrinter1.PageSubRange = Gnostice.PDFOne.PDFPrinter.PrintSubRange.All
Me.PdfPrinter1.Password = ""
Me.PdfPrinter1.PrintOptions = CType(resources.GetObject("PdfPrinter1.PrintOptions"), System.Drawing.Printing.PrinterSettings)
PdfRenderOptions2.SmoothImages = True
PdfRenderOptions2.SmoothLineart = True
PdfRenderOptions2.SmoothText = True
Me.PdfPrinter1.RenderingOptions = PdfRenderOptions2
Me.PdfPrinter1.ReversePageOrder = False
Me.PdfPrinter1.SelectedPages = ""
Me.PdfPrinter1.ShowPrintStatus = False
'
'ToolStrip1
'
Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolPrint, Me.ToolSalvar})
Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
Me.ToolStrip1.Name = "ToolStrip1"
Me.ToolStrip1.Size = New System.Drawing.Size(957, 25)
Me.ToolStrip1.TabIndex = 2
Me.ToolStrip1.Text = "ToolStrip1"
'
'ToolPrint
'
Me.ToolPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.ToolPrint.Image = CType(resources.GetObject("ToolPrint.Image"), System.Drawing.Image)
Me.ToolPrint.ImageTransparentColor = System.Drawing.Color.Magenta
Me.ToolPrint.Name = "ToolPrint"
Me.ToolPrint.Size = New System.Drawing.Size(23, 22)
Me.ToolPrint.Text = "Imprimir"
'
'ToolSalvar
'
Me.ToolSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.ToolSalvar.Image = CType(resources.GetObject("ToolSalvar.Image"), System.Drawing.Image)
Me.ToolSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
Me.ToolSalvar.Name = "ToolSalvar"
Me.ToolSalvar.Size = New System.Drawing.Size(23, 22)
Me.ToolSalvar.Text = "Salvar a un Archivo PDF"
Me.ToolSalvar.ToolTipText = " Salvar Planilla en uso "
'
'ReSize1
'
Me.ReSize1.About = Nothing
Me.ReSize1.AutoCenterFormOnLoad = False
Me.ReSize1.Enabled = False
Me.ReSize1.HostContainer = Me
Me.ReSize1.InitialHostContainerHeight = 746.0R
Me.ReSize1.InitialHostContainerWidth = 957.0R
Me.ReSize1.Tag = Nothing
'
'Viewer
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(957, 746)
Me.Controls.Add(Me.ToolStrip1)
Me.Controls.Add(Me.PdfViewer1)
Me.MaximizeBox = False
Me.MinimizeBox = False
Me.Name = "Viewer"
Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
Me.Text = "Viewer"
Me.TopMost = True
Me.ToolStrip1.ResumeLayout(False)
Me.ToolStrip1.PerformLayout()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
				Friend WithEvents PdfViewer1 As Gnostice.PDFOne.Windows.PDFViewer.PDFViewer
				Friend WithEvents PdfPrinter1 As Gnostice.PDFOne.PDFPrinter.PDFPrinter
				Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
				Friend WithEvents ToolPrint As System.Windows.Forms.ToolStripButton
				Friend WithEvents ToolSalvar As System.Windows.Forms.ToolStripButton
				Friend WithEvents ReSize1 As LarcomAndYoung.Windows.Forms.ReSize
End Class
