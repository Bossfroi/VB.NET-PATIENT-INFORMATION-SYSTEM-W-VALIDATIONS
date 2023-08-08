Imports System.Data.SqlClient
Imports System.IO
Public Class Form7
    Dim HOST As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Clinic Database;Integrated Security=True")
    Dim open As New OpenFileDialog
    Private Sub PASSTABLEBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PASSTABLEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Clinic_databaseDataSet)

    End Sub


    Private Sub PASSTABLEBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PASSTABLEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Clinic_databaseDataSet)

    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LOGINTextBox.Text = ""
        PASSWORDTextBox.Text = ""

        iduser.Text = Form1.LOGINTextBox.Text
    End Sub

    Private Sub PASSWORDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PASSWORDLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LOGINLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LOGINTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PASSTABLEBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PASSTABLEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Clinic_databaseDataSet)

    End Sub

    Private Sub DATABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        host.Open()
        Dim yesno As MsgBoxResult = MsgBox("Are you sure you create this Administrative Account Username:   " + LOGINTextBox.Text, MsgBoxStyle.YesNo)


        Try
            Dim CREATE As SqlClient.SqlCommand = host.CreateCommand
            Dim MS As New MemoryStream
            CREATE.CommandText = "INSERT INTO PASSTABLE (LOGIN,PASSWORD) VALUES(@LOGIN,@PASSWORD)"
            CREATE.Parameters.AddWithValue("@LOGIN", LOGINTextBox.Text)
            CREATE.Parameters.AddWithValue("@PASSWORD", PASSWORDTextBox.Text)
            If Len(Trim(LOGINTextBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PATIENT USERNAME ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LOGINTextBox.Focus()
            ElseIf PASSWORDTextBox.Text.Length <= 7 Then
                MessageBox.Show("8 character password requirments")
            ElseIf LOGINTextBox.Text.Length <= 5 Then
                MessageBox.Show("5 character Username requirments")
            ElseIf Len(Trim(PASSWORDTextBox.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "PLEASE FILL PASSWORD", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PASSWORDTextBox.Focus()
            ElseIf PASSWORDTextBox.Text <> PASS2.Text Then
                MsgBox("Password not Match!,Please Re-type.", MsgBoxStyle.Critical)
                PASSWORDTextBox.Text = ""
                PASS2.Text = ""
            ElseIf yesno = MsgBoxResult.No Then
            ElseIf CREATE.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Successfully Create", "Create", MessageBoxButtons.OK, MessageBoxIcon.None)
                PASSWORDTextBox.Text = ""
                LOGINTextBox.Text = ""
                PASS2.Text = ""
            ElseIf MetroFramework.MetroMessageBox.Show(Me, "ERROR") Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
        host.Close()
        Me.Refresh()


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        LOGINTextBox.Text = ""
        PASSWORDTextBox.Text = ""
        Refresh()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Close()
        Form6.Show()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub userlevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles userlevel.SelectedIndexChanged
        If Me.userlevel.SelectedItem = "GUEST" Then
            Form9.Show()
            Me.Close()


        End If

    End Sub

    Private Sub LOGINTextBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LOGINTextBox.MouseClick
        LOGINTextBox.Text = ""
    End Sub

    Private Sub PASSWORDTextBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PASSWORDTextBox.MouseClick
        PASSWORDTextBox.Text = ""
    End Sub


End Class