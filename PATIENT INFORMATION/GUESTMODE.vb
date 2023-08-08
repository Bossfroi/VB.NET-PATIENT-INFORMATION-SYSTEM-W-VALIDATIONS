Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.SqlClient.SqlException

Public Class GUESTMODE
    Dim HOST As New SqlConnection("Data Source=kamote-pc;Initial Catalog=CLINIC DATABASE;User ID=sa;Password=froi")
    Dim open As New OpenFileDialog
    Public Touchless As New TouchlessLib.TouchlessMgr
    Public Camera1 As TouchlessLib.Camera = Touchless.Cameras.ElementAt(0)
    Dim PROID As String
    Dim generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Private Sub GETID()
        Dim sql As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Try
            HOST.Open()
            sql = "select PATIENTID from DATA order by PATIENTID Desc"
            cmd = New SqlCommand(sql, HOST)
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

            HOST.Close()

        End Try
        Refresh()
        IDHIDE.Text = PROID


    End Sub
    Private Sub GUESTMODE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        GETID()
        iduser.Text = Form8.LOGINTextBox.Text
        PATIENTNAMETextBox.Enabled = False
        MIDDLENAMETextBox.Enabled = False
        SURNAMETextBox.Enabled = False
        AGEComboBox.Enabled = False
        BIRTHDAYDateTimePicker.Enabled = False
        DATE_REGISTEREDDateTimePicker.Enabled = False
        GENDERComboBox.Enabled = False
        ADDRESSTextBox.Enabled = False
        PHONE_TextBox.Enabled = False
        INSURANCEComboBox.Enabled = False
        OCCUPATIONTextBox.Enabled = False
        STATUSComboBox.Enabled = False
        ABOUT_HEALTH_PATIENTTextBox.Enabled = False
        DIAGNOSISTextBox.Enabled = False
        TREATMENTSTextBox.Enabled = False
        idhide.Enabled = False
    End Sub
    Private Sub PHONE_TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PHONE_TextBox.KeyPress
        If Asc(e.KeyChar) <> 12 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then

            MessageBox.Show("Only numbers")
            e.Handled = True
        End If
        If PHONE_TextBox.Text.Length >= 13 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        REFRESHGUESTADDFORM.Show()
        Me.Close()


    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PATIENTNAMETextBox.Enabled = True
        MIDDLENAMETextBox.Enabled = True
        SURNAMETextBox.Enabled = True
        AGEComboBox.Enabled = True
        BIRTHDAYDateTimePicker.Enabled = True
        DATE_REGISTEREDDateTimePicker.Enabled = True
        GENDERComboBox.Enabled = True
        ADDRESSTextBox.Enabled = True
        PHONE_TextBox.Enabled = True
        INSURANCEComboBox.Enabled = True
        OCCUPATIONTextBox.Enabled = True
        STATUSComboBox.Enabled = True
        ABOUT_HEALTH_PATIENTTextBox.Enabled = True
        DIAGNOSISTextBox.Enabled = True
        TREATMENTSTextBox.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        QRCODEPictureBox.Image = generator.Encode(idhide.Text)
        Dim result As Integer = MessageBox.Show("Are you sure to Approve this Client", "Patient Information System Approval", MessageBoxButtons.YesNoCancel)
        Dim QR As New MemoryStream
        Dim PROFILEPIC As New MemoryStream
        BIRTHDAYDateTimePicker.Format = DateTimePickerFormat.Custom

        BIRTHDAYDateTimePicker.CustomFormat = ("                 yyyy-MM-dd")

        DATE_REGISTEREDDateTimePicker.Format = DateTimePickerFormat.Custom

        DATE_REGISTEREDDateTimePicker.CustomFormat = ("                 yyyy-MM-dd")

        Try
            Dim CMD As SqlClient.SqlCommand = host.CreateCommand
            Dim MS As New MemoryStream
            CMD.CommandText = "INSERT INTO DATA (PATIENTID,PATIENTNAME,MIDDLENAME,SURNAME,AGE,BIRTHDAY,[DATE REGISTERED],GENDER,ADDRESS,PHONE#,INSURANCE,OCCUPATION,STATUS,DIAGNOSIS,TREATMENTS,[ABOUT HEALTH PATIENT],PICTURE,QRCODE)VALUES(@PATIENTID,@PATIENTNAME,@MIDDLENAME,@SURNAME,@AGE,@BIRTHDAY,@DATE_REGISTERED,@GENDER,@ADDRESS,@PHONE#,@INSURANCE,@OCCUPATION,@STATUS,@DIAGNOSIS,@TREATMENTS,@ABOUT_HEALTH_PATIENT,@PICTURE,@QRCODE)"
            CMD.Parameters.AddWithValue("@PATIENTID", idhide.Text)
            CMD.Parameters.AddWithValue("@PATIENTNAME", PATIENTNAMETextBox.Text)

            CMD.Parameters.AddWithValue("@MIDDLENAME", MIDDLENAMETextBox.Text)

            CMD.Parameters.AddWithValue("@SURNAME", SURNAMETextBox.Text)

            CMD.Parameters.AddWithValue("@AGE", AGEComboBox.Text)

            CMD.Parameters.AddWithValue("@BIRTHDAY", BIRTHDAYDateTimePicker.Text)

            CMD.Parameters.AddWithValue("@DATE_REGISTERED", DATE_REGISTEREDDateTimePicker.Text)

            CMD.Parameters.AddWithValue("@GENDER", GENDERComboBox.Text)

            CMD.Parameters.AddWithValue("@ADDRESS", ADDRESSTextBox.Text)

            CMD.Parameters.AddWithValue("@PHONE#", PHONE_TextBox.Text)

            CMD.Parameters.AddWithValue("@INSURANCE", INSURANCEComboBox.Text)
            CMD.Parameters.AddWithValue("@OCCUPATION", OCCUPATIONTextBox.Text)
            CMD.Parameters.AddWithValue("@STATUS", STATUSComboBox.Text)

            CMD.Parameters.AddWithValue("@ABOUT_HEALTH_PATIENT", SqlDbType.Text).Value = ABOUT_HEALTH_PATIENTTextBox.Text
            CMD.Parameters.AddWithValue("@DIAGNOSIS", DIAGNOSISTextBox.Text + ":Edited By:" + Form8.LOGINTextBox.Text)
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
            If Len(Trim(PATIENTNAMETextBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT NAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PATIENTNAMETextBox.Focus()

            ElseIf Len(Trim(MIDDLENAMETextBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT SURNAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MIDDLENAMETextBox.Focus()

            ElseIf Len(Trim(SURNAMETextBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT LASTNAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SURNAMETextBox.Focus()

            ElseIf Len(Trim(AGEComboBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT AGE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                AGEComboBox.Focus()

            ElseIf Len(Trim(BIRTHDAYDateTimePicker.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT BIRTHDAY", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BIRTHDAYDateTimePicker.Focus()

            ElseIf Len(Trim(DATE_REGISTEREDDateTimePicker.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT REGISTERED DATE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DATE_REGISTEREDDateTimePicker.Focus()

            ElseIf Len(Trim(GENDERComboBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT GENDER", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GENDERComboBox.Focus()
            ElseIf Len(Trim(ADDRESSTextBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT ADDRESS", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ADDRESSTextBox.Focus()
            ElseIf Len(Trim(OCCUPATIONTextBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT OCCUPATION", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                OCCUPATIONTextBox.Focus()

            ElseIf Len(Trim(STATUSComboBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT STATUS", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                STATUSComboBox.Focus()

            ElseIf Len(Trim(PHONE_TextBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT PHONE NUMBER", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PHONE_TextBox.Focus()
            ElseIf Len(Trim(INSURANCEComboBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT INSURANCE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                INSURANCEComboBox.Focus()

            ElseIf Len(Trim(ABOUT_HEALTH_PATIENTTextBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL HEALTH PATIENT INFORMATION", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ABOUT_HEALTH_PATIENTTextBox.Focus()

            ElseIf Len(Trim(PICTUREPictureBox.CanSelect)) = 1 Then
                MetroFramework.MetroMessageBox.Show(Me, "CHOOSE PICTURE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PICTUREPictureBox.Focus()

            ElseIf Len(Trim(INSURANCEComboBox.CanSelect)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL INSURANCE PATIENT", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                INSURANCEComboBox.Focus()

            ElseIf Len(Trim(DIAGNOSISTextBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL DIAGNOSIS NOR NONE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DIAGNOSISTextBox.Focus()

            ElseIf Len(Trim(TREATMENTSTextBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL TREATMENTS NOR NONE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TREATMENTSTextBox.Focus()

            ElseIf result = DialogResult.Cancel Then
                MetroFramework.MetroMessageBox.Show(Me, "Cancelled", "Patient Information System Says ", MessageBoxButtons.OK, MessageBoxIcon.None)
            ElseIf result = DialogResult.No Then
                MetroFramework.MetroMessageBox.Show(Me, "OK", "Patient Information System Says", MessageBoxButtons.OK, MessageBoxIcon.None)
            ElseIf result = DialogResult.Yes Then
                MessageBox.Show("Patient Info Was Client Verified", "Successfully Verification ok", MessageBoxButtons.OK, MessageBoxIcon.None)

                CMD.ExecuteNonQuery()
                REFRESHGUESTADDFORM.Show()
                Me.Close()




                PATIENTNAMETextBox.Enabled = False
                DIAGNOSISTextBox.Enabled = False
                TREATMENTSTextBox.Enabled = False
                MIDDLENAMETextBox.Enabled = False
                SURNAMETextBox.Enabled = False
                AGEComboBox.Enabled = False
                BIRTHDAYDateTimePicker.Enabled = False
                DATE_REGISTEREDDateTimePicker.Enabled = False
                GENDERComboBox.Enabled = False
                ADDRESSTextBox.Enabled = False
                PHONE_TextBox.Enabled = False
                INSURANCEComboBox.Enabled = False
                OCCUPATIONTextBox.Enabled = False
                STATUSComboBox.Enabled = False
                ABOUT_HEALTH_PATIENTTextBox.Enabled = False

            ElseIf MetroFramework.MetroMessageBox.Show(Me, "ERROR") Then

            End If

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

        host.Close()
        Me.Refresh()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        open.Filter = "image files (*.jpg; *.bmp;*.png ;*.jpeg;*.gif;*.ico)|*.jpg; *.bmp;*.png ;*.jpeg;*.gif;*.ico"

        If open.ShowDialog = Windows.Forms.DialogResult.OK Then

            PICTUREPictureBox.Image = Image.FromFile(open.FileName)
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim WHY As MsgBoxResult = MsgBox("Do you Want to Logout User: " + Form8.LOGINTextBox.Text, MsgBoxStyle.YesNoCancel)
        If WHY = MsgBoxResult.Yes Then

            MessageBox.Show("Successfully Logout", "Successfuly Out", MessageBoxButtons.OK)
            End
            Form8.LOGINTextBox.Text = ""
            Form8.PASSWORDTextBox.Text = ""
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        REFRESHGUESTADDFORM.Show()
        Me.Close()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        guest_view.Show()
        Timer1.Enabled = False
        Me.Hide()
        Touchless.RefreshCameraList()
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
        Timer1.Stop()

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim WHY As MsgBoxResult = MsgBox("Do you Want to Logout User: " + Form8.LOGINTextBox.Text, MsgBoxStyle.YesNoCancel)
        If WHY = MsgBoxResult.Yes Then
            Me.Close()
            MessageBox.Show("Successfully Logout", "Successfuly Out", MessageBoxButtons.OK)
            Form8.Show()
            Form8.LOGINTextBox.Text = ""
            Form8.PASSWORDTextBox.Text = ""
            Touchless.RefreshCameraList()
        End If

        End
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        open.Filter = "image files (*.jpg; *.bmp;*.png ;*.jpeg;*.gif;*.ico)|*.jpg; *.bmp;*.png ;*.jpeg;*.gif;*.ico"

        If open.ShowDialog = Windows.Forms.DialogResult.OK Then

            PICTUREPictureBox.Image = Image.FromFile(open.FileName)
        End If
    End Sub

    Private Sub PATIENTNAMELabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub INSURANCELabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ABOUT_HEALTH_PATIENTLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TREATMENTSLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DIAGNOSISLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub STATUSLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OCCUPATIONLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MIDDLENAMELabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PHONE_Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ADDRESSLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GENDERLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DATE_REGISTEREDLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BIRTHDAYLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AGELabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SURNAMELabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub idhide_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idhide.TextChanged

    End Sub

    Private Sub AGEComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AGEComboBox.KeyPress
        If Not IsNumeric(AGEComboBox.Text.ToString) Then
            MsgBox("Please enter numbers only.", vbInformation)
        ElseIf AGEComboBox.Text.Length >= 3 Then
            e.Handled = True
        ElseIf e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub AGEComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AGEComboBox.SelectedIndexChanged

    End Sub

    Private Sub PHONE_TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PHONE_TextBox.TextChanged

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        About.Show()
    End Sub

    Private Sub notification2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guestnotif.Click
        chattingform.Show()
    End Sub
End Class