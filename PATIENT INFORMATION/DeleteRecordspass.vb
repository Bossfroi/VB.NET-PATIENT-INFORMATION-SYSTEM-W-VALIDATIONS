Imports System.Data.SqlClient
Public Class DeleteRecordspass

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim HOST As New SqlConnection("Data Source=kamote-pc;Initial Catalog=CLINIC DATABASE;User ID=sa;Password=froi")
        Dim command As New SqlCommand("SELECT * FROM PASSTABLE where LOGIN = @LOGIN AND PASSWORD = @PASSWORD ", HOST)
        command.Parameters.Add("@PASSWORD", SqlDbType.NVarChar).Value = PASSWORDTextBox.Text
        command.Parameters.Add("@LOGIN", SqlDbType.NVarChar).Value = LOGINTextBox.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then

            MetroFramework.MetroMessageBox.Show(Me, "Invalid Administration password!Invalid Username: " + LOGINTextBox.Text, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim deletesql As String = " delete from data where PATIENTID = " & Form3.IDHIDE.Text
            Form3.DELexecutequery(deletesql)
            Me.Close()
        End If
    End Sub

    Private Sub LOGINTextBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LOGINTextBox.MouseClick
        LOGINTextBox.Text = ""
        PASSWORDTextBox.Text = ""
    End Sub

    Private Sub LOGINTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGINTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class