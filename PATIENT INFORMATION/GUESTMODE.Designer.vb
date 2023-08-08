<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUESTMODE
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
        Dim PATIENTNAMELabel As System.Windows.Forms.Label
        Dim MIDDLENAMELabel As System.Windows.Forms.Label
        Dim SURNAMELabel As System.Windows.Forms.Label
        Dim AGELabel As System.Windows.Forms.Label
        Dim BIRTHDAYLabel As System.Windows.Forms.Label
        Dim DATE_REGISTEREDLabel As System.Windows.Forms.Label
        Dim GENDERLabel As System.Windows.Forms.Label
        Dim ADDRESSLabel As System.Windows.Forms.Label
        Dim PHONE_Label As System.Windows.Forms.Label
        Dim INSURANCELabel As System.Windows.Forms.Label
        Dim OCCUPATIONLabel As System.Windows.Forms.Label
        Dim STATUSLabel As System.Windows.Forms.Label
        Dim DIAGNOSISLabel As System.Windows.Forms.Label
        Dim TREATMENTSLabel As System.Windows.Forms.Label
        Dim ABOUT_HEALTH_PATIENTLabel As System.Windows.Forms.Label
        Dim PICTURELabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUESTMODE))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Clinic_databaseDataSet = New PATIENT_INFORMATION.clinic_databaseDataSet()
        Me.DATABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DATATableAdapter = New PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.DATATableAdapter()
        Me.TableAdapterManager = New PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.TableAdapterManager()
        Me.PATIENTNAMETextBox = New System.Windows.Forms.TextBox()
        Me.MIDDLENAMETextBox = New System.Windows.Forms.TextBox()
        Me.SURNAMETextBox = New System.Windows.Forms.TextBox()
        Me.AGEComboBox = New System.Windows.Forms.ComboBox()
        Me.BIRTHDAYDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DATE_REGISTEREDDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GENDERComboBox = New System.Windows.Forms.ComboBox()
        Me.ADDRESSTextBox = New System.Windows.Forms.TextBox()
        Me.PHONE_TextBox = New System.Windows.Forms.TextBox()
        Me.INSURANCEComboBox = New System.Windows.Forms.ComboBox()
        Me.OCCUPATIONTextBox = New System.Windows.Forms.TextBox()
        Me.STATUSComboBox = New System.Windows.Forms.ComboBox()
        Me.DIAGNOSISTextBox = New System.Windows.Forms.TextBox()
        Me.TREATMENTSTextBox = New System.Windows.Forms.TextBox()
        Me.ABOUT_HEALTH_PATIENTTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.iduser = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PICTUREPictureBox = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.idhide = New System.Windows.Forms.TextBox()
        Me.QRCODEPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.guestnotif = New System.Windows.Forms.Label()
        PATIENTNAMELabel = New System.Windows.Forms.Label()
        MIDDLENAMELabel = New System.Windows.Forms.Label()
        SURNAMELabel = New System.Windows.Forms.Label()
        AGELabel = New System.Windows.Forms.Label()
        BIRTHDAYLabel = New System.Windows.Forms.Label()
        DATE_REGISTEREDLabel = New System.Windows.Forms.Label()
        GENDERLabel = New System.Windows.Forms.Label()
        ADDRESSLabel = New System.Windows.Forms.Label()
        PHONE_Label = New System.Windows.Forms.Label()
        INSURANCELabel = New System.Windows.Forms.Label()
        OCCUPATIONLabel = New System.Windows.Forms.Label()
        STATUSLabel = New System.Windows.Forms.Label()
        DIAGNOSISLabel = New System.Windows.Forms.Label()
        TREATMENTSLabel = New System.Windows.Forms.Label()
        ABOUT_HEALTH_PATIENTLabel = New System.Windows.Forms.Label()
        PICTURELabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.Clinic_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICTUREPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRCODEPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PATIENTNAMELabel
        '
        PATIENTNAMELabel.AutoSize = True
        PATIENTNAMELabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENTNAMELabel.Location = New System.Drawing.Point(84, 221)
        PATIENTNAMELabel.Name = "PATIENTNAMELabel"
        PATIENTNAMELabel.Size = New System.Drawing.Size(81, 14)
        PATIENTNAMELabel.TabIndex = 38
        PATIENTNAMELabel.Text = "PATIENTNAME:"
        AddHandler PATIENTNAMELabel.Click, AddressOf Me.PATIENTNAMELabel_Click
        '
        'MIDDLENAMELabel
        '
        MIDDLENAMELabel.AutoSize = True
        MIDDLENAMELabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MIDDLENAMELabel.Location = New System.Drawing.Point(84, 273)
        MIDDLENAMELabel.Name = "MIDDLENAMELabel"
        MIDDLENAMELabel.Size = New System.Drawing.Size(81, 14)
        MIDDLENAMELabel.TabIndex = 40
        MIDDLENAMELabel.Text = "MIDDLENAME:"
        AddHandler MIDDLENAMELabel.Click, AddressOf Me.MIDDLENAMELabel_Click
        '
        'SURNAMELabel
        '
        SURNAMELabel.AutoSize = True
        SURNAMELabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SURNAMELabel.Location = New System.Drawing.Point(84, 321)
        SURNAMELabel.Name = "SURNAMELabel"
        SURNAMELabel.Size = New System.Drawing.Size(62, 14)
        SURNAMELabel.TabIndex = 42
        SURNAMELabel.Text = "SURNAME:"
        AddHandler SURNAMELabel.Click, AddressOf Me.SURNAMELabel_Click
        '
        'AGELabel
        '
        AGELabel.AutoSize = True
        AGELabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AGELabel.Location = New System.Drawing.Point(83, 366)
        AGELabel.Name = "AGELabel"
        AGELabel.Size = New System.Drawing.Size(31, 14)
        AGELabel.TabIndex = 44
        AGELabel.Text = "AGE:"
        AddHandler AGELabel.Click, AddressOf Me.AGELabel_Click
        '
        'BIRTHDAYLabel
        '
        BIRTHDAYLabel.AutoSize = True
        BIRTHDAYLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BIRTHDAYLabel.Location = New System.Drawing.Point(84, 406)
        BIRTHDAYLabel.Name = "BIRTHDAYLabel"
        BIRTHDAYLabel.Size = New System.Drawing.Size(60, 14)
        BIRTHDAYLabel.TabIndex = 46
        BIRTHDAYLabel.Text = "BIRTHDAY:"
        AddHandler BIRTHDAYLabel.Click, AddressOf Me.BIRTHDAYLabel_Click
        '
        'DATE_REGISTEREDLabel
        '
        DATE_REGISTEREDLabel.AutoSize = True
        DATE_REGISTEREDLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DATE_REGISTEREDLabel.Location = New System.Drawing.Point(84, 447)
        DATE_REGISTEREDLabel.Name = "DATE_REGISTEREDLabel"
        DATE_REGISTEREDLabel.Size = New System.Drawing.Size(102, 14)
        DATE_REGISTEREDLabel.TabIndex = 48
        DATE_REGISTEREDLabel.Text = "DATE REGISTERED:"
        AddHandler DATE_REGISTEREDLabel.Click, AddressOf Me.DATE_REGISTEREDLabel_Click
        '
        'GENDERLabel
        '
        GENDERLabel.AutoSize = True
        GENDERLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GENDERLabel.Location = New System.Drawing.Point(84, 487)
        GENDERLabel.Name = "GENDERLabel"
        GENDERLabel.Size = New System.Drawing.Size(53, 14)
        GENDERLabel.TabIndex = 50
        GENDERLabel.Text = "GENDER:"
        AddHandler GENDERLabel.Click, AddressOf Me.GENDERLabel_Click
        '
        'ADDRESSLabel
        '
        ADDRESSLabel.AutoSize = True
        ADDRESSLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ADDRESSLabel.Location = New System.Drawing.Point(84, 532)
        ADDRESSLabel.Name = "ADDRESSLabel"
        ADDRESSLabel.Size = New System.Drawing.Size(58, 14)
        ADDRESSLabel.TabIndex = 52
        ADDRESSLabel.Text = "ADDRESS:"
        AddHandler ADDRESSLabel.Click, AddressOf Me.ADDRESSLabel_Click
        '
        'PHONE_Label
        '
        PHONE_Label.AutoSize = True
        PHONE_Label.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PHONE_Label.Location = New System.Drawing.Point(542, 219)
        PHONE_Label.Name = "PHONE_Label"
        PHONE_Label.Size = New System.Drawing.Size(52, 14)
        PHONE_Label.TabIndex = 54
        PHONE_Label.Text = "PHONE#:"
        AddHandler PHONE_Label.Click, AddressOf Me.PHONE_Label_Click
        '
        'INSURANCELabel
        '
        INSURANCELabel.AutoSize = True
        INSURANCELabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        INSURANCELabel.Location = New System.Drawing.Point(538, 254)
        INSURANCELabel.Name = "INSURANCELabel"
        INSURANCELabel.Size = New System.Drawing.Size(69, 14)
        INSURANCELabel.TabIndex = 56
        INSURANCELabel.Text = "INSURANCE:"
        AddHandler INSURANCELabel.Click, AddressOf Me.INSURANCELabel_Click
        '
        'OCCUPATIONLabel
        '
        OCCUPATIONLabel.AutoSize = True
        OCCUPATIONLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OCCUPATIONLabel.Location = New System.Drawing.Point(538, 281)
        OCCUPATIONLabel.Name = "OCCUPATIONLabel"
        OCCUPATIONLabel.Size = New System.Drawing.Size(74, 14)
        OCCUPATIONLabel.TabIndex = 58
        OCCUPATIONLabel.Text = "OCCUPATION:"
        AddHandler OCCUPATIONLabel.Click, AddressOf Me.OCCUPATIONLabel_Click
        '
        'STATUSLabel
        '
        STATUSLabel.AutoSize = True
        STATUSLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        STATUSLabel.Location = New System.Drawing.Point(548, 314)
        STATUSLabel.Name = "STATUSLabel"
        STATUSLabel.Size = New System.Drawing.Size(47, 14)
        STATUSLabel.TabIndex = 60
        STATUSLabel.Text = "STATUS:"
        AddHandler STATUSLabel.Click, AddressOf Me.STATUSLabel_Click
        '
        'DIAGNOSISLabel
        '
        DIAGNOSISLabel.AutoSize = True
        DIAGNOSISLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DIAGNOSISLabel.Location = New System.Drawing.Point(538, 354)
        DIAGNOSISLabel.Name = "DIAGNOSISLabel"
        DIAGNOSISLabel.Size = New System.Drawing.Size(67, 14)
        DIAGNOSISLabel.TabIndex = 62
        DIAGNOSISLabel.Text = "DIAGNOSIS:"
        AddHandler DIAGNOSISLabel.Click, AddressOf Me.DIAGNOSISLabel_Click
        '
        'TREATMENTSLabel
        '
        TREATMENTSLabel.AutoSize = True
        TREATMENTSLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TREATMENTSLabel.Location = New System.Drawing.Point(538, 425)
        TREATMENTSLabel.Name = "TREATMENTSLabel"
        TREATMENTSLabel.Size = New System.Drawing.Size(77, 14)
        TREATMENTSLabel.TabIndex = 64
        TREATMENTSLabel.Text = "TREATMENTS:"
        AddHandler TREATMENTSLabel.Click, AddressOf Me.TREATMENTSLabel_Click
        '
        'ABOUT_HEALTH_PATIENTLabel
        '
        ABOUT_HEALTH_PATIENTLabel.AutoSize = True
        ABOUT_HEALTH_PATIENTLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ABOUT_HEALTH_PATIENTLabel.Location = New System.Drawing.Point(517, 492)
        ABOUT_HEALTH_PATIENTLabel.Name = "ABOUT_HEALTH_PATIENTLabel"
        ABOUT_HEALTH_PATIENTLabel.Size = New System.Drawing.Size(130, 14)
        ABOUT_HEALTH_PATIENTLabel.TabIndex = 66
        ABOUT_HEALTH_PATIENTLabel.Text = "ABOUT HEALTH PATIENT:"
        AddHandler ABOUT_HEALTH_PATIENTLabel.Click, AddressOf Me.ABOUT_HEALTH_PATIENTLabel_Click
        '
        'PICTURELabel
        '
        PICTURELabel.AutoSize = True
        PICTURELabel.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PICTURELabel.Location = New System.Drawing.Point(1056, 129)
        PICTURELabel.Name = "PICTURELabel"
        PICTURELabel.Size = New System.Drawing.Size(64, 16)
        PICTURELabel.TabIndex = 68
        PICTURELabel.Text = "PICTURE"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(285, 72)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(546, 35)
        Label1.TabIndex = 290
        Label1.Text = "Clinic of Mamatid Patient Information System"
        Label1.UseCompatibleTextRendering = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(529, 613)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(208, 40)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "SAVE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(147, 581)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(208, 36)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "ADD NEW"
        Me.Button2.UseVisualStyleBackColor = False
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
        'PATIENTNAMETextBox
        '
        Me.PATIENTNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "PATIENTNAME", True))
        Me.PATIENTNAMETextBox.Location = New System.Drawing.Point(196, 215)
        Me.PATIENTNAMETextBox.Name = "PATIENTNAMETextBox"
        Me.PATIENTNAMETextBox.Size = New System.Drawing.Size(231, 20)
        Me.PATIENTNAMETextBox.TabIndex = 39
        '
        'MIDDLENAMETextBox
        '
        Me.MIDDLENAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "MIDDLENAME", True))
        Me.MIDDLENAMETextBox.Location = New System.Drawing.Point(196, 267)
        Me.MIDDLENAMETextBox.Name = "MIDDLENAMETextBox"
        Me.MIDDLENAMETextBox.Size = New System.Drawing.Size(231, 20)
        Me.MIDDLENAMETextBox.TabIndex = 41
        '
        'SURNAMETextBox
        '
        Me.SURNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "SURNAME", True))
        Me.SURNAMETextBox.Location = New System.Drawing.Point(196, 316)
        Me.SURNAMETextBox.Name = "SURNAMETextBox"
        Me.SURNAMETextBox.Size = New System.Drawing.Size(231, 20)
        Me.SURNAMETextBox.TabIndex = 43
        '
        'AGEComboBox
        '
        Me.AGEComboBox.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90"})
        Me.AGEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "AGE", True))
        Me.AGEComboBox.FormattingEnabled = True
        Me.AGEComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90"})
        Me.AGEComboBox.Location = New System.Drawing.Point(196, 360)
        Me.AGEComboBox.Name = "AGEComboBox"
        Me.AGEComboBox.Size = New System.Drawing.Size(231, 21)
        Me.AGEComboBox.TabIndex = 45
        Me.AGEComboBox.Text = "10"
        '
        'BIRTHDAYDateTimePicker
        '
        Me.BIRTHDAYDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DATABindingSource, "BIRTHDAY", True))
        Me.BIRTHDAYDateTimePicker.Location = New System.Drawing.Point(196, 399)
        Me.BIRTHDAYDateTimePicker.Name = "BIRTHDAYDateTimePicker"
        Me.BIRTHDAYDateTimePicker.Size = New System.Drawing.Size(231, 20)
        Me.BIRTHDAYDateTimePicker.TabIndex = 47
        '
        'DATE_REGISTEREDDateTimePicker
        '
        Me.DATE_REGISTEREDDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DATABindingSource, "DATE REGISTERED", True))
        Me.DATE_REGISTEREDDateTimePicker.Location = New System.Drawing.Point(196, 440)
        Me.DATE_REGISTEREDDateTimePicker.Name = "DATE_REGISTEREDDateTimePicker"
        Me.DATE_REGISTEREDDateTimePicker.Size = New System.Drawing.Size(231, 20)
        Me.DATE_REGISTEREDDateTimePicker.TabIndex = 49
        '
        'GENDERComboBox
        '
        Me.GENDERComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "GENDER", True))
        Me.GENDERComboBox.FormattingEnabled = True
        Me.GENDERComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GENDERComboBox.Location = New System.Drawing.Point(196, 481)
        Me.GENDERComboBox.Name = "GENDERComboBox"
        Me.GENDERComboBox.Size = New System.Drawing.Size(231, 21)
        Me.GENDERComboBox.TabIndex = 51
        Me.GENDERComboBox.Text = "Male"
        '
        'ADDRESSTextBox
        '
        Me.ADDRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "ADDRESS", True))
        Me.ADDRESSTextBox.Location = New System.Drawing.Point(196, 526)
        Me.ADDRESSTextBox.Name = "ADDRESSTextBox"
        Me.ADDRESSTextBox.Size = New System.Drawing.Size(231, 20)
        Me.ADDRESSTextBox.TabIndex = 53
        '
        'PHONE_TextBox
        '
        Me.PHONE_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "PHONE#", True))
        Me.PHONE_TextBox.Location = New System.Drawing.Point(660, 210)
        Me.PHONE_TextBox.Name = "PHONE_TextBox"
        Me.PHONE_TextBox.Size = New System.Drawing.Size(225, 20)
        Me.PHONE_TextBox.TabIndex = 55
        Me.PHONE_TextBox.Text = "+63"
        '
        'INSURANCEComboBox
        '
        Me.INSURANCEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "INSURANCE", True))
        Me.INSURANCEComboBox.FormattingEnabled = True
        Me.INSURANCEComboBox.Items.AddRange(New Object() {"NONE", "PHILHEALTH", "Pantawid Pamilyang Pilipino Program(4PS)", "MEDICARE", "MEXICARE-PREMIUM", "INSULAR LIFE ICARE", "EAST-WEST HEALTH OPTION", "Health Maintenance, lnc", "Medocare Health Systems, lnc", "Value Care Health Systems, Inc.", "Caritas Health Shield, Inc", "Asalus Corporation (Intellicare)", "(OTHER)"})
        Me.INSURANCEComboBox.Location = New System.Drawing.Point(660, 248)
        Me.INSURANCEComboBox.Name = "INSURANCEComboBox"
        Me.INSURANCEComboBox.Size = New System.Drawing.Size(225, 21)
        Me.INSURANCEComboBox.TabIndex = 57
        Me.INSURANCEComboBox.Text = "Pantawid Pamilyang Pilipino Program(4PS)"
        '
        'OCCUPATIONTextBox
        '
        Me.OCCUPATIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "OCCUPATION", True))
        Me.OCCUPATIONTextBox.Location = New System.Drawing.Point(660, 277)
        Me.OCCUPATIONTextBox.Name = "OCCUPATIONTextBox"
        Me.OCCUPATIONTextBox.Size = New System.Drawing.Size(225, 20)
        Me.OCCUPATIONTextBox.TabIndex = 59
        '
        'STATUSComboBox
        '
        Me.STATUSComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "STATUS", True))
        Me.STATUSComboBox.FormattingEnabled = True
        Me.STATUSComboBox.Items.AddRange(New Object() {"SINGLE", "MERRIED", "DIVORCED", "WINDOWED"})
        Me.STATUSComboBox.Location = New System.Drawing.Point(660, 310)
        Me.STATUSComboBox.Name = "STATUSComboBox"
        Me.STATUSComboBox.Size = New System.Drawing.Size(225, 21)
        Me.STATUSComboBox.TabIndex = 61
        Me.STATUSComboBox.Text = "SINGLE"
        '
        'DIAGNOSISTextBox
        '
        Me.DIAGNOSISTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "DIAGNOSIS", True))
        Me.DIAGNOSISTextBox.Location = New System.Drawing.Point(660, 348)
        Me.DIAGNOSISTextBox.Multiline = True
        Me.DIAGNOSISTextBox.Name = "DIAGNOSISTextBox"
        Me.DIAGNOSISTextBox.Size = New System.Drawing.Size(225, 63)
        Me.DIAGNOSISTextBox.TabIndex = 63
        '
        'TREATMENTSTextBox
        '
        Me.TREATMENTSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "TREATMENTS", True))
        Me.TREATMENTSTextBox.Location = New System.Drawing.Point(660, 421)
        Me.TREATMENTSTextBox.Multiline = True
        Me.TREATMENTSTextBox.Name = "TREATMENTSTextBox"
        Me.TREATMENTSTextBox.Size = New System.Drawing.Size(225, 60)
        Me.TREATMENTSTextBox.TabIndex = 65
        '
        'ABOUT_HEALTH_PATIENTTextBox
        '
        Me.ABOUT_HEALTH_PATIENTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "ABOUT HEALTH PATIENT", True))
        Me.ABOUT_HEALTH_PATIENTTextBox.Location = New System.Drawing.Point(662, 487)
        Me.ABOUT_HEALTH_PATIENTTextBox.Multiline = True
        Me.ABOUT_HEALTH_PATIENTTextBox.Name = "ABOUT_HEALTH_PATIENTTextBox"
        Me.ABOUT_HEALTH_PATIENTTextBox.Size = New System.Drawing.Size(223, 59)
        Me.ABOUT_HEALTH_PATIENTTextBox.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 16)
        Me.Label3.TabIndex = 291
        Me.Label3.Text = "Mamatid Health Care Center "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1287, 45)
        Me.Panel1.TabIndex = 293
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1040, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(166, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 335
        Me.PictureBox2.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1250, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 23)
        Me.btnClose.TabIndex = 12
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1219, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(25, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.UseVisualStyleBackColor = False
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(296, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 294
        Me.Label2.Text = "Guest/user:"
        '
        'iduser
        '
        Me.iduser.AutoSize = True
        Me.iduser.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iduser.ForeColor = System.Drawing.Color.DarkGreen
        Me.iduser.Location = New System.Drawing.Point(361, 122)
        Me.iduser.Name = "iduser"
        Me.iduser.Size = New System.Drawing.Size(14, 16)
        Me.iduser.TabIndex = 295
        Me.iduser.Text = "*"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Green
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(888, 581)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(211, 37)
        Me.Button6.TabIndex = 296
        Me.Button6.Text = "CLEAR"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PATIENT_INFORMATION.My.Resources.Resources._26733436_543181366062477_3439808344077873153_n
        Me.PictureBox1.Location = New System.Drawing.Point(100, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 289
        Me.PictureBox1.TabStop = False
        '
        'PICTUREPictureBox
        '
        Me.PICTUREPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.DATABindingSource, "PICTURE", True))
        Me.PICTUREPictureBox.Image = Global.PATIENT_INFORMATION.My.Resources.Resources.user_image_with_black_background
        Me.PICTUREPictureBox.Location = New System.Drawing.Point(957, 148)
        Me.PICTUREPictureBox.Name = "PICTUREPictureBox"
        Me.PICTUREPictureBox.Size = New System.Drawing.Size(249, 213)
        Me.PICTUREPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PICTUREPictureBox.TabIndex = 69
        Me.PICTUREPictureBox.TabStop = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Green
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(147, 654)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(249, 32)
        Me.Button7.TabIndex = 297
        Me.Button7.Text = "LOGOUT"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Green
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(850, 653)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(249, 32)
        Me.Button8.TabIndex = 298
        Me.Button8.Text = "VIEW RECORDS DATABASE"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Green
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.LightCyan
        Me.Button14.Location = New System.Drawing.Point(1052, 368)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(71, 33)
        Me.Button14.TabIndex = 331
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
        Me.Button13.Location = New System.Drawing.Point(964, 368)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(82, 33)
        Me.Button13.TabIndex = 330
        Me.Button13.Text = "START"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightCyan
        Me.Button1.Location = New System.Drawing.Point(1129, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 33)
        Me.Button1.TabIndex = 329
        Me.Button1.Text = "BROWSE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'idhide
        '
        Me.idhide.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "PATIENTID", True))
        Me.idhide.Location = New System.Drawing.Point(305, 154)
        Me.idhide.Name = "idhide"
        Me.idhide.Size = New System.Drawing.Size(70, 20)
        Me.idhide.TabIndex = 332
        '
        'QRCODEPictureBox
        '
        Me.QRCODEPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.DATABindingSource, "QRCODE", True))
        Me.QRCODEPictureBox.Location = New System.Drawing.Point(1214, 51)
        Me.QRCODEPictureBox.Name = "QRCODEPictureBox"
        Me.QRCODEPictureBox.Size = New System.Drawing.Size(61, 56)
        Me.QRCODEPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QRCODEPictureBox.TabIndex = 333
        Me.QRCODEPictureBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(285, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 334
        Me.Label4.Text = "ID:"
        '
        'guestnotif
        '
        Me.guestnotif.AutoSize = True
        Me.guestnotif.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestnotif.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.guestnotif.Location = New System.Drawing.Point(658, 129)
        Me.guestnotif.Name = "guestnotif"
        Me.guestnotif.Size = New System.Drawing.Size(0, 20)
        Me.guestnotif.TabIndex = 341
        '
        'GUESTMODE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1287, 706)
        Me.Controls.Add(Me.guestnotif)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.QRCODEPictureBox)
        Me.Controls.Add(Me.idhide)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.iduser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(PATIENTNAMELabel)
        Me.Controls.Add(Me.PATIENTNAMETextBox)
        Me.Controls.Add(MIDDLENAMELabel)
        Me.Controls.Add(Me.MIDDLENAMETextBox)
        Me.Controls.Add(SURNAMELabel)
        Me.Controls.Add(Me.SURNAMETextBox)
        Me.Controls.Add(AGELabel)
        Me.Controls.Add(Me.AGEComboBox)
        Me.Controls.Add(BIRTHDAYLabel)
        Me.Controls.Add(Me.BIRTHDAYDateTimePicker)
        Me.Controls.Add(DATE_REGISTEREDLabel)
        Me.Controls.Add(Me.DATE_REGISTEREDDateTimePicker)
        Me.Controls.Add(GENDERLabel)
        Me.Controls.Add(Me.GENDERComboBox)
        Me.Controls.Add(ADDRESSLabel)
        Me.Controls.Add(Me.ADDRESSTextBox)
        Me.Controls.Add(PHONE_Label)
        Me.Controls.Add(Me.PHONE_TextBox)
        Me.Controls.Add(INSURANCELabel)
        Me.Controls.Add(Me.INSURANCEComboBox)
        Me.Controls.Add(OCCUPATIONLabel)
        Me.Controls.Add(Me.OCCUPATIONTextBox)
        Me.Controls.Add(STATUSLabel)
        Me.Controls.Add(Me.STATUSComboBox)
        Me.Controls.Add(DIAGNOSISLabel)
        Me.Controls.Add(Me.DIAGNOSISTextBox)
        Me.Controls.Add(TREATMENTSLabel)
        Me.Controls.Add(Me.TREATMENTSTextBox)
        Me.Controls.Add(ABOUT_HEALTH_PATIENTLabel)
        Me.Controls.Add(Me.ABOUT_HEALTH_PATIENTTextBox)
        Me.Controls.Add(PICTURELabel)
        Me.Controls.Add(Me.PICTUREPictureBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GUESTMODE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUESTMODE"
        CType(Me.Clinic_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICTUREPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRCODEPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Clinic_databaseDataSet As PATIENT_INFORMATION.clinic_databaseDataSet
    Friend WithEvents DATABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DATATableAdapter As PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.DATATableAdapter
    Friend WithEvents TableAdapterManager As PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PATIENTNAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents MIDDLENAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents SURNAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents AGEComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BIRTHDAYDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DATE_REGISTEREDDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GENDERComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ADDRESSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PHONE_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents INSURANCEComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OCCUPATIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents STATUSComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DIAGNOSISTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TREATMENTSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ABOUT_HEALTH_PATIENTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PICTUREPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents iduser As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents idhide As System.Windows.Forms.TextBox
    Friend WithEvents QRCODEPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents guestnotif As System.Windows.Forms.Label
End Class
