<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaPlanillaDlg
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
		Dim lb1 As System.Windows.Forms.Label
		Dim Label1 As System.Windows.Forms.Label
		Dim PictureBox4 As System.Windows.Forms.PictureBox
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevaPlanillaDlg))
		Dim Label6 As System.Windows.Forms.Label
		Dim Label2 As System.Windows.Forms.Label
		Dim Label4 As System.Windows.Forms.Label
		Dim Label5 As System.Windows.Forms.Label
		Dim Label8 As System.Windows.Forms.Label
		Dim Label7 As System.Windows.Forms.Label
		Dim Label9 As System.Windows.Forms.Label
		Dim Label10 As System.Windows.Forms.Label
		Dim Label12 As System.Windows.Forms.Label
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btBack = New System.Windows.Forms.Button()
		Me.btAbrir = New System.Windows.Forms.Button()
		Me.btCrear = New System.Windows.Forms.Button()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btExit = New System.Windows.Forms.Button()
		Me.btBrowse = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label105 = New System.Windows.Forms.Label()
		Me.PictureBox5 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.ReSize1 = New LarcomAndYoung.Windows.Forms.ReSize(Me.components)
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.tbNombCont = New System.Windows.Forms.TextBox()
		Me.btCancCopia = New System.Windows.Forms.Button()
		Me.btCCopia = New System.Windows.Forms.Button()
		Me.PictureBox6 = New System.Windows.Forms.PictureBox()
		lb1 = New System.Windows.Forms.Label()
		Label1 = New System.Windows.Forms.Label()
		PictureBox4 = New System.Windows.Forms.PictureBox()
		Label6 = New System.Windows.Forms.Label()
		Label2 = New System.Windows.Forms.Label()
		Label4 = New System.Windows.Forms.Label()
		Label5 = New System.Windows.Forms.Label()
		Label8 = New System.Windows.Forms.Label()
		Label7 = New System.Windows.Forms.Label()
		Label9 = New System.Windows.Forms.Label()
		Label10 = New System.Windows.Forms.Label()
		Label12 = New System.Windows.Forms.Label()
		CType(PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel2.SuspendLayout()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lb1
		'
		lb1.AutoSize = True
		lb1.FlatStyle = System.Windows.Forms.FlatStyle.System
		lb1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		lb1.ForeColor = System.Drawing.Color.Green
		lb1.Location = New System.Drawing.Point(53, 23)
		lb1.Name = "lb1"
		lb1.Size = New System.Drawing.Size(328, 18)
		lb1.TabIndex = 1
		lb1.Text = "¿Desea crear una nueva planilla?"
		'
		'Label1
		'
		Label1.AutoSize = True
		Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
		Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Label1.ForeColor = System.Drawing.Color.Green
		Label1.Location = New System.Drawing.Point(53, 142)
		Label1.Name = "Label1"
		Label1.Size = New System.Drawing.Size(308, 18)
		Label1.TabIndex = 1
		Label1.Text = "¿Abrir una planilla existente?"
		'
		'PictureBox4
		'
		PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
		PictureBox4.Location = New System.Drawing.Point(25, 134)
		PictureBox4.Name = "PictureBox4"
		PictureBox4.Size = New System.Drawing.Size(27, 29)
		PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		PictureBox4.TabIndex = 16
		PictureBox4.TabStop = False
		'
		'Label6
		'
		Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Label6.ForeColor = System.Drawing.Color.Brown
		Label6.Location = New System.Drawing.Point(26, 53)
		Label6.Name = "Label6"
		Label6.Size = New System.Drawing.Size(545, 74)
		Label6.TabIndex = 15
		Label6.Text = resources.GetString("Label6.Text")
		Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Label2.Location = New System.Drawing.Point(26, 172)
		Label2.Name = "Label2"
		Label2.Size = New System.Drawing.Size(478, 69)
		Label2.TabIndex = 15
		Label2.Text = resources.GetString("Label2.Text")
		Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		'
		'Label4
		'
		Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Label4.ForeColor = System.Drawing.Color.Brown
		Label4.Location = New System.Drawing.Point(20, 149)
		Label4.Name = "Label4"
		Label4.Size = New System.Drawing.Size(529, 63)
		Label4.TabIndex = 15
		Label4.Text = "Nota: El fólder puede ser movido luego a su discreción con cualquier otro program" & _
				"a de manejo de archivos y fólders como por ejemplo el Windows Explorer u Opus"
		Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label5
		'
		Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Label5.ForeColor = System.Drawing.Color.MediumBlue
		Label5.Location = New System.Drawing.Point(346, 235)
		Label5.Name = "Label5"
		Label5.Size = New System.Drawing.Size(132, 17)
		Label5.TabIndex = 15
		Label5.Text = "Crear o Buscar folder"
		Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label8
		'
		Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
		Label8.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Label8.ForeColor = System.Drawing.Color.Green
		Label8.Location = New System.Drawing.Point(44, 99)
		Label8.Name = "Label8"
		Label8.Size = New System.Drawing.Size(521, 33)
		Label8.TabIndex = 1
		Label8.Text = "Si usted ha creado el fólder de planillas previamente simplemente escójalo nuevam" & _
				"ente en el botón OK para Crear o Buscar Fólder"
		Label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		'
		'Label7
		'
		Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
		Label7.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Label7.ForeColor = System.Drawing.Color.Green
		Label7.Location = New System.Drawing.Point(58, 16)
		Label7.Name = "Label7"
		Label7.Size = New System.Drawing.Size(492, 68)
		Label7.TabIndex = 1
		Label7.Text = resources.GetString("Label7.Text")
		Label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		'
		'Label9
		'
		Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Label9.ForeColor = System.Drawing.Color.Brown
		Label9.Location = New System.Drawing.Point(60, 8)
		Label9.Name = "Label9"
		Label9.Size = New System.Drawing.Size(509, 92)
		Label9.TabIndex = 15
		Label9.Text = "Esta rutina crea una copia de la planilla para el mismo año de este cliente, uste" & _
				"d luego puede escoger cambiar a esa planilla en el botón de la derecha 'Abrir ot" & _
				"ra planilla del mismo año'"
		Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label10
		'
		Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Label10.Location = New System.Drawing.Point(73, 98)
		Label10.Name = "Label10"
		Label10.Size = New System.Drawing.Size(478, 69)
		Label10.TabIndex = 15
		Label10.Text = resources.GetString("Label10.Text")
		Label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		'
		'Label12
		'
		Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
		Label12.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Label12.ForeColor = System.Drawing.Color.Green
		Label12.Location = New System.Drawing.Point(50, 178)
		Label12.Name = "Label12"
		Label12.Size = New System.Drawing.Size(215, 36)
		Label12.TabIndex = 1
		Label12.Text = "Si desea crear la copia, entre el nombre y presione ‘Ok’"
		Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel2.Controls.Add(Me.btBack)
		Me.Panel2.Controls.Add(Me.btAbrir)
		Me.Panel2.Controls.Add(Me.btCrear)
		Me.Panel2.Controls.Add(PictureBox4)
		Me.Panel2.Controls.Add(Me.PictureBox3)
		Me.Panel2.Controls.Add(Label6)
		Me.Panel2.Controls.Add(Label2)
		Me.Panel2.Controls.Add(lb1)
		Me.Panel2.Controls.Add(Label1)
		Me.Panel2.Location = New System.Drawing.Point(547, 237)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(581, 265)
		Me.Panel2.TabIndex = 14
		Me.Panel2.Visible = False
		'
		'btBack
		'
		Me.btBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(124, Byte), Integer))
		Me.btBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.btBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
		Me.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btBack.Location = New System.Drawing.Point(525, 233)
		Me.btBack.Name = "btBack"
		Me.btBack.Size = New System.Drawing.Size(50, 23)
		Me.btBack.TabIndex = 1816
		Me.btBack.TabStop = False
		Me.btBack.Text = "Salir"
		Me.btBack.UseVisualStyleBackColor = True
		'
		'btAbrir
		'
		Me.btAbrir.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(124, Byte), Integer))
		Me.btAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btAbrir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btAbrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.btAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
		Me.btAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btAbrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btAbrir.Location = New System.Drawing.Point(358, 139)
		Me.btAbrir.Name = "btAbrir"
		Me.btAbrir.Size = New System.Drawing.Size(33, 23)
		Me.btAbrir.TabIndex = 1815
		Me.btAbrir.TabStop = False
		Me.btAbrir.Text = "Ok"
		Me.btAbrir.UseVisualStyleBackColor = True
		'
		'btCrear
		'
		Me.btCrear.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(124, Byte), Integer))
		Me.btCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btCrear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.btCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
		Me.btCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btCrear.Location = New System.Drawing.Point(377, 21)
		Me.btCrear.Name = "btCrear"
		Me.btCrear.Size = New System.Drawing.Size(33, 23)
		Me.btCrear.TabIndex = 1815
		Me.btCrear.TabStop = False
		Me.btCrear.Text = "Ok"
		Me.btCrear.UseVisualStyleBackColor = True
		'
		'PictureBox3
		'
		Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
		Me.PictureBox3.Location = New System.Drawing.Point(25, 16)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(27, 29)
		Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox3.TabIndex = 16
		Me.PictureBox3.TabStop = False
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.btExit)
		Me.Panel1.Controls.Add(Me.btBrowse)
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.Label105)
		Me.Panel1.Controls.Add(Me.PictureBox5)
		Me.Panel1.Controls.Add(Me.PictureBox1)
		Me.Panel1.Controls.Add(Label4)
		Me.Panel1.Controls.Add(Label5)
		Me.Panel1.Controls.Add(Label8)
		Me.Panel1.Controls.Add(Label7)
		Me.Panel1.Location = New System.Drawing.Point(3, 2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(581, 265)
		Me.Panel1.TabIndex = 15
		'
		'btExit
		'
		Me.btExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(124, Byte), Integer))
		Me.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
		Me.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btExit.Location = New System.Drawing.Point(520, 232)
		Me.btExit.Name = "btExit"
		Me.btExit.Size = New System.Drawing.Size(50, 23)
		Me.btExit.TabIndex = 1814
		Me.btExit.TabStop = False
		Me.btExit.Text = "Salir"
		Me.btExit.UseVisualStyleBackColor = True
		'
		'btBrowse
		'
		Me.btBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(124, Byte), Integer))
		Me.btBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.btBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
		Me.btBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btBrowse.Location = New System.Drawing.Point(478, 232)
		Me.btBrowse.Name = "btBrowse"
		Me.btBrowse.Size = New System.Drawing.Size(33, 23)
		Me.btBrowse.TabIndex = 1814
		Me.btBrowse.TabStop = False
		Me.btBrowse.Text = "Ok"
		Me.btBrowse.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.IndianRed
		Me.Label3.Location = New System.Drawing.Point(2, 214)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(573, 7)
		Me.Label3.TabIndex = 571
		'
		'Label105
		'
		Me.Label105.BackColor = System.Drawing.Color.IndianRed
		Me.Label105.Location = New System.Drawing.Point(2, 138)
		Me.Label105.Name = "Label105"
		Me.Label105.Size = New System.Drawing.Size(573, 7)
		Me.Label105.TabIndex = 571
		'
		'PictureBox5
		'
		Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
		Me.PictureBox5.Location = New System.Drawing.Point(12, 94)
		Me.PictureBox5.Name = "PictureBox5"
		Me.PictureBox5.Size = New System.Drawing.Size(27, 29)
		Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox5.TabIndex = 16
		Me.PictureBox5.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(13, 16)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(27, 29)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 16
		Me.PictureBox1.TabStop = False
		'
		'ReSize1
		'
		Me.ReSize1.About = Nothing
		Me.ReSize1.AutoCenterFormOnLoad = False
		Me.ReSize1.Enabled = False
		Me.ReSize1.HostContainer = Me
		Me.ReSize1.InitialHostContainerHeight = 271.0R
		Me.ReSize1.InitialHostContainerWidth = 589.0R
		Me.ReSize1.Tag = Nothing
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel3.Controls.Add(Me.tbNombCont)
		Me.Panel3.Controls.Add(Me.btCancCopia)
		Me.Panel3.Controls.Add(Me.btCCopia)
		Me.Panel3.Controls.Add(Me.PictureBox6)
		Me.Panel3.Controls.Add(Label9)
		Me.Panel3.Controls.Add(Label10)
		Me.Panel3.Controls.Add(Label12)
		Me.Panel3.Location = New System.Drawing.Point(568, 213)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(581, 265)
		Me.Panel3.TabIndex = 14
		Me.Panel3.Visible = False
		'
		'tbNombCont
		'
		Me.tbNombCont.BackColor = System.Drawing.Color.AntiqueWhite
		Me.tbNombCont.Location = New System.Drawing.Point(269, 191)
		Me.tbNombCont.Name = "tbNombCont"
		Me.tbNombCont.Size = New System.Drawing.Size(263, 20)
		Me.tbNombCont.TabIndex = 1817
		'
		'btCancCopia
		'
		Me.btCancCopia.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(124, Byte), Integer))
		Me.btCancCopia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btCancCopia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btCancCopia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.btCancCopia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
		Me.btCancCopia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btCancCopia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btCancCopia.Location = New System.Drawing.Point(505, 225)
		Me.btCancCopia.Name = "btCancCopia"
		Me.btCancCopia.Size = New System.Drawing.Size(68, 23)
		Me.btCancCopia.TabIndex = 1816
		Me.btCancCopia.TabStop = False
		Me.btCancCopia.Text = "Cancelar"
		Me.btCancCopia.UseVisualStyleBackColor = True
		'
		'btCCopia
		'
		Me.btCCopia.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(124, Byte), Integer))
		Me.btCCopia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btCCopia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btCCopia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.btCCopia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
		Me.btCCopia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btCCopia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btCCopia.Location = New System.Drawing.Point(467, 225)
		Me.btCCopia.Name = "btCCopia"
		Me.btCCopia.Size = New System.Drawing.Size(33, 23)
		Me.btCCopia.TabIndex = 1815
		Me.btCCopia.TabStop = False
		Me.btCCopia.Text = "Ok"
		Me.btCCopia.UseVisualStyleBackColor = True
		'
		'PictureBox6
		'
		Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
		Me.PictureBox6.Location = New System.Drawing.Point(26, 28)
		Me.PictureBox6.Name = "PictureBox6"
		Me.PictureBox6.Size = New System.Drawing.Size(27, 29)
		Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox6.TabIndex = 16
		Me.PictureBox6.TabStop = False
		'
		'NuevaPlanillaDlg
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(589, 271)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.Panel3)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "NuevaPlanillaDlg"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Crea una Nueva Planilla o Abrir Existente"
		CType(PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

End Sub
				Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
				Friend WithEvents ReSize1 As LarcomAndYoung.Windows.Forms.ReSize
				Friend WithEvents btAbrir As System.Windows.Forms.Button
				Friend WithEvents btCrear As System.Windows.Forms.Button
				Friend WithEvents btBack As System.Windows.Forms.Button
				Friend WithEvents btExit As System.Windows.Forms.Button
				Friend WithEvents btBrowse As System.Windows.Forms.Button
				Friend WithEvents Label3 As System.Windows.Forms.Label
				Friend WithEvents Label105 As System.Windows.Forms.Label
				Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
				Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
				Friend WithEvents Panel2 As System.Windows.Forms.Panel
				Friend WithEvents Panel1 As System.Windows.Forms.Panel
				Friend WithEvents Panel3 As System.Windows.Forms.Panel
				Friend WithEvents btCancCopia As System.Windows.Forms.Button
				Friend WithEvents btCCopia As System.Windows.Forms.Button
				Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
				Friend WithEvents tbNombCont As System.Windows.Forms.TextBox

End Class
