Imports System.Data.SqlClient
Imports System.IO.FileStream
Imports System.Text.RegularExpressions
Imports System.IO


Public Class Form2
        Dim HOST As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Clinic Database;Integrated Security=True")
    Dim open As New OpenFileDialog
    Dim PROID As String
    Public Touchless As New TouchlessLib.TouchlessMgr
    Public Camera1 As TouchlessLib.Camera = Touchless.Cameras.ElementAt(0)
    Dim generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder



    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GETID()
        iduser.Text = Form1.LOGINTextBox.Text
        PATIENTNAME.Enabled = False
        MIDDLENAME.Enabled = False
        SURNAME.Enabled = False
        AGE.Enabled = False
        BIRTHDAY.Enabled = False
        DATEREG.Enabled = False
        gENDER.Enabled = False
        ADDRESS.Enabled = False
        PHONE.Enabled = False
        INSURANCE.Enabled = False
        OCCUPATION.Enabled = False
        STATUS.Enabled = False
        ABOUTPA.Enabled = False
        IDHIDE.Enabled = False
        DIAGNOSISComboBox.Enabled = False
        TREATMENTSTextBox.Enabled = False
        '----------------------------------'
        PATIENTNAME.Text.ToUpper.ToString()
        SURNAME.Text.ToUpper.ToString()
        MIDDLENAME.Text.ToUpper.ToString()
    End Sub
    Private Sub GETID()
        Dim sql As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        Try
            host.Open()
            sql = "select PATIENTID from DATA order by PATIENTID Desc"
            cmd = New SqlCommand(sql, host)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If (dr.Read.ToString) = True Then
                Dim ID As Integer
                ID = (dr(0) + 43)
                PROID = ID.ToString("00000")

            ElseIf IsDBNull(dr) Then
                PROID = ("00000")
            Else
                PROID = ("00000")
            End If

        Catch ex As Exception
        Finally

            host.Close()

        End Try
        Refresh()
        IDHIDE.Text = PROID


    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        open.Filter = "image files (*.jpg; *.bmp;*.png ;*.jpeg;*.gif;*.ico)|*.jpg; *.bmp;*.png ;*.jpeg;*.gif;*.ico"

        If open.ShowDialog = Windows.Forms.DialogResult.OK Then

            PICTUREPictureBox.Image = Image.FromFile(open.FileName)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
        refresh_1.Show()
        PATIENTNAME.Clear()
        MIDDLENAME.Clear()
        SURNAME.Clear()
        AGE.Text = ""
        BIRTHDAY.Text = ""
        DATEREG.Text = ""
        gENDER.Text = ""
        ADDRESS.Text = ""
        PHONE.Text = ""
        INSURANCE.Text = ""
        OCCUPATION.Text = ""
        STATUS.Text = ""
        ABOUTPA.Text = ""
        IDHIDE.Text = ""
        PICTUREPictureBox.Dispose()
        DIAGNOSISComboBox.Text = ""
        PATIENTNAME.Enabled = False
        MIDDLENAME.Enabled = False
        SURNAME.Enabled = False
        AGE.Enabled = False
        BIRTHDAY.Enabled = False
        DATEREG.Enabled = False
        gENDER.Enabled = False
        ADDRESS.Enabled = False
        PHONE.Enabled = False
        INSURANCE.Enabled = False
        OCCUPATION.Enabled = False
        STATUS.Enabled = False
        ABOUTPA.Enabled = False
        IDHIDE.Enabled = False

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Form3.Show()
        Timer1.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        form4.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PATIENTNAME.Enabled = True
        MIDDLENAME.Enabled = True
        SURNAME.Enabled = True
        AGE.Enabled = True
        BIRTHDAY.Enabled = True
        DATEREG.Enabled = True
        gENDER.Enabled = True
        ADDRESS.Enabled = True
        PHONE.Enabled = True
        INSURANCE.Enabled = True
        OCCUPATION.Enabled = True
        STATUS.Enabled = True
        ABOUTPA.Enabled = True
        IDHIDE.Enabled = False
        DIAGNOSISComboBox.Enabled = True
        TREATMENTSTextBox.Enabled = True

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        QRCODEPictureBox.Image = generator.Encode(IDHIDE.Text)
        Dim result As Integer = MessageBox.Show("Are you sure to Approve this Client", "Patient Information System Approval", MessageBoxButtons.YesNoCancel)
        Dim QR As New MemoryStream
        Dim PROFILEPIC As New MemoryStream
        '-------------------------------------------------------------------'
        BIRTHDAY.Format = DateTimePickerFormat.Custom

        BIRTHDAY.CustomFormat = ("                 yyyy-MM-dd")

        DATEREG.Format = DateTimePickerFormat.Custom

        DATEREG.CustomFormat = ("                 yyyy-MM-dd")

        Try
            Dim CMD As SqlClient.SqlCommand = host.CreateCommand

            CMD.CommandText = "INSERT INTO DATA (PATIENTID,PATIENTNAME,MIDDLENAME,SURNAME,AGE,BIRTHDAY,[DATE REGISTERED],GENDER,ADDRESS,PHONE#,INSURANCE,OCCUPATION,STATUS,DIAGNOSIS,TREATMENTS,[ABOUT HEALTH PATIENT],PICTURE,QRCODE)VALUES(@PATIENTID,@PATIENTNAME,@MIDDLENAME,@SURNAME,@AGE,@BIRTHDAY,@DATE_REGISTERED,@GENDER,@ADDRESS,@PHONE#,@INSURANCE,@OCCUPATION,@STATUS,@DIAGNOSIS,@TREATMENTS,@ABOUT_HEALTH_PATIENT,@PICTURE,@QRCODE)"
            CMD.Parameters.AddWithValue("@PATIENTID", IDHIDE.Text)
            CMD.Parameters.AddWithValue("@PATIENTNAME", PATIENTNAME.Text)

            CMD.Parameters.AddWithValue("@MIDDLENAME", MIDDLENAME.Text)

            CMD.Parameters.AddWithValue("@SURNAME", SURNAME.Text)

            CMD.Parameters.AddWithValue("@AGE", AGE.Text)

            CMD.Parameters.AddWithValue("@BIRTHDAY", BIRTHDAY.Text)

            CMD.Parameters.AddWithValue("@DATE_REGISTERED", DATEREG.Text)

            CMD.Parameters.AddWithValue("@GENDER", gENDER.Text)

            CMD.Parameters.AddWithValue("@ADDRESS", ADDRESS.Text)

            CMD.Parameters.AddWithValue("@PHONE#", PHONE.Text)

            CMD.Parameters.AddWithValue("@INSURANCE", INSURANCE.Text)
            CMD.Parameters.AddWithValue("@OCCUPATION", OCCUPATION.Text)
            CMD.Parameters.AddWithValue("@STATUS", STATUS.Text)

            CMD.Parameters.AddWithValue("@ABOUT_HEALTH_PATIENT", SqlDbType.Text).Value = ABOUTPA.Text
            CMD.Parameters.AddWithValue("@DIAGNOSIS", DIAGNOSISComboBox.Text + ":Edited By:" + Form1.LOGINTextBox.Text)
            CMD.Parameters.AddWithValue("@TREATMENTS", TREATMENTSTextBox.Text)
            '---------------------------------------------------------------------'
            'PICTURE'
            PICTUREPictureBox.Image.Save(PROFILEPIC, Imaging.ImageFormat.Bmp)
            CMD.Parameters.Add("@PICTURE", SqlDbType.Image).Value = PROFILEPIC.ToArray
            '---------------------------------------------------------------------'
            'QR'
            QRCODEPictureBox.Image.Save(QR, Imaging.ImageFormat.Bmp)
            CMD.Parameters.Add("@QRCODE", SqlDbType.Image).Value = QR.ToArray


            host.Open()
            If Len(Trim(PATIENTNAME.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT NAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PATIENTNAME.Focus()

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

            ElseIf Len(Trim(gENDER.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT GENDER", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                gENDER.Focus()
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
                MessageBox.Show("PLEASE FILL PATIENT INSURANCE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                INSURANCE.Focus()

            ElseIf Len(Trim(ABOUTPA.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL HEALTH PATIENT INFORMATION", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ABOUTPA.Focus()

            ElseIf Len(Trim(PICTUREPictureBox.CanSelect)) = 1 Then
                MetroFramework.MetroMessageBox.Show(Me, "CHOOSE PICTURE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PICTUREPictureBox.Focus()

            ElseIf Len(Trim(INSURANCE.CanSelect)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL INSURANCE PATIENT", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                INSURANCE.Focus()

            ElseIf Len(Trim(DIAGNOSISComboBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL DIAGNOSIS NOR NONE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DIAGNOSISComboBox.Focus()

            ElseIf Len(Trim(TREATMENTSTextBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL TREATMENTS NOR NONE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TREATMENTSTextBox.Focus()

            ElseIf IDHIDE.Enabled = True Then
                MetroFramework.MetroMessageBox.Show(Me, "YOU ARE EDIT IN MODE PLEASE ADD NEW FOR NEW SAVE DATA", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf result = DialogResult.Cancel Then
                MetroFramework.MetroMessageBox.Show(Me, "Cancelled", "Patient Information System Says", MessageBoxButtons.OK, MessageBoxIcon.None)
            ElseIf result = DialogResult.No Then
                MetroFramework.MetroMessageBox.Show(Me, "OK", "Patient Information System Says", MessageBoxButtons.OK, MessageBoxIcon.None)
            ElseIf result = DialogResult.Yes Then
                MessageBox.Show(Me, "Patient Info Was Client Verified", "Successfully Verification ok", MessageBoxButtons.OK, MessageBoxIcon.None)
                CMD.ExecuteNonQuery()
                Me.Close()
                refresh_1.Show()

                PATIENTNAME.Enabled = False
                DIAGNOSISComboBox.Enabled = False
                TREATMENTSTextBox.Enabled = False
                MIDDLENAME.Enabled = False
                SURNAME.Enabled = False
                AGE.Enabled = False
                BIRTHDAY.Enabled = False
                DATEREG.Enabled = False
                gENDER.Enabled = False
                ADDRESS.Enabled = False
                PHONE.Enabled = False
                INSURANCE.Enabled = False
                OCCUPATION.Enabled = False
                STATUS.Enabled = False
                ABOUTPA.Enabled = False
                IDHIDE.Enabled = False
            ElseIf MessageBox.Show(Me, "ERROR") Then

            End If

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
        Timer1.Stop()
        host.Close()
        Me.Refresh()
    End Sub

    Private Sub FillBy1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Refresh()
    End Sub


    Private Sub FillByfroi1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        PATIENTNAME.Enabled = True
        MIDDLENAME.Enabled = True
        SURNAME.Enabled = True
        AGE.Enabled = True
        BIRTHDAY.Enabled = True
        DATEREG.Enabled = True
        gENDER.Enabled = True
        ADDRESS.Enabled = True
        PHONE.Enabled = True
        INSURANCE.Enabled = True
        OCCUPATION.Enabled = True
        STATUS.Enabled = True
        ABOUTPA.Enabled = True
        IDHIDE.Enabled = True
        DIAGNOSISComboBox.Enabled = True
        TREATMENTSTextBox.Enabled = True
        MetroFramework.MetroMessageBox.Show(Me, "PLEASE CHOOSE PATIENT ID IN THE SEARCH BUTTON IF YOU WANT TO UPDATE", "EDIT MODE", MessageBoxButtons.OKCancel)


    End Sub
    Public Sub EXECUTE(ByVal queryNEW As String)
        host.Open()
        Dim comand As New SqlCommand(queryNEW, host)


    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Touchless.RefreshCameraList()
        Me.Close()
        Form6.Show()


    End Sub


    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        PATIENTNAME.Enabled = False
        MIDDLENAME.Enabled = False
        SURNAME.Enabled = False
        AGE.Enabled = False
        BIRTHDAY.Enabled = False
        DATEREG.Enabled = False
        gENDER.Enabled = False
        ADDRESS.Enabled = False
        PHONE.Enabled = False
        INSURANCE.Enabled = False
        OCCUPATION.Enabled = False
        STATUS.Enabled = False
        ABOUTPA.Enabled = False

        IDHIDE.Enabled = True
        Me.Close()
        refresh_1.Show()
        IDHIDE.Enabled = False

    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Close()
        Form6.Show()
        Touchless.RefreshCameraList()
        PATIENTNAME.Enabled = False
        MIDDLENAME.Enabled = False
        SURNAME.Enabled = False
        AGE.Enabled = False
        BIRTHDAY.Enabled = False
        DATEREG.Enabled = False
        gENDER.Enabled = False
        ADDRESS.Enabled = False
        PHONE.Enabled = False
        INSURANCE.Enabled = False
        OCCUPATION.Enabled = False
        STATUS.Enabled = False
        ABOUTPA.Enabled = False

        IDHIDE.Enabled = False
    End Sub

    Private Sub ABOUT_HEALTH_PATIENTLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub IDHIDE_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        IDHIDE.Text = ""
    End Sub

    Private Sub Button9_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        QRCODEPictureBox.Image = generator.Encode("Surname:" + SURNAME.Text + ")(Name:" + PATIENTNAME.Text + ")(Date registration Verification:" + DATEREG.Text + ")" + "MamatidClinicDatabase")
        BIRTHDAY.Format = DateTimePickerFormat.Custom

        BIRTHDAY.CustomFormat = ("                 yyyy-MM-dd")

        DATEREG.Format = DateTimePickerFormat.Custom

        DATEREG.CustomFormat = ("                 yyyy-MM-dd")




        Dim froiupdate As New SqlCommand("UPDATE DATA SET PATIENTNAME = @PATIENTNAME ,MIDDLENAME = @MIDDLENAME ,SURNAME = @SURNAME,AGE = @AGE ,BIRTHDAY = @BIRTHDAY,[DATE REGISTERED] = @DATE_REGISTERED ,GENDER = @GENDER,ADDRESS = @ADDRESS ,PHONE# = @PHONE#,INSURANCE = @INSURANCE,OCCUPATION = @OCCUPATION,STATUS = @STATUS,DIAGNOSIS = @DIAGNOSIS,TREATMENTS = @TREATMENTS,[ABOUT HEALTH PATIENT] = @ABOUT_HEALTH_PATIENT ,PICTURE = @PICTURE ,QRCODE = @QRCODE WHERE PATIENTID = @PATIENTID", host)
        Dim MS As New MemoryStream
        Dim MS2 As New MemoryStream
        froiupdate.Parameters.AddWithValue("@PATIENTNAME", PATIENTNAME.Text)

        froiupdate.Parameters.AddWithValue("@MIDDLENAME", MIDDLENAME.Text)

        froiupdate.Parameters.AddWithValue("@SURNAME", SURNAME.Text)

        froiupdate.Parameters.AddWithValue("@AGE", AGE.Text)

        froiupdate.Parameters.AddWithValue("@BIRTHDAY", BIRTHDAY.Text)

        froiupdate.Parameters.AddWithValue("@DATE_REGISTERED", DATEREG.Text)

        froiupdate.Parameters.AddWithValue("@GENDER", gENDER.Text)

        froiupdate.Parameters.AddWithValue("@ADDRESS", ADDRESS.Text)

        froiupdate.Parameters.AddWithValue("@PHONE#", PHONE.Text)
        froiupdate.Parameters.AddWithValue("@DIAGNOSIS", DIAGNOSISComboBox.Text + ":EDITED BY:" + Form1.LOGINTextBox.Text)
        froiupdate.Parameters.AddWithValue("@TREATMENTS", TREATMENTSTextBox.Text)

        froiupdate.Parameters.AddWithValue("@INSURANCE", INSURANCE.Text)
        froiupdate.Parameters.AddWithValue("@OCCUPATION", OCCUPATION.Text)
        froiupdate.Parameters.AddWithValue("@STATUS", STATUS.Text)
        froiupdate.Parameters.AddWithValue("@ABOUT_HEALTH_PATIENT", SqlDbType.Text).Value = ABOUTPA.Text
        froiupdate.Parameters.AddWithValue("@PATIENTID", IDHIDE.Text)
        PICTUREPictureBox.Image.Save(MS, Imaging.ImageFormat.Bmp)
        froiupdate.Parameters.Add("@PICTURE", SqlDbType.Image).Value = MS.ToArray
        QRCODEPictureBox.Image.Save(MS2, Imaging.ImageFormat.Bmp)
        froiupdate.Parameters.Add("@QRCODE", SqlDbType.Image).Value = MS2.ToArray
        host.Open()
        Try
            If Len(Trim(PATIENTNAME.Text)) = 0 Then
                MessageBox.Show("PLEASE FILL PATIENT NAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PATIENTNAME.Focus()

            ElseIf Len(Trim(MIDDLENAME.Text)) = 0 Then
                MessageBox.Show("PLEASE FILL PATIENT SURNAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MIDDLENAME.Focus()

            ElseIf Len(Trim(SURNAME.Text)) = 0 Then
                MessageBox.Show("PLEASE FILL PATIENT LASTNAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SURNAME.Focus()

            ElseIf Len(Trim(AGE.Text)) = 0 Then
                MessageBox.Show("PLEASE FILL PATIENT AGE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                AGE.Focus()

            ElseIf Len(Trim(BIRTHDAY.Text)) = 0 Then
                MessageBox.Show("PLEASE FILL PATIENT BIRTHDAY", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BIRTHDAY.Focus()

            ElseIf Len(Trim(DATEREG.Text)) = 0 Then
                MessageBox.Show("PLEASE FILL PATIENT REGISTERED DATE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DATEREG.Focus()

            ElseIf Len(Trim(gENDER.Text)) = 0 Then
                MessageBox.Show("PLEASE FILL PATIENT GENDER", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                gENDER.Focus()
            ElseIf Len(Trim(ADDRESS.Text)) = 0 Then
                MessageBox.Show("PLEASE FILL PATIENT ADDRESS", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ADDRESS.Focus()
            ElseIf Len(Trim(OCCUPATION.Text)) = 0 Then
                MessageBox.Show("PLEASE FILL PATIENT OCCUPATION", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                OCCUPATION.Focus()

            ElseIf Len(Trim(STATUS.Text)) = 0 Then
                MessageBox.Show("PLEASE FILL PATIENT STATUS", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                STATUS.Focus()

            ElseIf Len(Trim(PHONE.Text)) = 0 Then
                MessageBox.Show("PLEASE FILL PATIENT PHONE NUMBER", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PHONE.Focus()
            ElseIf Len(Trim(INSURANCE.Text)) = 0 Then
                MessageBox.Show("PLEASE FILL PATIENT INSURANCE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                INSURANCE.Focus()
            ElseIf Len(Trim(ABOUTPA.Text)) = 0 Then
                MessageBox.Show("PLEASE FILL HEALTH PATIENT INFORMATION", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ABOUTPA.Focus()

            ElseIf Len(Trim(PICTUREPictureBox.CanSelect)) = 1 Then
                MessageBox.Show("CHOOSE PICTURE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PICTUREPictureBox.Focus()
            ElseIf Len(Trim(INSURANCE.CanSelect)) = 0 Then
                MessageBox.Show("CHOOSE PICTURE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                INSURANCE.Focus()
            ElseIf froiupdate.ExecuteNonQuery() > 0 Then
                PATIENTNAME.Enabled = False
                MIDDLENAME.Enabled = False
                SURNAME.Enabled = False
                AGE.Enabled = False
                BIRTHDAY.Enabled = False
                DATEREG.Enabled = False
                gENDER.Enabled = False
                ADDRESS.Enabled = False
                PHONE.Enabled = False
                INSURANCE.Enabled = False
                OCCUPATION.Enabled = False
                STATUS.Enabled = False
                ABOUTPA.Enabled = False
                IDHIDE.Enabled = False
                DIAGNOSISComboBox.Enabled = False
                TREATMENTSTextBox.Enabled = False
                MessageBox.Show(" PatientID Info Was UPDATED Successfully", "Registration Report", MessageBoxButtons.OK)
            ElseIf MessageBox.Show("SAVING A NEW DATA WAS NOT ALLOWED IN EDIT MODE PLEASE ADD NEW FOR A NEW DATA ", "EDIT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error) Then

            End If

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
        host.Close()
        Me.Refresh()
        Timer1.Enabled = False
    End Sub

    Private Sub IDHIDE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then

            MessageBox.Show("Only Numbers")
            e.Handled = True
        End If
        If IDHIDE.Text.Length >= 8 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub i_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub
    Private Sub d_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not IsNumeric(SURNAME.Text) Then
            MsgBox("Please enter numbers only.", vbInformation)

            SURNAME.Text = ""
        End If
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click

        Dim search As New SqlCommand("SELECT * FROM DATA WHERE PATIENTID=@PATIENTID", host)
        Dim adapter As New SqlDataAdapter(search)
        Dim table As New DataTable()
        search.Parameters.AddWithValue("@PATIENTID", IDHIDE.Text)
        adapter.Fill(table)
        host.Open()
        If table.Rows.Count() > 0 Then
            PATIENTNAME.Text = table.Rows(0)(1).ToString
            MIDDLENAME.Text = table.Rows(0)(2).ToString
            SURNAME.Text = table.Rows(0)(3).ToString
            AGE.Text = table.Rows(0)(4).ToString
            BIRTHDAY.Text = table.Rows(0)(5).ToString
            DATEREG.Text = table.Rows(0)(6).ToString
            gENDER.Text = table.Rows(0)(7).ToString
            ADDRESS.Text = table.Rows(0)(8).ToString
            PHONE.Text = table.Rows(0)(9).ToString
            INSURANCE.Text = table.Rows(0)(10).ToString
            OCCUPATION.Text = table.Rows(0)(11).ToString
            STATUS.Text = table.Rows(0)(12).ToString
            DIAGNOSISComboBox.Text = table.Rows(0)(13).ToString
            TREATMENTSTextBox.Text = table.Rows(0)(14).ToString
            ABOUTPA.Text = table.Rows(0)(15).ToString
            Try
                Dim picture As Byte()
                picture = table.Rows(0)(16)
                Dim MS2 As New MemoryStream(picture)
                PICTUREPictureBox.Image = Image.FromStream(MS2)
                '---------------------------------------------'

            Catch ex As Exception
            End Try



        ElseIf search.ExecuteNonQuery.ToString() > 0 Then
            Refresh()
        ElseIf MessageBox.Show("No Records Found: " + IDHIDE.Text, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error) Then
        End If
        host.Close()
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


    Private Sub QRCODEPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QRCODEPictureBox.Click
        QRCODEPictureBox.Image = generator.Encode(IDHIDE.Text)
    End Sub

    Private Sub MetroLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AGE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AGE.SelectedIndexChanged
        

    End Sub
    Private Sub notification2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles notification2.Click
        chattingform.Show()
    End Sub
End Class
