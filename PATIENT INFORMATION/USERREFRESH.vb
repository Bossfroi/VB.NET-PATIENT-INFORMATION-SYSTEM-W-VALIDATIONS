Public Class USERREFRESH

    Private Sub USERREFRESH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TransparencyKey = BackColor()

        Timer1.Start()
        Dim GRAPHICSLOADING As New OpenFileDialog
        GRAPHICSLOADING.Filter = "bind offnen (*.png)|*.png|All Files|*.*"
    End Sub
    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(15)
        Timer1.Start()
        Label1.Text = ProgressBar1.Value & "%"
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            guest_view.Show()
            Me.Close()
            guest_view.DATATableAdapter.Fill(guest_view.Clinic_databaseDataSet.DATA)
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class