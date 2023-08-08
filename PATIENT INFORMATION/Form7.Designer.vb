<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim LOGINLabel As System.Windows.Forms.Label
        Dim PASSWORDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Clinic_databaseDataSet = New PATIENT_INFORMATION.clinic_databaseDataSet()
        Me.PASSTABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PASSTABLETableAdapter = New PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.PASSTABLETableAdapter()
        Me.TableAdapterManager = New PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LOGINTextBox = New System.Windows.Forms.TextBox()
        Me.PASSWORDTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userlevel = New System.Windows.Forms.ComboBox()
        Me.iduser = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PASS2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        LOGINLabel = New System.Windows.Forms.Label()
        PASSWORDLabel = New System.Windows.Forms.Label()
        CType(Me.Clinic_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PASSTABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LOGINLabel
        '
        LOGINLabel.AutoSize = True
        LOGINLabel.Location = New System.Drawing.Point(161, 185)
        LOGINLabel.Name = "LOGINLabel"
        LOGINLabel.Size = New System.Drawing.Size(71, 13)
        LOGINLabel.TabIndex = 290
        LOGINLabel.Text = "USERNAME:"
        '
        'PASSWORDLabel
        '
        PASSWORDLabel.AutoSize = True
        PASSWORDLabel.Location = New System.Drawing.Point(161, 209)
        PASSWORDLabel.Name = "PASSWORDLabel"
        PASSWORDLabel.Size = New System.Drawing.Size(73, 13)
        PASSWORDLabel.TabIndex = 292
        PASSWORDLabel.Text = "PASSWORD:"
        '
        'Clinic_databaseDataSet
        '
        Me.Clinic_databaseDataSet.DataSetName = "clinic_databaseDataSet"
        Me.Clinic_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PASSTABLEBindingSource
        '
        Me.PASSTABLEBindingSource.DataMember = "PASSTABLE"
        Me.PASSTABLEBindingSource.DataSource = Me.Clinic_databaseDataSet
        '
        'PASSTABLETableAdapter
        '
        Me.PASSTABLETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DATATableAdapter = Nothing
        Me.TableAdapterManager.GUESTTableAdapter = Nothing
        Me.TableAdapterManager.PASSTABLETableAdapter = Me.PASSTABLETableAdapter
        Me.TableAdapterManager.UpdateOrder = PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 25)
        Me.Label1.TabIndex = 297
        Me.Label1.Text = "Create a Administrative Account"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PATIENT_INFORMATION.My.Resources.Resources._26733436_543181366062477_3439808344077873153_n
        Me.PictureBox1.Location = New System.Drawing.Point(43, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 296
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 40)
        Me.Panel1.TabIndex = 295
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(523, 12)
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
        Me.Button10.Location = New System.Drawing.Point(492, 12)
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
        Me.Button11.Location = New System.Drawing.Point(12, 11)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(25, 24)
        Me.Button11.TabIndex = 7
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(177, 279)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(233, 37)
        Me.Button3.TabIndex = 294
        Me.Button3.Text = "CREATE ADMIN USER"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'LOGINTextBox
        '
        Me.LOGINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PASSTABLEBindingSource, "LOGIN", True))
        Me.LOGINTextBox.Location = New System.Drawing.Point(237, 182)
        Me.LOGINTextBox.Name = "LOGINTextBox"
        Me.LOGINTextBox.Size = New System.Drawing.Size(160, 20)
        Me.LOGINTextBox.TabIndex = 291
        '
        'PASSWORDTextBox
        '
        Me.PASSWORDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PASSTABLEBindingSource, "PASSWORD", True))
        Me.PASSWORDTextBox.Location = New System.Drawing.Point(237, 205)
        Me.PASSWORDTextBox.Name = "PASSWORDTextBox"
        Me.PASSWORDTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PASSWORDTextBox.Size = New System.Drawing.Size(160, 20)
        Me.PASSWORDTextBox.TabIndex = 293
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(206, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 16)
        Me.Label3.TabIndex = 298
        Me.Label3.Text = "Mamatid Health Care Center "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 300
        Me.Label2.Text = "USER TYPE:"
        '
        'userlevel
        '
        Me.userlevel.FormattingEnabled = True
        Me.userlevel.Items.AddRange(New Object() {"ADMIN", "GUEST"})
        Me.userlevel.Location = New System.Drawing.Point(15, 337)
        Me.userlevel.Name = "userlevel"
        Me.userlevel.Size = New System.Drawing.Size(82, 21)
        Me.userlevel.TabIndex = 299
        Me.userlevel.Text = "ADMIN"
        '
        'iduser
        '
        Me.iduser.AutoSize = True
        Me.iduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iduser.ForeColor = System.Drawing.Color.DarkRed
        Me.iduser.Location = New System.Drawing.Point(317, 129)
        Me.iduser.Name = "iduser"
        Me.iduser.Size = New System.Drawing.Size(12, 15)
        Me.iduser.TabIndex = 328
        Me.iduser.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(234, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 327
        Me.Label4.Text = "Creator/Admin:"
        '
        'PASS2
        '
        Me.PASS2.Location = New System.Drawing.Point(238, 253)
        Me.PASS2.Name = "PASS2"
        Me.PASS2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PASS2.Size = New System.Drawing.Size(159, 20)
        Me.PASS2.TabIndex = 329
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(245, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 13)
        Me.Label5.TabIndex = 330
        Me.Label5.Text = "RETYPE YOUR PASSWORD"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(560, 370)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PASS2)
        Me.Controls.Add(Me.iduser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.userlevel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(LOGINLabel)
        Me.Controls.Add(Me.LOGINTextBox)
        Me.Controls.Add(PASSWORDLabel)
        Me.Controls.Add(Me.PASSWORDTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        CType(Me.Clinic_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PASSTABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Clinic_databaseDataSet As PATIENT_INFORMATION.clinic_databaseDataSet
    Friend WithEvents PASSTABLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PASSTABLETableAdapter As PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.PASSTABLETableAdapter
    Friend WithEvents TableAdapterManager As PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents LOGINTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PASSWORDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents userlevel As System.Windows.Forms.ComboBox
    Friend WithEvents iduser As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PASS2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
