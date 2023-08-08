Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Object
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Form3
    Dim HOST As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Clinic Database;Integrated Security=True")
    Dim open As New OpenFileDialog
    Public Touchless As New TouchlessLib.TouchlessMgr
    Public Camera1 As TouchlessLib.Camera = Touchless.Cameras.ElementAt(0)
    Dim generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim PROID As String
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iduser.Text = Form1.LOGINTextBox.Text
        search.Enabled = False
        graph()
        IDHIDE.Enabled = False
        PATIENNAME.Enabled = False
        MIDDLENAME.Enabled = False
        SURNAME.Enabled = False
        AGE.Enabled = False
        BIRTHDAY.Enabled = False
        DATEREG.Enabled = False
        ADDRESS.Enabled = False
        PHONE.Enabled = False
        INSURANCE.Enabled = False
        OCCUPATION.Enabled = False
        STATUS.Enabled = False
        ABOUTPA.Enabled = False
        GENDER.Enabled = False
        DIAGNOSISComboBox.Enabled = False
        TREATMENTSTextBox.Enabled = False
        '---------------------------------'
    End Sub

    Private Sub FillBysurnameToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.DATATableAdapter.FillBy(Me.Clinic_databaseDataSet.DATA, search.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Form2.Show()
    End Sub


    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESS.Click
        Me.Close()
        refreshform3.Show()
        search.Enabled = False
        IDHIDE.Enabled = False
        PATIENNAME.Enabled = False
        MIDDLENAME.Enabled = False
        SURNAME.Enabled = False
        AGE.Enabled = False
        BIRTHDAY.Enabled = False
        DATEREG.Enabled = False
        ADDRESS.Enabled = False
        PHONE.Enabled = False
        INSURANCE.Enabled = False
        OCCUPATION.Enabled = False
        STATUS.Enabled = False
        ABOUTPA.Enabled = False
        GENDER.Enabled = False
        Refresh()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()
        Form5.combosearch.Text = "ID"
        Form5.SEARCH.Text = IDHIDE.Text
        Form5.SEARCBTN.PerformClick()








    End Sub




    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        search.Text = ""
        search.Enabled = True
        search.BackColor = Color.White
        DATATableAdapter.Fill(Me.Clinic_databaseDataSet.DATA)
        Refresh()
    End Sub



    Private Sub search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.TextChanged
       
    
        If combosearch.SelectedItem = "SURNAME" Then
            DATATableAdapter.FillBy(Me.Clinic_databaseDataSet.DATA, search.Text.ToString)

        ElseIf combosearch.SelectedItem = "NAME" Then
            DATATableAdapter.FillBy1(Me.Clinic_databaseDataSet.DATA, search.Text.ToString)

        ElseIf combosearch.SelectedItem = "PHONE#" Then
            DATATableAdapter.FillBy2(Me.Clinic_databaseDataSet.DATA, search.Text.ToString)

        ElseIf combosearch.SelectedItem = "DIAGNOSIS" Then
            DATATableAdapter.FillBy3(Me.Clinic_databaseDataSet.DATA, search.Text.ToString)

        ElseIf combosearch.SelectedItem = "INSURANCES" Then
            DATATableAdapter.FillBy4(Me.Clinic_databaseDataSet.DATA, search.Text.ToString)

        ElseIf combosearch.SelectedItem = "ADDRESS" Then
            DATATableAdapter.FillBy5(Me.Clinic_databaseDataSet.DATA, search.Text.ToString)


        End If
    End Sub

    Private Sub PICTURELabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Timer1.Enabled = False
        Me.Close()
        Form6.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        IDHIDE.Enabled = False
        PATIENNAME.Enabled = True
        MIDDLENAME.Enabled = True
        SURNAME.Enabled = True
        AGE.Enabled = True
        BIRTHDAY.Enabled = True
        DATEREG.Enabled = True
        ADDRESS.Enabled = True
        PHONE.Enabled = True
        INSURANCE.Enabled = True
        OCCUPATION.Enabled = True
        STATUS.Enabled = True
        ABOUTPA.Enabled = True
        GENDER.Enabled = True
        TREATMENTSTextBox.Enabled = True
        DIAGNOSISComboBox.Enabled = True

        MetroFramework.MetroMessageBox.Show(Me, "CHOOSE THE PATIENT YOU WANT TO EDIT OR DELETE", "EDIT MODE", MessageBoxButtons.OKCancel)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        QRCODEPictureBox.Image = generator.Encode(IDHIDE.Text)
        BIRTHDAY.Format = DateTimePickerFormat.Custom

        BIRTHDAY.CustomFormat = ("                 yyyy-MM-dd")

        DATEREG.Format = DateTimePickerFormat.Custom

        DATEREG.CustomFormat = ("                 yyyy-MM-dd")
        Dim QR As New MemoryStream
        Dim PROFILEPIC As New MemoryStream

        Dim froiupdate As New SqlCommand("UPDATE DATA SET PATIENTNAME = @PATIENTNAME ,MIDDLENAME = @MIDDLENAME ,SURNAME = @SURNAME,AGE = @AGE ,BIRTHDAY = @BIRTHDAY,[DATE REGISTERED] = @DATE_REGISTERED ,GENDER = @GENDER,ADDRESS = @ADDRESS ,PHONE# = @PHONE#,INSURANCE = @INSURANCE,OCCUPATION = @OCCUPATION,STATUS = @STATUS,DIAGNOSIS = @DIAGNOSIS,TREATMENTS = @TREATMENTS,[ABOUT HEALTH PATIENT] = @ABOUT_HEALTH_PATIENT ,PICTURE = @PICTURE ,QRCODE = @QRCODE WHERE PATIENTID = @PATIENTID", host)

        froiupdate.Parameters.AddWithValue("@PATIENTNAME", PATIENNAME.Text)

        froiupdate.Parameters.AddWithValue("@MIDDLENAME", MIDDLENAME.Text)

        froiupdate.Parameters.AddWithValue("@SURNAME", SURNAME.Text)

        froiupdate.Parameters.AddWithValue("@AGE", AGE.Text)

        froiupdate.Parameters.AddWithValue("@BIRTHDAY", BIRTHDAY.Text)

        froiupdate.Parameters.AddWithValue("@DATE_REGISTERED", DATEREG.Text)

        froiupdate.Parameters.AddWithValue("@GENDER", GENDER.Text)

        froiupdate.Parameters.AddWithValue("@ADDRESS", ADDRESS.Text)

        froiupdate.Parameters.AddWithValue("@PHONE#", PHONE.Text)

        froiupdate.Parameters.AddWithValue("@INSURANCE", INSURANCE.Text)
        froiupdate.Parameters.AddWithValue("@OCCUPATION", OCCUPATION.Text)
        froiupdate.Parameters.AddWithValue("@STATUS", STATUS.Text)
        froiupdate.Parameters.AddWithValue("@ABOUT_HEALTH_PATIENT", SqlDbType.Text).Value = ABOUTPA.Text
        froiupdate.Parameters.AddWithValue("@PATIENTID", IDHIDE.Text)
        froiupdate.Parameters.AddWithValue("@DIAGNOSIS", DIAGNOSISComboBox.Text + ":Edited By:" + Form1.LOGINTextBox.Text)
        froiupdate.Parameters.AddWithValue("@TREATMENTS", TREATMENTSTextBox.Text)

        '---------------------------------------------------------------------'
        'PICTURE'
        PICTUREPictureBox.Image.Save(PROFILEPIC, Imaging.ImageFormat.Bmp)
        froiupdate.Parameters.Add("@PICTURE", SqlDbType.Image).Value = PROFILEPIC.ToArray
        '---------------------------------------------------------------------'
        'QR'
        QRCODEPictureBox.Image.Save(QR, Imaging.ImageFormat.Bmp)
        froiupdate.Parameters.Add("@QRCODE", SqlDbType.Image).Value = QR.ToArray

    
        host.Open()
        Try
            If Len(Trim(PATIENNAME.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT NAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PATIENNAME.Focus()

            ElseIf Len(Trim(MIDDLENAME.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT SURNAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MIDDLENAME.Focus()

            ElseIf Len(Trim(SURNAME.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT LASTNAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SURNAME.Focus()

            ElseIf Len(Trim(AGE.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT AGE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                AGE.Focus()

            ElseIf Len(Trim(BIRTHDAY.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT BIRTHDAY", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BIRTHDAY.Focus()

            ElseIf Len(Trim(DATEREG.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT REGISTERED DATE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DATEREG.Focus()

            ElseIf Len(Trim(GENDER.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT GENDER", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GENDER.Focus()
            ElseIf Len(Trim(ADDRESS.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT ADDRESS", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ADDRESS.Focus()
            ElseIf Len(Trim(OCCUPATION.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT OCCUPATION", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                OCCUPATION.Focus()

            ElseIf Len(Trim(STATUS.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT STATUS", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                STATUS.Focus()

            ElseIf Len(Trim(PHONE.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT PHONE NUMBER", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PHONE.Focus()
            ElseIf Len(Trim(INSURANCE.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT INSURANCE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                INSURANCE.Focus()
            ElseIf Len(Trim(ABOUTPA.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL HEALTH PATIENT INFORMATION", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ABOUTPA.Focus()

            ElseIf Len(Trim(PICTUREPictureBox.CanSelect)) = 1 Then
                MetroFramework.MetroMessageBox.Show(Me, "CHOOSE PICTURE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PICTUREPictureBox.Focus()
            ElseIf Len(Trim(INSURANCE.CanSelect)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "CHOOSE PICTURE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                INSURANCE.Focus()
            ElseIf Len(Trim(TREATMENTSTextBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT TREATMENTS NOR SET NONE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                INSURANCE.Focus()
            ElseIf Len(Trim(DIAGNOSISComboBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT DIAGNOSIS NOR SET NONE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                INSURANCE.Focus()
            ElseIf froiupdate.ExecuteNonQuery() > 0 Then
                PATIENNAME.Enabled = False
                MIDDLENAME.Enabled = False
                SURNAME.Enabled = False
                AGE.Enabled = False
                BIRTHDAY.Enabled = False
                DATEREG.Enabled = False
                GENDER.Enabled = False
                ADDRESS.Enabled = False
                PHONE.Enabled = False
                INSURANCE.Enabled = False
                OCCUPATION.Enabled = False
                STATUS.Enabled = False
                ABOUTPA.Enabled = False
                IDHIDE.Enabled = False
                DIAGNOSISComboBox.Enabled = False
                TREATMENTSTextBox.Enabled = False
                MessageBox.Show(" Patient Info Was UPDATED Successfully", "Registration Report", MessageBoxButtons.OK)
            ElseIf MetroFramework.MetroMessageBox.Show(Me, "PLEASE GO TO PATIENT REGISTRATION FOR A NEW RECORDS", "ERROR Report", MessageBoxButtons.OK, MessageBoxIcon.Error) Then

            End If

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

        host.Close()
        Timer1.Enabled = False
        Me.DATATableAdapter.Fill(Me.Clinic_databaseDataSet.DATA)
        Me.Refresh()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim WHY As MsgBoxResult = MsgBox("Would you delete a Record of Patient", MsgBoxStyle.YesNoCancel)
        If IDHIDE.Text = "" Then
            MessageBox.Show("To delete An Records Make sure you click the Refresh button to find you Want to Delete", "INFORMATION", MessageBoxButtons.OK)

        elseif WHY = MsgBoxResult.Yes Then
        DeleteRecordspass.Show()
        End If
        graph()
    End Sub

    Public Sub DELexecutequery(ByVal query As String)

        Dim comand2 As New SqlCommand(query, host)
        host.Open()
        If IDHIDE.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " Please choose a number you want to delete", "DELETE", MessageBoxButtons.OKCancel)
        ElseIf comand2.ExecuteNonQuery() > 0 Then
            Me.DATATableAdapter.Fill(Me.Clinic_databaseDataSet.DATA)
            MetroFramework.MetroMessageBox.Show(Me, " Patient ID Info Was Deleted Successfully  ", "DELETE FILE", MessageBoxButtons.OK)
        ElseIf MessageBox.Show(" Please choose a valid ID File", "ERROR", MessageBoxButtons.AbortRetryIgnore) Then
        End If
        host.Close()

    End Sub

    Private Sub DATADataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        refreshform3.Show()
        search.Enabled = False
        IDHIDE.Enabled = False
        PATIENNAME.Enabled = False
        MIDDLENAME.Enabled = False
        SURNAME.Enabled = False
        AGE.Enabled = False
        BIRTHDAY.Enabled = False
        DATEREG.Enabled = False
        ADDRESS.Enabled = False
        PHONE.Enabled = False
        INSURANCE.Enabled = False
        OCCUPATION.Enabled = False
        STATUS.Enabled = False
        ABOUTPA.Enabled = False
        GENDER.Enabled = False
        Refresh()
        MIDDLENAME.Clear()
        SURNAME.Clear()
        AGE.Text = ""
        BIRTHDAY.Text = ""
        DATEREG.Text = ""
        GENDER.Text = ""
        ADDRESS.Text = ""
        PHONE.Text = ""
        INSURANCE.Text = ""
        OCCUPATION.Text = ""
        STATUS.Text = ""
        ABOUTPA.Text = ""
        IDHIDE.Text = ""
        PICTUREPictureBox.Dispose()
        DIAGNOSISComboBox.Text = ""

        Me.DATATableAdapter.Fill(Me.Clinic_databaseDataSet.DATA)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        open.Filter = "image files (*.jpg; *.bmp;*.png ;*.jpeg;*.gif;*.ico)|*.jpg; *.bmp;*.png ;*.jpeg;*.gif;*.ico"

        If open.ShowDialog = Windows.Forms.DialogResult.OK Then

            PICTUREPictureBox.Image = Image.FromFile(open.FileName)
        End If

    End Sub

    Private Sub AGE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AGE.KeyPress
        If Not IsNumeric(AGE.Text.ToString) Then
            MsgBox("Please enter numbers only.", vbInformation)
        ElseIf AGE.Text.Length >= 3 Then
            e.Handled = True
        ElseIf e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub PHONE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PHONE.KeyPress
        If Asc(e.KeyChar) <> 12 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then

            MessageBox.Show("Only numbers")
            e.Handled = True
        End If
        If PHONE.Text.Length >= 13 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub DATABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DATABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Clinic_databaseDataSet)

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If Form2.IsHandleCreated Then
            Me.Close()
            refresh_1.Show()
        ElseIf Form6.Handle Then
            Me.Hide()
            Form6.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Touchless.CurrentCamera = Camera1
        Touchless.CurrentCamera.CaptureHeight = 1080
        Touchless.CurrentCamera.CaptureWidth = 720

        PICTUREPictureBox.Image = Touchless.CurrentCamera.GetCurrentImage

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click

        Touchless.CurrentCamera = Camera1
        Touchless.CurrentCamera.CaptureHeight = 1080
        Touchless.CurrentCamera.CaptureWidth = 720
        PICTUREPictureBox.Image = Touchless.CurrentCamera.GetCurrentImage
        Timer1.Enabled = False
    End Sub


 
   

    Private Sub DATADataGridView_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DATADataGridView.CellContentClick
      

    End Sub

    Private Sub QRCODEPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        QRCODEPictureBox.Image = generator.Encode("Surname:" + SURNAME.Text + ")(Name:" + PATIENNAME.Text + ")(Date registration Verification:" + DATEREG.Text + ")" + "MamatidClinicDatabase:VERIFICATIONCODE")
    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Private Sub graph()
        Dim sql As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        Try
            host.Open()
            sql = "Select count(*) as count_var from data"
            cmd = New SqlCommand(sql, host)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If (dr.Read.ToString) = True Then
                Dim ID As Integer
                ID = (dr(0))
                PROID = ID.ToString("0")

            ElseIf IsDBNull(dr) Then
                PROID = ("0")
            Else
                PROID = ("0")
            End If

        Catch ex As Exception
        Finally

            host.Close()

        End Try
        Refresh()
        Label6.Text = proid
    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub notification3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles notification3.Click
        chattingform.Show()
    End Sub
End Class

