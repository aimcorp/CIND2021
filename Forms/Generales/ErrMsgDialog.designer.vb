<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrMsgDialog
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
Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
Me.bt5 = New System.Windows.Forms.Label()
Me.bt4 = New System.Windows.Forms.Label()
Me.bt3 = New System.Windows.Forms.Label()
Me.bt1 = New System.Windows.Forms.Label()
Me.bt0 = New System.Windows.Forms.Label()
Me.bt2 = New System.Windows.Forms.Label()
Me.Panel1 = New System.Windows.Forms.Panel()
Me.Lb1 = New System.Windows.Forms.Label()
Me.Label1 = New System.Windows.Forms.Label()
Me.ReSize1 = New LarcomAndYoung.Windows.Forms.ReSize(Me.components)
Me.TableLayoutPanel1.SuspendLayout()
Me.Panel1.SuspendLayout()
Me.SuspendLayout()
'
'ShapeContainer1
'
Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
Me.ShapeContainer1.Name = "ShapeContainer1"
Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
Me.ShapeContainer1.Size = New System.Drawing.Size(510, 347)
Me.ShapeContainer1.TabIndex = 7
Me.ShapeContainer1.TabStop = False
'
'RectangleShape1
'
Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(138, Byte), Integer))
Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
Me.RectangleShape1.Location = New System.Drawing.Point(5, 13)
Me.RectangleShape1.Name = "RectangleShape1"
Me.RectangleShape1.Size = New System.Drawing.Size(499, 328)
'
'TableLayoutPanel1
'
Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(138, Byte), Integer))
Me.TableLayoutPanel1.ColumnCount = 6
Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
Me.TableLayoutPanel1.Controls.Add(Me.bt5, 0, 0)
Me.TableLayoutPanel1.Controls.Add(Me.bt4, 1, 0)
Me.TableLayoutPanel1.Controls.Add(Me.bt3, 2, 0)
Me.TableLayoutPanel1.Controls.Add(Me.bt1, 4, 0)
Me.TableLayoutPanel1.Controls.Add(Me.bt0, 5, 0)
Me.TableLayoutPanel1.Controls.Add(Me.bt2, 3, 0)
Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
Me.TableLayoutPanel1.Location = New System.Drawing.Point(49, 306)
Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
Me.TableLayoutPanel1.RowCount = 1
Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel1.Size = New System.Drawing.Size(447, 29)
Me.TableLayoutPanel1.TabIndex = 8
'
'bt5
'
Me.bt5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
  Me.bt5.Image = Global.AIMContribucionesIncentivos.My.Resources.Resources.Msg1
  Me.bt5.Location = New System.Drawing.Point(3, 0)
  Me.bt5.Name = "bt5"
  Me.bt5.Size = New System.Drawing.Size(66, 25)
  Me.bt5.TabIndex = 1178
  Me.bt5.Text = "Continuar"
  Me.bt5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
  '
  'bt4
  '
  Me.bt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
  Me.bt4.Image = Global.AIMContribucionesIncentivos.My.Resources.Resources.Msg1
  Me.bt4.Location = New System.Drawing.Point(77, 0)
  Me.bt4.Name = "bt4"
  Me.bt4.Size = New System.Drawing.Size(66, 25)
  Me.bt4.TabIndex = 1177
  Me.bt4.Text = "Continuar"
  Me.bt4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
  '
  'bt3
  '
  Me.bt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
  Me.bt3.Image = Global.AIMContribucionesIncentivos.My.Resources.Resources.Msg1
  Me.bt3.Location = New System.Drawing.Point(151, 0)
  Me.bt3.Name = "bt3"
  Me.bt3.Size = New System.Drawing.Size(66, 25)
  Me.bt3.TabIndex = 1175
  Me.bt3.Text = "Continuar"
  Me.bt3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
  '
  'bt1
  '
  Me.bt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
  Me.bt1.Image = Global.AIMContribucionesIncentivos.My.Resources.Resources.Msg1
  Me.bt1.Location = New System.Drawing.Point(299, 0)
  Me.bt1.Name = "bt1"
  Me.bt1.Size = New System.Drawing.Size(66, 25)
  Me.bt1.TabIndex = 1171
  Me.bt1.Text = "Continuar"
  Me.bt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
  '
  'bt0
  '
  Me.bt0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
  Me.bt0.Image = Global.AIMContribucionesIncentivos.My.Resources.Resources.Msg1
  Me.bt0.Location = New System.Drawing.Point(373, 0)
  Me.bt0.Name = "bt0"
  Me.bt0.Size = New System.Drawing.Size(66, 25)
  Me.bt0.TabIndex = 1170
  Me.bt0.Text = "OK"
  Me.bt0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
  '
  'bt2
  '
  Me.bt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
  Me.bt2.Image = Global.AIMContribucionesIncentivos.My.Resources.Resources.Msg1
  Me.bt2.Location = New System.Drawing.Point(225, 0)
  Me.bt2.Name = "bt2"
  Me.bt2.Size = New System.Drawing.Size(66, 25)
  Me.bt2.TabIndex = 1173
  Me.bt2.Text = "Continuar"
  Me.bt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
  '
  'Panel1
  '
  Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
  Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
  Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
  Me.Panel1.Controls.Add(Me.Lb1)
  Me.Panel1.Location = New System.Drawing.Point(9, 58)
  Me.Panel1.Name = "Panel1"
  Me.Panel1.Size = New System.Drawing.Size(487, 242)
  Me.Panel1.TabIndex = 10
  '
  'Lb1
  '
  Me.Lb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
  Me.Lb1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
  Me.Lb1.Location = New System.Drawing.Point(2, 3)
  Me.Lb1.Name = "Lb1"
  Me.Lb1.Size = New System.Drawing.Size(480, 231)
  Me.Lb1.TabIndex = 2
  Me.Lb1.Text = "Label1"
  Me.Lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
  '
  'Label1
  '
  Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
  Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
  Me.Label1.Image = Global.AIMContribucionesIncentivos.My.Resources.Resources.MsgHeader
  Me.Label1.Location = New System.Drawing.Point(8, 19)
Me.Label1.Name = "Label1"
Me.Label1.Size = New System.Drawing.Size(488, 36)
Me.Label1.TabIndex = 1171
Me.Label1.Text = "M E N S A J E"
Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
'
'ReSize1
'
Me.ReSize1.About = Nothing
Me.ReSize1.AutoCenterFormOnLoad = False
Me.ReSize1.Enabled = False
Me.ReSize1.HostContainer = Me
Me.ReSize1.InitialHostContainerHeight = 347.0R
Me.ReSize1.InitialHostContainerWidth = 510.0R
Me.ReSize1.Tag = Nothing
'
'ErrMsgDialog
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.BackColor = System.Drawing.Color.BurlyWood
Me.CausesValidation = False
Me.ClientSize = New System.Drawing.Size(510, 347)
Me.ControlBox = False
Me.Controls.Add(Me.Label1)
Me.Controls.Add(Me.Panel1)
Me.Controls.Add(Me.TableLayoutPanel1)
Me.Controls.Add(Me.ShapeContainer1)
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
Me.MaximizeBox = False
Me.MinimizeBox = False
Me.Name = "ErrMsgDialog"
Me.ShowInTaskbar = False
Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
Me.Text = "Atención"
Me.TableLayoutPanel1.ResumeLayout(False)
Me.Panel1.ResumeLayout(False)
Me.ResumeLayout(False)

End Sub
				Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
				Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
				Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
				Friend WithEvents Panel1 As System.Windows.Forms.Panel
				Friend WithEvents Lb1 As System.Windows.Forms.Label
				Friend WithEvents bt0 As System.Windows.Forms.Label
				Friend WithEvents bt1 As System.Windows.Forms.Label
				Friend WithEvents bt2 As System.Windows.Forms.Label
				Friend WithEvents bt3 As System.Windows.Forms.Label
				Friend WithEvents bt4 As System.Windows.Forms.Label
				Friend WithEvents bt5 As System.Windows.Forms.Label
				Friend WithEvents Label1 As System.Windows.Forms.Label
				Friend WithEvents ReSize1 As LarcomAndYoung.Windows.Forms.ReSize

End Class
