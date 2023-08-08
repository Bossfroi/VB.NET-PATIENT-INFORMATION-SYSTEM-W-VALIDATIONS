Imports System.Data.SqlClient
Public Class changeGuestpass

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


          Dim HOST As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Clinic Database;Integrated Security=True")
        Dim command As New SqlCommand("SELECT * FROM GUEST where USERNAME = @USERNAME AND PASSWORD = @PASSWORD ", HOST)
        HOST.Open()
        command.Parameters.Add("@PASSWORD", SqlDbType.NVarChar).Value = password.Text
        command.Parameters.Add("@USERNAME", SqlDbType.NVarChar).Value = username.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        If newpassword.Text.Length <= 7 Then
            MessageBox.Show("8 character password requirments")
        ElseIf table.Rows.Count() <= 0 Then

            MetroFramework.MetroMessageBox.Show(Me, "Invalid Password Or Invalid Username: ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim froiupdate As New SqlCommand("UPDATE guest SET username = @username ,PASSWORD = @PASSWORD WHERE username = @username", HOST)


            froiupdate.Parameters.AddWithValue("@username", username.Text)
            froiupdate.Parameters.AddWithValue("@PASSWORD", newpassword.Text)

            froiupdate.ExecuteNonQuery()
            HOST.Close()

            Me.Refresh()

            MessageBox.Show("Successfully Change")
            form4.GUESTTableAdapter.Fill(form4.Clinic_databaseDataSet.GUEST)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()

    End Sub

    Private Sub changeGuestpass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username.TextChanged
        username.Enabled = False
    End Sub

    Private Sub newpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles newpassword.KeyPress
      
    End Sub

    Private Sub newpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newpassword.TextChanged

    End Sub
End Class