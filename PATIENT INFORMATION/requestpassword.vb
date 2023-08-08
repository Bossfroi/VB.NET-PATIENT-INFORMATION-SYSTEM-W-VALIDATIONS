Imports System.Data.SqlClient
Public Class requestpassword

    Private Sub requestpassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim HOST As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Clinic Database;Integrated Security=True")
        Dim command As New SqlCommand("SELECT * FROM PASSTABLE where LOGIN = @LOGIN AND PASSWORD = @PASSWORD ", HOST)
        command.Parameters.Add("@PASSWORD", SqlDbType.NVarChar).Value = PASSWORDTextBox.Text
        command.Parameters.Add("@LOGIN", SqlDbType.NVarChar).Value = LOGINTextBox.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then

            MetroFramework.MetroMessageBox.Show(Me, "Invalid Administration password!Invalid Username: " + LOGINTextBox.Text, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            form4.Show()
            Me.Hide()

            MessageBox.Show("SUCCESSFULLY ENTER ADMIN: " + Form1.LOGINTextBox.Text)
            LOGINTextBox.Text = ""
            PASSWORDTextBox.Text = ""
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub LOGINTextBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LOGINTextBox.MouseClick
        LOGINTextBox.Text = ""
    End Sub

    Private Sub PASSWORDTextBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PASSWORDTextBox.MouseClick
        PASSWORDTextBox.Text = ""
    End Sub
End Class