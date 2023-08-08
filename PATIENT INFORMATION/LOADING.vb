Public Class LOADING

    Private Sub LOADING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TransparencyKey = BackColor()

        Timer1.Start()
        Dim GRAPHICSLOADING As New OpenFileDialog
        GRAPHICSLOADING.Filter = "bind offnen (*.png)|*.png|All Files|*.*"

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(3)
        Timer1.Start()
        Label1.Text = ProgressBar1.Value & "%"
        If ProgressBar1.Value = ProgressBar1.Maximum Then

            Form6.Show()
            Timer1.Stop()
            Me.Close()

        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class