<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class guest_view
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
        Dim Label1 As System.Windows.Forms.Label
        Dim PICTURELabel As System.Windows.Forms.Label
        Dim QRCODELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(guest_view))
        Me.Clinic_databaseDataSet = New PATIENT_INFORMATION.clinic_databaseDataSet()
        Me.DATABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DATATableAdapter = New PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.DATATableAdapter()
        Me.TableAdapterManager = New PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.TableAdapterManager()
        Me.DATADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iduser = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PATIENTIDTextBox = New System.Windows.Forms.TextBox()
        Me.combosearch = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.search = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PICTUREPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.QRCODEPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Viewg = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        PICTURELabel = New System.Windows.Forms.Label()
        QRCODELabel = New System.Windows.Forms.Label()
        CType(Me.Clinic_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PICTUREPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRCODEPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(198, 53)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(615, 39)
        Label1.TabIndex = 297
        Label1.Text = "Clinic of Mamatid Patient Information System"
        Label1.UseCompatibleTextRendering = True
        '
        'PICTURELabel
        '
        PICTURELabel.AutoSize = True
        PICTURELabel.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PICTURELabel.Location = New System.Drawing.Point(1072, 65)
        PICTURELabel.Name = "PICTURELabel"
        PICTURELabel.Size = New System.Drawing.Size(69, 15)
        PICTURELabel.TabIndex = 300
        PICTURELabel.Text = "PICTURE:"
        '
        'QRCODELabel
        '
        QRCODELabel.AutoSize = True
        QRCODELabel.Location = New System.Drawing.Point(229, 138)
        QRCODELabel.Name = "QRCODELabel"
        QRCODELabel.Size = New System.Drawing.Size(87, 13)
        QRCODELabel.TabIndex = 305
        QRCODELabel.Text = "Verification Code"
        '
        'Clinic_databaseDataSet
        '
        Me.Clinic_databaseDataSet.DataSetName = "clinic_databaseDataSet"
        Me.Clinic_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DATABindingSource
        '
        Me.DATABindingSource.DataMember = "DATA"
        Me.DATABindingSource.DataSource = Me.Clinic_databaseDataSet
        '
        'DATATableAdapter
        '
        Me.DATATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DATATableAdapter = Me.DATATableAdapter
        Me.TableAdapterManager.GUESTTableAdapter = Nothing
        Me.TableAdapterManager.PASSTABLETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DATADataGridView
        '
        Me.DATADataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart
        Me.DATADataGridView.AllowUserToAddRows = False
        Me.DATADataGridView.AllowUserToDeleteRows = False
        Me.DATADataGridView.AutoGenerateColumns = False
        Me.DATADataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DATADataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DATADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.DATADataGridView.DataSource = Me.DATABindingSource
        Me.DATADataGridView.Location = New System.Drawing.Point(26, 260)
        Me.DATADataGridView.Name = "DATADataGridView"
        Me.DATADataGridView.Size = New System.Drawing.Size(1219, 414)
        Me.DATADataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PATIENTID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PATIENTID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PATIENTNAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PATIENTNAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MIDDLENAME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MIDDLENAME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SURNAME"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SURNAME"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "AGE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "AGE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "BIRTHDAY"
        Me.DataGridViewTextBoxColumn6.HeaderText = "BIRTHDAY"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DATE REGISTERED"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DATE REGISTERED"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "GENDER"
        Me.DataGridViewTextBoxColumn8.HeaderText = "GENDER"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ADDRESS"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ADDRESS"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PHONE#"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PHONE#"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "INSURANCE"
        Me.DataGridViewTextBoxColumn11.HeaderText = "INSURANCE"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "OCCUPATION"
        Me.DataGridViewTextBoxColumn12.HeaderText = "OCCUPATION"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "STATUS"
        Me.DataGridViewTextBoxColumn13.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "DIAGNOSIS"
        Me.DataGridViewTextBoxColumn14.HeaderText = "DIAGNOSIS"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "TREATMENTS"
        Me.DataGridViewTextBoxColumn15.HeaderText = "TREATMENTS"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ABOUT HEALTH PATIENT"
        Me.DataGridViewTextBoxColumn16.HeaderText = "ABOUT HEALTH PATIENT"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 20
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'iduser
        '
        Me.iduser.AutoSize = True
        Me.iduser.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iduser.ForeColor = System.Drawing.Color.DarkGreen
        Me.iduser.Location = New System.Drawing.Point(278, 104)
        Me.iduser.Name = "iduser"
        Me.iduser.Size = New System.Drawing.Size(15, 16)
        Me.iduser.TabIndex = 300
        Me.iduser.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(206, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 299
        Me.Label2.Text = "Guest/user:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(203, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 20)
        Me.Label3.TabIndex = 298
        Me.Label3.Text = "Mamatid Health Care Center "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PATIENTIDTextBox)
        Me.Panel1.Controls.Add(Me.combosearch)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.search)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1287, 45)
        Me.Panel1.TabIndex = 302
        '
        'PATIENTIDTextBox
        '
        Me.PATIENTIDTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.PATIENTIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PATIENTIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "PATIENTID", True))
        Me.PATIENTIDTextBox.Enabled = False
        Me.PATIENTIDTextBox.Location = New System.Drawing.Point(749, 15)
        Me.PATIENTIDTextBox.Name = "PATIENTIDTextBox"
        Me.PATIENTIDTextBox.Size = New System.Drawing.Size(10, 13)
        Me.PATIENTIDTextBox.TabIndex = 307
        '
        'combosearch
        '
        Me.combosearch.FormattingEnabled = True
        Me.combosearch.Items.AddRange(New Object() {"SURNAME", "NAME", "PHONE#", "DIAGNOSIS", "INSURANCES", "ADDRESS"})
        Me.combosearch.Location = New System.Drawing.Point(947, 12)
        Me.combosearch.Name = "combosearch"
        Me.combosearch.Size = New System.Drawing.Size(83, 21)
        Me.combosearch.TabIndex = 306
        Me.combosearch.Text = "    Search By:"
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1227, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 23)
        Me.btnClose.TabIndex = 12
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(916, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 305
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1196, 10)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(25, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.UseVisualStyleBackColor = False
        '
        'search
        '
        Me.search.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.search.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.search.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.ForeColor = System.Drawing.Color.Black
        Me.search.Location = New System.Drawing.Point(1036, 10)
        Me.search.Multiline = True
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(145, 24)
        Me.search.TabIndex = 304
        Me.search.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "search"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(12, 9)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 24)
        Me.Button4.TabIndex = 7
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PICTUREPictureBox
        '
        Me.PICTUREPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.DATABindingSource, "PICTURE", True))
        Me.PICTUREPictureBox.Image = Global.PATIENT_INFORMATION.My.Resources.Resources.photo_camera
        Me.PICTUREPictureBox.Location = New System.Drawing.Point(996, 82)
        Me.PICTUREPictureBox.Name = "PICTUREPictureBox"
        Me.PICTUREPictureBox.Size = New System.Drawing.Size(221, 172)
        Me.PICTUREPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PICTUREPictureBox.TabIndex = 301
        Me.PICTUREPictureBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PATIENT_INFORMATION.My.Resources.Resources._26733436_543181366062477_3439808344077873153_n
        Me.PictureBox1.Location = New System.Drawing.Point(37, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 296
        Me.PictureBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Green
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(26, 186)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(179, 35)
        Me.Button6.TabIndex = 303
        Me.Button6.Text = "REFRESH/VIEW"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(26, 223)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 31)
        Me.Button2.TabIndex = 304
        Me.Button2.Text = "PRINT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'QRCODEPictureBox
        '
        Me.QRCODEPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.DATABindingSource, "QRCODE", True))
        Me.QRCODEPictureBox.Location = New System.Drawing.Point(228, 154)
        Me.QRCODEPictureBox.Name = "QRCODEPictureBox"
        Me.QRCODEPictureBox.Size = New System.Drawing.Size(90, 81)
        Me.QRCODEPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QRCODEPictureBox.TabIndex = 306
        Me.QRCODEPictureBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(211, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 307
        Me.Label4.Text = "Total of Patients:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(313, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 16)
        Me.Label5.TabIndex = 308
        Me.Label5.Text = "5456"
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.Green
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.ForeColor = System.Drawing.Color.White
        Me.Button17.Location = New System.Drawing.Point(732, 230)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(258, 28)
        Me.Button17.TabIndex = 309
        Me.Button17.Text = "Private Chat to Staff or Administrator"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Viewg
        '
        Me.Viewg.AutoSize = True
        Me.Viewg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Viewg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Viewg.Location = New System.Drawing.Point(763, 114)
        Me.Viewg.Name = "Viewg"
        Me.Viewg.Size = New System.Drawing.Size(49, 16)
        Me.Viewg.TabIndex = 310
        Me.Viewg.Text = "Label6"
        '
        'guest_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1287, 703)
        Me.Controls.Add(Me.Viewg)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(QRCODELabel)
        Me.Controls.Add(Me.QRCODEPictureBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(PICTURELabel)
        Me.Controls.Add(Me.PICTUREPictureBox)
        Me.Controls.Add(Me.iduser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DATADataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "guest_view"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "guest_view"
        CType(Me.Clinic_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PICTUREPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRCODEPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Clinic_databaseDataSet As PATIENT_INFORMATION.clinic_databaseDataSet
    Friend WithEvents DATABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DATATableAdapter As PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.DATATableAdapter
    Friend WithEvents TableAdapterManager As PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DATADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents iduser As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PICTUREPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents combosearch As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents search As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents QRCODEPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PATIENTIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Viewg As System.Windows.Forms.Label
End Class
