<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class requestpassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(requestpassword))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Clinic_databaseDataSet = New PATIENT_INFORMATION.clinic_databaseDataSet()
        Me.PASSTABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PASSTABLETableAdapter = New PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.PASSTABLETableAdapter()
        Me.TableAdapterManager = New PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.TableAdapterManager()
        Me.LOGINTextBox = New System.Windows.Forms.TextBox()
        Me.PASSWORDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        LOGINLabel = New System.Windows.Forms.Label()
        PASSWORDLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clinic_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PASSTABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LOGINLabel
        '
        LOGINLabel.AutoSize = True
        LOGINLabel.Location = New System.Drawing.Point(102, 101)
        LOGINLabel.Name = "LOGINLabel"
        LOGINLabel.Size = New System.Drawing.Size(43, 13)
        LOGINLabel.TabIndex = 15
        LOGINLabel.Text = "LOGIN:"
        '
        'PASSWORDLabel
        '
        PASSWORDLabel.AutoSize = True
        PASSWORDLabel.Location = New System.Drawing.Point(102, 127)
        PASSWORDLabel.Name = "PASSWORDLabel"
        PASSWORDLabel.Size = New System.Drawing.Size(73, 13)
        PASSWORDLabel.TabIndex = 17
        PASSWORDLabel.Text = "PASSWORD:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(-3, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 25)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 24)
        Me.Button1.TabIndex = 15
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(286, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 23)
        Me.btnClose.TabIndex = 14
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(-619, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 24)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(-771, 79)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 24)
        Me.Button3.TabIndex = 13
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
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
        'LOGINTextBox
        '
        Me.LOGINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PASSTABLEBindingSource, "LOGIN", True))
        Me.LOGINTextBox.Location = New System.Drawing.Point(178, 98)
        Me.LOGINTextBox.Name = "LOGINTextBox"
        Me.LOGINTextBox.Size = New System.Drawing.Size(103, 20)
        Me.LOGINTextBox.TabIndex = 16
        Me.LOGINTextBox.Text = "Username"
        '
        'PASSWORDTextBox
        '
        Me.PASSWORDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PASSTABLEBindingSource, "PASSWORD", True))
        Me.PASSWORDTextBox.Location = New System.Drawing.Point(178, 124)
        Me.PASSWORDTextBox.Name = "PASSWORDTextBox"
        Me.PASSWORDTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PASSWORDTextBox.Size = New System.Drawing.Size(103, 20)
        Me.PASSWORDTextBox.TabIndex = 18
        Me.PASSWORDTextBox.Text = "xhcbqqwsdkjasd"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "To continue,Type an Any Administration Password"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(129, 160)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'requestpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(311, 216)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(LOGINLabel)
        Me.Controls.Add(Me.LOGINTextBox)
        Me.Controls.Add(PASSWORDLabel)
        Me.Controls.Add(Me.PASSWORDTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "requestpassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "requestpassword"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clinic_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PASSTABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Clinic_databaseDataSet As PATIENT_INFORMATION.clinic_databaseDataSet
    Friend WithEvents PASSTABLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PASSTABLETableAdapter As PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.PASSTABLETableAdapter
    Friend WithEvents TableAdapterManager As PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LOGINTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PASSWORDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
