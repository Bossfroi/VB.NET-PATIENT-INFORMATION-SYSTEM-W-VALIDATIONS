<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim PATIENTIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Clinic_databaseDataSet = New PATIENT_INFORMATION.clinic_databaseDataSet()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DATABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DATATableAdapter = New PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.DATATableAdapter()
        Me.TableAdapterManager = New PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.TableAdapterManager()
        Me.PATIENTNAME = New System.Windows.Forms.TextBox()
        Me.MIDDLENAME = New System.Windows.Forms.TextBox()
        Me.SURNAME = New System.Windows.Forms.TextBox()
        Me.AGE = New System.Windows.Forms.ComboBox()
        Me.BIRTHDAY = New System.Windows.Forms.DateTimePicker()
        Me.DATEREG = New System.Windows.Forms.DateTimePicker()
        Me.gENDER = New System.Windows.Forms.ComboBox()
        Me.ADDRESS = New System.Windows.Forms.TextBox()
        Me.PHONE = New System.Windows.Forms.TextBox()
        Me.OCCUPATION = New System.Windows.Forms.TextBox()
        Me.STATUS = New System.Windows.Forms.ComboBox()
        Me.TREATMENTSTextBox = New System.Windows.Forms.TextBox()
        Me.ABOUTPA = New System.Windows.Forms.TextBox()
        Me.IDHIDE = New System.Windows.Forms.TextBox()
        Me.INSURANCE = New System.Windows.Forms.ComboBox()
        Me.iduser = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button14 = New System.Windows.Forms.Button()
        Me.PICTUREPictureBox = New System.Windows.Forms.PictureBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.QRCODEPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DIAGNOSISComboBox = New System.Windows.Forms.ComboBox()
        Me.notification2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
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
        PATIENTIDLabel = New System.Windows.Forms.Label()
        CType(Me.Clinic_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DATABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICTUREPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRCODEPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(262, 77)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(546, 35)
        Label1.TabIndex = 287
        Label1.Text = "Clinic of Mamatid Patient Information System"
        Label1.UseCompatibleTextRendering = True
        '
        'PATIENTNAMELabel
        '
        PATIENTNAMELabel.AutoSize = True
        PATIENTNAMELabel.Location = New System.Drawing.Point(33, 182)
        PATIENTNAMELabel.Name = "PATIENTNAMELabel"
        PATIENTNAMELabel.Size = New System.Drawing.Size(87, 13)
        PATIENTNAMELabel.TabIndex = 291
        PATIENTNAMELabel.Text = "PATIENTNAME:"
        '
        'MIDDLENAMELabel
        '
        MIDDLENAMELabel.AutoSize = True
        MIDDLENAMELabel.Location = New System.Drawing.Point(33, 204)
        MIDDLENAMELabel.Name = "MIDDLENAMELabel"
        MIDDLENAMELabel.Size = New System.Drawing.Size(82, 13)
        MIDDLENAMELabel.TabIndex = 293
        MIDDLENAMELabel.Text = "MIDDLENAME:"
        '
        'SURNAMELabel
        '
        SURNAMELabel.AutoSize = True
        SURNAMELabel.Location = New System.Drawing.Point(33, 231)
        SURNAMELabel.Name = "SURNAMELabel"
        SURNAMELabel.Size = New System.Drawing.Size(64, 13)
        SURNAMELabel.TabIndex = 295
        SURNAMELabel.Text = "SURNAME:"
        '
        'AGELabel
        '
        AGELabel.AutoSize = True
        AGELabel.Location = New System.Drawing.Point(33, 257)
        AGELabel.Name = "AGELabel"
        AGELabel.Size = New System.Drawing.Size(32, 13)
        AGELabel.TabIndex = 297
        AGELabel.Text = "AGE:"
        '
        'BIRTHDAYLabel
        '
        BIRTHDAYLabel.AutoSize = True
        BIRTHDAYLabel.Location = New System.Drawing.Point(33, 287)
        BIRTHDAYLabel.Name = "BIRTHDAYLabel"
        BIRTHDAYLabel.Size = New System.Drawing.Size(65, 13)
        BIRTHDAYLabel.TabIndex = 299
        BIRTHDAYLabel.Text = "BIRTHDAY:"
        '
        'DATE_REGISTEREDLabel
        '
        DATE_REGISTEREDLabel.AutoSize = True
        DATE_REGISTEREDLabel.Location = New System.Drawing.Point(33, 314)
        DATE_REGISTEREDLabel.Name = "DATE_REGISTEREDLabel"
        DATE_REGISTEREDLabel.Size = New System.Drawing.Size(112, 13)
        DATE_REGISTEREDLabel.TabIndex = 301
        DATE_REGISTEREDLabel.Text = "DATE REGISTERED:"
        '
        'GENDERLabel
        '
        GENDERLabel.AutoSize = True
        GENDERLabel.Location = New System.Drawing.Point(33, 343)
        GENDERLabel.Name = "GENDERLabel"
        GENDERLabel.Size = New System.Drawing.Size(56, 13)
        GENDERLabel.TabIndex = 303
        GENDERLabel.Text = "GENDER:"
        '
        'ADDRESSLabel
        '
        ADDRESSLabel.AutoSize = True
        ADDRESSLabel.Location = New System.Drawing.Point(33, 373)
        ADDRESSLabel.Name = "ADDRESSLabel"
        ADDRESSLabel.Size = New System.Drawing.Size(62, 13)
        ADDRESSLabel.TabIndex = 305
        ADDRESSLabel.Text = "ADDRESS:"
        '
        'PHONE_Label
        '
        PHONE_Label.AutoSize = True
        PHONE_Label.Location = New System.Drawing.Point(33, 403)
        PHONE_Label.Name = "PHONE_Label"
        PHONE_Label.Size = New System.Drawing.Size(55, 13)
        PHONE_Label.TabIndex = 307
        PHONE_Label.Text = "PHONE#:"
        '
        'INSURANCELabel
        '
        INSURANCELabel.AutoSize = True
        INSURANCELabel.Location = New System.Drawing.Point(33, 430)
        INSURANCELabel.Name = "INSURANCELabel"
        INSURANCELabel.Size = New System.Drawing.Size(73, 13)
        INSURANCELabel.TabIndex = 309
        INSURANCELabel.Text = "INSURANCE:"
        '
        'OCCUPATIONLabel
        '
        OCCUPATIONLabel.AutoSize = True
        OCCUPATIONLabel.Location = New System.Drawing.Point(33, 457)
        OCCUPATIONLabel.Name = "OCCUPATIONLabel"
        OCCUPATIONLabel.Size = New System.Drawing.Size(80, 13)
        OCCUPATIONLabel.TabIndex = 311
        OCCUPATIONLabel.Text = "OCCUPATION:"
        '
        'STATUSLabel
        '
        STATUSLabel.AutoSize = True
        STATUSLabel.Location = New System.Drawing.Point(33, 489)
        STATUSLabel.Name = "STATUSLabel"
        STATUSLabel.Size = New System.Drawing.Size(53, 13)
        STATUSLabel.TabIndex = 313
        STATUSLabel.Text = "STATUS:"
        '
        'DIAGNOSISLabel
        '
        DIAGNOSISLabel.AutoSize = True
        DIAGNOSISLabel.Location = New System.Drawing.Point(33, 524)
        DIAGNOSISLabel.Name = "DIAGNOSISLabel"
        DIAGNOSISLabel.Size = New System.Drawing.Size(69, 13)
        DIAGNOSISLabel.TabIndex = 315
        DIAGNOSISLabel.Text = "DIAGNOSIS:"
        '
        'TREATMENTSLabel
        '
        TREATMENTSLabel.AutoSize = True
        TREATMENTSLabel.Location = New System.Drawing.Point(26, 555)
        TREATMENTSLabel.Name = "TREATMENTSLabel"
        TREATMENTSLabel.Size = New System.Drawing.Size(156, 13)
        TREATMENTSLabel.TabIndex = 317
        TREATMENTSLabel.Text = "TREATMENTS PRESCRIBED:"
        '
        'ABOUT_HEALTH_PATIENTLabel
        '
        ABOUT_HEALTH_PATIENTLabel.AutoSize = True
        ABOUT_HEALTH_PATIENTLabel.Location = New System.Drawing.Point(29, 585)
        ABOUT_HEALTH_PATIENTLabel.Name = "ABOUT_HEALTH_PATIENTLabel"
        ABOUT_HEALTH_PATIENTLabel.Size = New System.Drawing.Size(142, 13)
        ABOUT_HEALTH_PATIENTLabel.TabIndex = 319
        ABOUT_HEALTH_PATIENTLabel.Text = "ABOUT HEALTH PATIENT:"
        '
        'PATIENTIDLabel
        '
        PATIENTIDLabel.AutoSize = True
        PATIENTIDLabel.Location = New System.Drawing.Point(976, 155)
        PATIENTIDLabel.Name = "PATIENTIDLabel"
        PATIENTIDLabel.Size = New System.Drawing.Size(67, 13)
        PATIENTIDLabel.TabIndex = 320
        PATIENTIDLabel.Text = "PATIENTID:"
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
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightCyan
        Me.Button1.Location = New System.Drawing.Point(717, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 25)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "BROWSE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Green
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(1002, 580)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(176, 61)
        Me.Button6.TabIndex = 36
        Me.Button6.Text = "VIEW  RECORDS"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1002, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 61)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "ADD NEW"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1002, 266)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(175, 61)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "SAVE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Green
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(1002, 348)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(175, 61)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "CLEAR"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Clinic_databaseDataSet
        '
        Me.Clinic_databaseDataSet.DataSetName = "clinic_databaseDataSet"
        Me.Clinic_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Green
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(1002, 499)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(176, 61)
        Me.Button8.TabIndex = 124
        Me.Button8.Text = "EDIT"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1229, 44)
        Me.Panel1.TabIndex = 125
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1172, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 23)
        Me.btnClose.TabIndex = 12
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(1141, 10)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(25, 23)
        Me.Button10.TabIndex = 9
        Me.Button10.UseVisualStyleBackColor = False
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
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Transparent
        Me.Button7.Location = New System.Drawing.Point(1110, 10)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(25, 24)
        Me.Button7.TabIndex = 37
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Green
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(1002, 422)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(175, 61)
        Me.Button9.TabIndex = 153
        Me.Button9.Text = "UPDATE"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(266, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 16)
        Me.Label3.TabIndex = 288
        Me.Label3.Text = "Mamatid Health Care Center "
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
        'PATIENTNAME
        '
        Me.PATIENTNAME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "PATIENTNAME", True))
        Me.PATIENTNAME.Location = New System.Drawing.Point(181, 176)
        Me.PATIENTNAME.Name = "PATIENTNAME"
        Me.PATIENTNAME.Size = New System.Drawing.Size(242, 20)
        Me.PATIENTNAME.TabIndex = 292
        '
        'MIDDLENAME
        '
        Me.MIDDLENAME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "MIDDLENAME", True))
        Me.MIDDLENAME.Location = New System.Drawing.Point(182, 198)
        Me.MIDDLENAME.Name = "MIDDLENAME"
        Me.MIDDLENAME.Size = New System.Drawing.Size(242, 20)
        Me.MIDDLENAME.TabIndex = 294
        '
        'SURNAME
        '
        Me.SURNAME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "SURNAME", True))
        Me.SURNAME.Location = New System.Drawing.Point(181, 224)
        Me.SURNAME.Name = "SURNAME"
        Me.SURNAME.Size = New System.Drawing.Size(242, 20)
        Me.SURNAME.TabIndex = 296
        '
        'AGE
        '
        Me.AGE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "AGE", True))
        Me.AGE.FormattingEnabled = True
        Me.AGE.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90"})
        Me.AGE.Location = New System.Drawing.Point(181, 250)
        Me.AGE.Name = "AGE"
        Me.AGE.Size = New System.Drawing.Size(242, 21)
        Me.AGE.TabIndex = 298
        Me.AGE.Text = "10"
        '
        'BIRTHDAY
        '
        Me.BIRTHDAY.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DATABindingSource, "BIRTHDAY", True))
        Me.BIRTHDAY.Location = New System.Drawing.Point(181, 279)
        Me.BIRTHDAY.Name = "BIRTHDAY"
        Me.BIRTHDAY.Size = New System.Drawing.Size(242, 20)
        Me.BIRTHDAY.TabIndex = 300
        '
        'DATEREG
        '
        Me.DATEREG.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DATABindingSource, "DATE REGISTERED", True))
        Me.DATEREG.Location = New System.Drawing.Point(181, 308)
        Me.DATEREG.Name = "DATEREG"
        Me.DATEREG.Size = New System.Drawing.Size(242, 20)
        Me.DATEREG.TabIndex = 302
        '
        'gENDER
        '
        Me.gENDER.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "GENDER", True))
        Me.gENDER.FormattingEnabled = True
        Me.gENDER.Items.AddRange(New Object() {"Male", "Female"})
        Me.gENDER.Location = New System.Drawing.Point(181, 337)
        Me.gENDER.Name = "gENDER"
        Me.gENDER.Size = New System.Drawing.Size(242, 21)
        Me.gENDER.TabIndex = 304
        Me.gENDER.Text = "Male"
        '
        'ADDRESS
        '
        Me.ADDRESS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "ADDRESS", True))
        Me.ADDRESS.Location = New System.Drawing.Point(181, 366)
        Me.ADDRESS.Name = "ADDRESS"
        Me.ADDRESS.Size = New System.Drawing.Size(242, 20)
        Me.ADDRESS.TabIndex = 306
        '
        'PHONE
        '
        Me.PHONE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "PHONE#", True))
        Me.PHONE.Location = New System.Drawing.Point(181, 395)
        Me.PHONE.Name = "PHONE"
        Me.PHONE.Size = New System.Drawing.Size(242, 20)
        Me.PHONE.TabIndex = 308
        Me.PHONE.Text = "+63"
        '
        'OCCUPATION
        '
        Me.OCCUPATION.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "OCCUPATION", True))
        Me.OCCUPATION.Location = New System.Drawing.Point(181, 451)
        Me.OCCUPATION.Name = "OCCUPATION"
        Me.OCCUPATION.Size = New System.Drawing.Size(242, 20)
        Me.OCCUPATION.TabIndex = 312
        '
        'STATUS
        '
        Me.STATUS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "STATUS", True))
        Me.STATUS.FormattingEnabled = True
        Me.STATUS.Items.AddRange(New Object() {"SINGLE", "MERRIED", "DIVORCED", "WINDOWED"})
        Me.STATUS.Location = New System.Drawing.Point(181, 483)
        Me.STATUS.Name = "STATUS"
        Me.STATUS.Size = New System.Drawing.Size(242, 21)
        Me.STATUS.TabIndex = 314
        Me.STATUS.Text = "SINGLE"
        '
        'TREATMENTSTextBox
        '
        Me.TREATMENTSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "TREATMENTS", True))
        Me.TREATMENTSTextBox.Location = New System.Drawing.Point(181, 549)
        Me.TREATMENTSTextBox.Name = "TREATMENTSTextBox"
        Me.TREATMENTSTextBox.Size = New System.Drawing.Size(242, 20)
        Me.TREATMENTSTextBox.TabIndex = 318
        '
        'ABOUTPA
        '
        Me.ABOUTPA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "ABOUT HEALTH PATIENT", True))
        Me.ABOUTPA.Location = New System.Drawing.Point(181, 580)
        Me.ABOUTPA.Name = "ABOUTPA"
        Me.ABOUTPA.Size = New System.Drawing.Size(242, 20)
        Me.ABOUTPA.TabIndex = 320
        '
        'IDHIDE
        '
        Me.IDHIDE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "PATIENTID", True))
        Me.IDHIDE.Location = New System.Drawing.Point(1049, 152)
        Me.IDHIDE.Name = "IDHIDE"
        Me.IDHIDE.Size = New System.Drawing.Size(100, 20)
        Me.IDHIDE.TabIndex = 321
        '
        'INSURANCE
        '
        Me.INSURANCE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "INSURANCE", True))
        Me.INSURANCE.FormattingEnabled = True
        Me.INSURANCE.Items.AddRange(New Object() {"NONE", "PHILHEALTH", "Pantawid Pamilyang Pilipino Program(4PS)", "MEDICARE", "MEXICARE-PREMIUM", "INSULAR LIFE ICARE", "EAST-WEST HEALTH OPTION", "Health Maintenance, lnc", "Medocare Health Systems, lnc", "Value Care Health Systems, Inc.", "Caritas Health Shield, Inc", "Asalus Corporation (Intellicare)", "(OTHER)"})
        Me.INSURANCE.Location = New System.Drawing.Point(181, 422)
        Me.INSURANCE.Name = "INSURANCE"
        Me.INSURANCE.Size = New System.Drawing.Size(242, 21)
        Me.INSURANCE.TabIndex = 323
        Me.INSURANCE.Text = "Pantawid Pamilyang Pilipino Program(4PS)"
        '
        'iduser
        '
        Me.iduser.AutoSize = True
        Me.iduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iduser.ForeColor = System.Drawing.Color.DarkRed
        Me.iduser.Location = New System.Drawing.Point(312, 136)
        Me.iduser.Name = "iduser"
        Me.iduser.Size = New System.Drawing.Size(12, 15)
        Me.iduser.TabIndex = 326
        Me.iduser.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(273, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 325
        Me.Label4.Text = "Admin:"
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Green
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.LightCyan
        Me.Button13.Location = New System.Drawing.Point(552, 402)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(82, 25)
        Me.Button13.TabIndex = 327
        Me.Button13.Text = "START"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Green
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.LightCyan
        Me.Button14.Location = New System.Drawing.Point(640, 402)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(71, 25)
        Me.Button14.TabIndex = 328
        Me.Button14.Text = "CAPTURE"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'PICTUREPictureBox
        '
        Me.PICTUREPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PICTUREPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.DATABindingSource, "PICTURE", True))
        Me.PICTUREPictureBox.Image = Global.PATIENT_INFORMATION.My.Resources.Resources.user_image_with_black_background
        Me.PICTUREPictureBox.Location = New System.Drawing.Point(552, 176)
        Me.PICTUREPictureBox.Name = "PICTUREPictureBox"
        Me.PICTUREPictureBox.Size = New System.Drawing.Size(242, 215)
        Me.PICTUREPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PICTUREPictureBox.TabIndex = 322
        Me.PICTUREPictureBox.TabStop = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.BackgroundImage = Global.PATIENT_INFORMATION.My.Resources.Resources.icons8_google_web_search_filled_50
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(1156, 143)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(40, 37)
        Me.Button12.TabIndex = 156
        Me.Button12.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PATIENT_INFORMATION.My.Resources.Resources._26733436_543181366062477_3439808344077873153_n
        Me.PictureBox1.Location = New System.Drawing.Point(131, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 155
        Me.PictureBox1.TabStop = False
        '
        'QRCODEPictureBox
        '
        Me.QRCODEPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.QRCODEPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.DATABindingSource, "QRCODE", True))
        Me.QRCODEPictureBox.Location = New System.Drawing.Point(1049, 50)
        Me.QRCODEPictureBox.Name = "QRCODEPictureBox"
        Me.QRCODEPictureBox.Size = New System.Drawing.Size(101, 96)
        Me.QRCODEPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QRCODEPictureBox.TabIndex = 329
        Me.QRCODEPictureBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(645, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 334
        Me.Label2.Text = "PICTURE"
        '
        'DIAGNOSISComboBox
        '
        Me.DIAGNOSISComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABindingSource, "DIAGNOSIS", True))
        Me.DIAGNOSISComboBox.FormattingEnabled = True
        Me.DIAGNOSISComboBox.Items.AddRange(New Object() {"Blood Donor", "Arthritis", "Diabetes", "Influenza and Pneumonia", "Osteoporosis", "Substance Abuse", "Respiratory Diseases", "Environmental Quality.", "Immunization.", "Heart disease.", "Asthma.", "Diabetes.", "Headaches.", "Depression", "Gastrointestinal problems.", "Physical Activity and Nutrition.", "Overweight and Obesity.", "Substance Abuse.", "Mental Health.", "Premature death(For Babies)."})
        Me.DIAGNOSISComboBox.Location = New System.Drawing.Point(182, 516)
        Me.DIAGNOSISComboBox.Name = "DIAGNOSISComboBox"
        Me.DIAGNOSISComboBox.Size = New System.Drawing.Size(241, 21)
        Me.DIAGNOSISComboBox.TabIndex = 335
        Me.DIAGNOSISComboBox.Text = "Influenza and Pneumonia"
        '
        'notification2
        '
        Me.notification2.AutoSize = True
        Me.notification2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.notification2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.notification2.Location = New System.Drawing.Point(769, 115)
        Me.notification2.Name = "notification2"
        Me.notification2.Size = New System.Drawing.Size(0, 20)
        Me.notification2.TabIndex = 336
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1229, 709)
        Me.Controls.Add(Me.notification2)
        Me.Controls.Add(Me.DIAGNOSISComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.QRCODEPictureBox)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.iduser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.INSURANCE)
        Me.Controls.Add(Me.PICTUREPictureBox)
        Me.Controls.Add(PATIENTIDLabel)
        Me.Controls.Add(Me.IDHIDE)
        Me.Controls.Add(PATIENTNAMELabel)
        Me.Controls.Add(Me.PATIENTNAME)
        Me.Controls.Add(MIDDLENAMELabel)
        Me.Controls.Add(Me.MIDDLENAME)
        Me.Controls.Add(SURNAMELabel)
        Me.Controls.Add(Me.SURNAME)
        Me.Controls.Add(AGELabel)
        Me.Controls.Add(Me.AGE)
        Me.Controls.Add(BIRTHDAYLabel)
        Me.Controls.Add(Me.BIRTHDAY)
        Me.Controls.Add(DATE_REGISTEREDLabel)
        Me.Controls.Add(Me.DATEREG)
        Me.Controls.Add(GENDERLabel)
        Me.Controls.Add(Me.gENDER)
        Me.Controls.Add(ADDRESSLabel)
        Me.Controls.Add(Me.ADDRESS)
        Me.Controls.Add(PHONE_Label)
        Me.Controls.Add(Me.PHONE)
        Me.Controls.Add(INSURANCELabel)
        Me.Controls.Add(OCCUPATIONLabel)
        Me.Controls.Add(Me.OCCUPATION)
        Me.Controls.Add(STATUSLabel)
        Me.Controls.Add(Me.STATUS)
        Me.Controls.Add(DIAGNOSISLabel)
        Me.Controls.Add(TREATMENTSLabel)
        Me.Controls.Add(Me.TREATMENTSTextBox)
        Me.Controls.Add(ABOUT_HEALTH_PATIENTLabel)
        Me.Controls.Add(Me.ABOUTPA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTER"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        CType(Me.Clinic_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DATABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICTUREPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRCODEPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Clinic_databaseDataSet As PATIENT_INFORMATION.clinic_databaseDataSet
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DATABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DATATableAdapter As PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.DATATableAdapter
    Friend WithEvents TableAdapterManager As PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PATIENTNAME As System.Windows.Forms.TextBox
    Friend WithEvents MIDDLENAME As System.Windows.Forms.TextBox
    Friend WithEvents SURNAME As System.Windows.Forms.TextBox
    Friend WithEvents AGE As System.Windows.Forms.ComboBox
    Friend WithEvents BIRTHDAY As System.Windows.Forms.DateTimePicker
    Friend WithEvents DATEREG As System.Windows.Forms.DateTimePicker
    Friend WithEvents gENDER As System.Windows.Forms.ComboBox
    Friend WithEvents ADDRESS As System.Windows.Forms.TextBox
    Friend WithEvents PHONE As System.Windows.Forms.TextBox
    Friend WithEvents OCCUPATION As System.Windows.Forms.TextBox
    Friend WithEvents STATUS As System.Windows.Forms.ComboBox
    Friend WithEvents TREATMENTSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ABOUTPA As System.Windows.Forms.TextBox
    Friend WithEvents IDHIDE As System.Windows.Forms.TextBox
    Friend WithEvents PICTUREPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents INSURANCE As System.Windows.Forms.ComboBox
    Friend WithEvents iduser As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents QRCODEPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DIAGNOSISComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents notification2 As System.Windows.Forms.Label
End Class
