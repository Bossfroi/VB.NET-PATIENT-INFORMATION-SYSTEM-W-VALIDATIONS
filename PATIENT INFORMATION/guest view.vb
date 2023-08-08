Imports System.Data.SqlClient
Public Class guest_view
    Dim PROID As String
    Dim HOST As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Clinic Database;Integrated Security=True")
    Private Sub DATABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DATABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Clinic_databaseDataSet)

    End Sub

    Private Sub guest_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iduser.Text = Form8.LOGINTextBox.Text
        graph()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        USERREFRESH.Show()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        GUESTMODE.Show()
        Me.Hide()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GUESTMODE.Show()
        Me.Close()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        USERREFRESH.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        search.Text = ""
        search.Enabled = True
        search.BackColor = Color.White
        DATATableAdapter.Fill(Me.Clinic_databaseDataSet.DATA)
        Refresh()
    End Sub

    Private Sub search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.TextChanged

        If combosearch.SelectedItem = "SURNAME" Then
            DATATableAdapter.FillBy(Me.Clinic_databaseDataSet.DATA, search.Text.ToString)

        ElseIf combosearch.SelectedItem = "NAME" Then
            DATATableAdapter.FillBy1(Me.Clinic_databaseDataSet.DATA, search.Text.ToString)

        ElseIf combosearch.SelectedItem = "PHONE#" Then
            DATATableAdapter.FillBy2(Me.Clinic_databaseDataSet.DATA, search.Text.ToString)

        ElseIf combosearch.SelectedItem = "DIAGNOSIS" Then
            DATATableAdapter.FillBy3(Me.Clinic_databaseDataSet.DATA, search.Text.ToString)

        ElseIf combosearch.SelectedItem = "INSURANCES" Then
            DATATableAdapter.FillBy4(Me.Clinic_databaseDataSet.DATA, search.Text.ToString)

        ElseIf combosearch.SelectedItem = "ADDRESS" Then
            DATATableAdapter.FillBy5(Me.Clinic_databaseDataSet.DATA, search.Text.ToString)


        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Hide()
        Form5.combosearch.Text = "ID"
        Form5.SEARCH.Text = PATIENTIDTextBox.Text
        Form5.SEARCBTN.PerformClick()

    End Sub

    Private Sub C_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub graph()
        Dim sql As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        Try
            host.Open()
            sql = "Select count(*) as count_var from data"
            cmd = New SqlCommand(sql, host)
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

            host.Close()

        End Try
        Refresh()
        Label5.Text = PROID
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        chattingform.Show()
    End Sub

    Private Sub Viewg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Viewg.Click
        chattingform.Show()
    End Sub
End Class