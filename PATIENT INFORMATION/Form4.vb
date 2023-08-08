Imports System.Data.SqlClient

Public Class form4
    Dim info As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
    Dim HOST As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Clinic Database;Integrated Security=True")
    Dim PROID As String
    Dim PROIDGUEST As String
    Private Sub form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GUESTTableAdapter.Fill(Me.Clinic_databaseDataSet.GUEST)
        Me.PASSTABLETableAdapter.Fill(Me.Clinic_databaseDataSet.PASSTABLE)
        A.Enabled = False

        C.Enabled = False
        ADMIN()
        GUEST1()
    End Sub
    Private Sub ADMIN()
        Dim sql As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        Try
            HOST.Open()
            sql = "Select count(*) as count_var from PASSTABLE"
            cmd = New SqlCommand(sql, HOST)
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

            HOST.Close()

        End Try
        Refresh()
        ADMIN1.Text = PROID
    End Sub
    Private Sub GUEST1()
        Dim sql As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        Try
            HOST.Open()
            sql = "Select count(*) as count_var from GUEST"
            cmd = New SqlCommand(sql, HOST)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If (dr.Read.ToString) = True Then
                Dim ID As Integer
                ID = (dr(0))
                PROIDGUEST = ID.ToString("0")

            ElseIf IsDBNull(dr) Then
                PROIDGUEST = ("0")
            Else
                PROIDGUEST = ("0")
            End If

        Catch ex As Exception
        Finally

            HOST.Close()

        End Try
        Refresh()
        GUEST.Text = PROIDGUEST
    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
      
    End Sub
    Private Sub admintrue()

        A.Enabled = False

    End Sub
    Private Sub guesttrue()

        C.Enabled = False

    End Sub

    Private Sub PASSTABLEBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PASSTABLEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Clinic_databaseDataSet)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MessageBox.Show("CHOOSE A ADMIN DO YOU WANT TO EDIT/DELETE", "EDIT MODE", MessageBoxButtons.OK)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MessageBox.Show("CHOOSE GUEST DO YOU WANT TO EDIT/DELETE", "EDIT MODE", MessageBoxButtons.OK)
    End Sub

    Private Sub USERNAMETextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form6.Show()


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        Form6.Show()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim WHY As MsgBoxResult = MsgBox("Would you delete a Administrative User: " + A.Text, MsgBoxStyle.YesNoCancel)
        If WHY = MsgBoxResult.Yes Then
            Dim deletesql As String = " delete from PASSTABLE WHERE LOGIN  = @LOGIN"
            Dim comand2 As New SqlCommand(deletesql, HOST)
            comand2.Parameters.AddWithValue("@LOGIN", A.Text)
            HOST.Open()
            If A.Text = "" Then

            ElseIf A.Text = "Creator" Then
                MessageBox.Show("FAILED TO DELETE THE CREATOR OF THIS SYSTEM PLEASE CONTACT THE DEVELOPER", "ERROR", MessageBoxButtons.OK)
                DialogResult = vbOK
                About.Show()
            ElseIf comand2.ExecuteNonQuery() > 0 Then
                MessageBox.Show(" Successfully delete ADMIN USER : " + A.Text, "DELETE FILE", MessageBoxButtons.OK)
            End If
            Me.PASSTABLETableAdapter.Fill(Me.Clinic_databaseDataSet.PASSTABLE)
            HOST.CLOSE()
        End If
        ADMIN()
    End Sub

    Public Sub DELexecutequeryGUEST(ByVal query As String)

        Dim comand2 As New SqlCommand(query, HOST)
        comand2.Parameters.AddWithValue("@LOGIN", A.Text)
        HOST.Open()
        If A.Text = "" Then

        ElseIf comand2.ExecuteNonQuery() > 0 Then
            MessageBox.Show(" Successfully delete ADMIN USER : " + A.Text, "DELETE FILE", MessageBoxButtons.OK)
        ElseIf MessageBox.Show(" Please choose a valid ID File", "ERROR", MessageBoxButtons.AbortRetryIgnore) Then
        End If
        HOST.Close()
        Me.GUESTTableAdapter.Fill(Me.Clinic_databaseDataSet.GUEST)
        Me.Refresh()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim WHY As MsgBoxResult = MsgBox("Would you delete a Record GUEST USER:" + C.Text, MsgBoxStyle.YesNoCancel)
        If WHY = MsgBoxResult.Yes Then
            Dim deletesql As String = " DELETE from GUEST WHERE USERNAME  = @USERNAME"
            
            DELexecutequery(deletesql)
            Me.PASSTABLETableAdapter.Fill(Me.Clinic_databaseDataSet.PASSTABLE)
            Me.GUESTTableAdapter.Fill(Me.Clinic_databaseDataSet.GUEST)
        End If
        Me.PASSTABLETableAdapter.Fill(Me.Clinic_databaseDataSet.PASSTABLE)
        Me.GUESTTableAdapter.Fill(Me.Clinic_databaseDataSet.GUEST)
        GUEST1()
    End Sub

    Public Sub DELexecutequery(ByVal query As String)

        Dim comand2 As New SqlCommand(query, HOST)
        comand2.Parameters.AddWithValue("@USERNAME", C.Text)
        HOST.Open()
        If A.Text = "" Then

        ElseIf comand2.ExecuteNonQuery() > 0 Then
            MessageBox.Show(" Successfully delete GUEST USER: " + C.Text, "DELETE FILE", MessageBoxButtons.OK)
        ElseIf MessageBox.Show(" Please choose a valid ID File", "ERROR", MessageBoxButtons.AbortRetryIgnore) Then
        End If
        HOST.Close()

        Me.Refresh()
    End Sub


    Private Sub UPDATEGUEST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPDATEGUEST.Click
        changeGuestpass.username.Text = C.Text
        changeGuestpass.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.PASSTABLETableAdapter.Fill(Me.Clinic_databaseDataSet.PASSTABLE)
        Me.GUESTTableAdapter.Fill(Me.Clinic_databaseDataSet.GUEST)
    End Sub


    Private Sub GUESTDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GUESTDataGridView.CellContentClick

    End Sub
End Class