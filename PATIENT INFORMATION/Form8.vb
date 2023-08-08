Imports System.Data.SqlClient
Public Class Form8

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        LOGINTextBox.Text.ToString()
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim HOST As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Clinic Database;Integrated Security=True")
        Dim command As New SqlCommand("SELECT * FROM GUEST where USERNAME = @USERNAME AND PASSWORD = @PASSWORD ", HOST)
        command.Parameters.Add("@PASSWORD", SqlDbType.NVarChar).Value = PASSWORDTextBox.Text
        command.Parameters.Add("@USERNAME", SqlDbType.NVarChar).Value = LOGINTextBox.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then

            MetroFramework.MetroMessageBox.Show(Me, "Invalid Password Or Invalid Username: " + LOGINTextBox.Text, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            REFRESHGUESTFORM.Show()
            Me.Hide()
            chattingform.networkCreator()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
        Form1.Refresh()


    End Sub

    Private Sub LOGINTextBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LOGINTextBox.MouseClick
        LOGINTextBox.Text = ""
    End Sub

    Private Sub PASSWORDTextBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PASSWORDTextBox.MouseClick
        PASSWORDTextBox.Text = ""
    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class