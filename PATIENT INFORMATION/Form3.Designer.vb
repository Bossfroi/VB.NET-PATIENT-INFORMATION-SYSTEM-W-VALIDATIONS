<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim PICTURELabel1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim ABOUT_HEALTH_PATIENTLabel As System.Windows.Forms.Label
        Dim TREATMENTSLabel As System.Windows.Forms.Label
        Dim STATUSLabel As System.Windows.Forms.Label
        Dim OCCUPATIONLabel As System.Windows.Forms.Label
        Dim INSURANCELabel As System.Windows.Forms.Label
        Dim PHONE_Label As System.Windows.Forms.Label
        Dim ADDRESSLabel As System.Windows.Forms.Label
        Dim GENDERLabel As System.Windows.Forms.Label
        Dim DATE_REGISTEREDLabel As System.Windows.Forms.Label
        Dim BIRTHDAYLabel As System.Windows.Forms.Label
        Dim AGELabel As System.Windows.Forms.Label
        Dim SURNAMELabel As System.Windows.Forms.Label
        Dim MIDDLENAMELabel As System.Windows.Forms.Label
        Dim PATIENTNAMELabel As System.Windows.Forms.Label
        Dim PATIENTIDLabel As System.Windows.Forms.Label
        Dim DIAGNOSISLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DATABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Clinic_databaseDataSet = New PATIENT_INFORMATION.clinic_databaseDataSet()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATIENTNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATIENTID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATATableAdapter = New PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.DATATableAdapter()
        Me.TableAdapterManager = New PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.TableAdapterManager()
        Me.DATADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.search = New System.Windows.Forms.TextBox()
        Me.REFRESS = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.combosearch = New System.Windows.Forms.ComboBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.iduser = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ABOUTPA = New System.Windows.Forms.TextBox()
        Me.TREATMENTSTextBox = New System.Windows.Forms.TextBox()
        Me.STATUS = New System.Windows.Forms.ComboBox()
        Me.OCCUPATION = New System.Windows.Forms.TextBox()
        Me.PHONE = New System.Windows.Forms.TextBox()
        Me.ADDRESS = New System.Windows.Forms.TextBox()
        Me.GENDER = New System.Windows.Forms.ComboBox()
        Me.DATEREG = New System.Windows.Forms.DateTimePicker()
        Me.BIRTHDAY = New System.Windows.Forms.DateTimePicker()
        Me.AGE = New System.Windows.Forms.ComboBox()
        Me.SURNAME = New System.Windows.Forms.TextBox()
        Me.MIDDLENAME = New System.Windows.Forms.TextBox()
        Me.PATIENNAME = New System.Windows.Forms.TextBox()
        Me.IDHIDE = New System.Windows.Forms.TextBox()
        Me.INSURANCE = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DIAGNOSISComboBox = New System.Windows.Forms.ComboBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.QRCODEPictureBox = New System.Windows.Forms.PictureBox()
        Me.PICTUREPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.notification3 = New System.Windows.Forms.Label()
        PICTURELabel1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        ABOUT_HEALTH_PATIENTLabel = New System.Windows.Forms.Label()
        TREATMENTSLabel = New System.Windows.Forms.Label()
        STATUSLabel = New System.Windows.Forms.Label()
        OCCUPATIONLabel = New System.Windows.Forms.Label()
        INSURANCELabel = New System.Windows.Forms.Label()
        PHONE_Label = New System.Windows.Forms.Label()
        ADDRESSLabel = New System.Windows.Forms.Label()
        GENDERLabel = New System.Windows.Forms.Label()
        DATE_REGISTEREDLabel = New System.Windows.Forms.Label()
        BIRTHDAYLabel = New System.Windows.Forms.Label()
        AGELabel = New System.Windows.Forms.Label()
        SURNAMELabel = New System.Windows.Forms.Label()
        MIDDLENAMELabel = New System.Windows.Forms.Label()
        PATIENTNAMELabel = New System.Windows.Forms.Label()
        PATIENTIDLabel = New System.Windows.Forms.Label()
        DIAGNOSISLabel = New System.Windows.Forms.Label()
        CType(Me.DATABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clinic_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.QRCODEPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICTUREPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PICTURELabel1
        '
        PICTURELabel1.AutoSize = True
        PICTURELabel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PICTURELabel1.Location = New System.Drawing.Point(89, 179)
        PICTURELabel1.Name = "PICTURELabel1"
        PICTURELabel1.Size = New System.Drawing.Size(56, 16)
        PICTURELabel1.TabIndex = 15
        PICTURELabel1.Text = "PICTURE:"
        AddHandler PICTURELabel1.Click, AddressOf Me.PICTURELabel1_Click
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(223, 41)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(660, 42)
        Label2.TabIndex = 158
        Label2.Text = "Clinic of Mamatid Patient Information System"
        Label2.UseCompatibleTextRendering = True
        '
        'ABOUT_HEALTH_PATIENTLabel
        '
        ABOUT_HEALTH_PATIENTLabel.AutoSize = True
        ABOUT_HEALTH_PATIENTLabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ABOUT_HEALTH_PATIENTLabel.Location = New System.Drawing.Point(379, 232)
        ABOUT_HEALTH_PATIENTLabel.Name = "ABOUT_HEALTH_PATIENTLabel"
        ABOUT_HEALTH_PATIENTLabel.Size = New System.Drawing.Size(126, 15)
        ABOUT_HEALTH_PATIENTLabel.TabIndex = 30
        ABOUT_HEALTH_PATIENTLabel.Text = "ABOUT HEALTH PATIENT:"
        '
        'TREATMENTSLabel
        '
        TREATMENTSLabel.AutoSize = True
        TREATMENTSLabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TREATMENTSLabel.Location = New System.Drawing.Point(430, 150)
        TREATMENTSLabel.Name = "TREATMENTSLabel"
        TREATMENTSLabel.Size = New System.Drawing.Size(75, 15)
        TREATMENTSLabel.TabIndex = 28
        TREATMENTSLabel.Text = "TREATMENTS :"
        '
        'STATUSLabel
        '
        STATUSLabel.AutoSize = True
        STATUSLabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        STATUSLabel.Location = New System.Drawing.Point(434, 16)
        STATUSLabel.Name = "STATUSLabel"
        STATUSLabel.Size = New System.Drawing.Size(46, 15)
        STATUSLabel.TabIndex = 24
        STATUSLabel.Text = "STATUS:"
        '
        'OCCUPATIONLabel
        '
        OCCUPATIONLabel.AutoSize = True
        OCCUPATIONLabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OCCUPATIONLabel.Location = New System.Drawing.Point(16, 219)
        OCCUPATIONLabel.Name = "OCCUPATIONLabel"
        OCCUPATIONLabel.Size = New System.Drawing.Size(73, 15)
        OCCUPATIONLabel.TabIndex = 22
        OCCUPATIONLabel.Text = "OCCUPATION:"
        '
        'INSURANCELabel
        '
        INSURANCELabel.AutoSize = True
        INSURANCELabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        INSURANCELabel.Location = New System.Drawing.Point(432, 80)
        INSURANCELabel.Name = "INSURANCELabel"
        INSURANCELabel.Size = New System.Drawing.Size(67, 15)
        INSURANCELabel.TabIndex = 20
        INSURANCELabel.Text = "INSURANCE:"
        '
        'PHONE_Label
        '
        PHONE_Label.AutoSize = True
        PHONE_Label.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PHONE_Label.Location = New System.Drawing.Point(16, 243)
        PHONE_Label.Name = "PHONE_Label"
        PHONE_Label.Size = New System.Drawing.Size(48, 15)
        PHONE_Label.TabIndex = 18
        PHONE_Label.Text = "PHONE#:"
        '
        'ADDRESSLabel
        '
        ADDRESSLabel.AutoSize = True
        ADDRESSLabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ADDRESSLabel.Location = New System.Drawing.Point(434, 115)
        ADDRESSLabel.Name = "ADDRESSLabel"
        ADDRESSLabel.Size = New System.Drawing.Size(56, 15)
        ADDRESSLabel.TabIndex = 16
        ADDRESSLabel.Text = "ADDRESS:"
        '
        'GENDERLabel
        '
        GENDERLabel.AutoSize = True
        GENDERLabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GENDERLabel.Location = New System.Drawing.Point(16, 192)
        GENDERLabel.Name = "GENDERLabel"
        GENDERLabel.Size = New System.Drawing.Size(50, 15)
        GENDERLabel.TabIndex = 14
        GENDERLabel.Text = "GENDER:"
        '
        'DATE_REGISTEREDLabel
        '
        DATE_REGISTEREDLabel.AutoSize = True
        DATE_REGISTEREDLabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DATE_REGISTEREDLabel.Location = New System.Drawing.Point(16, 169)
        DATE_REGISTEREDLabel.Name = "DATE_REGISTEREDLabel"
        DATE_REGISTEREDLabel.Size = New System.Drawing.Size(98, 15)
        DATE_REGISTEREDLabel.TabIndex = 12
        DATE_REGISTEREDLabel.Text = "DATE REGISTERED:"
        '
        'BIRTHDAYLabel
        '
        BIRTHDAYLabel.AutoSize = True
        BIRTHDAYLabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BIRTHDAYLabel.Location = New System.Drawing.Point(16, 145)
        BIRTHDAYLabel.Name = "BIRTHDAYLabel"
        BIRTHDAYLabel.Size = New System.Drawing.Size(59, 15)
        BIRTHDAYLabel.TabIndex = 10
        BIRTHDAYLabel.Text = "BIRTHDAY:"
        '
        'AGELabel
        '
        AGELabel.AutoSize = True
        AGELabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AGELabel.Location = New System.Drawing.Point(16, 118)
        AGELabel.Name = "AGELabel"
        AGELabel.Size = New System.Drawing.Size(30, 15)
        AGELabel.TabIndex = 8
        AGELabel.Text = "AGE:"
        '
        'SURNAMELabel
        '
        SURNAMELabel.AutoSize = True
        SURNAMELabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SURNAMELabel.Location = New System.Drawing.Point(16, 92)
        SURNAMELabel.Name = "SURNAMELabel"
        SURNAMELabel.Size = New System.Drawing.Size(64, 15)
        SURNAMELabel.TabIndex = 6
        SURNAMELabel.Text = "SURENAME:"
        '
        'MIDDLENAMELabel
        '
        MIDDLENAMELabel.AutoSize = True
        MIDDLENAMELabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MIDDLENAMELabel.Location = New System.Drawing.Point(16, 66)
        MIDDLENAMELabel.Name = "MIDDLENAMELabel"
        MIDDLENAMELabel.Size = New System.Drawing.Size(75, 15)
        MIDDLENAMELabel.TabIndex = 4
        MIDDLENAMELabel.Text = "MIDDLENAME:"
        '
        'PATIENTNAMELabel
        '
        PATIENTNAMELabel.AutoSize = True
        PATIENTNAMELabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENTNAMELabel.Location = New System.Drawing.Point(16, 41)
        PATIENTNAMELabel.Name = "PATIENTNAMELabel"
        PATIENTNAMELabel.Size = New System.Drawing.Size(77, 15)
        PATIENTNAMELabel.TabIndex = 2
        PATIENTNAMELabel.Text = "PATIENTNAME:"
        '
        'PATIENTIDLabel
        '
        PATIENTIDLabel.AutoSize = True
        PATIENTIDLabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENTIDLabel.Location = New System.Drawing.Point(16, 18)
        PATIENTIDLabel.Name = "PATIENTIDLabel"
        PATIENTIDLabel.Size = New System.Drawing.Size(59, 15)
        PATIENTIDLabel.TabIndex = 0
        PATIENTIDLabel.Text = "PATIENTID:"
        '
        'DIAGNOSISLabel
        '
        DIAGNOSISLabel.AutoSize = True
        DIAGNOSISLabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DIAGNOSISLabel.Location = New System.Drawing.Point(432, 50)
        DIAGNOSISLabel.Name = "DIAGNOSISLabel"
        DIAGNOSISLabel.Size = New System.Drawing.Size(63, 15)
        DIAGNOSISLabel.TabIndex = 26
        DIAGNOSISLabel.Text = "DIAGNOSIS:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1115, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 26)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "PRINT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(305, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 24)
        Me.Label1.TabIndex = 14
        '
        'DATABindingSource
        '
        Me.DATABindingSource.DataMember = "DATA"
        Me.DATABindingSource.DataSource = Me.Clinic_databaseDataSet
        '
        'Clinic_databaseDataSet
        '
        Me.Clinic_databaseDataSet.DataSetName = "clinic_databaseDataSet"
        Me.Clinic_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Green
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(1115, 288)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(129, 33)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "EDIT"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Green
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(1115, 251)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(129, 28)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "DELETE"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Green
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(1115, 331)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(129, 29)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "UPDATE"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PATIENT_INFORMATION.My.Resources.Resources._26733436_543181366062477_3439808344077873153_n
        Me.PictureBox1.Location = New System.Drawing.Point(101, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 157
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(230, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(283, 22)
        Me.Label3.TabIndex = 289
        Me.Label3.Text = "Mamatid Health Care Center "
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1114, 369)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(129, 35)
        Me.Button3.TabIndex = 290
        Me.Button3.Text = "Refresh Record"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Green
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.LightCyan
        Me.Button8.Location = New System.Drawing.Point(159, 393)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(69, 25)
        Me.Button8.TabIndex = 291
        Me.Button8.Text = "BROWSE"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PATIENTID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PATIENTID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SURNAME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SURNAME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'PATIENTNAME
        '
        Me.PATIENTNAME.DataPropertyName = "PATIENTNAME"
        Me.PATIENTNAME.HeaderText = "PATIENTNAME"
        Me.PATIENTNAME.Name = "PATIENTNAME"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MIDDLENAME"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MIDDLENAME"
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
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "GENDER"
        Me.DataGridViewTextBoxColumn7.HeaderText = "GENDER"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "STATUS"
        Me.DataGridViewTextBoxColumn8.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "OCCUPATION"
        Me.DataGridViewTextBoxColumn9.HeaderText = "OCCUPATION"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'PATIENTID
        '
        Me.PATIENTID.DataPropertyName = "PATIENTID"
        Me.PATIENTID.HeaderText = "PATIENTID"
        Me.PATIENTID.Name = "PATIENTID"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SURNAME"
        Me.DataGridViewTextBoxColumn10.HeaderText = "SURNAME"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PATIENTNAME"
        Me.DataGridViewTextBoxColumn11.HeaderText = "PATIENTNAME"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "MIDDLENAME"
        Me.DataGridViewTextBoxColumn14.HeaderText = "MIDDLENAME"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "AGE"
        Me.DataGridViewTextBoxColumn15.HeaderText = "AGE"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "BIRTHDAY"
        Me.DataGridViewTextBoxColumn16.HeaderText = "BIRTHDAY"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "GENDER"
        Me.DataGridViewTextBoxColumn17.HeaderText = "GENDER"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "PATIENTID"
        Me.DataGridViewTextBoxColumn18.HeaderText = "PATIENTID"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "SURNAME"
        Me.DataGridViewTextBoxColumn19.HeaderText = "SURNAME"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "MIDDLENAME"
        Me.DataGridViewTextBoxColumn20.HeaderText = "MIDDLENAME"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "AGE"
        Me.DataGridViewTextBoxColumn21.HeaderText = "AGE"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "BIRTHDAY"
        Me.DataGridViewTextBoxColumn22.HeaderText = "BIRTHDAY"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "PATIENTID"
        Me.DataGridViewTextBoxColumn23.HeaderText = "PATIENTID"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "SURNAME"
        Me.DataGridViewTextBoxColumn24.HeaderText = "SURNAME"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "MIDDLENAME"
        Me.DataGridViewTextBoxColumn25.HeaderText = "MIDDLENAME"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "PATIENTNAME"
        Me.DataGridViewTextBoxColumn26.HeaderText = "PATIENTNAME"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "AGE"
        Me.DataGridViewTextBoxColumn27.HeaderText = "AGE"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "BIRTHDAY"
        Me.DataGridViewTextBoxColumn28.HeaderText = "BIRTHDAY"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
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
        Me.DATADataGridView.AllowUserToAddRows = False
        Me.DATADataGridView.AllowUserToDeleteRows = False
        Me.DATADataGridView.AutoGenerateColumns = False
        Me.DATADataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DATADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44})
        Me.DATADataGridView.DataSource = Me.DATABindingSource
        Me.DATADataGridView.Location = New System.Drawing.Point(11, 426)
        Me.DATADataGridView.Name = "DATADataGridView"
        Me.DATADataGridView.ReadOnly = True
        Me.DATADataGridView.Size = New System.Drawing.Size(1232, 288)
        Me.DATADataGridView.TabIndex = 292
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "PATIENTID"
        Me.DataGridViewTextBoxColumn29.HeaderText = "PATIENTID"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "PATIENTNAME"
        Me.DataGridViewTextBoxColumn30.HeaderText = "PATIENTNAME"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "MIDDLENAME"
        Me.DataGridViewTextBoxColumn31.HeaderText = "MIDDLENAME"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "SURNAME"
        Me.DataGridViewTextBoxColumn32.HeaderText = "SURNAME"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "AGE"
        Me.DataGridViewTextBoxColumn33.HeaderText = "AGE"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "BIRTHDAY"
        Me.DataGridViewTextBoxColumn34.HeaderText = "BIRTHDAY"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "DATE REGISTERED"
        Me.DataGridViewTextBoxColumn35.HeaderText = "DATE REGISTERED"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "GENDER"
        Me.DataGridViewTextBoxColumn36.HeaderText = "GENDER"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "ADDRESS"
        Me.DataGridViewTextBoxColumn37.HeaderText = "ADDRESS"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "PHONE#"
        Me.DataGridViewTextBoxColumn38.HeaderText = "PHONE#"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "INSURANCE"
        Me.DataGridViewTextBoxColumn39.HeaderText = "INSURANCE"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "OCCUPATION"
        Me.DataGridViewTextBoxColumn40.HeaderText = "OCCUPATION"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "STATUS"
        Me.DataGridViewTextBoxColumn41.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "DIAGNOSIS"
        Me.DataGridViewTextBoxColumn42.HeaderText = "DIAGNOSIS"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "TREATMENTS"
        Me.DataGridViewTextBoxColumn43.HeaderText = "TREATMENTS"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "ABOUT HEALTH PATIENT"
        Me.DataGridViewTextBoxColumn44.HeaderText = "ABOUT HEALTH PATIENT"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        '
        'search
        '
        Me.search.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.search.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.search.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.ForeColor = System.Drawing.Color.Black
        Me.search.Location = New System.Drawing.Point(1032, 10)
        Me.search.Multiline = True
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(145, 24)
        Me.search.TabIndex = 3
        Me.search.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "search"
        '
        'REFRESS
        '
        Me.REFRESS.BackColor = System.Drawing.Color.Transparent
        Me.REFRESS.BackgroundImage = CType(resources.GetObject("REFRESS.BackgroundImage"), System.Drawing.Image)
        Me.REFRESS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.REFRESS.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.REFRESS.FlatAppearance.BorderSize = 0
        Me.REFRESS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.REFRESS.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REFRESS.Location = New System.Drawing.Point(1183, 10)
        Me.REFRESS.Name = "REFRESS"
        Me.REFRESS.Size = New System.Drawing.Size(25, 23)
        Me.REFRESS.TabIndex = 9
        Me.REFRESS.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1214, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 23)
        Me.btnClose.TabIndex = 12
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(915, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Controls.Add(Me.combosearch)
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.search)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.REFRESS)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 44)
        Me.Panel1.TabIndex = 294
        '
        'combosearch
        '
        Me.combosearch.FormattingEnabled = True
        Me.combosearch.Items.AddRange(New Object() {"SURNAME", "NAME", "PHONE#", "DIAGNOSIS", "INSURANCES", "ADDRESS"})
        Me.combosearch.Location = New System.Drawing.Point(943, 12)
        Me.combosearch.Name = "combosearch"
        Me.combosearch.Size = New System.Drawing.Size(83, 21)
        Me.combosearch.TabIndex = 14
        Me.combosearch.Text = "    Search By:"
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(12, 10)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(25, 24)
        Me.Button11.TabIndex = 7
        Me.Button11.UseVisualStyleBackColor = False
        '
        'iduser
        '
        Me.iduser.AutoSize = True
        Me.iduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iduser.ForeColor = System.Drawing.Color.DarkRed
        Me.iduser.Location = New System.Drawing.Point(277, 100)
        Me.iduser.Name = "iduser"
        Me.iduser.Size = New System.Drawing.Size(13, 16)
        Me.iduser.TabIndex = 297
        Me.iduser.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(233, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 296
        Me.Label4.Text = "Admin:"
        '
        'ABOUTPA
        '
        Me.ABOUTPA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "ABOUT HEALTH PATIENT", True))
        Me.ABOUTPA.Location = New System.Drawing.Point(508, 212)
        Me.ABOUTPA.Multiline = True
        Me.ABOUTPA.Name = "ABOUTPA"
        Me.ABOUTPA.Size = New System.Drawing.Size(325, 46)
        Me.ABOUTPA.TabIndex = 31
        '
        'TREATMENTSTextBox
        '
        Me.TREATMENTSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "TREATMENTS", True))
        Me.TREATMENTSTextBox.Location = New System.Drawing.Point(508, 147)
        Me.TREATMENTSTextBox.Multiline = True
        Me.TREATMENTSTextBox.Name = "TREATMENTSTextBox"
        Me.TREATMENTSTextBox.Size = New System.Drawing.Size(325, 53)
        Me.TREATMENTSTextBox.TabIndex = 29
        '
        'STATUS
        '
        Me.STATUS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "STATUS", True))
        Me.STATUS.FormattingEnabled = True
        Me.STATUS.Location = New System.Drawing.Point(510, 13)
        Me.STATUS.Name = "STATUS"
        Me.STATUS.Size = New System.Drawing.Size(302, 23)
        Me.STATUS.TabIndex = 25
        Me.STATUS.Text = "Single"
        '
        'OCCUPATION
        '
        Me.OCCUPATION.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "OCCUPATION", True))
        Me.OCCUPATION.Location = New System.Drawing.Point(118, 216)
        Me.OCCUPATION.Name = "OCCUPATION"
        Me.OCCUPATION.Size = New System.Drawing.Size(205, 20)
        Me.OCCUPATION.TabIndex = 23
        '
        'PHONE
        '
        Me.PHONE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "PHONE#", True))
        Me.PHONE.Location = New System.Drawing.Point(118, 240)
        Me.PHONE.Name = "PHONE"
        Me.PHONE.Size = New System.Drawing.Size(205, 20)
        Me.PHONE.TabIndex = 19
        '
        'ADDRESS
        '
        Me.ADDRESS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "ADDRESS", True))
        Me.ADDRESS.Location = New System.Drawing.Point(508, 103)
        Me.ADDRESS.Multiline = True
        Me.ADDRESS.Name = "ADDRESS"
        Me.ADDRESS.Size = New System.Drawing.Size(325, 30)
        Me.ADDRESS.TabIndex = 17
        '
        'GENDER
        '
        Me.GENDER.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "GENDER", True))
        Me.GENDER.FormattingEnabled = True
        Me.GENDER.Items.AddRange(New Object() {"Male", "Female"})
        Me.GENDER.Location = New System.Drawing.Point(118, 189)
        Me.GENDER.Name = "GENDER"
        Me.GENDER.Size = New System.Drawing.Size(205, 23)
        Me.GENDER.TabIndex = 15
        Me.GENDER.Text = "Male"
        '
        'DATEREG
        '
        Me.DATEREG.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DATABindingSource, "DATE REGISTERED", True))
        Me.DATEREG.Location = New System.Drawing.Point(118, 165)
        Me.DATEREG.Name = "DATEREG"
        Me.DATEREG.Size = New System.Drawing.Size(205, 20)
        Me.DATEREG.TabIndex = 13
        '
        'BIRTHDAY
        '
        Me.BIRTHDAY.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DATABindingSource, "BIRTHDAY", True))
        Me.BIRTHDAY.Location = New System.Drawing.Point(118, 141)
        Me.BIRTHDAY.Name = "BIRTHDAY"
        Me.BIRTHDAY.Size = New System.Drawing.Size(205, 20)
        Me.BIRTHDAY.TabIndex = 11
        '
        'AGE
        '
        Me.AGE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "AGE", True))
        Me.AGE.FormattingEnabled = True
        Me.AGE.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90"})
        Me.AGE.Location = New System.Drawing.Point(118, 115)
        Me.AGE.Name = "AGE"
        Me.AGE.Size = New System.Drawing.Size(205, 23)
        Me.AGE.TabIndex = 9
        Me.AGE.Text = "18"
        '
        'SURNAME
        '
        Me.SURNAME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "SURNAME", True))
        Me.SURNAME.Location = New System.Drawing.Point(118, 89)
        Me.SURNAME.Name = "SURNAME"
        Me.SURNAME.Size = New System.Drawing.Size(205, 20)
        Me.SURNAME.TabIndex = 7
        '
        'MIDDLENAME
        '
        Me.MIDDLENAME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "MIDDLENAME", True))
        Me.MIDDLENAME.Location = New System.Drawing.Point(118, 63)
        Me.MIDDLENAME.Name = "MIDDLENAME"
        Me.MIDDLENAME.Size = New System.Drawing.Size(205, 20)
        Me.MIDDLENAME.TabIndex = 5
        '
        'PATIENNAME
        '
        Me.PATIENNAME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "PATIENTNAME", True))
        Me.PATIENNAME.Location = New System.Drawing.Point(118, 38)
        Me.PATIENNAME.Name = "PATIENNAME"
        Me.PATIENNAME.Size = New System.Drawing.Size(205, 20)
        Me.PATIENNAME.TabIndex = 3
        '
        'IDHIDE
        '
        Me.IDHIDE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "PATIENTID", True))
        Me.IDHIDE.Location = New System.Drawing.Point(118, 15)
        Me.IDHIDE.Name = "IDHIDE"
        Me.IDHIDE.Size = New System.Drawing.Size(205, 20)
        Me.IDHIDE.TabIndex = 1
        '
        'INSURANCE
        '
        Me.INSURANCE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "INSURANCE", True))
        Me.INSURANCE.FormattingEnabled = True
        Me.INSURANCE.Items.AddRange(New Object() {"NONE", "PHILHEALTH", "Pantawid Pamilyang Pilipino Program(4PS)", "MEDICARE", "MEXICARE-PREMIUM", "INSULAR LIFE ICARE", "EAST-WEST HEALTH OPTION", "Health Maintenance, lnc", "Medocare Health Systems, lnc", "Value Care Health Systems, Inc.", "Caritas Health Shield, Inc", "Asalus Corporation (Intellicare)", "(OTHER)"})
        Me.INSURANCE.Location = New System.Drawing.Point(510, 73)
        Me.INSURANCE.Name = "INSURANCE"
        Me.INSURANCE.Size = New System.Drawing.Size(302, 23)
        Me.INSURANCE.TabIndex = 32
        Me.INSURANCE.Text = "Pantawid Pamilyang Pilipino Program(4PS)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DIAGNOSISComboBox)
        Me.GroupBox1.Controls.Add(Me.INSURANCE)
        Me.GroupBox1.Controls.Add(PATIENTIDLabel)
        Me.GroupBox1.Controls.Add(Me.IDHIDE)
        Me.GroupBox1.Controls.Add(PATIENTNAMELabel)
        Me.GroupBox1.Controls.Add(Me.PATIENNAME)
        Me.GroupBox1.Controls.Add(MIDDLENAMELabel)
        Me.GroupBox1.Controls.Add(Me.MIDDLENAME)
        Me.GroupBox1.Controls.Add(SURNAMELabel)
        Me.GroupBox1.Controls.Add(Me.SURNAME)
        Me.GroupBox1.Controls.Add(AGELabel)
        Me.GroupBox1.Controls.Add(Me.AGE)
        Me.GroupBox1.Controls.Add(BIRTHDAYLabel)
        Me.GroupBox1.Controls.Add(Me.BIRTHDAY)
        Me.GroupBox1.Controls.Add(DATE_REGISTEREDLabel)
        Me.GroupBox1.Controls.Add(Me.DATEREG)
        Me.GroupBox1.Controls.Add(GENDERLabel)
        Me.GroupBox1.Controls.Add(Me.GENDER)
        Me.GroupBox1.Controls.Add(ADDRESSLabel)
        Me.GroupBox1.Controls.Add(Me.ADDRESS)
        Me.GroupBox1.Controls.Add(PHONE_Label)
        Me.GroupBox1.Controls.Add(Me.PHONE)
        Me.GroupBox1.Controls.Add(STATUSLabel)
        Me.GroupBox1.Controls.Add(INSURANCELabel)
        Me.GroupBox1.Controls.Add(DIAGNOSISLabel)
        Me.GroupBox1.Controls.Add(OCCUPATIONLabel)
        Me.GroupBox1.Controls.Add(Me.STATUS)
        Me.GroupBox1.Controls.Add(Me.OCCUPATION)
        Me.GroupBox1.Controls.Add(TREATMENTSLabel)
        Me.GroupBox1.Controls.Add(Me.TREATMENTSTextBox)
        Me.GroupBox1.Controls.Add(ABOUT_HEALTH_PATIENTLabel)
        Me.GroupBox1.Controls.Add(Me.ABOUTPA)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(240, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(848, 266)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DETAILS"
        '
        'DIAGNOSISComboBox
        '
        Me.DIAGNOSISComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "DIAGNOSIS", True))
        Me.DIAGNOSISComboBox.FormattingEnabled = True
        Me.DIAGNOSISComboBox.Items.AddRange(New Object() {"Blood Donor", "Arthritis", "Diabetes", "Influenza and Pneumonia", "Osteoporosis", "Substance Abuse", "Respiratory Diseases", "Environmental Quality.", "Immunization.", "Heart disease.", "Asthma.", "Diabetes.", "Headaches.", "Depression", "Gastrointestinal problems.", "Physical Activity and Nutrition.", "Overweight and Obesity.", "Substance Abuse.", "Mental Health.", "Premature death(For Babies)."})
        Me.DIAGNOSISComboBox.Location = New System.Drawing.Point(510, 46)
        Me.DIAGNOSISComboBox.Name = "DIAGNOSISComboBox"
        Me.DIAGNOSISComboBox.Size = New System.Drawing.Size(302, 23)
        Me.DIAGNOSISComboBox.TabIndex = 33
        Me.DIAGNOSISComboBox.Text = "Osteoporosis"
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Green
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.LightCyan
        Me.Button14.Location = New System.Drawing.Point(87, 393)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(66, 25)
        Me.Button14.TabIndex = 330
        Me.Button14.Text = "CAPTURE"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Green
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.LightCyan
        Me.Button13.Location = New System.Drawing.Point(12, 393)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(69, 25)
        Me.Button13.TabIndex = 329
        Me.Button13.Text = "START"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1135, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "Verification Code"
        '
        'QRCODEPictureBox
        '
        Me.QRCODEPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.DATABindingSource, "QRCODE", True))
        Me.QRCODEPictureBox.Location = New System.Drawing.Point(1116, 113)
        Me.QRCODEPictureBox.Name = "QRCODEPictureBox"
        Me.QRCODEPictureBox.Size = New System.Drawing.Size(122, 104)
        Me.QRCODEPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QRCODEPictureBox.TabIndex = 333
        Me.QRCODEPictureBox.TabStop = False
        '
        'PICTUREPictureBox
        '
        Me.PICTUREPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.DATABindingSource, "PICTURE", True))
        Me.PICTUREPictureBox.Image = Global.PATIENT_INFORMATION.My.Resources.Resources.user_image_with_black_background1
        Me.PICTUREPictureBox.Location = New System.Drawing.Point(12, 195)
        Me.PICTUREPictureBox.Name = "PICTUREPictureBox"
        Me.PICTUREPictureBox.Size = New System.Drawing.Size(216, 195)
        Me.PICTUREPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PICTUREPictureBox.TabIndex = 334
        Me.PICTUREPictureBox.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(329, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 336
        Me.Label6.Text = "0000000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(245, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 337
        Me.Label7.Text = "Total of Patients:"
        '
        'notification3
        '
        Me.notification3.AutoSize = True
        Me.notification3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notification3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.notification3.Location = New System.Drawing.Point(800, 95)
        Me.notification3.Name = "notification3"
        Me.notification3.Size = New System.Drawing.Size(0, 20)
        Me.notification3.TabIndex = 338
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1256, 728)
        Me.Controls.Add(Me.notification3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PICTUREPictureBox)
        Me.Controls.Add(Me.QRCODEPictureBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.iduser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DATADataGridView)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(PICTURELabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.DATABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clinic_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.QRCODEPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICTUREPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SURENAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Clinic_databaseDataSet As PATIENT_INFORMATION.clinic_databaseDataSet
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATIENTNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATIENTID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DATATableAdapter As PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.DATATableAdapter
    Friend WithEvents TableAdapterManager As PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DATADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents search As System.Windows.Forms.TextBox
    Friend WithEvents REFRESS As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents iduser As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ABOUTPA As System.Windows.Forms.TextBox
    Friend WithEvents TREATMENTSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents STATUS As System.Windows.Forms.ComboBox
    Friend WithEvents OCCUPATION As System.Windows.Forms.TextBox
    Friend WithEvents PHONE As System.Windows.Forms.TextBox
    Friend WithEvents ADDRESS As System.Windows.Forms.TextBox
    Friend WithEvents GENDER As System.Windows.Forms.ComboBox
    Friend WithEvents DATEREG As System.Windows.Forms.DateTimePicker
    Friend WithEvents BIRTHDAY As System.Windows.Forms.DateTimePicker
    Friend WithEvents AGE As System.Windows.Forms.ComboBox
    Friend WithEvents SURNAME As System.Windows.Forms.TextBox
    Friend WithEvents MIDDLENAME As System.Windows.Forms.TextBox
    Friend WithEvents PATIENNAME As System.Windows.Forms.TextBox
    Friend WithEvents IDHIDE As System.Windows.Forms.TextBox
    Friend WithEvents INSURANCE As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents combosearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents QRCODEPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PICTUREPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents DIAGNOSISComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents notification3 As System.Windows.Forms.Label
End Class
