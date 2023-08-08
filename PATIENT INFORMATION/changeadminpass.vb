Imports System.Data.SqlClient
Public Class changeadminpass

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim HOST As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Clinic Database;Integrated Security=True")
        Dim command As New SqlCommand("SELECT * FROM PASSTABLE where LOGIN = @LOGIN AND PASSWORD = @PASSWORD ", HOST)
        HOST.Open()
        command.Parameters.Add("@PASSWORD", SqlDbType.NVarChar).Value = password.Text
        command.Parameters.Add("@LOGIN", SqlDbType.NVarChar).Value = username.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        If newpassword.Text.Length <= 7 Then
            MessageBox.Show("8 character password requirments")


        ElseIf table.Rows.Count() <= 0 Then

            MessageBox.Show("Invalid Password Or Invalid Username: ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Else
            Dim froiupdate As New SqlCommand("UPDATE PASSTABLE SET LOGIN = @LOGIN ,PASSWORD = @PASSWORD WHERE login = @login", HOST)


            froiupdate.Parameters.AddWithValue("@LOGIN", username.Text)
            froiupdate.Parameters.AddWithValue("@PASSWORD", newpassword.Text)



            froiupdate.ExecuteNonQuery()
            HOST.Close()

            Me.Refresh()

            MessageBox.Show("Successfully change password")
            form4.PASSTABLETableAdapter.Fill(form4.Clinic_databaseDataSet.PASSTABLE)
        End If
    End Sub

    Private Sub newpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles newpassword.KeyPress
       
     
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newpassword.TextChanged

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub changeadminpass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class