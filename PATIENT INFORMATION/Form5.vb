Imports System.Data.SqlClient

Public Class Form5

    Dim rpt As New CrystalReport1()
    Dim con As New SqlConnection
    Dim adap As New SqlDataAdapter
    Dim datast As New DataSet
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Clinic Database;Integrated Security=True")
        adap = New SqlDataAdapter("select * from DATA order by @@TOTAL_READ Desc", con)
        adap.Fill(datast, "DATA")
        rpt.SetDataSource(datast)
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.RefreshReport()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If Form6.IsHandleCreated Then
            Form6.Show()
            Me.Close()
        ElseIf Form3.IsHandleCreated Then
            Me.Close()
            Form3.Show()
        ElseIf guest_view.IsHandleCreated Then
            guest_view.Show()
            Me.Close()
   
        End If
        Form10.TextBox1.Text = ""

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If guest_view.IsHandleCreated Then
            guest_view.Show()
            Me.Close()
        ElseIf Form6.IsHandleCreated Then
            Form6.Show()
            Me.Close()
        ElseIf Form3.IsHandleCreated Then
            Form3.Show()
            Me.Close()
        End If
        Form10.TextBox1.Text = ""
    End Sub

    Private Sub SEARCBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCBTN.Click

        If combosearch.SelectedItem = "ID" Then
            CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.SelectionFormula = "{DATA.PATIENTID}='" + SEARCH.Text.ToString + "'"
            CrystalReportViewer1.RefreshReport()

        ElseIf combosearch.SelectedItem = "SURNAME" Then
            CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.SelectionFormula = "{DATA.SURNAME}='" + SEARCH.Text.ToString + "'"
            CrystalReportViewer1.RefreshReport()

        ElseIf combosearch.SelectedItem = "NAME" Then
            CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.SelectionFormula = "{DATA.PATIENTNAME}='" + SEARCH.Text.ToString + "'"
            CrystalReportViewer1.RefreshReport()
        ElseIf combosearch.SelectedItem = "VERIFICATIONQR" Then
            CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.SelectionFormula = "{DATA.PATIENTID}='" + search1.Text.ToString + "'"
            CrystalReportViewer1.RefreshReport()

        Else : MessageBox.Show("Please seclect a search selection")
        End If



    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub SEARCH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCH.TextChanged

    End Sub

    Private Sub combosearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combosearch.SelectedIndexChanged

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
    
        con = New SqlConnection("Data Source=KAMOTE-PC\SQLEXPRESS;Initial Catalog=clinic database;Integrated Security=True")
        adap = New SqlDataAdapter("Select * FROM DATA", con)
        adap.Fill(datast, "DATA")
        rpt.SetDataSource(datast)
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class