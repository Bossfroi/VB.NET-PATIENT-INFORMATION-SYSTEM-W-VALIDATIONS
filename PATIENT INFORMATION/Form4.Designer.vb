<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form4))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.A = New System.Windows.Forms.TextBox()
        Me.PASSTABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Clinic_databaseDataSet = New PATIENT_INFORMATION.clinic_databaseDataSet()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GUEST = New System.Windows.Forms.Label()
        Me.UPDATEGUEST = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ADMIN1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.C = New System.Windows.Forms.TextBox()
        Me.GUESTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GUESTDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSTABLEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSTABLETableAdapter = New PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.PASSTABLETableAdapter()
        Me.TableAdapterManager = New PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.TableAdapterManager()
        Me.GUESTTableAdapter = New PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.GUESTTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.PASSTABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clinic_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GUESTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GUESTDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PASSTABLEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.A)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 54)
        Me.Panel1.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(168, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 21)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "List Records of Administration|GuestUsers"
        '
        'A
        '
        Me.A.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.A.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.A.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PASSTABLEBindingSource, "LOGIN", True))
        Me.A.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.A.Location = New System.Drawing.Point(571, 36)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(10, 13)
        Me.A.TabIndex = 58
        '
        'PASSTABLEBindingSource
        '
        Me.PASSTABLEBindingSource.DataMember = "PASSTABLE"
        Me.PASSTABLEBindingSource.DataSource = Me.Clinic_databaseDataSet
        '
        'Clinic_databaseDataSet
        '
        Me.Clinic_databaseDataSet.DataSetName = "clinic_databaseDataSet"
        Me.Clinic_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(641, 14)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 23)
        Me.btnClose.TabIndex = 12
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
        Me.Button2.Location = New System.Drawing.Point(12, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 24)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.DarkGreen
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.FlatAppearance.BorderSize = 0
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Location = New System.Drawing.Point(386, 163)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(134, 62)
        Me.cmdSave.TabIndex = 22
        Me.cmdSave.Text = "DELETE"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GUEST)
        Me.GroupBox1.Controls.Add(Me.UPDATEGUEST)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.ADMIN1)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GUESTDataGridView)
        Me.GroupBox1.Controls.Add(Me.PASSTABLEDataGridView)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 505)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VIEW LIST"
        '
        'GUEST
        '
        Me.GUEST.AutoSize = True
        Me.GUEST.Location = New System.Drawing.Point(444, 86)
        Me.GUEST.Name = "GUEST"
        Me.GUEST.Size = New System.Drawing.Size(14, 15)
        Me.GUEST.TabIndex = 57
        Me.GUEST.Text = "0"
        '
        'UPDATEGUEST
        '
        Me.UPDATEGUEST.BackColor = System.Drawing.Color.DarkGreen
        Me.UPDATEGUEST.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UPDATEGUEST.FlatAppearance.BorderSize = 0
        Me.UPDATEGUEST.ForeColor = System.Drawing.Color.White
        Me.UPDATEGUEST.Location = New System.Drawing.Point(389, 309)
        Me.UPDATEGUEST.Name = "UPDATEGUEST"
        Me.UPDATEGUEST.Size = New System.Drawing.Size(133, 65)
        Me.UPDATEGUEST.TabIndex = 52
        Me.UPDATEGUEST.Text = "CHANGE GUEST PASSWORD"
        Me.UPDATEGUEST.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(377, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 15)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "TOTAL OF GUEST USER"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkGreen
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(388, 380)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(134, 60)
        Me.Button5.TabIndex = 53
        Me.Button5.Text = "DELETE"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ADMIN1
        '
        Me.ADMIN1.AutoSize = True
        Me.ADMIN1.Location = New System.Drawing.Point(444, 33)
        Me.ADMIN1.Name = "ADMIN1"
        Me.ADMIN1.Size = New System.Drawing.Size(14, 15)
        Me.ADMIN1.TabIndex = 55
        Me.ADMIN1.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.C)
        Me.Panel2.Location = New System.Drawing.Point(-19, 248)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(723, 10)
        Me.Panel2.TabIndex = 51
        '
        'C
        '
        Me.C.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.C.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GUESTBindingSource, "USERNAME", True))
        Me.C.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.C.Location = New System.Drawing.Point(600, -5)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(100, 15)
        Me.C.TabIndex = 55
        '
        'GUESTBindingSource
        '
        Me.GUESTBindingSource.DataMember = "GUEST"
        Me.GUESTBindingSource.DataSource = Me.Clinic_databaseDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(138, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "GUEST USERS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(390, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 15)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "TOTAL OF ADMINS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(122, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "ADMINISTRATION"
        '
        'GUESTDataGridView
        '
        Me.GUESTDataGridView.AutoGenerateColumns = False
        Me.GUESTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GUESTDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.GUESTDataGridView.DataSource = Me.GUESTBindingSource
        Me.GUESTDataGridView.Location = New System.Drawing.Point(18, 285)
        Me.GUESTDataGridView.Name = "GUESTDataGridView"
        Me.GUESTDataGridView.Size = New System.Drawing.Size(344, 200)
        Me.GUESTDataGridView.TabIndex = 48
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "USERNAME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "USERNAME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PASSWORD"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PASSWORD"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'PASSTABLEDataGridView
        '
        Me.PASSTABLEDataGridView.AutoGenerateColumns = False
        Me.PASSTABLEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PASSTABLEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.PASSTABLEDataGridView.DataSource = Me.PASSTABLEBindingSource
        Me.PASSTABLEDataGridView.Location = New System.Drawing.Point(16, 49)
        Me.PASSTABLEDataGridView.Name = "PASSTABLEDataGridView"
        Me.PASSTABLEDataGridView.Size = New System.Drawing.Size(346, 192)
        Me.PASSTABLEDataGridView.TabIndex = 48
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "LOGIN"
        Me.DataGridViewTextBoxColumn1.HeaderText = "USERNAME"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 350
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
        'GUESTTableAdapter
        '
        Me.GUESTTableAdapter.ClearBeforeFill = True
        '
        'form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(678, 591)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PASSTABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clinic_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GUESTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GUESTDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PASSTABLEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Clinic_databaseDataSet As PATIENT_INFORMATION.clinic_databaseDataSet
    Friend WithEvents PASSTABLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PASSTABLETableAdapter As PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.PASSTABLETableAdapter
    Friend WithEvents TableAdapterManager As PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PASSTABLEDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GUESTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GUESTTableAdapter As PATIENT_INFORMATION.clinic_databaseDataSetTableAdapters.GUESTTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GUESTDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents A As System.Windows.Forms.TextBox
    Friend WithEvents C As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents UPDATEGUEST As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GUEST As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ADMIN1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
