Imports System.Data.SqlClient

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim HOST As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Clinic Database;Integrated Security=True")
        Dim command As New SqlCommand("SELECT * FROM PASSTABLE where LOGIN = @LOGIN AND PASSWORD = @PASSWORD ", HOST)
        command.Parameters.Add("@PASSWORD", SqlDbType.NVarChar).Value = PASSWORDTextBox.Text
        command.Parameters.Add("@LOGIN", SqlDbType.NVarChar).Value = LOGINTextBox.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then

            MetroFramework.MetroMessageBox.Show(Me, "The password or Username you’ve entered is incorrect", "LOGIN FAILED", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else

            LOADING.Show()
            Me.Hide()

        End If

    End Sub

   

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub
   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If userlevel.SelectedItem = "GUEST/USER" Then
            Form8.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub userlevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles userlevel.SelectedIndexChanged
        If Me.userlevel.SelectedItem = "GUEST/USER" Then
            Form8.Show()
            Me.Close()


        End If

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        chattingform.networkCreator()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LOGINTextBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LOGINTextBox.MouseClick
        LOGINTextBox.Text = ""
    End Sub

  

    Private Sub PASSWORDTextBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PASSWORDTextBox.MouseClick
        PASSWORDTextBox.Text = ""
    End Sub

   
End Class
